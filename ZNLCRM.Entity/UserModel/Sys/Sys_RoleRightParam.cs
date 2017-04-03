using System;
using ZNLFrame.Entity;

namespace ZNLCRM.Entity.UserModel.Sys
{
    [Serializable]
    public class Sys_RoleRightParam : PageParam
    {
        public int RoleRightID { get; set; }
        public Guid GCompanyID { get; set; }
        public int RoleID { get; set; }
        public int ModuleID { get; set; }
        public string ActionCode { get; set; }
        public Boolean IsDeleted { get; set; }
        public string MenuCode { get; set; }
        public string ModuleName { get; set; }
    }
}
