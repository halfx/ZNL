using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZNLCRM.UI.Logic.PPM;
using ZNLCRM.UI.Logic.Common;
using ZNLCRM.Entity.UserModel.PPM;
using ZNLCRM.Entity.UserModel.SPM;
using ZNLFrame.Entity;


namespace ZNLCRM.UI.PPM
{
    public partial class frmSelectPurchaseReturn : frmSelectForm
    {
        public int? SupplierID = null;
        string _idColName = "colPRGuid";
        string _chkColName = "colSelect";
        ORD_PurchaseReturnLogic returnLogic = null;
        public frmSelectPurchaseReturn(bool isMutiSelect)
        {
            InitializeComponent();
            InitBaseSelectForm(isMutiSelect, this.dgvPurchaseReturn, this.chkAll, _idColName, _chkColName);
            returnLogic = new ORD_PurchaseReturnLogic(this);
        }

        private void frmSelectPurchaseReturn_Load(object sender, EventArgs e)
        {
            BindDataGridView(1);
        }
        private void BindDataGridView(int pageIndex)
        {
            ORD_PurchaseReturnParam param = new ORD_PurchaseReturnParam();
            param.PageIndex = pageIndex;
            param.PageSize = 100;
            param.SupplierID = SupplierID;
            param.BillNo = txtBillNo.Text.Trim();
            PageList<ORD_PurchaseReturnResult> lstRst = returnLogic.GetPageList(param);
            dgvPurchaseReturn.DataSource = lstRst.ResultList;
            pgPurchaseReturn.RecordCount = lstRst.TotalCount;
            this.SetDataSource<ORD_PurchaseReturnResult>(lstRst.ResultList);
            SetGridCheck(this.dgvPurchaseReturn, _idColName, _chkColName);
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            BindDataGridView(1);
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            SubmitForm();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.CancelForm();
        }

        private void pgPurchaseReturn_PageIndexChanged(object sender, EventArgs e)
        {
            BindDataGridView(pgPurchaseReturn.PageIndex);
        }

        
    }
}
