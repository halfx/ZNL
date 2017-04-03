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
using ZNLCRM.BLL.SPM;
using ZNLCRM.Entity.UserModel.SPM;

namespace ZNLCRM.BLL.STK
{
    public  class STK_OutLineBLL:BaseBLL
    {

        /// <summary>
        /// 获取出库明细的分页信息
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public PageList<STK_OutLineResult> GetPageList(STK_OutLineParam param)
        {

            PageList<STK_OutLineResult> ret = new PageList<STK_OutLineResult>();
            try
            {
                    STK_OutParam outParam = new STK_OutParam()
                    {
                        SourceBillNo=param.SourceBillNo,
                        BillNo=param.StkOutBillNo,
                        PageIndex = 1,
                        PageSize = 5000,
                        Status=param.Status
                        
                    };
                    STK_OutBLL outBLL=new STK_OutBLL ();
                    outBLL.SessionInfo=this.SessionInfo;
                    PageList<STK_OutResult> outList = outBLL.GetPageList(outParam);
                    if (outList != null && outList.ResultList.Count > 0)
                    {
                        Guid?[] StkOutGuids = outList.ResultList.Select(a => (Guid?)a.StkOutGuid).Distinct().ToArray();
                        param.StkOutGuids = StkOutGuids;
                        
                        ret = this.SelectList<STK_OutLineResult>(param.PageIndex.GetValueOrDefault(1), param.PageSize.GetValueOrDefault(50), new List<Field>() { Field.All }, GetWhereClip(param), STK_OutLine._.CreatedTime.Desc);
                        if (ret != null && ret.ResultList.Count > 0)
                        {
                              
                            foreach (STK_OutLineResult outLineResult in ret.ResultList)
                            {   
                                //获取出库单号
                                STK_OutResult outResult= outList.ResultList.FirstOrDefault(a => a.StkOutGuid == outLineResult.StkOutGuid);
                                if (outResult != null)
                                {
                                    outLineResult.StkOutBillNo = outResult.BillNo;
                                    outLineResult.SourceBillNo = outResult.SourceBillNo;
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
        public List<STK_OutLineResult> GetList(STK_OutLineParam param)
        {
            this.CheckSession();
            List<STK_OutLineResult> ret = new List<STK_OutLineResult>();
            try
            {
                WhereClip whereClip = GetWhereClip(param);
                ret = this.SelectList<STK_OutLineResult>(whereClip, STK_OutLine._.CreatedTime.Asc);
                if(ret!=null && ret.Count>0)
                {
                   Guid?[] StkOutGuids= ret.Select(a=>a.StkOutGuid).Distinct().ToArray();
                   Guid?[] ItemCodes = ret.Select(a => a.ItemCode).Distinct().ToArray();
                   STK_OutBLL stkOutBLL=new STK_OutBLL ();
                    stkOutBLL.SessionInfo=this.SessionInfo;
                    List<STK_OutResult> outResultList=  stkOutBLL.GetList(new STK_OutParam(){StkOutGuids=StkOutGuids});
                    STK_StockBLL stockBLL = new STK_StockBLL();
                    stockBLL.SessionInfo = this.SessionInfo;
                    List<STK_StockResult> stockResultList= stockBLL.GetList(new STK_StockParam() { ItemCodes = ItemCodes });
                    foreach (STK_OutLineResult outLineResult in ret)
                    { 
                        STK_OutResult outResult=outResultList.FirstOrDefault(a=>a.StkOutGuid==outLineResult.StkOutGuid);
                        if (outResult != null)
                        {
                            outLineResult.StkOutBillNo = outResult.BillNo;
                            outLineResult.SourceBillNo = outResult.SourceBillNo;
                        }
                        STK_StockResult stockResult = stockResultList.FirstOrDefault(a => a.ItemCode == outLineResult.ItemCode);
                        if (stockResult != null)
                        {
                            outLineResult.BuyerID = stockResult.BuyerID;
                            outLineResult.BuyerName = stockResult.BuyerName;
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

        WhereClip GetWhereClip(STK_OutLineParam param)
        {
            this.CheckSession();
            
            WhereClip where = STK_OutLine._.IsDeleted == 0;
            if (param.StkOutGuid != null) where = where && STK_OutLine._.StkOutGuid == param.StkOutGuid;
            if (param.StkOutGuids != null) where = where && STK_OutLine._.StkOutGuid.In(param.StkOutGuids);
            if (param.StkOutLineGuid != null) where = where && STK_OutLine._.StkOutLineGuid == param.StkOutLineGuid;
            if (param.SourceBillGuid != null) where = where && STK_OutLine._.SourceBillGuid == param.SourceBillGuid;
            if (!string.IsNullOrEmpty(param.Model)) where = where && STK_OutLine._.Model.Like("%" + param.Model + "%");
            if (param.IsReturnOver != null && !param.IsReturnOver.ToBooleanHasNull()) where = where && STK_OutLine._.Qty > STK_OutLine._.ReturnOccQty.ToInt32();
            if (param.StkOutLineGuids != null && param.StkOutLineGuids.Length > 0) where = where && STK_OutLine._.StkOutLineGuid.In(param.StkOutLineGuids);
            if (param.NoStkOutLineGuids != null && param.NoStkOutLineGuids.Length > 0) where = where && !STK_OutLine._.StkOutLineGuid.In(param.NoStkOutLineGuids);
            return where;
        }


        /// <summary>
        /// 获取一条信息记录
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public STK_OutLineResult GetInfo(STK_OutLineParam param)
        {
            this.CheckSession();
            STK_OutLineResult rst = new STK_OutLineResult();
            #region 判断
            if (param.StkOutLineGuid == null) throw new WarnException("请指定明细GUID！");
            #endregion
            #region 获取实体

            rst = this.Select<STK_OutLineResult>(GetWhereClip(param));

            #endregion
            return rst;
        }

        /// <summary>
        /// 删除实体
        /// </summary>
        /// <param name="param">删除条件实体</param>
        /// <returns></returns>
        public WCFAddUpdateResult DelInfo(STK_OutLineParam param)
        {
            this.CheckSession();
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            int affect = 0;
            try
            {
                #region 判断
                if (param.StkOutLineGuid == null) throw new WarnException("请指定明细GUID！");
                #endregion
                WhereClip whereClip = GetWhereClip(param);
                STK_OutLineResult info = new STK_OutLineResult();
                info.IsDeleted = true;
                affect = this.Update<STK_OutLineResult>(info, whereClip);
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
        public WCFAddUpdateResult UpdateOrInsertList(List<STK_OutLineResult> list)
        {
            this.CheckSession();
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            try
            {
                #region 判断
                if (list.Count <= 0) throw new WarnException("没有需要操作的对象！");
                if (list.Where(a => string.IsNullOrEmpty(a.InvType)).Count() > 0) throw new WarnException("请指定库存类型！");
                if (list.Where(a => string.IsNullOrEmpty(a.Warehouse)).Count() > 0) throw new WarnException("请指定仓库");
                if (list.Where(a => string.IsNullOrEmpty(a.Currency)).Count() > 0) throw new WarnException("请指定出库币种");
                #endregion
                foreach (STK_OutLineResult stkStockResult in list)
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
                this.BatchInsertOrUpdate<STK_OutLineResult>(list);
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
