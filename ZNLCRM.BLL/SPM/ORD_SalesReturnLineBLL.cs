using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLCRM.Entity.UserModel.SPM;
using ZNLFrame.Entity;
using MySoft.Data;
using ZNLCRM.Entity.DBModel;
using ZNLCRM.BLL.Sys;
using ZNLCRM.Entity.UserModel.Common;
using ZNLCRM.Utility;
using ZNLCRM.Entity.UserModel.STK;
using ZNLCRM.BLL.STK;
using ZNLCRM.Entity.UserModel.PPM;

namespace ZNLCRM.BLL.SPM
{
    public  class ORD_SalesReturnLineBLL:BaseBLL
    {
        /// <summary>
        /// 获取销售退货的分页信息
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public PageList<ORD_SalesReturnLineResult> GetPageList(ORD_SalesReturnLineParam param)
        {

            PageList<ORD_SalesReturnLineResult> ret = new PageList<ORD_SalesReturnLineResult>();
            try
            {
                ret = this.SelectList<ORD_SalesReturnLineResult>(param.PageIndex.GetValueOrDefault(1), param.PageSize.GetValueOrDefault(50), new List<Field> { Field.All }, GetWhereClip(param), ORD_SalesReturnLine._.CreatedTime.Desc);
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
        public List<ORD_SalesReturnLineResult> GetList(ORD_SalesReturnLineParam param)
        {
            this.CheckSession();
            List<ORD_SalesReturnLineResult> ret = new List<ORD_SalesReturnLineResult>();
            try
            {
                WhereClip whereClip = GetWhereClip(param);
                ret = this.SelectList<ORD_SalesReturnLineResult>(whereClip, ORD_SalesReturnLine._.CreatedTime.Asc);
                if (ret != null)
                {
                    STK_InLineBLL stkInLineBLL = new STK_InLineBLL();
                    stkInLineBLL.SessionInfo = this.SessionInfo;
                    Guid?[] stkInLineGuids = ret.Select(a => a.StkInLineGuid).Distinct().ToArray();
                    List<STK_InLineResult> linkInLineResultList = stkInLineBLL.GetList(new STK_InLineParam() { StkInLineGuids = stkInLineGuids });
                    
                    ORD_SalesReturnBLL returnBLL = new ORD_SalesReturnBLL();
                    returnBLL.SessionInfo = this.SessionInfo;
                    Guid?[] SRGuids = ret.Select(a => a.SRGuid).Distinct().ToArray();
                    List<ORD_SalesReturnResult> returnResultList = returnBLL.GetList(new ORD_SalesReturnParam() { SRGuids = SRGuids });
                    foreach (ORD_SalesReturnLineResult returnLineResult in ret)
                    {
                         
                         ORD_SalesReturnResult returnResult = returnResultList.FirstOrDefault(a => a.SRGuid == returnLineResult.SRGuid);
                         if (returnResult != null)
                        {
                            returnLineResult.SRBillNo = returnResult.BillNo;
                        }
                        STK_InLineResult linkStkInLineResult = linkInLineResultList.FirstOrDefault(a => a.StkInLineGuid == returnLineResult.StkInLineGuid);
                        if (linkStkInLineResult != null)
                        {
                            
                            returnLineResult.LinkStkInCurrency = linkStkInLineResult.Currency;
                            returnLineResult.LinkStkInTaxRate = linkStkInLineResult.TaxRate;
                            returnLineResult.LinkStkInUnitPrice = linkStkInLineResult.UnitPrice;
                            returnLineResult.LinkStkInFreight = linkStkInLineResult.Freight;
                            returnLineResult.LinkStkInCostPrice = linkStkInLineResult.CostPrice;
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

        WhereClip GetWhereClip(ORD_SalesReturnLineParam param)
        {
            this.CheckSession();
            WhereClip where = ORD_SalesReturnLine._.IsDeleted == 0;
            if (param.SRLineGuid != null) where = where && ORD_SalesReturnLine._.SRLineGuid == param.SRLineGuid;
            if (param.SRLineGuids != null && param.SRLineGuids.Length > 0) where = where && ORD_SalesReturnLine._.SRLineGuid.In(param.SRLineGuids);
            if (param.NoSRLineGuids != null && param.NoSRLineGuids.Length > 0) where = where && !ORD_SalesReturnLine._.SRLineGuid.In(param.NoSRLineGuids);
            if (param.SRGuid != null) where = where && ORD_SalesReturnLine._.SRGuid == param.SRGuid;
            if (!string.IsNullOrEmpty(param.Model)) where = where && ORD_SalesReturnLine._.Model.Like(param.Model + "%");
            if (param.StkOutLineGuids != null && param.StkOutLineGuids.Length > 0) where = where && ORD_SalesReturnLine._.StkOutLineGuid.In(param.StkOutLineGuids);
            return where;
        }


        /// <summary>
        /// 获取一条信息记录
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public ORD_SalesReturnLineResult GetInfo(ORD_SalesReturnLineParam param)
        {
            this.CheckSession();
            ORD_SalesReturnLineResult rst = new ORD_SalesReturnLineResult();
            #region 判断
            if (param.SRLineGuid == null) throw new WarnException("请指定明细GUID！");
            #endregion
            #region 获取实体

            rst = this.Select<ORD_SalesReturnLineResult>(GetWhereClip(param));

            #endregion
            return rst;
        }

        /// <summary>
        /// 删除实体
        /// </summary>
        /// <param name="param">删除条件实体</param>
        /// <returns></returns>
        public WCFAddUpdateResult DelInfo(ORD_SalesReturnLineParam param)
        {
            this.CheckSession();
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            int affect = 0;
            try
            {
                #region 判断
                if (param.SRLineGuid == null) throw new WarnException("请指定明细GUID！");
                #endregion
                WhereClip whereClip = GetWhereClip(param);
                ORD_SalesReturnLineResult info = new ORD_SalesReturnLineResult();
                info.IsDeleted = true;
                affect = this.Update<ORD_SalesReturnLineResult>(info, whereClip);
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
        /// 添加和新增修改
        /// </summary>
        /// <param name="param">新增或修改的实体</param>
        /// <returns></returns>
        public WCFAddUpdateResult AddOrUpdate(ORD_SalesReturnLineResult param)
        {
            this.CheckSession();
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            try
            {
                int affect = 0;
                #region 判断
                #endregion

                #region 系统默认值
                if (param.SRLineGuid != null)
                {
                    WhereClip where = ORD_SalesReturnLine._.SRLineGuid == param.SRLineGuid;
                    param.UpdatedEmpID = this.SessionInfo.UserID;
                    param.UpdatedEmpName = this.SessionInfo.UserName;
                    param.UpdatedTime = DateTime.Now;
                    affect = this.Update<ORD_SalesReturnLineResult>(param, where);
                }
                else
                {
                    param.SRLineGuid = Guid.NewGuid();
                    param.IsDeleted = false;
                    param.CreatedEmpID = this.SessionInfo.UserID;
                    param.CreatedEmpName = this.SessionInfo.UserName;
                    param.CreatedTime = DateTime.Now;
                    affect = this.Insert<ORD_SalesReturnLineResult>(param);
                    param = this.Select<ORD_SalesReturnLineResult>(new List<Field>() { ORD_SalesReturnLine._.All }, ORD_SalesReturnLine._.SRLineGuid == param.SRLineGuid);
                }
                #region 设置返回值
                ret.KeyGuid = param.SRLineGuid;
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

        public WCFAddUpdateResult UpdateOrInsertList(List<ORD_SalesReturnLineResult> list)
        {
            this.CheckSession();
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            try
            {
                #region 判断
                if (list.Count <= 0) throw new WarnException("没有需要操作的对象！");
                #endregion
                foreach (ORD_SalesReturnLineResult lineResult in list)
                {
                    if (lineResult.SRLineGuid.ToGuid() != Guid.Empty)
                    {
                        lineResult.UpdatedEmpID = this.SessionInfo.UserID;
                        lineResult.UpdatedEmpName = this.SessionInfo.UserName;
                        lineResult.UpdatedTime = DateTime.Now;

                    }
                    else
                    {
                        lineResult.SRLineGuid = Guid.NewGuid();
                        lineResult.CreatedEmpID = this.SessionInfo.UserID;
                        lineResult.CreatedEmpName = this.SessionInfo.UserName;
                        lineResult.CreatedTime = DateTime.Now;
                        lineResult.IsDeleted = false;
                    }

                }
                int affect = 0;
                this.BatchInsertOrUpdate<ORD_SalesReturnLineResult>(list);
                affect = this.BatchExecute();
                #region 设置返回值
                ret.Key = affect;
                #endregion

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
            return ret;
        }
    }
}
