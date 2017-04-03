using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLCRM.Entity.DBModel;

namespace ZNLCRM.Entity.UserModel.HR
{
    [Serializable]
    public class HR_EmployeeResult : HR_Employee
    {
        public string CompanyName { get; set; }
        public string Password { get; set; }
        public DateTime? LastSignTime { get; set; }
        public string LastSignIP { get; set; }
        
        public bool? NeedValidate { get; set; }
        public string UseTimeBegin { get; set; }
        public string UseTimeOver { get; set; }
        public string MacAddress { get; set; }
        public string HardDiskSN { get; set; }
        public int? SignInTimes { get; set; }
        public DateTime? AfterTimeForBill { get; set; }
    }
}
