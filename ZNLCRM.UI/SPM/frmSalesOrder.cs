using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZNLCRM.UI.Logic.Sys;
using ZNLCRM.Entity.UserModel.Sys;
using ZNLFrame.Entity;
using ZNLCRM.UI.Logic.SPM;
using ZNLCRM.Entity.UserModel.SPM;
using ZNLCRM.UI.Logic.Common;
using ZNLCRM.Utility;
using ZNLCRM.Entity.UserModel.Common;
using ZNLCRM.UI.HR;
using ZNLCRM.UI.Logic.HR;
using ZNLCRM.Entity.UserModel.HR;
using ZNLCRM.UI.CRM;
using ZNLCRM.Entity.UserModel.CRM;
using ZNLCRM.Utility.CommonEnum;
using ZNLCRM.UI.Logic.CRM;
using ZNLCRM.Client.Entry;
using ZNLCRM.UI.STK;
using ZNLCRM.Entity.DBModel;
using ZNLCRM.Entity.UserModel.STK;
using ZNLCRM.UI.Logic.STK;
using ZNLCRM.Controls;
using ZNLCRM.UI.Logic.WF;
using ZNLCRM.UI.WF;

namespace ZNLCRM.UI.SPM
{
    public partial class frmSalesOrder : frmBaseEditForm
    {
        public delegate void dlgRefreshParentForm();
        public event dlgRefreshParentForm RefreshParentForm;
        public delegate void dlgSaveAttach(string sourceTable, Guid sourceGuid, string sourceBillNo);
        public event dlgSaveAttach SaveAttach;
        public int? soid = 0;
        public Guid? soguid;
        public string sourcebillno = string.Empty;
        HR_OrgLogic orgLogic = null;
        SYS_DictItemLineLogic dictLineLogic = null;
        CRM_CompanyLogic companyLogic = null;
        ORD_SalesOrderLogic orderLogic = null;
        ORD_PurchaseNoticeLogic noticeLogic = null;
        STK_StockReserveLogic  reserveLogic=null;
        BindingSource bsOrderLine = new BindingSource();
        List<ORD_SalesOrderLineResult> tempList = new List<ORD_SalesOrderLineResult>();
        List<ORD_SalesOrderLineResult> delList = new List<ORD_SalesOrderLineResult>();
        List<ORD_SalesOrderLineResult> addOrModifyList = new List<ORD_SalesOrderLineResult>();
        bool operFlag = false;
        public frmSalesOrder()
        {
            InitializeComponent();
            this.GetEditEntity += new dlgGetEditEntity(Form_GetEditEntity);
            dictLineLogic = new SYS_DictItemLineLogic(this);
            orgLogic = new HR_OrgLogic(this);
            orderLogic = new ORD_SalesOrderLogic(this);
            companyLogic = new CRM_CompanyLogic(this);
            reserveLogic=new STK_StockReserveLogic(this);
            noticeLogic = new ORD_PurchaseNoticeLogic(this);
        }

        #region 实现基类获取实体信息方法
        object Form_GetEditEntity()
        {
            ORD_SalesOrderResult info = new ORD_SalesOrderResult();
            info.SOGuid = soguid;
            info = this.ConvertControlToEntity<ORD_SalesOrderResult>(this.stcpBase.Controls, info, null);
            info = this.ConvertControlToEntity<ORD_SalesOrderResult>(this.stcpOther.Controls, info, null);
            this.SetDataIsChanged<ORD_SalesOrderResult>(info);
            return info;
        }
        #endregion

        #region 初始化绑定控件
        public void BindComboBox()
        {
            orgLogic.BindComboBox(cboSalOrgID, new HR_OrgParam { });
            List<SYS_DictItemLineResult> itemLineList = dictLineLogic.GetListByCode(new SYS_DictItemLineParam
            {
                ItemCodes = new string[] {
                "SalesOrderBillType","TransportCompany","FreightPaymentType" ,"ClearingForm","Currency","UnitCode","InvType","IsInvoiced","InvoiceType","TaxRate","Warehouse" }
            });
            dictLineLogic.BindComboBox(cboBillType,"SalesOrderBillType" , itemLineList);
            dictLineLogic.BindComboBox(cboTransportCompany,  "TransportCompany" , itemLineList);
            dictLineLogic.BindComboBox(cboFreightClearForm, "FreightPaymentType" , itemLineList);
            dictLineLogic.BindComboBox(cboClearingForm,"ClearingForm" , itemLineList);
            dictLineLogic.BindComboBox(cboCurrency, "Currency" , itemLineList);
            dictLineLogic.BindComboBox(cboIsInvoiced,"IsInvoiced" , itemLineList);
            dictLineLogic.BindComboBox(cboInvoiceType,"InvoiceType", itemLineList);
            dictLineLogic.BindComboBox(cboTaxRate,"TaxRate" , itemLineList);
            dictLineLogic.BindComboBox(colUnit, "UnitCode", itemLineList);
            dictLineLogic.BindComboBox(colInvType, "InvType", itemLineList);
            dictLineLogic.BindComboBox(colWarehouse, "Warehouse", itemLineList);
            
        }
        #endregion

