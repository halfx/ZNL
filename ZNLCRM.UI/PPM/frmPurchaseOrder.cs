using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZNLCRM.UI.Logic.Common;
using ZNLCRM.UI.Logic.HR;
using ZNLCRM.UI.Logic.Sys;
using ZNLCRM.UI.Logic.CRM;
using ZNLCRM.UI.Logic.PPM;
using ZNLCRM.Entity.UserModel.PPM;
using ZNLCRM.Entity.UserModel.HR;
using ZNLFrame.Entity;
using ZNLCRM.Entity.UserModel.Sys;
using ZNLCRM.Utility.CommonEnum;
using ZNLCRM.UI.SPM;
using ZNLCRM.Utility;
using ZNLCRM.Entity.UserModel.Common;
using ZNLCRM.Entity.UserModel.CRM;
using ZNLCRM.UI.HR;
using ZNLCRM.UI.CRM;
using ZNLCRM.Entity.UserModel.STK;
using ZNLCRM.Entity.UserModel.SPM;
using ZNLCRM.UI.Logic.SPM;
using ZNLCRM.Client.Entry;

namespace ZNLCRM.UI.PPM
{
    public partial class frmPurchaseOrder : frmBaseEditForm
    {
       public delegate void dlgRefreshParentForm();
        public event dlgRefreshParentForm RefreshParentForm;
        public delegate void dlgSaveAttach(string sourceTable, Guid sourceGuid, string sourceBillNo);
        public event dlgSaveAttach SaveAttach;
        public int? poid = 0;
        public Guid? poguid;
        public string sourcebillno = string.Empty;
        HR_OrgLogic orgLogic = null;
        SYS_DictItemLineLogic dictLineLogic = null;
        CRM_CompanyLogic companyLogic = null;
        ORD_PurchaseOrderLogic orderLogic=null;
        ORD_PurchaseOrderLineLogic orderLineLogic = null;
        ORD_PurchaseNoticeLogic noticeLogic = null;
        ORD_SalesOrderLineLogic salesOrderLineLogic = null;
        BindingSource bsOrderLine = new BindingSource();
        List<ORD_PurchaseOrderLineResult> tempList = new List<ORD_PurchaseOrderLineResult>();
        List<ORD_PurchaseOrderLineResult> delList = new List<ORD_PurchaseOrderLineResult>();
        List<ORD_PurchaseOrderLineResult> addOrModifyList = new List<ORD_PurchaseOrderLineResult>();
        bool operFlag = false;
        public frmPurchaseOrder()
        {
            InitializeComponent();
            this.GetEditEntity += new dlgGetEditEntity(Form_GetEditEntity);
            dictLineLogic = new SYS_DictItemLineLogic(this);
            orgLogic = new HR_OrgLogic(this);
            orderLogic = new ORD_PurchaseOrderLogic(this);
            orderLineLogic = new ORD_PurchaseOrderLineLogic(this);
            companyLogic = new CRM_CompanyLogic(this);
            noticeLogic = new ORD_PurchaseNoticeLogic(this);
            salesOrderLineLogic = new ORD_SalesOrderLineLogic(this);
        }

        #region 实现基类获取实体信息方法
        object Form_GetEditEntity()
        {
            ORD_PurchaseOrderResult info = new ORD_PurchaseOrderResult();
            info.POGuid = poguid;
            info = this.ConvertControlToEntity<ORD_PurchaseOrderResult>(this.stcpOrder.Controls, info, null);
            info = this.ConvertControlToEntity<ORD_PurchaseOrderResult>(this.stcpOther.Controls, info, null);
            info = this.ConvertControlToEntity<ORD_PurchaseOrderResult>(this.stcpConEntry.Controls, info, null);
            if (!chkIsInvoiced.Checked)
                info.InvoiceType = null;
            this.SetDataIsChanged<ORD_PurchaseOrderResult>(info);
            
            #region 明细列表
            bsOrderLine.EndEdit();
            tempList.Clear();
            foreach (ORD_PurchaseOrderLineResult rst in addOrModifyList)
            {
                if (rst.HasChanged())
                {
                    tempList.Add(rst);
                }
            }
            tempList.AddRange(delList);
            info.OrderLineList = tempList;
            if (tempList.Count > 0)
            {
                this.DataIsChanged = true;
            }
            #endregion
            return info;
        }
        #endregion

        #region 初始化绑定控件
        public void BindComboBox()
        {
            orgLogic.BindComboBox(cboPurOrgID, new HR_OrgParam { });
            List<SYS_DictItemLineResult> itemLineList = dictLineLogic.GetListByCode(new SYS_DictItemLineParam
            {
                ItemCodes = new string[] {
                "PurTransportCompany","FreightPaymentType" ,"ClearingForm","Currency","UnitCode","InvType","InvoiceType","TaxRate" }
            });
          
            dictLineLogic.BindComboBox(cboTransportCompany,"PurTransportCompany" ,itemLineList);
            dictLineLogic.BindComboBox(cboFreightClearForm,  "FreightPaymentType" , itemLineList);
            dictLineLogic.BindComboBox(cboClearingForm,  "ClearingForm" , itemLineList);
            dictLineLogic.BindComboBox(cboCurrency, "Currency" ,itemLineList);
            dictLineLogic.BindComboBox(cboInvoiceType, "InvoiceType" , itemLineList);
            dictLineLogic.BindComboBox(cboTaxRate, "TaxRate" , itemLineList);
            dictLineLogic.BindComboBox(cboInvType, "InvType", itemLineList);

            dictLineLogic.BindComboBox(colInvType, "InvType" , itemLineList);
            dictLineLogic.BindComboBox(colUnit, "UnitCode", itemLineList);
            
        }
        #endregion

