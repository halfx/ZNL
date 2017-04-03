using System.ComponentModel;
using System.Windows.Forms;

namespace ZNLCRM.Controls
{
    public partial class UcLinkLabel : LinkLabel
    {
        public UcLinkLabel()
        {
            InitializeComponent();
        }

        public UcLinkLabel(IContainer container)
        {
            InitializeComponent();
            if (!this.DesignMode)
            {
                container.Add(this);
            }
        }
    }
}
