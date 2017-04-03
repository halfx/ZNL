using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLFrame.Entity;

namespace ZNLCRM.BLL.Sys
{
    public class LogInfoBLL : BaseBLL
    {
        public int UserIsOnline(Guid? companyID, int? userID, Guid? userGuid, string userName, string userIP, string adpater)
        {
            return 1;
        }

        public static void WriteLog(SessionInfo session, Exception ex)
        {
            if ((ex.InnerException != null) && ((ex.InnerException.GetType() == typeof(ErrorException)) || (ex.GetType() == typeof(ErrorException))))
            {
                throw ex.InnerException;
            }
            if (((ex.InnerException == null) || (ex.InnerException.GetType() != typeof(WarnException))) && (ex.GetType() != typeof(WarnException)))
            {
                throw new ErrorException(ex.ToString());
            }
            throw ex;
        }

        public string GetRightEmpID()
        {
            string ret = "";
            ret += this.SessionInfo.UserID;
            return ret;
        }

    }
}
