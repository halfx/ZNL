using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace ZNLCRM.Controls
{
    public partial class UcPanel : Panel
    {
        public UcPanel()
        {
            InitializeComponent();
            SetStyle();
        }

        public UcPanel(IContainer container)
        {
            InitializeComponent();
            if (!this.DesignMode)
            {
                container.Add(this);
                SetStyle();
            }
        }

        private void SetStyle()
        {
            this.BackColor = Color.Transparent;
        }
    }
}
