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
using ZNLCRM.Utility.CommonEnum;

namespace ZNLCRM.BLL.Sys
{
    public  class SYS_DictItemLineBLL:BaseBLL
    {
       

        public PageList<SYS_DictItemLineResult> GetDictItemLineList(SYS_DictItemLineParam param)
        {
            this.CheckSession();
            PageList<SYS_DictItemLineResult> ret = new PageList<SYS_DictItemLineResult>();
            try
            {
                WhereClip whereClip = SYS_DictItem._.IsDeleted.At("b") == 0 && SYS_DictItemLine._.IsDeleted == 0;
                if (param.ItemName != null) whereClip = whereClip && SYS_DictItem._.ItemName.At("b") == param.ItemName;
                if (param.ItemCode != null) whereClip = whereClip && SYS_DictItem._.ItemCode.At("b") == param.ItemCode;
                if (param.ItemCodes != null) whereClip = whereClip && SYS_DictItem._.ItemCode.At("b").In(param.ItemCodes);
                if (param.NoItemValue != null) whereClip = whereClip && !SYS_DictItemLine._.ItemValue2.In(param.NoItemValue);
                WhereClip onWhereClip = SYS_DictItem._.DictItemID.At("b") == SYS_DictItemLine._.DictItemID;
                List<Field> field = new List<Field>{
                    SYS_DictItemLine._.DictItemLineID,
                    SYS_DictItemLine._.ItemValue,
                    SYS_DictItemLine._.ItemValue2,
                    SYS_DictItem._.DictItemID.At("b"),
                    SYS_DictItem._.ItemCode.At("b"),
                    SYS_DictItem._.ItemName.At("b")
               
               };
                ret = this.SelectList<SYS_DictItemLineResult, SYS_DictItem>(JoinType.InnerJoin, onWhereClip,
                    param.PageIndex.GetValueOrDefault(1), param.PageSize.GetValueOrDefault(50), field, whereClip, null, null, null);

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
        /// 绑定下拉框使用
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public List<SYS_DictItemLineResult> GetListByCode(SYS_DictItemLineParam param)
        {
            this.CheckSession();
            List<SYS_DictItemLineResult> ret = new List<SYS_DictItemLineResult>();
            try
            {
                List<Field> fields=new List<Field> (){
                   SYS_DictItem._.DictItemID,
                   SYS_DictItem._.ItemCode,
                   SYS_DictItem._.ItemName,
                   SYS_DictItem._.ValueType
                };
               WhereClip clip=SYS_DictItem._.ItemCode.In(param.ItemCodes) && SYS_DictItem._.IsDeleted==0;
               List<SYS_DictItemResult> dictItemResultList = this.SelectList<SYS_DictItemResult>(fields, clip, SYS_DictItem._.ItemCode.Desc);
               int[] dictItemIDArr= dictItemResultList.Select(a=>a.DictItemID).ToArray();
               if (dictItemIDArr != null && dictItemIDArr.Length > 0)
                {
                   WhereClip clip2=SYS_DictItemLine._.DictItemID.In(dictItemIDArr);
                   List<Field> fields2 = new List<Field>(){
                   SYS_DictItemLine._.DictItemID,
                   SYS_DictItemLine._.DictItemLineID,
                   SYS_DictItemLine._.ItemValue,
                   SYS_DictItemLine._.ItemValue2
                };
                   ret = this.SelectList<SYS_DictItemLineResult>(fields2,clip2, SYS_DictItemLine._.DictItemLineID.Asc);
                   foreach (SYS_DictItemLineResult itemLineResult in ret)
                   {
                       SYS_DictItemResult itemResult=dictItemResultList.FirstOrDefault(a => a.DictItemID == itemLineResult.DictItemID);
                       itemLineResult.ItemCode = itemResult.ItemCode;
                       switch(itemResult.ValueType)
                       {
                           case "Boolean":
                               itemLineResult.ValueType=DataValueType.Boolean;
                               break;
                           case "Decimal":
                               itemLineResult.ValueType=DataValueType.Decimal;
                               break;
                           case "Int32":
                               itemLineResult.ValueType = DataValueType.Int32;
                               break;
                           case "JSON":
                               itemLineResult.ValueType = DataValueType.JSON;
                               break;
                           case "String":
                               itemLineResult.ValueType = DataValueType.String;
                               break;
                           case "XML":
                               itemLineResult.ValueType = DataValueType.XML;
                               break;
                       }
                       
                   }
                }
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

        public List<SYS_DictItemLineResult> GetList(SYS_DictItemLineParam param)
        {
            this.CheckSession();
            List<SYS_DictItemLineResult> ret = new List<SYS_DictItemLineResult>();
            try
            {
                WhereClip whereClip = GetWhereClip(param);
                ret = this.SelectList<SYS_DictItemLineResult>(whereClip, SYS_DictItemLine._.DictItemLineID.Asc);
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

        WhereClip GetWhereClip(SYS_DictItemLineParam param)
        {
            this.CheckSession();
            WhereClip where = SYS_DictItemLineResult._.IsDeleted == 0;
            if (param.DictItemLineID != null) where = where && SYS_DictItemLine._.DictItemLineID == param.DictItemLineID;
            if (param.DictItemID != null) where = where && SYS_DictItemLine._.DictItemID == param.DictItemID;
            return where;
        }

        /// <summary>
        /// 添加和新增修改
        /// </summary>
        /// <param name="param">新增或修改的实体</param>
        /// <returns></returns>
        public WCFAddUpdateResult AddOrUpdate(SYS_DictItemLineResult param)
        {
            this.CheckSession();
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            try
            {
                int affect = 0;
                #region 判断
                  
                if (param.ItemValue.Trim() == "") throw new WarnException("请指定数据字典子项名称！");
                if (param.ItemValue2.Trim() == "") throw new WarnException("请指定数据字典子项项值！");
                #endregion

                #region 判断重复
                WhereClip whereChk = SYS_DictItemLine._.IsDeleted == false && SYS_DictItemLine._.DictItemID == param.DictItemID;
                if (param.DictItemLineID > 0) whereChk = whereChk & SYS_DictItemLine._.DictItemLineID != param.DictItemLineID;
                int chkNum = this.Count<SYS_DictItemLineResult>(whereChk);
                if (chkNum > 0) throw new WarnException("存在重复的数据字典子项!");
                #endregion
                #region 系统默认值
                if (param.DictItemID > 0)
                {

                    WhereClip where = SYS_DictItemLine._.DictItemID == param.DictItemID;
                    affect = this.Update<SYS_DictItemLineResult>(param, where);
                }
                else
                {

              
                    param.IsDeleted = false;
                    affect = this.Insert<SYS_DictItemLineResult>(param);
                    param = this.Select<SYS_DictItemLineResult>(new List<Field>() { SYS_DictItemLineResult._.DictItemLineID }, SYS_DictItemLine._.DictItemID == param.DictItemID && SYS_DictItemLine._.ItemValue == param.ItemValue);
                }
                #region 设置返回值
                ret.Key = param.DictItemLineID;
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
        public SYS_DictItemLineResult GetInfo(SYS_DictItemLineParam param)
        {
            this.CheckSession();
            SYS_DictItemLineResult rst = new SYS_DictItemLineResult();
            #region 判断
            
            if (param.DictItemLineID.ToInt32() <= 0) throw new WarnException("请指定数据字典子项ID！");
            #endregion
            #region 获取实体
            WhereClip whereClip = SYS_DictItemLine._.DictItemLineID == param.DictItemLineID;
            rst = this.Select<SYS_DictItemLineResult>(whereClip);

            #endregion
            return rst;
        }

        /// <summary>
        /// 删除实体
        /// </summary>
        /// <param name="param">删除条件实体</param>
        /// <returns></returns>
        public WCFAddUpdateResult DelInfo(SYS_DictItemLineParam param)
        {
            this.CheckSession();
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            int affect = 0;
            try
            {
                #region 判断
                if (param.DictItemLineID.ToInt32() <= 0) throw new WarnException("请指定要删除的数据字典子项ID！");
                #endregion

                WhereClip whereClip = GetWhereClip(param);
                SYS_DictItemLineResult info = new SYS_DictItemLineResult();
                info.IsDeleted = true;
                affect = this.Update<SYS_DictItemLineResult>(info, whereClip);
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
        /// 批量修改和插入
        /// </summary>
        /// <param name="paramList"></param>
        /// <returns></returns>
        public WCFAddUpdateResult UpdateOrInsertList(List<SYS_DictItemLineResult> list)
        {
            this.CheckSession();
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
             try
            {
                #region 判断
                if (list.Count<= 0) throw new WarnException("没有需要操作的对象！");
                #endregion
               int affect = 0;
                this.BatchInsertOrUpdate<SYS_DictItemLineResult>(list);
               affect=this.BatchExecute();
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
