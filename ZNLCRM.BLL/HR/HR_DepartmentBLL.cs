using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySoft.Data;
using ZNLCRM.Entity.UserModel.HR;
using ZNLCRM.Entity.UserModel.Common;
using ZNLCRM.BLL.Sys;
using ZNLFrame.Entity;
using ZNLCRM.Entity.DBModel;
using ZNLCRM.Utility;

namespace ZNLCRM.BLL.HR
{
    public class HR_DepartmentBLL:BaseBLL
    {
         public HR_DepartmentBLL()
        {
            
        }
        /// <summary>
        /// 获取条件的公共方法
        /// </summary>
        /// <param name="param">条件实体</param>
        /// <returns></returns>
        WhereClip GetWhereClip(HR_DepartmentParam param)
        {
            this.CheckSession();
            WhereClip where = HR_Department._.IsActive == 2;
            if (param.DeptID != null) where = where && HR_Department._.DeptID == param.DeptID;
            if (param.OrgID != null) where = where && HR_Department._.OrgID == param.OrgID;
            if (param.OrgGuID != null) where = where && HR_Department._.OrgGuID == param.OrgGuID;
            if (param.DeptIDs != null) where = where && HR_Department._.DeptID.In(param.DeptIDs);
            return where;
        }
        /// <summary>
        /// 添加和新增修改
        /// </summary>
        /// <param name="param">新增或修改的实体</param>
        /// <returns></returns>
        public WCFAddUpdateResult AddOrUpdate(HR_DepartmentResult param)
        {
            this.CheckSession();
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            try
            {
                int affect = 0;
                #region 判断
                if (param.DeptID == 0) { param.OrgGuID = param.DeptOrgGuID; param.OrgID = param.DeptOrgID; }
                if (param.OrgGuID == Guid.Empty) throw new WarnException("没有所属部门GUID！");
                if (param.OrgID == 0) throw new WarnException("没有所属机构的ID！");
                if (param.DeptName.Trim() == "") throw new WarnException("请输入部门名称！");
                #endregion
               

                if (param.DeptID !=0)
                {
                    WhereClip where = HR_Department._.DeptID == param.DeptID;
                    affect = this.Update<HR_DepartmentResult>(param, where);
                }
                else
                {
                    #region 获取最大编号数字
                    int maxDeptNum = 0;
                    maxDeptNum = this.Count<HR_DepartmentResult>(HR_Department._.ParentID == param.ParentID && HR_Department._.OrgGuID == param.OrgGuID) + 1;
                    #endregion
                    #region 获取父级部门的编号
                    string parentDeptNo = string.Empty;
                    HR_Department parentDepartment = this.Select<HR_Department>(HR_Department._.DeptID == param.ParentID && HR_Department._.OrgGuID == param.OrgGuID);
                    if (parentDepartment != null) parentDeptNo = parentDepartment.DeptNo;
                    #endregion
                    #region 系统默认值
                    param.DeptNo = parentDeptNo+maxDeptNum.ToString().PadLeft(3, '0');
                    param.GCompanyID = this.SessionInfo.CompanyID;
                    param.IsActive = 2;
                    affect = this.Insert<HR_DepartmentResult>(param);
                    param = this.Select<HR_DepartmentResult>(new List<Field> { HR_Department._.DeptID }, HR_Department._.DeptNo==param.DeptNo);
                }
                #region 设置返回值
                ret.Key = param.DeptID;
                ret.KeyGuid = param.OrgGuID;
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
        public HR_DepartmentResult GetInfo(HR_DepartmentParam param)
        {
            this.CheckSession();
            HR_DepartmentResult rst = new HR_DepartmentResult();
            #region 判断
            if (param.DeptID == null) throw new WarnException("请指定关键字DeptID！");
            #endregion
            #region 获取实体
            rst = this.Select<HR_DepartmentResult>(GetWhereClip(param));
            rst.DeptOrgGuID = rst.OrgGuID;
            rst.DeptOrgID = rst.OrgID;
            HR_DepartmentResult parentResult = this.Select<HR_DepartmentResult>(HR_Department._.DeptID == rst.ParentID && HR_Department._.OrgGuID == rst.OrgGuID);
            if (parentResult != null)
            rst.ParentDeptName=parentResult.DeptName;
            HR_OrgResult orgResult = this.Select<HR_OrgResult>(HR_Org._.OrgGuID == rst.OrgGuID);
            if (orgResult!=null)
                rst.DeptOrgName = orgResult.OrgName;
            #endregion
            return rst;
        }

        /// <summary>
        /// 获取部门和机构信息
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public PageList<HR_DepartmentResult> GetPageList(HR_DepartmentParam param)
        {
            this.CheckSession();
            PageList<HR_DepartmentResult> pagelist = new PageList<HR_DepartmentResult>();
            try
            {
                WhereClip whereClip = GetWhereClip(param);
                if (!string.IsNullOrEmpty(param.OrgName)) whereClip = whereClip && HR_Org._.OrgName.At("b") == param.OrgName;
               
         
                List<Field> fiels = new List<Field>(){
                  HR_Department._.DeptID,
                  HR_Department._.DeptName,
                  HR_Department._.DeptNo,
                  HR_Org._.OrgID.At("b"),
                  HR_Org._.OrgNo.At("b"),
                  HR_Org._.OrgName.At("b")
               };
                WhereClip onWhereClip = HR_Department._.OrgID == HR_Org._.OrgID.At("b");
                pagelist = this.SelectList<HR_DepartmentResult, HR_Org>(JoinType.InnerJoin, onWhereClip, param.PageIndex.GetValueOrDefault(1), param.PageSize.GetValueOrDefault(50), fiels, whereClip, HR_Department._.DeptNo.Asc, null, null);
               

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
        public List<HR_DepartmentResult> GetDeptList(HR_DepartmentParam param)
        {
            this.CheckSession();
            List<HR_DepartmentResult> ret = new List<HR_DepartmentResult>();
            try
            {
                WhereClip whereClip = GetWhereClip(param);
                ret = this.SelectList<HR_DepartmentResult>(whereClip, HR_DepartmentResult._.DeptNo.Asc);
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
        /// 获取部门名称
        /// </summary>
        /// <param name="deptID">部门ID</param>
        /// <returns></returns>
        public string GetDeptName(int deptID)
        {
            this.CheckSession();
            string ret = "";
            HR_Department depRst = new HR_Department();
            depRst = this.Select<HR_Department>(HR_Department._.DeptID == deptID && HR_Department._.IsDeleted == false);
            if (depRst != null) ret = depRst.DeptName.ToStringHasNull();
            return ret;
        }
        /// <summary>
        /// 删除实体
        /// </summary>
        /// <param name="param">删除条件实体</param>
        /// <returns></returns>
        public WCFAddUpdateResult DelInfo(HR_DepartmentParam param)
        {
            this.CheckSession();
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            int affect = 0;
            try
            {
                #region 判断
                if (param.DeptID == null) throw new WarnException("请指定要删除的记录！");
                #endregion
                WhereClip where = GetWhereClip(param);
                HR_DepartmentResult info = new HR_DepartmentResult();
                info.IsActive = 2;
                affect = this.Update<HR_DepartmentResult>(info, where);
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
