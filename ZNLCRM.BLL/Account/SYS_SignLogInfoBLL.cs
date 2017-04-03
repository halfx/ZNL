using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLFrame.Entity;
using ZNLCRM.Entity.UserModel.Account;
using ZNLCRM.Entity.DBModel;

namespace ZNLCRM.BLL.Account
{
    public class SYS_SignLogInfoBLL:BaseBLL
    {
        /// <summary>
        /// 检测公司帐户是否合法
        /// </summary>
        /// <param name="companyID"></param>
        /// <param name="userID"></param>
        /// <param name="userGuid"></param>
        /// <param name="userName"></param>
        /// <param name="userIP"></param>
        /// <param name="adapter"></param>
        public void CheckLogUserRuler(Guid? companyID, int? empID, Guid? empGuid, string userName, string userIP, string adapter)
        {
            if (companyID == null) throw new WarnException("请传公司ID！");
            if (empID.GetValueOrDefault(0) <= 0) throw new WarnException("请指定登录用户ID！");
            #region 公司帐户信息是否合法
            SYS_CompanyInfoResult rst = new SYS_CompanyInfoResult();
            SYS_CompanyInfoBLL companyBll = new SYS_CompanyInfoBLL();
            this.SessionInfo.UserID = empID;
            this.SessionInfo.CompanyID = companyID;
            this.SessionInfo.UserGuid = empGuid;
            this.SessionInfo.UserName = userName;
            this.SessionInfo.ClientIP = userIP;
            this.SessionInfo.AdapterAddress = adapter;
            companyBll.SessionInfo = this.SessionInfo;
            rst = companyBll.GetCompanyInfo(new SYS_CompanyInfoParam()
            {
                CompanyID = companyID
            });
            if (rst == null) throw new WarnException("未找到用户对应的公司信息！");
            if (rst.IsActive == 1) throw new WarnException("您公司的帐户信息状态已被禁用，如果要激活，请联系相软件供应商！");
            #endregion
        }

        /// <summary>
        /// 更新登录状态
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public SYS_SignLogInfoResult UpdateUserOnline(SYS_SignLogInfoResult param)
        {
            SYS_SignLogInfoResult rst = new SYS_SignLogInfoResult();
            int ret = 0;
            if (param.GCompanyID == null) throw new WarnException("请指定公司ID！");
            if (param.UserID.GetValueOrDefault(0) <= 0) throw new WarnException("请指定登录ID！");
            if (string.IsNullOrEmpty(param.UserName)) throw new WarnException("请指定登录用户姓名！");
            param.UserIP = this.SessionInfo.ClientIP;
            param.UserAdapter = this.SessionInfo.AdapterAddress;
            DateTime now = DateTime.Now;
            DateTime timeOut = DateTime.Now.AddMinutes(-600);

            SYS_SignLogInfo signLogInfo = this.Select<SYS_SignLogInfo>(SYS_SignLogInfo._.GCompanyID == param.GCompanyID
                                                                    && SYS_SignLogInfo._.UserID == param.UserID
                                                                    && SYS_SignLogInfo._.Online == 1);
            if (signLogInfo == null || signLogInfo.LogID <= 0)
            {
                ret = this.Insert<SYS_SignLogInfo>(new SYS_SignLogInfo()
                {
                    GCompanyID = param.GCompanyID,
                    UserID = param.UserID,
                    UserIP = param.UserIP,
                    UserAdapter = param.UserAdapter,
                    UserName = param.UserName,
                    Online = 1,
                    LogTime = now
                });
            }
            else
            {
                ret = this.Update<SYS_SignLogInfo>(new SYS_SignLogInfo()
                {
                    LogTime = now,
                    UserIP = this.SessionInfo.ClientIP,
                    UserAdapter = this.SessionInfo.AdapterAddress
                }, SYS_SignLogInfo._.LogID == signLogInfo.LogID);
            }
            rst.LogID = 1;
            return rst;
        }
    }
}
