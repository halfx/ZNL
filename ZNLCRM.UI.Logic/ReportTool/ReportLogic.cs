using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLCRM.Entity.UserModel.ReportTool;
using ZNLFrame.Entity;
using System.Windows.Forms;
using ZNLCRM.Entity.UserModel.Common;

namespace ZNLCRM.UI.Logic.ReportTool
{
    public class ReportLogic:BaseLogic
    {
        public ReportLogic(Form form) : base(form) { }

        public Sys_ReportResult GetInfo(Sys_ReportParam param)
        {
            Sys_ReportResult ret = new Sys_ReportResult();
            ExeResult rst = new ExeResult();
            if (param.SysRptID == null)
            {
                this.ShowMessage("请指定要修改的记录！");
                return ret;
            }
            rst = this.Execute("ZNLCRM.BLL.ReportTool.ReportBLL", "GetInfo", param);
            ret = rst == null ? new Sys_ReportResult() : rst.Result as Sys_ReportResult;
            return ret;
        }

        public WCFAddUpdateResult AddOrUpdate(Sys_ReportResult param)
        {
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            ExeResult rst = new ExeResult();
            if (param.SysRptID == null)
            {
                this.ShowMessage("请指定要修改的记录！");
                return ret;
            }
            rst = this.Execute("ZNLCRM.BLL.ReportTool.ReportBLL", "AddOrUpdate", param);
            ret = rst == null ? new WCFAddUpdateResult() : rst.Result as WCFAddUpdateResult;
            return ret; 

        }
    }
}