        #region 初始化加载数据
        private void InitData()
        {
            if (soguid != null)
            {
                ORD_SalesOrderResult info = orderLogic.GetInfo(new ORD_SalesOrderParam { SOGuid = soguid });
                
                this.ConvertEntityToControl<ORD_SalesOrderResult>(this.stcpBase.Controls, info, null);
                this.ConvertEntityToControl<ORD_SalesOrderResult>(this.stcpOther.Controls, info, null);
                if (info != null )
                {
                    txtSalDeptName.Text = info.SalDeptName;
                    decimal taxAmount = Math.Round(info.TaxAmount.ToDecimal(), 3, MidpointRounding.AwayFromZero);
                    decimal totalAmount = Math.Round(info.Amount.ToDecimal(), 3, MidpointRounding.AwayFromZero);
                    decimal commissionAmount = Math.Round(info.CommissionAmount.ToDecimal(), 3, MidpointRounding.AwayFromZero);
                    txtAmount.Text = totalAmount.ToStringHasNull();
                    txtTaxAmount.Text = taxAmount.ToStringHasNull();
                    txtCommissionAmount.Text = commissionAmount.ToStringHasNull();
                    if (info.OrderLineList != null)
                    {
                        addOrModifyList = info.OrderLineList;
                    }
                }

            }
            else
            {
                cboBillType.SelectedValue = "外贸单";
                txtNeedDeliveryDate.Text = DateTime.Now.ToStringHasNull();
                txtNeedRecAmtDate.Text = DateTime.Now.ToStringHasNull();
                txtSODate.Text = DateTime.Now.Date.ToStringHasNull();
                txtSalDeptID.Text = MySession.DeptID.ToStringHasNull();
                txtSalDeptName.Text = MySession.DeptName;
                txtSalerID.Text = MySession.UserID.ToStringHasNull();
                txtSalerName.Text = MySession.UserName.ToStringHasNull();
                SYS_DictItemLineLogic.SetCombolSelectedIndex(this.cboSalOrgID, MySession.OrgID, true);
            }
            bsOrderLine.DataSource = addOrModifyList;
            dgvSalesOrderLine.DataSource = bsOrderLine;
            BindSuperGridControl();
            CheckAuditButton("ORD_SalesOrder", soguid, this.tsbSubmit, null, this.tsbAudit, this.tsbUnDo);
        }
        #endregion

        #region 窗体加载
        private void frmSalesOrder_Load(object sender, EventArgs e)
        {
            frmSysAttachFiles frm=new frmSysAttachFiles ();
            frm.SourceGuid = soguid;
            frm.TopLevel = false;
            //frm.Tag = newItem; //存放选项卡对象，方便后续在事件里关闭选项卡
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            stcpSys_AttachFiles.Controls.Add(frm);
            frm.Show();
            BindComboBox();
            InitData();
            this.SaveAttach += new dlgSaveAttach(frm.SaveAttach);
            operFlag = true;
           
        }
        #endregion

