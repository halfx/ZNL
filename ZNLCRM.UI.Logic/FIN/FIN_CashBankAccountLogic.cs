using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZNLCRM.Entity.UserModel.Common;
using ZNLFrame.Entity;
using ZNLCRM.Entity.UserModel;
using ZNLCRM.Entity.UserModel.FIN;

namespace ZNLCRM.UI.Logic.FIN
{
   public   class FIN_CashBankAccountLogic:BaseLogic
    {
       public FIN_CashBankAccountLogic(Form form) : base(form) { }

       public WCFAddUpdateResult AddOrUpdate(FIN_CashBankAccountResult param)
       {
           WCFAddUpdateResult ret = new WCFAddUpdateResult();
           ExeResult rst = new ExeResult();
           rst = this.Execute("ZNLCRM.BLL.FIN.FIN_CashBankAccountBLL", "AddOrUpdate", param);
           ret = (rst == null ? new WCFAddUpdateResult() : rst.Result as WCFAddUpdateResult);
           return ret;
       }

       public FIN_CashBankAccountResult GetInfo(FIN_CashBankAccountParam param)
       {
           FIN_CashBankAccountResult ret = new FIN_CashBankAccountResult();
           ExeResult rst = new ExeResult();
           rst = this.Execute("ZNLCRM.BLL.FIN.FIN_CashBankAccountBLL", "GetInfo", param);
           ret = rst == null ? new FIN_CashBankAccountResult() : rst.Result as FIN_CashBankAccountResult;
           return ret;
       }
       public PageList<FIN_CashBankAccountResult> GetPageList(FIN_CashBankAccountParam param)
       {
           ExeResult rst = new ExeResult();
           rst = this.Execute("ZNLCRM.BLL.FIN.FIN_CashBankAccountBLL", "GetPageList", param);
           PageList<FIN_CashBankAccountResult> pageList = new PageList<FIN_CashBankAccountResult>();
           pageList = (rst == null ? new PageList<FIN_CashBankAccountResult>() : rst.Result as PageList<FIN_CashBankAccountResult>);
           return pageList;
       }

       public WCFAddUpdateResult DelInfo(FIN_CashBankAccountParam param)
       {
           WCFAddUpdateResult ret = new WCFAddUpdateResult();
           ExeResult rst = new ExeResult();
           rst = this.Execute("ZNLCRM.BLL.FIN.FIN_CashBankAccountBLL", "DelInfo", param);
           ret = (rst == null ? new WCFAddUpdateResult() : rst.Result as WCFAddUpdateResult);
           return ret;
       }

       public WCFAddUpdateResult UpdateOrInsertList(List<FIN_CashBankAccountResult> list)
       {

           WCFAddUpdateResult ret = new WCFAddUpdateResult();
           ExeResult rst = new ExeResult();
           rst = this.Execute("ZNLCRM.BLL.FIN.FIN_CashBankAccountBLL", "UpdateOrInsertList", list);
           ret = (rst == null ? new WCFAddUpdateResult() : rst.Result as WCFAddUpdateResult);
           return ret;
       }
    }
}
