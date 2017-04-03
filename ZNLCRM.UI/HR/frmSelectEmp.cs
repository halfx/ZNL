using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZNLCRM.UI.Logic.Common;
using ZNLCRM.Entity.UserModel.HR;
using ZNLCRM.UI.Logic.HR;
using ZNLFrame.Entity;
using ZNLCRM.Utility;

namespace ZNLCRM.UI.HR
{
    public partial class frmSelectEmp : frmSelectForm
    {
        
        string _idColName="colEmpID";
        string _chkColName = "colSelect";
        HR_OrgLogic orgLogic = null;
        HR_DepartmentLogic deptLogic = null;
        HR_EmployeeLogic empLogic = null;
        public  int?[] empIds = null;
        public int? OrgID;
        public int? DeptID;
        public frmSelectEmp(bool isMutiSelect)
        {
            InitializeComponent();
            InitBaseSelectForm(isMutiSelect, this.dgvEmp, this.chkAll, _idColName, _chkColName);
           
            orgLogic =new HR_OrgLogic (this);
            deptLogic = new HR_DepartmentLogic(this);
            empLogic = new HR_EmployeeLogic(this);
        }

        private void grpDgvModule_Enter(object sender, EventArgs e)
        {

        }


   
        #region 绑定机构树
        void BindOrgTree()
        {

            this.trOrg.Nodes.Clear();
            List<HR_OrgResult> lstRst = orgLogic.GetOrgTree(new HR_OrgParam() { });
            List<HR_DepartmentResult> lstDeptRst = deptLogic.GetDeptList(new HR_DepartmentParam() { });
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
                BindDeptTree(rst.OrgGuID, 0, lstDeptRst, orgNode);

            }
            trOrg.ExpandAll();
        }
        #endregion

        #region 绑定机构下部门
        void BindDeptTree(Guid? orgGuID, int parentID, List<HR_DepartmentResult> list, DevComponents.AdvTree.Node parentNode)
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
                    deptNode.Tag = rst.OrgID + "," + rst.OrgGuID + "," + rst.DeptID + "," + deptNode.Level;
                    deptNode.Image = ZNLCRM.UI.Properties.Resources.dept;
                    if (DeptID > 0 && DeptID != rst.DeptID) deptNode.Visible = false;
                    parentNode.Nodes.Add(deptNode);
                   
                    BindDeptTree(orgGuID, rst.DeptID, list, deptNode);
                }
            }

        }
        #endregion

        #region 绑定人员清单
        void BindDgvEmp(int pageIndex)
        {
            if (trOrg.SelectedNode != null)
            {
                HR_EmployeeParam param = new HR_EmployeeParam();
                if (trOrg.SelectedNode.Name.Contains("trnOrg")) param.OrgID = int.Parse(trOrg.SelectedNode.Name.Substring(6));
                if (trOrg.SelectedNode.Name.Contains("trnDept")) param.DeptID = int.Parse(trOrg.SelectedNode.Name.Substring(7));
                if (!string.IsNullOrEmpty(txtEmpName.Text)) param.EmpName = txtEmpName.Text.Trim();
                param.NoEmpIDs = empIds;
                param.PageIndex = pageIndex;
                param.PageSize = 100;
                PageList<HR_EmployeeResult> lstRst =empLogic.GetPageList(param);
                dgvEmp.DataSource = lstRst.ResultJoinList;
                pgEmp.RecordCount = lstRst.TotalCount;
                List<HR_EmployeeResult> empList = new List<HR_EmployeeResult>();
                foreach (DataRow row in lstRst.ResultJoinList.Rows)
                {

                    empList.Add(new HR_EmployeeResult
                    {
                        EmpID = row["EmpID"].ToInt32(),
                        EmpCode = row["EmpCode"].ToStringHasNull(),
                        EmpName=row["EmpName"].ToStringHasNull()
                    });
                }
                this.SetDataSource<HR_EmployeeResult>(empList);
                SetGridCheck(this.dgvEmp, _idColName, _chkColName);
            }
            else
            {
                this.ShowMessage("请选择要搜索的机构或者部门！");
            }
        }
        #endregion

        private void trOrg_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindDgvEmp(1);
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
            BindDgvEmp(1);
        }

        private void frmSelectEmp_Load(object sender, EventArgs e)
        {
            BindOrgTree();
        }

        private void pgEmp_PageIndexChanged(object sender, EventArgs e)
        {
            BindDgvEmp(pgEmp.PageIndex);
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

       

      
    }
}
