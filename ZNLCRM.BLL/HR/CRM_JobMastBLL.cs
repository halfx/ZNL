using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLCRM.BLL.Sys;
using ZNLCRM.Entity.UserModel.HR;
using MySoft.Data;
using ZNLCRM.Entity.DBModel;
using ZNLFrame.Entity;
using ZNLCRM.Utility;
using ZNLCRM.Entity.UserModel.Common;
using ZNLCRM.Entity.UserModel.CRM;
using ZNLCRM.Entity.UserModel.WF;

namespace ZNLCRM.BLL.HR
{
    public class CRM_JobMastBLL:BaseBLL
    {
        public CRM_JobMastBLL()
        {
            
        }
        /// <summary>
        /// 获取条件的公共方法
        /// </summary>
        /// <param name="param">条件实体</param>
        /// <returns></returns>
        WhereClip GetWhereClip(CRM_JobMastParam param)
        {
            this.CheckSession();
            WhereClip where = CRM_JobMast._.IsDeleted == 0;
            if (param.EmpJobGuid != null) where = where && CRM_JobMast._.EmpJobGuid == param.EmpJobGuid;
            if (!string.IsNullOrEmpty(param.JobName)) where = where && CRM_JobMast._.JobName.Like("%" + param.JobName + "%");
            if (!string.IsNullOrEmpty(param.JobType)) where = where && CRM_JobMast._.JobType == param.JobType;
            if (param.JobDateS != null) where = where && CRM_JobMast._.JobDate >= param.JobDateS;
            if (param.JobDateE != null) where = where && CRM_JobMast._.JobDate < param.JobDateE.Value.AddDays(1);

            where = Sys_EmpDataRightBLL.GetEmpIDInWhere(where, CRM_JobMast._.JobDate, CRM_JobMast._.BeLongEmpID, CRM_JobMast._.OrgID, CRM_JobMast._.DeptID, this.SessionInfo);
            return where;
        }
        /// <summary>
        /// 添加和新增修改
        /// </summary>
        /// <param name="param">新增或修改的实体</param>
        /// <returns></returns>
        public WCFAddUpdateResult AddOrUpdate(CRM_JobMastResult param)
        {
            this.CheckSession();
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            try
            {
                int affect = 0;
                #region 判断
                if (param.JobName.ToStringHasNull().Trim() == "") throw new WarnException("请指定报告标题！");
                if (param.JobType.ToStringHasNull().Trim() == "") throw new WarnException("请指定报告类型");
                if (param.JobDate == null) throw new WarnException("请指定报告日期！");
                if (param.JobContext.ToStringHasNull().Trim() == "") throw new WarnException("请指定报告内容！");
                if (param.JobContext.VarcharLen()>8000) throw new WarnException("请指定报告内容超长,请指定4000个汉字，8000个英文！");
                #endregion
                #region 系统默认值
                param.Summary = param.JobContext;
                if (param.EmpJobGuid!=null)
                {
                    WhereClip where = CRM_JobMast._.EmpJobGuid == param.EmpJobGuid;
                    param.GCompanyID = this.SessionInfo.CompanyID;
                    param.UpdatedEmpID = this.SessionInfo.UserID;
                    param.UpdatedTime = DateTime.Now;
                    affect = this.Update<CRM_JobMastResult>(param, where);
                }
                else
                {
                    Sys_CodeRulerBLL codeRulerBll = new Sys_CodeRulerBLL();
                    codeRulerBll.SessionInfo = this.SessionInfo;
                    param.BillNo = codeRulerBll.GetBillNo(new Entity.UserModel.Sys.SYS_CredentialCodeRuleParam() { BillDate = DateTime.Today, TableName = "CRM_JobMast" });
                    param.Status = "New";
                    param.EmpJobGuid = Guid.NewGuid();
                    param.GCompanyID = this.SessionInfo.CompanyID;
                    param.CreatedEmpID = this.SessionInfo.UserID;
                    param.CreatedTime = DateTime.Now;
                    param.BeLongEmpID = this.SessionInfo.UserID;
                    param.BelongEmpName = this.SessionInfo.UserName;
                    param.IsDeleted = false;
                    affect = this.Insert<CRM_JobMastResult>(param);
                }
                #region 设置返回值
                ret.Key = param.EmpJobID;
                ret.KeyGuid = param.EmpJobGuid;
                ret.BillNo = param.BillNo;
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
        public CRM_JobMastResult GetInfo(CRM_JobMastParam param)
        {
            this.CheckSession();
            CRM_JobMastResult rst = new CRM_JobMastResult();
            #region 判断
            if (param.EmpJobGuid == null) throw new WarnException("请指定关键字GUID！");
            #endregion
            #region 保存实体
            WhereClip where = CRM_JobMast._.EmpJobGuid == param.EmpJobGuid;
            where = Sys_EmpDataRightBLL.GetEmpIDInWhere(where, CRM_JobMast._.JobDate, CRM_JobMast._.BeLongEmpID, CRM_JobMast._.OrgID, CRM_JobMast._.DeptID, this.SessionInfo);
            rst = this.Select<CRM_JobMastResult>(where);
            Sys_EmpDataRightBLL.SetRecIsEdit<CRM_JobMastResult>(rst, "BeLongEmpID", "", "OrgID", this.SessionInfo);
            #endregion
            return rst;
        }
        /// <summary>
        /// 获取上一条或下一条记录
        /// </summary>
        /// <param name="param">条件实体</param>
        /// <returns></returns>
        public CRM_JobMastResult GetNextOrPreInfo(CRM_JobMastParam param)
        {
            this.CheckSession();
            CRM_JobMastResult rst = new CRM_JobMastResult();
            #region 判断
            if (param.EmpJobGuid == null) throw new WarnException("请指定关键字GUID！");
            #endregion
            #region 保存实体
            WhereClip where = CRM_JobMast._.EmpJobGuid == param.EmpJobGuid;
            where = Sys_EmpDataRightBLL.GetEmpIDInWhere(where, CRM_JobMast._.JobDate, CRM_JobMast._.BeLongEmpID, CRM_JobMast._.OrgID, CRM_JobMast._.DeptID, this.SessionInfo);
            rst = this.Select<CRM_JobMastResult>(where);
            #endregion
            return rst;
        }
        /// <summary>
        /// 查询记录,并返回分页列表
        /// </summary>
        /// <param name="param">查询条件实体</param>
        /// <returns></returns>
        public PageList<CRM_JobMastResult> GetPageList(CRM_JobMastParam param)
        {
            this.CheckSession();
            PageList<CRM_JobMastResult> rst = new PageList<CRM_JobMastResult>();
            WhereClip where = GetWhereClip(param);
            List<Field> lstField = new List<Field>()
            {
                CRM_JobMast._.EmpJobGuid,CRM_JobMast._.JobName,CRM_JobMast._.JobDate
                ,CRM_JobMast._.BillNo,CRM_JobMast._.BelongEmpName,CRM_JobMast._.ApproveStatus
                ,CRM_JobMast._.JobType,CRM_JobMast._.BeLongEmpID,CRM_JobMast._.OrgID
                ,CRM_JobMast._.Summary,CRM_JobMast._.CreatedEmpName,CRM_JobMast._.CreatedTime
            };
            rst = this.SelectList<CRM_JobMastResult>(param.PageIndex.GetValueOrDefault(1), param.PageSize.GetValueOrDefault(20), lstField, where, CRM_JobMast._.CreatedTime.Desc);
            rst.ResultList = Sys_EmpDataRightBLL.SetRecIsEdit<CRM_JobMastResult>(rst.ResultList, "BeLongEmpID", "", "OrgID", this.SessionInfo);
            return rst;
        }
        /// <summary>
        /// 删除实体
        /// </summary>
        /// <param name="param">删除条件实体</param>
        /// <returns></returns>
        public WCFAddUpdateResult DelInfo(CRM_JobMastParam param)
        {
            this.CheckSession();
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            int affect = 0;
            try
            {
                #region 判断
                if (param.EmpJobGuid == null) throw new WarnException("请指定要删除的记录！");
                #endregion
                WhereClip where = GetWhereClip(param);
                CRM_JobMastResult oldInfo = this.GetInfo(param);
                oldInfo = Sys_EmpDataRightBLL.SetRecIsEdit<CRM_JobMastResult>(oldInfo, "BeLongEmpID", "", "OrgID", this.SessionInfo);
                if (oldInfo.RecStatu != 2)
                {
                    throw new WarnException("您无权删除当前记录！");
                }
                CRM_JobMastResult info = new CRM_JobMastResult();
                info.IsDeleted = true;
                info.UpdatedTime = DateTime.Now;
                info.UpdatedEmpID = this.SessionInfo.UserID;
                affect = this.Update<CRM_JobMastResult>(info, where);
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
        /// 提交审核
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public WCFAddUpdateResult SubmitOrAuditBill(AuditBillParam param)
        {
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            if (param.ExecuteStatus == "PassBill")
            {

            }
            else if (param.ExecuteStatus == "CancelBill")
            {

            }
            return ret;
        }
    }
}
