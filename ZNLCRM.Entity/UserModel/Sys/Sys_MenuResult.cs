using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLCRM.Entity.DBModel;

namespace ZNLCRM.Entity.UserModel.Sys
{
    [Serializable]
    public class Sys_MenuResult : Sys_Menu
    {
        public string ParentMenuName { get; set; }

        public string TargetForm { get; set; }

        public string NewSeq { get; set; }
    }
}
