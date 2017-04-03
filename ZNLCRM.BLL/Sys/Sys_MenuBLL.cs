using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLCRM.Entity.UserModel.Sys;
using MySoft.Data;
using ZNLCRM.Entity.DBModel;
using ZNLCRM.Entity.UserModel.Common;
using ZNLFrame.Entity;
using ZNLCRM.Utility;
using System.Data;

namespace ZNLCRM.BLL.Sys
{
    class Sys_MenuBLL : BaseBLL
    {
        public List<Sys_MenuResult> GetMenuTree(Sys_MenuParam param)
        {
            this.CheckSession();
            List<Sys_MenuResult> ret = new List<Sys_MenuResult>();
            try
            {
                WhereClip whereClip = GetWhereClip(param);
                ret = this.SelectList<Sys_MenuResult>(whereClip, Sys_MenuResult._.MenuCode.Asc);
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

        public List<Sys_MenuResult> GetEmpMenuTree(Sys_MenuParam param)
        {
            this.CheckSession();
            List<Sys_MenuResult> allRet = new List<Sys_MenuResult>();
            List<Sys_MenuResult> ret = new List<Sys_MenuResult>();
            List<int?> arrHasModuleIDs = new List<int?>();
            try
            {
                //Sys_Module._.OrderSeq.At("b"), Sys_Module._.ActionCode.At("b"), Sys_Module._.ModuleCode.At("b"), Sys_Module._.ModuleName.At("b"), Sys_Module._.TargetForm.At("b"), Sys_Module._.ModuleID.At("b")
                #region 获取对应员工角色与权限
                List<Sys_RoleRight> roleRightList = new List<Sys_RoleRight>();
                Sys_EmpDataRight formRight = this.Select<Sys_EmpDataRight>(Sys_EmpDataRight._.EmpID == this.SessionInfo.UserID && Sys_EmpDataRight._.IsDeleted == false && Sys_EmpDataRight._.GCompanyID == this.SessionInfo.CompanyID);
                if (formRight != null)
                {
                    int?[] arrRightID = formRight.RoleIDs.Split(',').Where(a=>a.ToStringHasNull().Trim()!="").Select(a => (int?)a.ToInt32()).ToArray();
                    if(arrRightID.Length>0)
                    {
                        roleRightList = this.SelectList<Sys_RoleRight>(Sys_RoleRight._.RoleID.In(arrRightID) && Sys_RoleRight._.IsDeleted == false);
                        arrHasModuleIDs.AddRange(roleRightList.Select(a => a.ModuleID).Distinct().ToList());
                    }
                }
                #endregion
                #region 获取对应员工个人权限
                List<Sys_EmpRight> lstEmpRight = new List<Sys_EmpRight>();
                lstEmpRight = this.SelectList<Sys_EmpRight>(Sys_EmpRight._.EmpID == this.SessionInfo.UserID && Sys_EmpRight._.IsDeleted == false);
                arrHasModuleIDs.AddRange(lstEmpRight.Select(a => a.ModuleID).Distinct().ToList());
                #endregion
                #region 获取菜单列表
                List<Sys_Module> lstModule = new List<Sys_Module>();
                WhereClip whereModule = Sys_Module._.IsDeleted == false;
                if (lstEmpRight.Count > 0)
                {
                    whereModule = whereModule && Sys_Module._.ModuleID.In(lstEmpRight.ToArray());
                }
                lstModule = this.SelectList<Sys_Module>(whereModule);
                List<string> lstEmpMdlCode = lstModule.Where(a => a.ModuleCode.ToStringHasNull() != "").Select(a => a.ModuleCode.ToStringHasNull().Trim()).ToList();
                ret = this.SelectList<Sys_MenuResult>(Sys_Menu._.IsDeleted == false, Sys_Menu._.MenuCode.Asc);
                ret = ret.Where(a => !lstEmpMdlCode.Contains(a.MenuCode)).ToList();
                foreach (Sys_Module info in lstModule)
                {
                    ret.Add(new Sys_MenuResult()
                    {
                        MenuID = info.ModuleID * -1,
                        MenuCode = info.ModuleCode,
                        MenuName = info.ModuleName,
                        TargetForm = info.TargetForm,
                        OrderSeq = info.OrderSeq,
                        MenuType = "Leaf"
                    });
                }
                #endregion
                #region old code
                //GroupByClip groupByClip = new GroupByClip("b.OrderSeq,b.ActionCode,b.ModuleCode,b.ModuleName,b.TargetForm,b.ModuleID");
                //DataTable lstEmpModeule = this.SelectList<Sys_EmpRight, Sys_Module>(JoinType.InnerJoin
                //                , Sys_EmpRight._.ModuleID == Sys_Module._.ModuleID.At("b")
                //                  , 1, int.MaxValue
                //                  , new List<Field>() {Sys_Module._.OrderSeq.At("b"), Sys_Module._.ActionCode.At("b"), Sys_Module._.ModuleCode.At("b"), Sys_Module._.ModuleName.At("b"), Sys_Module._.TargetForm.At("b"), Sys_Module._.ModuleID.At("b") },
                //                  Sys_EmpRight._.EmpID == this.SessionInfo.UserID && Sys_EmpRight._.IsDeleted == false
                //                  , Sys_Module._.ModuleCode.At("b").Asc, groupByClip, null).ResultJoinList;
                //List<string> lstEmpMdlCode = lstEmpModeule.Select("ModuleCode<>''").Select(a => a["ModuleCode"].ToStringHasNull()).ToList();
                //ret = this.SelectList<Sys_MenuResult>(Sys_Menu._.IsDeleted == false, Sys_Menu._.MenuCode.Asc);
                //ret = ret.Where(a => !lstEmpMdlCode.Contains(a.MenuCode)).ToList();
                //#region 将模块添加至菜单集合
                //foreach (DataRow row in lstEmpModeule.Rows)
                //{
                //    ret.Add(new Sys_MenuResult()
                //    {
                //        MenuID = row["ModuleID"].ToInt32() * -1,
                //        MenuCode = row["ModuleCode"].ToStringHasNull(),
                //        MenuName = row["ModuleName"].ToStringHasNull(),
                //        TargetForm = row["TargetForm"].ToStringHasNull(),
                //        OrderSeq = row["OrderSeq"].ToInt32(),
                //        MenuType = "Leaf"
                //    });
                //}
                //#endregion
                #endregion
                #region 按指定的次序号重新排序
                List<Sys_MenuResult> newRet = new List<Sys_MenuResult>();
                int atIdx=0;
                for (int i = 3; i <= 3*5; i=i+3)
                {
                    newRet = ret.Where(a => a.MenuCode.Length == i).OrderBy(a => a.OrderSeq).ToList();
                    if (i > 3)
                    {
                        foreach (Sys_MenuResult info in newRet)
                        {
                            atIdx = allRet.FindIndex(a => a.MenuCode.Length == i - 3 && info.MenuCode.StartsWith(a.MenuCode));
                            if (atIdx<0) continue;
                            allRet.Insert(atIdx + 1, info);
                        }
                    }
                    else allRet = ret.Where(a => a.MenuCode.Length == i).OrderBy(a => a.OrderSeq).ToList();
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
            return allRet;
        }


        WhereClip GetWhereClip(Sys_MenuParam param)
        {
            this.CheckSession();
            WhereClip where = Sys_Menu._.IsDeleted == 0;
            if (param.MenuID >0) where = where && Sys_Menu._.MenuID == param.MenuID;
            if (param.MenuCode != null) where = where && Sys_Menu._.MenuCode.Like("%"+param.MenuCode+"%");
            if (param.MenuName != null) where = where && Sys_Menu._.MenuName.Like("%" + param.MenuName + "%");
            return where;
        }

        /// <summary>
        /// 添加和新增修改
        /// </summary>
        /// <param name="param">新增或修改的实体</param>
        /// <returns></returns>
        public WCFAddUpdateResult AddOrUpdate(Sys_MenuResult param)
        {
            this.CheckSession();
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            try
            {
                int affect = 0;
                #region 判断
                if (param.MenuCode.ToStringHasNull().Trim() == "") throw new WarnException("请指定菜单编号！");
                if (param.MenuName.ToStringHasNull().Trim() == "") throw new WarnException("请指定菜单名称!");
                if (param.MenuType.ToStringHasNull().Trim() == "") throw new WarnException("请指定菜单类型!");
                if (param.MenuCode.Length % 3 > 0) throw new WarnException("请菜单编号为三位迭加!");
                string parentCode="";
                if(param.MenuCode.Length>3)
                    parentCode=param.MenuCode.Substring(0,param.MenuCode.Length-3);
                if (parentCode!="" && this.Count<Sys_MenuResult>(Sys_Menu._.MenuCode == parentCode) < 0)
                {
                    throw new WarnException("菜单编号的父菜单不存在!");
                }
                #endregion
                #region 判断重复
                WhereClip whereChk = Sys_Menu._.IsDeleted==false && Sys_Menu._.MenuCode==param.MenuCode;
                if(param.MenuID>0)whereChk=whereChk&Sys_Menu._.MenuID!=param.MenuID;
                int chkNum= this.Count<Sys_MenuResult>(whereChk);
                if (chkNum > 0) throw new WarnException("存在重复的菜单编号!");
                #endregion
                #region 系统默认值
                if (param.MenuID >0)
                {
                    WhereClip where = Sys_Menu._.MenuID == param.MenuID;
                    affect = this.Update<Sys_MenuResult>(param, where);
                }
                else
                {
                    Sys_MenuResult codeRulerBll = new Sys_MenuResult();
                    param.IsDeleted = false;
                    affect = this.Insert<Sys_MenuResult>(param);
                    param = this.Select<Sys_MenuResult>(new List<Field>() { Sys_Menu._.MenuID }, Sys_Menu._.MenuCode == param.MenuCode);
                }
                #region 设置返回值
                ret.Key = param.MenuID;
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
        public Sys_MenuResult GetInfo(Sys_MenuParam param)
        {
            this.CheckSession();
            Sys_MenuResult rst = new Sys_MenuResult();
            #region 判断
            if (param.MenuID.ToInt32()<=0) throw new WarnException("请指定ID！");
            #endregion
            #region 保存实体
            WhereClip where = Sys_Menu._.MenuID == param.MenuID;
            rst = this.Select<Sys_MenuResult>(where);
            #region 父级菜单
            if (rst.MenuCode.ToStringHasNull().Length > 3)
            {
                string parentCode = rst.MenuCode.Substring(0, rst.MenuCode.Length - 3);
                Sys_MenuResult parMenu = this.Select<Sys_MenuResult>(new List<Field>() { Sys_Menu._.MenuName }
                                                                    , Sys_Menu._.MenuCode == parentCode);
                if (parMenu != null) rst.ParentMenuName = parMenu.MenuName;
            }
            else rst.ParentMenuName = "顶级菜单";
            #endregion
            #endregion
            return rst;
        }

        /// <summary>
        /// 删除实体
        /// </summary>
        /// <param name="param">删除条件实体</param>
        /// <returns></returns>
        public WCFAddUpdateResult DelInfo(Sys_MenuParam param)
        {
            this.CheckSession();
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            int affect = 0;
            try
            {
                #region 判断
                if (param.MenuID.ToInt32() <= 0) throw new WarnException("请指定要删除的菜单ID！");
                #endregion
                #region 业务关联判断
                if (this.Count<Sys_Module>(Sys_Module._.MenuID == param.MenuID && Sys_Module._.IsDeleted == false) > 0)
                {
                    throw new WarnException("已发生业务关联！");
                }
                #endregion

                WhereClip where = GetWhereClip(param);
                Sys_MenuResult info = new Sys_MenuResult();
                info.IsDeleted = true;
                affect = this.Update<Sys_MenuResult>(info, where);
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
