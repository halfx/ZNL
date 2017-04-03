using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySoft.Data;
using ZNLCRM.Entity.DBModel;
using ZNLCRM.Entity.UserModel.Account;
using ZNLCRM.Utility;
using ZNLFrame.Entity;
using ZNLCRM.BLL.HR;
namespace ZNLCRM.BLL.Account
{
    public class SYS_UserAccountBLL : BaseBLL
    {
        public SYS_UserAccountResult UserLogin(SYS_UserAccountParam param)
        {
            var result = new SYS_UserAccountResult();
            try
            {
                #region 用户帐号判定

                param.Account.ThrowIfNullOfEmpty("请指定用户名！");
                param.CompanyName.ThrowIfNullOfEmpty("请指定公司名称！");
                param.PWD.ThrowIfNullOfEmpty("请指定登录密码！");
                #endregion
                #region 验证公司
                //正式版验证时需要排除平台用户相关的公司
                WhereClip coInfoWhereClip =
                    SYS_CompanyInfo._.CompanyName == param.CompanyName &&
                    SYS_CompanyInfo._.IsActive != (int)ZNLCRM.Utility.CommonEnum.IsActive.Deleted;

                if (!string.IsNullOrEmpty(param.PartnerCode))
                {
                    coInfoWhereClip = coInfoWhereClip && SYS_CompanyInfo._.PartnerCode == param.PartnerCode;
                }
                else
                {
                    coInfoWhereClip = coInfoWhereClip && SYS_CompanyInfo._.PartnerCode.IsNull();
                }
                SYS_CompanyInfo coInfo = Select<SYS_CompanyInfo>(coInfoWhereClip);
                coInfo.ThrowIfNull("未找到公司帐户信息！");
                SYS_UserAccount userAccount = Select<SYS_UserAccount>(
                        SYS_UserAccount._.GCompanyID == coInfo.CompanyID &&
                        SYS_UserAccount._.Account == param.Account &&
                        SYS_UserAccount._.IsActive != (int)ZNLCRM.Utility.CommonEnum.IsActive.Deleted &&
                        SYS_UserAccount._.IsDeleted == false
                    );
                userAccount.ThrowIfNull("未找到公司用户信息！");
                userAccount.IsActive.ThrowIfEqual(
                        (int?)ZNLCRM.Utility.CommonEnum.IsActive.Disabled,
                        "当前用户已被禁用！"
                    );

                HR_Employee userEmpInfo = Select<HR_Employee>(
                        HR_Employee._.GCompanyID == coInfo.CompanyID &&
                        HR_Employee._.EmpCode == param.Account &&
                        HR_Employee._.IsActive != (int)ZNLCRM.Utility.CommonEnum.IsActive.Deleted &&
                        HR_Employee._.IsDeleted==false
                    );
                userEmpInfo.ThrowIfNull("未找到公司用户信息！");
                userEmpInfo.IsActive.ThrowIfEqual(
                        (int?)ZNLCRM.Utility.CommonEnum.IsActive.Disabled,
                        "当前用户已被禁用！"
                    );

                bool isMater = false;
                userEmpInfo.EmpStatus.ThrowIfEqual(3, "当前用户状态已离职！");

                //子帐号需要做验证逻辑判断
                if (!isMater)
                {
                    if (userAccount.NeedValidate.ToBooleanHasNull() &&
                        !string.IsNullOrEmpty(userAccount.MacAddress.ToStringHasNull()) &&
                        !string.IsNullOrEmpty(userAccount.HardDiskSN.ToStringHasNull()))
                    {
                        if (userAccount.MacAddress.ToStringHasNull().Trim().ToLower() != param.MacAddress.ToStringHasNull().Trim().ToLower() ||
                            userAccount.HardDiskSN.ToStringHasNull().Trim().ToLower() != param.HardSN.ToStringHasNull().Trim().ToLower())
                        {
                            throw new WarnException("您不能在本机登录！");
                        }
                    }
                    if (!string.IsNullOrEmpty(userAccount.UseTimeBegin.ToStringHasNull()) &&
                        !string.IsNullOrEmpty(userAccount.UseTimeOver.ToStringHasNull()))
                    {
                        DateTime start = (DateTime.Now.ToString("yyyy-MM-dd") + " " + userAccount.UseTimeBegin).ToDateTime();
                        DateTime end = (DateTime.Now.ToString("yyyy-MM-dd") + " " + userAccount.UseTimeOver).ToDateTime();
                        if (!(DateTime.Now >= start && DateTime.Now <= end))
                        {
                            throw new WarnException("您不能在非工作时间(" + userAccount.UseTimeBegin + " - " + userAccount.UseTimeOver + ")登录！");
                        }
                    }
                }
                #endregion

                #region 判断登录用户数

                SYS_SignLogInfoBLL signBll = new SYS_SignLogInfoBLL();
                signBll.SessionInfo = this.SessionInfo;
                signBll.CheckLogUserRuler(
                    userAccount.GCompanyID,
                    userEmpInfo.EmpID,
                    userEmpInfo.EmpGuid,
                    userEmpInfo.EmpName,
                    SessionInfo.ClientIP,
                    SessionInfo.AdapterAddress);

                #endregion

                #region 修改登录统计信息

                this.Update<SYS_UserAccount>(new Field[]{
                                        SYS_UserAccount._.SignInTimes,
                                        SYS_UserAccount._.LastSignIP,
                                        SYS_UserAccount._.LastSignTime,
                                        SYS_UserAccount._.MacAddress,
                                        SYS_UserAccount._.HardDiskSN
                                        }, new object[]{
                                            userAccount.SignInTimes.GetValueOrDefault(0) + 1,
                                            param.ClientIP,
                                            DateTime.Now,
                                            param.MacAddress,
                                            param.HardSN
                                        }, SYS_UserAccount._.UserID == userAccount.UserID);
                #endregion

                #region 修改登录session
                SYS_SignLogInfoResult signParam = new SYS_SignLogInfoResult();
                signBll.SessionInfo = this.SessionInfo;
                signParam.GCompanyID = userAccount.GCompanyID;
                signParam.UserID = userAccount.UserID;
                signParam.UserName = userEmpInfo.EmpName;
                signParam.UserAdapter = this.SessionInfo.AdapterAddress;
                signParam.UserIP = this.SessionInfo.ClientIP;
                signBll.UpdateUserOnline(signParam);
                #endregion
                #region 返回值
                result.GCompanyID = userAccount.GCompanyID;
                result.UserID = userAccount.UserID;
                result.EmpName = userEmpInfo.EmpName;
                result.UserGUID = userAccount.UserGUID;
                result.Account = userAccount.Account;
                result.SaleCurrency = userEmpInfo.DefaultSaleCurreny;
                result.BuyCurrency = userEmpInfo.DefaultBuyCurreny;
                result.OrgID = userEmpInfo.OrgID;
                result.DeptID = userEmpInfo.DeptID;
                result.LoginSucceed = 1;
                #endregion
                #region 获取部门名称和机构名称
                HR_OrgBLL orgBll=new HR_OrgBLL();
                HR_DepartmentBLL deptBll = new HR_DepartmentBLL();
                orgBll.SessionInfo = this.SessionInfo;
                deptBll.SessionInfo = this.SessionInfo;
                result.OrgName = orgBll.GetOrgName(result.OrgID.ToInt32());
                result.DeptName = deptBll.GetDeptName(result.DeptID.ToInt32());
                #endregion
            }
            catch (Exception ex)
            {
                throw ex;
            }

            

            return result;
        }

        
    }
}
