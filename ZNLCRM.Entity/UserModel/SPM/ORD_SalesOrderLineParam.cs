using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLFrame.Entity;

namespace ZNLCRM.Entity.UserModel.SPM
{
    [Serializable]
    public  class ORD_SalesOrderLineParam:PageParam
    {
        public int? SOLineID { get; set; }
        public Guid? SOLineGuid { get; set; }
        public string SOLineCode { get; set; }
        public int? SOID { get; set; }
        public Guid? SOGuid { get; set; }
        public Guid?[] SOGuids{ get; set; }
        public string Model { get; set; }
        public Guid?[] SOLineGuids { get; set; }
        public bool? IsCancel { get; set; }
       
    }
}
