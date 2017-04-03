using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZNLCRM.UI.Logic.Common;
using ZNLCRM.UI.Logic.CRM;
using ZNLCRM.Entity.UserModel.CRM;
using ZNLCRM.Entity.UserModel.Common;
using ZNLFrame.Entity;
using ZNLCRM.Utility;
namespace ZNLCRM.UI.CRM
{
    public partial class frmCustomerManage : frmBaseForm
    {
        int rowIndex = 0;
        int companyID = 0;
        CRM_CompanyLogic companyLogic = null;
        public frmCustomerManage()
        {
            InitializeComponent();
            companyLogic = new CRM_CompanyLogic(this);
        }
   

        private void frmCustomerManage_Load(object sender, EventArgs e)
        {
            
            BindDataGridView(1);
        }

        public void BindDataGridView(int pageIndex)
        { 
            CRM_CompanyParam param=  new CRM_CompanyParam();
           if(!string.IsNullOrEmpty(txtCompanyCode.Text.Trim()))
               param.CompanyCode=txtCompanyCode.Text.Trim();
            if(!string.IsNullOrEmpty(txtCompanyName.Text.Trim()))
                param.CompanyName=txtCompanyName.Text.Trim();
            param.CompanySearchType = rdoMyCustomer.Checked ? SysEnum.CompanySearchType.Me : SysEnum.CompanySearchType.All;
            if (adtCust.SelectedNode != null && adtCust.SelectedNode.Parent != null && adtCust.SelectedNode.Parent.Name == "trnContactedCust")
            {
                string contactType = adtCust.SelectedNode.Name.Substring(3);
                switch (contactType)
                {
                    case "Today"://今天联系过的客户
                        param.CompanyContactType = SysEnum.CompanyContactType.Today;
                        break;
                    case "Yesterday"://昨天联系过的客户
                        param.CompanyContactType = SysEnum.CompanyContactType.Yesterday;
                        break;
                    case "ThisWeek"://这周联系过的客户
                        param.CompanyContactType = SysEnum.CompanyContactType.ThisWeek;
                        break;
                    case "ThisMonth"://这个月联系过的客户
                        param.CompanyContactType = SysEnum.CompanyContactType.ThisMonth;
                        break;
                    case "ThreeMonth"://三个月内联系过的客户
                        param.CompanyContactType = SysEnum.CompanyContactType.ThreeMonth;
                        break;
                    case "OneMonthNonContact"://近一个月未联系过的客户
                        param.CompanyContactType = SysEnum.CompanyContactType.OneMonthNonContact;
                        break;
                    case "ThreeMonthNonContact"://近三个月未联系过的客户
                        param.CompanyContactType = SysEnum.CompanyContactType.ThreeMonthNonContact;
                        break;
                    case "AboveThreeMonth"://三个月以上未联系过的客户
                        param.CompanyContactType = SysEnum.CompanyContactType.AboveThreeMonth;
                        break;
                    case "AboveOneYear"://一年以上未联系过的客户
                        param.CompanyContactType = SysEnum.CompanyContactType.AboveOneYear;
                        break;
                    case "SpecialAttention":
                        param.CompanyContactType = SysEnum.CompanyContactType.SpecialAttention;
                        break;
                    case "Focus":
                        param.CompanyContactType = SysEnum.CompanyContactType.Focus;
                        break;
                    case "ColdTreament":
                        param.CompanyContactType = SysEnum.CompanyContactType.ColdTreament;
                        break;
                    case "AreTracking":
                        param.CompanyContactType = SysEnum.CompanyContactType.AreTracking;
                        break;
                    case "IsTrackOver":
                        param.CompanyContactType = SysEnum.CompanyContactType.IsTrackOver;
                        break;
                    case "NoTrack":
                        param.CompanyContactType = SysEnum.CompanyContactType.NoTrack;
                        break;

                }
            }
              param.PageIndex = pageIndex;
              param.PageSize=100;
              PageList<CRM_CompanyResult> pageList = this.AsyncExecute<PageList<CRM_CompanyResult>, CRM_CompanyParam>(param, companyLogic.GetCustPageList, a =>
              { 
              
                 dgvCompany.DataSource=a.ResultList;
                 pgCompany.RecordCount = a.TotalCount;
                 
              });
        }
      

     

        private void btnAddCust_Click(object sender, EventArgs e)
        {
            frmCustomerEdit frmCustEdit = new frmCustomerEdit();
            frmCustEdit.ShowDialog();
            frmCustEdit.BringToFront();
        }

        private void rdoMyCustomer_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoMyCustomer.Checked) rdoAllCustomer.Checked = false;
            else rdoAllCustomer.Checked = true;
        }

        private void rdoAllCustomer_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoAllCustomer.Checked) rdoMyCustomer.Checked = false;
            else rdoMyCustomer.Checked = true;
        }

        private void pgCompany_PageIndexChanged(object sender, EventArgs e)
        {
            BindDataGridView(pgCompany.PageIndex);
        }

        private void dgvCompany_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                rowIndex = e.RowIndex;
                companyID = dgvCompany["colCompanyID", e.RowIndex].Value.ToInt32();
            }
        }

        private void dgvCompany_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void dgvCompany_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                frmCustomerEdit frmCustEdit = new frmCustomerEdit();
                frmCustEdit.BringToFront();
                frmCustEdit.companyID = companyID;
                frmCustEdit.ShowDialog();

            }
        }

        private void btnEditCust_Click(object sender, EventArgs e)
        {
            if (companyID > 0)
            {
                frmCustomerEdit frmCustEdit = new frmCustomerEdit();
                frmCustEdit.BringToFront();
                frmCustEdit.companyID = companyID;
                frmCustEdit.ShowDialog();
            }
            else
            {
                this.ShowMessage("请选择要编辑的客户资料！");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            BindDataGridView(1);
        }

        private void adtCust_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindDataGridView(1);
        }

      

        private void btnDelCust_Click(object sender, EventArgs e)
        {

        }

       

       

      

       
    }
}
