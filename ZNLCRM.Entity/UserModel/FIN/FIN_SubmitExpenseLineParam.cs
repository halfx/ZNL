using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLFrame.Entity;

namespace ZNLCRM.Entity.UserModel.FIN
{
    [Serializable]
    public  class FIN_SubmitExpenseLineParam:PageParam
    {
        public int? ExpLineID { get; set; }
        public Guid? ExpLineGuID { get; set; }
    }
}
