using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZNLCRM.UI.Logic.Common;
using ZNLCRM.Entity.UserModel.STK;
using ZNLFrame.Entity;
using ZNLCRM.UI.Logic.STK;
using DevComponents.DotNetBar.SuperGrid;
using DevComponents.DotNetBar.SuperGrid.Style;
using ZNLCRM.Entity.UserModel.Sys;
using ZNLCRM.UI.Logic.Sys;

namespace ZNLCRM.UI.STK
{
    public partial class frmStockManage : frmBaseForm
    {
        STK_StockTtlLogic stockTtlLogic = null;
        STK_StockLogic stockLogic = null;
        SYS_DictItemLineLogic dictLineLogic = null;
        public frmStockManage()
        {
            InitializeComponent();
            stockTtlLogic = new STK_StockTtlLogic(this);
            stockLogic = new STK_StockLogic(this);
            dictLineLogic = new SYS_DictItemLineLogic(this);
            InitializeGrid();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            BindSuperGrid(1);
        }

        private void frmStockManage_Load(object sender, EventArgs e)
        {
            BindComboBox();
            BindSuperGrid(1);
            
        }

        private void InitializeGrid()
        {
            GridPanel panel = sgcStock.PrimaryGrid;
            panel.FrozenColumnCount = 4;
            GridColumnCollection columns = panel.Columns;
            List<SYS_DictItemLineResult> itemLineList = dictLineLogic.GetListByCode(new SYS_DictItemLineParam
            {
                ItemCodes = new string[] { "Currency" }
            });
            foreach (GridColumn gridColumn in columns)
            {
               
                GridNumericUpDownEditControl nc=null;
                GridDoubleInputEditControl  rc= null;
                switch (gridColumn.Name)
                {
                    case "colCurrency":
                            dictLineLogic.BindComboBox(gridColumn.EditControl, "Currency", itemLineList);
                            dictLineLogic.BindComboBox(gridColumn.RenderControl, "Currency", itemLineList);
                            //gridColumn.RenderType = typeof(GridComboBoxExEditControl);
                        break;
                    case "colModel":
                    case "colItemCode":
                    case "colTItemCode":
                    case "colBrand":
                    case "colBatch":
                    case "colPackage":
                    case "colWarehouse":
                    case "colInvQty":
                    case "colBookedQty":
                    case "colUsableQty":
                    case "colInBatchNo":
                    case "colLocation":
                    case "colQuality":
                    case "colMPQ":
                    case "colMarkCode":
                    case "colDescription":
                    case "colRemark":
                    case "colInvType":
                    case "colUnit":
                    
                    case "colCreatedTime":
                        gridColumn.ReadOnly = true;
                        break;
                    case "colBuyPriceRMB":
                    case "colBuyPrice":
                    case "colBuyAveragePrice":
                        nc= (GridNumericUpDownEditControl)gridColumn.EditControl;
                        nc.Minimum =0;
                        nc.Maximum = 10000;
                        nc.DecimalPlaces = 5;
                        
                        gridColumn.RenderType = typeof(GridDoubleInputEditControl);
                        rc =(GridDoubleInputEditControl)gridColumn.RenderControl;
                        rc.DisplayFormat = "#,###.###;(#,###.###);";
                        gridColumn.ReadOnly = true;
                        break;
                    case "colFollowPrice":
                    case "colSalePrice":
                    
                        nc = (GridNumericUpDownEditControl)gridColumn.EditControl;
                        nc.Minimum =0;
                        nc.Maximum = 10000;
                        nc.DecimalPlaces = 5;
                        
                        gridColumn.RenderType = typeof(GridDoubleInputEditControl);
                        rc =(GridDoubleInputEditControl)gridColumn.RenderControl;
                        rc.DisplayFormat = "#,###.###;(#,###.###);";
                        rc.DisplayFormat = "F3";
                        break;
                }

               
            }

            

        }
   

