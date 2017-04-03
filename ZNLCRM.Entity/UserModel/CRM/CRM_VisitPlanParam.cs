using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLFrame.Entity;

namespace ZNLCRM.Entity.UserModel.CRM
{
    [Serializable]
    public  class CRM_VisitPlanParam:PageParam
    {
        public int? CustVstPlnID { get; set; }
        public Guid? CustVstPlnGuID { get; set; }
        public Guid? CompanyGuID { get; set; }
        public string PlanName { get; set; }

       
    }
}
