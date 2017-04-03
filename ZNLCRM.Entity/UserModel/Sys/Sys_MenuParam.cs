using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLFrame.Entity;

namespace ZNLCRM.Entity.UserModel.Sys
{
    [Serializable]
    public class Sys_MenuParam : PageParam
    {
        public int MenuID { get; set; }
        public string MenuCode { get; set; }
        public string MenuName { get; set; }


    }
}
