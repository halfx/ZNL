using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZNLCRM.Entity.UserModel.Common;
using ZNLFrame.Entity;
using ZNLCRM.Entity.UserModel.WF;

namespace ZNLCRM.UI.Logic.WF
{
    public class WF_AuditRecordLogic : BaseLogic
    {
        public WF_AuditRecordLogic(Form form) : base(form) { }

        public WCFAddUpdateResult SubmitBill(WF_AuditRecordParam param)
        {
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.WF.WF_AuditRecordBLL", "SubmitBill", param);
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            ret = (rst == null ? new WCFAddUpdateResult() : rst.Result as WCFAddUpdateResult);
            return ret;
        }
        public WCFAddUpdateResult AuditBill(WF_AuditRecordParam param)
        {
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.WF.WF_AuditRecordBLL", "AuditBill", param);
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            ret = (rst == null ? new WCFAddUpdateResult() : rst.Result as WCFAddUpdateResult);
            return ret;
        }
        public WF_AuditBillResult GetAuditBillRecord(WF_AuditRecordParam param)
        {
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.WF.WF_AuditRecordBLL", "GetAuditBillRecord", param);
            WF_AuditBillResult ret = new WF_AuditBillResult();
            ret = (rst == null ? new WF_AuditBillResult() : rst.Result as WF_AuditBillResult);
            return ret;
        }
        public WCFAddUpdateResult CancelBill(WF_AuditRecordParam param)
        {
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            if (MessageBox.Show("是否真的撤消当前单据审批状态!","提示",MessageBoxButtons.YesNo,MessageBoxIcon.Information)==DialogResult.No) return ret;
            ExeResult rst = new ExeResult();
            param.OperationType = "Cancel";
            rst = this.Execute("ZNLCRM.BLL.WF.WF_AuditRecordBLL", "CancelBill", param);
            ret = (rst == null ? new WCFAddUpdateResult() : rst.Result as WCFAddUpdateResult);
            return ret;
        }
        public WCFAddUpdateResult TakeBackBill(WF_AuditRecordParam param)
        {
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            if (MessageBox.Show("是否真的收回当前单据审批状态!", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No) return ret;
            ExeResult rst = new ExeResult();
            param.OperationType = "TakeBack";
            rst = this.Execute("ZNLCRM.BLL.WF.WF_AuditRecordBLL", "CancelBill", param);
            ret = (rst == null ? new WCFAddUpdateResult() : rst.Result as WCFAddUpdateResult);
            return ret;
        }
        /// <summary>
        /// 获取审核列表
        /// </summary>
        /// <param name="param">参数实体条件</param>
        /// <returns></returns>
        public PageList<WF_AuditRecordResult> GetAuditRecList(WF_AuditRecordParam param)
        {
            PageList<WF_AuditRecordResult> ret = new PageList<WF_AuditRecordResult>();
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.WF.WF_AuditRecordBLL", "GetAuditRecList", param);
            ret = (rst == null ? new PageList<WF_AuditRecordResult>() : rst.Result as PageList<WF_AuditRecordResult>);
            return ret;
        }
        

    }
}
