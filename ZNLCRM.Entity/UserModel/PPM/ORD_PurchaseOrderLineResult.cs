using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLCRM.Entity.DBModel;

namespace ZNLCRM.Entity.UserModel.PPM
{
    [Serializable]
    public class ORD_PurchaseOrderLineResult : ORD_PurchaseOrderLine
    {
        public string POBillNo { get; set; }
        public string SOLineCode { get; set; }
        public string SOModel { get; set; }
        public string SOBrand { get; set; }
        public string SOBatch { get; set; }
        public string SOPackage { get; set; }
        public int? SOQty { get; set; }
        public DateTime? SONeedDeliveryDate { get; set; }
        public string Currency { get; set; }
        public decimal? TaxRate { get;set;}
        public int? BuyerID { get; set; }
        public string BuyerName { get; set; }
        public string BillNo { get; set; }//采购订单号
    }
}
