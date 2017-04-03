using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZNLCRM.Entity.UserModel.Common
{
    [Serializable]
    public class WCFAddUpdateResult
    {
        public int Key { get; set; }
        public Guid? KeyGuid { get; set; }
        public string BillNo{get;set;}

        public DateTime? CreatedTime { get; set; }
        public int? CreatedEmpID { get; set; }
        public string CreatedEmpName { get; set; }

        public DateTime? UpdatedTime { get; set; }
        public int? UpdatedEmpID { get; set; }
        public string UpdatedEmpName { get; set; }


    }
}
