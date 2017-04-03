using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLCRM.Entity.DBModel;

namespace ZNLCRM.Entity.UserModel.Sys
{

    [Serializable]
    public class Sys_EmpRightResult : Sys_EmpRight
    {
        public string ModuleName { get; set; }
        public string RightName { get; set; }

    }
}
