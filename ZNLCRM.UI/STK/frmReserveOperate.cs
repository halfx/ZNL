using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar.SuperGrid;
using DevComponents.DotNetBar;
using ZNLCRM.Utility;
using ZNLCRM.Entity.UserModel.Sys;
using ZNLCRM.UI.Logic.Sys;
using ZNLCRM.Entity.DBModel;
using ZNLCRM.Entity.UserModel.STK;
using ZNLCRM.UI.Logic.STK;
using ZNLCRM.UI.Logic.Common;
using ZNLFrame.Entity;
using DevComponents.DotNetBar.SuperGrid.Style;
using ZNLCRM.UI.Logic.SPM;
using ZNLCRM.Entity.UserModel.SPM;
using ZNLCRM.Entity.UserModel.PPM;
using ZNLCRM.UI.Logic.PPM;


namespace ZNLCRM.UI.STK
{
    public partial class frmReserveOperate : frmBaseForm
    {
        public delegate void dlgRefreshParentForm();
        public event dlgRefreshParentForm RefreshParentForm;
        public Guid? SourceBillGuid=null;
        public string SourceBillNo=string.Empty;
        public Guid? SourceBillLineGuid;
        public string SourceBillType=string.Empty;
        List<STK_StockReserveResult> reserveList = new List<STK_StockReserveResult>();
        List<STK_StockResult> stockResultList = new List<STK_StockResult>();
        SYS_DictItemLineLogic dictLineLogic = null;
        STK_InLineLogic stkInLineLogic = null;
        STK_StockLogic stockLogic = null;
        STK_StockReserveLogic reserveLogic = null;
        ORD_SalesOrderLineLogic orderLineLogic = null;
        ORD_PurchaseReturnLineLogic returnLineLogic=null;
        STK_StockSheetLogic sheetLogic = null;
        public frmReserveOperate()
        {
            InitializeComponent();
            stockLogic = new STK_StockLogic(this);
            reserveLogic = new STK_StockReserveLogic(this);
            dictLineLogic = new SYS_DictItemLineLogic(this);
            orderLineLogic = new ORD_SalesOrderLineLogic(this);
            stkInLineLogic = new STK_InLineLogic(this);
            returnLineLogic=new ORD_PurchaseReturnLineLogic (this);

        }

       
        private void frmReserveOperate_Load(object sender, EventArgs e)
        {
            BindComboBox();
            InitData();
            BindReserveDataGridView();
            BindStockDataGridView(1);
        }

        private void InitData()
        {
            switch (SourceBillType)
            {
                case "销售出库":
                ORD_SalesOrderLineResult orderLineResult=orderLineLogic.GetInfo(new ORD_SalesOrderLineParam() { SOLineGuid = SourceBillLineGuid });
                txtModel.Text = orderLineResult.Model;
                txtBrand.Text = orderLineResult.Brand;
                txtBatch.Text = orderLineResult.Batch;
                txtPackage.Text = orderLineResult.Package;
                txtSourceBillNo.Text = SourceBillNo;
                txtSourceBillLineCode.Text =orderLineResult.SOLineCode;
                txtSModel.Text = orderLineResult.Model;
                txtQty.Text = orderLineResult.Qty.ToStringHasNull();
                txtReserveQty.Text = orderLineResult.ReserveQty.ToStringHasNull();
                break;
                case "采购退货出库":
                ORD_PurchaseReturnLineResult  returnLineResult=returnLineLogic.GetInfo(new ORD_PurchaseReturnLineParam(){PRLineGuid=SourceBillLineGuid});
                txtModel.Text = returnLineResult.Model;
                txtBrand.Text = returnLineResult.Brand;
                txtBatch.Text = returnLineResult.Batch;
                txtPackage.Text = returnLineResult.Package;
                txtSourceBillNo.Text = SourceBillNo;
                txtSModel.Text = returnLineResult.Model;
                txtQty.Text = returnLineResult.Qty.ToStringHasNull();
                txtReserveQty.Text = returnLineResult.ReserveQty.ToStringHasNull();
                break;
                
            }
        }

        private void BindComboBox()
        {
            List<SYS_DictItemLineResult> itemLineList = dictLineLogic.GetListByCode(new SYS_DictItemLineParam
            {
                ItemCodes = new string[] { "Warehouse" }
            });
           dictLineLogic.BindComboBox(cboWarehouse, "Warehouse", itemLineList);

        }

