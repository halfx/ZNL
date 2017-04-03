using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySoft.Data;
using ZNLCRM.Entity.UserModel.FIN;
using ZNLCRM.Entity.DBModel;
using ZNLCRM.Entity.UserModel.Common;
using ZNLFrame.Entity;
using ZNLCRM.BLL.Sys;

namespace ZNLCRM.BLL.FIN
{  
    public   class FIN_CashBankJournalBLL:BaseBLL
    {
        /// <summary>
        /// 获取条件的公共方法
        /// </summary>
        /// <param name="param">条件实体</param>
        /// <returns></returns>
        WhereClip GetWhereClip(FIN_CashBankJournalParam param)
        {
            this.CheckSession();
            WhereClip where = WhereClip.All;
            if (param.CBJID != null) where = where && FIN_CashBankJournal._.CBJID == param.CBJID;
            if (param.CBID != null) where = where && FIN_CashBankJournal._.CBID == param.CBID;
            if (param.SourceBillNo != null) where = where && FIN_CashBankJournal._.SourceBillNo.Like("%" + param.SourceBillNo + "%");
            if (param.Abstract != null) where = where && FIN_CashBankJournal._.Abstract.Like("%" + param.Abstract + "%");
            return where;
        }
       
        /// <summary>
        /// 获取一条信息记录
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public FIN_CashBankJournalResult GetInfo(FIN_CashBankJournalParam param)
        {
            this.CheckSession();
            FIN_CashBankJournalResult rst = new FIN_CashBankJournalResult();
            #region 判断
            if (param.CBJID == null) throw new WarnException("请指定流水记录ID！");
            #endregion
            #region 保存实体
            WhereClip where = GetWhereClip(param);

            rst = this.Select<FIN_CashBankJournalResult>(where);
            //Sys_EmpDataRightBLL.SetRecIsEdit<FIN_CashBankJournalResult>(rst, "BeLongEmpID", "", "OrgID", this.SessionInfo);
            #endregion
            return rst;
        }

        /// <summary>
        /// 查询记录,并返回分页列表
        /// </summary>
        /// <param name="param">查询条件实体</param>
        /// <returns></returns>
        public PageList<FIN_CashBankJournalResult> GetPageList(FIN_CashBankJournalParam param)
        {
            this.CheckSession();
            PageList<FIN_CashBankJournalResult> rst = new PageList<FIN_CashBankJournalResult>();
            WhereClip where = GetWhereClip(param);
            List<Field> lstField = new List<Field>()
            {
                FIN_CashBankJournal._.All
               
            };
            rst = this.SelectList<FIN_CashBankJournalResult>(param.PageIndex.GetValueOrDefault(1), param.PageSize.GetValueOrDefault(50), lstField, where, FIN_CashBankJournal._.CreatedTime.Desc);
            // rst.ResultList = Sys_EmpDataRightBLL.SetRecIsEdit<FIN_CashBankJournalResult>(rst.ResultList, "BeLongEmpID", "", "OrgID", this.SessionInfo);
            return rst;
        }
       
    }
}
