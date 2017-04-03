using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZNLCRM.Entity.UserModel.Common;
using ZNLCRM.Entity.UserModel.Sys;
using ZNLFrame.Entity;
using ZNLCRM.Utility;

namespace ZNLCRM.UI.Logic.Sys
{
    public class Sys_ModuleLogic : BaseLogic
    {
        public Sys_ModuleLogic(Form form) : base(form) { }

        public List<Sys_ModuleResult> GetModuleList(Sys_ModuleParam param)
        {
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.Sys.Sys_ModuleBLL", "GetPageList", param);
            List<Sys_ModuleResult> list = new List<Sys_ModuleResult>();
            list = (rst == null ? new List<Sys_ModuleResult>() : rst.Result as List<Sys_ModuleResult>);
            return list;
        
        }
        public WCFAddUpdateResult AddOrUpdate(Sys_ModuleResult param)
        {
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.Sys.Sys_ModuleBLL", "AddOrUpdate", param);
            ret = (rst == null ? new WCFAddUpdateResult() : rst.Result as WCFAddUpdateResult);
            return ret;
        }

        public Sys_ModuleResult GetInfo(Sys_ModuleParam param)
        {
            Sys_ModuleResult ret = new Sys_ModuleResult();
            ExeResult rst = new ExeResult();
            if (param.ModuleID.ToInt32() <= 0)
            {
                this.ShowMessage("请指定要修改的记录！");
                return ret;
            }
            rst = this.Execute("ZNLCRM.BLL.Sys.Sys_ModuleBLL", "GetInfo", param);
            ret = rst == null ? new Sys_ModuleResult() : rst.Result as Sys_ModuleResult;
            return ret;
        }
        public PageList<Sys_ModuleResult> GetPageList(Sys_ModuleParam param)
        {
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.Sys.Sys_ModuleBLL", "GetPageList", param);
            PageList<Sys_ModuleResult> pageList = new PageList<Sys_ModuleResult>();
            pageList = (rst == null ? new PageList<Sys_ModuleResult>() : rst.Result as PageList<Sys_ModuleResult>);
            return pageList;
        }
        public WCFAddUpdateResult DelInfo(Sys_ModuleParam param)
        {
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            if (param.ModuleID <= 0)
            {
                this.ShowMessage("请指定要删除的记录！");
                return ret;
            }
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.Sys.Sys_ModuleBLL", "DelInfo", param);
            ret = (rst == null ? new WCFAddUpdateResult() : rst.Result as WCFAddUpdateResult);
            return ret;
        }

        public ExeResult GetModuleAndEmp(Sys_ModuleParam param)
        {
            //ExeResult rst = new ExeResult();
            //rst = this.Execute("ZNLCRM.BLL.Sys.Sys_ModuleBLL", "GetPageList", param);
            //PageList<Sys_ModuleResult> pageList = new PageList<Sys_ModuleResult>();
            //pageList = (rst == null ? new PageList<Sys_ModuleResult>() : rst.Result as PageList<Sys_ModuleResult>);
            //return pageList;
           return this.Execute("ZNLCRM.BLL.Sys.Sys_ModuleBLL", "GetModuleAndEmp", param);
        }
    }
}
