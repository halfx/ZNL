using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZNLCRM.Entity.UserModel.Common
{
    [Serializable]
    public class DropGridCol
    {
        public string ColName { get; set; }
        public string HeadText { get; set; }
        public bool IsShow { get; set; }
        public int Width { get; set; }
        public object ToControl { get; set; }
        public bool IsDropSource { get; set; }
    }
}
