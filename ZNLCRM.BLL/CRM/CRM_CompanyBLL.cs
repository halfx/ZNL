using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLFrame.Entity;
using ZNLCRM.Entity.UserModel.CRM;
using MySoft.Data;
using ZNLCRM.Entity.DBModel;
using ZNLCRM.BLL.Sys;
using ZNLCRM.Entity.UserModel.Common;
using ZNLCRM.Utility;
namespace ZNLCRM.BLL.CRM
{
    public  class CRM_CompanyBLL:BaseBLL
    {
        #region 获取公司信息
        /// <summary>
        /// 通过自义设置条件获取公司列表,该方法使用用在各逻辑层间方便调用
        /// </summary>
        /// <param name="lstField">字段列表</param>
        /// <param name="whereClip">传入的条件实体,方法会自动加入公司和删除标志的判断筛选</param>
        /// <returns>返加条件实体</returns>
        public List<CRM_CompanyResult> GetComapnyListByFilter(List<Field> lstField, WhereClip whereClip)
        {
            this.CheckSession();
            if (lstField == null) lstField = new List<Field>() { CRM_Company._.CompanyName };
            List<CRM_CompanyResult> ret = new List<CRM_CompanyResult>();
            WhereClip whereClipEx = CRM_Company._.GCompanyID == this.SessionInfo.CompanyID && CRM_Company._.IsDeleted == false;
            if (whereClip != null) whereClipEx = whereClipEx && whereClip;
            ret = this.SelectList<CRM_CompanyResult>(lstField, whereClipEx, CRM_Company._.CompanyName.Asc);
            return ret;
        }
         
        #endregion

        #region 客户相关方法
        public PageList<CRM_CompanyResult> GetCustPageList(CRM_CompanyParam param)
        {
            this.CheckSession();
            PageList<CRM_CompanyResult> ret = new PageList<CRM_CompanyResult>();
            try
            {
                List<Field> field = new List<Field>()
             {
                Field.All
             };
                ret = this.SelectList<CRM_CompanyResult>(param.PageIndex.GetValueOrDefault(1), param.PageSize.GetValueOrDefault(50), field, GetCustWhereClip(param), CRM_Company._.CompanyCode.Asc);
                
            }
            catch (WarnException exp)
            {
                throw exp;
            }
            catch (System.Exception exp)
            {
                LogInfoBLL.WriteLog(this.SessionInfo, exp);
                throw exp;
            }
            return ret;

        }
        
        public List<CRM_CompanyResult> GetCustList(CRM_CompanyParam param)
        {
            this.CheckSession();
            List<CRM_CompanyResult> ret = new List<CRM_CompanyResult>();
            try
            {
                WhereClip whereClip = GetCustWhereClip(param);
                ret = this.SelectList<CRM_CompanyResult>(whereClip, CRM_Company._.CompanyCode.Desc);
            }
            catch (WarnException exp)
            {
                throw exp;
            }
            catch (System.Exception exp)
            {
                LogInfoBLL.WriteLog(this.SessionInfo, exp);
                throw exp;
            }
            return ret;

        }

