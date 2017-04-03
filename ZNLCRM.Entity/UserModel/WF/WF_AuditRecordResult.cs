using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLCRM.Entity.DBModel;

namespace ZNLCRM.Entity.UserModel.WF
{
    [Serializable]
    public class WF_AuditRecordResult : WF_AuditRecord
    {
        public WF_AuditBill AuditBill { get; set; }

    }
}
