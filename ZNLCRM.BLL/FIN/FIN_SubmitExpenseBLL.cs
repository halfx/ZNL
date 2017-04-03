using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySoft.Data;
using ZNLCRM.Entity.UserModel.CRM;
using ZNLCRM.Entity.DBModel;
using ZNLCRM.Entity.UserModel.FIN;
using ZNLCRM.Entity.UserModel.Common;
using ZNLFrame.Entity;
using ZNLCRM.BLL.Sys;
using ZNLCRM.Utility;

namespace ZNLCRM.BLL.FIN
{
    public  class FIN_SubmitExpenseBLL:BaseBLL
    {
        /// <summary>
        /// 获取条件的公共方法
        /// </summary>
        /// <param name="param">条件实体</param>
        /// <returns></returns>
        WhereClip GetWhereClip(FIN_SubmitExpenseParam param)
        {
            this.CheckSession();
            WhereClip where = FIN_SubmitExpense._.IsDeleted == 0;
            if (param.ExpID != null) where = where && FIN_SubmitExpense._.ExpID == param.ExpID;
            if (param.ExpGuID != null) where = where && FIN_SubmitExpense._.ExpGuID == param.ExpGuID;
            if (param.BillNo != null) where = where && FIN_SubmitExpense._.BillNo.Like("%" + param.BillNo + "%");
            if (param.SourceGuid != null) where = where && FIN_SubmitExpense._.SourceGuid == param.SourceGuid;
            return where;
        }
        /// <summary>
        /// 添加和新增修改
        /// </summary>
        /// <param name="param">新增或修改的实体</param>
        /// <returns></returns>
        public WCFAddUpdateResult AddOrUpdate(FIN_SubmitExpenseResult param)
        {
            this.CheckSession();
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            try
            {

                int affect = 0;
                #region 判断

                if (string.IsNullOrEmpty(param.SourceBillNo)) throw new WarnException("请选择关联单号！");
                if (string.IsNullOrEmpty(param.ExpName)) throw new WarnException("请填写报销标题！");
                if (string.IsNullOrEmpty(param.OpEmpName)) throw new WarnException("请选择处理人！");

                #endregion
                #region 系统默认值
                List<FIN_SubmitExpenseLineResult> expenseLineList = param.ExpenseLineList;
                 
                if (param.ExpID.ToInt32() > 0)
                {
                    WhereClip where = FIN_SubmitExpense._.ExpID == param.ExpID;
                    param.GCompanyGuID = this.SessionInfo.CompanyID;
                    param.UpdatedEmpID = this.SessionInfo.UserID;
                    param.UpdatedEmpName = this.SessionInfo.UserName;
                    param.UpdatedTime = DateTime.Now;
                    affect = this.Update<FIN_SubmitExpenseResult>(param, where);
                }
                else
                {
                    Sys_CodeRulerBLL codeRulerBll = new Sys_CodeRulerBLL();
                    codeRulerBll.SessionInfo = this.SessionInfo;
                    param.BillNo = param.BillNo = codeRulerBll.GetBillNo(new Entity.UserModel.Sys.SYS_CredentialCodeRuleParam() { BillDate = DateTime.Today, TableName = "FIN_SubmitExpense" });
                    param.GCompanyGuID = this.SessionInfo.CompanyID;
                    param.OrgID = this.SessionInfo.OrgID;
                    param.ExpGuID = Guid.NewGuid();
                    param.CreatedEmpID = this.SessionInfo.UserID;
                    param.CreatedEmpName = this.SessionInfo.UserName;
                    param.CreatedTime = DateTime.Now;
                    param.IsDeleted = false;
                    affect = this.Insert<FIN_SubmitExpenseResult>(param);
                    param = this.Select<FIN_SubmitExpenseResult>(new List<Field>() { FIN_SubmitExpense._.All}, FIN_SubmitExpense._.ExpGuID == param.ExpGuID);
                }
                foreach (FIN_SubmitExpenseLineResult rst in expenseLineList)
                {
                    if (rst.ExpLineID == 0)
                    {
                        rst.IsDeleted = false;
                        rst.ExpGuID = param.ExpGuID;
                        rst.ExpLineGuID =Guid.NewGuid();
                        rst.CreatedEmpID = this.SessionInfo.UserID;
                        rst.CreatedEmpName = this.SessionInfo.UserName;
                        rst.CreatedTime = DateTime.Now;
                    }
                    else
                    {
                        rst.UpdatedEmpID = this.SessionInfo.UserID;
                        rst.UpdatedEmpName = this.SessionInfo.UserName;
                        rst.UpdatedTime = DateTime.Now;
                    }
                }

                this.BatchInsertOrUpdate<FIN_SubmitExpenseLineResult>(expenseLineList);
                this.BatchExecute();
                #region 设置返回值
                ret.Key = param.ExpID;
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
        public FIN_SubmitExpenseResult GetInfo(FIN_SubmitExpenseParam param)
        {
            this.CheckSession();
            FIN_SubmitExpenseResult rst = new FIN_SubmitExpenseResult();
            #region 判断
            if (param.ExpID == null) throw new WarnException("请指定报销主单ID！");
            #endregion
            #region 保存实体
            WhereClip where = GetWhereClip(param);

            rst = this.Select<FIN_SubmitExpenseResult>(where);
        
            
            if (rst != null)
            {
                rst.ExpenseLineList = this.SelectList<FIN_SubmitExpenseLineResult>(FIN_SubmitExpenseLine._.ExpGuID == rst.ExpGuID);
            }
            //Sys_EmpDataRightBLL.SetRecIsEdit<FIN_SubmitExpenseResult>(rst, "BeLongEmpID", "", "OrgID", this.SessionInfo);
            #endregion
            return rst;
        }


        /// <summary>
        /// 查询记录,并返回分页列表
        /// </summary>
        /// <param name="param">查询条件实体</param>
        /// <returns></returns>
        public List<FIN_SubmitExpenseResult> GetList(FIN_SubmitExpenseParam param)
        {
            this.CheckSession();
            List<FIN_SubmitExpenseResult> rst = new List<FIN_SubmitExpenseResult>();
            try
            {
                WhereClip whereClip = GetWhereClip(param);
                rst = this.SelectList<FIN_SubmitExpenseResult>(whereClip, FIN_SubmitExpense._.CreatedTime.Asc);
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
        public WCFAddUpdateResult DelInfo(FIN_SubmitExpenseParam param)
        {
            this.CheckSession();
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            int affect = 0;
            try
            {
                #region 判断
                if (param.ExpID == null) throw new WarnException("请指定要删除的记录！");
                #endregion
                WhereClip where = GetWhereClip(param);
                //FIN_SubmitExpenseResult oldInfo = this.GetInfo(param);
                //oldInfo = Sys_EmpDataRightBLL.SetRecIsEdit<FIN_SubmitExpenseResult>(oldInfo, "BeLongEmpID", "", "OrgID", this.SessionInfo);
                //if (oldInfo.RecStatu != 2)
                //{
                //    throw new WarnException("您无权删除当前记录！");
                //}
                FIN_SubmitExpenseResult info = new FIN_SubmitExpenseResult();
                info.IsDeleted = true;
                info.UpdatedTime = DateTime.Now;
                info.UpdatedEmpID = this.SessionInfo.UserID;
                info.UpdatedEmpName = this.SessionInfo.UserName;
                affect = this.Update<FIN_SubmitExpenseResult>(info, where);
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
        public WCFAddUpdateResult UpdateOrInsertList(List<FIN_SubmitExpenseResult> list)
        {
            this.CheckSession();
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            try
            {
                #region 判断
                if (list.Count <= 0) throw new WarnException("没有需要操作的对象！");
                #endregion
                int affect = 0;
                this.BatchInsertOrUpdate<FIN_SubmitExpenseResult>(list);
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