        #region 按钮方法
        private void tsbSave_Click(object sender, EventArgs e)
        {
            SaveData(true);
        }
        /// <summary>
        /// 保存,返回值如果是异步执行,返回值无效果,除非是同步执行,返回值有效
        /// </summary>
        /// <param name="isAsyncExecute">是否异步执行</param>
        /// <returns></returns>
        private bool SaveData(bool isAsyncExecute)
        {
            bool ret = false;
            WCFAddUpdateResult result = new WCFAddUpdateResult();
            #region 判断和获取实体
            ORD_SalesOrderResult info = Form_GetEditEntity() as ORD_SalesOrderResult;
            if (!this.DataIsChanged && isAsyncExecute)//异步执行时判断数据是否有变化
            {
                this.ShowNoChangedMsg();
                return ret;
            }
            bool flag = false;
            foreach (ORD_SalesOrderLineResult rst in addOrModifyList)
            {
                if (string.IsNullOrEmpty(rst.Model) || rst.Qty.ToInt32() <= 0)
                {
                    flag = true;
                    break;
                }
            }
            if (flag)
            {
                this.ShowMessage("型号或数量不能为空！");
                return ret;
            }
            #endregion
            #region 明细
            bsOrderLine.EndEdit();
            tempList.Clear();
            foreach (ORD_SalesOrderLineResult rst in addOrModifyList)
            {
                if (rst.HasChanged())
                {
                    tempList.Add(rst);
                }
            }
            //tempList.AddRange(addOrModifyList);
            tempList.AddRange(delList);
            info.OrderLineList = tempList;
            #endregion
            #region 异步执行,点击保存铵钮时
            if (isAsyncExecute)
            {
                #region 异步执行保存操作
                result = this.AsyncExecute<WCFAddUpdateResult, ORD_SalesOrderResult>(info, orderLogic.AddOrUpdate, (a) =>
                {
                    if (a.KeyGuid.ToGuid() != Guid.Empty)
                    {
                        soid = a.Key;
                        soguid = a.KeyGuid.ToGuid();
                        sourcebillno = a.BillNo;
                        CRM_CompanyResult companyResult = companyLogic.GetCustInfo(new CRM_CompanyParam() { CompanyID = txtCustomerID.Text.ToInt32() });
                        if (companyResult != null)
                        {
                            companyResult.LastBusinessDate = txtSODate.Text.ToDateTime();
                            companyLogic.AddOrUpdateCust(companyResult);
                        }
                        if (SaveAttach != null)
                            SaveAttach("ORD_SalesOrder", soguid.ToGuid(), sourcebillno);
                        InitData();
                        delList.Clear();
                    }
                });
                #endregion
            }
            #endregion
            #region 非异步执
            else
            {
                result = orderLogic.AddOrUpdate(info);
                if (result.KeyGuid.ToGuid() != Guid.Empty)
                {
                    ret = true;
                }
            }
            return ret;
            #endregion
        }
       
