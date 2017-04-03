using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLCRM.Entity.UserModel.SPM;
using ZNLCRM.Entity.DBModel;
using MySoft.Data;
using ZNLFrame.Entity;
using ZNLCRM.BLL.Sys;
using ZNLCRM.Entity.UserModel.Common;
using ZNLCRM.Utility;

namespace ZNLCRM.BLL.SPM
{
    public  class ORD_PurchaseNoticeBLL:BaseBLL
    {

        public bool CancelPurchaseNotice(ORD_PurchaseNoticeParam param)
        {
            bool flag = true;
            try
            {
               ORD_PurchaseNoticeResult noticeResult= this.GetInfo(param);
               if (noticeResult != null)
               {

                   if (noticeResult.PurchaseQty > 0)
                   {
                       flag = false;
                       throw new WarnException("当前采购通知已存在关联的采购信息，不允许取消通知！");
                   }
                  this.DelInfo(param);//删除当前采购通知
                   //汇总采购通知所关联的销售明细下所有关联的有效的采购通知的数量
                   List<ORD_PurchaseNoticeResult> noticeList = this.GetList(new ORD_PurchaseNoticeParam() { SOLineGuid = noticeResult.SOLineGuid });
                    int? noticeQty =0;
                   if (noticeList != null && noticeList.Count > 0)
                   {
                       noticeQty = noticeList.Sum(a => a.NoticeQty);
                   }
                   ORD_SalesOrderLineBLL orderLineBLL = new ORD_SalesOrderLineBLL();
                   orderLineBLL.SessionInfo = this.SessionInfo;
                   ORD_SalesOrderLineResult orderLineResult=  orderLineBLL.GetInfo(new ORD_SalesOrderLineParam() { SOLineGuid = noticeResult.SOLineGuid });
                   orderLineResult.NotifyQty = noticeQty;
                   orderLineBLL.AddOrUpdate(orderLineResult);
                   ORD_SalesOrderBLL orderBLL = new ORD_SalesOrderBLL();
                   orderBLL.SessionInfo = this.SessionInfo;
                   orderBLL.UpdateStatus(new ORD_SalesOrderParam() { SOGuid = noticeResult.SOGuid });//更新销售明细的通知状态
               }
               else
               {
                   flag = false;
                   throw new WarnException("当前采购通知记录在系统中不存在！");
               }
            }
            catch (WarnException exp)
            {
                throw exp;
            }
            catch (Exception exp)
            {
                LogInfoBLL.WriteLog(this.SessionInfo, exp);
                throw exp;
            }

            return flag;
        
        
        }
        public PageList<ORD_PurchaseNoticeResult> GetPageList(ORD_PurchaseNoticeParam param)
        {

                PageList<ORD_PurchaseNoticeResult> ret = new PageList<ORD_PurchaseNoticeResult>();
                try
                {
                   
                    ORD_SalesOrderBLL orderBLL = new ORD_SalesOrderBLL();
                    orderBLL.SessionInfo = this.SessionInfo;
                    ORD_SalesOrderParam  orderParam=new ORD_SalesOrderParam ()
                    {
                        BillNo=param.SOBillNo,
                        SalerName=param.SalerName,
                        PageIndex=1,
                        PageSize=5000
                    
                    };

                    PageList<ORD_SalesOrderResult> orderList = orderBLL.GetPageList(orderParam);
                    if(orderList.ResultList!=null && orderList.ResultList.Count>0)
                    {
                       Guid?[] SOGuids=  orderList.ResultList.Select(a=>a.SOGuid).Distinct().ToArray();
                       ORD_SalesOrderLineBLL lineBLL = new ORD_SalesOrderLineBLL();
                       lineBLL.SessionInfo = this.SessionInfo;
                      ORD_SalesOrderLineParam lineParam=new ORD_SalesOrderLineParam ()
                      {
                         Model=param.Model,
                         SOLineCode=param.SOLineCode,
                         SOGuids=SOGuids,
                         PageIndex=1,
                         PageSize=5000,
                         IsCancel=false
                         
                      };
                       PageList<ORD_SalesOrderLineResult> lineList=lineBLL.GetPageList(lineParam);
                       if (lineList.ResultList != null && lineList.ResultList.Count > 0)
                       {
                           Guid?[] SOLineGuIds = lineList.ResultList.Select(a => (Guid?)a.SOLineGuid).Distinct().ToArray();
                           param.SOLineGuids = SOLineGuIds;
                           ret = this.SelectList<ORD_PurchaseNoticeResult>(param.PageIndex.GetValueOrDefault(1), param.PageSize.GetValueOrDefault(50), new List<Field>() { Field.All }, GetWhereClip(param), ORD_PurchaseNotice._.CreatedTime.Desc);
                           foreach (ORD_PurchaseNoticeResult noticeResult in ret.ResultList)
                           { 
                               ORD_SalesOrderResult orderResult=  orderList.ResultList.FirstOrDefault(a=>a.SOGuid==noticeResult.SOGuid);
                               if(orderResult!=null)
                               {
                                   noticeResult.SOBillNo = orderResult.BillNo;
                                   noticeResult.SalerName = orderResult.SalerName;
                                   noticeResult.SaleCurrency = orderResult.Currency;
                               }
                               ORD_SalesOrderLineResult lineResult = lineList.ResultList.FirstOrDefault(a => a.SOLineGuid == noticeResult.SOLineGuid);
                               if (lineResult != null)
                               {
                                   noticeResult.SOLineCode = lineResult.SOLineCode;
                                   noticeResult.SalePrice = lineResult.UnitPrice;
                                   noticeResult.Unit = lineResult.Unit;
                                   noticeResult.Model = lineResult.Model;
                                   noticeResult.Brand = lineResult.Brand;
                                   noticeResult.Batch = lineResult.Batch;
                                   noticeResult.Package = lineResult.Package;
                                   noticeResult.InvType = lineResult.InvType;
                                   noticeResult.NeedDeliveryDate = lineResult.NeedDeliveryDate;
                                   noticeResult.SaleQty = lineResult.Qty;
                               }
                               if(noticeResult.PurchaseQty.ToInt32()==0)
                                  noticeResult.PurStatus="未采购";
                               else  if(noticeResult.NoticeQty.ToInt32()<=noticeResult.PurchaseQty.ToInt32())
                                   noticeResult.PurStatus = "采购完成";
                               else
                                   noticeResult.PurStatus = "部分采购";
                           }
                       }
                    }
                }
                catch (WarnException exp)
                {
                    throw exp;
                }
                catch (System.Exception exp)
                {
                    LogInfoBLL.WriteLog(this.SessionInfo, exp);
                    throw exp;
                }
                return ret;
        }
        /// <summary>
        /// 获取集合
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public List<ORD_PurchaseNoticeResult> GetList(ORD_PurchaseNoticeParam param)
        {
            this.CheckSession();
            List<ORD_PurchaseNoticeResult> ret = new List<ORD_PurchaseNoticeResult>();
            try
            {
                WhereClip whereClip = GetWhereClip(param);
                ret = this.SelectList<ORD_PurchaseNoticeResult>(whereClip, ORD_PurchaseNotice._.CreatedTime.Asc);
                if (ret != null && ret.Count > 0)
                {
                    Guid?[] SOLineGuids = ret.Where(a => a.SOLineGuid.ToGuid() != Guid.Empty).Select(a => a.SOLineGuid).Distinct().ToArray();
                    ORD_SalesOrderLineBLL lineBLL = new ORD_SalesOrderLineBLL();
                    lineBLL.SessionInfo = this.SessionInfo;
                    ORD_SalesOrderLineParam lineParam = new ORD_SalesOrderLineParam();
                    lineParam.SOLineGuids = SOLineGuids;
                    List<ORD_SalesOrderLineResult> lineResultList = lineBLL.GetList(lineParam);
                    if (ret != null && ret.Count > 0 && lineResultList != null && lineResultList.Count > 0)
                    {
                        foreach (ORD_PurchaseNoticeResult noticeResult in ret)
                        {
                            ORD_SalesOrderLineResult lineResult = lineResultList.FirstOrDefault(a => a.SOLineGuid == noticeResult.SOLineGuid);
                            if (lineResult != null)
                            {
                                noticeResult.SOLineCode = lineResult.SOLineCode;
                                noticeResult.SalePrice = lineResult.UnitPrice;
                                noticeResult.Unit = lineResult.Unit;
                                noticeResult.Model = lineResult.Model;
                                noticeResult.Brand = lineResult.Brand;
                                noticeResult.Batch = lineResult.Batch;
                                noticeResult.Package = lineResult.Package;
                                noticeResult.InvType = lineResult.InvType;
                                noticeResult.NeedDeliveryDate = lineResult.NeedDeliveryDate;
                                noticeResult.SaleQty = lineResult.Qty;
                            }

                        }
                    }
                }
            }
            catch (WarnException exp)
            {
                throw exp;
            }
            catch (System.Exception exp)
            {
                LogInfoBLL.WriteLog(this.SessionInfo, exp);
                throw exp;
            }
            return ret;

        }

