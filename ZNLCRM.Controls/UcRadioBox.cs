using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ZNLCRM.Controls
{
    public partial class UcRadioBox : RadioButton
    {
        public UcRadioBox()
        {
            InitializeComponent();
        }

        public UcRadioBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
