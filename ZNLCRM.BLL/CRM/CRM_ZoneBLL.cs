using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySoft.Data;
using ZNLCRM.Entity.UserModel.CRM;
using ZNLCRM.Entity.DBModel;
using ZNLCRM.Entity.UserModel.Common;
using ZNLFrame.Entity;
using ZNLCRM.BLL.Sys;

namespace ZNLCRM.BLL.CRM
{
    public  class CRM_ZoneBLL:BaseBLL
    {
        public CRM_ZoneBLL()
        {
            
        }
        /// <summary>
        /// 获取条件的公共方法
        /// </summary>
        /// <param name="param">条件实体</param>
        /// <returns></returns>
        WhereClip GetWhereClip(CRM_ZoneParam param)
        {
            this.CheckSession();
            WhereClip where = CRM_Zone._.IsDeleted == 0;

            if (param.ZID != null) where = where && CRM_Zone._.ZID == param.ZID;
            if (param.PZID != null) where = where && CRM_Zone._.PZID == param.PZID;
            if (param.ZGuID != null) where = where && CRM_Zone._.ZGuID == param.ZGuID;
            if (param.ZType != 0) where = where && CRM_Zone._.ZType == param.ZType;
            if (param.Name_CN != null) where = where && CRM_Zone._.Name_CN.Like("%" + param.Name_CN + "%");
            return where;
        }

        /// <summary>
        /// 批量修改和插入
        /// </summary>
        /// <param name="paramList"></param>
        /// <returns></returns>
        public WCFAddUpdateResult UpdateOrInsertList(List<CRM_ZoneResult> list)
        {
            this.CheckSession();
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            try
            {
                #region 判断
                if (list.Count <= 0) throw new WarnException("没有需要操作的对象！");
                #endregion
                int affect = 0;
                foreach (CRM_ZoneResult rst in list)
                {
                    rst.GCompanyID = this.SessionInfo.CompanyID;
                    if (rst.ZID <= 0)
                        rst.ZGuID = Guid.NewGuid();
                }
                affect += this.BatchInsertOrUpdate<CRM_ZoneResult>(list);
                this.BatchExecute();
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

        /// <summary>
        /// 添加和新增修改
        /// </summary>
        /// <param name="param">新增或修改的实体</param>
        /// <returns></returns>
        public WCFAddUpdateResult AddOrUpdate(CRM_ZoneResult param)
        {
            this.CheckSession();
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            try
            {
                int affect = 0;
                #region 判断
                if(param.ZID==0) throw new  WarnException("请输入区域ID！");
                if (param.Name_CN.Trim() == "") throw new WarnException("请输入区域名称！");
                #endregion

                #region 判断重复
                WhereClip whereChk = CRM_Zone._.Name_CN == param.Name_CN;
                if (param.ZID > 0) whereChk = whereChk && CRM_Zone._.ZID != param.ZID;
                int chkNum = this.Count<CRM_ZoneResult>(whereChk);
                if (chkNum > 0) throw new WarnException("存在重复的区域名称!");
                #endregion

                #region 系统默认值
                if (param.ZID !=0)
                {
                    WhereClip where = CRM_Zone._.ZID == param.ZID;
                    affect = this.Update<CRM_ZoneResult>(param, where);
                }
                else
                {
                    param.ZGuID = Guid.NewGuid();
                    param.GCompanyID = this.SessionInfo.CompanyID;
                    param.IsDeleted = false;
                    affect = this.Insert<CRM_ZoneResult>(param);
                    param = this.Select<CRM_ZoneResult>(new List<Field>() { CRM_Zone._.ZID }, CRM_Zone._.Name_CN == param.Name_CN);
                }
                #region 设置返回值
                ret.Key = param.ZID;
                ret.KeyGuid = param.ZGuID;
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
        public CRM_ZoneResult GetInfo(CRM_ZoneParam param)
        {
            this.CheckSession();
            CRM_ZoneResult rst = new CRM_ZoneResult();
            #region 获取实体
            rst = this.Select<CRM_ZoneResult>(GetWhereClip(param));
            #endregion
            return rst;
        }

      
        /// <summary>
        /// 获取集合
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public List<CRM_ZoneResult> GetList(CRM_ZoneParam param)
        {
            this.CheckSession();
            List<CRM_ZoneResult> ret = new List<CRM_ZoneResult>();
            try
            {
                WhereClip whereClip = GetWhereClip(param);
                ret = this.SelectList<CRM_ZoneResult>(whereClip, CRM_ZoneResult._.Name_CN.Asc);
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
        /// 删除实体
        /// </summary>
        /// <param name="param">删除条件实体</param>
        /// <returns></returns>
        public WCFAddUpdateResult DelInfo(CRM_ZoneParam param)
        {
            this.CheckSession();
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            int affect = 0;
            try
            {
                #region 判断
                if (param.ZID == null) throw new WarnException("请指定要删除的记录！");
                #endregion
                WhereClip where = GetWhereClip(param);
                CRM_ZoneResult info = new CRM_ZoneResult();
                info.IsDeleted = true;
                affect = this.Update<CRM_ZoneResult>(info, where);
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
