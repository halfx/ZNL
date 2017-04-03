using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLCRM.Entity.DBModel;

namespace ZNLCRM.Entity.UserModel.STK
{
    [Serializable]
    public class STK_StockTtlResult : STK_StockTtl
    {
        public List<STK_StockResult> StockList { get; set; }
    }
}
