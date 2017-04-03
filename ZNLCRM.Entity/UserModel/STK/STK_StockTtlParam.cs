﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLFrame.Entity;

namespace ZNLCRM.Entity.UserModel.STK
{
    [Serializable]
    public  class STK_StockTtlParam:PageParam
    {
        public Guid? TItemCode { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }
        public string Batch { get; set; }
        public string Package { get; set; }
    }
}
