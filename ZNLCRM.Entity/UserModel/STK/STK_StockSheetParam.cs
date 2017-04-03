using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLFrame.Entity;

namespace ZNLCRM.Entity.UserModel.STK
{
    [Serializable]
    public  class STK_StockSheetParam:PageParam
    {
        public Guid? SSGuid { get; set; }
        public int? SSType { get; set; }
        public Guid? SourceBillNo { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }
        public Guid? ItemCode { get; set; }
        
    }
}
