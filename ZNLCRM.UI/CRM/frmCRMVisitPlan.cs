using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZNLCRM.UI.Logic.Common;
using ZNLCRM.Entity.UserModel.CRM;
using ZNLFrame.Entity;
using ZNLCRM.Entity.UserModel.Sys;
using ZNLCRM.UI.Logic.Sys;
using ZNLCRM.UI.Logic.CRM;
using ZNLCRM.Utility;
using ZNLCRM.Entity.UserModel.Common;
using ZNLCRM.UI.HR;
using ZNLCRM.Entity.UserModel.HR;
using ZNLCRM.Entity.UserModel.FIN;
using ZNLCRM.UI.Logic.FIN;

namespace ZNLCRM.UI.CRM
{
   
    public partial class frmCRMVisitPlan : frmBaseEditForm
    {
        public delegate void dlgRefreshParentForm();
        public event dlgRefreshParentForm RefreshParentForm;
        public  int custVstPlnID = 0;
        public Guid custVstPlnGuID;
        int custVstPlnLineID = 0;
        int expID = 0;
        SYS_DictItemLineLogic dictLineLogic = null;
        CRM_VisitPlanLogic cvpLogic = null;
        CRM_VisitPlanLineLogic cvpLineLogic = null;
        FIN_SubmitExpenseLogic expenseLogic = null;
        string important = string.Empty;
        
        public frmCRMVisitPlan()
        {
            InitializeComponent();
            this.GetEditEntity += new dlgGetEditEntity(Form_GetEditEntity);
            dictLineLogic = new SYS_DictItemLineLogic(this);
            cvpLogic = new CRM_VisitPlanLogic(this);
            cvpLineLogic = new CRM_VisitPlanLineLogic(this);
            expenseLogic = new FIN_SubmitExpenseLogic(this);
        }

        #region 实现基类获取实体信息方法
        object Form_GetEditEntity()
        {
            CRM_VisitPlanResult info = new CRM_VisitPlanResult();
            info.CustVstPlnID = custVstPlnID;
            info = this.ConvertControlToEntity<CRM_VisitPlanResult>(this.grpBase.Controls, info, null);
            info = this.ConvertControlToEntity<CRM_VisitPlanResult>(this.grpVst.Controls, info, null);
            if (!string.IsNullOrEmpty(important))
                info.Important = important;
            this.SetDataIsChanged<CRM_VisitPlanResult>(info);
            return info;
        }
        #endregion
        #region 保存
        private void btnSave_Click(object sender, EventArgs e)
        {
            CRM_VisitPlanResult info = Form_GetEditEntity() as CRM_VisitPlanResult;
           
            if (!this.DataIsChanged)
            {
                this.ShowNoChangedMsg();
                return;
            }
            WCFAddUpdateResult result = this.AsyncExecute<WCFAddUpdateResult, CRM_VisitPlanResult>(info, cvpLogic.AddOrUpdate, (a) =>
            {
                if (a.Key > 0)
                {
                    this.SetDataIsNoChanged();
                    custVstPlnID = a.Key;
                    custVstPlnGuID = a.KeyGuid.ToGuid();
                    InitData();
                }
            });
        }
        #endregion

        private void frmCRMVisitPlan_Load(object sender, EventArgs e)
        {
            rdoHight.CheckedChanged += radioButton_CheckedChanged;
            rdoCommon.CheckedChanged += radioButton_CheckedChanged;
            rdoLow.CheckedChanged += radioButton_CheckedChanged;
            BindComboBox();
            InitData();
        }

        #region 初始化绑定控件
        public void BindComboBox()
        {
            List<KeyValuePair<string, string>> kvList = new List<KeyValuePair<string, string>>();
            kvList.Insert(0,new KeyValuePair<string,string>("",""));
            kvList.Add(new KeyValuePair<string, string>("上门拜访", "上门拜访"));
            cboVstTyp.DataSource = kvList;
            cboVstTyp.DisplayMember = "Key";
            cboVstTyp.ValueMember = "Value";
           

        }
        #endregion

        #region 初始化加载数据
        public void InitData()
        {

            if (custVstPlnID > 0)
            {
                CRM_VisitPlanResult info = cvpLogic.GetInfo(new CRM_VisitPlanParam { CustVstPlnID = custVstPlnID });
                this.ConvertEntityToControl<CRM_VisitPlanResult>(this.grpBase.Controls, info, null);
                this.ConvertEntityToControl<CRM_VisitPlanResult>(this.grpVst.Controls, info, null);
                CRM_CompanyResult crmCompany = info.CrmCompany;
                if (crmCompany != null)
                {
                    txtCompanyName.Text = crmCompany.CompanyName;
                    txtWebSite.Text = crmCompany.WebSite;
                    txtEmail.Text = crmCompany.Email;
                }
                switch (info.Important)
                {
                    case "高":
                        rdoHight.Checked = true;
                        break;
                    case "普通":
                        rdoCommon.Checked = true;
                        break;
                    case "低":
                        rdoLow.Checked = true;
                        break;
                }
            }
            else
            {
                this.txtOpEmpID.Text = this.SessionInfo.UserID.ToStringHasNull();
                this.txtOpEmpName.Text = this.SessionInfo.UserName;
                txtStartDate.Text = Common.GetServerNow();
            }
            BindLineDataGridView();
            BindFeeDataGridView();
        }
        #endregion

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (!((RadioButton)sender).Checked)
            {
                return;
            }
            important=string.Empty;
            string text = ((RadioButton)sender).Text.ToStringHasNull();
            switch (text)
            {
                case "高":
                    important=text;
                    break;
                case "普通":
                    important=text;
                    break;
                case "低":
                    important=text;
                    break;
            }
        }

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

