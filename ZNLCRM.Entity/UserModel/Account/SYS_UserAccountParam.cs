using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLFrame.Entity;

namespace ZNLCRM.Entity.UserModel.Account
{
    [Serializable]
    public class SYS_UserAccountParam : PageParam
    {
        public string CompanyCode { get; set; }
        public string CompanyName { get; set; }
        public string Account { get; set; }
        public string UserName { get; set; }
        public Guid? UserGuid { get; set; }
        public string PWD { get; set; }
        public string NewPwd { get; set; }
        public string ClientIP { get; set; }
        public string MacAddress { get; set; }
        public string HardSN { get; set; }
        public bool IsMainAccount { get; set; }
        public string PartnerCode { get; set; }
    }
}