        private void BindSuperGrid(int pageIndex)
        {
            STK_StockTtlParam param = new STK_StockTtlParam();
            param.Model = txtModel.Text;
            param.PageIndex = pageIndex;
            param.PageSize = 100;
            GridPanel panel = sgcStock.PrimaryGrid;
            PageList<STK_StockTtlResult> pageList = this.AsyncExecute<PageList<STK_StockTtlResult>, STK_StockTtlParam>(param, stockTtlLogic.GetPageListByDetail, a =>
            {

               // panel.DataSource = a.ResultList;
                pgStock.RecordCount = a.TotalCount;
                //sgcStock.BeginUpdate();


                //foreach (STK_StockTtlResult stockTtl in a.ResultList)
                //{

                //    GridRow row = panel.NewRow();
                //    row.Cells["colSelect"].ReadOnly = true;
                //    row.Cells["colTItemCode"].Value = stockTtl.TItemCode;
                //    row.Cells["colModel"].Value = stockTtl.Model;
                //    row.Cells["colBrand"].Value = stockTtl.Brand;
                //    row.Cells["colBatch"].Value = stockTtl.Batch;
                //    panel.Rows.Add(row);
                //    foreach (STK_StockResult stock in stockTtl.StockList)
                //    {
                //        GridPanel childPanel = new GridPanel();
                //        childPanel.Columns.Add(new GridColumn("colModel"));
                //        childPanel.Columns.Add(new GridColumn("colQty"));
                //        childPanel.Rows.Add(new GridRow(new object[] { "11", "22" }));
                //        row.Rows.Add(childPanel);
                //    }
                    
                //}
                    
                
                
                //sgcStock.EndUpdate();
                sgcStock.BeginUpdate();

                panel.Rows.Clear();
                foreach (STK_StockTtlResult stockTtl in a.ResultList)
                {

                    GridRow row = panel.NewRow();
                    //new Background(Color.AliceBlue)
                    //new Background(Color.White, Color.FromArgb(238, 244, 251), 45);
                    // new Background(Color.FromArgb(249, 249, 234));
                    // new Background(Color.FromArgb(255, 247, 250));
                    row.CellStyles.Default.Background = new Background(Color.FromArgb(238, 244, 251));
                    row.Cells["colSelect"].ReadOnly = true;
                    row.Cells["colTItemCode"].Value = stockTtl.TItemCode;
                    row.Cells["colModel"].Value = stockTtl.Model;
                    row.Cells["colBrand"].Value = stockTtl.Brand;
                    row.Cells["colBatch"].Value = stockTtl.Batch;
                    row.Cells["colPackage"].Value = stockTtl.Package;
                    row.Cells["colWarehouse"].Value = stockTtl.Warehouse;
                    row.Cells["colInvQty"].Value = stockTtl.TotalQty;
                    row.Cells["colBookedQty"].Value = stockTtl.MaxQty;
                    row.Cells["colUsableQty"].Value = stockTtl.MinQty;
                    row.Cells["colFollowPrice"].Value = stockTtl.MinQty;
                    row.Cells["colSalePrice"].Value = stockTtl.MinQty;
                    row.Cells["colCreatedTime"].Value = stockTtl.CreatedTime;

                    panel.Rows.Add(row);

                    foreach (STK_StockResult stock in stockTtl.StockList)
                    {
                        GridRow childRow = panel.NewRow();
                        childRow.Cells["colItemCode"].Value = stock.ItemCode;
                        childRow.Cells["colTItemCode"].Value = stock.TItemCode;
                        childRow.Cells["colModel"].Value = stock.Model;
                        childRow.Cells["colBrand"].Value = stock.Brand;
                        childRow.Cells["colBatch"].Value = stock.Batch;
                        childRow.Cells["colPackage"].Value = stock.Package;
                        childRow.Cells["colWarehouse"].Value = stock.Warehouse;
                        childRow.Cells["colInvQty"].Value = stock.InvQty;
                        childRow.Cells["colBookedQty"].Value = stock.BookedQty;
                        childRow.Cells["colUsableQty"].Value = stock.UsableQty;
                        childRow.Cells["colFollowPrice"].Value = stock.FollowPrice;
                        childRow.Cells["colSalePrice"].Value = stock.SalePrice;
                        childRow.Cells["colInBatchNo"].Value = stock.InBatchNo;
                        childRow.Cells["colLocation"].Value = stock.Location;
                        childRow.Cells["colQuality"].Value = stock.Quality;
                        childRow.Cells["colMPQ"].Value = stock.MPQ;
                        childRow.Cells["colMarkCode"].Value = stock.MarkCode;
                        childRow.Cells["colDescription"].Value = stock.Description;
                        childRow.Cells["colRemark"].Value = stock.Remark;
                        childRow.Cells["colInvType"].Value = stock.InvType;
                        childRow.Cells["colUnit"].Value = stock.Unit;
                        childRow.Cells["colCurrency"].Value = stock.Currency;
                        childRow.Cells["colBuyPrice"].Value = stock.BuyPrice;
                        childRow.Cells["colBuyPriceRMB"].Value = stock.BuyPriceRMB;
                        childRow.Cells["colBuyAveragePrice"].Value = stock.BuyAveragePrice;
                        childRow.Cells["colCreatedTime"].Value = stock.CreatedTime;
                        row.Rows.Add(childRow);
                    }

                }
                sgcStock.EndUpdate();
                panel.ExpandAll();

                
            });
        }

        private void BindComboBox()
        {
            List<SYS_DictItemLineResult> itemLineList = dictLineLogic.GetListByCode(new SYS_DictItemLineParam
            {
                ItemCodes = new string[] {"Warehouse"}
            });
            dictLineLogic.BindComboBox(cboWarehouse, "Warehouse", itemLineList);
        
        }

        private void pgStock_PageIndexChanged(object sender, EventArgs e)
        {
            BindSuperGrid(pgStock.PageIndex);
        }

        private void sgcStock_DataBindingComplete(object sender, GridDataBindingCompleteEventArgs e)
        {
           
        }
    }
}
