using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZNLCRM.Entity.UserModel.Common;
using ZNLFrame.Entity;
using ZNLCRM.Entity.UserModel.Sys;
using ZNLCRM.Utility;
namespace ZNLCRM.UI.Logic.Sys
{
    public class Sys_MenuLogic : BaseLogic
    {
        public Sys_MenuLogic(Form form) : base(form) { }

        public WCFAddUpdateResult AddOrUpdate(Sys_MenuResult param)
        {
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.Sys.Sys_MenuBLL", "AddOrUpdate", param);
            ret = (rst == null ? new WCFAddUpdateResult() : rst.Result as WCFAddUpdateResult);
            return ret;
        }

        public Sys_MenuResult GetInfo(Sys_MenuParam param)
        {
            Sys_MenuResult ret = new Sys_MenuResult();
            ExeResult rst = new ExeResult();
            if (param.MenuID.ToInt32()<=0)
            {
                this.ShowMessage("请指定要修改的记录！");
                return ret;
            }
            rst = this.Execute("ZNLCRM.BLL.Sys.Sys_MenuBLL", "GetInfo", param);
            ret = rst == null ? new Sys_MenuResult() : rst.Result as Sys_MenuResult;
            return ret;
        }
        public List<Sys_MenuResult> GetMenuTree(Sys_MenuParam param)
        {
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.Sys.Sys_MenuBLL", "GetMenuTree", param);
            List<Sys_MenuResult> pageList = new List<Sys_MenuResult>();
            pageList = (rst == null ? new List<Sys_MenuResult>() : rst.Result as List<Sys_MenuResult>);
            return pageList;
        }
        public List<Sys_MenuResult> GetEmpMenuTree(Sys_MenuParam param)
        {
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.Sys.Sys_MenuBLL", "GetEmpMenuTree", param);
            List<Sys_MenuResult> pageList = new List<Sys_MenuResult>();
            pageList = (rst == null ? new List<Sys_MenuResult>() : rst.Result as List<Sys_MenuResult>);
            return pageList;
        }
        public WCFAddUpdateResult DelInfo(Sys_MenuParam param)
        {
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            if (param.MenuID<=0)
            {
                this.ShowMessage("请指定要修改的记录！");
                return ret;
            }
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.Sys.Sys_MenuBLL", "DelInfo", param);
            ret = (rst == null ? new WCFAddUpdateResult() : rst.Result as WCFAddUpdateResult);
            return ret;
        }
    }
}
