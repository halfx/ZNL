using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLFrame.Entity;

namespace ZNLCRM.Entity.UserModel.HR
{
    [Serializable]
    public class HR_DepartmentParam : PageParam
    {
        public int? DeptID { get; set; }
        public string DeptName { get; set; }
        public int? OrgID { get; set; }
        public Guid? OrgGuID { get; set; }
        public string OrgName { get; set; }
        public int?[] DeptIDs { get; set; }
        public int?[] NoDeptIDs { get; set; }
    }
}
