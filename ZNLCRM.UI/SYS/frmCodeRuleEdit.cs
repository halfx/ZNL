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
using ZNLCRM.UI.Logic.Sys;
using ZNLCRM.Entity.UserModel.Common;

namespace ZNLCRM.UI.SYS
{
    public partial class frmCodeRuleEdit : frmBaseEditForm
    {
        public int _ruleID;
        public frmCodeRuleEdit(int key)
        {
            InitializeComponent();
            _ruleID = key;
            this.GetEditEntity += new dlgGetEditEntity(Form_GetEditEntity);
        }
        #region 装载数据和设置界面状态
        void LoadData()
        {
            if (_ruleID == -1) return;
            SYS_CredentialCodeRuleLogic logic = new SYS_CredentialCodeRuleLogic(this);
            SYS_CredentialCodeRuleResult rst = logic.GetInfo(new SYS_CredentialCodeRuleParam()
            {
                RuleID = _ruleID
            });
            if (rst == null) return;

            this.ConvertEntityToControl(this.grpMain.Controls, rst, null);
            this.EditBeforeData = rst;
        }
        #endregion
        #region 实现基类获取实体信息方法
        object Form_GetEditEntity()
        {
            SYS_CredentialCodeRuleResult info = new SYS_CredentialCodeRuleResult();
            info.RuleID = _ruleID;
            info = this.ConvertControlToEntity<SYS_CredentialCodeRuleResult>(this.grpMain.Controls, info, null);
            //info = this.ConvertControlToEntity<SYS_CredentialCodeRuleResult>(this.grpContext.Controls, info, null);
            //info = this.ConvertControlToEntity<SYS_CredentialCodeRuleResult>(this.panEditInfo.Controls, info, null);

            //if (this.chkJobType1.Checked) info.JobType = "日报";
            //if (this.chkJobType2.Checked) info.JobType = "周报";
            //if (this.chkJobType3.Checked) info.JobType = "月报";

            this.SetDataIsChanged<SYS_CredentialCodeRuleResult>(info);
            return info;
        }
        #endregion

        private void frmCodeRuleEdit_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SYS_CredentialCodeRuleResult info = Form_GetEditEntity() as SYS_CredentialCodeRuleResult;
            if (!this.DataIsChanged)
            {
                this.ShowNoChangedMsg();
                return;
            }
            SYS_CredentialCodeRuleLogic logic = new SYS_CredentialCodeRuleLogic(this);
            WCFAddUpdateResult pageList = this.AsyncExecute<WCFAddUpdateResult, SYS_CredentialCodeRuleResult>(info, logic.AddOrUpdate, SaveComplete);
        }
        void SaveComplete(WCFAddUpdateResult a)
        {
            if (a.Key >0)
            {
                this.SaveComplete(a, this.grpMain.Controls);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
