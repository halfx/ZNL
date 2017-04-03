using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLFrame.Entity;

namespace ZNLCRM.Entity.UserModel.Sys
{
    [Serializable]
    public class Sys_EmpDataRightParam : PageParam
    {
        public int? EmpID { get; set; }
        public string RoleID { get; set; }
        public string RoleName { get; set; }
        public int?[] EmpIDs { get; set; }
    }
}
