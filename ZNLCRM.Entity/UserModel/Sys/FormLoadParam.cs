using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLFrame.Entity;

namespace ZNLCRM.Entity.UserModel.Sys
{
    [Serializable]
    public class FormLoadParam:PageParam
    {
        public string NameSpace { get; set; }
        public string FormName { get; set; }
    }
}
