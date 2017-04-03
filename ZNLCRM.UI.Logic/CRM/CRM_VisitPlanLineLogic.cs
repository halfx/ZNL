using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZNLCRM.Entity.UserModel.Common;
using ZNLFrame.Entity;
using ZNLCRM.Entity.UserModel.CRM;

namespace ZNLCRM.UI.Logic.CRM
{
    public   class CRM_VisitPlanLineLogic:BaseLogic
    {
        public CRM_VisitPlanLineLogic(Form form) : base(form) { }

        public WCFAddUpdateResult AddOrUpdate(CRM_VisitPlanLineResult param)
        {
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.CRM.CRM_VisitPlanLineBLL", "AddOrUpdate", param);
            ret = (rst == null ? new WCFAddUpdateResult() : rst.Result as WCFAddUpdateResult);
            return ret;
        }

        public CRM_VisitPlanLineResult GetInfo(CRM_VisitPlanLineParam param)
        {
            CRM_VisitPlanLineResult ret = new CRM_VisitPlanLineResult();
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.CRM.CRM_VisitPlanLineBLL", "GetInfo", param);
            ret = rst == null ? new CRM_VisitPlanLineResult() : rst.Result as CRM_VisitPlanLineResult;
            return ret;
        }
        public List<CRM_VisitPlanLineResult> GetList(CRM_VisitPlanLineParam param)
        {
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.CRM.CRM_VisitPlanLineBLL", "GetList", param);
            List<CRM_VisitPlanLineResult> list = new List<CRM_VisitPlanLineResult>();
            list = (rst == null ? new List<CRM_VisitPlanLineResult>() : rst.Result as List<CRM_VisitPlanLineResult>);
            return list;
        }

        public WCFAddUpdateResult DelInfo(CRM_VisitPlanLineParam param)
        {
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.CRM.CRM_VisitPlanLineBLL", "DelInfo", param);
            ret = (rst == null ? new WCFAddUpdateResult() : rst.Result as WCFAddUpdateResult);
            return ret;
        }

        public WCFAddUpdateResult UpdateOrInsertList(List<CRM_VisitPlanLineResult> list)
        {

            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.CRM.CRM_VisitPlanLineBLL", "UpdateOrInsertList", list);
            ret = (rst == null ? new WCFAddUpdateResult() : rst.Result as WCFAddUpdateResult);
            return ret;
        }
    }
}
