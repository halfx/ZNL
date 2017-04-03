using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLCRM.Entity.UserModel.PPM;
using ZNLFrame.Entity;
using MySoft.Data;
using ZNLCRM.BLL.Sys;
using ZNLCRM.Entity.DBModel;
using ZNLCRM.Entity.UserModel.Common;
using ZNLCRM.Entity.UserModel.HR;
using ZNLCRM.BLL.HR;
using ZNLCRM.BLL.SPM;
using ZNLCRM.Entity.UserModel.SPM;
using ZNLCRM.Utility;
using System.Data;

namespace ZNLCRM.BLL.PPM
{
    public  class ORD_PurchaseOrderBLL:BaseBLL
    {
        public bool SubmitPurchaseOrderBill(ORD_PurchaseOrderParam param)
        {
            this.CheckSession();
            bool submitFlag = true;
            try
            {
                ORD_PurchaseOrderResult orderResult = this.GetInfo(param);

                if (orderResult != null)
                {
                    #region 判断是否可以提交

                    bool isAllowSubmit = true;

                    if (orderResult.ApproveStatus == "待审核")
                    {
                        isAllowSubmit = false;
                        throw new WarnException("采购单当前状态为:【已提交,待审核】,禁止重复提交！");
                    }
                    else if (orderResult.ApproveStatus == "审核完成")
                    {
                        isAllowSubmit = false;
                        throw new WarnException("采购单当前状态为:【审核完成】,撤单后才可以再次提交！");
                    }
                    if (isAllowSubmit)
                    {
                        orderResult.Status = "Approve";
                        orderResult.ApproveStatus = "待审核";
                        WCFAddUpdateResult ret = this.AddOrUpdate(orderResult);
                        if (ret.KeyGuid.ToGuid() == Guid.Empty)
                            submitFlag = false;
                    }


                    #endregion
                }
                else
                {
                    throw new WarnException("要提交的采购单在系统中不存在！");
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

        public bool AuditPurchaseOrderBill(ORD_PurchaseOrderParam param)
        {
            bool auditFlag = true;
            try
            {
                ORD_PurchaseOrderResult orderResult = this.GetInfo(param);

                if (orderResult != null)
                {
                    bool isAllowAudit = true;

                    if (orderResult.ApproveStatus == "待提交")
                    {
                        isAllowAudit = false;
                        throw new WarnException("采购单当前状态为:【待提交】,请先提交！");
                    }
                    else if (orderResult.ApproveStatus == "审核完成")
                    {
                        isAllowAudit = false;
                        throw new WarnException("采购单当前状态为:【审核完成】,禁止重复审核！");
                    }
                    if (isAllowAudit)
                    {
                      
                        orderResult.Status = "Complete";
                        orderResult.ApproveStatus = "审核完成";
                        WCFAddUpdateResult ret = this.AddOrUpdate(orderResult);
                        if (ret.KeyGuid.ToGuid() == Guid.Empty)
                        {
                            auditFlag = false;
                        }
                        else
                        {
                            #region  更新关联单据的相关数据（回写）和状态
                            //采购单关联的采购明细
                            List<ORD_PurchaseOrderLineResult> purLineList = orderResult.OrderLineList;
                            if (purLineList != null && purLineList.Count > 0)
                            {
                                #region 定义相关变量(可重复使用)
                                ORD_SalesOrderBLL saleOrderBLL=new ORD_SalesOrderBLL ();
                                saleOrderBLL.SessionInfo=this.SessionInfo;
                                ORD_SalesOrderLineBLL saleLineBLL = new ORD_SalesOrderLineBLL();
                                saleLineBLL.SessionInfo = this.SessionInfo;
                                ORD_PurchaseNoticeBLL noticeBLL = new ORD_PurchaseNoticeBLL();
                                noticeBLL.SessionInfo = this.SessionInfo;
                                ORD_PurchaseOrderLineBLL purLineBLL = new ORD_PurchaseOrderLineBLL();
                                purLineBLL.SessionInfo = this.SessionInfo;
                                Guid?[] SOGuids=null;
                                Guid?[] SOLineGuids = null;
                                Guid?[] NoticeGuids=null;
                                Guid?[] POGuids=null;
                                Guid?[] effPOGuids = null;
                                List<ORD_SalesOrderLineResult> saleLineList =null;
                                List<ORD_PurchaseNoticeResult> noticeResultList =null;
                                List<ORD_PurchaseOrderResult> purOrderList =null;
                                List<ORD_PurchaseOrderLineResult> linkPurLineList=null;
                                List<ORD_PurchaseOrderLineResult> effPurLineList = null;
                                
                                #endregion

                                #region 更新采购通知的采购数量
                                //获取关联的所有的采购通知guid
                                 NoticeGuids= purLineList.Where(a => a.NoticeGuid != Guid.Empty && a.IsCancel != true).Select(a => a.NoticeGuid).Distinct().ToArray();
                                //获取关联的所有的采购通知信息
                                noticeResultList= noticeBLL.GetList(new ORD_PurchaseNoticeParam(){NoticeGuids=NoticeGuids});
                                if (noticeResultList != null && noticeResultList.Count > 0)
                                {
                                    //采购单明细关联的采购通知所有关联的采购明细
                                    linkPurLineList = purLineBLL.GetList(new ORD_PurchaseOrderLineParam() { NoticeGuids = NoticeGuids, IsCancel = false });
                                    //获取采购单明细关联的POGuid
                                    POGuids = linkPurLineList.Select(a => a.POGuid).Distinct().ToArray();
                                    //获取所有关联的采购主单
                                    purOrderList = this.GetList(new ORD_PurchaseOrderParam() { POGuids = POGuids, Status = "Complete" });
                                    if (purOrderList != null && purOrderList.Count > 0)
                                    {
                                        effPOGuids = purOrderList.Select(a => a.POGuid).Distinct().ToArray();
                                        effPurLineList = linkPurLineList.Where(a => effPOGuids.Contains(a.POGuid)).ToList();
                                        foreach (ORD_PurchaseNoticeResult noticeResult in noticeResultList)
                                        {
                                            int? qty = effPurLineList.Where(a => a.NoticeGuid == noticeResult.NoticeGuid).Sum(a => a.Qty.ToInt32());
                                            noticeResult.PurchaseQty = qty;
                                        }
                                    }
                                    noticeBLL.UpdateOrInsertList(noticeResultList);
                                }
                                #endregion

                                #region 更新销售明细的采购数量
                                // 有关联销售同时未取消的采购明细
                                SOLineGuids = purLineList.Where(a => a.SOLineGuid != null && a.IsCancel != true).Select(a => a.SOLineGuid).Distinct().ToArray();
                                if (SOLineGuids != null && SOLineGuids.Length > 0)
                                {
                                    //采购明细关联的所有的销售明细(未取消)
                                    saleLineList = saleLineBLL.GetList(new ORD_SalesOrderLineParam() { SOLineGuids = SOLineGuids, IsCancel = false });
                                    if (saleLineList != null && saleLineList.Count > 0)
                                    {
                                        //销售明细所关联的采购明细（未取消）
                                        linkPurLineList= purLineBLL.GetList(new ORD_PurchaseOrderLineParam() { SOLineGuids = SOLineGuids, IsCancel = false });
                                        POGuids = linkPurLineList.Select(a => a.POGuid).Distinct().ToArray();
                                        if (POGuids != null && POGuids.Length > 0)
                                        {
                                            //销售明细所关联的采购明细对应的采购主单
                                            purOrderList = this.GetList(new ORD_PurchaseOrderParam() { POGuids = POGuids, Status = "Complete" });
                                            if (purOrderList != null && purOrderList.Count > 0)
                                            {
                                                effPOGuids = purOrderList.Select(a => a.POGuid).Distinct().ToArray();
                                                effPurLineList = linkPurLineList.Where(a => effPOGuids.Contains(a.POGuid)).ToList();
                                                foreach (ORD_SalesOrderLineResult saleLineResult in saleLineList)
                                                {
                                                    int? qty = effPurLineList.Where(a => a.SOLineGuid == saleLineResult.SOLineGuid).Sum(a => a.Qty.ToInt32());
                                                    saleLineResult.PurchaseQty = qty;
                                                }
                                            }
                                        }
                                        saleLineBLL.UpdateOrInsertList(saleLineList);
                                       SOGuids= saleLineList.Select(a=>a.SOGuid).Distinct().ToArray();
                                       foreach(Guid soguid in SOGuids)
                                       {
                                           saleOrderBLL.UpdateStatus(new ORD_SalesOrderParam() { SOGuid = soguid });
                                       }
                                     
                                       
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
        public PageList<ORD_PurchaseOrderResult> GetPageList(ORD_PurchaseOrderParam param)
        {
            this.CheckSession();
            PageList<ORD_PurchaseOrderResult> ret = new PageList<ORD_PurchaseOrderResult>();
            try
            {
                List<Field> field = new List<Field>()
                 {
                    Field.All
                 };
                ret = this.SelectList<ORD_PurchaseOrderResult>(param.PageIndex.GetValueOrDefault(1), param.PageSize.GetValueOrDefault(50), field, GetWhereClip(param), ORD_PurchaseOrder._.CreatedTime.Desc);
                if (ret.ResultList != null && ret.ResultList.Count>0)
                {
                    HR_OrgBLL orgBLL = new HR_OrgBLL();
                    orgBLL.SessionInfo = this.SessionInfo;
                    HR_OrgParam orgParam = new HR_OrgParam();
                    orgParam.OrgIDs = ret.ResultList.Where(a=>a.PurOrgID!=null).Select(a =>a.PurOrgID).Distinct().ToArray();
                    List<HR_OrgResult> orgList = orgBLL.GetOrgTree(orgParam);

                    HR_DepartmentBLL deptBLL = new HR_DepartmentBLL();
                    deptBLL.SessionInfo = this.SessionInfo;
                    HR_DepartmentParam deptParam = new HR_DepartmentParam();
                    deptParam.DeptIDs = ret.ResultList.Where(a=>a.PurDeptID!=null).Select(a => a.PurDeptID).Distinct().ToArray();
                    List<HR_DepartmentResult> deptList = deptBLL.GetDeptList(deptParam);
                    HR_Org findOrg = null;
                    HR_DepartmentResult findDept = null;

                    foreach (ORD_PurchaseOrderResult orderResult in ret.ResultList)
                    {
                        findOrg = orgList.Find(a => a.OrgID == orderResult.PurOrgID);
                        if (findOrg != null) orderResult.PurOrgName = findOrg.OrgName;
                        findDept = deptList.Find(a => a.DeptID == orderResult.PurDeptID);
                        if (findDept != null) orderResult.PurDeptName = findDept.DeptName;
                        orderResult.AllStatus =  orderResult.StkInStatus + "->" + orderResult.StkOutStatus;
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

        #region 获取彩购订单明细分页数据
        /// <summary>
        ///获取彩购订单明细分页数据 - 2015/03/10  W:LHQ
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public PageList<ORD_PurchaseOrderResult> GetDtlPageList(ORD_PurchaseOrderParam param)
        {
            this.CheckSession();
            PageList<ORD_PurchaseOrderResult> ret = new PageList<ORD_PurchaseOrderResult>();
            try
            {
                #region 表字段
                List<Field> field = new List<Field>()
                {
                    ORD_PurchaseOrderLine._.Model.At("b").As("Model"),
                    ORD_PurchaseOrderLine._.Brand.At("b").As("Brand")
                    ,
                    ORD_PurchaseOrderLine._.Package.At("b").As("Package"),
                    ORD_PurchaseOrderLine._.Batch.At("b").As("Batch")
                    ,
                    ORD_PurchaseOrderLine._.MarkCode.At("b").As("MarkCode"),
                    ORD_PurchaseOrderLine._.UnitPrice.At("b").As("UnitPrice")
                    ,
                    ORD_PurchaseOrderLine._.NTaxPrice.At("b").As("NTaxPrice"),
                    ORD_PurchaseOrderLine._.Qty.At("b").As("Qty")
                    ,
                    ORD_PurchaseOrderLine._.NeedDeliveryDate.At("b").As("NeedDeliveryDate"),
                    ORD_PurchaseOrderLine._.NeedPayAmtDate.At("b").As("NeedPayAmtDate")
                    ,
                    ORD_PurchaseOrderLine._.CreatedEmpName.At("b").As("CreatedEmpName"),
                    ORD_PurchaseOrderLine._.CreatedTime.At("b").As("CreatedTime")
                    ,
                    ORD_PurchaseOrderLine._.StkInQty.At("b").As("StkInQty"),
                    ORD_PurchaseOrderLine._.StkOutQty.At("b").As("StkOutQty")
                    ,
                    ORD_PurchaseOrderLine._.ReturnQty.At("b").As("ReturnQty")
                    ,ORD_PurchaseOrderLine._.POLineGuid.At("b").As("POLineGuid")                    ,
                    ORD_PurchaseOrder._.Status,
                    ORD_PurchaseOrder._.ApproveStatus,
                    ORD_PurchaseOrder._.IsCancel,
                    ORD_PurchaseOrder._.Amount
                    ,
                    ORD_PurchaseOrder._.BillNo,
                    ORD_PurchaseOrder._.PODate,
                    ORD_PurchaseOrder._.BuyerName,
                    ORD_PurchaseOrder._.Currency,
                    ORD_PurchaseOrder._.TaxRate,
                    ORD_PurchaseOrder._.POID,
                    ORD_PurchaseOrder._.POGuid
                }; 
                #endregion
                WhereClip onWhere = ORD_PurchaseOrder._.POGuid == ORD_PurchaseOrderLine._.POGuid.At("b") 
                    && ORD_PurchaseOrderLine._.IsDeleted.At("b") == 0;//明细删除状态
                 
                ret = this.SelectList<ORD_PurchaseOrderResult, ORD_PurchaseOrderLineResult>(JoinType.InnerJoin, onWhere, param.PageIndex.GetValueOrDefault(1), param.PageSize.GetValueOrDefault(50), field, GetWhereClip(param), ORD_PurchaseOrder._.CreatedTime.Desc,null,null);
                if (ret.ResultJoinList.Rows.Count > 0)
                {
                    ret.ResultJoinList.Columns.Add("IsCancelName");
                    ret.ResultJoinList.Columns.Add("All_Status");
                    string s = "";
                    int StkInQty = 0;
                    int StkOutQty = 0;
                    int Qty = 0;
                    int ReturnQty = 0;
                    for (int i = 0; i < ret.ResultJoinList.Rows.Count; i++)
                    {
                        if (ret.ResultJoinList.Rows[i]["IsCancel"].ToString() == "True")
                        {
                            ret.ResultJoinList.Rows[i]["IsCancelName"] = "是";
                        }
                        #region 状态判断
                        s = "";
                        StkInQty = ret.ResultJoinList.Rows[i]["StkInQty"].ToInt32();
                        StkOutQty = ret.ResultJoinList.Rows[i]["StkOutQty"].ToInt32();
                        Qty = ret.ResultJoinList.Rows[i]["Qty"].ToInt32();
                        ReturnQty = ret.ResultJoinList.Rows[i]["ReturnQty"].ToInt32();

                        if (StkInQty >= Qty)
                        {
                            s += "全部入库,";
                        }
                        if (StkInQty > 0 && StkInQty < Qty)
                        {
                            s += "部分入库,";
                        }
                        if (StkOutQty == Qty)
                        {
                            s += "全部出库,";
                        }
                        if (StkOutQty > 0 && StkOutQty < Qty)
                        {
                            s += "部分出库,";
                        }
                        if (StkInQty == 0 && Qty > 0)
                        {
                            s += "未入库,";
                        }
                        if (StkOutQty == 0 && Qty > 0)
                        {
                            s += "待出库,";
                        }
                        if (ReturnQty == 0 && StkInQty > 0)
                        {
                            s += "未退货";
                        }
                        if (ReturnQty > 0 && ReturnQty < Qty)
                        {
                            s += "部分退货";
                        }
                        if (ReturnQty >= Qty)
                        {
                            s += "全部退货";
                        }
                        ret.ResultJoinList.Rows[i]["All_Status"] = s; 
                        #endregion
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
        #endregion

        /// <summary>
        /// 获取集合
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public List<ORD_PurchaseOrderResult> GetList(ORD_PurchaseOrderParam param)
        {
            this.CheckSession();
            List<ORD_PurchaseOrderResult> ret = new List<ORD_PurchaseOrderResult>();
            try
            {
                WhereClip whereClip = GetWhereClip(param);
                ret = this.SelectList<ORD_PurchaseOrderResult>(whereClip, ORD_PurchaseOrder._.CreatedTime.Desc);
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
        WhereClip GetWhereClip(ORD_PurchaseOrderParam param)
        {
            this.CheckSession();
            WhereClip where = ORD_PurchaseOrder._.IsDeleted == 0;
            if (param.POID > 0) where = where && ORD_PurchaseOrder._.POID == param.POID;
            if (param.POGuid != null) where = where && ORD_PurchaseOrder._.POGuid == param.POGuid;
            if (!string.IsNullOrEmpty(param.BillNo)) where = where && ORD_PurchaseOrder._.BillNo.Like("%" + param.BillNo + "%");
            if (!string.IsNullOrEmpty(param.BillType)) where = where && ORD_PurchaseOrder._.BillType==param.BillType;
            if (!string.IsNullOrEmpty(param.SupplierName)) where = where && ORD_PurchaseOrder._.SupplierName.Like("%" + param.SupplierName + "%");
            if (!string.IsNullOrEmpty(param.Contact)) where = where && ORD_PurchaseOrder._.Contact.Like("%" + param.Contact + "%");
            if (!string.IsNullOrEmpty(param.ClearingForm)) where = where && ORD_PurchaseOrder._.ClearingForm.Like("%" + param.ClearingForm + "%");
            if (!string.IsNullOrEmpty(param.BuyerName)) where = where && ORD_PurchaseOrder._.BuyerName.Like("%" + param.BuyerName + "%");
            if (!string.IsNullOrEmpty(param.Status))
            {
                if (param.Status.ToLower() == "new")
                {
                    string[] tmpStatus = new String[2] {"", param.Status};
                    where = where && ORD_PurchaseOrder._.Status.IsNull("").In(tmpStatus);
                }
                else where = where && ORD_PurchaseOrder._.Status == param.Status;
            }
            if (!string.IsNullOrEmpty(param.Model)) where = where && ORD_PurchaseOrderLine._.Model.At("b").As("Model").Like("%" + param.Model + "%");//Model
            if (!string.IsNullOrEmpty(param.Brand)) where = where && ORD_PurchaseOrderLine._.Brand.At("b").As("Brand").Like("%" + param.Brand + "%");//Brand
            if (!string.IsNullOrEmpty(param.StkInStatus))
            {
                where = where && ORD_PurchaseOrder._.StkInStatus.Like("%" + param.StkInStatus + "%"); //InStatus
            }
            if (!string.IsNullOrEmpty(param.HasTaxRate))
            {
                if (param.HasTaxRate.ToLower() == "true") where = where && ORD_PurchaseOrder._.TaxRate > 0;
                else where = where && ORD_PurchaseOrder._.TaxRate.IsNull(0) <= 0;
            }
            if ( param.StartPODate != null && param.EndPODate != null)
                where = where && ORD_PurchaseOrder._.PODate.Between(param.StartPODate.GetValueOrDefault(),param.EndPODate.GetValueOrDefault());//采购日期
            if (param.StartNeedPayAmtDate != null && param.EndNeedPayAmtDate != null)
                where = where && ORD_PurchaseOrder._.PODate.Between(param.StartNeedPayAmtDate.GetValueOrDefault(), param.EndNeedPayAmtDate.GetValueOrDefault());//付款日期
            if (param.StartNeedDeliveryDate != null && param.EndNeedDeliveryDate != null)
                where = where && ORD_PurchaseOrder._.PODate.Between(param.StartNeedDeliveryDate.GetValueOrDefault(), param.EndNeedDeliveryDate.GetValueOrDefault());//到货日期
            
            if (param.StkInOccStatusArr != null && param.StkInOccStatusArr.Length > 0) where = where && ORD_PurchaseOrder._.StkInOccStatus.In(param.StkInOccStatusArr);
            return where;
        }

        /// <summary>
        /// 添加和新增修改
        /// </summary>
        /// <param name="param">新增或修改的实体</param>
        /// <returns></returns>
        public WCFAddUpdateResult AddOrUpdate(ORD_PurchaseOrderResult param)
        {
            this.CheckSession();
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            try
            {
                int affect = 0;
                #region 判断

                if (string.IsNullOrEmpty(param.SupplierName.Trim())) throw new WarnException("请指定公司名称！");
                if (string.IsNullOrEmpty(param.BuyerName)) throw new WarnException("请选择采购员！");
                if (string.IsNullOrEmpty(param.Currency)) throw new WarnException("请选择币种！");
                if (string.IsNullOrEmpty(param.ClearingForm)) throw new WarnException("请填写结算方式！");
                if (param.OrderLineList == null ) throw new WarnException("请填写采购明细！");
                string msg = string.Empty;

                foreach (ORD_PurchaseOrderLineResult rst in param.OrderLineList)
                {
                    if (string.IsNullOrEmpty(rst.Model))
                    {
                        msg = "请填写采购明细的型号！";
                        break;
                    }
                    if (rst.Qty <= 0)
                    {
                        msg = "请填写采购明细的数量！";
                    }

                }
                #endregion
                List<ORD_PurchaseOrderLineResult> orderLineList = param.OrderLineList;

                #region 系统默认值
                if (param.POGuid != null)
                {
                    WhereClip where = ORD_PurchaseOrder._.POGuid == param.POGuid;
                    param.UpdatedEmpID = this.SessionInfo.UserID;
                    param.UpdatedEmpName = this.SessionInfo.UserName;
                    param.UpdatedTime = DateTime.Now;
                    affect = this.Update<ORD_PurchaseOrderResult>(param, where);
                }
                else
                {
                    param.POGuid = Guid.NewGuid();
                    Sys_CodeRulerBLL codeRulerBll = new Sys_CodeRulerBLL();
                    codeRulerBll.SessionInfo = this.SessionInfo;
                    param.BillNo = param.BillNo = codeRulerBll.GetBillNo(new Entity.UserModel.Sys.SYS_CredentialCodeRuleParam() { BillDate = DateTime.Today, TableName = "ORD_PurchaseOrder" });
                    param.GCompanyID = this.SessionInfo.CompanyID;

                    param.StkInOccStatus = "待占有";
                    param.StkInStatus = "待入库";
                    param.StkOutStatus = "待出库";
                    param.ReturnOccStatus = "待占有";
                    param.ReturnStatus = "待退货";
                    param.PaymentStatus = "待收款";
                    
                    param.Status = "New";
                    param.ApproveStatus = "待提交";
                    param.IsDeleted = false;
                    param.CreatedEmpID = this.SessionInfo.UserID;
                    param.CreatedEmpName = this.SessionInfo.UserName;
                    param.CreatedTime = DateTime.Now;
                    affect = this.Insert<ORD_PurchaseOrderResult>(param);
                    param = this.Select<ORD_PurchaseOrderResult>(new List<Field>() { ORD_PurchaseOrder._.All }, ORD_PurchaseOrder._.POGuid == param.POGuid);
                }
                
                
                foreach (ORD_PurchaseOrderLineResult rst in orderLineList)
                {
                    if (rst.POLineGuid ==null)
                    {
                        rst.POLineGuid = Guid.NewGuid();
                        rst.POGuid = param.POGuid;
                        rst.GCompanyID = this.SessionInfo.CompanyID;
                        rst.CreatedEmpID = this.SessionInfo.UserID;
                        rst.CreatedEmpName = this.SessionInfo.UserName;
                        rst.CreatedTime = DateTime.Now;
                        rst.IsCancel = false;
                        rst.IsDeleted = false;
                        
                    }
                    else
                    {
                        rst.UpdatedEmpID = this.SessionInfo.UserID;
                        rst.UpdatedEmpName = this.SessionInfo.UserName;
                        rst.UpdatedTime = DateTime.Now;
                    }
                }
                this.BatchInsertOrUpdate<ORD_PurchaseOrderLineResult>(orderLineList);
                this.BatchExecute();

               
                #region 设置返回值
                ret.Key = param.POID.ToInt32();
                ret.KeyGuid = param.POGuid;
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
        public ORD_PurchaseOrderResult GetInfo(ORD_PurchaseOrderParam param)
        {
            this.CheckSession();
            ORD_PurchaseOrderResult rst = new ORD_PurchaseOrderResult();
            #region 判断
            if (param.POGuid == null) throw new WarnException("请指定采购单GUID！");
            #endregion
            #region 获取实体

            rst = this.Select<ORD_PurchaseOrderResult>(GetWhereClip(param));
            if (rst != null)
            {
                string[] statusArr = new string[]{rst.StkInStatus,rst.StkOutStatus,rst.ReturnStatus,rst.PaymentStatus};
                rst.AllStatus = string.Join(",", statusArr);
                ORD_PurchaseOrderLineBLL lineBLL = new ORD_PurchaseOrderLineBLL();
                lineBLL.SessionInfo = this.SessionInfo;
                rst.OrderLineList = lineBLL.GetList(new ORD_PurchaseOrderLineParam() { POGuid = rst.POGuid });
                Guid?[] NoticeGuids=  rst.OrderLineList.Where(a=>a.NoticeGuid!=null).Select(a => a.NoticeGuid).Distinct().ToArray();
                ORD_PurchaseNoticeBLL noticeBLl=new ORD_PurchaseNoticeBLL ();
                noticeBLl.SessionInfo=this.SessionInfo;
                ORD_PurchaseNoticeParam noticeParam=new ORD_PurchaseNoticeParam ();
                noticeParam.NoticeGuids=NoticeGuids;
                List<ORD_PurchaseNoticeResult> noticeList= noticeBLl.GetList(noticeParam);

                foreach (ORD_PurchaseOrderLineResult lineResult in rst.OrderLineList)
                {
                    ORD_PurchaseNoticeResult noticeResult = noticeList.FirstOrDefault(a => a.NoticeGuid == lineResult.NoticeGuid);
                    if (noticeResult != null)
                    {
                        lineResult.SOLineCode = noticeResult.SOLineCode;
                        lineResult.SOModel = noticeResult.Model;
                        lineResult.SOBrand = noticeResult.Brand;
                        lineResult.SOBatch = noticeResult.Batch;
                        lineResult.SOPackage = noticeResult.Package;
                        lineResult.SOQty = noticeResult.SaleQty;
                        lineResult.SONeedDeliveryDate = noticeResult.NeedDeliveryDate;
                    }
                }
                rst.HR_DepartmentResult = this.Select<HR_DepartmentResult>(new List<Field>() { HR_Department._.DeptID, HR_Department._.DeptName }, HR_Department._.DeptID == rst.PurDeptID);
                    
            }
            
               
            
            #endregion
            return rst;
        }

        /// <summary>
        /// 删除实体
        /// </summary>
        /// <param name="param">删除条件实体</param>
        /// <returns></returns>
        public WCFAddUpdateResult DelInfo(ORD_PurchaseOrderParam param)
        {
            this.CheckSession();
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            int affect = 0;
            try
            {
                #region 判断
                if (param.POGuid == null) throw new WarnException("请指定要删除的采购单ID！");
                #endregion
                WhereClip whereClip = GetWhereClip(param);
                ORD_PurchaseOrderResult info = new ORD_PurchaseOrderResult();
                info.IsDeleted = true;
                affect = this.Update<ORD_PurchaseOrderResult>(info, whereClip);
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
        /// 取消单据
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public WCFAddUpdateResult UpdateCancelFlag(ORD_PurchaseOrderResult param)
        {
            this.CheckSession();
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            #region 判断
            if (param.POGuid == null) throw new WarnException("请指定采购单GUID！");
            #endregion
            #region 判断是否存在采购主单
            ORD_PurchaseOrderResult info = new ORD_PurchaseOrderResult();
            info = this.Select<ORD_PurchaseOrderResult>(new List<Field>() { ORD_PurchaseOrder._.Status }
                            , ORD_PurchaseOrder._.GCompanyID == this.SessionInfo.CompanyID && ORD_PurchaseOrder._.POGuid == param.POGuid && ORD_PurchaseOrder._.IsDeleted == false
                            , ORD_PurchaseOrder._.POID.Asc);
            if (info == null)
            {
                throw new WarnException("采购单主单不存在！");
            }
            if (info.IsCancel.ToBooleanHasNull() && param.IsCancel.ToBooleanHasNull())
            {
                throw new WarnException("您已取消当前单据，不允许重复执行当前操作！");
            }
            if (info.IsCancel.ToBooleanHasNull() && !param.IsCancel.ToBooleanHasNull())
            {
                throw new WarnException("当前单据已属于正常状态，不允许重复执当前操作！");
            }
            #endregion
            if (param.IsCancel.ToBooleanHasNull())
            {
                #region 判断是否存在对应的入库单
                if (Exists<STK_In>(STK_In._.GCompanyID == this.SessionInfo.CompanyID && STK_In._.BillType == "PO_IN" && STK_In._.SourceBillGuid == param.POGuid && STK_In._.IsDeleted == false))
                {
                    throw new WarnException("存在对应的入库单，不允许取消当前单据！");
                }
                #endregion
                #region 更新采购单
                this.Update<ORD_PurchaseOrder>(new ORD_PurchaseOrder() { IsCancel = true, UpdatedTime = DateTime.Now, UpdatedEmpID = this.SessionInfo.UserID, UpdatedEmpName = this.SessionInfo.UserName }
                                            , ORD_PurchaseOrder._.POGuid == param.POGuid && ORD_PurchaseOrder._.GCompanyID == this.SessionInfo.CompanyID);
                #endregion
            }
            else//收回取消
            {
                #region 更新采购单
                this.Update<ORD_PurchaseOrder>(new ORD_PurchaseOrder() { IsCancel = false, UpdatedTime = DateTime.Now, UpdatedEmpID = this.SessionInfo.UserID, UpdatedEmpName = this.SessionInfo.UserName }
                                            , ORD_PurchaseOrder._.POGuid == param.POGuid && ORD_PurchaseOrder._.GCompanyID == this.SessionInfo.CompanyID);
                #endregion
            }
            ret.Key = 1;
            return ret;
        }

        public bool UpdateStatus(ORD_PurchaseOrderParam param)
        {
            bool flag = true;
            try
            {
                ORD_PurchaseOrderResult orderResult = this.GetInfo(param);
                if (orderResult != null)
                {
                    if (orderResult.OrderLineList != null && orderResult.OrderLineList.Count > 0)
                    {
                        //取消的明细需要排除
                        List<ORD_PurchaseOrderLineResult> lineList = orderResult.OrderLineList;
                        if (lineList != null && lineList.Count > 0)
                        {
                            int? qty = lineList.Where(a => a.Qty != null).Select(a => a.Qty).Sum();
                            int? stkInOccQty = lineList.Where(a => a.StkInOccQty != null).Select(a => a.StkInOccQty).Sum();
                            int? stkInQty = lineList.Where(a => a.StkInQty != null).Select(a => a.StkInQty).Sum();
                            int? stkOutQty = lineList.Where(a => a.StkOutQty != null).Select(a => a.StkOutQty).Sum();
                            int? returnOccQty=lineList.Where(a=>a.ReturnOccQty!=null).Select(a=>a.ReturnOccQty).Sum();
                            int? returnQty = lineList.Where(a => a.ReturnQty != null).Select(a => a.ReturnQty).Sum();
                            if (stkInOccQty == 0)
                                orderResult.StkInOccStatus = "待占有";
                            else if (stkInOccQty >= qty)
                                orderResult.StkInOccStatus = "全部占有";
                            else
                                orderResult.StkInOccStatus = "部分占有";
                            if (stkInQty == 0)
                                orderResult.StkInStatus = "待入库";
                            else if (stkInQty >= qty)
                                orderResult.StkInStatus = "全部入库";
                            else
                                orderResult.StkInStatus = "部分采购";
                            if (stkOutQty == 0)
                                orderResult.StkOutStatus = "待出库";
                            else if (stkOutQty >= qty)
                                orderResult.StkOutStatus = "全部出库";
                            else
                                orderResult.StkOutStatus = "部分出库";
                            if (returnOccQty == 0)
                                orderResult.ReturnOccStatus = "待占有";
                            else if (returnOccQty >= qty)
                                orderResult.ReturnOccStatus = "全部占有";
                            else
                                orderResult.ReturnOccStatus = "部分占有";
                            if (returnQty == 0)
                                orderResult.ReturnStatus = "待退货";
                            else if (returnQty >= qty)
                                orderResult.ReturnStatus = "全部退货";
                            else
                                orderResult.ReturnStatus = "部分退货";
                            this.AddOrUpdate(orderResult);
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
        /// <summary>
        /// 获取某供应商的最近料的历史单价
        /// </summary>
        /// <returns></returns>
        public List<ORD_PurchaseOrderLineResult> GetLastHisstoryPrice(ORD_PurchaseOrderParam param)
        {
            List<ORD_PurchaseOrderLineResult> ret = new List<ORD_PurchaseOrderLineResult>();
            #region 判断提供条件
            if (param.SupplierID.ToInt32() <= 0)
            {
                throw new WarnException("请指定供应商条件!");
            }
            if (param.ModelList == null || param.ModelList.Length <= 0)
            {
                throw new WarnException("请指定查找型号!");
            }
            #endregion
            #region 获取最近最大日期和明细ID
            WhereClip filterWhere = ORD_PurchaseOrder._.SupplierID == param.SupplierID && ORD_PurchaseOrder._.GCompanyID == this.SessionInfo.CompanyID && ORD_PurchaseOrder._.IsDeleted == false;
            filterWhere = filterWhere && ORD_PurchaseOrderLine._.Model.At("b").In(param.ModelList);
            if (param.BrandList != null && param.BrandList.Length > 0)
            {
                filterWhere = filterWhere && ORD_PurchaseOrderLine._.Brand.At("b").In(param.BrandList);
            }
            PageList<ORD_PurchaseOrderResult> lstPOTemp = new PageList<ORD_PurchaseOrderResult>();
            WhereClip onWhere = ORD_PurchaseOrder._.POGuid == ORD_PurchaseOrderLine._.POGuid.At("b");
            lstPOTemp = this.SelectList<ORD_PurchaseOrderResult, ORD_PurchaseOrderLine>(JoinType.InnerJoin, onWhere, 1, 5000
                , new List<Field>() { ORD_PurchaseOrder._.BillNo.Max().As("BillNo") }
                , filterWhere, null, null, null);
            #region 生成条件数组
            List<string> billNoList = new List<string>();
            DataTable tbl = lstPOTemp.ResultJoinList;
            if (tbl != null)
            {
                foreach (DataRow row in tbl.Rows)
                {
                    billNoList.Add(row["BillNo"].ToStringHasNull());
                }
            }
            if (billNoList.Count > 0)
            {
                filterWhere = filterWhere && ORD_PurchaseOrder._.BillNo.In(billNoList.ToArray());
            }
            #endregion
            #endregion
            #region 获取返回记录
            lstPOTemp = new PageList<ORD_PurchaseOrderResult>();
            lstPOTemp = this.SelectList<ORD_PurchaseOrderResult, ORD_PurchaseOrderLine>(JoinType.InnerJoin, onWhere, 1, 5000
                , new List<Field>() { ORD_PurchaseOrderLine._.Model.At("b").As("Model"),ORD_PurchaseOrderLine._.Brand.At("b").As("Brand")
                                    ,ORD_PurchaseOrderLine._.Package.At("b").As("Package"),ORD_PurchaseOrderLine._.Batch.At("b").As("Batch")
                                    ,ORD_PurchaseOrderLine._.MarkCode.At("b").As("MarkCode"),ORD_PurchaseOrderLine._.UnitPrice.At("b").As("UnitPrice")
                                    ,ORD_PurchaseOrderLine._.NTaxPrice.At("b").As("NTaxPrice")}
                , filterWhere, null, null, null);
            #endregion
            #region 返回值
            foreach (DataRow row in lstPOTemp.ResultJoinList.Rows)
            {
                ret.Add(new ORD_PurchaseOrderLineResult()
                {
                    Model = row["Model"].ToStringHasNull(),
                    Brand = row["Brand"].ToStringHasNull(),
                    Package = row["Package"].ToStringHasNull(),
                    MarkCode = row["Package"].ToStringHasNull(),
                    Batch = row["Batch"].ToStringHasNull(),
                    NTaxPrice = row["NTaxPrice"].ToDecimal(),
                    UnitPrice = row["NTaxPrice"].ToDecimal()
                });
            }
            #endregion
            return ret;
        }
    }
}
