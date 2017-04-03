using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLCRM.Entity.DBModel;

namespace ZNLCRM.Entity.UserModel.PPM
{
    [Serializable]
    public   class ORD_PurchaseReturnResult:ORD_PurchaseReturn
    {
        public string OperOrgName { get; set; }
        public string OperDeptName { get; set;}
        public List<ORD_PurchaseReturnLineResult> ReturnLineList { get; set; }
        public string AllStatus { get; set; }
    }
}
