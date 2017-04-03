using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySoft.Data;
using ZNLCRM.Entity.UserModel.FIN;
using ZNLCRM.Entity.DBModel;
using ZNLCRM.Entity.UserModel.Common;
using ZNLFrame.Entity;
using ZNLCRM.Utility;
using ZNLCRM.BLL.Sys;

namespace ZNLCRM.BLL.FIN
{
    public  class FIN_SubmitExpenseLineBLL:BaseBLL 
    {
        /// <summary>
        /// 获取条件的公共方法
        /// </summary>
        /// <param name="param">条件实体</param>
        /// <returns></returns>
        WhereClip GetWhereClip(FIN_SubmitExpenseLineParam param)
        {
            this.CheckSession();
            WhereClip where = FIN_SubmitExpenseLine._.IsDeleted == 0;
            if (param.ExpLineID != null) where = where && FIN_SubmitExpenseLine._.ExpLineID == param.ExpLineID;
            if (param.ExpLineGuID != null) where = where && FIN_SubmitExpenseLine._.ExpLineGuID == param.ExpLineGuID;
            return where;
        }
        /// <summary>
        /// 添加和新增修改
        /// </summary>
        /// <param name="param">新增或修改的实体</param>
        /// <returns></returns>
        public WCFAddUpdateResult AddOrUpdate(FIN_SubmitExpenseLineResult param)
        {
            this.CheckSession();
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            try
            {

                int affect = 0;
                #region 判断
                 
                
                if (string.IsNullOrEmpty(param.ExpName)) throw new WarnException("请填写费用名目！");
                if (param.Amount.ToDecimal()<=0) throw new WarnException("请填写费用金额！");

                #endregion
                #region 系统默认值


                if (param.ExpLineID.ToInt32() > 0)
                {
                    WhereClip where = FIN_SubmitExpenseLine._.ExpLineID == param.ExpLineID;
                    param.UpdatedEmpID = this.SessionInfo.UserID;
                    param.UpdatedEmpName = this.SessionInfo.UserName;
                    param.UpdatedTime = DateTime.Now;
                    affect = this.Update<FIN_SubmitExpenseLineResult>(param, where);
                }
                else
                {
                    param.ExpLineGuID = Guid.NewGuid();
                    param.CreatedEmpID = this.SessionInfo.UserID;
                    param.CreatedEmpName = this.SessionInfo.UserName;
                    param.CreatedTime = DateTime.Now;
                    param.IsDeleted = false;
                    affect = this.Insert<FIN_SubmitExpenseLineResult>(param);
                    param = this.Select<FIN_SubmitExpenseLineResult>(new List<Field>() { FIN_SubmitExpenseLine._.ExpLineID }, FIN_SubmitExpenseLine._.ExpLineGuID == param.ExpLineGuID);
                }
                #region 设置返回值
                ret.Key = param.ExpLineID;
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
        public FIN_SubmitExpenseLineResult GetInfo(FIN_SubmitExpenseLineParam param)
        {
            this.CheckSession();
            FIN_SubmitExpenseLineResult rst = new FIN_SubmitExpenseLineResult();
            #region 判断
            if (param.ExpLineID == null) throw new WarnException("请指定报销费用明细ID！");
            #endregion
            #region 保存实体
            WhereClip where = GetWhereClip(param);

            rst = this.Select<FIN_SubmitExpenseLineResult>(where);
            //Sys_EmpDataRightBLL.SetRecIsEdit<FIN_SubmitExpenseLineResult>(rst, "BeLongEmpID", "", "OrgID", this.SessionInfo);
            #endregion
            return rst;
        }


        /// <summary>
        /// 查询记录,并返回分页列表
        /// </summary>
        /// <param name="param">查询条件实体</param>
        /// <returns></returns>
        public List<FIN_SubmitExpenseLineResult> GetList(FIN_SubmitExpenseLineParam param)
        {
            this.CheckSession();
            List<FIN_SubmitExpenseLineResult> rst = new List<FIN_SubmitExpenseLineResult>();
            try
            {
                WhereClip whereClip = GetWhereClip(param);
                rst = this.SelectList<FIN_SubmitExpenseLineResult>(whereClip, FIN_SubmitExpenseLineResult._.CreatedTime.Asc);
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
            return rst;
        }
        /// <summary>
        /// 删除实体
        /// </summary>
        /// <param name="param">删除条件实体</param>
        /// <returns></returns>
        public WCFAddUpdateResult DelInfo(FIN_SubmitExpenseLineParam param)
        {
            this.CheckSession();
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            int affect = 0;
            try
            {
                #region 判断
                if (param.ExpLineID == null) throw new WarnException("请指定要删除的记录！");
                #endregion
                WhereClip where = GetWhereClip(param);
                //FIN_SubmitExpenseLineResult oldInfo = this.GetInfo(param);
                //oldInfo = Sys_EmpDataRightBLL.SetRecIsEdit<FIN_SubmitExpenseLineResult>(oldInfo, "BeLongEmpID", "", "OrgID", this.SessionInfo);
                //if (oldInfo.RecStatu != 2)
                //{
                //    throw new WarnException("您无权删除当前记录！");
                //}
                FIN_SubmitExpenseLineResult info = new FIN_SubmitExpenseLineResult();
                info.IsDeleted = true;
                info.UpdatedTime = DateTime.Now;
                info.UpdatedEmpID = this.SessionInfo.UserID;
                info.UpdatedEmpName = this.SessionInfo.UserName;
                affect = this.Update<FIN_SubmitExpenseLineResult>(info, where);
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
        public WCFAddUpdateResult UpdateOrInsertList(List<FIN_SubmitExpenseLineResult> list)
        {
            this.CheckSession();
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            try
            {
                #region 判断
                if (list.Count <= 0) throw new WarnException("没有需要操作的对象！");
                #endregion
                int affect = 0;
                this.BatchInsertOrUpdate<FIN_SubmitExpenseLineResult>(list);
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
