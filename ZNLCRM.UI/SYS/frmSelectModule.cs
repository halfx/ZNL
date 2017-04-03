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
using ZNLCRM.Controls;

namespace ZNLCRM.UI.SYS
{
    public partial class frmSelectModule : frmSelectForm
    {
        string _idColName="col_Sys_Module_ModuleID";
        string _chkColName = "_col_Sys_Module_Chk";
        public  int?[] moduleID = null;
        public frmSelectModule(bool isMutiSelect)
        {
            InitializeComponent();
            InitBaseSelectForm(isMutiSelect, this.dgvModule, this.chkAll, _idColName, _chkColName);
        }
        #region 绑定树形和列表数据
        #region 绑定菜单树
        void BindMenuTree()
        {
            this.ShowWaitting(enuWaitMsgType.BindData);
            this.treMenu.Nodes.Clear();
            Dictionary<string, DevComponents.AdvTree.Node> lstNode = new Dictionary<string, DevComponents.AdvTree.Node>();
            Sys_MenuLogic logic = new Sys_MenuLogic(this);
            List<Sys_MenuResult> lstRst = new List<Sys_MenuResult>();
            lstRst = logic.GetMenuTree(new Sys_MenuParam() { });
            string beforeCode = "", parentCode = "";
            DevComponents.AdvTree.Node beforeNode = null, currentNode = null, topNode = null;

            #region 顶级树形菜单节点
            topNode = new DevComponents.AdvTree.Node();
            topNode.Image = global::ZNLCRM.UI.Properties.Resources.folder16;
            topNode.Text = "系统菜单目录";
            topNode.Name = "trn0";
            topNode.Tag = "";
            topNode.Checked = true;
            topNode.Expanded = true;
            topNode.ImageExpanded = ZNLCRM.UI.Properties.Resources.folder16;
            this.treMenu.Nodes.Add(topNode);
            #endregion
            #region 产生子级节点
            foreach (Sys_MenuResult info in lstRst)
            {
                #region 产生节点
                if (!info.MenuCode.StartsWith(beforeCode) || beforeCode == "")
                {
                    #region 顶级菜单的顶级
                    currentNode = new DevComponents.AdvTree.Node();
                    currentNode.Image = global::ZNLCRM.UI.Properties.Resources.folder16;
                    currentNode.Text = info.MenuName;
                    currentNode.Name = "trn" + info.MenuID;
                    currentNode.Tag = info.MenuCode;
                    currentNode.Expanded = true;
                    currentNode.ImageExpanded = ZNLCRM.UI.Properties.Resources.folder16;
                    topNode.Nodes.Add(currentNode);
                    beforeNode = currentNode;
                    beforeCode = info.MenuCode;
                    #endregion
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
                    currentNode.Expanded = true;
                    currentNode.ImageExpanded = ZNLCRM.UI.Properties.Resources.folder16;
                    lstNode[parentCode].Nodes.Add(currentNode);
                }
                #endregion
                lstNode.Add(info.MenuCode, currentNode);
            }
            #endregion
            //隐藏等待窗体
            HideWaitting();
            this.treMenu.SelectNode(this.treMenu.Nodes[0], DevComponents.AdvTree.eTreeAction.Expand);
        }
        #endregion
        #region 绑定模块清单
        List<Sys_ModuleResult> _lstRst = new List<Sys_ModuleResult>();
        void BindModuleList(int pageIndex)
        {
            string moduleCode = "";
            this.ShowWaitting(enuWaitMsgType.BindData);
            DevComponents.AdvTree.Node node = this.treMenu.SelectedNode;
            if (node == null)
            {
                HideWaitting();
                return;
            }
            moduleCode = node.Tag.ToStringHasNull();
            Sys_ModuleLogic logic = new Sys_ModuleLogic(this);
            PageList<Sys_ModuleResult> lstRst = new PageList<Sys_ModuleResult>();
            Sys_ModuleParam param = new Sys_ModuleParam();
            param.PageIndex = pageIndex;
            param.ModuleCode = moduleCode;
            param.PageSize = this.pagModule.PageSize;
            param.NotModuleIDs = moduleID;
            param = this.ConvertControlToEntity<Sys_ModuleParam>(this.grpSearch.Controls, param,null);
            lstRst = logic.GetPageList(param);
            dgvModule.DataSource = lstRst.ResultList;
            this.pagModule.RecordCount = lstRst.TotalCount;
            this.SetDataSource<Sys_ModuleResult>(lstRst.ResultList);
            SetGridCheck(this.dgvModule, _idColName, _chkColName);
            HideWaitting();
        }
        #endregion
        private void frmSelectModule_Load(object sender, EventArgs e)
        {
            BindMenuTree();
            BindModuleList(1);
        }
        #endregion

        private void pagModule_PageIndexChanged(object sender, EventArgs e)
        {
            BindModuleList(this.pagModule.PageIndex);
        }
        
        private void btnOK_Click(object sender, EventArgs e)
        {
            SubmitForm();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.CancelForm();
        }
        private void treMenu_NodeClick(object sender, DevComponents.AdvTree.TreeNodeMouseEventArgs e)
        {
            BindModuleList(1);
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            BindModuleList(1);
        }
    }
}
