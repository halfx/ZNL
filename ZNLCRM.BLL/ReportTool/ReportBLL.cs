using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLCRM.Entity.UserModel.Sys;
using ZNLCRM.Utility;
using ZNLCRM.Entity.UserModel.ReportTool;
using ZNLFrame.Entity;
using MySoft.Data;
using ZNLCRM.Entity.DBModel;
using ZNLCRM.Entity.UserModel.Common;
using ZNLCRM.BLL.Sys;

namespace ZNLCRM.BLL.ReportTool
{
    public class ReportBLL : BaseBLL
    {
        /// <summary>
        /// 获取一条信息记录
        /// </summary>
        /// <param name="param">条件参数</param>
        /// <returns></returns>
        public Sys_ReportResult GetInfo(Sys_ReportParam param)
        {
            this.CheckSession();
            Sys_ReportResult rst = new Sys_ReportResult();
            #region 判断
            if (param.SysRptID.ToInt32() <= 0) throw new WarnException("请指定ID！");
            #endregion
            #region 获取实体
            WhereClip where = Sys_Report._.SysRptID == param.SysRptID && Sys_Report._.IsDeleted == false;
            rst = this.Select<Sys_ReportResult>(where);
            if (rst == null) throw new WarnException("未找到定义的报表设置！");
            List<Sys_ReportSectionResult> reportSections = new List<Sys_ReportSectionResult>();
            reportSections = this.SelectList<Sys_ReportSectionResult>(Sys_ReportSection._.SysRptGuID == rst.SysRptGuID && Sys_ReportSection._.IsDeleted == false, Sys_ReportSection._.OrderSeq.Asc);
            rst.ReportSections = reportSections;
            List<Sys_ReportElementsResult> reportElements = new List<Sys_ReportElementsResult>();
            reportElements = this.SelectList<Sys_ReportElementsResult>(Sys_ReportElements._.SysRptGuID == rst.SysRptGuID && Sys_ReportElements._.IsDeleted == false);
            rst.ReportElements = reportElements;
            #endregion
            return rst;
        }

        /// <summary>
        /// 添加和新增修改
        /// </summary>
        /// <param name="param">新增或修改的实体</param>
        /// <returns></returns>
        public WCFAddUpdateResult AddOrUpdate(Sys_ReportResult param)
        {
            this.CheckSession();
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            try
            {
                int affect = 0;
                #region 判断
                //if (!string.IsNullOrEmpty(param.SysRptID<=0)) throw new WarnException("请指定公司名称！");
                #endregion

                #region 判断重复
                WhereClip whereChk = Sys_Report._.IsDeleted == false && Sys_Report._.RptChsName == param.RptChsName;
                if (param.SysRptID > 0) whereChk = whereChk & Sys_Report._.SysRptID != param.SysRptID;
                int chkNum = this.Count<Sys_ReportResult>(whereChk);
                if (chkNum > 0) throw new WarnException("存在重复的报表名称!");
                #endregion
                #region 保存主单
                if (param.SysRptID > 0)
                {
                    WhereClip where = Sys_Report._.SysRptID == param.SysRptID;
                    param.UpdatedEmpID = this.SessionInfo.UserID;
                    param.UpdatedEmpName = this.SessionInfo.UserName;
                    param.UpdatedTime = DateTime.Now;
                    affect = this.Update<Sys_ReportResult>(param, where);
                }
                else
                {
                    param.CreatedEmpID = this.SessionInfo.UserID;
                    param.CreatedEmpName = this.SessionInfo.UserName;
                    param.CreatedTime = DateTime.Now;
                    param.GCompanyGuID = this.SessionInfo.CompanyID;
                    param.SysRptGuID = Guid.NewGuid();
                    param.IsDeleted = false;
                    affect = this.Insert<Sys_ReportResult>(param);
                    param = this.Select<Sys_ReportResult>(new List<Field>() { Sys_ReportResult._.SysRptID }, Sys_Report._.SysRptGuID == param.SysRptGuID);
                }
                #endregion
                #region 保存带区
                int[] editIDs = param.ReportSections.Where(a => a.RptSectionID > 0).Select(a => a.RptSectionID).Distinct().ToArray();
                foreach (Sys_ReportSectionResult info in param.ReportSections)
                {
                    info.AttachAll();
                    info.SysRptGuID = param.SysRptGuID;
                    info.IsDeleted = false;
                }
                if (editIDs.Length > 0)
                {
                    this.Delete<Sys_ReportSectionResult>(!Sys_ReportSection._.RptSectionID.In(editIDs));
                }
                if (param.ReportSections.Count > 0)
                {
                    this.BatchInsertOrUpdate<Sys_ReportSectionResult>(param.ReportSections);
                    this.BatchExecute();
                }
                #endregion
                #region 保存元素值
                editIDs = param.ReportElements.Where(a => a.RptEleID > 0).Select(a => a.RptEleID).Distinct().ToArray();
                foreach (Sys_ReportElementsResult info in param.ReportElements)
                {
                    info.AttachAll();
                    info.SysRptGuID = param.SysRptGuID;
                    info.IsDeleted = false;
                }
                if (editIDs.Length > 0)
                {
                    this.Delete<Sys_ReportElementsResult>(!Sys_ReportElements._.RptEleID.In(editIDs));
                }
                if (param.ReportElements.Count > 0)
                {
                    this.BatchInsertOrUpdate<Sys_ReportElementsResult>(param.ReportElements);
                    this.BatchExecute();
                }
                #endregion
                #region 设置返回值
                ret.Key = param.SysRptID;
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

    }
}
