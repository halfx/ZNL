using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZNLCRM.UI.Logic.WF;
using ZNLCRM.Entity.UserModel.WF;
using ZNLFrame.Entity;
using ZNLCRM.UI.Logic.Common;
using ZNLCRM.Entity.UserModel.Common;
using ZNLCRM.Utility;

namespace ZNLCRM.UI.WF
{
    public partial class frmAuditRecordList : frmBaseForm
    {
        Guid? _sourceGuidKey;
        string _tableName;
        string _sourceBillNo;
        public delegate bool dlgBeforePassEvent();
        public dlgBeforePassEvent BeforePassEvent;
        public delegate void dlgAfterPassEvent();
        public dlgAfterPassEvent AfterPassEvent;

        public frmAuditRecordList(string tableName,Guid? sourceGuidKey,string sourceBillNo)
        {
            _sourceGuidKey = sourceGuidKey;
            _tableName = tableName;
            _sourceBillNo = sourceBillNo;
            InitializeComponent();
        }
        void BindData(int pageIndex)
        {
            this.btnReturn.Enabled = false;//收回
            this.btnNoPass.Enabled = false;//拒绝
            this.btnCancelCheck.Enabled = false;//驳回
            this.btnArgee.Enabled = false;//同意

            WF_AuditRecordLogic logic = new WF_AuditRecordLogic(this);
            WF_AuditRecordParam param = new WF_AuditRecordParam();
            param.SourceTableEngName = _tableName;
            param.SourceBillGuid = _sourceGuidKey;
            param.PageIndex = pageIndex;
            param.PageSize = int.MaxValue;
            param.IsPage = true;
            WF_AuditBillResult rst = this.AsyncExecute<WF_AuditBillResult, WF_AuditRecordParam>(param, logic.GetAuditBillRecord, BindDataComplete);
        }
        void BindDataComplete(WF_AuditBillResult a)
        {
            List<WF_AuditRecordResult> lstRrcord = a.WF_AuditRecordResultList;
            List<WF_AuditRecordResult> lstBindRrcord = lstRrcord.Where(b => b.IsCurrent == 0).ToList();
            #region 绑定表格
            int seqNo = 1;
            foreach (WF_AuditRecordResult info in lstBindRrcord)
            {
                info.SeqNo = seqNo;
                seqNo++;
            }
            this.dgvMain.DataSource = lstBindRrcord;
            #endregion
            #region 获取单据编号和审核状态
            WF_AuditRecordResult findRecord = lstRrcord.Find(b => b.IsCurrent == 1);
            txtBillNo.Text = (lstRrcord.Count <= 0 ? "" : lstRrcord[0].SourceBillNo);
            txtApproveStatus.Text = a.ApproveStatus;
            if (findRecord == null)
            {
                txtCurrentCheckMan.Text = "";
            }
            else
            {
                txtCurrentCheckMan.Text = findRecord.AuditEmpNames;
            }
            #endregion
            #region 设置按钮状态
            List<WF_AuditRecordResult> lstAudit = a.WF_AuditRecordResultList;
            if (lstAudit == null && lstAudit.Count <= 0)//未提交
            {
                this.btnSubmit.Enabled = true;//提交
                this.btnReturn.Enabled = false;//收回
                this.btnNoPass.Enabled = false;//拒绝
                this.btnCancelCheck.Enabled = false;//驳回
                this.btnArgee.Enabled = false;//同意
            }
            else
            {
                int countNum = lstAudit.Where(b => b.IsCurrent.ToInt32() > 0).Count();
                if (countNum > 0)//已提交待审核
                {
                    this.btnSubmit.Enabled = false;//提交
                    this.btnReturn.Enabled = true;//收回
                    this.btnNoPass.Enabled = true;//拒绝
                    this.btnCancelCheck.Enabled = true;//驳回
                    this.btnArgee.Enabled = true;//同意
                    if (lstAudit.Where(b => b.AuditEmpIDs.IndexOf("," + this.SessionInfo.UserID + ",") >= 0).Count() <= 0)
                    {
                        this.btnNoPass.Enabled = false;//拒绝
                        this.btnCancelCheck.Enabled = false;//驳回
                        this.btnArgee.Enabled = false;//同意
                    }
                }
                else //已提交待审核
                {
                    if (a.BillStatus.ToLower() == "new")
                    {
                        this.btnSubmit.Enabled = true;//提交
                        this.btnReturn.Enabled = false;//收回
                        this.btnNoPass.Enabled = false;//拒绝
                        this.btnCancelCheck.Enabled = false;//驳回
                        this.btnArgee.Enabled = false;//同意
                    }
                    else if (a.BillStatus.ToLower() == "complete")
                    {
                        this.btnSubmit.Enabled = false;//提交
                        this.btnReturn.Enabled = false;//收回
                        this.btnNoPass.Enabled = false;//拒绝
                        this.btnCancelCheck.Enabled = false;//驳回
                        this.btnArgee.Enabled = false;//同意
                    }
                    else if (a.BillStatus.ToLower() == "nopass")
                    {
                        this.btnSubmit.Enabled = false;//提交
                        this.btnReturn.Enabled = false;//收回
                        this.btnNoPass.Enabled = false;//拒绝
                        this.btnCancelCheck.Enabled = false;//驳回
                        this.btnArgee.Enabled = false;//同意
                    }
                }
            }
            #endregion
        }
        private void dgvMain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnArgee_Click(object sender, EventArgs e)
        {
            ExeAudit("同意");
        }
        void ExeAudit(string auditResult)
        {
            if (BeforePassEvent != null)
            {
                if (!BeforePassEvent())
                {
                    return;
                }
            }
            WF_AuditRecordLogic logicWF = new WF_AuditRecordLogic(this);
            WCFAddUpdateResult rstAudit = logicWF.AuditBill(new Entity.UserModel.WF.WF_AuditRecordParam()
            {
                SourceTableEngName = _tableName,
                SourceBillGuid = _sourceGuidKey,
                SourceBillNo = _sourceBillNo,
                AuditResult = auditResult,
                AuditRemark = txtCheckRemark.Text
            });
            if (rstAudit.Key > 0)
            {
                if (AfterPassEvent != null)
                {
                    AfterPassEvent();
                }
                this.Close();
            }
        }

