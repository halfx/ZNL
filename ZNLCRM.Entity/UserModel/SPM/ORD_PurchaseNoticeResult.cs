using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLCRM.Entity.DBModel;

namespace ZNLCRM.Entity.UserModel.SPM
{
    [Serializable]
    public class ORD_PurchaseNoticeResult : ORD_PurchaseNotice
    {
        public string SOBillNo { get; set; }
        public string SalerName{get;set;}
        public string SOLineCode { get; set; }
        
        public string Model { get; set; }
        public string Brand { get; set; }
        public string Batch { get; set; }
        public string Package { get; set; }
        public string InvType { get; set; }
        public string Unit { get; set; }
        public int? SaleQty { get; set; }
        public decimal? SalePrice { get; set; }
        public string  SaleCurrency { get; set; }
        public string PurStatus { get; set; }
        public DateTime? NeedDeliveryDate { get; set; }
    }
}
