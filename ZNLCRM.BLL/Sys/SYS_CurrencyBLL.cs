using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLCRM.Entity.UserModel.Sys;
using MySoft.Data;
using ZNLFrame.Entity;
using ZNLCRM.Entity.DBModel;
using ZNLCRM.Entity.UserModel.Common;
using ZNLCRM.Utility;
namespace ZNLCRM.BLL.Sys
{
    public   class SYS_CurrencyBLL:BaseBLL
    {
        /// <summary>
        /// 获取集合
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public List<SYS_CurrencyResult> GetList(SYS_CurrencyParam param)
        {
            this.CheckSession();
            List<SYS_CurrencyResult> ret = new List<SYS_CurrencyResult>();
            try
            {
                #region 取最近一条汇率记录
                if (param.GetLastRate.ToBooleanHasNull())
                {
                    #region 获取条件下的最靠近的汇率
                    #region 获取条件下的最靠近的汇率的条件日期列表
                    WhereClip whereClip = GetWhereClip(param);
                    List<SYS_CurrencyResult> lastRst = new List<SYS_CurrencyResult>();
                    List<Field> lstField = new List<Field>()
                    {
                        SYS_Currency._.CurrencyCode,
                        SYS_Currency._.RateDate.Min().As("RateDate"),
                    };
                    PageList<SYS_CurrencyResult> pageRst = this.SelectList<SYS_CurrencyResult>(1, 500, lstField
                            , whereClip, null
                            , new GroupByClip("CurrencyCode"), null);
                    WhereClip whereClipLast = SYS_Currency._.IsDeleted == false;
                    WhereClip whereClipLastEx = WhereClip.All;
                    #endregion
                    #region 生成取值条件
                    int countStep = -1;
                    if (pageRst != null)
                    {
                        foreach (SYS_CurrencyResult info in pageRst.ResultList)
                        {
                            if (countStep == -1)
                                whereClipLastEx = (whereClipLastEx && SYS_Currency._.CurrencyCode == info.CurrencyCode && SYS_Currency._.RateDate == info.RateDate);
                            else
                                whereClipLastEx = whereClipLastEx || (SYS_Currency._.CurrencyCode == info.CurrencyCode && SYS_Currency._.RateDate == info.RateDate);
                            countStep++;
                        }
                    }
                    #endregion
                    #region 条件步骤
                    if (countStep >= 0)
                    {
                        whereClipLast = whereClipLast && (whereClipLastEx);
                        lastRst = this.SelectList<SYS_CurrencyResult>(whereClipLast);
                        foreach (SYS_CurrencyResult info in lastRst)
                        {
                            if (!ret.Exists(a => a.CurrencyCode == info.CurrencyCode && a.RateDate == info.RateDate))
                            {
                                ret.Add(info);
                            }
                        }
                    }
                    #endregion
                    #endregion

                    #region 获取最近条件
                    #region 获取最后一次日期条件
                    lastRst = new List<SYS_CurrencyResult>();
                    lstField = new List<Field>()
                    {
                        SYS_Currency._.CurrencyCode,
                        SYS_Currency._.RateDate.Max().As("RateDate"),
                    };
                    pageRst = this.SelectList<SYS_CurrencyResult>(1, 500, lstField
                            , SYS_Currency._.IsDeleted == false, null
                            , new GroupByClip("CurrencyCode"), null);
                    whereClipLast = SYS_Currency._.IsDeleted == false;
                    whereClipLastEx = WhereClip.All;
                    #endregion
                    #region 组合最后一次日期条件
                    countStep = -1;
                    if (pageRst != null)
                    {
                        foreach (SYS_CurrencyResult info in pageRst.ResultList)
                        {
                            if (countStep == -1)
                                whereClipLastEx = (whereClipLastEx && SYS_Currency._.CurrencyCode == info.CurrencyCode && SYS_Currency._.RateDate == info.RateDate);
                            else
                                whereClipLastEx = whereClipLastEx || (SYS_Currency._.CurrencyCode == info.CurrencyCode && SYS_Currency._.RateDate == info.RateDate);
                            countStep++;
                        }
                    }
                    if (countStep >=0)
                    {
                        whereClipLast = whereClipLast && (whereClipLastEx);
                    }
                    #endregion
                    #endregion
                    #region 获取最近条件,将结果进行组合,加入返回值
                    lastRst = this.SelectList<SYS_CurrencyResult>(whereClipLast);
                    foreach (SYS_CurrencyResult info in lastRst)
                    {
                        if (!ret.Exists(a => a.CurrencyCode == info.CurrencyCode && a.RateDate == info.RateDate))
                        {
                            ret.Add(info);
                        }
                    }
                    #endregion
                }
                else
                {
                    WhereClip whereClip = GetWhereClip(param);
                    ret = this.SelectList<SYS_CurrencyResult>(whereClip, SYS_Currency._.CreatedTime.Asc);
                }
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

        WhereClip GetWhereClip(SYS_CurrencyParam param)
        {
            this.CheckSession();
            WhereClip where = SYS_Currency._.IsDeleted == 0;
            if (param.RateTaxID != null) where = where && SYS_Currency._.RateTaxID == param.RateTaxID;
            if (!string.IsNullOrEmpty(param.CurrencyCode)) where = where && SYS_Currency._.CurrencyCode.Like("%" + param.CurrencyCode + "%");
            if (param.CurrencyCodes != null && param.CurrencyCodes.Length > 0) where = where && SYS_Currency._.CurrencyCode.In(param.CurrencyCodes);
            if (param.RateDate != null) where = where && SYS_Currency._.RateDate >= param.RateDate ;
            return where;
        }

        /// <summary>
        /// 添加和新增修改
        /// </summary>
        /// <param name="param">新增或修改的实体</param>
        /// <returns></returns>
        public WCFAddUpdateResult AddOrUpdate(SYS_CurrencyResult param)
        {
            this.CheckSession();
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            try
            {
                int affect = 0;
                #region 判断
                
                if (string.IsNullOrEmpty(param.CurrencyCode)) throw new WarnException("请指定币种！");
                if (param.RateDate==null) throw new WarnException("请选择汇率启用日期！");
                if (param.ExchangeRate == null) throw new WarnException("请填写对应的汇率！");
               
                #endregion
              
                #region 系统默认值
                if (param.RateTaxID>0)
                {
                    WhereClip where = SYS_Currency._.RateTaxID == param.RateTaxID;
                    param.UpdatedEmpID = this.SessionInfo.UserID;
                    param.UpdatedEmpName = this.SessionInfo.UserName;
                    param.UpdatedTime = DateTime.Now;
                    affect = this.Update<SYS_CurrencyResult>(param, where);
                }
                else
                {
                    param.RateTaxGuid = new Guid();
                    param.GCompanyID = this.SessionInfo.CompanyID;
                    param.IsDeleted = false;
                    param.CreatedEmpID = this.SessionInfo.UserID;
                    param.CreatedEmpName = this.SessionInfo.UserName;
                    param.CreatedTime = DateTime.Now;
                    affect = this.Insert<SYS_CurrencyResult>(param);
                    param = this.Select<SYS_CurrencyResult>(new List<Field>() { SYS_Currency._.All }, SYS_Currency._.RateTaxGuid == param.RateTaxGuid);
                }
             
                #region 设置返回值

                ret.Key = param.RateTaxID;
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
        /// 获取一条信息记录
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public SYS_CurrencyResult GetInfo(SYS_CurrencyParam param)
        {
            this.CheckSession();
            SYS_CurrencyResult rst = new SYS_CurrencyResult();
            #region 判断
            if (param.RateTaxID == null) throw new WarnException("请指定ID！");
            #endregion
            #region 获取实体

            rst = this.Select<SYS_CurrencyResult>(GetWhereClip(param));

            #endregion
            return rst;
        }

        /// <summary>
        /// 删除实体
        /// </summary>
        /// <param name="param">删除条件实体</param>
        /// <returns></returns>
        public WCFAddUpdateResult DelInfo(SYS_CurrencyParam param)
        {
            this.CheckSession();
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            int affect = 0;
            try
            {
                #region 判断
                if (param.RateTaxID == null) throw new WarnException("请指定ID！");
                #endregion
                WhereClip whereClip = GetWhereClip(param);
                SYS_CurrencyResult info = new SYS_CurrencyResult();
                info.IsDeleted = true;
                affect = this.Update<SYS_CurrencyResult>(info, whereClip);
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
        
        
    }


}
