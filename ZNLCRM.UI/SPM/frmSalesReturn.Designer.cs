namespace ZNLCRM.UI.SPM
{
    partial class frmSalesReturn
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ucPanel1 = new ZNLCRM.Controls.UcPanel(this.components);
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
            this.ucPanel2 = new ZNLCRM.Controls.UcPanel(this.components);
            this.ucPanel7 = new ZNLCRM.Controls.UcPanel(this.components);
            this.ucSuperTabControl2 = new ZNLCRM.Controls.UcSuperTabControl(this.components);
            this.superTabControlPanel3 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.ucPanel6 = new ZNLCRM.Controls.UcPanel(this.components);
            this.dgvSalesReturnLine = new ZNLCRM.Controls.UcDataGridView(this.components);
            this.colSRLineGuid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSRLineID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSOGuid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSOBillNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLineGuid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStkOutGuid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStkOutBillNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStkOutLineGuid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStkInLineGuid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colModel = new DevComponents.DotNetBar.Controls.DataGridViewMaskedTextBoxAdvColumn();
            this.colBrand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPackage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBatch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnit = new DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn();
            this.colQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStkInQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCurrency = new DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn();
            this.colUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMPQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMarkCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInvType = new DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn();
            this.colWarehouse = new DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn();
            this.colLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRemark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ucPanel5 = new ZNLCRM.Controls.UcPanel(this.components);
            this.btnInsertBefore = new ZNLCRM.Controls.UcButton(this.components);
            this.btnImportStkOutLine = new ZNLCRM.Controls.UcButton(this.components);
            this.btnPaste = new ZNLCRM.Controls.UcButton(this.components);
            this.btnDelRow = new ZNLCRM.Controls.UcButton(this.components);
            this.btnAddRow = new ZNLCRM.Controls.UcButton(this.components);
            this.superTabItem3 = new DevComponents.DotNetBar.SuperTabItem();
            this.stcpSys_AttachFiles = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.superTabItem5 = new DevComponents.DotNetBar.SuperTabItem();
            this.ucExpandableSplitter1 = new ZNLCRM.Controls.UcExpandableSplitter(this.components);
            this.ucPanel3 = new ZNLCRM.Controls.UcPanel(this.components);
            this.ucSuperTabControl1 = new ZNLCRM.Controls.UcSuperTabControl(this.components);
            this.stcpBase = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.txtExplain = new ZNLCRM.Controls.UcTextBox(this.components);
            this.ucLabelX10 = new ZNLCRM.Controls.UcLabelX(this.components);
            this.txtOperDeptID = new ZNLCRM.Controls.UcTextBox(this.components);
            this.txtSODate = new ZNLCRM.Controls.UcDateTimeInput(this.components);
            this.ucLabelX9 = new ZNLCRM.Controls.UcLabelX(this.components);
            this.txtRemark = new ZNLCRM.Controls.UcTextBox(this.components);
            this.ucLabelX8 = new ZNLCRM.Controls.UcLabelX(this.components);
            this.txtOperEmpID = new ZNLCRM.Controls.UcTextBox(this.components);
            this.txtCreatedTime = new ZNLCRM.Controls.UcTextBox(this.components);
            this.txtCustomerID = new ZNLCRM.Controls.UcTextBox(this.components);
            this.txtUpdatedTime = new ZNLCRM.Controls.UcTextBox(this.components);
            this.txtSOGuid = new ZNLCRM.Controls.UcTextBox(this.components);
            this.txtApproveStatus = new ZNLCRM.Controls.UcTextBox(this.components);
            this.txtSRGuid = new ZNLCRM.Controls.UcTextBox(this.components);
            this.ucLabelX53 = new ZNLCRM.Controls.UcLabelX(this.components);
            this.txtStatus = new ZNLCRM.Controls.UcTextBox(this.components);
            this.ucLabelX52 = new ZNLCRM.Controls.UcLabelX(this.components);
            this.ucLabelX51 = new ZNLCRM.Controls.UcLabelX(this.components);
            this.txtUpdatedEmpName = new ZNLCRM.Controls.UcTextBox(this.components);
            this.ucLabelX50 = new ZNLCRM.Controls.UcLabelX(this.components);
            this.ucLabelX49 = new ZNLCRM.Controls.UcLabelX(this.components);
            this.txtCreatedEmpName = new ZNLCRM.Controls.UcTextBox(this.components);
            this.ucLabelX48 = new ZNLCRM.Controls.UcLabelX(this.components);
            this.txtFreight = new ZNLCRM.Controls.UcTextBox(this.components);
            this.ucLabelX7 = new ZNLCRM.Controls.UcLabelX(this.components);
            this.txtShippingNo = new ZNLCRM.Controls.UcTextBox(this.components);
            this.ucLabelX6 = new ZNLCRM.Controls.UcLabelX(this.components);
            this.cboTransportCompany = new ZNLCRM.Controls.UcComboBox(this.components);
            this.ucLabelX4 = new ZNLCRM.Controls.UcLabelX(this.components);
            this.cboFreightClearForm = new ZNLCRM.Controls.UcComboBox(this.components);
            this.ucLabelX3 = new ZNLCRM.Controls.UcLabelX(this.components);
            this.txtSOBillNo = new ZNLCRM.Controls.UcTextBox(this.components);
            this.ucLabelX2 = new ZNLCRM.Controls.UcLabelX(this.components);
            this.ucLabelX54 = new ZNLCRM.Controls.UcLabelX(this.components);
            this.txtReturnDate = new ZNLCRM.Controls.UcDateTimeInput(this.components);
            this.cboOperOrgID = new ZNLCRM.Controls.UcComboBox(this.components);
            this.ucLabelX1 = new ZNLCRM.Controls.UcLabelX(this.components);
            this.txtBillNo = new ZNLCRM.Controls.UcTextBox(this.components);
            this.txtOperEmpName = new ZNLCRM.Controls.UcTextBox(this.components);
            this.ucLabelX38 = new ZNLCRM.Controls.UcLabelX(this.components);
            this.txtOperDeptName = new ZNLCRM.Controls.UcTextBox(this.components);
            this.ucLabelX37 = new ZNLCRM.Controls.UcLabelX(this.components);
            this.ucLabelX36 = new ZNLCRM.Controls.UcLabelX(this.components);
            this.cboCurrency = new ZNLCRM.Controls.UcComboBox(this.components);
            this.ucLabelX5 = new ZNLCRM.Controls.UcLabelX(this.components);
            this.ucLabelX16 = new ZNLCRM.Controls.UcLabelX(this.components);
            this.txtCustomerName = new ZNLCRM.Controls.UcTextBox(this.components);
            this.txtAmount = new ZNLCRM.Controls.UcTextBox(this.components);
            this.ucLabelX13 = new ZNLCRM.Controls.UcLabelX(this.components);
            this.stiBase = new DevComponents.DotNetBar.SuperTabItem();
            this.ucPanel1.SuspendLayout();
            this.tsOper.SuspendLayout();
            this.ucPanel2.SuspendLayout();
            this.ucPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ucSuperTabControl2)).BeginInit();
            this.ucSuperTabControl2.SuspendLayout();
            this.superTabControlPanel3.SuspendLayout();
            this.ucPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesReturnLine)).BeginInit();
            this.ucPanel5.SuspendLayout();
            this.ucPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ucSuperTabControl1)).BeginInit();
            this.ucSuperTabControl1.SuspendLayout();
            this.stcpBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSODate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReturnDate)).BeginInit();
            this.SuspendLayout();
            // 
            // ucPanel1
            // 
            this.ucPanel1.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel1.Controls.Add(this.tsOper);
            this.ucPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucPanel1.Location = new System.Drawing.Point(0, 0);
            this.ucPanel1.Name = "ucPanel1";
            this.ucPanel1.Size = new System.Drawing.Size(1043, 36);
            this.ucPanel1.TabIndex = 1;
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
            this.tsOper.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tsOper.Size = new System.Drawing.Size(1043, 36);
            this.tsOper.TabIndex = 0;
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
            // 
            // tsbExport
            // 
            this.tsbExport.Image = global::ZNLCRM.UI.Properties.Resources.export_1;
            this.tsbExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExport.Name = "tsbExport";
            this.tsbExport.Size = new System.Drawing.Size(55, 23);
            this.tsbExport.Text = "导出";
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
            // 
            // tsbClose
            // 
            this.tsbClose.Image = global::ZNLCRM.UI.Properties.Resources.close;
            this.tsbClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbClose.Name = "tsbClose";
            this.tsbClose.Size = new System.Drawing.Size(55, 23);
            this.tsbClose.Text = "关闭";
            // 
            // ucPanel2
            // 
            this.ucPanel2.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel2.Controls.Add(this.ucPanel7);
            this.ucPanel2.Controls.Add(this.ucExpandableSplitter1);
            this.ucPanel2.Controls.Add(this.ucPanel3);
            this.ucPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPanel2.Location = new System.Drawing.Point(0, 36);
            this.ucPanel2.Name = "ucPanel2";
            this.ucPanel2.Size = new System.Drawing.Size(1043, 574);
            this.ucPanel2.TabIndex = 2;
            // 
            // ucPanel7
            // 
            this.ucPanel7.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel7.Controls.Add(this.ucSuperTabControl2);
            this.ucPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPanel7.Location = new System.Drawing.Point(0, 259);
            this.ucPanel7.Name = "ucPanel7";
            this.ucPanel7.Size = new System.Drawing.Size(1043, 315);
            this.ucPanel7.TabIndex = 5;
            // 
            // ucSuperTabControl2
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.ucSuperTabControl2.ControlBox.CloseBox.Name = "";
            // 
            // 
            // 
            this.ucSuperTabControl2.ControlBox.MenuBox.Name = "";
            this.ucSuperTabControl2.ControlBox.Name = "";
            this.ucSuperTabControl2.ControlBox.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ucSuperTabControl2.ControlBox.MenuBox,
            this.ucSuperTabControl2.ControlBox.CloseBox});
            this.ucSuperTabControl2.Controls.Add(this.superTabControlPanel3);
            this.ucSuperTabControl2.Controls.Add(this.stcpSys_AttachFiles);
            this.ucSuperTabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucSuperTabControl2.Location = new System.Drawing.Point(0, 0);
            this.ucSuperTabControl2.Name = "ucSuperTabControl2";
            this.ucSuperTabControl2.ReorderTabsEnabled = true;
            this.ucSuperTabControl2.SelectedTabFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold);
            this.ucSuperTabControl2.SelectedTabIndex = 0;
            this.ucSuperTabControl2.Size = new System.Drawing.Size(1043, 315);
            this.ucSuperTabControl2.TabFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucSuperTabControl2.TabIndex = 4;
            this.ucSuperTabControl2.Tabs.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.superTabItem3,
            this.superTabItem5});
            this.ucSuperTabControl2.Text = "ucSuperTabControl2";
            // 
            // superTabControlPanel3
            // 
            this.superTabControlPanel3.Controls.Add(this.ucPanel6);
            this.superTabControlPanel3.Controls.Add(this.ucPanel5);
            this.superTabControlPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel3.Location = new System.Drawing.Point(0, 28);
            this.superTabControlPanel3.Name = "superTabControlPanel3";
            this.superTabControlPanel3.Size = new System.Drawing.Size(1043, 287);
            this.superTabControlPanel3.TabIndex = 1;
            this.superTabControlPanel3.TabItem = this.superTabItem3;
            // 
            // ucPanel6
            // 
            this.ucPanel6.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel6.Controls.Add(this.dgvSalesReturnLine);
            this.ucPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPanel6.Location = new System.Drawing.Point(0, 30);
            this.ucPanel6.Name = "ucPanel6";
            this.ucPanel6.Padding = new System.Windows.Forms.Padding(5);
            this.ucPanel6.Size = new System.Drawing.Size(1043, 257);
            this.ucPanel6.TabIndex = 3;
            // 
            // dgvSalesReturnLine
            // 
            this.dgvSalesReturnLine.AllowUserToAddRows = false;
            this.dgvSalesReturnLine.AllowUserToDeleteRows = false;
            this.dgvSalesReturnLine.AllowUserToOrderColumns = true;
            this.dgvSalesReturnLine.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSalesReturnLine.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvSalesReturnLine.ColumnHeadersHeight = 30;
            this.dgvSalesReturnLine.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSRLineGuid,
            this.colSRLineID,
            this.colSOGuid,
            this.colSOBillNo,
            this.SOLineGuid,
            this.colStkOutGuid,
            this.colStkOutBillNo,
            this.colStkOutLineGuid,
            this.colStkInLineGuid,
            this.colItemCode,
            this.colModel,
            this.colBrand,
            this.colPackage,
            this.colBatch,
            this.colUnit,
            this.colQty,
            this.colStkInQty,
            this.colCurrency,
            this.colUnitPrice,
            this.colAmount,
            this.colQuality,
            this.colMPQ,
            this.colMarkCode,
            this.colInvType,
            this.colWarehouse,
            this.colLocation,
            this.colRemark});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSalesReturnLine.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvSalesReturnLine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSalesReturnLine.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvSalesReturnLine.HighlightSelectedColumnHeaders = false;
            this.dgvSalesReturnLine.Location = new System.Drawing.Point(5, 5);
            this.dgvSalesReturnLine.Name = "dgvSalesReturnLine";
            this.dgvSalesReturnLine.PaintEnhancedSelection = false;
            this.dgvSalesReturnLine.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvSalesReturnLine.RowHeadersWidth = 40;
            this.dgvSalesReturnLine.RowTemplate.Height = 23;
            this.dgvSalesReturnLine.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSalesReturnLine.SelectAllSignVisible = false;
            this.dgvSalesReturnLine.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvSalesReturnLine.ShowRowNo = true;
            this.dgvSalesReturnLine.Size = new System.Drawing.Size(1033, 247);
            this.dgvSalesReturnLine.TabIndex = 0;
            // 
            // colSRLineGuid
            // 
            this.colSRLineGuid.DataPropertyName = "SRLineGuid";
            this.colSRLineGuid.HeaderText = "SRLineGuid";
            this.colSRLineGuid.Name = "colSRLineGuid";
            this.colSRLineGuid.Visible = false;
            // 
            // colSRLineID
            // 
            this.colSRLineID.DataPropertyName = "SRLineID";
            this.colSRLineID.HeaderText = "SRLineID";
            this.colSRLineID.Name = "colSRLineID";
            this.colSRLineID.Visible = false;
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
            this.colSOBillNo.Width = 80;
            // 
            // SOLineGuid
            // 
            this.SOLineGuid.DataPropertyName = "SOLineGuid";
            this.SOLineGuid.HeaderText = "SOLineGuid";
            this.SOLineGuid.Name = "SOLineGuid";
            this.SOLineGuid.Visible = false;
            // 
            // colStkOutGuid
            // 
            this.colStkOutGuid.DataPropertyName = "StkOutGuid";
            this.colStkOutGuid.HeaderText = "StkOutGuid";
            this.colStkOutGuid.Name = "colStkOutGuid";
            this.colStkOutGuid.Visible = false;
            // 
            // colStkOutBillNo
            // 
            this.colStkOutBillNo.DataPropertyName = "StkOutBillNo";
            this.colStkOutBillNo.HeaderText = "出库单号";
            this.colStkOutBillNo.Name = "colStkOutBillNo";
            this.colStkOutBillNo.ReadOnly = true;
            this.colStkOutBillNo.Width = 80;
            // 
            // colStkOutLineGuid
            // 
            this.colStkOutLineGuid.DataPropertyName = "StkOutLineGuid";
            this.colStkOutLineGuid.HeaderText = "StkOutLineGuid";
            this.colStkOutLineGuid.Name = "colStkOutLineGuid";
            this.colStkOutLineGuid.Visible = false;
            // 
            // colStkInLineGuid
            // 
            this.colStkInLineGuid.DataPropertyName = "StkInLineGuid";
            this.colStkInLineGuid.HeaderText = "StkInLineGuid";
            this.colStkInLineGuid.Name = "colStkInLineGuid";
            this.colStkInLineGuid.Visible = false;
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
            // colBrand
            // 
            this.colBrand.DataPropertyName = "Brand";
            this.colBrand.HeaderText = "品牌";
            this.colBrand.Name = "colBrand";
            this.colBrand.ReadOnly = true;
            this.colBrand.Width = 80;
            // 
            // colPackage
            // 
            this.colPackage.DataPropertyName = "Package";
            this.colPackage.HeaderText = "封装";
            this.colPackage.Name = "colPackage";
            this.colPackage.ReadOnly = true;
            this.colPackage.Width = 80;
            // 
            // colBatch
            // 
            this.colBatch.DataPropertyName = "Batch";
            this.colBatch.HeaderText = "批号";
            this.colBatch.Name = "colBatch";
            this.colBatch.ReadOnly = true;
            this.colBatch.Width = 80;
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
            this.colUnit.ReadOnly = true;
            this.colUnit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colUnit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.colUnit.Width = 60;
            // 
            // colQty
            // 
            this.colQty.DataPropertyName = "Qty";
            this.colQty.HeaderText = "退货数量";
            this.colQty.Name = "colQty";
            this.colQty.Width = 80;
            // 
            // colStkInQty
            // 
            this.colStkInQty.DataPropertyName = "StkInQty";
            this.colStkInQty.HeaderText = "入库数量";
            this.colStkInQty.Name = "colStkInQty";
            this.colStkInQty.ReadOnly = true;
            this.colStkInQty.Width = 80;
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
            this.colCurrency.Width = 60;
            // 
            // colUnitPrice
            // 
            this.colUnitPrice.DataPropertyName = "UnitPrice";
            this.colUnitPrice.HeaderText = "退货单价";
            this.colUnitPrice.Name = "colUnitPrice";
            this.colUnitPrice.ReadOnly = true;
            this.colUnitPrice.Width = 80;
            // 
            // colAmount
            // 
            this.colAmount.DataPropertyName = "Amount";
            this.colAmount.HeaderText = "小计金额";
            this.colAmount.Name = "colAmount";
            this.colAmount.ReadOnly = true;
            this.colAmount.Width = 80;
            // 
            // colQuality
            // 
            this.colQuality.DataPropertyName = "Quality";
            this.colQuality.HeaderText = "品质";
            this.colQuality.Name = "colQuality";
            this.colQuality.ReadOnly = true;
            this.colQuality.Width = 80;
            // 
            // colMPQ
            // 
            this.colMPQ.DataPropertyName = "MPQ";
            this.colMPQ.HeaderText = "包装";
            this.colMPQ.Name = "colMPQ";
            this.colMPQ.ReadOnly = true;
            this.colMPQ.Width = 80;
            // 
            // colMarkCode
            // 
            this.colMarkCode.DataPropertyName = "MarkCode";
            this.colMarkCode.HeaderText = "标记码";
            this.colMarkCode.Name = "colMarkCode";
            this.colMarkCode.ReadOnly = true;
            this.colMarkCode.Width = 80;
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
            this.colInvType.Width = 80;
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
            this.colWarehouse.ReadOnly = true;
            this.colWarehouse.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colWarehouse.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.colWarehouse.Width = 80;
            // 
            // colLocation
            // 
            this.colLocation.DataPropertyName = "Location";
            this.colLocation.HeaderText = "位置";
            this.colLocation.Name = "colLocation";
            this.colLocation.ReadOnly = true;
            this.colLocation.Width = 80;
            // 
            // colRemark
            // 
            this.colRemark.DataPropertyName = "Remark";
            this.colRemark.HeaderText = "备注";
            this.colRemark.Name = "colRemark";
            // 
            // ucPanel5
            // 
            this.ucPanel5.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel5.Controls.Add(this.btnInsertBefore);
            this.ucPanel5.Controls.Add(this.btnImportStkOutLine);
            this.ucPanel5.Controls.Add(this.btnPaste);
            this.ucPanel5.Controls.Add(this.btnDelRow);
            this.ucPanel5.Controls.Add(this.btnAddRow);
            this.ucPanel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucPanel5.Location = new System.Drawing.Point(0, 0);
            this.ucPanel5.Name = "ucPanel5";
            this.ucPanel5.Size = new System.Drawing.Size(1043, 30);
            this.ucPanel5.TabIndex = 2;
            // 
            // btnInsertBefore
            // 
            this.btnInsertBefore.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnInsertBefore.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnInsertBefore.Image = global::ZNLCRM.UI.Properties.Resources.add_4;
            this.btnInsertBefore.Location = new System.Drawing.Point(92, 5);
            this.btnInsertBefore.Name = "btnInsertBefore";
            this.btnInsertBefore.Size = new System.Drawing.Size(75, 23);
            this.btnInsertBefore.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnInsertBefore.TabIndex = 8;
            this.btnInsertBefore.Text = "插入一行";
            this.btnInsertBefore.Click += new System.EventHandler(this.btnInsertBefore_Click);
            // 
            // btnImportStkOutLine
            // 
            this.btnImportStkOutLine.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnImportStkOutLine.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnImportStkOutLine.Image = global::ZNLCRM.UI.Properties.Resources.import_1;
            this.btnImportStkOutLine.Location = new System.Drawing.Point(346, 4);
            this.btnImportStkOutLine.Name = "btnImportStkOutLine";
            this.btnImportStkOutLine.Size = new System.Drawing.Size(101, 23);
            this.btnImportStkOutLine.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnImportStkOutLine.TabIndex = 7;
            this.btnImportStkOutLine.Text = "导入出库明细";
            this.btnImportStkOutLine.Click += new System.EventHandler(this.btnImportStkOutLine_Click);
            // 
            // btnPaste
            // 
            this.btnPaste.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnPaste.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnPaste.Image = global::ZNLCRM.UI.Properties.Resources.paste;
            this.btnPaste.Location = new System.Drawing.Point(265, 4);
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Size = new System.Drawing.Size(75, 23);
            this.btnPaste.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnPaste.TabIndex = 6;
            this.btnPaste.Text = "粘贴数据";
            // 
            // btnDelRow
            // 
            this.btnDelRow.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDelRow.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDelRow.Image = global::ZNLCRM.UI.Properties.Resources.del_4;
            this.btnDelRow.Location = new System.Drawing.Point(173, 5);
            this.btnDelRow.Name = "btnDelRow";
            this.btnDelRow.Size = new System.Drawing.Size(87, 23);
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
            // superTabItem3
            // 
            this.superTabItem3.AttachedControl = this.superTabControlPanel3;
            this.superTabItem3.GlobalItem = false;
            this.superTabItem3.Name = "superTabItem3";
            this.superTabItem3.Text = "退货明细";
            // 
            // stcpSys_AttachFiles
            // 
            this.stcpSys_AttachFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stcpSys_AttachFiles.Location = new System.Drawing.Point(0, 0);
            this.stcpSys_AttachFiles.Name = "stcpSys_AttachFiles";
            this.stcpSys_AttachFiles.Size = new System.Drawing.Size(1043, 315);
            this.stcpSys_AttachFiles.TabIndex = 0;
            this.stcpSys_AttachFiles.TabItem = this.superTabItem5;
            // 
            // superTabItem5
            // 
            this.superTabItem5.AttachedControl = this.stcpSys_AttachFiles;
            this.superTabItem5.GlobalItem = false;
            this.superTabItem5.Name = "superTabItem5";
            this.superTabItem5.Text = "相关附件";
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
            this.ucExpandableSplitter1.Location = new System.Drawing.Point(0, 256);
            this.ucExpandableSplitter1.Name = "ucExpandableSplitter1";
            this.ucExpandableSplitter1.Size = new System.Drawing.Size(1043, 3);
            this.ucExpandableSplitter1.Style = DevComponents.DotNetBar.eSplitterStyle.Office2007;
            this.ucExpandableSplitter1.TabIndex = 4;
            this.ucExpandableSplitter1.TabStop = false;
            // 
            // ucPanel3
            // 
            this.ucPanel3.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel3.Controls.Add(this.ucSuperTabControl1);
            this.ucPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucPanel3.Location = new System.Drawing.Point(0, 0);
            this.ucPanel3.Name = "ucPanel3";
            this.ucPanel3.Size = new System.Drawing.Size(1043, 256);
            this.ucPanel3.TabIndex = 1;
            // 
            // ucSuperTabControl1
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.ucSuperTabControl1.ControlBox.CloseBox.Name = "";
            // 
            // 
            // 
            this.ucSuperTabControl1.ControlBox.MenuBox.Name = "";
            this.ucSuperTabControl1.ControlBox.Name = "";
            this.ucSuperTabControl1.ControlBox.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ucSuperTabControl1.ControlBox.MenuBox,
            this.ucSuperTabControl1.ControlBox.CloseBox});
            this.ucSuperTabControl1.Controls.Add(this.stcpBase);
            this.ucSuperTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucSuperTabControl1.Location = new System.Drawing.Point(0, 0);
            this.ucSuperTabControl1.Name = "ucSuperTabControl1";
            this.ucSuperTabControl1.ReorderTabsEnabled = true;
            this.ucSuperTabControl1.SelectedTabFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold);
            this.ucSuperTabControl1.SelectedTabIndex = 0;
            this.ucSuperTabControl1.Size = new System.Drawing.Size(1043, 256);
            this.ucSuperTabControl1.TabFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucSuperTabControl1.TabIndex = 1;
            this.ucSuperTabControl1.Tabs.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.stiBase});
            this.ucSuperTabControl1.Text = "ucSuperTabControl1";
            // 
            // stcpBase
            // 
            this.stcpBase.Controls.Add(this.txtExplain);
            this.stcpBase.Controls.Add(this.ucLabelX10);
            this.stcpBase.Controls.Add(this.txtOperDeptID);
            this.stcpBase.Controls.Add(this.txtSODate);
            this.stcpBase.Controls.Add(this.ucLabelX9);
            this.stcpBase.Controls.Add(this.txtRemark);
            this.stcpBase.Controls.Add(this.ucLabelX8);
            this.stcpBase.Controls.Add(this.txtOperEmpID);
            this.stcpBase.Controls.Add(this.txtCreatedTime);
            this.stcpBase.Controls.Add(this.txtCustomerID);
            this.stcpBase.Controls.Add(this.txtUpdatedTime);
            this.stcpBase.Controls.Add(this.txtSOGuid);
            this.stcpBase.Controls.Add(this.txtApproveStatus);
            this.stcpBase.Controls.Add(this.txtSRGuid);
            this.stcpBase.Controls.Add(this.ucLabelX53);
            this.stcpBase.Controls.Add(this.txtStatus);
            this.stcpBase.Controls.Add(this.ucLabelX52);
            this.stcpBase.Controls.Add(this.ucLabelX51);
            this.stcpBase.Controls.Add(this.txtUpdatedEmpName);
            this.stcpBase.Controls.Add(this.ucLabelX50);
            this.stcpBase.Controls.Add(this.ucLabelX49);
            this.stcpBase.Controls.Add(this.txtCreatedEmpName);
            this.stcpBase.Controls.Add(this.ucLabelX48);
            this.stcpBase.Controls.Add(this.txtFreight);
            this.stcpBase.Controls.Add(this.ucLabelX7);
            this.stcpBase.Controls.Add(this.txtShippingNo);
            this.stcpBase.Controls.Add(this.ucLabelX6);
            this.stcpBase.Controls.Add(this.cboTransportCompany);
            this.stcpBase.Controls.Add(this.ucLabelX4);
            this.stcpBase.Controls.Add(this.cboFreightClearForm);
            this.stcpBase.Controls.Add(this.ucLabelX3);
            this.stcpBase.Controls.Add(this.txtSOBillNo);
            this.stcpBase.Controls.Add(this.ucLabelX2);
            this.stcpBase.Controls.Add(this.ucLabelX54);
            this.stcpBase.Controls.Add(this.txtReturnDate);
            this.stcpBase.Controls.Add(this.cboOperOrgID);
            this.stcpBase.Controls.Add(this.ucLabelX1);
            this.stcpBase.Controls.Add(this.txtBillNo);
            this.stcpBase.Controls.Add(this.txtOperEmpName);
            this.stcpBase.Controls.Add(this.ucLabelX38);
            this.stcpBase.Controls.Add(this.txtOperDeptName);
            this.stcpBase.Controls.Add(this.ucLabelX37);
            this.stcpBase.Controls.Add(this.ucLabelX36);
            this.stcpBase.Controls.Add(this.cboCurrency);
            this.stcpBase.Controls.Add(this.ucLabelX5);
            this.stcpBase.Controls.Add(this.ucLabelX16);
            this.stcpBase.Controls.Add(this.txtCustomerName);
            this.stcpBase.Controls.Add(this.txtAmount);
            this.stcpBase.Controls.Add(this.ucLabelX13);
            this.stcpBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stcpBase.Location = new System.Drawing.Point(0, 28);
            this.stcpBase.Name = "stcpBase";
            this.stcpBase.Size = new System.Drawing.Size(1043, 228);
            this.stcpBase.TabIndex = 1;
            this.stcpBase.TabItem = this.stiBase;
            // 
            // txtExplain
            // 
            // 
            // 
            // 
            this.txtExplain.Border.Class = "TextBoxBorder";
            this.txtExplain.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtExplain.EnterToNextControl = false;
            this.txtExplain.Location = new System.Drawing.Point(99, 61);
            this.txtExplain.Name = "txtExplain";
            this.txtExplain.PreventEnterBeep = true;
            this.txtExplain.Size = new System.Drawing.Size(647, 21);
            this.txtExplain.TabIndex = 116;
            // 
            // ucLabelX10
            // 
            // 
            // 
            // 
            this.ucLabelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ucLabelX10.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabelX10.ForeColor = System.Drawing.Color.Gray;
            this.ucLabelX10.Location = new System.Drawing.Point(23, 61);
            this.ucLabelX10.Name = "ucLabelX10";
            this.ucLabelX10.Size = new System.Drawing.Size(66, 23);
            this.ucLabelX10.TabIndex = 115;
            this.ucLabelX10.Text = "退货原因：";
            // 
            // txtOperDeptID
            // 
            // 
            // 
            // 
            this.txtOperDeptID.Border.Class = "TextBoxBorder";
            this.txtOperDeptID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtOperDeptID.EnterToNextControl = false;
            this.txtOperDeptID.Location = new System.Drawing.Point(615, 206);
            this.txtOperDeptID.Name = "txtOperDeptID";
            this.txtOperDeptID.Size = new System.Drawing.Size(27, 21);
            this.txtOperDeptID.TabIndex = 114;
            // 
            // txtSODate
            // 
            // 
            // 
            // 
            this.txtSODate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtSODate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSODate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.txtSODate.ButtonDropDown.Visible = true;
            this.txtSODate.CustomFormat = "yyyy-MM-dd";
            this.txtSODate.Enabled = false;
            this.txtSODate.Format = DevComponents.Editors.eDateTimePickerFormat.Custom;
            this.txtSODate.IsPopupCalendarOpen = false;
            this.txtSODate.Location = new System.Drawing.Point(846, 7);
            // 
            // 
            // 
            this.txtSODate.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.txtSODate.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.txtSODate.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSODate.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.txtSODate.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.txtSODate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.txtSODate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.txtSODate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.txtSODate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtSODate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.txtSODate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.txtSODate.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSODate.MonthCalendar.DisplayMonth = new System.DateTime(2014, 11, 1, 0, 0, 0, 0);
            this.txtSODate.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.txtSODate.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.txtSODate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.txtSODate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.txtSODate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.txtSODate.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSODate.MonthCalendar.TodayButtonVisible = true;
            this.txtSODate.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.txtSODate.Name = "txtSODate";
            this.txtSODate.Size = new System.Drawing.Size(150, 21);
            this.txtSODate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.txtSODate.TabIndex = 113;
            // 
            // ucLabelX9
            // 
            // 
            // 
            // 
            this.ucLabelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ucLabelX9.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabelX9.ForeColor = System.Drawing.Color.Gray;
            this.ucLabelX9.Location = new System.Drawing.Point(772, 7);
            this.ucLabelX9.Name = "ucLabelX9";
            this.ucLabelX9.Size = new System.Drawing.Size(70, 23);
            this.ucLabelX9.TabIndex = 112;
            this.ucLabelX9.Text = "合同日期：";
            // 
            // txtRemark
            // 
            // 
            // 
            // 
            this.txtRemark.Border.Class = "TextBoxBorder";
            this.txtRemark.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtRemark.EnterToNextControl = false;
            this.txtRemark.Location = new System.Drawing.Point(99, 143);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.PreventEnterBeep = true;
            this.txtRemark.Size = new System.Drawing.Size(647, 21);
            this.txtRemark.TabIndex = 111;
            // 
            // ucLabelX8
            // 
            // 
            // 
            // 
            this.ucLabelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ucLabelX8.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabelX8.ForeColor = System.Drawing.Color.Gray;
            this.ucLabelX8.Location = new System.Drawing.Point(45, 143);
            this.ucLabelX8.Name = "ucLabelX8";
            this.ucLabelX8.Size = new System.Drawing.Size(42, 23);
            this.ucLabelX8.TabIndex = 110;
            this.ucLabelX8.Text = "备注：";
            // 
            // txtOperEmpID
            // 
            // 
            // 
            // 
            this.txtOperEmpID.Border.Class = "TextBoxBorder";
            this.txtOperEmpID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtOperEmpID.EnterToNextControl = false;
            this.txtOperEmpID.Location = new System.Drawing.Point(648, 205);
            this.txtOperEmpID.Name = "txtOperEmpID";
            this.txtOperEmpID.Size = new System.Drawing.Size(27, 21);
            this.txtOperEmpID.TabIndex = 97;
            // 
            // txtCreatedTime
            // 
            // 
            // 
            // 
            this.txtCreatedTime.Border.Class = "TextBoxBorder";
            this.txtCreatedTime.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCreatedTime.EnterToNextControl = false;
            this.txtCreatedTime.Location = new System.Drawing.Point(347, 172);
            this.txtCreatedTime.Name = "txtCreatedTime";
            this.txtCreatedTime.ReadOnly = true;
            this.txtCreatedTime.Size = new System.Drawing.Size(150, 21);
            this.txtCreatedTime.TabIndex = 109;
            // 
            // txtCustomerID
            // 
            // 
            // 
            // 
            this.txtCustomerID.Border.Class = "TextBoxBorder";
            this.txtCustomerID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCustomerID.EnterToNextControl = false;
            this.txtCustomerID.Location = new System.Drawing.Point(582, 205);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(27, 21);
            this.txtCustomerID.TabIndex = 96;
            // 
            // txtUpdatedTime
            // 
            // 
            // 
            // 
            this.txtUpdatedTime.Border.Class = "TextBoxBorder";
            this.txtUpdatedTime.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtUpdatedTime.EnterToNextControl = false;
            this.txtUpdatedTime.Location = new System.Drawing.Point(846, 173);
            this.txtUpdatedTime.Name = "txtUpdatedTime";
            this.txtUpdatedTime.ReadOnly = true;
            this.txtUpdatedTime.Size = new System.Drawing.Size(150, 21);
            this.txtUpdatedTime.TabIndex = 108;
            // 
            // txtSOGuid
            // 
            // 
            // 
            // 
            this.txtSOGuid.Border.Class = "TextBoxBorder";
            this.txtSOGuid.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSOGuid.EnterToNextControl = false;
            this.txtSOGuid.Location = new System.Drawing.Point(549, 205);
            this.txtSOGuid.Name = "txtSOGuid";
            this.txtSOGuid.Size = new System.Drawing.Size(27, 21);
            this.txtSOGuid.TabIndex = 95;
            // 
            // txtApproveStatus
            // 
            // 
            // 
            // 
            this.txtApproveStatus.Border.Class = "TextBoxBorder";
            this.txtApproveStatus.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtApproveStatus.EnterToNextControl = false;
            this.txtApproveStatus.Location = new System.Drawing.Point(347, 199);
            this.txtApproveStatus.Name = "txtApproveStatus";
            this.txtApproveStatus.ReadOnly = true;
            this.txtApproveStatus.Size = new System.Drawing.Size(150, 21);
            this.txtApproveStatus.TabIndex = 107;
            // 
            // txtSRGuid
            // 
            // 
            // 
            // 
            this.txtSRGuid.Border.Class = "TextBoxBorder";
            this.txtSRGuid.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSRGuid.EnterToNextControl = false;
            this.txtSRGuid.Location = new System.Drawing.Point(516, 204);
            this.txtSRGuid.Name = "txtSRGuid";
            this.txtSRGuid.Size = new System.Drawing.Size(27, 21);
            this.txtSRGuid.TabIndex = 94;
            // 
            // ucLabelX53
            // 
            // 
            // 
            // 
            this.ucLabelX53.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ucLabelX53.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabelX53.ForeColor = System.Drawing.Color.Gray;
            this.ucLabelX53.Location = new System.Drawing.Point(271, 200);
            this.ucLabelX53.Name = "ucLabelX53";
            this.ucLabelX53.Size = new System.Drawing.Size(70, 23);
            this.ucLabelX53.TabIndex = 106;
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
            this.txtStatus.Location = new System.Drawing.Point(99, 199);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(150, 21);
            this.txtStatus.TabIndex = 105;
            // 
            // ucLabelX52
            // 
            // 
            // 
            // 
            this.ucLabelX52.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ucLabelX52.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabelX52.ForeColor = System.Drawing.Color.Gray;
            this.ucLabelX52.Location = new System.Drawing.Point(23, 197);
            this.ucLabelX52.Name = "ucLabelX52";
            this.ucLabelX52.Size = new System.Drawing.Size(70, 23);
            this.ucLabelX52.TabIndex = 104;
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
            this.ucLabelX51.Location = new System.Drawing.Point(772, 173);
            this.ucLabelX51.Name = "ucLabelX51";
            this.ucLabelX51.Size = new System.Drawing.Size(70, 23);
            this.ucLabelX51.TabIndex = 103;
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
            this.txtUpdatedEmpName.Location = new System.Drawing.Point(596, 172);
            this.txtUpdatedEmpName.Name = "txtUpdatedEmpName";
            this.txtUpdatedEmpName.ReadOnly = true;
            this.txtUpdatedEmpName.Size = new System.Drawing.Size(150, 21);
            this.txtUpdatedEmpName.TabIndex = 102;
            // 
            // ucLabelX50
            // 
            // 
            // 
            // 
            this.ucLabelX50.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ucLabelX50.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabelX50.ForeColor = System.Drawing.Color.Gray;
            this.ucLabelX50.Location = new System.Drawing.Point(523, 173);
            this.ucLabelX50.Name = "ucLabelX50";
            this.ucLabelX50.Size = new System.Drawing.Size(70, 23);
            this.ucLabelX50.TabIndex = 101;
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
            this.ucLabelX49.Location = new System.Drawing.Point(271, 172);
            this.ucLabelX49.Name = "ucLabelX49";
            this.ucLabelX49.Size = new System.Drawing.Size(70, 23);
            this.ucLabelX49.TabIndex = 100;
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
            this.txtCreatedEmpName.Location = new System.Drawing.Point(99, 172);
            this.txtCreatedEmpName.Name = "txtCreatedEmpName";
            this.txtCreatedEmpName.ReadOnly = true;
            this.txtCreatedEmpName.Size = new System.Drawing.Size(150, 21);
            this.txtCreatedEmpName.TabIndex = 99;
            // 
            // ucLabelX48
            // 
            // 
            // 
            // 
            this.ucLabelX48.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ucLabelX48.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabelX48.ForeColor = System.Drawing.Color.Gray;
            this.ucLabelX48.Location = new System.Drawing.Point(23, 172);
            this.ucLabelX48.Name = "ucLabelX48";
            this.ucLabelX48.Size = new System.Drawing.Size(70, 23);
            this.ucLabelX48.TabIndex = 98;
            this.ucLabelX48.Text = "创建人员：";
            // 
            // txtFreight
            // 
            // 
            // 
            // 
            this.txtFreight.Border.Class = "TextBoxBorder";
            this.txtFreight.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtFreight.EnterToNextControl = false;
            this.txtFreight.Location = new System.Drawing.Point(846, 89);
            this.txtFreight.Name = "txtFreight";
            this.txtFreight.PreventEnterBeep = true;
            this.txtFreight.Size = new System.Drawing.Size(150, 21);
            this.txtFreight.TabIndex = 89;
            // 
            // ucLabelX7
            // 
            // 
            // 
            // 
            this.ucLabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ucLabelX7.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabelX7.ForeColor = System.Drawing.Color.Gray;
            this.ucLabelX7.Location = new System.Drawing.Point(772, 87);
            this.ucLabelX7.Name = "ucLabelX7";
            this.ucLabelX7.Size = new System.Drawing.Size(66, 23);
            this.ucLabelX7.TabIndex = 88;
            this.ucLabelX7.Text = "运费金额：";
            // 
            // txtShippingNo
            // 
            // 
            // 
            // 
            this.txtShippingNo.Border.Class = "TextBoxBorder";
            this.txtShippingNo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtShippingNo.EnterToNextControl = false;
            this.txtShippingNo.Location = new System.Drawing.Point(346, 89);
            this.txtShippingNo.Name = "txtShippingNo";
            this.txtShippingNo.PreventEnterBeep = true;
            this.txtShippingNo.Size = new System.Drawing.Size(150, 21);
            this.txtShippingNo.TabIndex = 87;
            // 
            // ucLabelX6
            // 
            // 
            // 
            // 
            this.ucLabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ucLabelX6.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabelX6.ForeColor = System.Drawing.Color.Gray;
            this.ucLabelX6.Location = new System.Drawing.Point(274, 88);
            this.ucLabelX6.Name = "ucLabelX6";
            this.ucLabelX6.Size = new System.Drawing.Size(66, 23);
            this.ucLabelX6.TabIndex = 86;
            this.ucLabelX6.Text = "货运单号：";
            // 
            // cboTransportCompany
            // 
            this.cboTransportCompany.DisplayMember = "Text";
            this.cboTransportCompany.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboTransportCompany.FormattingEnabled = true;
            this.cboTransportCompany.ItemHeight = 15;
            this.cboTransportCompany.Location = new System.Drawing.Point(98, 88);
            this.cboTransportCompany.Name = "cboTransportCompany";
            this.cboTransportCompany.Size = new System.Drawing.Size(150, 21);
            this.cboTransportCompany.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboTransportCompany.TabIndex = 85;
            // 
            // ucLabelX4
            // 
            // 
            // 
            // 
            this.ucLabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ucLabelX4.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabelX4.ForeColor = System.Drawing.Color.Gray;
            this.ucLabelX4.Location = new System.Drawing.Point(23, 88);
            this.ucLabelX4.Name = "ucLabelX4";
            this.ucLabelX4.Size = new System.Drawing.Size(66, 23);
            this.ucLabelX4.TabIndex = 84;
            this.ucLabelX4.Text = "货运公司：";
            // 
            // cboFreightClearForm
            // 
            this.cboFreightClearForm.DisplayMember = "Text";
            this.cboFreightClearForm.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboFreightClearForm.FormattingEnabled = true;
            this.cboFreightClearForm.ItemHeight = 15;
            this.cboFreightClearForm.Location = new System.Drawing.Point(596, 89);
            this.cboFreightClearForm.Name = "cboFreightClearForm";
            this.cboFreightClearForm.Size = new System.Drawing.Size(150, 21);
            this.cboFreightClearForm.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboFreightClearForm.TabIndex = 83;
            // 
            // ucLabelX3
            // 
            // 
            // 
            // 
            this.ucLabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ucLabelX3.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabelX3.ForeColor = System.Drawing.Color.Gray;
            this.ucLabelX3.Location = new System.Drawing.Point(519, 86);
            this.ucLabelX3.Name = "ucLabelX3";
            this.ucLabelX3.Size = new System.Drawing.Size(70, 23);
            this.ucLabelX3.TabIndex = 82;
            this.ucLabelX3.Text = "运费结算：";
            // 
            // txtSOBillNo
            // 
            // 
            // 
            // 
            this.txtSOBillNo.Border.Class = "TextBoxBorder";
            this.txtSOBillNo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSOBillNo.ButtonCustom.Visible = true;
            this.txtSOBillNo.ButtonCustom2.Image = global::ZNLCRM.UI.Properties.Resources.del_6;
            this.txtSOBillNo.ButtonCustom2.Visible = true;
            this.txtSOBillNo.EnterToNextControl = false;
            this.txtSOBillNo.Location = new System.Drawing.Point(596, 7);
            this.txtSOBillNo.Name = "txtSOBillNo";
            this.txtSOBillNo.Size = new System.Drawing.Size(150, 21);
            this.txtSOBillNo.TabIndex = 81;
            this.txtSOBillNo.ButtonCustomClick += new System.EventHandler(this.txtSOBillNo_ButtonCustomClick);
            this.txtSOBillNo.ButtonCustom2Click += new System.EventHandler(this.txtSOBillNo_ButtonCustom2Click);
            // 
            // ucLabelX2
            // 
            // 
            // 
            // 
            this.ucLabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ucLabelX2.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabelX2.ForeColor = System.Drawing.Color.Gray;
            this.ucLabelX2.Location = new System.Drawing.Point(523, 7);
            this.ucLabelX2.Name = "ucLabelX2";
            this.ucLabelX2.Size = new System.Drawing.Size(70, 23);
            this.ucLabelX2.TabIndex = 80;
            this.ucLabelX2.Text = "销售单号：";
            // 
            // ucLabelX54
            // 
            // 
            // 
            // 
            this.ucLabelX54.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ucLabelX54.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabelX54.ForeColor = System.Drawing.Color.Gray;
            this.ucLabelX54.Location = new System.Drawing.Point(275, 7);
            this.ucLabelX54.Name = "ucLabelX54";
            this.ucLabelX54.Size = new System.Drawing.Size(70, 23);
            this.ucLabelX54.TabIndex = 78;
            this.ucLabelX54.Text = "退货日期：";
            // 
            // txtReturnDate
            // 
            // 
            // 
            // 
            this.txtReturnDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtReturnDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtReturnDate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.txtReturnDate.ButtonDropDown.Visible = true;
            this.txtReturnDate.CustomFormat = "yyyy-MM-dd";
            this.txtReturnDate.Format = DevComponents.Editors.eDateTimePickerFormat.Custom;
            this.txtReturnDate.IsPopupCalendarOpen = false;
            this.txtReturnDate.Location = new System.Drawing.Point(349, 7);
            // 
            // 
            // 
            this.txtReturnDate.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.txtReturnDate.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtReturnDate.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            // 
            // 
            // 
            this.txtReturnDate.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtReturnDate.MonthCalendar.DisplayMonth = new System.DateTime(2015, 3, 1, 0, 0, 0, 0);
            this.txtReturnDate.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.txtReturnDate.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.txtReturnDate.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtReturnDate.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.txtReturnDate.Name = "txtReturnDate";
            this.txtReturnDate.Size = new System.Drawing.Size(150, 21);
            this.txtReturnDate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.txtReturnDate.TabIndex = 79;
            // 
            // cboOperOrgID
            // 
            this.cboOperOrgID.DisplayMember = "Text";
            this.cboOperOrgID.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboOperOrgID.FormattingEnabled = true;
            this.cboOperOrgID.ItemHeight = 15;
            this.cboOperOrgID.Location = new System.Drawing.Point(99, 116);
            this.cboOperOrgID.Name = "cboOperOrgID";
            this.cboOperOrgID.Size = new System.Drawing.Size(150, 21);
            this.cboOperOrgID.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboOperOrgID.TabIndex = 3;
            // 
            // ucLabelX1
            // 
            // 
            // 
            // 
            this.ucLabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ucLabelX1.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabelX1.ForeColor = System.Drawing.Color.Gray;
            this.ucLabelX1.Location = new System.Drawing.Point(23, 7);
            this.ucLabelX1.Name = "ucLabelX1";
            this.ucLabelX1.Size = new System.Drawing.Size(70, 23);
            this.ucLabelX1.TabIndex = 1;
            this.ucLabelX1.Text = "退货单号：";
            // 
            // txtBillNo
            // 
            // 
            // 
            // 
            this.txtBillNo.Border.Class = "TextBoxBorder";
            this.txtBillNo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtBillNo.EnterToNextControl = false;
            this.txtBillNo.Location = new System.Drawing.Point(99, 7);
            this.txtBillNo.Name = "txtBillNo";
            this.txtBillNo.ReadOnly = true;
            this.txtBillNo.Size = new System.Drawing.Size(150, 21);
            this.txtBillNo.TabIndex = 0;
            // 
            // txtOperEmpName
            // 
            // 
            // 
            // 
            this.txtOperEmpName.Border.Class = "TextBoxBorder";
            this.txtOperEmpName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtOperEmpName.ButtonCustom.Visible = true;
            this.txtOperEmpName.ButtonCustom2.Image = global::ZNLCRM.UI.Properties.Resources.del_6;
            this.txtOperEmpName.ButtonCustom2.Visible = true;
            this.txtOperEmpName.EnterToNextControl = false;
            this.txtOperEmpName.Location = new System.Drawing.Point(595, 116);
            this.txtOperEmpName.Name = "txtOperEmpName";
            this.txtOperEmpName.Size = new System.Drawing.Size(150, 21);
            this.txtOperEmpName.TabIndex = 25;
            this.txtOperEmpName.ButtonCustomClick += new System.EventHandler(this.txtOperEmpName_ButtonCustomClick);
            this.txtOperEmpName.ButtonCustom2Click += new System.EventHandler(this.txtOperEmpName_ButtonCustom2Click);
            // 
            // ucLabelX38
            // 
            // 
            // 
            // 
            this.ucLabelX38.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ucLabelX38.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabelX38.ForeColor = System.Drawing.Color.Gray;
            this.ucLabelX38.Location = new System.Drawing.Point(519, 112);
            this.ucLabelX38.Name = "ucLabelX38";
            this.ucLabelX38.Size = new System.Drawing.Size(70, 23);
            this.ucLabelX38.TabIndex = 24;
            this.ucLabelX38.Text = "归属人员：";
            // 
            // txtOperDeptName
            // 
            // 
            // 
            // 
            this.txtOperDeptName.Border.Class = "TextBoxBorder";
            this.txtOperDeptName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtOperDeptName.ButtonCustom.Visible = true;
            this.txtOperDeptName.ButtonCustom2.Image = global::ZNLCRM.UI.Properties.Resources.del_6;
            this.txtOperDeptName.ButtonCustom2.Visible = true;
            this.txtOperDeptName.EnterToNextControl = false;
            this.txtOperDeptName.Location = new System.Drawing.Point(347, 116);
            this.txtOperDeptName.Name = "txtOperDeptName";
            this.txtOperDeptName.Size = new System.Drawing.Size(150, 21);
            this.txtOperDeptName.TabIndex = 23;
            this.txtOperDeptName.ButtonCustomClick += new System.EventHandler(this.txtOperDeptName_ButtonCustomClick);
            this.txtOperDeptName.ButtonCustom2Click += new System.EventHandler(this.txtOperDeptName_ButtonCustom2Click);
            // 
            // ucLabelX37
            // 
            // 
            // 
            // 
            this.ucLabelX37.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ucLabelX37.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabelX37.ForeColor = System.Drawing.Color.Gray;
            this.ucLabelX37.Location = new System.Drawing.Point(271, 116);
            this.ucLabelX37.Name = "ucLabelX37";
            this.ucLabelX37.Size = new System.Drawing.Size(70, 23);
            this.ucLabelX37.TabIndex = 22;
            this.ucLabelX37.Text = "归属部门：";
            // 
            // ucLabelX36
            // 
            // 
            // 
            // 
            this.ucLabelX36.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ucLabelX36.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabelX36.ForeColor = System.Drawing.Color.Gray;
            this.ucLabelX36.Location = new System.Drawing.Point(23, 114);
            this.ucLabelX36.Name = "ucLabelX36";
            this.ucLabelX36.Size = new System.Drawing.Size(70, 23);
            this.ucLabelX36.TabIndex = 20;
            this.ucLabelX36.Text = "归属机构：";
            // 
            // cboCurrency
            // 
            this.cboCurrency.DisplayMember = "Text";
            this.cboCurrency.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboCurrency.FormattingEnabled = true;
            this.cboCurrency.ItemHeight = 15;
            this.cboCurrency.Location = new System.Drawing.Point(596, 34);
            this.cboCurrency.Name = "cboCurrency";
            this.cboCurrency.Size = new System.Drawing.Size(150, 21);
            this.cboCurrency.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboCurrency.TabIndex = 48;
            // 
            // ucLabelX5
            // 
            // 
            // 
            // 
            this.ucLabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ucLabelX5.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabelX5.ForeColor = System.Drawing.Color.Gray;
            this.ucLabelX5.Location = new System.Drawing.Point(23, 34);
            this.ucLabelX5.Name = "ucLabelX5";
            this.ucLabelX5.Size = new System.Drawing.Size(70, 23);
            this.ucLabelX5.TabIndex = 8;
            this.ucLabelX5.Text = "客户名称：";
            // 
            // ucLabelX16
            // 
            // 
            // 
            // 
            this.ucLabelX16.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ucLabelX16.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabelX16.ForeColor = System.Drawing.Color.Gray;
            this.ucLabelX16.Location = new System.Drawing.Point(772, 34);
            this.ucLabelX16.Name = "ucLabelX16";
            this.ucLabelX16.Size = new System.Drawing.Size(70, 23);
            this.ucLabelX16.TabIndex = 45;
            this.ucLabelX16.Text = "退货金额：";
            // 
            // txtCustomerName
            // 
            // 
            // 
            // 
            this.txtCustomerName.Border.Class = "TextBoxBorder";
            this.txtCustomerName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCustomerName.ButtonCustom.Visible = true;
            this.txtCustomerName.ButtonCustom2.Image = global::ZNLCRM.UI.Properties.Resources.del_6;
            this.txtCustomerName.ButtonCustom2.Visible = true;
            this.txtCustomerName.EnterToNextControl = false;
            this.txtCustomerName.Location = new System.Drawing.Point(99, 34);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(400, 21);
            this.txtCustomerName.TabIndex = 9;
            this.txtCustomerName.ButtonCustomClick += new System.EventHandler(this.txtCustomerName_ButtonCustomClick);
            this.txtCustomerName.ButtonCustom2Click += new System.EventHandler(this.txtCustomerName_ButtonCustom2Click);
            // 
            // txtAmount
            // 
            // 
            // 
            // 
            this.txtAmount.Border.Class = "TextBoxBorder";
            this.txtAmount.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtAmount.EnterToNextControl = false;
            this.txtAmount.Location = new System.Drawing.Point(846, 34);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.ReadOnly = true;
            this.txtAmount.Size = new System.Drawing.Size(150, 21);
            this.txtAmount.TabIndex = 43;
            // 
            // ucLabelX13
            // 
            // 
            // 
            // 
            this.ucLabelX13.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ucLabelX13.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabelX13.ForeColor = System.Drawing.Color.Gray;
            this.ucLabelX13.Location = new System.Drawing.Point(548, 36);
            this.ucLabelX13.Name = "ucLabelX13";
            this.ucLabelX13.Size = new System.Drawing.Size(45, 23);
            this.ucLabelX13.TabIndex = 40;
            this.ucLabelX13.Text = "币种：";
            // 
            // stiBase
            // 
            this.stiBase.AttachedControl = this.stcpBase;
            this.stiBase.GlobalItem = false;
            this.stiBase.Name = "stiBase";
            this.stiBase.Text = " 基本信息";
            // 
            // frmSalesReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 610);
            this.Controls.Add(this.ucPanel2);
            this.Controls.Add(this.ucPanel1);
            this.Name = "frmSalesReturn";
            this.Text = "销售退货单";
            this.Load += new System.EventHandler(this.frmSalesReturn_Load);
            this.ucPanel1.ResumeLayout(false);
            this.ucPanel1.PerformLayout();
            this.tsOper.ResumeLayout(false);
            this.tsOper.PerformLayout();
            this.ucPanel2.ResumeLayout(false);
            this.ucPanel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ucSuperTabControl2)).EndInit();
            this.ucSuperTabControl2.ResumeLayout(false);
            this.superTabControlPanel3.ResumeLayout(false);
            this.ucPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesReturnLine)).EndInit();
            this.ucPanel5.ResumeLayout(false);
            this.ucPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ucSuperTabControl1)).EndInit();
            this.ucSuperTabControl1.ResumeLayout(false);
            this.stcpBase.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtSODate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReturnDate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.UcPanel ucPanel1;
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
        private Controls.UcPanel ucPanel2;
        private Controls.UcPanel ucPanel7;
        private Controls.UcSuperTabControl ucSuperTabControl2;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel3;
        private Controls.UcPanel ucPanel6;
        private Controls.UcDataGridView dgvSalesReturnLine;
        private Controls.UcPanel ucPanel5;
        private Controls.UcButton btnImportStkOutLine;
        private Controls.UcButton btnPaste;
        private Controls.UcButton btnDelRow;
        private Controls.UcButton btnAddRow;
        private DevComponents.DotNetBar.SuperTabItem superTabItem3;
        private DevComponents.DotNetBar.SuperTabControlPanel stcpSys_AttachFiles;
        private DevComponents.DotNetBar.SuperTabItem superTabItem5;
        private Controls.UcExpandableSplitter ucExpandableSplitter1;
        private Controls.UcPanel ucPanel3;
        private Controls.UcSuperTabControl ucSuperTabControl1;
        private DevComponents.DotNetBar.SuperTabControlPanel stcpBase;
        private Controls.UcLabelX ucLabelX54;
        private Controls.UcDateTimeInput txtReturnDate;
        private Controls.UcComboBox cboOperOrgID;
        private Controls.UcLabelX ucLabelX1;
        private Controls.UcTextBox txtBillNo;
        private Controls.UcTextBox txtOperEmpName;
        private Controls.UcLabelX ucLabelX38;
        private Controls.UcTextBox txtOperDeptName;
        private Controls.UcLabelX ucLabelX37;
        private Controls.UcLabelX ucLabelX36;
        private Controls.UcComboBox cboCurrency;
        private Controls.UcLabelX ucLabelX5;
        private Controls.UcLabelX ucLabelX16;
        private Controls.UcTextBox txtCustomerName;
        private Controls.UcTextBox txtAmount;
        private Controls.UcLabelX ucLabelX13;
        private DevComponents.DotNetBar.SuperTabItem stiBase;
        private Controls.UcLabelX ucLabelX2;
        private Controls.UcTextBox txtSOBillNo;
        private Controls.UcDateTimeInput txtSODate;
        private Controls.UcLabelX ucLabelX9;
        private Controls.UcTextBox txtRemark;
        private Controls.UcLabelX ucLabelX8;
        private Controls.UcTextBox txtOperEmpID;
        private Controls.UcTextBox txtCreatedTime;
        private Controls.UcTextBox txtCustomerID;
        private Controls.UcTextBox txtUpdatedTime;
        private Controls.UcTextBox txtSOGuid;
        private Controls.UcTextBox txtApproveStatus;
        private Controls.UcTextBox txtSRGuid;
        private Controls.UcLabelX ucLabelX53;
        private Controls.UcTextBox txtStatus;
        private Controls.UcLabelX ucLabelX52;
        private Controls.UcLabelX ucLabelX51;
        private Controls.UcTextBox txtUpdatedEmpName;
        private Controls.UcLabelX ucLabelX50;
        private Controls.UcLabelX ucLabelX49;
        private Controls.UcTextBox txtCreatedEmpName;
        private Controls.UcLabelX ucLabelX48;
        private Controls.UcTextBox txtFreight;
        private Controls.UcLabelX ucLabelX7;
        private Controls.UcTextBox txtShippingNo;
        private Controls.UcLabelX ucLabelX6;
        private Controls.UcComboBox cboTransportCompany;
        private Controls.UcLabelX ucLabelX4;
        private Controls.UcComboBox cboFreightClearForm;
        private Controls.UcLabelX ucLabelX3;
        private Controls.UcTextBox txtOperDeptID;
        private Controls.UcButton btnInsertBefore;
        private Controls.UcTextBox txtExplain;
        private Controls.UcLabelX ucLabelX10;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSRLineGuid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSRLineID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSOGuid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSOBillNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLineGuid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStkOutGuid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStkOutBillNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStkOutLineGuid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStkInLineGuid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemCode;
        private DevComponents.DotNetBar.Controls.DataGridViewMaskedTextBoxAdvColumn colModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBrand;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPackage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBatch;
        private DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn colUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStkInQty;
        private DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn colCurrency;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuality;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMPQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMarkCode;
        private DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn colInvType;
        private DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn colWarehouse;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRemark;
    }
}