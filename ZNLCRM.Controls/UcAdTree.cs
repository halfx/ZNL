using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace ZNLCRM.Controls
{
    public partial class UcAdTree : DevComponents.AdvTree.AdvTree
    {
        public UcAdTree()
        {
            InitializeComponent();
        }

        public UcAdTree(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