        WhereClip GetCustWhereClip(CRM_CompanyParam param)
        {
            this.CheckSession();
            WhereClip where = CRM_Company._.IsDeleted == 0 && CRM_Company._.CompanyType == 1;
            if (param.CompanyID > 0) where = where && CRM_Company._.CompanyID == param.CompanyID;
            if (param.CompanyGuID != null) where = where && CRM_Company._.CompanyGuID == param.CompanyGuID;
            if (!string.IsNullOrEmpty(param.CompanyName)) where = where && CRM_Company._.CompanyName.Like("%" + param.CompanyName + "%");
            if (param.CompanyContactType != null)
            {
                DateTime dt = DateTime.Now;
                //当天起始
                DateTime startTime= DateTime.Now.Date;
                //当天结束
                DateTime endTime = startTime.Add(new TimeSpan(23, 59, 59));
                //昨天起始
                DateTime yesStartTime = DateTime.Now.AddDays(-1).Date;
                //昨天结束
                DateTime yesEndTime = yesStartTime.Add(new TimeSpan(23, 59, 59));
            //ucTextBox1.Text = DateTime.Now.Date.Add(new TimeSpan(23,59,59)).ToStringHasNull();
                //本周一
                DateTime startWeek = dt.AddDays(1 - Convert.ToInt32(dt.DayOfWeek.ToString("d"))).Date;
                //本周日
                DateTime endWeek = startWeek.AddDays(6).Add(new TimeSpan(23, 59, 59)) ;
                //本月月初 
                DateTime startMonth = dt.AddDays(1 - dt.Day).Date;
                //本月月末  
                DateTime endMonth = startMonth.AddMonths(1).AddDays(-1).Add(new TimeSpan(23, 59, 59));
                
                //本季度初  
                DateTime startQuarter = dt.AddMonths(0 - (dt.Month - 1) % 3).AddDays(1 - dt.Day);
                //本季度末  
                DateTime endQuarter = startQuarter.AddMonths(3).AddDays(-1); 
                switch (param.CompanyContactType)
                { 
                    case SysEnum.CompanyContactType.Today:

                        where = where && CRM_Company._.LastBusinessDate >= startTime && CRM_Company._.LastBusinessDate <= endTime;
                        break;
                    case SysEnum.CompanyContactType.Yesterday:
                        where = where && CRM_Company._.LastBusinessDate >= yesStartTime &&  CRM_Company._.LastBusinessDate <= yesEndTime;
                        break;
                    case SysEnum.CompanyContactType.ThisWeek:
                        where = where && CRM_Company._.LastBusinessDate >= startWeek && CRM_Company._.LastBusinessDate <= endWeek;
                        break;
                    case SysEnum.CompanyContactType.ThisMonth:
                        where = where && CRM_Company._.LastBusinessDate >= startMonth && CRM_Company._.LastBusinessDate <= endMonth;
                        break;
                    case SysEnum.CompanyContactType.ThreeMonth:
                        where = where && CRM_Company._.LastBusinessDate >= startTime.AddMonths(-3) && CRM_Company._.LastBusinessDate <= startTime.Add(new TimeSpan(23, 59, 59));
                        break;
                    case SysEnum.CompanyContactType.OneMonthNonContact:
                        where = where && CRM_Company._.LastBusinessDate < startTime.AddMonths(-1) ;
                        break;
                    case SysEnum.CompanyContactType.ThreeMonthNonContact:
                        where = where && CRM_Company._.LastBusinessDate < startTime.AddMonths(-3);
                        break;
                     case SysEnum.CompanyContactType.AboveOneYear:
                        where = where && CRM_Company._.LastBusinessDate< startTime.AddYears(-1);
                         break;
                }
            }
            return where;
        }

