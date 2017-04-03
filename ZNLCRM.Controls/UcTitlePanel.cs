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
    public partial class UcTitlePanel : UserControl
    {
        #region 控件属性

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
        public UcTitlePanel()
        {
            InitializeComponent();
        }
    }
}