        private void txtCompanyName_ButtonCustomClick(object sender, EventArgs e)
        {
            frmSelectCustomer frmSelectCustomer = new frmSelectCustomer(false,null);
            DialogResult rst = frmSelectCustomer.ShowDialog();
            if (rst == DialogResult.OK)
            {
                List<CRM_CompanyResult> rstList = frmSelectCustomer.GetSelectList<CRM_CompanyResult>();
                if (rstList != null && rstList.Count > 0)
                {
                    txtCompanyGuID.Text = string.Join(",", rstList.Select(a => a.CompanyGuID).ToArray());
                    txtCompanyName.Text = string.Join(",", rstList.Select(a => a.CompanyName).ToArray());
                }

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (RefreshParentForm != null)
                RefreshParentForm();
            this.Close();

        }

        private void frmCRMVisitPlan_FormClosed(object sender, FormClosedEventArgs e)
        {
            //btnCancel_Click(sender, e);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            BindLineDataGridView();
        }

        private void tsbAddLine_Click(object sender, EventArgs e)
        {
            if (custVstPlnGuID != Guid.Empty)
            {
                frmCRMVisitPlanLine frmCRMVisitPlanLine = new frmCRMVisitPlanLine();
                frmCRMVisitPlanLine.custVstPlnGuID = custVstPlnGuID;
                frmCRMVisitPlanLine.BringToFront();
                frmCRMVisitPlanLine.ShowDialog();
            }
            else
                this.ShowMessage("请先保存拜访计划！");
        }

        private void tsbEditLine_Click(object sender, EventArgs e)
        {
            if (custVstPlnLineID > 0)
            {
                frmCRMVisitPlanLine frmCRMVisitPlanLine = new frmCRMVisitPlanLine();
                frmCRMVisitPlanLine.custVstPlnGuID = custVstPlnGuID;
                frmCRMVisitPlanLine.custVstPlnLineID = custVstPlnLineID;
                frmCRMVisitPlanLine.BringToFront();
                frmCRMVisitPlanLine.ShowDialog();
            }
        }
        private void BindLineDataGridView()
        {
            CRM_VisitPlanLineParam param = new CRM_VisitPlanLineParam();
            param.CustVstPlnGuID = custVstPlnGuID;
            param.VstName = txtVstName.Text.Trim();
            List<CRM_VisitPlanLineResult> lineList = this.AsyncExecute<List<CRM_VisitPlanLineResult>, CRM_VisitPlanLineParam>(param, cvpLineLogic.GetList, a =>
            {
                dgvLine.DataSource = a;

            });
            
        }
        private void BindFeeDataGridView()
        {
            FIN_SubmitExpenseParam param = new FIN_SubmitExpenseParam();
            param.SourceGuid = custVstPlnGuID;
            param.ExpName = txtExpName.Text.Trim();
            List<FIN_SubmitExpenseResult> lineList = this.AsyncExecute<List<FIN_SubmitExpenseResult>,FIN_SubmitExpenseParam>(param, expenseLogic.GetList, a =>
            {
                dgvFee.DataSource=a;

            });
        }
        
        private void dgvLine_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                custVstPlnLineID = dgvLine["colCustVstPlnLineID", e.RowIndex].Value.ToInt32();
                
            }
        }

        private void dgvLine_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tsbEditLine_Click(sender, e);
        }

        #region 添加费用
        private void tsbAddExpense_Click(object sender, EventArgs e)
        {
            if (custVstPlnGuID != Guid.Empty)
            {
                frmFINSubmitExpense frmFINSubmitExpense = new frmFINSubmitExpense();
                frmFINSubmitExpense.custVstPlnGuID = custVstPlnGuID;
                frmFINSubmitExpense.billNo = txtBillNo.Text;
                frmFINSubmitExpense.ShowDialog();
                frmFINSubmitExpense.BringToFront();
            }
            else
            {
                this.ShowMessage("请先保存拜访计划！");
            }
        }
        #endregion

        #region
        private void tsbEditExpense_Click(object sender, EventArgs e)
        {
            if (custVstPlnGuID != Guid.Empty)
            {
                frmFINSubmitExpense frmFINSubmitExpense = new frmFINSubmitExpense();
                frmFINSubmitExpense.expID = expID;
                frmFINSubmitExpense.ShowDialog();
                frmFINSubmitExpense.BringToFront();
            }
            else
            {
                this.ShowMessage("请先保存拜访计划！");
            }
        }
        #endregion
        private void tsbDelExpense_Click(object sender, EventArgs e)
        {

        }

        private void dgvFee_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                expID = dgvFee["colExpID", e.RowIndex].Value.ToInt32();
            }
        }

        private void btnSearchFee_Click(object sender, EventArgs e)
        {
            BindFeeDataGridView();
        }

        private void dgvFee_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tsbEditExpense_Click(sender, e);
        }

        private void ucLabel2_Click(object sender, EventArgs e)
        {

        }

        private void txtStartDate_Click(object sender, EventArgs e)
        {

        }

    

        
       
    }
}
