using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZNLCRM.UI.Logic.CRM;
using ZNLCRM.UI.Logic.Common;
using ZNLCRM.Entity.UserModel.CRM;

namespace ZNLCRM.UI.CRM
{
    public partial class frmSelectCustomerContact : frmSelectForm
    {
        string _idColName = "colContactID";
        string _chkColName = "colSelect";
        public int? CompanyID = 0;
        public CRM_CompanyContactLogic contactLogic = null;
        public frmSelectCustomerContact(bool isMutiSelect)
        {
            InitializeComponent();
            InitBaseSelectForm(isMutiSelect, this.dgvContact, this.chkAll, _idColName, _chkColName);
            contactLogic = new CRM_CompanyContactLogic(this);
        }
        private void frmSelectCustomerContact_Load(object sender, EventArgs e)
        {
            BindComboBox();
            BindDataGridView();
        }

        void BindComboBox()
        {
            List<KeyValuePair<string,string>> kvList=new List<KeyValuePair<string,string>> ();
            kvList.Add(new KeyValuePair<string,string>("",""));
            kvList.Add(new KeyValuePair<string,string>("男","男"));
            kvList.Add(new KeyValuePair<string,string>("女","女"));
            colGender.DisplayMember = "Key";
            colGender.ValueMember = "Value";
            colGender.DataSource = kvList;
        
        }
        void BindDataGridView()
        {

            CRM_CompanyContactParam param = new CRM_CompanyContactParam();
            param.CompanyID = CompanyID;
            if (!string.IsNullOrEmpty(txtContactName.Text)) param.ContactName = txtContactName.Text.Trim();
            if (!string.IsNullOrEmpty(txtTelephone.Text)) param.Telephone = txtTelephone.Text.Trim();

            List<CRM_CompanyContactResult> lstRst = contactLogic.GetList(param);
            dgvContact.DataSource = lstRst;
            this.SetDataSource<CRM_CompanyContactResult>(lstRst);
            SetGridCheck(this.dgvContact, _idColName, _chkColName);

        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            BindDataGridView();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            SubmitForm();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.CancelForm();
        }

       
    }
}
