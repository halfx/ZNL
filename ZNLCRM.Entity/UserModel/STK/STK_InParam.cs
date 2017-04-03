using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLFrame.Entity;
using ZNLCRM.Entity.UserModel.HR;

namespace ZNLCRM.Entity.UserModel.STK
{
    [Serializable]
    public   class STK_InParam:PageParam
    {
        public Guid? StkInGuid { get; set; }
        public Guid?[] StkInGuids { get; set; }
        public string BillNo { get; set; }
        public string BillType { get; set; }
        public Guid? SourceBillGuid { get; set; }
        public string SourceBillNo { get; set; }
        public string Status { get; set; }
        public string[] StatusArr { get; set; }
       
    }
}
