using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLCRM.Entity.DBModel;
using ZNLFrame.Entity;



namespace ZNLCRM.Entity.UserModel.Sys
{
    [Serializable]
    public class Sys_FormRightParam : PageParam
    {
        public string NameSpace { get; set; }
        public string FormEngName { get; set; }
        public int FormRightID { get; set; }
        public string OprControlEngName { get; set; }
    }
}
