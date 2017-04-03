using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLCRM.Entity.UserModel.Sys;
using ZNLFrame.Entity;
using MySoft.Data;
using ZNLCRM.Entity.DBModel;
using ZNLCRM.Entity.UserModel.Common;
using ZNLCRM.Utility;
namespace ZNLCRM.BLL.Sys
{
    public class SYS_DictItemBLL : BaseBLL
    {
      

        public Dictionary<string,int> GetDictGroup(SYS_DictItemParam param)
        {
            this.CheckSession();
            Dictionary<string, int> dic = new  Dictionary<string, int>();
            try
            {
                WhereClip whereClip = GetWhereClip(param);
                var query = this.SelectList<SYS_DictItemResult>(whereClip, SYS_DictItem._.DictGroupName.Desc).GroupBy(a => a.DictGroupName).Select(g => new { g.Key, Count = g.Count() });
                foreach (var item in query)
                {
                    dic.Add(item.Key, item.Count);
                }
                 
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
            return dic;
        }
        
        public List<SYS_DictItemResult> GetList(SYS_DictItemParam param)
        {
            this.CheckSession();
            List<SYS_DictItemResult> ret = new List<SYS_DictItemResult>();
            try
            {
                WhereClip whereClip = GetWhereClip(param);
                ret = this.SelectList<SYS_DictItemResult>(whereClip, SYS_DictItem._.DictGroupName.Desc);
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

        WhereClip GetWhereClip(SYS_DictItemParam param)
        {
            this.CheckSession();
            WhereClip where = SYS_DictItemResult._.IsDeleted == 0;
            if (param.DictItemID != null) where = where && SYS_DictItem._.DictItemID == param.DictItemID;
            if (param.Condition != null) where = where && (SYS_DictItem._.ItemCode.Like("%" + param.Condition + "%") || SYS_DictItem._.ItemName.Like("%" + param.Condition + "%"));
            return where;
        }

        /// <summary>
        /// 添加和新增修改
        /// </summary>
        /// <param name="param">新增或修改的实体</param>
        /// <returns></returns>
        public WCFAddUpdateResult AddOrUpdate(SYS_DictItemResult param)
        {
            this.CheckSession();
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            try
            {
                int affect = 0;
                #region 判断
                if (param.ItemCode.Trim()=="") throw new WarnException("请指定数据字典编码！");
                if (param.ItemName.Trim() == "") throw new WarnException("请指定数据字典名称！");
                if (param.DictGroupName.Trim() == "") throw new WarnException("请指定数据字典所属组名！");
                #endregion
              
                #region 判断重复
                WhereClip whereChk = SYS_DictItem._.IsDeleted == false && SYS_DictItem._.ItemCode == param.ItemCode;
                if (param.DictItemID > 0) whereChk = whereChk & SYS_DictItem._.DictItemID != param.DictItemID;
                int chkNum = this.Count<SYS_DictItemResult>(whereChk);
                if (chkNum > 0) throw new WarnException("存在重复的数据字典编码!");
                #endregion
                #region 系统默认值
                if (param.DictItemID > 0)
                {
                   
                    WhereClip where = SYS_DictItem._.DictItemID == param.DictItemID;
                    affect = this.Update<SYS_DictItemResult>(param, where);
                }
                else
                {
                    
                    param.GCompanyID=this.SessionInfo.CompanyID;
                    param.IsDeleted = false;
                    affect = this.Insert<SYS_DictItemResult>(param);
                    param = this.Select<SYS_DictItemResult>(new List<Field>() { SYS_DictItemResult._.DictItemID }, SYS_DictItem._.ItemCode == param.ItemCode);
                }
                #region 设置返回值
                ret.Key = param.DictItemID;
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
        public SYS_DictItemResult GetInfo(SYS_DictItemParam param)
        {
            this.CheckSession();
            SYS_DictItemResult rst = new SYS_DictItemResult();
            #region 判断
            if (param.DictItemID.ToInt32() <= 0) throw new WarnException("请指定数据字典ID！");
            #endregion
            #region 获取实体
            WhereClip whereClip = SYS_DictItem._.DictItemID == param.DictItemID;
            rst = this.Select<SYS_DictItemResult>(whereClip);
          
            #endregion
            return rst;
        }

        /// <summary>
        /// 删除实体
        /// </summary>
        /// <param name="param">删除条件实体</param>
        /// <returns></returns>
        public WCFAddUpdateResult DelInfo(SYS_DictItemParam param)
        {
            this.CheckSession();
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            int affect = 0;
            try
            {
                #region 判断
                if (param.DictItemID.ToInt32() <= 0) throw new WarnException("请指定要删除的数据字典ID！");
                #endregion
                
                WhereClip whereClip = GetWhereClip(param);
                SYS_DictItemResult info = new SYS_DictItemResult();
                info.IsDeleted = true;
                affect = this.Update<SYS_DictItemResult>(info, whereClip);
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
