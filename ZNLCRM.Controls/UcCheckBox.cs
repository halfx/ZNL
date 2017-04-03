using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using DevComponents.DotNetBar.Controls;

namespace ZNLCRM.Controls
{
    public partial class UcCheckBox : CheckBoxX
    {
        public UcCheckBox()
        {
            InitializeComponent();
        }

        public UcCheckBox(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
        }
    }
}
