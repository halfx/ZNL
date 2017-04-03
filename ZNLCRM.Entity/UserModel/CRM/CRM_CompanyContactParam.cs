using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLFrame.Entity;

namespace ZNLCRM.Entity.UserModel.CRM
{
    [Serializable]
    public class CRM_CompanyContactParam:PageParam
    {
        public int? CompanyID { get; set; }
        public int? ContactID { get; set; }
        public int? OrgID { get; set; }
        public int? DeptID { get; set; }
        public string ContactName { get; set; }
        public string Telephone { get; set; }
     }
}
