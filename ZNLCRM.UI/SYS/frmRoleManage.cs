using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DevComponents.AdvTree;
using MySoft.Data;
using ZNLCRM.Controls;
using ZNLCRM.Entity.UserModel.Common;
using ZNLCRM.Entity.UserModel.Sys;
using ZNLCRM.UI.Logic.Common;
using ZNLCRM.UI.Logic.Sys;
using ZNLCRM.Utility;
using ZNLCRM.Entity.DBModel;
using System.Drawing;
using ZNLFrame.Entity;
using ZNLCRM.UI.HR;
using ZNLCRM.Entity.UserModel.HR;

namespace ZNLCRM.UI.SYS
{
    public partial class frmRoleManage : frmBaseForm
    {
        #region 变量定义

        private Sys_RoleRightResult roleRightResult;
        List<KeyValuePair<string, object>> kvRightList = new List<KeyValuePair<string, object>>();
        Sys_RoleLogic roleLogic = null;
        Sys_RoleRightLogic roleRightLogic = null;
        Hashtable htRight = new Hashtable();
        SYS_DictItemLineLogic dictLineLogic = null;
        int _roleID = 0; 
        string _roleName = "";
        int rowIndex = 0;
        #endregion

        public frmRoleManage()
        {
           InitializeComponent();
           roleLogic =new Sys_RoleLogic(this);
           roleRightLogic = new Sys_RoleRightLogic(this);
           dictLineLogic = new SYS_DictItemLineLogic(this);
        }

        private void frmRoleManage_Load(object sender, EventArgs e)
        {

            BindRolesTree();
            PageList<SYS_DictItemLineResult> pgList = dictLineLogic.GetDictItemLineList(new SYS_DictItemLineParam() { ItemName = "权限名称" });
            if (pgList.ResultJoinList != null && pgList.ResultJoinList.Rows.Count > 0)
            {
                foreach (DataRow row in pgList.ResultJoinList.Rows)
                {
                    if (!htRight.ContainsKey(row["ItemValue"]))
                    {
                        htRight.Add(row["ItemValue2"], row["ItemValue"]);
                        kvRightList.Add(new KeyValuePair<string, object>(row["ItemValue"].ToStringHasNull(), row["ItemValue2"]));
                    }
                }
            }
            BindDataGridView(1);
        }

        /// <summary>
        /// 绑定角色树
        /// </summary>
        private void BindRolesTree()
        {
            ShowWaitting(enuWaitMsgType.BindData);
            treeRoles.Nodes.Clear();
          
            List<Sys_RoleResult> rolesResult = roleLogic.GetRolesTree(new Sys_RoleParam());
            Node newNode = null;
            foreach (Sys_RoleResult info in rolesResult)
            {
                    newNode = new Node
                    {
                        VerticalCellLayoutAlignment = eHorizontalAlign.Left,
                        CellLayout = eCellLayout.Vertical,
                        Text = info.RoleName,
                        Name = "trn" + info.RoleID,
                        Image=global::ZNLCRM.UI.Properties.Resources.dept,
                        Tag = info.RoleName
                    };
                    treeRoles.Nodes.Add(newNode);
            }
            //节点双击事件
            treeRoles.NodeDoubleClick += treeRoles_NodeDoubleClick;
            treeRoles.NodeClick += treeRoles_NodeClick;
            HideWaitting();
        }
        /// <summary>
        /// 加载角色权限
        /// </summary>
        /// 
        private void BindDataGridView(int pageIndex)
        {
            if (_roleID <= 0) return;
            Sys_RoleRightParam  param=new Sys_RoleRightParam ();
            param.RoleID = _roleID;
            param.PageIndex = pageIndex;
            param.PageSize = 100;
            param.MenuCode = this.txfMenuCode.Text;
            param.ModuleName = txfModuleName.Text;
            PageList<Sys_RoleRightResult> pgList=  roleRightLogic.GetRoleRightList(param);
            if (pgList.ResultJoinList != null && pgList.ResultJoinList.Rows.Count > 0)
            {
                foreach (DataRow row in  pgList.ResultJoinList.Rows)
                {
                    string actionCode = row["ActionCode"].ToStringHasNull();
                    if (string.IsNullOrEmpty(actionCode)) continue;
                    row["RightName"] = GetRightName(actionCode);
                }
            }
            dgvModule.DataSource = pgList.ResultJoinList;
            pgModule.RecordCount = pgList.TotalCount;
        }

