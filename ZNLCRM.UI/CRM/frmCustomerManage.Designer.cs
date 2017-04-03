﻿namespace ZNLCRM.UI.CRM
{
    partial class frmCustomerManage
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
            this.ucPanel1 = new ZNLCRM.Controls.UcPanel(this.components);
            this.ucExpandableSplitter1 = new ZNLCRM.Controls.UcExpandableSplitter(this.components);
            this.ucPanel3 = new ZNLCRM.Controls.UcPanel(this.components);
            this.ucPanel7 = new ZNLCRM.Controls.UcPanel(this.components);
            this.ucPanel10 = new ZNLCRM.Controls.UcPanel(this.components);
            this.ucPanel9 = new ZNLCRM.Controls.UcPanel(this.components);
            this.dgvCompany = new ZNLCRM.Controls.UcDataGridView(this.components);
            this.colCompanyID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCompanyCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIndustry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMainBrand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ucPanel11 = new ZNLCRM.Controls.UcPanel(this.components);
            this.ucLabelX1 = new ZNLCRM.Controls.UcLabelX(this.components);
            this.txtCompanyName = new ZNLCRM.Controls.UcTextBox(this.components);
            this.txtCompanyCode = new ZNLCRM.Controls.UcTextBox(this.components);
            this.ucLabelX2 = new ZNLCRM.Controls.UcLabelX(this.components);
            this.ucPanel12 = new ZNLCRM.Controls.UcPanel(this.components);
            this.pgCompany = new ZNLCRM.Controls.UcPager();
            this.ucPanel4 = new ZNLCRM.Controls.UcPanel(this.components);
            this.ucToolStrip1 = new ZNLCRM.Controls.UcToolStrip(this.components);
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ucPanel8 = new ZNLCRM.Controls.UcPanel(this.components);
            this.ucComAttachedInfo2 = new ZNLCRM.Controls.UcComAttachedInfo();
            this.exWebBrowser1 = new ZNLCRM.Controls.ExWebBrowser();
            this.ucComAttachedInfo1 = new ZNLCRM.Controls.UcComAttachedInfo();
            this.ucPanel2 = new ZNLCRM.Controls.UcPanel(this.components);
            this.adtCust = new ZNLCRM.Controls.UcAdTree(this.components);
            this.nodeConnector1 = new DevComponents.AdvTree.NodeConnector();
            this.elementStyle1 = new DevComponents.DotNetBar.ElementStyle();
            this.ucPanel5 = new ZNLCRM.Controls.UcPanel(this.components);
            this.rdoAllCustomer = new System.Windows.Forms.RadioButton();
            this.rdoMyCustomer = new System.Windows.Forms.RadioButton();
            this.btnSearch = new ZNLCRM.Controls.UcButton(this.components);
            this.btnAddCust = new System.Windows.Forms.ToolStripButton();
            this.btnEditCust = new System.Windows.Forms.ToolStripButton();
            this.btnDelCust = new System.Windows.Forms.ToolStripButton();
            this.btnImport = new System.Windows.Forms.ToolStripButton();
            this.btnExport = new System.Windows.Forms.ToolStripButton();
            this.btnFlowUp = new System.Windows.Forms.ToolStripButton();
            this.trnContactedCust = new DevComponents.AdvTree.Node();
            this.trnToday = new DevComponents.AdvTree.Node();
            this.trnYesterday = new DevComponents.AdvTree.Node();
            this.trnThisWeek = new DevComponents.AdvTree.Node();
            this.trnThisMonth = new DevComponents.AdvTree.Node();
            this.trnThreeMonth = new DevComponents.AdvTree.Node();
            this.trnOneMonthNonContact = new DevComponents.AdvTree.Node();
            this.trnThreeMonthNonContact = new DevComponents.AdvTree.Node();
            this.trnAboveOneYear = new DevComponents.AdvTree.Node();
            this.trnSpecialAttention = new DevComponents.AdvTree.Node();
            this.trnFocus = new DevComponents.AdvTree.Node();
            this.trnColdTreament = new DevComponents.AdvTree.Node();
            this.trnAreTracking = new DevComponents.AdvTree.Node();
            this.trnIsTrackOver = new DevComponents.AdvTree.Node();
            this.trnNoTrack = new DevComponents.AdvTree.Node();
            this.trnDealStage = new DevComponents.AdvTree.Node();
            this.trnIndustryClass = new DevComponents.AdvTree.Node();
            this.trnBusinessBrand = new DevComponents.AdvTree.Node();
            this.trnBusinessSeries = new DevComponents.AdvTree.Node();
            this.trnActiveDegree = new DevComponents.AdvTree.Node();
            this.ucPanel1.SuspendLayout();
            this.ucPanel3.SuspendLayout();
            this.ucPanel7.SuspendLayout();
            this.ucPanel10.SuspendLayout();
            this.ucPanel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompany)).BeginInit();
            this.ucPanel11.SuspendLayout();
            this.ucPanel12.SuspendLayout();
            this.ucPanel4.SuspendLayout();
            this.ucToolStrip1.SuspendLayout();
            this.ucPanel8.SuspendLayout();
            this.ucPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adtCust)).BeginInit();
            this.ucPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // ucPanel1
            // 
            this.ucPanel1.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel1.Controls.Add(this.ucExpandableSplitter1);
            this.ucPanel1.Controls.Add(this.ucPanel3);
            this.ucPanel1.Controls.Add(this.ucPanel2);
            this.ucPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPanel1.Location = new System.Drawing.Point(0, 0);
            this.ucPanel1.Name = "ucPanel1";
            this.ucPanel1.Size = new System.Drawing.Size(1007, 515);
            this.ucPanel1.TabIndex = 1;
            // 
            // ucExpandableSplitter1
            // 
            this.ucExpandableSplitter1.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207)))));
            this.ucExpandableSplitter1.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.ucExpandableSplitter1.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
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
            this.ucExpandableSplitter1.Location = new System.Drawing.Point(219, 0);
            this.ucExpandableSplitter1.Name = "ucExpandableSplitter1";
            this.ucExpandableSplitter1.Size = new System.Drawing.Size(3, 515);
            this.ucExpandableSplitter1.Style = DevComponents.DotNetBar.eSplitterStyle.Office2007;
            this.ucExpandableSplitter1.TabIndex = 2;
            this.ucExpandableSplitter1.TabStop = false;
            // 
            // ucPanel3
            // 
            this.ucPanel3.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel3.Controls.Add(this.ucPanel7);
            this.ucPanel3.Controls.Add(this.ucPanel4);
            this.ucPanel3.Controls.Add(this.ucPanel8);
            this.ucPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPanel3.Location = new System.Drawing.Point(219, 0);
            this.ucPanel3.Name = "ucPanel3";
            this.ucPanel3.Size = new System.Drawing.Size(788, 515);
            this.ucPanel3.TabIndex = 1;
            // 
            // ucPanel7
            // 
            this.ucPanel7.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel7.Controls.Add(this.ucPanel10);
            this.ucPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPanel7.Location = new System.Drawing.Point(0, 34);
            this.ucPanel7.Name = "ucPanel7";
            this.ucPanel7.Size = new System.Drawing.Size(788, 273);
            this.ucPanel7.TabIndex = 6;
            // 
            // ucPanel10
            // 
            this.ucPanel10.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel10.Controls.Add(this.ucPanel9);
            this.ucPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPanel10.Location = new System.Drawing.Point(0, 0);
            this.ucPanel10.Name = "ucPanel10";
            this.ucPanel10.Size = new System.Drawing.Size(788, 273);
            this.ucPanel10.TabIndex = 7;
            // 
            // ucPanel9
            // 
            this.ucPanel9.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel9.Controls.Add(this.dgvCompany);
            this.ucPanel9.Controls.Add(this.ucPanel11);
            this.ucPanel9.Controls.Add(this.ucPanel12);
            this.ucPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPanel9.Location = new System.Drawing.Point(0, 0);
            this.ucPanel9.Name = "ucPanel9";
            this.ucPanel9.Size = new System.Drawing.Size(788, 273);
            this.ucPanel9.TabIndex = 7;
            // 
            // dgvCompany
            // 
            this.dgvCompany.AllowUserToAddRows = false;
            this.dgvCompany.AllowUserToDeleteRows = false;
            this.dgvCompany.AllowUserToOrderColumns = true;
            this.dgvCompany.BackgroundColor = System.Drawing.Color.White;
            this.dgvCompany.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompany.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCompanyID,
            this.colCompanyCode,
            this.colCompanyName,
            this.colArea,
            this.colIndustry,
            this.colMainBrand});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCompany.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCompany.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCompany.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvCompany.HighlightSelectedColumnHeaders = false;
            this.dgvCompany.Location = new System.Drawing.Point(0, 34);
            this.dgvCompany.Name = "dgvCompany";
            this.dgvCompany.PaintEnhancedSelection = false;
            this.dgvCompany.ReadOnly = true;
            this.dgvCompany.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCompany.RowTemplate.Height = 23;
            this.dgvCompany.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCompany.SelectAllSignVisible = false;
            this.dgvCompany.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvCompany.Size = new System.Drawing.Size(788, 205);
            this.dgvCompany.TabIndex = 0;
            this.dgvCompany.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCompany_CellContentDoubleClick);
            this.dgvCompany.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCompany_CellDoubleClick);
            this.dgvCompany.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCompany_RowEnter);
            // 
            // colCompanyID
            // 
            this.colCompanyID.DataPropertyName = "CompanyID";
            this.colCompanyID.HeaderText = "客户ID";
            this.colCompanyID.Name = "colCompanyID";
            this.colCompanyID.ReadOnly = true;
            // 
            // colCompanyCode
            // 
            this.colCompanyCode.DataPropertyName = "CompanyCode";
            this.colCompanyCode.HeaderText = "客户编码";
            this.colCompanyCode.Name = "colCompanyCode";
            this.colCompanyCode.ReadOnly = true;
            // 
            // colCompanyName
            // 
            this.colCompanyName.DataPropertyName = "CompanyName";
            this.colCompanyName.HeaderText = "客户名称";
            this.colCompanyName.Name = "colCompanyName";
            this.colCompanyName.ReadOnly = true;
            // 
            // colArea
            // 
            this.colArea.DataPropertyName = "Area";
            this.colArea.HeaderText = "所在区域";
            this.colArea.Name = "colArea";
            this.colArea.ReadOnly = true;
            // 
            // colIndustry
            // 
            this.colIndustry.DataPropertyName = "Industry";
            this.colIndustry.HeaderText = "行业分类";
            this.colIndustry.Name = "colIndustry";
            this.colIndustry.ReadOnly = true;
            // 
            // colMainBrand
            // 
            this.colMainBrand.DataPropertyName = "MainBrand";
            this.colMainBrand.HeaderText = "经营品牌";
            this.colMainBrand.Name = "colMainBrand";
            this.colMainBrand.ReadOnly = true;
            // 
            // ucPanel11
            // 
            this.ucPanel11.BackColor = System.Drawing.Color.GhostWhite;
            this.ucPanel11.Controls.Add(this.btnSearch);
            this.ucPanel11.Controls.Add(this.ucLabelX1);
            this.ucPanel11.Controls.Add(this.txtCompanyName);
            this.ucPanel11.Controls.Add(this.txtCompanyCode);
            this.ucPanel11.Controls.Add(this.ucLabelX2);
            this.ucPanel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucPanel11.Location = new System.Drawing.Point(0, 0);
            this.ucPanel11.Name = "ucPanel11";
            this.ucPanel11.Size = new System.Drawing.Size(788, 34);
            this.ucPanel11.TabIndex = 1;
            // 
            // ucLabelX1
            // 
            // 
            // 
            // 
            this.ucLabelX1.BackgroundStyle.Class = "";
            this.ucLabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ucLabelX1.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabelX1.ForeColor = System.Drawing.Color.Gray;
            this.ucLabelX1.Location = new System.Drawing.Point(12, 8);
            this.ucLabelX1.Name = "ucLabelX1";
            this.ucLabelX1.Size = new System.Drawing.Size(67, 23);
            this.ucLabelX1.TabIndex = 0;
            this.ucLabelX1.Text = "客户编码：";
            // 
            // txtCompanyName
            // 
            // 
            // 
            // 
            this.txtCompanyName.Border.Class = "TextBoxBorder";
            this.txtCompanyName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCompanyName.EnterToNextControl = false;
            this.txtCompanyName.Location = new System.Drawing.Point(264, 8);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(100, 21);
            this.txtCompanyName.TabIndex = 3;
            // 
            // txtCompanyCode
            // 
            // 
            // 
            // 
            this.txtCompanyCode.Border.Class = "TextBoxBorder";
            this.txtCompanyCode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCompanyCode.EnterToNextControl = false;
            this.txtCompanyCode.Location = new System.Drawing.Point(85, 8);
            this.txtCompanyCode.Name = "txtCompanyCode";
            this.txtCompanyCode.Size = new System.Drawing.Size(100, 21);
            this.txtCompanyCode.TabIndex = 1;
            // 
            // ucLabelX2
            // 
            // 
            // 
            // 
            this.ucLabelX2.BackgroundStyle.Class = "";
            this.ucLabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ucLabelX2.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabelX2.ForeColor = System.Drawing.Color.Gray;
            this.ucLabelX2.Location = new System.Drawing.Point(191, 8);
            this.ucLabelX2.Name = "ucLabelX2";
            this.ucLabelX2.Size = new System.Drawing.Size(67, 23);
            this.ucLabelX2.TabIndex = 2;
            this.ucLabelX2.Text = "客户名称：";
            // 
            // ucPanel12
            // 
            this.ucPanel12.BackColor = System.Drawing.Color.GhostWhite;
            this.ucPanel12.Controls.Add(this.pgCompany);
            this.ucPanel12.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucPanel12.Location = new System.Drawing.Point(0, 239);
            this.ucPanel12.Name = "ucPanel12";
            this.ucPanel12.Size = new System.Drawing.Size(788, 34);
            this.ucPanel12.TabIndex = 2;
            // 
            // pgCompany
            // 
            this.pgCompany.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pgCompany.AutoSize = true;
            this.pgCompany.BackColor = System.Drawing.Color.Transparent;
            this.pgCompany.Location = new System.Drawing.Point(500, 8);
            this.pgCompany.Name = "pgCompany";
            this.pgCompany.RecordCount = 0;
            this.pgCompany.Size = new System.Drawing.Size(267, 20);
            this.pgCompany.TabIndex = 0;
            this.pgCompany.PageIndexChanged += new System.EventHandler(this.pgCompany_PageIndexChanged);
            // 
            // ucPanel4
            // 
            this.ucPanel4.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel4.Controls.Add(this.ucToolStrip1);
            this.ucPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucPanel4.Location = new System.Drawing.Point(0, 0);
            this.ucPanel4.Name = "ucPanel4";
            this.ucPanel4.Size = new System.Drawing.Size(788, 34);
            this.ucPanel4.TabIndex = 2;
            // 
            // ucToolStrip1
            // 
            this.ucToolStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ucToolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddCust,
            this.btnEditCust,
            this.btnDelCust,
            this.toolStripSeparator1,
            this.btnImport,
            this.btnExport,
            this.btnFlowUp,
            this.toolStripSeparator2});
            this.ucToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.ucToolStrip1.Name = "ucToolStrip1";
            this.ucToolStrip1.Padding = new System.Windows.Forms.Padding(5);
            this.ucToolStrip1.Size = new System.Drawing.Size(788, 34);
            this.ucToolStrip1.TabIndex = 6;
            this.ucToolStrip1.Text = "ucToolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 24);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 24);
            // 
            // ucPanel8
            // 
            this.ucPanel8.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel8.Controls.Add(this.ucComAttachedInfo2);
            this.ucPanel8.Controls.Add(this.exWebBrowser1);
            this.ucPanel8.Controls.Add(this.ucComAttachedInfo1);
            this.ucPanel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucPanel8.Location = new System.Drawing.Point(0, 307);
            this.ucPanel8.Name = "ucPanel8";
            this.ucPanel8.Size = new System.Drawing.Size(788, 208);
            this.ucPanel8.TabIndex = 7;
            // 
            // ucComAttachedInfo2
            // 
            this.ucComAttachedInfo2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucComAttachedInfo2.Location = new System.Drawing.Point(0, 0);
            this.ucComAttachedInfo2.Name = "ucComAttachedInfo2";
            this.ucComAttachedInfo2.Size = new System.Drawing.Size(788, 208);
            this.ucComAttachedInfo2.TabIndex = 2;
            // 
            // exWebBrowser1
            // 
            this.exWebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.exWebBrowser1.Location = new System.Drawing.Point(0, 0);
            this.exWebBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.exWebBrowser1.Name = "exWebBrowser1";
            this.exWebBrowser1.ScriptErrorsSuppressed = true;
            this.exWebBrowser1.Size = new System.Drawing.Size(788, 208);
            this.exWebBrowser1.TabIndex = 1;
            this.exWebBrowser1.TagA = null;
            this.exWebBrowser1.TagB = null;
            // 
            // ucComAttachedInfo1
            // 
            this.ucComAttachedInfo1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucComAttachedInfo1.Location = new System.Drawing.Point(0, 0);
            this.ucComAttachedInfo1.Name = "ucComAttachedInfo1";
            this.ucComAttachedInfo1.Size = new System.Drawing.Size(788, 208);
            this.ucComAttachedInfo1.TabIndex = 0;
            // 
            // ucPanel2
            // 
            this.ucPanel2.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel2.Controls.Add(this.adtCust);
            this.ucPanel2.Controls.Add(this.ucPanel5);
            this.ucPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.ucPanel2.Location = new System.Drawing.Point(0, 0);
            this.ucPanel2.Name = "ucPanel2";
            this.ucPanel2.Size = new System.Drawing.Size(219, 515);
            this.ucPanel2.TabIndex = 0;
            // 
            // adtCust
            // 
            this.adtCust.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline;
            this.adtCust.AllowDrop = true;
            this.adtCust.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.adtCust.BackgroundStyle.Class = "TreeBorderKey";
            this.adtCust.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.adtCust.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adtCust.Location = new System.Drawing.Point(0, 34);
            this.adtCust.Name = "adtCust";
            this.adtCust.Nodes.AddRange(new DevComponents.AdvTree.Node[] {
            this.trnContactedCust,
            this.trnDealStage,
            this.trnIndustryClass,
            this.trnBusinessBrand,
            this.trnBusinessSeries,
            this.trnActiveDegree});
            this.adtCust.NodesConnector = this.nodeConnector1;
            this.adtCust.NodeStyle = this.elementStyle1;
            this.adtCust.PathSeparator = ";";
            this.adtCust.Size = new System.Drawing.Size(219, 481);
            this.adtCust.Styles.Add(this.elementStyle1);
            this.adtCust.TabIndex = 0;
            this.adtCust.Text = "ucAdTree1";
            this.adtCust.SelectedIndexChanged += new System.EventHandler(this.adtCust_SelectedIndexChanged);
            // 
            // nodeConnector1
            // 
            this.nodeConnector1.LineColor = System.Drawing.SystemColors.ControlText;
            // 
            // elementStyle1
            // 
            this.elementStyle1.Class = "";
            this.elementStyle1.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.elementStyle1.Name = "elementStyle1";
            this.elementStyle1.TextColor = System.Drawing.SystemColors.ControlText;
            // 
            // ucPanel5
            // 
            this.ucPanel5.BackColor = System.Drawing.Color.GhostWhite;
            this.ucPanel5.Controls.Add(this.rdoAllCustomer);
            this.ucPanel5.Controls.Add(this.rdoMyCustomer);
            this.ucPanel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucPanel5.Location = new System.Drawing.Point(0, 0);
            this.ucPanel5.Name = "ucPanel5";
            this.ucPanel5.Size = new System.Drawing.Size(219, 34);
            this.ucPanel5.TabIndex = 0;
            // 
            // rdoAllCustomer
            // 
            this.rdoAllCustomer.AutoSize = true;
            this.rdoAllCustomer.ForeColor = System.Drawing.Color.SteelBlue;
            this.rdoAllCustomer.Location = new System.Drawing.Point(86, 10);
            this.rdoAllCustomer.Name = "rdoAllCustomer";
            this.rdoAllCustomer.Size = new System.Drawing.Size(71, 16);
            this.rdoAllCustomer.TabIndex = 1;
            this.rdoAllCustomer.TabStop = true;
            this.rdoAllCustomer.Text = "所有客户";
            this.rdoAllCustomer.UseVisualStyleBackColor = true;
            this.rdoAllCustomer.CheckedChanged += new System.EventHandler(this.rdoAllCustomer_CheckedChanged);
            // 
            // rdoMyCustomer
            // 
            this.rdoMyCustomer.AutoSize = true;
            this.rdoMyCustomer.Checked = true;
            this.rdoMyCustomer.ForeColor = System.Drawing.Color.SteelBlue;
            this.rdoMyCustomer.Location = new System.Drawing.Point(9, 10);
            this.rdoMyCustomer.Name = "rdoMyCustomer";
            this.rdoMyCustomer.Size = new System.Drawing.Size(71, 16);
            this.rdoMyCustomer.TabIndex = 0;
            this.rdoMyCustomer.TabStop = true;
            this.rdoMyCustomer.Text = "我的客户";
            this.rdoMyCustomer.UseVisualStyleBackColor = true;
            this.rdoMyCustomer.CheckedChanged += new System.EventHandler(this.rdoMyCustomer_CheckedChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSearch.Image = global::ZNLCRM.UI.Properties.Resources.search;
            this.btnSearch.Location = new System.Drawing.Point(379, 7);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlS);
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "搜索(S)";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAddCust
            // 
            this.btnAddCust.Image = global::ZNLCRM.UI.Properties.Resources.add_1;
            this.btnAddCust.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddCust.Name = "btnAddCust";
            this.btnAddCust.Size = new System.Drawing.Size(52, 21);
            this.btnAddCust.Text = "添加";
            this.btnAddCust.Click += new System.EventHandler(this.btnAddCust_Click);
            // 
            // btnEditCust
            // 
            this.btnEditCust.Image = global::ZNLCRM.UI.Properties.Resources.edit_1;
            this.btnEditCust.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditCust.Name = "btnEditCust";
            this.btnEditCust.Size = new System.Drawing.Size(52, 21);
            this.btnEditCust.Text = "修改";
            this.btnEditCust.Click += new System.EventHandler(this.btnEditCust_Click);
            // 
            // btnDelCust
            // 
            this.btnDelCust.Image = global::ZNLCRM.UI.Properties.Resources.del_1;
            this.btnDelCust.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelCust.Name = "btnDelCust";
            this.btnDelCust.Size = new System.Drawing.Size(52, 21);
            this.btnDelCust.Text = "删除";
            this.btnDelCust.Click += new System.EventHandler(this.btnDelCust_Click);
            // 
            // btnImport
            // 
            this.btnImport.Image = global::ZNLCRM.UI.Properties.Resources.import_1;
            this.btnImport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(52, 21);
            this.btnImport.Text = "导入";
            // 
            // btnExport
            // 
            this.btnExport.Image = global::ZNLCRM.UI.Properties.Resources.export_1;
            this.btnExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(52, 21);
            this.btnExport.Text = "导出";
            // 
            // btnFlowUp
            // 
            this.btnFlowUp.Image = global::ZNLCRM.UI.Properties.Resources.Follow_up;
            this.btnFlowUp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFlowUp.Name = "btnFlowUp";
            this.btnFlowUp.Size = new System.Drawing.Size(52, 21);
            this.btnFlowUp.Text = "跟进";
            // 
            // trnContactedCust
            // 
            this.trnContactedCust.Expanded = true;
            this.trnContactedCust.Image = global::ZNLCRM.UI.Properties.Resources.folder16;
            this.trnContactedCust.Name = "trnContactedCust";
            this.trnContactedCust.Nodes.AddRange(new DevComponents.AdvTree.Node[] {
            this.trnToday,
            this.trnYesterday,
            this.trnThisWeek,
            this.trnThisMonth,
            this.trnThreeMonth,
            this.trnOneMonthNonContact,
            this.trnThreeMonthNonContact,
            this.trnAboveOneYear,
            this.trnSpecialAttention,
            this.trnFocus,
            this.trnColdTreament,
            this.trnAreTracking,
            this.trnIsTrackOver,
            this.trnNoTrack});
            this.trnContactedCust.Text = "联系过的客户";
            // 
            // trnToday
            // 
            this.trnToday.Image = global::ZNLCRM.UI.Properties.Resources.msg;
            this.trnToday.Name = "trnToday";
            this.trnToday.Text = "今天联系过过的客户";
            // 
            // trnYesterday
            // 
            this.trnYesterday.Image = global::ZNLCRM.UI.Properties.Resources.msg;
            this.trnYesterday.Name = "trnYesterday";
            this.trnYesterday.Text = "昨天联系过的客户";
            // 
            // trnThisWeek
            // 
            this.trnThisWeek.Image = global::ZNLCRM.UI.Properties.Resources.msg;
            this.trnThisWeek.Name = "trnThisWeek";
            this.trnThisWeek.Text = "本周联系过的客户";
            // 
            // trnThisMonth
            // 
            this.trnThisMonth.Image = global::ZNLCRM.UI.Properties.Resources.msg;
            this.trnThisMonth.Name = "trnThisMonth";
            this.trnThisMonth.Text = "本月联系过的客户";
            // 
            // trnThreeMonth
            // 
            this.trnThreeMonth.Image = global::ZNLCRM.UI.Properties.Resources.msg;
            this.trnThreeMonth.Name = "trnThreeMonth";
            this.trnThreeMonth.Text = "近三个月联系过的客户";
            // 
            // trnOneMonthNonContact
            // 
            this.trnOneMonthNonContact.Image = global::ZNLCRM.UI.Properties.Resources.msg;
            this.trnOneMonthNonContact.Name = "trnOneMonthNonContact";
            this.trnOneMonthNonContact.Text = "近一月未联系客户";
            // 
            // trnThreeMonthNonContact
            // 
            this.trnThreeMonthNonContact.Image = global::ZNLCRM.UI.Properties.Resources.msg;
            this.trnThreeMonthNonContact.Name = "trnThreeMonthNonContact";
            this.trnThreeMonthNonContact.Text = "近三月未联系客户";
            // 
            // trnAboveOneYear
            // 
            this.trnAboveOneYear.Image = global::ZNLCRM.UI.Properties.Resources.msg;
            this.trnAboveOneYear.Name = "trnAboveOneYear";
            this.trnAboveOneYear.Text = "一年以上未联系过的客户";
            // 
            // trnSpecialAttention
            // 
            this.trnSpecialAttention.Image = global::ZNLCRM.UI.Properties.Resources.msg;
            this.trnSpecialAttention.Name = "trnSpecialAttention";
            this.trnSpecialAttention.Text = "特别关注客户";
            // 
            // trnFocus
            // 
            this.trnFocus.Image = global::ZNLCRM.UI.Properties.Resources.msg;
            this.trnFocus.Name = "trnFocus";
            this.trnFocus.Text = "重点关注客户";
            // 
            // trnColdTreament
            // 
            this.trnColdTreament.Image = global::ZNLCRM.UI.Properties.Resources.msg;
            this.trnColdTreament.Name = "trnColdTreament";
            this.trnColdTreament.Text = "冷处理客户";
            // 
            // trnAreTracking
            // 
            this.trnAreTracking.Image = global::ZNLCRM.UI.Properties.Resources.msg;
            this.trnAreTracking.Name = "trnAreTracking";
            this.trnAreTracking.Text = "正在跟踪的客户";
            // 
            // trnIsTrackOver
            // 
            this.trnIsTrackOver.Image = global::ZNLCRM.UI.Properties.Resources.msg;
            this.trnIsTrackOver.Name = "trnIsTrackOver";
            this.trnIsTrackOver.Text = "已跟踪完成的客户";
            // 
            // trnNoTrack
            // 
            this.trnNoTrack.Image = global::ZNLCRM.UI.Properties.Resources.msg;
            this.trnNoTrack.Name = "trnNoTrack";
            this.trnNoTrack.Text = "未跟踪未成交的客户";
            // 
            // trnDealStage
            // 
            this.trnDealStage.Expanded = true;
            this.trnDealStage.Image = global::ZNLCRM.UI.Properties.Resources.folder16;
            this.trnDealStage.Name = "trnDealStage";
            this.trnDealStage.Text = "客户成交阶段";
            // 
            // trnIndustryClass
            // 
            this.trnIndustryClass.Image = global::ZNLCRM.UI.Properties.Resources.folder16;
            this.trnIndustryClass.Name = "trnIndustryClass";
            this.trnIndustryClass.Text = "行业分类";
            // 
            // trnBusinessBrand
            // 
            this.trnBusinessBrand.Image = global::ZNLCRM.UI.Properties.Resources.folder16;
            this.trnBusinessBrand.Name = "trnBusinessBrand";
            this.trnBusinessBrand.Text = "经营品牌";
            // 
            // trnBusinessSeries
            // 
            this.trnBusinessSeries.Image = global::ZNLCRM.UI.Properties.Resources.folder16;
            this.trnBusinessSeries.Name = "trnBusinessSeries";
            this.trnBusinessSeries.Text = "经营系列";
            // 
            // trnActiveDegree
            // 
            this.trnActiveDegree.Image = global::ZNLCRM.UI.Properties.Resources.folder16;
            this.trnActiveDegree.Name = "trnActiveDegree";
            this.trnActiveDegree.Text = "活跃程度";
            // 
            // frmCustomerManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 515);
            this.Controls.Add(this.ucPanel1);
            this.Name = "frmCustomerManage";
            this.Text = "客户管理";
            this.Load += new System.EventHandler(this.frmCustomerManage_Load);
            this.ucPanel1.ResumeLayout(false);
            this.ucPanel3.ResumeLayout(false);
            this.ucPanel7.ResumeLayout(false);
            this.ucPanel10.ResumeLayout(false);
            this.ucPanel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompany)).EndInit();
            this.ucPanel11.ResumeLayout(false);
            this.ucPanel12.ResumeLayout(false);
            this.ucPanel12.PerformLayout();
            this.ucPanel4.ResumeLayout(false);
            this.ucPanel4.PerformLayout();
            this.ucToolStrip1.ResumeLayout(false);
            this.ucToolStrip1.PerformLayout();
            this.ucPanel8.ResumeLayout(false);
            this.ucPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.adtCust)).EndInit();
            this.ucPanel5.ResumeLayout(false);
            this.ucPanel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.UcPanel ucPanel1;
        private Controls.UcPanel ucPanel3;
        private Controls.UcPanel ucPanel2;
        private Controls.UcPanel ucPanel4;
        private Controls.UcAdTree adtCust;
        private DevComponents.AdvTree.NodeConnector nodeConnector1;
        private DevComponents.DotNetBar.ElementStyle elementStyle1;
        private Controls.UcPanel ucPanel5;
        private System.Windows.Forms.RadioButton rdoAllCustomer;
        private System.Windows.Forms.RadioButton rdoMyCustomer;
        private DevComponents.AdvTree.Node trnContactedCust;
        private DevComponents.AdvTree.Node trnToday;
        private DevComponents.AdvTree.Node trnYesterday;
        private DevComponents.AdvTree.Node trnThisWeek;
        private DevComponents.AdvTree.Node trnThisMonth;
        private DevComponents.AdvTree.Node trnThreeMonth;
        private DevComponents.AdvTree.Node trnOneMonthNonContact;
        private DevComponents.AdvTree.Node trnThreeMonthNonContact;
        private DevComponents.AdvTree.Node trnAboveOneYear;
        private DevComponents.AdvTree.Node trnSpecialAttention;
        private DevComponents.AdvTree.Node trnFocus;
        private DevComponents.AdvTree.Node trnColdTreament;
        private DevComponents.AdvTree.Node trnAreTracking;
        private DevComponents.AdvTree.Node trnIsTrackOver;
        private DevComponents.AdvTree.Node trnNoTrack;
        private DevComponents.AdvTree.Node trnDealStage;
        private DevComponents.AdvTree.Node trnIndustryClass;
        private DevComponents.AdvTree.Node trnBusinessBrand;
        private DevComponents.AdvTree.Node trnBusinessSeries;
        private DevComponents.AdvTree.Node trnActiveDegree;
        private Controls.UcPanel ucPanel7;
        private Controls.UcPanel ucPanel10;
        private Controls.UcPanel ucPanel9;
        private Controls.UcDataGridView dgvCompany;
        private Controls.UcButton btnSearch;
        private Controls.UcTextBox txtCompanyName;
        private Controls.UcLabelX ucLabelX2;
        private Controls.UcTextBox txtCompanyCode;
        private Controls.UcLabelX ucLabelX1;
        private Controls.UcPanel ucPanel8;
        private Controls.UcExpandableSplitter ucExpandableSplitter1;
        private Controls.UcPanel ucPanel12;
        private Controls.UcPanel ucPanel11;
        private Controls.UcToolStrip ucToolStrip1;
        private System.Windows.Forms.ToolStripButton btnAddCust;
        private System.Windows.Forms.ToolStripButton btnEditCust;
        private System.Windows.Forms.ToolStripButton btnDelCust;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnImport;
        private System.Windows.Forms.ToolStripButton btnExport;
        private System.Windows.Forms.ToolStripButton btnFlowUp;
        private Controls.UcPager pgCompany;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private Controls.UcComAttachedInfo ucComAttachedInfo1;
        private Controls.ExWebBrowser exWebBrowser1;
        private Controls.UcComAttachedInfo ucComAttachedInfo2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCompanyID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCompanyCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colArea;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIndustry;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMainBrand;

    }
}