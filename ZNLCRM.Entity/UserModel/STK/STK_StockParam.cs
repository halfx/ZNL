using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLFrame.Entity;

namespace ZNLCRM.Entity.UserModel.STK
{
    [Serializable]
    public   class STK_StockParam:PageParam
    {
        public Guid? ItemCode { get; set; }
        public Guid?[] ItemCodes { get; set; }
        public Guid?[] NoItemCodes { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }
        public string Batch { get; set; }
        public string Package { get; set; }
        public string Warehouse { get; set; }
        public string Location { get; set; }
        public string InvType { get; set; }
        public bool? AllowUsableQtyZero { get; set; }
    }
}
