using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZNLCRM.UI.Logic.Common;
using ZNLCRM.Entity.UserModel.Sys;
using ZNLCRM.UI.Logic.HR;
using ZNLCRM.UI.Logic.Sys;
using ZNLCRM.Utility;
using ZNLCRM.Entity.UserModel.HR;
using ZNLCRM.Entity.UserModel.Common;

namespace ZNLCRM.UI.SYS
{
    public partial class frmSysEmpDataRight : frmBaseForm
    {
        Sys_RoleLogic roleLogic = null;
        HR_OrgLogic orgLogic = null;
        HR_DepartmentLogic deptLogic = null;
        HR_EmployeeLogic empLogic = null;
        Sys_EmpDataRightLogic empDataRightLogic = null;
        Sys_EmpDataRightResult rst = null;
        public frmSysEmpDataRight()
        {
            InitializeComponent();
            roleLogic = new Sys_RoleLogic(this);
            empDataRightLogic = new Sys_EmpDataRightLogic(this);
            orgLogic = new HR_OrgLogic(this);
            deptLogic = new HR_DepartmentLogic(this);
            empLogic = new HR_EmployeeLogic(this);
            
        }

        #region 窗体加载
        private void frmSysEmpDataRight_Load(object sender, EventArgs e)
        {
           
                Sys_EmpDataRightParam param = new Sys_EmpDataRightParam();
                param.EmpID = txtEmpID.Text.ToInt32();
                rst = empDataRightLogic.GetEmpDataRight(param);
                BindDataGridView();
            
        }
        #endregion

        void BindDataGridView()
        {
            dgvRole.DataSource = roleLogic.GetRolesTree(new Sys_RoleParam() { });
            dgvOrg.DataSource = orgLogic.GetOrgTree(new HR_OrgParam() { });
            dgvDept.DataSource = deptLogic.GetPageList(new HR_DepartmentParam() { });
            dgvEmp.DataSource = empLogic.GetPageList(new HR_EmployeeParam() { });
         
        }

