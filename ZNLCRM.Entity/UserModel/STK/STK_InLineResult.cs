using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLCRM.Entity.DBModel;

namespace ZNLCRM.Entity.UserModel.STK
{
    [Serializable]
    public   class STK_InLineResult:STK_InLine
    {
        public string StkInBillNo { get; set; }
        public string SourceBillNo { get; set; }
    }
}