        #region 初始化加载数据
        private void InitData()
        {
            if (poguid != null)
            {
                ORD_PurchaseOrderResult info = orderLogic.GetInfo(new ORD_PurchaseOrderParam { POGuid = poguid });
                this.ConvertEntityToControl<ORD_PurchaseOrderResult>(this.stcpOrder.Controls, info, null);
                this.ConvertEntityToControl<ORD_PurchaseOrderResult>(this.stcpOther.Controls, info, null);
                this.ConvertEntityToControl<ORD_PurchaseOrderResult>(this.stcpConEntry.Controls, info, null);
                if (info != null)
                {
                    txtPurDeptName.Text = info.HR_DepartmentResult == null ? "" : info.HR_DepartmentResult.DeptName;
                    decimal taxAmount = Math.Round(info.TaxAmount.ToDecimal(), 3, MidpointRounding.AwayFromZero);
                    decimal totalAmount = Math.Round(info.Amount.ToDecimal(), 3, MidpointRounding.AwayFromZero);
                    txtAmount.Text = totalAmount.ToStringHasNull();
                    txtTaxAmount.Text = taxAmount.ToStringHasNull();
                    if (info.OrderLineList != null) addOrModifyList = info.OrderLineList;
                }
                this.CheckIsReadOnly<ORD_PurchaseOrderResult>(info);
                this.CheckAuditStatus<ORD_PurchaseOrderResult>(info, this.stcpOrder,this.panDtlOpr, this.stcpOther, this.stcpAttachFiles, this.stcpConEntry, this.stcpLine);
                this.EditBeforeData = info;
            }
            else
            {
                cboInvType.SelectedValue = "备货库存";
                string date = DateTime.Now.Date.ToStringHasNull();
                txtPODate.Text = date;
                txtNeedDeliveryDate.Text = date;
                txtNeedPayAmtDate.Text = date;

                this.txtPurDeptName.Text = MySession.DeptName;
                this.txtPurDeptID.Text = MySession.DeptID.ToStringHasNull();
                this.txtBuyerName.Text = MySession.UserName;
                this.txtBuyerID.Text = MySession.UserID.ToStringHasNull();
                
                SYS_DictItemLineLogic.SetCombolSelectedIndex(this.cboPurOrgID, MySession.OrgID, true);
            }
            bsOrderLine.DataSource = addOrModifyList;
            dgvPurchaseOrderLine.DataSource = bsOrderLine;
            
            CheckAuditButton("ORD_PurchaseOrder", poguid, this.tsbSubmit, null, this.tsbAudit, this.tsbUnDo);
            if (this.txtIsCancel.Text.Trim().ToLower() == "true")
            {
                this.lblSignFlag.SetFlag(ZNLCRM.Controls.UcSignature.SignFlag.CancelBill);
                this.tsbCancelBill.Visible = false;
                this.tsbTakeCancel.Visible = true;
            }
            else
            {
                this.lblSignFlag.SetFlag(ZNLCRM.Controls.UcSignature.SignFlag.None);
                this.tsbCancelBill.Visible = true;
                this.tsbTakeCancel.Visible = false;
            }
            this.DataIsChanged = false;
        }
        #endregion

        #region 窗体加载
        private void frmPurchaseOrder_Load(object sender, EventArgs e)
        {
            colModel.ButtonCustomClick += new EventHandler<EventArgs>(editControl_ButtonCustomClick);
            colModel.ButtonClearClick += new EventHandler<CancelEventArgs>(editControl_ButtonClearClick);
            frmSysAttachFiles frm=new frmSysAttachFiles ();
            frm.SourceGuid = poguid;
            frm.TopLevel = false;
            //frm.Tag = newItem; //存放选项卡对象，方便后续在事件里关闭选项卡
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            stcpAttachFiles.Controls.Add(frm);
            frm.Show();
            BindComboBox();
            InitData();
            this.SaveAttach += new dlgSaveAttach(frm.SaveAttach);
            operFlag = true;
        }
        #endregion

