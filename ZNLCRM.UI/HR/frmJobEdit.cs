using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZNLCRM.UI.Logic.Common;
using ZNLCRM.Entity.UserModel.Sys;
using ZNLCRM.Entity.UserModel.HR;
using ZNLCRM.UI.Logic.HR;
using ZNLCRM.Entity.UserModel.Common;
using ZNLCRM.Utility;
using ZNLCRM.Entity.UserModel.CRM;
using ZNLCRM.UI.Logic.WF;
using ZNLCRM.Entity.UserModel.WF;
using ZNLCRM.UI.WF;

namespace ZNLCRM.UI.HR
{
    public partial class frmJobEdit : frmBaseEditForm
    {

        string _jobType = "日报";

        public frmJobEdit(string jobType, Guid? guidKey)
        {
            InitializeComponent();
            _jobType = !string.IsNullOrEmpty(jobType) ? jobType : "日报";
            GuidKey = guidKey;
            this.GetEditEntity += new dlgGetEditEntity(Form_GetEditEntity);
        }
        private void frmJobEdit_Load(object sender, EventArgs e)
        {
            SetWin();
            LoadData();
        }
        #region 装载数据和设置界面状态
        void SetWin()
        {
            this.chkJobType1.Enabled = false;
            this.chkJobType2.Enabled = false;
            this.chkJobType3.Enabled = false;

            this.chkJobType1.Checked = false;
            this.chkJobType2.Checked = false;
            this.chkJobType3.Checked = false;

            if (_jobType == "日报") this.chkJobType1.Checked = true;
            else if (_jobType == "周报") this.chkJobType2.Checked = true;
            else if (_jobType == "月报") this.chkJobType3.Checked = true;

        }
        void LoadData()
        {
            if (GuidKey == null) return;
            CRM_JobMastLogic logic = new CRM_JobMastLogic(this);
            CRM_JobMastResult rst = logic.GetInfo(new CRM_JobMastParam()
            {
                EmpJobGuid = GuidKey
            });
            if (rst == null) return;

            this.ConvertEntityToControl(this.grpMain.Controls, rst, null);
            this.ConvertEntityToControl(this.grpContext.Controls, rst, null);
            this.ConvertEntityToControl(this.panEditInfo.Controls, rst, null);
            this.CheckIsReadOnly<CRM_JobMastResult>(rst);
            this.CheckAuditStatus<CRM_JobMastResult>(rst, this.grpMain, this.grpContext, this.panEditInfo);
            this.chkJobType1.Checked = false;
            this.chkJobType2.Checked = false;
            this.chkJobType3.Checked = false;

            if (rst.JobType == "日报") this.chkJobType1.Checked = true;
            if (rst.JobType == "周报") this.chkJobType2.Checked = true;
            if (rst.JobType == "月报") this.chkJobType3.Checked = true;
            this.EditBeforeData = rst;

            CheckAuditButton("CRM_JobMast", GuidKey, this.btnSubmit,this.btnTakeBack, this.btnCheck,this.btnCancelCheck);
            this.DataIsChanged = false;
        }
        #endregion
        #region 实现基类获取实体信息方法
        object Form_GetEditEntity()
        {
            CRM_JobMastResult info = new CRM_JobMastResult();
            info.EmpJobGuid = GuidKey;
            info = this.ConvertControlToEntity<CRM_JobMastResult>(this.grpMain.Controls, info, null);
            info = this.ConvertControlToEntity<CRM_JobMastResult>(this.grpContext.Controls, info, null);
            info = this.ConvertControlToEntity<CRM_JobMastResult>(this.panEditInfo.Controls, info, null);

            if (this.chkJobType1.Checked) info.JobType = "日报";
            if (this.chkJobType2.Checked) info.JobType = "周报";
            if (this.chkJobType3.Checked) info.JobType = "月报";

            this.SetDataIsChanged<CRM_JobMastResult>(info);
            return info;
        }
        #endregion

