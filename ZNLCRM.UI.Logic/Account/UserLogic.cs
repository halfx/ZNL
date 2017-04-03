using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLFrame.Entity;
using ZNLCRM.Client.Entry;
using ZNLCRM.Entity.UserModel.Account;
using ZNLCRM.Utility;

namespace ZNLCRM.UI.Logic.Account
{
    public class UserLogic:BaseLogic
    {
        /// <summary>
        /// 获得公司的购买服务的记录
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public ExeResult GetChargeRecord(SYS_CompanyInfoParam param)
        {
            return WCFBLL.Execute("ZNLCRM.BLL.Account.SYS_CompanyInfoBLL", "GetChargeRecord", param);
        }

        public ExeResult UserLogin(SYS_UserAccountParam param)
        {
            string ipAddress = EnvironmentHandler.GetNetCardIP();
            string macAddress = EnvironmentHandler.GetNetCardMAC(ipAddress);
            param.ClientIP = ipAddress;
            param.MacAddress = macAddress;
            param.HardSN = EnvironmentHandler.GetHardSN();
            param.PartnerCode = MySession.PartnerCode;
            //string usedQuoteAgent = ManagerAppConfig.GetAppConfig(Constant.EnableQuoteAgent);
            //param.IsSearchByNew = string.IsNullOrEmpty(usedQuoteAgent) || usedQuoteAgent == "1";

            MySession.ClientIP = ipAddress;
            MySession.MacAddress = macAddress;
            return WCFBLL.Execute("ZNLCRM.BLL.Account.SYS_UserAccountBLL", "UserLogin", param);
        }
        



    }
}
