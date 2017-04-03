using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLFrame.Entity;

namespace ZNLCRM.Entity.UserModel.PPM
{
    [Serializable]
    public  class ORD_PurchaseOrderParam:PageParam
    {
        public int? POID { get; set; }
        public Guid? POGuid { get; set; }
        public Guid?[] POGuids { get; set; }
        public string BillNo { get; set; }
        public string BillType { get; set; }
        public int SupplierID { get; set; }
        public string SupplierName { get; set; }
        public string PONumber { get; set; }
        public string Contact { get; set; }
        public string PurOrgName { get; set; }
        public string PurDeptName { get; set; }
        public string BuyerName { get; set; }
        public string ClearingForm { get; set; }
        public string Status { get; set; }
        public string StkInOccStatus { get; set; }
        public string[] StkInOccStatusArr { get; set; }
        public string[] ModelList { get; set; }
        public string[] BrandList { get; set; }
        public string Model { get; set; }  //商品型号
        public string Brand { get; set; }  //品牌
        public string StkInStatus { get; set; }  //入库状态
        public string Currency { get; set; } //币种
        public string HasTaxRate { get; set; } //含税否
        public DateTime? StartPODate { get; set; } //采购日期(起)
        public DateTime? EndPODate { get; set; } //采购日期(至)
        public DateTime? StartNeedPayAmtDate { get; set; } //需付款日期(起)
        public DateTime? EndNeedPayAmtDate { get; set; } //需付款日期(至)
        public DateTime? StartNeedDeliveryDate { get; set; } //需到货日期(起)
        public DateTime? EndNeedDeliveryDate { get; set; } //需到货日期(至)
    }
}
