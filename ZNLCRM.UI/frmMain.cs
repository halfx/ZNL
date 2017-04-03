using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZNLCRM.UI.Logic.Sys;
using ZNLCRM.Entity.UserModel.Sys;
using ZNLCRM.Utility;
using DevComponents.AdvTree;

namespace ZNLCRM.UI
{
    public partial class frmMain : Form
    {
        private int childFormNumber = 0;
        public delegate void dlgLogout();
        public dlgLogout LogOut;
        public frmMain()
        {
            InitializeComponent();
            BindMenuTree();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "窗口 " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "文本文件(*.txt)|*.txt|所有文件(*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "文本文件(*.txt)|*.txt|所有文件(*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

       
        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        #region 动态生成菜单
        void menuClick(object sender, EventArgs e)
        {
            string targetForm = "";
            if (sender.GetType() == typeof(ToolStripMenuItem))
            {
                ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;
                targetForm = menuItem.Tag.ToStringHasNull();
            }
            else
            {
                DevComponents.AdvTree.Node menuItem = (DevComponents.AdvTree.Node)sender;
                targetForm = menuItem.Tag.ToStringHasNull();
            }

            try
            {
                if (string.IsNullOrEmpty(targetForm)) return;

                string formName = targetForm.Substring(targetForm.LastIndexOf(".") + 1);
                Form form = this.MdiChildren.FirstOrDefault<Form>(a => a.Name == formName);
                if (form == null)
                {
                    form = Activator.CreateInstance(Type.GetType(targetForm)) as Form;
                    int count = this.MdiChildren.Where(a => a.Name == form.Name).Count();
                    if (form != null && count == 0)
                    {
                        form.MdiParent = this;
                    }
                }
                form.WindowState = FormWindowState.Maximized;
                form.BringToFront();
                form.Show();
            }
            catch (System.Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
        void BindMenuTree()
        {
            Sys_MenuLogic logic = new Sys_MenuLogic(this);
            List<Sys_MenuResult> lstRst = new List<Sys_MenuResult>();
            Dictionary<string, DevComponents.AdvTree.Node> nodeList = new Dictionary<string, DevComponents.AdvTree.Node>();
            Dictionary<string, ToolStripMenuItem> lstNode = new Dictionary<string, ToolStripMenuItem>();
            adtMenu.Nodes.Clear();
            this.menuStrip.Items.Clear();
            Node treeNode = null;
            ToolStripMenuItem beforeNode = null, newNode = null;
            string beforeCode = "", parentCode = "";
            lstRst = logic.GetEmpMenuTree(new Sys_MenuParam() { });
            foreach (Sys_MenuResult info in lstRst)
            {
                 if (!info.MenuCode.StartsWith(beforeCode) || beforeCode == "")
                {
                    #region 添加菜单栏里的子项
                    newNode = new ToolStripMenuItem(info.MenuName);
                    this.menuStrip.Items.Add(newNode);
                    beforeCode = info.MenuCode;
                    beforeNode = newNode;
                    #endregion

                    treeNode = new Node
                    {
                        VerticalCellLayoutAlignment = eHorizontalAlign.Left,
                        CellLayout = eCellLayout.Vertical,
                        Text = info.MenuName,
                        Name = "trn" + info.MenuCode,
                        Image = global::ZNLCRM.UI.Properties.Resources.menu_1,
                        Tag = info.TargetForm
                    };
                    nodeList.Add(info.MenuCode, treeNode);
                    adtMenu.Nodes.Add(treeNode);
                }
                else 
                {
                    #region 添加菜单栏里的子项
                    parentCode = info.MenuCode.Substring(0, info.MenuCode.Length - 3);
                    newNode = new ToolStripMenuItem(info.MenuName);
                    newNode.Tag = info.TargetForm;
                    newNode.Click += menuClick;
                    lstNode[parentCode].DropDownItems.Add(newNode);
                    #endregion

                    #region 添加advtree的节点
                    if (info.MenuType == "Leaf")//menu下dodule
                    {
                        treeNode = new Node
                        {
                            VerticalCellLayoutAlignment = eHorizontalAlign.Left,
                            CellLayout = eCellLayout.Vertical,
                            Text = info.MenuName,
                            Name = "trn" + info.MenuCode,
                            Image = global::ZNLCRM.UI.Properties.Resources.module,
                            Tag = info.TargetForm
                        };
                        nodeList[parentCode].Nodes.Add(treeNode);//添加
                        treeNode.NodeClick += menuClick;
                    }
                    else//二级menu
                    {
                        treeNode = new Node
                        {
                            VerticalCellLayoutAlignment = eHorizontalAlign.Left,
                            CellLayout = eCellLayout.Vertical,
                            Text = info.MenuName,
                            Name = "trn" + info.MenuCode,
                            Image = global::ZNLCRM.UI.Properties.Resources.menu_2,
                            Tag = info.TargetForm
                        };
                       
                        nodeList[parentCode].Nodes.Add(treeNode);
                        nodeList.Add(info.MenuCode, treeNode);//添加节点
                    }
                    #endregion
                }
                 lstNode.Add(info.MenuCode, newNode);//添加节点

            }
        }
        #endregion

        private void ucToolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Name == "tbiClose")
            {
                Form frms = this.ActiveMdiChild;
                if (frms!=null)
                {
                    frms.Close(); 
                    frms.Dispose();
                }

            }
            if (e.ClickedItem.Name == "tbiExit")
            {
                Application.Exit();
            }
        }

        private void buttonItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
