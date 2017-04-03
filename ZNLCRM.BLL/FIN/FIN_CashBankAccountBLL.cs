using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySoft.Data;
using ZNLCRM.Entity.UserModel;
using ZNLCRM.Entity.DBModel;
using ZNLCRM.Entity.UserModel.Common;
using ZNLCRM.Entity.UserModel.FIN;
using ZNLFrame.Entity;
using ZNLCRM.Utility;
using ZNLCRM.BLL.Sys;

namespace ZNLCRM.BLL.FIN
{
    public  class FIN_CashBankAccountBLL:BaseBLL
    {
        /// <summary>
        /// 获取条件的公共方法
        /// </summary>
        /// <param name="param">条件实体</param>
        /// <returns></returns>
        WhereClip GetWhereClip(FIN_CashBankAccountParam param)
        {
            this.CheckSession();
            WhereClip where = FIN_CashBankAccount._.IsFrozen == 0;
            if (param.CBID != null) where = where && FIN_CashBankAccount._.CBID == param.CBID;
            if (param.CBNo != null) where = where && FIN_CashBankAccount._.CBNo.Like("%" + param.CBNo + "%");
            if (param.CBName != null) where = where && FIN_CashBankAccount._.CBName.Like("%"+ param.CBName+"%");
            return where;
        }
        /// <summary>
        /// 添加和新增修改
        /// </summary>
        /// <param name="param">新增或修改的实体</param>
        /// <returns></returns>
        public WCFAddUpdateResult AddOrUpdate(FIN_CashBankAccountResult param)
        {
            this.CheckSession();
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            try
            {
                
                int affect = 0;
                #region 判断
                if (string.IsNullOrEmpty(param.CBNo)) throw new WarnException("请指定账号！");
                if (string.IsNullOrEmpty(param.CBName)) throw new WarnException("请指定开户行！");
                if(string.IsNullOrEmpty(param.BCode))throw new WarnException("请指定户名！");
                if (string.IsNullOrEmpty(param.Currency)) throw new WarnException("请指定币种！");
              
                #endregion
                #region 系统默认值
 
                if (param.CBID.ToInt32() >0)
                {
                    WhereClip where = FIN_CashBankAccount._.CBID == param.CBID;
                    param.GCompanyID = this.SessionInfo.CompanyID;
                    param.UpdatedEmpID = this.SessionInfo.UserID;
                    param.UpdatedEmpName = this.SessionInfo.UserName;
                    param.UpdatedTime = DateTime.Now;
                    affect = this.Update<FIN_CashBankAccountResult>(param, where);
                }
                else
                {
                    param.GCompanyID = this.SessionInfo.CompanyID;
                    param.CBGuid = Guid.NewGuid();
                    param.CreatedEmpID = this.SessionInfo.UserID;
                    param.CreatedEmpName = this.SessionInfo.UserName;
                    param.CreatedTime = DateTime.Now;
                    param.IsFrozen = false;
                    param.IsDeleted = false;
                    affect=  this.Insert<FIN_CashBankAccountResult>(param);
                   param = this.Select<FIN_CashBankAccountResult>(new List<Field>() { FIN_CashBankAccount._.CBID }, FIN_CashBankAccount._.CBGuid == param.CBGuid);
                }
                #region 设置返回值
                ret.Key = param.CBID;
                ret.BillNo = param.CBNo;
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
        public FIN_CashBankAccountResult GetInfo(FIN_CashBankAccountParam param)
        {
            this.CheckSession();
            FIN_CashBankAccountResult rst = new FIN_CashBankAccountResult();
            #region 判断
            if (param.CBID == null) throw new WarnException("请指定账户ID！");
            #endregion
            #region 保存实体
            WhereClip where = GetWhereClip(param);
            
            rst = this.Select<FIN_CashBankAccountResult>(where);
            //Sys_EmpDataRightBLL.SetRecIsEdit<FIN_CashBankAccountResult>(rst, "BeLongEmpID", "", "OrgID", this.SessionInfo);
            #endregion
            return rst;
        }
      
        
        /// <summary>
        /// 查询记录,并返回分页列表
        /// </summary>
        /// <param name="param">查询条件实体</param>
        /// <returns></returns>
        public PageList<FIN_CashBankAccountResult> GetPageList(FIN_CashBankAccountParam param)
        {
            this.CheckSession();
            PageList<FIN_CashBankAccountResult> rst = new PageList<FIN_CashBankAccountResult>();
            WhereClip where = GetWhereClip(param);
            List<Field> lstField = new List<Field>()
            {
                FIN_CashBankAccount._.All
               
            };
            rst = this.SelectList<FIN_CashBankAccountResult>(param.PageIndex.GetValueOrDefault(1), param.PageSize.GetValueOrDefault(50), lstField, where, FIN_CashBankAccount._.CreatedTime.Desc);
           // rst.ResultList = Sys_EmpDataRightBLL.SetRecIsEdit<FIN_CashBankAccountResult>(rst.ResultList, "BeLongEmpID", "", "OrgID", this.SessionInfo);
            return rst;
        }
        /// <summary>
        /// 删除实体
        /// </summary>
        /// <param name="param">删除条件实体</param>
        /// <returns></returns>
        public WCFAddUpdateResult DelInfo(FIN_CashBankAccountParam param)
        {
            this.CheckSession();
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            int affect = 0;
            try
            {
                #region 判断
                if (param.CBID == null) throw new WarnException("请指定要删除的记录！");
                #endregion
                WhereClip where = GetWhereClip(param);
                //FIN_CashBankAccountResult oldInfo = this.GetInfo(param);
                //oldInfo = Sys_EmpDataRightBLL.SetRecIsEdit<FIN_CashBankAccountResult>(oldInfo, "BeLongEmpID", "", "OrgID", this.SessionInfo);
                //if (oldInfo.RecStatu != 2)
                //{
                //    throw new WarnException("您无权删除当前记录！");
                //}
                FIN_CashBankAccountResult info = new FIN_CashBankAccountResult();
                info.IsDeleted = true;
                info.UpdatedTime = DateTime.Now;
                info.UpdatedEmpID = this.SessionInfo.UserID;
                info.UpdatedEmpName = this.SessionInfo.UserName;
                affect = this.Update<FIN_CashBankAccountResult>(info, where);
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
        public WCFAddUpdateResult UpdateOrInsertList(List<FIN_CashBankAccountResult> list)
        {
            this.CheckSession();
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            try
            {
                #region 判断
                if (list.Count <= 0) throw new WarnException("没有需要操作的对象！");
                #endregion
                int affect = 0;
                this.BatchInsertOrUpdate<FIN_CashBankAccountResult>(list);
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
