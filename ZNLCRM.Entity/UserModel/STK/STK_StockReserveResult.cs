using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLCRM.Entity.DBModel;

namespace ZNLCRM.Entity.UserModel.STK
{
    [Serializable]
    public class STK_StockReserveResult : STK_StockReserve
    {
        public string BelongEmpName { get; set; }
        public DateTime? SourceBillDate { get; set; }
        public string SourceBillLineCode { get; set; }
        public int? Qty { get; set; }
        public string Unit { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }
        public string Batch { get; set; }
        public string Package { get; set; }
        public string Quality { get; set; }
        public string MPQ { get; set; }
        public string MarkCode { get; set; }
        public string Warehouse { get; set; }
        public string Location { get; set; }
        public string InvType { get; set; }
        public string InBatchNo { get; set; }
        public List<STK_StockReserveResult> ReserveList { get; set; }
        public bool OperFlag { get; set; }//true 代表增加，flase代表减少
    }
}
