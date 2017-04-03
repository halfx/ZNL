using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLFrame.Entity;

namespace ZNLCRM.Entity.UserModel.WF
{
    [Serializable]
    public class WF_AuditBillParam : PageParam
    {
        public Guid? WFAuditGuid { get; set; }
        public string TableName { get; set; }
        public string WFNamae { get; set; }
    }
}
