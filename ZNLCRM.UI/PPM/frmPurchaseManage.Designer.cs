namespace ZNLCRM.UI.PPM
{
    partial class frmPurchaseManage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPurchaseManage));
            this.ucToolStrip1 = new ZNLCRM.Controls.UcToolStrip(this.components);
            this.tsbAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbDel = new System.Windows.Forms.ToolStripButton();
            this.tsbPrint = new System.Windows.Forms.ToolStripButton();
            this.tlbAuditBill = new System.Windows.Forms.ToolStripButton();
            this.tlbCancelBill = new System.Windows.Forms.ToolStripButton();
            this.ucPanel4 = new ZNLCRM.Controls.UcPanel(this.components);
            this.ucPanel2 = new ZNLCRM.Controls.UcPanel(this.components);
            this.tabPurchase = new ZNLCRM.Controls.UcSuperTabControl(this.components);
            this.tbpMast = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.panMast = new ZNLCRM.Controls.UcPanel(this.components);
            this.dgvPurchaseOrder = new ZNLCRM.Controls.UcDataGridView(this.components);
            this.colSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colOperIn = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colPOID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPOGuid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBillNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPODate = new DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn();
            this.colInvType = new DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn();
            this.colSupplierName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPurOrgID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPurOrgName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPurDeptID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPurDeptName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBuyerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBuyerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCurrency = new DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn();
            this.colClearingForm = new DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn();
            this.colTaxRate = new DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNeedPayAmtDate = new DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn();
            this.colNeedDeliveryDate = new DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn();
            this.colAllStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStkInStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReturnOccStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApproveStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRemark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreatedEmpID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreatedEmpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreatedTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panMastPage = new ZNLCRM.Controls.UcPanel(this.components);
            this.pgPurchaseOrder = new ZNLCRM.Controls.UcPager();
            this.expandableSplitter2 = new DevComponents.DotNetBar.ExpandableSplitter();
            this.panMastWhere = new ZNLCRM.Controls.UcPanel(this.components);
            this.btnSearch = new ZNLCRM.Controls.UcButton(this.components);
            this.tbiMast = new DevComponents.DotNetBar.SuperTabItem();
            this.tbpDtl = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.expandableSplitter1 = new DevComponents.DotNetBar.ExpandableSplitter();
            this.panDtl = new ZNLCRM.Controls.UcPanel(this.components);
            this.dgvDtl = new ZNLCRM.Controls.UcDataGridView(this.components);
            this.colDtlOper = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colDtlPOID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDtlPOGuid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDtlPOLineGuid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDtlAllStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDtlBillNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDtlPODate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDtlModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDtlBrand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDtlPackage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDtlBatch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDtlQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDtlUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDtlAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDtlStkInQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDtlStkOutQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDtlBuyerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDtlCurrency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDtlTaxRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDtlNeedPayAmtDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDtlNeedDeliveryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDtlStkInStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDtlApproveStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDtlIsCancelName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDtlIsCancel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDtlStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panDtlPage = new ZNLCRM.Controls.UcPanel(this.components);
            this.pagDtl = new ZNLCRM.Controls.UcPager();
            this.panDtlWhere = new ZNLCRM.Controls.UcPanel(this.components);
            this.btnDtlSearch = new ZNLCRM.Controls.UcButton(this.components);
            this.tbiDtl = new DevComponents.DotNetBar.SuperTabItem();
            this.dataGridViewButtonXColumn1 = new DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn();
            this.采购单明细列表 = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel1 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.ucToolStrip1.SuspendLayout();
            this.ucPanel4.SuspendLayout();
            this.ucPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabPurchase)).BeginInit();
            this.tabPurchase.SuspendLayout();
            this.tbpMast.SuspendLayout();
            this.panMast.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseOrder)).BeginInit();
            this.panMastPage.SuspendLayout();
            this.panMastWhere.SuspendLayout();
            this.tbpDtl.SuspendLayout();
            this.panDtl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDtl)).BeginInit();
            this.panDtlPage.SuspendLayout();
            this.panDtlWhere.SuspendLayout();
            this.SuspendLayout();
            // 
            // ucToolStrip1
            // 
            this.ucToolStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ucToolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucToolStrip1.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.ucToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAdd,
            this.tsbEdit,
            this.tsbDel,
            this.tsbPrint,
            this.tlbAuditBill,
            this.tlbCancelBill});
            this.ucToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.ucToolStrip1.Name = "ucToolStrip1";
            this.ucToolStrip1.Padding = new System.Windows.Forms.Padding(5);
            this.ucToolStrip1.Size = new System.Drawing.Size(1030, 37);
            this.ucToolStrip1.TabIndex = 0;
            this.ucToolStrip1.Text = "ucToolStrip1";
            // 
            // tsbAdd
            // 
            this.tsbAdd.Image = global::ZNLCRM.UI.Properties.Resources.add_1;
            this.tsbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdd.Name = "tsbAdd";
            this.tsbAdd.Size = new System.Drawing.Size(55, 24);
            this.tsbAdd.Text = "新增";
            this.tsbAdd.ToolTipText = "添加新的采购单";
            this.tsbAdd.Click += new System.EventHandler(this.tsbAdd_Click);
            // 
            // tsbEdit
            // 
            this.tsbEdit.Image = global::ZNLCRM.UI.Properties.Resources.edit_1;
            this.tsbEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEdit.Name = "tsbEdit";
            this.tsbEdit.Size = new System.Drawing.Size(55, 24);
            this.tsbEdit.Text = "修改";
            this.tsbEdit.Click += new System.EventHandler(this.tsbEdit_Click);
            // 
            // tsbDel
            // 
            this.tsbDel.Image = global::ZNLCRM.UI.Properties.Resources.del_1;
            this.tsbDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDel.Name = "tsbDel";
            this.tsbDel.Size = new System.Drawing.Size(55, 24);
            this.tsbDel.Text = "删除";
            this.tsbDel.Click += new System.EventHandler(this.tsbDel_Click);
            // 
            // tsbPrint
            // 
            this.tsbPrint.Image = global::ZNLCRM.UI.Properties.Resources.print_1;
            this.tsbPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPrint.Name = "tsbPrint";
            this.tsbPrint.Size = new System.Drawing.Size(55, 24);
            this.tsbPrint.Text = "打印";
            // 
            // tlbAuditBill
            // 
            this.tlbAuditBill.Image = global::ZNLCRM.UI.Properties.Resources.checkok;
            this.tlbAuditBill.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlbAuditBill.Name = "tlbAuditBill";
            this.tlbAuditBill.Size = new System.Drawing.Size(55, 24);
            this.tlbAuditBill.Text = "审核";
            this.tlbAuditBill.Click += new System.EventHandler(this.tlbAuditBill_Click);
            // 
            // tlbCancelBill
            // 
            this.tlbCancelBill.Image = global::ZNLCRM.UI.Properties.Resources.cancel_1;
            this.tlbCancelBill.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlbCancelBill.Name = "tlbCancelBill";
            this.tlbCancelBill.Size = new System.Drawing.Size(55, 24);
            this.tlbCancelBill.Text = "撤单";
            this.tlbCancelBill.Click += new System.EventHandler(this.tlbCancelBill_Click);
            // 
            // ucPanel4
            // 
            this.ucPanel4.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel4.Controls.Add(this.ucToolStrip1);
            this.ucPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucPanel4.Location = new System.Drawing.Point(0, 0);
            this.ucPanel4.Name = "ucPanel4";
            this.ucPanel4.Size = new System.Drawing.Size(1030, 37);
            this.ucPanel4.TabIndex = 4;
            // 
            // ucPanel2
            // 
            this.ucPanel2.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel2.Controls.Add(this.tabPurchase);
            this.ucPanel2.Controls.Add(this.ucPanel4);
            this.ucPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPanel2.Location = new System.Drawing.Point(0, 0);
            this.ucPanel2.Name = "ucPanel2";
            this.ucPanel2.Size = new System.Drawing.Size(1030, 482);
            this.ucPanel2.TabIndex = 3;
            // 
            // tabPurchase
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tabPurchase.ControlBox.CloseBox.Name = "";
            // 
            // 
            // 
            this.tabPurchase.ControlBox.MenuBox.Name = "";
            this.tabPurchase.ControlBox.Name = "";
            this.tabPurchase.ControlBox.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.tabPurchase.ControlBox.MenuBox,
            this.tabPurchase.ControlBox.CloseBox});
            this.tabPurchase.Controls.Add(this.tbpMast);
            this.tabPurchase.Controls.Add(this.tbpDtl);
            this.tabPurchase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPurchase.Location = new System.Drawing.Point(0, 37);
            this.tabPurchase.Name = "tabPurchase";
            this.tabPurchase.ReorderTabsEnabled = true;
            this.tabPurchase.SelectedTabFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold);
            this.tabPurchase.SelectedTabIndex = 1;
            this.tabPurchase.Size = new System.Drawing.Size(1030, 445);
            this.tabPurchase.TabFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPurchase.TabIndex = 6;
            this.tabPurchase.Tabs.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.tbiDtl,
            this.tbiMast});
            this.tabPurchase.Text = "ucSuperTabControl1";
            // 
            // tbpMast
            // 
            this.tbpMast.Controls.Add(this.panMast);
            this.tbpMast.Controls.Add(this.panMastPage);
            this.tbpMast.Controls.Add(this.expandableSplitter2);
            this.tbpMast.Controls.Add(this.panMastWhere);
            this.tbpMast.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbpMast.Location = new System.Drawing.Point(0, 28);
            this.tbpMast.Name = "tbpMast";
            this.tbpMast.Size = new System.Drawing.Size(1030, 417);
            this.tbpMast.TabIndex = 1;
            this.tbpMast.TabItem = this.tbiMast;
            // 
            // panMast
            // 
            this.panMast.BackColor = System.Drawing.Color.Transparent;
            this.panMast.Controls.Add(this.dgvPurchaseOrder);
            this.panMast.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panMast.Location = new System.Drawing.Point(0, 34);
            this.panMast.Name = "panMast";
            this.panMast.Padding = new System.Windows.Forms.Padding(5);
            this.panMast.Size = new System.Drawing.Size(1030, 353);
            this.panMast.TabIndex = 9;
            // 
            // dgvPurchaseOrder
            // 
            this.dgvPurchaseOrder.AllowUserToAddRows = false;
            this.dgvPurchaseOrder.AllowUserToDeleteRows = false;
            this.dgvPurchaseOrder.AllowUserToOrderColumns = true;
            this.dgvPurchaseOrder.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPurchaseOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPurchaseOrder.ColumnHeadersHeight = 30;
            this.dgvPurchaseOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSelect,
            this.colOperIn,
            this.colPOID,
            this.colPOGuid,
            this.colBillNo,
            this.colPODate,
            this.colInvType,
            this.colSupplierName,
            this.colPurOrgID,
            this.colPurOrgName,
            this.colPurDeptID,
            this.colPurDeptName,
            this.colBuyerID,
            this.colBuyerName,
            this.colCurrency,
            this.colClearingForm,
            this.colTaxRate,
            this.colAmount,
            this.colNeedPayAmtDate,
            this.colNeedDeliveryDate,
            this.colAllStatus,
            this.colStkInStatus,
            this.colReturnOccStatus,
            this.colApproveStatus,
            this.colRemark,
            this.colCreatedEmpID,
            this.colStatus,
            this.colCreatedEmpName,
            this.colCreatedTime});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPurchaseOrder.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPurchaseOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPurchaseOrder.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvPurchaseOrder.HighlightSelectedColumnHeaders = false;
            this.dgvPurchaseOrder.Location = new System.Drawing.Point(5, 5);
            this.dgvPurchaseOrder.Name = "dgvPurchaseOrder";
            this.dgvPurchaseOrder.PaintEnhancedSelection = false;
            this.dgvPurchaseOrder.ReadOnly = true;
            this.dgvPurchaseOrder.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPurchaseOrder.RowTemplate.Height = 23;
            this.dgvPurchaseOrder.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPurchaseOrder.SelectAllSignVisible = false;
            this.dgvPurchaseOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvPurchaseOrder.Size = new System.Drawing.Size(1020, 343);
            this.dgvPurchaseOrder.TabIndex = 0;
            this.dgvPurchaseOrder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPurchaseOrder_CellContentClick);
            this.dgvPurchaseOrder.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPurchaseOrder_CellDoubleClick);
            this.dgvPurchaseOrder.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvPurchaseOrder_DataBindingComplete);
            this.dgvPurchaseOrder.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPurchaseOrder_RowEnter);
            // 
            // colSelect
            // 
            this.colSelect.HeaderText = "选？";
            this.colSelect.Name = "colSelect";
            this.colSelect.ReadOnly = true;
            this.colSelect.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colSelect.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colSelect.Visible = false;
            this.colSelect.Width = 35;
            // 
            // colOperIn
            // 
            this.colOperIn.HeaderText = "操作";
            this.colOperIn.Name = "colOperIn";
            this.colOperIn.ReadOnly = true;
            this.colOperIn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colOperIn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colOperIn.Width = 60;
            // 
            // colPOID
            // 
            this.colPOID.DataPropertyName = "POID";
            this.colPOID.HeaderText = "POID";
            this.colPOID.Name = "colPOID";
            this.colPOID.ReadOnly = true;
            this.colPOID.Visible = false;
            // 
            // colPOGuid
            // 
            this.colPOGuid.DataPropertyName = "POGuid";
            this.colPOGuid.HeaderText = "POGuid";
            this.colPOGuid.Name = "colPOGuid";
            this.colPOGuid.ReadOnly = true;
            this.colPOGuid.Visible = false;
            // 
            // colBillNo
            // 
            this.colBillNo.DataPropertyName = "BillNo";
            this.colBillNo.HeaderText = "单据编号";
            this.colBillNo.Name = "colBillNo";
            this.colBillNo.ReadOnly = true;
            // 
            // colPODate
            // 
            // 
            // 
            // 
            this.colPODate.BackgroundStyle.Class = "DataGridViewDateTimeBorder";
            this.colPODate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.colPODate.CustomFormat = "yyyy-MM-dd";
            this.colPODate.DataPropertyName = "PODate";
            this.colPODate.Format = DevComponents.Editors.eDateTimePickerFormat.Custom;
            this.colPODate.HeaderText = "采购日期";
            this.colPODate.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left;
            // 
            // 
            // 
            this.colPODate.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.colPODate.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.colPODate.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            // 
            // 
            // 
            this.colPODate.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.colPODate.MonthCalendar.DisplayMonth = new System.DateTime(2015, 2, 1, 0, 0, 0, 0);
            this.colPODate.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.colPODate.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.colPODate.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.colPODate.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.colPODate.Name = "colPODate";
            this.colPODate.ReadOnly = true;
            this.colPODate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colInvType
            // 
            this.colInvType.DataPropertyName = "InvType";
            this.colInvType.DropDownHeight = 106;
            this.colInvType.DropDownWidth = 121;
            this.colInvType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colInvType.HeaderText = "库存类型";
            this.colInvType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.colInvType.IntegralHeight = false;
            this.colInvType.ItemHeight = 16;
            this.colInvType.Name = "colInvType";
            this.colInvType.ReadOnly = true;
            this.colInvType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colInvType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.colInvType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colSupplierName
            // 
            this.colSupplierName.DataPropertyName = "SupplierName";
            this.colSupplierName.HeaderText = "供应商名称";
            this.colSupplierName.Name = "colSupplierName";
            this.colSupplierName.ReadOnly = true;
            this.colSupplierName.Width = 150;
            // 
            // colPurOrgID
            // 
            this.colPurOrgID.DataPropertyName = "PurOrgID";
            this.colPurOrgID.HeaderText = "采购机构ID";
            this.colPurOrgID.Name = "colPurOrgID";
            this.colPurOrgID.ReadOnly = true;
            this.colPurOrgID.Visible = false;
            // 
            // colPurOrgName
            // 
            this.colPurOrgName.DataPropertyName = "PurOrgName";
            this.colPurOrgName.HeaderText = "采购机构";
            this.colPurOrgName.Name = "colPurOrgName";
            this.colPurOrgName.ReadOnly = true;
            // 
            // colPurDeptID
            // 
            this.colPurDeptID.DataPropertyName = "PurDeptID";
            this.colPurDeptID.HeaderText = "采购部门ID";
            this.colPurDeptID.Name = "colPurDeptID";
            this.colPurDeptID.ReadOnly = true;
            this.colPurDeptID.Visible = false;
            // 
            // colPurDeptName
            // 
            this.colPurDeptName.DataPropertyName = "PurDeptName";
            this.colPurDeptName.HeaderText = "采购部门";
            this.colPurDeptName.Name = "colPurDeptName";
            this.colPurDeptName.ReadOnly = true;
            // 
            // colBuyerID
            // 
            this.colBuyerID.DataPropertyName = "BuyerID";
            this.colBuyerID.HeaderText = "采购员ID";
            this.colBuyerID.Name = "colBuyerID";
            this.colBuyerID.ReadOnly = true;
            this.colBuyerID.Visible = false;
            // 
            // colBuyerName
            // 
            this.colBuyerName.DataPropertyName = "BuyerName";
            this.colBuyerName.HeaderText = "采购员";
            this.colBuyerName.Name = "colBuyerName";
            this.colBuyerName.ReadOnly = true;
            // 
            // colCurrency
            // 
            this.colCurrency.DataPropertyName = "Currency";
            this.colCurrency.DropDownHeight = 106;
            this.colCurrency.DropDownWidth = 121;
            this.colCurrency.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colCurrency.HeaderText = "币种";
            this.colCurrency.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.colCurrency.IntegralHeight = false;
            this.colCurrency.ItemHeight = 16;
            this.colCurrency.Name = "colCurrency";
            this.colCurrency.ReadOnly = true;
            this.colCurrency.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colCurrency.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // colClearingForm
            // 
            this.colClearingForm.DataPropertyName = "ClearingForm";
            this.colClearingForm.DropDownHeight = 106;
            this.colClearingForm.DropDownWidth = 121;
            this.colClearingForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colClearingForm.HeaderText = "结算方式";
            this.colClearingForm.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.colClearingForm.IntegralHeight = false;
            this.colClearingForm.ItemHeight = 16;
            this.colClearingForm.Name = "colClearingForm";
            this.colClearingForm.ReadOnly = true;
            this.colClearingForm.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colClearingForm.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // colTaxRate
            // 
            this.colTaxRate.DataPropertyName = "TaxRate";
            this.colTaxRate.DropDownHeight = 106;
            this.colTaxRate.DropDownWidth = 121;
            this.colTaxRate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colTaxRate.HeaderText = "税率";
            this.colTaxRate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.colTaxRate.IntegralHeight = false;
            this.colTaxRate.ItemHeight = 16;
            this.colTaxRate.Name = "colTaxRate";
            this.colTaxRate.ReadOnly = true;
            this.colTaxRate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colTaxRate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.colTaxRate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colAmount
            // 
            this.colAmount.DataPropertyName = "Amount";
            this.colAmount.HeaderText = "采购金额";
            this.colAmount.Name = "colAmount";
            this.colAmount.ReadOnly = true;
            // 
            // colNeedPayAmtDate
            // 
            // 
            // 
            // 
            this.colNeedPayAmtDate.BackgroundStyle.Class = "DataGridViewDateTimeBorder";
            this.colNeedPayAmtDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.colNeedPayAmtDate.CustomFormat = "yyyy-MM-dd";
            this.colNeedPayAmtDate.DataPropertyName = "NeedPayAmtDate";
            this.colNeedPayAmtDate.Format = DevComponents.Editors.eDateTimePickerFormat.Custom;
            this.colNeedPayAmtDate.HeaderText = "需付款日期";
            this.colNeedPayAmtDate.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left;
            // 
            // 
            // 
            this.colNeedPayAmtDate.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.colNeedPayAmtDate.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.colNeedPayAmtDate.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            // 
            // 
            // 
            this.colNeedPayAmtDate.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.colNeedPayAmtDate.MonthCalendar.DisplayMonth = new System.DateTime(2015, 2, 1, 0, 0, 0, 0);
            this.colNeedPayAmtDate.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.colNeedPayAmtDate.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.colNeedPayAmtDate.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.colNeedPayAmtDate.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.colNeedPayAmtDate.Name = "colNeedPayAmtDate";
            this.colNeedPayAmtDate.ReadOnly = true;
            this.colNeedPayAmtDate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colNeedDeliveryDate
            // 
            // 
            // 
            // 
            this.colNeedDeliveryDate.BackgroundStyle.Class = "DataGridViewDateTimeBorder";
            this.colNeedDeliveryDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.colNeedDeliveryDate.CustomFormat = "yyyy-MM-dd";
            this.colNeedDeliveryDate.DataPropertyName = "NeedDeliveryDate";
            this.colNeedDeliveryDate.Format = DevComponents.Editors.eDateTimePickerFormat.Custom;
            this.colNeedDeliveryDate.HeaderText = "需到货日期";
            this.colNeedDeliveryDate.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left;
            // 
            // 
            // 
            this.colNeedDeliveryDate.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.colNeedDeliveryDate.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.colNeedDeliveryDate.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            // 
            // 
            // 
            this.colNeedDeliveryDate.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.colNeedDeliveryDate.MonthCalendar.DisplayMonth = new System.DateTime(2015, 2, 1, 0, 0, 0, 0);
            this.colNeedDeliveryDate.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.colNeedDeliveryDate.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.colNeedDeliveryDate.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.colNeedDeliveryDate.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.colNeedDeliveryDate.Name = "colNeedDeliveryDate";
            this.colNeedDeliveryDate.ReadOnly = true;
            this.colNeedDeliveryDate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colAllStatus
            // 
            this.colAllStatus.DataPropertyName = "AllStatus";
            this.colAllStatus.HeaderText = "业务状态";
            this.colAllStatus.Name = "colAllStatus";
            this.colAllStatus.ReadOnly = true;
            // 
            // colStkInStatus
            // 
            this.colStkInStatus.DataPropertyName = "StkInStatus";
            this.colStkInStatus.HeaderText = "入库状态";
            this.colStkInStatus.Name = "colStkInStatus";
            this.colStkInStatus.ReadOnly = true;
            this.colStkInStatus.Visible = false;
            // 
            // colReturnOccStatus
            // 
            this.colReturnOccStatus.DataPropertyName = "ReturnOccStatus";
            this.colReturnOccStatus.HeaderText = "退货占有状态";
            this.colReturnOccStatus.Name = "colReturnOccStatus";
            this.colReturnOccStatus.ReadOnly = true;
            // 
            // colApproveStatus
            // 
            this.colApproveStatus.DataPropertyName = "ApproveStatus";
            this.colApproveStatus.HeaderText = "单据状态";
            this.colApproveStatus.Name = "colApproveStatus";
            this.colApproveStatus.ReadOnly = true;
            // 
            // colRemark
            // 
            this.colRemark.DataPropertyName = "Remark";
            this.colRemark.HeaderText = "备注";
            this.colRemark.Name = "colRemark";
            this.colRemark.ReadOnly = true;
            // 
            // colCreatedEmpID
            // 
            this.colCreatedEmpID.DataPropertyName = "CreatedEmpID";
            this.colCreatedEmpID.HeaderText = "创建人员ID";
            this.colCreatedEmpID.Name = "colCreatedEmpID";
            this.colCreatedEmpID.ReadOnly = true;
            this.colCreatedEmpID.Visible = false;
            // 
            // colStatus
            // 
            this.colStatus.DataPropertyName = "Status";
            this.colStatus.HeaderText = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            this.colStatus.Visible = false;
            // 
            // colCreatedEmpName
            // 
            this.colCreatedEmpName.DataPropertyName = "CreatedEmpName";
            this.colCreatedEmpName.HeaderText = "创建人员";
            this.colCreatedEmpName.Name = "colCreatedEmpName";
            this.colCreatedEmpName.ReadOnly = true;
            // 
            // colCreatedTime
            // 
            this.colCreatedTime.DataPropertyName = "CreatedTime";
            this.colCreatedTime.HeaderText = "创建时间";
            this.colCreatedTime.Name = "colCreatedTime";
            this.colCreatedTime.ReadOnly = true;
            // 
            // panMastPage
            // 
            this.panMastPage.BackColor = System.Drawing.Color.Transparent;
            this.panMastPage.Controls.Add(this.pgPurchaseOrder);
            this.panMastPage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panMastPage.Location = new System.Drawing.Point(0, 387);
            this.panMastPage.Name = "panMastPage";
            this.panMastPage.Size = new System.Drawing.Size(1030, 30);
            this.panMastPage.TabIndex = 9;
            // 
            // pgPurchaseOrder
            // 
            this.pgPurchaseOrder.BackColor = System.Drawing.Color.Transparent;
            this.pgPurchaseOrder.Location = new System.Drawing.Point(14, 7);
            this.pgPurchaseOrder.Name = "pgPurchaseOrder";
            this.pgPurchaseOrder.RecordCount = 0;
            this.pgPurchaseOrder.Size = new System.Drawing.Size(195, 15);
            this.pgPurchaseOrder.TabIndex = 0;
            this.pgPurchaseOrder.PageIndexChanged += new System.EventHandler(this.pgPurchaseOrder_PageIndexChanged);
            // 
            // expandableSplitter2
            // 
            this.expandableSplitter2.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207)))));
            this.expandableSplitter2.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter2.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandableSplitter2.Dock = System.Windows.Forms.DockStyle.Top;
            this.expandableSplitter2.ExpandFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207)))));
            this.expandableSplitter2.ExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter2.ExpandLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.expandableSplitter2.ExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandableSplitter2.GripDarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.expandableSplitter2.GripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandableSplitter2.GripLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.expandableSplitter2.GripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.expandableSplitter2.HotBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(151)))), ((int)(((byte)(61)))));
            this.expandableSplitter2.HotBackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(94)))));
            this.expandableSplitter2.HotBackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground2;
            this.expandableSplitter2.HotBackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground;
            this.expandableSplitter2.HotExpandFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207)))));
            this.expandableSplitter2.HotExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter2.HotExpandLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.expandableSplitter2.HotExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandableSplitter2.HotGripDarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207)))));
            this.expandableSplitter2.HotGripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter2.HotGripLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.expandableSplitter2.HotGripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.expandableSplitter2.Location = new System.Drawing.Point(0, 31);
            this.expandableSplitter2.Name = "expandableSplitter2";
            this.expandableSplitter2.Size = new System.Drawing.Size(1030, 3);
            this.expandableSplitter2.Style = DevComponents.DotNetBar.eSplitterStyle.Office2007;
            this.expandableSplitter2.TabIndex = 8;
            this.expandableSplitter2.TabStop = false;
            // 
            // panMastWhere
            // 
            this.panMastWhere.BackColor = System.Drawing.Color.Transparent;
            this.panMastWhere.Controls.Add(this.btnSearch);
            this.panMastWhere.Dock = System.Windows.Forms.DockStyle.Top;
            this.panMastWhere.Location = new System.Drawing.Point(0, 0);
            this.panMastWhere.Name = "panMastWhere";
            this.panMastWhere.Size = new System.Drawing.Size(1030, 31);
            this.panMastWhere.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSearch.Image = global::ZNLCRM.UI.Properties.Resources.search;
            this.btnSearch.Location = new System.Drawing.Point(5, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "搜索";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbiMast
            // 
            this.tbiMast.AttachedControl = this.tbpMast;
            this.tbiMast.GlobalItem = false;
            this.tbiMast.Name = "tbiMast";
            this.tbiMast.Text = "采购订单列表";
            // 
            // tbpDtl
            // 
            this.tbpDtl.Controls.Add(this.expandableSplitter1);
            this.tbpDtl.Controls.Add(this.panDtl);
            this.tbpDtl.Controls.Add(this.panDtlPage);
            this.tbpDtl.Controls.Add(this.panDtlWhere);
            this.tbpDtl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbpDtl.Location = new System.Drawing.Point(0, 28);
            this.tbpDtl.Name = "tbpDtl";
            this.tbpDtl.Size = new System.Drawing.Size(1030, 417);
            this.tbpDtl.TabIndex = 1;
            this.tbpDtl.TabItem = this.tbiDtl;
            // 
            // expandableSplitter1
            // 
            this.expandableSplitter1.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207)))));
            this.expandableSplitter1.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter1.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandableSplitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.expandableSplitter1.ExpandFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207)))));
            this.expandableSplitter1.ExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter1.ExpandLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.expandableSplitter1.ExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandableSplitter1.GripDarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.expandableSplitter1.GripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandableSplitter1.GripLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.expandableSplitter1.GripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.expandableSplitter1.HotBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(151)))), ((int)(((byte)(61)))));
            this.expandableSplitter1.HotBackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(94)))));
            this.expandableSplitter1.HotBackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground2;
            this.expandableSplitter1.HotBackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground;
            this.expandableSplitter1.HotExpandFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207)))));
            this.expandableSplitter1.HotExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter1.HotExpandLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.expandableSplitter1.HotExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandableSplitter1.HotGripDarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207)))));
            this.expandableSplitter1.HotGripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter1.HotGripLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.expandableSplitter1.HotGripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.expandableSplitter1.Location = new System.Drawing.Point(0, 31);
            this.expandableSplitter1.Name = "expandableSplitter1";
            this.expandableSplitter1.Size = new System.Drawing.Size(1030, 3);
            this.expandableSplitter1.Style = DevComponents.DotNetBar.eSplitterStyle.Office2007;
            this.expandableSplitter1.TabIndex = 8;
            this.expandableSplitter1.TabStop = false;
            // 
            // panDtl
            // 
            this.panDtl.BackColor = System.Drawing.Color.Transparent;
            this.panDtl.Controls.Add(this.dgvDtl);
            this.panDtl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panDtl.Location = new System.Drawing.Point(0, 31);
            this.panDtl.Name = "panDtl";
            this.panDtl.Padding = new System.Windows.Forms.Padding(5);
            this.panDtl.Size = new System.Drawing.Size(1030, 356);
            this.panDtl.TabIndex = 6;
            // 
            // dgvDtl
            // 
            this.dgvDtl.AllowUserToAddRows = false;
            this.dgvDtl.AllowUserToDeleteRows = false;
            this.dgvDtl.AllowUserToOrderColumns = true;
            this.dgvDtl.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDtl.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDtl.ColumnHeadersHeight = 30;
            this.dgvDtl.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDtlOper,
            this.colDtlPOID,
            this.colDtlPOGuid,
            this.colDtlPOLineGuid,
            this.colDtlAllStatus,
            this.colDtlBillNo,
            this.colDtlPODate,
            this.colDtlModel,
            this.colDtlBrand,
            this.colDtlPackage,
            this.colDtlBatch,
            this.colDtlQty,
            this.colDtlUnitPrice,
            this.colDtlAmount,
            this.colDtlStkInQty,
            this.colDtlStkOutQty,
            this.colDtlBuyerName,
            this.colDtlCurrency,
            this.colDtlTaxRate,
            this.colDtlNeedPayAmtDate,
            this.colDtlNeedDeliveryDate,
            this.colDtlStkInStatus,
            this.colDtlApproveStatus,
            this.colDtlIsCancelName,
            this.colDtlIsCancel,
            this.colDtlStatus,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDtl.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDtl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDtl.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvDtl.HighlightSelectedColumnHeaders = false;
            this.dgvDtl.Location = new System.Drawing.Point(5, 5);
            this.dgvDtl.Name = "dgvDtl";
            this.dgvDtl.PaintEnhancedSelection = false;
            this.dgvDtl.ReadOnly = true;
            this.dgvDtl.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDtl.RowTemplate.Height = 23;
            this.dgvDtl.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDtl.SelectAllSignVisible = false;
            this.dgvDtl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvDtl.Size = new System.Drawing.Size(1020, 346);
            this.dgvDtl.TabIndex = 0;
            this.dgvDtl.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDtl_CellContentClick);
            this.dgvDtl.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDtl_CellDoubleClick);
            this.dgvDtl.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvDtl_DataBindingComplete);
            this.dgvDtl.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDtl_RowEnter);
            // 
            // colDtlOper
            // 
            this.colDtlOper.HeaderText = "操作";
            this.colDtlOper.Name = "colDtlOper";
            this.colDtlOper.ReadOnly = true;
            this.colDtlOper.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colDtlOper.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colDtlOper.Width = 60;
            // 
            // colDtlPOID
            // 
            this.colDtlPOID.DataPropertyName = "POID";
            this.colDtlPOID.HeaderText = "POID";
            this.colDtlPOID.Name = "colDtlPOID";
            this.colDtlPOID.ReadOnly = true;
            this.colDtlPOID.Visible = false;
            // 
            // colDtlPOGuid
            // 
            this.colDtlPOGuid.DataPropertyName = "POGuid";
            this.colDtlPOGuid.HeaderText = "POGuid";
            this.colDtlPOGuid.Name = "colDtlPOGuid";
            this.colDtlPOGuid.ReadOnly = true;
            this.colDtlPOGuid.Visible = false;
            // 
            // colDtlPOLineGuid
            // 
            this.colDtlPOLineGuid.DataPropertyName = "POLineGuid";
            this.colDtlPOLineGuid.HeaderText = "采购明细GUID";
            this.colDtlPOLineGuid.Name = "colDtlPOLineGuid";
            this.colDtlPOLineGuid.ReadOnly = true;
            this.colDtlPOLineGuid.Visible = false;
            // 
            // colDtlAllStatus
            // 
            this.colDtlAllStatus.DataPropertyName = "All_Status";
            this.colDtlAllStatus.HeaderText = "业务状态";
            this.colDtlAllStatus.Name = "colDtlAllStatus";
            this.colDtlAllStatus.ReadOnly = true;
            this.colDtlAllStatus.Width = 150;
            // 
            // colDtlBillNo
            // 
            this.colDtlBillNo.DataPropertyName = "BillNo";
            this.colDtlBillNo.HeaderText = "单据编号";
            this.colDtlBillNo.Name = "colDtlBillNo";
            this.colDtlBillNo.ReadOnly = true;
            // 
            // colDtlPODate
            // 
            this.colDtlPODate.DataPropertyName = "PODate";
            this.colDtlPODate.HeaderText = "采购日期";
            this.colDtlPODate.Name = "colDtlPODate";
            this.colDtlPODate.ReadOnly = true;
            this.colDtlPODate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colDtlPODate.Width = 80;
            // 
            // colDtlModel
            // 
            this.colDtlModel.DataPropertyName = "Model";
            this.colDtlModel.HeaderText = "型号";
            this.colDtlModel.Name = "colDtlModel";
            this.colDtlModel.ReadOnly = true;
            this.colDtlModel.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colDtlModel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colDtlBrand
            // 
            this.colDtlBrand.DataPropertyName = "Brand";
            this.colDtlBrand.HeaderText = "品牌";
            this.colDtlBrand.Name = "colDtlBrand";
            this.colDtlBrand.ReadOnly = true;
            this.colDtlBrand.Width = 80;
            // 
            // colDtlPackage
            // 
            this.colDtlPackage.DataPropertyName = "Package";
            this.colDtlPackage.HeaderText = "封装";
            this.colDtlPackage.Name = "colDtlPackage";
            this.colDtlPackage.ReadOnly = true;
            this.colDtlPackage.Visible = false;
            this.colDtlPackage.Width = 60;
            // 
            // colDtlBatch
            // 
            this.colDtlBatch.DataPropertyName = "Batch";
            this.colDtlBatch.HeaderText = "年份";
            this.colDtlBatch.Name = "colDtlBatch";
            this.colDtlBatch.ReadOnly = true;
            this.colDtlBatch.Width = 60;
            // 
            // colDtlQty
            // 
            this.colDtlQty.DataPropertyName = "Qty";
            this.colDtlQty.HeaderText = "数量";
            this.colDtlQty.Name = "colDtlQty";
            this.colDtlQty.ReadOnly = true;
            this.colDtlQty.Width = 70;
            // 
            // colDtlUnitPrice
            // 
            this.colDtlUnitPrice.DataPropertyName = "UnitPrice";
            this.colDtlUnitPrice.HeaderText = "单价";
            this.colDtlUnitPrice.Name = "colDtlUnitPrice";
            this.colDtlUnitPrice.ReadOnly = true;
            this.colDtlUnitPrice.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colDtlUnitPrice.Width = 70;
            // 
            // colDtlAmount
            // 
            this.colDtlAmount.DataPropertyName = "Amount";
            this.colDtlAmount.HeaderText = "金额";
            this.colDtlAmount.Name = "colDtlAmount";
            this.colDtlAmount.ReadOnly = true;
            this.colDtlAmount.Width = 80;
            // 
            // colDtlStkInQty
            // 
            this.colDtlStkInQty.DataPropertyName = "StkInQty";
            this.colDtlStkInQty.HeaderText = "已入库数";
            this.colDtlStkInQty.Name = "colDtlStkInQty";
            this.colDtlStkInQty.ReadOnly = true;
            this.colDtlStkInQty.Visible = false;
            this.colDtlStkInQty.Width = 60;
            // 
            // colDtlStkOutQty
            // 
            this.colDtlStkOutQty.DataPropertyName = "StkOutQty";
            this.colDtlStkOutQty.HeaderText = "已出库数";
            this.colDtlStkOutQty.Name = "colDtlStkOutQty";
            this.colDtlStkOutQty.ReadOnly = true;
            this.colDtlStkOutQty.Visible = false;
            this.colDtlStkOutQty.Width = 60;
            // 
            // colDtlBuyerName
            // 
            this.colDtlBuyerName.DataPropertyName = "BuyerName";
            this.colDtlBuyerName.HeaderText = "采购员";
            this.colDtlBuyerName.Name = "colDtlBuyerName";
            this.colDtlBuyerName.ReadOnly = true;
            this.colDtlBuyerName.Width = 80;
            // 
            // colDtlCurrency
            // 
            this.colDtlCurrency.DataPropertyName = "Currency";
            this.colDtlCurrency.HeaderText = "币种";
            this.colDtlCurrency.Name = "colDtlCurrency";
            this.colDtlCurrency.ReadOnly = true;
            this.colDtlCurrency.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colDtlCurrency.Width = 60;
            // 
            // colDtlTaxRate
            // 
            this.colDtlTaxRate.DataPropertyName = "TaxRate";
            this.colDtlTaxRate.HeaderText = "税率";
            this.colDtlTaxRate.Name = "colDtlTaxRate";
            this.colDtlTaxRate.ReadOnly = true;
            this.colDtlTaxRate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colDtlTaxRate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colDtlTaxRate.Width = 60;
            // 
            // colDtlNeedPayAmtDate
            // 
            this.colDtlNeedPayAmtDate.DataPropertyName = "NeedPayAmtDate";
            this.colDtlNeedPayAmtDate.HeaderText = "需付款日期";
            this.colDtlNeedPayAmtDate.Name = "colDtlNeedPayAmtDate";
            this.colDtlNeedPayAmtDate.ReadOnly = true;
            this.colDtlNeedPayAmtDate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colDtlNeedPayAmtDate.Width = 80;
            // 
            // colDtlNeedDeliveryDate
            // 
            this.colDtlNeedDeliveryDate.DataPropertyName = "NeedDeliveryDate";
            this.colDtlNeedDeliveryDate.HeaderText = "需到货日期";
            this.colDtlNeedDeliveryDate.Name = "colDtlNeedDeliveryDate";
            this.colDtlNeedDeliveryDate.ReadOnly = true;
            this.colDtlNeedDeliveryDate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colDtlNeedDeliveryDate.Width = 80;
            // 
            // colDtlStkInStatus
            // 
            this.colDtlStkInStatus.DataPropertyName = "StkInStatus";
            this.colDtlStkInStatus.HeaderText = "入库状态";
            this.colDtlStkInStatus.Name = "colDtlStkInStatus";
            this.colDtlStkInStatus.ReadOnly = true;
            this.colDtlStkInStatus.Visible = false;
            this.colDtlStkInStatus.Width = 80;
            // 
            // colDtlApproveStatus
            // 
            this.colDtlApproveStatus.DataPropertyName = "ApproveStatus";
            this.colDtlApproveStatus.HeaderText = "审批状态";
            this.colDtlApproveStatus.Name = "colDtlApproveStatus";
            this.colDtlApproveStatus.ReadOnly = true;
            // 
            // colDtlIsCancelName
            // 
            this.colDtlIsCancelName.DataPropertyName = "IsCancelName";
            this.colDtlIsCancelName.HeaderText = "取消否";
            this.colDtlIsCancelName.Name = "colDtlIsCancelName";
            this.colDtlIsCancelName.ReadOnly = true;
            // 
            // colDtlIsCancel
            // 
            this.colDtlIsCancel.DataPropertyName = "IsCancel";
            this.colDtlIsCancel.HeaderText = "IsCancel";
            this.colDtlIsCancel.Name = "colDtlIsCancel";
            this.colDtlIsCancel.ReadOnly = true;
            this.colDtlIsCancel.Visible = false;
            // 
            // colDtlStatus
            // 
            this.colDtlStatus.DataPropertyName = "Status";
            this.colDtlStatus.HeaderText = "Status";
            this.colDtlStatus.Name = "colDtlStatus";
            this.colDtlStatus.ReadOnly = true;
            this.colDtlStatus.Visible = false;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "CreatedEmpName";
            this.dataGridViewTextBoxColumn18.HeaderText = "创建人员";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "CreatedTime";
            this.dataGridViewTextBoxColumn19.HeaderText = "创建时间";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            // 
            // panDtlPage
            // 
            this.panDtlPage.BackColor = System.Drawing.Color.Transparent;
            this.panDtlPage.Controls.Add(this.pagDtl);
            this.panDtlPage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panDtlPage.Location = new System.Drawing.Point(0, 387);
            this.panDtlPage.Name = "panDtlPage";
            this.panDtlPage.Size = new System.Drawing.Size(1030, 30);
            this.panDtlPage.TabIndex = 7;
            // 
            // pagDtl
            // 
            this.pagDtl.BackColor = System.Drawing.Color.Transparent;
            this.pagDtl.Location = new System.Drawing.Point(14, 7);
            this.pagDtl.Name = "pagDtl";
            this.pagDtl.RecordCount = 0;
            this.pagDtl.Size = new System.Drawing.Size(195, 15);
            this.pagDtl.TabIndex = 0;
            this.pagDtl.PageIndexChanged += new System.EventHandler(this.pagDtl_PageIndexChanged);
            // 
            // panDtlWhere
            // 
            this.panDtlWhere.BackColor = System.Drawing.Color.Transparent;
            this.panDtlWhere.Controls.Add(this.btnDtlSearch);
            this.panDtlWhere.Dock = System.Windows.Forms.DockStyle.Top;
            this.panDtlWhere.Location = new System.Drawing.Point(0, 0);
            this.panDtlWhere.Name = "panDtlWhere";
            this.panDtlWhere.Size = new System.Drawing.Size(1030, 31);
            this.panDtlWhere.TabIndex = 5;
            // 
            // btnDtlSearch
            // 
            this.btnDtlSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDtlSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDtlSearch.Image = global::ZNLCRM.UI.Properties.Resources.search;
            this.btnDtlSearch.Location = new System.Drawing.Point(5, 4);
            this.btnDtlSearch.Name = "btnDtlSearch";
            this.btnDtlSearch.Size = new System.Drawing.Size(75, 23);
            this.btnDtlSearch.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDtlSearch.TabIndex = 4;
            this.btnDtlSearch.Text = "搜索";
            this.btnDtlSearch.Click += new System.EventHandler(this.btnDtlSearch_Click);
            // 
            // tbiDtl
            // 
            this.tbiDtl.AttachedControl = this.tbpDtl;
            this.tbiDtl.GlobalItem = false;
            this.tbiDtl.Name = "tbiDtl";
            this.tbiDtl.Text = "采购订单明细列表";
            // 
            // dataGridViewButtonXColumn1
            // 
            this.dataGridViewButtonXColumn1.HeaderText = "操作";
            this.dataGridViewButtonXColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewButtonXColumn1.Image")));
            this.dataGridViewButtonXColumn1.Name = "dataGridViewButtonXColumn1";
            this.dataGridViewButtonXColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewButtonXColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewButtonXColumn1.Text = "操作";
            // 
            // 采购单明细列表
            // 
            this.采购单明细列表.AttachedControl = this.superTabControlPanel1;
            this.采购单明细列表.GlobalItem = false;
            this.采购单明细列表.Name = "采购单明细列表";
            this.采购单明细列表.Text = "superTabItem1";
            // 
            // superTabControlPanel1
            // 
            this.superTabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel1.Location = new System.Drawing.Point(0, 28);
            this.superTabControlPanel1.Name = "superTabControlPanel1";
            this.superTabControlPanel1.Size = new System.Drawing.Size(395, 399);
            this.superTabControlPanel1.TabIndex = 0;
            this.superTabControlPanel1.TabItem = this.采购单明细列表;
            // 
            // frmPurchaseManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 482);
            this.Controls.Add(this.ucPanel2);
            this.Name = "frmPurchaseManage";
            this.Text = "采购单管理";
            this.Load += new System.EventHandler(this.frmPurchaseManage_Load);
            this.ucToolStrip1.ResumeLayout(false);
            this.ucToolStrip1.PerformLayout();
            this.ucPanel4.ResumeLayout(false);
            this.ucPanel4.PerformLayout();
            this.ucPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabPurchase)).EndInit();
            this.tabPurchase.ResumeLayout(false);
            this.tbpMast.ResumeLayout(false);
            this.panMast.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseOrder)).EndInit();
            this.panMastPage.ResumeLayout(false);
            this.panMastWhere.ResumeLayout(false);
            this.tbpDtl.ResumeLayout(false);
            this.panDtl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDtl)).EndInit();
            this.panDtlPage.ResumeLayout(false);
            this.panDtlWhere.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripButton tsbDel;
        private System.Windows.Forms.ToolStripButton tsbEdit;
        private System.Windows.Forms.ToolStripButton tsbAdd;
        private Controls.UcToolStrip ucToolStrip1;
        private System.Windows.Forms.ToolStripButton tsbPrint;
        private Controls.UcPanel ucPanel4;
        private Controls.UcPanel ucPanel2;
        private DevComponents.DotNetBar.Controls.DataGridViewButtonXColumn dataGridViewButtonXColumn1;
        private System.Windows.Forms.ToolStripButton tlbAuditBill;
        private System.Windows.Forms.ToolStripButton tlbCancelBill;
        private Controls.UcSuperTabControl tabPurchase;
        private DevComponents.DotNetBar.SuperTabControlPanel tbpDtl;
        private DevComponents.DotNetBar.SuperTabItem tbiDtl;
        private DevComponents.DotNetBar.ExpandableSplitter expandableSplitter1;
        private Controls.UcPanel panDtl;
        private Controls.UcDataGridView dgvDtl;
        private Controls.UcPanel panDtlPage;
        private Controls.UcPager pagDtl;
        private Controls.UcPanel panDtlWhere;
        private Controls.UcButton btnDtlSearch;
        private DevComponents.DotNetBar.SuperTabItem 采购单明细列表;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel1;
        private DevComponents.DotNetBar.SuperTabControlPanel tbpMast;
        private DevComponents.DotNetBar.SuperTabItem tbiMast;
        private Controls.UcPanel panMast;
        private Controls.UcDataGridView dgvPurchaseOrder;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colSelect;
        private System.Windows.Forms.DataGridViewLinkColumn colOperIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPOID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPOGuid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBillNo;
        private DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn colPODate;
        private DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn colInvType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSupplierName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPurOrgID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPurOrgName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPurDeptID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPurDeptName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBuyerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBuyerName;
        private DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn colCurrency;
        private DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn colClearingForm;
        private DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn colTaxRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn colNeedPayAmtDate;
        private DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn colNeedDeliveryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAllStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStkInStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReturnOccStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApproveStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRemark;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreatedEmpID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreatedEmpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreatedTime;
        private Controls.UcPanel panMastPage;
        private Controls.UcPager pgPurchaseOrder;
        private DevComponents.DotNetBar.ExpandableSplitter expandableSplitter2;
        private Controls.UcPanel panMastWhere;
        private Controls.UcButton btnSearch;
        private System.Windows.Forms.DataGridViewLinkColumn colDtlOper;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDtlPOID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDtlPOGuid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDtlPOLineGuid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDtlAllStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDtlBillNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDtlPODate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDtlModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDtlBrand;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDtlPackage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDtlBatch;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDtlQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDtlUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDtlAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDtlStkInQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDtlStkOutQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDtlBuyerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDtlCurrency;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDtlTaxRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDtlNeedPayAmtDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDtlNeedDeliveryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDtlStkInStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDtlApproveStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDtlIsCancelName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDtlIsCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDtlStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
    }
}