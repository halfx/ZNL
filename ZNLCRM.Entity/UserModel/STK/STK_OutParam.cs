using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLFrame.Entity;

namespace ZNLCRM.Entity.UserModel.STK
{
    [Serializable]
    public class STK_OutParam:PageParam
    {
        public int? StkOutID {get;set;}
        public Guid? StkOutGuid { get; set; }
        public Guid?[] StkOutGuids { get; set; }
        public string BillNo { get; set; }
        public string BillType{get;set;}
        public Guid? SourceBillGuid { get; set; }
        public string SourceBillNo { get; set; }
        public string Status { get; set; }
    }
}
