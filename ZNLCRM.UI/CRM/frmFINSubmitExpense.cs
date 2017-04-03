using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZNLCRM.Entity.UserModel.FIN;
using ZNLCRM.UI.HR;
using ZNLCRM.Entity.UserModel.HR;
using ZNLCRM.Utility;
using ZNLCRM.UI.Logic.Common;
using ZNLCRM.Entity.UserModel.Common;
using ZNLCRM.Entity.DBModel;
using ZNLCRM.UI.Logic.FIN;
using ZNLCRM.Entity.UserModel.CRM;

namespace ZNLCRM.UI.CRM
{
    public partial class frmFINSubmitExpense : frmBaseEditForm
    {
        public int expID = 0;
        public Guid custVstPlnGuID;
        public string billNo = string.Empty;
        BindingSource bsExpenseLine = new BindingSource();
        List<FIN_SubmitExpenseLineResult> tempList = new List<FIN_SubmitExpenseLineResult>();
        List<FIN_SubmitExpenseLineResult> delList = new List<FIN_SubmitExpenseLineResult>();
        List<FIN_SubmitExpenseLineResult> addOrModifyList = new List<FIN_SubmitExpenseLineResult>();
        FIN_SubmitExpenseLogic expenseLogic = null;
        public frmFINSubmitExpense()
        {
            InitializeComponent();
            this.GetEditEntity += new dlgGetEditEntity(Form_GetEditEntity);
            expenseLogic = new FIN_SubmitExpenseLogic(this);
        }

        #region 实现基类获取实体信息方法
        object Form_GetEditEntity()
        {
            FIN_SubmitExpenseResult info = new FIN_SubmitExpenseResult();
            info.ExpID = expID;
            info = this.ConvertControlToEntity<FIN_SubmitExpenseResult>(this.panelExpense.Controls, info, null);
            this.SetDataIsChanged<FIN_SubmitExpenseResult>(info);
            return info;
        }
        #endregion

        public void InitData() {

            if (expID > 0)
            {
                FIN_SubmitExpenseResult info = expenseLogic.GetInfo(new FIN_SubmitExpenseParam { ExpID = expID });
                this.ConvertEntityToControl<FIN_SubmitExpenseResult>(this.panelExpense.Controls, info, null);
                if (info != null && info.ExpenseLineList != null)
                {
                    addOrModifyList = info.ExpenseLineList;
                }
            }
            else
            {
                txtSourceBillNo.Text = billNo;
                txtSourceGuid.Text = custVstPlnGuID.ToStringHasNull();
                this.txtOpDate.Text = ZNLCRM.UI.Logic.Sys.Common.GetServerNow(false);
                this.txtOpEmpID.Text = this.SessionInfo.UserID.ToStringHasNull();
                this.txtOpEmpName.Text = this.SessionInfo.UserName;
            }

            bsExpenseLine.DataSource = addOrModifyList;
            dgvExpenseLine.DataSource = bsExpenseLine;
        
        }

        #region 查找关联单号
        private void txtSourceBillNo_ButtonCustomClick(object sender, EventArgs e)
        {
            
        }
        #endregion

        #region 查找所属人员
        private void txtOpEmpName_ButtonCustomClick(object sender, EventArgs e)
        {
            frmSelectEmp frmSelectEmp = new frmSelectEmp(false);

            frmSelectEmp.empIds = txtOpEmpID.Text.Split(',').Select(a => (int?)a.ToInt32()).ToArray();

            DialogResult rst = frmSelectEmp.ShowDialog();
            if (rst == DialogResult.OK)
            {
                List<HR_EmployeeResult> rstList = frmSelectEmp.GetSelectList<HR_EmployeeResult>();
                if (rstList != null && rstList.Count > 0)
                {
                    txtOpEmpID.Text = string.Join(",", rstList.Select(a => a.EmpID).ToArray());
                    txtOpEmpName.Text = string.Join(",", rstList.Select(a => a.EmpName).ToArray());
                }

            }
        }
        #endregion


        #region 添加
        private void tsbAdd_Click(object sender, EventArgs e)
        {
            bsExpenseLine.AddNew();
        }
        #endregion

        private void tsbDel_Click(object sender, EventArgs e)
        {
            if (this.bsExpenseLine.Current != null)
            {

                int expLineID = 0;
                FIN_SubmitExpenseLineResult delResult = this.bsExpenseLine.Current as FIN_SubmitExpenseLineResult;
                expLineID = delResult.ExpLineID.ToInt32();
                if (expLineID > 0)
                {
                    delResult.IsDeleted = true;
                    delList.Add(delResult);
                }
                bsExpenseLine.RemoveCurrent();

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            FIN_SubmitExpenseResult info = Form_GetEditEntity() as FIN_SubmitExpenseResult;
            if (!this.DataIsChanged)
            {
                this.ShowNoChangedMsg();
                return;
            }
            bool flag = false;
            foreach (FIN_SubmitExpenseLineResult rst in addOrModifyList)
            {
                if (string.IsNullOrEmpty(rst.ExpName) || string.IsNullOrEmpty(rst.Amount.ToStringHasNull()))
                {
                    flag = true;
                    break;
                }
            }
            if (flag)
            {
                this.ShowMessage("费用名目和报销金额不能为空！");
                return;
            }



            bsExpenseLine.EndEdit();
            tempList.Clear();
            foreach (FIN_SubmitExpenseLineResult rst in addOrModifyList)
            {
                if (rst.HasChanged())
                {
                    tempList.Add(rst);
                }
            }

            tempList.AddRange(delList);
            info.ExpenseLineList = tempList;
            WCFAddUpdateResult result = this.AsyncExecute<WCFAddUpdateResult, FIN_SubmitExpenseResult>(info, expenseLogic.AddOrUpdate, (a) =>
            {
                expID = a.Key;
                this.SetDataIsNoChanged();
                InitData();
                delList.Clear();
            });
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmFINSubmitExpense_Load(object sender, EventArgs e)
        {
            InitData();
        }
        #region 
        private void dgvExpenseLine_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            decimal amount =0;
            decimal chkAmount = 0;
            if (e.RowIndex > -1 && (dgvExpenseLine.Columns[e.ColumnIndex].Name == "colExpName"
                || dgvExpenseLine.Columns[e.ColumnIndex].Name == "colAmount" || dgvExpenseLine.Columns[e.ColumnIndex].Name=="colChkAmount"))
            {
                foreach (DataGridViewRow row in dgvExpenseLine.Rows)
                {
                    if (!string.IsNullOrEmpty(row.Cells["colExpName"].Value.ToStringHasNull()))
                    {
                        amount += row.Cells["colAmount"].Value.ToDecimal();
                        chkAmount += row.Cells["colChkAmount"].Value.ToDecimal();
                    }
                }
            }
            txtAmount.Text = amount.ToStringHasNull();
            txtChkAmount.Text = chkAmount.ToStringHasNull();
        }
        #endregion
    }
}
