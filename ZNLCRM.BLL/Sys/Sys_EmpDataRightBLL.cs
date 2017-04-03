using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySoft.Data;
using ZNLFrame.Entity;
using ZNLCRM.Utility;
using ZNLCRM.Entity.DBModel;
using ZNLCRM.Entity.UserModel.Sys;
using ZNLCRM.Entity.UserModel.Common;
using ZNLCRM.Entity.UserModel.HR;
using ZNLCRM.BLL.HR;

namespace ZNLCRM.BLL.Sys
{
    public class Sys_EmpDataRightBLL:BaseBLL
    {
        static Sys_EmpDataRightBLL _instarnce = new Sys_EmpDataRightBLL();
        static Sys_EmpDataRightResult _empDataRight { get; set; }

        public  Sys_EmpDataRightResult GetEmpDataRight(Sys_EmpDataRightParam param)
        {
            this.CheckSession();
            try
            {
                if (_empDataRight != null) return _empDataRight;
                WhereClip where = Sys_EmpDataRight._.EmpID == this.SessionInfo.UserID.ToInt32()
                    && Sys_EmpDataRight._.IsDeleted == false
                    && Sys_EmpDataRight._.GCompanyID == this.SessionInfo.CompanyID;
                _empDataRight = this.Select<Sys_EmpDataRightResult>(where);
              
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
            return _empDataRight;
        }

        
        /// <summary>
        /// 添加和新增修改
        /// </summary>
        /// <param name="param">新增或修改的实体</param>
        /// <returns></returns>
        public WCFAddUpdateResult AddOrUpdate(Sys_EmpDataRightResult param)
        {
            this.CheckSession();
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            try
            {
                int affect = 0;
                #region 判断


                #endregion

                #region 系统默认值
                if (param.SysEmpRoleID != 0)
                {
                    WhereClip where = Sys_EmpDataRight._.SysEmpRoleID == param.SysEmpRoleID;
                    affect = this.Update<Sys_EmpDataRightResult>(param, where);
                }
                else
                {
                    param.IsDeleted = false;
                    param.GCompanyID = this.SessionInfo.CompanyID;
                    affect = this.Insert<Sys_EmpDataRightResult>(param);
                    param = this.Select<Sys_EmpDataRightResult>(new List<Field>() { Sys_EmpDataRight._.SysEmpRoleID }, Sys_EmpDataRight._.EmpID == param.EmpID);
                }
                #region 设置返回值
                ret.Key = param.SysEmpRoleID.ToInt32();
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

        public static WhereClip GetEmpIDInWhere(WhereClip whereClip,Field fldBillDate, Field fldEmp, Field fldOrg,Field fldDept, SessionInfo sessionInfo)
        {
            WhereClip ret = whereClip;
            #region 获取人员的权限
            Sys_EmpDataRightResult dataRight = new Sys_EmpDataRightResult();
            _instarnce.SessionInfo = sessionInfo;
            dataRight = _instarnce.GetEmpDataRight(null);
            if (dataRight == null) { return ret; }
            string[] arrRIds = new string[] { }; string[] arrEId = new string[] { };
            string[] arrIds = new string[] { };
            #region 绑定机构条件
            if (!string.IsNullOrEmpty(dataRight.ReadOrgIDs)) arrRIds = dataRight.ReadOrgIDs.Split(',');
            if (!string.IsNullOrEmpty(dataRight.EditOrgIDs)) arrEId = dataRight.EditOrgIDs.Split(',');
            arrIds = arrRIds.Union(arrEId).Distinct().ToArray();
            if (fldOrg != null)
            {
                if (arrRIds.Length > 0)
                {
                    ret = ret && fldOrg.In(arrIds);
                }
            }
            #endregion
            #region 绑定部门条件
            arrRIds = new string[] { }; arrIds = new string[] { };
            if (!string.IsNullOrEmpty(dataRight.ReadDeptIDs)) arrRIds = dataRight.ReadDeptIDs.Split(',');
            if (!string.IsNullOrEmpty(dataRight.EditDeptIDs)) arrEId = dataRight.EditDeptIDs.Split(',');
            arrIds = arrRIds.Union(arrEId).Distinct().ToArray();
            if (fldDept != null)
            {
                if (arrRIds.Length > 0)
                {
                    ret = ret && fldDept.In(arrIds);
                }
            }
            #endregion
            #region 绑定员工条件
            arrRIds = new string[] { }; arrIds = new string[] { };
            if (!string.IsNullOrEmpty(dataRight.ReadEmpIDs)) arrRIds = dataRight.ReadEmpIDs.Split(',');
            if (!string.IsNullOrEmpty(dataRight.EditEmpIDs)) arrEId = dataRight.EditEmpIDs.Split(',');
            arrIds = arrRIds.Union(new string[] { sessionInfo.UserID.ToInt32().ToStringHasNull() }).Union(arrEId).Distinct().ToArray();
            if (fldEmp != null)
            {
                if (arrRIds.Length > 0)
                {
                    ret = ret && fldEmp.In(arrIds);
                }
            }
            #endregion
            #endregion
            return ret;
        }
        public static T SetRecIsEdit<T>(T info,string empIDFld, string deptIDName, string orgName, SessionInfo sessionInfo) where T : BaseEntity
        {
            int fOrg = (orgName != "") ? info.GetType().GetProperty(orgName) != null ? info.GetType().GetProperty(orgName).GetValue(info, null).ToInt32() : 0 : 0;
            int fDept = (deptIDName != "") ? info.GetType().GetProperty(deptIDName) != null ? info.GetType().GetProperty(deptIDName).GetValue(info, null).ToInt32() : 0 : 0;// info.GetType().GetProperty(deptIDName).GetValue(info, null).ToInt32();
            int fEmpID = (empIDFld != "") ? info.GetType().GetProperty(empIDFld) != null ? info.GetType().GetProperty(empIDFld).GetValue(info, null).ToInt32() : 0 : 0;// info.GetType().GetProperty(empIDFld).GetValue(info, null).ToInt32();
           
            Sys_EmpDataRightResult dataRight = new Sys_EmpDataRightResult();
            dataRight = _instarnce.GetEmpDataRight(null);

            string[] arrROrgIds = new string[] { }; string[] arrEOrgId = new string[] { };
            string[] arrRDeptIds = new string[] { }; string[] arrEDeptId = new string[] { };
            string[] arrREmpIds = new string[] { }; string[] arrEEmpId = new string[] { };
           
            #region 绑定机构条件
            if (!string.IsNullOrEmpty(dataRight.ReadOrgIDs)) arrROrgIds = dataRight.ReadOrgIDs.Split(',');
            if (!string.IsNullOrEmpty(dataRight.EditOrgIDs)) arrEOrgId = dataRight.EditOrgIDs.Split(',');
            if (!string.IsNullOrEmpty(dataRight.ReadDeptIDs)) arrRDeptIds = dataRight.ReadDeptIDs.Split(',');
            if (!string.IsNullOrEmpty(dataRight.EditDeptIDs)) arrEDeptId = dataRight.EditDeptIDs.Split(',');
            if (!string.IsNullOrEmpty(dataRight.ReadEmpIDs)) arrREmpIds = dataRight.ReadEmpIDs.Split(',');
            if (!string.IsNullOrEmpty(dataRight.EditEmpIDs)) arrEEmpId = dataRight.EditEmpIDs.Split(',');
            #endregion
            info.RecStatu = 2;//正常
            #region 机构数据权限设置
            if (fOrg > 0 && (arrROrgIds.Length > 0 || arrEOrgId.Length > 0))
            {
                if (arrROrgIds.Contains(fOrg.ToString()))
                    info.RecStatu = 1;
                if (arrEOrgId.Length > 0)
                {
                    if (arrEOrgId.Contains(fOrg.ToString()))
                        info.RecStatu = 2;
                    else info.RecStatu = 1;
                }
            }
            #endregion
            #region 部门权限设置
            if (fDept > 0 && (arrRDeptIds.Length > 0 || arrEDeptId.Length > 0))
            {
                if (arrRDeptIds.Contains(fDept.ToString()))
                    info.RecStatu = 1;
                if (arrEDeptId.Length > 0)
                {
                    if (arrEDeptId.Contains(fDept.ToString()))
                        info.RecStatu = 2;
                    else info.RecStatu = 1;
                }
            }
            #endregion
            #region 员工权限设置
            if (fEmpID > 0 && (arrREmpIds.Length > 0 || arrEEmpId.Length > 0))
            {
                if (arrREmpIds.Contains(fEmpID.ToString()))
                    info.RecStatu = 1;
                if (arrEEmpId.Length > 0)
                {
                    if (arrEEmpId.Contains(fEmpID.ToString()))
                        info.RecStatu = 2;
                    else info.RecStatu = 1;
                }
            }
            #endregion
            return info;

        }
        public static List<T> SetRecIsEdit<T>(List<T> lstInfo, string empIDFld, string deptIDName, string orgName, SessionInfo sessionInfo) where T : BaseEntity
        {
            foreach (T info in lstInfo)
            {
                SetRecIsEdit<T>(info, empIDFld, deptIDName, orgName, sessionInfo);
            }
            return lstInfo;
        }
        /// <summary>
        /// 获取角色对应员工列表
        /// </summary>
        /// <param name="param">条件参数</param>
        /// <returns></returns>
        public List<HR_EmployeeResult> GetRoleEmpList(Sys_EmpDataRightParam param)
        {
            List<HR_EmployeeResult> ret = new List<HR_EmployeeResult>();
            HR_EmployeeBLL empBll = new HR_EmployeeBLL();
            empBll.SessionInfo = this.SessionInfo;
            List<Sys_EmpDataRightResult> empDataRightList = new List<Sys_EmpDataRightResult>();
            WhereClip where = Sys_EmpDataRight._.RoleIDs.Like("%," + param.RoleID + ",%")
                            && Sys_EmpDataRight._.IsDeleted == false
                            && Sys_EmpDataRight._.GCompanyID == this.SessionInfo.CompanyID;
            empDataRightList = this.SelectList<Sys_EmpDataRightResult>(where);
            int?[] arrEmpIDs = empDataRightList.Select(a => a.EmpID).ToArray();
            if (arrEmpIDs.Length > 0)
            {
                ret = empBll.GetEmpMainInfoList(new HR_EmployeeParam() { EmpIDs = arrEmpIDs });
            }
            return ret;
        }
        public WCFAddUpdateResult AddRoleEmpIDs(Sys_EmpDataRightParam param)
        {
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            if (param.EmpIDs ==null || param.EmpIDs.Length <= 0) { throw new WarnException("请指定员工记录!"); }
            if (param.RoleID.ToInt32() <= 0) { throw new WarnException("请指定角色!"); }
            Sys_EmpDataRightResult rst = new Sys_EmpDataRightResult();
            List<Sys_EmpDataRightResult> empDataRightList = new List<Sys_EmpDataRightResult>();
            WhereClip where = Sys_EmpDataRight._.EmpID.In(param.EmpIDs)
                            && Sys_EmpDataRight._.IsDeleted == false
                            && Sys_EmpDataRight._.GCompanyID == this.SessionInfo.CompanyID;
            empDataRightList = this.SelectList<Sys_EmpDataRightResult>(where);
            List<Sys_EmpDataRightResult> editList = new List<Sys_EmpDataRightResult>();
            foreach (Sys_EmpDataRightResult info in empDataRightList)
            {
                if (info.RoleIDs.ToStringHasNull().IndexOf("," + param.RoleID + ",") >= 0)
                {
                    continue;
                }
                else
                {
                    if (info.RoleIDs.ToStringHasNull().Trim() != "")
                    {
                        info.RoleIDs += param.RoleID + ",";
                        if (!string.IsNullOrEmpty(info.RoleNames)) info.RoleNames += ",";
                        info.RoleNames += param.RoleName;
                    }
                    else
                    {
                        info.RoleIDs += "," + param.RoleID + ",";
                        info.RoleNames += param.RoleName;
                    }
                    editList.Add(info);
                }
            }
            if (editList.Count > 0) { this.BatchInsertOrUpdate(editList); this.BatchExecute(); }
            int?[] empIDs = empDataRightList.Select(a => a.EmpID).ToArray();
            int?[] newEmpIDs = param.EmpIDs.Where(a => !empIDs.Contains(a)).ToArray();
            Sys_EmpDataRightResult newEmpDataRightRst = new Sys_EmpDataRightResult();
            List<Sys_EmpDataRightResult> newList = new List<Sys_EmpDataRightResult>();
            foreach (int? id in newEmpIDs)
            {
                newEmpDataRightRst = new Sys_EmpDataRightResult();
                newEmpDataRightRst.GCompanyID = this.SessionInfo.CompanyID;
                newEmpDataRightRst.IsDeleted = false;
                newEmpDataRightRst.EmpID = id;
                newEmpDataRightRst.RoleIDs = "," + param.RoleID.ToStringHasNull() + ",";
                newEmpDataRightRst.RoleNames = param.RoleName.ToStringHasNull();
                newList.Add(newEmpDataRightRst);
            }
            if (newList.Count > 0)
            {
                this.BatchInsert(newList);
                this.BatchExecute();
            }
            ret.Key = 1;
            return ret;
        }
        /// <summary>
        /// 删除某员工所拥有的角色
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public WCFAddUpdateResult DelRoleEmpIDs(Sys_EmpDataRightParam param)
        {
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            if (param.EmpIDs == null || param.EmpIDs.Length <= 0) { throw new WarnException("请指定员工记录!"); }
            if (param.RoleID.ToInt32() <= 0) { throw new WarnException("请指定角色!"); }
            ZNLCRM.BLL.Sys.Sys_RolesBLL roleBll = new Sys_RolesBLL();
            Sys_EmpDataRightResult rst = new Sys_EmpDataRightResult();
            List<Sys_EmpDataRightResult> empDataRightList = new List<Sys_EmpDataRightResult>();
            WhereClip where = Sys_EmpDataRight._.EmpID.In(param.EmpIDs)
                            && Sys_EmpDataRight._.IsDeleted == false
                            && Sys_EmpDataRight._.GCompanyID == this.SessionInfo.CompanyID;
            roleBll.SessionInfo = this.SessionInfo;
            empDataRightList = this.SelectList<Sys_EmpDataRightResult>(where);
            List<Sys_EmpDataRightResult> editList = new List<Sys_EmpDataRightResult>();
            string[] arrRoleIDs;
            foreach (Sys_EmpDataRightResult info in empDataRightList)
            {
                if (info.RoleIDs.ToStringHasNull().IndexOf("," + param.RoleID + ",") >= 0)
                {
                    arrRoleIDs = info.RoleIDs.Replace("," + param.RoleID + ",", ",").Split(',').Where(a => a.ToStringHasNull().Trim() != "").ToArray();
                    if (arrRoleIDs.Length > 0)
                    {
                        info.RoleNames = roleBll.GetRoleNames(arrRoleIDs.Select(a => (int?)a.ToInt32()).ToArray());
                        info.RoleIDs = "," + string.Join(",", arrRoleIDs) + ",";
                    }
                    else
                    {
                        info.RoleNames = "";
                        info.RoleIDs = "";
                    }
                    editList.Add(info);
                }
            }
            if (editList.Count > 0)
            {
                this.BatchInsertOrUpdate(editList);
                this.BatchExecute();
            }
            ret.Key = 1;
            return ret;
        }

    }
}
