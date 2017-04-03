using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZNLCRM.UI.Logic.Common;
using ZNLCRM.UI.Logic.HR;
using ZNLCRM.Entity.UserModel.HR;
using ZNLFrame.Entity;

namespace ZNLCRM.UI.HR
{
    public partial class frmSelectDepartment : frmSelectForm
    {
       string _idColName="colDeptID";
        string _chkColName = "colSelect";
        HR_OrgLogic orgLogic = null;
        HR_DepartmentLogic deptLogic = null;
        public  int?[] deptIds = null;
        public int? OrgID;
        public int? DeptID;
        public frmSelectDepartment(bool isMutiSelect)
        {
            InitializeComponent();
            InitBaseSelectForm(isMutiSelect, this.dgvDept, this.chkAll, _idColName, _chkColName);
            orgLogic =new HR_OrgLogic (this);
            deptLogic = new HR_DepartmentLogic(this);
        }
        #region 绑定机构树
        void BindOrgTree()
        {

            this.trOrg.Nodes.Clear();
            List<HR_OrgResult> lstRst = orgLogic.GetOrgTree(new HR_OrgParam() { });

            DevComponents.AdvTree.Node orgNode = null;
            foreach (HR_OrgResult rst in lstRst)
            {
                
                orgNode = new DevComponents.AdvTree.Node();
                orgNode.VerticalCellLayoutAlignment = DevComponents.AdvTree.eHorizontalAlign.Left;
                orgNode.CellLayout = DevComponents.AdvTree.eCellLayout.Vertical;
                orgNode.Text = "[" + rst.OrgNo + "]" + rst.OrgName;
                orgNode.Name = "trnOrg" + rst.OrgID;
                orgNode.Tag = rst.OrgID + "," + rst.OrgGuID + "," + 0 + "," + orgNode.Level;
                orgNode.Image = global::ZNLCRM.UI.Properties.Resources.org;
                if (OrgID > 0 && OrgID != rst.OrgID) orgNode.Visible = false;
                trOrg.Nodes.Add(orgNode);
        

            }
            trOrg.ExpandAll();
         

        }
        #endregion



        #region 绑定部门列表
        void BindDgvDept()
        {
            if (trOrg.SelectedNode != null)
            {
                HR_DepartmentParam param = new HR_DepartmentParam();
                if (trOrg.SelectedNode.Name.Contains("trnOrg")) param.OrgID = int.Parse(trOrg.SelectedNode.Name.Substring(6));

                if (!string.IsNullOrEmpty(txtDeptName.Text)) param.DeptName = txtDeptName.Text.Trim();
                param.NoDeptIDs = deptIds;
                List<HR_DepartmentResult> lstRst = deptLogic.GetDeptList(param);
                dgvDept.DataSource = lstRst;

                this.SetDataSource<HR_DepartmentResult>(lstRst);
                SetGridCheck(this.dgvDept, _idColName, _chkColName);
            }
            else
            {
                this.ShowMessage("请选择要搜索的机构！");
            }
        }
        #endregion

        private void trOrg_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindDgvDept();
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            SubmitForm();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.CancelForm();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            BindDgvDept();
        }

        private void frmSelectEmp_Load(object sender, EventArgs e)
        {
            BindOrgTree();
        }

   

        private void frmSelectDepartment_Load(object sender, EventArgs e)
        {
            BindOrgTree();
        }

       

    }
}
