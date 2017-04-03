using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLCRM.Entity.UserModel.WF;
using ZNLFrame.Entity;
using ZNLCRM.Entity.DBModel;
using MySoft.Data;
using ZNLCRM.Utility;
using System.Reflection;
using ZNLCRM.Entity.UserModel.Common;
using ZNLCRM.BLL.Sys;

namespace ZNLCRM.BLL.WF
{
    public class WF_AuditRecordBLL:BaseBLL
    {
        /// <summary>
        /// 提交审核
        /// </summary>
        /// <param name="param">条件实体</param>
        /// <returns>返回生效的当前审核</returns>
        public WCFAddUpdateResult SubmitBill(WF_AuditRecordParam param)
        {
            WCFAddUpdateResult rst = new WCFAddUpdateResult();
            try
            {
                #region 判断提交值
                this.CheckSession();
                if (string.IsNullOrEmpty(param.SourceTableEngName)) throw new WarnException("请指定相关审核业务单据!");
                if (param.SourceBillGuid == null) throw new WarnException("请指定相关审核业务单据ID!");
                //if (string.IsNullOrEmpty(param.SourceBillNo)) throw new WarnException("请指定相关审核业务单据编号!");

                #endregion
                #region 获取相关表定义
                WF_TableResult tblRst = new WF_TableResult();
                WF_TableBLL tblBll = new WF_TableBLL();
                tblBll.SessionInfo = this.SessionInfo;
                tblRst = tblBll.GetInfo(new WF_TableParam()
                {
                    WF_TableEngName = param.SourceTableEngName
                });
                if (tblRst == null || tblRst.WF_TableID <= 0)
                {
                    throw new WarnException("系统中未发现定义的业务表!");
                }
                if (tblRst.WF_TableFieldList == null || tblRst.WF_TableFieldList.Count < 0)
                {
                    throw new WarnException("系统中未发现定义的业务表相关字段!");
                }
                if (!tblRst.WF_TableFieldList.Exists(a => a.IsKeyGuid.ToBooleanHasNull() == true))
                {
                    throw new WarnException("系统中未发现定义的业务表相关主键字段!");
                }
                #endregion
                #region 判断当前记录状态
                object sourceInfo = this.GetSourceAuditStatus(tblRst, param.SourceBillGuid);
                //判断是否取消
                bool isCancel = sourceInfo.GetType().GetProperty("IsCancel") != null ? sourceInfo.GetType().GetProperty("IsCancel").GetValue(sourceInfo, null).ToBooleanHasNull() : false;
                if (isCancel)
                {
                    throw new WarnException("您的单据已取消不允许执行当前操作!");
                }
                string oldStatus = sourceInfo.GetType().GetProperty("Status").GetValue(sourceInfo, null).ToStringHasNull();
                if (oldStatus.ToLower() == "approve")
                {
                    throw new WarnException("您的单据已提交,不允许重复提交!");
                }
                if (oldStatus.ToLower() == "complete")
                {
                    throw new WarnException("您的单据已审核完成,不允许提交!");
                }
                if (oldStatus.ToLower() == "nopass")
                {
                    throw new WarnException("您提交的单据已拒绝,不允许再次提交!");
                }
                #endregion
                #region 获取相关审核基础流程
                WF_AuditBillBLL auditBll = new WF_AuditBillBLL();
                auditBll.SessionInfo = this.SessionInfo;
                WF_AuditBillResult auditBillRst = auditBll.GetInfo(new WF_AuditBillParam()
                {
                    TableName = param.SourceTableEngName
                });
                if (auditBillRst == null || auditBillRst.WFAuditGuid == null
                    || auditBillRst.WF_AuditBillLineList == null || auditBillRst.WF_AuditBillLineList.Count <= 0)
                {
                    throw new WarnException("未定相关业务单据的审核流程!");
                }
                if (auditBillRst.WF_AuditBillLineList.Exists(a => a.AuditEmpIDs.ToStringHasNull().Trim() == "" && a.NextType != "审核完成"))
                {
                    throw new WarnException("相关审批流程中,未找到相关审核人!");
                }
                #endregion
                #region 判断是否已提交业务单据,否则加入审核记录
                WF_AuditRecordResult currentStep = new WF_AuditRecordResult();
                WhereClip whereClip = WF_AuditRecord._.SourceBillGuid == param.SourceBillGuid
                                    && WF_AuditRecord._.GCompanyID == this.SessionInfo.CompanyID
                                    && WF_AuditRecord._.IsDeleted == false
                                    && WF_AuditRecord._.SourceTableEngName == param.SourceTableEngName
                                    && WF_AuditRecord._.IsCurrent == true;
                currentStep = this.Select<WF_AuditRecordResult>(whereClip);
                if (currentStep != null && currentStep.WF_RecGuid != null)
                    throw new WarnException("当前单据已提交,正处于审核流程中,不允许重复提交!");
                List<WF_AuditRecordResult> newAuditRecList = new List<WF_AuditRecordResult>();
                WF_AuditRecordResult newAuditRec = new WF_AuditRecordResult();
                #region 添加提交LOG记录
                newAuditRec.WF_RecGuid = Guid.NewGuid();
                newAuditRec.GCompanyID = this.SessionInfo.CompanyID;
                newAuditRec.SourceTableEngName = auditBillRst.TableName;
                newAuditRec.SourceBillNo = param.SourceBillNo;
                newAuditRec.SourceBillGuid = param.SourceBillGuid;
                newAuditRec.WFAuditGuid = auditBillRst.WFAuditGuid;
                newAuditRec.WFAuditLineGuid = null;
                newAuditRec.SeqNo = 0;
                newAuditRec.GreeMans = 0;
                newAuditRec.AuditEmpIDs = "," + this.SessionInfo.UserID + ",";
                newAuditRec.AuditEmpNames = this.SessionInfo.UserName;
                newAuditRec.IsCurrent = 0;
                newAuditRec.AuditResult = "提交";
                newAuditRec.AuditRemark = "用户" + this.SessionInfo.UserName + "提交审核";
                newAuditRec.CreatedEmpID = this.SessionInfo.UserID;
                newAuditRec.CreatedEmpName = this.SessionInfo.UserName;
                newAuditRec.CreatedTime = DateTime.Now;
                newAuditRec.IsDeleted = false;
                newAuditRecList.Add(newAuditRec);
                #endregion
                #region 添加审核记录
                string billStatus = "", billApproveStatus = "";
                string[] arrEmpIds, arrEmpNames; int idx = 0;
                WF_AuditRecordLineResult auditRecLine;
                foreach (WF_AuditBillLineResult info in auditBillRst.WF_AuditBillLineList)
                {
                    newAuditRec = new WF_AuditRecordResult();
                    newAuditRec.WF_RecGuid = Guid.NewGuid();
                    newAuditRec.GCompanyID = this.SessionInfo.CompanyID;
                    newAuditRec.SourceTableEngName = auditBillRst.TableName;
                    newAuditRec.SourceBillNo = param.SourceBillNo;
                    newAuditRec.SourceBillGuid = param.SourceBillGuid;
                    newAuditRec.WFAuditGuid = auditBillRst.WFAuditGuid;
                    newAuditRec.WFAuditLineGuid = info.WFAuditLineGuid;
                    newAuditRec.SeqNo = info.StepNo;
                    newAuditRec.GreeMans = info.GreeMans;
                    newAuditRec.AuditEmpIDs = info.AuditEmpIDs.ToStringHasNull().Trim() != "" ? ("," + info.AuditEmpIDs + ",") : "";//暂时是指定到人
                    newAuditRec.AuditEmpNames = info.AuditEmpNames;
                    newAuditRec.IsCurrent = 2;
                    newAuditRec.CreatedEmpID = this.SessionInfo.UserID;
                    newAuditRec.CreatedEmpName = this.SessionInfo.UserName;
                    newAuditRec.CreatedTime = DateTime.Now;
                    newAuditRec.IsDeleted = false;
                    if (info.OperationType == "提交")
                    {
                        newAuditRec.IsCurrent = 1;
                        billStatus = "Approve";
                        billApproveStatus = "待审核";//" + info.AuditEmpNames.ToStringHasNull() + "
                        if (info.NextType == "审核完成" && info.AuditEmpIDs.ToStringHasNull().Trim()=="")
                        {
                            billStatus = "Complete";
                            billApproveStatus = "审核完成";
                            newAuditRec.IsCurrent = 0;
                            newAuditRecList.Add(newAuditRec);
                            break;
                        }
                    }
                    newAuditRecList.Add(newAuditRec);
                    #region 添加审人明细记录
                    idx = 0;
                    arrEmpIds = newAuditRec.AuditEmpIDs.ToStringHasNull().Split(',').Where(a => a.ToStringHasNull().Trim() != "").Distinct().ToArray();
                    arrEmpNames = newAuditRec.AuditEmpNames.ToStringHasNull().Split(',').Where(a => a.ToStringHasNull().Trim() != "").Distinct().ToArray();
                    foreach (string s in arrEmpIds)
                    {
                        auditRecLine = new WF_AuditRecordLineResult();
                        auditRecLine.WF_RecGuid = newAuditRec.WF_RecGuid;
                        auditRecLine.SourceBillGuid = newAuditRec.SourceBillGuid;
                        auditRecLine.WFAuditGuid = newAuditRec.WFAuditGuid;
                        auditRecLine.WFAuditLineGuid = newAuditRec.WFAuditLineGuid;
                        auditRecLine.SourceTableEngName = newAuditRec.SourceTableEngName;
                        auditRecLine.SourceBillNo = newAuditRec.SourceBillNo;
                        auditRecLine.AuditEmpID = s.ToInt32();
                        auditRecLine.AuditEmpName = arrEmpNames[idx];
                        this.AddOrUpdateAuditRecLine(auditRecLine);
                        idx++;
                    }
                    #endregion
                }
                if (newAuditRecList.Count > 0)
                {
                    this.BatchInsert<WF_AuditRecordResult>(newAuditRecList);
                    this.BatchExecute();
                }
                if (billStatus != "")
                {
                    ChangeSourceBllAuditStatus(tblRst, billStatus, billApproveStatus, sourceInfo);
                    AfterAuditExeMethod(param.SourceTableEngName, oldStatus, billStatus, tblRst.TriggerStatus, tblRst.AfterAuditMethodPath, tblRst.AfterAuditMethodName,param.SourceBillGuid);
                }
                #endregion
                #endregion
                rst.Key = 1;
            }
            catch (WarnException exp)
            {
                throw exp;
            }
            catch (System.Exception exp)
            {
                LogInfoBLL.WriteLog(this.SessionInfo, exp);
            }
            return rst;
        }
        /// <summary>
        /// 审核单据
        /// </summary>
        /// <param name="param">条件实体</param>
        /// <returns></returns>
        public WCFAddUpdateResult AuditBill(WF_AuditRecordParam param)
        {
            WCFAddUpdateResult rst = new WCFAddUpdateResult();
            try
            {
                #region 判断提交值
                this.CheckSession();
                if (string.IsNullOrEmpty(param.SourceTableEngName)) throw new WarnException("请指定相关审核业务单据!");
                if (param.SourceBillGuid == null) throw new WarnException("请指定相关审核业务单据ID!");
                //if (string.IsNullOrEmpty(param.SourceBillNo)) throw new WarnException("请指定相关审核业务单据编号!");
                if (param.AuditResult.ToStringHasNull() == "") throw new WarnException("请指定审批意见!");


                #endregion
                #region 获取相关表定义
                WF_TableResult tblRst = new WF_TableResult();
                WF_TableBLL tblBll = new WF_TableBLL();
                tblBll.SessionInfo = this.SessionInfo;
                tblRst = tblBll.GetInfo(new WF_TableParam()
                {
                    WF_TableEngName = param.SourceTableEngName
                });
                if (tblRst == null || tblRst.WF_TableID <= 0)
                {
                    throw new WarnException("系统中未发现定义的业务表!");
                }
                if (tblRst.WF_TableFieldList == null || tblRst.WF_TableFieldList.Count < 0)
                {
                    throw new WarnException("系统中未发现定义的业务表相关字段!");
                }
                if (!tblRst.WF_TableFieldList.Exists(a => a.IsKeyGuid.ToBooleanHasNull() == true))
                {
                    throw new WarnException("系统中未发现定义的业务表相关主键字段!");
                }
                #endregion
                #region 判断当前记录状态
                object sourceInfo = this.GetSourceAuditStatus(tblRst, param.SourceBillGuid);
                string oldStatus = sourceInfo.GetType().GetProperty("Status").GetValue(sourceInfo, null).ToStringHasNull();
                if (oldStatus.ToLower() == "complete")
                {
                    throw new WarnException("您的单据已审核完成,不允许提交!");
                }
                if (oldStatus.ToLower() == "nopass")
                {
                    throw new WarnException("您提交的单据已拒绝,不允许再次提交!");
                }
                #endregion
                #region 判断是否已提交业务单据,否则加入审核记录
                string billStatus = "", billApproveStatus = "";
                List<WF_AuditRecordResult> stepList = new List<WF_AuditRecordResult>();
                WhereClip whereClip = WF_AuditRecord._.SourceBillGuid == param.SourceBillGuid
                                    && WF_AuditRecord._.GCompanyID == this.SessionInfo.CompanyID
                                    && WF_AuditRecord._.IsDeleted == false
                                    && WF_AuditRecord._.IsCurrent > 0
                                    && WF_AuditRecord._.SourceTableEngName == param.SourceTableEngName;
                stepList = this.SelectList<WF_AuditRecordResult>(whereClip, WF_AuditRecord._.SeqNo.Asc);
                if (stepList == null && stepList.Count <= 0) throw new WarnException("您的相关单据未提交!");
                List<WF_AuditRecordResult> newAuditRecList = new List<WF_AuditRecordResult>();
                WF_AuditRecordResult currAuditRec = new WF_AuditRecordResult();
                WF_AuditRecordResult nextAuditRec = new WF_AuditRecordResult();
                #region 添加审核记录
                if (!stepList.Exists(a => a.IsCurrent > 0))
                {
                    throw new WarnException("当前业务单据已审核完成!");
                }
                currAuditRec = stepList.FirstOrDefault(a => a.IsCurrent == 1 && a.AuditEmpIDs.IndexOf("," + this.SessionInfo.UserID.ToStringHasNull() + ",") >= 0);
                if (currAuditRec == null)
                {
                    throw new WarnException("您没有审核当前业务单据的权限!");
                }
                nextAuditRec = stepList.FirstOrDefault(a => a.IsCurrent == 2 && a.SeqNo > currAuditRec.SeqNo);
                #region 审核情况
                int stdManNum = currAuditRec.GreeMans.ToInt32();
                int stdCheckManNum = currAuditRec.AuditEmpIDs.ToStringHasNull().Split(',').ToArray().Where(a => a.ToStringHasNull().Trim() != "").Distinct().ToArray().Length;
                if (stdManNum > stdCheckManNum) stdManNum = stdCheckManNum;
                if (stdManNum <= 0) stdManNum = 1;
                List<WF_AuditRecordLineResult> auditRecList = this.GetAuditRecLineList(new WF_AuditRecordLineParam() { WF_RecGuid = currAuditRec.WF_RecGuid });

                if (auditRecList.Exists(a => a.AuditEmpID == this.SessionInfo.UserID && a.AuditResult.ToStringHasNull() != ""))
                {
                    throw new WarnException("您已审核当前业务单据,不允许重复审核!");
                }
                WF_AuditRecordLineResult currEmpAuditRec = auditRecList.Find(a => a.AuditEmpID == this.SessionInfo.UserID);
                #region 更新审核人意见
                if (currEmpAuditRec == null)
                {
                    currEmpAuditRec = new WF_AuditRecordLineResult();
                    currEmpAuditRec.WF_RecGuid = currAuditRec.WF_RecGuid;
                    currEmpAuditRec.SourceBillGuid = currAuditRec.SourceBillGuid;
                    currEmpAuditRec.WFAuditGuid = currAuditRec.WFAuditGuid;
                    currEmpAuditRec.WFAuditLineGuid = currAuditRec.WFAuditLineGuid;
                    currEmpAuditRec.SourceTableEngName = currAuditRec.SourceTableEngName;
                    currEmpAuditRec.SourceBillNo = currAuditRec.SourceBillNo;
                    currEmpAuditRec.AuditEmpID = this.SessionInfo.UserID;
                    currEmpAuditRec.AuditEmpName = this.SessionInfo.UserName;
                    currEmpAuditRec.AuditResult = param.AuditResult;
                    currEmpAuditRec.AuditRemark = param.AuditRemark;
                }
                else
                {
                    currEmpAuditRec.AuditResult = param.AuditResult;
                    currEmpAuditRec.AuditRemark = param.AuditRemark;
                }
                this.AddOrUpdateAuditRecLine(currEmpAuditRec);
                #endregion
                #region 重新获取当前步骤的审批记录
                auditRecList = this.GetAuditRecLineList(new WF_AuditRecordLineParam() { WF_RecGuid = currAuditRec.WF_RecGuid });
                int currManGreeNum = auditRecList.Where(a => a.AuditResult.ToStringHasNull() == "同意").Select(a => a.AuditEmpID).Distinct().ToArray().Length;
                #endregion
                #region 同意的处理
                if (param.AuditResult == "同意")
                {
                    currManGreeNum++;
                    if (currManGreeNum >= stdManNum)//审核人数通过
                    {
                        currAuditRec.IsCurrent = 0;
                        currAuditRec.AuditResult = param.AuditResult;
                        currAuditRec.AuditRemark = param.AuditRemark;
                        currAuditRec.UpdatedEmpID = this.SessionInfo.UserID;
                        currAuditRec.UpdatedEmpName = this.SessionInfo.UserName;
                        currAuditRec.UpdatedTime = DateTime.Now;
                        if (nextAuditRec == null)//审核完成
                        {
                            billStatus = "Complete";
                            billApproveStatus = "审核完成";
                            ChangeSourceBllAuditStatus(tblRst, billStatus, billApproveStatus, sourceInfo);
                            AfterAuditExeMethod(param.SourceTableEngName, oldStatus, billStatus, tblRst.TriggerStatus, tblRst.AfterAuditMethodPath, tblRst.AfterAuditMethodName, param.SourceBillGuid);
                        }
                        else
                        {
                            this.Update<WF_AuditRecordResult>(new WF_AuditRecordResult()
                            {
                                IsCurrent = 1,
                                UpdatedEmpID = this.SessionInfo.UserID,
                                UpdatedEmpName = this.SessionInfo.UserName,
                                UpdatedTime = DateTime.Now
                            }, WF_AuditRecord._.WF_RecGuid == nextAuditRec.WF_RecGuid);
                        }
                        this.Update<WF_AuditRecordResult>(currAuditRec, WF_AuditRecord._.WF_RecGuid == currAuditRec.WF_RecGuid);
                    }
                }
                #endregion
                #region 拒绝和驳回的处理(NoPass,Reject)
                else
                {
                    currAuditRec.IsCurrent = 0;
                    currAuditRec.AuditResult = param.AuditResult;
                    currAuditRec.AuditRemark = param.AuditRemark;
                    currAuditRec.UpdatedEmpID = this.SessionInfo.UserID;
                    currAuditRec.UpdatedEmpName = this.SessionInfo.UserName;
                    currAuditRec.UpdatedTime = DateTime.Now;
                    this.Update<WF_AuditRecordResult>(currAuditRec, WF_AuditRecord._.WF_RecGuid == currAuditRec.WF_RecGuid);
                    if (param.AuditResult == "拒绝")
                    {
                        billStatus = "NoPass";
                        billApproveStatus = "拒绝";
                    }
                    else
                    {
                        billStatus = "New";
                        billApproveStatus = "待提交";
                    }
                    ChangeSourceBllAuditStatus(tblRst, billStatus, billApproveStatus, sourceInfo);
                    AfterAuditExeMethod(param.SourceTableEngName, oldStatus, billStatus, tblRst.TriggerStatus, tblRst.AfterAuditMethodPath, tblRst.AfterAuditMethodName, param.SourceBillGuid);

                    //将后续审批节点失效掉(删除)
                    this.Update<WF_AuditRecordResult>(new WF_AuditRecordResult()
                    {
                        IsDeleted = true,
                        UpdatedEmpID = this.SessionInfo.UserID,
                        UpdatedEmpName = this.SessionInfo.UserName,
                        UpdatedTime = DateTime.Now
                    }, WF_AuditRecord._.IsCurrent == 2
                        && WF_AuditRecord._.WFAuditGuid == currAuditRec.WFAuditGuid
                        && WF_AuditRecord._.SourceBillGuid == currAuditRec.SourceBillGuid
                        && WF_AuditRecord._.IsDeleted == false);
                    this.Update<WF_AuditRecordLineResult>(new WF_AuditRecordLineResult()
                    {
                        IsDeleted = true,
                        UpdatedEmpID = this.SessionInfo.UserID,
                        UpdatedEmpName = this.SessionInfo.UserName,
                        UpdatedTime = DateTime.Now
                    }, WF_AuditRecordLine._.IsDeleted == false
                        && WF_AuditRecordLine._.AuditResult.IsNull("") == ""
                        && WF_AuditRecordLine._.WFAuditGuid == currAuditRec.WFAuditGuid
                        && WF_AuditRecordLine._.SourceBillGuid == currAuditRec.SourceBillGuid);
                }
                #endregion
                #endregion
                #endregion
                #endregion
                rst.Key = 1;
            }
            catch (WarnException exp)
            {
                throw exp;
            }
            catch (System.Exception exp)
            {
                LogInfoBLL.WriteLog(this.SessionInfo, exp);
            }
            return rst;
        }
        /// <summary>
        /// 撤消审核
        /// </summary>
        /// <param name="param">条件实体</param>
        /// <returns>返回生效的当前审核</returns>
        public WCFAddUpdateResult CancelBill(WF_AuditRecordParam param)
        {
            WCFAddUpdateResult rst = new WCFAddUpdateResult();
            try
            {
                #region 判断提交值
                this.CheckSession();
                if (string.IsNullOrEmpty(param.SourceTableEngName)) throw new WarnException("请指定相关审核业务单据!");
                if (param.SourceBillGuid == null) throw new WarnException("请指定相关审核业务单据ID!");
                //if (param.AuditResult.ToStringHasNull() == "") throw new WarnException("请指定审批意见!");
                #endregion
                #region 获取相关表定义
                WF_TableResult tblRst = new WF_TableResult();
                WF_TableBLL tblBll = new WF_TableBLL();
                tblBll.SessionInfo = this.SessionInfo;
                tblRst = tblBll.GetInfo(new WF_TableParam()
                {
                    WF_TableEngName = param.SourceTableEngName
                });
                if (tblRst == null || tblRst.WF_TableID <= 0)
                {
                    throw new WarnException("系统中未发现定义的业务表!");
                }
                if (tblRst.WF_TableFieldList == null || tblRst.WF_TableFieldList.Count < 0)
                {
                    throw new WarnException("系统中未发现定义的业务表相关字段!");
                }
                if (!tblRst.WF_TableFieldList.Exists(a => a.IsKeyGuid.ToBooleanHasNull() == true))
                {
                    throw new WarnException("系统中未发现定义的业务表相关主键字段!");
                }
                #endregion
                #region 判断当前记录状态
                string operationType = "";
                object sourceInfo = this.GetSourceAuditStatus(tblRst, param.SourceBillGuid);
                string oldStatus = sourceInfo.GetType().GetProperty("Status").GetValue(sourceInfo, null).ToStringHasNull();
                if (param.OperationType.ToStringHasNull().ToLower() == "cancel")
                {
                    operationType = "撤消";
                    if (oldStatus.ToLower() == "new")
                    {
                        throw new WarnException("您的单据已处于未提交状态,不允许撤消!");
                    }
                }
                else
                {
                    operationType = "收回";
                    if (oldStatus.ToLower() == "new")
                    {
                        throw new WarnException("您的单据已处于未提交状态,不允许执行收回操作!");
                    }
                    else if (oldStatus.ToLower() == "complete")
                    {
                        throw new WarnException("您的单据已处于审核状态,不允许收回!");
                    }
                    #region 判断是否属于当前人的记录
                    string empFldIDName = tblRst.BelongEmpIDFld.ToStringHasNull();
                    if (empFldIDName != "")
                    {
                        string belongEmpID = sourceInfo.GetType().GetProperty(empFldIDName).GetValue(sourceInfo, null).ToStringHasNull();
                        if (belongEmpID.ToInt32() != this.SessionInfo.UserID)
                        {
                            throw new WarnException("当前单据记录不属于您创建,不允许收回!");
                        }
                    }
                    #endregion
                }
                #endregion
                #region 判断是否已提交业务单据,否则加入审核记录
                string billStatus = "", billApproveStatus = "";
                List<WF_AuditRecordResult> stepList = new List<WF_AuditRecordResult>();
                WhereClip whereClip = WF_AuditRecord._.SourceBillGuid == param.SourceBillGuid
                                    && WF_AuditRecord._.GCompanyID == this.SessionInfo.CompanyID
                                    && WF_AuditRecord._.IsDeleted == false
                                    && WF_AuditRecord._.SourceTableEngName == param.SourceTableEngName;
                stepList = this.SelectList<WF_AuditRecordResult>(whereClip, WF_AuditRecord._.SeqNo.Asc);
                if (stepList == null && stepList.Count <= 0) throw new WarnException("您的相关单据未提交!");
                List<WF_AuditRecordResult> newAuditRecList = new List<WF_AuditRecordResult>();
                WF_AuditRecordResult currAuditRec = new WF_AuditRecordResult();
                #region 撤消所有的审批
                currAuditRec = stepList.LastOrDefault(a => a.IsCurrent == 0);
                billStatus = "New";
                billApproveStatus = "未提交";
                ChangeSourceBllAuditStatus(tblRst, billStatus, billApproveStatus, sourceInfo);
                AfterAuditExeMethod(param.SourceTableEngName, oldStatus, billStatus, tblRst.TriggerStatus, tblRst.AfterAuditMethodPath, tblRst.AfterAuditMethodName, param.SourceBillGuid);
                #region 将后续审批节点失效掉(删除)
                this.Update<WF_AuditRecordResult>(new WF_AuditRecordResult()
                {
                    IsDeleted = true,
                    UpdatedEmpID = this.SessionInfo.UserID,
                    UpdatedEmpName = this.SessionInfo.UserName,
                    UpdatedTime = DateTime.Now
                }, WF_AuditRecord._.IsCurrent >0
                    && WF_AuditRecord._.WFAuditGuid == currAuditRec.WFAuditGuid
                    && WF_AuditRecord._.SourceBillGuid == currAuditRec.SourceBillGuid
                    && WF_AuditRecord._.IsDeleted == false);
                this.Update<WF_AuditRecordLineResult>(new WF_AuditRecordLineResult()
                {
                    IsDeleted = true,
                    UpdatedEmpID = this.SessionInfo.UserID,
                    UpdatedEmpName = this.SessionInfo.UserName,
                    UpdatedTime = DateTime.Now
                }, WF_AuditRecordLine._.IsDeleted == false
                    && WF_AuditRecordLine._.AuditResult.IsNull("") == ""
                    && WF_AuditRecordLine._.WFAuditGuid == currAuditRec.WFAuditGuid
                    && WF_AuditRecordLine._.SourceBillGuid == currAuditRec.SourceBillGuid);
                #endregion
                #endregion
                #region 添加撤消说明
                WF_AuditRecordResult newAuditRec = new WF_AuditRecordResult();
                newAuditRec.WF_RecGuid = Guid.NewGuid();
                newAuditRec.GCompanyID = this.SessionInfo.CompanyID;
                newAuditRec.SourceTableEngName = param.SourceTableEngName;
                newAuditRec.SourceBillNo = currAuditRec.SourceBillNo;
                newAuditRec.SourceBillGuid = param.SourceBillGuid;
                newAuditRec.WFAuditGuid = currAuditRec.WFAuditGuid;
                newAuditRec.WFAuditLineGuid = null;
                newAuditRec.SeqNo = stepList.Max(a => a.SeqNo).ToInt32() + 1;
                newAuditRec.GreeMans = 1;
                newAuditRec.AuditEmpIDs = "," + this.SessionInfo.UserID + ",";//暂时是指定到人
                newAuditRec.AuditEmpNames = this.SessionInfo.UserName;
                newAuditRec.AuditRemark = "被用户" + this.SessionInfo.UserName + operationType;
                newAuditRec.AuditResult = operationType;
                newAuditRec.IsCurrent = 0;
                newAuditRec.CreatedEmpID = this.SessionInfo.UserID;
                newAuditRec.CreatedEmpName = this.SessionInfo.UserName;
                newAuditRec.CreatedTime = DateTime.Now;
                newAuditRec.IsDeleted = false;
                this.Insert<WF_AuditRecordResult>(newAuditRec);
                #endregion
                #endregion
                rst.Key = 1;
            }
            catch (WarnException exp)
            {
                throw exp;
            }
            catch (System.Exception exp)
            {
                LogInfoBLL.WriteLog(this.SessionInfo, exp);
            }
            return rst;
        }
        /// <summary>
        /// 改变当前单据的审批状态
        /// </summary>
        /// <param name="tableRst">关联表字段名</param>
        /// <param name="sourceGuid">业务单据GUID</param>
        /// <param name="addEditInfo">要添加或修改的实体</param>
        /// <param name="approveStatus">审批状态中文说明</param>
        /// <param name="status">审批状态代码</param>
        private void ChangeSourceBllAuditStatus(WF_TableResult tableRst, string status, string approveStatus, object sourceInfo)
        {
            try
            {
                this.CheckSession();
                #region 获取相关方法
                Type typeBll = Type.GetType(tableRst.BillPath + ",ZNLCRM.BLL");
                object bll = Activator.CreateInstance(typeBll);
                #region 设置实体审批状态
                PropertyInfo statusField = sourceInfo.GetType().GetProperty("Status");
                PropertyInfo approveStatusField = sourceInfo.GetType().GetProperty("ApproveStatus");
                if (statusField == null) throw new WarnException("相关单据中不存在审批状态字段!");
                if (approveStatusField == null) throw new WarnException("相关单据中不存在审批状态说明字段!");
                statusField.SetValue(sourceInfo, status, null);
                approveStatusField.SetValue(sourceInfo, approveStatus, null);
                #endregion
                //MethodInfo addMothod = typeBll.GetMethod(tableRst.AddMethodName.ToStringHasNull());
                MethodInfo updateMothod = typeBll.GetMethod(tableRst.UpdateMethodName.ToStringHasNull());
                //if (addMothod == null) throw new WarnException("系统定义的逻辑类添加方法错误!");
                if (updateMothod == null) throw new WarnException("系统定义的逻辑类修改方法错误!");
                if (sourceInfo == null)
                {
                    throw new WarnException("请先保存当前单据新增数据!");
                }
                else
                {
                    updateMothod.Invoke(bll, new object[] { sourceInfo });
                }
                #endregion
            }
            catch (WarnException exp)
            {
                throw exp;
            }
            catch (System.Exception exp)
            {
                LogInfoBLL.WriteLog(this.SessionInfo, exp);
            }
        }
        private object GetSourceAuditStatus(WF_TableResult tableRst, Guid? sourceGuid)
        {
            object ret = null;
            try
            {
                this.CheckSession();
                #region 定义获取的参数
                WF_TableFieldsResult findGuidKeyFld = tableRst.WF_TableFieldList.Find(a => a.IsKeyGuid == true);
                if (findGuidKeyFld == null) throw new WarnException("系统定义的表未定义主键ID!");
                string guidKeyField = findGuidKeyFld.WF_FieldEngName.ToStringHasNull();
                Type typeParam = Type.GetType(tableRst.GetParamPath + ",ZNLCRM.Entity");
                object param = Activator.CreateInstance(typeParam);
                if (param == null) throw new WarnException("系统定义的表定义参数类路错误!");
                typeParam.GetProperty(guidKeyField).SetValue(param, sourceGuid, null);
                #endregion
                #region BLL方法
                Type typeBll = Type.GetType(tableRst.BillPath + ",ZNLCRM.BLL");
                object bll = Activator.CreateInstance(typeBll);
                if (bll == null) throw new WarnException("系统定义的表逻辑类路错误!");
                PropertyInfo sessionInfo = typeBll.GetProperty("SessionInfo");
                if (sessionInfo == null) throw new WarnException("系统定义的逻辑类未发现对话实体！");
                sessionInfo.SetValue(bll, this.SessionInfo, null);
                ret = typeBll.GetMethod(tableRst.GetMethodName.ToStringHasNull()).Invoke(bll, new object[] { param });
                if (ret==null || ret.GetType().GetProperty(guidKeyField).GetValue(ret, null) == null)
                {
                    ret = null;
                }
                #endregion
            }
            catch (WarnException exp)
            {
                throw exp;
            }
            catch (System.Exception exp)
            {
                LogInfoBLL.WriteLog(this.SessionInfo, exp);
            }
            return ret;
        }
        /// <summary>
        /// 审核完成后调用的方法
        /// </summary>
        /// <param name="exeMethodPath">方法路径</param>
        /// <param name="methodName">方法名称</param>
        /// <param name="param">方法要传入的实体</param>
        private void AfterAuditExeMethod(string sourceTableName,string billOldStatus, string billNewStatus,string triggerStatus,string exeMethodPath,string methodName,Guid? sourceBillGuid)
        {
            try
            {
                if (string.IsNullOrEmpty(exeMethodPath))
                {
                    return;
                }
                #region 判断状态是否可触发执行方法
                bool exeOK = false;
                if (triggerStatus.ToLower() == "approve")//提交审核
                {
                    //提交
                    if ((billOldStatus.ToStringHasNull().Trim()=="" || billOldStatus.ToLower() == "new") && billNewStatus.ToLower() == "complete"
                        || (billOldStatus.ToStringHasNull().Trim() == "" || billOldStatus.ToLower() == "new") && billNewStatus.ToLower() == "approve")
                    {
                        exeOK = true;
                    }
                    //撤消
                    if (billOldStatus.ToStringHasNull().Trim() == "complete"  && billNewStatus.ToLower() == "new"
                        || billOldStatus.ToStringHasNull().Trim() == "approve" && billNewStatus.ToLower() == "new")
                    {
                        exeOK = true;
                    }
                }
                if (triggerStatus.ToLower() == "complete")//审核完成
                {
                    if ((billOldStatus.ToStringHasNull().Trim()=="" || billOldStatus.ToLower() == "new") && billNewStatus.ToLower() == "complete"
                        || billOldStatus.ToLower() == "approve" && billNewStatus.ToLower() == "complete")
                    {
                        exeOK = true;
                    }
                    //撤消
                    if (billOldStatus.ToStringHasNull().Trim() == "complete" && billNewStatus.ToLower() == "new")
                    {
                        exeOK = true;
                    }
                }
                if (!exeOK) return;
                #endregion
                #region 产生实例
                object bll = Activator.CreateInstance(Type.GetType(exeMethodPath + ",ZNLCRM.BLL"));
                if (bll == null)
                {
                    throw new WarnException("指定的审核完成后执行的方法类有异常!");
                }
                #endregion
                #region 相关参数
                AuditBillParam param = new AuditBillParam();
                param.SourceBillGuid = sourceBillGuid;
                param.OldBillStatus = billOldStatus;
                param.NewBillStatus = billNewStatus;
                param.TriggerStatus = triggerStatus;
                param.SourceTableName = sourceTableName;
                #endregion
                #region 获取相关方法并执行
                MethodInfo exeMethod = bll.GetType().GetMethod(methodName);
                if (exeMethod == null)
                {
                    throw new WarnException("指定的审核完成后执行的方法有异常!");
                }
                exeMethod.Invoke(bll, new object[] { param });
                #endregion
            }
            catch (WarnException exp)
            {
                throw exp;
            }
            catch (System.Exception exp)
            {
                LogInfoBLL.WriteLog(this.SessionInfo, exp);
            }
        }
        /// <summary>
        /// 获取审核明信息记录
        /// </summary>
        /// <param name="param">条件实体</param>
        /// <returns></returns>
        public List<WF_AuditRecordLineResult> GetAuditRecLineList(WF_AuditRecordLineParam param)
        {
            List<WF_AuditRecordLineResult> rstList = new List<WF_AuditRecordLineResult>();
            try
            {
                this.CheckSession();
                #region 判断
                if (param.WF_RecGuid == null && param.WF_RecGuids == null
                    && param.WFAuditGuid == null && param.WFAuditLineGuid == null) throw new WarnException("请指定审核结果条件！");
                #endregion
                #region 获取主单实体
                WhereClip where = WF_AuditRecordLine._.IsDeleted == false && WF_AuditRecordLine._.GCompanyID == this.SessionInfo.CompanyID;
                if (param.WF_RecGuid != null) where = where && WF_AuditRecordLine._.WF_RecGuid == param.WF_RecGuid;
                if (param.WF_RecGuids != null) where = where && WF_AuditRecordLine._.WF_RecGuid.In(param.WF_RecGuids);

                rstList = this.SelectList<WF_AuditRecordLineResult>(where, WF_AuditRecordLine._.CreatedTime.Asc);
                if (rstList == null)
                {
                    return rstList;
                }
                #endregion
            }
            catch (WarnException exp)
            {
                throw exp;
            }
            catch (System.Exception exp)
            {
                LogInfoBLL.WriteLog(this.SessionInfo, exp);
            }
            return rstList;
        }
        public WCFAddUpdateResult AddOrUpdateAuditRecLine(WF_AuditRecordLineResult param)
        {
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            try
            {
                if (param.WF_RecGuid == null) throw new WarnException("请指定关联审批记录ID！");
                if (param.SourceBillGuid == null) throw new WarnException("请指定关联单据ID！");
                if (param.WFAuditGuid == null) throw new WarnException("请指定关联审批基准ID！");
                if (param.WFAuditLineGuid == null) throw new WarnException("请指定关联审批基准明细ID！");
                if (string.IsNullOrEmpty(param.SourceTableEngName)) throw new WarnException("请指定关联业务表名！");
                //if (string.IsNullOrEmpty(param.SourceBillNo)) throw new WarnException("请指定关联业务单据编号！");
                if (param.WF_RecLineGuid == null)
                {
                    param.WF_RecLineGuid = Guid.NewGuid();
                    param.GCompanyID = this.SessionInfo.CompanyID;
                    param.CreatedEmpID = this.SessionInfo.UserID;
                    param.CreatedEmpName = this.SessionInfo.UserName;
                    param.CreatedTime = DateTime.Now;
                    param.IsDeleted = false;
                    this.Insert<WF_AuditRecordLineResult>(param);
                }
                else
                {
                    param.UpdatedEmpID = this.SessionInfo.UserID;
                    param.UpdatedEmpName = this.SessionInfo.UserName;
                    param.UpdatedTime = DateTime.Now;
                    this.Update<WF_AuditRecordLineResult>(param, WF_AuditRecordLine._.WFAuditLineGuid == param.WF_RecLineGuid);
                }
                ret.Key = param.WF_RecLineID;
                ret.KeyGuid = param.WF_RecLineGuid;
                ret.BillNo = param.SourceBillNo;
                ret.CreatedTime = param.CreatedTime;
                ret.CreatedEmpID = param.CreatedEmpID;
                ret.CreatedEmpName = param.CreatedEmpName;
                ret.UpdatedEmpID = param.UpdatedEmpID;
                ret.UpdatedEmpName = param.UpdatedEmpName;
                ret.UpdatedTime = param.UpdatedTime;
            }
            catch (WarnException exp)
            {
                throw exp;
            }
            catch (System.Exception exp)
            {
                LogInfoBLL.WriteLog(this.SessionInfo, exp);
            }
            return ret;
        }
        /// <summary>
        /// 获取审核列表
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public WF_AuditBillResult GetAuditBillRecord(WF_AuditRecordParam param)
        {
            WF_AuditBillResult ret = new WF_AuditBillResult();
            this.CheckSession();
            if (string.IsNullOrEmpty(param.SourceTableEngName)) throw new WarnException("请指定相关审核业务单据!");
            if (param.SourceBillGuid == null) throw new WarnException("请指定相关审核业务单据的ID!");
            #region 获取相关表定义
            WF_TableResult tblRst = new WF_TableResult();
            WF_TableBLL tblBll = new WF_TableBLL();
            tblBll.SessionInfo = this.SessionInfo;
            tblRst = tblBll.GetInfo(new WF_TableParam()
            {
                WF_TableEngName = param.SourceTableEngName
            });
            if (tblRst == null || tblRst.WF_TableID <= 0)
            {
                throw new WarnException("系统中未发现定义的业务表!");
            }
            if (tblRst.WF_TableFieldList == null || tblRst.WF_TableFieldList.Count < 0)
            {
                throw new WarnException("系统中未发现定义的业务表相关字段!");
            }
            if (!tblRst.WF_TableFieldList.Exists(a => a.IsKeyGuid.ToBooleanHasNull() == true))
            {
                throw new WarnException("系统中未发现定义的业务表相关主键字段!");
            }
            #endregion
            #region 判断当前记录状态
            object sourceInfo = this.GetSourceAuditStatus(tblRst, param.SourceBillGuid);
            string billStatus = sourceInfo.GetType().GetProperty("Status").GetValue(sourceInfo, null).ToStringHasNull();
            string approveStatus = sourceInfo.GetType().GetProperty("ApproveStatus").GetValue(sourceInfo, null).ToStringHasNull();
            #endregion
            #region 审核状态
            WF_AuditBillBLL auditBll = new WF_AuditBillBLL();
            auditBll.SessionInfo = this.SessionInfo;
            ret = auditBll.GetInfo(new WF_AuditBillParam() { TableName = param.SourceTableEngName });
            if (ret == null) return ret;
            PageList<WF_AuditRecordResult> recordRstList = new PageList<WF_AuditRecordResult>();
            recordRstList = GetAuditRecList(new WF_AuditRecordParam() { PageIndex = 1, PageSize = int.MaxValue, SourceTableEngName = param.SourceTableEngName, SourceBillGuid = param.SourceBillGuid });
            ret.WF_AuditRecordResultList = recordRstList.ResultList;
            ret.BillStatus = billStatus;
            ret.ApproveStatus = approveStatus;
            #endregion
            return ret;
        }
        public PageList<WF_AuditRecordResult> GetAuditRecList(WF_AuditRecordParam param)
        {
            this.CheckSession();
            PageList<WF_AuditRecordResult> ret = new PageList<WF_AuditRecordResult>();
            WhereClip whereClip = WF_AuditRecord._.IsDeleted == false && WF_AuditRecord._.GCompanyID == this.SessionInfo.CompanyID;
            OrderByClip orderBy = WF_AuditRecord._.SourceBillGuid.Asc && WF_AuditRecord._.CreatedTime.Asc && WF_AuditRecord._.SeqNo.Asc;
            if (param.SourceTableEngName.ToStringHasNull().Trim() != "") whereClip = whereClip && WF_AuditRecord._.SourceTableEngName == param.SourceTableEngName;
            if (param.SourceBillGuid != null) whereClip = whereClip && WF_AuditRecord._.SourceBillGuid == param.SourceBillGuid;
            ret = this.SelectList<WF_AuditRecordResult>(param.PageIndex.ToInt32(), param.PageSize.ToInt32(), whereClip, orderBy);
            return ret;
        }
    }
}
