using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLCRM.Entity.DBModel;

namespace ZNLCRM.Entity.UserModel.CRM
{
    [Serializable]
    public class CRM_VisitPlanResult : CRM_VisitPlan
    {
        public CRM_CompanyResult CrmCompany { get; set; }
        public string  LastVisitTime { get; set; }
        public int TotalVisitCount{get;set;}
        public string CompanyName { get; set; }
    }
}
