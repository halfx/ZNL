using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLFrame.Entity;

namespace ZNLCRM.Entity.UserModel.FIN
{
   [Serializable]
    public   class FIN_CashBankJournalParam:PageParam
    {
       public int? CBJID { get; set; }
       public int? CBID { get; set; }
       public string BillType { get; set; }
       public string SourceBillNo { get; set; }
       public string Abstract { get; set; }

       
    }
}
