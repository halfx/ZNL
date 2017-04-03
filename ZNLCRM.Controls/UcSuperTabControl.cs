using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using DevComponents.DotNetBar;

namespace ZNLCRM.Controls
{
    public partial class UcSuperTabControl : SuperTabControl
    {
        public UcSuperTabControl()
        {
            InitializeComponent();
            if (!this.DesignMode)
            {
                SetStyle();
            }
        }

        public UcSuperTabControl(IContainer container)
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
            this.TabStyle = eSuperTabStyle.Office2007;
        }
    }
}