        /// <summary>
        /// 添加和新增修改
        /// </summary>
        /// <param name="param">新增或修改的实体</param>
        /// <returns></returns>
        public WCFAddUpdateResult AddOrUpdateCust(CRM_CompanyResult param)
        {
            this.CheckSession();
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            try
            {
                int affect = 0;
                #region 判断
                
                if (string.IsNullOrEmpty(param.CompanyName.Trim())) throw new WarnException("请指定公司名称！");
                
                #endregion
                List<CRM_CompanyContactResult> contactList = param.ContactList;
                if(string.IsNullOrEmpty(param.CompanyCode))
                    param.CompanyCode = StringHandler.GetChineseSpell(param.CompanyName);
                if (string.IsNullOrEmpty(param.CompanyCode)) throw new WarnException("请指定公司编码！");
                #region 判断重复
                WhereClip whereChkName = CRM_Company._.IsDeleted == false && CRM_Company._.CompanyName == param.CompanyName;
                WhereClip whereChkCode = CRM_Company._.IsDeleted == false && CRM_Company._.CompanyCode == param.CompanyCode;
                if (param.CompanyID > 0)
                {
                    whereChkName = whereChkName && CRM_Company._.CompanyID != param.CompanyID;
                    whereChkCode = whereChkCode && CRM_Company._.CompanyID != param.CompanyID;
                }
                int chkNameNum = this.Count<CRM_CompanyResult>(whereChkName);
                int chkCodeNum=this.Count<CRM_CompanyResult>(whereChkCode);
                if (chkNameNum > 0) throw new WarnException("存在重复的公司名称！");
                if (chkCodeNum > 0) throw new WarnException("存在重复的公司编码！");
                #endregion
                #region 系统默认值
                if (param.CompanyID > 0)
                {

                    WhereClip where = CRM_Company._.CompanyID == param.CompanyID;
                    param.UpdatedEmpID = this.SessionInfo.UserID;
                    param.UpdatedEmpName = this.SessionInfo.UserName;
                    param.UpdatedTime = DateTime.Now;
                    affect = this.Update<CRM_CompanyResult>(param, where);
                }
                else
                {
                  
                    param.CompanyGuID = Guid.NewGuid();
                    param.CompanyType = 1;
                    param.GCompanyID = this.SessionInfo.CompanyID;
                    param.IsDeleted = false;
                    param.CreatedEmpID = this.SessionInfo.UserID;
                    param.CreatedEmpName = this.SessionInfo.UserName;
                    param.CreatedTime = DateTime.Now;
                    affect = this.Insert<CRM_CompanyResult>(param);
                    param = this.Select<CRM_CompanyResult>(new List<Field>() { CRM_CompanyResult._.CompanyID }, CRM_Company._.CompanyName == param.CompanyName);
                }
                foreach (CRM_CompanyContactResult rst in contactList)
                {
                    if (rst.ContactID == 0)
                    {
                        rst.IsDeleted = false;
                        rst.CompanyID = param.CompanyID;
                        rst.GCompanyID = this.SessionInfo.CompanyID;
                        rst.CreatedEmpID = this.SessionInfo.UserID;
                        rst.CreatedEmpName = this.SessionInfo.UserName;
                        rst.CreatedTime = DateTime.Now;
                    }
                    else
                    {
                        rst.UpdatedEmpID = this.SessionInfo.UserID;
                        rst.UpdatedEmpName = this.SessionInfo.UserName;
                        rst.UpdatedTime = DateTime.Now;
                    }
                }
                 
                 this.BatchInsertOrUpdate<CRM_CompanyContactResult>(contactList);
                 this.BatchExecute();
                #region 设置返回值
                ret.Key = param.CompanyID;
                #endregion
                #endregion
            }
            catch (WarnException exp)
            {
                throw exp;
            }
            catch (System.Exception exp)
            {
                LogInfoBLL.WriteLog(this.SessionInfo, exp);
                throw exp;
            }
            return ret;
        }
        /// <summary>
        /// 获取一条信息记录
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public CRM_CompanyResult GetCustInfo(CRM_CompanyParam param)
        {
            this.CheckSession();
            CRM_CompanyResult rst = new CRM_CompanyResult();
            #region 判断
            if (param.CompanyID <= 0 && param.CompanyGuID==null) throw new WarnException("请指定公司ID或者GUID！");
            #endregion
            #region 获取实体
            WhereClip whereClip = WhereClip.All;
            if (param.CompanyID>0)whereClip=whereClip && CRM_Company._.CompanyID == param.CompanyID;
            if (param.CompanyGuID != null) whereClip = whereClip && CRM_Company._.CompanyGuID == param.CompanyGuID;
            rst = this.Select<CRM_CompanyResult>(whereClip);
            if(rst!=null)
            {
               rst.ContactList= this.SelectList<CRM_CompanyContactResult>(CRM_CompanyContact._.CompanyID == rst.CompanyID);
            }
            #endregion
            return rst;
        }

