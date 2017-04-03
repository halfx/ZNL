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
using ZNLFrame.Entity;
using ZNLCRM.Utility;

namespace ZNLCRM.UI.PPM
{
    public partial class frmSelectPurchaseOrder : frmSelectForm
    {
        string _idColName = "colPOGuid";
        string _chkColName = "colSelect";
        ORD_PurchaseOrderLogic orderLogic = null;
        public int?[] empIds = null;
        public int? SupplierID = null;
        string[] _StkInOccStatusArr = new string[] { "待占有", "部分占有" };
        public frmSelectPurchaseOrder(bool isMutiSelect)
        {

             InitForm(isMutiSelect, null);
        }
        public frmSelectPurchaseOrder(bool isMutiSelect, ORD_PurchaseOrderParam param)
        {
              InitForm(isMutiSelect, param);
        }
        void InitForm(bool isMutiSelect, ORD_PurchaseOrderParam param)
        {
            InitializeComponent();
            InitBaseSelectForm(isMutiSelect, this.dgvPurchaseOrder, this.chkAll, _idColName, _chkColName);
            orderLogic = new ORD_PurchaseOrderLogic(this);
            if (param != null)
            {
                _StkInOccStatusArr = param.StkInOccStatusArr;
            }
        }
        private void frmSelectPurchaseOrder_Load(object sender, EventArgs e)
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            BindDataGridView(1);
        }

        private void BindDataGridView(int pageIndex)
        {
            ORD_PurchaseOrderParam param = new ORD_PurchaseOrderParam();
            param.PageIndex = pageIndex;
            param.PageSize = 100;
            param.SupplierID = SupplierID.ToInt32();
            param.BillNo = txtBillNo.Text.Trim();
            param.Status = "Complete";
            param.StkInOccStatusArr =_StkInOccStatusArr ;
            PageList<ORD_PurchaseOrderResult> lstRst = orderLogic.GetPageList(param);
            dgvPurchaseOrder.DataSource = lstRst.ResultList;
            pgPurchaseOrder.RecordCount = lstRst.TotalCount;
            this.SetDataSource<ORD_PurchaseOrderResult>(lstRst.ResultList);
            SetGridCheck(this.dgvPurchaseOrder, _idColName, _chkColName);
        }

        private void pgPurchaseOrder_PageIndexChanged(object sender, EventArgs e)
        {
            BindDataGridView(pgPurchaseOrder.PageIndex);
        }

      

      
         
    }
}
