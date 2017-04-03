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
namespace ZNLCRM.UI.SYS
{
    public partial class frmMenuManage : frmBaseForm
    {
        public frmMenuManage()
        {
            InitializeComponent();
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
            string beforeCode="",parentCode="";
            DevComponents.AdvTree.Node beforeNode = null, currentNode = null; ;
            foreach (Sys_MenuResult info in lstRst)
            {
                #region 产生节点
                if (!info.MenuCode.StartsWith(beforeCode) || beforeCode=="")
                {
                    currentNode = new DevComponents.AdvTree.Node();
                    currentNode.Image = global::ZNLCRM.UI.Properties.Resources.folder16;
                    currentNode.Text = info.MenuName;
                    currentNode.Name = "trn" + info.MenuID;
                    currentNode.Tag = info.MenuCode;
                    currentNode.ImageExpanded = ZNLCRM.UI.Properties.Resources.folder16;
                    this.treMenu.Nodes.Add(currentNode);
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
        #region 绑定模块清单
        void BindModuleList()
        {
            this.ShowWaitting(enuWaitMsgType.BindData);
            DevComponents.AdvTree.Node node = this.treMenu.SelectedNode;
            if (node == null) return;
            Sys_ModuleLogic logic = new Sys_ModuleLogic(this);
            PageList<Sys_ModuleResult> lstRst =new PageList<Sys_ModuleResult>();
            lstRst = logic.GetPageList(new Sys_ModuleParam() { PageSize = 20000, MenuID = node.Name.Substring(3).ToInt32() });
            dgvModule.DataSource = lstRst.ResultList;
            HideWaitting();
        }
        #endregion
        #endregion
        #region 加载数据
        private void frmMenuManage_Load(object sender, EventArgs e)
        {
            BindMenuTree();
        }
        #endregion
        #region 工具栏单击
        private void tlbMain_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            #region 新增菜单项
            if (e.ClickedItem.Name == "tlbAdd1")
            {
                DevComponents.AdvTree.Node node = this.treMenu.SelectedNode;
                int menuID = 0;
                string menuCode = "";
                string menuName = "顶级菜单";
                if (node != null)
                {
                    menuID = node.Name.Substring(3).ToInt32();
                    menuCode = node.Tag.ToStringHasNull();
                    menuName = node.Text;
                }
                this.txtMenuCode.Text = menuCode;
                this.txtMenuID.Text = "0";
                this.txtParentMenuName.Text = menuName;
                this.ShowEditWindow("添加菜单", this.grpEditMenu);
                
            }
            #endregion
            #region 新增模块
            if (e.ClickedItem.Name == "tlbAdd2")
            {
                DevComponents.AdvTree.Node node = this.treMenu.SelectedNode;
                int menuID = 0;string menuName = "";
                if (node != null)
                {
                    menuID = node.Name.Substring(3).ToInt32();
                    menuName = node.Text;
                }
                this.txtModuleID.Text = "0";
                this.txtModuleCode.Text = "系统自动产生";
                this.stxMenuID.Text = menuID.ToString();
                this.sxtParentMenuName.Text = menuName;
                this.ShowEditWindow("添加模块", this.grpEditModule);
                
            }
            #endregion
            #region 修改菜单
            if (e.ClickedItem.Name == "tlbEdit")
            {
                DevComponents.AdvTree.Node node = this.treMenu.SelectedNode;
                int menuID = 0;
                if (node != null)
                {
                    menuID = node.Name.Substring(3).ToInt32();
                    GetMenuInfo(menuID);
                }
                this.ShowEditWindow("修改菜单", this.grpEditMenu);
                
            }
            #endregion
            #region 修改模块
            if (e.ClickedItem.Name == "tlbEdit2")
            {
                if (this.dgvModule.CurrentCell == null) return;
                int rowIdx = this.dgvModule.CurrentCell.RowIndex;
                if (rowIdx <= 0) return;
                editModuleList(rowIdx);
            }
            #endregion
            #region 删除菜单
            if (e.ClickedItem.Name == "tlbDel")
            {
                DelMenu();
            }
            #endregion
            #region 删除模块
            if (e.ClickedItem.Name == "tlbDel2")
            {
                DelModule();
            }
            #endregion
        }
        #endregion
        #region 获取编辑记录
        #region 获取菜单编辑记录
        void GetMenuInfo(int menuID)
        {
            this.ShowWaitting(enuWaitMsgType.BindData);
            Sys_MenuResult info = new Sys_MenuResult();
            Sys_MenuLogic logic = new Sys_MenuLogic(this);
            info = logic.GetInfo(new Sys_MenuParam() { MenuID = menuID });
            this.ConvertEntityToControl<Sys_MenuResult>(this.grpEditMenu.Controls, info, null);
            this.HideWaitting();
        }
        #endregion
        #region 获取模块编辑记录
        void GetModuleInfo(int moduleID)
        {
            this.ShowWaitting(enuWaitMsgType.BindData);
            Sys_ModuleResult info = new Sys_ModuleResult();
            Sys_ModuleLogic logic = new Sys_ModuleLogic(this);
            info = logic.GetInfo(new Sys_ModuleParam() { ModuleID = moduleID });
            this.ConvertEntityToControl<Sys_ModuleResult>(this.grpEditModule.Controls, info, null);
            this.HideWaitting();
        }
        #endregion
        #endregion
        #region 从界面获取保存实体
        object Form_GetEditEntity(string editName)
        {
            object ret = null;
            if (editName == "menu")
            {
                Sys_MenuResult info = new Sys_MenuResult();
                info.MenuType = "Folder";
                info = this.ConvertControlToEntity<Sys_MenuResult>(this.grpEditMenu.Controls, info, null);
                ret = info;
            }
            else
            {
                DevComponents.AdvTree.Node node = this.treMenu.SelectedNode;
                int menuID = 0;
                menuID = node.Tag.ToInt32();
                Sys_ModuleResult info = new Sys_ModuleResult();
                info.MenuID = menuID;
                info = this.ConvertControlToEntity<Sys_ModuleResult>(this.grpEditModule.Controls, info, null);
                ret = info;
            }
            return ret;
        }
        #endregion
        #region 保存相关操作
        #region 保存菜单
        private void btnSaveMenu_Click(object sender, EventArgs e)
        {
            Sys_MenuResult info = Form_GetEditEntity("menu") as Sys_MenuResult;
            Sys_MenuLogic logic = new Sys_MenuLogic(this);
            WCFAddUpdateResult pageList = this.AsyncExecute<WCFAddUpdateResult, Sys_MenuResult>(info, logic.AddOrUpdate, SaveComplete);
        }
        void SaveComplete(WCFAddUpdateResult a)
        {
            if (a.Key.ToInt32() > 0)
            {
                this.grpEditMenu.Visible = false;
                BindMenuTree();
                this.HidEditWindow();
            }
        }
        #endregion
        #region 保存模块
        private void btnSaveEditModule_Click(object sender, EventArgs e)
        {
            DevComponents.AdvTree.Node node = this.treMenu.SelectedNode;
            if (node == null)
            {
                this.ShowMessage("请指定菜单！");
                return;
            }
            Sys_ModuleResult info = Form_GetEditEntity("module") as Sys_ModuleResult;
            Sys_ModuleLogic logic = new Sys_ModuleLogic(this);
            WCFAddUpdateResult pageList = this.AsyncExecute<WCFAddUpdateResult, Sys_ModuleResult>(info, logic.AddOrUpdate, (a) => { if (a.Key.ToInt32() > 0) { this.grpEditModule.Visible = false; this.BindModuleList(); this.HidEditWindow(); } });
        }
        #endregion
        #endregion
        #region 加载模块列表
        private void treMenu_NodeClick(object sender, DevComponents.AdvTree.TreeNodeMouseEventArgs e)
        {
            this.BindModuleList();
        }
        #endregion
        #region 模块单元格双击弹出修改
        private void dgvModule_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            editModuleList(e.RowIndex);
        }
        void editModuleList(int rowIdx)
        {
            DevComponents.AdvTree.Node node = this.treMenu.SelectedNode;
            int moduleID = 0;
            if (node != null)
            {
                moduleID = this.dgvModule["col_Sys_Module_ModuleID", rowIdx].Value.ToInt32();
                GetModuleInfo(moduleID);
            }
            this.ShowEditWindow("修改模块", this.grpEditModule);
            
        }
        #endregion
        #region 关闭小窗体
        private void btnCloseEditMenu_Click(object sender, EventArgs e)
        {
            this.HidEditWindow();
        }

        private void btnCloseEditModule_Click(object sender, EventArgs e)
        {
            this.HidEditWindow();
        }
        #endregion
        #region 删除列表
        void DelMenu()
        {
            DevComponents.AdvTree.Node node = this.treMenu.SelectedNode;
            int menuID = 0;
            if (node == null)
            {
                this.ShowMessage("请选择要删除的菜单！");
                return;
            }
            if (MessageBox.Show("是否真的删除当前记录？", "删除提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            menuID = node.Name.Substring(3).ToInt32();
            Sys_MenuParam info = new Sys_MenuParam();
            info.MenuID = menuID;
            Sys_MenuLogic logic = new Sys_MenuLogic(this);
            WCFAddUpdateResult rst = this.AsyncExecute<WCFAddUpdateResult, Sys_MenuParam>(info, logic.DelInfo, (a) => { if(a.Key>0) this.BindMenuTree(); });
        }
        void DelModule()
        {
            DataGridViewCell cell = this.dgvModule.CurrentCell;
            if (cell == null || cell.RowIndex<0)
            {
                this.ShowMessage("请选择要删除的模块！");
                return;
            }
            int moduleID = 0;
            moduleID = this.dgvModule["col_Sys_Module_ModuleID", cell.RowIndex].Value.ToInt32();
            if (MessageBox.Show("是否真的删除当前记录？", "删除提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            Sys_ModuleParam info = new Sys_ModuleParam();
            info.ModuleID = moduleID;
            Sys_ModuleLogic logic = new Sys_ModuleLogic(this);
            WCFAddUpdateResult rst = this.AsyncExecute<WCFAddUpdateResult, Sys_ModuleParam>(info, logic.DelInfo, (a) => { this.BindModuleList(); });
        }
        #endregion
    }
}
