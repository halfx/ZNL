using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLFrame.Entity;

namespace ZNLCRM.Entity.UserModel.Account
{
    [Serializable]
    public class SYS_CompanyInfoParam : PageParam
    {
        public string CompanyName { get; set; }
    }
}
