using System.ComponentModel;
using DevComponents.Editors.DateTimeAdv;


namespace ZNLCRM.Controls
{
    public partial class UcDateTimeInput:DateTimeInput
    {
        public UcDateTimeInput()
        {
            InitializeComponent();
        }

        public UcDateTimeInput(IContainer container)
        {
            InitializeComponent();
            
            if (!this.DesignMode)
            {
                container.Add(this);
            }
        }


    }
}
