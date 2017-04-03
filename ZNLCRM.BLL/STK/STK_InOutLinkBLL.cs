using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLCRM.Entity.UserModel.STK;
using MySoft.Data;
using ZNLCRM.Entity.DBModel;
using ZNLFrame.Entity;
using ZNLCRM.BLL.Sys;
using ZNLCRM.Entity.UserModel.Common;
using ZNLCRM.Utility;

namespace ZNLCRM.BLL.STK
{
    public  class STK_InOutLinkBLL:BaseBLL
    {
       
        /// <summary>
        /// 获取集合
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public List<STK_InOutLinkResult> GetList(STK_InOutLinkParam param)
        {
            this.CheckSession();
            List<STK_InOutLinkResult> ret = new List<STK_InOutLinkResult>();
            try
            {
                WhereClip whereClip = GetWhereClip(param);
                ret = this.SelectList<STK_InOutLinkResult>(whereClip, STK_InOutLink._.CreatedTime.Asc);
                
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

        WhereClip GetWhereClip(STK_InOutLinkParam param)
        {
            this.CheckSession();

            WhereClip where = STK_InOutLink._.IsDeleted == 0;
            if (param.StkInLineGuid != null) where = where && STK_InOutLink._.StkInLineGuid == param.StkInLineGuid;
            if (param.StkOutGuid != null) where = where && STK_InOutLink._.StkOutGuid == param.StkOutGuid;
            if (param.StkInLineGuids != null) where = where && STK_InOutLink._.StkInLineGuid.In(param.StkInLineGuids);
            
            return where;
        }


        /// <summary>
        /// 获取一条信息记录
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public STK_InOutLinkResult GetInfo(STK_InOutLinkParam param)
        {
            this.CheckSession();
            STK_InOutLinkResult rst = new STK_InOutLinkResult();
            #region 判断
            if (param.StkLinkGuid == null) throw new WarnException("请指定明细GUID！");
            #endregion
            #region 获取实体

            rst = this.Select<STK_InOutLinkResult>(GetWhereClip(param));

            #endregion
            return rst;
        }

        /// <summary>
        /// 删除实体
        /// </summary>
        /// <param name="param">删除条件实体</param>
        /// <returns></returns>
        public WCFAddUpdateResult DelInfo(STK_InOutLinkParam param)
        {
            this.CheckSession();
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            int affect = 0;
            try
            {
                #region 判断
                if (param.StkLinkGuid == null) throw new WarnException("请指定明细GUID！");
                #endregion
                WhereClip whereClip = GetWhereClip(param);
                STK_InOutLinkResult info = new STK_InOutLinkResult();
                info.IsDeleted = true;
                affect = this.Update<STK_InOutLinkResult>(info, whereClip);
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
        /// 批量修改和插入
        /// </summary>
        /// <param name="paramList"></param>
        /// <returns></returns>
        public WCFAddUpdateResult UpdateOrInsertList(List<STK_InOutLinkResult> list)
        {
            this.CheckSession();
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            try
            {
                #region 判断
              
                #endregion
                foreach (STK_InOutLinkResult linkResult in list)
                {

                    if (linkResult.StkLinkGuid.ToGuid() != Guid.Empty)
                    {
                        linkResult.UpdatedEmpID = this.SessionInfo.UserID;
                        linkResult.UpdatedEmpName = this.SessionInfo.UserName;
                        linkResult.UpdatedTime = DateTime.Now;

                    }
                    else
                    {
                        linkResult.CreatedEmpID = this.SessionInfo.UserID;
                        linkResult.CreatedEmpName = this.SessionInfo.UserName;
                        linkResult.CreatedTime = DateTime.Now;
                        linkResult.IsDeleted = false;
                    }

                }
                int affect = 0;
                this.BatchInsertOrUpdate<STK_InOutLinkResult>(list);
                affect = this.BatchExecute();
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
