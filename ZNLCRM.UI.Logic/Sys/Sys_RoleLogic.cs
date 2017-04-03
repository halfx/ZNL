using System.Collections.Generic;
using System.Windows.Forms;
using ZNLCRM.Entity.UserModel.Common;
using ZNLCRM.Entity.UserModel.Sys;
using ZNLCRM.Utility;
using ZNLFrame.Entity;

namespace ZNLCRM.UI.Logic.Sys
{
    public class Sys_RoleLogic : BaseLogic
    {
        public Sys_RoleLogic(Form form) : base(form)
        {
        }

        public List<Sys_RoleResult> GetRolesTree(Sys_RoleParam sysRoleParam)
        {
            ExeResult rst = Execute("ZNLCRM.BLL.Sys.Sys_RolesBLL", "GetRolesTree", sysRoleParam);
            List<Sys_RoleResult> pageList = (rst == null ? new List<Sys_RoleResult>() : rst.Result as List<Sys_RoleResult>);
            return pageList;
        }

        public WCFAddUpdateResult AddOrUpdate(Sys_RoleResult param)
        {
            ExeResult rst = Execute("ZNLCRM.BLL.Sys.Sys_RolesBLL", "AddOrUpdate", param);
            WCFAddUpdateResult ret = (rst == null ? new WCFAddUpdateResult() : rst.Result as WCFAddUpdateResult);
            return ret;
        }

        public Sys_RoleResult GetInfo(Sys_RoleParam param)
        {
            var ret = new Sys_RoleResult();
            if (param.RoleID.ToInt32() <= 0)
            {
                ShowMessage("请指定要修改的记录！");
                return ret;
            }
            ExeResult rst = Execute("ZNLCRM.BLL.Sys.Sys_RolesBLL", "GetInfo", param);
            ret = rst == null ? new Sys_RoleResult() : rst.Result as Sys_RoleResult;
            return ret;
        }

        public WCFAddUpdateResult DelInfo(Sys_RoleParam param)
        {
            var ret = new WCFAddUpdateResult();
            if (param.RoleID <= 0)
            {
                ShowMessage("请指定要修改的记录！");
                return ret;
            }
            ExeResult rst = Execute("ZNLCRM.BLL.Sys.Sys_RolesBLL", "DelInfo", param);
            ret = (rst == null ? new WCFAddUpdateResult() : rst.Result as WCFAddUpdateResult);
            return ret;
        }
    }
}