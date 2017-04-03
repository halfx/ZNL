using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLFrame.Entity;

namespace ZNLCRM.Entity.UserModel.WF
{
    public class AuditBillParam : PageParam
    {
        public Guid? SourceBillGuid { get; set; }
        public string OldBillStatus { get; set; }
        public string NewBillStatus { get; set; }
        public string TriggerStatus { get; set; }
        public string SourceTableName { get; set; }
        /// <summary>
        /// 可执行状态,PassBill(单据通过),CancelBill(撤单)
        /// </summary>
        public string ExecuteStatus { get; set; }

    }
}
