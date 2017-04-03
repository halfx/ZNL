using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZNLCRM.Entity.UserModel.HR;
using ZNLCRM.Entity.UserModel.Common;
using ZNLCRM.UI.Logic.Common;
using ZNLCRM.UI.Logic.HR;

namespace ZNLCRM.UI.HR
{
    public partial class frmEmpManage : frmBaseForm
    {
        Guid? orgGuID = Guid.Empty;
        Guid? deptGuID = Guid.Empty;
        int? orgID = 0;
        int? deptID = 0;
        int level = 0;
        HR_OrgLogic orgLogic = null;
        HR_DepartmentLogic deptLogic = null;
        HR_EmployeeLogic empLogic = null;
        Point pt;
        public frmEmpManage()
        {
            InitializeComponent();
            orgLogic = new HR_OrgLogic(this);
            deptLogic = new HR_DepartmentLogic(this);
            empLogic = new HR_EmployeeLogic(this);
        }

        #region 窗体加载事件
        private void frmEmpManage_Load(object sender, EventArgs e)
        {
            BindOrgTree();
        }
        #endregion

        #region 组织机构树节点选择
        private void trOrg_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (trOrg.SelectedNode != null)
            {
                string[] arr = trOrg.SelectedNode.Tag.ToString().Split(',');
                orgID = int.Parse(arr[0]);
                orgGuID = Guid.Parse(arr[1]);
                txtOrgGuID.Text = arr[1];
                deptID = int.Parse(arr[2]);
                level = int.Parse(arr[3]);
                if (deptID == 0)
                {
                    tsmiEditOrg.Visible = true;
                    tsmiDelOrg.Visible = true;
                    tsmiAddDept.Visible = false;
                    tsmiEditDept.Visible = false;
                    tsmiDelDept.Visible = false;
                }
                else
                {
                    tsmiEditOrg.Visible = false;
                    tsmiDelOrg.Visible = false;
                    tsmiAddDept.Visible = true;
                    tsmiEditDept.Visible = true;
                    tsmiDelDept.Visible = true;
                }
                SearchEmp();
            }
        }
        #endregion

        #region 绑定机构树
        void BindOrgTree()
        { 
           
            this.trOrg.Nodes.Clear();
            List<HR_OrgResult> lstRst = orgLogic.GetOrgTree(new HR_OrgParam() { });
            List<HR_DepartmentResult> lstDeptRst = deptLogic.GetDeptList(new HR_DepartmentParam() { });
            DevComponents.AdvTree.Node orgNode=null;
            foreach (HR_OrgResult rst in lstRst)
            { 
                orgNode=new DevComponents.AdvTree.Node();
                orgNode.VerticalCellLayoutAlignment = DevComponents.AdvTree.eHorizontalAlign.Left;
                orgNode.CellLayout = DevComponents.AdvTree.eCellLayout.Vertical;
                orgNode.Text="["+rst.OrgNo+"]"+rst.OrgName;
                orgNode.Name= "trnOrg" + rst.OrgID;
                orgNode.Tag = rst.OrgID+","+ rst.OrgGuID + "," + 0 + "," + orgNode.Level;
                orgNode.Image = global::ZNLCRM.UI.Properties.Resources.org;
                trOrg.Nodes.Add(orgNode);
                BindDeptTree(rst.OrgGuID, 0, lstDeptRst, orgNode);
              
            }
            trOrg.ExpandAll();
        }
        #endregion

        #region 绑定机构下部门
        void BindDeptTree(Guid? orgGuID, int parentID,List<HR_DepartmentResult> list,DevComponents.AdvTree.Node parentNode)
        {
            DevComponents.AdvTree.Node deptNode = null;
            List<HR_DepartmentResult> deptList = list.Where(a => a.OrgGuID == orgGuID && a.ParentID == parentID).ToList();
            if (deptList != null)
            {
                foreach (HR_DepartmentResult rst in deptList)
                {
                    deptNode = new DevComponents.AdvTree.Node();
                    deptNode.VerticalCellLayoutAlignment = DevComponents.AdvTree.eHorizontalAlign.Left;
                    deptNode.CellLayout = DevComponents.AdvTree.eCellLayout.Vertical;
                    deptNode.Text = "[" + rst.DeptNo + "]" + rst.DeptName;
                    deptNode.Name = "trnDept" + rst.DeptID;
                    deptNode.Tag = rst.OrgID+","+rst.OrgGuID + "," + rst.DeptID+","+deptNode.Level;
                    deptNode.Image = ZNLCRM.UI.Properties.Resources.dept;
                    parentNode.Nodes.Add(deptNode);
                    BindDeptTree(orgGuID, rst.DeptID, list, deptNode);
                }
            }
             
        }
        #endregion

        #region 清除机构编辑窗体控件的内容
        private void ClearOrgConent()
        {
            txtOrgID.Text = string.Empty;
            txtOrgGuID.Text = string.Empty;
            txtOrgNo.Text = string.Empty;
            txtOrgName.Text = string.Empty;
        }
        #endregion

