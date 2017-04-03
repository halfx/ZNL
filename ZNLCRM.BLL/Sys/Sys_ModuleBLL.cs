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
    public class Sys_ModuleBLL : BaseBLL
    {

        public List<Sys_ModuleResult> GetModuleList(Sys_ModuleParam param)
        {
            this.CheckSession();
            List<Sys_ModuleResult> ret = new List<Sys_ModuleResult>();
            try
            {
                WhereClip whereClip = GetWhereClip(param);
                List<Field> lstField = new List<Field>()
                {
                    Sys_Module._.MenuID,
                    Sys_Module._.ModuleCode,
                    Sys_Module._.ModuleID,
                    Sys_Module._.ModuleName,
                    Sys_Module._.ActionCode
                };
                ret = this.SelectList<Sys_ModuleResult>(whereClip, Sys_Module._.ModuleCode.Desc);
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
        public PageList<Sys_ModuleResult> GetPageList(Sys_ModuleParam param)
        {
            this.CheckSession();
            PageList<Sys_ModuleResult> ret = new PageList<Sys_ModuleResult>();
            try
            {
                WhereClip whereClip = GetWhereClip(param);
                List<Field> lstField = new List<Field>()
                {
                    Sys_Module._.MenuID,Sys_Module._.ModuleCode,Sys_Module._.ModuleID
                    ,Sys_Module._.ModuleName,Sys_Module._.ActionCode
                };
                ret = this.SelectList<Sys_ModuleResult>(param.PageIndex.GetValueOrDefault(1), param.PageSize.GetValueOrDefault(20), lstField, whereClip, Sys_Module._.ModuleCode.Desc);
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

        WhereClip GetWhereClip(Sys_ModuleParam param)
        {
            this.CheckSession();
            WhereClip where = Sys_Module._.IsDeleted == 0;
            if (param.ModuleID > 0) where = where && Sys_Module._.ModuleID == param.ModuleID;
            if (param.MenuID > 0) where = where && Sys_Module._.MenuID == param.MenuID;
            if (param.ModuleCode != null) where = where && Sys_Module._.ModuleCode.Like(param.ModuleCode + "%");
            if (param.ModuleName != null) where = where && Sys_Module._.ModuleName.Like("%" + param.ModuleName + "%");
            if (param.ModuleIDs != null && param.ModuleIDs.Length > 0) where = where && Sys_Module._.ModuleID.In(param.ModuleIDs);
            if (param.NotModuleIDs != null && param.NotModuleIDs.Length > 0) where = where && !Sys_Module._.ModuleID.In(param.NotModuleIDs);
            return where;
        }

        /// <summary>
        /// 添加和新增修改
        /// </summary>
        /// <param name="param">新增或修改的实体</param>
        /// <returns></returns>
        public WCFAddUpdateResult AddOrUpdate(Sys_ModuleResult param)
        {
            this.CheckSession();
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            try
            {
                int affect = 0;
                #region 判断
                if (param.ModuleName.ToStringHasNull().Trim() == "") throw new WarnException("请指定菜单名称!");
                if (param.MenuID.ToInt32() < 0) throw new WarnException("请指定所属菜单!");
                if (param.TargetForm.ToStringHasNull().Trim() == "") throw new WarnException("请指定所属目标体窗!");

                string parentCode = "";
                Sys_MenuResult menuRst = new Sys_MenuResult();
                menuRst = this.Select<Sys_MenuResult>(Sys_Menu._.MenuID == param.MenuID);
                if (param.MenuID > 0 && (menuRst == null || menuRst.MenuCode == ""))
                {
                    throw new WarnException("菜单编号的所属菜单不存在!");
                }
                parentCode = menuRst.MenuCode;
                #endregion
                #region 生成模块编号
                int maxModuleNum = 1;
                maxModuleNum = this.Count<Sys_ModuleResult>(Sys_Module._.MenuID == param.MenuID) + 1;
                #endregion
                #region 判断重复
                WhereClip whereChk = Sys_Module._.IsDeleted == false && Sys_Module._.ModuleName == param.ModuleName;
                if (param.ModuleID > 0) whereChk = whereChk & Sys_Module._.ModuleID != param.ModuleID;
                int chkNum = this.Count<Sys_ModuleResult>(whereChk);
                if (chkNum > 0) throw new WarnException("存在重复的模块名称!");
                #endregion
                #region 系统默认值
                if (param.ModuleID > 0)
                {
                    if (!param.ModuleCode.StartsWith(parentCode))
                    {
                        param.ModuleCode = parentCode + maxModuleNum.ToString().PadLeft(3, '0');
                    }
                    WhereClip where = Sys_Module._.ModuleID == param.ModuleID;
                    affect = this.Update<Sys_ModuleResult>(param, where);
                }
                else
                {
                    Sys_ModuleResult codeRulerBll = new Sys_ModuleResult();
                    param.ModuleCode = parentCode + maxModuleNum.ToString().PadLeft(3, '0');
                    param.IsDeleted = false;
                    affect = this.Insert<Sys_ModuleResult>(param);
                    param = this.Select<Sys_ModuleResult>(new List<Field>() { Sys_Module._.ModuleID }, Sys_Module._.ModuleCode == param.ModuleCode);
                }
                #region 设置返回值
                ret.Key = param.ModuleID;
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
            }
            return ret;
        }
        /// <summary>
        /// 获取一条信息记录
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public Sys_ModuleResult GetInfo(Sys_ModuleParam param)
        {
            this.CheckSession();
            Sys_ModuleResult rst = new Sys_ModuleResult();
            #region 判断
            if (param.ModuleID.ToInt32() <= 0) throw new WarnException("请指定ID！");
            #endregion
            #region 保存实体
            WhereClip where = Sys_Module._.ModuleID == param.ModuleID;
            rst = this.Select<Sys_ModuleResult>(where);
            #region 父级菜单
            if (rst.ModuleCode.ToStringHasNull().Length > 3)
            {
                string parentCode = rst.ModuleCode.Substring(0, rst.ModuleCode.Length - 3);
                Sys_MenuResult parMenu = this.Select<Sys_MenuResult>(new List<Field>() { Sys_Menu._.MenuName }
                                                                    , Sys_Menu._.MenuCode == parentCode);
                if (parMenu != null) rst.ParentMenuName = parMenu.MenuName;
            }
            #endregion
            #endregion
            return rst;
        }

        /// <summary>
        /// 删除实体
        /// </summary>
        /// <param name="param">删除条件实体</param>
        /// <returns></returns>
        public WCFAddUpdateResult DelInfo(Sys_ModuleParam param)
        {
            this.CheckSession();
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            int affect = 0;
            try
            {
                #region 判断
                if (param.ModuleID.ToInt32() <= 0) throw new WarnException("请指定要删除的模块ID！");
                #endregion
                #region 删除关联性,暂未加上

                #endregion
                WhereClip where = GetWhereClip(param);
                Sys_ModuleResult info = new Sys_ModuleResult();
                info.IsDeleted = true;
                affect = this.Update<Sys_ModuleResult>(info, where);
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
