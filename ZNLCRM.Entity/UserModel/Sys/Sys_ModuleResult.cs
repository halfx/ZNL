using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLCRM.Entity.DBModel;

namespace ZNLCRM.Entity.UserModel.Sys
{
    [Serializable]
    public class Sys_ModuleResult : Sys_Module
    {
        public string ParentMenuName { get; set; }
    }
}
