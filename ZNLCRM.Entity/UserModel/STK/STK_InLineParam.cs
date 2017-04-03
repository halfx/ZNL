using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLFrame.Entity;

namespace ZNLCRM.Entity.UserModel.STK
{
    [Serializable]
    public  class STK_InLineParam:PageParam
    {
        public Guid? StkInLineGuid { get; set; }
        public Guid?[] StkInLineGuids { get; set; }
        public Guid? SourceBillGuid { get; set; }
        public string SourceBillNo { get; set; }
        public Guid? StkInGuid { get; set; }
        public Guid?[] StkInGuids { get; set; }
        public string StkInBillNo { get; set; }
        public Guid? SourceBillLineGuid { get; set; }
        public Guid?[] SourceBillLineGuids { get; set; }
        public string Model { get; set; }
        public Guid?[] SOLineGuids { get; set; }
        public Guid? ItemCode { get; set; }
        public Guid?[] ItemCodes { get; set; }
        public string Status { get; set; }
        public bool? IsReturnOver { get; set; }
        
        
    }
}
