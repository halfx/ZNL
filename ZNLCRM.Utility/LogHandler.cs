using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZNLCRM.Utility
{
    public class LogHandler
    {
        public static void WriteError(Type type, string msg,Exception exp)
        {
            log4net.ILog log = log4net.LogManager.GetLogger(type);
            log.Error(msg, exp);
        }
        public static void WriteDebug(Type type, string msg, Exception exp)
        {
            log4net.ILog log = log4net.LogManager.GetLogger(type);
            log.Debug(msg, exp);
        }
        public static void WriteWarn(Type type, string msg, Exception exp)
        {
            log4net.ILog log = log4net.LogManager.GetLogger(type);
            log.Warn(msg, exp);
        }

    }
}