        /// <summary>
        /// 删除实体
        /// </summary>
        /// <param name="param">删除条件实体</param>
        /// <returns></returns>
        public WCFAddUpdateResult DelCustInfo(CRM_CompanyParam param)
        {
            this.CheckSession();
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            int affect = 0;
            try
            {
                #region 判断
                if (param.CompanyID <= 0) throw new WarnException("请指定要删除的公司ID！");
                #endregion

                WhereClip whereClip = GetCustWhereClip(param);
                CRM_CompanyResult info = new CRM_CompanyResult();
                info.IsDeleted = true;
                affect = this.Update<CRM_CompanyResult>(info, whereClip);
                #region 设置返回值
                ret.Key = affect;
                #endregion
            }
            catch (WarnException exp)
            {
                throw exp;
            }
            catch (System.Exception exp)
            {
                LogInfoBLL.WriteLog(this.SessionInfo, exp);
                throw exp;
            }
            return ret;
        }
        #endregion

        #region  供应商相关方法
        public PageList<CRM_CompanyResult> GetSupPageList(CRM_CompanyParam param)
        {
            this.CheckSession();
            PageList<CRM_CompanyResult> ret = new PageList<CRM_CompanyResult>();
            try
            {
                List<Field> field = new List<Field>()
             {
                Field.All
             };
                ret = this.SelectList<CRM_CompanyResult>(param.PageIndex.GetValueOrDefault(1), param.PageSize.GetValueOrDefault(50), field, GetSupWhereClip(param), CRM_Company._.CompanyCode.Asc);

            }
            catch (WarnException exp)
            {
                throw exp;
            }
            catch (System.Exception exp)
            {
                LogInfoBLL.WriteLog(this.SessionInfo, exp);
                throw exp;
            }
            return ret;

        }

        public List<CRM_CompanyResult> GetSupList(CRM_CompanyParam param)
        {
            this.CheckSession();
            List<CRM_CompanyResult> ret = new List<CRM_CompanyResult>();
            try
            {
                WhereClip whereClip = GetSupWhereClip(param);
                ret = this.SelectList<CRM_CompanyResult>(whereClip, CRM_Company._.CompanyCode.Desc);
            }
            catch (WarnException exp)
            {
                throw exp;
            }
            catch (System.Exception exp)
            {
                LogInfoBLL.WriteLog(this.SessionInfo, exp);
                throw exp;
            }
            return ret;
        }

