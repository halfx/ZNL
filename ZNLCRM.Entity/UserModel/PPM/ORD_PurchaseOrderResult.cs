using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLCRM.Entity.DBModel;
using ZNLCRM.Entity.UserModel.HR;

namespace ZNLCRM.Entity.UserModel.PPM
{
    [Serializable]
    public class ORD_PurchaseOrderResult : ORD_PurchaseOrder
    {
       
        public HR_DepartmentResult HR_DepartmentResult { get; set; }
        public List<ORD_PurchaseOrderLineResult> OrderLineList { get; set; }
        public string AllStatus { get; set; }
        public string PurOrgName { get; set; }
        public string PurDeptName { get; set; }
        public string IsCancelName { get; set; }
    }
}