        string GetRightName(string actionCode)
        {

            string[] rights = actionCode.TrimEnd(new char[] { ',' }).Split(new char[] { ',' });
            List<string> rightNames = new List<string>();
            foreach (string right in rights)
            {
                rightNames.Add(htRight[right].ToStringHasNull());
            }
            return string.Join(",", rightNames);
        }

        #region 从界面获取保存实体

        private object Form_GetEditEntity(string editName)
        {
            object ret;
            if (editName == "Roles")
            {
                var info = new Sys_RoleResult();
                info = ConvertControlToEntity(grpRole.Controls, info, null);
                ret = info;
            }
            else
            {
                var node = treeRoles.SelectedNode;
                var roleID = node.Tag.ToInt32();
                var info = new Sys_RoleResult { RoleID = roleID };
                info = ConvertControlToEntity(grpRole.Controls, info, null);
                ret = info;
            }
            return ret;
        }

        #endregion


        #region 清除编辑层内容
        private void ClearConent()
        {
            txtRoleID.Text = string.Empty;
            txtRoleName.Text = string.Empty;
        }
        #endregion

        #region 添加角色
        private void tlbAddRole_Click(object sender, EventArgs e)
        {
            ShowEditWindow("添加角色", grpRole);
            ClearConent();
        }
        #endregion

        #region 修改角色
        private void tlbEditRole_Click(object sender, EventArgs e)
        {
            ClearConent();
            ShowEditWindow("修改角色", grpRole);
            Sys_RoleResult info = new Sys_RoleResult();
            info = roleLogic.GetInfo(new Sys_RoleParam() { RoleID =_roleID });
            this.ConvertEntityToControl<Sys_RoleResult>(this.grpRole.Controls, info, null);
        }
        #endregion


        #region 删除角色
        private void tlbDelRole_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(@"是否真的删除当前角色？", @"删除提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) !=
                DialogResult.OK)
            {
                return;
            }
            Sys_RoleParam param = new Sys_RoleParam { RoleID = _roleID };
            this.AsyncExecute(param, roleLogic.DelInfo, a => BindRolesTree());
        }
        #endregion

        
        #region 保存角色
        private void btnSaveRole_Click(object sender, EventArgs e)
        {
            Sys_RoleResult info = Form_GetEditEntity("Roles") as Sys_RoleResult;
            AsyncExecute(info, roleLogic.AddOrUpdate, a=>
            {
                if (a.Key.ToInt32() > 0)
                {
                    HidEditWindow();
                    BindRolesTree();
                }
            });
        }
        #endregion

        #region 取消编辑窗体
        private void btnCloseEditRole_Click(object sender, EventArgs e)
        {
            HidEditWindow();
        }
        #endregion
        #region 添加模块
        private void tlbAddModule_Click(object sender, EventArgs e)
        {
            List<int?> list=new List<int?> ();
            if(dgvModule.Rows.Count>0)
            {
                foreach(DataGridViewRow row in dgvModule.Rows)
                {
                      list.Add(row.Cells["colModuleID"].Value.ToInt32());
                }
            }
    
        
            var frmModule = new frmSelectModule(true);
            frmModule.moduleID = list.ToArray();
            DialogResult rst = frmModule.ShowDialog();
            if (rst == DialogResult.OK)
            {
                List<Sys_ModuleResult> moduleResultList = frmModule.GetSelectList<Sys_ModuleResult>();
                List<Sys_RoleRightResult> roleRightResultList = new List<Sys_RoleRightResult>();
                foreach (Sys_ModuleResult moduleResult in moduleResultList)
                {
                    Sys_RoleRightResult result = new Sys_RoleRightResult
                    {
                        ModuleID = moduleResult.ModuleID,
                        RoleID = _roleID,
                        ActionCode = "Search",
                        IsDeleted = false
                    };
                    roleRightResultList.Add(result);
                }

                WCFAddUpdateResult ret = this.AsyncExecute<WCFAddUpdateResult, List<Sys_RoleRightResult>>(roleRightResultList, roleRightLogic.UpdateOrInsertList, a => BindDataGridView(1));
            }
        }
        #endregion

