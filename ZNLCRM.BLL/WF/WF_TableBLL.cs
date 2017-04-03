using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLCRM.Entity.UserModel.WF;
using ZNLFrame.Entity;
using MySoft.Data;
using ZNLCRM.Entity.DBModel;
using ZNLCRM.BLL.Sys;

namespace ZNLCRM.BLL.WF
{
    public class WF_TableBLL:BaseBLL
    {
        WhereClip GetWhereClip(WF_TableParam param)
        {
            this.CheckSession();
            WhereClip where = WF_Table._.IsDeleted == false;
            if (!string.IsNullOrEmpty(param.WF_TableEngName))
                where = where && WF_Table._.WF_TableEngName == param.WF_TableEngName;
            return where;
        }
        /// <summary>
        /// 获取一条信息记录
        /// </summary>
        /// <param name="param">条件实体</param>
        /// <returns></returns>
        public WF_TableResult GetInfo(WF_TableParam param)
        {
            WF_TableResult rst = new WF_TableResult();
            try
            {
                this.CheckSession();
                #region 判断
                if (string.IsNullOrEmpty(param.WF_TableEngName)) throw new WarnException("请指定表名！");
                #endregion
                #region 获取主单实体
                WhereClip where = GetWhereClip(param);
                rst = this.Select<WF_TableResult>(where);
                if (rst == null || rst.WF_TableID <= 0)
                {
                    return rst;
                }
                #endregion
                #region 获取明细实体
                where = WF_TableFields._.WF_TableID == rst.WF_TableID && WF_TableFields._.IsDeleted == false;
                List<WF_TableFieldsResult> lineRst = new List<WF_TableFieldsResult>();
                lineRst = this.SelectList<WF_TableFieldsResult>(where, WF_TableFields._.WF_TableFieldID.Asc);
                rst.WF_TableFieldList = lineRst;
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
            return rst;
        }
    }
}
