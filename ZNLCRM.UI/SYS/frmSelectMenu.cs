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
using ZNLCRM.Utility;

namespace ZNLCRM.UI.SYS
{
    public partial class frmSelectMenu : frmBaseForm
    {
        public frmSelectMenu()
        {
            InitializeComponent();
        }
        List<Sys_MenuResult> _lstSelectNode = new List<Sys_MenuResult>();
        private void btnSaveEditModule_Click(object sender, EventArgs e)
        {
            if (_lstSelectNode.Count <= 0)
            {
                this.ShowMessage("您未选择记录!");
                return;
            }
            this.Tag = _lstSelectNode;
            this.Close();
        }
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
            DevComponents.AdvTree.Node beforeNode = null, currentNode = null; ;
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
                    currentNode.CheckBoxVisible = true;
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
                    currentNode.CheckBoxVisible = true;
                    currentNode.ImageExpanded = ZNLCRM.UI.Properties.Resources.folder16;
                    lstNode[parentCode].Nodes.Add(currentNode);
                }
                #endregion
                lstNode.Add(info.MenuCode, currentNode);
            }
            HideWaitting();
        }
        #endregion


        private void btnCloseEditModule_Click(object sender, EventArgs e)
        {
            List<Sys_MenuResult> _lstSelectNode = new List<Sys_MenuResult>();
            this.Close();
        }

        private void frmSelectMenu_Load(object sender, EventArgs e)
        {
            BindMenuTree();
        }

        private void treMenu_NodeClick(object sender, DevComponents.AdvTree.TreeNodeMouseEventArgs e)
        {
            DevComponents.AdvTree.Node slcNode = this.treMenu.SelectedNode;
            if (slcNode == null) return;
            if (slcNode.Checked)
            {
                if (!_lstSelectNode.Exists(a => a.MenuCode == slcNode.Tag.ToStringHasNull()))
                {
                    _lstSelectNode.Add(new Sys_MenuResult() { MenuCode = slcNode.Tag.ToStringHasNull(), MenuName = slcNode.Text });
                }
            }
            else
            
                if (!_lstSelectNode.Exists(a => a.MenuCode == slcNode.Tag.ToStringHasNull()))
                {
                    _lstSelectNode.Remove(_lstSelectNode.Find(a=>a.MenuCode==slcNode.Tag.ToStringHasNull()));
                }
            }

        private void panBottom_Click(object sender, EventArgs e)
        {
        
        
        }
    }
}