        private void frmAuditRecordList_Load(object sender, EventArgs e)
        {
            BindData(1);
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要驳回相关单据吗?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            ExeAudit("驳回");
        }
        private void btnCancelCheck_Click(object sender, EventArgs e)
        {
            WF_AuditRecordLogic logicWF = new WF_AuditRecordLogic(this);
            WCFAddUpdateResult rstAudit = logicWF.TakeBackBill(new Entity.UserModel.WF.WF_AuditRecordParam()
            {
                SourceTableEngName = _tableName,
                SourceBillGuid = _sourceGuidKey,
            });
            if (rstAudit.Key > 0)
            {
                if (AfterPassEvent != null)
                {
                    AfterPassEvent();
                }
                this.Close();
            }
        }
        private void btnNoPass_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要拒绝相关单据吗?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            ExeAudit("拒绝");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (BeforePassEvent != null)
            {
                if (!BeforePassEvent())
                {
                    return;
                }
            }
            WF_AuditRecordLogic logicWF = new WF_AuditRecordLogic(this);
            WCFAddUpdateResult rstAudit = logicWF.SubmitBill(new Entity.UserModel.WF.WF_AuditRecordParam()
            {
                SourceTableEngName = _tableName,
                SourceBillGuid =_sourceGuidKey,
                SourceBillNo =_sourceBillNo
            });
            if (rstAudit.Key > 0)
            {
                if (AfterPassEvent != null)
                {
                    AfterPassEvent();
                }
                this.Close();
            }
            
        }
    }
}
