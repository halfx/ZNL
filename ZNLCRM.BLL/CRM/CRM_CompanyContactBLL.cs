using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLCRM.Entity.UserModel.CRM;
using ZNLFrame.Entity;
using MySoft.Data;
using ZNLCRM.Entity.DBModel;
using ZNLCRM.BLL.Sys;
using ZNLCRM.Entity.UserModel.Common;

namespace ZNLCRM.BLL.CRM
{
    public class CRM_CompanyContactBLL:BaseBLL
    {
       
        /// <summary>
        /// 获取集合
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public List<CRM_CompanyContactResult> GetList(CRM_CompanyContactParam param)
        {
            this.CheckSession();
            List<CRM_CompanyContactResult> ret = new List<CRM_CompanyContactResult>();
            try
            {
                WhereClip whereClip = GetWhereClip(param);
                ret = this.SelectList<CRM_CompanyContactResult>(whereClip, CRM_CompanyContact._.ContactName.Desc);
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

        WhereClip GetWhereClip(CRM_CompanyContactParam param)
        {
            this.CheckSession();
            WhereClip where = CRM_CompanyContact._.IsDeleted == 0;
            if (param.ContactID > 0) where = where && CRM_CompanyContact._.ContactID == param.ContactID;
            if (param.CompanyID > 0) where = where && CRM_CompanyContact._.CompanyID == param.CompanyID;
            if (!string.IsNullOrEmpty(param.Telephone)) where = where && CRM_CompanyContact._.Telephone.Like("%" + param.Telephone + "%");
            if (!string.IsNullOrEmpty(param.ContactName)) where = where && CRM_CompanyContact._.ContactName.Like("%" + param.ContactName + "%");
            return where;
        }

        /// <summary>
        /// 添加和新增修改
        /// </summary>
        /// <param name="param">新增或修改的实体</param>
        /// <returns></returns>
        public WCFAddUpdateResult AddOrUpdate(CRM_CompanyContactResult param)
        {
            this.CheckSession();
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            try
            {
                int affect = 0;
                #region 判断
                if (!string.IsNullOrEmpty(param.ContactName.Trim())) throw new WarnException("请指定联系人！");
                #endregion

                #region 判断重复
                WhereClip whereChk = CRM_CompanyContact._.IsDeleted == false && CRM_CompanyContact._.ContactName == param.ContactName;
                if (param.ContactID > 0) whereChk = whereChk & CRM_CompanyContact._.CompanyID != param.CompanyID;
                int chkNum = this.Count<CRM_CompanyContactResult>(whereChk);
                if (chkNum > 0) throw new WarnException("存在重复的联系人!");
                #endregion
                #region 系统默认值
                if (param.CompanyID > 0)
                {

                    WhereClip where = CRM_CompanyContact._.CompanyID == param.CompanyID;
                    affect = this.Update<CRM_CompanyContactResult>(param, where);
                }
                else
                {

                    param.GCompanyID = this.SessionInfo.CompanyID;
                    param.IsDeleted = false;
                    affect = this.Insert<CRM_CompanyContactResult>(param);
                    param = this.Select<CRM_CompanyContactResult>(new List<Field>() { CRM_CompanyContactResult._.ContactID }, CRM_CompanyContact._.ContactName == param.ContactName);
                }
                #region 设置返回值
                ret.Key = param.ContactID;
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
        public CRM_CompanyContactResult GetInfo(CRM_CompanyContactParam param)
        {
            this.CheckSession();
            CRM_CompanyContactResult rst = new CRM_CompanyContactResult();
            #region 判断
            if (param.ContactID <= 0) throw new WarnException("请指定联系人ID！");
            #endregion
            #region 获取实体
            
            rst = this.Select<CRM_CompanyContactResult>(GetWhereClip(param));

            #endregion
            return rst;
        }

        /// <summary>
        /// 删除实体
        /// </summary>
        /// <param name="param">删除条件实体</param>
        /// <returns></returns>
        public WCFAddUpdateResult DelInfo(CRM_CompanyContactParam param)
        {
            this.CheckSession();
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            int affect = 0;
            try
            {
                #region 判断
                if (param.ContactID <= 0) throw new WarnException("请指定联系人ID！");
                #endregion

                WhereClip whereClip = GetWhereClip(param);
                CRM_CompanyContactResult info = new CRM_CompanyContactResult();
                info.IsDeleted = true;
                affect = this.Update<CRM_CompanyContactResult>(info, whereClip);
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
    }
}
