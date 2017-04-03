using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using ZNLCRM.Server.IService;
using System.Reflection;
using System.ServiceModel.Channels;
using ZNLFrame.Entity;
using ZNLCRM.Utility;

namespace ZNLCRM.Server
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码、svc 和配置文件中的类名“Service1”。
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class Adapter : IAdapter
    {
        /// <summary>
        /// 执行WCF入口方法调用
        /// </summary>
        public byte[] Execute(byte[] param)
        {
            ZNLFrame.Entry.Adapter adapter = new ZNLFrame.Entry.Adapter();
            return adapter.Execute(param);
        }
    }
}