        WhereClip GetSupWhereClip(CRM_CompanyParam param)
        {
            this.CheckSession();
            WhereClip where = CRM_Company._.IsDeleted == 0 && CRM_Company._.CompanyType ==2;
            if (param.CompanyID > 0) where = where && CRM_Company._.CompanyID == param.CompanyID;
            if (param.CompanyGuID != null) where = where && CRM_Company._.CompanyGuID == param.CompanyGuID;
            if (!string.IsNullOrEmpty(param.CompanyName)) where = where && CRM_Company._.CompanyName.Like("%" + param.CompanyName + "%");
            if (param.CompanyContactType != null)
            {
                DateTime dt = DateTime.Now;
                //当天起始
                DateTime startTime = DateTime.Now.Date;
                //当天结束
                DateTime endTime = startTime.Add(new TimeSpan(23, 59, 59));
                //昨天起始
                DateTime yesStartTime = DateTime.Now.AddDays(-1).Date;
                //昨天结束
                DateTime yesEndTime = yesStartTime.Add(new TimeSpan(23, 59, 59));
                //ucTextBox1.Text = DateTime.Now.Date.Add(new TimeSpan(23,59,59)).ToStringHasNull();
                //本周一
                DateTime startWeek = dt.AddDays(1 - Convert.ToInt32(dt.DayOfWeek.ToString("d"))).Date;
                //本周日
                DateTime endWeek = startWeek.AddDays(6).Add(new TimeSpan(23, 59, 59));
                //本月月初 
                DateTime startMonth = dt.AddDays(1 - dt.Day).Date;
                //本月月末  
                DateTime endMonth = startMonth.AddMonths(1).AddDays(-1).Add(new TimeSpan(23, 59, 59));

                //本季度初  
                DateTime startQuarter = dt.AddMonths(0 - (dt.Month - 1) % 3).AddDays(1 - dt.Day);
                //本季度末  
                DateTime endQuarter = startQuarter.AddMonths(3).AddDays(-1);
                switch (param.CompanyContactType)
                {
                    case SysEnum.CompanyContactType.Today:

                        where = where && CRM_Company._.LastBusinessDate >= startTime && CRM_Company._.LastBusinessDate <= endTime;
                        break;
                    case SysEnum.CompanyContactType.Yesterday:
                        where = where && CRM_Company._.LastBusinessDate >= yesStartTime && CRM_Company._.LastBusinessDate <= yesEndTime;
                        break;
                    case SysEnum.CompanyContactType.ThisWeek:
                        where = where && CRM_Company._.LastBusinessDate >= startWeek && CRM_Company._.LastBusinessDate <= endWeek;
                        break;
                    case SysEnum.CompanyContactType.ThisMonth:
                        where = where && CRM_Company._.LastBusinessDate >= startMonth && CRM_Company._.LastBusinessDate <= endMonth;
                        break;
                    case SysEnum.CompanyContactType.ThreeMonth:
                        where = where && CRM_Company._.LastBusinessDate >= startTime.AddMonths(-3) && CRM_Company._.LastBusinessDate <= startTime.Add(new TimeSpan(23, 59, 59));
                        break;
                    case SysEnum.CompanyContactType.OneMonthNonContact:
                        where = where && CRM_Company._.LastBusinessDate < startTime.AddMonths(-1);
                        break;
                    case SysEnum.CompanyContactType.ThreeMonthNonContact:
                        where = where && CRM_Company._.LastBusinessDate < startTime.AddMonths(-3);
                        break;
                    case SysEnum.CompanyContactType.AboveOneYear:
                        where = where && CRM_Company._.LastBusinessDate < startTime.AddYears(-1);
                        break;
                }
            }
            return where;
        }

