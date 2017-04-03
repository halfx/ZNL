using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySoft.Data;
using ZNLCRM.Entity.UserModel.HR;
using ZNLCRM.Entity.UserModel.Common;
using ZNLFrame.Entity;
using ZNLCRM.BLL.Sys;
using ZNLCRM.Utility;
using ZNLCRM.Entity.DBModel;
using ZNLCRM.Entity.UserModel.Account;

namespace ZNLCRM.BLL.HR
{
    public  class HR_EmployeeBLL:BaseBLL
    {
         public HR_EmployeeBLL()
        {
            
        }
        /// <summary>
        /// 获取条件的公共方法
        /// </summary>
        /// <param name="param">条件实体</param>
        /// <returns></returns>
        WhereClip GetWhereClip(HR_EmployeeParam param)
        {
            this.CheckSession();
            WhereClip where = HR_Employee._.IsDeleted == 0;
            if (param.EmpID != null) where = where && HR_Employee._.EmpID == param.EmpID;
            if (param.EmpIDs != null) where = where && HR_Employee._.EmpID.In(param.EmpIDs);
            if (param.EmpCode != null) where = where && HR_Employee._.EmpCode == param.EmpCode;
            if (param.EmpGuid != null) where = where && HR_Employee._.EmpGuid == param.EmpGuid;
            if (param.OrgID != null) where = where && HR_Employee._.OrgID == param.OrgID;
            if (param.DeptID != null) where = where && HR_Employee._.DeptID == param.DeptID;
            if (param.EmpName != null) where = where && HR_Employee._.EmpName.Like("%" + param.EmpName + "%");
            if (param.NoEmpIDs != null && param.NoEmpIDs.Length > 0) where = where && !HR_Employee._.EmpID.In(param.NoEmpIDs);
            return where;
        }
        /// <summary>
        /// 添加和新增修改
        /// </summary>
        /// <param name="param">新增或修改的实体</param>
        /// <returns></returns>
        public WCFAddUpdateResult AddOrUpdate(HR_EmployeeResult param)
        {
            this.CheckSession();
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            try
            {
                int affect = 0;
                #region 判断
                if(param.EmpCode.Trim()=="") throw new  WarnException("请输入人员编号！");
                if (param.EmpName.Trim() == "") throw new WarnException("请输入人员名称！");
                if(param.OrgID==0) throw new  WarnException("请选择所属机构！");
                if(param.DeptID==0 ) throw new WarnException("请选择所属部门！");
               
                
                #endregion

                #region 判断重复
                WhereClip whereChk = HR_Employee._.EmpCode == param.EmpCode;
                if (param.EmpID > 0) whereChk = whereChk && HR_Employee._.EmpID != param.EmpID;
                int chkNum = this.Count<HR_EmployeeResult>(whereChk);
                if (chkNum > 0) throw new WarnException("存在重复的人员编号!");
                #endregion

                #region 系统默认值
                if (param.EmpID !=0)
                {
                    WhereClip where = HR_Employee._.EmpGuid == param.EmpGuid;
                    affect = this.Update<HR_EmployeeResult>(param, where);
                }
                else
                {
                    param.EmpGuid = Guid.NewGuid();
                    param.GCompanyID = this.SessionInfo.CompanyID;
                    param.IsDeleted = false;
                    affect = this.Insert<HR_EmployeeResult>(param);
                    param = this.Select<HR_EmployeeResult>(new List<Field>() { HR_Employee._.EmpID }, HR_Employee._.EmpGuid == param.EmpGuid);
                }
                #region 保存帐户登录信息
                SYS_UserAccount userAcct = new SYS_UserAccount();
                userAcct = this.Select<SYS_UserAccount>(SYS_UserAccount._.EmpID == param.EmpID && SYS_UserAccount._.IsDeleted == false);
                if (userAcct == null) userAcct = new SYS_UserAccount();
                userAcct.Account = param.EmpCode;
                userAcct.EmpID = param.EmpID;
                userAcct.NeedValidate = param.NeedValidate;
                userAcct.IsActive= param.IsActive;
                if (param.Password.ToStringHasNull().Trim() != "")
                {
                    userAcct.PWD = StringExt.MD5(param.Password);
                }
                if(userAcct.UserID.ToInt32()<=0)
                {
                    userAcct.GCompanyID = this.SessionInfo.CompanyID;
                    userAcct.UserGUID = Guid.NewGuid();
                    userAcct.CreatedTime = DateTime.Now;
                    userAcct.CreatedByID = this.SessionInfo.UserID;
                    userAcct.CreatedByName = this.SessionInfo.UserName;
                    userAcct.IsDeleted = false;
                    this.Insert<SYS_UserAccount>(userAcct);
                }
                else
                {
                    this.Update<SYS_UserAccount>(userAcct, SYS_UserAccount._.EmpID == param.EmpID && SYS_UserAccount._.IsDeleted == false);
                }
                #endregion
                #region 设置返回值
                ret.Key = param.EmpID;
                ret.KeyGuid = param.EmpGuid;
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
        public HR_EmployeeResult GetInfo(HR_EmployeeParam param)
        {
            this.CheckSession();
            HR_EmployeeResult rst = new HR_EmployeeResult();
            #region 判断
            if (param.EmpID == null) throw new WarnException("请指定关键字EmpID！");
            #endregion
            #region 获取实体
            rst = this.Select<HR_EmployeeResult>(GetWhereClip(param));
            //rst.Password = EncrypHandler.Decrypto(rst.Password);
            #endregion
            #region 获取登录的信息
            SYS_UserAccountResult userAccount = new SYS_UserAccountResult();
            if (rst != null && rst.EmpID > 0)
            {
                userAccount = this.Select<SYS_UserAccountResult>(SYS_UserAccount._.EmpID == rst.EmpID && SYS_UserAccount._.GCompanyID==this.SessionInfo.CompanyID  && SYS_UserAccount._.IsDeleted == false);
                if (userAccount != null)
                {
                    rst.NeedValidate = userAccount.NeedValidate;
                    rst.UseTimeBegin = userAccount.UseTimeBegin;
                    rst.UseTimeOver = userAccount.UseTimeOver;
                    rst.MacAddress = userAccount.MacAddress;
                    rst.HardDiskSN = userAccount.HardDiskSN;
                    rst.SignInTimes = userAccount.SignInTimes;
                    rst.LastSignTime = userAccount.LastSignTime;
                    rst.LastSignIP = userAccount.LastSignIP;
                    rst.AfterTimeForBill = userAccount.AfterTimeForBill;
                }
            }
            #endregion
            return rst;
        }

        /// <summary>
        /// 获取人员，部门，机构信息
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public PageList<HR_EmployeeResult> GetPageList(HR_EmployeeParam param)
        {
            this.CheckSession();
            PageList<HR_EmployeeResult> pagelist = new PageList<HR_EmployeeResult>();
            try
            {
                WhereClip whereClip = GetWhereClip(param);
                if (!string.IsNullOrEmpty(param.DeptName)) whereClip = whereClip && HR_Department._.DeptName.At("b") == param.DeptName;
                if (!string.IsNullOrEmpty(param.OrgName)) whereClip = whereClip && HR_Org._.OrgName.At("c") == param.OrgName;

                List<Field> fiels = new List<Field>(){
                  HR_Employee._.EmpID,
                  HR_Employee._.EmpName,
                  HR_Employee._.EmpCode,
                  HR_Department._.DeptID.At("b"),
                  HR_Department._.DeptName.At("b"),
                  HR_Department._.DeptNo.At("b"),
                  HR_Org._.OrgID.At("c"),
                  HR_Org._.OrgNo.At("c"),
                  HR_Org._.OrgName.At("c")
               };
                WhereClip onWhereClip1 = HR_Employee._.DeptID == HR_Department._.DeptID.At("b");
                WhereClip onWhereClip2 = HR_Org._.OrgID.At("b") == HR_Department._.OrgID.At("c");
                pagelist = this.SelectList<HR_EmployeeResult, HR_Department, HR_Org>(JoinType.InnerJoin, onWhereClip1,JoinType.InnerJoin,onWhereClip2, param.PageIndex.GetValueOrDefault(1), param.PageSize.GetValueOrDefault(100), fiels, whereClip, HR_Employee._.EmpName.Asc, null, null);


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
            return pagelist;
        }

        /// <summary>
        /// 获取集合
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public List<HR_EmployeeResult> GetEmpList(HR_EmployeeParam param)
        {
            this.CheckSession();
            List<HR_EmployeeResult> ret = new List<HR_EmployeeResult>();
            try
            {
                WhereClip whereClip = GetWhereClip(param);
                ret = this.SelectList<HR_EmployeeResult>(whereClip, HR_EmployeeResult._.EmpName.Asc);
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
        /// 获取员工信息列表(返回员工主要字段名称)
        /// </summary>
        /// <param name="param">条件参数</param>
        /// <returns></returns>
        public List<HR_EmployeeResult> GetEmpMainInfoList(HR_EmployeeParam param)
        {
            this.CheckSession();
            List<HR_EmployeeResult> ret = new List<HR_EmployeeResult>();
            try
            {
                WhereClip whereClip = GetWhereClip(param);
                List<Field> lstField = new List<Field>() { HR_Employee._.EmpID, HR_Employee._.EmpCode, HR_Employee._.EmpName, HR_Employee._.PositionID };
                ret = this.SelectList<HR_EmployeeResult>(whereClip, HR_EmployeeResult._.EmpName.Asc);
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
        /// 删除实体
        /// </summary>
        /// <param name="param">删除条件实体</param>
        /// <returns></returns>
        public WCFAddUpdateResult DelInfo(HR_EmployeeParam param)
        {
            this.CheckSession();
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            int affect = 0;
            try
            {
                #region 判断
                if (param.EmpGuid == null) throw new WarnException("请指定要删除的记录！");
                #endregion
                HR_EmployeeResult info = new HR_EmployeeResult();
                info = this.Select<HR_EmployeeResult>(new List<Field>() { HR_Employee._.EmpID }, HR_Employee._.IsDeleted == false && HR_Employee._.EmpGuid == param.EmpGuid);
                if (info == null) { throw new WarnException("未找到员工信息"); }
                if (this.Count<ORD_SalesOrder>((ORD_SalesOrder._.SalerID == info.EmpID || ORD_SalesOrder._.CreatedEmpID == info.EmpID) && ORD_SalesOrder._.IsDeleted == false) > 0
                    || this.Count<ORD_PurchaseOrder>((ORD_PurchaseOrder._.BuyerID == info.EmpID || ORD_PurchaseOrder._.CreatedEmpID == info.EmpID) && ORD_PurchaseOrder._.IsDeleted == false) > 0)
                    throw new WarnException("存在业务引用，不允许删除！");
                WhereClip where = GetWhereClip(param);
                info = new HR_EmployeeResult();
                info.IsDeleted = true;
                affect = this.Update<HR_EmployeeResult>(info, where);
                this.Update<SYS_UserAccount>(new SYS_UserAccount() { IsDeleted = true }, SYS_UserAccount._.EmpID == info.EmpID && SYS_UserAccount._.GCompanyID==this.SessionInfo.CompanyID && SYS_UserAccount._.IsDeleted == false);
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
