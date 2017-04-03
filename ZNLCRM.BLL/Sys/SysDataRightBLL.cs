using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySoft.Data;
using ZNLFrame.Entity;
using ZNLCRM.Utility;
using ZNLCRM.Entity.DBModel;
using ZNLCRM.Entity.UserModel.Sys;

namespace ZNLCRM.BLL.Sys
{
    public class SysDataRightBLL:BaseBLL
    {
        static SysDataRightBLL _instarnce = new SysDataRightBLL();
        static Sys_EmpDataRightResult _empDataRight { get; set; }

        Sys_EmpDataRightResult GetEmpDataRight(Sys_EmpDataRightParam param)
        {
            if (_empDataRight != null) return _empDataRight;
            WhereClip where = Sys_EmpDataRight._.EmpID == this.SessionInfo.UserID.ToInt32();
            _empDataRight = this.Select<Sys_EmpDataRightResult>(where);
            return _empDataRight;
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
            if (!string.IsNullOrEmpty(dataRight.EditOrgtIDs)) arrEId = dataRight.EditOrgtIDs.Split(',');
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
            if (!string.IsNullOrEmpty(dataRight.EditOrgtIDs)) arrEOrgId = dataRight.EditOrgtIDs.Split(',');
            if (!string.IsNullOrEmpty(dataRight.ReadDeptIDs)) arrRDeptIds = dataRight.ReadOrgIDs.Split(',');
            if (!string.IsNullOrEmpty(dataRight.EditDeptIDs)) arrEDeptId = dataRight.EditOrgtIDs.Split(',');
            if (!string.IsNullOrEmpty(dataRight.ReadEmpIDs)) arrREmpIds = dataRight.ReadOrgIDs.Split(',');
            if (!string.IsNullOrEmpty(dataRight.EditEmpIDs)) arrEEmpId = dataRight.EditOrgtIDs.Split(',');
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
    }
}