        #region 审核相关方法
        #region 提交
        private void tsbSubmit_Click(object sender, EventArgs e)
        {
            //tsbSave_Click(sender, e);
            //bool flag = orderLogic.SubmitSalesOrderBill(new ORD_SalesOrderParam() { SOGuid = soguid });
            // if (flag)
            //     InitData();
            ORD_SalesOrderResult info = Form_GetEditEntity() as ORD_SalesOrderResult;
            this.WF_SubmitBill("ORD_SalesOrder", info, info.BillNo, info.SOGuid, this.DataIsChanged, delegate() { return (SaveData(false)); }, InitData);
        }
        #endregion
        #region 审核
        private void tsbAudit_Click(object sender, EventArgs e)
        {
            //bool flag= orderLogic.AuditSalesOrderBill(new ORD_SalesOrderParam() { SOGuid = soguid });
            //if (flag)
            //  InitData();
            ORD_SalesOrderResult info = Form_GetEditEntity() as ORD_SalesOrderResult;
            this.WF_CheckBill("ORD_SalesOrder", info.BillNo, info.SOGuid, this.DataIsChanged, delegate() { return (SaveData(false)); }, InitData);
        }
        #endregion
        #region 撤单
        private void tsbUnDo_Click(object sender, EventArgs e)
        {
            ORD_SalesOrderResult info = Form_GetEditEntity() as ORD_SalesOrderResult;
            this.WF_CancelCheckBill("ORD_SalesOrder", info.SOGuid, InitData);
        }
        #endregion
        #endregion
        #region   从库存导入
        private void btnImportByStock_Click(object sender, EventArgs e)
        {
            ImportByStock(true);

        }
        private void ImportByStock(bool isMutiSelect)
        {

                frmSelectStock frmSelectStock = new frmSelectStock(isMutiSelect);
                Guid? itemCode = Guid.Empty;
                string model = string.Empty;
                if (!isMutiSelect)//单选时
                {
                    model = dgvSalesOrderLine.CurrentRow.Cells["colModel"].Value.ToStringHasNull();
                    itemCode = dgvSalesOrderLine.CurrentRow.Cells["colItemCode"].Value.ToGuid();
                }

                if (!string.IsNullOrEmpty(model))
                    frmSelectStock.Model = model;
                if (itemCode != Guid.Empty)//如果已经存在关联的库存guid，则只筛选此条明细
                    frmSelectStock.ItemCode = itemCode;
                else//如果是新行，则排除掉已经存在列表里面的所有的库存guid
                {
                    Guid?[] noItemCodes = addOrModifyList.Where(a => a.ItemCode.ToGuid() != Guid.Empty).Select(a => a.ItemCode).Distinct().ToArray();
                    frmSelectStock.NoItemCodes = noItemCodes;
                }
                frmSelectStock.BringToFront();
                frmSelectStock.StartPosition = FormStartPosition.CenterScreen;
                DialogResult rst = frmSelectStock.ShowDialog();
                if (rst == DialogResult.OK)
                {
                    List<STK_StockResult> rstList = frmSelectStock.GetSelectList<STK_StockResult>();
                    if (rstList != null && rstList.Count > 0)
                    {
                        foreach (STK_StockResult stockResult in rstList)
                        {
                            bool isAddNew = true;
                            foreach (DataGridViewRow row in dgvSalesOrderLine.Rows)
                            {
                                //如果是已经存在的行，则利用现成的行进行编辑

                                if (row.Cells["colItemCode"].Value.ToGuid() == stockResult.ItemCode)
                                {
                                    isAddNew = false;

                                    ORD_SalesOrderLineResult orderLineResult = bsOrderLine[row.Index] as ORD_SalesOrderLineResult;
                                    SetOrderLineObjectValue(orderLineResult, stockResult);
                                    break;
                                }
                            }
                            if (isAddNew)
                            {
                                if (!isMutiSelect)//单选
                                {
                                    ORD_SalesOrderLineResult orderLineResult = bsOrderLine.Current as ORD_SalesOrderLineResult;
                                    SetOrderLineObjectValue(orderLineResult, stockResult);
                                }
                                else//多选
                                {
                                    ORD_SalesOrderLineResult orderLineResult = new ORD_SalesOrderLineResult();
                                    SetOrderLineObjectValue(orderLineResult, stockResult);
                                    bsOrderLine.Add(orderLineResult);
                                }
                            }
                        }
                    }
                }
            
        
        }
        #endregion
        #region 给销售明细对象赋值
        public void SetOrderLineObjectValue(ORD_SalesOrderLineResult salesLineRst, STK_StockResult stockResult)
        {
            salesLineRst.ItemCode = stockResult.ItemCode;
            salesLineRst.Model = stockResult.Model;
            salesLineRst.Brand = stockResult.Brand;
            salesLineRst.Package = stockResult.Package;
            salesLineRst.Batch = stockResult.Batch;
            salesLineRst.InvType = stockResult.InvType;
            salesLineRst.Unit = stockResult.Unit;
            salesLineRst.Qty = stockResult.UsableQty;
            salesLineRst.Quality = stockResult.Quality;
            salesLineRst.MPQ = stockResult.MPQ;
            salesLineRst.MarkCode = stockResult.MarkCode;
            salesLineRst.Warehouse = stockResult.Warehouse;
            salesLineRst.Location = stockResult.Location;
            salesLineRst.NeedDeliveryDate = string.IsNullOrEmpty(txtNeedDeliveryDate.Text) ? null : (DateTime?)txtNeedDeliveryDate.Value;
            salesLineRst.NeedRecAmtDate = string.IsNullOrEmpty(txtNeedRecAmtDate.Text) ? null : (DateTime?)txtNeedRecAmtDate.Value;
        }
        #endregion
        #region 预留
        private void btnReserve_Click(object sender, EventArgs e)
        {
            if (soguid != null)
            {
                frmStockReserve frmStockReserve = new frmStockReserve();
                frmStockReserve.StartPosition = FormStartPosition.CenterScreen;
                frmStockReserve.BringToFront();
                frmStockReserve.SourceBillGuid = soguid;
                frmStockReserve.RefreshParentForm += delegate { BindSuperGridControl(); };
                frmStockReserve.ShowDialog();
            }
            else {
                this.ShowMessage("预留之前请先保存销售单！");
            }
        }
        #endregion

