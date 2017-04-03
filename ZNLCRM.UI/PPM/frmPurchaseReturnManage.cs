using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZNLCRM.UI.Logic.PPM;
using ZNLCRM.UI.Logic.Sys;
using ZNLCRM.UI.Logic.STK;
using ZNLCRM.Entity.UserModel.Sys;
using ZNLCRM.Entity.UserModel.PPM;
using ZNLFrame.Entity;
using ZNLCRM.UI.Logic.Common;
using ZNLCRM.Entity.UserModel.Common;
using ZNLCRM.Utility;
using ZNLCRM.UI.Logic.WF;
using ZNLCRM.UI.STK;

namespace ZNLCRM.UI.PPM
{
    public partial class frmPurchaseReturnManage : frmBaseForm
    {
        ORD_PurchaseReturnLogic returnLogic = null;
        SYS_DictItemLineLogic dictLineLogic = null;
        STK_InLogic stkInLogic = null;
        int rowIndex = 0;
        Guid? _PRGuid;
        public frmPurchaseReturnManage()
        {
            InitializeComponent();
            dictLineLogic = new SYS_DictItemLineLogic(this);
            returnLogic = new ORD_PurchaseReturnLogic(this);
        }
        private void frmPurchaseReturnManage_Load(object sender, EventArgs e)
        {
            BindComboBox();
            BindDataGridView(1);
        }
        #region  初始化下拉框
        private void BindComboBox()
        {

            List<SYS_DictItemLineResult> itemLineList = dictLineLogic.GetListByCode(new SYS_DictItemLineParam
            {
                ItemCodes = new string[] { "Currency", "InvType", "ClearingForm", "TaxRate" }
            });
            dictLineLogic.BindComboBox(colCurrency, "Currency", itemLineList);
        }
        #endregion 

         #region 绑定表格
        private void BindDataGridView(int pageIndex)
        {
            ORD_PurchaseReturnParam param = new ORD_PurchaseReturnParam();
            param.BillNo = txtBillNo.Text;
            param.SupplierName = txtSupplierName.Text;
            param.OperEmpName = txtOperEmpName.Text;
            param.PageIndex = pageIndex;
            param.PageSize = 100;
            PageList<ORD_PurchaseReturnResult> pageList = this.AsyncExecute<PageList<ORD_PurchaseReturnResult>, ORD_PurchaseReturnParam>(param, returnLogic.GetPageList, a =>
            {


                dgvPurchaseReturn.DataSource = a.ResultList;
                pgPurchaseReturn.RecordCount = a.TotalCount;

            });
        }
        #endregion
        private void btnSearch_Click(object sender, EventArgs e)
        {
            BindDataGridView(1);
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            frmPurchaseReturn frmPurchaseReturn = new frmPurchaseReturn();
            frmPurchaseReturn.BringToFront();
            frmPurchaseReturn.StartPosition = FormStartPosition.CenterScreen;
            frmPurchaseReturn.ShowDialog();
            frmPurchaseReturn.RefreshParentForm += delegate { BindDataGridView(pgPurchaseReturn.PageIndex); };
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            if (_PRGuid != null)
            {
                frmPurchaseReturn frmPurchaseReturn = new frmPurchaseReturn();
                frmPurchaseReturn.PRGuid = _PRGuid;
                frmPurchaseReturn.BringToFront();
                frmPurchaseReturn.StartPosition = FormStartPosition.CenterScreen;
                frmPurchaseReturn.ShowDialog();
                frmPurchaseReturn.RefreshParentForm += delegate { BindDataGridView(pgPurchaseReturn.PageIndex); };

            }
            else
            {
                this.ShowMessage("请选择要编辑的采购单");
            }
        }

        
        

        private void tsbDel_Click(object sender, EventArgs e)
        {
            ORD_PurchaseReturnParam param = new ORD_PurchaseReturnParam();
            param.PRGuid = _PRGuid;

            ORD_PurchaseReturnResult rst = returnLogic.GetInfo(param);
            if (rst != null)
            {
                if (MessageBox.Show("请确认是否要删除采购退货单：【" + rst.BillNo + "】", "操作提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    WCFAddUpdateResult result = this.AsyncExecute<WCFAddUpdateResult, ORD_PurchaseReturnParam>(param, returnLogic.DelInfo, a => { BindDataGridView(pgPurchaseReturn.PageIndex); });
                }
            }
            else
            {
                this.ShowMessage("请选择需要删除的采购退货单！");
            }
        }

        private void pgPurchaseReturn_PageIndexChanged(object sender, EventArgs e)
        {
            BindDataGridView(pgPurchaseReturn.PageIndex);
        }

        private void tlbAuditBill_Click(object sender, EventArgs e)
        {
            AuditBill();
        }
        void AuditBill()
        {
            int rowIdx = this.dgvPurchaseReturn.CurrentCell == null ? -1 : this.dgvPurchaseReturn.CurrentCell.RowIndex;
            if (rowIdx < 0)
            {
                this.ShowMessage("请指定要审核记录！");
                return;
            }
            
            Guid? guidKey = this.dgvPurchaseReturn["colPRGuid", rowIdx].Value.ToGuid();
            string billNo = this.dgvPurchaseReturn["colBillNo", rowIdx].Value.ToStringHasNull();
            ZNLCRM.UI.Logic.WF.frmAuditRecordList frmRecord = new ZNLCRM.UI.Logic.WF.frmAuditRecordList("ORD_PurchaseReturn", guidKey, billNo);
            frmRecord.ShowDialog();
        }

        private void tlbCancelBill_Click(object sender, EventArgs e)
        {
            CancelBill();
        }
        void CancelBill()
        {
            int rowIdx = this.dgvPurchaseReturn.CurrentCell == null ? -1 : this.dgvPurchaseReturn.CurrentCell.RowIndex;
            if (rowIdx < 0)
            {
                this.ShowMessage("请指定要撤单的记录！");
                return;
            }
            Guid? guidKey = this.dgvPurchaseReturn["colPRGuid", rowIdx].Value.ToGuid();
            WF_AuditRecordLogic logicWF = new WF_AuditRecordLogic(this);
            WCFAddUpdateResult rstAudit = logicWF.CancelBill(new Entity.UserModel.WF.WF_AuditRecordParam()
            {
                SourceTableEngName = "ORD_PurchaseReturn",
                SourceBillGuid = guidKey
            });
            if (rstAudit.Key > 0)
            {
                BindDataGridView(1);
                this.ShowMessage("撤单成功!");
            }
        }

        #region  数据加载完成
        private void dgvPurchaseReturn_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in this.dgvPurchaseReturn.Rows)
            {
                if (row.Cells["colStkOutOccStatus"].Value.ToStringHasNull() != "全部占有" && row.Cells["colStatus"].Value.ToStringHasNull() == "Complete")
                {
                    row.Cells["colOperOut"].Value = "出库";
                }
                else
                {
                    row.Cells["colOperOut"].Value = "";
                }
            }
        }
        #endregion

        #region 单元格内容点击
        private void dgvPurchaseReturn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            #region 入库按钮
            if (e.ColumnIndex == this.dgvPurchaseReturn.Columns["colOperOut"].Index)
            {
                frmStkOut frm = new frmStkOut("POR_OUT", this.dgvPurchaseReturn["colPRGuid", e.RowIndex].Value.ToGuid());
                frm.BringToFront();
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.ShowDialog();
            }
            #endregion
        }
        #endregion
    }
}
