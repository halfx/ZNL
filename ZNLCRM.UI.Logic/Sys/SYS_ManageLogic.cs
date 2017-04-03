using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLCRM.Client.Entry;
using ZNLCRM.Utility;

namespace ZNLCRM.UI.Logic.Sys
{
    public class SYS_ManageLogic
    {
        /// <summary>
        /// 初始化全局的参数
        /// </summary>
        public void InitGlobalVars()
        {
            //获取服务器时间，并设置本机时间
            DateTime? sDateTime = WCFBLL.GetServerTime();
            if (sDateTime != null)
            {
                WinApi.SetLocalTime((DateTime)sDateTime);
            }
            
            #region 设置最大接收数
            ManagerAppConfig.SetAppConfigKeyValue("configuration/system.serviceModel/bindings/basicHttpBinding/binding[@name='ZNLERP.Mini.Server.Adapter']", "maxBufferSize", "45536000");
            ManagerAppConfig.SetAppConfigKeyValue("configuration/system.serviceModel/bindings/basicHttpBinding/binding[@name='ZNLERP.Mini.Server.Adapter']", "maxReceivedMessageSize", "45536000");
            ManagerAppConfig.SetAppConfigKeyValue("configuration/system.serviceModel/bindings/basicHttpBinding/binding[@name='ZNLERP.Mini.Server.Adapter']", "maxBufferPoolSize", "52428800");
            ManagerAppConfig.SetAppConfigKeyValue("configuration/system.serviceModel/bindings/basicHttpBinding/binding[@name='ZNLERP.Mini.Server.Adapter']", "closeTimeout", "00:05:00");
            ManagerAppConfig.SetAppConfigKeyValue("configuration/system.serviceModel/bindings/basicHttpBinding/binding[@name='ZNLERP.Mini.Server.Adapter']", "openTimeout", "00:05:00");
            ManagerAppConfig.SetAppConfigKeyValue("configuration/system.serviceModel/bindings/basicHttpBinding/binding/readerQuotas", "maxArrayLength", "16384000");
            #endregion
        }
    }
}
