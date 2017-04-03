using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLFrame.Entity;

namespace ZNLCRM.Entity.UserModel
{
    [Serializable]
    public class FIN_CashBankAccountParam : PageParam
    {
        public int? CBID { get; set; }
        public Guid? CBGuid { get; set; }
        public string CBNo { get; set; }
        public string CBName { get; set; }
        public string BCode { get; set; }
    }
}
