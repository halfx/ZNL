using System;
using System.Collections.Generic;
using MySoft.Data;
using ZNLCRM.Entity.DBModel;
using ZNLCRM.Entity.UserModel.Common;
using ZNLCRM.Entity.UserModel.Sys;
using ZNLCRM.Utility;
using ZNLFrame.Entity;


namespace ZNLCRM.BLL.Sys
{
    internal class Sys_RolesBLL : BaseBLL
    {
        public List<Sys_RoleResult> GetRolesTree(Sys_RoleParam param)
        {
            CheckSession();
            var ret = new List<Sys_RoleResult>();
            try
            {
                WhereClip whereClip = GetWhereClip(param);
                ret = SelectList<Sys_RoleResult>(whereClip, Sys_Roles._.RoleName.Asc);
            }
            catch (WarnException exp)
            {
                throw exp;
            }
            catch (Exception exp)
            {
                LogInfoBLL.WriteLog(SessionInfo, exp);
                throw exp;
            }
            return ret;
        }

        private WhereClip GetWhereClip(Sys_RoleParam param)
        {
            CheckSession();
            WhereClip where = Sys_Roles._.IsDeleted == 0;
            if (param.RoleID > 0) where = where && Sys_Roles._.RoleID == param.RoleID;
            if (param.RoleName != null) where = where && Sys_Roles._.RoleName.Like("%" + param.RoleName + "%");
            return where;
        }

        /// <summary>
        ///     添加和新增修改
        /// </summary>
        /// <param name="param">新增或修改的实体</param>
        /// <returns></returns>
        public WCFAddUpdateResult AddOrUpdate(Sys_RoleResult param)
        {
            CheckSession();
            var ret = new WCFAddUpdateResult();
            try
            {
                #region 判断重复
                WhereClip whereChk = Sys_Roles._.RoleID != -1 && Sys_Roles._.RoleName == param.RoleName;
                if (param.RoleID > 0) whereChk = whereChk & Sys_Roles._.RoleID != param.RoleID;
                int chkNum = Count<Sys_RoleResult>(whereChk);
                if (chkNum > 0) throw new WarnException("存在重复的角色名称!");

                #endregion

                #region 系统默认值

                if (param.RoleID > 0)
                {
                    WhereClip where = Sys_Roles._.RoleID == param.RoleID;
                    Update(param, @where);
                }
                else
                {
                    param.IsDeleted = false;
                    param.GCompanyID = this.SessionInfo.CompanyID;
                    this.Insert(param);
                    param = Select<Sys_RoleResult>(new List<Field> {Sys_Roles._.RoleID},
                        Sys_Roles._.RoleName == param.RoleName);
                }

                #region 设置返回值

                ret.Key = param.RoleID;

                #endregion

                #endregion
            }
            catch (WarnException exp)
            {
                throw exp;
            }
            catch (Exception exp)
            {
                LogInfoBLL.WriteLog(SessionInfo, exp);
                throw exp;
            }
            return ret;
        }

        /// <summary>
        ///     获取一条角色信息记录
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public Sys_RoleResult GetInfo(Sys_RoleParam param)
        {
            CheckSession();

            #region 判断

            if (param.RoleID.ToInt32() <= 0) throw new WarnException("请指定ID！");

            #endregion

            #region 保存实体

            WhereClip where = Sys_Roles._.RoleID == param.RoleID;
            if (param.RoleName != null) where = where && Sys_Roles._.RoleName.Like("%" + param.RoleName + "%");
            Sys_RoleResult rst = Select<Sys_RoleResult>(@where);

            #endregion

            return rst;
        }

        /// <summary>
        ///     删除角色
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public WCFAddUpdateResult DelInfo(Sys_RoleParam param)
        {
            CheckSession();
            var ret = new WCFAddUpdateResult();
            try
            {
                #region 判断

                if (param.RoleID.ToInt32() <= 0) throw new WarnException("请指定要删除的模块ID！");
                if (this.Count<Sys_EmpDataRight>(Sys_EmpDataRight._.IsDeleted==false && Sys_EmpDataRight._.RoleIDs.Like("%," + param.RoleID.ToStringHasNull() + ",%")) >= 0)
                {
                    throw new WarnException("存在业务引用,不允许删除！");
                }
                if (this.Count<Sys_RoleRight>(Sys_RoleRight._.RoleID == param.RoleID && Sys_RoleRight._.IsDeleted==false) >= 0)
                {
                    throw new WarnException("存在业务引用,不允许删除！");
                }
                #endregion

                WhereClip where = GetWhereClip(param);
                var info = new Sys_RoleResult {IsDeleted = true};
                var affect = Update(info, @where);

                #region 设置返回值

                ret.Key = affect;

                #endregion
            }
            catch (WarnException exp)
            {
                throw exp;
            }
            catch (Exception exp)
            {
                LogInfoBLL.WriteLog(SessionInfo, exp);
                throw exp;
            }
            return ret;
        }
        /// <summary>
        /// 获取角色名称
        /// </summary>
        /// <returns></returns>
        public string GetRoleNames(int?[] roleIds)
        {
            string ret = "";
            //string[] arrRoleIds = roleIds.ToStringHasNull().Split(',');
            //List<int?> lstRoleIds = new List<int?>();
            //foreach (string s in arrRoleIds)
            //{
            //    if (s.ToStringHasNull().Trim() == "") continue;
            //    lstRoleIds.Add((int?)s.ToInt32());
            //}
            int?[] arrIRoleIds = roleIds;
            if (arrIRoleIds.Length <= 0) return "";
            WhereClip whereClip = Sys_Roles._.RoleID.In(arrIRoleIds) && Sys_Roles._.IsDeleted == false 
                                  && Sys_Roles._.GCompanyID==this.SessionInfo.CompanyID;
            List<Sys_RoleResult> lstRoleRst = new List<Sys_RoleResult>();
            lstRoleRst = this.SelectList<Sys_RoleResult>(new List<Field>() { Sys_Roles._.RoleName }, whereClip, Sys_Roles._.RoleName.Asc);
            foreach (Sys_RoleResult info in lstRoleRst)
            {
                if (ret != "") ret += ",";
                ret += info.RoleName;
            }
            return ret;
        }
    }
}