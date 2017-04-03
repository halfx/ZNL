using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySoft.Data;
using ZNLCRM.Entity.UserModel.CRM;
using ZNLCRM.Entity.DBModel;
using ZNLCRM.Entity.UserModel.Common;
using ZNLFrame.Entity;
using ZNLCRM.Utility;
using ZNLCRM.BLL.Sys;

namespace ZNLCRM.BLL.CRM
{
    public  class CRM_VisitPlanLineBLL:BaseBLL
    {
        /// <summary>
        /// 获取条件的公共方法
        /// </summary>
        /// <param name="param">条件实体</param>
        /// <returns></returns>
        WhereClip GetWhereClip(CRM_VisitPlanLineParam param)
        {
            this.CheckSession();
            WhereClip where = CRM_VisitPlanLine._.IsDeleted == 0;
            if (param.CustVstPlnLineID != null) where = where && CRM_VisitPlanLine._.CustVstPlnLineID == param.CustVstPlnLineID;
            if (param.CustVstPlnLineGuID != null) where = where && CRM_VisitPlanLine._.CustVstPlnLineGuID == param.CustVstPlnLineGuID;
            if (param.CustVstPlnGuID!=null) where =where && CRM_VisitPlanLine._.CustVstPlnGuID==param.CustVstPlnGuID;
            if (param.VstName != null) where = where && CRM_VisitPlanLine._.VstName.Like("%" + param.VstName + "%");
            
            return where;
        }
        /// <summary>
        /// 添加和新增修改
        /// </summary>
        /// <param name="param">新增或修改的实体</param>
        /// <returns></returns>
        public WCFAddUpdateResult AddOrUpdate(CRM_VisitPlanLineResult param)
        {
            this.CheckSession();
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            try
            {

                int affect = 0;
                #region 判断
                if (param.CompanyGuID == Guid.Empty) throw new WarnException("请选择跟进的客户！");
                if (string.IsNullOrEmpty(param.VstName)) throw new WarnException("请指定跟进主题！");
                if (string.IsNullOrEmpty(param.VstText)) throw new WarnException("请填写跟进内容！");
                if (string.IsNullOrEmpty(param.VstTyp)) throw new WarnException("请选择跟进类型！");
                if (param.VstDate == null) throw new WarnException("请选择跟进时间！");

                #endregion
                #region 系统默认值

                
                if (param.CustVstPlnLineID.ToInt32() > 0)
                {
                    WhereClip where = CRM_VisitPlanLine._.CustVstPlnLineID == param.CustVstPlnLineID;
                    param.GCompanyGuID = this.SessionInfo.CompanyID;
                    param.UpdatedEmpID = this.SessionInfo.UserID;
                    param.UpdatedEmpName = this.SessionInfo.UserName;
                    param.UpdatedTime = DateTime.Now;
                    affect = this.Update<CRM_VisitPlanLineResult>(param, where);
                }
                else
                {
                    param.GCompanyGuID = this.SessionInfo.CompanyID;
                    param.CustVstPlnLineGuID = Guid.NewGuid();
                    param.CreatedEmpID = this.SessionInfo.UserID;
                    param.CreatedEmpName = this.SessionInfo.UserName;
                    param.CreatedTime = DateTime.Now;
                    param.IsDeleted = false;
                    affect = this.Insert<CRM_VisitPlanLineResult>(param);
                    param = this.Select<CRM_VisitPlanLineResult>(new List<Field>() { CRM_VisitPlanLine._.CustVstPlnLineID }, CRM_VisitPlanLine._.CustVstPlnLineGuID == param.CustVstPlnLineGuID);
                }
                #region 设置返回值
                ret.Key = param.CustVstPlnLineID;
                ret.CreatedTime = param.CreatedTime;
                ret.CreatedEmpID = param.CreatedEmpID;
                ret.CreatedEmpName = param.CreatedEmpName;
                ret.UpdatedEmpID = param.UpdatedEmpID;
                ret.UpdatedEmpName = param.UpdatedEmpName;
                ret.UpdatedTime = param.UpdatedTime;
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
        public CRM_VisitPlanLineResult GetInfo(CRM_VisitPlanLineParam param)
        {
            this.CheckSession();
            CRM_VisitPlanLineResult rst = new CRM_VisitPlanLineResult();
            #region 判断
            if (param.CustVstPlnLineID == null) throw new WarnException("请指定拜访明细ID！");
            #endregion
            #region 保存实体
            WhereClip where = GetWhereClip(param);

            rst = this.Select<CRM_VisitPlanLineResult>(where);
            //Sys_EmpDataRightBLL.SetRecIsEdit<CRM_VisitPlanLineResult>(rst, "BeLongEmpID", "", "OrgID", this.SessionInfo);
            #endregion
            return rst;
        }


        /// <summary>
        /// 查询记录,并返回分页列表
        /// </summary>
        /// <param name="param">查询条件实体</param>
        /// <returns></returns>
        public List<CRM_VisitPlanLineResult> GetList(CRM_VisitPlanLineParam param)
        {
            this.CheckSession();
            List<CRM_VisitPlanLineResult> rst = new List<CRM_VisitPlanLineResult>();
            try
            {
                WhereClip whereClip = GetWhereClip(param);
                rst = this.SelectList<CRM_VisitPlanLineResult>(whereClip, CRM_VisitPlanLineResult._.CreatedTime.Asc);
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
            return rst;
        }
        /// <summary>
        /// 删除实体
        /// </summary>
        /// <param name="param">删除条件实体</param>
        /// <returns></returns>
        public WCFAddUpdateResult DelInfo(CRM_VisitPlanLineParam param)
        {
            this.CheckSession();
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            int affect = 0;
            try
            {
                #region 判断
                if (param.CustVstPlnLineID == null) throw new WarnException("请指定要删除的记录！");
                #endregion
                WhereClip where = GetWhereClip(param);
                //CRM_VisitPlanLineResult oldInfo = this.GetInfo(param);
                //oldInfo = Sys_EmpDataRightBLL.SetRecIsEdit<CRM_VisitPlanLineResult>(oldInfo, "BeLongEmpID", "", "OrgID", this.SessionInfo);
                //if (oldInfo.RecStatu != 2)
                //{
                //    throw new WarnException("您无权删除当前记录！");
                //}
                CRM_VisitPlanLineResult info = new CRM_VisitPlanLineResult();
                info.IsDeleted = true;
                info.UpdatedTime = DateTime.Now;
                info.UpdatedEmpID = this.SessionInfo.UserID;
                info.UpdatedEmpName = this.SessionInfo.UserName;
                affect = this.Update<CRM_VisitPlanLineResult>(info, where);
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

        /// <summary>
        /// 批量修改和插入
        /// </summary>
        /// <param name="paramList"></param>
        /// <returns></returns>
        public WCFAddUpdateResult UpdateOrInsertList(List<CRM_VisitPlanLineResult> list)
        {
            this.CheckSession();
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            try
            {
                #region 判断
                if (list.Count <= 0) throw new WarnException("没有需要操作的对象！");
                #endregion
                int affect = 0;
                this.BatchInsertOrUpdate<CRM_VisitPlanLineResult>(list);
                affect = this.BatchExecute();
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

        public DateTime?  GetLastVisitTime(CRM_VisitPlanLineParam param)
        {
           object obj= this.Max<CRM_VisitPlanLineResult>(new Field("VstDate"), GetWhereClip(param));
           if (obj != null)
               return obj.ToDateTime();
            else
                return null;
            
        }

        public int GetTotalVisitCount(CRM_VisitPlanLineParam param)
        {
            return this.Count<CRM_VisitPlanLineResult>(GetWhereClip(param)); ;
        }
    }
}
