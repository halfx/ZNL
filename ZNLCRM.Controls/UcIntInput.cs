using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using DevComponents.Editors;

namespace ZNLCRM.Controls
{
    public partial class UcIntInput : IntegerInput
    {
        public UcIntInput()
        {
            InitializeComponent();
        }

        public UcIntInput(IContainer container)
        {
            InitializeComponent();
            if (this.DesignMode)
            {
                container.Add(this);
            }
        }
    }
}
