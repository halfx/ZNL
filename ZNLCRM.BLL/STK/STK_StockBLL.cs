using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLFrame.Entity;
using ZNLCRM.Entity.UserModel.STK;
using MySoft.Data;
using ZNLCRM.Entity.DBModel;
using ZNLCRM.Entity.UserModel.Common;
using ZNLCRM.Utility;
using ZNLCRM.BLL.Sys;


namespace ZNLCRM.BLL.STK
{
    public  class STK_StockBLL:BaseBLL
    {
        /// <summary>
        /// 分页集合
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public PageList<STK_StockResult> GetPageList(STK_StockParam param)
        {
            this.CheckSession();
            PageList<STK_StockResult> ret = new PageList<STK_StockResult>();
            try
            {
                List<Field> field = new List<Field>()
                 {
                    Field.All
                 };
                ret = this.SelectList<STK_StockResult>(param.PageIndex.GetValueOrDefault(1), param.PageSize.GetValueOrDefault(50), field, GetWhereClip(param), STK_Stock._.CreatedTime.Desc);
                
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
        public WCFAddUpdateResult AddOrUpdate(STK_StockResult param)
        {
            this.CheckSession();
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            try
            {
                int affect = 0;
                #region 判断


                if (string.IsNullOrEmpty(param.InvType)) throw new WarnException("请指定库存类型！");
                if (string.IsNullOrEmpty(param.Warehouse)) throw new WarnException("请指定仓库！");
                if (string.IsNullOrEmpty(param.InBatchNo)) throw new WarnException("请指定入库批次号！");
                if (param.InvQty==null) throw new WarnException("请指定入库数量！");
                if (string.IsNullOrEmpty(param.Currency)) throw new WarnException("请指定入库币种！");
                if (param.BuyPrice == null) throw new WarnException("请指定入库单价！");
                #endregion
              

                #region 系统默认值
                if (param.ItemCode != null)
                {
                    WhereClip where = STK_Stock._.ItemCode == param.ItemCode;
                    param.UpdatedEmpID = this.SessionInfo.UserID;
                    param.UpdatedEmpName = this.SessionInfo.UserName;
                    param.UpdatedTime = DateTime.Now;
                    affect = this.Update<STK_StockResult>(param, where);
                }
                else
                {
                    param.ItemCode = Guid.NewGuid();
                   
                    param.GCompanyID = this.SessionInfo.CompanyID;

                    param.IsDeleted = false;
                    param.CreatedEmpID = this.SessionInfo.UserID;
                    param.CreatedEmpName = this.SessionInfo.UserName;
                    param.CreatedTime = DateTime.Now;
                    affect = this.Insert<STK_StockResult>(param);
                    param = this.Select<STK_StockResult>(new List<Field>() { STK_Stock._.All }, STK_Stock._.ItemCode == param.ItemCode);
                }
                #region 设置返回值
                ret.KeyGuid = param.ItemCode;
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
        /// <summary>
        /// 批量修改和插入
        /// </summary>
        /// <param name="paramList"></param>
        /// <returns></returns>
        public WCFAddUpdateResult UpdateOrInsertList(List<STK_StockResult> list)
        {
            this.CheckSession();
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            try
            {
                #region 判断
                if (list.Count <= 0) throw new WarnException("没有需要操作的对象！");
                if (list.Where(a => string.IsNullOrEmpty(a.InvType)).Count() > 0) throw new WarnException("请指定库存类型！");
                if (list.Where(a => string.IsNullOrEmpty(a.Warehouse)).Count() > 0) throw new WarnException("请指定仓库");
                if (list.Where(a => a.InvQty == null).Count() > 0) throw new WarnException("请指定入库数量");
                if (list.Where(a => string.IsNullOrEmpty(a.Currency)).Count() > 0) throw new WarnException("请指定入库币种");
                if (list.Where(a => a.BuyPrice == null).Count() > 0) throw new WarnException("请指定入库单价");
                #endregion
                foreach (STK_StockResult stkStockResult in list)
                {

                    if (!string.IsNullOrEmpty(stkStockResult.InBatchNo))
                    {
                        stkStockResult.UpdatedEmpID = this.SessionInfo.UserID;
                        stkStockResult.UpdatedEmpName = this.SessionInfo.UserName;
                        stkStockResult.UpdatedTime = DateTime.Now ;

                    }
                    else
                    {
                        stkStockResult.GCompanyID = this.SessionInfo.CompanyID;
                        stkStockResult.CreatedEmpID = this.SessionInfo.UserID;
                        stkStockResult.CreatedEmpName = this.SessionInfo.UserName;
                        stkStockResult.CreatedTime = DateTime.Now;
                        stkStockResult.InBatchNo = DateTime.Now.ToString("yyyyMMddHHmmssms") + new Random().Next(10000, 99999);
                        stkStockResult.IsDeleted = false;
                    }
                  
                }
                int affect = 0;
                this.BatchInsertOrUpdate<STK_StockResult>(list);
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
        public List<STK_StockResult> GetList(STK_StockParam param)
        {
            this.CheckSession();
            List<STK_StockResult> ret = new List<STK_StockResult>();
            try
            {
                WhereClip whereClip = GetWhereClip(param);
                ret = this.SelectList<STK_StockResult>(whereClip, STK_Stock._.CreatedTime.Asc);
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

        WhereClip GetWhereClip(STK_StockParam param)
        {
            this.CheckSession();
            WhereClip where = STK_Stock._.IsDeleted == 0;
            if (param.ItemCode != null) where = where && STK_Stock._.ItemCode == param.ItemCode;
            if (param.ItemCodes != null && param.ItemCodes.Length > 0) where = where && STK_Stock._.ItemCode.In(param.ItemCodes);
            if (param.NoItemCodes != null && param.ItemCodes.Length > 0) where = where && !STK_Stock._.ItemCode.In(param.NoItemCodes);
            if (!string.IsNullOrEmpty(param.Model)) where = where && STK_Stock._.Model.Like("%" + param.Model + "%");
            if (param.AllowUsableQtyZero != null && !param.AllowUsableQtyZero.ToBooleanHasNull()) where = where && STK_Stock._.UsableQty != 0;
            return where;
        }



        /// <summary>
        /// 获取一条信息记录
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public STK_StockResult GetInfo(STK_StockParam param)
        {
            this.CheckSession();
            STK_StockResult rst = new STK_StockResult();
            #region 判断
            if (param.ItemCode == null) throw new WarnException("请指定GUID！");
            #endregion
            #region 获取实体

            rst = this.Select<STK_StockResult>(GetWhereClip(param));

            #endregion
            return rst;
        }

        /// <summary>
        /// 删除实体
        /// </summary>
        /// <param name="param">删除条件实体</param>
        /// <returns></returns>
        public WCFAddUpdateResult DelInfo(STK_StockParam param)
        {
            this.CheckSession();
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            int affect = 0;
            try
            {
                #region 判断
                if (param.ItemCode == null) throw new WarnException("请指定GUID！");
                #endregion
                WhereClip whereClip = GetWhereClip(param);
                STK_StockResult info = new STK_StockResult();
                info.IsDeleted = true;
                affect = this.Update<STK_StockResult>(info, whereClip);
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
