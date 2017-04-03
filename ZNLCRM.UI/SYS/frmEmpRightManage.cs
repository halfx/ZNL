using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZNLCRM.UI.Logic.Common;
using ZNLCRM.UI.Logic.Sys;
using ZNLCRM.Entity.UserModel.Sys;
using ZNLFrame.Entity;
using ZNLCRM.Utility;
using System.Collections;
using ZNLCRM.Entity.UserModel.Common;

namespace ZNLCRM.UI.SYS
{
    public partial class frmEmpRightManage : frmBaseForm
    {
        Hashtable htRight = new Hashtable();
        List<KeyValuePair<string, object>> kvRightList = new List<KeyValuePair<string, object>>();
        SYS_DictItemLogic dictlogic=null;
        SYS_DictItemLineLogic dictLineLogic = null;
        Sys_EmpRightLogic rightLogic = null;
        int rowIndex = 0;
        int _empID = 0;
        string _empName = "";
        public frmEmpRightManage()
        {
            _empID = 1;

        }
        public frmEmpRightManage(int empID,string empName)
        {
            InitializeComponent();
            _empID = empID;
            _empName = empName;
            dictlogic=new SYS_DictItemLogic (this);
            dictLineLogic = new SYS_DictItemLineLogic(this);
            rightLogic = new Sys_EmpRightLogic(this);
        }

        private void frmSysModuleManage_Load(object sender, EventArgs e)
        {
            BindMenuTree(this.tabControl.SelectedTab);

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
        }

        #region 绑定菜单项
        private void BindMenuTree(TabPage tabpage)
        {
            this.ShowWaitting(enuWaitMsgType.BindData);
            //获取当前选中的tree

            adtMenu.Nodes.Clear();
            Dictionary<string, DevComponents.AdvTree.Node> lstNode = new Dictionary<string, DevComponents.AdvTree.Node>();

            Sys_MenuLogic logic = new Sys_MenuLogic(this);
            List<Sys_MenuResult> lstRst = new List<Sys_MenuResult>();
            lstRst = logic.GetMenuTree(new Sys_MenuParam() { });
            string beforeCode = "", parentCode = "";
            DevComponents.AdvTree.Node beforeNode = null, currentNode = null;

            foreach (Sys_MenuResult info in lstRst)
            {
                #region 产生节点
                if (!info.MenuCode.StartsWith(beforeCode) || beforeCode == "")
                {
                    currentNode = new DevComponents.AdvTree.Node();
                    currentNode.Image = global::ZNLCRM.UI.Properties.Resources.folder16;
                    currentNode.Text = info.MenuName;
                    currentNode.Name = "trn" + info.MenuID;
                    currentNode.Tag = info.MenuCode;
                    currentNode.ImageExpanded = ZNLCRM.UI.Properties.Resources.folder16;
                    adtMenu.Nodes.Add(currentNode);
                    beforeNode = currentNode;
                    beforeCode = info.MenuCode;
                }
                #endregion
                #region 产生子节点
                else
                {
                    parentCode = info.MenuCode.Substring(0, info.MenuCode.Length - 3);
                    currentNode = new DevComponents.AdvTree.Node();
                    currentNode.Image = ZNLCRM.UI.Properties.Resources.folder16;
                    currentNode.Text = info.MenuName;
                    currentNode.Name = "trn" + info.MenuID;
                    currentNode.Tag = info.MenuCode;
                    currentNode.ImageExpanded = ZNLCRM.UI.Properties.Resources.folder16;
                    lstNode[parentCode].Nodes.Add(currentNode);
                }
                #endregion
                lstNode.Add(info.MenuCode, currentNode);
            }
            HideWaitting();
        }
        #endregion

