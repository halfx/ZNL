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
    public partial class UcEditPanel : UserControl
    {
         #region 控件属性
        Point pt;
        /// <summary>
        /// 获取或设置控件标题
        /// </summary>
        [DefaultValue((string)null), Description("文本")]
        public string Title
        {
            get { return this.pTitle.Text; }
            set { this.pTitle.Text = value; } 
        }

        /// <summary>
        /// 获取或设置控件内容文本
        /// </summary>
        [DefaultValue("暂无数据"), Description("文本")]
        public string ContentText
        {
            get { return this.pContent.Text; }
            set { this.pContent.Text = value; }
        }

        /// <summary>
        /// 获取窗体内容容器
        /// </summary>
        public DevComponents.DotNetBar.PanelEx ContentPanel { get { return this.pContent; } }

        #endregion
        public UcEditPanel()
        {
            InitializeComponent();
            if (!this.DesignMode)
            {
                this.pContent.Controls.Clear();
            }
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
      
        private void pTitle_MouseDown(object sender, MouseEventArgs e)
        {
            pt = Cursor.Position;
        }

        private void pTitle_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int px = Cursor.Position.X - pt.X;
                int py = Cursor.Position.Y - pt.Y;
                this.Location = new Point(this.Location.X + px, this.Location.Y + py);

                pt = Cursor.Position;
            }
        }

        private void UcEditPanel_Load(object sender, EventArgs e)
        {
            this.Location = new Point((this.Parent.Width - this.Width) / 2, (this.Parent.Height - this.Height) / 2);
        }
        Dictionary<string, int[]> _editSize = new Dictionary<string, int[]>();
        public void AddControl(Control c, string editTitle)
        {


            if (!this.pContent.Controls.Contains(c))
            {
                _editSize.Add(c.Name, new int[] { c.Width + 20, c.Height + 46 });
                this.pContent.Controls.Add(c);
                
            }
            foreach (Control control in this.pContent.Controls)
            {
                if (control.Name != c.Name)
                {
                    control.Visible = false;
                }
            
            }
            this.Width = _editSize[c.Name][0];
            this.Height = _editSize[c.Name][1];
            c.Visible = true;
            c.Dock = DockStyle.Fill;
            this.Anchor = AnchorStyles.None;
            this.pTitle.Text = editTitle;
        }

    }
}
