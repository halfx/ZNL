using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLFrame.Entity;

namespace ZNLCRM.Entity.UserModel.STK
{
    [Serializable]
    public  class STK_InOutLinkParam:PageParam
    {
        public Guid? StkLinkGuid { get; set; }
        public Guid? StkInGuid { get; set; }
        public Guid? StkInLineGuid { get; set; }
        public Guid?[] StkInLineGuids { get; set; }
        public Guid? StkOutGuid { get; set; }
        public Guid? ItemCode { get; set; }
    }
}
