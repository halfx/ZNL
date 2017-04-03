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
using ZNLCRM.UI.Logic.STK;
using ZNLCRM.Entity.UserModel.STK;
using ZNLCRM.Entity.UserModel.HR;
using ZNLCRM.Entity.UserModel.Sys;
using ZNLFrame.Entity;
using ZNLCRM.Utility.CommonEnum;
using ZNLCRM.UI.SPM;
using ZNLCRM.UI.HR;
using ZNLCRM.Utility;
using ZNLCRM.UI.PPM;
using ZNLCRM.Entity.DBModel;
using ZNLCRM.Entity.UserModel.PPM;
using ZNLCRM.Controls;
using DevComponents.DotNetBar.Controls;
using System.Reflection;
using ZNLCRM.Entity.UserModel.Common;
using ZNLCRM.Entity.UserModel.CRM;
using ZNLCRM.Client.Entry;
using ZNLCRM.Entity.UserModel.SPM;
using ZNLCRM.UI.Logic.SPM;


namespace ZNLCRM.UI.STK
{
    public partial class frmStkIn : frmBaseEditForm
    {
       
        public delegate void dlgRefreshParentForm();
        public event dlgRefreshParentForm RefreshParentForm;
        public delegate void dlgSaveAttach(string sourceTable, Guid sourceGuid, string sourceBillNo);
        public event dlgSaveAttach SaveAttach;

        bool operFlag = false;
        public Guid? StkInGuid;
        public Guid? SourceBillGuid
        {
            get { return _sourceBillGuid; }
            set { _sourceBillGuid = value; }
        }
        Guid? _sourceBillGuid = null;
        public string SourceBillNo = string.Empty;
        public string BillType = string.Empty;
        STK_InLogic stkInLogic = null;
        STK_InLineLogic stkInLineLogic = null;
        STK_StockLogic stkStockLogic = null;
        STK_StockSheetLogic stkStockSheetLogic = null;
        HR_OrgLogic orgLogic = null;
        SYS_DictItemLineLogic dictLineLogic = null;
        CRM_CompanyLogic companyLogic = null;
        ORD_PurchaseOrderLogic purOrderLogic = null;
        ORD_PurchaseOrderLineLogic purLineLogic = null;
        ORD_SalesReturnLogic returnLogic = null;
        ORD_SalesReturnLineLogic returnLineLogic=null;
        SYS_CurrencyLogic currencyLogic = null;
        BindingSource bsStkInLine = new BindingSource();
        List<STK_InLineResult> tempList = new List<STK_InLineResult>();
        List<STK_InLineResult> delList = new List<STK_InLineResult>();
        List<STK_InLineResult> addOrModifyList = new List<STK_InLineResult>();
        PropertyInfo[] purProperties = typeof(ORD_PurchaseOrderLineResult).GetProperties();
        PropertyInfo[] stkInProperties = typeof(STK_InLineResult).GetProperties();
        
        public frmStkIn()
        {
            InitForm("", null);
        }
        public frmStkIn(string billType, Guid? sourceBillGuid)
        {
            InitForm(billType, sourceBillGuid);
        }
        void InitForm(string billType, Guid? sourceBillGuid)
        {
            InitializeComponent();
            this.GetEditEntity += new dlgGetEditEntity(Form_GetEditEntity);
            dictLineLogic = new SYS_DictItemLineLogic(this);
            orgLogic = new HR_OrgLogic(this);
            purOrderLogic = new ORD_PurchaseOrderLogic(this);
            purLineLogic = new ORD_PurchaseOrderLineLogic(this);
            stkInLogic = new STK_InLogic(this);
            companyLogic = new CRM_CompanyLogic(this);
            currencyLogic = new SYS_CurrencyLogic(this);
            stkStockLogic = new STK_StockLogic(this);
            stkInLineLogic = new STK_InLineLogic(this);
            stkStockSheetLogic = new STK_StockSheetLogic(this);
            returnLogic = new ORD_SalesReturnLogic(this);
            returnLineLogic = new ORD_SalesReturnLineLogic(this);
            BillType = billType;
            _sourceBillGuid = sourceBillGuid;

        }

        #region 实现基类获取实体信息方法
        object Form_GetEditEntity()
        {
            #region 主单编辑
            STK_InResult info = new STK_InResult();
            info.StkInGuid = StkInGuid;
            info = this.ConvertControlToEntity<STK_InResult>(this.stcpStkIn.Controls, info, null);
            this.SetDataIsChanged<STK_InResult>(info);
            #endregion
            #region 明细项目编辑
            bsStkInLine.EndEdit();
            tempList.Clear();
            foreach (STK_InLineResult rst in addOrModifyList)
            {
                if (rst.HasChanged())
                {
                    tempList.Add(rst);
                }
            }
            tempList.AddRange(delList);
            info.StkInLineList = tempList;
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
            orgLogic.BindComboBox(cboOperOrgID, new HR_OrgParam { });
            List<SYS_DictItemLineResult> itemLineList = dictLineLogic.GetListByCode(new SYS_DictItemLineParam
            {
                ItemCodes = new string[] {
                "StkInBillType","FreightPaymentType","Currency","UnitCode","TaxRate" ,"Warehouse"}
            });
            dictLineLogic.BindComboBox(cboCurrency, "Currency", itemLineList);
            dictLineLogic.BindComboBox(cboTaxRate, "TaxRate", itemLineList);

            dictLineLogic.BindComboBox(cboBillType, "StkInBillType", itemLineList);
            dictLineLogic.BindComboBox(colCurrency, "Currency", itemLineList);
            dictLineLogic.BindComboBox(colUnit, "UnitCode", itemLineList);
            dictLineLogic.BindComboBox(colInvType,"InvType", itemLineList);
            dictLineLogic.BindComboBox(colWarehouse,"Warehouse", itemLineList);
            dictLineLogic.BindComboBox(colTaxRate,"TaxRate", itemLineList);
        }
        #endregion