        #region 保存采购单
        private void tsbSave_Click(object sender, EventArgs e)
        {
            SaveData(true);
        }
        private bool SaveData(bool isAsyncExecute)
        {
            bool ret = false;
            ORD_PurchaseOrderResult info = Form_GetEditEntity() as ORD_PurchaseOrderResult;
            if (isAsyncExecute && !this.DataIsChanged)
            {
                this.ShowNoChangedMsg();
                return ret;
            }
            #region 异步执行保存操作
            if (isAsyncExecute)
            {
                WCFAddUpdateResult result = this.AsyncExecute<WCFAddUpdateResult, ORD_PurchaseOrderResult>(info, orderLogic.AddOrUpdate, (a) =>
                {
                    if (a.KeyGuid.ToGuid() != Guid.Empty)
                    {
                        poid = a.Key;
                        poguid = a.KeyGuid.ToGuid();
                        sourcebillno = a.BillNo;
                        CRM_CompanyResult companyResult = companyLogic.GetCustInfo(new CRM_CompanyParam() { CompanyID = txtSupplierID.Text.ToInt32() });
                        if (companyResult != null)
                        {
                            companyResult.LastBusinessDate = txtPODate.Text.ToDateTime();
                            companyLogic.AddOrUpdateSup(companyResult);
                        }
                        if (SaveAttach != null)
                            SaveAttach("ORD_PurchaseOrder", poguid.ToGuid(), sourcebillno);
                        InitData();
                        delList.Clear();
                    }
                });
            }
            #endregion
            #region 同步执行保存操作
            else
            {
                WCFAddUpdateResult result = orderLogic.AddOrUpdate(info);
                if (result.KeyGuid.ToGuid() != Guid.Empty)
                {
                    ret = true;
                }
            }
            #endregion
            return ret;
        }
        #endregion
        
        #region 添加采购单明细
        private void btnAddRow_Click(object sender, EventArgs e)
        {
            
            bsOrderLine.AddNew();
            ORD_PurchaseOrderLineResult rst = bsOrderLine.Current as ORD_PurchaseOrderLineResult;
            InitNewData(rst);
        }

        private void btnInsertBefore_Click(object sender, EventArgs e)
        {
            if (dgvPurchaseOrderLine.CurrentCell == null)
            {
                btnAddRow_Click(null, null);
                return;
            }
            ORD_PurchaseOrderLineResult rst =new  ORD_PurchaseOrderLineResult();
            InitNewData(rst);
            bsOrderLine.Insert(dgvPurchaseOrderLine.CurrentRow.Index, rst);
        }

        void InitNewData(ORD_PurchaseOrderLineResult rst)
        {
            rst.Unit = "PCS";
            rst.InvType = cboInvType.SelectedValue.ToStringHasNull();
            rst.NeedDeliveryDate = string.IsNullOrEmpty(txtNeedDeliveryDate.Text) ? null : (DateTime?)txtNeedDeliveryDate.Value;
            rst.NeedPayAmtDate = string.IsNullOrEmpty(txtNeedPayAmtDate.Text) ? null : (DateTime?)txtNeedPayAmtDate.Value;
        }

        #endregion

        #region 删除采购单明细
        private void btnDelRow_Click(object sender, EventArgs e)
        {
            if (this.bsOrderLine.Current != null)
            {

                Guid? poLineGuid = null;
                ORD_PurchaseOrderLineResult delResult = this.bsOrderLine.Current as ORD_PurchaseOrderLineResult;
                poLineGuid = delResult.POLineGuid;
                if (poLineGuid != null)
                {
                    delResult.IsDeleted = true;
                    delList.Add(delResult);
                }
                bsOrderLine.RemoveCurrent(); 
            }
        }
        #endregion

        #region  计算汇总
        private void CalcAmount()
        {
            decimal totalAmount = 0.0m;
            decimal taxAmount = 0.0m;
            decimal taxRate = 0.0m;
            taxRate = cboTaxRate.SelectedValue.ToDecimal() / 100;
            foreach (DataGridViewRow row in dgvPurchaseOrderLine.Rows)
            {
                bool cancelFlag = row.Cells["colIsCancel"].Value.ToBooleanHasNull();
                if (!cancelFlag)
                {
                    totalAmount += row.Cells["colAmount"].Value.ToDecimal();
                }


            }
            totalAmount = Math.Round(totalAmount, 3, MidpointRounding.AwayFromZero);
            taxAmount = Math.Round(totalAmount * taxRate, 3, MidpointRounding.AwayFromZero);

            txtAmount.Text = totalAmount.ToStringHasNull();
            txtTaxAmount.Text = taxAmount.ToStringHasNull();


        }
        #endregion

        #region 税率改变
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
                foreach (DataGridViewRow row in dgvPurchaseOrderLine.Rows)
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
        #endregion

