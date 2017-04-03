using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLCRM.Entity.DBModel;
using ZNLFrame.Entity;

namespace ZNLCRM.Entity.UserModel.FIN
{
    [Serializable]
    public class FIN_SubmitExpenseParam :PageParam
    {
        public int? ExpID { get; set; }
        public Guid? ExpGuID { get; set; }
        public Guid? SourceGuid { get; set; }
        public string BillNo { get; set; }
        public string ExpName { get; set; }
    }
}
