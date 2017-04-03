using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLFrame.Entity;

namespace ZNLCRM.Entity.UserModel.SPM
{
    [Serializable]
    public   class ORD_SalesReturnLineParam:PageParam
    {
        public Guid? SRLineGuid { get; set; }
        public Guid?[] SRLineGuids { get; set; }
        public Guid?[] NoSRLineGuids { get; set; }
        public Guid? SRGuid { get; set; }
        public Guid? SOGuid { get; set; }
        public Guid? SOLineGuid { get; set; }
        public Guid?[] SOLineGuids { get; set; }
        public Guid? StkOutGuid { get; set; }
        public Guid? StkOutLineGuid { get; set; }
        public Guid?[] StkOutLineGuids { get; set; }
        public Guid? ItemCode { get; set; }
        public string Model { get; set; }
    }
}
