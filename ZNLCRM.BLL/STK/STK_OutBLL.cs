using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLFrame.Entity;
using ZNLCRM.Entity.UserModel.STK;
using MySoft.Data;
using ZNLCRM.BLL.HR;
using ZNLCRM.Entity.UserModel.HR;
using ZNLCRM.Entity.DBModel;
using ZNLCRM.Entity.UserModel.Common;
using ZNLCRM.BLL.Sys;
using ZNLCRM.Utility;
using ZNLCRM.BLL.PPM;
using ZNLCRM.BLL.SPM;
using ZNLCRM.Entity.UserModel.PPM;
using ZNLCRM.Entity.UserModel.SPM;

namespace ZNLCRM.BLL.STK
{
    public  class STK_OutBLL:BaseBLL
    {

        public bool SubmitStkOutBill(STK_OutParam param)
        {
            this.CheckSession();
            bool submitFlag = true;
            try
            {
                STK_OutResult outResult = this.GetInfo(param);

                if (outResult != null)
                {
                    
                    #region 判断是否可以提交
                    bool isAllowSubmit = true;
                    if (outResult.ApproveStatus == "待审核")
                    {
                        isAllowSubmit = false;
                        throw new WarnException("入库单当前状态为:【已提交,待审核】,禁止重复提交！");
                    }
                    else if (outResult.ApproveStatus == "审核完成")
                    {
                        isAllowSubmit = false;
                        throw new WarnException("入库单当前状态为:【审核完成】,撤单后才可以再次提交！");
                    }
                   
                    #region 提交时判断预留信息使用数量是否大于预留数量,如果大于预留数量是不允许提交的
                        List<STK_OutLineResult> outLineList = outResult.StkOutLineList;
                        Guid?[] SRGuids = outLineList.Select(a => a.SRGuid).Distinct().ToArray();
                        STK_StockReserveBLL reserveBLL = new STK_StockReserveBLL();
                        reserveBLL.SessionInfo = this.SessionInfo;

                        List<STK_StockReserveResult> reserveList = reserveBLL.GetList(new STK_StockReserveParam() { SRGuids = SRGuids });
                        foreach (STK_StockReserveResult reserveResult in reserveList)
                        {
                            reserveResult.UsedQty = reserveResult.UsedQty.ToInt32();
                            reserveResult.ReserveQty = reserveResult.ReserveQty.ToInt32();
                            int? usedQty = 0;
                            STK_OutLineResult outLineResult = outLineList.FirstOrDefault(a => a.SRGuid == reserveResult.SRGuid);
                            if (outLineResult != null) usedQty = outLineResult.Qty;
                            if ((reserveResult.UsedQty + usedQty) > reserveResult.ReserveQty)
                            {
                                isAllowSubmit = false;
                                break;
                            }
                            reserveResult.UsedQty += usedQty;
                        }

                    if (isAllowSubmit)
                    {
                        #region 回写库存预留的出库数量
                        WCFAddUpdateResult ret = reserveBLL.UpdateOrInsertList(reserveList);
                        if (ret.Key <= 0)
                        {
                            submitFlag = false;
                            throw new WarnException("回写出库单明细关联的库存预留明细的出库数量失败,禁止提交出库单！");
                        }
                        #endregion

                        #region 更新出库单的状态
                        outResult.Status = "Approve";
                        outResult.ApproveStatus = "待审核";
                        this.AddOrUpdate(outResult);
                        #endregion
                    }
                    else
                    {
                        submitFlag = false;
                        throw new WarnException("出库单明细所关联库存预留明细的出库数量+此次出库数量>库存预留数量，禁止提交出库单！");
                    }
                        #endregion
                    #endregion
                }
                else
                {
                    throw  new WarnException("要提交的出库单在系统中不存在！");
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
            return submitFlag;
        }

        public bool AuditStkOutBill(STK_OutParam param)
        {
            bool auditFlag = true;
            try
            {
                STK_OutResult outResult = this.GetInfo(param);
                if (outResult != null)
                {
                    bool isAllowAudit = true;
                    if (outResult.ApproveStatus == "待提交")
                    {
                        isAllowAudit = false;
                        throw new WarnException("出库单当前状态为:【待提交】,请先提交！");
                    }
                    else if (outResult.ApproveStatus == "审核完成")
                    {
                        isAllowAudit = false;
                        throw new WarnException("出库单当前状态为:【审核完成】,禁止重复审核！");
                    }
                    if (isAllowAudit)
                    {
                        outResult.Status = "Complete";
                        outResult.ApproveStatus = "审核完成";
                        WCFAddUpdateResult ret = this.AddOrUpdate(outResult);
                        
                        if (ret.KeyGuid.ToGuid() == Guid.Empty)
                        {
                            auditFlag = false;
                        }
                        else
                        {
                            #region 定义相关变量(可重复使用)
                            STK_OutLineBLL outLineBLL=new STK_OutLineBLL ();
                            outLineBLL.SessionInfo=this.SessionInfo;
                            STK_InBLL inBLL = new STK_InBLL();
                            inBLL.SessionInfo = this.SessionInfo;
                            STK_InLineBLL inLineBLL = new STK_InLineBLL();
                            inLineBLL.SessionInfo = this.SessionInfo;
                            
                            ORD_PurchaseOrderLineBLL purOrderLineBLL = new ORD_PurchaseOrderLineBLL();
                            purOrderLineBLL.SessionInfo = this.SessionInfo;
                            ORD_PurchaseOrderBLL purOrderBLL = new ORD_PurchaseOrderBLL();
                            purOrderBLL.SessionInfo = this.SessionInfo;
                            ORD_SalesOrderBLL saleOrderBLL = new ORD_SalesOrderBLL();
                            saleOrderBLL.SessionInfo = this.SessionInfo;
                            ORD_SalesOrderLineBLL saleOrderLineBLL = new ORD_SalesOrderLineBLL();
                            saleOrderLineBLL.SessionInfo = this.SessionInfo;
                            ORD_PurchaseReturnBLL purReturnBLL = new ORD_PurchaseReturnBLL();
                            purReturnBLL.SessionInfo = this.SessionInfo;
                            ORD_PurchaseReturnLineBLL purReturnLineBLL = new ORD_PurchaseReturnLineBLL();
                            purReturnLineBLL.SessionInfo = this.SessionInfo;
                            STK_StockSheetBLL stockSheetBLL = new STK_StockSheetBLL();
                            stockSheetBLL.SessionInfo = this.SessionInfo;
                            STK_StockBLL stockBLL = new STK_StockBLL();
                            stockBLL.SessionInfo = this.SessionInfo;
                            STK_InOutLinkBLL inOutLinkBLL=new STK_InOutLinkBLL ();
                            inOutLinkBLL.SessionInfo=this.SessionInfo;
                            List<ORD_SalesOrderResult> saleList = null;
                            List<ORD_SalesOrderLineResult> saleLineList = null;
                            List<ORD_PurchaseOrderLineResult>  purLineList=null;
                            List<ORD_PurchaseReturnResult> purReturnList = null;
                            List<ORD_PurchaseReturnLineResult> purReturnLineList = null;
                            List<STK_InResult> stkInList = null;
                            List<STK_InLineResult> stkInLineList = null;
                            List<STK_InLineResult> effStkInLineList = null;
                            List<STK_OutResult> stkOutList = null;
                            List<STK_OutLineResult> stkOutLineList = null;
                            List<STK_OutLineResult> effStkOutLineList = null;
                            List<STK_StockResult> stockList = null;
                            List<STK_StockSheetResult> stkStockSheetList = null;
                            
                            Guid?[] ItemCodes = null;
                            Guid?[] StkInGuids = null;
                            Guid?[] StkInLineGuids=null;
                            Guid?[] EffStkInGuids = null;
                            Guid?[] StkOutGuids = null;
                            Guid?[] _stkOutLineGuids=null;
                            Guid?[] EffStkOutGuids = null;
                            Guid?[] POGuids = null;
                            Guid?[] POLineGuids = null;
                            Guid?[] SOGuids=null;
                            Guid?[] SOLineGuids=null;
                            Guid?[] PRGuids = null;
                            Guid?[] PRLineGuids = null;
                            #endregion 
                            //获取出库单下的出库明细集合
                            List<STK_OutLineResult> outLineList=outLineBLL.GetList(new STK_OutLineParam(){StkOutGuid=ret.KeyGuid});
                            //获取出库单下的关联明细集合
                            List<STK_InOutLinkResult> inOutLinkList = inOutLinkBLL.GetList(new STK_InOutLinkParam() { StkOutGuid = ret.KeyGuid });
                            if(outLineList!=null && outLineList.Count>0)
                            {
                                
                                #region 减少库存，形成出库流水
                                ItemCodes = outLineList.Select(a => a.ItemCode).Distinct().ToArray() ;
                                stockList = stockBLL.GetList(new STK_StockParam() { ItemCodes = ItemCodes });
                                
                                stkStockSheetList = new List<STK_StockSheetResult>();
                                STK_StockSheetResult stkStockSheetResult=null;
                                foreach (STK_OutLineResult outLineResult in outLineList)
                                {
                                    STK_StockResult stockResult= stockList.FirstOrDefault(a => a.ItemCode == outLineResult.ItemCode.ToGuid());
                                    if (stockResult != null)
                                    {
                                        stockResult.InvQty -= outLineResult.Qty;
                                        stockResult.BookedQty -= outLineResult.Qty;
                                        stkStockSheetResult = new STK_StockSheetResult();
                                        stkStockSheetResult.SSType = 2;
                                        stkStockSheetResult.SourceBillGuid = outResult.StkOutGuid;
                                        stkStockSheetResult.SourceBillNo = outResult.BillNo;
                                        stkStockSheetResult.SourceBillLineGuid = outLineResult.StkOutLineGuid;
                                        stkStockSheetResult.ItemCode = outLineResult.ItemCode;
                                        stkStockSheetResult.Model = outLineResult.Model;
                                        stkStockSheetResult.Brand = outLineResult.Brand;
                                        stkStockSheetResult.Batch = outLineResult.Batch;
                                        stkStockSheetResult.Package = outLineResult.Package;
                                        stkStockSheetResult.Quality = outLineResult.Quality;
                                        stkStockSheetResult.MPQ = outLineResult.MPQ;
                                        stkStockSheetResult.MarkCode = outLineResult.MarkCode;
                                        stkStockSheetResult.Currency = outLineResult.Currency;
                                        stkStockSheetResult.FlowQty = outLineResult.Qty;
                                        stkStockSheetResult.FlowPrice = outLineResult.UnitPrice;
                                        stkStockSheetResult.FlowAmount = outLineResult.Amount;
                                        stkStockSheetList.Add(stkStockSheetResult);
                                    
                                    }
                                    
                                }
                                stockBLL.UpdateOrInsertList(stockList);
                                stockSheetBLL.UpdateOrInsertList(stkStockSheetList);

                                
                                #endregion

                                #region 回写关联的入库单的出库数量和出库状态，入库单关联单据的出库数量和出库状态，出库单关联单据的出库数量和出库状态
                               
                                #region 回写关联入库单的出库数量出库状态
                               
                                //获取出库明细的guid
                                StkInLineGuids = inOutLinkList.Select(a => a.StkInLineGuid).Distinct().ToArray();
                                
                                if (StkInLineGuids != null && StkInLineGuids.Length > 0)
                                {
                                    //获取出库明细所关联的入库明细
                                    stkInLineList = inLineBLL.GetList(new STK_InLineParam() { StkInLineGuids = StkInLineGuids });
                                    if (stkInLineList != null && stkInLineList.Count > 0)
                                    {
                                        //获取出库明细所关联的入库明细对应的出库明细
                                         List<STK_InOutLinkResult> linkList= inOutLinkBLL.GetList(new STK_InOutLinkParam() { StkInLineGuids = StkInLineGuids });
                                         if (linkList != null && linkList.Count>0)
                                         {
                                             _stkOutLineGuids = linkList.Select(a => a.StkOutLineGuid).Distinct().ToArray();
                                             stkOutLineList = outLineBLL.GetList(new STK_OutLineParam() { StkOutLineGuids = _stkOutLineGuids });
                                             if (stkOutLineList != null && stkOutLineList.Count > 0)
                                             {
                                                 //获取出库明细对应的出库主单guid
                                                 StkOutGuids = stkOutLineList.Select(a => a.StkOutGuid).Distinct().ToArray();
                                                 if (StkOutGuids != null && StkOutGuids.Length > 0)
                                                 {
                                                     //获取出库明细对应的出库主单
                                                     stkOutList = this.GetList(new STK_OutParam() { StkOutGuids = StkOutGuids, Status = "Complete" });
                                                     if (stkOutList != null && stkOutList.Count > 0)
                                                     {
                                                         //获取有效的出库主单guid
                                                         EffStkOutGuids = stkOutList.Select(a => a.StkOutGuid).Distinct().ToArray();
                                                         //获取有效的出库明细集合
                                                         effStkOutLineList = stkOutLineList.Where(a => EffStkOutGuids.Contains(a.StkOutGuid)).ToList();
                                                         foreach (STK_InLineResult stkInLineResult in stkInLineList)
                                                         {
                                                             //汇总出库明细的出库数量
                                                             int? qty = effStkOutLineList.Where(a => a.StkInLineGuid == stkInLineResult.StkInLineGuid).Sum(a => a.Qty.ToInt32());
                                                             //回写入库明细的出库数量
                                                             stkInLineResult.StkOutQty = qty;
                                                         }
                                                     }
                                                 }
                                                 //更新入库明细的集合
                                                 inLineBLL.UpdateOrInsertList(stkInLineList);
                                                 //获取入库主单guid
                                                 StkInGuids = stkInLineList.Select(a => a.StkInGuid).Distinct().ToArray();
                                                 foreach (Guid stkinguid in StkInGuids)
                                                 {
                                                     //更新入库单的状态
                                                     inBLL.UpdateStatus(new STK_InParam() { StkInGuid = stkinguid });
                                                     //获取入库单
                                                     STK_InResult stkInResult = inBLL.GetInfo(new STK_InParam() { StkInGuid = stkinguid });
                                                     if (stkInResult.BillType == "PO_IN")
                                                     {
                                                         #region 回写采购单的出库的数量出库状态
                                                         //找到入库明细所关联的采购明细guid和采购明细集合
                                                         POLineGuids = stkInLineList.Where(a => a.StkInGuid == stkinguid).Select(a => a.SourceBillLineGuid).Distinct().ToArray();
                                                         if (POLineGuids != null && POLineGuids.Length > 0)
                                                         {
                                                             purLineList = purOrderLineBLL.GetList(new ORD_PurchaseOrderLineParam() { POLineGuids = POLineGuids });
                                                             if (purLineList != null && purLineList.Count > 0)
                                                             {
                                                                 //找到采购单明细关联的入库明细
                                                                 List<STK_InLineResult> linkInLineList = inLineBLL.GetList(new STK_InLineParam() { SourceBillLineGuids = POLineGuids });
                                                                 if (linkInLineList != null && linkInLineList.Count > 0)
                                                                 {
                                                                     //找到采购明细关联的入库明细的入库主单guid
                                                                     Guid?[] LinkInGuids = linkInLineList.Select(a => a.StkInGuid).Distinct().ToArray();
                                                                     if (LinkInGuids != null && LinkInGuids.Length > 0)
                                                                     {
                                                                         //找到采购单明细关联的入库明细所在的入库主单
                                                                         stkInList = inBLL.GetList(new STK_InParam() { StkInGuids = LinkInGuids, Status = "Complete" });
                                                                         if (stkInList != null && stkInList.Count > 0)
                                                                         {
                                                                             //有效的入库主单guid
                                                                             EffStkInGuids = stkInList.Select(a => a.StkInGuid).Distinct().ToArray();
                                                                             //有效的入库明细集合
                                                                             effStkInLineList = linkInLineList.Where(a => EffStkInGuids.Contains(a.StkInGuid)).ToList();
                                                                             foreach (ORD_PurchaseOrderLineResult purLineResult in purLineList)
                                                                             {
                                                                                 //汇总有效的入库明细的出库数量
                                                                                 int? qty = effStkInLineList.Where(a => a.SourceBillLineGuid == purLineResult.POLineGuid).Sum(a => a.StkOutQty).ToInt32();
                                                                                 //更新采购明细的出库数量
                                                                                 purLineResult.StkOutQty = qty;
                                                                             }
                                                                         }
                                                                     }
                                                                 }
                                                                 //更新采购明细集合
                                                                 purOrderLineBLL.UpdateOrInsertList(purLineList);
                                                                 POGuids = purLineList.Select(a => a.POGuid).Distinct().ToArray();
                                                                 foreach (Guid poguid in POGuids)
                                                                 {
                                                                     purOrderBLL.UpdateStatus(new ORD_PurchaseOrderParam() { POGuid = poguid });
                                                                 }
                                                             }
                                                         }

                                                         #endregion
                                                     }
                                                     else if (stkInResult.BillType == "SOR_IN")
                                                     {

                                                     }
                                                     else if (stkInResult.BillType == "ZX_IN")
                                                     {

                                                     }
                                                 }

                                             }
                                         }

                                    }
                                }
                                #endregion


                                #region 回写出库单关联的业务单据的出库数量和出库状态
                                if (outResult.BillType== "SO_OUT")
                                {
                                    #region 回写销售单的出库数量和出库状态
                                    //获取出库明细对应的销售明细guid
                                    SOLineGuids= outLineList.Select(a => a.SourceBillLineGuid).Distinct().ToArray();
                                    if(SOLineGuids!=null && SOLineGuids.Length>0)
                                    {
                                        //获取出库明细对应的销售明细
                                        saleLineList = saleOrderLineBLL.GetList(new ORD_SalesOrderLineParam() { SOLineGuids = SOLineGuids });
                                        if (saleLineList != null && saleLineList.Count > 0)
                                        {
                                            //获取出库明细对应的销售明细关联关联的出库明细
                                            stkOutLineList = outLineBLL.GetList(new STK_OutLineParam() { SourceBillLineGuids = SOLineGuids});
                                            if (stkOutLineList != null && stkOutLineList.Count > 0)
                                            {
                                                //获取出库明细对应的出库主单guid
                                                StkOutGuids = stkOutLineList.Select(a => a.StkOutGuid).Distinct().ToArray();
                                                if (StkOutGuids != null && StkOutGuids.Length > 0)
                                                {
                                                    //获取出库明细对应的出库主单
                                                    stkOutList = this.GetList(new STK_OutParam() { StkOutGuids = StkOutGuids, Status = "Complete" });
                                                    if (stkOutList != null && stkOutList.Count > 0)
                                                    {
                                                        //获取有效的出库主单guid
                                                        EffStkOutGuids = stkOutList.Select(a => a.StkOutGuid).Distinct().ToArray();
                                                        //获取有效的出库明细集合
                                                        effStkOutLineList = stkOutLineList.Where(a => EffStkOutGuids.Contains(a.StkOutGuid)).ToList();
                                                        foreach (ORD_SalesOrderLineResult orderLineResult in saleLineList)
                                                        {
                                                            //汇总有效的出库明细的出库数量
                                                            int? qty = effStkOutLineList.Where(a => a.SourceBillLineGuid == orderLineResult.SOLineGuid).Sum(a => a.Qty).ToInt32();
                                                            orderLineResult.StkOutQty=qty;
                                                        }
                                                    }
                                                }
                                            }
                                            saleOrderLineBLL.UpdateOrInsertList(saleLineList);
                                            SOGuids=saleLineList.Select(a=>a.SOGuid).Distinct().ToArray();
                                            foreach(Guid soguid in SOGuids)
                                            {
                                               saleOrderBLL.UpdateStatus(new ORD_SalesOrderParam(){SOGuid=soguid});
                                            }
                                        }
                                    }
                                    #endregion
                                }
                                else if (outResult.BillType == "POR_OUT")
                                {
                                    #region 回写采购退货单的出库数量和出库状态
                                    //获取出库明细对应的退货明细guid
                                    PRLineGuids = outLineList.Select(a => a.SourceBillLineGuid).Distinct().ToArray();
                                    if (PRLineGuids != null && PRLineGuids.Length > 0)
                                    {
                                        //获取出库明细对应的退货明细
                                        purReturnLineList = purReturnLineBLL.GetList(new ORD_PurchaseReturnLineParam() { PRLineGuids = PRLineGuids });
                                        if (purReturnLineList != null && purReturnLineList.Count > 0)
                                        {
                                            //获取出库明细对应的退货明细关联关联的出库明细
                                            stkOutLineList = outLineBLL.GetList(new STK_OutLineParam() { SourceBillLineGuids = PRLineGuids });
                                            if (stkOutLineList != null && stkOutLineList.Count > 0)
                                            {
                                                //获取出库明细对应的出库主单guid
                                                StkOutGuids = stkOutLineList.Select(a => a.StkOutGuid).Distinct().ToArray();
                                                if (StkOutGuids != null && StkOutGuids.Length > 0)
                                                {
                                                    //获取出库明细对应的出库主单
                                                    stkOutList = this.GetList(new STK_OutParam() { StkOutGuids = StkOutGuids, Status = "Complete" });
                                                    if (stkOutList != null && stkOutList.Count > 0)
                                                    {
                                                        //获取有效的出库主单guid
                                                        EffStkOutGuids = stkOutList.Select(a => a.StkOutGuid).Distinct().ToArray();
                                                        //获取有效的出库明细集合
                                                        effStkOutLineList = stkOutLineList.Where(a => EffStkOutGuids.Contains(a.StkOutGuid)).ToList();
                                                        foreach (ORD_PurchaseReturnLineResult purReturnLineResult in purReturnLineList)
                                                        {
                                                            //汇总有效的出库明细的出库数量
                                                            int? qty = effStkOutLineList.Where(a => a.SourceBillLineGuid == purReturnLineResult.PRLineGuid).Sum(a => a.Qty).ToInt32();
                                                            purReturnLineResult.StkOutQty = qty;
                                                        }
                                                    }
                                                }
                                            }
                                            purReturnLineBLL.UpdateOrInsertList(purReturnLineList);
                                            PRGuids = purReturnLineList.Select(a => a.PRGuid).Distinct().ToArray();
                                            foreach (Guid prguid in PRGuids)
                                            {
                                               purReturnBLL.UpdateStatus(new ORD_PurchaseReturnParam() { PRGuid = prguid });
                                            }
                                        }
                                    }
                                    #endregion
                                }
                                else if (outResult.BillType == "ZX_OUT")
                                { 
                                
                                }
                                #endregion
                                #endregion


                            }
                        }
                    }

                }
                else
                {
                    throw new WarnException("要审核的出库单在系统中不存在！");
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
            return auditFlag;
        }
        /// <summary>
        /// 分页集合
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public PageList<STK_OutResult> GetPageList(STK_OutParam param)
        {
            this.CheckSession();
            PageList<STK_OutResult> ret = new PageList<STK_OutResult>();
            try
            {
                List<Field> field = new List<Field>()
                 {
                    Field.All
                 };
                ret = this.SelectList<STK_OutResult>(param.PageIndex.GetValueOrDefault(1), param.PageSize.GetValueOrDefault(50), field, GetWhereClip(param), STK_Out._.CreatedTime.Desc);
                if (ret.ResultList != null && ret.ResultList.Count > 0)
                {
                    HR_OrgBLL orgBLL = new HR_OrgBLL();
                    orgBLL.SessionInfo = this.SessionInfo;
                    HR_OrgParam orgParam = new HR_OrgParam();
                    orgParam.OrgIDs = ret.ResultList.Where(a => a.OperDeptID != null).Select(a => a.OperOrgID).Distinct().ToArray();
                    List<HR_OrgResult> orgList = orgBLL.GetOrgTree(orgParam);

                    HR_DepartmentBLL deptBLL = new HR_DepartmentBLL();
                    deptBLL.SessionInfo = this.SessionInfo;
                    HR_DepartmentParam deptParam = new HR_DepartmentParam();
                    deptParam.DeptIDs = ret.ResultList.Where(a => a.OperDeptID != null).Select(a => a.OperDeptID).Distinct().ToArray();
                    List<HR_DepartmentResult> deptList = deptBLL.GetDeptList(deptParam);

                    foreach (STK_OutResult orderResult in ret.ResultList)
                    {
                        if (orderResult.OperOrgID != null)
                            orderResult.OperOrgName = orgList.FirstOrDefault(a => a.OrgID == orderResult.OperOrgID).OrgName;
                        if (orderResult.OperDeptID != null)
                            orderResult.OperDeptName = deptList.FirstOrDefault(a => a.DeptID == orderResult.OperDeptID).DeptName;
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
        public List<STK_OutResult> GetList(STK_OutParam param)
        {
            this.CheckSession();
            List<STK_OutResult> ret = new List<STK_OutResult>();
            try
            {
                WhereClip whereClip = GetWhereClip(param);
                ret = this.SelectList<STK_OutResult>(whereClip, STK_Out._.CreatedTime.Desc);
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
        /// 查询条件
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        WhereClip GetWhereClip(STK_OutParam param)
        {
            this.CheckSession();
            WhereClip where = STK_Out._.IsDeleted == 0;
            if (param.StkOutGuid != null) where = where && STK_Out._.StkOutGuid == param.StkOutGuid;
            if (param.StkOutGuids != null && param.StkOutGuids.Length > 0) where = where && STK_Out._.StkOutGuid.In(param.StkOutGuids);
            if (!string.IsNullOrEmpty(param.BillNo)) where = where && STK_Out._.BillNo.Like("%" + param.BillNo + "%");
            if (!string.IsNullOrEmpty(param.BillType)) where = where && STK_Out._.BillType == param.BillType;
            if (param.SourceBillGuid != null) where = where && STK_Out._.SourceBillGuid == param.SourceBillGuid;
            if (!string.IsNullOrEmpty(param.SourceBillNo)) where = where && STK_Out._.SourceBillNo.Like("%" + param.SourceBillNo + "%");
            if (!string.IsNullOrEmpty(param.Status)) where = where && STK_Out._.Status == param.Status;
            return where;
        }

        /// <summary>
        /// 添加和新增修改
        /// </summary>
        /// <param name="param">新增或修改的实体</param>
        /// <returns></returns>
        public WCFAddUpdateResult AddOrUpdate(STK_OutResult param)
        {
            this.CheckSession();
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            try
            {
                int affect = 0;
                #region 判断
                if (string.IsNullOrEmpty(param.BillType)) throw new WarnException("请指定出库类型！");
                if (string.IsNullOrEmpty(param.Currency)) throw new WarnException("请选择币种！");
                if (param.StkOutLineList == null) throw new WarnException("请填写出库明细！");
                string msg = string.Empty;

                foreach (STK_OutLineResult rst in param.StkOutLineList)
                {
                    if (string.IsNullOrEmpty(rst.Model))
                    {
                        msg = "请填写出库明细的型号！";
                        break;
                    }
                    if (rst.Qty <= 0)
                    {
                        msg = "请填写出库明细的数量！";
                    }

                }
                #endregion
                List<STK_OutLineResult> orderLineList = param.StkOutLineList;

                #region 系统默认值
                if (param.StkOutGuid.ToGuid() != Guid.Empty)
                {
                    WhereClip where = STK_Out._.StkOutGuid == param.StkOutGuid;
                    param.UpdatedEmpID = this.SessionInfo.UserID;
                    param.UpdatedEmpName = this.SessionInfo.UserName;
                    param.UpdatedTime = DateTime.Now;
                    affect = this.Update<STK_OutResult>(param, where);
                }
                else
                {
                    param.StkOutGuid = Guid.NewGuid();
                    Sys_CodeRulerBLL codeRulerBll = new Sys_CodeRulerBLL();
                    codeRulerBll.SessionInfo = this.SessionInfo;
                    param.BillNo = param.BillNo = codeRulerBll.GetBillNo(new Entity.UserModel.Sys.SYS_CredentialCodeRuleParam() { BillDate = DateTime.Today, TableName = "STK_Out" });
                    param.GCompanyID = this.SessionInfo.CompanyID;
                    param.Status = "New";
                    param.ApproveStatus = "待提交";
                    param.IsDeleted = false;
                    param.CreatedEmpID = this.SessionInfo.UserID;
                    param.CreatedEmpName = this.SessionInfo.UserName;
                    param.CreatedTime = DateTime.Now;
                    affect = this.Insert<STK_OutResult>(param);
                    param = this.Select<STK_OutResult>(new List<Field>() { STK_Out._.All }, STK_Out._.StkOutGuid == param.StkOutGuid);
                }
                foreach (STK_OutLineResult rst in orderLineList)
                {
                    if (rst.StkOutLineGuid.ToGuid() == Guid.Empty)
                    {
                        rst.StkOutLineGuid = Guid.NewGuid();
                        rst.StkOutGuid = param.StkOutGuid;
                        rst.GCompanyID = this.SessionInfo.CompanyID;
                        rst.CreatedEmpID = this.SessionInfo.UserID;
                        rst.CreatedEmpName = this.SessionInfo.UserName;
                        rst.CreatedTime = DateTime.Now;
                        rst.IsDeleted = false;
                    }
                    else
                    {
                        rst.UpdatedEmpID = this.SessionInfo.UserID;
                        rst.UpdatedEmpName = this.SessionInfo.UserName;
                        rst.UpdatedTime = DateTime.Now;
                    }
                }

                this.BatchInsertOrUpdate<STK_OutLineResult>(orderLineList);
                this.BatchExecute();
                #region 设置返回值

                ret.KeyGuid = param.StkOutGuid;
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
        /// 获取一条信息记录
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public STK_OutResult GetInfo(STK_OutParam param)
        {
            this.CheckSession();
            STK_OutResult rst = new STK_OutResult();
            #region 判断
            if (param.StkOutGuid == null) throw new WarnException("请指定出库单GUID！");
            #endregion
            #region 获取实体

            rst = this.Select<STK_OutResult>(GetWhereClip(param));

            if (rst != null)
            {
                rst.StkOutLineList = this.SelectList<STK_OutLineResult>(STK_OutLine._.StkOutGuid == rst.StkOutGuid);
                rst.HR_DepartmentResult = this.Select<HR_DepartmentResult>(new List<Field>() { HR_Department._.DeptID, HR_Department._.DeptName }, HR_Department._.DeptID == rst.OperDeptID);
            }
            #endregion
            return rst;
        }

        /// <summary>
        /// 删除实体
        /// </summary>
        /// <param name="param">删除条件实体</param>
        /// <returns></returns>
        public WCFAddUpdateResult DelInfo(STK_OutParam param)
        {
            this.CheckSession();
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            int affect = 0;
            try
            {
                #region 判断
                if (param.StkOutGuid == null) throw new WarnException("请指定要删除的出库单GUID！");
                #endregion
                WhereClip whereClip = GetWhereClip(param);
                STK_OutResult info = new STK_OutResult();
                info.IsDeleted = true;
                affect = this.Update<STK_OutResult>(info, whereClip);
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
