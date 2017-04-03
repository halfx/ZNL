using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using MySoft.Data;
using ZNLCRM.Entity.UserModel.Common;
using ZNLCRM.Entity.UserModel.Sys;
using ZNLCRM.Utility;
using ZNLFrame.Entity;

namespace ZNLCRM.UI.Logic.Sys
{
    public class Sys_RoleRightLogic : BaseLogic
    {
        public Sys_RoleRightLogic(Form form) : base(form){}


        public PageList<Sys_RoleRightResult> GetRoleRightList(Sys_RoleRightParam param)
        {
            ExeResult rst = Execute("ZNLCRM.BLL.Sys.Sys_RoleRightBLL", "GetRoleRightList", param);
            PageList<Sys_RoleRightResult> pageList = (rst == null ? new PageList<Sys_RoleRightResult>() : ((PageList<Sys_RoleRightResult>)rst.Result));
            return pageList;
        }

        public WCFAddUpdateResult UpdateOrInsertList(List<Sys_RoleRightResult> list)
        {
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.Sys.Sys_RoleRightBLL", "UpdateOrInsertList", list);
            ret = (rst == null ? new WCFAddUpdateResult() : rst.Result as WCFAddUpdateResult);
            return ret;
        }

        public WCFAddUpdateResult AddOrUpdate(Sys_RoleRightResult result)
        {
            if (result == null) throw new ArgumentNullException("result");
            ExeResult rst = Execute("ZNLCRM.BLL.Sys.Sys_RoleRightBLL", "AddOrUpdate", result);
            WCFAddUpdateResult ret = (rst == null ? new WCFAddUpdateResult() : rst.Result as WCFAddUpdateResult);
            return ret;
        }

        public Sys_RoleRightResult GetInfo(Sys_RoleRightParam param)
        {
            var ret = new Sys_RoleRightResult();
            if (param.RoleRightID.ToInt32() <= 0)
            {
                ShowMessage("请指定要修改的记录！");
                return ret;
            }
            ExeResult rst = Execute("ZNLCRM.BLL.Sys.Sys_RoleRightBLL", "GetInfo", param);
            ret = rst == null ? new Sys_RoleRightResult() : rst.Result as Sys_RoleRightResult;
            return ret;
        }

        public WCFAddUpdateResult DelInfo(Sys_RoleRightParam param)
        {
            var ret = new WCFAddUpdateResult();
            if (param.RoleRightID <= 0)
            {
                ShowMessage("请指定要删除的记录！");
                return ret;
            }
            ExeResult rst = Execute("ZNLCRM.BLL.Sys.Sys_RoleRightBLL", "DelInfo", param);
            ret = (rst == null ? new WCFAddUpdateResult() : rst.Result as WCFAddUpdateResult);
            return ret;
        }

    }
}