        #region 添加机构
        private void btnAddOrg_Click(object sender, EventArgs e)
        {
           
            this.ShowEditWindow("添加机构", grpOrg);
            ClearOrgConent();
            txtOrgGuID.Text = Guid.Empty.ToString();
        }
        #endregion

        #region 修改组织机构
        private void btnEditOrg_Click(object sender, EventArgs e)
        {
            ClearOrgConent();
            txtOrgGuID.Text=orgGuID.ToString();
            if (Guid.Parse(txtOrgGuID.Text)!=Guid.Empty)
            {
                ShowEditWindow("编辑机构信息",grpOrg);
                HR_OrgResult info = new HR_OrgResult();
                info = orgLogic.GetInfo(new HR_OrgParam() { OrgGuID = Guid.Parse(txtOrgGuID.Text) });
                this.ConvertEntityToControl<HR_OrgResult>(this.grpOrg.Controls, info, null);
            }
            else
                ShowMessage("请选择需要修改机构！");

        }
        #endregion

        #region 右键修改机构
        private void tsmiEditOrg_Click(object sender, EventArgs e)
        {
            btnEditOrg_Click(sender, e);

        }
        #endregion

        #region 保存机构
        private void btnSaveOrg_Click(object sender, EventArgs e)
        {
            HR_OrgResult info = new HR_OrgResult();
            info.OrgGuID =Guid.Parse(txtOrgGuID.Text);
            info = this.ConvertControlToEntity<HR_OrgResult>(this.grpOrg.Controls, info, null);
            WCFAddUpdateResult result = this.AsyncExecute<WCFAddUpdateResult, HR_OrgResult>(info, orgLogic.AddOrUpdate, (a)=>{
                this.HidEditWindow();
                BindOrgTree();
            });
        }
        #endregion

        #region 取消机构编辑窗体
        private void btnCancelOrg_Click(object sender, EventArgs e)
        {
            this.HidEditWindow();
        }
        #endregion

