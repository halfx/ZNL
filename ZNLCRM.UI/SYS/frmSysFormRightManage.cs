using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZNLCRM.UI.Logic.Common;
using ZNLCRM.Utility;
using ZNLCRM.UI.Logic.Sys;
using ZNLCRM.Entity.UserModel.Common;
using ZNLCRM.Entity.UserModel.Sys;
using ZNLFrame.Entity;
using ZNLCRM.Controls;

namespace ZNLCRM.UI.SYS
{
    public partial class frmSysFormRightManage : frmBaseManageForm
    {
        public frmSysFormRightManage()
        {
            InitializeComponent();
        }


        void BindMenuTree()
        {
            this.ShowWaitting(enuWaitMsgType.BindData);
            this.treeNameSpace.Nodes.Clear();
            Dictionary<string, DevComponents.AdvTree.Node> lstNode = new Dictionary<string, DevComponents.AdvTree.Node>();
            Sys_FormRightLogic logic = new Sys_FormRightLogic(this);
            List<Sys_FormRightResult> lstRst = new List<Sys_FormRightResult>();
            lstRst = logic.GetRightTree(new Sys_FormRightParam() { });
            string beforeCode = "", parentCode = "";
            DevComponents.AdvTree.Node topNode = null, beforeNode = null, currentNode = null;
            #region 顶给节点
            topNode = new DevComponents.AdvTree.Node();
            topNode.VerticalCellLayoutAlignment = DevComponents.AdvTree.eHorizontalAlign.Left;
            topNode.CellLayout = DevComponents.AdvTree.eCellLayout.Vertical;
            topNode.Image = global::ZNLCRM.UI.Properties.Resources.folder16;
            topNode.ImageExpanded = ZNLCRM.UI.Properties.Resources.folder16;
            topNode.Text = "系统路径";
            topNode.Expanded = true;
            this.treeNameSpace.Nodes.Add(topNode);
            #endregion

            foreach (Sys_FormRightResult info in lstRst)
            {
                #region 产生节点
                if (!info.NameSpace.StartsWith(beforeCode) || beforeCode == "")
                {

                    string[] str = info.NameSpace.Split('.');
                    int index = str[str.Length - 1].Length + 1;
                    currentNode = new DevComponents.AdvTree.Node();
                    currentNode.VerticalCellLayoutAlignment = DevComponents.AdvTree.eHorizontalAlign.Left;
                    currentNode.CellLayout = DevComponents.AdvTree.eCellLayout.Vertical;
                    currentNode.Image = global::ZNLCRM.UI.Properties.Resources.folder16;
                    currentNode.ImageExpanded = ZNLCRM.UI.Properties.Resources.folder16;
                    if (info.NameSpace.Length < index)
                    {
                        currentNode.Text = info.NameSpace;
                    }
                    else
                    {
                        currentNode.Text = info.NameSpace.Replace(info.NameSpace.Substring(0, info.NameSpace.Length - index) + ".", "");
                    } currentNode.Name = info.NameSpace;
                    topNode.Nodes.Add(currentNode);
                    beforeNode = currentNode;
                    beforeCode = info.NameSpace;
                }
                #endregion
                #region 产生子节点
                else
                {
                    string[] str = info.NameSpace.Split('.');
                    int index = str[str.Length - 1].Length + 1;
                    parentCode = info.NameSpace.Substring(0, info.NameSpace.Length - index);
                    currentNode = new DevComponents.AdvTree.Node();
                    currentNode.VerticalCellLayoutAlignment = DevComponents.AdvTree.eHorizontalAlign.Left;
                    currentNode.CellLayout = DevComponents.AdvTree.eCellLayout.Vertical;
                    currentNode.Image = global::ZNLCRM.UI.Properties.Resources.folder16;
                    currentNode.ImageExpanded = ZNLCRM.UI.Properties.Resources.folder16;
                    if (info.NameSpace.Length < index)
                    {
                        currentNode.Text = info.NameSpace;
                    }
                    else
                    {
                        currentNode.Text = info.NameSpace.Replace(parentCode + ".", "");
                    }
                    currentNode.Name = info.NameSpace;
                    lstNode[parentCode].Nodes.Add(currentNode);
                }
                #endregion
                lstNode.Add(info.NameSpace, currentNode);
            }
            HideWaitting();
        }
        void BindData(int pageIndex)
        {
            Sys_FormRightLogic logic = new Sys_FormRightLogic(this);
            Sys_FormRightParam param = new Sys_FormRightParam();
            param = this.ConvertControlToEntity<Sys_FormRightParam>(this.panWhere.Controls, param, null);
            param.PageIndex = pageIndex;
            param.PageSize = this.pagForm.PageSize;
            PageList<Sys_FormRightResult> pageList = this.AsyncExecute<PageList<Sys_FormRightResult>, Sys_FormRightParam>(param, logic.GetPageList, BindDataComplete);
        }
        void BindDataComplete(PageList<Sys_FormRightResult> a)
        {
            this.dgvMain.DataSource = a.ResultList;
            this.pagForm.RecordCount = a.TotalCount;
        }

