using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLCRM.Entity.DBModel;
using ZNLCRM.Entity.UserModel.PPM;

namespace ZNLCRM.Entity.UserModel.SPM
{
    [Serializable]
    public class ORD_SalesReturnResult : ORD_SalesReturn
    {
        public List<ORD_SalesReturnLineResult> ReturnLineList { get; set; }
        public string AllStatus { get; set; }
        public string OperOrgName { get; set; }
        public string OperDeptName { get; set; }
    }
}
