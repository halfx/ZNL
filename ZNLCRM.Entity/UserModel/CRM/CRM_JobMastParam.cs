using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLFrame.Entity;

namespace ZNLCRM.Entity.UserModel.CRM
{
    [Serializable]
    public class CRM_JobMastParam : PageParam
    {
        public Guid? EmpJobGuid { get; set; }
        public string JobType { get; set; }
        public DateTime? JobDateS { get; set; }
        public DateTime? JobDateE { get; set; }
        public string JobName { get; set; }
        public string BillNo { get; set; }
        public string BelongEmpIDs { get; set; }
    }
}
