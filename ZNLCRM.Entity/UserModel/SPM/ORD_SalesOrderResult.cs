using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLCRM.Entity.DBModel;

namespace ZNLCRM.Entity.UserModel.SPM
{
    [Serializable]
    public  class ORD_SalesOrderResult:ORD_SalesOrder
    {
        public List<ORD_SalesOrderLineResult> OrderLineList { get; set; }
        public string AllStatus { get; set; }
        public string SalOrgName { get; set; }
        public string SalDeptName { get; set; }
    }
}
