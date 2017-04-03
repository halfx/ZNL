using System;
using ZNLCRM.Entity.DBModel;

namespace ZNLCRM.Entity.UserModel.Sys
{
    [Serializable]
    public class Sys_RoleRightResult : Sys_RoleRight
    {
        public string ModuleName { get; set; }
        public string RoleName { get; set; }
    }
}
