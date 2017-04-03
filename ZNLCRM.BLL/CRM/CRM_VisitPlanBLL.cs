using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySoft.Data;
using ZNLCRM.Entity.UserModel.CRM;
using ZNLCRM.Entity.DBModel;
using ZNLCRM.Entity.UserModel.Common;
using ZNLFrame.Entity;
using ZNLCRM.Utility;
using ZNLCRM.BLL.Sys;

namespace ZNLCRM.BLL.CRM
{
    public  class CRM_VisitPlanBLL:BaseBLL
    {
        /// <summary>
        /// 获取条件的公共方法
        /// </summary>
        /// <param name="param">条件实体</param>
        /// <returns></returns>
        WhereClip GetWhereClip(CRM_VisitPlanParam param)
        {
            this.CheckSession();
            WhereClip where = CRM_VisitPlan._.IsDeleted == 0;
            if (param.CustVstPlnID != null) where = where && CRM_VisitPlan._.CustVstPlnID == param.CustVstPlnID;
            if (param.CustVstPlnGuID != null) where = where && CRM_VisitPlan._.CustVstPlnGuID == param.CustVstPlnGuID;
            if (param.PlanName != null) where = where && CRM_VisitPlan._.PlanName.Like("%" + param.PlanName + "%");
            where = Sys_EmpDataRightBLL.GetEmpIDInWhere(where, CRM_VisitPlan._.CreatedTime, CRM_VisitPlan._.OpEmpID, CRM_VisitPlan._.OrgID, CRM_VisitPlan._.DeptID, this.SessionInfo);

            return where;
        }
        /// <summary>
        /// 添加和新增修改
        /// </summary>
        /// <param name="param">新增或修改的实体</param>
        /// <returns></returns>
        public WCFAddUpdateResult AddOrUpdate(CRM_VisitPlanResult param)
        {
            this.CheckSession();
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            try
            {

                int affect = 0;
                #region 判断
                if (param.CompanyGuID==Guid.Empty) throw new WarnException("请选择跟踪的客户！");
                if (string.IsNullOrEmpty(param.PlanName)) throw new WarnException("请指定跟踪主题！");
                if (string.IsNullOrEmpty(param.VstText)) throw new WarnException("请填写拜访内容！");
                if (string.IsNullOrEmpty(param.VstTyp)) throw new WarnException("请选择拜访类型！");
                if (param.OpEmpID.ToInt32()<=0) throw new WarnException("请选择所属人！");
                if (param.StartDate == null) throw new WarnException("请选择开始时间！");
                #endregion
                #region 系统默认值
                if (param.CustVstPlnID.ToInt32() > 0)
                {
                    WhereClip where = CRM_VisitPlan._.CustVstPlnID == param.CustVstPlnID;
                    param.GCompanyGuID = this.SessionInfo.CompanyID;
                    param.UpdatedEmpID = this.SessionInfo.UserID;
                    param.UpdatedEmpName = this.SessionInfo.UserName;
                    param.UpdatedTime = DateTime.Now;
                    affect = this.Update<CRM_VisitPlanResult>(param, where);
                }
                else
                {
                    Sys_CodeRulerBLL codeRulerBll = new Sys_CodeRulerBLL();
                    codeRulerBll.SessionInfo = this.SessionInfo;
                    param.BillNo = param.BillNo = codeRulerBll.GetBillNo(new Entity.UserModel.Sys.SYS_CredentialCodeRuleParam() { BillDate = DateTime.Today, TableName = "CRM_VisitPlan" });
                    param.GCompanyGuID = this.SessionInfo.CompanyID;
                    param.CustVstPlnGuID = Guid.NewGuid();
                    param.CreatedEmpID = this.SessionInfo.UserID;
                    param.CreatedEmpName = this.SessionInfo.UserName;
                    param.CreatedTime = DateTime.Now;
                    param.TraceStatus = "计划跟踪";
                    param.IsDeleted = false;
                    param.IsRead = false;
                    affect = this.Insert<CRM_VisitPlanResult>(param);
                    param = this.Select<CRM_VisitPlanResult>(new List<Field>() { CRM_VisitPlan._.CustVstPlnID, CRM_VisitPlan._.CustVstPlnGuID }, CRM_VisitPlan._.CustVstPlnGuID == param.CustVstPlnGuID);
                }
                #region 设置返回值
                ret.Key = param.CustVstPlnID;
                ret.KeyGuid = param.CustVstPlnGuID;
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
        public CRM_VisitPlanResult GetInfo(CRM_VisitPlanParam param)
        {
            this.CheckSession();
            CRM_VisitPlanResult rst = new CRM_VisitPlanResult();
            #region 判断
            if (param.CustVstPlnID == null && param.CustVstPlnGuID==null) throw new WarnException("请指定拜访计划主单ID或者GUID！");
            #endregion
            #region 保存实体
            WhereClip where = GetWhereClip(param);

            rst = this.Select<CRM_VisitPlanResult>(where);
            if (rst.CompanyGuID != null)
            {
              CRM_CompanyBLL companyBLL=   new CRM_CompanyBLL();
                companyBLL.SessionInfo=this.SessionInfo;
                CRM_CompanyResult companyRst = companyBLL.GetCustInfo(new CRM_CompanyParam { CompanyGuID = rst.CompanyGuID });
               if (companyRst != null)
                   rst.CrmCompany = companyRst;
              CRM_VisitPlanLineBLL visitPlanLineBLL=   new CRM_VisitPlanLineBLL();
                visitPlanLineBLL.SessionInfo=this.SessionInfo;
                DateTime? lastVistTime = visitPlanLineBLL.GetLastVisitTime(new CRM_VisitPlanLineParam() { CustVstPlnGuID = rst.CustVstPlnGuID });
                if(lastVistTime!=null)
                {
                    rst.LastVisitTime = lastVistTime.ToStringHasNull();
                }
                rst.TotalVisitCount = visitPlanLineBLL.GetTotalVisitCount(new CRM_VisitPlanLineParam() { CustVstPlnGuID = rst.CustVstPlnGuID });
               
            }
            //Sys_EmpDataRightBLL.SetRecIsEdit<CRM_VisitPlanResult>(rst, "BeLongEmpID", "", "OrgID", this.SessionInfo);
            #endregion
            return rst;
        }


        /// <summary>
        /// 查询记录,并返回分页列表
        /// </summary>
        /// <param name="param">查询条件实体</param>
        /// <returns></returns>
        public PageList<CRM_VisitPlanResult> GetPageList(CRM_VisitPlanParam param)
        {
            this.CheckSession();
            PageList<CRM_VisitPlanResult> rst = new PageList<CRM_VisitPlanResult>();
            WhereClip where = GetWhereClip(param);
            List<Field> lstField = new List<Field>()
            {
                CRM_VisitPlan._.All
               
            };
            rst = this.SelectList<CRM_VisitPlanResult>(param.PageIndex.GetValueOrDefault(1), param.PageSize.GetValueOrDefault(50), lstField, where, CRM_VisitPlan._.CreatedTime.Desc);
            Guid?[] arrCompanyID = rst.ResultList.Select(a => a.CompanyGuID).ToArray().Distinct().ToArray() ;
            List<CRM_CompanyResult> lstCompany = new List<CRM_CompanyResult>();
            CRM_CompanyBLL companyBll = new CRM_CompanyBLL();
            companyBll.SessionInfo = this.SessionInfo;
            if (arrCompanyID.Length > 0)
            {
                lstCompany = companyBll.GetComapnyListByFilter(new List<Field>() { CRM_Company._.CompanyName, CRM_Company._.CompanyGuID }, CRM_Company._.CompanyGuID.In(arrCompanyID));
            }
            CRM_CompanyResult findCompany;
            foreach (CRM_VisitPlanResult info in rst.ResultList)
            {
                findCompany = lstCompany.Find(a => a.CompanyGuID == info.CompanyGuID);
                if (findCompany != null)
                {
                    info.CompanyName = findCompany.CompanyName;
                }
            }
            // rst.ResultList = Sys_EmpDataRightBLL.SetRecIsEdit<CRM_VisitPlanResult>(rst.ResultList, "BeLongEmpID", "", "OrgID", this.SessionInfo);
            return rst;
        }
        /// <summary>
        /// 删除实体
        /// </summary>
        /// <param name="param">删除条件实体</param>
        /// <returns></returns>
        public WCFAddUpdateResult DelInfo(CRM_VisitPlanParam param)
        {
            this.CheckSession();
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            int affect = 0;
            try
            {
                #region 判断
                if (param.CustVstPlnID == null) throw new WarnException("请指定要删除的记录！");
                #endregion
                WhereClip where = GetWhereClip(param);
                //CRM_VisitPlanResult oldInfo = this.GetInfo(param);
                //oldInfo = Sys_EmpDataRightBLL.SetRecIsEdit<CRM_VisitPlanResult>(oldInfo, "BeLongEmpID", "", "OrgID", this.SessionInfo);
                //if (oldInfo.RecStatu != 2)
                //{
                //    throw new WarnException("您无权删除当前记录！");
                //}
                CRM_VisitPlanResult info = new CRM_VisitPlanResult();
                info.IsDeleted = true;
                info.UpdatedTime = DateTime.Now;
                info.UpdatedEmpID = this.SessionInfo.UserID;
                info.UpdatedEmpName = this.SessionInfo.UserName;
                affect = this.Update<CRM_VisitPlanResult>(info, where);
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
        public WCFAddUpdateResult UpdateOrInsertList(List<CRM_VisitPlanResult> list)
        {
            this.CheckSession();
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            try
            {
                #region 判断
                if (list.Count <= 0) throw new WarnException("没有需要操作的对象！");
                #endregion
                int affect = 0;
                this.BatchInsertOrUpdate<CRM_VisitPlanResult>(list);
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
