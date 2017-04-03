using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLFrame.Entity;

namespace ZNLCRM.Entity.UserModel.CRM
{
    [Serializable]
    public  class CRM_ZoneParam:PageParam
    {
        public int? ZID { get; set; }
        public int? PZID { get; set; }
        public string ZCode { get; set; }
        public Guid? ZGuID { get; set; }
        public int ZType { get; set; }
        public string Name_CN { get; set; }
        public string Name_EN { get; set; }
    }
}
