using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLCRM.Entity.UserModel.Sys;
using MySoft.Data;
using ZNLCRM.Entity.DBModel;
using ZNLCRM.Utility;
using ZNLFrame.Entity;

namespace ZNLCRM.BLL.Sys
{
    /// <summary>
    /// 员工权限业务层
    /// </summary>
    public class Sys_EmpRightBLL : BaseBLL
    {

        WhereClip GetWhereClip(Sys_EmpRightParam param)
        {
            this.CheckSession();
            WhereClip where = Sys_EmpRight._.IsDeleted == false;
            if (param.EmpRightID > 0) where = where && Sys_EmpRight._.EmpRightID == param.EmpRightID;
            if (param.EmpID > 0) where = where && Sys_EmpRight._.EmpID == param.EmpID;
            if (param.ModuleID > 0) where = where && Sys_EmpRight._.ModuleID == param.ModuleID;
            return where;
        }

        /// <summary>
        /// 获取员工的操作权限
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public PageList<Sys_EmpRightResult> GetPageList(Sys_EmpRightParam param)
        {
            this.CheckSession();
            PageList<Sys_EmpRightResult> pagelist = new PageList<Sys_EmpRightResult>();
            try
            {
                WhereClip whereClip = WhereClip.All;//
                if (param.IsNoAction)
                {
                    whereClip = whereClip && Sys_EmpRight._.ActionCode.IsNull();
                }
                else
                {
                    whereClip = GetWhereClip(param);
                }
                if (param.MenuID > 0) whereClip = whereClip && Sys_Module._.MenuID.At("b") == param.MenuID;
                if (!string.IsNullOrEmpty(param.ModuleName)) whereClip = whereClip && Sys_Module._.ModuleName.At("b").Like("%"+ param.ModuleName+"%");
               
               List<Field> fiels=new List<Field>(){
                  Sys_EmpRight._.EmpRightID,
                  Sys_EmpRight._.EmpID,
                  Sys_Module._.ModuleID.At("b"),
                  Sys_EmpRight._.ActionCode,
                  Sys_Module._.ModuleName.At("b"),
                  Sys_Module._.ModuleCode.At("b"),
                  Sys_Module._.MenuID.At("b"),
                  Sys_Module._.ActionCode.At("b").As("BaseActionCode")
               };
                WhereClip onWhereClip=Sys_EmpRight._.ModuleID==Sys_Module._.ModuleID.At("b");
                pagelist = this.SelectList<Sys_EmpRightResult, Sys_Module>(JoinType.RightJoin,onWhereClip, param.PageIndex.GetValueOrDefault(1), param.PageSize.GetValueOrDefault(50), fiels, whereClip, Sys_Module._.ModuleCode.At("b").Asc,null, null);
                pagelist.ResultJoinList.Columns.Add("RightName");
    
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
        /// 批量修改和插入,删除
        /// </summary>
        /// <param name="paramList"></param>
        /// <returns></returns>
        public int UpdateOrInsertList(List<Sys_EmpRightResult> list)
        {
            this.CheckSession();
            int ret = 0;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].EmpRightID == 0)
                {
                    list[i].GCompanyID = this.SessionInfo.CompanyID;
                    list[i].IsDeleted = false;
                }
            }

            ret += this.BatchInsertOrUpdate<Sys_EmpRightResult>(list);
            this.BatchExecute();
            return ret;
        }
        public int SaveEmpRight(Sys_EmpRightParam param)
        {
            this.CheckSession();
            int ret = 0;
            if (param.EmpID.ToInt32() <= 0) throw new WarnException("请指定员工!");
            List<Sys_EmpRightResult> lstEmpRight = new List<Sys_EmpRightResult>();
            lstEmpRight = this.SelectList<Sys_EmpRightResult>(Sys_EmpRight._.EmpID == param.EmpID && Sys_EmpRight._.IsDeleted == false);
            List<Sys_EmpRightResult> lstEditEmpRight = param.EmpRightList;
            if(lstEditEmpRight==null)lstEditEmpRight=new List<Sys_EmpRightResult>();

            List<Sys_EmpRightResult> lstNewEmpRight = lstEditEmpRight.Where(a => !lstEmpRight.Exists(b => b.ModuleID == a.ModuleID)).Distinct().ToList();
            List<Sys_EmpRightResult> lstModifyEmpRight = lstEditEmpRight.Where(a => lstEmpRight.Exists(b => b.ModuleID == a.ModuleID)).Distinct().ToList();
            List<Sys_EmpRightResult> lstDelEmpRight = lstEmpRight.Where(a => !lstEditEmpRight.Exists(b => b.ModuleID == a.ModuleID)).Distinct().ToList();

            if (lstNewEmpRight.Count > 0) this.BatchInsertOrUpdate<Sys_EmpRightResult>(lstNewEmpRight);
            if (lstModifyEmpRight.Count > 0) this.BatchInsertOrUpdate<Sys_EmpRightResult>(lstModifyEmpRight);
            if (lstDelEmpRight.Count > 0) this.BatchDelete<Sys_EmpRightResult>(lstDelEmpRight);
            ret = this.BatchExecute();

            return ret;
        }
    }
}