        private void dgvRole_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dgvRole.Rows)
                {
                    if (("," + rst.RoleIDs + ",").Contains("," + row.Cells["colRoleID"].Value.ToStringHasNull() + ","))
                        row.Cells["colSelectRole"].Value = true;
                }
            }
            catch (Exception ex)
            {

                this.ShowMessage(ex.Message);
            }
        }

        private void dgvOrg_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dgvOrg.Rows)
                {
                    if (("," + rst.ReadOrgIDs + ",").Contains("," + row.Cells["colOrgID"].Value.ToStringHasNull() + ","))
                        row.Cells["colReadOrg"].Value = true;

                    if (("," + rst.EditOrgIDs + ",").Contains("," + row.Cells["colOrgID"].Value.ToStringHasNull() + ","))
                        row.Cells["colEditOrg"].Value = true;
                }
            }
            catch (Exception ex)
            {

                this.ShowMessage(ex.Message);
            }
        }

        private void dgvDept_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dgvDept.Rows)
                {
                    if (("," + rst.ReadDeptIDs + ",").Contains("," + row.Cells["colDeptID"].Value.ToStringHasNull() + ","))
                        row.Cells["colReadDept"].Value = true;

                    if (("," + rst.EditDeptIDs + ",").Contains("," + row.Cells["colDeptID"].Value.ToStringHasNull() + ","))
                        row.Cells["colEditDept"].Value = true;
                }
            }
            catch (Exception ex)
            {

                this.ShowMessage(ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            dgvEmp.DataSource = empLogic.GetEmpList(new HR_EmployeeParam() { EmpName = txtSEmpName.Text.ToStringHasNull()});
        }

        private void dgvEmp_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dgvEmp.Rows)
                {
                    if (("," + rst.ReadEmpIDs + ",").Contains("," + row.Cells["colEmpID"].Value.ToStringHasNull() + ","))
                        row.Cells["colReadEmp"].Value = true;

                    if (("," + rst.EditEmpIDs + ",").Contains("," + row.Cells["colEmpID"].Value.ToStringHasNull() + ","))
                        row.Cells["colEditEmp"].Value = true;
                }
             }
            catch (Exception ex)
            {

                this.ShowMessage(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           string roleIDs=string.Empty;
            string roleNames=string.Empty;
            string readOrgIDs=string.Empty;
            string editOrgIDs=string.Empty;
            string readDeptIDs=string.Empty;
            string editDeptIDs=string.Empty;
            string readEmpIDs=string.Empty;
            string editEmpIDs=string.Empty;
            foreach (DataGridViewRow row in dgvRole.Rows)
            { 
              if(row.Cells["colSelectRole"].Value.ToBooleanHasNull())
              {
                  roleIDs += row.Cells["colRoleID"].Value + ",";
                  roleNames += row.Cells["colRoleName"].Value + ",";
              }
            }
            if (roleIDs.Length > 0)
            {
                roleIDs = roleIDs.Substring(0, roleIDs.Length - 1);
                roleNames = roleNames.Substring(0, roleNames.Length - 1);
            }
            foreach (DataGridViewRow row in dgvOrg.Rows)
            {
                if (row.Cells["colReadOrg"].Value.ToBooleanHasNull())
                    readOrgIDs += row.Cells["colOrgID"].Value + ",";
                if (row.Cells["colEditOrg"].Value.ToBooleanHasNull())
                  editOrgIDs += row.Cells["colOrgID"].Value + ",";
            }
            if (readOrgIDs.Length > 0)
                readOrgIDs = readOrgIDs.Substring(0, readOrgIDs.Length - 1);
            if (editOrgIDs.Length>0)
                editOrgIDs = editOrgIDs.Substring(0, editOrgIDs.Length - 1);
            foreach (DataGridViewRow row in dgvDept.Rows)
            {
                if (row.Cells["colReadDept"].Value.ToBooleanHasNull())
                    readDeptIDs += row.Cells["colDeptID"].Value + ",";
                if (row.Cells["colEditDept"].Value.ToBooleanHasNull())
                    editDeptIDs += row.Cells["colDeptID"].Value + ",";
            }
            if (readDeptIDs.Length > 0)
                readDeptIDs = readDeptIDs.Substring(0, readDeptIDs.Length - 1);
            if (editDeptIDs.Length > 0)
                editDeptIDs = editDeptIDs.Substring(0, editDeptIDs.Length - 1);
            foreach (DataGridViewRow row in dgvEmp.Rows)
            {
                if (row.Cells["colReadEmp"].Value.ToBooleanHasNull())
                    readEmpIDs += row.Cells["colEmpID"].Value + ",";
                if (row.Cells["colEditEmp"].Value.ToBooleanHasNull())
                    editEmpIDs += row.Cells["colEmpID"].Value + ",";
            }
            if (readEmpIDs.Length > 0)
                readEmpIDs = readEmpIDs.Substring(0, readEmpIDs.Length - 1);
            if (editDeptIDs.Length > 0)
                editEmpIDs = editEmpIDs.Substring(0, editEmpIDs.Length - 1);

            rst.RoleIDs = roleIDs;
            rst.RoleNames = roleNames;
            rst.ReadOrgIDs = readOrgIDs;
            rst.EditOrgIDs = editOrgIDs;
            rst.ReadDeptIDs = readDeptIDs;
            rst.EditDeptIDs = editDeptIDs;
            rst.ReadEmpIDs = readEmpIDs;
            rst.EditEmpIDs = editEmpIDs;
            WCFAddUpdateResult result = this.AsyncExecute<WCFAddUpdateResult, Sys_EmpDataRightResult>(rst, empDataRightLogic.AddOrUpdate, (a) =>
            {
                BindDataGridView();
            });
        }

        private void dgvEmp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
         
    }
}
