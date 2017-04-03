using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ZNLCRM.Controls
{
    public partial class UcBlockList : UserControl
    {
        #region 子级实体类
        public class UcBlockListInfo
        {
            public string TaskDesc = "";
            public string TaskID;
            public string LinkName;
        }
        #endregion
        public UcBlockList()
        {
            InitializeComponent();
            if (!this.DesignMode)
            {
                this.panMid.Controls.Clear();
            }
        }
        private List<UcBlockListInfo> _listDataSource = new List<UcBlockListInfo>();
        #region 自定义事件
        public delegate void dlgBlockLinkClick(string key);
        [Category("自定义事件"), Description("链接单击选择")]
        public event dlgBlockLinkClick BlockLinkClick;
        public delegate void dlgBlockMoreClick();
        [Category("自定义事件"), Description("更多单击时")]
        public event dlgBlockMoreClick BlockMoreClick;
        #endregion
        #region 自定义属性
        public string TitleText
        {
            set
            {
                this.lblTitle.Text = value.ToString();
            }
        }
        public Image TitelIcon
        {
            set
            {
                this.pictureBox1.Image = value;
            }
        }
        #endregion
        #region 绑定数据源
        /// <summary>
        /// 绑定数据源
        /// </summary>
        /// <param name="bindData"></param>
        public void SetDataSource(List<UcBlockListInfo> bindData )
        {
            _listDataSource = bindData;
            BindData();
        }
        private void BindData()
        {
            DevComponents.DotNetBar.PanelEx newPanel = new DevComponents.DotNetBar.PanelEx();
            panMid.Controls.Clear();
            #region 显示列表数据
            foreach (UcBlockListInfo info in _listDataSource)
            {
                #region 添加列表容器
                newPanel = new DevComponents.DotNetBar.PanelEx();
                newPanel.Style.BackColor1.Color = Color.Transparent;
                newPanel.Style.BackColor2.Color = Color.Transparent;
                newPanel.Dock = DockStyle.Top;
                newPanel.Height = 22;
                newPanel.Style.Alignment = StringAlignment.Near;
                newPanel.Padding = new Padding(0,3,0,0);
                #endregion
                #region 添加显示内容
                LinkLabel lbl = new LinkLabel();
                lbl.Text = info.TaskDesc;
                lbl.Dock = DockStyle.Fill;
                lbl.Tag = info.TaskID;
                lbl.ForeColor = Color.Gray;
                lbl.LinkColor = Color.Gray;
                
                lbl.LinkClicked += new LinkLabelLinkClickedEventHandler(linkLabel_LinkClicked); 
                newPanel.Controls.Add(lbl);
                #endregion
                #region 添加查看链接按钮
                if (!string.IsNullOrEmpty(info.LinkName))
                {
                    LinkLabel linkLabel = new LinkLabel();
                    linkLabel.Text = info.LinkName;
                    linkLabel.AutoSize = false;
                    linkLabel.Height = 26;
                    linkLabel.Width = 50;
                    linkLabel.Tag = info.TaskID;
                    linkLabel.Dock = DockStyle.Right;
                    linkLabel.LinkClicked += new LinkLabelLinkClickedEventHandler(linkLabel_LinkClicked);
                    newPanel.Controls.Add(linkLabel);
                }
                #endregion
                panMid.Controls.Add(newPanel);
            }
            #endregion
        }
        #region 动态添加控件的事件
        void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (BlockLinkClick == null) return;
            LinkLabel linkLabel = sender as LinkLabel;
            string key = linkLabel.Tag == null ? "" : linkLabel.Tag.ToString();
            BlockLinkClick(key);
        }

        private void lnkMore_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (BlockMoreClick == null) return;
            BlockMoreClick();
        }
        #endregion
        #endregion


    }
}
