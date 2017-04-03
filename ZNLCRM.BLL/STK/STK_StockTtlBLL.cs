using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLFrame.Entity;
using ZNLCRM.Entity.UserModel.STK;
using MySoft.Data;
using ZNLCRM.Entity.DBModel;
using ZNLCRM.Entity.UserModel.Common;
using ZNLCRM.BLL.Sys;

namespace ZNLCRM.BLL.STK
{
    public  class STK_StockTtlBLL:BaseBLL
    {

        /// <summary>
        /// 分页集合按明细分页
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public PageList<STK_StockTtlResult> GetPageListByDetail(STK_StockTtlParam param)
        {
            this.CheckSession();
            PageList<STK_StockTtlResult> stockTtlPgList=new PageList<STK_StockTtlResult>(); 
            PageList<STK_StockResult> stockPgList = new PageList<STK_StockResult>();
            try
            {
                List<Field> field = new List<Field>()
                 {
                    Field.All
                 };
                WhereClip clip= STK_Stock._.IsDeleted==0 && STK_Stock._.InvQty != 0 ;
                if(!string.IsNullOrEmpty(param.Model))clip=clip && STK_Stock._.Model.Like(param.Model+"%");
                if(!string.IsNullOrEmpty(param.Brand)) clip=clip && STK_Stock._.Brand.Like(param.Brand+"%");
                if(!string.IsNullOrEmpty(param.Batch)) clip=clip && STK_Stock._.Brand.Like(param.Batch+"%");
                if(!string.IsNullOrEmpty(param.Package)) clip=clip && STK_Stock._.Brand.Like(param.Package+"%");
                stockPgList = this.SelectList<STK_StockResult>(param.PageIndex.GetValueOrDefault(1), param.PageSize.GetValueOrDefault(50), field, clip, STK_Stock._.CreatedTime.Desc);
                List<STK_StockResult> stockList= stockPgList.ResultList;
                if (stockList != null && stockList.Count > 0)
                {
                    stockTtlPgList.TotalCount = stockPgList.TotalCount;
                    Guid?[] tItemCodes = stockList.Select(a => a.TItemCode).Distinct().ToArray();
                    List<STK_StockTtlResult> stockTtlList = this.SelectList<STK_StockTtlResult>(STK_StockTtl._.TItemCode.In(tItemCodes));
                    foreach (STK_StockTtlResult stockTtl in stockTtlList)
                    {
                        List<STK_StockResult> list = stockList.Where(a => a.TItemCode == stockTtl.TItemCode).ToList();
                        if (list != null && list.Count > 0)
                        {
                            stockTtl.StockList = list;
                        }
                    }
                    stockTtlPgList.ResultList = stockTtlList;
                }

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
            return stockTtlPgList;

        }
        /// <summary>
        /// 分页集合按主单分页
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public PageList<STK_StockTtlResult> GetPageList(STK_StockTtlParam param)
        {
            this.CheckSession();
            PageList<STK_StockTtlResult> ret = new PageList<STK_StockTtlResult>();
            try
            {
                List<Field> field = new List<Field>()
                 {
                    Field.All
                 };
                
                ret = this.SelectList<STK_StockTtlResult>(param.PageIndex.GetValueOrDefault(1), param.PageSize.GetValueOrDefault(50), field, GetWhereClip(param), STK_StockTtl._.CreatedTime.Desc);
                
                //foreach (STK_StockTtlResult stockTtl in ret.ResultList)
                //{
                //    List<STK_StockResult> stockList = this.SelectList<STK_StockResult>(STK_Stock._.TItemCode == stockTtl.TItemCode && STK_Stock._.InvQty != 0, STK_Stock._.CreatedTime.Desc);
                //    if (stockList != null && stockList.Count>0)
                //    {
                //        stockTtl.StockList = stockList;
                //    }
                //}
               
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
        public WCFAddUpdateResult AddOrUpdate(STK_StockTtlResult param)
        {
            this.CheckSession();
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            try
            {
                int affect = 0;
                #region 判断


              
                #endregion


                #region 系统默认值
                if (param.TItemCode != null)
                {
                    WhereClip where = STK_StockTtl._.TItemCode == param.TItemCode;
                    param.UpdatedEmpID = this.SessionInfo.UserID;
                    param.UpdatedEmpName = this.SessionInfo.UserName;
                    param.UpdatedTime = DateTime.Now;
                    affect = this.Update<STK_StockTtlResult>(param, where);
                }
                else
                {
                    param.TItemCode = Guid.NewGuid();
                    param.GCompanyID = this.SessionInfo.CompanyID;
                    param.IsDeleted = false;
                    param.CreatedEmpID = this.SessionInfo.UserID;
                    param.CreatedEmpName = this.SessionInfo.UserName;
                    param.CreatedTime = DateTime.Now;
                    affect = this.Insert<STK_StockTtlResult>(param);
                    param = this.Select<STK_StockTtlResult>(new List<Field>() { STK_StockTtl._.All }, STK_StockTtl._.TItemCode == param.TItemCode);
                }
               
                #region 设置返回值
                ret.KeyGuid = param.TItemCode;
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
        public WCFAddUpdateResult UpdateOrInsertList(List<STK_StockTtlResult> list)
        {
            this.CheckSession();
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            try
            {
                #region 判断
                if (list.Count <= 0) throw new WarnException("没有需要操作的对象！");
                #endregion
                int affect = 0;
                this.BatchInsertOrUpdate<STK_StockTtlResult>(list);
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
            }
            return ret;

        }
        /// <summary>
        /// 获取集合
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public List<STK_StockTtlResult> GetList(STK_StockTtlParam param)
        {
            this.CheckSession();
            List<STK_StockTtlResult> ret = new List<STK_StockTtlResult>();
            try
            {
                WhereClip whereClip = GetWhereClip(param);
                ret = this.SelectList<STK_StockTtlResult>(whereClip, STK_StockTtl._.CreatedTime.Asc);
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

        WhereClip GetWhereClip(STK_StockTtlParam param)
        {
            this.CheckSession();
            WhereClip where = STK_StockTtl._.IsDeleted == 0;
            if (param.TItemCode != null) where = where && STK_StockTtl._.TItemCode == param.TItemCode;
            if (!string.IsNullOrEmpty(param.Model)) where = where && STK_StockTtl._.Model.Like("%" + param.Model + "%");
            return where;
        }



        /// <summary>
        /// 获取一条信息记录
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public STK_StockTtlResult GetInfo(STK_StockTtlParam param)
        {
            this.CheckSession();
            STK_StockTtlResult rst = new STK_StockTtlResult();
            #region 判断
            if (param.TItemCode == null) throw new WarnException("请指定GUID！");
            #endregion
            #region 获取实体

            rst = this.Select<STK_StockTtlResult>(GetWhereClip(param));

            #endregion
            return rst;
        }

        /// <summary>
        /// 删除实体
        /// </summary>
        /// <param name="param">删除条件实体</param>
        /// <returns></returns>
        public WCFAddUpdateResult DelInfo(STK_StockTtlParam param)
        {
            this.CheckSession();
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            int affect = 0;
            try
            {
                #region 判断
                if (param.TItemCode == null) throw new WarnException("请指定GUID！");
                #endregion
                WhereClip whereClip = GetWhereClip(param);
                STK_StockTtlResult info = new STK_StockTtlResult();
                info.IsDeleted = true;
                affect = this.Update<STK_StockTtlResult>(info, whereClip);
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
