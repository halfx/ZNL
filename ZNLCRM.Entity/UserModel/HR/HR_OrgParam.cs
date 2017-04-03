using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLFrame.Entity;

namespace ZNLCRM.Entity.UserModel.HR
{
    [Serializable]
    public class HR_OrgParam : PageParam
    {
        public int? OrgID { get; set; }
        public Guid? OrgGuID { get; set; }
        public int?[] OrgIDs { get; set; }
    }
}