        #region 删除机构
        private void btnDelOrg_Click(object sender, EventArgs e)
        {
            
          
            HR_OrgParam param = new HR_OrgParam();
            param.OrgGuID = orgGuID;
           
            HR_OrgResult rst=  orgLogic.GetInfo(param);
            if (rst != null)
            {
                if (MessageBox.Show("请确认是否要删除机构：【"+rst.OrgName+"】", "操作提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    WCFAddUpdateResult result = this.AsyncExecute<WCFAddUpdateResult, HR_OrgParam>(param, orgLogic.DelInfo, (a) => { BindOrgTree(); });
                }
            }
            else
            {
                this.ShowMessage("请选择需要删除的机构！");
            }
            
        }
        #endregion 

        #region 右键删除机构
        private void tsmiDelOrg_Click(object sender, EventArgs e)
        {
            btnDelOrg_Click(sender, e);
        }
        #endregion

        #region  清楚部门编辑窗体控件的内容
        private void ClearDeptContent()
        {
            txtDeptID.Text = string.Empty;
            txtParentDeptName.Text = string.Empty;
            txtDeptOrgName.Text = string.Empty;
            txtDeptName.Text = string.Empty;
            txtDeptNo.Text = string.Empty;
            txtOrgName.Text = string.Empty;
        
        }
        #endregion

        #region 添加部门
        private void btnAddDept_Click(object sender, EventArgs e)
        {
            this.ShowEditWindow("添加部门", grpDept);
            
            ClearDeptContent();
            txtDeptID.Text = "0";
            txtParentID.Text = deptID.ToString();
            txtDeptOrgGuID.Text = orgGuID.ToString();
            txtDeptOrgID.Text = orgID.ToString();
        }
        #endregion

        #region 修改部门
        private void btnEditDept_Click(object sender, EventArgs e)
        {
            ClearDeptContent();
            txtDeptID.Text = deptID.ToString();
            txtDeptOrgGuID.Text = orgGuID.ToString();
            if (Guid.Parse(txtDeptOrgGuID.Text) != Guid.Empty && int.Parse(txtDeptID.Text) != 0)
            {
                this.ShowEditWindow("编辑部门信息", grpDept);
                HR_DepartmentResult info = new HR_DepartmentResult();
                info = deptLogic.GetInfo(new HR_DepartmentParam() { OrgGuID = Guid.Parse(txtDeptOrgGuID.Text), DeptID = int.Parse(txtDeptID.Text) });
                this.ConvertEntityToControl<HR_DepartmentResult>(this.grpDept.Controls, info, null);
            }
            else 
            {
                ShowMessage("请选择需要修改部门！");
            }

        }
        #endregion

        #region 保存部门
        private void btnSaveDept_Click(object sender, EventArgs e)
        {
            HR_DepartmentResult info = new HR_DepartmentResult();
            info = this.ConvertControlToEntity<HR_DepartmentResult>(this.grpDept.Controls, info, null);
            WCFAddUpdateResult result = this.AsyncExecute<WCFAddUpdateResult, HR_DepartmentResult>(info, deptLogic.AddOrUpdate, (a) =>
            {
                this.HidEditWindow();
                BindOrgTree();
            });
        }
        #endregion

        #region 取消部门
        private void btnCancelDept_Click(object sender, EventArgs e)
        {
            this.HidEditWindow();
        }
        #endregion

        #region 删除部门
        private void btnDelDept_Click(object sender, EventArgs e)
        {
            HR_DepartmentParam param = new HR_DepartmentParam();
            param.DeptID = (int) deptID;
            HR_DepartmentResult rst = deptLogic.GetInfo(param);
            if (rst != null)
            {
                if (MessageBox.Show("请确认是否要删除部门：【" + rst.DeptName + "】", "操作提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    WCFAddUpdateResult result = this.AsyncExecute<WCFAddUpdateResult, HR_DepartmentParam>(param, deptLogic.DelInfo, (a) => { BindOrgTree(); });
                }
            }
            else
            {
                this.ShowMessage("请选择要删除的部门！");
            }
        }
        #endregion

        #region 右键添加部门
        private void tsmiAddDept_Click(object sender, EventArgs e)
        {
            btnAddDept_Click(sender, e);
        }
        #endregion

        #region 右键修改部门
        private void tsmiEditDept_Click(object sender, EventArgs e)
        {
            btnEditDept_Click(sender, e);
        }
        #endregion

        #region 右键删除部门
        private void tsmiDelDept_Click(object sender, EventArgs e)
        {
            btnDelDept_Click(sender, e);
        }
        #endregion



        #region 表格事件

        #region 点击单元格内容
        private void ucDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        #endregion

        #endregion


        #region 绑定表格
        void  SearchEmp()
        {
            if (trOrg.SelectedNode != null)
            {
                HR_EmployeeParam param = new HR_EmployeeParam();
                if (trOrg.SelectedNode.Name.Contains("trnOrg")) param.OrgID = int.Parse(trOrg.SelectedNode.Name.Substring(6));
                if (trOrg.SelectedNode.Name.Contains("trnDept")) param.DeptID = int.Parse(trOrg.SelectedNode.Name.Substring(7));
                if (!string.IsNullOrEmpty(txtEmpName.Text)) param.EmpName = txtEmpName.Text.Trim();
                List<HR_EmployeeResult> rst = this.AsyncExecute<List<HR_EmployeeResult>, HR_EmployeeParam>(param, empLogic.GetEmpList, BindDataGrid);
            }
            else
            {
                this.ShowMessage("请选择要搜索的机构或者部门！");
            }

            
         
        
        }

        void BindDataGrid(List<HR_EmployeeResult> rst)
        {
            dgvEmp.DataSource = rst;
        }
        #endregion

        #region 搜索按钮
        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchEmp();
        }
        #endregion

        private void tmsiAddEmp_Click(object sender, EventArgs e)
        {
            btnAddEmp_Click(sender, e);
        }

        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            if (orgID == 0 || deptID == 0)
            {
                this.ShowMessage("请选择所属部门");
                return;
            }
            frmEditEmp frmEditEmp = new frmEditEmp();
            frmEditEmp.orgID = (int)orgID;
            frmEditEmp.deptID = (int)deptID;
            frmEditEmp.ShowDialog();
            frmEditEmp.RefreshParentForm += new HR.frmEditEmp.dlgRefreshParentForm(SearchEmp);
        }

        private void dgvEmp_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex > -1 && e.ColumnIndex > -1)
            //{
                
            //    frmEditEmp frmEditEmp = new frmEditEmp();
            //    frmEditEmp.empID = (int)dgvEmp["colEmpID", e.RowIndex].Value;
            //    frmEditEmp.orgID = (int)dgvEmp["colOrgID",e.RowIndex].Value;
            //    frmEditEmp.deptID = (int)dgvEmp["colDeptID", e.RowIndex].Value;
            //    frmEditEmp.ShowDialog();
            //    frmEditEmp.RefreshParentForm += new HR.frmEditEmp.dlgRefreshParentForm(SearchEmp);
            //}
            ModifyEmpRec();
        }
        void ModifyEmpRec()
        {
            int rowIndex = -1;
            if (dgvEmp.CurrentCell != null) rowIndex = dgvEmp.CurrentCell.RowIndex;
            if (rowIndex >= 0)
            {
                frmEditEmp frmEditEmp = new frmEditEmp();
                frmEditEmp.empID = (int)dgvEmp["colEmpID", rowIndex].Value;
                frmEditEmp.orgID = (int)dgvEmp["colOrgID", rowIndex].Value;
                frmEditEmp.deptID = (int)dgvEmp["colDeptID", rowIndex].Value;
                frmEditEmp.ShowDialog();
                frmEditEmp.RefreshParentForm += new HR.frmEditEmp.dlgRefreshParentForm(SearchEmp);
            }
        }

        private void btnEditEmp_Click(object sender, EventArgs e)
        {
            ModifyEmpRec();
        }

      



    }
}