        WhereClip GetWhereClip(ORD_PurchaseNoticeParam param)
        {
            this.CheckSession();
            WhereClip where = ORD_PurchaseNotice._.IsDeleted == 0;
            if (param.NoticeGuid != null) where = where && ORD_PurchaseNotice._.NoticeGuid == param.NoticeGuid;
            if(param.SOGuid!=null) where =where && ORD_PurchaseNotice._.SOGuid==param.SOGuid;
            if (param.SOLineGuid !=null) where = where && ORD_PurchaseNotice._.SOLineGuid == param.SOLineGuid;
            if (param.SOLineGuids != null && param.SOLineGuids.Length>0) where = where && ORD_PurchaseNotice._.SOLineGuid.In(param.SOLineGuids);
            if (param.NoticeGuids != null && param.NoticeGuids.Length > 0) where = where && ORD_PurchaseNotice._.NoticeGuid.In(param.NoticeGuids);
            if (param.NoNoticeGuids != null && param.NoNoticeGuids.Length>0) where = where && !ORD_PurchaseNotice._.NoticeGuid.In(param.NoNoticeGuids);
            if(param.StartTime!=null)
            {
                DateTime startTime=  param.StartTime.ToDateTime().Date;
                where =where && ORD_PurchaseNotice._.CreatedTime>=startTime;
                    
            }
            if(param.EndTime!=null)
            {
               DateTime endTime=param.EndTime.ToDateTime().Date.Add(new TimeSpan(23,59,59));
               where = where && ORD_PurchaseNotice._.CreatedTime <= endTime;
            }
            
            return where;

        }


