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
using ZNLFrame.Entity;

namespace ZNLCRM.UI.CRM
{
    public partial class frmSelectSupplier : frmSelectForm
    {
        string _idColName = "colCompanyGuID";
        string _chkColName = "colSelect";
        public CRM_CompanyLogic companyLogic = null;
        public frmSelectSupplier(bool isMutiSelect, string idColName)
        {
            InitializeComponent();
            if (!string.IsNullOrEmpty(idColName)) _idColName = idColName;
            InitBaseSelectForm(isMutiSelect, this.dgvCompany, this.chkAll, _idColName, _chkColName);
            companyLogic = new CRM_CompanyLogic(this);
        }

        #region 绑定公司清单
        void BindDgvCompany(int pageIndex)
        {

            CRM_CompanyParam param = new CRM_CompanyParam();
            if (!string.IsNullOrEmpty(txtCompanyName.Text)) param.CompanyName = txtCompanyName.Text.Trim();
            if (!string.IsNullOrEmpty(txtCompanyCode.Text)) param.CompanyCode = txtCompanyCode.Text.Trim();
            param.PageIndex = pageIndex;
            param.PageSize = 100;
            PageList<CRM_CompanyResult> lstRst = companyLogic.GetSupPageList(param);
            dgvCompany.DataSource = lstRst.ResultList;
            pgCompany.RecordCount = lstRst.TotalCount;

            this.SetDataSource<CRM_CompanyResult>(lstRst.ResultList);
            SetGridCheck(this.dgvCompany, _idColName, _chkColName);

        }
        #endregion

      

        private void btnOK_Click(object sender, EventArgs e)
        {
            SubmitForm();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.CancelForm();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            BindDgvCompany(1);
        }

        private void frmSelectSupplier_Load(object sender, EventArgs e)
        {
            BindDgvCompany(1);
        }

        private void pgCompany_PageIndexChanged(object sender, EventArgs e)
        {
            BindDgvCompany(pgCompany.PageIndex);
        }

      

    
    }
}
