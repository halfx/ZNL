namespace ZNLCRM.UI.STK
{
    partial class frmStkIn
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tsOper = new ZNLCRM.Controls.UcToolStrip(this.components);
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbSubmit = new System.Windows.Forms.ToolStripButton();
            this.tsbAudit = new System.Windows.Forms.ToolStripButton();
            this.tsbUnDo = new System.Windows.Forms.ToolStripButton();
            this.tsbImport = new System.Windows.Forms.ToolStripButton();
            this.tsbExport = new System.Windows.Forms.ToolStripButton();
            this.tsbPrint = new System.Windows.Forms.ToolStripButton();
            this.tsbRefresh = new System.Windows.Forms.ToolStripButton();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.ucPanel1 = new ZNLCRM.Controls.UcPanel(this.components);
            this.ucPanel4 = new ZNLCRM.Controls.UcPanel(this.components);
            this.ustcStkInLine = new ZNLCRM.Controls.UcSuperTabControl(this.components);
            this.stcpStkInLine = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.panDtlGrid = new ZNLCRM.Controls.UcPanel(this.components);
            this.dgvStkInLine = new ZNLCRM.Controls.UcDataGridView(this.components);
            this.colAddGive = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colIsGive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colStkInLineGuid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSourceBillLineGuid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSOLineGuid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colModel = new DevComponents.DotNetBar.Controls.DataGridViewMaskedTextBoxAdvColumn();
            this.colQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFreight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCostPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSCAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTaxRate = new DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn();
            this.colPaymentAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPayAmtDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBrand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPackage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBatch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMPQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInvType = new DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn();
            this.colWarehouse = new DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn();
            this.colLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStkOutQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnit = new DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn();
            this.colCurrency = new DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn();
            this.colExchangeRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDemands = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRemark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsCut = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colIsPCut = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colIsRaiseTaxes = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panDtlBtn = new ZNLCRM.Controls.UcPanel(this.components);
            this.btnInsertBefore = new ZNLCRM.Controls.UcButton(this.components);
            this.btnImportSourceLine = new ZNLCRM.Controls.UcButton(this.components);
            this.btnDelRow = new ZNLCRM.Controls.UcButton(this.components);
            this.btnAddRow = new ZNLCRM.Controls.UcButton(this.components);
            this.stiStkInLine = new DevComponents.DotNetBar.SuperTabItem();
            this.stcpAttach = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.stiAttach = new DevComponents.DotNetBar.SuperTabItem();
            this.ucExpandableSplitter1 = new ZNLCRM.Controls.UcExpandableSplitter(this.components);
            this.ucPanel3 = new ZNLCRM.Controls.UcPanel(this.components);
            this.ustcStKIn = new ZNLCRM.Controls.UcSuperTabControl(this.components);
            this.stcpStkIn = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.txtExchangeRate = new ZNLCRM.Controls.UcTextBox(this.components);
            this.cboCurrency = new ZNLCRM.Controls.UcComboBox(this.components);
            this.txtTaxAmount = new ZNLCRM.Controls.UcTextBox(this.components);
            this.cboTaxRate = new ZNLCRM.Controls.UcComboBox(this.components);
            this.ucLabelX4 = new ZNLCRM.Controls.UcLabelX(this.components);
            this.ucLabelX5 = new ZNLCRM.Controls.UcLabelX(this.components);
            this.ucLabelX6 = new ZNLCRM.Controls.UcLabelX(this.components);
            this.ucLabelX13 = new ZNLCRM.Controls.UcLabelX(this.components);
            this.txtReceiverID = new ZNLCRM.Controls.UcTextBox(this.components);
            this.txtOperEmpID = new ZNLCRM.Controls.UcTextBox(this.components);
            this.txtOperDeptID = new ZNLCRM.Controls.UcTextBox(this.components);
            this.txtSourceBillGuid = new ZNLCRM.Controls.UcTextBox(this.components);
            this.txtUpdatedTime = new ZNLCRM.Controls.UcTextBox(this.components);
            this.txtSCAmount = new ZNLCRM.Controls.UcTextBox(this.components);
            this.txtInDate = new ZNLCRM.Controls.UcDateTimeInput(this.components);
            this.txtApproveStatus = new ZNLCRM.Controls.UcTextBox(this.components);
            this.ucLabelX21 = new ZNLCRM.Controls.UcLabelX(this.components);
            this.txtStatus = new ZNLCRM.Controls.UcTextBox(this.components);
            this.txtStkInGuid = new ZNLCRM.Controls.UcTextBox(this.components);
            this.txtReceiverName = new ZNLCRM.Controls.UcTextBox(this.components);
            this.cboOperOrgID = new ZNLCRM.Controls.UcComboBox(this.components);
            this.txtOperEmpName = new ZNLCRM.Controls.UcTextBox(this.components);
            this.ucLabelX18 = new ZNLCRM.Controls.UcLabelX(this.components);
            this.txtOperDeptName = new ZNLCRM.Controls.UcTextBox(this.components);
            this.ucLabelX17 = new ZNLCRM.Controls.UcLabelX(this.components);
            this.ucLabelX16 = new ZNLCRM.Controls.UcLabelX(this.components);
            this.ucLabelX15 = new ZNLCRM.Controls.UcLabelX(this.components);
            this.txtPaymentAmount = new ZNLCRM.Controls.UcTextBox(this.components);
            this.ucLabelX14 = new ZNLCRM.Controls.UcLabelX(this.components);
            this.ucLabelX12 = new ZNLCRM.Controls.UcLabelX(this.components);
            this.ucLabelX11 = new ZNLCRM.Controls.UcLabelX(this.components);
            this.txtUpdatedEmpName = new ZNLCRM.Controls.UcTextBox(this.components);
            this.ucLabelX10 = new ZNLCRM.Controls.UcLabelX(this.components);
            this.txtCreatedTime = new ZNLCRM.Controls.UcTextBox(this.components);
            this.ucLabelX9 = new ZNLCRM.Controls.UcLabelX(this.components);
            this.txtCreatedEmpName = new ZNLCRM.Controls.UcTextBox(this.components);
            this.ucLabelX8 = new ZNLCRM.Controls.UcLabelX(this.components);
            this.txtRemark = new ZNLCRM.Controls.UcTextBox(this.components);
            this.ucLabelX7 = new ZNLCRM.Controls.UcLabelX(this.components);
            this.txtAmount = new ZNLCRM.Controls.UcTextBox(this.components);
            this.ucLabelX3 = new ZNLCRM.Controls.UcLabelX(this.components);
            this.ucLabelX54 = new ZNLCRM.Controls.UcLabelX(this.components);
            this.txtSourceBillNo = new ZNLCRM.Controls.UcTextBox(this.components);
            this.ucLabelX37 = new ZNLCRM.Controls.UcLabelX(this.components);
            this.cboBillType = new ZNLCRM.Controls.UcComboBox(this.components);
            this.ucLabelX2 = new ZNLCRM.Controls.UcLabelX(this.components);
            this.ucLabelX1 = new ZNLCRM.Controls.UcLabelX(this.components);
            this.txtBillNo = new ZNLCRM.Controls.UcTextBox(this.components);
            this.stiStkIn = new DevComponents.DotNetBar.SuperTabItem();
            this.ucPanel2 = new ZNLCRM.Controls.UcPanel(this.components);
            this.tsOper.SuspendLayout();
            this.ucPanel1.SuspendLayout();
            this.ucPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ustcStkInLine)).BeginInit();
            this.ustcStkInLine.SuspendLayout();
            this.stcpStkInLine.SuspendLayout();
            this.panDtlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStkInLine)).BeginInit();
            this.panDtlBtn.SuspendLayout();
            this.ucPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ustcStKIn)).BeginInit();
            this.ustcStKIn.SuspendLayout();
            this.stcpStkIn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtInDate)).BeginInit();
            this.ucPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsOper
            // 
            this.tsOper.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tsOper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tsOper.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.tsOper.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSave,
            this.tsbSubmit,
            this.tsbAudit,
            this.tsbUnDo,
            this.tsbImport,
            this.tsbExport,
            this.tsbPrint,
            this.tsbRefresh,
            this.tsbClose});
            this.tsOper.Location = new System.Drawing.Point(0, 0);
            this.tsOper.Name = "tsOper";
            this.tsOper.Padding = new System.Windows.Forms.Padding(5);
            this.tsOper.Size = new System.Drawing.Size(1037, 41);
            this.tsOper.TabIndex = 2;
            this.tsOper.Text = "ucToolStrip1";
            // 
            // tsbSave
            // 
            this.tsbSave.Image = global::ZNLCRM.UI.Properties.Resources.save_1;
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(55, 28);
            this.tsbSave.Text = "保存";
            this.tsbSave.Click += new System.EventHandler(this.tsbSave_Click);
            // 
            // tsbSubmit
            // 
            this.tsbSubmit.Image = global::ZNLCRM.UI.Properties.Resources.submit_1;
            this.tsbSubmit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSubmit.Name = "tsbSubmit";
            this.tsbSubmit.Size = new System.Drawing.Size(55, 28);
            this.tsbSubmit.Text = "提交";
            this.tsbSubmit.Click += new System.EventHandler(this.tsbSubmit_Click);
            // 
            // tsbAudit
            // 
            this.tsbAudit.Image = global::ZNLCRM.UI.Properties.Resources.audit;
            this.tsbAudit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAudit.Name = "tsbAudit";
            this.tsbAudit.Size = new System.Drawing.Size(55, 28);
            this.tsbAudit.Text = "审核";
            this.tsbAudit.Click += new System.EventHandler(this.tsbAudit_Click);
            // 
            // tsbUnDo
            // 
            this.tsbUnDo.Image = global::ZNLCRM.UI.Properties.Resources.undo;
            this.tsbUnDo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUnDo.Name = "tsbUnDo";
            this.tsbUnDo.Size = new System.Drawing.Size(55, 28);
            this.tsbUnDo.Text = "撤销";
            this.tsbUnDo.Click += new System.EventHandler(this.tsbUnDo_Click);
            // 
            // tsbImport
            // 
            this.tsbImport.Image = global::ZNLCRM.UI.Properties.Resources.import_1;
            this.tsbImport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbImport.Name = "tsbImport";
            this.tsbImport.Size = new System.Drawing.Size(55, 28);
            this.tsbImport.Text = "导入";
            this.tsbImport.Visible = false;
            // 
            // tsbExport
            // 
            this.tsbExport.Image = global::ZNLCRM.UI.Properties.Resources.export_1;
            this.tsbExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExport.Name = "tsbExport";
            this.tsbExport.Size = new System.Drawing.Size(55, 28);
            this.tsbExport.Text = "导出";
            this.tsbExport.Visible = false;
            // 
            // tsbPrint
            // 
            this.tsbPrint.Image = global::ZNLCRM.UI.Properties.Resources.print_1;
            this.tsbPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPrint.Name = "tsbPrint";
            this.tsbPrint.Size = new System.Drawing.Size(55, 28);
            this.tsbPrint.Text = "打印";
            // 
            // tsbRefresh
            // 
            this.tsbRefresh.Image = global::ZNLCRM.UI.Properties.Resources.refresh_1;
            this.tsbRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRefresh.Name = "tsbRefresh";
            this.tsbRefresh.Size = new System.Drawing.Size(55, 28);
            this.tsbRefresh.Text = "刷新";
            this.tsbRefresh.Visible = false;
            // 
            // tsbClose
            // 
            this.tsbClose.Image = global::ZNLCRM.UI.Properties.Resources.close;
            this.tsbClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbClose.Name = "tsbClose";
            this.tsbClose.Size = new System.Drawing.Size(55, 28);
            this.tsbClose.Text = "关闭";
            this.tsbClose.Click += new System.EventHandler(this.tsbClose_Click);
            // 
            // ucPanel1
            // 
            this.ucPanel1.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel1.Controls.Add(this.ucPanel4);
            this.ucPanel1.Controls.Add(this.ucExpandableSplitter1);
            this.ucPanel1.Controls.Add(this.ucPanel3);
            this.ucPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPanel1.Location = new System.Drawing.Point(0, 41);
            this.ucPanel1.Name = "ucPanel1";
            this.ucPanel1.Size = new System.Drawing.Size(1037, 621);
            this.ucPanel1.TabIndex = 4;
            // 
            // ucPanel4
            // 
            this.ucPanel4.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel4.Controls.Add(this.ustcStkInLine);
            this.ucPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPanel4.Location = new System.Drawing.Point(0, 251);
            this.ucPanel4.Name = "ucPanel4";
            this.ucPanel4.Size = new System.Drawing.Size(1037, 370);
            this.ucPanel4.TabIndex = 7;
            // 
            // ustcStkInLine
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.ustcStkInLine.ControlBox.CloseBox.Name = "";
            // 
            // 
            // 
            this.ustcStkInLine.ControlBox.MenuBox.Name = "";
            this.ustcStkInLine.ControlBox.Name = "";
            this.ustcStkInLine.ControlBox.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ustcStkInLine.ControlBox.MenuBox,
            this.ustcStkInLine.ControlBox.CloseBox});
            this.ustcStkInLine.Controls.Add(this.stcpStkInLine);
            this.ustcStkInLine.Controls.Add(this.stcpAttach);
            this.ustcStkInLine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ustcStkInLine.Location = new System.Drawing.Point(0, 0);
            this.ustcStkInLine.Name = "ustcStkInLine";
            this.ustcStkInLine.ReorderTabsEnabled = true;
            this.ustcStkInLine.SelectedTabFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold);
            this.ustcStkInLine.SelectedTabIndex = 0;
            this.ustcStkInLine.Size = new System.Drawing.Size(1037, 370);
            this.ustcStkInLine.TabFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ustcStkInLine.TabIndex = 5;
            this.ustcStkInLine.Tabs.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.stiStkInLine,
            this.stiAttach});
            this.ustcStkInLine.Text = "ucSuperTabControl1";
            // 
            // stcpStkInLine
            // 
            this.stcpStkInLine.Controls.Add(this.panDtlGrid);
            this.stcpStkInLine.Controls.Add(this.panDtlBtn);
            this.stcpStkInLine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stcpStkInLine.Location = new System.Drawing.Point(0, 28);
            this.stcpStkInLine.Name = "stcpStkInLine";
            this.stcpStkInLine.Size = new System.Drawing.Size(1037, 342);
            this.stcpStkInLine.TabIndex = 1;
            this.stcpStkInLine.TabItem = this.stiStkInLine;
            // 
            // panDtlGrid
            // 
            this.panDtlGrid.BackColor = System.Drawing.Color.Transparent;
            this.panDtlGrid.Controls.Add(this.dgvStkInLine);
            this.panDtlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panDtlGrid.Location = new System.Drawing.Point(0, 30);
            this.panDtlGrid.Name = "panDtlGrid";
            this.panDtlGrid.Size = new System.Drawing.Size(1037, 312);
            this.panDtlGrid.TabIndex = 7;
            // 
            // dgvStkInLine
            // 
            this.dgvStkInLine.AllowUserToAddRows = false;
            this.dgvStkInLine.AllowUserToDeleteRows = false;
            this.dgvStkInLine.AllowUserToOrderColumns = true;
            this.dgvStkInLine.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStkInLine.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvStkInLine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStkInLine.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colAddGive,
            this.colIsGive,
            this.colStkInLineGuid,
            this.colSourceBillLineGuid,
            this.colSOLineGuid,
            this.colItemCode,
            this.colModel,
            this.colQty,
            this.colUnitPrice,
            this.colFreight,
            this.colCostPrice,
            this.colAmount,
            this.colSCAmount,
            this.colTaxRate,
            this.colPaymentAmount,
            this.colPayAmtDate,
            this.colBrand,
            this.colPackage,
            this.colBatch,
            this.colQuality,
            this.colMPQ,
            this.colInvType,
            this.colWarehouse,
            this.colLocation,
            this.colStkOutQty,
            this.colUnit,
            this.colCurrency,
            this.colExchangeRate,
            this.colDemands,
            this.colRemark,
            this.colIsCut,
            this.colIsPCut,
            this.colIsRaiseTaxes});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStkInLine.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvStkInLine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStkInLine.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvStkInLine.HighlightSelectedColumnHeaders = false;
            this.dgvStkInLine.Location = new System.Drawing.Point(0, 0);
            this.dgvStkInLine.Name = "dgvStkInLine";
            this.dgvStkInLine.PaintEnhancedSelection = false;
            this.dgvStkInLine.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvStkInLine.RowHeadersWidth = 40;
            this.dgvStkInLine.RowTemplate.Height = 23;
            this.dgvStkInLine.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStkInLine.SelectAllSignVisible = false;
            this.dgvStkInLine.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvStkInLine.ShowRowNo = true;
            this.dgvStkInLine.Size = new System.Drawing.Size(1037, 312);
            this.dgvStkInLine.TabIndex = 5;
            this.dgvStkInLine.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStkInLine_CellContentClick);
            this.dgvStkInLine.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvStkInLine_CellFormatting);
            this.dgvStkInLine.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStkInLine_CellValueChanged);
            this.dgvStkInLine.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvStkInLine_DataBindingComplete);
            // 
            // colAddGive
            // 
            this.colAddGive.DataPropertyName = "colAddGive";
            this.colAddGive.HeaderText = "操作";
            this.colAddGive.Name = "colAddGive";
            this.colAddGive.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colAddGive.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colAddGive.Text = "添加赠送";
            this.colAddGive.UseColumnTextForLinkValue = true;
            this.colAddGive.Width = 80;
            // 
            // colIsGive
            // 
            this.colIsGive.DataPropertyName = "IsGive";
            this.colIsGive.HeaderText = "赠？";
            this.colIsGive.Name = "colIsGive";
            this.colIsGive.ReadOnly = true;
            this.colIsGive.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colIsGive.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colIsGive.Width = 35;
            // 
            // colStkInLineGuid
            // 
            this.colStkInLineGuid.DataPropertyName = "StkInLineGuid";
            this.colStkInLineGuid.HeaderText = "StkInLineGuid";
            this.colStkInLineGuid.Name = "colStkInLineGuid";
            this.colStkInLineGuid.Visible = false;
            // 
            // colSourceBillLineGuid
            // 
            this.colSourceBillLineGuid.DataPropertyName = "SourceBillLineGuid";
            this.colSourceBillLineGuid.HeaderText = "SourceBillLineGuid";
            this.colSourceBillLineGuid.Name = "colSourceBillLineGuid";
            this.colSourceBillLineGuid.Visible = false;
            // 
            // colSOLineGuid
            // 
            this.colSOLineGuid.DataPropertyName = "SOLineGuid";
            this.colSOLineGuid.HeaderText = "销售明细ID";
            this.colSOLineGuid.Name = "colSOLineGuid";
            this.colSOLineGuid.Visible = false;
            // 
            // colItemCode
            // 
            this.colItemCode.DataPropertyName = "ItemCode";
            this.colItemCode.HeaderText = "ItemCode";
            this.colItemCode.Name = "colItemCode";
            this.colItemCode.Visible = false;
            // 
            // colModel
            // 
            this.colModel.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.colModel.BackgroundStyle.Class = "DataGridViewBorder";
            this.colModel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.colModel.ButtonClear.Visible = true;
            this.colModel.ButtonCustom.Visible = true;
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
            this.colModel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colModel.Text = "";
            // 
            // colQty
            // 
            this.colQty.DataPropertyName = "Qty";
            this.colQty.HeaderText = "入库数量";
            this.colQty.Name = "colQty";
            // 
            // colUnitPrice
            // 
            this.colUnitPrice.DataPropertyName = "UnitPrice";
            this.colUnitPrice.HeaderText = "采购单价";
            this.colUnitPrice.Name = "colUnitPrice";
            // 
            // colFreight
            // 
            this.colFreight.DataPropertyName = "Freight";
            this.colFreight.HeaderText = "运费单价";
            this.colFreight.Name = "colFreight";
            // 
            // colCostPrice
            // 
            this.colCostPrice.DataPropertyName = "CostPrice";
            this.colCostPrice.HeaderText = "成本单价";
            this.colCostPrice.Name = "colCostPrice";
            this.colCostPrice.ReadOnly = true;
            // 
            // colAmount
            // 
            this.colAmount.DataPropertyName = "Amount";
            this.colAmount.HeaderText = "小计金额";
            this.colAmount.Name = "colAmount";
            this.colAmount.ReadOnly = true;
            // 
            // colSCAmount
            // 
            this.colSCAmount.DataPropertyName = "SCAmount";
            this.colSCAmount.HeaderText = "本币金额";
            this.colSCAmount.Name = "colSCAmount";
            this.colSCAmount.ReadOnly = true;
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
            this.colTaxRate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colTaxRate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // colPaymentAmount
            // 
            this.colPaymentAmount.DataPropertyName = "PaymentAmount";
            this.colPaymentAmount.HeaderText = "已付款金额";
            this.colPaymentAmount.Name = "colPaymentAmount";
            this.colPaymentAmount.ReadOnly = true;
            // 
            // colPayAmtDate
            // 
            this.colPayAmtDate.HeaderText = "付款日期";
            this.colPayAmtDate.Name = "colPayAmtDate";
            this.colPayAmtDate.ReadOnly = true;
            // 
            // colBrand
            // 
            this.colBrand.DataPropertyName = "Brand";
            this.colBrand.HeaderText = "厂商";
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
            this.colInvType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colInvType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // colWarehouse
            // 
            this.colWarehouse.DataPropertyName = "Warehouse";
            this.colWarehouse.DropDownHeight = 106;
            this.colWarehouse.DropDownWidth = 121;
            this.colWarehouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colWarehouse.HeaderText = "仓库";
            this.colWarehouse.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.colWarehouse.IntegralHeight = false;
            this.colWarehouse.ItemHeight = 16;
            this.colWarehouse.Name = "colWarehouse";
            this.colWarehouse.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colWarehouse.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // colLocation
            // 
            this.colLocation.DataPropertyName = "Location";
            this.colLocation.HeaderText = "位置";
            this.colLocation.Name = "colLocation";
            // 
            // colStkOutQty
            // 
            this.colStkOutQty.DataPropertyName = "StkOutQty";
            this.colStkOutQty.HeaderText = "出库数量";
            this.colStkOutQty.Name = "colStkOutQty";
            this.colStkOutQty.ReadOnly = true;
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
            // colExchangeRate
            // 
            this.colExchangeRate.DataPropertyName = "ExchangeRate";
            this.colExchangeRate.HeaderText = "汇率";
            this.colExchangeRate.Name = "colExchangeRate";
            this.colExchangeRate.ReadOnly = true;
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
            // colIsCut
            // 
            this.colIsCut.DataPropertyName = "IsCut";
            this.colIsCut.HeaderText = "纳入销售提成";
            this.colIsCut.Name = "colIsCut";
            this.colIsCut.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colIsCut.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colIsCut.Visible = false;
            // 
            // colIsPCut
            // 
            this.colIsPCut.DataPropertyName = "IsPCut";
            this.colIsPCut.HeaderText = "纳入采购提成";
            this.colIsPCut.Name = "colIsPCut";
            this.colIsPCut.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colIsPCut.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colIsPCut.Visible = false;
            // 
            // colIsRaiseTaxes
            // 
            this.colIsRaiseTaxes.DataPropertyName = "IsRaiseTaxes";
            this.colIsRaiseTaxes.HeaderText = "是否已提税金";
            this.colIsRaiseTaxes.Name = "colIsRaiseTaxes";
            this.colIsRaiseTaxes.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colIsRaiseTaxes.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colIsRaiseTaxes.Visible = false;
            // 
            // panDtlBtn
            // 
            this.panDtlBtn.BackColor = System.Drawing.Color.Transparent;
            this.panDtlBtn.Controls.Add(this.btnInsertBefore);
            this.panDtlBtn.Controls.Add(this.btnImportSourceLine);
            this.panDtlBtn.Controls.Add(this.btnDelRow);
            this.panDtlBtn.Controls.Add(this.btnAddRow);
            this.panDtlBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.panDtlBtn.Location = new System.Drawing.Point(0, 0);
            this.panDtlBtn.Name = "panDtlBtn";
            this.panDtlBtn.Size = new System.Drawing.Size(1037, 30);
            this.panDtlBtn.TabIndex = 6;
            // 
            // btnInsertBefore
            // 
            this.btnInsertBefore.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnInsertBefore.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnInsertBefore.Image = global::ZNLCRM.UI.Properties.Resources.add_4;
            this.btnInsertBefore.Location = new System.Drawing.Point(189, 5);
            this.btnInsertBefore.Name = "btnInsertBefore";
            this.btnInsertBefore.Size = new System.Drawing.Size(81, 23);
            this.btnInsertBefore.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnInsertBefore.TabIndex = 8;
            this.btnInsertBefore.Text = "插入一行";
            this.btnInsertBefore.Click += new System.EventHandler(this.btnInsertBefore_Click);
            // 
            // btnImportSourceLine
            // 
            this.btnImportSourceLine.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnImportSourceLine.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnImportSourceLine.Image = global::ZNLCRM.UI.Properties.Resources.add_4;
            this.btnImportSourceLine.Location = new System.Drawing.Point(276, 5);
            this.btnImportSourceLine.Name = "btnImportSourceLine";
            this.btnImportSourceLine.Size = new System.Drawing.Size(100, 23);
            this.btnImportSourceLine.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnImportSourceLine.TabIndex = 3;
            this.btnImportSourceLine.Text = "导入关联明细";
            this.btnImportSourceLine.Click += new System.EventHandler(this.btnImportSourceLine_Click);
            // 
            // btnDelRow
            // 
            this.btnDelRow.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDelRow.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDelRow.Image = global::ZNLCRM.UI.Properties.Resources.del_4;
            this.btnDelRow.Location = new System.Drawing.Point(93, 5);
            this.btnDelRow.Name = "btnDelRow";
            this.btnDelRow.Size = new System.Drawing.Size(90, 23);
            this.btnDelRow.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDelRow.TabIndex = 2;
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
            this.btnAddRow.TabIndex = 1;
            this.btnAddRow.Text = "新增一行";
            this.btnAddRow.Click += new System.EventHandler(this.btnAddRow_Click);
            // 
            // stiStkInLine
            // 
            this.stiStkInLine.AttachedControl = this.stcpStkInLine;
            this.stiStkInLine.GlobalItem = false;
            this.stiStkInLine.Name = "stiStkInLine";
            this.stiStkInLine.Text = "入库明细";
            // 
            // stcpAttach
            // 
            this.stcpAttach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stcpAttach.Location = new System.Drawing.Point(0, 0);
            this.stcpAttach.Name = "stcpAttach";
            this.stcpAttach.Size = new System.Drawing.Size(1037, 370);
            this.stcpAttach.TabIndex = 0;
            this.stcpAttach.TabItem = this.stiAttach;
            // 
            // stiAttach
            // 
            this.stiAttach.AttachedControl = this.stcpAttach;
            this.stiAttach.GlobalItem = false;
            this.stiAttach.Name = "stiAttach";
            this.stiAttach.Text = "相关附件";
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
            this.ucExpandableSplitter1.Location = new System.Drawing.Point(0, 248);
            this.ucExpandableSplitter1.Name = "ucExpandableSplitter1";
            this.ucExpandableSplitter1.Size = new System.Drawing.Size(1037, 3);
            this.ucExpandableSplitter1.Style = DevComponents.DotNetBar.eSplitterStyle.Office2007;
            this.ucExpandableSplitter1.TabIndex = 5;
            this.ucExpandableSplitter1.TabStop = false;
            // 
            // ucPanel3
            // 
            this.ucPanel3.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel3.Controls.Add(this.ustcStKIn);
            this.ucPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucPanel3.Location = new System.Drawing.Point(0, 0);
            this.ucPanel3.Name = "ucPanel3";
            this.ucPanel3.Size = new System.Drawing.Size(1037, 248);
            this.ucPanel3.TabIndex = 6;
            // 
            // ustcStKIn
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.ustcStKIn.ControlBox.CloseBox.Name = "";
            // 
            // 
            // 
            this.ustcStKIn.ControlBox.MenuBox.Name = "";
            this.ustcStKIn.ControlBox.Name = "";
            this.ustcStKIn.ControlBox.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ustcStKIn.ControlBox.MenuBox,
            this.ustcStKIn.ControlBox.CloseBox});
            this.ustcStKIn.Controls.Add(this.stcpStkIn);
            this.ustcStKIn.Location = new System.Drawing.Point(0, 0);
            this.ustcStKIn.Name = "ustcStKIn";
            this.ustcStKIn.ReorderTabsEnabled = true;
            this.ustcStKIn.SelectedTabFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold);
            this.ustcStKIn.SelectedTabIndex = 0;
            this.ustcStKIn.Size = new System.Drawing.Size(1037, 242);
            this.ustcStKIn.TabFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ustcStKIn.TabIndex = 4;
            this.ustcStKIn.Tabs.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.stiStkIn});
            this.ustcStKIn.Text = "ucSuperTabControl1";
            // 
            // stcpStkIn
            // 
            this.stcpStkIn.Controls.Add(this.txtExchangeRate);
            this.stcpStkIn.Controls.Add(this.cboCurrency);
            this.stcpStkIn.Controls.Add(this.txtTaxAmount);
            this.stcpStkIn.Controls.Add(this.cboTaxRate);
            this.stcpStkIn.Controls.Add(this.ucLabelX4);
            this.stcpStkIn.Controls.Add(this.ucLabelX5);
            this.stcpStkIn.Controls.Add(this.ucLabelX6);
            this.stcpStkIn.Controls.Add(this.ucLabelX13);
            this.stcpStkIn.Controls.Add(this.txtReceiverID);
            this.stcpStkIn.Controls.Add(this.txtOperEmpID);
            this.stcpStkIn.Controls.Add(this.txtOperDeptID);
            this.stcpStkIn.Controls.Add(this.txtSourceBillGuid);
            this.stcpStkIn.Controls.Add(this.txtUpdatedTime);
            this.stcpStkIn.Controls.Add(this.txtSCAmount);
            this.stcpStkIn.Controls.Add(this.txtInDate);
            this.stcpStkIn.Controls.Add(this.txtApproveStatus);
            this.stcpStkIn.Controls.Add(this.ucLabelX21);
            this.stcpStkIn.Controls.Add(this.txtStatus);
            this.stcpStkIn.Controls.Add(this.txtStkInGuid);
            this.stcpStkIn.Controls.Add(this.txtReceiverName);
            this.stcpStkIn.Controls.Add(this.cboOperOrgID);
            this.stcpStkIn.Controls.Add(this.txtOperEmpName);
            this.stcpStkIn.Controls.Add(this.ucLabelX18);
            this.stcpStkIn.Controls.Add(this.txtOperDeptName);
            this.stcpStkIn.Controls.Add(this.ucLabelX17);
            this.stcpStkIn.Controls.Add(this.ucLabelX16);
            this.stcpStkIn.Controls.Add(this.ucLabelX15);
            this.stcpStkIn.Controls.Add(this.txtPaymentAmount);
            this.stcpStkIn.Controls.Add(this.ucLabelX14);
            this.stcpStkIn.Controls.Add(this.ucLabelX12);
            this.stcpStkIn.Controls.Add(this.ucLabelX11);
            this.stcpStkIn.Controls.Add(this.txtUpdatedEmpName);
            this.stcpStkIn.Controls.Add(this.ucLabelX10);
            this.stcpStkIn.Controls.Add(this.txtCreatedTime);
            this.stcpStkIn.Controls.Add(this.ucLabelX9);
            this.stcpStkIn.Controls.Add(this.txtCreatedEmpName);
            this.stcpStkIn.Controls.Add(this.ucLabelX8);
            this.stcpStkIn.Controls.Add(this.txtRemark);
            this.stcpStkIn.Controls.Add(this.ucLabelX7);
            this.stcpStkIn.Controls.Add(this.txtAmount);
            this.stcpStkIn.Controls.Add(this.ucLabelX3);
            this.stcpStkIn.Controls.Add(this.ucLabelX54);
            this.stcpStkIn.Controls.Add(this.txtSourceBillNo);
            this.stcpStkIn.Controls.Add(this.ucLabelX37);
            this.stcpStkIn.Controls.Add(this.cboBillType);
            this.stcpStkIn.Controls.Add(this.ucLabelX2);
            this.stcpStkIn.Controls.Add(this.ucLabelX1);
            this.stcpStkIn.Controls.Add(this.txtBillNo);
            this.stcpStkIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stcpStkIn.Location = new System.Drawing.Point(0, 28);
            this.stcpStkIn.Name = "stcpStkIn";
            this.stcpStkIn.Size = new System.Drawing.Size(1037, 214);
            this.stcpStkIn.TabIndex = 1;
            this.stcpStkIn.TabItem = this.stiStkIn;
            // 
            // txtExchangeRate
            // 
            // 
            // 
            // 
            this.txtExchangeRate.Border.Class = "TextBoxBorder";
            this.txtExchangeRate.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtExchangeRate.EnterToNextControl = false;
            this.txtExchangeRate.Location = new System.Drawing.Point(865, 35);
            this.txtExchangeRate.Name = "txtExchangeRate";
            this.txtExchangeRate.PreventEnterBeep = true;
            this.txtExchangeRate.ReadOnly = true;
            this.txtExchangeRate.Size = new System.Drawing.Size(150, 21);
            this.txtExchangeRate.TabIndex = 206;
            // 
            // cboCurrency
            // 
            this.cboCurrency.DisplayMember = "Text";
            this.cboCurrency.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboCurrency.Enabled = false;
            this.cboCurrency.FormattingEnabled = true;
            this.cboCurrency.ItemHeight = 15;
            this.cboCurrency.Location = new System.Drawing.Point(602, 35);
            this.cboCurrency.Name = "cboCurrency";
            this.cboCurrency.Size = new System.Drawing.Size(150, 21);
            this.cboCurrency.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboCurrency.TabIndex = 205;
            this.cboCurrency.SelectedValueChanged += new System.EventHandler(this.cboCurrency_SelectedValueChanged);
            // 
            // txtTaxAmount
            // 
            // 
            // 
            // 
            this.txtTaxAmount.Border.Class = "TextBoxBorder";
            this.txtTaxAmount.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTaxAmount.EnterToNextControl = false;
            this.txtTaxAmount.Location = new System.Drawing.Point(94, 146);
            this.txtTaxAmount.Name = "txtTaxAmount";
            this.txtTaxAmount.PreventEnterBeep = true;
            this.txtTaxAmount.ReadOnly = true;
            this.txtTaxAmount.Size = new System.Drawing.Size(150, 21);
            this.txtTaxAmount.TabIndex = 204;
            // 
            // cboTaxRate
            // 
            this.cboTaxRate.DisplayMember = "Text";
            this.cboTaxRate.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboTaxRate.Enabled = false;
            this.cboTaxRate.FormattingEnabled = true;
            this.cboTaxRate.ItemHeight = 15;
            this.cboTaxRate.Location = new System.Drawing.Point(348, 35);
            this.cboTaxRate.Name = "cboTaxRate";
            this.cboTaxRate.Size = new System.Drawing.Size(150, 21);
            this.cboTaxRate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboTaxRate.TabIndex = 203;
            // 
            // ucLabelX4
            // 
            // 
            // 
            // 
            this.ucLabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ucLabelX4.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabelX4.ForeColor = System.Drawing.Color.Gray;
            this.ucLabelX4.Location = new System.Drawing.Point(788, 34);
            this.ucLabelX4.Name = "ucLabelX4";
            this.ucLabelX4.Size = new System.Drawing.Size(46, 23);
            this.ucLabelX4.TabIndex = 202;
            this.ucLabelX4.Text = "汇率：";
            // 
            // ucLabelX5
            // 
            // 
            // 
            // 
            this.ucLabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ucLabelX5.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabelX5.ForeColor = System.Drawing.Color.Gray;
            this.ucLabelX5.Location = new System.Drawing.Point(540, 34);
            this.ucLabelX5.Name = "ucLabelX5";
            this.ucLabelX5.Size = new System.Drawing.Size(45, 23);
            this.ucLabelX5.TabIndex = 201;
            this.ucLabelX5.Text = "币种：";
            // 
            // ucLabelX6
            // 
            // 
            // 
            // 
            this.ucLabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ucLabelX6.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabelX6.ForeColor = System.Drawing.Color.Gray;
            this.ucLabelX6.Location = new System.Drawing.Point(18, 145);
            this.ucLabelX6.Name = "ucLabelX6";
            this.ucLabelX6.Size = new System.Drawing.Size(55, 23);
            this.ucLabelX6.TabIndex = 200;
            this.ucLabelX6.Text = "税金额：";
            // 
            // ucLabelX13
            // 
            // 
            // 
            // 
            this.ucLabelX13.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ucLabelX13.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabelX13.ForeColor = System.Drawing.Color.Gray;
            this.ucLabelX13.Location = new System.Drawing.Point(300, 34);
            this.ucLabelX13.Name = "ucLabelX13";
            this.ucLabelX13.Size = new System.Drawing.Size(42, 23);
            this.ucLabelX13.TabIndex = 199;
            this.ucLabelX13.Text = "税率：";
            // 
            // txtReceiverID
            // 
            // 
            // 
            // 
            this.txtReceiverID.Border.Class = "TextBoxBorder";
            this.txtReceiverID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtReceiverID.EnterToNextControl = false;
            this.txtReceiverID.Location = new System.Drawing.Point(899, 120);
            this.txtReceiverID.Name = "txtReceiverID";
            this.txtReceiverID.ReadOnly = true;
            this.txtReceiverID.Size = new System.Drawing.Size(26, 21);
            this.txtReceiverID.TabIndex = 198;
            this.txtReceiverID.Visible = false;
            // 
            // txtOperEmpID
            // 
            // 
            // 
            // 
            this.txtOperEmpID.Border.Class = "TextBoxBorder";
            this.txtOperEmpID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtOperEmpID.EnterToNextControl = false;
            this.txtOperEmpID.Location = new System.Drawing.Point(867, 120);
            this.txtOperEmpID.Name = "txtOperEmpID";
            this.txtOperEmpID.ReadOnly = true;
            this.txtOperEmpID.Size = new System.Drawing.Size(26, 21);
            this.txtOperEmpID.TabIndex = 197;
            this.txtOperEmpID.Visible = false;
            // 
            // txtOperDeptID
            // 
            // 
            // 
            // 
            this.txtOperDeptID.Border.Class = "TextBoxBorder";
            this.txtOperDeptID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtOperDeptID.EnterToNextControl = false;
            this.txtOperDeptID.Location = new System.Drawing.Point(835, 120);
            this.txtOperDeptID.Name = "txtOperDeptID";
            this.txtOperDeptID.ReadOnly = true;
            this.txtOperDeptID.Size = new System.Drawing.Size(26, 21);
            this.txtOperDeptID.TabIndex = 196;
            this.txtOperDeptID.Visible = false;
            // 
            // txtSourceBillGuid
            // 
            // 
            // 
            // 
            this.txtSourceBillGuid.Border.Class = "TextBoxBorder";
            this.txtSourceBillGuid.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSourceBillGuid.EnterToNextControl = false;
            this.txtSourceBillGuid.Location = new System.Drawing.Point(803, 120);
            this.txtSourceBillGuid.Name = "txtSourceBillGuid";
            this.txtSourceBillGuid.ReadOnly = true;
            this.txtSourceBillGuid.Size = new System.Drawing.Size(26, 21);
            this.txtSourceBillGuid.TabIndex = 195;
            this.txtSourceBillGuid.Visible = false;
            // 
            // txtUpdatedTime
            // 
            // 
            // 
            // 
            this.txtUpdatedTime.Border.Class = "TextBoxBorder";
            this.txtUpdatedTime.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtUpdatedTime.EnterToNextControl = false;
            this.txtUpdatedTime.Location = new System.Drawing.Point(865, 179);
            this.txtUpdatedTime.Name = "txtUpdatedTime";
            this.txtUpdatedTime.ReadOnly = true;
            this.txtUpdatedTime.Size = new System.Drawing.Size(150, 21);
            this.txtUpdatedTime.TabIndex = 194;
            // 
            // txtSCAmount
            // 
            // 
            // 
            // 
            this.txtSCAmount.Border.Class = "TextBoxBorder";
            this.txtSCAmount.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSCAmount.EnterToNextControl = false;
            this.txtSCAmount.Location = new System.Drawing.Point(602, 146);
            this.txtSCAmount.Name = "txtSCAmount";
            this.txtSCAmount.ReadOnly = true;
            this.txtSCAmount.Size = new System.Drawing.Size(150, 21);
            this.txtSCAmount.TabIndex = 193;
            // 
            // txtInDate
            // 
            // 
            // 
            // 
            this.txtInDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtInDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtInDate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.txtInDate.ButtonDropDown.Visible = true;
            this.txtInDate.CustomFormat = "yyyy-MM-dd";
            this.txtInDate.Format = DevComponents.Editors.eDateTimePickerFormat.Custom;
            this.txtInDate.IsPopupCalendarOpen = false;
            this.txtInDate.Location = new System.Drawing.Point(865, 7);
            // 
            // 
            // 
            this.txtInDate.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.txtInDate.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.txtInDate.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtInDate.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.txtInDate.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.txtInDate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.txtInDate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.txtInDate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.txtInDate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtInDate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.txtInDate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.txtInDate.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtInDate.MonthCalendar.DisplayMonth = new System.DateTime(2014, 11, 1, 0, 0, 0, 0);
            this.txtInDate.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.txtInDate.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.txtInDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.txtInDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.txtInDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.txtInDate.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtInDate.MonthCalendar.TodayButtonVisible = true;
            this.txtInDate.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.txtInDate.Name = "txtInDate";
            this.txtInDate.Size = new System.Drawing.Size(150, 21);
            this.txtInDate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.txtInDate.TabIndex = 191;
            // 
            // txtApproveStatus
            // 
            // 
            // 
            // 
            this.txtApproveStatus.Border.Class = "TextBoxBorder";
            this.txtApproveStatus.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtApproveStatus.EnterToNextControl = false;
            this.txtApproveStatus.Location = new System.Drawing.Point(865, 65);
            this.txtApproveStatus.Name = "txtApproveStatus";
            this.txtApproveStatus.ReadOnly = true;
            this.txtApproveStatus.Size = new System.Drawing.Size(150, 21);
            this.txtApproveStatus.TabIndex = 190;
            // 
            // ucLabelX21
            // 
            // 
            // 
            // 
            this.ucLabelX21.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ucLabelX21.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabelX21.ForeColor = System.Drawing.Color.Gray;
            this.ucLabelX21.Location = new System.Drawing.Point(786, 65);
            this.ucLabelX21.Name = "ucLabelX21";
            this.ucLabelX21.Size = new System.Drawing.Size(70, 23);
            this.ucLabelX21.TabIndex = 189;
            this.ucLabelX21.Text = "审核状态：";
            // 
            // txtStatus
            // 
            // 
            // 
            // 
            this.txtStatus.Border.Class = "TextBoxBorder";
            this.txtStatus.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtStatus.EnterToNextControl = false;
            this.txtStatus.Location = new System.Drawing.Point(931, 120);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(44, 21);
            this.txtStatus.TabIndex = 188;
            this.txtStatus.Visible = false;
            // 
            // txtStkInGuid
            // 
            // 
            // 
            // 
            this.txtStkInGuid.Border.Class = "TextBoxBorder";
            this.txtStkInGuid.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtStkInGuid.EnterToNextControl = false;
            this.txtStkInGuid.Location = new System.Drawing.Point(771, 120);
            this.txtStkInGuid.Name = "txtStkInGuid";
            this.txtStkInGuid.ReadOnly = true;
            this.txtStkInGuid.Size = new System.Drawing.Size(26, 21);
            this.txtStkInGuid.TabIndex = 184;
            this.txtStkInGuid.Visible = false;
            // 
            // txtReceiverName
            // 
            // 
            // 
            // 
            this.txtReceiverName.Border.Class = "TextBoxBorder";
            this.txtReceiverName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtReceiverName.ButtonCustom.Visible = true;
            this.txtReceiverName.ButtonCustom2.Image = global::ZNLCRM.UI.Properties.Resources.del_6;
            this.txtReceiverName.ButtonCustom2.Visible = true;
            this.txtReceiverName.EnterToNextControl = false;
            this.txtReceiverName.Location = new System.Drawing.Point(94, 35);
            this.txtReceiverName.Name = "txtReceiverName";
            this.txtReceiverName.Size = new System.Drawing.Size(150, 21);
            this.txtReceiverName.TabIndex = 183;
            this.txtReceiverName.ButtonCustomClick += new System.EventHandler(this.txtReceiverName_ButtonCustomClick);
            this.txtReceiverName.ButtonCustom2Click += new System.EventHandler(this.txtReceiverName_ButtonCustom2Click);
            // 
            // cboOperOrgID
            // 
            this.cboOperOrgID.DisplayMember = "Text";
            this.cboOperOrgID.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboOperOrgID.Enabled = false;
            this.cboOperOrgID.FormattingEnabled = true;
            this.cboOperOrgID.ItemHeight = 15;
            this.cboOperOrgID.Location = new System.Drawing.Point(94, 65);
            this.cboOperOrgID.Name = "cboOperOrgID";
            this.cboOperOrgID.Size = new System.Drawing.Size(150, 21);
            this.cboOperOrgID.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboOperOrgID.TabIndex = 182;
            // 
            // txtOperEmpName
            // 
            // 
            // 
            // 
            this.txtOperEmpName.Border.Class = "TextBoxBorder";
            this.txtOperEmpName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtOperEmpName.ButtonCustom2.Image = global::ZNLCRM.UI.Properties.Resources.del_6;
            this.txtOperEmpName.EnterToNextControl = false;
            this.txtOperEmpName.Location = new System.Drawing.Point(602, 65);
            this.txtOperEmpName.Name = "txtOperEmpName";
            this.txtOperEmpName.ReadOnly = true;
            this.txtOperEmpName.Size = new System.Drawing.Size(150, 21);
            this.txtOperEmpName.TabIndex = 181;
            this.txtOperEmpName.ButtonCustomClick += new System.EventHandler(this.txtOperEmpName_ButtonCustomClick);
            this.txtOperEmpName.ButtonCustom2Click += new System.EventHandler(this.txtOperEmpName_ButtonCustom2Click);
            // 
            // ucLabelX18
            // 
            // 
            // 
            // 
            this.ucLabelX18.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ucLabelX18.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabelX18.ForeColor = System.Drawing.Color.Gray;
            this.ucLabelX18.Location = new System.Drawing.Point(526, 64);
            this.ucLabelX18.Name = "ucLabelX18";
            this.ucLabelX18.Size = new System.Drawing.Size(70, 23);
            this.ucLabelX18.TabIndex = 180;
            this.ucLabelX18.Text = "所属人员：";
            // 
            // txtOperDeptName
            // 
            // 
            // 
            // 
            this.txtOperDeptName.Border.Class = "TextBoxBorder";
            this.txtOperDeptName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtOperDeptName.ButtonCustom2.Image = global::ZNLCRM.UI.Properties.Resources.del_6;
            this.txtOperDeptName.EnterToNextControl = false;
            this.txtOperDeptName.Location = new System.Drawing.Point(348, 65);
            this.txtOperDeptName.Name = "txtOperDeptName";
            this.txtOperDeptName.ReadOnly = true;
            this.txtOperDeptName.Size = new System.Drawing.Size(150, 21);
            this.txtOperDeptName.TabIndex = 179;
            this.txtOperDeptName.ButtonCustomClick += new System.EventHandler(this.txtOperDeptName_ButtonCustomClick);
            this.txtOperDeptName.ButtonCustom2Click += new System.EventHandler(this.txtOperDeptName_ButtonCustom2Click);
            // 
            // ucLabelX17
            // 
            // 
            // 
            // 
            this.ucLabelX17.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ucLabelX17.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabelX17.ForeColor = System.Drawing.Color.Gray;
            this.ucLabelX17.Location = new System.Drawing.Point(272, 64);
            this.ucLabelX17.Name = "ucLabelX17";
            this.ucLabelX17.Size = new System.Drawing.Size(70, 23);
            this.ucLabelX17.TabIndex = 178;
            this.ucLabelX17.Text = "所属部门：";
            // 
            // ucLabelX16
            // 
            // 
            // 
            // 
            this.ucLabelX16.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ucLabelX16.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabelX16.ForeColor = System.Drawing.Color.Gray;
            this.ucLabelX16.Location = new System.Drawing.Point(23, 64);
            this.ucLabelX16.Name = "ucLabelX16";
            this.ucLabelX16.Size = new System.Drawing.Size(70, 23);
            this.ucLabelX16.TabIndex = 177;
            this.ucLabelX16.Text = "所属机构：";
            // 
            // ucLabelX15
            // 
            // 
            // 
            // 
            this.ucLabelX15.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ucLabelX15.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabelX15.ForeColor = System.Drawing.Color.Gray;
            this.ucLabelX15.Location = new System.Drawing.Point(22, 34);
            this.ucLabelX15.Name = "ucLabelX15";
            this.ucLabelX15.Size = new System.Drawing.Size(57, 23);
            this.ucLabelX15.TabIndex = 176;
            this.ucLabelX15.Text = "收货人：";
            // 
            // txtPaymentAmount
            // 
            // 
            // 
            // 
            this.txtPaymentAmount.Border.Class = "TextBoxBorder";
            this.txtPaymentAmount.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPaymentAmount.EnterToNextControl = false;
            this.txtPaymentAmount.Location = new System.Drawing.Point(865, 146);
            this.txtPaymentAmount.Name = "txtPaymentAmount";
            this.txtPaymentAmount.ReadOnly = true;
            this.txtPaymentAmount.Size = new System.Drawing.Size(150, 21);
            this.txtPaymentAmount.TabIndex = 175;
            // 
            // ucLabelX14
            // 
            // 
            // 
            // 
            this.ucLabelX14.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ucLabelX14.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabelX14.ForeColor = System.Drawing.Color.Gray;
            this.ucLabelX14.Location = new System.Drawing.Point(782, 145);
            this.ucLabelX14.Name = "ucLabelX14";
            this.ucLabelX14.Size = new System.Drawing.Size(70, 23);
            this.ucLabelX14.TabIndex = 174;
            this.ucLabelX14.Text = "付款金额：";
            // 
            // ucLabelX12
            // 
            // 
            // 
            // 
            this.ucLabelX12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ucLabelX12.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabelX12.ForeColor = System.Drawing.Color.Gray;
            this.ucLabelX12.Location = new System.Drawing.Point(511, 145);
            this.ucLabelX12.Name = "ucLabelX12";
            this.ucLabelX12.Size = new System.Drawing.Size(70, 23);
            this.ucLabelX12.TabIndex = 173;
            this.ucLabelX12.Text = "本币金额：";
            // 
            // ucLabelX11
            // 
            // 
            // 
            // 
            this.ucLabelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ucLabelX11.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabelX11.ForeColor = System.Drawing.Color.Gray;
            this.ucLabelX11.Location = new System.Drawing.Point(782, 178);
            this.ucLabelX11.Name = "ucLabelX11";
            this.ucLabelX11.Size = new System.Drawing.Size(70, 23);
            this.ucLabelX11.TabIndex = 172;
            this.ucLabelX11.Text = "修改时间：";
            // 
            // txtUpdatedEmpName
            // 
            // 
            // 
            // 
            this.txtUpdatedEmpName.Border.Class = "TextBoxBorder";
            this.txtUpdatedEmpName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtUpdatedEmpName.EnterToNextControl = false;
            this.txtUpdatedEmpName.Location = new System.Drawing.Point(602, 179);
            this.txtUpdatedEmpName.Name = "txtUpdatedEmpName";
            this.txtUpdatedEmpName.ReadOnly = true;
            this.txtUpdatedEmpName.Size = new System.Drawing.Size(150, 21);
            this.txtUpdatedEmpName.TabIndex = 171;
            // 
            // ucLabelX10
            // 
            // 
            // 
            // 
            this.ucLabelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ucLabelX10.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabelX10.ForeColor = System.Drawing.Color.Gray;
            this.ucLabelX10.Location = new System.Drawing.Point(521, 178);
            this.ucLabelX10.Name = "ucLabelX10";
            this.ucLabelX10.Size = new System.Drawing.Size(70, 23);
            this.ucLabelX10.TabIndex = 170;
            this.ucLabelX10.Text = "修改人员：";
            // 
            // txtCreatedTime
            // 
            // 
            // 
            // 
            this.txtCreatedTime.Border.Class = "TextBoxBorder";
            this.txtCreatedTime.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCreatedTime.EnterToNextControl = false;
            this.txtCreatedTime.Location = new System.Drawing.Point(348, 179);
            this.txtCreatedTime.Name = "txtCreatedTime";
            this.txtCreatedTime.ReadOnly = true;
            this.txtCreatedTime.Size = new System.Drawing.Size(150, 21);
            this.txtCreatedTime.TabIndex = 169;
            // 
            // ucLabelX9
            // 
            // 
            // 
            // 
            this.ucLabelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ucLabelX9.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabelX9.ForeColor = System.Drawing.Color.Gray;
            this.ucLabelX9.Location = new System.Drawing.Point(268, 178);
            this.ucLabelX9.Name = "ucLabelX9";
            this.ucLabelX9.Size = new System.Drawing.Size(70, 23);
            this.ucLabelX9.TabIndex = 168;
            this.ucLabelX9.Text = "创建时间：";
            // 
            // txtCreatedEmpName
            // 
            // 
            // 
            // 
            this.txtCreatedEmpName.Border.Class = "TextBoxBorder";
            this.txtCreatedEmpName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCreatedEmpName.EnterToNextControl = false;
            this.txtCreatedEmpName.Location = new System.Drawing.Point(94, 179);
            this.txtCreatedEmpName.Name = "txtCreatedEmpName";
            this.txtCreatedEmpName.ReadOnly = true;
            this.txtCreatedEmpName.Size = new System.Drawing.Size(150, 21);
            this.txtCreatedEmpName.TabIndex = 167;
            // 
            // ucLabelX8
            // 
            // 
            // 
            // 
            this.ucLabelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ucLabelX8.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabelX8.ForeColor = System.Drawing.Color.Gray;
            this.ucLabelX8.Location = new System.Drawing.Point(18, 178);
            this.ucLabelX8.Name = "ucLabelX8";
            this.ucLabelX8.Size = new System.Drawing.Size(70, 23);
            this.ucLabelX8.TabIndex = 166;
            this.ucLabelX8.Text = "创建人员：";
            // 
            // txtRemark
            // 
            // 
            // 
            // 
            this.txtRemark.Border.Class = "TextBoxBorder";
            this.txtRemark.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtRemark.EnterToNextControl = false;
            this.txtRemark.Location = new System.Drawing.Point(94, 96);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(654, 39);
            this.txtRemark.TabIndex = 165;
            // 
            // ucLabelX7
            // 
            // 
            // 
            // 
            this.ucLabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ucLabelX7.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabelX7.ForeColor = System.Drawing.Color.Gray;
            this.ucLabelX7.Location = new System.Drawing.Point(47, 99);
            this.ucLabelX7.Name = "ucLabelX7";
            this.ucLabelX7.Size = new System.Drawing.Size(45, 23);
            this.ucLabelX7.TabIndex = 164;
            this.ucLabelX7.Text = "备注：";
            // 
            // txtAmount
            // 
            // 
            // 
            // 
            this.txtAmount.Border.Class = "TextBoxBorder";
            this.txtAmount.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtAmount.EnterToNextControl = false;
            this.txtAmount.Location = new System.Drawing.Point(348, 146);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.ReadOnly = true;
            this.txtAmount.Size = new System.Drawing.Size(150, 21);
            this.txtAmount.TabIndex = 162;
            // 
            // ucLabelX3
            // 
            // 
            // 
            // 
            this.ucLabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ucLabelX3.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabelX3.ForeColor = System.Drawing.Color.Gray;
            this.ucLabelX3.Location = new System.Drawing.Point(272, 145);
            this.ucLabelX3.Name = "ucLabelX3";
            this.ucLabelX3.Size = new System.Drawing.Size(54, 23);
            this.ucLabelX3.TabIndex = 161;
            this.ucLabelX3.Text = "总金额：";
            // 
            // ucLabelX54
            // 
            // 
            // 
            // 
            this.ucLabelX54.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ucLabelX54.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabelX54.ForeColor = System.Drawing.Color.Gray;
            this.ucLabelX54.Location = new System.Drawing.Point(786, 7);
            this.ucLabelX54.Name = "ucLabelX54";
            this.ucLabelX54.Size = new System.Drawing.Size(70, 23);
            this.ucLabelX54.TabIndex = 158;
            this.ucLabelX54.Text = "入库日期：";
            // 
            // txtSourceBillNo
            // 
            // 
            // 
            // 
            this.txtSourceBillNo.Border.Class = "TextBoxBorder";
            this.txtSourceBillNo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSourceBillNo.ButtonCustom.Visible = true;
            this.txtSourceBillNo.ButtonCustom2.Image = global::ZNLCRM.UI.Properties.Resources.del_6;
            this.txtSourceBillNo.ButtonCustom2.Visible = true;
            this.txtSourceBillNo.EnterToNextControl = false;
            this.txtSourceBillNo.Location = new System.Drawing.Point(602, 7);
            this.txtSourceBillNo.Name = "txtSourceBillNo";
            this.txtSourceBillNo.Size = new System.Drawing.Size(150, 21);
            this.txtSourceBillNo.TabIndex = 157;
            this.txtSourceBillNo.ButtonCustomClick += new System.EventHandler(this.txtSourceBillNo_ButtonCustomClick);
            this.txtSourceBillNo.ButtonCustom2Click += new System.EventHandler(this.txtSourceBillNo_ButtonCustom2Click);
            // 
            // ucLabelX37
            // 
            // 
            // 
            // 
            this.ucLabelX37.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ucLabelX37.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabelX37.ForeColor = System.Drawing.Color.Gray;
            this.ucLabelX37.Location = new System.Drawing.Point(515, 7);
            this.ucLabelX37.Name = "ucLabelX37";
            this.ucLabelX37.Size = new System.Drawing.Size(81, 23);
            this.ucLabelX37.TabIndex = 156;
            this.ucLabelX37.Text = "源单据编号：";
            // 
            // cboBillType
            // 
            this.cboBillType.DisplayMember = "Text";
            this.cboBillType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboBillType.FormattingEnabled = true;
            this.cboBillType.ItemHeight = 15;
            this.cboBillType.Location = new System.Drawing.Point(348, 7);
            this.cboBillType.Name = "cboBillType";
            this.cboBillType.Size = new System.Drawing.Size(150, 21);
            this.cboBillType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboBillType.TabIndex = 152;
            this.cboBillType.SelectedIndexChanged += new System.EventHandler(this.cboBillType_SelectedIndexChanged);
            // 
            // ucLabelX2
            // 
            // 
            // 
            // 
            this.ucLabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ucLabelX2.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabelX2.ForeColor = System.Drawing.Color.Gray;
            this.ucLabelX2.Location = new System.Drawing.Point(272, 7);
            this.ucLabelX2.Name = "ucLabelX2";
            this.ucLabelX2.Size = new System.Drawing.Size(70, 23);
            this.ucLabelX2.TabIndex = 150;
            this.ucLabelX2.Text = "入库类型：";
            // 
            // ucLabelX1
            // 
            // 
            // 
            // 
            this.ucLabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ucLabelX1.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabelX1.ForeColor = System.Drawing.Color.Gray;
            this.ucLabelX1.Location = new System.Drawing.Point(22, 9);
            this.ucLabelX1.Name = "ucLabelX1";
            this.ucLabelX1.Size = new System.Drawing.Size(70, 23);
            this.ucLabelX1.TabIndex = 149;
            this.ucLabelX1.Text = "入库单号：";
            // 
            // txtBillNo
            // 
            // 
            // 
            // 
            this.txtBillNo.Border.Class = "TextBoxBorder";
            this.txtBillNo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtBillNo.EnterToNextControl = false;
            this.txtBillNo.Location = new System.Drawing.Point(94, 7);
            this.txtBillNo.Name = "txtBillNo";
            this.txtBillNo.ReadOnly = true;
            this.txtBillNo.Size = new System.Drawing.Size(150, 21);
            this.txtBillNo.TabIndex = 148;
            // 
            // stiStkIn
            // 
            this.stiStkIn.AttachedControl = this.stcpStkIn;
            this.stiStkIn.GlobalItem = false;
            this.stiStkIn.Name = "stiStkIn";
            this.stiStkIn.Text = "入库主单";
            // 
            // ucPanel2
            // 
            this.ucPanel2.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel2.Controls.Add(this.tsOper);
            this.ucPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucPanel2.Location = new System.Drawing.Point(0, 0);
            this.ucPanel2.Name = "ucPanel2";
            this.ucPanel2.Size = new System.Drawing.Size(1037, 41);
            this.ucPanel2.TabIndex = 5;
            // 
            // frmStkIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 662);
            this.Controls.Add(this.ucPanel1);
            this.Controls.Add(this.ucPanel2);
            this.Name = "frmStkIn";
            this.Text = "入库单编辑";
            this.Load += new System.EventHandler(this.frmStkIn_Load);
            this.tsOper.ResumeLayout(false);
            this.tsOper.PerformLayout();
            this.ucPanel1.ResumeLayout(false);
            this.ucPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ustcStkInLine)).EndInit();
            this.ustcStkInLine.ResumeLayout(false);
            this.stcpStkInLine.ResumeLayout(false);
            this.panDtlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStkInLine)).EndInit();
            this.panDtlBtn.ResumeLayout(false);
            this.ucPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ustcStKIn)).EndInit();
            this.ustcStKIn.ResumeLayout(false);
            this.stcpStkIn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtInDate)).EndInit();
            this.ucPanel2.ResumeLayout(false);
            this.ucPanel2.PerformLayout();
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
        private Controls.UcExpandableSplitter ucExpandableSplitter1;
        private Controls.UcPanel ucPanel4;
        private Controls.UcSuperTabControl ustcStkInLine;
        private DevComponents.DotNetBar.SuperTabControlPanel stcpStkInLine;
        private Controls.UcPanel panDtlGrid;
        private Controls.UcDataGridView dgvStkInLine;
        private Controls.UcPanel panDtlBtn;
        private Controls.UcButton btnImportSourceLine;
        private Controls.UcButton btnDelRow;
        private Controls.UcButton btnAddRow;
        private DevComponents.DotNetBar.SuperTabItem stiStkInLine;
        private DevComponents.DotNetBar.SuperTabControlPanel stcpAttach;
        private DevComponents.DotNetBar.SuperTabItem stiAttach;
        private Controls.UcPanel ucPanel3;
        private Controls.UcSuperTabControl ustcStKIn;
        private DevComponents.DotNetBar.SuperTabControlPanel stcpStkIn;
        private Controls.UcTextBox txtReceiverID;
        private Controls.UcTextBox txtOperEmpID;
        private Controls.UcTextBox txtOperDeptID;
        private Controls.UcTextBox txtSourceBillGuid;
        private Controls.UcTextBox txtUpdatedTime;
        private Controls.UcTextBox txtSCAmount;
        private Controls.UcDateTimeInput txtInDate;
        private Controls.UcTextBox txtApproveStatus;
        private Controls.UcLabelX ucLabelX21;
        private Controls.UcTextBox txtStatus;
        private Controls.UcTextBox txtStkInGuid;
        private Controls.UcTextBox txtReceiverName;
        private Controls.UcComboBox cboOperOrgID;
        private Controls.UcTextBox txtOperEmpName;
        private Controls.UcLabelX ucLabelX18;
        private Controls.UcTextBox txtOperDeptName;
        private Controls.UcLabelX ucLabelX17;
        private Controls.UcLabelX ucLabelX16;
        private Controls.UcLabelX ucLabelX15;
        private Controls.UcTextBox txtPaymentAmount;
        private Controls.UcLabelX ucLabelX14;
        private Controls.UcLabelX ucLabelX12;
        private Controls.UcLabelX ucLabelX11;
        private Controls.UcTextBox txtUpdatedEmpName;
        private Controls.UcLabelX ucLabelX10;
        private Controls.UcTextBox txtCreatedTime;
        private Controls.UcLabelX ucLabelX9;
        private Controls.UcTextBox txtCreatedEmpName;
        private Controls.UcLabelX ucLabelX8;
        private Controls.UcTextBox txtRemark;
        private Controls.UcLabelX ucLabelX7;
        private Controls.UcTextBox txtAmount;
        private Controls.UcLabelX ucLabelX3;
        private Controls.UcLabelX ucLabelX54;
        private Controls.UcTextBox txtSourceBillNo;
        private Controls.UcLabelX ucLabelX37;
        private Controls.UcComboBox cboBillType;
        private Controls.UcLabelX ucLabelX2;
        private Controls.UcLabelX ucLabelX1;
        private Controls.UcTextBox txtBillNo;
        private DevComponents.DotNetBar.SuperTabItem stiStkIn;
        private Controls.UcButton btnInsertBefore;
        private System.Windows.Forms.DataGridViewLinkColumn colAddGive;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colIsGive;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStkInLineGuid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSourceBillLineGuid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSOLineGuid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemCode;
        private DevComponents.DotNetBar.Controls.DataGridViewMaskedTextBoxAdvColumn colModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFreight;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCostPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSCAmount;
        private DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn colTaxRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPaymentAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPayAmtDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBrand;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPackage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBatch;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuality;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMPQ;
        private DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn colInvType;
        private DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn colWarehouse;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStkOutQty;
        private DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn colUnit;
        private DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn colCurrency;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExchangeRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDemands;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRemark;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colIsCut;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colIsPCut;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colIsRaiseTaxes;
        private Controls.UcTextBox txtExchangeRate;
        private Controls.UcComboBox cboCurrency;
        private Controls.UcTextBox txtTaxAmount;
        private Controls.UcComboBox cboTaxRate;
        private Controls.UcLabelX ucLabelX4;
        private Controls.UcLabelX ucLabelX5;
        private Controls.UcLabelX ucLabelX6;
        private Controls.UcLabelX ucLabelX13;
    }
}