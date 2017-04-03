using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLFrame.Entity;

namespace ZNLCRM.Entity.UserModel.PPM
{
    [Serializable]
    public   class ORD_PurchaseReturnLineParam:PageParam
    {
        public Guid? PRLineGuid { get; set; }
        public Guid?[] PRLineGuids { get; set; }
        public Guid? PRGuid { get; set; }
        public Guid? POGuid { get; set; }
        public Guid? POLineGuid { get; set; }
        public Guid?[] POLineGuids { get; set; }
        public Guid? StkInGuid { get; set; }
        public Guid? StkInLineGuid { get; set; }
        public Guid?[] StkInLineGuids { get; set; }
        public Guid? ItemCode { get; set; }
        public string Model { get; set; }
    }
}
