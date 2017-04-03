using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLFrame.Entity;

namespace ZNLCRM.Entity.UserModel.SPM
{
    [Serializable]
    public   class ORD_SalesReturnParam:PageParam
    {
        public Guid? SRGuid { get; set; }
        public Guid?[] SRGuids { get; set; }
        public string BillNo { get; set; }
        public Guid? SOGuid { get; set; }
        public string SOBillNo { get; set; }
        public string CustomerName { get; set; }
        public string Status { get; set; }
        public string[] StatusArr { get; set; }
        /// <summary>
        /// 窗体来源stk_in
        /// </summary>
        public string FromWinType { get; set; }

    }
}
