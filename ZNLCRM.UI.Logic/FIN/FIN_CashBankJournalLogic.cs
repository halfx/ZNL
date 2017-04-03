using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZNLCRM.Entity.UserModel.FIN;
using ZNLFrame.Entity;

namespace ZNLCRM.UI.Logic.FIN
{
    public class FIN_CashBankJournalLogic:BaseLogic
    {
        public FIN_CashBankJournalLogic(Form form) : base(form) { }
       

        public FIN_CashBankJournalResult GetInfo(FIN_CashBankJournalParam param)
        {
            FIN_CashBankJournalResult ret = new FIN_CashBankJournalResult();
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.FIN.FIN_CashBankJournalBLL", "GetInfo", param);
            ret = rst == null ? new FIN_CashBankJournalResult() : rst.Result as FIN_CashBankJournalResult;
            return ret;
        }
        public PageList<FIN_CashBankJournalResult> GetPageList(FIN_CashBankJournalParam param)
        {
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.FIN.FIN_CashBankJournalBLL", "GetPageList", param);
            PageList<FIN_CashBankJournalResult> pageList = new PageList<FIN_CashBankJournalResult>();
            pageList = (rst == null ? new PageList<FIN_CashBankJournalResult>() : rst.Result as PageList<FIN_CashBankJournalResult>);
            return pageList;
        }

       
    }
}
