using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLFrame.Entity;

namespace ZNLCRM.Entity.UserModel.PPM
{
    [Serializable]
    public class ORD_PurchaseOrderLineParam : PageParam
    {
        public int? POLineID { get; set; }
        public Guid? POLineGuid { get; set; }
        public int? POID { get; set; }
        public Guid? POGuid { get; set; }
        public string Model { get; set; }
        public Guid?[] POLineGuids { get; set; }
        public Guid?[] NoPOLineGuids { get; set; }
        public Guid?[] NoticeGuids { get; set; }
        public Guid?[] SOLineGuids { get; set; }
        public bool? IsCancel { get; set; }
    }
}