        public WCFAddUpdateResult AddOrUpdateSup(CRM_CompanyResult param)
        {
            this.CheckSession();
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            try
            {
                int affect = 0;
                #region 判断

                if (string.IsNullOrEmpty(param.CompanyName.Trim())) throw new WarnException("请指定公司名称！");

                #endregion
                List<CRM_CompanyContactResult> contactList = param.ContactList;
                if (string.IsNullOrEmpty(param.CompanyCode))
                    param.CompanyCode = StringHandler.GetChineseSpell(param.CompanyName);
                if (string.IsNullOrEmpty(param.CompanyCode)) throw new WarnException("请指定公司编码！");
                #region 判断重复
                WhereClip whereChkName = CRM_Company._.IsDeleted == false && CRM_Company._.CompanyName == param.CompanyName;
                WhereClip whereChkCode = CRM_Company._.IsDeleted == false && CRM_Company._.CompanyCode == param.CompanyCode;
                if (param.CompanyID > 0)
                {
                    whereChkName = whereChkName && CRM_Company._.CompanyID != param.CompanyID;
                    whereChkCode = whereChkCode && CRM_Company._.CompanyID != param.CompanyID;
                }
                int chkNameNum = this.Count<CRM_CompanyResult>(whereChkName);
                int chkCodeNum = this.Count<CRM_CompanyResult>(whereChkCode);
                if (chkNameNum > 0) throw new WarnException("存在重复的公司名称！");
                if (chkCodeNum > 0) throw new WarnException("存在重复的公司编码！");
                #endregion
                #region 系统默认值
                if (param.CompanyID > 0)
                {

                    WhereClip where = CRM_Company._.CompanyID == param.CompanyID;
                    param.UpdatedEmpID = this.SessionInfo.UserID;
                    param.UpdatedEmpName = this.SessionInfo.UserName;
                    param.UpdatedTime = DateTime.Now;
                    affect = this.Update<CRM_CompanyResult>(param, where);
                }
                else
                {

                    param.CompanyGuID = Guid.NewGuid();
                    param.CompanyType = 2;
                    param.GCompanyID = this.SessionInfo.CompanyID;
                    param.IsDeleted = false;
                    param.CreatedEmpID = this.SessionInfo.UserID;
                    param.CreatedEmpName = this.SessionInfo.UserName;
                    param.CreatedTime = DateTime.Now;
                    affect = this.Insert<CRM_CompanyResult>(param);
                    param = this.Select<CRM_CompanyResult>(new List<Field>() { CRM_CompanyResult._.CompanyID }, CRM_Company._.CompanyName == param.CompanyName);
                }
                foreach (CRM_CompanyContactResult rst in contactList)
                {
                    if (rst.ContactID == 0)
                    {
                        rst.IsDeleted = false;
                        rst.CompanyID = param.CompanyID;
                        rst.GCompanyID = this.SessionInfo.CompanyID;
                        rst.CreatedEmpID = this.SessionInfo.UserID;
                        rst.CreatedEmpName = this.SessionInfo.UserName;
                        rst.CreatedTime = DateTime.Now;
                    }
                    else
                    {
                        rst.UpdatedEmpID = this.SessionInfo.UserID;
                        rst.UpdatedEmpName = this.SessionInfo.UserName;
                        rst.UpdatedTime = DateTime.Now;
                    }
                }

                this.BatchInsertOrUpdate<CRM_CompanyContactResult>(contactList);
                this.BatchExecute();
                #region 设置返回值
                ret.Key = param.CompanyID;
                #endregion
                #endregion
            }
            catch (WarnException exp)
            {
                throw exp;
            }
            catch (System.Exception exp)
            {
                LogInfoBLL.WriteLog(this.SessionInfo, exp);
                throw exp;
            }
            return ret;
        }

        public CRM_CompanyResult GetSupInfo(CRM_CompanyParam param)
        {
            this.CheckSession();
            CRM_CompanyResult rst = new CRM_CompanyResult();
            #region 判断
            if (param.CompanyID <= 0 && param.CompanyGuID == null) throw new WarnException("请指定公司ID或者GUID！");
            #endregion
            #region 获取实体
            WhereClip whereClip = WhereClip.All;
            if (param.CompanyID > 0) whereClip = whereClip && CRM_Company._.CompanyID == param.CompanyID;
            if (param.CompanyGuID != null) whereClip = whereClip && CRM_Company._.CompanyGuID == param.CompanyGuID;
            rst = this.Select<CRM_CompanyResult>(whereClip);
            if (rst != null)
            {
                rst.ContactList = this.SelectList<CRM_CompanyContactResult>(CRM_CompanyContact._.CompanyID == rst.CompanyID);
            }
            #endregion
            return rst;
        }

        public WCFAddUpdateResult DelSupInfo(CRM_CompanyParam param)
        {
            this.CheckSession();
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            int affect = 0;
            try
            {
                #region 判断
                if (param.CompanyID <= 0) throw new WarnException("请指定要删除的公司ID！");
                #endregion

                WhereClip whereClip = GetSupWhereClip(param);
                CRM_CompanyResult info = new CRM_CompanyResult();
                info.IsDeleted = true;
                affect = this.Update<CRM_CompanyResult>(info, whereClip);
                #region 设置返回值
                ret.Key = affect;
                #endregion
            }
            catch (WarnException exp)
            {
                throw exp;
            }
            catch (System.Exception exp)
            {
                LogInfoBLL.WriteLog(this.SessionInfo, exp);
                throw exp;
            }
            return ret;
        }
        #endregion
    }
}
