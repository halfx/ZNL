using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLCRM.Entity.UserModel.WF;
using ZNLFrame.Entity;
using ZNLCRM.Entity.DBModel;
using MySoft.Data;
using ZNLCRM.BLL.Sys;
using ZNLCRM.Utility;

namespace ZNLCRM.BLL.WF
{
    public class WF_AuditBillBLL:BaseBLL
    {
        /// <summary>
        /// 获取一条信息记录
        /// </summary>
        /// <param name="param">条件实体</param>
        /// <returns></returns>
        public WF_AuditBillResult GetInfo(WF_AuditBillParam param)
        {
            WF_AuditBillResult rst = new WF_AuditBillResult();
            try
            {
                this.CheckSession();
                #region 判断
                if (param.WFAuditGuid == null 
                    && param.TableName.ToStringHasNull().Trim()=="") throw new WarnException("请指定获取审核单据的条件！");
                #endregion
                #region 获取主单实体
                WhereClip where = WF_AuditBill._.GCompanyID == this.SessionInfo.CompanyID && WF_AuditBill._.IsDeleted == false && WF_AuditBill._.IsStop==false;
                if (param.WFAuditGuid != null) where = where && WF_AuditBill._.WFAuditGuid == param.WFAuditGuid;
                if (param.TableName.ToStringHasNull().Trim() != "") where = where && WF_AuditBill._.TableName == param.TableName;
                rst = this.Select<WF_AuditBillResult>(where);
                #endregion
                #region 获取明细实体
                if (rst != null && rst.WFAuditGuid!=null)
                {
                    where = WF_AuditBillLine._.WFAuditGuid == rst.WFAuditGuid
                            && WF_AuditBillLine._.GCompanyID == this.SessionInfo.CompanyID
                            && WF_AuditBillLine._.IsDeleted == false;
                    List<WF_AuditBillLineResult> lineRst = new List<WF_AuditBillLineResult>();
                    lineRst = this.SelectList<WF_AuditBillLineResult>(where, WF_AuditBillLine._.StepNo.Asc);
                    rst.WF_AuditBillLineList = lineRst;
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
            return rst;
        }
    }
}
