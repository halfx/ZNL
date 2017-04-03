using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLFrame.Entity;

namespace ZNLCRM.Entity.UserModel.Sys
{
    [Serializable]
    public   class SYS_CurrencyParam:PageParam
    {
        public int? RateTaxID { get; set; }
        public string CurrencyCode { get; set; }
        public string[] CurrencyCodes { get; set; }
        public DateTime? RateDate { get; set; }
        /// <summary>
        /// 获取最近的汇率(比如按时间找汇率,没找到,则最近一条记录)
        /// </summary>
        public bool? GetLastRate { get; set; }
    }
}