        /// <summary>
        /// 获取一条信息记录
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public ORD_PurchaseNoticeResult GetInfo(ORD_PurchaseNoticeParam param)
        {
            this.CheckSession();
            ORD_PurchaseNoticeResult rst = new ORD_PurchaseNoticeResult();
            #region 判断
            if (param.NoticeGuid == null) throw new WarnException("请指定GUID！");
            #endregion
            #region 获取实体

            rst = this.Select<ORD_PurchaseNoticeResult>(GetWhereClip(param));

            #endregion
            return rst;
        }

        /// <summary>
        /// 删除实体
        /// </summary>
        /// <param name="param">删除条件实体</param>
        /// <returns></returns>
        public WCFAddUpdateResult DelInfo(ORD_PurchaseNoticeParam param)
        {
            this.CheckSession();
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            int affect = 0;
            try
            {
                #region 判断
                if (param.NoticeGuid == null) throw new WarnException("请指定GUID！");
                #endregion
                WhereClip whereClip = GetWhereClip(param);
                ORD_PurchaseNoticeResult info = new ORD_PurchaseNoticeResult();
                info.IsDeleted = true;
                affect = this.Update<ORD_PurchaseNoticeResult>(info, whereClip);
                #region 设置返回值
                ret.Key = affect;
                #endregion
            }
            catch (WarnException exp)
            {
                throw exp;
            }
            catch (System.Exception exp)
            {
                LogInfoBLL.WriteLog(this.SessionInfo, exp);
                throw exp;
            }
            return ret;
        }

