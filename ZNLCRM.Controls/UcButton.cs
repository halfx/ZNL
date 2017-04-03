using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using DevComponents.DotNetBar;

namespace ZNLCRM.Controls
{
    public partial class UcButton : ButtonX
    {
        public UcButton()
        {
            InitializeComponent();
            if (!this.DesignMode)
            {
                this.EnabledChanged += new EventHandler(UcButton_EnabledChanged);
            }
        }

        void UcButton_EnabledChanged(object sender, EventArgs e)
        {
            //权限控制,防止代码里把控件的Enable属性设置为true  addby:rocky.he
            if (this.Tag != null && this.Tag.ToString() == "RoleSetDisabled" && this.Enabled)
            {
                this.Enabled = false;
            }
        }

        public UcButton(IContainer container)
        {
            InitializeComponent();
            if (!this.DesignMode)
            {
                container.Add(this);
                this.EnabledChanged += new EventHandler(UcButton_EnabledChanged);
            }
        }
    }
}
