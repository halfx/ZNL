using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLCRM.Entity.DBModel;

namespace ZNLCRM.Entity.UserModel.Account
{
    [Serializable]
    public class SYS_UserAccountResult : SYS_UserAccount
    {
        public string EmpName { get; set; }
        public int LoginSucceed { get; set; }

        public string SaleCurrency { get; set; }
        public string BuyCurrency { get; set; }

        public int? OrgID { get; set; }
        public int? DeptID { get; set; }
        public string OrgName { get; set; }
        public string DeptName { get; set; }
    }
}
