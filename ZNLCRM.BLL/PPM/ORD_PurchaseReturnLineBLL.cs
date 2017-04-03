using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLFrame.Entity;
using ZNLCRM.Entity.UserModel.PPM;
using MySoft.Data;
using ZNLCRM.Entity.DBModel;
using ZNLCRM.BLL.Sys;
using ZNLCRM.Entity.UserModel.Common;
using ZNLCRM.Utility;

namespace ZNLCRM.BLL.PPM
{
    [Serializable]
    public   class ORD_PurchaseReturnLineBLL:BaseBLL
    {
        
        public PageList<ORD_PurchaseReturnLineResult> GetPageList(ORD_PurchaseReturnLineParam param)
        {

            PageList<ORD_PurchaseReturnLineResult> ret = new PageList<ORD_PurchaseReturnLineResult>();
            try
            {
                ret = this.SelectList<ORD_PurchaseReturnLineResult>(param.PageIndex.GetValueOrDefault(1), param.PageSize.GetValueOrDefault(50), new List<Field> { Field.All }, GetWhereClip(param), ORD_PurchaseReturnLine._.CreatedTime.Desc);
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
        public List<ORD_PurchaseReturnLineResult> GetList(ORD_PurchaseReturnLineParam param)
        {
            this.CheckSession();
            List<ORD_PurchaseReturnLineResult> ret = new List<ORD_PurchaseReturnLineResult>();
            try
            {
                WhereClip whereClip = GetWhereClip(param);
                ret = this.SelectList<ORD_PurchaseReturnLineResult>(whereClip, ORD_PurchaseReturnLine._.CreatedTime.Asc);


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

        WhereClip GetWhereClip(ORD_PurchaseReturnLineParam param)
        {
            this.CheckSession();
            WhereClip where = ORD_PurchaseReturnLine._.IsDeleted == 0;
            if (param.PRLineGuid != null) where = where && ORD_PurchaseReturnLine._.PRLineGuid == param.PRLineGuid;
            if (param.PRGuid != null) where = where && ORD_PurchaseReturnLine._.PRGuid == param.PRGuid;
            if (param.POLineGuids != null && param.POLineGuids.Length > 0) where = where && ORD_PurchaseReturnLine._.POLineGuid.In(param.POLineGuids);
            if (!string.IsNullOrEmpty(param.Model)) where = where && ORD_PurchaseReturnLine._.Model.Like(param.Model + "%");
            if (param.StkInLineGuids != null && param.StkInLineGuids.Length > 0) where = where && ORD_PurchaseReturnLine._.StkInLineGuid.In(param.StkInLineGuids);
            return where;
        }


        /// <summary>
        /// 获取一条信息记录
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public ORD_PurchaseReturnLineResult GetInfo(ORD_PurchaseReturnLineParam param)
        {
            this.CheckSession();
            ORD_PurchaseReturnLineResult rst = new ORD_PurchaseReturnLineResult();
            #region 判断
            if (param.PRLineGuid == null) throw new WarnException("请指定明细GUID！");
            #endregion
            #region 获取实体

            rst = this.Select<ORD_PurchaseReturnLineResult>(GetWhereClip(param));

            #endregion
            return rst;
        }

        /// <summary>
        /// 删除实体
        /// </summary>
        /// <param name="param">删除条件实体</param>
        /// <returns></returns>
        public WCFAddUpdateResult DelInfo(ORD_PurchaseReturnLineParam param)
        {
            this.CheckSession();
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            int affect = 0;
            try
            {
                #region 判断
                if (param.PRLineGuid == null) throw new WarnException("请指定明细GUID！");
                #endregion
                WhereClip whereClip = GetWhereClip(param);
                ORD_PurchaseReturnLineResult info = new ORD_PurchaseReturnLineResult();
                info.IsDeleted = true;
                affect = this.Update<ORD_PurchaseReturnLineResult>(info, whereClip);
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
        public WCFAddUpdateResult AddOrUpdate(ORD_PurchaseReturnLineResult param)
        {
            this.CheckSession();
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            try
            {
                int affect = 0;
                #region 判断
                #endregion

                #region 系统默认值
                if (param.PRLineGuid != null)
                {
                    WhereClip where = ORD_PurchaseReturnLine._.PRLineGuid == param.PRLineGuid;
                    param.UpdatedEmpID = this.SessionInfo.UserID;
                    param.UpdatedEmpName = this.SessionInfo.UserName;
                    param.UpdatedTime = DateTime.Now;
                    affect = this.Update<ORD_PurchaseReturnLineResult>(param, where);
                }
                else
                {
                    param.PRLineGuid = Guid.NewGuid();
                    param.IsDeleted = false;
                    param.CreatedEmpID = this.SessionInfo.UserID;
                    param.CreatedEmpName = this.SessionInfo.UserName;
                    param.CreatedTime = DateTime.Now;
                    affect = this.Insert<ORD_PurchaseReturnLineResult>(param);
                    param = this.Select<ORD_PurchaseReturnLineResult>(new List<Field>() { ORD_PurchaseReturnLine._.All }, ORD_PurchaseReturnLine._.PRLineGuid == param.PRLineGuid);
                }
                #region 设置返回值
                ret.KeyGuid = param.PRLineGuid;
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

        public WCFAddUpdateResult UpdateOrInsertList(List<ORD_PurchaseReturnLineResult> list)
        {
            this.CheckSession();
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            try
            {
                #region 判断
                if (list.Count <= 0) throw new WarnException("没有需要操作的对象！");
                #endregion
                foreach (ORD_PurchaseReturnLineResult lineResult in list)
                {
                    if (lineResult.PRLineGuid.ToGuid() != Guid.Empty)
                    {
                        lineResult.UpdatedEmpID = this.SessionInfo.UserID;
                        lineResult.UpdatedEmpName = this.SessionInfo.UserName;
                        lineResult.UpdatedTime = DateTime.Now;

                    }
                    else
                    {
                        lineResult.PRLineGuid = Guid.NewGuid();
                        lineResult.CreatedEmpID = this.SessionInfo.UserID;
                        lineResult.CreatedEmpName = this.SessionInfo.UserName;
                        lineResult.CreatedTime = DateTime.Now;
                        lineResult.IsDeleted = false;
                    }

                }
                int affect = 0;
                this.BatchInsertOrUpdate<ORD_PurchaseReturnLineResult>(list);
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