        private void frmSysFormRightManage_Load(object sender, EventArgs e)
        {
            BindData(1);
            BindMenuTree();
        }

        private void treeNameSpace_NodeClick(object sender, DevComponents.AdvTree.TreeNodeMouseEventArgs e)
        {
            this.BindModuleList();
        }
        #region 绑定模块清单
        void BindModuleList()
        {
            this.ShowWaitting(enuWaitMsgType.BindData);
            DevComponents.AdvTree.Node node = this.treeNameSpace.SelectedNode;
            if (node == null) return;
            Sys_FormRightLogic logic = new Sys_FormRightLogic(this);
            PageList<Sys_FormRightResult> lstRst = new PageList<Sys_FormRightResult>();
            lstRst = logic.GetPageList(new Sys_FormRightParam() { PageSize = int.MaxValue, NameSpace = node.Name.ToString() });
            dgvMain.DataSource = lstRst.ResultList;
            HideWaitting();
        }
        #endregion

        private void tlbMain_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            #region 新增
            if (e.ClickedItem.Name == "tlbAdd")
            {
                frmSysFormRightEdit frmEdit = new frmSysFormRightEdit(-1);
                frmEdit.ShowDialog();
            }
            #endregion
            #region 修改
            else if (e.ClickedItem.Name == "tlbEdit")
            {
                editData();
            }
            #endregion
            #region 删除
            if (e.ClickedItem.Name == "tlbDel")
            {
                int rowIdx = this.dgvMain.CurrentCell == null ? -1 : this.dgvMain.CurrentCell.RowIndex;
                if (rowIdx < 0)
                {
                    this.ShowMessage("请指定要删除记录！");
                    return;
                }
                int _formrightid = this.dgvMain["col_Sys_FormRight_FormRightID", rowIdx].Value.ToInt32();
                Sys_FormRightLogic logic = new Sys_FormRightLogic(this);
                WCFAddUpdateResult rst = logic.DelInfo(new Sys_FormRightParam() { FormRightID = _formrightid });
                if (rst.Key > 0)
                {
                    BindData(1);
                    BindMenuTree();
                }
            }
            #endregion
        }
        void editData()
        {
            int rowIdx = this.dgvMain.CurrentCell == null ? -1 : this.dgvMain.CurrentCell.RowIndex;
            if (rowIdx < 0)
            {
                this.ShowMessage("请指定要修改记录！");
                return;
            }
            int Key = this.dgvMain["col_Sys_FormRight_FormRightID", rowIdx].Value.ToInt32();
            frmSysFormRightEdit frmEdit = new frmSysFormRightEdit(Key);
            frmEdit.ShowDialog();
        }

        private void dgvMain_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            editData();
        }

        private void ucTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.BindData(1);
        }

        private void pagForm_PageIndexChanging(Controls.UcPagerEventArgs e)
        {
            this.BindData(this.pagForm.PageIndex);
        }

        private void dgvMain_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void dgvMain_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
