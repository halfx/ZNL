using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLCRM.Entity.UserModel.HR;
using ZNLFrame.Entity;
using ZNLCRM.Entity.UserModel.Common;
using System.Windows.Forms;
using System.Data;

namespace ZNLCRM.UI.Logic.HR
{
    public class HR_DepartmentLogic : BaseLogic
    {
        public HR_DepartmentLogic(Form form) : base(form) { }

        public WCFAddUpdateResult AddOrUpdate(HR_DepartmentResult param)
        {
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.HR.HR_DepartmentBLL", "AddOrUpdate", param);
            ret = (rst == null ? new WCFAddUpdateResult() : rst.Result as WCFAddUpdateResult);
            return ret;
        }

        public HR_DepartmentResult GetInfo(HR_DepartmentParam param)
        {
            HR_DepartmentResult ret = new HR_DepartmentResult();
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.HR.HR_DepartmentBLL", "GetInfo", param);
            ret = rst == null ? new HR_DepartmentResult() : rst.Result as HR_DepartmentResult;
            return ret;
        }
        public PageList<HR_DepartmentResult> GetPageList(HR_DepartmentParam param)
        {
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.HR.HR_DepartmentBLL", "GetPageList", param);
            PageList<HR_DepartmentResult> pageList = (rst == null ? new PageList<HR_DepartmentResult>() : rst.Result as PageList<HR_DepartmentResult>);
            return pageList;

        }
        public List<HR_DepartmentResult> GetDeptList(HR_DepartmentParam param)
        {
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.HR.HR_DepartmentBLL", "GetDeptList", param);
            List<HR_DepartmentResult> pageList = new List<HR_DepartmentResult>();
            pageList = (rst == null ? new List<HR_DepartmentResult>() : rst.Result as List<HR_DepartmentResult>);
            return pageList;
        }
        public WCFAddUpdateResult DelInfo(HR_DepartmentParam param)
        {
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.HR.HR_DepartmentBLL", "DelInfo", param);
            ret = (rst == null ? new WCFAddUpdateResult() : rst.Result as WCFAddUpdateResult);
            return ret;
        }
        public void BindComboBox(Controls.UcComboBox c,HR_DepartmentParam param)
        {
            if (c != null && param != null)
            {
                List<HR_DepartmentResult> deptList = this.GetDeptList(param);
                c.ValueMember = "DeptID";
                c.DisplayMember = "DeptName";
                c.DataSource = deptList;
            }
            
        }

        
    }
}
