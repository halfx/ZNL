using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZNLCRM.Entity.UserModel.Common;
using ZNLFrame.Entity;
using ZNLCRM.Entity.UserModel.CRM;
using ZNLCRM.Entity.UserModel;

namespace ZNLCRM.UI.Logic.CRM
{
    public class CRM_VisitPlanLogic:BaseLogic
    {
        public CRM_VisitPlanLogic(Form form) : base(form) { }

        public WCFAddUpdateResult AddOrUpdate(CRM_VisitPlanResult param)
        {
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.CRM.CRM_VisitPlanBLL", "AddOrUpdate", param);
            ret = (rst == null ? new WCFAddUpdateResult() : rst.Result as WCFAddUpdateResult);
            return ret;
        }

        public CRM_VisitPlanResult GetInfo(CRM_VisitPlanParam param)
        {
            CRM_VisitPlanResult ret = new CRM_VisitPlanResult();
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.CRM.CRM_VisitPlanBLL", "GetInfo", param);
            ret = rst == null ? new CRM_VisitPlanResult() : rst.Result as CRM_VisitPlanResult;
            return ret;
        }
        public PageList<CRM_VisitPlanResult> GetPageList(CRM_VisitPlanParam param)
        {
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.CRM.CRM_VisitPlanBLL", "GetPageList", param);
            PageList<CRM_VisitPlanResult> pageList = new PageList<CRM_VisitPlanResult>();
            pageList = (rst == null ? new PageList<CRM_VisitPlanResult>() : rst.Result as PageList<CRM_VisitPlanResult>);
            return pageList;
        }

        public WCFAddUpdateResult DelInfo(CRM_VisitPlanParam param)
        {
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.CRM.CRM_VisitPlanBLL", "DelInfo", param);
            ret = (rst == null ? new WCFAddUpdateResult() : rst.Result as WCFAddUpdateResult);
            return ret;
        }

        public WCFAddUpdateResult UpdateOrInsertList(List<CRM_VisitPlanResult> list)
        {

            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.CRM.CRM_VisitPlanBLL", "UpdateOrInsertList", list);
            ret = (rst == null ? new WCFAddUpdateResult() : rst.Result as WCFAddUpdateResult);
            return ret;
        }
    }
}
