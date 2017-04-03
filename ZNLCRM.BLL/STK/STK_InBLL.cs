using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLCRM.Entity.UserModel.STK;
using ZNLFrame.Entity;
using MySoft.Data;
using ZNLCRM.Entity.DBModel;
using ZNLCRM.BLL.Sys;
using ZNLCRM.Entity.UserModel.Common;
using ZNLCRM.Entity.UserModel.HR;
using ZNLCRM.BLL.HR;
using ZNLCRM.Utility;
using ZNLCRM.BLL.PPM;
using ZNLCRM.Entity.UserModel.PPM;
using ZNLCRM.BLL.SPM;
using ZNLCRM.Entity.UserModel.SPM;
using ZNLCRM.Entity.UserModel.WF;

namespace ZNLCRM.BLL.STK
{
    public class STK_InBLL:BaseBLL
    {
        public WCFAddUpdateResult SubmitOrAuditBill(AuditBillParam param)
        {
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            if (param.OldBillStatus.ToStringHasNull().ToLower() == "new" && param.NewBillStatus.ToStringHasNull().ToLower() == "approve"
                || param.OldBillStatus.ToStringHasNull().ToLower() == "new" && param.NewBillStatus.ToStringHasNull().ToLower() == "complete")
            {
                SubmitStkInBill(new STK_InParam() { StkInGuid = param.SourceBillGuid });
            }
            if (param.NewBillStatus.ToStringHasNull().ToLower() == "complete")
            {
                AuditStkInBill(new STK_InParam() { StkInGuid = param.SourceBillGuid });
            }
            
            return ret;
        }
        public bool SubmitStkInBill(STK_InParam param)
        {
            this.CheckSession();
            bool submitFlag = true;
            try
            {
                STK_InResult inResult = this.GetInfo(param);
                if (inResult != null)
                {
                    #region  更新关联单据的相关数据（回写）和状态
                    //入库单关联的入库明细
                    List<STK_InLineResult> inLineList = inResult.StkInLineList;
                    if (inLineList != null && inLineList.Count > 0)
                    {
                        #region 定义相关变量(可重复使用)
                        #region 申明逻辑层变量
                        ORD_PurchaseOrderLineBLL purLineBLL = new ORD_PurchaseOrderLineBLL();
                        purLineBLL.SessionInfo = this.SessionInfo;
                        ORD_PurchaseOrderBLL purOrderBLL = new ORD_PurchaseOrderBLL();
                        purOrderBLL.SessionInfo = this.SessionInfo;
                        ORD_SalesReturnBLL returnBLL = new ORD_SalesReturnBLL();
                        returnBLL.SessionInfo = this.SessionInfo;
                        ORD_SalesReturnLineBLL returnLineBLL = new ORD_SalesReturnLineBLL();
                        returnLineBLL.SessionInfo = this.SessionInfo;
                        STK_InLineBLL stkInLineBLL = new STK_InLineBLL();
                        stkInLineBLL.SessionInfo = this.SessionInfo;
                        STK_InBLL inBLL = new STK_InBLL();
                        inBLL.SessionInfo = this.SessionInfo;
                        #endregion
                        #region 初始化变量
                        Guid? POGuid = null;
                        Guid?[] POLineGuids = null;
                        Guid? SRGuid = null;
                        Guid?[] SRLineGuids = null;
                        Guid?[] StkInGuids = null;
                        Guid?[] effInGuids = null;
                        List<ORD_PurchaseOrderLineResult> purLineList = null;
                        List<ORD_SalesReturnLineResult> returnLineList = null;
                        List<STK_InResult> inList = null;
                        List<STK_InLineResult> linkInLineList = null;
                        List<STK_InLineResult> effInLineList = null;
                        #endregion
                        #endregion
                        if (inResult.BillType == "PO_IN")
                        {
                            #region 更新采购明细的占有数量和采购主单的占有状态
                            POGuid = inResult.SourceBillGuid;//关联的采购主单
                            POLineGuids = inLineList.Where(a => a.SourceBillLineGuid != null).Select(a => a.SourceBillLineGuid).Distinct().ToArray();//关联的采购明细ID集合
                            if (POLineGuids != null && POLineGuids.Length > 0)
                            {
                                purLineList = purLineBLL.GetList(new ORD_PurchaseOrderLineParam() { POLineGuids = POLineGuids });//采购明细
                                linkInLineList = stkInLineBLL.GetList(new STK_InLineParam() { SourceBillLineGuids = POLineGuids });//采购明细所关联的入库明细
                                StkInGuids = linkInLineList.Select(a => a.StkInGuid).Distinct().ToArray();
                                if (StkInGuids != null && StkInGuids.Length > 0)
                                {
                                    //采购明细所关联的入库明细对应的入库主单
                                    inList = this.GetList(new STK_InParam() { StkInGuids = StkInGuids, StatusArr = new string[]{ "Complete","Approve"} });
                                    if (inList != null && inList.Count > 0)
                                    {
                                        effInGuids = inList.Select(a => a.StkInGuid).Distinct().ToArray();
                                        effInLineList = linkInLineList.Where(a => effInGuids.Contains(a.StkInGuid)).ToList();
                                        foreach (ORD_PurchaseOrderLineResult purLineResult in purLineList)
                                        {
                                            int? qty = effInLineList.Where(a => a.SourceBillLineGuid == purLineResult.POLineGuid).Sum(a => a.Qty.ToInt32());
                                            purLineResult.StkInOccQty = qty;
                                        }
                                    }
                                }
                                purLineBLL.UpdateOrInsertList(purLineList);
                                purOrderBLL.UpdateStatus(new ORD_PurchaseOrderParam() { POGuid = POGuid });
                            }
                            #endregion
                        }
                        else if (inResult.BillType == "SOR_IN")
                        {
                            #region 更新销售退货明细的入库占有数量和退货主单的占有状态
                            //关联的销售退货主单
                            SRGuid = inResult.SourceBillGuid;
                            //关联的销售退货明细ID集合
                            SRLineGuids = inLineList.Where(a => a.SourceBillLineGuid != null).Select(a => a.SourceBillLineGuid).Distinct().ToArray();
                            if (SRLineGuids != null && SRLineGuids.Length > 0)
                            {
                                //退货明细
                                returnLineList = returnLineBLL.GetList(new ORD_SalesReturnLineParam() { SRLineGuids = SRLineGuids });

                                //退货明细所关联的入库明细
                                linkInLineList = stkInLineBLL.GetList(new STK_InLineParam() { SourceBillLineGuids = SRLineGuids });
                                StkInGuids = linkInLineList.Select(a => a.StkInGuid).Distinct().ToArray();
                                if (StkInGuids != null && StkInGuids.Length > 0)
                                {
                                    //退货明细所关联的入库明细对应的入库主单
                                    inList = this.GetList(new STK_InParam() { StkInGuids = StkInGuids, StatusArr = new string[] { "Complete", "Approve" } });
                                    if (inList != null && inList.Count > 0)
                                    {
                                        effInGuids = inList.Select(a => a.StkInGuid).Distinct().ToArray();
                                        effInLineList = linkInLineList.Where(a => effInGuids.Contains(a.StkInGuid)).ToList();
                                        foreach (ORD_SalesReturnLineResult returnLineResult in returnLineList)
                                        {
                                            int? qty = effInLineList.Where(a => a.SourceBillLineGuid == returnLineResult.SRLineGuid).Sum(a => a.Qty.ToInt32());
                                            returnLineResult.StkInOccQty = qty;
                                        }
                                    }
                                }
                                returnLineBLL.UpdateOrInsertList(returnLineList);
                            }
                            #endregion
                        }
                        else if (inResult.BillType == "ZX_IN")
                        { 
                                   
                        }
                    }
                    #endregion
                }
                else
                {
                    throw new WarnException("要提交的入库单在系统中不存在！");
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

        public bool AuditStkInBill(STK_InParam param)
        {
            bool auditFlag = true;
            try
            {
                STK_InResult inResult = this.GetInfo(param);;

                if (inResult != null)
                {
                    bool isAllowAudit = true;

                    if (inResult.ApproveStatus == "待提交")
                    {
                        isAllowAudit = false;
                        throw new WarnException("入库单当前状态为:【待提交】,请先提交！");
                    }
                    else if (inResult.ApproveStatus == "审核完成")
                    {
                        isAllowAudit = false;
                        throw new WarnException("入库单当前状态为:【审核完成】,禁止重复审核！");
                    }
                    if (isAllowAudit)
                    {

                        inResult.Status = "Complete";
                        inResult.ApproveStatus = "审核完成";
                        WCFAddUpdateResult ret = this.AddOrUpdate(inResult);
                        if (ret.KeyGuid.ToGuid() == Guid.Empty)
                        {
                            auditFlag = false;
                        }
                        else
                        { 
                            #region 定义相关变量(可重复使用)
                            STK_InLineBLL stkInLineBLL = new STK_InLineBLL();
                            stkInLineBLL.SessionInfo = this.SessionInfo;
                            STK_StockBLL stkStockBLL = new STK_StockBLL();
                            stkStockBLL.SessionInfo = this.SessionInfo;
                            STK_StockSheetBLL stkStockSheetBLL = new STK_StockSheetBLL();
                            stkStockSheetBLL.SessionInfo = this.SessionInfo;
                            STK_StockReserveBLL reserveBLL=new STK_StockReserveBLL ();
                            reserveBLL.SessionInfo=this.SessionInfo;

                            ORD_SalesOrderBLL saleOrderBLL=new ORD_SalesOrderBLL ();
                            saleOrderBLL.SessionInfo=this.SessionInfo;
                            ORD_SalesOrderLineBLL saleOrderLineBLL=new ORD_SalesOrderLineBLL();
                            saleOrderLineBLL.SessionInfo=this.SessionInfo;

                            ORD_PurchaseOrderBLL purOrderBLL=new ORD_PurchaseOrderBLL ();
                            purOrderBLL.SessionInfo=this.SessionInfo;
                            ORD_PurchaseOrderLineBLL purOrderLineBLL = new ORD_PurchaseOrderLineBLL();
                            purOrderLineBLL.SessionInfo = this.SessionInfo;

                            ORD_SalesReturnBLL returnBLL = new ORD_SalesReturnBLL();
                            returnBLL.SessionInfo = this.SessionInfo;
                            ORD_SalesReturnLineBLL returnLineBLL = new ORD_SalesReturnLineBLL();
                            returnLineBLL.SessionInfo = this.SessionInfo;
                            
                            Guid?[] _ItemCodes=null;
                            List<STK_InLineResult> stkInLineList = stkInLineBLL.GetList(new STK_InLineParam() { StkInGuid = inResult.StkInGuid });
                            #endregion
                            #region 形成库存，回写库存ID到入库明细，形成库存流水，预留库存 ,回写采购单，销售单的入库数量和入库状态
                            List<STK_StockResult> stkStockList = new List<STK_StockResult>();
                            List<STK_StockSheetResult> stkStockSheetList = new List<STK_StockSheetResult>();
                            if (stkInLineList != null && stkInLineList.Count > 0)
                            {
                                if(inResult.BillType == "SOR_IN")
                                {
                                   _ItemCodes =stkInLineList.Where(a=>a.ItemCode!=null).Select(a=>a.ItemCode).Distinct().ToArray();
                                    stkStockList=stkStockBLL.GetList(new STK_StockParam(){ItemCodes=_ItemCodes});
                                }
                                #region 形成库存，回写库存ID，形成流水
                                STK_StockResult stkStockResult = null;
                                STK_StockSheetResult stkStockSheetResult = null;
                                foreach (STK_InLineResult stkInLineResult in stkInLineList)
                                {
                                    
                                    //形成ItemCode,如果是采购入库则new一个实体，如果是销售退货入库则使用传递过来的退货明细的itemCode
                                    Guid? itemCode =null;
                                        
                                    #region 形成库存
                                    
                                    if (inResult.BillType == "PO_IN")//采购入库
                                    {
                                        itemCode=Guid.NewGuid();
                                        stkStockResult = new STK_StockResult();
                                        stkStockResult.BuyerID = stkInLineResult.BuyerID;
                                        stkStockResult.BuyerName = stkInLineResult.BuyerName;
                                        stkStockResult.POGuid = stkInLineResult.SourceBillGuid;
                                        stkStockResult.POBillNo=stkInLineResult.SourceBillNo;
                                        stkStockResult.POLineGuid=stkInLineResult.SourceBillLineGuid;
                                        stkStockResult.StkInGuid=inResult.StkInGuid;
                                        stkStockResult.StkInBillNo=inResult.BillNo;
                                        stkStockResult.StkInLineGuid=stkInLineResult.StkInLineGuid;
                                        stkStockResult.ItemCode = itemCode;
                                        stkStockResult.Model = stkInLineResult.Model;
                                        stkStockResult.Brand = stkInLineResult.Brand;
                                        stkStockResult.Batch = stkInLineResult.Batch;
                                        stkStockResult.Package = stkInLineResult.Package;
                                        stkStockResult.Quality = stkInLineResult.Quality;
                                        stkStockResult.MPQ = stkInLineResult.MPQ;
                                        stkStockResult.MarkCode = stkInLineResult.MarkCode;
                                        stkStockResult.Remark = stkInLineResult.Remark;
                                        stkStockResult.Warehouse = stkInLineResult.Warehouse;
                                        stkStockResult.Location = stkInLineResult.Location;
                                        stkStockResult.InvType = stkInLineResult.InvType;
                                        stkStockResult.InvQty = stkInLineResult.Qty;
                                        stkStockResult.BookedQty = 0;
                                        stkStockResult.UsableQty = stkInLineResult.Qty;
                                        stkStockResult.Unit = stkInLineResult.Unit;
                                        stkStockResult.Currency = stkInLineResult.Currency;
                                        stkStockResult.BuyPrice = stkInLineResult.CostPrice;
                                        stkStockResult.BuyPriceRMB = stkInLineResult.CostPrice * stkInLineResult.ExchangeRate;
                                        stkStockList.Add(stkStockResult);

                                        stkInLineResult.ItemCode = itemCode;//回写入库明细的库存ID
                                        
                                    }
                                    else if (inResult.BillType == "SOR_IN")//销售退货入库
                                    {
                                        itemCode=stkInLineResult.ItemCode;
                                        stkStockResult = stkStockList.FirstOrDefault(a => a.ItemCode == stkInLineResult.ItemCode);
                                        stkStockResult.InvQty += stkInLineResult.Qty;
                                        stkStockResult.UsableQty += stkInLineResult.Qty;
                                    }
                                    else if (inResult.BillType == "ZX_IN")
                                    {

                                    }
                                    #endregion

                                    #region 形成流水
                                    stkStockSheetResult = new STK_StockSheetResult();
                                    stkStockSheetResult.OperEmpID = stkInLineResult.BuyerID;
                                    stkStockSheetResult.OperEmpName = stkInLineResult.BuyerName;
                                    stkStockSheetResult.SSType = 1;
                                    stkStockSheetResult.SourceBillGuid = inResult.StkInGuid;
                                    stkStockSheetResult.SourceBillNo = inResult.BillNo;
                                    stkStockSheetResult.SourceBillLineGuid = stkInLineResult.StkInLineGuid;
                                    stkStockSheetResult.ItemCode = itemCode;
                                    stkStockSheetResult.Model = stkInLineResult.Model;
                                    stkStockSheetResult.Brand = stkInLineResult.Brand;
                                    stkStockSheetResult.Batch = stkInLineResult.Batch;
                                    stkStockSheetResult.Package = stkInLineResult.Package;
                                    stkStockSheetResult.Quality = stkInLineResult.Quality;
                                    stkStockSheetResult.MPQ = stkInLineResult.MPQ;
                                    stkStockSheetResult.MarkCode = stkInLineResult.MarkCode;
                                    stkStockSheetResult.Currency = stkInLineResult.Currency;
                                    stkStockSheetResult.FlowQty = stkInLineResult.Qty;
                                    stkStockSheetResult.FlowPrice = stkInLineResult.CostPrice;
                                    stkStockSheetResult.FlowAmount = stkInLineResult.Amount;
                                    stkStockSheetList.Add(stkStockSheetResult);
                                    #endregion
                                }
                                stkStockBLL.UpdateOrInsertList(stkStockList);
                                stkStockSheetBLL.UpdateOrInsertList(stkStockSheetList);
                                stkInLineBLL.UpdateOrInsertList(stkInLineList);
                                #endregion
                                #region 预留库存
                                if (inResult.BillType == "PO_IN")//采购入库
                                {
                                    //有关联销售的采购入库会有销售明细Guid
                                    List<STK_InLineResult> tempInLineList=  stkInLineList.Where(a => a.SOLineGuid != null).ToList();
                                    if(tempInLineList!=null && tempInLineList.Count>0)
                                    {  
                                           Guid?[] POLineGuids = tempInLineList.Select(a => a.SourceBillLineGuid).Distinct().ToArray();
                                           List<ORD_PurchaseOrderLineResult> purOrderLineList = purOrderLineBLL.GetList(new ORD_PurchaseOrderLineParam() { POLineGuids = POLineGuids });
                                           foreach(STK_InLineResult stkInLineResult in   tempInLineList)
                                           {
                                               //入库明细所对应的采购明细
                                               ORD_PurchaseOrderLineResult purOrderLineResult = purOrderLineList.FirstOrDefault(a => a.POLineGuid == stkInLineResult.SourceBillLineGuid);
                                               if (purOrderLineResult != null)
                                                {
                                                    //创建预留明细
                                                    STK_StockReserveResult reserveResult = new STK_StockReserveResult();
                                                    reserveResult.SourceBillGuid = purOrderLineResult.SOGuid;//销售单guid
                                                    reserveResult.SourceBillNo = purOrderLineResult.SOBillNo;//销售单编号
                                                    reserveResult.SourceBillLineGuid = purOrderLineResult.SOLineGuid;//销售明细guid
                                                    reserveResult.SourceBillType = "销售出库";
                                                    reserveResult.ReserveType = 1;//采购预留
                                                    reserveResult.OperType = false;//系统预留
                                                    reserveResult.StkInLineGuid = stkInLineResult.StkInLineGuid;// 入库明细guid
                                                    reserveResult.ItemCode = stkInLineResult.ItemCode;
                                                    reserveResult.OperFlag = true;//增加
                                                    reserveBLL.OperateReserve(reserveResult);

                                                }
                                           }
                                    }
                                }
                                #endregion
                                #region 回写关联单据的入库数量和入库状态
                                //入库单关联的入库明细
                                if (stkInLineList != null && stkInLineList.Count > 0)
                                {
                                    #region 定义相关变量(可重复使用)
                                    Guid?[] SOGuids = null;
                                    Guid?[] SOLineGuids = null;

                                    Guid? POGuid = null;
                                    Guid?[] POLineGuids = null;

                                    Guid? SRGuid = null;
                                    Guid?[] SRLineGuids = null;

                                    Guid?[] StkInGuids = null;
                                    Guid?[] effInGuids = null;

                                    List<ORD_SalesReturnLineResult> returnLineList = null;
                                    List<ORD_PurchaseOrderLineResult> purLineList = null;

                                    List<STK_InResult> inList = null;
                                    List<STK_InLineResult> linkInLineList = null;
                                    List<STK_InLineResult> effInLineList = null;
                                    #endregion
                                    if (inResult.BillType == "PO_IN")
                                    {
                                
                                        #region 更新采购明细的入库数量和采购主单的入库状态
                                        //关联的采购主单
                                        POGuid = inResult.SourceBillGuid;
                                        //关联的采购明细ID集合
                                        POLineGuids = stkInLineList.Where(a => a.SourceBillLineGuid != null).Select(a => a.SourceBillLineGuid).Distinct().ToArray();
                                        if (POLineGuids != null && POLineGuids.Length > 0)
                                        {
                                            //采购明细
                                            purLineList = purOrderLineBLL.GetList(new ORD_PurchaseOrderLineParam() { POLineGuids = POLineGuids });

                                            //采购明细所关联的入库明细
                                            linkInLineList = stkInLineBLL.GetList(new STK_InLineParam() { SourceBillLineGuids = POLineGuids });
                                            StkInGuids = linkInLineList.Select(a => a.StkInGuid).Distinct().ToArray();
                                            if (StkInGuids != null && StkInGuids.Length > 0)
                                            {
                                                //采购明细所关联的入库明细对应的入库主单
                                                inList = this.GetList(new STK_InParam() { StkInGuids = StkInGuids, Status = "Complete" });
                                                if (inList != null && inList.Count > 0)
                                                {
                                                    effInGuids = inList.Select(a => a.StkInGuid).Distinct().ToArray();
                                                    effInLineList = linkInLineList.Where(a => effInGuids.Contains(a.StkInGuid)).ToList();
                                                    foreach (ORD_PurchaseOrderLineResult purLineResult in purLineList)
                                                    {
                                                        int? qty = effInLineList.Where(a => a.SourceBillLineGuid == purLineResult.POLineGuid).Sum(a => a.Qty.ToInt32());
                                                        purLineResult.StkInQty = qty;
                                                    }
                                                }
                                            }
                                            purOrderLineBLL.UpdateOrInsertList(purLineList);
                                            purOrderBLL.UpdateStatus(new ORD_PurchaseOrderParam() { POGuid = POGuid });
                                        }
                                        #endregion
                                        #region 更新销售明细的入库数量和销售主单的入库状态
                                        
                                            List<STK_InLineResult> tempInLineList= stkInLineList.Where(a => a.SOLineGuid != null).ToList();
                                            if (tempInLineList != null)
                                            {
                                                //获取关联的销售明细ID集合
                                                SOLineGuids = tempInLineList.Select(a => a.SOLineGuid).Distinct().ToArray();
                                                List<ORD_SalesOrderLineResult> saleOrderLineList = saleOrderLineBLL.GetList(new ORD_SalesOrderLineParam() { SOLineGuids = SOLineGuids });
                                                //获取关联的销售明细所关联的入库明细
                                                linkInLineList = stkInLineBLL.GetList(new STK_InLineParam() { SOLineGuids = SOLineGuids });
                                                StkInGuids = linkInLineList.Select(a => a.StkInGuid).Distinct().ToArray();
                                                if (StkInGuids != null && StkInGuids.Length > 0)
                                                {
                                                    //销售明细所关联的入库明细对应的入库主单
                                                    inList = this.GetList(new STK_InParam() { StkInGuids = StkInGuids, Status = "Complete" });
                                                    if (inList != null && inList.Count > 0)
                                                    {
                                                        effInGuids = inList.Select(a => a.StkInGuid).Distinct().ToArray();
                                                        effInLineList = linkInLineList.Where(a => effInGuids.Contains(a.StkInGuid)).ToList();
                                                        foreach (ORD_SalesOrderLineResult saleLineResult in saleOrderLineList)
                                                        {
                                                            int? qty = effInLineList.Where(a => a.SOLineGuid == saleLineResult.SOLineGuid).Sum(a => a.Qty.ToInt32());
                                                            saleLineResult.StkInQty = qty;
                                                        }
                                                    }
                                                }
                                                saleOrderLineBLL.UpdateOrInsertList(saleOrderLineList);
                                                SOGuids = saleOrderLineList.Select(a => a.SOGuid).Distinct().ToArray();
                                                foreach (Guid soguid in SOGuids)
                                                {
                                                    saleOrderBLL.UpdateStatus(new ORD_SalesOrderParam() { SOGuid = soguid });
                                                }
                                            }
                                        #endregion 
                                    }
                                    else if (inResult.BillType == "SOR_IN")
                                    {
                                        #region 更新销售退货明细的入库数量和退货主单的入库状态
                                        //关联的销售退货主单
                                        SRGuid = inResult.SourceBillGuid;
                                        //关联的销售退货明细ID集合
                                        SRLineGuids = stkInLineList.Where(a => a.SourceBillLineGuid != null).Select(a => a.SourceBillLineGuid).Distinct().ToArray();
                                        if (SRLineGuids != null && SRLineGuids.Length > 0)
                                        {
                                            //退货明细
                                            returnLineList = returnLineBLL.GetList(new ORD_SalesReturnLineParam() { SRLineGuids = SRLineGuids });

                                            //退货明细所关联的入库明细
                                            linkInLineList = stkInLineBLL.GetList(new STK_InLineParam() { SourceBillLineGuids = SRLineGuids });
                                            StkInGuids = linkInLineList.Select(a => a.StkInGuid).Distinct().ToArray();
                                            if (StkInGuids != null && StkInGuids.Length > 0)
                                            {
                                                //退货明细所关联的入库明细对应的入库主单
                                                inList = this.GetList(new STK_InParam() { StkInGuids = StkInGuids, Status ="Complete"  });
                                                if (inList != null && inList.Count > 0)
                                                {
                                                    effInGuids = inList.Select(a => a.StkInGuid).Distinct().ToArray();
                                                    effInLineList = linkInLineList.Where(a => effInGuids.Contains(a.StkInGuid)).ToList();
                                                    foreach (ORD_SalesReturnLineResult returnLineResult in returnLineList)
                                                    {
                                                        int? qty = effInLineList.Where(a => a.SourceBillLineGuid == returnLineResult.SRLineGuid).Sum(a => a.Qty.ToInt32());
                                                        returnLineResult.StkInQty = qty;
                                                    }
                                                }
                                            }
                                            returnLineBLL.UpdateOrInsertList(returnLineList);
                                           
                                        }
                                        
                                        #endregion
                                    }
                                    else if (inResult.BillType == "ZX_IN")
                                    {

                                    }
                                }
                                #endregion
                            }
                            #endregion

                            

                        }
                    }

                }
                else
                {
                    throw new WarnException("要审核的采购单在系统中不存在！");
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
        public PageList<STK_InResult> GetPageList(STK_InParam param)
        {
            this.CheckSession();
            PageList<STK_InResult> ret = new PageList<STK_InResult>();
            try
            {
                List<Field> field = new List<Field>()
                 {
                    Field.All
                 };
                ret = this.SelectList<STK_InResult>(param.PageIndex.GetValueOrDefault(1), param.PageSize.GetValueOrDefault(50), field, GetWhereClip(param), STK_In._.CreatedTime.Desc);
                if (ret.ResultList != null && ret.ResultList.Count>0)
                {
                    HR_OrgBLL orgBLL = new HR_OrgBLL();
                    orgBLL.SessionInfo = this.SessionInfo;
                    HR_OrgParam orgParam = new HR_OrgParam();
                    orgParam.OrgIDs = ret.ResultList.Where(a => a.OperDeptID != null).Select(a => a.OperOrgID).Distinct().ToArray();
                    List<HR_OrgResult> orgList = orgBLL.GetOrgTree(orgParam);

                    HR_DepartmentBLL deptBLL = new HR_DepartmentBLL();
                    deptBLL.SessionInfo = this.SessionInfo;
                    HR_DepartmentParam deptParam = new HR_DepartmentParam();
                    deptParam.DeptIDs = ret.ResultList.Where(a=>a.OperDeptID!=null).Select(a => a.OperDeptID).Distinct().ToArray();
                    List<HR_DepartmentResult> deptList = deptBLL.GetDeptList(deptParam);

                    foreach (STK_InResult inResult in ret.ResultList)
                    {
                        if (inResult.OperOrgID!=null)
                        inResult.OperOrgName = orgList.FirstOrDefault(a => a.OrgID == inResult.OperOrgID).OrgName;
                        if (inResult.OperDeptID!=null)
                        inResult.OperDeptName = deptList.FirstOrDefault(a => a.DeptID == inResult.OperDeptID).DeptName;
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
        public List<STK_InResult> GetList(STK_InParam param)
        {
            this.CheckSession();
            List<STK_InResult> ret = new List<STK_InResult>();
            try
            {
                WhereClip whereClip = GetWhereClip(param);
                ret = this.SelectList<STK_InResult>(whereClip, STK_In._.CreatedTime.Desc);
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
        WhereClip GetWhereClip(STK_InParam param)
        {
            this.CheckSession();
            WhereClip where = STK_In._.IsDeleted == 0;
            if (param.StkInGuid != null) where = where && STK_In._.StkInGuid == param.StkInGuid;
            if (param.StkInGuids != null && param.StkInGuids.Length > 0) where = where && STK_In._.StkInGuid.In(param.StkInGuids);
            if (!string.IsNullOrEmpty(param.BillNo)) where = where && STK_In._.BillNo.Like("%" + param.BillNo + "%");
            if (!string.IsNullOrEmpty(param.BillType)) where = where && STK_In._.BillType == param.BillType;
            if (param.SourceBillGuid != null) where = where && STK_In._.SourceBillGuid== param.SourceBillGuid;
            if (!string.IsNullOrEmpty(param.SourceBillNo)) where = where && STK_In._.SourceBillNo.Like("%" + param.SourceBillNo + "%");
            if (!string.IsNullOrEmpty(param.Status)) where = where && STK_In._.Status == param.Status;
            if(param.StatusArr!=null && param.StatusArr.Length>0) where = where && STK_In._.Status.In( param.StatusArr);
            return where;
        }

        /// <summary>
        /// 添加和新增修改
        /// </summary>
        /// <param name="param">新增或修改的实体</param>
        /// <returns></returns>
        public WCFAddUpdateResult AddOrUpdate(STK_InResult param)
        {
            this.CheckSession();
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            try
            {
                int affect = 0;
                #region 判断
                if (string.IsNullOrEmpty(param.BillType )) throw new WarnException("请指定入库类型！");
                if (param.StkInLineList == null) throw new WarnException("请填写入库明细！");
                string msg = string.Empty;

                foreach (STK_InLineResult rst in param.StkInLineList)
                {
                    if (string.IsNullOrEmpty(rst.Model))
                    {
                        msg = "请填写入库明细的型号！";
                        break;
                    }
                    if (rst.Qty <= 0)
                    {
                        msg = "请填写入库明细的数量！";
                    }

                }
                #endregion
                List<STK_InLineResult> orderLineList = param.StkInLineList;

                #region 系统默认值
                if (param.StkInGuid != null)
                {
                    WhereClip where = STK_In._.StkInGuid == param.StkInGuid;
                    param.UpdatedEmpID = this.SessionInfo.UserID;
                    param.UpdatedEmpName = this.SessionInfo.UserName;
                    param.UpdatedTime = DateTime.Now;
                    affect = this.Update<STK_InResult>(param, where);
                }
                else
                {
                    param.StkInGuid = Guid.NewGuid();
                    Sys_CodeRulerBLL codeRulerBll = new Sys_CodeRulerBLL();
                    codeRulerBll.SessionInfo = this.SessionInfo;
                    param.BillNo = param.BillNo = codeRulerBll.GetBillNo(new Entity.UserModel.Sys.SYS_CredentialCodeRuleParam() { BillDate = DateTime.Today, TableName = "STK_In" });
                    param.GCompanyID = this.SessionInfo.CompanyID;
                    param.Status = "New";
                    param.ApproveStatus = "待提交";
                    param.IsDeleted = false;
                    param.CreatedEmpID = this.SessionInfo.UserID;
                    param.CreatedEmpName = this.SessionInfo.UserName;
                    param.CreatedTime = DateTime.Now;
                    affect = this.Insert<STK_InResult>(param);
                    param = this.Select<STK_InResult>(new List<Field>() { STK_In._.All }, STK_In._.StkInGuid == param.StkInGuid);
                }
                foreach (STK_InLineResult rst in orderLineList)
                {
                    if (rst.StkInLineGuid ==null)
                    {
                        rst.StkInLineGuid = Guid.NewGuid();
                        rst.StkInGuid = param.StkInGuid;
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

                this.BatchInsertOrUpdate<STK_InLineResult>(orderLineList);
                this.BatchExecute();
                #region 设置返回值
               
                ret.KeyGuid = param.StkInGuid;
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
        public STK_InResult GetInfo(STK_InParam param)
        {
            this.CheckSession();
            STK_InResult rst = new STK_InResult();
            #region 判断
            if (param.StkInGuid == null) throw new WarnException("请指定入库单GUID！");
            #endregion
            #region 获取实体

            rst = this.Select<STK_InResult>(GetWhereClip(param));
            
            if (rst != null)
            {
                rst.StkInLineList = this.SelectList<STK_InLineResult>(STK_InLine._.StkInGuid == rst.StkInGuid);
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
        public WCFAddUpdateResult DelInfo(STK_InParam param)
        {
            this.CheckSession();
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            int affect = 0;
            try
            {
                #region 判断
                if (param.StkInGuid == null) throw new WarnException("请指定要删除的入库单GUID！");
                #endregion
                WhereClip whereClip = GetWhereClip(param);
                STK_InResult info = new STK_InResult();
                info.IsDeleted = true;
                affect = this.Update<STK_InResult>(info, whereClip);
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
        public bool UpdateStatus(STK_InParam param)
        {
            bool flag = true;
            try
            {
                STK_InResult inResult = this.GetInfo(param);
                if (inResult != null)
                {
                    if (inResult.StkInLineList != null && inResult.StkInLineList.Count > 0)
                    {
                        //取消的明细需要排除
                        List<STK_InLineResult> lineList = inResult.StkInLineList;
                        if (lineList != null && lineList.Count > 0)
                        {
                            int? qty = lineList.Where(a => a.Qty != null).Select(a => a.Qty).Sum();
                            int? stkOutQty = lineList.Where(a => a.StkOutQty != null).Select(a => a.StkOutQty).Sum();
                           
                            if (stkOutQty == 0)
                                inResult.StkOutStatus = "待出库";
                            else if (stkOutQty >= qty)
                                inResult.StkOutStatus = "全部出库";
                            else
                                inResult.StkOutStatus = "部分出库";
                            this.AddOrUpdate(inResult);
                        }
                    }
                }
            }
            catch (WarnException exp)
            {
                flag = false;
                throw exp;
            }
            catch (System.Exception exp)
            {
                flag = false;
                LogInfoBLL.WriteLog(this.SessionInfo, exp);
                throw exp;
            }
            return flag;
        }
    }
}
