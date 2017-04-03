using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLCRM.Entity.DBModel;
using ZNLFrame.Entity;

namespace ZNLCRM.Entity.UserModel.Sys
{
    [Serializable]
    public class Sys_AttachFilesParam : PageParam
    {
        public int? AttachID { get; set; }
        public Guid? AttachGuID { get; set; }
        public string AttachName { get; set; }
        public Guid? SourceGuid { get; set; } 
    }
}