        #region 通知
        private void btnNotice_Click(object sender, EventArgs e)
        {
            if (soguid != null)
            {
                if (txtStatus.Text == "Complete")
                {
                    frmPurchaseNotice frmPurchaseNotice = new frmPurchaseNotice();
                    frmPurchaseNotice.StartPosition = FormStartPosition.CenterScreen;
                    frmPurchaseNotice.BringToFront();
                    frmPurchaseNotice.SOGuid = soguid;
                    frmPurchaseNotice.RefreshParentForm += delegate { BindSuperGridControl(); };
                    frmPurchaseNotice.ShowDialog();
                }
                else
                {
                    this.ShowMessage("通知采购之前须先审核通过销售单！");
                }
            }

            else
            {
                this.ShowMessage("通知采购之前请先保存销售单！");
            }
            
        }
        #endregion

        #region 新增一行
        private void btnAddRow_Click(object sender, EventArgs e)
        {
            bsOrderLine.AddNew();
           ORD_SalesOrderLineResult rst= bsOrderLine.Current as ORD_SalesOrderLineResult;
           InitNewData(rst);
        }
        #endregion
        #region 插入一行
        private void btnInsertBefore_Click(object sender, EventArgs e)
        {
            if (dgvSalesOrderLine.CurrentCell == null)
            {
                btnAddRow_Click(null, null);
                return;
            }
            ORD_SalesOrderLineResult rst = new ORD_SalesOrderLineResult();
            InitNewData(rst);
            bsOrderLine.Insert(dgvSalesOrderLine.CurrentRow.Index, rst);
        }
        #endregion
        void InitNewData(ORD_SalesOrderLineResult rst)
        {
            rst.Unit = "PCS";
            if (!string.IsNullOrEmpty(txtNeedDeliveryDate.Text))
                rst.NeedDeliveryDate = txtNeedDeliveryDate.Value;
            else
                rst.NeedDeliveryDate = null;
            if (!string.IsNullOrEmpty(txtNeedRecAmtDate.Text))
                rst.NeedRecAmtDate = txtNeedRecAmtDate.Value;
            else
                rst.NeedRecAmtDate = null;
        }
        #region 删除行
        private void btnDelRow_Click(object sender, EventArgs e)
        {
            if (this.bsOrderLine.Current != null)
            {

                int solineid = 0;
                ORD_SalesOrderLineResult delResult = this.bsOrderLine.Current as ORD_SalesOrderLineResult;
                solineid = delResult.SOLineID.ToInt32();
                if (solineid > 0)
                {
                    delResult.IsDeleted = true;
                    delList.Add(delResult);
                }
                bsOrderLine.RemoveCurrent(); 

            }
        }
        #endregion
        #endregion

        #region 表格事件
        #region 单元格值改变
        private void dgvSalesOrderLine_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
           
            int qty=0;
            decimal taxRate=0.0m;
            decimal nTaxPrice=0.0m;
            decimal unitPrice=0.0m;
            decimal commissionPrice = 0.0m;
            int calcType=0;
            calcType = chkCalcType.Checked ? 1 : 0;
            taxRate = cboTaxRate.SelectedValue.ToDecimal() / 100;
           
