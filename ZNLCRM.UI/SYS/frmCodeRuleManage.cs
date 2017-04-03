using System;
using System.Windows.Forms;
using ZNLCRM.UI.Logic.Common;
using ZNLCRM.UI.Logic.Sys;
using ZNLCRM.Entity.UserModel.Sys;
using ZNLFrame.Entity;
using ZNLCRM.Utility;
using ZNLCRM.Entity.UserModel.Common;

namespace ZNLCRM.UI.SYS
{
    public partial class frmCodeRuleManage : frmBaseManageForm
    {
        public frmCodeRuleManage()
        {
            InitializeComponent();
            //BindData(1);
        }
        void BindData(int pageIndex)
        {
            SYS_CredentialCodeRuleLogic logic = new SYS_CredentialCodeRuleLogic(this);
            SYS_CredentialCodeRuleParam param = new SYS_CredentialCodeRuleParam();
            param = this.ConvertControlToEntity<SYS_CredentialCodeRuleParam>(this.panTop.Controls, param, null);
            param.PageIndex = pageIndex;
            param.PageSize = this.pagMain.PageSize;
            param.IsPage = true;
            PageList<SYS_CredentialCodeRuleResult> pageList = this.AsyncExecute<PageList<SYS_CredentialCodeRuleResult>, SYS_CredentialCodeRuleParam>(param, logic.GetPageList, BindDataComplete);
        }
        void BindDataComplete(PageList<SYS_CredentialCodeRuleResult> a)
        {
            this.dgvMain.DataSource = a.ResultList;
            this.pagMain.RecordCount = a.TotalCount.ToInt32();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            BindData(1);
        }
        private void tlbMain_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            #region 新增
            if (e.ClickedItem.Name == "tlbAdd")
            {
                frmCodeRuleEdit frmEdit = new frmCodeRuleEdit(-1);
                frmEdit.ShowDialog();
            }
            #endregion
            #region 修改
            else if (e.ClickedItem.Name == "tlbEdit")
            {
                editData();
            }
            #endregion
            #region 删除
            if (e.ClickedItem.Name == "tlbDel")
            {
                int rowIdx = this.dgvMain.CurrentCell == null ? -1 : this.dgvMain.CurrentCell.RowIndex;
                if (rowIdx < 0)
                {
                    this.ShowMessage("请指定要删除记录！");
                    return;
                }
                int _ruleID = this.dgvMain["col_SYS_CredentialCodeRule_RuleID", rowIdx].Value.ToInt32();
                SYS_CredentialCodeRuleLogic logic = new SYS_CredentialCodeRuleLogic(this);
                WCFAddUpdateResult rst = logic.DelInfo(new SYS_CredentialCodeRuleParam() { RuleID = _ruleID });
                if (rst.Key > 0)
                {
                    BindData(this.pagMain.PageIndex);
                }
            }
            #endregion
        }
        void editData()
        {
            int rowIdx = this.dgvMain.CurrentCell == null ? -1 : this.dgvMain.CurrentCell.RowIndex;
            if (rowIdx < 0)
            {
                this.ShowMessage("请指定要修改记录！");
                return;
            }
            int Key = this.dgvMain["col_SYS_CredentialCodeRule_RuleID", rowIdx].Value.ToInt32();
            frmCodeRuleEdit frmEdit = new frmCodeRuleEdit(Key);
            frmEdit.ShowDialog();
        }

        private void frmCodeRuleManage_Load(object sender, EventArgs e)
        {
            BindData(1);
        }

        private void dgvMain_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            editData();
        }
    }
}
