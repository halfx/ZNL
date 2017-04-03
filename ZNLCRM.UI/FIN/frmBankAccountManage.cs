using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZNLCRM.UI.Logic.Common;
using ZNLCRM.Utility;
using ZNLCRM.Entity.UserModel.FIN;
using ZNLCRM.UI.Logic.FIN;
using ZNLCRM.Entity.UserModel;
using ZNLCRM.Entity.UserModel.Common;
using ZNLFrame.Entity;
using ZNLCRM.Entity.UserModel.Sys;
using ZNLCRM.UI.Logic.Sys;
using ZNLCRM.UI.HR;
using ZNLCRM.Entity.UserModel.HR;
using ZNLCRM.Utility.CommonEnum;
namespace ZNLCRM.UI.FIN
{
    public partial class frmBankAccountManage : frmBaseForm
    {
        int cbid = 0;
        FIN_CashBankAccountLogic accountLogic = null;
        SYS_DictItemLineLogic dictLineLogic = null;
        public frmBankAccountManage()
        {
            InitializeComponent();
            accountLogic = new FIN_CashBankAccountLogic(this);
            dictLineLogic = new SYS_DictItemLineLogic(this);
        }

      

        #region 清除内容
        private void ClearContent()
        {
            txtCBNo.Text = string.Empty;
            txtCBID.Text = string.Empty;
            txtCBName.Text = string.Empty;
            cboCurrency.Text = string.Empty;
            txtBCode.Text = string.Empty;
            txtBTelephone.Text = string.Empty;
            txtBFax.Text = string.Empty;
            txtBAddress.Text = string.Empty;
            txtManagerID.Text = string.Empty;
            txtManagerName.Text = string.Empty;
            chkFrozen.Checked = false;
        }
        #endregion

        #region 添加账号
        private void tsbAddAccount_Click(object sender, EventArgs e)
        {
            this.ShowEditWindow("添加银行账号", panelAccount);
            ClearContent();
        }
        #endregion

        #region 修改账号
        private void tsbEditAccount_Click(object sender, EventArgs e)
        {
            ClearContent();
            
            txtCBID.Text = cbid.ToStringHasNull();
            if (txtCBID.Text.ToInt32()>0)
            {
                ShowEditWindow("编辑银行账号", panelAccount);
                FIN_CashBankAccountResult info = new FIN_CashBankAccountResult();
                info = accountLogic.GetInfo(new FIN_CashBankAccountParam() { CBID = int.Parse(txtCBID.Text) });
                this.ConvertEntityToControl<FIN_CashBankAccountResult>(this.panelAccount.Controls, info, null);
            }
            else
                ShowMessage("请选择需要修改的银行账号！");
        }
        #endregion

        #region 保存账号
        private void btnSave_Click(object sender, EventArgs e)
        {
            FIN_CashBankAccountResult info = new FIN_CashBankAccountResult();

            info = this.ConvertControlToEntity<FIN_CashBankAccountResult>(this.panelAccount.Controls, info, null);
            WCFAddUpdateResult result = this.AsyncExecute<WCFAddUpdateResult, FIN_CashBankAccountResult>(info, accountLogic.AddOrUpdate, a =>
            {
                if (a.Key > 0)
                {
                    this.HidEditWindow();
                    BindDataGrid();
                }
            });
        }
        #endregion

        #region 绑定下拉框
        private void BindComboBox()
        {

            List<SYS_DictItemLineResult> itemLineList = dictLineLogic.GetListByCode(new SYS_DictItemLineParam
            {
                ItemCodes = new string[] { "Curreny" }
            });
            dictLineLogic.BindComboBox(cboCurrency,  "Curreny" , itemLineList);
        }
        #endregion

        #region  绑定列表
        private void BindDataGrid()
        { 
             FIN_CashBankAccountParam param=new FIN_CashBankAccountParam ();
             param.CBNo = txtSCBNo.Text;
             param.CBName = txtSCBName.Text;
             PageList<FIN_CashBankAccountResult> rst = this.AsyncExecute<PageList<FIN_CashBankAccountResult>, FIN_CashBankAccountParam>(param, accountLogic.GetPageList, a => {
                 if (a.ResultList != null)
                 {
                     dgvAccount.DataSource = a.ResultList;
                 }
             
             });
        }
        #endregion

        private void ucToolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void frmBankAccountManage_Load(object sender, EventArgs e)
        {
            BindComboBox();
            BindDataGrid();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            BindDataGrid();
        }

        #region 删除账号
        private void tsbDelAccount_Click(object sender, EventArgs e)
        {
            FIN_CashBankAccountParam param = new FIN_CashBankAccountParam();
            param.CBID = cbid;

            FIN_CashBankAccountResult rst = accountLogic.GetInfo(param);
            if (rst != null)
            {
                if (MessageBox.Show("请确认是否要删除银行账号：【" + rst.CBNo + "】", "操作提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    WCFAddUpdateResult result = this.AsyncExecute<WCFAddUpdateResult, FIN_CashBankAccountParam>(param, accountLogic.DelInfo, (a) => { BindDataGrid(); });
                }
            }
            else
            {
                this.ShowMessage("请选择需要删除的银行账号！");
            }
        }
        #endregion 

        #region 冻结账户
        private void tsbFrozenAccount_Click(object sender, EventArgs e)
        {

            List<FIN_CashBankAccountResult> rstList = new List<FIN_CashBankAccountResult>();
            foreach (DataGridViewRow dgvRow in dgvAccount.Rows)
            {
                if (dgvRow.Cells["colSelect"].Value.ToBooleanHasNull())
                {
                    FIN_CashBankAccountResult result = new FIN_CashBankAccountResult();
                    result.IsFrozen = true;
                    result.CBID = dgvRow.Cells["colCBID"].Value.ToInt32();
                    rstList.Add(result);
                }
            }
            WCFAddUpdateResult wcfResult = this.AsyncExecute<WCFAddUpdateResult, List<FIN_CashBankAccountResult>>(rstList, accountLogic.UpdateOrInsertList, (a) => { if(a.Key>0)BindDataGrid(); });
        }
        #endregion

        private void dgvAccount_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                cbid = dgvAccount.Rows[e.RowIndex].Cells["colCBID"].Value.ToInt32();
            }
        }

        private void txtManagerName_ButtonCustomClick(object sender, EventArgs e)
        {
            frmSelectEmp frmSelectEmp = new frmSelectEmp(false);

            frmSelectEmp.empIds = txtManagerID.Text.Split(',').Select(a => (int?)a.ToInt32()).ToArray();
            DialogResult rst = frmSelectEmp.ShowDialog();
            if (rst == DialogResult.OK)
            {
                List<HR_EmployeeResult> rstList = frmSelectEmp.GetSelectList<HR_EmployeeResult>();
                if (rstList != null && rstList.Count > 0)
                {
                    txtManagerID.Text = string.Join(",", rstList.Select(a => a.EmpID).ToArray());
                    txtManagerName.Text = string.Join(",", rstList.Select(a => a.EmpName).ToArray());
                }

            }
        }

        private void txtManagerName_ButtonCustom2Click(object sender, EventArgs e)
        {
            txtManagerID.Text = string.Empty;
            txtManagerName.Text = string.Empty;
        }
    }
}
