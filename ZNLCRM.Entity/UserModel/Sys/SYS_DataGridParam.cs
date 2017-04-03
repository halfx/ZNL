using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZNLCRM.Entity.UserModel.Sys
{
    [Serializable]
    public class SYS_DataGridParam
    {
        public int? DGID { get; set; }
        public string[] GridNames { get; set; }
        public string[] FormNames { get; set; }
        public string[] ParentNames { get; set; }
    }
}
