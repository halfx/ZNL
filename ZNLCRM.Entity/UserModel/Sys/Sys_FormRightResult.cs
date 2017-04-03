using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLCRM.Entity.DBModel;


namespace ZNLCRM.Entity.UserModel.Sys
{
    [Serializable]
    public class Sys_FormRightResult : Sys_FormRight
    {
        public bool PropertyValue { get; set; }

        public string ModuleName { get; set; }
    }
}
