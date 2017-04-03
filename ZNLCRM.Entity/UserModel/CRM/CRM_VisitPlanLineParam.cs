using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLCRM.Entity.DBModel;
using ZNLFrame.Entity;

namespace ZNLCRM.Entity.UserModel.CRM
{
    [Serializable]
    public class CRM_VisitPlanLineParam :PageParam
    {
        public int? CustVstPlnLineID { get; set; }
        public Guid? CustVstPlnLineGuID { get; set; }
        public Guid? CustVstPlnGuID { get; set; }
        public string VstName { get; set; }
    }
}
