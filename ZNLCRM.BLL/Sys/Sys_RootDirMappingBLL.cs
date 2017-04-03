using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLFrame.Entity;
using ZNLCRM.Entity.UserModel.Sys;
using MySoft.Data;
using ZNLCRM.Entity.DBModel;
using ZNLCRM.Entity.UserModel.Common;

namespace ZNLCRM.BLL.Sys
{
    public  class Sys_RootDirMappingBLL:BaseBLL
    {

        /// <summary>
        /// 分页集合
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public PageList<Sys_RootDirMappingResult> GetPageList(Sys_RootDirMappingParam param)
        {
            this.CheckSession();
            PageList<Sys_RootDirMappingResult> ret = new PageList<Sys_RootDirMappingResult>();
            try
            {
                 List<Field> field = new List<Field>()
                 {
                    Field.All
                 };
                 ret = this.SelectList<Sys_RootDirMappingResult>(param.PageIndex.GetValueOrDefault(1), param.PageSize.GetValueOrDefault(50), field, GetWhereClip(param), Sys_RootDirMapping._.CreatedTime.Desc);

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
        /// 获取集合
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public List<Sys_RootDirMappingResult> GetList(Sys_RootDirMappingParam param)
        {
            this.CheckSession();
            List<Sys_RootDirMappingResult> ret = new List<Sys_RootDirMappingResult>();
            try
            {
                WhereClip whereClip = GetWhereClip(param);
                ret = this.SelectList<Sys_RootDirMappingResult>(whereClip, Sys_RootDirMapping._.CreatedTime.Desc);
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
        /// 查询条件
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        WhereClip GetWhereClip(Sys_RootDirMappingParam param)
        {
            this.CheckSession();
            WhereClip where = Sys_RootDirMapping._.IsDeleted == 0;
            if (param.MID > 0) where = where && Sys_RootDirMapping._.MID == param.MID;
            if (param.MGuid != null) where = where && Sys_RootDirMapping._.MGuid == param.MGuid;
            if (!string.IsNullOrEmpty(param.MappingIdentifier)) where = where && Sys_RootDirMapping._.MappingIdentifier.Like("%" + param.MappingIdentifier + "%");
            if (!string.IsNullOrEmpty(param.AttachType)) where = where && Sys_RootDirMapping._.AttachType == param.AttachType;
            if (param.IsEffect != null) where = where && Sys_RootDirMapping._.IsEffect == param.IsEffect;
            
            return where;
        }

        /// <summary>
        /// 添加和新增修改
        /// </summary>
        /// <param name="param">新增或修改的实体</param>
        /// <returns></returns>
        public WCFAddUpdateResult AddOrUpdate(Sys_RootDirMappingResult param)
        {
            this.CheckSession();
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            try
            {
                int affect = 0;
                #region 判断
                if (string.IsNullOrEmpty(param.AttachType)) throw new WarnException("请指定单据类型！");
                if(string.IsNullOrEmpty(param.PhysicalRootPath)) throw new WarnException("请指定物理根目录路径！" );
                if(string.IsNullOrEmpty(param.MappingIdentifier)) throw new WarnException("请指定映射标示符！");
                #endregion

                #region
                if (param.MGuid!=null)
                {
                    WhereClip where = Sys_RootDirMapping._.MGuid == param.MGuid;
                    param.UpdatedEmpID = this.SessionInfo.UserID;
                    param.UpdatedEmpName = this.SessionInfo.UserName;
                    param.UpdatedTime = DateTime.Now;
                    affect = this.Update<Sys_RootDirMappingResult>(param, where);
                    List<Sys_RootDirMappingResult> rstList=this.SelectList<Sys_RootDirMappingResult>(Sys_RootDirMapping._.MGuid!=param.MGuid
                        && Sys_RootDirMapping._.AttachType==param.AttachType
                        && Sys_RootDirMapping._.GCompanyID==this.SessionInfo.CompanyID);
                    if (rstList != null)
                    {
                        rstList.ForEach(a => { a.IsEffect = false; });
                    }
                    this.BatchInsertOrUpdate<Sys_RootDirMappingResult>(rstList);
                }
                else
                {
                    param.MGuid = Guid.NewGuid();
                    param.GCompanyID = this.SessionInfo.CompanyID;
                    param.IsDeleted = false;
                   
                    param.CreatedEmpID = this.SessionInfo.UserID;
                    param.CreatedEmpName = this.SessionInfo.UserName;
                    param.CreatedTime = DateTime.Now;
                    
                    affect = this.Insert<Sys_RootDirMappingResult>(param);
                    param = this.Select<Sys_RootDirMappingResult>(new List<Field>() { Sys_RootDirMapping._.All }, Sys_RootDirMapping._.MGuid == param.MGuid);
                }
              
           
                #region 设置返回值
                ret.Key = param.MID;
                ret.KeyGuid = param.MGuid;
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
        public Sys_RootDirMappingResult GetInfo(Sys_RootDirMappingParam param)
        {
            this.CheckSession();
            Sys_RootDirMappingResult rst = new Sys_RootDirMappingResult();
            //#region 判断
            //if (param.MGuid == null) throw new WarnException("请指定映射表GUID！");
            //#endregion
            #region 获取实体
            rst = this.Select<Sys_RootDirMappingResult>(GetWhereClip(param));
            #endregion
            return rst;
        }

        /// <summary>
        /// 删除实体
        /// </summary>
        /// <param name="param">删除条件实体</param>
        /// <returns></returns>
        public WCFAddUpdateResult DelInfo(Sys_RootDirMappingParam param)
        {
            this.CheckSession();
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            int affect = 0;
            try
            {
                #region 判断
                if (param.MGuid ==null) throw new WarnException("请指定要删除的映射表guid！");
                #endregion
                WhereClip whereClip = GetWhereClip(param);
                Sys_RootDirMappingResult info = new Sys_RootDirMappingResult();
                info.IsDeleted = true;
                affect = this.Update<Sys_RootDirMappingResult>(info, whereClip);
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
