using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLCRM.Entity.UserModel.HR;
using ZNLFrame.Entity;
using ZNLCRM.Utility;
using System.Windows.Forms;
using ZNLCRM.Entity.UserModel.Common;
using ZNLCRM.Entity.UserModel.CRM;

namespace ZNLCRM.UI.Logic.HR
{
    public class CRM_JobMastLogic:BaseLogic
    {
        public CRM_JobMastLogic(Form form) : base(form) { }

        public WCFAddUpdateResult AddOrUpdate(CRM_JobMastResult param)
        {
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.HR.CRM_JobMastBLL", "AddOrUpdate", param);
            ret = (rst == null ? new WCFAddUpdateResult() : rst.Result as WCFAddUpdateResult);
            return ret;
        }

        public CRM_JobMastResult GetInfo(CRM_JobMastParam param)
        {
            CRM_JobMastResult ret = new CRM_JobMastResult();
            ExeResult rst = new ExeResult();
            if (param.EmpJobGuid == null)
            {
                this.ShowMessage("请指定要修改的记录！");
                return ret;
            }
            rst = this.Execute("ZNLCRM.BLL.HR.CRM_JobMastBLL", "GetInfo", param);
            ret = rst == null ? new CRM_JobMastResult() : rst.Result as CRM_JobMastResult;
            return ret;
        }
        public PageList<CRM_JobMastResult> GetPageList(CRM_JobMastParam param)
        {
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.HR.CRM_JobMastBLL", "GetPageList", param);
            PageList<CRM_JobMastResult> pageList = new PageList<CRM_JobMastResult>();
            pageList = (rst == null ? new PageList<CRM_JobMastResult>() : rst.Result as PageList<CRM_JobMastResult>);
            return pageList;
        }

        public WCFAddUpdateResult DelInfo(CRM_JobMastParam param)
        {
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            if (param.EmpJobGuid == null)
            {
                this.ShowMessage("请指定要修改的记录！");
                return ret;
            }
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.HR.CRM_JobMastBLL", "DelInfo", param);
            ret = (rst==null?new WCFAddUpdateResult():rst.Result as WCFAddUpdateResult);
            return ret;
        }
    }
}
