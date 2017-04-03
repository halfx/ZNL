using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZNLCRM.UI.Logic.STK;
using ZNLCRM.UI.Logic.Common;
using ZNLCRM.Entity.UserModel.STK;

namespace ZNLCRM.UI.STK
{
    public partial class frmSelectStockReserve : frmSelectForm
    {
        public Guid? SourceBillGuid = null;
        public Guid? SourceBillLineGuid = null;
        public string Model = string.Empty;
        public Guid? SRGuid = null;
        public Guid?[] NoSRGuids = null;
        string _idColName = "colSOGuid";
        string _chkColName = "colSelect";
        STK_StockReserveLogic reserveLogic = null;
         public frmSelectStockReserve(bool isMutiSelect)
        {
            InitializeComponent();
            InitBaseSelectForm(isMutiSelect, this.dgvStockReserve, this.chkAll, _idColName, _chkColName);
            reserveLogic = new STK_StockReserveLogic(this);
        }
    
        private void frmSelectSalesOrder_Load(object sender, EventArgs e)
        {
            BindDataGridView();
        }

        private void BindDataGridView()
        {
            STK_StockReserveParam param = new STK_StockReserveParam();
            param.Model = txtModel.Text.Trim();
            param.SourceBillGuid = SourceBillGuid;
            param.SourceBillLineGuid = SourceBillLineGuid;
            param.SRGuid = SRGuid;
            param.Model = Model;
            param.NoSRGuids = NoSRGuids;
            List<STK_StockReserveResult> lstRst = reserveLogic.GetList(param);
            dgvStockReserve.DataSource = lstRst;
            this.SetDataSource<STK_StockReserveResult>(lstRst);
            SetGridCheck(this.dgvStockReserve, _idColName, _chkColName);
        }
        #region 搜索
        private void btnSearch_Click(object sender, EventArgs e)
        {
            BindDataGridView();
        }
        #endregion
        #region 确定
        private void btnOK_Click(object sender, EventArgs e)
        {
            SubmitForm();
        }
        #endregion
        #region 取消
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.CancelForm();
        }
        #endregion
    

       
    }
}
