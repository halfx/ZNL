using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLFrame.Entity;

namespace ZNLCRM.Entity.UserModel.HR
{
    [Serializable]
    public class HR_EmployeeParam : PageParam
    {
        public int? EmpID { get; set; }
        public int?[] EmpIDs { get; set; }
        public Guid? EmpGuid { get; set; }
        public int? OrgID { get; set; }
        public string OrgName { get; set; }
        public int? DeptID { get; set; }
        public string DeptName { get; set; }
        public string EmpName { get; set; }
        public string EmpCode { get; set; }
        public int?[] NoEmpIDs { get; set; }
        public int IsSystem { get; set; }
    }
}
