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
    public partial class frmSelectStkOutLine : frmSelectForm
    {
        string _idColName = "colStkOutLineGuid";
        string _chkColName = "colSelect";
        STK_OutLineLogic  outLineLogic=null;
        public Guid? SourceBillGuid = null;
        public Guid? StkOutLineGuid = null;
        public Guid?[] NoStkOutLineGuids = null;
        public string Model = null;
        public int?[] empIds = null;
        public int? CustomerID = null;
        public string Currency = string.Empty;
        public frmSelectStkOutLine()
        {
            InitializeComponent();
        }
        public frmSelectStkOutLine(bool isMutiSelect)
        {
            InitializeComponent();
            InitBaseSelectForm(isMutiSelect, this.dgvStkOutLine, this.chkAll, _idColName, _chkColName);
            outLineLogic = new STK_OutLineLogic(this);
        }
        private void frmSelectStkOutLine_Load(object sender, EventArgs e)
        {
            InitData();
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

        private void InitData()
        {
            txtModel.Text = Model;
        }
        private void BindDataGridView(int pageIndex)
        {
            STK_OutLineParam param = new STK_OutLineParam();
            param.PageIndex = pageIndex;
            param.PageSize = 100;
            param.SourceBillGuid = SourceBillGuid;
            param.StkOutLineGuid = StkOutLineGuid;
            param.SourceBillNo = txtSourceBillNo.Text.Trim();
            param.StkOutBillNo = txtStkOutBillNo.Text.Trim();
            param.Model = txtModel.Text.Trim();
            param.Status = "Complete";//审核完成
            param.IsReturnOver = false;//未退完
            PageList<STK_OutLineResult> lstRst = outLineLogic.GetPageList(param);
            dgvStkOutLine.DataSource = lstRst.ResultList;
            pgStkOutLine.RecordCount = lstRst.TotalCount;
            this.SetDataSource<STK_OutLineResult>(lstRst.ResultList);
            SetGridCheck(this.dgvStkOutLine, _idColName, _chkColName);
        }

        private void pgStkOutLine_PageIndexChanged(object sender, EventArgs e)
        {
            BindDataGridView(pgStkOutLine.PageIndex);
        }

      
       
        
    }
}
