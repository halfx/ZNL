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
using ZNLCRM.UI.Logic.HR;
using ZNLCRM.UI.Logic.Sys;
using ZNLCRM.Entity.UserModel.HR;
using ZNLCRM.Entity.UserModel.Sys;
using DevComponents.DotNetBar.SuperGrid;
using ZNLCRM.Entity.UserModel.STK;
using ZNLCRM.Utility;
using ZNLCRM.UI.HR;
using ZNLCRM.UI.SPM;
using ZNLCRM.Entity.UserModel.SPM;
using ZNLCRM.UI.Logic.SPM;
using ZNLCRM.Entity.UserModel.PPM;
using ZNLCRM.Entity.UserModel.Common;
using ZNLCRM.Client.Entry;
using ZNLCRM.UI.PPM;
using ZNLCRM.UI.Logic.PPM;
using ZNLCRM.Entity.DBModel;

namespace ZNLCRM.UI.STK
{
    public partial class frmStkOut : frmBaseEditForm
    {
        public delegate void dlgRefreshParentForm();
        public event dlgRefreshParentForm RefreshParentForm;
        public delegate void dlgSaveAttach(string sourceTable, Guid sourceGuid, string sourceBillNo);
        public event dlgSaveAttach SaveAttach;
        public Guid? StkOutGuid = null;
        public string BillNo = string.Empty;
        private Guid? _sourceBillGuid =null;
        private  string _billType = string.Empty;
        
        STK_OutLogic stkOutLogic = null;
        HR_OrgLogic orgLogic = null;
        SYS_DictItemLineLogic dictLineLogic = null;
        SYS_CurrencyLogic currencyLogic = null;
        STK_StockReserveLogic reserveLogic = null;
        ORD_SalesOrderLogic orderLogic = null;
        ORD_SalesOrderLineLogic orderLineLogic = null;
        ORD_PurchaseReturnLogic returnLogic = null;
        ORD_PurchaseReturnLineLogic returnLineLogic = null;
        BindingSource bsStkOutLine = new BindingSource();
        List<STK_OutLineResult> tempList = new List<STK_OutLineResult>();
        List<STK_OutLineResult> delList = new List<STK_OutLineResult>();
        List<STK_OutLineResult> addOrModifyList = new List<STK_OutLineResult>();
        public frmStkOut()
        {
            InitForm("",null);
        }
        public frmStkOut(string billType, Guid? sourceBillGuid)
        {
            InitForm(billType, sourceBillGuid);
        }
        void InitForm(string billType, Guid? sourceBillGuid)
        {
            
            InitializeComponent();
            stkOutLogic = new STK_OutLogic(this);
            orgLogic = new HR_OrgLogic(this);
            currencyLogic = new SYS_CurrencyLogic(this);
            dictLineLogic = new SYS_DictItemLineLogic(this);
            orderLineLogic=new ORD_SalesOrderLineLogic(this);
            returnLogic = new ORD_PurchaseReturnLogic(this);
            returnLineLogic = new ORD_PurchaseReturnLineLogic(this);
            reserveLogic = new STK_StockReserveLogic(this);
            _billType = billType;
            _sourceBillGuid = sourceBillGuid;
        }
        #region 实现基类获取实体信息方法
        object Form_GetEditEntity()
        {
            STK_OutResult info = new STK_OutResult();
            info.StkOutGuid = StkOutGuid;
            info = this.ConvertControlToEntity<STK_OutResult>(this.stcpStkOut.Controls, info, null);
            this.SetDataIsChanged<STK_OutResult>(info);
           
            return info;
        }
        #endregion
        
        private void frmStkOut_Load(object sender, EventArgs e)
        {
            colModel.ButtonCustomClick += new EventHandler<EventArgs>(editControl_ButtonCustomClick);
            colModel.ButtonClearClick += new EventHandler<CancelEventArgs>(editControl_ButtonClearClick);

            frmSysAttachFiles frm = new frmSysAttachFiles();
            frm.SourceGuid = StkOutGuid;
            frm.TopLevel = false;
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            stcpAttach.Controls.Add(frm);
            frm.Show();
            this.SaveAttach += new dlgSaveAttach(frm.SaveAttach);
            BindComboBox();
            InitData();
            if (_billType != "" && StkOutGuid == null && _sourceBillGuid != null)
                InitSourceData(_billType, _sourceBillGuid);
        }

