using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLCRM.Entity.DBModel;
using ZNLCRM.Utility.CommonEnum;

namespace ZNLCRM.Entity.UserModel.Sys
{
    [Serializable]
    public class Sys_AttachFilesResult : Sys_AttachFiles
    {
        public byte[] File { get; set; }
        public byte[] TBNFile { get; set; }
        public string TBNFileName { get; set; }
        public string TBNFilePath { get; set; }
        public AttachType AttachType { get; set; }
    }
}
