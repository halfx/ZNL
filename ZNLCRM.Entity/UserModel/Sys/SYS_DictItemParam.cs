using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLFrame.Entity;

namespace ZNLCRM.Entity.UserModel.Sys
{
    [Serializable]
    public class SYS_DictItemParam : PageParam
    {
        public int? DictItemID { get; set; }
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public string Condition { get; set; }
        public string[] ItemCodes { get; set; }

    }
}
