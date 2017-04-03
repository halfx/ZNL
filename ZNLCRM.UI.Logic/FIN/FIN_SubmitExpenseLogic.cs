using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZNLCRM.Entity.UserModel.Common;
using ZNLFrame.Entity;
using ZNLCRM.Entity.UserModel.FIN;

namespace ZNLCRM.UI.Logic.FIN
{
    public  class FIN_SubmitExpenseLogic:BaseLogic
    {
        public FIN_SubmitExpenseLogic(Form form) : base(form) { }

        public WCFAddUpdateResult AddOrUpdate(FIN_SubmitExpenseResult param)
        {
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.FIN.FIN_SubmitExpenseBLL", "AddOrUpdate", param);
            ret = (rst == null ? new WCFAddUpdateResult() : rst.Result as WCFAddUpdateResult);
            return ret;
        }

        public FIN_SubmitExpenseResult GetInfo(FIN_SubmitExpenseParam param)
        {
            FIN_SubmitExpenseResult ret = new FIN_SubmitExpenseResult();
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.FIN.FIN_SubmitExpenseBLL", "GetInfo", param);
            ret = rst == null ? new FIN_SubmitExpenseResult() : rst.Result as FIN_SubmitExpenseResult;
            return ret;
        }
        public List<FIN_SubmitExpenseResult> GetList(FIN_SubmitExpenseParam param)
        {
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.FIN.FIN_SubmitExpenseBLL", "GetList", param);
            List<FIN_SubmitExpenseResult> list = new List<FIN_SubmitExpenseResult>();
            list = (rst == null ? new List<FIN_SubmitExpenseResult>() : rst.Result as List<FIN_SubmitExpenseResult>);
            return list;
        }

        public WCFAddUpdateResult DelInfo(FIN_SubmitExpenseParam param)
        {
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.FIN.FIN_SubmitExpenseBLL", "DelInfo", param);
            ret = (rst == null ? new WCFAddUpdateResult() : rst.Result as WCFAddUpdateResult);
            return ret;
        }

        public WCFAddUpdateResult UpdateOrInsertList(List<FIN_SubmitExpenseResult> list)
        {

            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.FIN.FIN_SubmitExpenseBLL", "UpdateOrInsertList", list);
            ret = (rst == null ? new WCFAddUpdateResult() : rst.Result as WCFAddUpdateResult);
            return ret;
        }
    }
}
