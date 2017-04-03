using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLCRM.Entity.DBModel;

namespace ZNLCRM.Entity.UserModel.STK
{
    [Serializable]
    public   class STK_OutLineResult:STK_OutLine
    {
        public string SourceBillNo { get; set; }
        public string StkOutBillNo { get; set; }
        public int? BuyerID { get; set; }
        public string BuyerName { get; set; }

    }
}