        #region 初始化加载数据
        private void InitData()
        {
            if (StkInGuid != null)//修改
            {
                STK_InResult info = stkInLogic.GetInfo(new STK_InParam { StkInGuid = StkInGuid });
                this.ConvertEntityToControl<STK_InResult>(this.stcpStkIn.Controls, info, null);
                if (info != null )
                {
                    txtAmount.Text = Math.Round(info.Amount.ToDecimal(), 3, MidpointRounding.AwayFromZero).ToStringHasNull();
                    txtSCAmount.Text = Math.Round(info.SCAmount.ToDecimal(), 3, MidpointRounding.AwayFromZero).ToStringHasNull();
                    txtOperDeptName.Text = info.HR_DepartmentResult.DeptName;
                    if(info.StkInLineList != null)
                    addOrModifyList = info.StkInLineList;
                }
                this.CheckIsReadOnly<STK_InResult>(info);
                this.CheckAuditStatus<STK_InResult>(info, this.stcpStkIn, this.panDtlBtn, this.panDtlGrid);
                this.EditBeforeData = info;
            }
            else//新增
            {
                txtInDate.Text = DateTime.Now.ToStringHasNull();
                cboOperOrgID.SelectedValue = MySession.OrgID;
                txtOperDeptName.Text = MySession.DeptName;
                txtOperDeptID.Text = MySession.DeptID.ToStringHasNull();
                txtOperEmpID.Text = MySession.UserID.ToStringHasNull();
                txtOperEmpName.Text = MySession.UserName;
            }
            bsStkInLine.DataSource = addOrModifyList;
            dgvStkInLine.DataSource = bsStkInLine;
            CheckAuditButton("STK_In", StkInGuid, this.tsbSubmit, null, this.tsbAudit, this.tsbUnDo);
            this.DataIsChanged = false;
        }
        #endregion

        #region 窗体加载
        private void frmStkIn_Load(object sender, EventArgs e)
        {
            colModel.ButtonCustomClick += new EventHandler<EventArgs>(editControl_ButtonCustomClick);
            colModel.ButtonClearClick += new EventHandler<CancelEventArgs>(editControl_ButtonClearClick);

            frmSysAttachFiles frm = new frmSysAttachFiles();
            frm.SourceGuid =StkInGuid;
            frm.TopLevel = false;
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            stcpAttach.Controls.Add(frm);
            frm.Show();
            this.SaveAttach += new dlgSaveAttach(frm.SaveAttach);
            BindComboBox();
            InitData();
            operFlag = true;
            if (_sourceBillGuid != null && BillType != "")
                InitSourceData(BillType, _sourceBillGuid);
           
        }
        #endregion

