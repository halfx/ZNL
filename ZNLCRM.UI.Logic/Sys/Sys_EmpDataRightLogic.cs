using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLCRM.Entity.UserModel.Sys;
using ZNLFrame.Entity;
using System.Windows.Forms;
using ZNLCRM.Entity.UserModel.Common;
using ZNLCRM.Entity.UserModel.HR;

namespace ZNLCRM.UI.Logic.Sys
{
    public  class Sys_EmpDataRightLogic:BaseLogic
    {
        public Sys_EmpDataRightLogic(Form form) : base(form) { }


        public WCFAddUpdateResult AddOrUpdate(Sys_EmpDataRightResult param)
        {
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.Sys.Sys_EmpDataRightBLL", "AddOrUpdate", param);
            ret = (rst == null ? new WCFAddUpdateResult() : rst.Result as WCFAddUpdateResult);
            return ret;
        }
        public Sys_EmpDataRightResult GetEmpDataRight(Sys_EmpDataRightParam param)
        {
            Sys_EmpDataRightResult ret = new Sys_EmpDataRightResult();
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.Sys.Sys_EmpDataRightBLL", "GetEmpDataRight", param);
            ret = rst == null ? new Sys_EmpDataRightResult() : rst.Result as Sys_EmpDataRightResult;
            return ret;
        }
        public List<HR_EmployeeResult> GetRoleEmpList(Sys_EmpDataRightParam param)
        {
            List<HR_EmployeeResult> ret = new List<HR_EmployeeResult>();
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.Sys.Sys_EmpDataRightBLL", "GetRoleEmpList", param);
            ret = (rst == null ? new List<HR_EmployeeResult>() : rst.Result as List<HR_EmployeeResult>);
            return ret;
        }
        public WCFAddUpdateResult AddRoleEmpIDs(Sys_EmpDataRightParam param)
        {
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.Sys.Sys_EmpDataRightBLL", "AddRoleEmpIDs", param);
            ret = (rst == null ? new WCFAddUpdateResult() : rst.Result as WCFAddUpdateResult);
            return ret;
        }

        public WCFAddUpdateResult DelRoleEmpIDs(Sys_EmpDataRightParam param)
        {
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.Sys.Sys_EmpDataRightBLL", "DelRoleEmpIDs", param);
            ret = (rst == null ? new WCFAddUpdateResult() : rst.Result as WCFAddUpdateResult);
            return ret;
        }
    }
}
