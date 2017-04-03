using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLCRM.Entity.UserModel.SPM;
using ZNLFrame.Entity;
using MySoft.Data;
using ZNLCRM.BLL.Sys;
using ZNLCRM.Entity.DBModel;
using ZNLCRM.Entity.UserModel.Common;
using ZNLCRM.Entity.UserModel.PPM;
using ZNLCRM.BLL.HR;
using ZNLCRM.Entity.UserModel.HR;
using ZNLCRM.Utility;
using ZNLCRM.Entity.UserModel.STK;
using ZNLCRM.BLL.STK;

namespace ZNLCRM.BLL.SPM
{
    public  class ORD_SalesOrderBLL:BaseBLL
    {
        public bool SubmitSalesOrderBill(ORD_SalesOrderParam param)
        {
            this.CheckSession();
            bool submitFlag = true;
            try
            {
                ORD_SalesOrderResult orderResult = this.GetInfo(param);

                if (orderResult != null)
                {
                    #region 判断是否可以提交
                    
                    bool isAllowSubmit = true;
                   
                    if (orderResult.ApproveStatus == "待审核")
                    {
                        isAllowSubmit = false;
                        throw new WarnException("销售单当前状态为:【已提交,待审核】,禁止重复提交！");
                    }
                    else if (orderResult.ApproveStatus == "审核完成")
                    {
                        isAllowSubmit = false;
                        throw new WarnException("销售单当前状态为:【审核完成】,撤单后才可以再次提交！");
                    }
                    if (isAllowSubmit)
                    {
                        orderResult.Status = "Approve";
                        orderResult.ApproveStatus = "待审核";
                        WCFAddUpdateResult ret= this.AddOrUpdate(orderResult);
                        if (ret.KeyGuid.ToGuid() == Guid.Empty)
                            submitFlag = false;
                        else
                        {
                            //STK_InLineBLL inLineBLL=new STK_InLineBLL ();
                            //inLineBLL.SessionInfo=this.SessionInfo;
                            //List<ORD_SalesOrderLineResult> salesOrderLineList = orderResult.OrderLineList;
                            //if(salesOrderLineList!=null && salesOrderLineList.Count>0 && orderResult.BillType=="现货单")
                            //{
                            //    Guid?[] _ItemCodes=salesOrderLineList.Where(a=>a.ItemCode!=null).Select(a=>a.ItemCode).Distinct().ToArray();
                            //    List<STK_InLineResult> inLineResultList = inLineBLL.GetList(new STK_InLineParam() { ItemCodes = _ItemCodes });
                            //    #region 预留库存
                            //    foreach (ORD_SalesOrderLineResult orderLineResult in salesOrderLineList)
                            //    {
                            //        if (orderLineResult.ItemCode != null)
                            //        {
                                       
                            //        }

                            //    }
                            //    #endregion
                            //}
                            

                        }
                    }
                    
                  
                    #endregion
                }
                else
                {
                    throw new WarnException("要提交的销售单在系统中不存在！");
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

        public bool AuditSalesOrderBill(ORD_SalesOrderParam param)
        {
            bool auditFlag = true;
            try
            {
                ORD_SalesOrderResult orderResult = this.GetInfo(param);

                if (orderResult != null)
                {
                    bool isAllowAudit = true;
                    
                    if (orderResult.ApproveStatus == "待提交")
                    {
                        isAllowAudit = false;
                        throw new WarnException("销售单当前状态为:【待提交】,请先提交！");
                    }
                    else if (orderResult.ApproveStatus == "审核完成")
                    {
                        isAllowAudit = false;
                        throw new WarnException("销售单当前状态为:【审核完成】,禁止重复审核！");
                    }
                    if (isAllowAudit)
                    {
                        orderResult.Status = "Complete";
                        orderResult.ApproveStatus = "审核完成";
                        WCFAddUpdateResult ret = this.AddOrUpdate(orderResult);
                        if (ret.KeyGuid.ToGuid() == Guid.Empty)
                            auditFlag = false;
                    }

                }
                else
                {
                    throw new WarnException("要审核的销售单在系统中不存在！");
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

        public PageList<ORD_SalesOrderResult> GetSimplePageList(ORD_SalesOrderParam param, List<Field> fields)
        {
            PageList<ORD_SalesOrderResult> ret = new PageList<ORD_SalesOrderResult>();
            try
            {

                ret = this.SelectList<ORD_SalesOrderResult>(param.PageIndex.GetValueOrDefault(1), param.PageSize.GetValueOrDefault(50), fields, GetWhereClip(param), ORD_SalesOrder._.CreatedTime.Desc);
                if (ret.ResultList != null && ret.ResultList.Count > 0)
                {
                    HR_OrgBLL orgBLL = new HR_OrgBLL();
                    orgBLL.SessionInfo = this.SessionInfo;
                    HR_OrgParam orgParam = new HR_OrgParam();
                    orgParam.OrgIDs = ret.ResultList.Where(a => a.SalDeptID != null).Select(a => a.SalOrgID).Distinct().ToArray();
                    List<HR_OrgResult> orgList = orgBLL.GetOrgTree(orgParam);

                    HR_DepartmentBLL deptBLL = new HR_DepartmentBLL();
                    deptBLL.SessionInfo = this.SessionInfo;
                    HR_DepartmentParam deptParam = new HR_DepartmentParam();
                    deptParam.DeptIDs = ret.ResultList.Where(a => a.SalDeptID != null).Select(a => a.SalDeptID).Distinct().ToArray();
                    List<HR_DepartmentResult> deptList = deptBLL.GetDeptList(deptParam);

                    

                    foreach (ORD_SalesOrderResult orderResult in ret.ResultList)
                    {
                        if (orderResult.SalOrgID != null)
                            orderResult.SalOrgName = orgList.FirstOrDefault(a => a.OrgID == orderResult.SalOrgID).OrgName;
                        if (orderResult.SalDeptID != null)
                            orderResult.SalDeptName = deptList.FirstOrDefault(a => a.DeptID == orderResult.SalDeptID).DeptName;
                        orderResult.AllStatus=orderResult.NotifyStatus+"->"+orderResult.PurchaseStatus+"->"+orderResult.StkInStatus+"->"+orderResult.StkOutStatus;
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
        /// 分页集合
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public PageList<ORD_SalesOrderResult> GetPageList(ORD_SalesOrderParam param)
        {
            this.CheckSession();
            return GetSimplePageList(param, new List<Field>{ Field.All});

        }

        /// <summary>
        /// 获取集合
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public List<ORD_SalesOrderResult> GetList(ORD_SalesOrderParam param)
        {
            this.CheckSession();
            List<ORD_SalesOrderResult> ret = new List<ORD_SalesOrderResult>();
            try
            {
                WhereClip whereClip = GetWhereClip(param);
                ret = this.SelectList<ORD_SalesOrderResult>(whereClip, ORD_SalesOrder._.CreatedTime.Desc);
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
        WhereClip GetWhereClip(ORD_SalesOrderParam param)
        {
            this.CheckSession();
            WhereClip where = ORD_SalesOrder._.IsDeleted == 0;
            if (param.SOID > 0) where = where && ORD_SalesOrder._.SOID == param.SOID;
            if (param.SOGuid != null) where = where && ORD_SalesOrder._.SOGuid == param.SOGuid;
            if (!string.IsNullOrEmpty(param.BillNo)) where = where && ORD_SalesOrder._.BillNo.Like("%" + param.BillNo + "%");
            if (!string.IsNullOrEmpty(param.BillType)) where = where && ORD_SalesOrder._.BillType.Like("%" + param.BillType + "%");
            if (param.CompanyID != null) where = where && ORD_SalesOrder._.CustomerID == param.CustomerID;
            if (!string.IsNullOrEmpty(param.CustomerName)) where = where && ORD_SalesOrder._.CustomerName.Like("%"+param.CustomerName+"%");
            if (!string.IsNullOrEmpty(param.Contact)) where = where && ORD_SalesOrder._.Contact.Like("%" + param.Contact + "%");
            if (!string.IsNullOrEmpty(param.ClearingForm)) where = where && ORD_SalesOrder._.ClearingForm.Like("%" + param.ClearingForm + "%");
            if (!string.IsNullOrEmpty(param.SalerName)) where = where && ORD_SalesOrder._.SalerName.Like("%" + param.SalerName + "%");
            return where;
        }

        /// <summary>
        /// 添加和新增修改
        /// </summary>
        /// <param name="param">新增或修改的实体</param>
        /// <returns></returns>
        public WCFAddUpdateResult AddOrUpdate(ORD_SalesOrderResult param)
        {
            this.CheckSession();
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            try
            {
                int affect = 0;
                #region 判断

                
                if (string.IsNullOrEmpty(param.BillType)) throw new WarnException("请指定单据类型！");
                
                if (string.IsNullOrEmpty(param.CustomerName.Trim())) throw new WarnException("请指定公司名称！");
                if (string.IsNullOrEmpty(param.SalerName)) throw new WarnException("请选择销售员！");
                if (string.IsNullOrEmpty(param.Currency)) throw new WarnException("请选择币种！");
                if(string.IsNullOrEmpty(param.ClearingForm)) throw new WarnException("请填写结算方式！");
                if (param.OrderLineList == null ) throw new WarnException("请填写销售明细！");
                string msg=string.Empty;
                
                foreach (ORD_SalesOrderLineResult rst in param.OrderLineList)
                {
                    if (string.IsNullOrEmpty(rst.Model))
                    {
                        msg = "请填写销售明细的型号！";
                        break;
                    }
                    if (rst.Qty <= 0)
                    {
                        msg = "请填写销售明细的数量！";
                        break;
                    }
                
                }
                #endregion
                List<ORD_SalesOrderLineResult> orderLineList = param.OrderLineList;
              
                
                
                #region 系统默认值
                if (param.SOGuid!=null)
                {
                    WhereClip where = ORD_SalesOrder._.SOGuid == param.SOGuid;
                    param.UpdatedEmpID = this.SessionInfo.UserID;
                    param.UpdatedEmpName = this.SessionInfo.UserName;
                    param.UpdatedTime = DateTime.Now;
                    affect = this.Update<ORD_SalesOrderResult>(param, where);
                }
                else
                {
                    param.SOGuid = Guid.NewGuid();
                    Sys_CodeRulerBLL codeRulerBll = new Sys_CodeRulerBLL();
                    codeRulerBll.SessionInfo = this.SessionInfo;
                    param.BillNo = param.BillNo = codeRulerBll.GetBillNo(new Entity.UserModel.Sys.SYS_CredentialCodeRuleParam() { BillDate = DateTime.Today, TableName = "ORD_SalesOrder" });
                    param.GCompanyID = this.SessionInfo.CompanyID;
                    param.NotifyStatus = "待通知";
                    param.PurchaseStatus = "待采购";
                    param.StkInStatus = "待入库";
                    param.StkOutOccStatus = "待占有";
                    param.StkOutStatus = "待出库";
                    param.ShipmentStatus = "待发运";
                    param.ReturnOccStatus = "待占有";
                    param.ReturnStatus = "待退货";
                    param.ReceivableStatus = "待收款";
                    param.Status = "New";
                    param.ApproveStatus = "待提交";
                    param.IsDeleted = false;
                    param.IsCancel = false;
                    param.CreatedEmpID = this.SessionInfo.UserID;
                    param.CreatedEmpName = this.SessionInfo.UserName;
                    param.CreatedTime = DateTime.Now;
                    affect = this.Insert<ORD_SalesOrderResult>(param);
                    param = this.Select<ORD_SalesOrderResult>(new List<Field>() { ORD_SalesOrder._.All }, ORD_SalesOrder._.SOGuid == param.SOGuid);
                }
               
               
                foreach (ORD_SalesOrderLineResult rst in orderLineList)
                {
                    
                    if (rst.SOLineGuid.ToGuid()==Guid.Empty)
                    {
                        rst.SOLineGuid = Guid.NewGuid();
                        rst.SOGuid = param.SOGuid;
                        rst.GCompanyID = this.SessionInfo.CompanyID;
                        rst.CreatedEmpID = this.SessionInfo.UserID;
                        rst.CreatedEmpName = this.SessionInfo.UserName;
                        rst.CreatedTime = DateTime.Now;
                        rst.SOLineCode = param.CreatedTime.ToDateTime().ToString("yyyyMMddHHmmssms") + new Random().Next(1000, 9999);
                        rst.IsDeleted = false;
                        rst.IsCancel = false;
                    }
                    else
                    {
                        rst.UpdatedEmpID = this.SessionInfo.UserID;
                        rst.UpdatedEmpName = this.SessionInfo.UserName;
                        rst.UpdatedTime = DateTime.Now;
                    }
                }
                 this.BatchInsertOrUpdate<ORD_SalesOrderLineResult>(orderLineList);
                 this.BatchExecute();
                #region 设置返回值
                ret.Key = param.SOID;
                ret.KeyGuid = param.SOGuid;
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
        public ORD_SalesOrderResult GetInfo(ORD_SalesOrderParam param)
        {
            this.CheckSession();
            ORD_SalesOrderResult rst = new ORD_SalesOrderResult();
            #region 判断
            if (param.SOGuid == null) throw new WarnException("请指定销售单GUID！");
            #endregion
            #region 获取实体
          
            rst = this.Select<ORD_SalesOrderResult>(GetWhereClip(param));
            if (rst != null)
            {
                string[] statusArr = new string[]{rst.NotifyStatus,rst.PurchaseStatus,rst.StkTakeStatus,
                rst.StkInStatus,rst.StkOutStatus,rst.ShipmentStatus,rst.ReturnStatus,rst.ReceivableStatus};
                rst.AllStatus = string.Join(",", statusArr);
           
                ORD_SalesOrderLineBLL lineBLL=new ORD_SalesOrderLineBLL();
                lineBLL.SessionInfo=this.SessionInfo;
                rst.OrderLineList = lineBLL.GetList(new ORD_SalesOrderLineParam() { SOGuid = rst.SOGuid });
                    //this.SelectList<ORD_SalesOrderLineResult>(ORD_SalesOrderLine._.SOGuid == rst.SOGuid);

                HR_DepartmentBLL deptBLL = new HR_DepartmentBLL();
                deptBLL.SessionInfo = this.SessionInfo;
                HR_DepartmentResult deptResult= deptBLL.GetInfo(new HR_DepartmentParam() { DeptID = rst.SalDeptID });
                rst.SalDeptName = deptResult.DeptName;
            }
            #endregion
            return rst;
        }

        /// <summary>
        /// 删除实体
        /// </summary>
        /// <param name="param">删除条件实体</param>
        /// <returns></returns>
        public WCFAddUpdateResult DelInfo(ORD_SalesOrderParam param)
        {
            this.CheckSession();
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            int affect = 0;
            try
            {
                #region 判断
                if (param.SOGuid ==null) throw new WarnException("请指定要删除的销售单ID！");
                #endregion
                WhereClip whereClip = GetWhereClip(param);
                ORD_SalesOrderResult info = new ORD_SalesOrderResult();
                info.IsDeleted = true;
                affect = this.Update<ORD_SalesOrderResult>(info, whereClip);
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

     
        public bool UpdateStatus(ORD_SalesOrderParam param)
        {
            bool flag = true ;
            try
            {
                ORD_SalesOrderResult orderResult=  this.GetInfo(param);
                if (orderResult != null)
                {
                    if (orderResult.OrderLineList != null && orderResult.OrderLineList.Count > 0)
                    {
                        //取消的明细需要排除
                        List<ORD_SalesOrderLineResult> lineList = orderResult.OrderLineList.Where(a => a.IsCancel == false).ToList();
                        if (lineList != null && lineList.Count > 0)
                        {
                            int? qty = lineList.Where(a => a.Qty != null).Select(a => a.Qty).Sum();
                            int? notifyQty = lineList.Where(a => a.NotifyQty != null).Select(a => a.NotifyQty).Sum();
                            int? purchaseQty = lineList.Where(a => a.PurchaseQty != null).Select(a => a.PurchaseQty).Sum();
                            int? stkInQty = lineList.Where(a => a.StkInQty != null).Select(a => a.StkInQty).Sum();
                            int? stkOutOccQty = lineList.Where(a => a.StkOutOccQty != null).Select(a => a.StkOutOccQty).Sum();
                            int? stkOutQty = lineList.Where(a => a.StkOutQty != null).Select(a => a.StkOutQty).Sum();
                            int? returnOccQty = lineList.Where(a => a.ReturnOccQty != null).Select(a => a.ReturnOccQty).Sum();
                            int? returnQty = lineList.Where(a => a.ReturnQty != null).Select(a => a.ReturnQty).Sum();
                            if (notifyQty == 0)
                                orderResult.NotifyStatus = "待通知";
                            else if (notifyQty >= qty)
                                orderResult.NotifyStatus = "全部通知";
                            else
                                orderResult.NotifyStatus = "部分通知";
                            if (purchaseQty == 0)
                                orderResult.PurchaseStatus = "待采购";
                            else if (purchaseQty >= qty)
                                orderResult.PurchaseStatus = "全部采购";
                            else
                                orderResult.PurchaseStatus = "部分采购";
                            if (stkInQty == 0)
                                orderResult.StkInStatus = "待入库";
                            else if (stkInQty >= qty)
                                orderResult.StkInStatus = "全部入库";
                            else
                                orderResult.StkInStatus = "部分入库";
                            if (stkOutOccQty == 0)
                                orderResult.StkOutOccStatus = "待占有";
                            else if (stkOutOccQty >= qty)
                                orderResult.StkOutOccStatus = "全部占有";
                            else
                                orderResult.StkOutOccStatus = " 部分占有";
                            if (stkOutQty == 0)
                                orderResult.StkOutStatus = "待出库";
                            else if (stkOutQty >= qty)
                                orderResult.StkOutStatus = "全部出库";
                            else
                                orderResult.StkOutStatus = " 部分出库";
                            if (returnOccQty == 0)
                                orderResult.ReturnOccStatus = "待占有";
                            else if (returnOccQty >= qty)
                                orderResult.ReturnOccStatus = "全部占有";
                            else
                                orderResult.ReturnOccStatus = " 部分占有";
                            if (returnQty == 0)
                                orderResult.ReturnStatus = "待退货";
                            else if (returnQty >= qty)
                                orderResult.ReturnStatus = "全部退货";
                            else
                                orderResult.ReturnStatus = " 部分退货";
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