            if(e.RowIndex>-1 && e.ColumnIndex>-1)
            {
                dgvSalesOrderLine.CellValueChanged -= new DataGridViewCellEventHandler(dgvSalesOrderLine_CellValueChanged);
                try
                {
                    string columnName = dgvSalesOrderLine.Columns[e.ColumnIndex].Name;
                    if (columnName == "colQty")
                    {
                        qty = dgvSalesOrderLine["colQty", e.RowIndex].Value.ToInt32();
                        nTaxPrice = dgvSalesOrderLine["colNTaxPrice", e.RowIndex].Value.ToDecimal();
                        unitPrice = dgvSalesOrderLine["colUnitPrice", e.RowIndex].Value.ToDecimal();
                        dgvSalesOrderLine["colAmount", e.RowIndex].Value = qty * unitPrice;
                            
                    }
                    else if (columnName == "colNTaxPrice")
                    {
                       if(calcType==0)
                       {
                            qty = dgvSalesOrderLine["colQty", e.RowIndex].Value.ToInt32();
                            nTaxPrice = dgvSalesOrderLine["colNTaxPrice", e.RowIndex].Value.ToDecimal();
                            unitPrice = Math.Round((taxRate  + 1) * nTaxPrice,5, MidpointRounding.AwayFromZero);
                            dgvSalesOrderLine["colUnitPrice", e.RowIndex].Value = unitPrice;
                            dgvSalesOrderLine["colAmount", e.RowIndex].Value = qty * unitPrice;
                        }

                    }
                    else if (columnName == "colUnitPrice")
                    {

                        if (calcType == 1)
                        {
                            qty = dgvSalesOrderLine["colQty", e.RowIndex].Value.ToInt32();
                            unitPrice = dgvSalesOrderLine["colUnitPrice", e.RowIndex].Value.ToDecimal();
                            dgvSalesOrderLine["colNTaxPrice", e.RowIndex].Value = Math.Round(unitPrice / (taxRate + 1), 5, MidpointRounding.AwayFromZero);
                            dgvSalesOrderLine["colAmount", e.RowIndex].Value = qty * unitPrice;
                        }
                        else
                        {
                            if (dgvSalesOrderLine["colNTaxPrice", e.RowIndex].Value.ToDecimal() > dgvSalesOrderLine["colUnitPrice", e.RowIndex].Value.ToDecimal())
                            {
                                this.ShowMessage("第"+(e.RowIndex+1)+"行含税价不能小于未含税价！");
                                dgvSalesOrderLine["colUnitPrice", e.RowIndex].Style.BackColor = Color.FromArgb(255, 128, 0);
                                return;
                            }
                        }
                    }
                    else if (columnName == "colCommissionPrice")
                    { 
                        qty = dgvSalesOrderLine["colQty", e.RowIndex].Value.ToInt32();
                        commissionPrice = dgvSalesOrderLine["colCommissionPrice", e.RowIndex].Value.ToDecimal();
                        dgvSalesOrderLine["colCommissionAmount", e.RowIndex].Value = qty * commissionPrice;
                    }
                 
                    bsOrderLine.EndEdit();
                    CalcAmount();
                }
                finally
                {
                    dgvSalesOrderLine.CellValueChanged += new DataGridViewCellEventHandler(dgvSalesOrderLine_CellValueChanged);
                }
                
            }
        }
        #endregion