        #region 绑定下拉框
        private void BindComboBox()
        {
            orgLogic.BindComboBox(cboOperOrgID, new HR_OrgParam { });
            List<SYS_DictItemLineResult> itemLineList = dictLineLogic.GetListByCode(new SYS_DictItemLineParam
            {
                ItemCodes = new string[] {
                "StkOutBillType","Currency","UnitCode","TaxRate" ,"InvType","TransportCompany","Warehouse"}
            });

            dictLineLogic.BindComboBox(cboBillType, "StkOutBillType", itemLineList);
            dictLineLogic.BindComboBox(cboTransportCompany, "TransportCompany", itemLineList);
            dictLineLogic.BindComboBox(cboCurrency, "Currency", itemLineList);
            dictLineLogic.BindComboBox(cboTaxRate, "TaxRate", itemLineList);

            dictLineLogic.BindComboBox(colCurrency, "Currency", itemLineList);
            dictLineLogic.BindComboBox(colUnit, "UnitCode", itemLineList);
            dictLineLogic.BindComboBox(colInvType, "InvType", itemLineList);
            dictLineLogic.BindComboBox(colWarehouse, "Warehouse", itemLineList);
            dictLineLogic.BindComboBox(colTaxRate, "TaxRate", itemLineList);
       
        }
        #endregion
        #region 初始化加载数据
        private void InitData()
        {

            //修改
            if (StkOutGuid != null)
            {
                STK_OutResult info = stkOutLogic.GetInfo(new STK_OutParam { StkOutGuid = StkOutGuid });
                this.ConvertEntityToControl<STK_OutResult>(this.stcpStkOut.Controls, info, null);
                if (info != null)
                {
                    txtAmount.Text = Math.Round(info.Amount.ToDecimal(), 3, MidpointRounding.AwayFromZero).ToStringHasNull();
                    txtSCAmount.Text = Math.Round(info.SCAmount.ToDecimal(), 3, MidpointRounding.AwayFromZero).ToStringHasNull();
                    txtTaxAmount.Text = Math.Round(info.TaxAmount.ToDecimal(), 3, MidpointRounding.AwayFromZero).ToStringHasNull();
                    txtExchangeRate.Text = Math.Round(info.ExchangeRate.ToDecimal(), 4, MidpointRounding.AwayFromZero).ToStringHasNull();
                    txtOperDeptName.Text = info.HR_DepartmentResult.DeptName;
                    if (info.StkOutLineList != null)
                        addOrModifyList = info.StkOutLineList;
                }

            }
            //新增
            else
            {
                txtOutDate.Text = DateTime.Now.ToStringHasNull();
                cboOperOrgID.SelectedValue=MySession.OrgID;
                txtOperDeptName.Text = MySession.DeptName;
                txtOperDeptID.Text = MySession.DeptID.ToStringHasNull();
                txtOperEmpID.Text = MySession.UserID.ToStringHasNull();
                txtOperEmpName.Text = MySession.UserName;
            }
            bsStkOutLine.DataSource = addOrModifyList;
            dgvStkOutLine.DataSource = bsStkOutLine;

        }
        #endregion

        void InitSourceData(string billType, Guid? sourceBillGuid)
        {
            
            switch (billType)
            { 
                case "SO_OUT":
                    ORD_SalesOrderResult orderResult = orderLogic.GetInfo(new ORD_SalesOrderParam() { SOGuid = sourceBillGuid });
                    InitSourceData(billType, orderResult);
                    break;
                case "POR_OUT":
                    ORD_PurchaseReturnResult returnResult = returnLogic.GetInfo(new ORD_PurchaseReturnParam() { PRGuid = sourceBillGuid });
                    InitSourceData(billType, returnResult);
                    break;
            }
        }

