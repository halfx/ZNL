using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySoft.Data;
using ZNLCRM.Entity.UserModel.HR;
using ZNLCRM.Entity.UserModel.Common;
using ZNLFrame.Entity;
using ZNLCRM.BLL.Sys;
using ZNLCRM.Entity.DBModel;
using ZNLCRM.Utility;

namespace ZNLCRM.BLL.HR
{
    public  class HR_OrgBLL : BaseBLL
    {
        public HR_OrgBLL()
        {
            
        }
        /// <summary>
        /// 获取条件的公共方法
        /// </summary>
        /// <param name="param">条件实体</param>
        /// <returns></returns>
        WhereClip GetWhereClip(HR_OrgParam param)
        {
            this.CheckSession();
            WhereClip where = HR_Org._.IsDeleted == 0;
            if( param.OrgID!=null ) where =where  &&  HR_Org._.OrgID==param.OrgID;
            if (param.OrgGuID != null) where = where && HR_Org._.OrgGuID == param.OrgGuID;
            if (param.OrgIDs != null) where = where && HR_Org._.OrgID.In(param.OrgIDs);
            return where;
        }
        /// <summary>
        /// 添加和新增修改
        /// </summary>
        /// <param name="param">新增或修改的实体</param>
        /// <returns></returns>
        public WCFAddUpdateResult AddOrUpdate(HR_OrgResult param)
        {
            this.CheckSession();
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            try
            {
                int affect = 0;
                #region 判断
                if (param.OrgName.Trim() == "") throw new WarnException("请输入机构名称！");
                if (param.OrgNo.Trim() == "") throw new WarnException("请输入机构编号！");
                #endregion
                #region 系统默认值

                if (param.OrgGuID != Guid.Empty)
                {
                    WhereClip where = HR_Org._.OrgGuID == param.OrgGuID;
                    affect = this.Update<HR_OrgResult>(param, where);
                }
                else
                {
                   
                    param.OrgGuID = Guid.NewGuid();
                    param.GCompanyID = this.SessionInfo.CompanyID;
                    param.IsDeleted = false;
                    affect = this.Insert<HR_OrgResult>(param);
                    param = this.Select<HR_OrgResult>(new List<Field>() { HR_Org._.OrgID }, HR_Org._.OrgGuID == param.OrgGuID);
                }
                #region 设置返回值
                ret.Key = param.OrgID;
                ret.KeyGuid = param.OrgGuID;
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
        public HR_OrgResult GetInfo(HR_OrgParam param)
        {
            this.CheckSession();
            HR_OrgResult rst = new HR_OrgResult();
            #region 判断
            if (param.OrgGuID == null) throw new WarnException("请指定关键字GUID！");
            #endregion
            #region 获取实体
            rst = this.Select<HR_OrgResult>(GetWhereClip(param));
            #endregion
            return rst;
        }

       
        /// <summary>
        /// 获取集合
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public List<HR_OrgResult> GetOrgTree(HR_OrgParam param)
        {
            this.CheckSession();
            List<HR_OrgResult> ret = new List<HR_OrgResult>();
            try
            {
                WhereClip whereClip = GetWhereClip(param);
                ret = this.SelectList<HR_OrgResult>(whereClip, HR_OrgResult._.OrgNo.Asc);
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
        public WCFAddUpdateResult DelInfo(HR_OrgParam param)
        {
            this.CheckSession();
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            int affect = 0;
            try
            {
                #region 判断
                if (param.OrgGuID == null) throw new WarnException("请指定要删除的记录！");
                #endregion
                WhereClip where = GetWhereClip(param);
                HR_OrgResult info = new HR_OrgResult();
                info.IsDeleted = true;
                affect = this.Update<HR_OrgResult>(info, where);
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
        /// 获取机构名称
        /// </summary>
        /// <param name="orgID">机构ID</param>
        /// <returns></returns>
        public string GetOrgName(int orgID)
        {
            this.CheckSession();
            string ret = "";
            HR_OrgResult orgRst = new HR_OrgResult();
            orgRst = this.Select<HR_OrgResult>(HR_Org._.OrgID == orgID && HR_Org._.IsDeleted == false);
            if (orgRst != null) ret = orgRst.OrgName.ToStringHasNull();
            return ret;
        }
    }
}
