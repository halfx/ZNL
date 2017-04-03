using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLFrame.Entity;

namespace ZNLCRM.Entity.UserModel.STK
{
    public  class STK_StockPriceRangeParam:PageParam
    {
        public string SPRID { get; set; }
        public string TItemCode { get; set; }
       
    }
}
