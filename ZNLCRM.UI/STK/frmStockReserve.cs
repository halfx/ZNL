using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZNLCRM.UI.Logic.Common;
using DevComponents.DotNetBar.SuperGrid;
using DevComponents.DotNetBar;
using ZNLCRM.Entity.UserModel.STK;
using ZNLFrame.Entity;
using ZNLCRM.UI.Logic.STK;
using ZNLCRM.Utility;

namespace ZNLCRM.UI.STK
{
    public partial class frmStockReserve :frmBaseForm
    {
        public delegate void dlgRefreshParentForm();
        public event dlgRefreshParentForm RefreshParentForm;
        public Guid? SourceBillGuid = null;
        STK_StockReserveLogic reserveLogic = null;
        List<STK_StockReserveResult> reserveList = null;
        public frmStockReserve()
        {
            InitializeComponent();
            reserveLogic = new STK_StockReserveLogic(this);
            InitializeGrid();
            BindComboBox();
        }
        private void BindComboBox()
        {

        }
        private void InitializeGrid()
        {

            GridColumn reserveGridCol= usgSource.PrimaryGrid.Columns["colAddReserve"];
            reserveGridCol.EditorType = typeof(GridLabelXEditControl);
            GridLabelXEditControl LabelX = (GridLabelXEditControl)reserveGridCol.EditControl;
            LabelX.MarkupLinkClick += new MarkupLinkClickEventHandler(LabelX_MarkupLinkClick);
        }

        void LabelX_MarkupLinkClick(object sender, MarkupLinkClickEventArgs e)
        {
            SelectedElementCollection collection = this.usgSource.GetSelectedCells();
            if (collection.Count > 0)
            {
                GridCell gridCell = collection[0] as GridCell;
                if (gridCell != null)
                {
                    GridRow gridRow = gridCell.Parent as GridRow;
                    if (gridRow != null)
                    {
                       
                     
                        frmReserveOperate frmReserveOperate = new frmReserveOperate();
                        frmReserveOperate.BringToFront();
                        frmReserveOperate.StartPosition = FormStartPosition.CenterScreen;
                        frmReserveOperate.SourceBillGuid = gridRow.Cells["colSourceBillGuid"].Value.ToGuid();
                        frmReserveOperate.SourceBillLineGuid = gridRow.Cells["colSourceBillLineGuid"].Value.ToGuid();
                        frmReserveOperate.SourceBillNo = gridRow.Cells["colSourceBillNo"].Value.ToStringHasNull();
                        frmReserveOperate.SourceBillType = gridRow.Cells["colSourceBillType"].Value.ToStringHasNull();
                        
                        frmReserveOperate.RefreshParentForm += delegate { BindSuperGrid(1); };
                        frmReserveOperate.ShowDialog();
                    }
                }
            }
        }
        private void BindSuperGrid(int pageIndex)
        {
            STK_StockReserveParam param = new STK_StockReserveParam();
            param.Model = txtModel.Text;
            param.SourceBillNo = txtBillNo.Text;
            param.SourceBillLineCode = txtLineCode.Text;
            param.SourceBillGuid = SourceBillGuid;
            param.PageIndex = pageIndex;
            param.PageSize = 100;
            PageList<STK_StockReserveResult> pageList = this.AsyncExecute<PageList<STK_StockReserveResult>, STK_StockReserveParam>(param, reserveLogic.GetPageList, a =>
            {
                reserveList = a.ResultList;
                usgSource.PrimaryGrid.DataSource = reserveList;
                pgSource.RecordCount = a.TotalCount;
            });
        }
        private void usgSource_DataBindingComplete(object sender, GridDataBindingCompleteEventArgs e)
        {
            foreach (GridRow row in e.GridPanel.Rows)
            {
                row.Cells["colAddReserve"].Value = "<a href='#'>备货</a>";

            }
        }

        private void usgSource_RowMouseEnter(object sender, GridRowEventArgs e)
        {  
          
            
             
        }

        private void frmStockReserve_Load(object sender, EventArgs e)
        {
            BindSuperGrid(1);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            BindSuperGrid(1);
        }

        private void usgReserve_DataBindingComplete(object sender, GridDataBindingCompleteEventArgs e)
        {
            foreach (GridRow row in e.GridPanel.Rows)
            {
               // row.Cells["colAddReserve"].Value = "<a href='#'>备货</a>";

            }
        }

        private void usgSource_RowActivated(object sender, GridRowActivatedEventArgs e)
        {
            if(e.NewActiveRow.RowIndex>-1)
            {
                GridRow gridRow = usgSource.PrimaryGrid.Rows[e.NewActiveRow.RowIndex] as GridRow;
            if (gridRow != null)
            {
                Guid? SourceBillLineGuid = gridRow.Cells["colSourceBillLineGuid"].Value.ToGuid();
                STK_StockReserveResult reserveResult = reserveList.FirstOrDefault(a => a.SourceBillLineGuid == SourceBillLineGuid);
                if (reserveResult != null)
                {
                    usgReserve.PrimaryGrid.DataSource = reserveResult.ReserveList;
                }

            }
            }
        }

      

       



       
    }
}
