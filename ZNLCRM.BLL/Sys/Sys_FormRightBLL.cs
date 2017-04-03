using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLCRM.Entity.UserModel.Sys;
using MySoft.Data;
using ZNLCRM.Entity.DBModel;
using System.ComponentModel;
using ZNLCRM.Utility;
using ZNLFrame.Entity;
using ZNLCRM.Entity.UserModel.Common;
namespace ZNLCRM.BLL.Sys
{
    public class Sys_FormRightBLL : BaseBLL
    {
        public List<Sys_FormRightResult> GetEmpWindowRight(Sys_FormRightParam param)
        {
            #region 判断
            this.CheckSession();
            if (param.NameSpace.ToStringHasNull() == "") throw new WarningException("请指定命名空间!");
            if (param.FormEngName.ToStringHasNull() == "") throw new WarningException("请指定窗体名称!");
            #endregion
            #region 员工所拥有权限设置
            List<Sys_FormRightResult> ret = new List<Sys_FormRightResult>();
            WhereClip where = Sys_FormRight._.IsDeleted == false;
            List<Sys_EmpRight> lstEmpRight = new List<Sys_EmpRight>();
            lstEmpRight = this.SelectList<Sys_EmpRight>(Sys_EmpRight._.EmpID == this.SessionInfo.UserID && Sys_EmpRight._.GCompanyID == this.SessionInfo.CompanyID && Sys_EmpRight._.IsDeleted == false);
            #endregion
            #region 员工所在角色
            Sys_EmpDataRightBLL empDataRightBll = new Sys_EmpDataRightBLL();
            Sys_EmpDataRightResult empDataRightRst = new Sys_EmpDataRightResult();
            empDataRightBll.SessionInfo = this.SessionInfo;
            empDataRightRst = empDataRightBll.GetEmpDataRight(new Sys_EmpDataRightParam() { });
            string roleIDs = empDataRightRst.RoleIDs;
            List<Sys_RoleRightResult> roleRightList = new List<Sys_RoleRightResult>();
            Sys_RoleRightResult findRoleRight = new Sys_RoleRightResult();
            WhereClip whereClip = Sys_RoleRight._.IsDeleted == false;
            if (roleIDs.ToStringHasNull().Trim() != "")
            {
                int?[] arrRoleIds = roleIDs.Split(',').Where(a => a != "").Select(a => (int?)a.ToInt32()).ToArray();
                whereClip = whereClip && Sys_RoleRight._.RoleID.In(arrRoleIds);
                roleRightList = this.SelectList<Sys_RoleRightResult>(whereClip);
            }
            #endregion

            #region 窗体控件集合
            List<Sys_FormRightResult> lstForm = new List<Sys_FormRightResult>();
            ret = this.SelectList<Sys_FormRightResult>(Sys_FormRight._.NameSpace == param.NameSpace && Sys_FormRight._.FormEngName == param.FormEngName && Sys_FormRight._.IsDeleted == false);
            #endregion
            #region 判断窗体控件是否有权限
            string[] arrActionForm = new string[] { };
            bool existRight = false;
            foreach (Sys_FormRightResult info in ret)
            {
                #region 判断是否拥有权限
                arrActionForm = info.ActionCode.ToStringHasNull().Split(',');
                if (arrActionForm.Length <= 0) info.PropertyValue = false;
                else
                {
                    existRight = false;
                    foreach (string s in arrActionForm)
                    {
                        if (lstEmpRight.Exists(a => a.ActionCode.ToStringHasNull().Split(',').Contains(s) && a.ModuleID == info.ModuleID)
                            || roleRightList.Exists(a => a.ActionCode.ToStringHasNull().Split(',').Contains(s) && a.ModuleID == info.ModuleID))
                        {
                            existRight = true;
                            break;
                        }
                    }
                    info.PropertyValue = existRight;
                }
                #endregion
            }
            #endregion

            return ret;
        }

        public List<Sys_FormRightResult> GetRightTree(Sys_FormRightParam param)
        {
            this.CheckSession();
            PageList<Sys_FormRightResult> ret = new PageList<Sys_FormRightResult>();
            List<Field> lstField = new List<Field>()
            {
                Sys_FormRight._.NameSpace
            };
            try
            {
                WhereClip whereClip = GetWhereClip(param);
                ret = this.SelectList<Sys_FormRightResult>(param.PageIndex.GetValueOrDefault(1), int.MaxValue, lstField, whereClip, Sys_FormRightResult._.NameSpace.Asc, Sys_FormRight._.NameSpace.Group, null);
            }
            catch (WarnException exp)
            {
                throw exp;
            }
            catch (System.Exception exp)
            {
                LogInfoBLL.WriteLog(this.SessionInfo, exp);
            }
            return ret.ResultList;
        }
        WhereClip GetWhereClip(Sys_FormRightParam param)
        {
            this.CheckSession();
            WhereClip where = Sys_FormRight._.IsDeleted == 0;
            if (param.FormRightID > 0) where = where && Sys_FormRight._.FormRightID == param.FormRightID;
            if (param.NameSpace != null) where = where && Sys_FormRight._.NameSpace.Like("%" + param.NameSpace + "%");
            if (param.FormEngName != null) where = where && Sys_FormRight._.FormEngName.Like("%" + param.FormEngName + "%");
            if (param.OprControlEngName != null) where = where && Sys_FormRight._.OprControlEngName.Like("%" + param.OprControlEngName + "%");
            return where;
        }