        public void InitSourceData(string billType, object obj)
        {
            if (obj != null)
            {
                if (cboBillType.SelectedValue.ToStringHasNull() == "")
                {
                    SYS_DictItemLineLogic.SetCombolSelectedIndex(cboBillType, billType, true);
                }
                if (obj is ORD_SalesOrderResult)
                {
                    ORD_SalesOrderResult salesOrderResult = obj as ORD_SalesOrderResult;
                    if (salesOrderResult != null)
                    {
                        txtSourceBillGuid.Text = salesOrderResult.SOGuid.ToStringHasNull();
                        txtSourceBillNo.Text = salesOrderResult.BillNo;
                        cboTaxRate.SelectedValue = salesOrderResult.TaxRate == null ? 0 : salesOrderResult.TaxRate;
                        cboCurrency.SelectedValue = salesOrderResult.Currency;
                        List<STK_StockReserveResult> reserveList = reserveLogic.GetList(new STK_StockReserveParam() { SourceBillGuid = salesOrderResult.SOGuid,IsUsedOver=false });
                        List<ORD_SalesOrderLineResult> lineList=null;
                        if (salesOrderResult.OrderLineList != null)//从其他窗体点击出库进入，只传递guid,通过guid获取的对象中含有明细
                            lineList = salesOrderResult.OrderLineList.Where(a => a.StkOutOccQty.ToInt32() < a.Qty).ToList();
                        else//在出库窗体打开选择窗体得到的对象是没有包含明细的，需要去单独获取明细
                            lineList = orderLineLogic.GetList(new ORD_SalesOrderLineParam() { SOGuid = salesOrderResult.SOGuid }).Where(a=>a.StkOutOccQty.ToInt32()<a.Qty).ToList();

                        foreach (STK_StockReserveResult reserveResult in reserveList)
                        {
                            STK_OutLineResult stkOutLineResult = new STK_OutLineResult();
                            ORD_SalesOrderLineResult lineResult = lineList.FirstOrDefault(a => a.SOLineGuid == reserveResult.SourceBillLineGuid);
                            if (lineResult != null)
                            {
                                stkOutLineResult.UnitPrice = lineResult.UnitPrice;
                            }
                            SetStkLineObjectValue(stkOutLineResult, reserveResult);
                            bsStkOutLine.Add(stkOutLineResult);

                        }
                    }
                }
                else if (obj is ORD_PurchaseReturnResult)
                {
                    ORD_PurchaseReturnResult purReturnResult = obj as ORD_PurchaseReturnResult;
                    if (purReturnResult != null)
                    {
                        txtSourceBillGuid.Text = purReturnResult.POGuid.ToStringHasNull();
                        txtSourceBillNo.Text = purReturnResult.BillNo;
                        decimal? taxRate = 0;
                        cboTaxRate.SelectedValue = taxRate;
                        cboCurrency.SelectedValue = purReturnResult.Currency;
                        List<STK_StockReserveResult> reserveList = reserveLogic.GetList(new STK_StockReserveParam() { SourceBillGuid = purReturnResult.PRGuid ,IsUsedOver = false });
                        List<ORD_PurchaseReturnLineResult> lineList = null;
                        if(purReturnResult.ReturnLineList!=null)
                            lineList = purReturnResult.ReturnLineList.Where(a => a.StkOutOccQty.ToInt32() < a.Qty).ToList();
                        else
                            lineList= returnLineLogic.GetList(new ORD_PurchaseReturnLineParam() { PRGuid = purReturnResult.PRGuid }).Where(a => a.StkOutOccQty.ToInt32() < a.Qty).ToList();

                        foreach (STK_StockReserveResult reserveResult in reserveList)
                        {
                            STK_OutLineResult stkOutLineResult = new STK_OutLineResult();
                            ORD_PurchaseReturnLineResult lineResult = lineList.FirstOrDefault(a => a.PRLineGuid == reserveResult.SourceBillLineGuid);
                            if (lineResult != null)
                            {
                                stkOutLineResult.UnitPrice = lineResult.UnitPrice;
                            }
                            SetStkLineObjectValue(stkOutLineResult, reserveResult);
                            bsStkOutLine.Add(stkOutLineResult);

                        }
                     
                    }
                }
                CalcExchangeRate();
            }
        }
       
