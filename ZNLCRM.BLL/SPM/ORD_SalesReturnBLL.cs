using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLCRM.Entity.UserModel.SPM;
using ZNLFrame.Entity;
using ZNLCRM.Entity.UserModel.Common;
using ZNLCRM.Utility;
using ZNLCRM.BLL.Sys;
using ZNLCRM.BLL.HR;
using ZNLCRM.Entity.UserModel.HR;
using MySoft.Data;
using ZNLCRM.Entity.DBModel;
using ZNLCRM.BLL.STK;
using ZNLCRM.Entity.UserModel.STK;

namespace ZNLCRM.BLL.SPM
{
    public  class ORD_SalesReturnBLL:BaseBLL
    {
         public bool SubmitSalesReturnBill(ORD_SalesReturnParam param)
        {
            this.CheckSession();
            bool submitFlag = true;
            try
            {
                ORD_SalesReturnResult returnResult = this.GetInfo(param);

                if (returnResult != null)
                {
                    #region 判断是否可以提交

                    bool isAllowSubmit = true;

                    if (returnResult.ApproveStatus == "待审核")
                    {
                        isAllowSubmit = false;
                        throw new WarnException("销售退货单当前状态为:【已提交,待审核】,禁止重复提交！");
                    }
                    else if (returnResult.ApproveStatus == "审核完成")
                    {
                        isAllowSubmit = false;
                        throw new WarnException("销售退货单当前状态为:【审核完成】,撤单后才可以再次提交！");
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
                            ORD_SalesOrderBLL saleOrderBLL = new ORD_SalesOrderBLL();
                            saleOrderBLL.SessionInfo = this.SessionInfo;
                            ORD_SalesOrderLineBLL saleOrderLineBLL = new ORD_SalesOrderLineBLL();
                            saleOrderLineBLL.SessionInfo = this.SessionInfo;
                            STK_OutBLL outBLL = new STK_OutBLL();
                            outBLL.SessionInfo = this.SessionInfo;
                            STK_OutLineBLL outLineBLL = new STK_OutLineBLL();
                            outLineBLL.SessionInfo = this.SessionInfo;
                            ORD_SalesReturnLineBLL returnLineBLL = new ORD_SalesReturnLineBLL();
                            returnLineBLL.SessionInfo = this.SessionInfo;
                            Guid?[] SOLineGuids = null;
                            Guid?[] StkOutLineGuids = null;
                            Guid?[] SRGuids = null;
                            Guid?[] effSRGuids = null;
                            Guid?[] SOGuids = null;
                            List<STK_OutLineResult> linkOutLineList = new List<STK_OutLineResult>();
                            List<ORD_SalesOrderLineResult> linkSaleOrderLineList = new List<ORD_SalesOrderLineResult>();
                            List<ORD_SalesReturnResult> linkReturnList = new List<ORD_SalesReturnResult>();
                            List<ORD_SalesReturnLineResult> linkReturnLineList = new List<ORD_SalesReturnLineResult>();
                            List<ORD_SalesReturnLineResult> effReturnLineList = new List<ORD_SalesReturnLineResult>();
                            #endregion
                            List<ORD_SalesReturnLineResult> salesReturnLineList = returnLineBLL.GetList(new ORD_SalesReturnLineParam() { SRGuid = returnResult.SRGuid });

                            #region 更新出库明细的数量
                            //获取退货明细关联的出库明细ID集合
                            StkOutLineGuids = salesReturnLineList.Select(a => a.StkOutLineGuid).Distinct().ToArray();
                            if (StkOutLineGuids != null && StkOutLineGuids.Length > 0)
                            {
                                //退货明细关联的出库明细
                                linkOutLineList = outLineBLL.GetList(new STK_OutLineParam() { StkOutLineGuids = StkOutLineGuids });
                                //关联的出库明细所关联的退货明细
                                linkReturnLineList = returnLineBLL.GetList(new ORD_SalesReturnLineParam() { StkOutLineGuids = StkOutLineGuids });
                                SRGuids = linkReturnLineList.Select(a => a.SRGuid).Distinct().ToArray();
                                if (SRGuids != null && SRGuids.Length > 0)
                                {
                                    //关联的出库明细所关联的退货明细对应的退货主单
                                    linkReturnList = this.GetList(new ORD_SalesReturnParam() { SRGuids = SRGuids,  StatusArr = new string[] { "Complete", "Approve" } });
                                    if (linkReturnList != null && linkReturnList.Count > 0)
                                    {
                                        effSRGuids = linkReturnList.Select(a => (Guid?)a.SRGuid).Distinct().ToArray();
                                        effReturnLineList = linkReturnLineList.Where(a => effSRGuids.Contains(a.SRGuid)).ToList();
                                        foreach (STK_OutLineResult outLineResult in linkOutLineList)
                                        {
                                            int? qty = effReturnLineList.Where(a => a.StkOutLineGuid == outLineResult.StkOutLineGuid).Sum(a => a.Qty.ToInt32());
                                            outLineResult.ReturnOccQty = qty;
                                        }
                                    }
                                }
                                //更新退货明细关联的出库明细的退货数量
                                outLineBLL.UpdateOrInsertList(linkOutLineList);

                            }
                            #endregion

                            #region 更新销售明细的退货占有数量和销售主单的退货占有状态
                            //获取关联的销售明细ID集合
                            SOLineGuids = salesReturnLineList.Select(a => a.SOLineGuid).Distinct().ToArray();
                            linkSaleOrderLineList = saleOrderLineBLL.GetList(new ORD_SalesOrderLineParam() { SOLineGuids = SOLineGuids, IsCancel = false });
                            //获取关联的销售明细所关联的退货明细
                            linkReturnLineList = returnLineBLL.GetList(new ORD_SalesReturnLineParam() { SOLineGuids = SOLineGuids });
                            SRGuids = linkReturnLineList.Select(a => a.SRGuid).Distinct().ToArray();
                            if (SRGuids != null && SRGuids.Length > 0)
                            {
                                //销售明细所关联的退货明细对应的退货主单
                                linkReturnList = this.GetList(new ORD_SalesReturnParam() { SRGuids = SRGuids, StatusArr = new string[] { "Complete", "Approve" } });
                                if (linkReturnList != null && linkReturnList.Count > 0)
                                {
                                    effSRGuids = linkReturnList.Select(a => (Guid?)a.SRGuid).Distinct().ToArray();
                                    effReturnLineList = linkReturnLineList.Where(a => effSRGuids.Contains(a.SRGuid)).ToList();
                                    foreach (ORD_SalesOrderLineResult saleLineResult in linkSaleOrderLineList)
                                    {
                                        int? qty = effReturnLineList.Where(a => a.SOLineGuid == saleLineResult.SOLineGuid).Sum(a => a.Qty.ToInt32());
                                        saleLineResult.ReturnOccQty = qty;
                                    }
                                }
                            }
                            saleOrderLineBLL.UpdateOrInsertList(linkSaleOrderLineList);
                            SOGuids = linkSaleOrderLineList.Select(a => a.SOGuid).Distinct().ToArray();
                            foreach (Guid soguid in SOGuids)
                            {
                                saleOrderBLL.UpdateStatus(new ORD_SalesOrderParam() { SOGuid = soguid });
                            }

                            #endregion 
                        }
                    }


                    #endregion
                }
                else
                {
                    throw new WarnException("要提交的销售退货单在系统中不存在！");
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

        public bool AuditSalesReturnBill(ORD_SalesReturnParam param)
        {
            bool auditFlag = true;
            try
            {
                ORD_SalesReturnResult returnResult = this.GetInfo(param);

                if (returnResult != null)
                {
                    bool isAllowAudit = true;

                    if (returnResult.ApproveStatus == "待提交")
                    {
                        isAllowAudit = false;
                        throw new WarnException("销售退货单当前状态为:【待提交】,请先提交！");
                    }
                    else if (returnResult.ApproveStatus == "审核完成")
                    {
                        isAllowAudit = false;
                        throw new WarnException("销售退货单当前状态为:【审核完成】,禁止重复审核！");
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
                            ORD_SalesOrderBLL saleOrderBLL = new ORD_SalesOrderBLL();
                            saleOrderBLL.SessionInfo = this.SessionInfo;
                            ORD_SalesOrderLineBLL saleOrderLineBLL = new ORD_SalesOrderLineBLL();
                            saleOrderLineBLL.SessionInfo = this.SessionInfo;
                            STK_OutBLL outBLL = new STK_OutBLL();
                            outBLL.SessionInfo = this.SessionInfo;
                            STK_OutLineBLL outLineBLL = new STK_OutLineBLL();
                            outLineBLL.SessionInfo = this.SessionInfo;
                            ORD_SalesReturnLineBLL returnLineBLL = new ORD_SalesReturnLineBLL();
                            returnLineBLL.SessionInfo = this.SessionInfo;
                            Guid?[] SOLineGuids = null;
                            Guid?[] StkOutLineGuids = null;
                            Guid?[] SRGuids = null;
                            Guid?[] effSRGuids=null;
                            Guid?[] SOGuids = null;
                            List<STK_OutLineResult> linkOutLineList = new List<STK_OutLineResult>();
                            List<ORD_SalesOrderLineResult> linkSaleOrderLineList = new List<ORD_SalesOrderLineResult>();
                            List<ORD_SalesReturnResult> linkReturnList = new List<ORD_SalesReturnResult>();
                            List<ORD_SalesReturnLineResult> linkReturnLineList=new List<ORD_SalesReturnLineResult> ();
                            List<ORD_SalesReturnLineResult> effReturnLineList = new List<ORD_SalesReturnLineResult>();
                            #endregion
                            List<ORD_SalesReturnLineResult> salesReturnLineList = returnLineBLL.GetList(new ORD_SalesReturnLineParam() { SRGuid = returnResult.SRGuid });
                            
                            #region 更新出库明细的退货数量
                            //获取退货明细关联的出库明细ID集合
                            StkOutLineGuids = salesReturnLineList.Select(a => a.StkOutLineGuid).Distinct().ToArray();
                            if (StkOutLineGuids != null && StkOutLineGuids.Length > 0)
                            {
                                //退货明细关联的出库明细
                                linkOutLineList = outLineBLL.GetList(new STK_OutLineParam() { StkOutLineGuids = StkOutLineGuids });
                                //关联的出库明细所关联的退货明细
                                linkReturnLineList = returnLineBLL.GetList(new ORD_SalesReturnLineParam() { StkOutLineGuids = StkOutLineGuids });
                                SRGuids = linkReturnLineList.Select(a => a.SRGuid).Distinct().ToArray();
                                if (SRGuids != null && SRGuids.Length > 0)
                                {
                                    //关联的出库明细所关联的退货明细对应的退货主单
                                    linkReturnList = this.GetList(new ORD_SalesReturnParam() { SRGuids = SRGuids, Status = "Complete" });
                                    if (linkReturnList != null && linkReturnList.Count > 0)
                                    {
                                        effSRGuids = linkReturnList.Select(a => (Guid?)a.SRGuid).Distinct().ToArray();
                                        effReturnLineList = linkReturnLineList.Where(a => effSRGuids.Contains(a.SRGuid)).ToList();
                                        foreach (STK_OutLineResult outLineResult in linkOutLineList)
                                        {
                                            int? qty = effReturnLineList.Where(a => a.StkOutLineGuid == outLineResult.StkOutLineGuid).Sum(a => a.Qty.ToInt32());
                                            outLineResult.ReturnQty = qty;
                                        }
                                    }
                                }
                                //更新退货明细关联的出库明细的退货数量
                                outLineBLL.UpdateOrInsertList(linkOutLineList);
                                
                            }
                            #endregion

                            #region 更新销售明细的退货数量和销售主单的退货状态
                             //获取关联的销售明细ID集合
                             SOLineGuids = salesReturnLineList.Select(a => a.SOLineGuid).Distinct().ToArray();
                             linkSaleOrderLineList = saleOrderLineBLL.GetList(new ORD_SalesOrderLineParam() { SOLineGuids = SOLineGuids });
                              //获取关联的销售明细所关联的退货明细
                             linkReturnLineList = returnLineBLL.GetList(new ORD_SalesReturnLineParam() { SOLineGuids = SOLineGuids });
                             SRGuids = linkReturnLineList.Select(a => a.SRGuid).Distinct().ToArray();
                             if (SRGuids != null && SRGuids.Length > 0)
                                {
                                    //销售明细所关联的退货明细对应的退货主单
                                    linkReturnList = this.GetList(new ORD_SalesReturnParam() { SRGuids = SRGuids, Status = "Complete" });
                                    if (linkReturnList != null && linkReturnList.Count > 0)
                                    {
                                        effSRGuids = linkReturnList.Select(a => (Guid?)a.SRGuid).Distinct().ToArray();
                                        effReturnLineList = linkReturnLineList.Where(a => effSRGuids.Contains(a.SRGuid)).ToList();
                                        foreach (ORD_SalesOrderLineResult saleLineResult in linkSaleOrderLineList)
                                        {
                                            int? qty = effReturnLineList.Where(a => a.SOLineGuid == saleLineResult.SOLineGuid).Sum(a => a.Qty.ToInt32());
                                            saleLineResult.ReturnQty = qty;
                                        }
                                    }
                                }
                                saleOrderLineBLL.UpdateOrInsertList(linkSaleOrderLineList);
                                SOGuids = linkSaleOrderLineList.Select(a => a.SOGuid).Distinct().ToArray();
                                foreach (Guid soguid in SOGuids)
                                {
                                    saleOrderBLL.UpdateStatus(new ORD_SalesOrderParam() { SOGuid = soguid });
                                }
                            
                            #endregion 
                          

                        }
                    }

                }
                else
                {
                    throw new WarnException("要审核的销售退货单在系统中不存在！");
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
        public PageList<ORD_SalesReturnResult> GetPageList(ORD_SalesReturnParam param)
        {
            this.CheckSession();
            PageList<ORD_SalesReturnResult> ret = new PageList<ORD_SalesReturnResult>();
            try
            {
                List<Field> field = new List<Field>()
                 {
                    Field.All
                 };
                ret = this.SelectList<ORD_SalesReturnResult>(param.PageIndex.GetValueOrDefault(1), param.PageSize.GetValueOrDefault(50), field, GetWhereClip(param), ORD_SalesReturn._.CreatedTime.Desc);
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



                    foreach (ORD_SalesReturnResult orderResult in ret.ResultList)
                    {
                        if (orderResult.OperOrgID != null)
                            orderResult.OperOrgName = orgList.FirstOrDefault(a => a.OrgID == orderResult.OperOrgID).OrgName;
                        if (orderResult.OperDeptID != null)
                            orderResult.OperDeptName = deptList.FirstOrDefault(a => a.DeptID == orderResult.OperDeptID).DeptName;
                        orderResult.AllStatus = orderResult.StkInStatus;
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
        public List<ORD_SalesReturnResult> GetList(ORD_SalesReturnParam param)
        {
            this.CheckSession();
            List<ORD_SalesReturnResult> ret = new List<ORD_SalesReturnResult>();
            try
            {
                WhereClip whereClip = GetWhereClip(param);
                ret = this.SelectList<ORD_SalesReturnResult>(whereClip, ORD_SalesReturn._.CreatedTime.Desc);
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
        WhereClip GetWhereClip(ORD_SalesReturnParam param)
        {
            this.CheckSession();
            WhereClip where = ORD_SalesReturn._.IsDeleted == 0;
            if (param.SRGuid != null) where = where && ORD_SalesReturn._.SRGuid == param.SRGuid;
            if (param.SRGuids != null && param.SRGuids.Length > 0) where = where && ORD_SalesReturn._.SRGuid.In(param.SRGuids);
            if (!string.IsNullOrEmpty(param.BillNo)) where = where && ORD_SalesReturn._.BillNo.Like("%" + param.BillNo + "%");
            if (!string.IsNullOrEmpty(param.CustomerName)) where = where && ORD_SalesReturn._.CustomerName.Like("%" + param.CustomerName + "%");
            if (!string.IsNullOrEmpty(param.Status)) where = where && ORD_SalesReturn._.Status == param.Status;
            if (param.StatusArr != null && param.StatusArr.Length > 0) where = where && ORD_SalesReturn._.Status.In(param.StatusArr);
            return where;
        }

        /// <summary>
        /// 添加和新增修改
        /// </summary>
        /// <param name="param">新增或修改的实体</param>
        /// <returns></returns>
        public WCFAddUpdateResult AddOrUpdate(ORD_SalesReturnResult param)
        {
            this.CheckSession();
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            try
            {
                int affect = 0;
                #region 判断
                if (string.IsNullOrEmpty(param.CustomerName.Trim())) throw new WarnException("请选择客户！");
                if (string.IsNullOrEmpty(param.SOBillNo)) throw new WarnException("请选择销售单号！");
                if (string.IsNullOrEmpty(param.OperEmpName)) throw new WarnException("请选择归属人！");
                if (string.IsNullOrEmpty(param.Currency)) throw new WarnException("请选择币种！");
                if (param.ReturnLineList == null) throw new WarnException("请导入退货明细！");
                string msg = string.Empty;

                foreach (ORD_SalesReturnLineResult rst in param.ReturnLineList)
                {
                    if (rst.StkOutLineGuid.ToGuid()==Guid.Empty)
                    {
                        msg = "请选择关联的出库明细！";
                        break;
                    }
                    if (rst.Qty <= 0)
                    {
                        msg = "请填写销售退货明细的数量！";
                        break;
                        
                    }
                }
                if (!string.IsNullOrEmpty(msg)) throw new WarnException(msg);
                #endregion
                List<ORD_SalesReturnLineResult> orderLineList = param.ReturnLineList;

                #region 系统默认值
                if (param.SRGuid != null)
                {
                    WhereClip where = ORD_SalesReturn._.SRGuid == param.SRGuid;
                    param.UpdatedEmpID = this.SessionInfo.UserID;
                    param.UpdatedEmpName = this.SessionInfo.UserName;
                    param.UpdatedTime = DateTime.Now;
                    affect = this.Update<ORD_SalesReturnResult>(param, where);
                }
                else
                {
                    param.SRGuid = Guid.NewGuid();
                    Sys_CodeRulerBLL codeRulerBll = new Sys_CodeRulerBLL();
                    codeRulerBll.SessionInfo = this.SessionInfo;
                    param.BillNo = param.BillNo = codeRulerBll.GetBillNo(new Entity.UserModel.Sys.SYS_CredentialCodeRuleParam() { BillDate = DateTime.Today, TableName = "ORD_SalesReturn" });
                    param.GCompanyID = this.SessionInfo.CompanyID;
                    param.StkInOccStatus = "待占有";
                    param.StkInStatus = "待入库";
                    param.Status = "New";
                    param.ApproveStatus = "待提交";
                    param.IsDeleted = false;
                    param.CreatedEmpID = this.SessionInfo.UserID;
                    param.CreatedEmpName = this.SessionInfo.UserName;
                    param.CreatedTime = DateTime.Now;
                    affect = this.Insert<ORD_SalesReturnResult>(param);
                    param = this.Select<ORD_SalesReturnResult>(new List<Field>() { ORD_SalesReturn._.All }, ORD_SalesReturn._.SRGuid == param.SRGuid);
                }


                foreach (ORD_SalesReturnLineResult rst in orderLineList)
                {

                    if (rst.SRLineGuid.ToGuid() == Guid.Empty)
                    {
                        rst.SRLineGuid = Guid.NewGuid();
                        rst.SRGuid = param.SRGuid;
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
                this.BatchInsertOrUpdate<ORD_SalesReturnLineResult>(orderLineList);
                this.BatchExecute();
                #region 设置返回值
                ret.Key = param.SRID.ToInt32();
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
        /// 获取一条信息记录
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public ORD_SalesReturnResult GetInfo(ORD_SalesReturnParam param)
        {
            this.CheckSession();
            ORD_SalesReturnResult rst = new ORD_SalesReturnResult();
            #region 判断
            if (param.SRGuid == null) throw new WarnException("请指定销售退货单GUID！");
            #endregion
            #region 获取实体

            rst = this.Select<ORD_SalesReturnResult>(GetWhereClip(param));
            if (rst != null)
            {
                string[] statusArr = new string[]{rst.StkInStatus};
                rst.AllStatus = string.Join(",", statusArr);

                ORD_SalesReturnLineBLL lineBLL = new ORD_SalesReturnLineBLL();
                lineBLL.SessionInfo = this.SessionInfo;
                rst.ReturnLineList = lineBLL.GetList(new ORD_SalesReturnLineParam() { SRGuid = rst.SRGuid });
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
        public WCFAddUpdateResult DelInfo(ORD_SalesReturnParam param)
        {
            this.CheckSession();
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            int affect = 0;
            try
            {
                #region 判断
                if (param.SRGuid == null) throw new WarnException("请指定要删除的退货单ID！");
                #endregion
                WhereClip whereClip = GetWhereClip(param);
                ORD_SalesReturnResult info = new ORD_SalesReturnResult();
                info.IsDeleted = true;
                affect = this.Update<ORD_SalesReturnResult>(info, whereClip);
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


        public bool UpdateStatus(ORD_SalesReturnParam param)
        {
            bool flag = true;
            try
            {
                ORD_SalesReturnResult orderResult = this.GetInfo(param);
                if (orderResult != null)
                {
                    if (orderResult.ReturnLineList != null && orderResult.ReturnLineList.Count > 0)
                    {
                       
                        List<ORD_SalesReturnLineResult> lineList = orderResult.ReturnLineList;
                        if (lineList != null && lineList.Count > 0)
                        {
                            int? qty = lineList.Where(a => a.Qty != null).Select(a => a.Qty).Sum();
                            int? stkInQty = lineList.Where(a => a.StkInQty != null).Select(a => a.StkInQty).Sum();
                            if (stkInQty == 0)
                                orderResult.StkInStatus = "待入库";
                            else if (stkInQty >= qty)
                                orderResult.StkInStatus = "全部入库";
                            else
                                orderResult.StkInStatus = "部分入库";
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
