using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLCRM.Entity.DBModel;

namespace ZNLCRM.Entity.UserModel.WF
{
    [Serializable]
    public class WF_AuditBillResult : WF_AuditBill
    {
        public List<WF_AuditBillLineResult> WF_AuditBillLineList { get; set; }
        public List<WF_AuditRecordResult> WF_AuditRecordResultList { get; set; }
        /// <summary>
        /// 单据状态
        /// </summary>
        public string BillStatus { get; set; }
        /// <summary>
        /// 单据中文状态
        /// </summary>
        public string ApproveStatus { get; set; }

    }
}
