using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZNLCRM.UI.Logic.Common;
using ZNLCRM.UI.Logic.PPM;
using ZNLCRM.Entity.UserModel.PPM;

namespace ZNLCRM.UI.PPM
{
    public partial class frmSelectPurchaseOrderLine : frmSelectForm
    {
        string _idColName = "colPOLineGuid";
        string _chkColName = "colSelect";
        ORD_PurchaseOrderLineLogic lineLogic = null;
        public   Guid?[] NoPOLineGuids = null;
        public Guid? POLineGuid = null;
        public Guid? POGuid = null;
        public string Model = string.Empty;
        public frmSelectPurchaseOrderLine(bool isMutiSelect)
        {
            InitializeComponent();
            InitBaseSelectForm(isMutiSelect, this.dgvPurchaseOrder, this.chkAll, _idColName, _chkColName);
            lineLogic = new ORD_PurchaseOrderLineLogic(this);
            
        }

        private void frmSelectPurchaseOrderLine_Load(object sender, EventArgs e)
        {
            InitData();
            BindDataGridView();
        }


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
            BindDataGridView();
        }

        private void InitData()
        {
            txtModel.Text = Model;
        }
        private void BindDataGridView()
        {
            ORD_PurchaseOrderLineParam param = new ORD_PurchaseOrderLineParam();

            param.POGuid = POGuid;
            param.Model = txtModel.Text.Trim();
            param.NoPOLineGuids = NoPOLineGuids;
            param.POLineGuid = POLineGuid;
            List<ORD_PurchaseOrderLineResult> lstRst = lineLogic.GetList(param);
            dgvPurchaseOrder.DataSource = lstRst;
            this.SetDataSource<ORD_PurchaseOrderLineResult>(lstRst);
            SetGridCheck(this.dgvPurchaseOrder, _idColName, _chkColName);
        }

        
    }
}