        #region 单元格内容单击
        private void dgvSalesOrderLine_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {


            }
        }
        #endregion

        #region 数据绑定完成
        private void dgvSalesOrderLine_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            
            foreach (DataGridViewRow row in dgvSalesOrderLine.Rows)
            {
               
                    if (row.Cells["colIsCancel"].Value.ToBooleanHasNull())
                    {

                        foreach (DataGridViewColumn column in dgvSalesOrderLine.Columns)
                        {
                            if (column.Name != "colIsCancel")
                            {
                                row.Cells[column.Name].Style.ForeColor = Color.Red;
                                row.Cells[column.Name].ReadOnly = true;
                            }
                           
                        }
                        
                    }
            }
        }
        #endregion

        #region 单元格值转换
        private void dgvSalesOrderLine_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            //DataGridView dgvx = sender as DataGridView;
            //int colIndex = dgvx.CurrentCell.ColumnIndex;
            //string colName = dgvx.Columns[colIndex].Name;
            //if (colName == "colModel")
            //{
            //    (e.Control as TextBox).CharacterCasing = CharacterCasing.Upper;
            //}
        }
        #endregion

        private void dgvSalesOrderLine_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                DataGridView dgv = sender as DataGridView;
                if (dgv.Columns[e.ColumnIndex].Name == "colModel"
                    || dgv.Columns[e.ColumnIndex].Name == "colBrand"
                    || dgv.Columns[e.ColumnIndex].Name == "colPackage"
                    || dgv.Columns[e.ColumnIndex].Name == "colBatch")
                {
                    e.Value = e.Value.ToStringHasNull().ToUpper();
                    e.FormattingApplied = true;
                }
            }
        }
        #endregion

        #region 方法
        private void CalcAmount()
        {
            decimal totalAmount = 0.0m;
            decimal taxAmount = 0.0m;
            decimal commissionAmount = 0.0m;
            decimal taxRate = 0.0m;
            taxRate = cboTaxRate.SelectedValue.ToDecimal() / 100;
            foreach (DataGridViewRow row in dgvSalesOrderLine.Rows)
            {
                bool cancelFlag = row.Cells["colIsCancel"].Value.ToBooleanHasNull();
                if (!cancelFlag)
                {
                    totalAmount += row.Cells["colAmount"].Value.ToDecimal();
                    commissionAmount += row.Cells["colCommissionAmount"].Value.ToDecimal();
                }

            }
            taxAmount = Math.Round(totalAmount * taxRate, 3, MidpointRounding.AwayFromZero);
            totalAmount = Math.Round(totalAmount, 3, MidpointRounding.AwayFromZero);
            commissionAmount = Math.Round(commissionAmount, 3, MidpointRounding.AwayFromZero);
            txtAmount.Text = totalAmount.ToStringHasNull();
            txtTaxAmount.Text = taxAmount.ToStringHasNull();
            txtCommissionAmount.Text = commissionAmount.ToStringHasNull();


        }
        #endregion

        #region 文本框按钮
        private void txtSalesDeptName_ButtonCustomClick(object sender, EventArgs e)
        {
            frmSelectDepartment frmSelectDepartment = new frmSelectDepartment(false);
            frmSelectDepartment.deptIds = txtSalerID.Text.Split(',').Select(a => (int?)a.ToInt32()).ToArray();
            frmSelectDepartment.OrgID = cboSalOrgID.SelectedValue.ToInt32();

            DialogResult rst = frmSelectDepartment.ShowDialog();
            if (rst == DialogResult.OK)
            {
                List<HR_DepartmentResult> rstList = frmSelectDepartment.GetSelectList<HR_DepartmentResult>();
                if (rstList != null && rstList.Count > 0)
                {
                        txtSalDeptID.Text = rstList[0].DeptID.ToStringHasNull();
                        txtSalDeptName.Text = rstList[0].DeptName.ToStringHasNull();
                }
            }
        }

        private void txtSalesManName_ButtonCustomClick(object sender, EventArgs e)
        {
             frmSelectEmp frmSelectEmp = new frmSelectEmp(false);
             frmSelectEmp.empIds = txtSalerID.Text.Split(',').Select(a => (int?)a.ToInt32()).ToArray();
             frmSelectEmp.OrgID = cboSalOrgID.SelectedValue.ToInt32();
             frmSelectEmp.DeptID = txtSalDeptID.Text.ToInt32();
            DialogResult rst = frmSelectEmp.ShowDialog();
            if (rst == DialogResult.OK)
            {
                List<HR_EmployeeResult> rstList = frmSelectEmp.GetSelectList<HR_EmployeeResult>();
                if (rstList != null && rstList.Count > 0)
                {
                    txtSalerID.Text =rstList[0].EmpID.ToStringHasNull();
                        txtSalerName.Text = rstList[0].EmpName.ToStringHasNull();
                }
            }
        }

        private void txtCustomerName_ButtonCustomClick(object sender, EventArgs e)
        {
            frmSelectCustomer frmSelectCustomer = new frmSelectCustomer(false, "colCompanyID");
            frmSelectCustomer.BringToFront();
            frmSelectCustomer.StartPosition = FormStartPosition.CenterScreen;
            DialogResult rst = frmSelectCustomer.ShowDialog();
            if (rst == DialogResult.OK)
            {
                List<CRM_CompanyResult> rstList = frmSelectCustomer.GetSelectList<CRM_CompanyResult>();
                if (rstList != null && rstList.Count > 0)
                {
                    txtCustomerID.Text = rstList[0].CompanyID.ToStringHasNull();
                    txtCustomerName.Text = rstList[0].CompanyName.ToStringHasNull() ;
                    txtAddress.Text = rstList[0].Address;
                    txtContact.Text = rstList[0].ContactName;
                    txtTelephone.Text = rstList[0].Telephone;
                    txtEmail.Text = rstList[0].Email;
                    txtFax.Text = rstList[0].Fax;
                    cboClearingForm.SelectedValue = rstList[0].ClearingForm;
                    txtClearFormDay.Text = rstList[0].ClearFormDay.ToStringHasNull();
                    txtDeliveryAddress.Text = rstList[0].DeliveryAddress;
                    //txtReceiveContact.Text=rstList[0]
                    //txtRecComName.Text=rstList[0]
                }

            }
        }

        private void txtCustomerName_ButtonCustom2Click(object sender, EventArgs e)
        {
            txtCustomerID.Text = string.Empty;
            txtCustomerName.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtClearFormDay.Text = string.Empty;
            txtFax.Text = string.Empty;
            txtContact.Text = string.Empty;
            txtTelephone.Text = string.Empty;
            txtEmail.Text = string.Empty;

        }
        private void txtContact_ButtonCustomClick(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCustomerID.Text))
            {
                frmSelectCustomerContact frmSelectCustomerContact = new frmSelectCustomerContact(false);
                frmSelectCustomerContact.CompanyID = txtCustomerID.Text.ToInt32();
                frmSelectCustomerContact.BringToFront();
                frmSelectCustomerContact.StartPosition = FormStartPosition.CenterScreen;
                DialogResult rst = frmSelectCustomerContact.ShowDialog();
                if (rst == DialogResult.OK)
                {
                    List<CRM_CompanyContactResult> rstList = frmSelectCustomerContact.GetSelectList<CRM_CompanyContactResult>();
                    if (rstList != null && rstList.Count > 0)
                    {
                        txtContact.Text = rstList[0].ContactName;
                        txtTelephone.Text = rstList[0].Telephone;
                        txtEmail.Text = rstList[0].Email;
                    }
                }
            }
            else
            {
                this.ShowMessage("请选择客户！");
            }
        }
        private void txtContact_ButtonCustom2Click(object sender, EventArgs e)
        {
            txtContact.Text = string.Empty;
            txtTelephone.Text = string.Empty;
            txtEmail.Text = string.Empty;
        }
        #endregion

        #region  文本值改变
        private void cboTaxRate_TextChanged(object sender, EventArgs e)
        {
            if (operFlag)
            {
                int calcType = 0;
                int qty = 0;
                decimal taxRate = 0.0m;
                decimal nTaxPrice = 0.0m;
                decimal unitPrice = 0.0m;
                calcType = chkCalcType.Checked ? 1 : 0;
                taxRate = cboTaxRate.SelectedValue.ToDecimal() / 100;
                foreach (DataGridViewRow row in dgvSalesOrderLine.Rows)
                {
                    if (calcType == 0)
                    {
                        qty = row.Cells["colQty"].Value.ToInt32();
                        nTaxPrice = row.Cells["colNTaxPrice"].Value.ToDecimal();
                        unitPrice = Math.Round((taxRate + 1) * nTaxPrice, 5, MidpointRounding.AwayFromZero);
                        row.Cells["colUnitPrice"].Value = unitPrice;
                        row.Cells["colAmount"].Value = qty * unitPrice;
                    }
                    else if (calcType == 1)
                    {
                        qty = row.Cells["colQty"].Value.ToInt32();
                        unitPrice = row.Cells["colUnitPrice"].Value.ToDecimal();
                        row.Cells["colNTaxPrice"].Value = Math.Round(unitPrice / (taxRate + 1), 5, MidpointRounding.AwayFromZero);
                        row.Cells["colAmount"].Value = qty * unitPrice;
                    }

                }
                CalcAmount();
            }
        }

       
        private void txtNeedRecAmtDate_TextChanged(object sender, EventArgs e)
        {
            if (operFlag)
            {
                foreach (DataGridViewRow row in dgvSalesOrderLine.Rows)
                {
                    if (!string.IsNullOrEmpty(txtNeedRecAmtDate.Text))
                        row.Cells["colNeedRecAmtDate"].Value = txtNeedRecAmtDate.Text;
                    else
                        row.Cells["colNeedRecAmtDate"].Value = null;

                }
            }
        }

        private void txtNeedDeliveryDate_TextChanged(object sender, EventArgs e)
        {
            if (operFlag)
            {
                foreach (DataGridViewRow row in dgvSalesOrderLine.Rows)
                {
                    if (!string.IsNullOrEmpty(txtNeedDeliveryDate.Text))
                        row.Cells["colNeedDeliveryDate"].Value = txtNeedDeliveryDate.Text;
                    else
                        row.Cells["colNeedDeliveryDate"].Value = null;

                }
            }
           
        }
       

        private void cboCurrency_TextChanged(object sender, EventArgs e)
        {
            
        }

      
        #endregion


        #region 预留,通知选项卡

        void BindSuperGridControl()
        {
           List<ORD_PurchaseNoticeResult> noticeList=  noticeLogic.GetList(new ORD_PurchaseNoticeParam() { SOGuid = soguid });
           if (noticeList != null)
           {
               usgNoticed.PrimaryGrid.DataSource = noticeList;
           }
           List<STK_StockReserveResult> reserveList = reserveLogic.GetList(new STK_StockReserveParam() { SourceBillGuid = soguid });
           if (reserveList != null)
           {
               usgReserve.PrimaryGrid.DataSource = reserveList;
           }
        
        }
        private void btnSearchNotice_Click(object sender, EventArgs e)
        {
            BindSuperGridControl();
        }

        #endregion

      
       

        

    }
}