        /// <summary>
        /// 绑定数据源
        /// </summary>
        /// <param name="dgv"></param>
        /// <param name="tr"></param>
        /// <param name="page"></param>
        private void BindDataGridView(int pageIndex)
        {
            panelShowRight.Hide();
           if(adtMenu.SelectedNode==null)return;


            List<Sys_MenuResult> lstRst = new List<Sys_MenuResult>();
            Sys_EmpRightParam param = new Sys_EmpRightParam();
            param.EmpID = _empID;
            param.PageIndex = pageIndex;
            param.PageSize = 50;
            param.MenuID = adtMenu.SelectedNode.Name.Substring(3).ToInt32();
            param.ModuleName = txtModuleName.Text.Trim();
            param.IsNoAction = cboIsNoSet.Checked;
            PageList<Sys_EmpRightResult>  pgList = rightLogic.GetPageList(param);

            if (pgList.ResultJoinList != null && pgList.ResultJoinList.Rows.Count > 0)
            {

          
                foreach (DataRow  row in pgList.ResultJoinList.Rows)
                {
                    string actionCode = row["ActionCode"].ToStringHasNull();
                    if (string.IsNullOrEmpty(actionCode)) continue;
                    row["RightName"] = GetRightName(actionCode);
                  
                }
                dgvModule.DataSource = pgList.ResultJoinList;
                pgEmpRight.RecordCount = pgList.TotalCount;
                pgEmpRight.Refresh();
            }
        }

        string  GetRightName(string actionCode)
        {

            string[] rights = actionCode.TrimEnd(new char[] { ',' }).Split(new char[] { ',' });
            List<string> rightNames = new List<string>();
            foreach (string right in rights)
            {
                rightNames.Add(htRight[right].ToStringHasNull());
            }
            return string.Join(",", rightNames);
        }

     
        /// <summary>
        /// 系统Tree
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void adtMenu_NodeClick(object sender, DevComponents.AdvTree.TreeNodeMouseEventArgs e)
        {
           
            BindDataGridView(1);
        }

       



        /// <summary>
        /// 系统模块保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_SystemSave_Click(object sender, EventArgs e)
        {
            SaveData();
            
        }

        /// <summary>
        /// 保存数据
        /// </summary>
        /// <param name="dgv"></param>
        public void SaveData()
        {
        
            Sys_EmpRightResult param;
            List<Sys_EmpRightResult> list = new List<Sys_EmpRightResult>();

            for (int i = 0; i < dgvModule.Rows.Count; i++)
            {
                param = new Sys_EmpRightResult();
                param.EmpRightID=dgvModule.Rows[i].Cells["colEmpRightID"].Value.ToInt32();
                param.EmpID = _empID;
                param.ModuleID = dgvModule.Rows[i].Cells["colModuleID"].Value.ToInt32();
                param.ActionCode = dgvModule.Rows[i].Cells["colActionCode"].Value.ToStringHasNull();
                list.Add(param);
            }

            WCFAddUpdateResult result = this.AsyncExecute<WCFAddUpdateResult, List<Sys_EmpRightResult>>(list, rightLogic.UpdateOrInsertList, (a) =>
            {
                   BindDataGridView(1);
            });

        }

        private void dgvModule_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dgvModule.Rows)
            {
                string actionCode = row.Cells["colActionCode"].Value.ToStringHasNull();
                if (actionCode.Length > 0)
                { 
                   
                 
                
                }
            }
        }

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

        private void panelShowRight_MouseLeave(object sender, EventArgs e)
        {
         
            
        }

     

        private void cbgRight_ItemCheckedChanged(object sender, Controls.CheckBoxGroupValueChangedArgs e)
        {
            dgvModule.Rows[rowIndex].Cells["colActionCode"].Value = cbgRight.Value;
            dgvModule.Rows[rowIndex].Cells["colRightName"].Value = GetRightName(cbgRight.Value);
        }

        private void dgvModule_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void cbgRight_MouseLeave(object sender, EventArgs e)
        {
            panelShowRight.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            BindDataGridView(1);
        }

        private void cboIsNoSet_CheckedChanged(object sender, EventArgs e)
        {
            BindDataGridView(1);
        }

        private void pgEmpRight_PageIndexChanged(object sender, EventArgs e)
        {
            BindDataGridView(pgEmpRight.PageIndex);
        }

        private void panToo_Paint(object sender, PaintEventArgs e)
        {

        }

     
      

       

       

      
     

    }
}
