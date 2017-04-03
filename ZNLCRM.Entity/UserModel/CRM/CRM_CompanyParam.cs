using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLFrame.Entity;
using ZNLCRM.Entity.UserModel.Common;
namespace ZNLCRM.Entity.UserModel.CRM
{
    [Serializable]
    public class CRM_CompanyParam : PageParam
    {
        public int? DGID { get; set; }
        public string[] GridNames { get; set; }
        public string[] FormNames { get; set; }
        public string[] ParentNames { get; set; }
        public int CompanyID { get; set; }
        public Guid? CompanyGuID { get; set; }
        public string CompanyCode { get; set; }
        public string CompanyName { get; set; }
        public SysEnum.CompanySearchType? CompanySearchType { get; set; }
        public SysEnum.CompanyContactType? CompanyContactType { get; set; }
    }
}
