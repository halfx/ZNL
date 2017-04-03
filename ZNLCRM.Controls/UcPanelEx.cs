using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using DevComponents.DotNetBar;

namespace ZNLCRM.Controls
{
    public partial class UcPanelEx : PanelEx
    {
        public UcPanelEx()
        {
            InitializeComponent();
        }

        public UcPanelEx(IContainer container)
        {
            InitializeComponent();
            container.Add(this);
        }
    }
}
