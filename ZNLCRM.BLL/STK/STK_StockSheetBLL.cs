using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLCRM.Entity.UserModel.STK;
using MySoft.Data;
using ZNLFrame.Entity;
using ZNLCRM.Entity.DBModel;
using ZNLCRM.Entity.UserModel.Common;
using ZNLCRM.BLL.Sys;
using ZNLCRM.Utility;

namespace ZNLCRM.BLL.STK
{
    public   class STK_StockSheetBLL:BaseBLL
    {

        /// <summary>
        /// 分页集合
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public PageList<STK_StockSheetResult> GetPageList(STK_StockSheetParam param)
        {
            this.CheckSession();
            PageList<STK_StockSheetResult> ret = new PageList<STK_StockSheetResult>();
            try
            {
                 List<Field> field = new List<Field>()
                 {
                    Field.All
                 };
                ret = this.SelectList<STK_StockSheetResult>(param.PageIndex.GetValueOrDefault(1), param.PageSize.GetValueOrDefault(50), field, GetWhereClip(param), STK_StockSheet._.CreatedTime.Desc);
               
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
        public WCFAddUpdateResult UpdateOrInsertList(List<STK_StockSheetResult> list)
        {
            this.CheckSession();
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            try
            {
                #region 判断
                if (list.Count <= 0) throw new WarnException("没有需要操作的对象！");
                #endregion
                foreach (STK_StockSheetResult stkStockSheetResult in list)
                {
                    
                    if (stkStockSheetResult.SSGuid.ToGuid() != Guid.Empty)
                    {
                        stkStockSheetResult.UpdatedEmpID = this.SessionInfo.UserID;
                        stkStockSheetResult.UpdatedEmpName = this.SessionInfo.UserName;
                        stkStockSheetResult.UpdatedTime = DateTime.Now;

                    }
                    else
                    {
                        stkStockSheetResult.SSGuid = Guid.NewGuid();
                        stkStockSheetResult.GCompanyID = this.SessionInfo.CompanyID;
                        stkStockSheetResult.CreatedEmpID = this.SessionInfo.UserID;
                        stkStockSheetResult.CreatedEmpName = this.SessionInfo.UserName;
                        stkStockSheetResult.CreatedTime = DateTime.Now;
                        stkStockSheetResult.IsDeleted = false;
                    }

                }
                int affect = 0;
                this.BatchInsertOrUpdate<STK_StockSheetResult>(list);
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
        /// <summary>
        /// 获取集合
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public List<STK_StockSheetResult> GetList(STK_StockSheetParam param)
        {
            this.CheckSession();
            List<STK_StockSheetResult> ret = new List<STK_StockSheetResult>();
            try
            {
                WhereClip whereClip = GetWhereClip(param);
                ret = this.SelectList<STK_StockSheetResult>(whereClip, STK_StockSheet._.CreatedTime.Asc);
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

        WhereClip GetWhereClip(STK_StockSheetParam param)
        {
            this.CheckSession();
            WhereClip where = STK_StockSheet._.IsDeleted == 0;
            if (param.SSGuid != null) where = where && STK_StockSheet._.SSGuid == param.SSGuid;
            if (!string.IsNullOrEmpty(param.Model)) where = where && STK_StockSheet._.Model.Like("%" + param.Model + "%");
            if (param.SSType != null) where = where && STK_StockSheet._.SSType == param.SSType;
            if (param.ItemCode != null) where = where && STK_StockSheet._.ItemCode == param.ItemCode;
            return where;
        }

       

        /// <summary>
        /// 获取一条信息记录
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public STK_StockSheetResult GetInfo(STK_StockSheetParam param)
        {
            this.CheckSession();
            STK_StockSheetResult rst = new STK_StockSheetResult();
            #region 判断
            if (param.SSGuid == null) throw new WarnException("请指定GUID！");
            #endregion
            #region 获取实体

            rst = this.Select<STK_StockSheetResult>(GetWhereClip(param));

            #endregion
            return rst;
        }

        /// <summary>
        /// 删除实体
        /// </summary>
        /// <param name="param">删除条件实体</param>
        /// <returns></returns>
        public WCFAddUpdateResult DelInfo(STK_StockSheetParam param)
        {
            this.CheckSession();
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            int affect = 0;
            try
            {
                #region 判断
                if (param.SSGuid == null) throw new WarnException("请指定GUID！");
                #endregion
                WhereClip whereClip = GetWhereClip(param);
                STK_StockSheetResult info = new STK_StockSheetResult();
                info.IsDeleted = true;
                affect = this.Update<STK_StockSheetResult>(info, whereClip);
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
