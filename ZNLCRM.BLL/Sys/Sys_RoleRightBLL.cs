using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using MySoft.Data;
using ZNLCRM.Entity.DBModel;
using ZNLCRM.Entity.UserModel.Common;
using ZNLCRM.Entity.UserModel.Sys;
using ZNLCRM.Utility;
using ZNLFrame.Entity;

namespace ZNLCRM.BLL.Sys
{
    internal class Sys_RoleRightBLL : BaseBLL
    {
        public PageList<Sys_RoleRightResult> GetRoleRightList(Sys_RoleRightParam param)
        {
            this.CheckSession();
            PageList<Sys_RoleRightResult> pagelist = new PageList<Sys_RoleRightResult>();
            WhereClip whereClip = Sys_RoleRight._.IsDeleted == 0 && Sys_Module._.IsDeleted.At("b") == 0;
            WhereClip onWhereClip = Sys_RoleRight._.ModuleID == Sys_Module._.ModuleID.At("b");
            if (!string.IsNullOrEmpty(param.ModuleName))
            {
                whereClip = whereClip && Sys_Module._.ModuleName.At("b").Like("%" + param.ModuleName + "%");
            }
            if (!string.IsNullOrEmpty(param.MenuCode))
            {
                WhereClip whereClipOr = WhereClip.All;
                string[] arrMenuCode=param.MenuCode.Split(',');
                foreach (string s in arrMenuCode)
                {
                    whereClipOr = whereClipOr && Sys_Module._.ModuleCode.At("b").Like(param.MenuCode + "%");
                }
                if (arrMenuCode.Length > 0)
                {
                    whereClip = whereClip && (whereClipOr);
                }
            }
            List<Field> fields = new List<Field>
            {
                Sys_RoleRight._.RoleRightID,
                Sys_RoleRight._.RoleID,
                Sys_RoleRight._.ModuleID,
                Sys_RoleRight._.GCompanyID,
                Sys_RoleRight._.ActionCode,
                Sys_Module._.ModuleName.At("b"),
                Sys_Module._.ActionCode.At("b").As("BaseActionCode")
            };
            if (param.RoleID>0) whereClip = whereClip && Sys_RoleRight._.RoleID == param.RoleID;
            pagelist = this.SelectList<Sys_RoleRightResult, Sys_Module>(JoinType.InnerJoin, onWhereClip, param.PageIndex.GetValueOrDefault(1).ToInt32(), param.PageSize.GetValueOrDefault(50).ToInt32(),
                fields, whereClip, null, null, null);
            pagelist.ResultJoinList.Columns.Add("RightName");
            return pagelist;
        }

