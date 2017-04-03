using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar.Controls;

namespace ZNLCRM.Controls
{
    public partial class UcComboBox : ComboBoxEx
    {
        public UcComboBox()
        {
            InitializeComponent();
        }

        public UcComboBox(IContainer container)
        {
            InitializeComponent();
            if (!this.DesignMode)
            {
                container.Add(this);
            }
        }

        /// <summary>
        /// 禁用鼠标滚动事件
        /// </summary>
        /// <param name="m"></param>
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x020A)
            { }
            else
            {
                base.WndProc(ref m);
            }
        } 
    }
}