        #region 删除模块
        private void tlbDelModule_Click(object sender, EventArgs e)
        {

            DataGridViewRow dr = dgvModule.CurrentRow;
            if (dr == null) return;
            string moduleName = dr.Cells["colModuleName"].Value.ToStringHasNull();
            int roleRightID = dr.Cells["colRoleRightID"].Value.ToInt32();
            if (MessageBox.Show(@"是否真的删除当前角色下的'" + moduleName + @"'模块？", @"删除提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                DialogResult.No)
            {
                return;
            }
            Sys_RoleRightParam info = new Sys_RoleRightParam { RoleRightID = roleRightID };
            this.AsyncExecute(info, roleRightLogic.DelInfo,a=>BindDataGridView(1));
        }
        #endregion 

        
        #region 双击节点编辑角色
        void treeRoles_NodeDoubleClick(object sender, TreeNodeMouseEventArgs e)
        {
            tlbEditRole_Click(sender, e);
        }
        #endregion

        #region 单击节点角色下模块权限
        void treeRoles_NodeClick(object sender, TreeNodeMouseEventArgs e)
        {
            _roleID = treeRoles.SelectedNode.Name.Substring(3).ToInt32();
            _roleName = treeRoles.SelectedNode.Text;
            panelShowRight.Visible = false;
            BindDataGridView(1);
            LoadEmpList();
        }
        #endregion

        private void dgvModule_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                if (dgvModule.Columns[e.ColumnIndex].Name == "colRightName")
                {
                    rowIndex = e.RowIndex;
                    Rectangle r = dgvModule.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);
                    panelShowRight.Width = dgvModule.Columns[e.ColumnIndex].Width;
                    panelShowRight.Location = new Point(r.Left, r.Top);
                    panelShowRight.Show();
                    string actionCode = dgvModule["colBaseActionCode", e.RowIndex].Value.ToStringHasNull();
                    if (string.IsNullOrEmpty(actionCode)) return;

                    // string[] rights = actionCode.TrimEnd(new char[] { ',' }).Split(new char[] { ',' });
                    List<KeyValuePair<string, object>> baseRightList = new List<KeyValuePair<string, object>>();
                    foreach (KeyValuePair<string, object> item in kvRightList)
                    {
                        if (actionCode.Contains(item.Value.ToStringHasNull()))
                        {
                            baseRightList.Add(new KeyValuePair<string, object>(item.Key, item.Value));
                        }
                    }
                    cbgRight.KvList = baseRightList;
                    cbgRight.Value = dgvModule["colActionCode", e.RowIndex].Value.ToStringHasNull();

                }
            }
        }

        private void btnSaveRoleRight_Click(object sender, EventArgs e)
        {
            Sys_RoleRightResult param;
            List<Sys_RoleRightResult> list = new List<Sys_RoleRightResult>();

            for (int i = 0; i < dgvModule.Rows.Count; i++)
            {
                param = new Sys_RoleRightResult();
                param.RoleRightID = dgvModule.Rows[i].Cells["colRoleRightID"].Value.ToInt32();
                param.ActionCode = dgvModule.Rows[i].Cells["colActionCode"].Value.ToStringHasNull();
                list.Add(param);
            }

            WCFAddUpdateResult result = this.AsyncExecute<WCFAddUpdateResult, List<Sys_RoleRightResult>>(list, roleRightLogic.UpdateOrInsertList, (a) =>
            {
                BindDataGridView(1);
            });
        }

        private void panelShowRight_MouseLeave(object sender, EventArgs e)
        {
            panelShowRight.Hide();
        }

        private void cbgRight_ItemCheckedChanged(object sender, CheckBoxGroupValueChangedArgs e)
        {
            dgvModule.Rows[rowIndex].Cells["colActionCode"].Value = cbgRight.Value;
            dgvModule.Rows[rowIndex].Cells["colRightName"].Value = GetRightName(cbgRight.Value);
        }

        private void pgModule_PageIndexChanged(object sender, EventArgs e)
        {
            BindDataGridView(pgModule.PageIndex);
        }

        private void cbgRight_Load(object sender, EventArgs e)
        {

        }

        private void txfMenuName_ButtonCustomClick(object sender, EventArgs e)
        {
            frmSelectMenu frm = new frmSelectMenu();
            frm.ShowDialog();
            List<Sys_MenuResult> lstMenu = new List<Sys_MenuResult>();
            lstMenu = frm.Tag as List<Sys_MenuResult>;
            if (lstMenu != null && lstMenu.Count>0)
            {
                this.txfMenuName.Text = lstMenu.Select(a => a.MenuName).ToArray().Join(',');
                this.txfMenuCode.Text = lstMenu.Select(a => a.MenuCode).ToArray().Join(',');
            }
        }

        private void txfMenuName_ButtonCustom2Click(object sender, EventArgs e)
        {
            this.txfMenuCode.Text = "";
            this.txfMenuName.Text = "";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.BindDataGridView(1);
        }

        private void btnAddEmps_Click(object sender, EventArgs e)
        {
            if (_roleID <= 0)
            {
                this.ShowMessage("请先选择角色!");
                return;
            }
            frmSelectEmp frm = new frmSelectEmp(true);
            frm.ShowDialog();
            List<HR_EmployeeResult> slcList = frm.GetSelectList<HR_EmployeeResult>();
            if (slcList.Count > 0)
            {
                int?[] arrEmpIds = slcList.Select(a => (int?)a.EmpID).ToArray();
                Sys_EmpDataRightLogic logic = new Sys_EmpDataRightLogic(this);
                WCFAddUpdateResult rst= logic.AddRoleEmpIDs(new Sys_EmpDataRightParam() { RoleID = _roleID.ToString(), RoleName = _roleName, EmpIDs = arrEmpIds });
                if (rst.Key > 0)
                {
                    LoadEmpList();
                }
            }
        }
        void LoadEmpList()
        {
            Sys_EmpDataRightLogic logic = new Sys_EmpDataRightLogic(this);
            List<HR_EmployeeResult> empList = logic.GetRoleEmpList(new Sys_EmpDataRightParam() { RoleID = _roleID.ToString() });
            this.dgvEmp.DataSource = empList;
        }

        private void btnDelEmp_Click(object sender, EventArgs e)
        {
            int rowIdx = 0;
            if (this.dgvEmp.CurrentCell != null) rowIdx = this.dgvEmp.CurrentCell.RowIndex;
            if (rowIdx < 0)
            {
                this.ShowMessage("请选择要移除的员工记录行!");
                return;
            }
            if (_roleID <= 0)
            {
                this.ShowMessage("请先选择角色!");
                return;
            }
            if (MessageBox.Show("确定是否删除当前记录?", "删除提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            int?[] arrEmpIds = new int?[] { this.dgvEmp["col_EmpID", rowIdx].Value.ToInt32() };
            Sys_EmpDataRightLogic logic = new Sys_EmpDataRightLogic(this);
            WCFAddUpdateResult rst = logic.DelRoleEmpIDs(new Sys_EmpDataRightParam() { RoleID = _roleID.ToString(), EmpIDs = arrEmpIds });
            if (rst.Key > 0)
            {
                LoadEmpList();
            }
        }








    }
}