        /// <summary>
        /// 批量修改和插入
        /// </summary>
        /// <param name="paramList"></param>
        /// <returns></returns>
        public WCFAddUpdateResult UpdateOrInsertList(List<ORD_PurchaseNoticeResult> list)
        {
            this.CheckSession();
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            try
            {
                #region 判断
                if (list.Count <= 0) throw new WarnException("没有需要操作的对象！");
                #endregion
                foreach (ORD_PurchaseNoticeResult noticeResult in list)
                {
                    
                    if (noticeResult.NoticeGuid.ToGuid() != Guid.Empty)
                    {
                        noticeResult.UpdatedEmpID = this.SessionInfo.UserID;
                        noticeResult.UpdatedEmpName = this.SessionInfo.UserName;
                        noticeResult.UpdatedTime = DateTime.Now;

                    }
                    else
                    {
                        noticeResult.NoticeGuid = Guid.NewGuid();
                        noticeResult.CreatedEmpID = this.SessionInfo.UserID;
                        noticeResult.CreatedEmpName = this.SessionInfo.UserName;
                        noticeResult.CreatedTime = DateTime.Now;
                        noticeResult.IsDeleted = false;
                    }

                }
                int affect = 0;
                this.BatchInsertOrUpdate<ORD_PurchaseNoticeResult>(list);
                affect = this.BatchExecute();
                
                #region 设置返回值
                ret.Key = affect;
                #endregion
                if (affect > 0)
                {
                  Guid?[] SOLineGuids=  list.Where(a=>a.SOLineGuid.ToGuid()!=Guid.Empty).Select(a => a.SOLineGuid).Distinct().ToArray();
                  if (SOLineGuids.Length > 0)
                  {
                      List<ORD_PurchaseNoticeResult> noticeList = this.GetList(new ORD_PurchaseNoticeParam() { SOLineGuids = SOLineGuids });

                      List<ORD_SalesOrderLineResult> lineResultList = new List<ORD_SalesOrderLineResult>();
                      ORD_SalesOrderLineResult lineResult = null;
                      foreach (Guid soLineGuid in SOLineGuids)
                      {
                          lineResult = new ORD_SalesOrderLineResult();
                          lineResult.SOLineGuid = soLineGuid;
                          int Qty = noticeList.Where(a => a.SOLineGuid == soLineGuid).Sum(a => a.NoticeQty.ToInt32());
                          lineResult.NotifyQty = Qty;
                          lineResultList.Add(lineResult);

                      }
                      ORD_SalesOrderLineBLL lineBLL = new ORD_SalesOrderLineBLL();
                      lineBLL.SessionInfo = this.SessionInfo;
                      lineBLL.UpdateOrInsertList(lineResultList);//更新销售明细的通知数量
                      ORD_SalesOrderBLL orderBLL = new ORD_SalesOrderBLL();
                      orderBLL.UpdateStatus(new ORD_SalesOrderParam() { SOGuid = list[0].SOGuid });//更新销售明细的通知状态
                  }
                
                }
            }
            catch (WarnException exp)
            {
                throw exp;
            }
            catch (System.Exception exp)
            {
                LogInfoBLL.WriteLog(this.SessionInfo, exp);
                throw exp;
            }
            return ret;

        }

      
    }
}
