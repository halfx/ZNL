using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace ZNLCRM.Controls
{
    public partial class UcRichBox : System.Windows.Forms.RichTextBox
    {
        public UcRichBox()
        {
            InitializeComponent();
        }

        public UcRichBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
