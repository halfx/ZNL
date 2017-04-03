using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLCRM.Entity.UserModel.SPM;
using MySoft.Data;
using ZNLCRM.Entity.DBModel;
using ZNLFrame.Entity;
using ZNLCRM.BLL.Sys;
using ZNLCRM.Entity.UserModel.Common;
using ZNLCRM.Utility;

namespace ZNLCRM.BLL.SPM
{
    public  class ORD_SalesOrderLineBLL:BaseBLL
    {
        /// <summary>
        /// 获取销售明细的分页信息
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public PageList<ORD_SalesOrderLineResult> GetPageList(ORD_SalesOrderLineParam param)
        {

            PageList<ORD_SalesOrderLineResult> ret = new PageList<ORD_SalesOrderLineResult>();
            try
            {
                ret = this.SelectList<ORD_SalesOrderLineResult>(param.PageIndex.GetValueOrDefault(1), param.PageSize.GetValueOrDefault(50), new List<Field> { Field.All }, GetWhereClip(param), ORD_SalesOrderLine._.CreatedTime.Desc);
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
        /// 获取集合
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public List<ORD_SalesOrderLineResult> GetList(ORD_SalesOrderLineParam param)
        {
            this.CheckSession();
            List<ORD_SalesOrderLineResult> ret = new List<ORD_SalesOrderLineResult>();
            try
            {
                WhereClip whereClip = GetWhereClip(param);
                ret = this.SelectList<ORD_SalesOrderLineResult>(whereClip, ORD_SalesOrderLine._.CreatedTime.Asc);
                
                
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

        WhereClip GetWhereClip(ORD_SalesOrderLineParam param)
        {
            this.CheckSession();
            WhereClip where = ORD_SalesOrderLine._.IsDeleted == 0;
            if (param.IsCancel != null) where = where && ORD_SalesOrderLine._.IsCancel == param.IsCancel;
            if (param.SOLineID > 0) where = where && ORD_SalesOrderLine._.SOLineID == param.SOLineID;
            if (param.SOLineGuid != null) where = where && ORD_SalesOrderLine._.SOLineGuid == param.SOLineGuid;
            if (param.SOGuid != null) where = where && ORD_SalesOrderLine._.SOGuid == param.SOGuid;
            if (param.SOGuids != null && param.SOGuids.Length > 0) where = where && ORD_SalesOrderLine._.SOGuid.In(param.SOGuids);
            if (param.SOLineGuids != null &&param.SOLineGuids.Length>0) where = where && ORD_SalesOrderLine._.SOLineGuid.In(param.SOLineGuids);
            if (!string.IsNullOrEmpty(param.Model)) where = where && ORD_SalesOrderLine._.Model.Like("%" + param.Model + "%");
            return where;
        }

      
        /// <summary>
        /// 获取一条信息记录
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public ORD_SalesOrderLineResult GetInfo(ORD_SalesOrderLineParam param)
        {
            this.CheckSession();
            ORD_SalesOrderLineResult rst = new ORD_SalesOrderLineResult();
            #region 判断
            if (param.SOLineGuid ==null) throw new WarnException("请指定明细GUID！");
            #endregion
            #region 获取实体
            
            rst = this.Select<ORD_SalesOrderLineResult>(GetWhereClip(param));

            #endregion
            return rst;
        }

        /// <summary>
        /// 删除实体
        /// </summary>
        /// <param name="param">删除条件实体</param>
        /// <returns></returns>
        public WCFAddUpdateResult DelInfo(ORD_SalesOrderLineParam param)
        {
            this.CheckSession();
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            int affect = 0;
            try
            {
                #region 判断
                if (param.SOLineGuid == null) throw new WarnException("请指定明细GUID！");
                #endregion
                WhereClip whereClip = GetWhereClip(param);
                ORD_SalesOrderLineResult info = new ORD_SalesOrderLineResult();
                info.IsDeleted = true;
                affect = this.Update<ORD_SalesOrderLineResult>(info, whereClip);
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
        public WCFAddUpdateResult AddOrUpdate(ORD_SalesOrderLineResult param)
        {
            this.CheckSession();
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            try
            {
                int affect = 0;
                #region 判断
                #endregion


                #region 系统默认值
                if (param.SOLineGuid != null)
                {
                    WhereClip where = ORD_SalesOrderLine._.SOLineGuid == param.SOLineGuid;
                    param.UpdatedEmpID = this.SessionInfo.UserID;
                    param.UpdatedEmpName = this.SessionInfo.UserName;
                    param.UpdatedTime = DateTime.Now;
                    affect = this.Update<ORD_SalesOrderLineResult>(param, where);
                }
                else
                {
                    param.SOLineGuid = Guid.NewGuid();

                    param.GCompanyID = this.SessionInfo.CompanyID;

                    param.IsDeleted = false;
                    param.CreatedEmpID = this.SessionInfo.UserID;
                    param.CreatedEmpName = this.SessionInfo.UserName;
                    param.CreatedTime = DateTime.Now;
                    affect = this.Insert<ORD_SalesOrderLineResult>(param);
                    param = this.Select<ORD_SalesOrderLineResult>(new List<Field>() { ORD_SalesOrderLine._.All }, ORD_SalesOrderLine._.SOLineGuid == param.SOLineGuid);
                }
                #region 设置返回值
                ret.KeyGuid = param.SOLineGuid;
                ret.CreatedTime = param.CreatedTime;
                ret.CreatedEmpID = param.CreatedEmpID;
                ret.CreatedEmpName = param.CreatedEmpName;
                ret.UpdatedEmpID = param.UpdatedEmpID;
                ret.UpdatedEmpName = param.UpdatedEmpName;
                ret.UpdatedTime = param.UpdatedTime;
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

        public WCFAddUpdateResult UpdateOrInsertList(List<ORD_SalesOrderLineResult> list)
        {
            this.CheckSession();
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            try
            {
                #region 判断
                if (list.Count <= 0) throw new WarnException("没有需要操作的对象！");
                #endregion
                foreach (ORD_SalesOrderLineResult lineResult in list)
                {

                    if (lineResult.SOLineGuid.ToGuid() != Guid.Empty)
                    {
                        lineResult.UpdatedEmpID = this.SessionInfo.UserID;
                        lineResult.UpdatedEmpName = this.SessionInfo.UserName;
                        lineResult.UpdatedTime = DateTime.Now;

                    }
                    else
                    {
                        lineResult.SOLineGuid = Guid.NewGuid();
                        lineResult.CreatedEmpID = this.SessionInfo.UserID;
                        lineResult.CreatedEmpName = this.SessionInfo.UserName;
                        lineResult.CreatedTime = DateTime.Now;
                        lineResult.IsDeleted = false;
                    }

                }
                int affect = 0;
                this.BatchInsertOrUpdate<ORD_SalesOrderLineResult>(list);
                affect = this.BatchExecute();
                #region 设置返回值
                ret.Key = affect;
                #endregion

            }
            catch (WarnException exp)
            {
                throw exp;
            }
            catch (Exception exp)
            {
                LogInfoBLL.WriteLog(this.SessionInfo, exp);
                throw exp;
            
            }
            return ret;
        }
    }
}
