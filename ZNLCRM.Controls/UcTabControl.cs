using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace ZNLCRM.Controls
{
    public partial class UcTabControl : DevComponents.DotNetBar.TabControl
    {
        public UcTabControl()
        {
            InitializeComponent();
            SetStyle();
        }
        public UcTabControl(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
            
        }
        private void SetStyle()
        {
            this.Style = DevComponents.DotNetBar.eTabStripStyle.VS2005;
        }
    }
}
