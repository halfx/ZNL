namespace ZNLCRM.UI.PPM
{
    partial class frmPurchaseOrder
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
            this.ucPanel7 = new ZNLCRM.Controls.UcPanel(this.components);
            this.ucPanel3 = new ZNLCRM.Controls.UcPanel(this.components);
            this.ustcLine = new ZNLCRM.Controls.UcSuperTabControl(this.components);
            this.stcpConEntry = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.txtConEntry = new ZNLCRM.Controls.UcTextBox(this.components);
            this.superTabItem2 = new DevComponents.DotNetBar.SuperTabItem();
            this.stcpLine = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.dgvPurchaseOrderLine = new ZNLCRM.Controls.UcDataGridView(this.components);
            this.colIsCancel = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colPOLineID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.POLineGuid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colModel = new DevComponents.DotNetBar.Controls.DataGridViewMaskedTextBoxAdvColumn();
            this.colInvType = new DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn();
            this.colQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNTaxPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBrand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPackage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBatch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMPQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStkInQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOfferInQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStkOutQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReturnQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnit = new DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn();
            this.colDemands = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRemark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNeedDeliveryDate = new DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn();
            this.colFactDeliveryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNeedPayAmtDate = new DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn();
            this.colFactPayAmtDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPaymentAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNoticeGuid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSOGuid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSOBillNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSOLineGuid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSONeedDeliveryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSOLineCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSOQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSOModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSOBrand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSOPackage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSOBatch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panDtlOpr = new ZNLCRM.Controls.UcPanel(this.components);
            this.btnInsertBefore = new ZNLCRM.Controls.UcButton(this.components);
            this.btnImportByHistory = new ZNLCRM.Controls.UcButton(this.components);
            this.btnImportByStock = new ZNLCRM.Controls.UcButton(this.components);
            this.btnImportByNotice = new ZNLCRM.Controls.UcButton(this.components);
            this.btnPaste = new ZNLCRM.Controls.UcButton(this.components);
            this.chkCalcType = new ZNLCRM.Controls.UcCheckBox(this.components);
            this.btnDelRow = new ZNLCRM.Controls.UcButton(this.components);
            this.btnAddRow = new ZNLCRM.Controls.UcButton(this.components);
            this.stiLine = new DevComponents.DotNetBar.SuperTabItem();
            this.stcpAttachFiles = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.stiAttachFiles = new DevComponents.DotNetBar.SuperTabItem();
            this.ucExpandableSplitter1 = new ZNLCRM.Controls.UcExpandableSplitter(this.components);
            this.ucPanel2 = new ZNLCRM.Controls.UcPanel(this.components);
            this.ustcOrder = new ZNLCRM.Controls.UcSuperTabControl(this.components);
            this.stcpOrder = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.lblSignFlag = new ZNLCRM.Controls.UcSignature();
            this.ucTextBox1 = new ZNLCRM.Controls.UcTextBox(this.components);
            this.ucLabelX3 = new ZNLCRM.Controls.UcLabelX(this.components);
            this.chkIsInvoiced = new ZNLCRM.Controls.UcCheckBox(this.components);
            this.cboInvoiceType = new ZNLCRM.Controls.UcComboBox(this.components);
            this.cboTransportCompany = new ZNLCRM.Controls.UcComboBox(this.components);
            this.txtIsCancel = new ZNLCRM.Controls.UcTextBox(this.components);
            this.txtFreight = new ZNLCRM.Controls.UcTextBox(this.components);
            this.ucLabelX28 = new ZNLCRM.Controls.UcLabelX(this.components);
            this.cboFreightClearForm = new ZNLCRM.Controls.UcComboBox(this.components);
            this.ucLabelX27 = new ZNLCRM.Controls.UcLabelX(this.components);
            this.txtShippingNo = new ZNLCRM.Controls.UcTextBox(this.components);
            this.ucLabelX26 = new ZNLCRM.Controls.UcLabelX(this.components);
            this.ucLabelX25 = new ZNLCRM.Controls.UcLabelX(this.components);
            this.cboInvType = new ZNLCRM.Controls.UcComboBox(this.components);
            this.ucLabelX2 = new ZNLCRM.Controls.UcLabelX(this.components);
            this.txtPOGuid = new ZNLCRM.Controls.UcTextBox(this.components);
            this.txtBuyerID = new ZNLCRM.Controls.UcTextBox(this.components);
            this.txtPurDeptID = new ZNLCRM.Controls.UcTextBox(this.components);
            this.txtSupplierID = new ZNLCRM.Controls.UcTextBox(this.components);
            this.txtPOID = new ZNLCRM.Controls.UcTextBox(this.components);
            this.txtNeedDeliveryDate = new ZNLCRM.Controls.UcDateTimeInput(this.components);
            this.ucLabelX1 = new ZNLCRM.Controls.UcLabelX(this.components);
            this.ucLabelX29 = new ZNLCRM.Controls.UcLabelX(this.components);
            this.txtBillNo = new ZNLCRM.Controls.UcTextBox(this.components);
            this.cboPurOrgID = new ZNLCRM.Controls.UcComboBox(this.components);
            this.ucLabelX4 = new ZNLCRM.Controls.UcLabelX(this.components);
            this.txtPONumber = new ZNLCRM.Controls.UcTextBox(this.components);
            this.txtBuyerName = new ZNLCRM.Controls.UcTextBox(this.components);
            this.ucLabelX5 = new ZNLCRM.Controls.UcLabelX(this.components);
            this.txtNeedPayAmtDate = new ZNLCRM.Controls.UcDateTimeInput(this.components);
            this.txtSupplierName = new ZNLCRM.Controls.UcTextBox(this.components);
            this.ucLabelX38 = new ZNLCRM.Controls.UcLabelX(this.components);
            this.ucLabelX6 = new ZNLCRM.Controls.UcLabelX(this.components);
            this.txtAddress = new ZNLCRM.Controls.UcTextBox(this.components);
            this.txtPurDeptName = new ZNLCRM.Controls.UcTextBox(this.components);
            this.ucLabelX7 = new ZNLCRM.Controls.UcLabelX(this.components);
            this.txtContact = new ZNLCRM.Controls.UcTextBox(this.components);
            this.ucLabelX37 = new ZNLCRM.Controls.UcLabelX(this.components);
            this.ucLabelX8 = new ZNLCRM.Controls.UcLabelX(this.components);
            this.txtTelephone = new ZNLCRM.Controls.UcTextBox(this.components);
            this.ucLabelX36 = new ZNLCRM.Controls.UcLabelX(this.components);
            this.ucLabelX54 = new ZNLCRM.Controls.UcLabelX(this.components);
            this.ucLabelX18 = new ZNLCRM.Controls.UcLabelX(this.components);
            this.txtPODate = new ZNLCRM.Controls.UcDateTimeInput(this.components);
            this.cboTaxRate = new ZNLCRM.Controls.UcComboBox(this.components);
            this.ucLabelX11 = new ZNLCRM.Controls.UcLabelX(this.components);
            this.cboCurrency = new ZNLCRM.Controls.UcComboBox(this.components);
            this.ucLabelX12 = new ZNLCRM.Controls.UcLabelX(this.components);
            this.cboClearingForm = new ZNLCRM.Controls.UcComboBox(this.components);
            this.txtClearFormDay = new ZNLCRM.Controls.UcTextBox(this.components);
            this.txtTaxAmount = new ZNLCRM.Controls.UcTextBox(this.components);
            this.ucLabelX13 = new ZNLCRM.Controls.UcLabelX(this.components);
            this.ucLabelX16 = new ZNLCRM.Controls.UcLabelX(this.components);
            this.ucLabelX14 = new ZNLCRM.Controls.UcLabelX(this.components);
            this.ucLabelX15 = new ZNLCRM.Controls.UcLabelX(this.components);
            this.txtAmount = new ZNLCRM.Controls.UcTextBox(this.components);
            this.stiOrder = new DevComponents.DotNetBar.SuperTabItem();
            this.stcpOther = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.txtCreatedTime = new ZNLCRM.Controls.UcTextBox(this.components);
            this.txtUpdatedTime = new ZNLCRM.Controls.UcTextBox(this.components);
            this.txtApproveStatus = new ZNLCRM.Controls.UcTextBox(this.components);
            this.ucLabelX53 = new ZNLCRM.Controls.UcLabelX(this.components);
            this.txtStatus = new ZNLCRM.Controls.UcTextBox(this.components);
            this.ucLabelX52 = new ZNLCRM.Controls.UcLabelX(this.components);
            this.ucLabelX51 = new ZNLCRM.Controls.UcLabelX(this.components);
            this.txtUpdatedEmpName = new ZNLCRM.Controls.UcTextBox(this.components);
            this.ucLabelX50 = new ZNLCRM.Controls.UcLabelX(this.components);
            this.ucLabelX49 = new ZNLCRM.Controls.UcLabelX(this.components);
            this.txtCreatedEmpName = new ZNLCRM.Controls.UcTextBox(this.components);
            this.ucLabelX48 = new ZNLCRM.Controls.UcLabelX(this.components);
            this.txtPaymentStatus = new ZNLCRM.Controls.UcTextBox(this.components);
            this.ucLabelX47 = new ZNLCRM.Controls.UcLabelX(this.components);
            this.txtReturnStatus = new ZNLCRM.Controls.UcTextBox(this.components);
            this.ucLabelX46 = new ZNLCRM.Controls.UcLabelX(this.components);
            this.txtStkOutStatus = new ZNLCRM.Controls.UcTextBox(this.components);
            this.ucLabelX44 = new ZNLCRM.Controls.UcLabelX(this.components);
            this.txtStkInStatus = new ZNLCRM.Controls.UcTextBox(this.components);
            this.ucLabelX43 = new ZNLCRM.Controls.UcLabelX(this.components);
            this.stiOther = new DevComponents.DotNetBar.SuperTabItem();
            this.ucPanel1 = new ZNLCRM.Controls.UcPanel(this.components);
            this.tsOper = new ZNLCRM.Controls.UcToolStrip(this.components);
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSubmit = new System.Windows.Forms.ToolStripButton();
            this.tsbAudit = new System.Windows.Forms.ToolStripButton();
            this.tsbUnDo = new System.Windows.Forms.ToolStripButton();
            this.tsbImport = new System.Windows.Forms.ToolStripButton();
            this.tsbExport = new System.Windows.Forms.ToolStripButton();
            this.tsbPrint = new System.Windows.Forms.ToolStripButton();
            this.tsbRefresh = new System.Windows.Forms.ToolStripButton();
            this.tsbCancelBill = new System.Windows.Forms.ToolStripButton();
            this.tsbTakeCancel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.ucPanel7.SuspendLayout();
            this.ucPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ustcLine)).BeginInit();
            this.ustcLine.SuspendLayout();
            this.stcpConEntry.SuspendLayout();
            this.stcpLine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseOrderLine)).BeginInit();
            this.panDtlOpr.SuspendLayout();
            this.ucPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ustcOrder)).BeginInit();
            this.ustcOrder.SuspendLayout();
            this.stcpOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNeedDeliveryDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNeedPayAmtDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPODate)).BeginInit();
            this.stcpOther.SuspendLayout();
            this.ucPanel1.SuspendLayout();
            this.tsOper.SuspendLayout();
            this.SuspendLayout();
            // 
            // ucPanel7
            // 
            this.ucPanel7.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel7.Controls.Add(this.ucPanel3);
            this.ucPanel7.Controls.Add(this.ucExpandableSplitter1);
            this.ucPanel7.Controls.Add(this.ucPanel2);
            this.ucPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPanel7.Location = new System.Drawing.Point(0, 32);
            this.ucPanel7.Name = "ucPanel7";
            this.ucPanel7.Size = new System.Drawing.Size(1020, 636);
            this.ucPanel7.TabIndex = 5;
            // 
            // ucPanel3
            // 
            this.ucPanel3.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel3.Controls.Add(this.ustcLine);
            this.ucPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPanel3.Location = new System.Drawing.Point(0, 283);
            this.ucPanel3.Name = "ucPanel3";
            this.ucPanel3.Size = new System.Drawing.Size(1020, 353);
            this.ucPanel3.TabIndex = 4;
            // 
            // ustcLine
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.ustcLine.ControlBox.CloseBox.Name = "";
            // 
            // 
            // 
            this.ustcLine.ControlBox.MenuBox.Name = "";
            this.ustcLine.ControlBox.Name = "";
            this.ustcLine.ControlBox.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ustcLine.ControlBox.MenuBox,
            this.ustcLine.ControlBox.CloseBox});
            this.ustcLine.Controls.Add(this.stcpLine);
            this.ustcLine.Controls.Add(this.stcpConEntry);
            this.ustcLine.Controls.Add(this.stcpAttachFiles);
            this.ustcLine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ustcLine.Location = new System.Drawing.Point(0, 0);
            this.ustcLine.Name = "ustcLine";
            this.ustcLine.ReorderTabsEnabled = true;
            this.ustcLine.SelectedTabFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold);
            this.ustcLine.SelectedTabIndex = 0;
            this.ustcLine.Size = new System.Drawing.Size(1020, 353);
            this.ustcLine.TabFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ustcLine.TabIndex = 0;
            this.ustcLine.Tabs.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.stiLine,
            this.superTabItem2,
            this.stiAttachFiles});
            this.ustcLine.Text = "ucSuperTabControl1";
            // 
            // stcpConEntry
            // 
            this.stcpConEntry.Controls.Add(this.txtConEntry);
            this.stcpConEntry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stcpConEntry.Location = new System.Drawing.Point(0, 0);
            this.stcpConEntry.Name = "stcpConEntry";
            this.stcpConEntry.Padding = new System.Windows.Forms.Padding(5);
            this.stcpConEntry.Size = new System.Drawing.Size(1020, 353);
            this.stcpConEntry.TabIndex = 0;
            this.stcpConEntry.TabItem = this.superTabItem2;
            // 
            // txtConEntry
            // 
            // 
            // 
            // 
            this.txtConEntry.Border.Class = "TextBoxBorder";
            this.txtConEntry.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtConEntry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtConEntry.EnterToNextControl = false;
            this.txtConEntry.Location = new System.Drawing.Point(5, 5);
            this.txtConEntry.Multiline = true;
            this.txtConEntry.Name = "txtConEntry";
            this.txtConEntry.PreventEnterBeep = true;
            this.txtConEntry.Size = new System.Drawing.Size(1010, 343);
            this.txtConEntry.TabIndex = 1;
            // 
            // superTabItem2
            // 
            this.superTabItem2.AttachedControl = this.stcpConEntry;
            this.superTabItem2.GlobalItem = false;
            this.superTabItem2.Name = "superTabItem2";
            this.superTabItem2.Text = "合同条款";
            // 
            // stcpLine
            // 
            this.stcpLine.Controls.Add(this.dgvPurchaseOrderLine);
            this.stcpLine.Controls.Add(this.panDtlOpr);
            this.stcpLine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stcpLine.Location = new System.Drawing.Point(0, 28);
            this.stcpLine.Name = "stcpLine";
            this.stcpLine.Size = new System.Drawing.Size(1020, 325);
            this.stcpLine.TabIndex = 1;
            this.stcpLine.TabItem = this.stiLine;
            // 
            // dgvPurchaseOrderLine
            // 
            this.dgvPurchaseOrderLine.AllowUserToAddRows = false;
            this.dgvPurchaseOrderLine.AllowUserToDeleteRows = false;
            this.dgvPurchaseOrderLine.AllowUserToOrderColumns = true;
            this.dgvPurchaseOrderLine.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPurchaseOrderLine.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPurchaseOrderLine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPurchaseOrderLine.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIsCancel,
            this.colPOLineID,
            this.POLineGuid,
            this.colModel,
            this.colInvType,
            this.colQty,
            this.colNTaxPrice,
            this.colUnitPrice,
            this.colAmount,
            this.colBrand,
            this.colPackage,
            this.colBatch,
            this.colQuality,
            this.colMPQ,
            this.colStkInQty,
            this.colOfferInQty,
            this.colStkOutQty,
            this.colReturnQty,
            this.colUnit,
            this.colDemands,
            this.colRemark,
            this.colNeedDeliveryDate,
            this.colFactDeliveryDate,
            this.colNeedPayAmtDate,
            this.colFactPayAmtDate,
            this.colPaymentAmount,
            this.colNoticeGuid,
            this.colSOGuid,
            this.colSOBillNo,
            this.colSOLineGuid,
            this.colSONeedDeliveryDate,
            this.colSOLineCode,
            this.colSOQty,
            this.colSOModel,
            this.colSOBrand,
            this.colSOPackage,
            this.colSOBatch});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPurchaseOrderLine.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPurchaseOrderLine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPurchaseOrderLine.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvPurchaseOrderLine.HighlightSelectedColumnHeaders = false;
            this.dgvPurchaseOrderLine.Location = new System.Drawing.Point(0, 30);
            this.dgvPurchaseOrderLine.Name = "dgvPurchaseOrderLine";
            this.dgvPurchaseOrderLine.PaintEnhancedSelection = false;
            this.dgvPurchaseOrderLine.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPurchaseOrderLine.RowHeadersWidth = 40;
            this.dgvPurchaseOrderLine.RowTemplate.Height = 23;
            this.dgvPurchaseOrderLine.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPurchaseOrderLine.SelectAllSignVisible = false;
            this.dgvPurchaseOrderLine.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvPurchaseOrderLine.ShowRowNo = true;
            this.dgvPurchaseOrderLine.Size = new System.Drawing.Size(1020, 295);
            this.dgvPurchaseOrderLine.TabIndex = 2;
            this.dgvPurchaseOrderLine.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvPurchaseOrderLine_CellFormatting);
            this.dgvPurchaseOrderLine.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPurchaseOrderLine_CellValueChanged);
            this.dgvPurchaseOrderLine.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvPurchaseOrderLine_DataBindingComplete);
            // 
            // colIsCancel
            // 
            this.colIsCancel.DataPropertyName = "IsCancel";
            this.colIsCancel.HeaderText = "取消";
            this.colIsCancel.Name = "colIsCancel";
            this.colIsCancel.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colIsCancel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colIsCancel.Width = 65;
            // 
            // colPOLineID
            // 
            this.colPOLineID.DataPropertyName = "POLineID";
            this.colPOLineID.HeaderText = "POLineID";
            this.colPOLineID.Name = "colPOLineID";
            this.colPOLineID.Visible = false;
            // 
            // POLineGuid
            // 
            this.POLineGuid.DataPropertyName = "POLineGuid";
            this.POLineGuid.HeaderText = "POLineGuid";
            this.POLineGuid.Name = "POLineGuid";
            this.POLineGuid.Visible = false;
            // 
            // colModel
            // 
            this.colModel.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.colModel.BackgroundStyle.Class = "DataGridViewBorder";
            this.colModel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.colModel.ButtonCustom.Visible = true;
            this.colModel.ButtonCustom2.Image = global::ZNLCRM.UI.Properties.Resources.del_6;
            this.colModel.ButtonCustom2.Visible = true;
            this.colModel.Culture = new System.Globalization.CultureInfo("zh-CN");
            this.colModel.DataPropertyName = "Model";
            this.colModel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.colModel.HeaderText = "型号";
            this.colModel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.colModel.Mask = "";
            this.colModel.Name = "colModel";
            this.colModel.PasswordChar = '\0';
            this.colModel.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colModel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.colModel.Text = "";
            this.colModel.Width = 150;
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
            this.colInvType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // colQty
            // 
            this.colQty.DataPropertyName = "Qty";
            this.colQty.HeaderText = "采购数量";
            this.colQty.Name = "colQty";
            // 
            // colNTaxPrice
            // 
            this.colNTaxPrice.DataPropertyName = "NTaxPrice";
            this.colNTaxPrice.HeaderText = "未含税单价";
            this.colNTaxPrice.Name = "colNTaxPrice";
            // 
            // colUnitPrice
            // 
            this.colUnitPrice.DataPropertyName = "UnitPrice";
            this.colUnitPrice.HeaderText = "含税单价";
            this.colUnitPrice.Name = "colUnitPrice";
            // 
            // colAmount
            // 
            this.colAmount.DataPropertyName = "Amount";
            this.colAmount.HeaderText = "小计金额";
            this.colAmount.Name = "colAmount";
            this.colAmount.ReadOnly = true;
            // 
            // colBrand
            // 
            this.colBrand.DataPropertyName = "Brand";
            this.colBrand.HeaderText = "品牌";
            this.colBrand.Name = "colBrand";
            // 
            // colPackage
            // 
            this.colPackage.DataPropertyName = "Package";
            this.colPackage.HeaderText = "封装";
            this.colPackage.Name = "colPackage";
            // 
            // colBatch
            // 
            this.colBatch.DataPropertyName = "Batch";
            this.colBatch.HeaderText = "批号";
            this.colBatch.Name = "colBatch";
            // 
            // colQuality
            // 
            this.colQuality.DataPropertyName = "Quality";
            this.colQuality.HeaderText = "品质";
            this.colQuality.Name = "colQuality";
            // 
            // colMPQ
            // 
            this.colMPQ.DataPropertyName = "MPQ";
            this.colMPQ.HeaderText = "包装";
            this.colMPQ.Name = "colMPQ";
            // 
            // colStkInQty
            // 
            this.colStkInQty.DataPropertyName = "StkInQty";
            this.colStkInQty.HeaderText = "入库数量";
            this.colStkInQty.Name = "colStkInQty";
            this.colStkInQty.ReadOnly = true;
            // 
            // colOfferInQty
            // 
            this.colOfferInQty.DataPropertyName = "OfferInQty";
            this.colOfferInQty.HeaderText = "入库赠送数";
            this.colOfferInQty.Name = "colOfferInQty";
            this.colOfferInQty.ReadOnly = true;
            // 
            // colStkOutQty
            // 
            this.colStkOutQty.DataPropertyName = "StkOutQty";
            this.colStkOutQty.HeaderText = "出库数量";
            this.colStkOutQty.Name = "colStkOutQty";
            this.colStkOutQty.ReadOnly = true;
            // 
            // colReturnQty
            // 
            this.colReturnQty.DataPropertyName = "ReturnQty";
            this.colReturnQty.HeaderText = "退货数量";
            this.colReturnQty.Name = "colReturnQty";
            this.colReturnQty.ReadOnly = true;
            // 
            // colUnit
            // 
            this.colUnit.DataPropertyName = "Unit";
            this.colUnit.DropDownHeight = 106;
            this.colUnit.DropDownWidth = 121;
            this.colUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colUnit.HeaderText = "单位";
            this.colUnit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.colUnit.IntegralHeight = false;
            this.colUnit.ItemHeight = 16;
            this.colUnit.Name = "colUnit";
            this.colUnit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colUnit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // colDemands
            // 
            this.colDemands.DataPropertyName = "Demands";
            this.colDemands.HeaderText = "采购要求";
            this.colDemands.Name = "colDemands";
            this.colDemands.ReadOnly = true;
            // 
            // colRemark
            // 
            this.colRemark.DataPropertyName = "Remark";
            this.colRemark.HeaderText = "备注";
            this.colRemark.Name = "colRemark";
            // 
            // colNeedDeliveryDate
            // 
            this.colNeedDeliveryDate.AutoSelectDate = true;
            // 
            // 
            // 
            this.colNeedDeliveryDate.BackgroundStyle.Class = "DataGridViewDateTimeBorder";
            this.colNeedDeliveryDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.colNeedDeliveryDate.ButtonDropDown.Visible = true;
            this.colNeedDeliveryDate.CustomFormat = "yyyy-MM-dd";
            this.colNeedDeliveryDate.DataPropertyName = "NeedDeliveryDate";
            this.colNeedDeliveryDate.Format = DevComponents.Editors.eDateTimePickerFormat.Custom;
            this.colNeedDeliveryDate.HeaderText = "应到货日期";
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
            this.colNeedDeliveryDate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colFactDeliveryDate
            // 
            this.colFactDeliveryDate.DataPropertyName = "FactDeliveryDate";
            this.colFactDeliveryDate.HeaderText = "实到货日期";
            this.colFactDeliveryDate.Name = "colFactDeliveryDate";
            this.colFactDeliveryDate.ReadOnly = true;
            // 
            // colNeedPayAmtDate
            // 
            this.colNeedPayAmtDate.AutoSelectDate = true;
            // 
            // 
            // 
            this.colNeedPayAmtDate.BackgroundStyle.Class = "DataGridViewDateTimeBorder";
            this.colNeedPayAmtDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.colNeedPayAmtDate.ButtonDropDown.Visible = true;
            this.colNeedPayAmtDate.CustomFormat = "yyyy-MM-dd";
            this.colNeedPayAmtDate.DataPropertyName = "NeedPayAmtDate";
            this.colNeedPayAmtDate.Format = DevComponents.Editors.eDateTimePickerFormat.Custom;
            this.colNeedPayAmtDate.HeaderText = "应收款日期";
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
            this.colNeedPayAmtDate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colFactPayAmtDate
            // 
            this.colFactPayAmtDate.DataPropertyName = "FactPayAmtDate";
            this.colFactPayAmtDate.HeaderText = "实收款日期";
            this.colFactPayAmtDate.Name = "colFactPayAmtDate";
            this.colFactPayAmtDate.ReadOnly = true;
            // 
            // colPaymentAmount
            // 
            this.colPaymentAmount.DataPropertyName = "PaymentAmount";
            this.colPaymentAmount.HeaderText = "已付款金额";
            this.colPaymentAmount.Name = "colPaymentAmount";
            this.colPaymentAmount.ReadOnly = true;
            // 
            // colNoticeGuid
            // 
            this.colNoticeGuid.DataPropertyName = "NoticeGuid";
            this.colNoticeGuid.HeaderText = "采购通知Guid";
            this.colNoticeGuid.Name = "colNoticeGuid";
            this.colNoticeGuid.ReadOnly = true;
            this.colNoticeGuid.Visible = false;
            // 
            // colSOGuid
            // 
            this.colSOGuid.DataPropertyName = "SOGuid";
            this.colSOGuid.HeaderText = "SOGuid";
            this.colSOGuid.Name = "colSOGuid";
            this.colSOGuid.Visible = false;
            // 
            // colSOBillNo
            // 
            this.colSOBillNo.DataPropertyName = "SOBillNo";
            this.colSOBillNo.HeaderText = "销售单号";
            this.colSOBillNo.Name = "colSOBillNo";
            this.colSOBillNo.ReadOnly = true;
            // 
            // colSOLineGuid
            // 
            this.colSOLineGuid.DataPropertyName = "SOLineGuid";
            this.colSOLineGuid.HeaderText = "销售明细GUID";
            this.colSOLineGuid.Name = "colSOLineGuid";
            this.colSOLineGuid.ReadOnly = true;
            this.colSOLineGuid.Visible = false;
            // 
            // colSONeedDeliveryDate
            // 
            this.colSONeedDeliveryDate.DataPropertyName = "NeedDeliveryDate";
            this.colSONeedDeliveryDate.HeaderText = "销售应发货日期";
            this.colSONeedDeliveryDate.Name = "colSONeedDeliveryDate";
            this.colSONeedDeliveryDate.ReadOnly = true;
            this.colSONeedDeliveryDate.Visible = false;
            // 
            // colSOLineCode
            // 
            this.colSOLineCode.DataPropertyName = "SOLineCode";
            this.colSOLineCode.HeaderText = "销售料号";
            this.colSOLineCode.Name = "colSOLineCode";
            this.colSOLineCode.ReadOnly = true;
            this.colSOLineCode.Visible = false;
            // 
            // colSOQty
            // 
            this.colSOQty.DataPropertyName = "SOQty";
            this.colSOQty.HeaderText = "需求数量";
            this.colSOQty.Name = "colSOQty";
            this.colSOQty.ReadOnly = true;
            // 
            // colSOModel
            // 
            this.colSOModel.DataPropertyName = "SOModel";
            this.colSOModel.HeaderText = "需求型号";
            this.colSOModel.Name = "colSOModel";
            this.colSOModel.ReadOnly = true;
            // 
            // colSOBrand
            // 
            this.colSOBrand.DataPropertyName = "SOBrand";
            this.colSOBrand.HeaderText = "需求厂商";
            this.colSOBrand.Name = "colSOBrand";
            this.colSOBrand.ReadOnly = true;
            // 
            // colSOPackage
            // 
            this.colSOPackage.DataPropertyName = "SOPackage";
            this.colSOPackage.HeaderText = "需求封装";
            this.colSOPackage.Name = "colSOPackage";
            this.colSOPackage.ReadOnly = true;
            // 
            // colSOBatch
            // 
            this.colSOBatch.DataPropertyName = "SOBatch";
            this.colSOBatch.HeaderText = "需求批号";
            this.colSOBatch.Name = "colSOBatch";
            this.colSOBatch.ReadOnly = true;
            // 
            // panDtlOpr
            // 
            this.panDtlOpr.BackColor = System.Drawing.Color.Transparent;
            this.panDtlOpr.Controls.Add(this.btnInsertBefore);
            this.panDtlOpr.Controls.Add(this.btnImportByHistory);
            this.panDtlOpr.Controls.Add(this.btnImportByStock);
            this.panDtlOpr.Controls.Add(this.btnImportByNotice);
            this.panDtlOpr.Controls.Add(this.btnPaste);
            this.panDtlOpr.Controls.Add(this.chkCalcType);
            this.panDtlOpr.Controls.Add(this.btnDelRow);
            this.panDtlOpr.Controls.Add(this.btnAddRow);
            this.panDtlOpr.Dock = System.Windows.Forms.DockStyle.Top;
            this.panDtlOpr.Location = new System.Drawing.Point(0, 0);
            this.panDtlOpr.Name = "panDtlOpr";
            this.panDtlOpr.Size = new System.Drawing.Size(1020, 30);
            this.panDtlOpr.TabIndex = 1;
            // 
            // btnInsertBefore
            // 
            this.btnInsertBefore.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnInsertBefore.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnInsertBefore.Image = global::ZNLCRM.UI.Properties.Resources.add_4;
            this.btnInsertBefore.Location = new System.Drawing.Point(186, 5);
            this.btnInsertBefore.Name = "btnInsertBefore";
            this.btnInsertBefore.Size = new System.Drawing.Size(81, 23);
            this.btnInsertBefore.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnInsertBefore.TabIndex = 2;
            this.btnInsertBefore.Text = "插入一行";
            this.btnInsertBefore.Click += new System.EventHandler(this.btnInsertBefore_Click);
            // 
            // btnImportByHistory
            // 
            this.btnImportByHistory.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnImportByHistory.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnImportByHistory.Image = global::ZNLCRM.UI.Properties.Resources.import_1;
            this.btnImportByHistory.Location = new System.Drawing.Point(572, 4);
            this.btnImportByHistory.Name = "btnImportByHistory";
            this.btnImportByHistory.Size = new System.Drawing.Size(113, 23);
            this.btnImportByHistory.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnImportByHistory.TabIndex = 6;
            this.btnImportByHistory.Text = "从采购记录导入";
            this.btnImportByHistory.Click += new System.EventHandler(this.btnImportByHistory_Click);
            // 
            // btnImportByStock
            // 
            this.btnImportByStock.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnImportByStock.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnImportByStock.Image = global::ZNLCRM.UI.Properties.Resources.import_1;
            this.btnImportByStock.Location = new System.Drawing.Point(476, 4);
            this.btnImportByStock.Name = "btnImportByStock";
            this.btnImportByStock.Size = new System.Drawing.Size(90, 23);
            this.btnImportByStock.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnImportByStock.TabIndex = 5;
            this.btnImportByStock.Text = "从库存导入";
            this.btnImportByStock.Click += new System.EventHandler(this.btnImportByStock_Click);
            // 
            // btnImportByNotice
            // 
            this.btnImportByNotice.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnImportByNotice.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnImportByNotice.Image = global::ZNLCRM.UI.Properties.Resources.import_1;
            this.btnImportByNotice.Location = new System.Drawing.Point(354, 4);
            this.btnImportByNotice.Name = "btnImportByNotice";
            this.btnImportByNotice.Size = new System.Drawing.Size(116, 23);
            this.btnImportByNotice.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnImportByNotice.TabIndex = 4;
            this.btnImportByNotice.Text = "从采购通知导入";
            this.btnImportByNotice.Click += new System.EventHandler(this.btnImportByNotice_Click);
            // 
            // btnPaste
            // 
            this.btnPaste.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnPaste.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnPaste.Image = global::ZNLCRM.UI.Properties.Resources.paste;
            this.btnPaste.Location = new System.Drawing.Point(273, 5);
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Size = new System.Drawing.Size(75, 23);
            this.btnPaste.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnPaste.TabIndex = 3;
            this.btnPaste.Text = "粘贴数据";
            // 
            // chkCalcType
            // 
            // 
            // 
            // 
            this.chkCalcType.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkCalcType.Location = new System.Drawing.Point(691, 3);
            this.chkCalcType.Name = "chkCalcType";
            this.chkCalcType.Size = new System.Drawing.Size(159, 23);
            this.chkCalcType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chkCalcType.TabIndex = 7;
            this.chkCalcType.Text = "由含税价计算未含税价";
            // 
            // btnDelRow
            // 
            this.btnDelRow.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDelRow.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDelRow.Image = global::ZNLCRM.UI.Properties.Resources.del_4;
            this.btnDelRow.Location = new System.Drawing.Point(93, 5);
            this.btnDelRow.Name = "btnDelRow";
            this.btnDelRow.Size = new System.Drawing.Size(87, 23);
            this.btnDelRow.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDelRow.TabIndex = 1;
            this.btnDelRow.Text = "删除选中行";
            this.btnDelRow.Click += new System.EventHandler(this.btnDelRow_Click);
            // 
            // btnAddRow
            // 
            this.btnAddRow.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddRow.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAddRow.Image = global::ZNLCRM.UI.Properties.Resources.add_4;
            this.btnAddRow.Location = new System.Drawing.Point(12, 4);
            this.btnAddRow.Name = "btnAddRow";
            this.btnAddRow.Size = new System.Drawing.Size(75, 23);
            this.btnAddRow.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAddRow.TabIndex = 0;
            this.btnAddRow.Text = "新增一行";
            this.btnAddRow.Click += new System.EventHandler(this.btnAddRow_Click);
            // 
            // stiLine
            // 
            this.stiLine.AttachedControl = this.stcpLine;
            this.stiLine.GlobalItem = false;
            this.stiLine.Name = "stiLine";
            this.stiLine.Text = "采购明细";
            // 
            // stcpAttachFiles
            // 
            this.stcpAttachFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stcpAttachFiles.Location = new System.Drawing.Point(0, 0);
            this.stcpAttachFiles.Name = "stcpAttachFiles";
            this.stcpAttachFiles.Size = new System.Drawing.Size(1020, 353);
            this.stcpAttachFiles.TabIndex = 0;
            this.stcpAttachFiles.TabItem = this.stiAttachFiles;
            // 
            // stiAttachFiles
            // 
            this.stiAttachFiles.AttachedControl = this.stcpAttachFiles;
            this.stiAttachFiles.GlobalItem = false;
            this.stiAttachFiles.Name = "stiAttachFiles";
            this.stiAttachFiles.Text = "相关附件";
            // 
            // ucExpandableSplitter1
            // 
            this.ucExpandableSplitter1.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207)))));
            this.ucExpandableSplitter1.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.ucExpandableSplitter1.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.ucExpandableSplitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucExpandableSplitter1.ExpandFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207)))));
            this.ucExpandableSplitter1.ExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.ucExpandableSplitter1.ExpandLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ucExpandableSplitter1.ExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.ucExpandableSplitter1.GripDarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ucExpandableSplitter1.GripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.ucExpandableSplitter1.GripLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.ucExpandableSplitter1.GripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.ucExpandableSplitter1.HotBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(151)))), ((int)(((byte)(61)))));
            this.ucExpandableSplitter1.HotBackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(94)))));
            this.ucExpandableSplitter1.HotBackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground2;
            this.ucExpandableSplitter1.HotBackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground;
            this.ucExpandableSplitter1.HotExpandFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207)))));
            this.ucExpandableSplitter1.HotExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.ucExpandableSplitter1.HotExpandLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ucExpandableSplitter1.HotExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.ucExpandableSplitter1.HotGripDarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207)))));
            this.ucExpandableSplitter1.HotGripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.ucExpandableSplitter1.HotGripLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.ucExpandableSplitter1.HotGripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.ucExpandableSplitter1.Location = new System.Drawing.Point(0, 280);
            this.ucExpandableSplitter1.Name = "ucExpandableSplitter1";
            this.ucExpandableSplitter1.Size = new System.Drawing.Size(1020, 3);
            this.ucExpandableSplitter1.Style = DevComponents.DotNetBar.eSplitterStyle.Office2007;
            this.ucExpandableSplitter1.TabIndex = 6;
            this.ucExpandableSplitter1.TabStop = false;
            // 
            // ucPanel2
            // 
            this.ucPanel2.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel2.Controls.Add(this.ustcOrder);
            this.ucPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucPanel2.Location = new System.Drawing.Point(0, 0);
            this.ucPanel2.Name = "ucPanel2";
            this.ucPanel2.Size = new System.Drawing.Size(1020, 280);
            this.ucPanel2.TabIndex = 3;
            // 
            // ustcOrder
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.ustcOrder.ControlBox.CloseBox.Name = "";
            // 
            // 
            // 
            this.ustcOrder.ControlBox.MenuBox.Name = "";
            this.ustcOrder.ControlBox.Name = "";
            this.ustcOrder.ControlBox.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ustcOrder.ControlBox.MenuBox,
            this.ustcOrder.ControlBox.CloseBox});
            this.ustcOrder.Controls.Add(this.stcpOrder);
            this.ustcOrder.Controls.Add(this.stcpOther);
            this.ustcOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ustcOrder.Location = new System.Drawing.Point(0, 0);
            this.ustcOrder.Name = "ustcOrder";
            this.ustcOrder.ReorderTabsEnabled = true;
            this.ustcOrder.SelectedTabFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold);
            this.ustcOrder.SelectedTabIndex = 0;
            this.ustcOrder.Size = new System.Drawing.Size(1020, 280);
            this.ustcOrder.TabFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ustcOrder.TabIndex = 0;
            this.ustcOrder.Tabs.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.stiOrder,
            this.stiOther});
            this.ustcOrder.Text = "ucSuperTabControl1";
            // 
            // stcpOrder
            // 
            this.stcpOrder.Controls.Add(this.lblSignFlag);
            this.stcpOrder.Controls.Add(this.ucTextBox1);
            this.stcpOrder.Controls.Add(this.ucLabelX3);
            this.stcpOrder.Controls.Add(this.chkIsInvoiced);
            this.stcpOrder.Controls.Add(this.cboInvoiceType);
            this.stcpOrder.Controls.Add(this.cboTransportCompany);
            this.stcpOrder.Controls.Add(this.txtIsCancel);
            this.stcpOrder.Controls.Add(this.txtFreight);
            this.stcpOrder.Controls.Add(this.ucLabelX28);
            this.stcpOrder.Controls.Add(this.cboFreightClearForm);
            this.stcpOrder.Controls.Add(this.ucLabelX27);
            this.stcpOrder.Controls.Add(this.txtShippingNo);
            this.stcpOrder.Controls.Add(this.ucLabelX26);
            this.stcpOrder.Controls.Add(this.ucLabelX25);
            this.stcpOrder.Controls.Add(this.cboInvType);
            this.stcpOrder.Controls.Add(this.ucLabelX2);
            this.stcpOrder.Controls.Add(this.txtPOGuid);
            this.stcpOrder.Controls.Add(this.txtBuyerID);
            this.stcpOrder.Controls.Add(this.txtPurDeptID);
            this.stcpOrder.Controls.Add(this.txtSupplierID);
            this.stcpOrder.Controls.Add(this.txtPOID);
            this.stcpOrder.Controls.Add(this.txtNeedDeliveryDate);
            this.stcpOrder.Controls.Add(this.ucLabelX1);
            this.stcpOrder.Controls.Add(this.ucLabelX29);
            this.stcpOrder.Controls.Add(this.txtBillNo);
            this.stcpOrder.Controls.Add(this.cboPurOrgID);
            this.stcpOrder.Controls.Add(this.ucLabelX4);
            this.stcpOrder.Controls.Add(this.txtPONumber);
            this.stcpOrder.Controls.Add(this.txtBuyerName);
            this.stcpOrder.Controls.Add(this.ucLabelX5);
            this.stcpOrder.Controls.Add(this.txtNeedPayAmtDate);
            this.stcpOrder.Controls.Add(this.txtSupplierName);
            this.stcpOrder.Controls.Add(this.ucLabelX38);
            this.stcpOrder.Controls.Add(this.ucLabelX6);
            this.stcpOrder.Controls.Add(this.txtAddress);
            this.stcpOrder.Controls.Add(this.txtPurDeptName);
            this.stcpOrder.Controls.Add(this.ucLabelX7);
            this.stcpOrder.Controls.Add(this.txtContact);
            this.stcpOrder.Controls.Add(this.ucLabelX37);
            this.stcpOrder.Controls.Add(this.ucLabelX8);
            this.stcpOrder.Controls.Add(this.txtTelephone);
            this.stcpOrder.Controls.Add(this.ucLabelX36);
            this.stcpOrder.Controls.Add(this.ucLabelX54);
            this.stcpOrder.Controls.Add(this.ucLabelX18);
            this.stcpOrder.Controls.Add(this.txtPODate);
            this.stcpOrder.Controls.Add(this.cboTaxRate);
            this.stcpOrder.Controls.Add(this.ucLabelX11);
            this.stcpOrder.Controls.Add(this.cboCurrency);
            this.stcpOrder.Controls.Add(this.ucLabelX12);
            this.stcpOrder.Controls.Add(this.cboClearingForm);
            this.stcpOrder.Controls.Add(this.txtClearFormDay);
            this.stcpOrder.Controls.Add(this.txtTaxAmount);
            this.stcpOrder.Controls.Add(this.ucLabelX13);
            this.stcpOrder.Controls.Add(this.ucLabelX16);
            this.stcpOrder.Controls.Add(this.ucLabelX14);
            this.stcpOrder.Controls.Add(this.ucLabelX15);
            this.stcpOrder.Controls.Add(this.txtAmount);
            this.stcpOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stcpOrder.Location = new System.Drawing.Point(0, 28);
            this.stcpOrder.Name = "stcpOrder";
            this.stcpOrder.Size = new System.Drawing.Size(1020, 252);
            this.stcpOrder.TabIndex = 1;
            this.stcpOrder.TabItem = this.stiOrder;
            // 
            // lblSignFlag
            // 
            this.lblSignFlag.Location = new System.Drawing.Point(804, 169);
            this.lblSignFlag.Name = "lblSignFlag";
            this.lblSignFlag.Size = new System.Drawing.Size(126, 41);
            this.lblSignFlag.TabIndex = 251;
            // 
            // ucTextBox1
            // 
            // 
            // 
            // 
            this.ucTextBox1.Border.Class = "TextBoxBorder";
            this.ucTextBox1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ucTextBox1.EnterToNextControl = false;
            this.ucTextBox1.Location = new System.Drawing.Point(103, 183);
            this.ucTextBox1.Multiline = true;
            this.ucTextBox1.Name = "ucTextBox1";
            this.ucTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.ucTextBox1.Size = new System.Drawing.Size(657, 27);
            this.ucTextBox1.TabIndex = 25;
            // 
            // ucLabelX3
            // 
            this.ucLabelX3.AutoSize = true;
            // 
            // 
            // 
            this.ucLabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ucLabelX3.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabelX3.ForeColor = System.Drawing.Color.Gray;
            this.ucLabelX3.Location = new System.Drawing.Point(51, 185);
            this.ucLabelX3.Name = "ucLabelX3";
            this.ucLabelX3.Size = new System.Drawing.Size(44, 18);
            this.ucLabelX3.TabIndex = 245;
            this.ucLabelX3.Text = "备注：";
            // 
            // chkIsInvoiced
            // 
            // 
            // 
            // 
            this.chkIsInvoiced.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkIsInvoiced.Location = new System.Drawing.Point(760, 222);
            this.chkIsInvoiced.Name = "chkIsInvoiced";
            this.chkIsInvoiced.Size = new System.Drawing.Size(66, 23);
            this.chkIsInvoiced.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chkIsInvoiced.TabIndex = 16;
            this.chkIsInvoiced.Text = "开票";
            this.chkIsInvoiced.Visible = false;
            // 
            // cboInvoiceType
            // 
            this.cboInvoiceType.DisplayMember = "Text";
            this.cboInvoiceType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboInvoiceType.FormattingEnabled = true;
            this.cboInvoiceType.ItemHeight = 15;
            this.cboInvoiceType.Location = new System.Drawing.Point(846, 222);
            this.cboInvoiceType.Name = "cboInvoiceType";
            this.cboInvoiceType.Size = new System.Drawing.Size(41, 21);
            this.cboInvoiceType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboInvoiceType.TabIndex = 17;
            this.cboInvoiceType.Visible = false;
            // 
            // cboTransportCompany
            // 
            this.cboTransportCompany.DisplayMember = "Text";
            this.cboTransportCompany.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboTransportCompany.FormattingEnabled = true;
            this.cboTransportCompany.ItemHeight = 15;
            this.cboTransportCompany.Location = new System.Drawing.Point(103, 125);
            this.cboTransportCompany.Name = "cboTransportCompany";
            this.cboTransportCompany.Size = new System.Drawing.Size(150, 21);
            this.cboTransportCompany.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboTransportCompany.TabIndex = 18;
            // 
            // txtIsCancel
            // 
            // 
            // 
            // 
            this.txtIsCancel.Border.Class = "TextBoxBorder";
            this.txtIsCancel.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtIsCancel.EnterToNextControl = false;
            this.txtIsCancel.Location = new System.Drawing.Point(893, 222);
            this.txtIsCancel.Name = "txtIsCancel";
            this.txtIsCancel.Size = new System.Drawing.Size(46, 21);
            this.txtIsCancel.TabIndex = 21;
            this.txtIsCancel.Visible = false;
            // 
            // txtFreight
            // 
            // 
            // 
            // 
            this.txtFreight.Border.Class = "TextBoxBorder";
            this.txtFreight.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtFreight.EnterToNextControl = false;
            this.txtFreight.Location = new System.Drawing.Point(856, 125);
            this.txtFreight.Name = "txtFreight";
            this.txtFreight.Size = new System.Drawing.Size(150, 21);
            this.txtFreight.TabIndex = 21;
            // 
            // ucLabelX28
            // 
            this.ucLabelX28.AutoSize = true;
            // 
            // 
            // 
            this.ucLabelX28.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ucLabelX28.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabelX28.ForeColor = System.Drawing.Color.Gray;
            this.ucLabelX28.Location = new System.Drawing.Point(804, 125);
            this.ucLabelX28.Name = "ucLabelX28";
            this.ucLabelX28.Size = new System.Drawing.Size(44, 18);
            this.ucLabelX28.TabIndex = 240;
            this.ucLabelX28.Text = "运费：";
            // 
            // cboFreightClearForm
            // 
            this.cboFreightClearForm.DisplayMember = "Text";
            this.cboFreightClearForm.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboFreightClearForm.FormattingEnabled = true;
            this.cboFreightClearForm.ItemHeight = 15;
            this.cboFreightClearForm.Location = new System.Drawing.Point(610, 125);
            this.cboFreightClearForm.Name = "cboFreightClearForm";
            this.cboFreightClearForm.Size = new System.Drawing.Size(150, 21);
            this.cboFreightClearForm.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboFreightClearForm.TabIndex = 20;
            // 
            // ucLabelX27
            // 
            this.ucLabelX27.AutoSize = true;
            // 
            // 
            // 
            this.ucLabelX27.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ucLabelX27.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabelX27.ForeColor = System.Drawing.Color.Gray;
            this.ucLabelX27.Location = new System.Drawing.Point(532, 125);
            this.ucLabelX27.Name = "ucLabelX27";
            this.ucLabelX27.Size = new System.Drawing.Size(68, 18);
            this.ucLabelX27.TabIndex = 239;
            this.ucLabelX27.Text = "运费结算：";
            // 
            // txtShippingNo
            // 
            // 
            // 
            // 
            this.txtShippingNo.Border.Class = "TextBoxBorder";
            this.txtShippingNo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtShippingNo.EnterToNextControl = false;
            this.txtShippingNo.Location = new System.Drawing.Point(353, 125);
            this.txtShippingNo.Name = "txtShippingNo";
            this.txtShippingNo.Size = new System.Drawing.Size(150, 21);
            this.txtShippingNo.TabIndex = 19;
            // 
            // ucLabelX26
            // 
            this.ucLabelX26.AutoSize = true;
            // 
            // 
            // 
            this.ucLabelX26.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ucLabelX26.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabelX26.ForeColor = System.Drawing.Color.Gray;
            this.ucLabelX26.Location = new System.Drawing.Point(277, 125);
            this.ucLabelX26.Name = "ucLabelX26";
            this.ucLabelX26.Size = new System.Drawing.Size(68, 18);
            this.ucLabelX26.TabIndex = 238;
            this.ucLabelX26.Text = "货运单号：";
            // 
            // ucLabelX25
            // 
            this.ucLabelX25.AutoSize = true;
            // 
            // 
            // 
            this.ucLabelX25.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ucLabelX25.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabelX25.ForeColor = System.Drawing.Color.Gray;
            this.ucLabelX25.Location = new System.Drawing.Point(27, 125);
            this.ucLabelX25.Name = "ucLabelX25";
            this.ucLabelX25.Size = new System.Drawing.Size(68, 18);
            this.ucLabelX25.TabIndex = 237;
            this.ucLabelX25.Text = "货运公司：";
            // 
            // cboInvType
            // 
            this.cboInvType.DisplayMember = "Text";
            this.cboInvType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboInvType.FormattingEnabled = true;
            this.cboInvType.ItemHeight = 15;
            this.cboInvType.Location = new System.Drawing.Point(856, 11);
            this.cboInvType.Name = "cboInvType";
            this.cboInvType.Size = new System.Drawing.Size(150, 21);
            this.cboInvType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboInvType.TabIndex = 3;
            this.cboInvType.TextChanged += new System.EventHandler(this.cboInvType_TextChanged);
            // 
            // ucLabelX2
            // 
            this.ucLabelX2.AutoSize = true;
            // 
            // 
            // 
            this.ucLabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ucLabelX2.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabelX2.ForeColor = System.Drawing.Color.Gray;
            this.ucLabelX2.IsMustChar = true;
            this.ucLabelX2.Location = new System.Drawing.Point(780, 12);
            this.ucLabelX2.Name = "ucLabelX2";
            this.ucLabelX2.Size = new System.Drawing.Size(68, 18);
            this.ucLabelX2.TabIndex = 224;
            this.ucLabelX2.Text = "库存类型：";
            // 
            // txtPOGuid
            // 
            // 
            // 
            // 
            this.txtPOGuid.Border.Class = "TextBoxBorder";
            this.txtPOGuid.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPOGuid.EnterToNextControl = false;
            this.txtPOGuid.Location = new System.Drawing.Point(598, 225);
            this.txtPOGuid.Name = "txtPOGuid";
            this.txtPOGuid.ReadOnly = true;
            this.txtPOGuid.Size = new System.Drawing.Size(27, 21);
            this.txtPOGuid.TabIndex = 20;
            this.txtPOGuid.Visible = false;
            // 
            // txtBuyerID
            // 
            // 
            // 
            // 
            this.txtBuyerID.Border.Class = "TextBoxBorder";
            this.txtBuyerID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtBuyerID.EnterToNextControl = false;
            this.txtBuyerID.Location = new System.Drawing.Point(711, 224);
            this.txtBuyerID.Name = "txtBuyerID";
            this.txtBuyerID.ReadOnly = true;
            this.txtBuyerID.Size = new System.Drawing.Size(27, 21);
            this.txtBuyerID.TabIndex = 222;
            this.txtBuyerID.Visible = false;
            // 
            // txtPurDeptID
            // 
            // 
            // 
            // 
            this.txtPurDeptID.Border.Class = "TextBoxBorder";
            this.txtPurDeptID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPurDeptID.EnterToNextControl = false;
            this.txtPurDeptID.Location = new System.Drawing.Point(678, 224);
            this.txtPurDeptID.Name = "txtPurDeptID";
            this.txtPurDeptID.ReadOnly = true;
            this.txtPurDeptID.Size = new System.Drawing.Size(27, 21);
            this.txtPurDeptID.TabIndex = 221;
            this.txtPurDeptID.Visible = false;
            // 
            // txtSupplierID
            // 
            // 
            // 
            // 
            this.txtSupplierID.Border.Class = "TextBoxBorder";
            this.txtSupplierID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSupplierID.EnterToNextControl = false;
            this.txtSupplierID.Location = new System.Drawing.Point(645, 225);
            this.txtSupplierID.Name = "txtSupplierID";
            this.txtSupplierID.ReadOnly = true;
            this.txtSupplierID.Size = new System.Drawing.Size(27, 21);
            this.txtSupplierID.TabIndex = 220;
            this.txtSupplierID.Visible = false;
            // 
            // txtPOID
            // 
            // 
            // 
            // 
            this.txtPOID.Border.Class = "TextBoxBorder";
            this.txtPOID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPOID.EnterToNextControl = false;
            this.txtPOID.Location = new System.Drawing.Point(561, 225);
            this.txtPOID.Name = "txtPOID";
            this.txtPOID.ReadOnly = true;
            this.txtPOID.Size = new System.Drawing.Size(27, 21);
            this.txtPOID.TabIndex = 219;
            this.txtPOID.Visible = false;
            // 
            // txtNeedDeliveryDate
            // 
            // 
            // 
            // 
            this.txtNeedDeliveryDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtNeedDeliveryDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtNeedDeliveryDate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.txtNeedDeliveryDate.ButtonDropDown.Visible = true;
            this.txtNeedDeliveryDate.CustomFormat = "yyyy-MM-dd";
            this.txtNeedDeliveryDate.Format = DevComponents.Editors.eDateTimePickerFormat.Custom;
            this.txtNeedDeliveryDate.IsPopupCalendarOpen = false;
            this.txtNeedDeliveryDate.Location = new System.Drawing.Point(856, 65);
            // 
            // 
            // 
            this.txtNeedDeliveryDate.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.txtNeedDeliveryDate.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.txtNeedDeliveryDate.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtNeedDeliveryDate.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.txtNeedDeliveryDate.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.txtNeedDeliveryDate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.txtNeedDeliveryDate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.txtNeedDeliveryDate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.txtNeedDeliveryDate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtNeedDeliveryDate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.txtNeedDeliveryDate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.txtNeedDeliveryDate.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtNeedDeliveryDate.MonthCalendar.DisplayMonth = new System.DateTime(2014, 11, 1, 0, 0, 0, 0);
            this.txtNeedDeliveryDate.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.txtNeedDeliveryDate.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.txtNeedDeliveryDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.txtNeedDeliveryDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.txtNeedDeliveryDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.txtNeedDeliveryDate.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtNeedDeliveryDate.MonthCalendar.TodayButtonVisible = true;
            this.txtNeedDeliveryDate.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.txtNeedDeliveryDate.Name = "txtNeedDeliveryDate";
            this.txtNeedDeliveryDate.Size = new System.Drawing.Size(150, 21);
            this.txtNeedDeliveryDate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.txtNeedDeliveryDate.TabIndex = 9;
            // 
            // ucLabelX1
            // 
            this.ucLabelX1.AutoSize = true;
            // 
            // 
            // 
            this.ucLabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ucLabelX1.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabelX1.ForeColor = System.Drawing.Color.Gray;
            this.ucLabelX1.Location = new System.Drawing.Point(27, 12);
            this.ucLabelX1.Name = "ucLabelX1";
            this.ucLabelX1.Size = new System.Drawing.Size(68, 18);
            this.ucLabelX1.TabIndex = 132;
            this.ucLabelX1.Text = "采购单号：";
            // 
            // ucLabelX29
            // 
            this.ucLabelX29.AutoSize = true;
            // 
            // 
            // 
            this.ucLabelX29.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ucLabelX29.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabelX29.ForeColor = System.Drawing.Color.Gray;
            this.ucLabelX29.Location = new System.Drawing.Point(766, 66);
            this.ucLabelX29.Name = "ucLabelX29";
            this.ucLabelX29.Size = new System.Drawing.Size(81, 18);
            this.ucLabelX29.TabIndex = 169;
            this.ucLabelX29.Text = "应到货日期：";
            // 
            // txtBillNo
            // 
            // 
            // 
            // 
            this.txtBillNo.Border.Class = "TextBoxBorder";
            this.txtBillNo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtBillNo.EnterToNextControl = false;
            this.txtBillNo.Location = new System.Drawing.Point(104, 11);
            this.txtBillNo.Name = "txtBillNo";
            this.txtBillNo.ReadOnly = true;
            this.txtBillNo.Size = new System.Drawing.Size(150, 21);
            this.txtBillNo.TabIndex = 0;
            // 
            // cboPurOrgID
            // 
            this.cboPurOrgID.DisplayMember = "Text";
            this.cboPurOrgID.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboPurOrgID.FormattingEnabled = true;
            this.cboPurOrgID.ItemHeight = 15;
            this.cboPurOrgID.Location = new System.Drawing.Point(103, 153);
            this.cboPurOrgID.Name = "cboPurOrgID";
            this.cboPurOrgID.Size = new System.Drawing.Size(150, 21);
            this.cboPurOrgID.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboPurOrgID.TabIndex = 22;
            // 
            // ucLabelX4
            // 
            this.ucLabelX4.AutoSize = true;
            // 
            // 
            // 
            this.ucLabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ucLabelX4.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabelX4.ForeColor = System.Drawing.Color.Gray;
            this.ucLabelX4.Location = new System.Drawing.Point(556, 12);
            this.ucLabelX4.Name = "ucLabelX4";
            this.ucLabelX4.Size = new System.Drawing.Size(44, 18);
            this.ucLabelX4.TabIndex = 133;
            this.ucLabelX4.Text = "PO号：";
            // 
            // txtPONumber
            // 
            // 
            // 
            // 
            this.txtPONumber.Border.Class = "TextBoxBorder";
            this.txtPONumber.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPONumber.EnterToNextControl = false;
            this.txtPONumber.Location = new System.Drawing.Point(610, 11);
            this.txtPONumber.Name = "txtPONumber";
            this.txtPONumber.Size = new System.Drawing.Size(150, 21);
            this.txtPONumber.TabIndex = 2;
            // 
            // txtBuyerName
            // 
            // 
            // 
            // 
            this.txtBuyerName.Border.Class = "TextBoxBorder";
            this.txtBuyerName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtBuyerName.ButtonCustom.Visible = true;
            this.txtBuyerName.ButtonCustom2.Image = global::ZNLCRM.UI.Properties.Resources.del_6;
            this.txtBuyerName.ButtonCustom2.Visible = true;
            this.txtBuyerName.EnterToNextControl = false;
            this.txtBuyerName.Location = new System.Drawing.Point(610, 153);
            this.txtBuyerName.Name = "txtBuyerName";
            this.txtBuyerName.Size = new System.Drawing.Size(150, 21);
            this.txtBuyerName.TabIndex = 24;
            this.txtBuyerName.ButtonCustomClick += new System.EventHandler(this.txtBuyerName_ButtonCustomClick);
            this.txtBuyerName.ButtonCustom2Click += new System.EventHandler(this.txtBuyerName_ButtonCustom2Click);
            // 
            // ucLabelX5
            // 
            this.ucLabelX5.AutoSize = true;
            // 
            // 
            // 
            this.ucLabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ucLabelX5.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabelX5.ForeColor = System.Drawing.Color.Gray;
            this.ucLabelX5.IsMustChar = true;
            this.ucLabelX5.Location = new System.Drawing.Point(14, 40);
            this.ucLabelX5.Name = "ucLabelX5";
            this.ucLabelX5.Size = new System.Drawing.Size(81, 18);
            this.ucLabelX5.TabIndex = 135;
            this.ucLabelX5.Text = "供应商名称：";
            // 
            // txtNeedPayAmtDate
            // 
            // 
            // 
            // 
            this.txtNeedPayAmtDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtNeedPayAmtDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtNeedPayAmtDate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.txtNeedPayAmtDate.ButtonDropDown.Visible = true;
            this.txtNeedPayAmtDate.CustomFormat = "yyyy-MM-dd";
            this.txtNeedPayAmtDate.Format = DevComponents.Editors.eDateTimePickerFormat.Custom;
            this.txtNeedPayAmtDate.IsPopupCalendarOpen = false;
            this.txtNeedPayAmtDate.Location = new System.Drawing.Point(610, 65);
            // 
            // 
            // 
            this.txtNeedPayAmtDate.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.txtNeedPayAmtDate.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.txtNeedPayAmtDate.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtNeedPayAmtDate.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.txtNeedPayAmtDate.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.txtNeedPayAmtDate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.txtNeedPayAmtDate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.txtNeedPayAmtDate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.txtNeedPayAmtDate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtNeedPayAmtDate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.txtNeedPayAmtDate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.txtNeedPayAmtDate.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtNeedPayAmtDate.MonthCalendar.DisplayMonth = new System.DateTime(2014, 11, 1, 0, 0, 0, 0);
            this.txtNeedPayAmtDate.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.txtNeedPayAmtDate.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.txtNeedPayAmtDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.txtNeedPayAmtDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.txtNeedPayAmtDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.txtNeedPayAmtDate.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtNeedPayAmtDate.MonthCalendar.TodayButtonVisible = true;
            this.txtNeedPayAmtDate.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.txtNeedPayAmtDate.Name = "txtNeedPayAmtDate";
            this.txtNeedPayAmtDate.Size = new System.Drawing.Size(150, 21);
            this.txtNeedPayAmtDate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.txtNeedPayAmtDate.TabIndex = 8;
            // 
            // txtSupplierName
            // 
            // 
            // 
            // 
            this.txtSupplierName.Border.Class = "TextBoxBorder";
            this.txtSupplierName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSupplierName.ButtonCustom.Visible = true;
            this.txtSupplierName.ButtonCustom2.Image = global::ZNLCRM.UI.Properties.Resources.del_6;
            this.txtSupplierName.ButtonCustom2.Visible = true;
            this.txtSupplierName.EnterToNextControl = false;
            this.txtSupplierName.Location = new System.Drawing.Point(104, 39);
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.Size = new System.Drawing.Size(400, 21);
            this.txtSupplierName.TabIndex = 4;
            this.txtSupplierName.ButtonCustomClick += new System.EventHandler(this.txtSupplierName_ButtonCustomClick);
            this.txtSupplierName.ButtonCustom2Click += new System.EventHandler(this.txtSupplierName_ButtonCustom2Click);
            this.txtSupplierName.TextChanged += new System.EventHandler(this.txtSupplierName_TextChanged);
            // 
            // ucLabelX38
            // 
            this.ucLabelX38.AutoSize = true;
            // 
            // 
            // 
            this.ucLabelX38.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ucLabelX38.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabelX38.ForeColor = System.Drawing.Color.Gray;
            this.ucLabelX38.IsMustChar = true;
            this.ucLabelX38.Location = new System.Drawing.Point(544, 154);
            this.ucLabelX38.Name = "ucLabelX38";
            this.ucLabelX38.Size = new System.Drawing.Size(56, 18);
            this.ucLabelX38.TabIndex = 147;
            this.ucLabelX38.Text = "采购员：";
            // 
            // ucLabelX6
            // 
            this.ucLabelX6.AutoSize = true;
            // 
            // 
            // 
            this.ucLabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ucLabelX6.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabelX6.ForeColor = System.Drawing.Color.Gray;
            this.ucLabelX6.Location = new System.Drawing.Point(27, 66);
            this.ucLabelX6.Name = "ucLabelX6";
            this.ucLabelX6.Size = new System.Drawing.Size(68, 18);
            this.ucLabelX6.TabIndex = 137;
            this.ucLabelX6.Text = "公司地址：";
            // 
            // txtAddress
            // 
            // 
            // 
            // 
            this.txtAddress.Border.Class = "TextBoxBorder";
            this.txtAddress.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtAddress.EnterToNextControl = false;
            this.txtAddress.Location = new System.Drawing.Point(104, 65);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(400, 21);
            this.txtAddress.TabIndex = 7;
            // 
            // txtPurDeptName
            // 
            // 
            // 
            // 
            this.txtPurDeptName.Border.Class = "TextBoxBorder";
            this.txtPurDeptName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPurDeptName.ButtonCustom.Visible = true;
            this.txtPurDeptName.ButtonCustom2.Image = global::ZNLCRM.UI.Properties.Resources.del_6;
            this.txtPurDeptName.ButtonCustom2.Visible = true;
            this.txtPurDeptName.EnterToNextControl = false;
            this.txtPurDeptName.Location = new System.Drawing.Point(353, 153);
            this.txtPurDeptName.Name = "txtPurDeptName";
            this.txtPurDeptName.Size = new System.Drawing.Size(150, 21);
            this.txtPurDeptName.TabIndex = 23;
            this.txtPurDeptName.ButtonCustomClick += new System.EventHandler(this.txtPurDeptName_ButtonCustomClick);
            this.txtPurDeptName.ButtonCustom2Click += new System.EventHandler(this.txtPurDeptName_ButtonCustom2Click);
            // 
            // ucLabelX7
            // 
            this.ucLabelX7.AutoSize = true;
            // 
            // 
            // 
            this.ucLabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ucLabelX7.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabelX7.ForeColor = System.Drawing.Color.Gray;
            this.ucLabelX7.Location = new System.Drawing.Point(544, 40);
            this.ucLabelX7.Name = "ucLabelX7";
            this.ucLabelX7.Size = new System.Drawing.Size(56, 18);
            this.ucLabelX7.TabIndex = 139;
            this.ucLabelX7.Text = "联系人：";
            // 
            // txtContact
            // 
            // 
            // 
            // 
            this.txtContact.Border.Class = "TextBoxBorder";
            this.txtContact.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtContact.ButtonCustom.Visible = true;
            this.txtContact.ButtonCustom2.Image = global::ZNLCRM.UI.Properties.Resources.del_6;
            this.txtContact.ButtonCustom2.Visible = true;
            this.txtContact.EnterToNextControl = false;
            this.txtContact.Location = new System.Drawing.Point(610, 39);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(150, 21);
            this.txtContact.TabIndex = 5;
            this.txtContact.ButtonCustomClick += new System.EventHandler(this.txtContact_ButtonCustomClick);
            this.txtContact.ButtonCustom2Click += new System.EventHandler(this.txtContact_ButtonCustom2Click);
            // 
            // ucLabelX37
            // 
            this.ucLabelX37.AutoSize = true;
            // 
            // 
            // 
            this.ucLabelX37.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ucLabelX37.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabelX37.ForeColor = System.Drawing.Color.Gray;
            this.ucLabelX37.IsMustChar = true;
            this.ucLabelX37.Location = new System.Drawing.Point(277, 154);
            this.ucLabelX37.Name = "ucLabelX37";
            this.ucLabelX37.Size = new System.Drawing.Size(68, 18);
            this.ucLabelX37.TabIndex = 145;
            this.ucLabelX37.Text = "采购部门：";
            // 
            // ucLabelX8
            // 
            this.ucLabelX8.AutoSize = true;
            // 
            // 
            // 
            this.ucLabelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ucLabelX8.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabelX8.ForeColor = System.Drawing.Color.Gray;
            this.ucLabelX8.Location = new System.Drawing.Point(780, 40);
            this.ucLabelX8.Name = "ucLabelX8";
            this.ucLabelX8.Size = new System.Drawing.Size(68, 18);
            this.ucLabelX8.TabIndex = 141;
            this.ucLabelX8.Text = "联系电话：";
            // 
            // txtTelephone
            // 
            // 
            // 
            // 
            this.txtTelephone.Border.Class = "TextBoxBorder";
            this.txtTelephone.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTelephone.EnterToNextControl = false;
            this.txtTelephone.Location = new System.Drawing.Point(856, 39);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(150, 21);
            this.txtTelephone.TabIndex = 6;
            // 
            // ucLabelX36
            // 
            this.ucLabelX36.AutoSize = true;
            // 
            // 
            // 
            this.ucLabelX36.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ucLabelX36.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabelX36.ForeColor = System.Drawing.Color.Gray;
            this.ucLabelX36.IsMustChar = true;
            this.ucLabelX36.Location = new System.Drawing.Point(27, 154);
            this.ucLabelX36.Name = "ucLabelX36";
            this.ucLabelX36.Size = new System.Drawing.Size(68, 18);
            this.ucLabelX36.TabIndex = 144;
            this.ucLabelX36.Text = "采购机构：";
            // 
            // ucLabelX54
            // 
            this.ucLabelX54.AutoSize = true;
            // 
            // 
            // 
            this.ucLabelX54.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ucLabelX54.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabelX54.ForeColor = System.Drawing.Color.Gray;
            this.ucLabelX54.IsMustChar = true;
            this.ucLabelX54.Location = new System.Drawing.Point(277, 12);
            this.ucLabelX54.Name = "ucLabelX54";
            this.ucLabelX54.Size = new System.Drawing.Size(68, 18);
            this.ucLabelX54.TabIndex = 149;
            this.ucLabelX54.Text = "采购日期：";
            // 
            // ucLabelX18
            // 
            this.ucLabelX18.AutoSize = true;
            // 
            // 
            // 
            this.ucLabelX18.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ucLabelX18.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabelX18.ForeColor = System.Drawing.Color.Gray;
            this.ucLabelX18.Location = new System.Drawing.Point(519, 66);
            this.ucLabelX18.Name = "ucLabelX18";
            this.ucLabelX18.Size = new System.Drawing.Size(81, 18);
            this.ucLabelX18.TabIndex = 163;
            this.ucLabelX18.Text = "应付款日期：";
            // 
            // txtPODate
            // 
            // 
            // 
            // 
            this.txtPODate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtPODate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPODate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.txtPODate.ButtonDropDown.Visible = true;
            this.txtPODate.CustomFormat = "yyyy-MM-dd";
            this.txtPODate.Format = DevComponents.Editors.eDateTimePickerFormat.Custom;
            this.txtPODate.IsPopupCalendarOpen = false;
            this.txtPODate.Location = new System.Drawing.Point(354, 11);
            // 
            // 
            // 
            this.txtPODate.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.txtPODate.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.txtPODate.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPODate.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.txtPODate.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.txtPODate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.txtPODate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.txtPODate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.txtPODate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtPODate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.txtPODate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.txtPODate.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPODate.MonthCalendar.DisplayMonth = new System.DateTime(2014, 11, 1, 0, 0, 0, 0);
            this.txtPODate.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.txtPODate.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.txtPODate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.txtPODate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.txtPODate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.txtPODate.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPODate.MonthCalendar.TodayButtonVisible = true;
            this.txtPODate.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.txtPODate.Name = "txtPODate";
            this.txtPODate.Size = new System.Drawing.Size(150, 21);
            this.txtPODate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.txtPODate.TabIndex = 1;
            // 
            // cboTaxRate
            // 
            this.cboTaxRate.DisplayMember = "Text";
            this.cboTaxRate.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboTaxRate.FormattingEnabled = true;
            this.cboTaxRate.ItemHeight = 15;
            this.cboTaxRate.Location = new System.Drawing.Point(856, 95);
            this.cboTaxRate.Name = "cboTaxRate";
            this.cboTaxRate.Size = new System.Drawing.Size(149, 21);
            this.cboTaxRate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboTaxRate.TabIndex = 13;
            this.cboTaxRate.TextChanged += new System.EventHandler(this.cboTaxRate_TextChanged);
            // 
            // ucLabelX11
            // 
            this.ucLabelX11.AutoSize = true;
            // 
            // 
            // 
            this.ucLabelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ucLabelX11.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabelX11.ForeColor = System.Drawing.Color.Gray;
            this.ucLabelX11.IsMustChar = true;
            this.ucLabelX11.Location = new System.Drawing.Point(27, 96);
            this.ucLabelX11.Name = "ucLabelX11";
            this.ucLabelX11.Size = new System.Drawing.Size(68, 18);
            this.ucLabelX11.TabIndex = 151;
            this.ucLabelX11.Text = "结算方式：";
            // 
            // cboCurrency
            // 
            this.cboCurrency.DisplayMember = "Text";
            this.cboCurrency.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboCurrency.FormattingEnabled = true;
            this.cboCurrency.ItemHeight = 15;
            this.cboCurrency.Location = new System.Drawing.Point(610, 95);
            this.cboCurrency.Name = "cboCurrency";
            this.cboCurrency.Size = new System.Drawing.Size(150, 21);
            this.cboCurrency.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboCurrency.TabIndex = 12;
            // 
            // ucLabelX12
            // 
            this.ucLabelX12.AutoSize = true;
            // 
            // 
            // 
            this.ucLabelX12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ucLabelX12.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabelX12.ForeColor = System.Drawing.Color.Gray;
            this.ucLabelX12.Location = new System.Drawing.Point(277, 96);
            this.ucLabelX12.Name = "ucLabelX12";
            this.ucLabelX12.Size = new System.Drawing.Size(68, 18);
            this.ucLabelX12.TabIndex = 152;
            this.ucLabelX12.Text = "结算天数：";
            // 
            // cboClearingForm
            // 
            this.cboClearingForm.DisplayMember = "Text";
            this.cboClearingForm.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboClearingForm.FormattingEnabled = true;
            this.cboClearingForm.ItemHeight = 15;
            this.cboClearingForm.Location = new System.Drawing.Point(104, 95);
            this.cboClearingForm.Name = "cboClearingForm";
            this.cboClearingForm.Size = new System.Drawing.Size(149, 21);
            this.cboClearingForm.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboClearingForm.TabIndex = 10;
            // 
            // txtClearFormDay
            // 
            // 
            // 
            // 
            this.txtClearFormDay.Border.Class = "TextBoxBorder";
            this.txtClearFormDay.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtClearFormDay.EnterToNextControl = false;
            this.txtClearFormDay.Location = new System.Drawing.Point(353, 95);
            this.txtClearFormDay.Name = "txtClearFormDay";
            this.txtClearFormDay.Size = new System.Drawing.Size(150, 21);
            this.txtClearFormDay.TabIndex = 11;
            // 
            // txtTaxAmount
            // 
            // 
            // 
            // 
            this.txtTaxAmount.Border.Class = "TextBoxBorder";
            this.txtTaxAmount.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTaxAmount.EnterToNextControl = false;
            this.txtTaxAmount.Location = new System.Drawing.Point(103, 218);
            this.txtTaxAmount.Name = "txtTaxAmount";
            this.txtTaxAmount.ReadOnly = true;
            this.txtTaxAmount.Size = new System.Drawing.Size(150, 21);
            this.txtTaxAmount.TabIndex = 14;
            // 
            // ucLabelX13
            // 
            this.ucLabelX13.AutoSize = true;
            // 
            // 
            // 
            this.ucLabelX13.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ucLabelX13.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabelX13.ForeColor = System.Drawing.Color.Gray;
            this.ucLabelX13.IsMustChar = true;
            this.ucLabelX13.Location = new System.Drawing.Point(556, 96);
            this.ucLabelX13.Name = "ucLabelX13";
            this.ucLabelX13.Size = new System.Drawing.Size(44, 18);
            this.ucLabelX13.TabIndex = 154;
            this.ucLabelX13.Text = "币种：";
            // 
            // ucLabelX16
            // 
            this.ucLabelX16.AutoSize = true;
            // 
            // 
            // 
            this.ucLabelX16.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ucLabelX16.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabelX16.ForeColor = System.Drawing.Color.Gray;
            this.ucLabelX16.Location = new System.Drawing.Point(277, 219);
            this.ucLabelX16.Name = "ucLabelX16";
            this.ucLabelX16.Size = new System.Drawing.Size(68, 18);
            this.ucLabelX16.TabIndex = 158;
            this.ucLabelX16.Text = "订单金额：";
            // 
            // ucLabelX14
            // 
            this.ucLabelX14.AutoSize = true;
            // 
            // 
            // 
            this.ucLabelX14.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ucLabelX14.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabelX14.ForeColor = System.Drawing.Color.Gray;
            this.ucLabelX14.Location = new System.Drawing.Point(804, 96);
            this.ucLabelX14.Name = "ucLabelX14";
            this.ucLabelX14.Size = new System.Drawing.Size(44, 18);
            this.ucLabelX14.TabIndex = 155;
            this.ucLabelX14.Text = "税率：";
            // 
            // ucLabelX15
            // 
            this.ucLabelX15.AutoSize = true;
            // 
            // 
            // 
            this.ucLabelX15.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ucLabelX15.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabelX15.ForeColor = System.Drawing.Color.Gray;
            this.ucLabelX15.Location = new System.Drawing.Point(27, 219);
            this.ucLabelX15.Name = "ucLabelX15";
            this.ucLabelX15.Size = new System.Drawing.Size(68, 18);
            this.ucLabelX15.TabIndex = 157;
            this.ucLabelX15.Text = "税金总额：";
            // 
            // txtAmount
            // 
            // 
            // 
            // 
            this.txtAmount.Border.Class = "TextBoxBorder";
            this.txtAmount.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtAmount.EnterToNextControl = false;
            this.txtAmount.Location = new System.Drawing.Point(353, 218);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.ReadOnly = true;
            this.txtAmount.Size = new System.Drawing.Size(150, 21);
            this.txtAmount.TabIndex = 15;
            // 
            // stiOrder
            // 
            this.stiOrder.AttachedControl = this.stcpOrder;
            this.stiOrder.GlobalItem = false;
            this.stiOrder.Name = "stiOrder";
            this.stiOrder.Text = "采购主单";
            // 
            // stcpOther
            // 
            this.stcpOther.Controls.Add(this.txtCreatedTime);
            this.stcpOther.Controls.Add(this.txtUpdatedTime);
            this.stcpOther.Controls.Add(this.txtApproveStatus);
            this.stcpOther.Controls.Add(this.ucLabelX53);
            this.stcpOther.Controls.Add(this.txtStatus);
            this.stcpOther.Controls.Add(this.ucLabelX52);
            this.stcpOther.Controls.Add(this.ucLabelX51);
            this.stcpOther.Controls.Add(this.txtUpdatedEmpName);
            this.stcpOther.Controls.Add(this.ucLabelX50);
            this.stcpOther.Controls.Add(this.ucLabelX49);
            this.stcpOther.Controls.Add(this.txtCreatedEmpName);
            this.stcpOther.Controls.Add(this.ucLabelX48);
            this.stcpOther.Controls.Add(this.txtPaymentStatus);
            this.stcpOther.Controls.Add(this.ucLabelX47);
            this.stcpOther.Controls.Add(this.txtReturnStatus);
            this.stcpOther.Controls.Add(this.ucLabelX46);
            this.stcpOther.Controls.Add(this.txtStkOutStatus);
            this.stcpOther.Controls.Add(this.ucLabelX44);
            this.stcpOther.Controls.Add(this.txtStkInStatus);
            this.stcpOther.Controls.Add(this.ucLabelX43);
            this.stcpOther.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stcpOther.Location = new System.Drawing.Point(0, 0);
            this.stcpOther.Name = "stcpOther";
            this.stcpOther.Size = new System.Drawing.Size(1020, 280);
            this.stcpOther.TabIndex = 0;
            this.stcpOther.TabItem = this.stiOther;
            // 
            // txtCreatedTime
            // 
            // 
            // 
            // 
            this.txtCreatedTime.Border.Class = "TextBoxBorder";
            this.txtCreatedTime.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCreatedTime.EnterToNextControl = false;
            this.txtCreatedTime.Location = new System.Drawing.Point(357, 37);
            this.txtCreatedTime.Name = "txtCreatedTime";
            this.txtCreatedTime.ReadOnly = true;
            this.txtCreatedTime.Size = new System.Drawing.Size(150, 21);
            this.txtCreatedTime.TabIndex = 5;
            // 
            // txtUpdatedTime
            // 
            // 
            // 
            // 
            this.txtUpdatedTime.Border.Class = "TextBoxBorder";
            this.txtUpdatedTime.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtUpdatedTime.EnterToNextControl = false;
            this.txtUpdatedTime.Location = new System.Drawing.Point(837, 37);
            this.txtUpdatedTime.Name = "txtUpdatedTime";
            this.txtUpdatedTime.ReadOnly = true;
            this.txtUpdatedTime.Size = new System.Drawing.Size(150, 21);
            this.txtUpdatedTime.TabIndex = 7;
            // 
            // txtApproveStatus
            // 
            // 
            // 
            // 
            this.txtApproveStatus.Border.Class = "TextBoxBorder";
            this.txtApproveStatus.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtApproveStatus.EnterToNextControl = false;
            this.txtApproveStatus.Location = new System.Drawing.Point(358, 64);
            this.txtApproveStatus.Name = "txtApproveStatus";
            this.txtApproveStatus.ReadOnly = true;
            this.txtApproveStatus.Size = new System.Drawing.Size(150, 21);
            this.txtApproveStatus.TabIndex = 9;
            // 
            // ucLabelX53
            // 
            // 
            // 
            // 
            this.ucLabelX53.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ucLabelX53.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabelX53.ForeColor = System.Drawing.Color.Gray;
            this.ucLabelX53.Location = new System.Drawing.Point(280, 64);
            this.ucLabelX53.Name = "ucLabelX53";
            this.ucLabelX53.Size = new System.Drawing.Size(66, 23);
            this.ucLabelX53.TabIndex = 214;
            this.ucLabelX53.Text = "审核状态：";
            // 
            // txtStatus
            // 
            // 
            // 
            // 
            this.txtStatus.Border.Class = "TextBoxBorder";
            this.txtStatus.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtStatus.EnterToNextControl = false;
            this.txtStatus.Location = new System.Drawing.Point(107, 64);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(150, 21);
            this.txtStatus.TabIndex = 8;
            // 
            // ucLabelX52
            // 
            // 
            // 
            // 
            this.ucLabelX52.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ucLabelX52.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabelX52.ForeColor = System.Drawing.Color.Gray;
            this.ucLabelX52.Location = new System.Drawing.Point(32, 64);
            this.ucLabelX52.Name = "ucLabelX52";
            this.ucLabelX52.Size = new System.Drawing.Size(66, 23);
            this.ucLabelX52.TabIndex = 212;
            this.ucLabelX52.Text = "单据状态：";
            // 
            // ucLabelX51
            // 
            // 
            // 
            // 
            this.ucLabelX51.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ucLabelX51.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabelX51.ForeColor = System.Drawing.Color.Gray;
            this.ucLabelX51.Location = new System.Drawing.Point(760, 35);
            this.ucLabelX51.Name = "ucLabelX51";
            this.ucLabelX51.Size = new System.Drawing.Size(66, 23);
            this.ucLabelX51.TabIndex = 211;
            this.ucLabelX51.Text = "修改时间：";
            // 
            // txtUpdatedEmpName
            // 
            // 
            // 
            // 
            this.txtUpdatedEmpName.Border.Class = "TextBoxBorder";
            this.txtUpdatedEmpName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtUpdatedEmpName.EnterToNextControl = false;
            this.txtUpdatedEmpName.Location = new System.Drawing.Point(599, 37);
            this.txtUpdatedEmpName.Name = "txtUpdatedEmpName";
            this.txtUpdatedEmpName.ReadOnly = true;
            this.txtUpdatedEmpName.Size = new System.Drawing.Size(150, 21);
            this.txtUpdatedEmpName.TabIndex = 6;
            // 
            // ucLabelX50
            // 
            // 
            // 
            // 
            this.ucLabelX50.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ucLabelX50.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabelX50.ForeColor = System.Drawing.Color.Gray;
            this.ucLabelX50.Location = new System.Drawing.Point(522, 37);
            this.ucLabelX50.Name = "ucLabelX50";
            this.ucLabelX50.Size = new System.Drawing.Size(66, 23);
            this.ucLabelX50.TabIndex = 209;
            this.ucLabelX50.Text = "修改人员：";
            // 
            // ucLabelX49
            // 
            // 
            // 
            // 
            this.ucLabelX49.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ucLabelX49.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabelX49.ForeColor = System.Drawing.Color.Gray;
            this.ucLabelX49.Location = new System.Drawing.Point(280, 37);
            this.ucLabelX49.Name = "ucLabelX49";
            this.ucLabelX49.Size = new System.Drawing.Size(66, 23);
            this.ucLabelX49.TabIndex = 208;
            this.ucLabelX49.Text = "创建时间：";
            // 
            // txtCreatedEmpName
            // 
            // 
            // 
            // 
            this.txtCreatedEmpName.Border.Class = "TextBoxBorder";
            this.txtCreatedEmpName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCreatedEmpName.EnterToNextControl = false;
            this.txtCreatedEmpName.Location = new System.Drawing.Point(107, 37);
            this.txtCreatedEmpName.Name = "txtCreatedEmpName";
            this.txtCreatedEmpName.ReadOnly = true;
            this.txtCreatedEmpName.Size = new System.Drawing.Size(150, 21);
            this.txtCreatedEmpName.TabIndex = 4;
            // 
            // ucLabelX48
            // 
            // 
            // 
            // 
            this.ucLabelX48.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ucLabelX48.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabelX48.ForeColor = System.Drawing.Color.Gray;
            this.ucLabelX48.Location = new System.Drawing.Point(32, 35);
            this.ucLabelX48.Name = "ucLabelX48";
            this.ucLabelX48.Size = new System.Drawing.Size(66, 23);
            this.ucLabelX48.TabIndex = 206;
            this.ucLabelX48.Text = "创建人员：";
            // 
            // txtPaymentStatus
            // 
            // 
            // 
            // 
            this.txtPaymentStatus.Border.Class = "TextBoxBorder";
            this.txtPaymentStatus.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPaymentStatus.EnterToNextControl = false;
            this.txtPaymentStatus.Location = new System.Drawing.Point(837, 10);
            this.txtPaymentStatus.Name = "txtPaymentStatus";
            this.txtPaymentStatus.ReadOnly = true;
            this.txtPaymentStatus.Size = new System.Drawing.Size(150, 21);
            this.txtPaymentStatus.TabIndex = 3;
            // 
            // ucLabelX47
            // 
            // 
            // 
            // 
            this.ucLabelX47.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ucLabelX47.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabelX47.ForeColor = System.Drawing.Color.Gray;
            this.ucLabelX47.Location = new System.Drawing.Point(760, 10);
            this.ucLabelX47.Name = "ucLabelX47";
            this.ucLabelX47.Size = new System.Drawing.Size(66, 23);
            this.ucLabelX47.TabIndex = 204;
            this.ucLabelX47.Text = "付款状态：";
            // 
            // txtReturnStatus
            // 
            // 
            // 
            // 
            this.txtReturnStatus.Border.Class = "TextBoxBorder";
            this.txtReturnStatus.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtReturnStatus.EnterToNextControl = false;
            this.txtReturnStatus.Location = new System.Drawing.Point(599, 10);
            this.txtReturnStatus.Name = "txtReturnStatus";
            this.txtReturnStatus.ReadOnly = true;
            this.txtReturnStatus.Size = new System.Drawing.Size(150, 21);
            this.txtReturnStatus.TabIndex = 2;
            // 
            // ucLabelX46
            // 
            // 
            // 
            // 
            this.ucLabelX46.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ucLabelX46.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabelX46.ForeColor = System.Drawing.Color.Gray;
            this.ucLabelX46.Location = new System.Drawing.Point(522, 10);
            this.ucLabelX46.Name = "ucLabelX46";
            this.ucLabelX46.Size = new System.Drawing.Size(66, 23);
            this.ucLabelX46.TabIndex = 202;
            this.ucLabelX46.Text = "退货状态：";
            // 
            // txtStkOutStatus
            // 
            // 
            // 
            // 
            this.txtStkOutStatus.Border.Class = "TextBoxBorder";
            this.txtStkOutStatus.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtStkOutStatus.EnterToNextControl = false;
            this.txtStkOutStatus.Location = new System.Drawing.Point(357, 10);
            this.txtStkOutStatus.Name = "txtStkOutStatus";
            this.txtStkOutStatus.ReadOnly = true;
            this.txtStkOutStatus.Size = new System.Drawing.Size(150, 21);
            this.txtStkOutStatus.TabIndex = 1;
            // 
            // ucLabelX44
            // 
            // 
            // 
            // 
            this.ucLabelX44.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ucLabelX44.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabelX44.ForeColor = System.Drawing.Color.Gray;
            this.ucLabelX44.Location = new System.Drawing.Point(280, 10);
            this.ucLabelX44.Name = "ucLabelX44";
            this.ucLabelX44.Size = new System.Drawing.Size(66, 23);
            this.ucLabelX44.TabIndex = 200;
            this.ucLabelX44.Text = "出库状态：";
            // 
            // txtStkInStatus
            // 
            // 
            // 
            // 
            this.txtStkInStatus.Border.Class = "TextBoxBorder";
            this.txtStkInStatus.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtStkInStatus.EnterToNextControl = false;
            this.txtStkInStatus.Location = new System.Drawing.Point(107, 10);
            this.txtStkInStatus.Name = "txtStkInStatus";
            this.txtStkInStatus.ReadOnly = true;
            this.txtStkInStatus.Size = new System.Drawing.Size(150, 21);
            this.txtStkInStatus.TabIndex = 0;
            // 
            // ucLabelX43
            // 
            // 
            // 
            // 
            this.ucLabelX43.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ucLabelX43.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabelX43.ForeColor = System.Drawing.Color.Gray;
            this.ucLabelX43.Location = new System.Drawing.Point(32, 8);
            this.ucLabelX43.Name = "ucLabelX43";
            this.ucLabelX43.Size = new System.Drawing.Size(66, 23);
            this.ucLabelX43.TabIndex = 198;
            this.ucLabelX43.Text = "入库状态：";
            // 
            // stiOther
            // 
            this.stiOther.AttachedControl = this.stcpOther;
            this.stiOther.GlobalItem = false;
            this.stiOther.Name = "stiOther";
            this.stiOther.Text = "其他信息";
            // 
            // ucPanel1
            // 
            this.ucPanel1.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel1.Controls.Add(this.tsOper);
            this.ucPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucPanel1.Location = new System.Drawing.Point(0, 0);
            this.ucPanel1.Name = "ucPanel1";
            this.ucPanel1.Size = new System.Drawing.Size(1020, 32);
            this.ucPanel1.TabIndex = 2;
            // 
            // tsOper
            // 
            this.tsOper.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tsOper.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.tsOper.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSave,
            this.toolStripSeparator2,
            this.tsbSubmit,
            this.tsbAudit,
            this.tsbUnDo,
            this.tsbImport,
            this.tsbExport,
            this.tsbPrint,
            this.tsbRefresh,
            this.tsbCancelBill,
            this.tsbTakeCancel,
            this.toolStripSeparator1,
            this.tsbClose});
            this.tsOper.Location = new System.Drawing.Point(0, 0);
            this.tsOper.Name = "tsOper";
            this.tsOper.Padding = new System.Windows.Forms.Padding(5);
            this.tsOper.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tsOper.Size = new System.Drawing.Size(1020, 36);
            this.tsOper.TabIndex = 1;
            this.tsOper.Text = "ucToolStrip1";
            // 
            // tsbSave
            // 
            this.tsbSave.Image = global::ZNLCRM.UI.Properties.Resources.save_1;
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(55, 23);
            this.tsbSave.Text = "保存";
            this.tsbSave.Click += new System.EventHandler(this.tsbSave_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 26);
            // 
            // tsbSubmit
            // 
            this.tsbSubmit.Image = global::ZNLCRM.UI.Properties.Resources.submit_1;
            this.tsbSubmit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSubmit.Name = "tsbSubmit";
            this.tsbSubmit.Size = new System.Drawing.Size(55, 23);
            this.tsbSubmit.Text = "提交";
            this.tsbSubmit.Click += new System.EventHandler(this.tsbSubmit_Click);
            // 
            // tsbAudit
            // 
            this.tsbAudit.Image = global::ZNLCRM.UI.Properties.Resources.audit;
            this.tsbAudit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAudit.Name = "tsbAudit";
            this.tsbAudit.Size = new System.Drawing.Size(55, 23);
            this.tsbAudit.Text = "审核";
            this.tsbAudit.Click += new System.EventHandler(this.tsbAudit_Click);
            // 
            // tsbUnDo
            // 
            this.tsbUnDo.Image = global::ZNLCRM.UI.Properties.Resources.undo;
            this.tsbUnDo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUnDo.Name = "tsbUnDo";
            this.tsbUnDo.Size = new System.Drawing.Size(55, 23);
            this.tsbUnDo.Text = "撤销";
            this.tsbUnDo.Click += new System.EventHandler(this.tsbUnDo_Click);
            // 
            // tsbImport
            // 
            this.tsbImport.Image = global::ZNLCRM.UI.Properties.Resources.import_1;
            this.tsbImport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbImport.Name = "tsbImport";
            this.tsbImport.Size = new System.Drawing.Size(55, 23);
            this.tsbImport.Text = "导入";
            this.tsbImport.Visible = false;
            // 
            // tsbExport
            // 
            this.tsbExport.Image = global::ZNLCRM.UI.Properties.Resources.export_1;
            this.tsbExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExport.Name = "tsbExport";
            this.tsbExport.Size = new System.Drawing.Size(55, 23);
            this.tsbExport.Text = "导出";
            this.tsbExport.Visible = false;
            // 
            // tsbPrint
            // 
            this.tsbPrint.Image = global::ZNLCRM.UI.Properties.Resources.print_1;
            this.tsbPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPrint.Name = "tsbPrint";
            this.tsbPrint.Size = new System.Drawing.Size(55, 23);
            this.tsbPrint.Text = "打印";
            // 
            // tsbRefresh
            // 
            this.tsbRefresh.Image = global::ZNLCRM.UI.Properties.Resources.refresh_1;
            this.tsbRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRefresh.Name = "tsbRefresh";
            this.tsbRefresh.Size = new System.Drawing.Size(55, 23);
            this.tsbRefresh.Text = "刷新";
            this.tsbRefresh.Visible = false;
            // 
            // tsbCancelBill
            // 
            this.tsbCancelBill.Image = global::ZNLCRM.UI.Properties.Resources.nopass2;
            this.tsbCancelBill.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCancelBill.Name = "tsbCancelBill";
            this.tsbCancelBill.Size = new System.Drawing.Size(81, 23);
            this.tsbCancelBill.Text = "取消订单";
            this.tsbCancelBill.Click += new System.EventHandler(this.tsbCancelBill_Click);
            // 
            // tsbTakeCancel
            // 
            this.tsbTakeCancel.Image = global::ZNLCRM.UI.Properties.Resources.returnsubmit;
            this.tsbTakeCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbTakeCancel.Name = "tsbTakeCancel";
            this.tsbTakeCancel.Size = new System.Drawing.Size(81, 23);
            this.tsbTakeCancel.Text = "收回取消";
            this.tsbTakeCancel.Click += new System.EventHandler(this.tsbTakeCancel_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 26);
            // 
            // tsbClose
            // 
            this.tsbClose.Image = global::ZNLCRM.UI.Properties.Resources.close;
            this.tsbClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbClose.Name = "tsbClose";
            this.tsbClose.Size = new System.Drawing.Size(55, 23);
            this.tsbClose.Text = "关闭";
            this.tsbClose.Click += new System.EventHandler(this.tsbClose_Click);
            // 
            // frmPurchaseOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 668);
            this.Controls.Add(this.ucPanel7);
            this.Controls.Add(this.ucPanel1);
            this.Name = "frmPurchaseOrder";
            this.Text = "采购单";
            this.Load += new System.EventHandler(this.frmPurchaseOrder_Load);
            this.ucPanel7.ResumeLayout(false);
            this.ucPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ustcLine)).EndInit();
            this.ustcLine.ResumeLayout(false);
            this.stcpConEntry.ResumeLayout(false);
            this.stcpLine.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseOrderLine)).EndInit();
            this.panDtlOpr.ResumeLayout(false);
            this.ucPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ustcOrder)).EndInit();
            this.ustcOrder.ResumeLayout(false);
            this.stcpOrder.ResumeLayout(false);
            this.stcpOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNeedDeliveryDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNeedPayAmtDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPODate)).EndInit();
            this.stcpOther.ResumeLayout(false);
            this.ucPanel1.ResumeLayout(false);
            this.ucPanel1.PerformLayout();
            this.tsOper.ResumeLayout(false);
            this.tsOper.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.UcToolStrip tsOper;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripButton tsbSubmit;
        private System.Windows.Forms.ToolStripButton tsbAudit;
        private System.Windows.Forms.ToolStripButton tsbUnDo;
        private System.Windows.Forms.ToolStripButton tsbImport;
        private System.Windows.Forms.ToolStripButton tsbExport;
        private System.Windows.Forms.ToolStripButton tsbPrint;
        private System.Windows.Forms.ToolStripButton tsbRefresh;
        private System.Windows.Forms.ToolStripButton tsbClose;
        private Controls.UcPanel ucPanel1;
        private Controls.UcPanel ucPanel2;
        private Controls.UcPanel ucPanel3;
        private Controls.UcPanel ucPanel7;
        private Controls.UcExpandableSplitter ucExpandableSplitter1;
        private Controls.UcSuperTabControl ustcOrder;
        private DevComponents.DotNetBar.SuperTabControlPanel stcpOther;
        private DevComponents.DotNetBar.SuperTabItem stiOther;
        private DevComponents.DotNetBar.SuperTabControlPanel stcpOrder;
        private DevComponents.DotNetBar.SuperTabItem stiOrder;
        private Controls.UcTextBox txtCreatedTime;
        private Controls.UcTextBox txtUpdatedTime;
        private Controls.UcTextBox txtApproveStatus;
        private Controls.UcLabelX ucLabelX53;
        private Controls.UcTextBox txtStatus;
        private Controls.UcLabelX ucLabelX52;
        private Controls.UcLabelX ucLabelX51;
        private Controls.UcTextBox txtUpdatedEmpName;
        private Controls.UcLabelX ucLabelX50;
        private Controls.UcLabelX ucLabelX49;
        private Controls.UcTextBox txtCreatedEmpName;
        private Controls.UcLabelX ucLabelX48;
        private Controls.UcTextBox txtPaymentStatus;
        private Controls.UcLabelX ucLabelX47;
        private Controls.UcTextBox txtReturnStatus;
        private Controls.UcLabelX ucLabelX46;
        private Controls.UcTextBox txtStkOutStatus;
        private Controls.UcLabelX ucLabelX44;
        private Controls.UcTextBox txtStkInStatus;
        private Controls.UcLabelX ucLabelX43;
        private Controls.UcTextBox txtPOGuid;
        private Controls.UcTextBox txtBuyerID;
        private Controls.UcTextBox txtPurDeptID;
        private Controls.UcTextBox txtSupplierID;
        private Controls.UcTextBox txtPOID;
        private Controls.UcDateTimeInput txtNeedDeliveryDate;
        private Controls.UcLabelX ucLabelX1;
        private Controls.UcLabelX ucLabelX29;
        private Controls.UcTextBox txtBillNo;
        private Controls.UcComboBox cboPurOrgID;
        private Controls.UcLabelX ucLabelX4;
        private Controls.UcTextBox txtPONumber;
        private Controls.UcTextBox txtBuyerName;
        private Controls.UcLabelX ucLabelX5;
        private Controls.UcDateTimeInput txtNeedPayAmtDate;
        private Controls.UcTextBox txtSupplierName;
        private Controls.UcLabelX ucLabelX38;
        private Controls.UcLabelX ucLabelX6;
        private Controls.UcTextBox txtAddress;
        private Controls.UcTextBox txtPurDeptName;
        private Controls.UcLabelX ucLabelX7;
        private Controls.UcTextBox txtContact;
        private Controls.UcLabelX ucLabelX37;
        private Controls.UcLabelX ucLabelX8;
        private Controls.UcTextBox txtTelephone;
        private Controls.UcLabelX ucLabelX36;
        private Controls.UcLabelX ucLabelX54;
        private Controls.UcLabelX ucLabelX18;
        private Controls.UcDateTimeInput txtPODate;
        private Controls.UcComboBox cboTaxRate;
        private Controls.UcLabelX ucLabelX11;
        private Controls.UcComboBox cboCurrency;
        private Controls.UcLabelX ucLabelX12;
        private Controls.UcComboBox cboClearingForm;
        private Controls.UcTextBox txtClearFormDay;
        private Controls.UcTextBox txtTaxAmount;
        private Controls.UcLabelX ucLabelX13;
        private Controls.UcLabelX ucLabelX16;
        private Controls.UcLabelX ucLabelX14;
        private Controls.UcLabelX ucLabelX15;
        private Controls.UcTextBox txtAmount;
        private Controls.UcSuperTabControl ustcLine;
        private DevComponents.DotNetBar.SuperTabControlPanel stcpLine;
        private Controls.UcDataGridView dgvPurchaseOrderLine;
        private Controls.UcPanel panDtlOpr;
        private Controls.UcCheckBox chkCalcType;
        private Controls.UcButton btnDelRow;
        private Controls.UcButton btnAddRow;
        private DevComponents.DotNetBar.SuperTabItem stiLine;
        private DevComponents.DotNetBar.SuperTabControlPanel stcpConEntry;
        private DevComponents.DotNetBar.SuperTabItem superTabItem2;
        private DevComponents.DotNetBar.SuperTabControlPanel stcpAttachFiles;
        private DevComponents.DotNetBar.SuperTabItem stiAttachFiles;
        private Controls.UcButton btnPaste;
        private Controls.UcButton btnImportByNotice;
        private Controls.UcComboBox cboInvType;
        private Controls.UcLabelX ucLabelX2;
        private Controls.UcButton btnImportByHistory;
        private Controls.UcButton btnImportByStock;
        private Controls.UcTextBox ucTextBox1;
        private Controls.UcLabelX ucLabelX3;
        private Controls.UcCheckBox chkIsInvoiced;
        private Controls.UcComboBox cboInvoiceType;
        private Controls.UcComboBox cboTransportCompany;
        private Controls.UcTextBox txtFreight;
        private Controls.UcLabelX ucLabelX28;
        private Controls.UcComboBox cboFreightClearForm;
        private Controls.UcLabelX ucLabelX27;
        private Controls.UcTextBox txtShippingNo;
        private Controls.UcLabelX ucLabelX26;
        private Controls.UcLabelX ucLabelX25;
        private Controls.UcButton btnInsertBefore;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colIsCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPOLineID;
        private System.Windows.Forms.DataGridViewTextBoxColumn POLineGuid;
        private DevComponents.DotNetBar.Controls.DataGridViewMaskedTextBoxAdvColumn colModel;
        private DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn colInvType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNTaxPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBrand;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPackage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBatch;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuality;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMPQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStkInQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOfferInQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStkOutQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReturnQty;
        private DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn colUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDemands;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRemark;
        private DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn colNeedDeliveryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFactDeliveryDate;
        private DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn colNeedPayAmtDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFactPayAmtDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPaymentAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNoticeGuid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSOGuid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSOBillNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSOLineGuid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSONeedDeliveryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSOLineCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSOQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSOModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSOBrand;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSOPackage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSOBatch;
        private Controls.UcSignature lblSignFlag;
        private Controls.UcTextBox txtIsCancel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbCancelBill;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbTakeCancel;
        private Controls.UcTextBox txtConEntry;
    }
}