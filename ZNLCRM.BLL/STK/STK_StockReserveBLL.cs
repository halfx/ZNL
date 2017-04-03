using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLFrame.Entity;
using ZNLCRM.Entity.UserModel.STK;
using MySoft.Data;
using ZNLCRM.BLL.Sys;
using ZNLCRM.Entity.UserModel.Common;
using ZNLCRM.Utility;
using ZNLCRM.Entity.DBModel;
using ZNLCRM.Entity.UserModel.SPM;
using ZNLCRM.BLL.SPM;
using ZNLCRM.Entity.UserModel.PPM;
using ZNLCRM.BLL.PPM;

namespace ZNLCRM.BLL.STK
{
    public  class STK_StockReserveBLL:BaseBLL
    {
        
        /// <summary>
        /// 分页集合
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public PageList<STK_StockReserveResult> GetPageList(STK_StockReserveParam param)
        {
            this.CheckSession();
            PageList<STK_StockReserveResult> ret = new PageList<STK_StockReserveResult>();
            try
            {
                #region 处理销售明细
                WhereClip orderClip = ORD_SalesOrder._.IsDeleted == 0;
                if (!string.IsNullOrEmpty(param.SourceBillNo)) orderClip = orderClip && ORD_SalesOrder._.BillNo.Like(param.SourceBillNo + "%");
                if (param.SourceBillGuid!=null) orderClip = orderClip && ORD_SalesOrder._.SOGuid == param.SourceBillGuid;

                PageList<ORD_SalesOrderResult> orderList = this.SelectList<ORD_SalesOrderResult>(1, 5000, new List<Field>() { Field.All }, orderClip, ORD_SalesOrder._.CreatedTime.Desc);
                PageList<ORD_SalesOrderLineResult> lineList=null;
                Guid?[] SOGuids=null;
                if (orderList.ResultList != null && orderList.ResultList.Count > 0)
                {
                    SOGuids = orderList.ResultList.Select(a => a.SOGuid).Distinct().ToArray();
                }
                WhereClip lineClip = ORD_SalesOrderLine._.IsDeleted == 0;
                if (SOGuids != null) lineClip = lineClip && ORD_SalesOrderLine._.SOGuid.In(SOGuids);
                if (!string.IsNullOrEmpty(param.Model)) lineClip = lineClip && ORD_SalesOrderLine._.Model.Like(param.Model + "%");
                if (!string.IsNullOrEmpty(param.SourceBillLineCode)) lineClip = lineClip && ORD_SalesOrderLine._.SOLineCode.Like(param.SourceBillLineCode + "%");
                lineList = this.SelectList<ORD_SalesOrderLineResult>(param.PageIndex.GetValueOrDefault(1), param.PageSize.GetValueOrDefault(100), new List<Field>() { Field.All }, lineClip, ORD_SalesOrderLine._.CreatedTime.Desc);
                if (lineList != null && lineList.ResultList.Count > 0)
                {
                    #region 获取业务明细下的预留信息
                    Guid?[]  SOLineGuids=lineList.ResultList.Select(a=>(Guid?)a.SOLineGuid).Distinct().ToArray();
                    STK_StockReserveParam reserveParam=new STK_StockReserveParam ();
                    reserveParam.SourceBillLineGuids=SOLineGuids;
                    List<STK_StockReserveResult> childReserveResultList= this.GetList(reserveParam);
                   
                    #endregion
                    List<STK_StockReserveResult> reserveResultList=new List<STK_StockReserveResult> ();
                    STK_StockReserveResult reserveResult=null;
                    foreach(ORD_SalesOrderLineResult lineResult in lineList.ResultList)
                    {
                       reserveResult=new STK_StockReserveResult();
                       ORD_SalesOrderResult orderResult = orderList.ResultList.FirstOrDefault(a=>a.SOGuid==lineResult.SOGuid);
                       if(orderResult!=null)
                       {
                           reserveResult.SourceBillNo=orderResult.BillNo;
                           reserveResult.SourceBillType="销售出库";
                           reserveResult.BelongEmpName = orderResult.SalerName;
                           reserveResult.SourceBillDate = orderResult.SODate;
                       }
                       
                       reserveResult.SourceBillGuid=lineResult.SOGuid;
                       reserveResult.SourceBillLineGuid=lineResult.SOLineGuid;
                       reserveResult.SourceBillLineCode=lineResult.SOLineCode;
                       reserveResult.Model=lineResult.Model;
                       reserveResult.Brand=lineResult.Brand;
                       reserveResult.Qty=lineResult.Qty;
                       reserveResult.ReserveQty=lineResult.ReserveQty;
                       reserveResult.CreatedEmpName=lineResult.CreatedEmpName;
                       reserveResult.CreatedTime=lineResult.CreatedTime;
                       reserveResult.UpdatedEmpName=lineResult.UpdatedEmpName;
                       reserveResult.UpdatedTime=lineResult.UpdatedTime;
                       if (childReserveResultList != null && childReserveResultList.Count > 0)
                       {
                           List<STK_StockReserveResult> srList = childReserveResultList.Where(a => a.SourceBillLineGuid == lineResult.SOLineGuid).ToList();
                           if (srList != null && srList.Count > 0)
                           {
                               Guid?[] ItemCodes = srList.Select(a => a.ItemCode).Distinct().ToArray();
                               STK_StockBLL stockBLL = new STK_StockBLL();
                               stockBLL.SessionInfo = this.SessionInfo;
                               List<STK_StockResult> stockList = stockBLL.GetList(new STK_StockParam() { ItemCodes = ItemCodes });
                               foreach (STK_StockReserveResult sr in srList)
                               {
                                   if (stockList != null && stockList.Count > 0)
                                   {
                                       STK_StockResult stockResult = stockList.FirstOrDefault(a => a.ItemCode == sr.ItemCode);
                                       sr.Model = stockResult.Model;
                                       sr.Brand = stockResult.Brand;
                                       sr.Batch = stockResult.Batch;
                                       sr.Package = stockResult.Package;
                                       sr.Quality = stockResult.Quality;
                                       sr.MPQ = stockResult.MPQ;
                                       sr.MarkCode = stockResult.MarkCode;
                                       sr.Warehouse = stockResult.Warehouse;
                                       sr.Location = stockResult.Location;
                                       sr.InvType = stockResult.InvType;
                                       sr.InBatchNo = stockResult.InBatchNo;
                                   }
                               }
                               reserveResult.ReserveList = srList;
                           }
                       }
                       reserveResultList.Add(reserveResult);
                    }
                    if (ret.ResultList == null)
                        ret.ResultList = new List<STK_StockReserveResult>();
                    ret.ResultList.AddRange(reserveResultList);
                    ret.TotalCount = lineList.TotalCount;
                }
                #endregion

                #region 处理采购退货明细

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

        public bool OperateReserveList(List<STK_StockReserveResult> resultList)
        { 
          this.CheckSession();
             
            try
            {
                foreach (STK_StockReserveResult reserveResult in resultList)
                {
                    OperateReserve(reserveResult);
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

            return true;
        }
       

        /// <summary>
        /// 操作预留
        /// </summary>
        /// <param name="result"></param>
        /// <returns></returns>
        public bool OperateReserve(STK_StockReserveResult result)
        {
            this.CheckSession();
            try
            {
                //预留调整量
                int? tempReserveQty = 0;
                ORD_SalesOrderLineResult orderLineResult = new ORD_SalesOrderLineResult();
                ORD_SalesOrderLineBLL orderLineBLL = new ORD_SalesOrderLineBLL();
                orderLineBLL.SessionInfo = this.SessionInfo;
                ORD_PurchaseReturnLineResult returnLineResult=new ORD_PurchaseReturnLineResult ();
                ORD_PurchaseReturnLineBLL returnLineBLL=new ORD_PurchaseReturnLineBLL ();
                returnLineBLL.SessionInfo=this.SessionInfo;
                
                //空值转换为零
                if (result.ReserveQty == null) result.ReserveQty = 0;
                // 预留明细的业务类型
                switch (result.SourceBillType)
                {
                    case "销售出库":
                        orderLineResult = orderLineBLL.GetInfo(new ORD_SalesOrderLineParam() { SOLineGuid = result.SourceBillLineGuid });
                        if (orderLineResult != null)
                        {
                            if (orderLineResult.Qty == null) orderLineResult.Qty = 0;
                            if (orderLineResult.ReserveQty == null) orderLineResult.ReserveQty = 0;
                            tempReserveQty = orderLineResult.Qty - orderLineResult.ReserveQty;
                        }
                        break;
                    case "采购退货出库":
                        returnLineResult = returnLineBLL.GetInfo(new ORD_PurchaseReturnLineParam() { PRLineGuid = result.SourceBillLineGuid });
                        if (returnLineResult != null)
                        {
                            if (returnLineResult.Qty == null) returnLineResult.Qty = 0;
                            if (returnLineResult.ReserveQty == null) returnLineResult.ReserveQty = 0;
                            tempReserveQty = returnLineResult.Qty - returnLineResult.ReserveQty;
                        }
                        break;
                }

                 //获取已存在的预留信息
                STK_StockReserveResult oldReserveResult=null;
                if(result.SRGuid!=null)
                {
                    STK_StockReserveParam reserveParam=new STK_StockReserveParam();
                    reserveParam.SRGuid = result.SRGuid;
                    oldReserveResult = this.GetInfo(reserveParam);
                }
                  if (oldReserveResult != null)
                  {
                      if (oldReserveResult.ReserveQty == null) orderLineResult.ReserveQty = 0;
                      //修改预留数量，预留量增加
                      if (result.ReserveQty >= oldReserveResult.ReserveQty)
                      {
                          tempReserveQty = result.ReserveQty - oldReserveResult.ReserveQty;
                          result.OperFlag = true;
                      }
                      //修改预留数量，预留量减少
                      else if (result.ReserveQty < oldReserveResult.ReserveQty)
                      {
                          tempReserveQty = oldReserveResult.ReserveQty - result.ReserveQty;
                          result.OperFlag = false;
                      }
                  }
                 //获取库存信息
                  STK_StockBLL stockBLL=new STK_StockBLL ();
                  stockBLL.SessionInfo=this.SessionInfo;
                  STK_StockResult stockResult=stockBLL.GetInfo(new STK_StockParam(){ItemCode=result.ItemCode});
                  if (stockResult != null)
                  {
                      //空值转换为零
                      if (stockResult.UsableQty == null) stockResult.UsableQty = 0;
                      if (stockResult.BookedQty == null) stockResult.BookedQty = 0;
                  }
                  
                  int? UsableQty = stockResult.UsableQty;
                  //删除预留信息
                  if (result.IsDeleted.ToBooleanHasNull())
                  {
                      result = oldReserveResult;
                      stockResult.UsableQty += result.ReserveQty;
                      stockResult.BookedQty -= result.ReserveQty;
                      switch (result.SourceBillType)
                      {
                          case "销售出库":
                              orderLineResult.ReserveQty -= result.ReserveQty;
                              break;
                          case "采购退货出库":
                              returnLineResult.ReserveQty -= result.ReserveQty;
                              break;
                      }
                  }
                  //新增或者修改预留信息
                  else
                  {
                      switch (result.OperFlag)
                      {
                          case true://增加
                              //预留信息已经存在
                              if (oldReserveResult != null)
                              {
                                  result = oldReserveResult;
                                  if (UsableQty >= tempReserveQty)//大于需要预留数量
                                      result.ReserveQty += tempReserveQty;
                                  else//小于需要预留数量
                                      result.ReserveQty += UsableQty;
                              }
                              //新的预留
                              else
                              {
                                  if (UsableQty >= tempReserveQty)//大于需要预留数量
                                      result.ReserveQty = tempReserveQty;
                                  else//小于需要预留数量
                                      result.ReserveQty = UsableQty;
                              }
                              if (UsableQty >= tempReserveQty)//大于需要预留数量
                              {
                                  stockResult.UsableQty -= tempReserveQty;
                                  stockResult.BookedQty += tempReserveQty;
                                  switch (result.SourceBillType)
                                  {
                                      case "销售出库":
                                          orderLineResult.ReserveQty += tempReserveQty;
                                          break;
                                      case "采购退货出库":
                                          returnLineResult.ReserveQty += tempReserveQty;
                                          break;
                                  }
                                  
                              }
                              else
                              {
                                  stockResult.UsableQty -= UsableQty;
                                  stockResult.BookedQty += UsableQty;
                                  switch (result.SourceBillType)
                                  {
                                      case "销售出库":
                                          orderLineResult.ReserveQty += UsableQty;
                                          break;
                                      case "采购退货出库":
                                          returnLineResult.ReserveQty += UsableQty;
                                          break;
                                  }
                                  
                              }
                              break;
                          case false://减少库存量
                                  result = oldReserveResult;
                                  result.ReserveQty -= tempReserveQty;
                                  stockResult.UsableQty += tempReserveQty;
                                  stockResult.BookedQty -= tempReserveQty;
                                  switch (result.SourceBillType)
                                  {
                                      case "销售出库":
                                          orderLineResult.ReserveQty -= tempReserveQty;
                                          break;
                                      case "采购退货出库":
                                          returnLineResult.ReserveQty -= tempReserveQty;
                                          break;
                                  }
                                  
                              break;
                      }// end of switch
                  } //end of if  else 
                    //更改预留表
                    this.AddOrUpdate(result);
                    //更改库存
                    stockBLL.AddOrUpdate(stockResult);
                    //更新预留关联单据明细
                    switch (result.SourceBillType)
                    { 
                        case "销售出库":
                            orderLineBLL.AddOrUpdate(orderLineResult);
                            break;
                        case "采购退货出库":
                            returnLineBLL.AddOrUpdate(returnLineResult);
                            break;
                    }// end of if else
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
            return true;
        }

        /// <summary>
        /// 添加和新增修改
        /// </summary>
        /// <param name="param">新增或修改的实体</param>
        /// <returns></returns>
        public WCFAddUpdateResult AddOrUpdate(STK_StockReserveResult param)
        {
            this.CheckSession();
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            try
            {
                int affect = 0;
                #region 判断

                if (param.ItemCode == null) throw new  WarnException("没有关联库存");
             
                #endregion


                #region 系统默认值
                if (param.SRGuid != null)
                {
                    WhereClip where = STK_StockReserve._.SRGuid == param.SRGuid;
                    param.UpdatedEmpID = this.SessionInfo.UserID;
                    param.UpdatedEmpName = this.SessionInfo.UserName;
                    param.UpdatedTime = DateTime.Now;
                    affect = this.Update<STK_StockReserveResult>(param, where);
                }
                else
                {
                    param.SRGuid = Guid.NewGuid();
                    param.GCompanyID = this.SessionInfo.CompanyID;
                    param.IsDeleted = false;
                    param.CreatedEmpID = this.SessionInfo.UserID;
                    param.CreatedEmpName = this.SessionInfo.UserName;
                    param.CreatedTime = DateTime.Now;
                    affect = this.Insert<STK_StockReserveResult>(param);
                    param = this.Select<STK_StockReserveResult>(new List<Field>() { STK_StockReserve._.All }, STK_StockReserve._.SRGuid == param.SRGuid);
                }
                #region 设置返回值
                ret.KeyGuid = param.SRGuid;
                ret.CreatedTime = param.CreatedTime;
                ret.CreatedEmpID = param.CreatedEmpID;
                ret.CreatedEmpName = param.CreatedEmpName;
                ret.UpdatedEmpID = param.UpdatedEmpID;
                ret.UpdatedEmpName = param.UpdatedEmpName;
                ret.UpdatedTime = param.UpdatedTime;
                #endregion
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
        public WCFAddUpdateResult UpdateOrInsertList(List<STK_StockReserveResult> list)
        {
            this.CheckSession();
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            try
            {
                #region 判断
                if (list.Count <= 0) throw new WarnException("没有需要操作的对象！");
                #endregion
                foreach (STK_StockReserveResult stk_StockReserveResult in list)
                {
                    if (stk_StockReserveResult.SRGuid.ToGuid() != Guid.Empty)
                    {
                        stk_StockReserveResult.UpdatedEmpID = this.SessionInfo.UserID;
                        stk_StockReserveResult.UpdatedEmpName = this.SessionInfo.UserName;
                        stk_StockReserveResult.UpdatedTime = DateTime.Now;

                    }
                    else
                    {
                        stk_StockReserveResult.SRGuid = Guid.NewGuid();
                        stk_StockReserveResult.GCompanyID = this.SessionInfo.CompanyID;
                        stk_StockReserveResult.CreatedEmpID = this.SessionInfo.UserID;
                        stk_StockReserveResult.CreatedEmpName = this.SessionInfo.UserName;
                        stk_StockReserveResult.CreatedTime = DateTime.Now;
                        stk_StockReserveResult.IsDeleted = false;
                    }

                }
                int affect = 0;
                this.BatchInsertOrUpdate<STK_StockReserveResult>(list);
                affect = this.BatchExecute();
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
        /// 获取集合
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public List<STK_StockReserveResult> GetList(STK_StockReserveParam param)
        {
            this.CheckSession();
            List<STK_StockReserveResult> ret = new List<STK_StockReserveResult>();
            try
            {
                WhereClip whereClip = GetWhereClip(param);
                
                ret = this.SelectList<STK_StockReserveResult>(whereClip, STK_StockReserve._.CreatedTime.Asc);

                if(ret!=null && ret.Count>0)
                {
                   Guid?[] ItemCodes = ret.Select(a => a.ItemCode).Distinct().ToArray();
                   STK_StockBLL stockBLL = new STK_StockBLL();
                   stockBLL.SessionInfo = this.SessionInfo;
                   List<STK_StockResult> stockList = stockBLL.GetList(new STK_StockParam() { ItemCodes = ItemCodes });
                   if (stockList!=null && stockList.Count>0)
                    {
                       foreach (STK_StockReserveResult sr in ret)
                        {
                            if (stockList != null && stockList.Count > 0)
                            {
                                STK_StockResult stockResult = stockList.FirstOrDefault(a => a.ItemCode == sr.ItemCode);
                                if (stockResult != null)
                                {
                                    sr.Unit = stockResult.Unit;
                                    sr.Model = stockResult.Model;
                                    sr.Brand = stockResult.Brand;
                                    sr.Batch = stockResult.Batch;
                                    sr.Package = stockResult.Package;
                                    sr.Quality = stockResult.Quality;
                                    sr.MPQ = stockResult.MPQ;
                                    sr.MarkCode = stockResult.MarkCode;
                                    sr.Warehouse = stockResult.Warehouse;
                                    sr.Location = stockResult.Location;
                                    sr.InvType = stockResult.InvType;
                                    sr.InBatchNo = stockResult.InBatchNo;
                                    
                                }
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

        WhereClip GetWhereClip(STK_StockReserveParam param)
        {
            this.CheckSession();
            WhereClip where = STK_StockReserve._.IsDeleted == 0;
            if(param.SRGuid!=null) where =where && STK_StockReserve._.SRGuid==param.SRGuid;
            if (param.SRGuids != null && param.SRGuids.Length > 0) where = where && STK_StockReserve._.SRGuid.In(param.SRGuids);
            if (param.NoSRGuids != null && param.NoSRGuids.Length > 0) where = where && !STK_StockReserve._.SRGuid.In(param.NoSRGuids);
            if (param.SourceBillGuid != null) where = where && STK_StockReserve._.SourceBillGuid == param.SourceBillGuid;
            if (param.SourceBillLineGuid != null) where = where && STK_StockReserve._.SourceBillLineGuid == param.SourceBillLineGuid;
            if (param.ItemCode != null) where = where && STK_StockReserve._.ItemCode == param.ItemCode;
            if(!string.IsNullOrEmpty(param.SourceBillNo)) where=where && STK_StockReserve._.SourceBillNo==param.SourceBillNo;
            if (param.SourceBillLineGuids != null && param.SourceBillLineGuids.Length > 0) where = where && STK_StockReserve._.SourceBillLineGuid.In(param.SourceBillLineGuids);
            if (param.IsUsedOver != null && !param.IsUsedOver.ToBooleanHasNull()) where = where && STK_StockReserve._.UsedQty.IsNull(0) < STK_StockReserve._.ReserveQty;
            return where;
        }

       

        /// <summary>
        /// 获取一条信息记录
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public STK_StockReserveResult GetInfo(STK_StockReserveParam param)
        {
            this.CheckSession();
            STK_StockReserveResult rst = new STK_StockReserveResult();
            #region 判断
           if (param.SRGuid == null) throw new WarnException("请指定GUID！");
            #endregion
            #region 获取实体
            try
            {
                rst = this.Select<STK_StockReserveResult>(GetWhereClip(param));
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

            #endregion
            return rst;
        }

        /// <summary>
        /// 删除实体
        /// </summary>
        /// <param name="param">删除条件实体</param>
        /// <returns></returns>
        public WCFAddUpdateResult DelInfo(STK_StockReserveParam param)
        {
            this.CheckSession();
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            int affect = 0;
            try
            {
                #region 判断
                if (param.SRGuid == null) throw new WarnException("请指定GUID！");
                #endregion
                WhereClip whereClip = GetWhereClip(param);
                STK_StockReserveResult info = new STK_StockReserveResult();
                info.IsDeleted = true;
                affect = this.Update<STK_StockReserveResult>(info, whereClip);
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
    
    }
}
