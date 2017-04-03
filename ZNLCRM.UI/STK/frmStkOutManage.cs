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
using ZNLCRM.UI.Logic.Sys;
using ZNLCRM.Entity.UserModel.Sys;
using ZNLCRM.Entity.UserModel.STK;
using ZNLFrame.Entity;
using ZNLCRM.Utility;
using DevComponents.DotNetBar.SuperGrid;

namespace ZNLCRM.UI.STK
{
    public partial class frmStkOutManage :frmBaseManageForm
    {
        STK_OutLogic stkOutlogic = null;
        SYS_DictItemLineLogic dictLineLogic = null;
        Guid? stkOutGuid =null;
        public frmStkOutManage()
        {
            InitializeComponent();
            stkOutlogic = new STK_OutLogic(this);
            dictLineLogic = new SYS_DictItemLineLogic(this);
            InitializeGrid();
        }
        private void frmStkOutManage_Load(object sender, EventArgs e)
        {
            BindComboBox();
            BindSuperGrid(1);
        }
       

        #region  初始化下拉框
        private void BindComboBox()
        {
            List<SYS_DictItemLineResult> itemLineList = dictLineLogic.GetListByCode(new SYS_DictItemLineParam
            {
                ItemCodes = new string[] {
                "StkOutBillType","Currency","TaxRate"}
            });

            foreach (GridColumn gridColumn in sgcStkOut.PrimaryGrid.Columns)
            {
                switch(gridColumn.Name)
                {
                    case "colBillType":
                        dictLineLogic.BindComboBox(gridColumn.RenderControl, "StkOutBillType", itemLineList);
                        break;
                    case "colCurrency":
                        dictLineLogic.BindComboBox(gridColumn.RenderControl, "Currency", itemLineList);
                        break;
                    case "colTaxRate":
                        dictLineLogic.BindComboBox(gridColumn.RenderControl, "TaxRate", itemLineList);
                        break;
                }
            }
          
        }
        #endregion

        #region 初始化表格
        private void InitializeGrid()
        { 
            
        
        }
        #endregion
        #region 绑定表格
        private void BindSuperGrid(int pageIndex)
        {
            STK_OutParam param=new STK_OutParam ();
            param.BillNo=txtBillNo.Text;
            
            param.BillType=cboBillType.SelectedValue.ToStringHasNull();

            PageList<STK_OutResult> pgList = this.AsyncExecute<PageList<STK_OutResult>, STK_OutParam>(param, stkOutlogic.GetPageList, a =>
            {
                if (a.ResultList != null)
                {
                    sgcStkOut.PrimaryGrid.DataSource = a.ResultList;
                    pgStkOut.RecordCount = a.TotalCount;
                }

            });
        }
        #endregion

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            frmStkOut frmStkOut = new frmStkOut();
            frmStkOut.ShowDialog();
            frmStkOut.BringToFront();
            frmStkOut.RefreshParentForm += delegate { BindSuperGrid(pgStkOut.PageIndex); };
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            frmStkOut frmStkOut = new frmStkOut();
            frmStkOut.StkOutGuid = stkOutGuid;
            frmStkOut.StartPosition = FormStartPosition.CenterScreen;
            frmStkOut.BringToFront();
            frmStkOut.ShowDialog();
            frmStkOut.RefreshParentForm += delegate { BindSuperGrid(pgStkOut.PageIndex); };
        }

        private void tsbDel_Click(object sender, EventArgs e)
        {
            
        }

        #region  分页     
        private void pgStkOut_PageIndexChanged(object sender, EventArgs e)
        {
            BindSuperGrid(pgStkOut.PageIndex);
        }
        #endregion

        #region 搜索
        private void btnSearch_Click(object sender, EventArgs e)
        {
            BindSuperGrid(1);
        }
        #endregion

        #region 行激活事件
        private void sgcStkOut_RowActivated(object sender, GridRowActivatedEventArgs e)
        {
            GridRow gridRow = sgcStkOut.PrimaryGrid.Rows[e.NewActiveRow.RowIndex] as GridRow;
            if (gridRow != null)
            {
               stkOutGuid= gridRow.Cells["colStkOutGuid"].Value.ToGuid();
            }
        }
        #endregion

        private void sgcStkOut_RowDoubleClick(object sender, GridRowDoubleClickEventArgs e)
        {
            tsbEdit_Click(sender, e);
        }

      


    }
}
