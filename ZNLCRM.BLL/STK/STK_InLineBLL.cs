using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLCRM.Entity.UserModel.STK;
using MySoft.Data;
using ZNLCRM.Entity.DBModel;
using ZNLFrame.Entity;
using ZNLCRM.BLL.Sys;
using ZNLCRM.Entity.UserModel.Common;
using ZNLCRM.Utility;

namespace ZNLCRM.BLL.STK
{
   public   class STK_InLineBLL:BaseBLL
    {
        /// <summary>
        /// 获取入库明细的分页信息
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public PageList<STK_InLineResult> GetPageList(STK_InLineParam param)
        {

            PageList<STK_InLineResult> ret = new PageList<STK_InLineResult>();
            try
            {
                STK_InParam InParam = new STK_InParam()
                {
                    SourceBillNo = param.SourceBillNo,
                    BillNo = param.StkInBillNo,
                    PageIndex = 1,
                    PageSize = 5000,
                    Status = param.Status

                };
                STK_InBLL inBLL = new STK_InBLL();
                inBLL.SessionInfo = this.SessionInfo;
                PageList<STK_InResult> inList = inBLL.GetPageList(InParam);
                if (inList != null && inList.ResultList.Count > 0)
                {
                    Guid?[] StkInGuids = inList.ResultList.Select(a => (Guid?)a.StkInGuid).Distinct().ToArray();
                    param.StkInGuids = StkInGuids;

                    ret = this.SelectList<STK_InLineResult>(param.PageIndex.GetValueOrDefault(1), param.PageSize.GetValueOrDefault(50), new List<Field>() { Field.All }, GetWhereClip(param), STK_OutLine._.CreatedTime.Desc);
                    if (ret != null && ret.ResultList.Count > 0)
                    {


                        foreach (STK_InLineResult inLineResult in ret.ResultList)
                        {
                            //获取入库单号
                            STK_InResult inResult = inList.ResultList.FirstOrDefault(a => a.StkInGuid == inLineResult.StkInGuid);
                            if (inResult != null)
                            {
                                inLineResult.StkInBillNo = inResult.BillNo;
                                inLineResult.SourceBillNo = inResult.SourceBillNo;
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
        /// <summary>
        /// 获取集合
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public List<STK_InLineResult> GetList(STK_InLineParam param)
        {
            this.CheckSession();
            List<STK_InLineResult> ret = new List<STK_InLineResult>();
            try
            {
                WhereClip whereClip = GetWhereClip(param);
                ret = this.SelectList<STK_InLineResult>(whereClip, STK_InLine._.CreatedTime.Asc);
                if (ret != null && ret.Count > 0)
                {
                    Guid?[] StkInGuids = ret.Select(a => a.StkInGuid).Distinct().ToArray();
                    STK_InBLL stkInBLL = new STK_InBLL();
                    stkInBLL.SessionInfo = this.SessionInfo;
                    List<STK_InResult> inResultList = stkInBLL.GetList(new STK_InParam() { StkInGuids = StkInGuids });
                    foreach (STK_InLineResult inLineResult in ret)
                    {
                        STK_InResult inResult = inResultList.FirstOrDefault(a => a.StkInGuid == inLineResult.StkInGuid);
                        if (inResult != null)
                        {
                            inLineResult.StkInBillNo = inResult.BillNo;
                            inLineResult.SourceBillNo = inResult.SourceBillNo;
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

        WhereClip GetWhereClip(STK_InLineParam param)
        {
            this.CheckSession();
            WhereClip where = STK_InLine._.IsDeleted == 0;
            if (param.StkInGuid != null) where = where && STK_InLine._.StkInGuid == param.StkInGuid;
            if (param.StkInLineGuid != null) where = where && STK_InLine._.StkInLineGuid == param.StkInLineGuid;
            if (param.StkInLineGuids != null && param.StkInLineGuids.Length > 0) where = where && STK_InLine._.StkInLineGuid.In(param.StkInLineGuids);
            if (param.SourceBillGuid != null) where = where && STK_InLine._.SourceBillGuid == param.SourceBillGuid;
            if (param.SourceBillLineGuids != null && param.SourceBillLineGuids.Length > 0) where = where && STK_InLine._.SourceBillLineGuid.In(param.SourceBillLineGuids);
            if (!string.IsNullOrEmpty(param.Model)) where = where && STK_InLine._.Model.Like("%" + param.Model + "%");
            if (param.SOLineGuids != null && param.SOLineGuids.Length > 0) where = where && STK_InLine._.SOLineGuid.In(param.SOLineGuids);
            if (param.ItemCode != null) where = where && STK_InLine._.ItemCode == param.ItemCode;
            if (param.ItemCodes != null && param.ItemCodes.Length > 0) where = where && STK_InLine._.ItemCode.In(param.ItemCodes);
            return where;
        }


        /// <summary>
        /// 获取一条信息记录
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public STK_InLineResult GetInfo(STK_InLineParam param)
        {
            this.CheckSession();
            STK_InLineResult rst = new STK_InLineResult();
            #region 判断
            if (param.StkInLineGuid == null) throw new WarnException("请指定明细GUID！");
            #endregion
            #region 获取实体

            rst = this.Select<STK_InLineResult>(GetWhereClip(param));

            #endregion
            return rst;
        }

        /// <summary>
        /// 删除实体
        /// </summary>
        /// <param name="param">删除条件实体</param>
        /// <returns></returns>
        public WCFAddUpdateResult DelInfo(STK_InLineParam param)
        {
            this.CheckSession();
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            int affect = 0;
            try
            {
                #region 判断
                if (param.StkInLineGuid == null) throw new WarnException("请指定明细GUID！");
                #endregion
                WhereClip whereClip = GetWhereClip(param);
                STK_InLineResult info = new STK_InLineResult();
                info.IsDeleted = true;
                affect = this.Update<STK_InLineResult>(info, whereClip);
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
        public WCFAddUpdateResult UpdateOrInsertList(List<STK_InLineResult> list)
        {
            this.CheckSession();
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            try
            {
                #region 判断
                if (list.Count <= 0) throw new WarnException("没有需要操作的对象！");
                if (list.Where(a => string.IsNullOrEmpty(a.InvType)).Count() > 0) throw new WarnException("请指定库存类型！");
                if (list.Where(a => string.IsNullOrEmpty(a.Warehouse)).Count() > 0) throw new WarnException("请指定仓库");
                if (list.Where(a => string.IsNullOrEmpty(a.Currency)).Count() > 0) throw new WarnException("请指定入库币种");
                #endregion
                foreach (STK_InLineResult stkStockResult in list)
                {
                    
                    if (stkStockResult.ItemCode.ToGuid() != Guid.Empty)
                    {
                        stkStockResult.UpdatedEmpID = this.SessionInfo.UserID;
                        stkStockResult.UpdatedEmpName = this.SessionInfo.UserName;
                        stkStockResult.UpdatedTime = DateTime.Now;

                    }
                    else
                    {
                        stkStockResult.CreatedEmpID = this.SessionInfo.UserID;
                        stkStockResult.CreatedEmpName = this.SessionInfo.UserName;
                        stkStockResult.CreatedTime = DateTime.Now;
                        stkStockResult.IsDeleted = false;
                    }

                }
                int affect = 0;
                this.BatchInsertOrUpdate<STK_InLineResult>(list);
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
    
    }
}
