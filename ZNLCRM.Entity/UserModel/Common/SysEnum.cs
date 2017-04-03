using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZNLCRM.Entity.UserModel.Common
{
    public  class SysEnum
    {
        public enum CompanySearchType
        { 
            Me,//自己的
            All//所有的
        }
        public enum CompanyContactType
        { 
            Today,//今天联系过过的客户
            Yesterday,//昨天联系过的客户
            ThisWeek,//本周联系过的客户
            ThisMonth,//本月联系过的客户
            ThreeMonth,//近三个月联系过的客户
            OneMonthNonContact,//近一月未联系客户
            ThreeMonthNonContact,//近三月未联系客户
            AboveThreeMonth,//三月以上未联系客户
            AboveOneYear,//一年以上未联系过的客户
            SpecialAttention,//特别关注客户
            Focus,//重点关注客户
            ColdTreament,//冷处理客户
            AreTracking,//正在跟踪的客户
            IsTrackOver,//已跟踪完成的客户
            NoTrack//未跟踪未成交的客户
          
        }
    }
}