        private void BindReserveDataGridView()
        {
            STK_StockReserveParam param = new STK_StockReserveParam();
            param.SourceBillGuid = SourceBillGuid;
            param.SourceBillLineGuid = SourceBillLineGuid;
            List<STK_StockReserveResult> stockReserveList = this.AsyncExecute<List<STK_StockReserveResult>, STK_StockReserveParam>(param, reserveLogic.GetList, a =>
            {
                dgvReserve.DataSource = a;
            });
          
        }
        private void BindStockDataGridView(int pageIndex)
        {
            STK_InLineParam inLineParam = new STK_InLineParam();
            STK_StockParam stockParam = new STK_StockParam();
            stockParam.Model = txtModel.Text;
            stockParam.AllowUsableQtyZero = false;
            stockParam.PageIndex = pageIndex;
            stockParam.PageSize = 100;
            PageList < STK_StockResult > stockList = this.AsyncExecute<PageList<STK_StockResult>, STK_StockParam>(stockParam, stockLogic.GetPageList, a =>
            {
                stockResultList = a.ResultList;
                Guid?[] ItemCodes= stockResultList.Select(o => (Guid?)o.ItemCode).Distinct().ToArray();
                dgvStock.DataSource = stockResultList;
                pgStock.RecordCount = a.TotalCount;

            });
        }
     

        private void pgStock_PageIndexChanged(object sender, EventArgs e)
        {
            BindStockDataGridView(pgStock.PageIndex);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

            List<STK_StockReserveResult> tempReserveList = new List<STK_StockReserveResult>();
            foreach (DataGridViewRow  row in dgvReserve.Rows)
            {
                Guid? srGuid = row.Cells["colSRGuid"].Value.ToGuid();
                int? reserveQty = row.Cells["colReserveQty"].Value.ToInt32();
                int? oldReserveQty = row.Cells["colReserveQty"].Tag.ToInt32();
                STK_StockReserveResult  reserveResult= reserveList.FirstOrDefault(a => a.SRGuid == srGuid);
                if (reserveResult != null)
                {
                    if (reserveQty != oldReserveQty)
                    {
                        reserveResult.ReserveQty = reserveQty;
                        tempReserveList.Add(reserveResult);
                    }
                }
            }
            if (tempReserveList.Count > 0)
            {
                reserveLogic.OperateReserveList(tempReserveList);
               InitData();
               BindReserveDataGridView();
               BindStockDataGridView(1);
               if (RefreshParentForm != null)
                   RefreshParentForm();
            }
        }

    
        
   

        private void dgvReserve_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                if (dgvReserve.Columns[e.ColumnIndex].Name == "colAddReserve")
                {
                    DataGridViewRow row = dgvReserve.Rows[e.RowIndex];
                    Guid? srGuid = row.Cells["colSRGuid"].Value.ToGuid();
                    STK_StockReserveResult reserveResult = new STK_StockReserveResult();
                    reserveResult.SRGuid = srGuid;
                    reserveResult.IsDeleted = true;
                    reserveLogic.OperateReserve(reserveResult);
                    InitData();
                    BindReserveDataGridView();
                    BindStockDataGridView(1);
                    if (RefreshParentForm != null)
                        RefreshParentForm();
                }
            }
        }

        private void dgvStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                if (dgvStock.Columns[e.ColumnIndex].Name == "colAddReserve")
                {
                    DataGridViewRow row = dgvStock.Rows[e.RowIndex];
                    Guid? itemCode = row.Cells["col_Stock_ItemCode"].Value.ToGuid();
                    STK_StockReserveResult reserveResult = new STK_StockReserveResult();
                    reserveResult.SourceBillGuid = SourceBillGuid;
                    reserveResult.SourceBillNo = SourceBillNo;
                    reserveResult.SourceBillLineGuid = SourceBillLineGuid;
                    reserveResult.SourceBillType = SourceBillType;
                    reserveResult.ReserveType = 1;
                    reserveResult.OperType = true;
                    STK_StockResult stockResult = stockLogic.GetInfo(new STK_StockParam() { ItemCode = itemCode });
                    if (stockResult != null)
                        reserveResult.StkInLineGuid = stockResult.StkInLineGuid;
                    reserveResult.ItemCode = itemCode;
                    reserveResult.OperFlag = true;//增加
                    reserveLogic.OperateReserve(reserveResult);
                    InitData();
                    BindReserveDataGridView();
                    BindStockDataGridView(1);
                    if (RefreshParentForm != null)
                        RefreshParentForm();
                }
            
            }
        }

        private void dgvReserve_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                if (dgvReserve.Columns[e.ColumnIndex].Name== "colReserveQty")
                {
                    DataGridViewRow row=dgvReserve.Rows[e.RowIndex];
                    Guid? srGuid = row.Cells["colSRGuid"].Value.ToGuid();

                    int? reserveQty = row.Cells["colReserveQty"].Value.ToInt32();
                    int? oldReserveQty = row.Cells["colReserveQty"].Tag.ToInt32();
                    if ((reserveQty - oldReserveQty) > (txtQty.Text.ToInt32() - txtReserveQty.Text.ToInt32()))
                    {
                        this.ShowMessage("合计预留数超过需预留数量,需减少当前的预留数量");
                        return;
                    }

                }
            
            }
        }

        private void dgvReserve_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dgvReserve.Rows)
            {
                row.Cells["colReserveQty"].Tag = row.Cells["colReserveQty"].Value;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            BindStockDataGridView(1);
        }

       

       

        
    }
}