        private void btnSave_Click(object sender, EventArgs e)
        {
            CRM_JobMastResult info = Form_GetEditEntity() as CRM_JobMastResult;
            if (!this.DataIsChanged)
            {
                this.ShowNoChangedMsg();
                return;
            }
            CRM_JobMastLogic logic = new CRM_JobMastLogic(this);
            WCFAddUpdateResult pageList = this.AsyncExecute<WCFAddUpdateResult, CRM_JobMastResult>(info, logic.AddOrUpdate, SaveComplete);
        }
        void SaveComplete(WCFAddUpdateResult a)
        {
            if (a.KeyGuid != null)
            {
                this.SaveComplete(a, this.panEditInfo.Controls, this.grpMain.Controls);
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            CRM_JobMastResult info = Form_GetEditEntity() as CRM_JobMastResult;
            WCFAddUpdateResult rst = new WCFAddUpdateResult();
            if (this.DataIsChanged)
            {
                CRM_JobMastLogic logic = new CRM_JobMastLogic(this);
                rst = logic.AddOrUpdate(info);
            }
            else
            {
                rst.KeyGuid = info.EmpJobGuid;
            }
            if (rst.KeyGuid != null)
            {
                WF_AuditRecordLogic logicWF = new WF_AuditRecordLogic(this);
                WCFAddUpdateResult rstAudit = logicWF.SubmitBill(new Entity.UserModel.WF.WF_AuditRecordParam()
                {
                    SourceTableEngName = "CRM_JobMast",
                    SourceBillGuid = info.EmpJobGuid,
                    SourceBillNo = info.BillNo
                });
                if (rstAudit.Key > 0)
                {
                    LoadData();
                    this.ShowMessage("提交成功!");
                }
            }
        }
        private void btnCheck_Click(object sender, EventArgs e)
        {
            //frmAuditRecordList frmRecord = new frmAuditRecordList("CRM_JobMast", GuidKey, this.txtBillNo.Text);
            //frmRecord.BeforePassEvent = SaveData;
            //frmRecord.AfterPassEvent = LoadData;
            //frmRecord.ShowDialog();
            CRM_JobMastResult info = Form_GetEditEntity() as CRM_JobMastResult;
            this.WF_CheckBill("CRM_JobMast", info.BillNo, info.EmpJobGuid, this.DataIsChanged, SaveData, LoadData);

        }
        bool SaveData()
        {
            bool ret=false;
            CRM_JobMastResult info = Form_GetEditEntity() as CRM_JobMastResult;
            WCFAddUpdateResult rst = new WCFAddUpdateResult();
            if (this.DataIsChanged)
            {
                CRM_JobMastLogic logic = new CRM_JobMastLogic(this);
                rst = logic.AddOrUpdate(info);
            }
            else
            {
                rst.KeyGuid = info.EmpJobGuid;
            }
            if (rst.KeyGuid != null) ret = true;
            else ret = false;
            return ret;
        }

        private void btnCancelCheck_Click(object sender, EventArgs e)
        {
            CRM_JobMastResult info = Form_GetEditEntity() as CRM_JobMastResult;
            WCFAddUpdateResult rst = new WCFAddUpdateResult();
            if (GuidKey != null)
            {
                WF_AuditRecordLogic logicWF = new WF_AuditRecordLogic(this);
                WCFAddUpdateResult rstAudit = logicWF.CancelBill(new Entity.UserModel.WF.WF_AuditRecordParam()
                {
                    SourceTableEngName = "CRM_JobMast",
                    SourceBillGuid = info.EmpJobGuid
                });
                if (rstAudit.Key > 0)
                {
                    LoadData();
                    this.ShowMessage("撤单成功!");
                }
            }
        }

        private void btnTakeBack_Click(object sender, EventArgs e)
        {
            CRM_JobMastResult info = Form_GetEditEntity() as CRM_JobMastResult;
            WCFAddUpdateResult rst = new WCFAddUpdateResult();
            if (GuidKey != null)
            {
                WF_AuditRecordLogic logicWF = new WF_AuditRecordLogic(this);
                WCFAddUpdateResult rstAudit = logicWF.TakeBackBill(new Entity.UserModel.WF.WF_AuditRecordParam()
                {
                    SourceTableEngName = "CRM_JobMast",
                    SourceBillGuid = info.EmpJobGuid
                });
                if (rstAudit.Key > 0)
                {
                    LoadData();
                    this.ShowMessage("收回成功!");
                }
            }
        }

        protected void CheckAuditButton(string tableName, Guid? sourceGuid
                    , Control conSubmit, Control conTakeBack, Control conAudit, Control conCancel)
        {
            #region 判断输入状态
            if (string.IsNullOrEmpty(tableName)) this.ShowMessage("请指定业务单据表名!");
            if (sourceGuid == null) this.ShowMessage("请指定业务单据ID!");
            if (conSubmit == null && conTakeBack == null && conAudit == null && conCancel == null) this.ShowMessage("请指定审批按钮!");
            #endregion
            #region 获取审批状态
            WF_AuditBillResult auditBillRst = new WF_AuditBillResult();
            WF_AuditRecordLogic recLogic = new WF_AuditRecordLogic(this);
            WF_AuditRecordParam param = new WF_AuditRecordParam();
            param.SourceTableEngName = tableName;
            param.SourceBillGuid = sourceGuid;
            auditBillRst = recLogic.GetAuditBillRecord(param);
            SetObjectPropertyValue(conSubmit, "Enabled", false);
            SetObjectPropertyValue(conAudit, "Enabled", false);
            SetObjectPropertyValue(conCancel, "Enabled", false);
            SetObjectPropertyValue(conTakeBack, "Enabled", false);
            if (auditBillRst == null) { this.ShowMessage("未定义当前单据审批流程!"); return; }
            #endregion
            #region 设置按钮状态
            List<WF_AuditRecordResult> lstAudit = auditBillRst.WF_AuditRecordResultList;
            if (lstAudit == null && lstAudit.Count <= 0)//未提交
            {
                SetObjectPropertyValue(conSubmit, "Enabled", true);
                SetObjectPropertyValue(conAudit, "Enabled", false);
                SetObjectPropertyValue(conCancel, "Enabled", false);
                SetObjectPropertyValue(conTakeBack, "Enabled", false);
            }
            else
            {
                int countNum = lstAudit.Where(a => a.IsCurrent.ToInt32() > 0).Count();
                if (countNum > 0)//已提交待审核
                {
                    SetObjectPropertyValue(conSubmit, "Enabled", false);
                    SetObjectPropertyValue(conAudit, "Enabled", true);
                    SetObjectPropertyValue(conCancel, "Enabled", true);
                    SetObjectPropertyValue(conTakeBack, "Enabled", true);
                    if (lstAudit.Where(a => a.AuditEmpIDs.IndexOf("," + this.SessionInfo.UserID + ",") >= 0).Count() <= 0)
                    {
                        SetObjectPropertyValue(conAudit, "Enabled", false);
                    }
                }
                else //已提交待审核
                {
                    if (auditBillRst.BillStatus.ToLower() == "new")
                    {
                        SetObjectPropertyValue(conSubmit, "Enabled", true);
                        SetObjectPropertyValue(conAudit, "Enabled", true);
                        SetObjectPropertyValue(conCancel, "Enabled", false);
                        SetObjectPropertyValue(conTakeBack, "Enabled", false);
                    }
                    else if (auditBillRst.BillStatus.ToLower() == "complete")
                    {
                        SetObjectPropertyValue(conSubmit, "Enabled", false);
                        SetObjectPropertyValue(conAudit, "Enabled", true);
                        SetObjectPropertyValue(conCancel, "Enabled", true);
                        SetObjectPropertyValue(conTakeBack, "Enabled", false);
                    }
                    else if (auditBillRst.BillStatus.ToLower() == "nopass")
                    {
                        SetObjectPropertyValue(conSubmit, "Enabled", false);
                        SetObjectPropertyValue(conAudit, "Enabled", true);
                        SetObjectPropertyValue(conCancel, "Enabled", true);
                        SetObjectPropertyValue(conTakeBack, "Enabled", false);
                    }

                }
            }
            #endregion
        }
    }
}