        #region 库存类型改变
        private void cboInvType_TextChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvPurchaseOrderLine.Rows)
            {
                if(row.Cells["colNoticeGuid"].Value.ToGuid()==Guid.Empty)//没有关联的随主单的库存类型一起变化
                  row.Cells["colInvType"].Value = cboInvType.SelectedValue;
            }
        }
        #endregion

        #region 表格事件
        #region  单元格文本值改变
        private void dgvPurchaseOrderLine_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            #region 计算含税价与非含税价
            int qty = 0;
            decimal taxRate = 0.0m;
            decimal nTaxPrice = 0.0m;
            decimal unitPrice = 0.0m;
            int calcType = 0;
            calcType = chkCalcType.Checked ? 1 : 0;
            taxRate = cboTaxRate.SelectedValue.ToDecimal() / 100;
            #endregion
            //dgvPurchaseOrderLine.CellValueChanged -= new DataGridViewCellEventHandler(dgvPurchaseOrderLine_CellValueChanged);
            try
            {
                string columnName = dgvPurchaseOrderLine.Columns[e.ColumnIndex].Name;
                #region 数量修改了,重新计算金额
                if (columnName == "colQty")
                {
                    qty = dgvPurchaseOrderLine["colQty", e.RowIndex].Value.ToInt32();
                    nTaxPrice = dgvPurchaseOrderLine["colNTaxPrice", e.RowIndex].Value.ToDecimal();
                    unitPrice = dgvPurchaseOrderLine["colUnitPrice", e.RowIndex].Value.ToDecimal();
                    dgvPurchaseOrderLine["colAmount", e.RowIndex].Value = qty * unitPrice;
                }
                #endregion
                #region 不含税价
                else if (columnName == "colNTaxPrice")
                {
                    if (calcType == 0)
                    {
                        qty = dgvPurchaseOrderLine["colQty", e.RowIndex].Value.ToInt32();
                        nTaxPrice = dgvPurchaseOrderLine["colNTaxPrice", e.RowIndex].Value.ToDecimal();
                        unitPrice = Math.Round((taxRate + 1) * nTaxPrice, 5, MidpointRounding.AwayFromZero);
                        dgvPurchaseOrderLine["colUnitPrice", e.RowIndex].Value = unitPrice;
                        dgvPurchaseOrderLine["colAmount", e.RowIndex].Value = Math.Round( qty * unitPrice,3,MidpointRounding.AwayFromZero);
                    }
                }
                #endregion
                #region 含税单价
                else if (columnName == "colUnitPrice")
                {
                    qty = dgvPurchaseOrderLine["colQty", e.RowIndex].Value.ToInt32();
                    unitPrice = dgvPurchaseOrderLine["colUnitPrice", e.RowIndex].Value.ToDecimal();
                    if (calcType == 1)
                    {
                        dgvPurchaseOrderLine["colNTaxPrice", e.RowIndex].Value = Math.Round(unitPrice / (taxRate + 1), 5, MidpointRounding.AwayFromZero);
                    }
                    dgvPurchaseOrderLine["colAmount", e.RowIndex].Value = Math.Round(qty * unitPrice, 3, MidpointRounding.AwayFromZero);
                }
                #endregion
                #region 型号
                else if (columnName == "colModel")
                {
                    this.GetLastHistoryPrice("model");
                }
                #endregion
                #region 品牌
                else if (columnName == "colBrand")
                {
                    this.GetLastHistoryPrice("brand");
                }
                #endregion
                bsOrderLine.EndEdit();
                CalcAmount();
            }
            finally
            {
                //dgvPurchaseOrderLine.CellValueChanged += new DataGridViewCellEventHandler(dgvPurchaseOrderLine_CellValueChanged);
            }
        }
        #endregion

        #region 表格数据绑定完成
        private void dgvPurchaseOrderLine_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {

            foreach (DataGridViewRow row in dgvPurchaseOrderLine.Rows)
            {
                if (row.Cells["colIsCancel"].Value.ToBooleanHasNull())
                {
                    foreach (DataGridViewColumn column in dgvPurchaseOrderLine.Columns)
                    {
                        if (column.Name != "colIsCancel")
                        {
                            row.Cells[column.Name].Style.ForeColor = Color.Red;
                            row.Cells[column.Name].ReadOnly = true;
                        }
                    }
                }
                else
                {
                    foreach (DataGridViewColumn column in dgvPurchaseOrderLine.Columns)
                    {
                        if (column.Name != "colIsCancel" )
                        {
                            row.Cells[column.Name].Style.ForeColor = Color.Black;
                        }
                    }
                }
                if (row.Cells["colNoticeGuid"].Value.ToGuid() != Guid.Empty)
                {
                    row.Cells["colInvType"].ReadOnly = true;
                }
            }
        }
        #endregion

        #region 单元格内容转换
        private void dgvPurchaseOrderLine_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
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
                }
            }
        }
        #endregion
        #endregion

        #region 供应商选择
        private void txtSupplierName_ButtonCustomClick(object sender, EventArgs e)
        {
            frmSelectSupplier frmSelectCustomer = new frmSelectSupplier(false, "colCompanyID");
            frmSelectCustomer.BringToFront();
            frmSelectCustomer.StartPosition = FormStartPosition.CenterScreen;
            DialogResult rst = frmSelectCustomer.ShowDialog();
            if (rst == DialogResult.OK)
            {
                List<CRM_CompanyResult> rstList = frmSelectCustomer.GetSelectList<CRM_CompanyResult>();
                if (rstList != null && rstList.Count > 0)
                {
                    txtSupplierID.Text = rstList[0].CompanyID.ToStringHasNull(); ;
                    txtSupplierName.Text = rstList[0].CompanyName;
                    txtTelephone.Text = rstList[0].Telephone;
                    txtContact.Text = rstList[0].ContactName;
                    txtAddress.Text = rstList[0].Address;
                    cboClearingForm.SelectedValue = rstList[0].ClearingForm;
                    txtClearFormDay.Text = rstList[0].ClearFormDay.ToStringHasNull();
                    
                }

            }
        }

        #endregion

        #region  供应商清除
        private void txtSupplierName_ButtonCustom2Click(object sender, EventArgs e)
        {
            txtSupplierID.Text = string.Empty;
            txtSupplierName.Text = string.Empty;
            txtContact.Text = string.Empty;
            txtTelephone.Text = string.Empty;
            txtAddress.Text = string.Empty;
            cboClearingForm.SelectedValue = "";
            txtClearFormDay.Text = string.Empty;
        }
        #endregion

        #region 联系人选择
        private void txtContact_ButtonCustomClick(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSupplierID.Text))
            {
                frmSelectCustomerContact frmSelectCustomerContact = new frmSelectCustomerContact(false);
                frmSelectCustomerContact.CompanyID = txtSupplierID.Text.ToInt32();
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
                    }
                }
            }
            else
            {
                this.ShowMessage("请先选择供应商！");
            }
        }
        #endregion

        #region 联系人清除
        private void txtContact_ButtonCustom2Click(object sender, EventArgs e)
        {
            txtContact.Text = string.Empty;
            txtTelephone.Text = string.Empty;
        }
        #endregion

        #region 部门选择
        private void txtPurDeptName_ButtonCustomClick(object sender, EventArgs e)
        {
            frmSelectDepartment frmSelectDepartment = new frmSelectDepartment(false);
            frmSelectDepartment.deptIds = txtPurDeptID.Text.Split(',').Select(a => (int?)a.ToInt32()).ToArray();
            frmSelectDepartment.OrgID = cboPurOrgID.SelectedValue.ToInt32();

            DialogResult rst = frmSelectDepartment.ShowDialog();
            if (rst == DialogResult.OK)
            {
                List<HR_DepartmentResult> rstList = frmSelectDepartment.GetSelectList<HR_DepartmentResult>();
                if (rstList != null && rstList.Count > 0)
                {
                    
                        txtPurDeptID.Text = rstList[0].DeptID.ToStringHasNull();
                        txtPurDeptName.Text = rstList[0].DeptName.ToStringHasNull();
                    

                }
            }
        }
        #endregion

        #region 部门清除
        private void txtPurDeptName_ButtonCustom2Click(object sender, EventArgs e)
        {
            txtPurDeptID.Text = string.Empty;
            txtPurDeptName.Text = string.Empty;
        }
        #endregion

        #region 采购员选择
        private void txtBuyerName_ButtonCustomClick(object sender, EventArgs e)
        {
             frmSelectEmp frmSelectEmp = new frmSelectEmp(false);
             frmSelectEmp.empIds = txtBuyerID.Text.Split(',').Select(a => (int?)a.ToInt32()).ToArray();
             frmSelectEmp.OrgID = cboPurOrgID.SelectedValue.ToInt32();
             frmSelectEmp.DeptID = txtPurDeptID.Text.ToInt32();
            DialogResult rst = frmSelectEmp.ShowDialog();
            if (rst == DialogResult.OK)
            {
                List<HR_EmployeeResult> rstList = frmSelectEmp.GetSelectList<HR_EmployeeResult>();
                if (rstList != null && rstList.Count > 0)
                {
                    txtBuyerID.Text = rstList[0].EmpID.ToStringHasNull() ;
                    txtBuyerName.Text =rstList[0].EmpName;
                    
                }
            }
        }
        #endregion

        #region 采购员清除
        private void txtBuyerName_ButtonCustom2Click(object sender, EventArgs e)
        {
            txtBuyerID.Text = string.Empty;
            txtBuyerName.Text = string.Empty;
        }
        #endregion

        #region  需到货日期选择改变
        private void txtNeedDeliveryDate_ValueChanged(object sender, EventArgs e)
        {
            if (operFlag)
            {
                foreach (DataGridViewRow row in dgvPurchaseOrderLine.Rows)
                {
                    row.Cells["colNeedDeliveryDate"].Value = txtNeedDeliveryDate.Value;
                }
            }
        }
        #endregion

        #region 需付款日期选择改变
        private void txtNeedPayAmtDate_ValueChanged(object sender, EventArgs e)
        {
            if (operFlag)
            {
                foreach (DataGridViewRow row in dgvPurchaseOrderLine.Rows)
                {
                    row.Cells["colNeedPayAmtDate"].Value = txtNeedPayAmtDate.Value;
                }
            }
        }
        #endregion


        #region 列编辑控件双击弹窗
        private void editControl_ButtonCustomClick(object sender, EventArgs e)
        {
            
            #region  从库存中选择

            #endregion 


        }
        #endregion

        #region 列编辑控件双击清除
        private void editControl_ButtonClearClick(object sender, EventArgs e)
        {

            DataGridViewRow row = dgvPurchaseOrderLine.CurrentRow;
            
            if (row != null)
            {
                if (MessageBox.Show("请确认是否清除当前行相关数据？包括【型号、品牌、批号、封装、品质、包装】", "操作提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    row.Cells["colModel"].Value = null;
                    row.Cells["colBrand"].Value = null;
                    row.Cells["colBatch"].Value = null;
                    row.Cells["colPackage"].Value = null;
                    row.Cells["colQuality"].Value = null;
                    row.Cells["colMPQ"].Value = null;
                }
                else
                {
                    return;
                }

            }
        }
        #endregion

        #region 从采购通知导入
        private void btnImportByNotice_Click(object sender, EventArgs e)
        {
            ImportByNotice(true);
        }

        #region 导入明细
        private void ImportByNotice(bool isMutiSelect)
        {

            ImportByNoticeList(isMutiSelect);

        }
        #endregion

        #region 给采购明细对象赋值
        public void SetOrderLineObjectValue(ORD_PurchaseOrderLineResult purLineRst, ORD_PurchaseNoticeResult noticeResult)
        {

            purLineRst.SOGuid = noticeResult.SOGuid;
            purLineRst.SOBillNo = noticeResult.SOBillNo;
            purLineRst.SOLineGuid = noticeResult.SOLineGuid;
            purLineRst.SOLineCode = noticeResult.SOLineCode;
            purLineRst.SOModel = noticeResult.Model;
            purLineRst.SOBrand = noticeResult.Brand;
            purLineRst.SOBatch = noticeResult.Batch;
            purLineRst.SOPackage = noticeResult.Package;
            purLineRst.SOQty = noticeResult.SaleQty;
            purLineRst.SONeedDeliveryDate = noticeResult.NeedDeliveryDate;
            purLineRst.NoticeGuid = noticeResult.NoticeGuid;
            purLineRst.Model = noticeResult.Model;
            purLineRst.Brand = noticeResult.Brand;
            purLineRst.Package = noticeResult.Package;
            purLineRst.Batch = noticeResult.Batch;
            purLineRst.InvType = string.IsNullOrEmpty(noticeResult.InvType) ? "补货库存" : noticeResult.InvType;
            purLineRst.Unit = noticeResult.Unit;
            purLineRst.Qty = noticeResult.NoticeQty.ToInt32() - noticeResult.PurchaseQty.ToInt32();
            purLineRst.Amount = purLineRst.UnitPrice * purLineRst.Qty;
            purLineRst.NeedDeliveryDate = string.IsNullOrEmpty(txtNeedDeliveryDate.Text) ? null : (DateTime?)txtNeedDeliveryDate.Value;
            purLineRst.NeedPayAmtDate = string.IsNullOrEmpty(txtNeedPayAmtDate.Text) ? null : (DateTime?)txtNeedPayAmtDate.Value;
        }
        #endregion

        private void ImportByNoticeList(bool isMutiSelect)
        {
            if (!string.IsNullOrEmpty(txtBuyerName.Text))
            {
                frmSelectForPurchaseList frm = new frmSelectForPurchaseList(isMutiSelect);
                frm.BuyerID = txtBuyerID.Text.ToInt32();
                Guid? noticeGuid = Guid.Empty;
                string model = string.Empty;
                if (!isMutiSelect)//单选时
                {
                    model = dgvPurchaseOrderLine.CurrentRow.Cells["colModel"].Value.ToStringHasNull();
                    noticeGuid = dgvPurchaseOrderLine.CurrentRow.Cells["colNoticeGuid"].Value.ToGuid();
                }

                if (!string.IsNullOrEmpty(model))
                    frm.Model = model;
                if (noticeGuid != Guid.Empty)//如果已经存在关联的源单据明细，则只筛选此条明细
                    frm.NoticeGuid = noticeGuid;
                else//如果是新行，则排除掉已经存在列表里面的所有的源单据明细
                {
                    Guid?[] noNoticeGuids = addOrModifyList.Where(a=>a.NoticeGuid.ToGuid()!=Guid.Empty).Select(a => a.NoticeGuid).Distinct().ToArray();
                    frm.NoNoticeGuids = noNoticeGuids;
                }
                frm.BringToFront();
                frm.StartPosition = FormStartPosition.CenterScreen;
                DialogResult rst = frm.ShowDialog();
                if (rst == DialogResult.OK)
                {
                    List<ORD_PurchaseNoticeResult> rstList = frm.GetSelectList<ORD_PurchaseNoticeResult>();
                    if (rstList != null && rstList.Count > 0)
                    {
                        foreach (ORD_PurchaseNoticeResult noticeResult in rstList)
                        {
                            bool isAddNew = true;
                            foreach (DataGridViewRow row in dgvPurchaseOrderLine.Rows)
                            {
                                //如果是已经存在的行，则利用现成的行进行编辑

                                if (row.Cells["colNoticeGuid"].Value.ToGuid() == noticeResult.NoticeGuid)
                                {
                                    isAddNew = false;

                                    ORD_PurchaseOrderLineResult orderLineResult = bsOrderLine[row.Index] as ORD_PurchaseOrderLineResult;
                                    SetOrderLineObjectValue(orderLineResult, noticeResult);
                                    break;
                                }
                            }
                            if (isAddNew)
                            {
                                if (!isMutiSelect)//单选
                                {
                                    ORD_PurchaseOrderLineResult orderLineResult = bsOrderLine.Current as ORD_PurchaseOrderLineResult;
                                    SetOrderLineObjectValue(orderLineResult, noticeResult);
                                }
                                else//多选
                                {
                                    ORD_PurchaseOrderLineResult orderLineResult = new ORD_PurchaseOrderLineResult();
                                    SetOrderLineObjectValue(orderLineResult, noticeResult);
                                    bsOrderLine.Add(orderLineResult);
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("请先选择采购员！");
            }
        }
        #endregion

        #region 从库存导入
        private void btnImportByStock_Click(object sender, EventArgs e)
        {

        }
        #endregion
       
        #region 从采购记录导入
        private void btnImportByHistory_Click(object sender, EventArgs e)
        {

        }

        #endregion 

        #region 审核相关方法
        #region  提交
        private void tsbSubmit_Click(object sender, EventArgs e)
        {
            //tsbSave_Click(sender, e);
            //bool flag=  orderLogic.SubmitPurchaseOrderBill(new ORD_PurchaseOrderParam() { POGuid = poguid });
            //if (flag)
            //{
            //    InitData();
            //}
            ORD_PurchaseOrderResult info = Form_GetEditEntity() as ORD_PurchaseOrderResult;
            this.WF_SubmitBill("ORD_PurchaseOrder", info, info.BillNo, info.POGuid, this.DataIsChanged, delegate() { return (SaveData(false)); }, InitData);

        }
        #endregion
        #region 审核通过
        private void tsbAudit_Click(object sender, EventArgs e)
        {
            // //tsbSave_Click(sender, e);
            //bool flag=  orderLogic.AuditPurchaseOrderBill(new ORD_PurchaseOrderParam() { POGuid = poguid });
            //if (flag)
            //{
            //    InitData();
            //}
            ORD_PurchaseOrderResult info = Form_GetEditEntity() as ORD_PurchaseOrderResult;
            this.WF_CheckBill("ORD_PurchaseOrder", info.BillNo, info.POGuid, this.DataIsChanged, delegate() { return (SaveData(false)); }, InitData);
        }
        #endregion
        #region 撤消单据
        private void tsbUnDo_Click(object sender, EventArgs e)
        {
            ORD_PurchaseOrderResult info = Form_GetEditEntity() as ORD_PurchaseOrderResult;
            this.WF_CancelCheckBill("ORD_PurchaseOrder", info.POGuid, InitData);
        }
        #endregion

        #endregion
        
        #region 取消和收取消单据相关方法
        private void tsbCancelBill_Click(object sender, EventArgs e)
        {
            UpdateCancelFlag(true);
        }
        private void tsbTakeCancel_Click(object sender, EventArgs e)
        {
            UpdateCancelFlag(false);
        }
        private void UpdateCancelFlag(bool isCancel)
        {
            ORD_PurchaseOrderLogic logic = new ORD_PurchaseOrderLogic(this);
            if (poguid == null)
            {
                this.ShowMessage("请先保存新增的数据！");
                return;
            }
            if (isCancel)
            {
                if (MessageBox.Show("是否真的取消当前单据？", "操作提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
            }
            else
            {
                if (MessageBox.Show("是否真的恢复当前单据？", "操作提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
            }
            ORD_PurchaseOrderResult param = new ORD_PurchaseOrderResult();
            param.POGuid = poguid;
            param.IsCancel = isCancel;
            WCFAddUpdateResult rst = logic.UpdateCancelFlag(param);
            if (rst.Key > 0)
            {
                InitData();
            }
        }
        #endregion
        #region 获取历史单据
        private void GetLastHistoryPrice(string oprType)
        {
            string supplierName = "";
            int supplierID = 0;
            List<string> modelList = new List<string>();
            List<string> brandList = new List<string>();
            #region 供应商名称
            supplierID = this.txtSupplierID.Text.ToInt32();
            supplierName = this.txtSupplierName.Text;
            if (supplierName.Trim() == "" || supplierID <= 0)
            {
                return;
            }
            #endregion
            #region 更改了供应商
            if (oprType == "supplier")
            {
                foreach (DataGridViewRow row in this.dgvPurchaseOrderLine.Rows)
                {
                    if (row.Cells["colModel"].Value.ToStringHasNull().Trim() == "") continue;
                    if (row.Cells["colNTaxPrice"].Tag.ToDecimal() != row.Cells["colNTaxPrice"].Value.ToDecimal()
                        && row.Cells["colUnitPrice"].Tag.ToDecimal() != row.Cells["colUnitPrice"].Value.ToDecimal()) continue;
                    modelList.Add(row.Cells["colModel"].Value.ToStringHasNull());
                    if (row.Cells["colBrand"].Value.ToStringHasNull().Trim() != "" && !brandList.Contains(row.Cells["colBrand"].Value.ToStringHasNull().Trim()))
                    {
                        brandList.Add(row.Cells["colBrand"].Value.ToStringHasNull());
                    }
                }
            }
            #endregion
            #region 更改了型号和品牌
            else if ((oprType == "model" || oprType == "brand") && this.dgvPurchaseOrderLine.CurrentCell != null)
            {
                DataGridViewRow row = this.dgvPurchaseOrderLine.Rows[this.dgvPurchaseOrderLine.CurrentCell.RowIndex];
                if (row.Cells["colModel"].Value.ToStringHasNull().Trim() != ""
                        && (row.Cells["colNTaxPrice"].Tag.ToDecimal() == row.Cells["colNTaxPrice"].Value.ToDecimal()
                        || row.Cells["colUnitPrice"].Tag.ToDecimal() == row.Cells["colUnitPrice"].Value.ToDecimal()))
                {
                    modelList.Add(row.Cells["colModel"].Value.ToStringHasNull());
                    if (row.Cells["colBrand"].Value.ToStringHasNull().Trim() != ""
                        && !brandList.Contains(row.Cells["colBrand"].Value.ToStringHasNull().Trim()))
                    {
                        brandList.Add(row.Cells["colBrand"].Value.ToStringHasNull());
                    }
                }
            }
            #endregion
            #region 获取历史单价
            if (modelList.Count <= 0) return;
            ORD_PurchaseOrderLogic logic = new ORD_PurchaseOrderLogic(this);
            ORD_PurchaseOrderParam param = new ORD_PurchaseOrderParam();
            param.SupplierID = supplierID;
            param.ModelList = modelList.ToArray();
            param.BrandList = brandList.ToArray();
            List<ORD_PurchaseOrderLineResult> rst = logic.GetLastHisstoryPrice(param);
            #endregion
            string model = "", brand = "";
            ORD_PurchaseOrderLineResult findInfo = new ORD_PurchaseOrderLineResult();
            #region 更改了供应商
            if (oprType == "supplier")
            {
                foreach (DataGridViewRow row in this.dgvPurchaseOrderLine.Rows)
                {
                    if (row.Cells["colModel"].Value.ToStringHasNull().Trim() == "") continue;
                    if (row.Cells["colNTaxPrice"].Tag.ToDecimal() != row.Cells["colNTaxPrice"].Value.ToDecimal()
                        && row.Cells["colUnitPrice"].Tag.ToDecimal() != row.Cells["colUnitPrice"].Value.ToDecimal()) continue;
                    model = row.Cells["colModel"].Value.ToStringHasNull().ToLower();
                    brand = row.Cells["colBrand"].Value.ToStringHasNull().ToLower();
                    if (brand.ToStringHasNull().Trim() == "")
                        findInfo = rst.Find(a => a.Model.ToLower() == model);
                    else
                        findInfo = rst.Find(a => a.Model.ToLower() == model && a.Brand.ToStringHasNull().ToLower() == brand);
                    if (findInfo != null)
                    {
                        row.Cells["colUnitPrice"].Value = findInfo.UnitPrice;
                        row.Cells["colNTaxPrice"].Value = findInfo.NTaxPrice;
                        row.Cells["colUnitPrice"].Tag = findInfo.UnitPrice;
                        row.Cells["colNTaxPrice"].Tag = findInfo.NTaxPrice;
                    }
                    else
                    {
                        row.Cells["colUnitPrice"].Value = "";
                        row.Cells["colNTaxPrice"].Value = "";
                        row.Cells["colUnitPrice"].Tag = null;
                        row.Cells["colNTaxPrice"].Tag = null;
                    }
                }
            }
            #endregion
            #region 更改了型号和品牌
            else if ((oprType == "model" || oprType == "brand") && this.dgvPurchaseOrderLine.CurrentCell != null)
            {
                DataGridViewRow row = this.dgvPurchaseOrderLine.Rows[this.dgvPurchaseOrderLine.CurrentCell.RowIndex];
                if (row.Cells["colModel"].Value.ToStringHasNull().Trim() == "") return;
                if (row.Cells["colNTaxPrice"].Tag.ToDecimal() != row.Cells["colNTaxPrice"].Value.ToDecimal()
                    && row.Cells["colUnitPrice"].Tag.ToDecimal() != row.Cells["colUnitPrice"].Value.ToDecimal()) return;
                model = row.Cells["colModel"].Value.ToStringHasNull().ToLower();
                brand = row.Cells["colBrand"].Value.ToStringHasNull().ToLower();
                if (brand.ToStringHasNull().Trim() == "")
                    findInfo = rst.Find(a => a.Model.ToLower() == model);
                else
                    findInfo = rst.Find(a => a.Model.ToLower() == model && a.Brand.ToStringHasNull().ToLower() == brand);
                if (findInfo != null)
                {
                    row.Cells["colUnitPrice"].Value = findInfo.UnitPrice;
                    row.Cells["colNTaxPrice"].Value = findInfo.NTaxPrice;
                    row.Cells["colUnitPrice"].Tag = findInfo.UnitPrice;
                    row.Cells["colNTaxPrice"].Tag = findInfo.NTaxPrice;
                }
                else
                {
                    row.Cells["colUnitPrice"].Value = "";
                    row.Cells["colNTaxPrice"].Value = "";
                    row.Cells["colUnitPrice"].Tag = null;
                    row.Cells["colNTaxPrice"].Tag = null;
                }
            }
            #endregion
        }
        private void txtSupplierName_TextChanged(object sender, EventArgs e)
        {
            GetLastHistoryPrice("supplier");
        }
        #endregion
        private void tsbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
