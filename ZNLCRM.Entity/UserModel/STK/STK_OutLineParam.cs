using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLFrame.Entity;

namespace ZNLCRM.Entity.UserModel.STK
{
    [Serializable]
    public class STK_OutLineParam:PageParam
    {
        public int? StkOutLineID { get; set; }

        public Guid? StkOutGuid { get; set; }
        public string Status { get; set; }
        public Guid?[] StkOutGuids { get; set; }
        public Guid? StkOutLineGuid { get; set; }
        public Guid?[] StkOutLineGuids { get; set; }
        public Guid?[] NoStkOutLineGuids { get; set; }
        public Guid? SourceBillGuid { get; set; }
        public Guid? SourceBillLineGuid { get; set; }

        public string Model { get; set; }
        public bool? IsReturnOver { get; set; }

        public Guid?[] SourceBillLineGuids { get; set; }
        public Guid?[] StkInLineGuids { get; set; }

        public string SourceBillNo { get; set; }
        public string StkOutBillNo { get; set; }
        
       
    }
}
