using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLFrame.Entity;

namespace ZNLCRM.Entity.UserModel.PPM
{
    [Serializable]
    public  class ORD_PurchaseReturnParam:PageParam
    {
        public Guid? PRGuid { get; set; }
        public Guid?[] PRGuids { get; set; }
        public string BillNo { get; set; }
        public Guid? POGuid { get; set; }
        public string POBillNo { get; set; }
        public int? SupplierID{get;set;}
        public string SupplierName{get;set;}
        public string OperEmpName { get; set; }
        public string Status { get; set; }
        public string[] StatusArr { get; set; }

    }
}
