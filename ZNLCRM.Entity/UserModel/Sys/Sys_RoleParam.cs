using System;
using ZNLFrame.Entity;


namespace ZNLCRM.Entity.UserModel.Sys
{
    [Serializable]
    public class Sys_RoleParam : PageParam
    {
        public int RoleID { get; set; }
        public string RoleName { get; set; }
        public Boolean IsDeleted { get; set; }
    }
}