        /// <summary>
        /// 批量修改和插入
        /// </summary>
        /// <param name="paramList"></param>
        /// <returns></returns>
        public WCFAddUpdateResult UpdateOrInsertList(List<Sys_RoleRightResult> list)
        {
            this.CheckSession();
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            try
            {
                #region 判断
                if (list.Count <= 0) throw new WarnException("没有需要保存的对象！");
                #endregion
                int affect = 0;
                foreach (Sys_RoleRightResult info in list)
                {
                    info.GCompanyID = this.SessionInfo.CompanyID;
                    if (info.IsDeleted == null) info.IsDeleted = false;
                }
                affect += this.BatchInsertOrUpdate<Sys_RoleRightResult>(list);
                this.BatchExecute();
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
        ///     添加和新增修改
        /// </summary>
        /// <param name="param">新增或修改的实体</param>
        /// <returns></returns>
        public WCFAddUpdateResult AddOrUpdate(Sys_RoleRightResult param)
        {
            CheckSession();
            var ret = new WCFAddUpdateResult();
            try
            {
                #region 判断

                if (param.ActionCode.ToStringHasNull().Trim() == "") throw new WarnException("请指定权限ActionCode!");
                if (param.RoleRightID < 0)
                {
                    throw new WarnException("请指定权限RoleRightID!");
                }

                var rolesResult = Select<Sys_RoleRightResult>(Sys_RoleRight._.RoleRightID == param.RoleRightID);
                if (param.RoleRightID > 0 && (rolesResult == null || rolesResult.ActionCode == ""))
                {
                    throw new WarnException("权限不存在!");
                }

                #endregion

                #region 判断重复

                WhereClip whereChk = Sys_RoleRight._.RoleRightID != -1 &&
                    Sys_RoleRight._.RoleID == param.RoleID && Sys_RoleRight._.ModuleID == param.ModuleID && 
                    Sys_RoleRight._.IsDeleted == param.IsDeleted;
                if (param.RoleRightID > 0) whereChk = whereChk & Sys_RoleRight._.RoleRightID != param.RoleRightID;
                int chkNum = Count<Sys_RoleRightResult>(whereChk);
                if (chkNum > 0) throw new WarnException("存在重复的模块权限!");

                #endregion

                #region 系统默认值

                if (param.RoleRightID > 0)
                {
                    WhereClip where = Sys_RoleRight._.RoleRightID == param.RoleRightID;
                    Update(param, @where);
                }
                else
                {
                    // var roleResult = new Sys_RoleRightResult();
                    Insert(param);
                    param = Select<Sys_RoleRightResult>(new List<Field> { Sys_RoleRight._.RoleRightID },
                        Sys_RoleRight._.ActionCode == param.ActionCode);
                }

                #region 设置返回值

                ret.Key = param.RoleRightID;

                #endregion

                #endregion
            }
            catch (WarnException)
            {
                throw;
            }
            catch (Exception exp)
            {
                LogInfoBLL.WriteLog(SessionInfo, exp);
            }
            return ret;
        }

        /// <summary>
        ///     获取一条角色信息记录
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public Sys_RoleRightResult GetInfo(Sys_RoleRightParam param)
        {
            CheckSession();

            #region 判断

            if (param.RoleRightID.ToInt32() <= 0) throw new WarnException("请指定ID！");

            #endregion

            #region 保存实体

            WhereClip where = Sys_RoleRight._.RoleRightID == param.RoleRightID;
            // if (param.ActionCode != null) where = where && Sys_RoleRight._.ActionCode.Like("%" + param.ActionCode + "%");
            var rst = Select<Sys_RoleRightResult>(@where);

            #endregion

            return rst;
        }

        /// <summary>
        ///     删除角色
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public WCFAddUpdateResult DelInfo(Sys_RoleRightParam param)
        {
            CheckSession();
            var ret = new WCFAddUpdateResult();
            try
            {
                #region 判断

                if (param.RoleRightID.ToInt32() <= 0) throw new WarnException("请指定要删除的权限ID！");

                #endregion

                WhereClip where = GetWhereClip(param);
                var info = new Sys_RoleRightResult { IsDeleted = true };
                var affect = Update(info, @where);

                #region 设置返回值

                ret.Key = affect;

                #endregion
            }
            catch (WarnException)
            {
                throw;
            }
            catch (Exception exp)
            {
                LogInfoBLL.WriteLog(SessionInfo, exp);
            }
            return ret;
        }

        private WhereClip GetWhereClip(Sys_RoleRightParam param)
        {
            CheckSession();
            WhereClip where = Sys_RoleRight._.IsDeleted == 0;
            if (param.RoleRightID > 0) where = where && Sys_RoleRight._.RoleRightID == param.RoleRightID;
            if (param.GCompanyID != Guid.Empty) where = where && Sys_RoleRight._.GCompanyID == param.GCompanyID;
            if (param.RoleID > 0) where = where && Sys_RoleRight._.RoleID == param.RoleID;
            if (param.ModuleID > 0) where = where && Sys_RoleRight._.RoleID == param.ModuleID;
            if (param.ActionCode != null) where = where && Sys_RoleRight._.ActionCode.Like("%" + param.ActionCode + "%");
            return where;
        }
    }
}
