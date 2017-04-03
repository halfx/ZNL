using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLCRM.Entity.UserModel.Common;
using ZNLFrame.Entity;
using System.Windows.Forms;
using ZNLCRM.Entity.UserModel.HR;
using System.Data;
using DevComponents.DotNetBar.Controls;
using DevComponents.DotNetBar.SuperGrid;

namespace ZNLCRM.UI.Logic.HR
{
    public  class HR_EmployeeLogic:BaseLogic
    {
          public HR_EmployeeLogic(Form form) : base(form) { }

          public void BindComboBox(object obj, List< HR_EmployeeResult> empList)
          {
            
            if (obj is Controls.UcComboBox)
            {
                Controls.UcComboBox c = obj as Controls.UcComboBox;
                c.ValueMember = "EmpID";
                c.DisplayMember = "EmpName";
                c.DataSource = empList;
            }
            else if (obj is DataGridViewComboBoxColumn)
            {
                DataGridViewComboBoxColumn c = obj as DataGridViewComboBoxColumn;
                c.ValueMember = "EmpID";
                c.DisplayMember = "EmpName";
                c.DataSource = empList;
               
            }
            else if (obj is DataGridViewComboBoxExColumn)
            {
                DataGridViewComboBoxExColumn c = obj as DataGridViewComboBoxExColumn;
                c.ValueMember = "EmpID";
                c.DisplayMember = "EmpName";
                c.DataSource = empList;
               
            }
            else if (obj is GridComboBoxExEditControl)
            {
                GridComboBoxExEditControl c = obj as GridComboBoxExEditControl;
                c.ValueMember = "EmpID";
                c.DisplayMember = "EmpName";
                c.DataSource = empList;
            }

          }

        public WCFAddUpdateResult AddOrUpdate(HR_EmployeeResult param)
        {
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.HR.HR_EmployeeBLL", "AddOrUpdate", param);
            ret = (rst == null ? new WCFAddUpdateResult() : rst.Result as WCFAddUpdateResult);
            return ret;
        }

        public HR_EmployeeResult GetInfo(HR_EmployeeParam param)
        {
            HR_EmployeeResult ret = new HR_EmployeeResult();
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.HR.HR_EmployeeBLL", "GetInfo", param);
            ret = rst == null ? new HR_EmployeeResult() : rst.Result as HR_EmployeeResult;
            return ret;
        }
        public PageList<HR_EmployeeResult> GetPageList(HR_EmployeeParam param)
        {
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.HR.HR_EmployeeBLL", "GetPageList", param);
            PageList<HR_EmployeeResult> pageList = (rst == null ? new  PageList<HR_EmployeeResult>(): (PageList<HR_EmployeeResult>)rst.Result);
            return pageList;

        }
        public List<HR_EmployeeResult> GetEmpList(HR_EmployeeParam param)
        {
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.HR.HR_EmployeeBLL", "GetEmpList", param);
            List<HR_EmployeeResult> pageList = new List<HR_EmployeeResult>();
            pageList = (rst == null ? new List<HR_EmployeeResult>() : rst.Result as List<HR_EmployeeResult>);
            return pageList;
        }
        public WCFAddUpdateResult DelInfo(HR_EmployeeParam param)
        {
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.HR.HR_EmployeeBLL", "DelInfo", param);
            ret = (rst == null ? new WCFAddUpdateResult() : rst.Result as WCFAddUpdateResult);
            return ret;
        }
        
    }
}
