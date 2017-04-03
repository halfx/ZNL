using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLFrame.Entity;

namespace ZNLCRM.Entity.UserModel.SPM
{
    [Serializable]
    public  class ORD_PurchaseNoticeParam:PageParam
    {
        public Guid? SOGuid { get; set; }
        public string SOBillNo { get; set; }
        public Guid? NoticeGuid { get; set; }
        public Guid?[] NoticeGuids { get; set; }
        public Guid?[] NoNoticeGuids { get; set; }
        public Guid? SOLineGuid { get; set; }
        public string SOLineCode { get; set; }
        public Guid?[] SOLineGuids { get; set; }
        public string Model { get; set; }
        public string SalerName { get; set; }
        public int? BuyerID { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }

        
        
    }
}