        public PageList<Sys_FormRightResult> GetPageList(Sys_FormRightParam param)
        {
            this.CheckSession();
            PageList<Sys_FormRightResult> rst = new PageList<Sys_FormRightResult>();
            try
            {
                #region 获取分页列表
                WhereClip where = GetWhereClip(param);
                List<Field> lstField = new List<Field>()
                {
                    Sys_FormRight._.FormRightID,Sys_FormRight._.NameSpace,Sys_FormRight._.FormEngName,
                    Sys_FormRight._.FormChsName,Sys_FormRight._.UserControlEngName,Sys_FormRight._.UserControlChsName,
                    Sys_FormRight._.OprControlEngName,Sys_FormRight._.OprControlChsName,Sys_FormRight._.OprPropertyName,
                    Sys_FormRight._.ModuleID, Sys_FormRight._.ActionCode,Sys_FormRight._.IsDeleted
                };
                rst = this.SelectList<Sys_FormRightResult>(param.PageIndex.GetValueOrDefault(1), param.PageSize.GetValueOrDefault(20), lstField, where, Sys_FormRight._.NameSpace.Desc);
                #endregion
                #region 单据对应模块名称
                if (rst != null && rst.ResultList != null)
                {
                    Sys_ModuleBLL moduleBll = new Sys_ModuleBLL();
                    int?[] arrModuleID = rst.ResultList.Select(a => a.ModuleID).Distinct().ToArray();
                    moduleBll.SessionInfo = this.SessionInfo;
                    List<Sys_ModuleResult> moduleList = new List<Sys_ModuleResult>();
                    if (arrModuleID.Length > 0)
                    {
                        moduleList = moduleBll.GetPageList(new Sys_ModuleParam() { PageIndex = 1, PageSize = arrModuleID.Length, ModuleIDs = arrModuleID }).ResultList;
                    }
                    Sys_ModuleResult findModule = new Sys_ModuleResult();
                    foreach (Sys_FormRightResult info in rst.ResultList)
                    {
                        findModule = moduleList.Find(a => a.ModuleID == info.ModuleID);
                        if (findModule != null)
                            info.ModuleName = findModule == null ? "" : findModule.ModuleName;
                    }
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
            }
            return rst;
        }
        public Sys_FormRightResult GetInfo(Sys_FormRightParam param)
        {
            this.CheckSession();
            Sys_FormRightResult rst = new Sys_FormRightResult();
            try
            {
                #region 判断
                if (param.FormRightID <= 0) throw new WarnException("请指定关键字GUID！");
                #endregion
                #region 保存实体
                WhereClip where = Sys_FormRight._.FormRightID == param.FormRightID;
                rst = this.Select<Sys_FormRightResult>(where);
                if (rst != null)
                {
                    Sys_ModuleBLL moduleBll = new Sys_ModuleBLL();
                    moduleBll.SessionInfo = this.SessionInfo;
                    Sys_ModuleResult moduleRst = moduleBll.GetInfo(new Sys_ModuleParam() { ModuleID = rst.ModuleID.ToInt32() });
                    rst.ModuleName = moduleRst == null ? "" : moduleRst.ModuleName;
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
            }
            return rst;
        }
        public WCFAddUpdateResult AddOrUpdate(Sys_FormRightResult param)
        {
            this.CheckSession();
            int affect = 0;
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            try
            {
                #region 判断
                if (param.FormEngName.ToStringHasNull().Trim() == "") throw new WarnException("请指定窗体英文名！");
                //if (param.UserControlEngName.ToStringHasNull().Trim() == "") throw new WarnException("请指定用户控件英文名！");
                if (param.OprControlEngName.ToStringHasNull().Trim() == "") throw new WarnException("请指定操作控件英文名！");
                if (param.ActionCode.ToStringHasNull().Trim() == "") throw new WarnException("请指定对应权限！");
                if (param.FormRightID > 0)
                {
                    WhereClip where = Sys_FormRightResult._.FormRightID == param.FormRightID;
                    affect = this.Update<Sys_FormRightResult>(param, where);
                    ret.Key = param.FormRightID;
                }
                else
                {
                    Sys_FormRightBLL formrightbll = new Sys_FormRightBLL();
                    formrightbll.SessionInfo = this.SessionInfo;
                    param.IsDeleted = false;
                    affect = this.Insert<Sys_FormRightResult>(param);
                    ret.Key = this.Select<Sys_FormRightResult>(Sys_FormRight._.NameSpace == param.NameSpace && Sys_FormRight._.OprControlEngName == param.OprControlEngName && Sys_FormRight._.IsDeleted == false).FormRightID;
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
            }

            return ret;
        }
        public WCFAddUpdateResult DelInfo(Sys_FormRightParam param)
        {
            this.CheckSession();
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            int affect = 0;
            try
            {
                #region 判断
                if (param.FormRightID <= 0) throw new WarnException("请指定要删除的记录！");
                #endregion
                WhereClip where = Sys_FormRightResult._.FormRightID == param.FormRightID;
                Sys_FormRightResult oldInfo = this.GetInfo(param);
                Sys_FormRightResult info = new Sys_FormRightResult();
                info.IsDeleted = true;
                affect = this.Update<Sys_FormRightResult>(info, where);
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

