using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLCRM.Entity.UserModel.PPM;
using ZNLFrame.Entity;
using ZNLCRM.Entity.UserModel.Common;
using ZNLCRM.BLL.SPM;
using ZNLCRM.BLL.STK;
using ZNLCRM.Utility;
using ZNLCRM.Entity.UserModel.STK;
using MySoft.Data;
using ZNLCRM.BLL.Sys;
using ZNLCRM.Entity.DBModel;
using ZNLCRM.BLL.HR;
using ZNLCRM.Entity.UserModel.HR;

namespace ZNLCRM.BLL.PPM
{
    [Serializable]
    public  class ORD_PurchaseReturnBLL:BaseBLL
    {
        public bool SubmitPurchaseReturnBill(ORD_PurchaseReturnParam param)
        {
            this.CheckSession();
            bool submitFlag = true;
            try
            {
                ORD_PurchaseReturnResult returnResult = this.GetInfo(param);

                if (returnResult != null)
                {
                    #region 判断是否可以提交

                    bool isAllowSubmit = true;

                    if (returnResult.ApproveStatus == "待审核")
                    {
                        isAllowSubmit = false;
                        throw new WarnException("采购退货单当前状态为:【已提交,待审核】,禁止重复提交！");
                    }
                    else if (returnResult.ApproveStatus == "审核完成")
                    {
                        isAllowSubmit = false;
                        throw new WarnException("采购退货单当前状态为:【审核完成】,撤单后才可以再次提交！");
                    }
                    if (isAllowSubmit)
                    {
                        returnResult.Status = "Approve";
                        returnResult.ApproveStatus = "待审核";
                        WCFAddUpdateResult ret = this.AddOrUpdate(returnResult);
                        if (ret.KeyGuid.ToGuid() == Guid.Empty)
                            submitFlag = false;
                        else
                        {

                            #region 定义相关变量
                            ORD_PurchaseOrderBLL purOrderBLL = new ORD_PurchaseOrderBLL();
                            purOrderBLL.SessionInfo = this.SessionInfo;
                            ORD_PurchaseOrderLineBLL purOrderLineBLL = new ORD_PurchaseOrderLineBLL();
                            purOrderLineBLL.SessionInfo = this.SessionInfo;
                            STK_InBLL inBLL = new STK_InBLL();
                            inBLL.SessionInfo = this.SessionInfo;
                            STK_InLineBLL inLineBLL = new STK_InLineBLL();
                            inLineBLL.SessionInfo = this.SessionInfo;
                            ORD_PurchaseReturnLineBLL returnLineBLL = new ORD_PurchaseReturnLineBLL();
                            returnLineBLL.SessionInfo = this.SessionInfo;
                            STK_StockReserveBLL reserveBLL = new STK_StockReserveBLL();
                            reserveBLL.SessionInfo = this.SessionInfo;
                            Guid?[] POLineGuids = null;
                            Guid?[] StkInLineGuids = null;
                            Guid?[] PRGuids = null;
                            Guid?[] effPRGuids = null;
                            Guid?[] POGuids = null;
                            List<STK_InLineResult> linkInLineList = new List<STK_InLineResult>();
                            List<ORD_PurchaseOrderLineResult> linkPurchaseOrderLineList = new List<ORD_PurchaseOrderLineResult>();
                            List<ORD_PurchaseReturnResult> linkReturnList = new List<ORD_PurchaseReturnResult>();
                            List<ORD_PurchaseReturnLineResult> linkReturnLineList = new List<ORD_PurchaseReturnLineResult>();
                            List<ORD_PurchaseReturnLineResult> effReturnLineList = new List<ORD_PurchaseReturnLineResult>();
                            #endregion
                            List<ORD_PurchaseReturnLineResult> purReturnLineList = returnLineBLL.GetList(new ORD_PurchaseReturnLineParam() { PRGuid = returnResult.PRGuid });

                            #region 预留库存
                            foreach (ORD_PurchaseReturnLineResult returnLineResult in purReturnLineList)
                            {
                                //创建预留明细
                                STK_StockReserveResult reserveResult = new STK_StockReserveResult();
                                reserveResult.SourceBillGuid = returnResult.PRGuid;//采购退货单guid
                                reserveResult.SourceBillNo = returnResult.BillNo;//退货单编号
                                reserveResult.SourceBillLineGuid = returnLineResult.PRLineGuid;//退货明细guid
                                reserveResult.SourceBillType = "采购退货出库";
                                reserveResult.ReserveType = 4;//退货预留
                                reserveResult.OperType = false;//系统预留
                                reserveResult.StkInLineGuid = returnLineResult.StkInLineGuid;// 入库明细guid
                                reserveResult.ItemCode = returnLineResult.ItemCode;
                                reserveResult.OperFlag = true;//增加
                                reserveBLL.OperateReserve(reserveResult);
                            }
                            #endregion 

                            #region 更新入库明细的退货数量
                            //获取退货明细关联的入库明细ID集合
                            StkInLineGuids = purReturnLineList.Select(a => a.StkInLineGuid).Distinct().ToArray();
                            if (StkInLineGuids != null && StkInLineGuids.Length > 0)
                            {
                                //退货明细关联的入库明细
                                linkInLineList = inLineBLL.GetList(new STK_InLineParam() { StkInLineGuids = StkInLineGuids });
                                //关联的入库明细所关联的退货明细
                                linkReturnLineList = returnLineBLL.GetList(new ORD_PurchaseReturnLineParam() { StkInLineGuids = StkInLineGuids });
                                PRGuids = linkReturnLineList.Select(a => a.PRGuid).Distinct().ToArray();
                                if (PRGuids != null && PRGuids.Length > 0)
                                {
                                    //关联的入库明细所关联的退货明细对应的退货主单
                                    linkReturnList = this.GetList(new ORD_PurchaseReturnParam() { PRGuids = PRGuids, StatusArr = new string[] { "Complete", "Approve" } });
                                    if (linkReturnList != null && linkReturnList.Count > 0)
                                    {
                                        effPRGuids = linkReturnList.Select(a => (Guid?)a.PRGuid).Distinct().ToArray();
                                        effReturnLineList = linkReturnLineList.Where(a => effPRGuids.Contains(a.PRGuid)).ToList();
                                        foreach (STK_InLineResult inLineResult in linkInLineList)
                                        {
                                            int? qty = effReturnLineList.Where(a => a.StkInLineGuid == inLineResult.StkInLineGuid).Sum(a => a.Qty.ToInt32());
                                            inLineResult.ReturnOccQty = qty;
                                        }
                                    }
                                }
                                //更新退货明细关联的入库明细的退货占有数量
                                inLineBLL.UpdateOrInsertList(linkInLineList);

                            }
                            #endregion

                            #region 更新采购明细的采购占有数量和采购主单的退货占有状态
                            //获取关联采购明细ID集合
                            POLineGuids = purReturnLineList.Select(a => a.POLineGuid).Distinct().ToArray();
                            linkPurchaseOrderLineList = purOrderLineBLL.GetList(new ORD_PurchaseOrderLineParam() { POLineGuids = POLineGuids, IsCancel = false });
                            //获取关联的采购明细所关联的退货明细
                            linkReturnLineList = returnLineBLL.GetList(new ORD_PurchaseReturnLineParam() { POLineGuids = POLineGuids });
                            PRGuids = linkReturnLineList.Select(a => a.PRGuid).Distinct().ToArray();
                            if (PRGuids != null && PRGuids.Length > 0)
                            {
                                //采购明细所关联的退货明细对应的退货主单
                                linkReturnList = this.GetList(new ORD_PurchaseReturnParam() { PRGuids = PRGuids, StatusArr = new string[] { "Complete", "Approve" } });
                                if (linkReturnList != null && linkReturnList.Count > 0)
                                {
                                    effPRGuids = linkReturnList.Select(a => (Guid?)a.PRGuid).Distinct().ToArray();
                                    effReturnLineList = linkReturnLineList.Where(a => effPRGuids.Contains(a.PRGuid)).ToList();
                                    foreach (ORD_PurchaseOrderLineResult purLineResult in linkPurchaseOrderLineList)
                                    {
                                        int? qty = effReturnLineList.Where(a => a.POLineGuid == purLineResult.POLineGuid).Sum(a => a.Qty.ToInt32());
                                        purLineResult.ReturnOccQty = qty;
                                    }
                                }
                            }
                            purOrderLineBLL.UpdateOrInsertList(linkPurchaseOrderLineList);
                            POGuids = linkPurchaseOrderLineList.Select(a => a.SOGuid).Distinct().ToArray();
                            foreach (Guid poguid in POGuids)
                            {
                                purOrderBLL.UpdateStatus(new ORD_PurchaseOrderParam() { POGuid = poguid });
                            }

                            #endregion
                        }
                    }


                    #endregion
                }
                else
                {
                    throw new WarnException("要提交的采购退货单在系统中不存在！");
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

        public bool AuditPurchaseReturnBill(ORD_PurchaseReturnParam param)
        {
            bool auditFlag = true;
            try
            {
                ORD_PurchaseReturnResult returnResult = this.GetInfo(param);

                if (returnResult != null)
                {
                    bool isAllowAudit = true;

                    if (returnResult.ApproveStatus == "待提交")
                    {
                        isAllowAudit = false;
                        throw new WarnException("采购退货单当前状态为:【待提交】,请先提交！");
                    }
                    else if (returnResult.ApproveStatus == "审核完成")
                    {
                        isAllowAudit = false;
                        throw new WarnException("采购退货单当前状态为:【审核完成】,禁止重复审核！");
                    }
                    if (isAllowAudit)
                    {
                        returnResult.Status = "Complete";
                        returnResult.ApproveStatus = "审核完成";
                        WCFAddUpdateResult ret = this.AddOrUpdate(returnResult);
                        if (ret.KeyGuid.ToGuid() == Guid.Empty)
                            auditFlag = false;
                        else
                        {

                            #region 定义相关变量
                            ORD_PurchaseOrderBLL purOrderBLL = new ORD_PurchaseOrderBLL();
                            purOrderBLL.SessionInfo = this.SessionInfo;
                            ORD_PurchaseOrderLineBLL purOrderLineBLL = new ORD_PurchaseOrderLineBLL();
                            purOrderLineBLL.SessionInfo = this.SessionInfo;
                            STK_InBLL inBLL = new STK_InBLL();
                            inBLL.SessionInfo = this.SessionInfo;
                            STK_InLineBLL inLineBLL = new STK_InLineBLL();
                            inLineBLL.SessionInfo = this.SessionInfo;
                            ORD_PurchaseReturnLineBLL returnLineBLL = new ORD_PurchaseReturnLineBLL();
                            returnLineBLL.SessionInfo = this.SessionInfo;
                            Guid?[] POLineGuids = null;
                            Guid?[] StkInLineGuids = null;
                            Guid?[] PRGuids = null;
                            Guid?[] effPRGuids = null;
                            Guid?[] POGuids = null;
                            List<STK_InLineResult> linkInLineList = new List<STK_InLineResult>();
                            List<ORD_PurchaseOrderLineResult> linkPurchaseOrderLineList = new List<ORD_PurchaseOrderLineResult>();
                            List<ORD_PurchaseReturnResult> linkReturnList = new List<ORD_PurchaseReturnResult>();
                            List<ORD_PurchaseReturnLineResult> linkReturnLineList = new List<ORD_PurchaseReturnLineResult>();
                            List<ORD_PurchaseReturnLineResult> effReturnLineList = new List<ORD_PurchaseReturnLineResult>();
                            #endregion
                            List<ORD_PurchaseReturnLineResult> purReturnLineList = returnLineBLL.GetList(new ORD_PurchaseReturnLineParam() { PRGuid = returnResult.PRGuid });

                           

                            #region 更新采购明细的退货数量和采购主单的退货状态
                            //获取关联的采购明细ID集合
                            POLineGuids = purReturnLineList.Select(a => a.POLineGuid).Distinct().ToArray();
                            linkPurchaseOrderLineList = purOrderLineBLL.GetList(new ORD_PurchaseOrderLineParam() { POLineGuids = POLineGuids });
                            //获取关联的采购明细所关联的退货明细
                            linkReturnLineList = returnLineBLL.GetList(new ORD_PurchaseReturnLineParam() { POLineGuids = POLineGuids });
                            PRGuids = linkReturnLineList.Select(a => a.PRGuid).Distinct().ToArray();
                            if (PRGuids != null && PRGuids.Length > 0)
                            {
                                //采购明细所关联的退货明细对应的退货主单
                                linkReturnList = this.GetList(new ORD_PurchaseReturnParam() { PRGuids = PRGuids, Status = "Complete" });
                                if (linkReturnList != null && linkReturnList.Count > 0)
                                {
                                    effPRGuids = linkReturnList.Select(a => (Guid?)a.PRGuid).Distinct().ToArray();
                                    effReturnLineList = linkReturnLineList.Where(a => effPRGuids.Contains(a.PRGuid)).ToList();
                                    foreach (ORD_PurchaseOrderLineResult purLineResult in linkPurchaseOrderLineList)
                                    {
                                        int? qty = effReturnLineList.Where(a => a.POLineGuid == purLineResult.SOLineGuid).Sum(a => a.Qty.ToInt32());
                                        purLineResult.ReturnQty = qty;
                                    }
                                }
                            }
                            purOrderLineBLL.UpdateOrInsertList(linkPurchaseOrderLineList);
                            POGuids = linkPurchaseOrderLineList.Select(a => a.SOGuid).Distinct().ToArray();
                            foreach (Guid poguid in POGuids)
                            {
                                purOrderBLL.UpdateStatus(new ORD_PurchaseOrderParam() { POGuid = poguid });
                            }

                            #endregion


                        }
                    }

                }
                else
                {
                    throw new WarnException("要审核的采购退货单在系统中不存在！");
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
        public PageList<ORD_PurchaseReturnResult> GetPageList(ORD_PurchaseReturnParam param)
        {
            this.CheckSession();
            PageList<ORD_PurchaseReturnResult> ret = new PageList<ORD_PurchaseReturnResult>();
            try
            {
                List<Field> field = new List<Field>()
                 {
                    Field.All
                 };
                ret = this.SelectList<ORD_PurchaseReturnResult>(param.PageIndex.GetValueOrDefault(1), param.PageSize.GetValueOrDefault(50), field, GetWhereClip(param), ORD_PurchaseReturn._.CreatedTime.Desc);
                if (ret.ResultList != null && ret.ResultList.Count > 0)
                {
                    HR_OrgBLL orgBLL = new HR_OrgBLL();
                    orgBLL.SessionInfo = this.SessionInfo;
                    HR_OrgParam orgParam = new HR_OrgParam();
                    orgParam.OrgIDs = ret.ResultList.Where(a => a.OperOrgID != null).Select(a => a.OperOrgID).Distinct().ToArray();
                    List<HR_OrgResult> orgList = orgBLL.GetOrgTree(orgParam);

                    HR_DepartmentBLL deptBLL = new HR_DepartmentBLL();
                    deptBLL.SessionInfo = this.SessionInfo;
                    HR_DepartmentParam deptParam = new HR_DepartmentParam();
                    deptParam.DeptIDs = ret.ResultList.Where(a => a.OperDeptID != null).Select(a => a.OperDeptID).Distinct().ToArray();
                    List<HR_DepartmentResult> deptList = deptBLL.GetDeptList(deptParam);



                    foreach (ORD_PurchaseReturnResult orderResult in ret.ResultList)
                    {
                        if (orderResult.OperOrgID != null)
                            orderResult.OperOrgName = orgList.FirstOrDefault(a => a.OrgID == orderResult.OperOrgID).OrgName;
                        if (orderResult.OperDeptID != null)
                            orderResult.OperDeptName = deptList.FirstOrDefault(a => a.DeptID == orderResult.OperDeptID).DeptName;
                        orderResult.AllStatus = orderResult.StkOutStatus;
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
        public List<ORD_PurchaseReturnResult> GetList(ORD_PurchaseReturnParam param)
        {
            this.CheckSession();
            List<ORD_PurchaseReturnResult> ret = new List<ORD_PurchaseReturnResult>();
            try
            {
                WhereClip whereClip = GetWhereClip(param);
                ret = this.SelectList<ORD_PurchaseReturnResult>(whereClip, ORD_PurchaseReturn._.CreatedTime.Desc);
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
        WhereClip GetWhereClip(ORD_PurchaseReturnParam param)
        {
            this.CheckSession();
            WhereClip where = ORD_PurchaseReturn._.IsDeleted == 0;
            if (param.PRGuid != null) where = where && ORD_PurchaseReturn._.PRGuid == param.PRGuid;
            if (param.PRGuids != null && param.PRGuids.Length > 0) where = where && ORD_PurchaseReturn._.PRGuid.In(param.PRGuids);
            if (!string.IsNullOrEmpty(param.BillNo)) where = where && ORD_PurchaseReturn._.BillNo.Like("%" + param.BillNo + "%");
            if (!string.IsNullOrEmpty(param.SupplierName)) where = where && ORD_PurchaseReturn._.SupplierName.Like("%" + param.SupplierName + "%");
            if (!string.IsNullOrEmpty(param.OperEmpName)) where = where && ORD_PurchaseReturn._.OperEmpName.Like("%" + param.OperEmpName + "%");
            if (!string.IsNullOrEmpty(param.Status)) where = where && ORD_PurchaseReturn._.Status == param.Status;
            if (param.StatusArr != null && param.StatusArr.Length > 0) where = where && ORD_PurchaseReturn._.Status.In(param.StatusArr);
            return where;
        }

        /// <summary>
        /// 添加和新增修改
        /// </summary>
        /// <param name="param">新增或修改的实体</param>
        /// <returns></returns>
        public WCFAddUpdateResult AddOrUpdate(ORD_PurchaseReturnResult param)
        {
            this.CheckSession();
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            try
            {
                int affect = 0;
                #region 判断
                if (string.IsNullOrEmpty(param.SupplierName.Trim())) throw new WarnException("请选择客户！");
                if (string.IsNullOrEmpty(param.POBillNo)) throw new WarnException("请选择采购单号！");
                if (string.IsNullOrEmpty(param.OperEmpName)) throw new WarnException("请选择归属人！");
                if (string.IsNullOrEmpty(param.Currency)) throw new WarnException("请选择币种！");
                if (param.ReturnLineList == null) throw new WarnException("请导入退货明细！");
                string msg = string.Empty;

                foreach (ORD_PurchaseReturnLineResult rst in param.ReturnLineList)
                {
                    if (rst.StkInLineGuid.ToGuid() == Guid.Empty)
                    {
                        msg = "请选择关联的入库明细！";
                        break;
                    }
                    if (rst.Qty <= 0)
                    {
                        msg = "请填写采购退货明细的数量！";
                        break;

                    }
                }
                if (!string.IsNullOrEmpty(msg)) throw new WarnException(msg);
                #endregion
                List<ORD_PurchaseReturnLineResult> orderLineList = param.ReturnLineList;

                #region 系统默认值
                if (param.PRGuid != null)
                {
                    WhereClip where = ORD_PurchaseReturn._.PRGuid == param.PRGuid;
                    param.UpdatedEmpID = this.SessionInfo.UserID;
                    param.UpdatedEmpName = this.SessionInfo.UserName;
                    param.UpdatedTime = DateTime.Now;
                    affect = this.Update<ORD_PurchaseReturnResult>(param, where);
                }
                else
                {
                    param.PRGuid = Guid.NewGuid();
                    Sys_CodeRulerBLL codeRulerBll = new Sys_CodeRulerBLL();
                    codeRulerBll.SessionInfo = this.SessionInfo;
                    param.BillNo = param.BillNo = codeRulerBll.GetBillNo(new Entity.UserModel.Sys.SYS_CredentialCodeRuleParam() { BillDate = DateTime.Today, TableName = "ORD_PurchaseReturn" });
                    param.GCompanyID = this.SessionInfo.CompanyID;
                    param.StkOutOccStatus = "待占有";
                    param.StkOutStatus = "待入库";
                    param.Status = "New";
                    param.ApproveStatus = "待提交";
                    param.IsDeleted = false;
                    param.CreatedEmpID = this.SessionInfo.UserID;
                    param.CreatedEmpName = this.SessionInfo.UserName;
                    param.CreatedTime = DateTime.Now;
                    affect = this.Insert<ORD_PurchaseReturnResult>(param);
                    param = this.Select<ORD_PurchaseReturnResult>(new List<Field>() { ORD_PurchaseReturn._.All }, ORD_PurchaseReturn._.PRGuid == param.PRGuid);
                }


                foreach (ORD_PurchaseReturnLineResult rst in orderLineList)
                {

                    if (rst.PRLineGuid.ToGuid() == Guid.Empty)
                    {
                        rst.PRLineGuid = Guid.NewGuid();
                        rst.PRGuid = param.PRGuid;
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
                this.BatchInsertOrUpdate<ORD_PurchaseReturnLineResult>(orderLineList);
                this.BatchExecute();
                
                #region 设置返回值
                ret.Key = param.PRID.ToInt32();
                ret.KeyGuid = param.PRGuid;
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
        public ORD_PurchaseReturnResult GetInfo(ORD_PurchaseReturnParam param)
        {
            this.CheckSession();
            ORD_PurchaseReturnResult rst = new ORD_PurchaseReturnResult();
            #region 判断
            if (param.PRGuid == null) throw new WarnException("请指定采购退货单GUID！");
            #endregion
            #region 获取实体

            rst = this.Select<ORD_PurchaseReturnResult>(GetWhereClip(param));
            if (rst != null)
            {
                string[] statusArr = new string[] { rst.StkOutStatus };
                rst.AllStatus = string.Join(",", statusArr);

                ORD_PurchaseReturnLineBLL lineBLL = new ORD_PurchaseReturnLineBLL();
                lineBLL.SessionInfo = this.SessionInfo;
                rst.ReturnLineList = lineBLL.GetList(new ORD_PurchaseReturnLineParam() { PRGuid = rst.PRGuid });
                //this.SelectList<ORD_SalesOrderLineResult>(ORD_SalesOrderLine._.SOGuid == rst.SOGuid);

                HR_DepartmentBLL deptBLL = new HR_DepartmentBLL();
                deptBLL.SessionInfo = this.SessionInfo;
                HR_DepartmentResult deptResult = deptBLL.GetInfo(new HR_DepartmentParam() { DeptID = rst.OperDeptID });
                rst.OperDeptName = deptResult.DeptName;
            }
            #endregion
            return rst;
        }

        /// <summary>
        /// 删除实体
        /// </summary>
        /// <param name="param">删除条件实体</param>
        /// <returns></returns>
        public WCFAddUpdateResult DelInfo(ORD_PurchaseReturnParam param)
        {
            this.CheckSession();
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            int affect = 0;
            try
            {
                #region 判断
                if (param.PRGuid == null) throw new WarnException("请指定要删除的退货单ID！");
                #endregion
                WhereClip whereClip = GetWhereClip(param);
                ORD_PurchaseReturnResult info = new ORD_PurchaseReturnResult();
                info.IsDeleted = true;
                affect = this.Update<ORD_PurchaseReturnResult>(info, whereClip);
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


        public bool UpdateStatus(ORD_PurchaseReturnParam param)
        {
            bool flag = true;
            try
            {
                ORD_PurchaseReturnResult orderResult = this.GetInfo(param);
                if (orderResult != null)
                {
                    if (orderResult.ReturnLineList != null && orderResult.ReturnLineList.Count > 0)
                    {

                        List<ORD_PurchaseReturnLineResult> lineList = orderResult.ReturnLineList;
                        if (lineList != null && lineList.Count > 0)
                        {
                            int? qty = lineList.Where(a => a.Qty != null).Select(a => a.Qty).Sum();
                            int? stkOutQty = lineList.Where(a => a.StkOutQty != null).Select(a => a.StkOutQty).Sum();
                            if (stkOutQty == 0)
                                orderResult.StkOutStatus = "待出库";
                            else if (stkOutQty >= qty)
                                orderResult.StkOutStatus = "全部出库";
                            else
                                orderResult.StkOutStatus = "部分出库";
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
    }
}
