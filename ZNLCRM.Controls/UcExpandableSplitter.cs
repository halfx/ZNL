using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using DevComponents.DotNetBar;

namespace ZNLCRM.Controls
{
    public partial class UcExpandableSplitter : ExpandableSplitter
    {
        public UcExpandableSplitter()
        {
            InitializeComponent();
            SetStyle();
        }

        public UcExpandableSplitter(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
            SetStyle();
        }

        private void SetStyle()
        {
        }
    }
}
