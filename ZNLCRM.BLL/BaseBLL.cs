using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLFrame.Entity;
using ZNLFrame.DB;
using ZNLCRM.BLL.Sys;
using System.Diagnostics;


namespace ZNLCRM.BLL
{
    public class BaseBLL : BaseAcess
    {
        protected string RightTableName { get; set; }
        private SessionInfo _sessionInfo = new SessionInfo();
        public SessionInfo SessionInfo
        {
            get
            {
                return _sessionInfo;
            }
            set { _sessionInfo = value; }
        }

        public void CheckSession()
        {
            if (this.SessionInfo == null || this.SessionInfo.UserID <= 0)
                throw new WarnException("登录超时或未登录，请重新登录！");
        }
    }

    [DebuggerNonUserCode]
    public static class ThrowHelpers
    {
        public static string ThrowIfNullOfEmpty(this string value, string message)
        {
            if (string.IsNullOrEmpty(value))
                throw new WarnException(message);

            return value;
        }

        public static T ThrowIfNull<T>(this T value, string message)
            where T : class
        {
            if (value == null)
                throw new WarnException(message);

            return value;
        }

        public static Nullable<T> ThrowIfNull<T>(this Nullable<T> value, string message)
            where T : struct
        {
            if (!value.HasValue)
                throw new WarnException(message);

            return value;
        }

        public static void ThrowIfTrue(this bool predicate, string message)
        {
            if (predicate)
                throw new WarnException(message);
        }

        public static void ThrowIfFalse(this bool predicate, string message)
        {
            if (!predicate)
                throw new WarnException(message);
        }

        public static void ThrowIfEqual<T>(this T left, T right, string message)
        {
            if (left.Equals(right))
                throw new WarnException(message);
        }

        public static void ThrowIfNotEqual<T>(this T left, T right, string message)
        {
            if (!left.Equals(right))
                throw new WarnException(message);
        }
    }
}
