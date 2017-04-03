using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLCRM.Entity.UserModel.PPM;
using MySoft.Data;
using ZNLCRM.Entity.DBModel;
using ZNLFrame.Entity;
using ZNLCRM.BLL.Sys;
using ZNLCRM.Entity.UserModel.Common;
using ZNLCRM.Utility;

namespace ZNLCRM.BLL.PPM
{
    public  class ORD_PurchaseOrderLineBLL:BaseBLL
    {

        public List<ORD_PurchaseOrderLineResult> GetSimpleList(ORD_PurchaseOrderLineParam param, List<Field> fields)
        {
            List<ORD_PurchaseOrderLineResult> ret = new List<ORD_PurchaseOrderLineResult>();
            try
            {
                WhereClip whereClip = GetWhereClip(param);
                ret = this.SelectList<ORD_PurchaseOrderLineResult>(fields,whereClip, ORD_PurchaseOrderLine._.CreatedTime.Asc);
                if (ret != null && ret.Count > 0)
                {
                   Guid?[] POGuids=  ret.Select(a => a.POGuid).Distinct().ToArray();
                   ORD_PurchaseOrderBLL orderBLL = new ORD_PurchaseOrderBLL();
                   orderBLL.SessionInfo = this.SessionInfo;
                   List<ORD_PurchaseOrderResult> orderResultList=  orderBLL.GetList(new ORD_PurchaseOrderParam() { POGuids = POGuids });
                   foreach (ORD_PurchaseOrderLineResult lineResult in ret)
                   {
                      ORD_PurchaseOrderResult orderResult=  orderResultList.FirstOrDefault(a => a.POGuid == lineResult.POGuid);
                      if (orderResult != null)
                      {
                          lineResult.POBillNo = orderResult.BillNo;
                          lineResult.Currency = orderResult.Currency;
                          lineResult.TaxRate = orderResult.TaxRate;
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
        public List<ORD_PurchaseOrderLineResult> GetList(ORD_PurchaseOrderLineParam param)
        {
            this.CheckSession();
            return GetSimpleList(param, new List<Field> { Field.All });
        }
        WhereClip GetWhereClip(ORD_PurchaseOrderLineParam param)
        {
            this.CheckSession();
            WhereClip where = ORD_PurchaseOrderLine._.IsDeleted == 0;
            if (param.IsCancel != null) where = where && ORD_PurchaseOrderLine._.IsCancel == param.IsCancel;
            if (param.POLineGuid != null) where = where && ORD_PurchaseOrderLine._.POLineGuid == param.POLineGuid;
            if (param.POLineGuids != null && param.POLineGuids.Length > 0) where = where && ORD_PurchaseOrderLine._.POLineGuid.In(param.POLineGuids);
            
            if (param.POGuid != null) where = where && ORD_PurchaseOrderLine._.POGuid == param.POGuid;
            if (!string.IsNullOrEmpty(param.Model)) where = where && ORD_PurchaseOrderLine._.Model.Like("%" + param.Model + "%");
            if (param.NoPOLineGuids != null && param.NoPOLineGuids.Length>0) where = where && !ORD_PurchaseOrderLine._.POLineGuid.In(param.NoPOLineGuids);
            if (param.NoticeGuids != null && param.NoticeGuids.Length > 0) where = where && ORD_PurchaseOrderLine._.NoticeGuid.In(param.NoticeGuids);
            if (param.SOLineGuids != null && param.SOLineGuids.Length > 0) where = where && ORD_PurchaseOrderLine._.SOLineGuid.In(param.SOLineGuids);
            return where;
        }
        /// <summary>
        /// 获取一条信息记录
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public ORD_PurchaseOrderLineResult GetInfo(ORD_PurchaseOrderLineParam param)
        {
            this.CheckSession();
            ORD_PurchaseOrderLineResult rst = new ORD_PurchaseOrderLineResult();
            #region 判断
            if (param.POLineGuid == null) throw new WarnException("请指定明细GUID！");
            #endregion
            #region 获取实体

            rst = this.Select<ORD_PurchaseOrderLineResult>(GetWhereClip(param));

            #endregion
            return rst;
        }
        /// <summary>
        /// 批量修改和插入
        /// </summary>
        /// <param name="paramList"></param>
        /// <returns></returns>
        public WCFAddUpdateResult UpdateOrInsertList(List<ORD_PurchaseOrderLineResult> list)
        {
            this.CheckSession();
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            try
            {
                #region 判断
                if (list.Count <= 0) throw new WarnException("没有需要操作的对象！");
               
                #endregion
                foreach (ORD_PurchaseOrderLineResult orderLineResult in list)
                {
                    
                    if (orderLineResult.POLineGuid.ToGuid() != Guid.Empty)
                    {
                        orderLineResult.UpdatedEmpID = this.SessionInfo.UserID;
                        orderLineResult.UpdatedEmpName = this.SessionInfo.UserName;
                        orderLineResult.UpdatedTime = DateTime.Now;

                    }
                    else
                    {
                        orderLineResult.CreatedEmpID = this.SessionInfo.UserID;
                        orderLineResult.CreatedEmpName = this.SessionInfo.UserName;
                        orderLineResult.CreatedTime = DateTime.Now;
                        orderLineResult.IsDeleted = false;
                    }

                }
                int affect = 0;
                this.BatchInsertOrUpdate<ORD_PurchaseOrderLineResult>(list);
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
        /// 删除实体
        /// </summary>
        /// <param name="param">删除条件实体</param>
        /// <returns></returns>
        public WCFAddUpdateResult DelInfo(ORD_PurchaseOrderLineParam param)
        {
            this.CheckSession();
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            int affect = 0;
            try
            {
                #region 判断
                if (param.POLineGuid == null) throw new WarnException("请指定明细GUID！");
                #endregion
                WhereClip whereClip = GetWhereClip(param);
                ORD_PurchaseOrderLineResult info = new ORD_PurchaseOrderLineResult();
                info.IsDeleted = true;
                affect = this.Update<ORD_PurchaseOrderLineResult>(info, whereClip);
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
