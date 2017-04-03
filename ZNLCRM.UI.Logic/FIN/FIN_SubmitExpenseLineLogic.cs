using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZNLCRM.Entity.UserModel.Common;
using ZNLCRM.Entity.UserModel.FIN;
using ZNLFrame.Entity;

namespace ZNLCRM.UI.Logic.FIN
{
    public  class FIN_SubmitExpenseLineLogic:BaseLogic
    {
        public FIN_SubmitExpenseLineLogic(Form form) : base(form) { }

        public WCFAddUpdateResult AddOrUpdate(FIN_SubmitExpenseLineResult param)
        {
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.FIN.FIN_SubmitExpenseLineBLL", "AddOrUpdate", param);
            ret = (rst == null ? new WCFAddUpdateResult() : rst.Result as WCFAddUpdateResult);
            return ret;
        }

        public FIN_SubmitExpenseLineResult GetInfo(FIN_SubmitExpenseLineParam param)
        {
            FIN_SubmitExpenseLineResult ret = new FIN_SubmitExpenseLineResult();
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.FIN.FIN_SubmitExpenseLineBLL", "GetInfo", param);
            ret = rst == null ? new FIN_SubmitExpenseLineResult() : rst.Result as FIN_SubmitExpenseLineResult;
            return ret;
        }
        public List<FIN_SubmitExpenseLineResult> GetList(FIN_SubmitExpenseLineParam param)
        {
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.FIN.FIN_SubmitExpenseLineBLL", "GetList", param);
            List<FIN_SubmitExpenseLineResult> list = new List<FIN_SubmitExpenseLineResult>();
            list = (rst == null ? new List<FIN_SubmitExpenseLineResult>() : rst.Result as List<FIN_SubmitExpenseLineResult>);
            return list;
        }

        public WCFAddUpdateResult DelInfo(FIN_SubmitExpenseLineParam param)
        {
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.FIN.FIN_SubmitExpenseLineBLL", "DelInfo", param);
            ret = (rst == null ? new WCFAddUpdateResult() : rst.Result as WCFAddUpdateResult);
            return ret;
        }

        public WCFAddUpdateResult UpdateOrInsertList(List<FIN_SubmitExpenseLineResult> list)
        {

            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.FIN.FIN_SubmitExpenseLineBLL", "UpdateOrInsertList", list);
            ret = (rst == null ? new WCFAddUpdateResult() : rst.Result as WCFAddUpdateResult);
            return ret;
        }
    }
}
