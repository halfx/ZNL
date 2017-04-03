using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZNLCRM.UI.Logic.Common;
using ZNLCRM.UI.Logic.SPM;
using ZNLCRM.Entity.UserModel.SPM;
using ZNLFrame.Entity;

namespace ZNLCRM.UI.PPM
{
    public partial class frmSelectForPurchaseList : frmSelectForm
    {
       
         string _idColName = "colNoticeGuid";
         string _chkColName = "colSelect";
         ORD_PurchaseNoticeLogic noticeLogic = null;
        public Guid? NoticeGuid = null;
        public Guid?[] NoNoticeGuids = null;
        public int? BuyerID = null;
        public string Model = string.Empty;
        public frmSelectForPurchaseList(bool isMutiSelect)
        {
            InitializeComponent();
            InitBaseSelectForm(isMutiSelect, this.dgvPurchaseList, this.chkAll, _idColName, _chkColName);
            noticeLogic = new ORD_PurchaseNoticeLogic(this);
        }

       private void frmSelectPurchaseList_Load(object sender, EventArgs e)
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

        public void  InitData()
        {
            txtModel.Text=Model ;
        }
        private void BindDataGridView(int pageIndex)
        {


            ORD_PurchaseNoticeParam param = new ORD_PurchaseNoticeParam();
          
            param.Model = txtModel.Text.Trim();
            param.SOBillNo = txtSOBillNo.Text.Trim();
            param.SOLineCode = txtSOLineCode.Text.Trim();
            param.BuyerID = BuyerID;
            param.NoNoticeGuids = NoNoticeGuids;
            PageList<ORD_PurchaseNoticeResult> lstRst = noticeLogic.GetPageList(param);
            dgvPurchaseList.DataSource = lstRst.ResultList;
            pgPurchaseList.RecordCount = lstRst.TotalCount;
            this.SetDataSource<ORD_PurchaseNoticeResult>(lstRst.ResultList);
            SetGridCheck(this.dgvPurchaseList, _idColName, _chkColName);
        }

        private void pgPurchaseList_PageIndexChanged(object sender, EventArgs e)
        {
            BindDataGridView(pgPurchaseList.PageIndex);
        }

       



       

      
    }
}
