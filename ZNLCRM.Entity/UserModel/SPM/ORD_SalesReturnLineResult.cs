using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLCRM.Entity.DBModel;

namespace ZNLCRM.Entity.UserModel.SPM
{
    [Serializable]
    public  class ORD_SalesReturnLineResult:ORD_SalesReturnLine
    {
        public string SRBillNo { get; set; }
        public string  LinkStkInCurrency { get; set; }
        public decimal? LinkStkInExchangeRate { get; set; }
        public decimal? LinkStkInUnitPrice { get; set; }
        public decimal? LinkStkInFreight { get; set; }
        public decimal? LinkStkInCostPrice { get; set; }
        public decimal? LinkStkInTaxRate { get; set; }
    }
}
