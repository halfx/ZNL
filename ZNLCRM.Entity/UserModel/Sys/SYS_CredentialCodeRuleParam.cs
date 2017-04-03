using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLFrame.Entity;

namespace ZNLCRM.Entity.UserModel.Sys
{
    [Serializable]
    public class SYS_CredentialCodeRuleParam : PageParam
    {
        public string TableName { get; set; }
        public DateTime? BillDate { get; set; }
        public string CredentialName { get; set; }
        public string ModuleName { get; set; }
        public int? RuleID { get; set; }
    }
}
