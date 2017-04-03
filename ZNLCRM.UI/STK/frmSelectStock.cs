using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZNLCRM.UI.Logic.Common;
using ZNLCRM.UI.Logic.STK;
using ZNLCRM.Entity.UserModel.STK;
using ZNLFrame.Entity;

namespace ZNLCRM.UI.STK
{
    public partial class frmSelectStock : frmSelectForm
    {
        
        string _idColName = "colItemCode";
        string _chkColName = "colSelect";
        STK_StockLogic stockLogic = null;
        public Guid? ItemCode = null;
        public Guid?[] NoItemCodes = null;
        public string Model = null;
        public frmSelectStock(bool isMutiSelect)
        {
            InitializeComponent();
            InitBaseSelectForm(isMutiSelect, this.dgvStock, this.chkAll, _idColName, _chkColName);
            stockLogic = new STK_StockLogic(this);
        }

        private void frmSelectStkInLine_Load(object sender, EventArgs e)
        {
            InitData();
            BindDataGridView(1);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SubmitForm();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.CancelForm();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            SubmitForm();
        }
        private void InitData()
        {
            txtModel.Text = Model;
        }
        private void BindDataGridView(int pageIndex)
        {
            STK_StockParam param = new STK_StockParam();
            param.PageIndex = pageIndex;
            param.PageSize = 100;
            param.NoItemCodes = NoItemCodes;
            param.Model = txtModel.Text.Trim();
            PageList<STK_StockResult> lstRst = stockLogic.GetPageList(param);
            dgvStock.DataSource = lstRst.ResultList;
            pgStock.RecordCount = lstRst.TotalCount;
            this.SetDataSource<STK_StockResult>(lstRst.ResultList);
            SetGridCheck(this.dgvStock, _idColName, _chkColName);
        }

        private void pgStock_PageIndexChanged(object sender, EventArgs e)
        {
            BindDataGridView(pgStock.PageIndex);
        }


      
    }
}
