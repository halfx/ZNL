using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLFrame.Entity;

namespace ZNLCRM.Entity.UserModel.STK
{
    [Serializable]
    public  class STK_StockReserveParam:PageParam
    {
        public Guid? SRGuid { get; set; }
        public Guid?[] SourceBillLineGuids { get; set; }
        public Guid?[] SRGuids { get; set; }
        public Guid?[] NoSRGuids { get; set; }
        public Guid? SourceBillGuid { get; set; }
        public string SourceBillNo { get; set; }
        public Guid? SourceBillLineGuid { get; set; }
        public string SourceBillLineCode { get; set; }
        public Guid? ItemCode { get; set; }
        public string Model { get; set; }
        public bool? IsUsedOver { get; set; }
    }
}
