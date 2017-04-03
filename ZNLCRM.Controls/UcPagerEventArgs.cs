using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZNLCRM.Controls
{
    public partial class UcPagerEventArgs : EventArgs
    {
        public int PageIndex { get; set; }
        public bool CancelEvent { get; set; }
    }
}
