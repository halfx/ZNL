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
using ZNLFrame.Entity;

namespace ZNLCRM.UI.STK
{
    public partial class frmSelectStkInLine : frmSelectForm
    {
        string _idColName = "colStkInLineGuid";
        string _chkColName = "colSelect";
        STK_InLineLogic inLineLogic = null;
        public Guid? SourceBillGuid = null;
        public Guid? StkInLineGuid = null;
        public Guid?[] NoStkInLineGuids = null;
        public string Model = null;
        public int?[] empIds = null;
        public int? SupplierID = null;
        public string Currency = string.Empty;
        public frmSelectStkInLine(bool isMutiSelect)
        {
            InitializeComponent();
            InitBaseSelectForm(isMutiSelect, this.dgvStkInLine, this.chkAll, _idColName, _chkColName);
            inLineLogic = new STK_InLineLogic(this);
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
            STK_InLineParam param = new STK_InLineParam();
            param.PageIndex = pageIndex;
            param.PageSize = 100;
            param.SourceBillGuid = SourceBillGuid;
            param.SourceBillNo = txtSourceBillNo.Text.Trim();
            param.StkInLineGuid = StkInLineGuid;
            param.StkInBillNo = txtStkOutBillNo.Text.Trim();
            param.Model = txtModel.Text.Trim();
            param.Status = "Complete";//审核完成
            param.IsReturnOver = false;//未退完
            PageList<STK_InLineResult> lstRst = inLineLogic.GetPageList(param);
            dgvStkInLine.DataSource = lstRst.ResultList;
            pgStkInLine.RecordCount = lstRst.TotalCount;
            this.SetDataSource<STK_InLineResult>(lstRst.ResultList);
            SetGridCheck(this.dgvStkInLine, _idColName, _chkColName);
        }
    }
}