        #region 入库类型选择改变
        private void cboBillType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboBillType.SelectedValue.ToStringHasNull() == "PO_IN")
            {
                colAddGive.Visible = true;
                colIsGive.Visible = true;
            }
            else
            {
                colAddGive.Visible = false;
                colIsGive.Visible = false;
                 
            }
        }
        #endregion
       

        #region 入库日期改变
        private void txtInDate_TextChanged(object sender, EventArgs e)
        {
            if (operFlag)
            {
                CalcExchangeRate();
            }
        }
        #endregion

        #region 计算汇率
        private void CalcExchangeRate()
        {
            string currency = string.Empty;
            DateTime? dateTime = !string.IsNullOrEmpty(txtInDate.Text) ? txtInDate.Text.ToDateTime() : DateTime.Now;
            Dictionary<string,decimal?> exchaneRateDic= currencyLogic.GetExchaneRateDic(dateTime, null);
            foreach (DataGridViewRow row in dgvStkInLine.Rows)
            {
                currency = row.Cells["colCurrency"].Value.ToStringHasNull();
                decimal? exchangeRate = exchaneRateDic.ContainsKey(currency) ? exchaneRateDic[currency] : 1;
                exchangeRate = Math.Round(exchangeRate.ToDecimal(), 4, MidpointRounding.AwayFromZero);
                row.Cells["colExchangeRate"].Value = exchangeRate.ToStringHasNull();
            }
            currency = this.cboCurrency.SelectedValue.ToStringHasNull();
            txtExchangeRate.Text = Math.Round((exchaneRateDic.ContainsKey(currency) ? exchaneRateDic[currency] : 1).ToDecimal(), 4, MidpointRounding.AwayFromZero).ToStringHasNull();
        }
        #endregion

        #region 收货人选择
        private void txtReceiverName_ButtonCustomClick(object sender, EventArgs e)
        {
            frmSelectEmp frmSelectEmp = new frmSelectEmp(false);
            
            frmSelectEmp.empIds = txtReceiverID.Text.Split(',').Select(a => (int?)a.ToInt32()).ToArray();
            frmSelectEmp.OrgID = cboOperOrgID.SelectedValue.ToInt32();
            frmSelectEmp.DeptID = txtOperDeptID.Text.ToInt32();
            DialogResult rst = frmSelectEmp.ShowDialog();
            if (rst == DialogResult.OK)
            {
                List<HR_EmployeeResult> rstList = frmSelectEmp.GetSelectList<HR_EmployeeResult>();
                if (rstList != null && rstList.Count > 0)
                {
                    txtReceiverID.Text = rstList[0].EmpID.ToStringHasNull();
                    txtReceiverName.Text = rstList[0].EmpName;
                }
            }
        }

        #endregion

        #region 收货人清除
        private void txtReceiverName_ButtonCustom2Click(object sender, EventArgs e)
        {
            txtReceiverID.Text = string.Empty;
            txtReceiverName.Text = string.Empty;
        }
        #endregion

        #region 源单据选择
        private void txtSourceBillNo_ButtonCustomClick(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cboBillType.SelectedValue.ToStringHasNull()))
            {
                string billType=cboBillType.SelectedValue.ToStringHasNull();
                DialogResult rst = DialogResult.Cancel;
                switch (billType)
                {
                    case "PO_IN":
                        frmSelectPurchaseOrder frmSelectPurchaseOrder = new frmSelectPurchaseOrder(false);
                        frmSelectPurchaseOrder.BringToFront();
                        frmSelectPurchaseOrder.StartPosition = FormStartPosition.CenterScreen;
                        rst = frmSelectPurchaseOrder.ShowDialog();
                        if (rst == DialogResult.OK)
                        {
                            List<ORD_PurchaseOrderResult> rstList = frmSelectPurchaseOrder.GetSelectList<ORD_PurchaseOrderResult>();
                            if (rstList != null && rstList.Count > 0)
                            {
                                InitSourceData(billType, rstList[0].POGuid);
                            }
                        }
                        break;
                    case "SOR_IN":
                        frmSelectSalesReturn frmSelectSalesReturn = new frmSelectSalesReturn(false);
                        frmSelectSalesReturn.BringToFront();
                        frmSelectSalesReturn.StartPosition = FormStartPosition.CenterScreen;
                        rst = frmSelectSalesReturn.ShowDialog();
                        if (rst == DialogResult.OK)
                        {
                            List<ORD_SalesReturnResult> rstList = frmSelectSalesReturn.GetSelectList<ORD_SalesReturnResult>();
                            if (rstList != null && rstList.Count > 0)
                            {
                                InitSourceData(billType, rstList[0].SRGuid);
                            }
                        }
                        break;
                    case "ZX_IN":

                        break;
                }
            }
            else 
            {
                MessageBox.Show("请选择入库类型！");
            }
        }
        public void InitSourceData(string billType, Guid? sourceBillGuid)
        {
            if (cboBillType.SelectedValue.ToStringHasNull() == "")
            {
                SYS_DictItemLineLogic.SetCombolSelectedIndex(cboBillType, billType, true);
            }
            switch (billType)
            {
                case "PO_IN"://采购入库
                    #region 采购入库
                    ORD_PurchaseOrderResult rst = purOrderLogic.GetInfo(new ORD_PurchaseOrderParam() { POGuid = sourceBillGuid });
                    if (rst != null)
                    {
                        bsStkInLine.Clear();
                        tempList.Clear();
                        delList.Clear();
                        addOrModifyList.Clear();
                        SetStkLineObjectValue(rst);
                        CalcExchangeRate();
                    }
                    #endregion
                    break;
                case "SOR_IN"://销售退货入库
                    #region 销售退货入库
                    ORD_SalesReturnResult returnResult = returnLogic.GetInfo(new ORD_SalesReturnParam() { SRGuid = sourceBillGuid });
                    if (returnResult != null)
                    {
                        bsStkInLine.Clear();
                        tempList.Clear();
                        delList.Clear();
                        addOrModifyList.Clear();
                        SetStkLineObjectValue(returnResult);
                        CalcExchangeRate();
                    }
                    #endregion
                    break;
            }
        }
        #endregion

        #region 给入库明细对象赋值
        public void SetStkLineObjectValue(STK_InLineResult inLineRst, ORD_PurchaseOrderLineResult purLineRst)
        {
            inLineRst.BuyerID = purLineRst.BuyerID;
            inLineRst.BuyerName = purLineRst.BuyerName;
            inLineRst.SourceBillGuid = purLineRst.POGuid;
            inLineRst.SourceBillLineGuid = purLineRst.POLineGuid;
            inLineRst.SOLineGuid = purLineRst.SOLineGuid;
            inLineRst.Model = purLineRst.Model;
            inLineRst.Brand = purLineRst.Brand;
            inLineRst.Package = purLineRst.Package;
            inLineRst.Batch = purLineRst.Batch;
            inLineRst.InvType = purLineRst.InvType;
            inLineRst.Currency = purLineRst.Currency;
            inLineRst.Unit = purLineRst.Unit;
            inLineRst.UnitPrice = purLineRst.UnitPrice;
            inLineRst.CostPrice = inLineRst.UnitPrice.ToDecimal() + inLineRst.Freight.ToDecimal();
            inLineRst.Qty = purLineRst.Qty.ToInt32() - purLineRst.StkInQty.ToInt32();
            inLineRst.Amount = purLineRst.UnitPrice * purLineRst.Qty;
            inLineRst.SCAmount = inLineRst.Amount * inLineRst.ExchangeRate;
            inLineRst.TaxRate = purLineRst.TaxRate;
            inLineRst.Warehouse = purLineRst.Warehouse;
            inLineRst.Location = purLineRst.Location;
            inLineRst.IsCut = true;
            inLineRst.IsPCut = true;
            inLineRst.IsRaiseTaxes = false;
            inLineRst.IsGive = inLineRst.IsGive == true ? true : false;
            inLineRst.IsDeleted = false;
        }
        public void SetStkLineObjectValue(ORD_PurchaseOrderResult purchaseOrder)
        {
            decimal? taxAmount = 0.0m;
            decimal? totalAmount = 0.0m;
            decimal? scAmount = 0.0m;
            STK_InLineResult inLineRst;
            txtSourceBillGuid.Text = purchaseOrder.POGuid.ToStringHasNull();
            txtSourceBillNo.Text = purchaseOrder.BillNo;
            cboCurrency.SelectedValue = purchaseOrder.Currency;
            cboTaxRate.SelectedValue = purchaseOrder.TaxRate.ToDecimal();
            foreach (ORD_PurchaseOrderLineResult purLineRst in purchaseOrder.OrderLineList)
            {
                inLineRst = new STK_InLineResult();
                purLineRst.BuyerID = purchaseOrder.BuyerID;
                purLineRst.BuyerName = purchaseOrder.BuyerName;
                purLineRst.Currency = purchaseOrder.Currency;
                SetStkLineObjectValue(inLineRst, purLineRst);
                bsStkInLine.Add(inLineRst);
                taxAmount += inLineRst.TaxRate.ToDecimal(); 
                totalAmount += inLineRst.Amount.ToDecimal();
                taxAmount += purLineRst.UnitPrice * purLineRst.Qty.ToInt32() - purLineRst.NTaxPrice * purLineRst.Qty.ToInt32();
                scAmount += inLineRst.SCAmount.ToDecimal();
            }
            totalAmount = Math.Round(totalAmount.ToDecimal(), 3, MidpointRounding.AwayFromZero);
            scAmount = Math.Round(scAmount.ToDecimal(), 3, MidpointRounding.AwayFromZero);
            taxAmount = Math.Round(taxAmount.ToDecimal(), 3, MidpointRounding.AwayFromZero);
            txtAmount.Text = totalAmount.ToStringHasNull();
            txtSCAmount.Text = scAmount.ToStringHasNull();
            txtTaxAmount.Text = taxAmount.ToStringHasNull();
            this.cboOperOrgID.SelectedValue = purchaseOrder.PurOrgID;
            this.txtOperDeptID.Text = purchaseOrder.PurDeptName;
            this.txtOperDeptID.Text = purchaseOrder.PurDeptID.ToStringHasNull();
            this.txtOperEmpID.Text = purchaseOrder.BuyerID.ToStringHasNull();
            this.txtOperEmpName.Text = purchaseOrder.BuyerName.ToStringHasNull();

        }
        public void SetStkLineObjectValue(ORD_SalesReturnResult salesReturnRst)
        {
            decimal? totalAmount = 0.0m;
            decimal? scAmount = 0.0m;
            STK_InLineResult inLineRst;
            txtSourceBillGuid.Text = salesReturnRst.SRGuid.ToStringHasNull();
            txtSourceBillNo.Text = salesReturnRst.BillNo;
            cboTaxRate.SelectedValue = "";
            if (salesReturnRst.ReturnLineList != null && salesReturnRst.ReturnLineList.Count > 0)
            {
                cboCurrency.SelectedValue = salesReturnRst.ReturnLineList[0].Currency;
            }
            else
            {
                cboCurrency.SelectedValue = "";
            }
            foreach (ORD_SalesReturnLineResult returnLineResult in salesReturnRst.ReturnLineList)
            {
                inLineRst = new STK_InLineResult();
                SetStkLineObjectValue(inLineRst, returnLineResult);
                totalAmount += inLineRst.Amount.ToDecimal();
                scAmount += inLineRst.SCAmount.ToDecimal();
                bsStkInLine.Add(inLineRst);
            }
            totalAmount = Math.Round(totalAmount.ToDecimal(), 3, MidpointRounding.AwayFromZero);
            scAmount = Math.Round(scAmount.ToDecimal(), 3, MidpointRounding.AwayFromZero);
            txtAmount.Text = totalAmount.ToStringHasNull();
            txtSCAmount.Text = scAmount.ToStringHasNull();
            txtTaxAmount.Text = "";
            this.cboOperOrgID.SelectedValue = salesReturnRst.OperOrgID;
            this.txtOperDeptID.Text = salesReturnRst.OperDeptName;
            this.txtOperDeptID.Text = salesReturnRst.OperDeptID.ToStringHasNull();
            this.txtOperEmpID.Text = salesReturnRst.OperEmpID.ToStringHasNull();
            this.txtOperEmpName.Text = salesReturnRst.OperEmpName.ToStringHasNull();
        }
        public void SetStkLineObjectValue(STK_InLineResult inLineRst, ORD_SalesReturnLineResult returnLineResult)
        {
            inLineRst.ItemCode = returnLineResult.ItemCode;
            inLineRst.BuyerID = returnLineResult.BuyerID;
            inLineRst.BuyerName = returnLineResult.BuyerName;
            inLineRst.SourceBillGuid = returnLineResult.SRGuid;
            inLineRst.SourceBillLineGuid = returnLineResult.SRLineGuid;
            inLineRst.Model = returnLineResult.Model;
            inLineRst.Brand = returnLineResult.Brand;
            inLineRst.Package = returnLineResult.Package;
            inLineRst.Batch = returnLineResult.Batch;
            inLineRst.InvType = returnLineResult.InvType;
            inLineRst.Currency = returnLineResult.LinkStkInCurrency;
            inLineRst.TaxRate = returnLineResult.LinkStkInTaxRate;
            inLineRst.ExchangeRate = returnLineResult.LinkStkInExchangeRate;
            inLineRst.Unit = returnLineResult.Unit;
            inLineRst.UnitPrice = returnLineResult.LinkStkInUnitPrice;
            inLineRst.Freight = returnLineResult.LinkStkInFreight;
            inLineRst.CostPrice = returnLineResult.LinkStkInCostPrice;
            inLineRst.Qty = returnLineResult.Qty.ToInt32() - returnLineResult.StkInOccQty.ToInt32();
            inLineRst.Amount = inLineRst.CostPrice * inLineRst.Qty;
            inLineRst.SCAmount = inLineRst.CostPrice * inLineRst.Qty;
            inLineRst.Warehouse = returnLineResult.Warehouse;
            inLineRst.Location = returnLineResult.Location;
            inLineRst.IsCut = true;
            inLineRst.IsPCut = true;
            inLineRst.IsRaiseTaxes = false;
            inLineRst.IsGive = false;
            inLineRst.IsDeleted = false;
        }
        #endregion
        #region 源单据清除
        private void txtSourceBillNo_ButtonCustom2Click(object sender, EventArgs e)
        {
            txtSourceBillGuid.Text = string.Empty;
            txtSourceBillNo.Text = string.Empty;
        }
        #endregion

        #region 归属部门选择
        private void txtOperDeptName_ButtonCustomClick(object sender, EventArgs e)
        {
            frmSelectDepartment frmSelectDepartment = new frmSelectDepartment(false);
            frmSelectDepartment.deptIds = txtOperDeptID.Text.Split(',').Select(a => (int?)a.ToInt32()).ToArray();
            frmSelectDepartment.OrgID = cboOperOrgID.SelectedValue.ToInt32();
            frmSelectDepartment.BringToFront();
            frmSelectDepartment.StartPosition = FormStartPosition.CenterScreen;
            DialogResult rst = frmSelectDepartment.ShowDialog();
            if (rst == DialogResult.OK)
            {
                List<HR_DepartmentResult> rstList = frmSelectDepartment.GetSelectList<HR_DepartmentResult>();
                if (rstList != null && rstList.Count > 0)
                {

                        txtOperDeptID.Text = rstList[0].DeptID.ToStringHasNull();
                        txtOperDeptName.Text =  rstList[0].DeptName;

                }
            }
        }
        #endregion

        #region 归属部门清除
        private void txtOperDeptName_ButtonCustom2Click(object sender, EventArgs e)
        {
            txtOperDeptID.Text = string.Empty;
            txtOperDeptName.Text = string.Empty;
        }
        #endregion

        #region 归属人员选择
        private void txtOperEmpName_ButtonCustomClick(object sender, EventArgs e)
        {
            frmSelectEmp frmSelectEmp = new frmSelectEmp(false);
            frmSelectEmp.empIds = txtOperEmpID.Text.Split(',').Select(a => (int?)a.ToInt32()).ToArray();
            frmSelectEmp.OrgID = cboOperOrgID.SelectedValue.ToInt32();
            frmSelectEmp.DeptID = txtOperDeptID.Text.ToInt32();
            DialogResult rst = frmSelectEmp.ShowDialog();
            if (rst == DialogResult.OK)
            {
                List<HR_EmployeeResult> rstList = frmSelectEmp.GetSelectList<HR_EmployeeResult>();
                if (rstList != null && rstList.Count > 0)
                {
                        txtOperEmpID.Text = rstList[0].EmpID.ToStringHasNull();
                        txtOperEmpName.Text = rstList[0].EmpName;
                }
            }
        }
        #endregion

        #region 归属人员清除
        private void txtOperEmpName_ButtonCustom2Click(object sender, EventArgs e)
        {
            txtOperEmpID.Text = string.Empty;
            txtOperEmpName.Text = string.Empty;
        }
        #endregion

        #region 添加空行
        private void btnAddRow_Click(object sender, EventArgs e)
        {
            bsStkInLine.AddNew();
            STK_InLineResult rst = bsStkInLine.Current as STK_InLineResult;
            InitNewData(rst);
        }
        #endregion

        #region 插入一行
        private void btnInsertBefore_Click(object sender, EventArgs e)
        {
            if (dgvStkInLine.CurrentRow != null)
            {
                STK_InLineResult rst = new STK_InLineResult();
                InitNewData(rst);
                bsStkInLine.Insert(dgvStkInLine.CurrentRow.Index, rst);
            }
        }
        #endregion

        void InitNewData(STK_InLineResult rst)
        {
          
            rst.InvType = "备货库存";
            rst.Unit = "PCS";
            rst.SCAmount = 0;
        }

        #region 删除行
        private void btnDelRow_Click(object sender, EventArgs e)
        {
            if (this.bsStkInLine.Current != null)
            {
                Guid? stkInLineGuid = null;
                STK_InLineResult delResult = this.bsStkInLine.Current as STK_InLineResult;
                stkInLineGuid = delResult.StkInLineGuid;
                if (stkInLineGuid!=null)
                {
                    delResult.IsDeleted = true;
                    delList.Add(delResult);
                }
                bsStkInLine.RemoveCurrent();
            }
        }
        #endregion

        #region  导入关联明细
        private void btnImportSourceLine_Click(object sender, EventArgs e)
        {
            ImportSourceLine(true);
        }
        #endregion

        #region 导入明细
        private void ImportSourceLine(bool isMutiSelect)
        {
            if (!string.IsNullOrEmpty(cboBillType.SelectedValue.ToStringHasNull()))
            {
                switch (cboBillType.SelectedValue.ToStringHasNull())
                {
                    case "PO_IN":
                        ImportPurchaseOrderLine(isMutiSelect);
                        break;
                    case "SOR_IN":
                        ImportSalesReturnLineLine(isMutiSelect);
                        break;
                    case "ZX_IN":
                        break;
                }
            }
            else
            {
                MessageBox.Show("请选择入库类型！");
            }
        }

        private void ImportPurchaseOrderLine(bool isMutiSelect)
        {
            if (!string.IsNullOrEmpty(txtSourceBillGuid.Text))
            {
                frmSelectPurchaseOrderLine frm = new frmSelectPurchaseOrderLine(isMutiSelect);
                frm.POGuid = txtSourceBillGuid.Text.ToGuid();
                Guid? plineGuid=Guid.Empty;
                string model = string.Empty;
                if (!isMutiSelect)
                {
                    plineGuid = dgvStkInLine.CurrentRow.Cells["colSourceBillLineGuid"].Value.ToGuid();
                    model = dgvStkInLine.CurrentRow.Cells["colModel"].Value.ToStringHasNull();
                }
                
                if (!string.IsNullOrEmpty(model))
                    frm.Model = model;
                if (plineGuid != Guid.Empty)//如果已经存在关联的源单据明细，则只筛选此条明细
                    frm.POLineGuid = plineGuid;
                else//如果是新行，则排除掉已经存在列表里面的所有的源单据明细
                {
                    Guid?[] nopLineGuids = addOrModifyList.Where(a => a.SourceBillLineGuid.ToGuid() != Guid.Empty).Select(a => a.SourceBillLineGuid).Distinct().ToArray();
                    frm.NoPOLineGuids = nopLineGuids;
                }
                frm.BringToFront();
                frm.StartPosition = FormStartPosition.CenterScreen;
                DialogResult rst = frm.ShowDialog();
                if (rst == DialogResult.OK)
                {
                    List<ORD_PurchaseOrderLineResult> rstList = frm.GetSelectList<ORD_PurchaseOrderLineResult>();
                    if (rstList != null && rstList.Count > 0)
                    {
                        foreach (ORD_PurchaseOrderLineResult purLineResult in rstList)
                        {
                            bool isAddNew = true;
                            foreach (DataGridViewRow row in dgvStkInLine.Rows)
                            {
                                //如果是已经存在的行，则利用现成的行进行编辑

                                if (row.Cells["colSourceBillLineGuid"].Value.ToGuid() == purLineResult.POLineGuid)
                                {
                                    isAddNew = false;
                                    STK_InLineResult stkInLineResult=  bsStkInLine[row.Index] as STK_InLineResult;
                                    SetStkLineObjectValue(stkInLineResult, purLineResult);
                                    break;
                                }
                            }
                            if (isAddNew)
                            {
                                if (!isMutiSelect)//单选
                                {
                                    STK_InLineResult stkInLineResult = bsStkInLine.Current as STK_InLineResult;
                                    SetStkLineObjectValue(stkInLineResult, purLineResult);
                                }
                                else//多选
                                {
                                    STK_InLineResult stkInLineResult = new STK_InLineResult();
                                    SetStkLineObjectValue(stkInLineResult, purLineResult);
                                    bsStkInLine.Add(stkInLineResult);
                                }
                            }
                        }
                    }
                }
                dgvStkInLine.EndEdit();
                CalcExchangeRate();
            }
            else
            {
                MessageBox.Show("请先选择源单据！");
            }
        }
        private void ImportSalesReturnLineLine(bool isMutiSelect)
        {
            if (!string.IsNullOrEmpty(txtSourceBillGuid.Text))
            {
                frmSelectSalesReturnLine frm = new frmSelectSalesReturnLine(isMutiSelect);
                frm.SRGuid = txtSourceBillGuid.Text.ToGuid();
                Guid? srlineGuid = Guid.Empty;
                string model = string.Empty;
                if (!isMutiSelect)
                {
                    srlineGuid = dgvStkInLine.CurrentRow.Cells["colSourceBillLineGuid"].Value.ToGuid();
                    model = dgvStkInLine.CurrentRow.Cells["colModel"].Value.ToStringHasNull();
                }

                if (!string.IsNullOrEmpty(model))
                    frm.Model = model;
                if (srlineGuid != Guid.Empty)//如果已经存在关联的源单据明细，则只筛选此条明细
                    frm.SRLineGuid= srlineGuid;
                else//如果是新行，则排除掉已经存在列表里面的所有的源单据明细
                {
                    Guid?[] noSRLineGuids = addOrModifyList.Where(a => a.SourceBillLineGuid.ToGuid() != Guid.Empty).Select(a => a.SourceBillLineGuid).Distinct().ToArray();
                    frm.NoSRLineGuids = noSRLineGuids;
                }
                frm.BringToFront();
                frm.StartPosition = FormStartPosition.CenterScreen;
                DialogResult rst = frm.ShowDialog();
                if (rst == DialogResult.OK)
                {
                    List<ORD_SalesReturnLineResult> rstList = frm.GetSelectList<ORD_SalesReturnLineResult>();
                    if (rstList != null && rstList.Count > 0)
                    {
                        foreach (ORD_SalesReturnLineResult returnLineResult in rstList)
                        {
                            bool isAddNew = true;
                            foreach (DataGridViewRow row in dgvStkInLine.Rows)
                            {
                                //如果是已经存在的行，则利用现成的行进行编辑

                                if (row.Cells["colSourceBillLineGuid"].Value.ToGuid() == returnLineResult.SRLineGuid)
                                {
                                    isAddNew = false;
                                    STK_InLineResult stkInLineResult = bsStkInLine[row.Index] as STK_InLineResult;
                                    SetStkLineObjectValue(stkInLineResult, returnLineResult);
                                    break;
                                }
                            }
                            if (isAddNew)
                            {
                                if (!isMutiSelect)//单选
                                {
                                    STK_InLineResult stkInLineResult = bsStkInLine.Current as STK_InLineResult;
                                    SetStkLineObjectValue(stkInLineResult, returnLineResult);
                                }
                                else//多选
                                {
                                    STK_InLineResult stkInLineResult = new STK_InLineResult();
                                    SetStkLineObjectValue(stkInLineResult, returnLineResult);
                                    bsStkInLine.Add(stkInLineResult);
                                }
                            }
                        }
                    }
                }
                dgvStkInLine.EndEdit();
                CalcExchangeRate();
            }
            else
            {
                MessageBox.Show("请先选择源单据！");
            }
           
        }
        #endregion

        #region 汇总计算
        private void CalcAmount()
        {
            decimal amount=0.0m;
            decimal totalAmount = 0.0m;
            decimal scAmount = 0.0m;
            decimal exchangeRate=0.0m;
            foreach (DataGridViewRow row in dgvStkInLine.Rows)
            {
                amount=(row.Cells["colUnitPrice"].Value.ToDecimal() + row.Cells["colFreight"].Value.ToDecimal()) * row.Cells["colQty"].Value.ToDecimal();
                exchangeRate=row.Cells["colExchangeRate"].Value.ToDecimal();
                totalAmount +=amount ;
                scAmount += amount * exchangeRate;
            }
           
            totalAmount = Math.Round(totalAmount, 3, MidpointRounding.AwayFromZero);
            scAmount = Math.Round(totalAmount * exchangeRate, 3, MidpointRounding.AwayFromZero);
            txtAmount.Text = totalAmount.ToStringHasNull();
            txtSCAmount.Text = scAmount.ToStringHasNull();
        }
        #endregion
        
        #region 表格数据绑定完成
        private void dgvStkInLine_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            
            foreach (DataGridViewRow row in dgvStkInLine.Rows)
            {
                if (row.Cells["colSourceBillLineGuid"].Value.ToGuid() != Guid.Empty)
                {
                    row.Cells["colInvType"].ReadOnly = true;
                    row.Cells["colTaxRate"].ReadOnly = true;
                }
                if (row.Cells["colIsGive"].Value.ToBooleanHasNull())
                {
                    row.Cells["colUnitPrice"].ReadOnly = true;
                    row.Cells["colUnitPrice"].ToolTipText = "赠送单价为零！";
                    row.DefaultCellStyle.BackColor = Color.PaleVioletRed;
                }
                else
                {
                    row.Cells["colUnitPrice"].ReadOnly = false;
                    row.DefaultCellStyle.BackColor = Color.White;
                }
              
            }
        }
        #endregion

        #region 单元格内容改变
        private void dgvStkInLine_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int qty = 0;
            decimal unitPrice = 0.0m;
            decimal freight = 0.0m;
            decimal costPrice = 0.0m;
            decimal exchangeRate = 0.0m;
            decimal amount=0.0m;
            decimal scAmount=0.0m;
            string currency = string.Empty;
            

            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                dgvStkInLine.CellValueChanged -= new DataGridViewCellEventHandler(dgvStkInLine_CellValueChanged);
                try
                {
                    string columnName = dgvStkInLine.Columns[e.ColumnIndex].Name;
                    if (columnName == "colQty" || columnName == "colUnitPrice" || columnName == "colFreight")
                    {
                        qty = dgvStkInLine["colQty", e.RowIndex].Value.ToInt32();
                        unitPrice = dgvStkInLine["colUnitPrice", e.RowIndex].Value.ToDecimal();
                        freight = dgvStkInLine["colFreight", e.RowIndex].Value.ToDecimal();
                        costPrice = unitPrice + freight;
                        dgvStkInLine["colCostPrice", e.RowIndex].Value = costPrice;
                        amount= Math.Round(qty * costPrice, 3, MidpointRounding.AwayFromZero);
                        dgvStkInLine["colAmount", e.RowIndex].Value =amount;
                        exchangeRate = dgvStkInLine["colExchangeRate", e.RowIndex].Value.ToDecimal();
                        dgvStkInLine["colSCAmount", e.RowIndex].Value = Math.Round(amount * exchangeRate, 3, MidpointRounding.AwayFromZero);
                    }
                    else if (columnName == "colCurrency")
                    {
                        DateTime? dateTime = !string.IsNullOrEmpty(txtInDate.Text) ? txtInDate.Text.ToDateTime() : DateTime.Now;
                        currency = dgvStkInLine["colCurrency", e.RowIndex].Value.ToStringHasNull();
                        exchangeRate = currencyLogic.GetExchangeRate(dateTime, currency).ToDecimal();
                        exchangeRate = Math.Round(exchangeRate.ToDecimal(), 4, MidpointRounding.AwayFromZero);
                        dgvStkInLine["colExchangeRate", e.RowIndex].Value = exchangeRate.ToStringHasNull();
                        amount = dgvStkInLine["colAmount", e.RowIndex].Value.ToDecimal();
                        scAmount = Math.Round((amount * exchangeRate).ToDecimal(), 3, MidpointRounding.AwayFromZero);
                        dgvStkInLine["colSCAmount", e.RowIndex].Value = scAmount;
                    }
                    else if (columnName == "colExchangeRate")
                    {
                        exchangeRate = dgvStkInLine["colExchangeRate", e.RowIndex].Value.ToDecimal();
                        amount = dgvStkInLine["colAmount", e.RowIndex].Value.ToDecimal();
                        scAmount = Math.Round((amount * exchangeRate).ToDecimal(), 3, MidpointRounding.AwayFromZero);
                        dgvStkInLine["colSCAmount", e.RowIndex].Value = scAmount;
                    }
                    bsStkInLine.EndEdit();
                    CalcAmount();
                }
                finally
                {
                    dgvStkInLine.CellValueChanged += new DataGridViewCellEventHandler(dgvStkInLine_CellValueChanged);
                }

            }
        }
        #endregion

        #region 单元格内容单击
        private void dgvStkInLine_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                if (dgvStkInLine.Columns[e.ColumnIndex].Name == "colAddGive")
                {
                    STK_InLineResult rst=bsStkInLine.Current  as STK_InLineResult;
                    STK_InLineResult newLine= EntityHandler.Clone(rst);
                    newLine.StkInGuid = null;
                    newLine.StkInLineGuid = null;
                    newLine.IsCut = true;
                    newLine.IsPCut = true;
                    newLine.IsRaiseTaxes = false;
                    newLine.IsGive = true;
                    newLine.IsDeleted = false;
                    newLine.Qty = null;
                    newLine.UnitPrice =null;
                    newLine.CostPrice = null;
                    newLine.CostPrice = null;
                    newLine.Amount = null;
                    bsStkInLine.Insert(e.RowIndex + 1, newLine);
                    
                }
            }
        }
        #endregion

        #region 单元格内容转换
        private void dgvStkInLine_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
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

        #region 列编辑控件显示注册
        private void dgvStkInLine_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
           
        }
        #endregion

        #region 列编辑控件双击弹窗
        private void editControl_ButtonCustomClick(object sender, EventArgs e)
        {
            ImportSourceLine(false);
        }
        #endregion

        #region 列编辑控件双击清除
        private void editControl_ButtonClearClick(object sender, EventArgs e)
        {
           
        }
        #endregion
        #region 更改了主单币种
        private void cboCurrency_SelectedValueChanged(object sender, EventArgs e)
        {
            ChangeCurrency();
        }
        private void ChangeCurrency()
        {
            string currency = this.cboCurrency.SelectedValue.ToStringHasNull();
            foreach (DataGridViewRow row in dgvStkInLine.Rows)
            {
                row.Cells["colCurrency"].Value = currency;
            }
            CalcExchangeRate();
        }
        #endregion
        #region 保存
        private void tsbSave_Click(object sender, EventArgs e)
        {
            SaveData(true);
        }
        #region 验证保存数据
        private bool CheckSaveData()
        {
            bool ret = false;
            bool err = false;
            #region 主单验证
            if (string.IsNullOrEmpty(this.txtSourceBillGuid.Text))
            {
                this.ShowMessage("请指定源单据！");
                err = true;
            }
            else if (string.IsNullOrEmpty(this.cboBillType.SelectedValue.ToStringHasNull()))
            {
                this.ShowMessage("请指定入库类型！");
                err = true;
            }
            else if (string.IsNullOrEmpty(this.cboOperOrgID.SelectedValue.ToStringHasNull()))
            {
                this.ShowMessage("请指定机构！");
                err = true;
            }
            else if (string.IsNullOrEmpty(this.txtOperDeptID.Text))
            {
                this.ShowMessage("请指定所属部门！");
                err = true;
            }
            else if (string.IsNullOrEmpty(this.txtOperEmpID.Text))
            {
                this.ShowMessage("请指定所属人员！");
                err = true;
            }
            #endregion
            #region 明细验证
            foreach (STK_InLineResult rst in addOrModifyList)
            {
                if (string.IsNullOrEmpty(rst.Model))
                {
                    this.ShowMessage("请输入明细型号！");
                    err = true;
                    break;
                }
                if (rst.Qty <= 0)
                {
                    this.ShowMessage("明细存在不正确的数量格式！");
                    err = true;
                    break;
                }
                if (string.IsNullOrEmpty(rst.Warehouse))
                {
                    this.ShowMessage("请指定明细仓库！");
                    err = true;
                    break;
                }
            }
            #endregion
            if (err) ret = false;
            else ret = true;
            return ret;
        }
        #endregion
        #region 保存数据
        private bool SaveData(bool isAsyncExecute)
        {
            bool ret = false;
            STK_InResult info = Form_GetEditEntity() as STK_InResult;
            if (isAsyncExecute && !this.DataIsChanged)
            {
                this.ShowNoChangedMsg();
                return ret;
            }
            if (!this.CheckSaveData()) return ret;


            #region 异步执行保存操作
            bsStkInLine.EndEdit();
            tempList.Clear();
            foreach (STK_InLineResult rst in addOrModifyList)
            {
                if (rst.HasChanged())
                {
                    tempList.Add(rst);
                }
            }
            tempList.AddRange(delList);
            info.StkInLineList = tempList;
            #region 异步执行操作
            if (isAsyncExecute)
            {
                WCFAddUpdateResult result = this.AsyncExecute<WCFAddUpdateResult, STK_InResult>(info, stkInLogic.AddOrUpdate, (a) =>
                {
                    if (a.KeyGuid.ToGuid() != Guid.Empty)
                    {
                        StkInGuid = a.KeyGuid.ToGuid();
                        if (SaveAttach != null)
                            SaveAttach("STK_In", StkInGuid.ToGuid(), a.BillNo);
                        InitData();
                        delList.Clear();
                    }
                });
            }
            #endregion
            #region 同步执行保存操作
            else
            {
                WCFAddUpdateResult result = stkInLogic.AddOrUpdate(info);
                if (result.KeyGuid.ToGuid() != Guid.Empty)
                {
                    ret = true;
                }
            }
            #endregion
            return ret;
        }
        #endregion
        #endregion
        #endregion
        #region 审核相关方法
        #region 提交
        private void tsbSubmit_Click(object sender, EventArgs e)
        {
            //tsbSave_Click(sender, e);
            //stkInLogic.SubmitStkInBill(new STK_InParam() { StkInGuid = StkInGuid });
            STK_InResult info = Form_GetEditEntity() as STK_InResult;
            this.WF_SubmitBill("STK_In", info, info.BillNo, info.StkInGuid, this.DataIsChanged, delegate() { return (SaveData(false)); }, InitData);

        }
        #endregion
        #region 审核
        private void tsbAudit_Click(object sender, EventArgs e)
        {
            //stkInLogic.AuditStkInBill(new STK_InParam() { StkInGuid = StkInGuid });
            STK_InResult info = Form_GetEditEntity() as STK_InResult;
            this.WF_CheckBill("STK_In", info.BillNo, info.StkInGuid, this.DataIsChanged, delegate() { return (SaveData(false)); }, InitData);
        }
        #endregion
        #region 撤单
        private void tsbUnDo_Click(object sender, EventArgs e)
        {
            STK_InResult info = Form_GetEditEntity() as STK_InResult;
            this.WF_CancelCheckBill("STK_In", info.StkInGuid, InitData);
        }
        #endregion

        private void tsbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

    }
}
