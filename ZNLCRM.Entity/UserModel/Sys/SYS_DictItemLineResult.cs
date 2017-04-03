using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLCRM.Entity.DBModel;
using ZNLCRM.Utility.CommonEnum;

namespace ZNLCRM.Entity.UserModel.Sys
{
    [Serializable]
    public class SYS_DictItemLineResult : SYS_DictItemLine
    {
        public string ItemCode { get; set; }
        public DataValueType ValueType { get; set; } 
    }
}