        #region 币种选择
        private void cboBillType_TextChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvStkOutLine.Rows)
            {
                row.Cells["colCurrency"].Value = cboCurrency.SelectedValue;
            }
            
        }
        #endregion
        #region 出库日期改变
        private void txtOutDate_TextChanged(object sender, EventArgs e)
        {
            CalcExchangeRate();
        }
        #endregion

        #region 计算汇率
        private void CalcExchangeRate()
        {

            string currency = string.Empty;
            DateTime? dateTime = !string.IsNullOrEmpty(txtOutDate.Text) ? txtOutDate.Text.ToDateTime() : DateTime.Now;
            Dictionary<string, decimal?> exchaneRateDic = currencyLogic.GetExchaneRateDic(dateTime, null);
            foreach (DataGridViewRow row in dgvStkOutLine.Rows)
            {
                currency = row.Cells["colCurrency"].Value.ToStringHasNull();
                decimal? exchangeRate = exchaneRateDic.ContainsKey(currency) ? exchaneRateDic[currency] : 1;
                exchangeRate = Math.Round(exchangeRate.ToDecimal(), 4, MidpointRounding.AwayFromZero);
                row.Cells["colExchangeRate"].Value = exchangeRate.ToStringHasNull();
            }
        }
        #endregion
        #region 税率选择
        private void cboTaxRate_SelectedIndexChanged(object sender, EventArgs e)
        {
                decimal taxRate = 0.0m;
                taxRate = cboTaxRate.SelectedValue.ToDecimal() / 100;
                decimal taxAmount = 0.0m;
                decimal totalAmount = 0.0m;
                totalAmount = txtAmount.Text.ToDecimal();
                foreach (DataGridViewRow  row in dgvStkOutLine.Rows)
                {
                    row.Cells["colTaxRate"].Value = cboTaxRate.SelectedValue;
                }
                taxAmount = Math.Round(totalAmount * taxRate, 3, MidpointRounding.AwayFromZero);
                txtTaxAmount.Text = taxAmount.ToStringHasNull();
        }
        #endregion
        #region 归属部门选择
        private void txtOperDeptName_ButtonCustomClick(object sender, EventArgs e)
        {
            frmSelectDepartment frmSelectDepartment = new frmSelectDepartment(false);
            frmSelectDepartment.deptIds = txtOperDeptID.Text.Split(',').Select(a => (int?)a.ToInt32()).ToArray();
            frmSelectDepartment.OrgID = cboOperOrgID.SelectedValue.ToInt32();

            DialogResult rst = frmSelectDepartment.ShowDialog();
            if (rst == DialogResult.OK)
            {
                List<HR_DepartmentResult> rstList = frmSelectDepartment.GetSelectList<HR_DepartmentResult>();
                if (rstList != null && rstList.Count > 0)
                {

                    txtOperDeptID.Text = rstList[0].DeptID.ToStringHasNull();
                    txtOperDeptName.Text = rstList[0].DeptName;

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



        #region 源单据选择
        private void txtSourceBillNo_ButtonCustomClick(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cboBillType.SelectedValue.ToStringHasNull()))
            {
                DialogResult rst = DialogResult.Cancel;
                switch (cboBillType.SelectedValue.ToStringHasNull())
                {
                    case "SO_OUT":
                        frmSelectSalesOrder frmSelectSalesOrder = new frmSelectSalesOrder(false);
                        frmSelectSalesOrder.BringToFront();
                        frmSelectSalesOrder.StartPosition = FormStartPosition.CenterScreen;
                        rst = frmSelectSalesOrder.ShowDialog();
                        if (rst == DialogResult.OK)
                        {
                            List<ORD_SalesOrderResult> rstList = frmSelectSalesOrder.GetSelectList<ORD_SalesOrderResult>();
                            if (rstList != null && rstList.Count > 0)
                            {
                                ORD_SalesOrderResult orderResult=rstList[0];
                                InitSourceData("SO_OUT", orderResult);
                            }
                        }
                        break;
                    case "POR_OUT":
                        frmSelectPurchaseReturn frmSelectPurchaseReturn = new frmSelectPurchaseReturn(false);
                        frmSelectPurchaseReturn.BringToFront();
                        frmSelectPurchaseReturn.StartPosition = FormStartPosition.CenterScreen;
                        rst = frmSelectPurchaseReturn.ShowDialog();
                        if (rst == DialogResult.OK)
                        {
                            List<ORD_PurchaseReturnResult> rstList = frmSelectPurchaseReturn.GetSelectList<ORD_PurchaseReturnResult>();
                            if (rstList != null && rstList.Count > 0)
                            {
                                ORD_PurchaseReturnResult orderResult = rstList[0];
                                InitSourceData("POR_OUT", orderResult);
                            }
                        }
                        break;
                    case "ZX_OUT":
                        break;
                }
            }
            else
            {
                MessageBox.Show("请选择出库类型！");
            }
        }
        #endregion
        #region 导入预留明细
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
                    case "SO_OUT":
                    case "POR_OUT":
                        ImportStockReserve(isMutiSelect);
                        break;
                    case "ZX_OUT":
                        break;
                }
            }
            else
            {
                MessageBox.Show("请选择出库类型！");
            }
        }

        private void ImportStockReserve(bool isMutiSelect)
        {
            if (!string.IsNullOrEmpty(txtSourceBillGuid.Text))
            {
                frmSelectStockReserve frm = new frmSelectStockReserve(isMutiSelect);
                frm.SourceBillGuid = txtSourceBillGuid.Text.ToGuid();
               
                Guid? SourceBillLineGuid = Guid.Empty;
                Guid? SRGuid = Guid.Empty;
                string model = string.Empty;

                if (!isMutiSelect)
                {
                    SourceBillLineGuid = dgvStkOutLine.CurrentRow.Cells["colSourceBillLineGuid"].Value.ToGuid();
                    model = dgvStkOutLine.CurrentRow.Cells["colModel"].Value.ToStringHasNull();
                    SRGuid = dgvStkOutLine.CurrentRow.Cells["colSRGuid"].Value.ToGuid();
                }

                if (!string.IsNullOrEmpty(model))
                    frm.Model = model;
                if (SourceBillLineGuid != Guid.Empty)//如果已经存在关联的源单据明细ID，则只筛选此条明细
                    frm.SourceBillLineGuid = SourceBillLineGuid;
                if (SRGuid != Guid.Empty)//如果已经存在关联的预留ID，则只能筛选此条明细
                    frm.SRGuid = SRGuid;
                else//如果是新行，则排除掉已经存在列表里面的所有的源单据明细
                {
                    Guid?[] NoSRGuids = addOrModifyList.Where(a => a.SRGuid.ToGuid() != Guid.Empty).Select(a => a.SRGuid).Distinct().ToArray();
                    frm.NoSRGuids = NoSRGuids;
                }
                frm.BringToFront();
                frm.StartPosition = FormStartPosition.CenterScreen;
                DialogResult rst = frm.ShowDialog();
                if (rst == DialogResult.OK)
                {
                    List<STK_StockReserveResult> rstList = frm.GetSelectList<STK_StockReserveResult>();
                    if (rstList != null && rstList.Count > 0)
                    {
                        foreach (STK_StockReserveResult reserveResult in rstList)
                        {
                            bool isAddNew = true;
                            foreach (DataGridViewRow row in dgvStkOutLine.Rows)
                            {
                                //如果是已经存在的行，则利用现成的行进行编辑

                                if (row.Cells["colSRGuid"].Value.ToGuid() == reserveResult.SRGuid)
                                {
                                    isAddNew = false;
                                    STK_OutLineResult stkOutLineResult = bsStkOutLine[row.Index] as STK_OutLineResult;
                                    SetStkLineObjectValue(stkOutLineResult, reserveResult);
                                    break;
                                }
                            }
                            if (isAddNew)
                            {
                                if (!isMutiSelect)//单选
                                {
                                    STK_OutLineResult stkOutLineResult = bsStkOutLine.Current as STK_OutLineResult;
                                    SetStkLineObjectValue(stkOutLineResult, reserveResult);
                                }
                                else//多选
                                {
                                    STK_OutLineResult stkOutLineResult = new STK_OutLineResult();
                                    SetStkLineObjectValue(stkOutLineResult, reserveResult);
                                    bsStkOutLine.Add(stkOutLineResult);
                                }
                            }
                        }
                    }
                }
                dgvStkOutLine.EndEdit();
                CalcExchangeRate();
            }
            else
            {
                MessageBox.Show("请先选择源单据！");
            }
        }
        #endregion
        #region 给出库明细对象赋值
        public void SetStkLineObjectValue(STK_OutLineResult outLineRst, STK_StockReserveResult reserveResult)
        {
            
            outLineRst.SRGuid = reserveResult.SRGuid;
            outLineRst.StkInLineGuid = reserveResult.StkInLineGuid;
            outLineRst.ItemCode = reserveResult.ItemCode;
            outLineRst.SourceBillGuid = reserveResult.SourceBillGuid;
            outLineRst.SourceBillLineGuid = reserveResult.SourceBillLineGuid;
            outLineRst.Model = reserveResult.Model;
            outLineRst.Brand = reserveResult.Brand;
            outLineRst.Package = reserveResult.Package;
            outLineRst.Batch = reserveResult.Batch;
            outLineRst.TaxRate = cboTaxRate.SelectedValue.ToDecimal();
            outLineRst.InvType = reserveResult.InvType;
            outLineRst.Currency = cboCurrency.SelectedValue.ToStringHasNull();
            outLineRst.Unit = reserveResult.Unit;
            outLineRst.Qty = reserveResult.ReserveQty.ToInt32() - reserveResult.UsedQty.ToInt32();
            outLineRst.Amount = outLineRst.Qty * outLineRst.UnitPrice;
            outLineRst.Warehouse = reserveResult.Warehouse;
            outLineRst.Location = reserveResult.Location;
            outLineRst.IsCut = true;
            outLineRst.IsPCut = true;
            outLineRst.IsRaiseTaxes = false;
            outLineRst.IsDeleted = false;
        }
        #endregion
        #region 添加新行
        private void btnAddRow_Click(object sender, EventArgs e)
        {


            bsStkOutLine.AddNew();
            STK_OutLineResult rst = bsStkOutLine.Current as STK_OutLineResult;
            rst.Currency = cboCurrency.SelectedValue.ToStringHasNull();
            rst.ExchangeRate = txtExchangeRate.Text.ToDecimal();
            rst.Unit = "PCS";
            rst.TaxRate = cboTaxRate.SelectedValue.ToDecimal();


        }
        #endregion
        #region 删除一行
        private void btnDelRow_Click(object sender, EventArgs e)
        {
            if (this.bsStkOutLine.Current != null)
            {
                Guid? stkOutLineGuid = null;
                STK_OutLineResult delResult = this.bsStkOutLine.Current as STK_OutLineResult;
                stkOutLineGuid = delResult.StkOutLineGuid;
                if (stkOutLineGuid != null)
                {
                    delResult.IsDeleted = true;
                    delList.Add(delResult);
                }
                bsStkOutLine.RemoveCurrent();
            }
        }
        #endregion
        #region 表格相关事件
        private void dgvStkOutLine_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
          
        }

        private void dgvStkOutLine_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int qty = 0;
            decimal unitPrice = 0.0m;
            decimal exchangeRate = 0.0m;
            decimal amount = 0.0m;
            decimal scAmount = 0.0m;
            string currency = string.Empty;


            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                dgvStkOutLine.CellValueChanged -= new DataGridViewCellEventHandler(dgvStkOutLine_CellValueChanged);
                try
                {
                    string columnName = dgvStkOutLine.Columns[e.ColumnIndex].Name;
                    if (columnName == "colQty" || columnName=="colUnitPrice")
                    {
                        qty = dgvStkOutLine["colQty", e.RowIndex].Value.ToInt32();
                        unitPrice = dgvStkOutLine["colUnitPrice", e.RowIndex].Value.ToDecimal();
                        amount = Math.Round(qty * unitPrice, 3, MidpointRounding.AwayFromZero);
                        dgvStkOutLine["colAmount", e.RowIndex].Value = amount;
                        exchangeRate = dgvStkOutLine["colExchangeRate", e.RowIndex].Value.ToDecimal();
                        dgvStkOutLine["colSCAmount", e.RowIndex].Value = Math.Round(amount * exchangeRate, 3, MidpointRounding.AwayFromZero);
                    }
                    else if (columnName == "colCurrency")
                    {
                        DateTime? dateTime = !string.IsNullOrEmpty(txtOutDate.Text) ? txtOutDate.Text.ToDateTime() : DateTime.Now;
                        currency = dgvStkOutLine["colCurrency", e.RowIndex].Value.ToStringHasNull();
                        exchangeRate = currencyLogic.GetExchangeRate(dateTime, currency).ToDecimal();
                        exchangeRate = Math.Round(exchangeRate.ToDecimal(), 4, MidpointRounding.AwayFromZero);
                        dgvStkOutLine["colExchangeRate", e.RowIndex].Value = exchangeRate.ToStringHasNull();
                        amount = dgvStkOutLine["colAmount", e.RowIndex].Value.ToDecimal();
                        scAmount = Math.Round((amount * exchangeRate).ToDecimal(), 3, MidpointRounding.AwayFromZero);
                        dgvStkOutLine["colSCAmount", e.RowIndex].Value = scAmount;
                    }
                    else if (columnName == "colExchangeRate")
                    {
                        exchangeRate = dgvStkOutLine["colExchangeRate", e.RowIndex].Value.ToDecimal();
                        amount = dgvStkOutLine["colAmount", e.RowIndex].Value.ToDecimal();
                        scAmount = Math.Round((amount * exchangeRate).ToDecimal(), 3, MidpointRounding.AwayFromZero);
                        dgvStkOutLine["colSCAmount", e.RowIndex].Value = scAmount;
                    }
                   
                    bsStkOutLine.EndEdit();
                    CalcAmount();
                }
                finally
                {
                    dgvStkOutLine.CellValueChanged += new DataGridViewCellEventHandler(dgvStkOutLine_CellValueChanged);
                }

            }
        }

        private void dgvStkOutLine_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }

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
        #endregion
        #region 汇总计算
        private void CalcAmount()
        {
            decimal totalAmount = 0.0m;
            decimal taxAmount = 0.0m;
            decimal taxRate = 0.0m;
            decimal scAmount = 0.0m;
            taxRate = cboTaxRate.SelectedValue.ToDecimal() / 100;
            foreach (DataGridViewRow row in dgvStkOutLine.Rows)
            {
                totalAmount += (row.Cells["colUnitPrice"].Value.ToDecimal()) * row.Cells["colQty"].Value.ToDecimal();
                scAmount += row.Cells["colSCAmount"].Value.ToDecimal();
            }
      
            totalAmount = Math.Round(totalAmount, 3, MidpointRounding.AwayFromZero);
            taxAmount = Math.Round(totalAmount * taxRate, 3, MidpointRounding.AwayFromZero);
            scAmount = Math.Round(scAmount, 3, MidpointRounding.AwayFromZero);
            txtAmount.Text = totalAmount.ToStringHasNull();
            txtTaxAmount.Text = taxAmount.ToStringHasNull();
            txtSCAmount.Text = scAmount.ToStringHasNull();



        }
        #endregion

        private void tsbSave_Click(object sender, EventArgs e)
        {
            STK_OutResult info = Form_GetEditEntity() as STK_OutResult;
            if (!this.DataIsChanged)
            {
                this.ShowNoChangedMsg();
                return;
            }
            bool flag = false;
            foreach (STK_OutLineResult rst in addOrModifyList)
            {
                if (string.IsNullOrEmpty(rst.Model) || rst.UnitPrice.ToDecimal() <= 0 || rst.Qty.ToInt32() <= 0)
                {
                    flag = true;
                    break;
                }
            }

            bsStkOutLine.EndEdit();
            tempList.Clear();
            foreach (STK_OutLineResult rst in addOrModifyList)
            {
                if (rst.HasChanged())
                {
                    tempList.Add(rst);
                }
            }
            //tempList.AddRange(addOrModifyList);
            tempList.AddRange(delList);
            info.StkOutLineList = tempList;
            WCFAddUpdateResult result = this.AsyncExecute<WCFAddUpdateResult, STK_OutResult>(info, stkOutLogic.AddOrUpdate, (a) =>
            {
                if (a.KeyGuid.ToGuid() != Guid.Empty)
                {
                    StkOutGuid = a.KeyGuid.ToGuid();
              
                    if (SaveAttach != null)
                        SaveAttach("STK_Out", StkOutGuid.ToGuid(), a.BillNo);
                    InitData();
                    delList.Clear();
                }
            });
        }

        private void tsbSubmit_Click(object sender, EventArgs e)
        {
           
            tsbSave_Click(sender, e);
            bool flag = stkOutLogic.SubmitStkOutBill(new STK_OutParam() { StkOutGuid = StkOutGuid });
            if(flag)
            {
                InitData();
            }
        }

        private void tsbAudit_Click(object sender, EventArgs e)
        {
            
            bool flag = stkOutLogic.AuditStkOutBill(new STK_OutParam() { StkOutGuid = StkOutGuid });
            if (flag)
            {
                InitData();
            }
        }

        private void dgvStkOutLine_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
