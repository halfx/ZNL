using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLCRM.Client.Entry;
using ZNLCRM.Entity.UserModel.Common;
using ZNLFrame.Entity;
using ZNLCRM.Entity.UserModel.Sys;
using ZNLCRM.Utility;

namespace ZNLCRM.UI.Logic.Sys
{
    public class Common:BaseLogic
    {
        //public static DateTime? GetServerNow()
        //{
        //    return WCFBLL.GetServerTime();
        //}

        public static string GetServerNow(bool includeTime)
        {
            DateTime? now = WCFBLL.GetServerTime().ToDateTime();
            string retDate = "";
            if (now != null)
            {
                if (includeTime) retDate = now.Value.ToString("yyyy-MM-dd hh:mm:ss");
                else retDate = now.Value.ToString("yyyy-MM-dd");
            }
            return retDate;
        }
        public static string GetServerNow()
        {
            return (GetServerNow(true));
        }

        public string GetBillNo(SYS_CredentialCodeRuleParam param)
        {
            string ret = "";
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.Sys.Sys_CodeRulerBLL", "GetBillNo", param);
            if (rst != null)
                ret = rst.Result.ToStringHasNull();
            return ret;
        }
    }
}
