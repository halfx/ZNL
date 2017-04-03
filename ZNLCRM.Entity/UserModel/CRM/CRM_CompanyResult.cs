using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLCRM.Entity.DBModel;

namespace ZNLCRM.Entity.UserModel.CRM
{
    [Serializable]
    public class CRM_CompanyResult : CRM_Company
    {
        public List<CRM_CompanyContactResult> ContactList { get; set; }
    }
}
