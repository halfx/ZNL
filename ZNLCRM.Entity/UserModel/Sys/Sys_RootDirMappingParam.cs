using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLFrame.Entity;

namespace ZNLCRM.Entity.UserModel.Sys
{
    [Serializable]
    public class Sys_RootDirMappingParam:PageParam
    {
        public int? MID { get; set; }
        public Guid? MGuid{get;set;}
        public string AttachType { get; set; }
        public string MappingIdentifier { get; set; }
        public bool? IsEffect { get; set; }
    }
}
