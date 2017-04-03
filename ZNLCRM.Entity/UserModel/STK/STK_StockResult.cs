using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLCRM.Entity.DBModel;

namespace ZNLCRM.Entity.UserModel.STK
{
    [Serializable]
    public  class STK_StockResult:STK_Stock
    {
        public Guid? StkInLineGuid { get; set; }
    }
}
