using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLFrame.Entity;
using ZNLCRM.Entity.DBModel;

namespace ZNLCRM.Entity.UserModel.SPM
{
    [Serializable]
    public class ORD_SalesOrderParam:PageParam
    {
        public int? SOID { get; set; }
        public Guid? SOGuid { get; set; }
        public Guid?[] SOGuids { get; set; }
        public string BillNo { get; set; }
        public string BillType { get; set; }
        public int? CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string PINumber { get; set; }
        public string PONumber { get; set; }
        public string Contact { get; set; }
        public string SalOrgName { get; set; }
        public string SalDeptName { get; set; }
        public string SalerName { get; set; }
        public string ClearingForm { get; set; }
       
     
    }
}
