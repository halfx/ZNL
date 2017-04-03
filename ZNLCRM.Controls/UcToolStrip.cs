using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Drawing;

namespace ZNLCRM.Controls
{
    public partial class UcToolStrip : System.Windows.Forms.ToolStrip
    {
        public UcToolStrip()
        {
            InitializeComponent();
            SetStyle();
        }

        public UcToolStrip(IContainer container)
        {
            container.Add(this);
            if (!this.DesignMode)
            {
                SetStyle();
            }
            InitializeComponent();
        }
        void SetStyle()
        {
            this.BackColor = Color.FromName("GradientInactiveCaption");
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Font = new System.Drawing.Font("微软雅黑", 9.5F);
        }
    }
}
