using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLFrame.Entity;

namespace ZNLCRM.Entity.UserModel.WF
{
    [Serializable]
    public class WF_AuditRecordLineParam : PageParam
    {
        public Guid? WF_RecGuid { get; set; }

        public Guid?[] WF_RecGuids { get; set; }

        public Guid? WFAuditGuid { get; set; }

        public Guid? WFAuditLineGuid { get; set; }

    }
}
