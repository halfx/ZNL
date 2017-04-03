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

namespace ZNLCRM.UI.SPM
{
    public partial class frmSelectSalesOrder : frmSelectForm
    {
        string _idColName = "colSOGuid";
        string _chkColName = "colSelect";
        ORD_SalesOrderLogic orderLogic = null;
        public int? CustomerID = null;
        public frmSelectSalesOrder(bool isMutiSelect)
        {
            InitializeComponent();
            InitBaseSelectForm(isMutiSelect, this.dgvSalesOrder, this.chkAll, _idColName, _chkColName);
            orderLogic = new ORD_SalesOrderLogic(this);
        }
        
        private void frmSelectSalesOrder_Load(object sender, EventArgs e)
        {
            BindDataGridView(1);
        }

        private void BindDataGridView(int pageIndex)
        {
            ORD_SalesOrderParam param = new ORD_SalesOrderParam();
            param.PageIndex = pageIndex;
            param.PageSize = 100;
            param.CustomerID = CustomerID;
            param.BillNo = txtBillNo.Text.Trim();
            PageList<ORD_SalesOrderResult> lstRst = orderLogic.GetPageList(param);
            dgvSalesOrder.DataSource = lstRst.ResultList;
            pgSalesOrder.RecordCount = lstRst.TotalCount;
            this.SetDataSource<ORD_SalesOrderResult>(lstRst.ResultList);
            SetGridCheck(this.dgvSalesOrder, _idColName, _chkColName);
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
        private void pgSalesOrder_PageIndexChanged(object sender, EventArgs e)
        {
            BindDataGridView(pgSalesOrder.PageIndex);
        }
        #endregion


        
    }
}
