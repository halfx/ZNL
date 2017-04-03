using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLCRM.Entity.DBModel;


namespace ZNLCRM.Entity.UserModel.HR
{
    [Serializable]
    public class HR_DepartmentResult : HR_Department
    {
        public string ParentDeptName { get; set; }
        public string DeptOrgName { get; set; }
        public Guid? DeptOrgGuID { get; set; }
        public int? DeptOrgID { get; set; }
    }
}
