using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZNLCRM.UI.Logic.SPM;
using ZNLCRM.UI.Logic.Common;
using ZNLCRM.Entity.UserModel.SPM;
using ZNLFrame.Entity;

namespace ZNLCRM.UI.SPM
{
    public partial class frmSelectSalesReturn : frmSelectForm
    {
        string _idColName = "colSRGuid";
        string _chkColName = "colSelect";
        ORD_SalesReturnLogic returnLogic = null;
        public frmSelectSalesReturn(bool isMutiSelect)
        {
            InitializeComponent();
            InitBaseSelectForm(isMutiSelect, this.dgvSalesReturn, this.chkAll, _idColName, _chkColName);
            returnLogic = new ORD_SalesReturnLogic(this);
        }

        private void frmSelectSalesReturn_Load(object sender, EventArgs e)
        {
            BindDataGridView(1);
        }
        private void BindDataGridView(int pageIndex)
        {
            ORD_SalesReturnParam param = new ORD_SalesReturnParam();
            param.PageIndex = pageIndex;
            param.PageSize = 100;
            param.BillNo = txtBillNo.Text.Trim();
            PageList<ORD_SalesReturnResult> lstRst = returnLogic.GetPageList(param);
            dgvSalesReturn.DataSource = lstRst.ResultList;
            pgSalesReturn.RecordCount = lstRst.TotalCount;
            this.SetDataSource<ORD_SalesReturnResult>(lstRst.ResultList);
            SetGridCheck(this.dgvSalesReturn, _idColName, _chkColName);
        }
        #region 搜索
        private void btnSearch_Click(object sender, EventArgs e)
        {
            BindDataGridView(1);
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

        #region 分页
        private void pgSalesReturn_PageIndexChanged(object sender, EventArgs e)
        {
            BindDataGridView(pgSalesReturn.PageIndex);
        }
        #endregion

    }
}
