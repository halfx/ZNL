namespace ZNLCRM.UI.SYS
{
    partial class frmSYSCurrency
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
            this.btnSearch = new ZNLCRM.Controls.UcButton(this.components);
            this.cboCurrency = new ZNLCRM.Controls.UcComboBox(this.components);
            this.ucLabelX1 = new ZNLCRM.Controls.UcLabelX(this.components);
            this.ucPanel2 = new ZNLCRM.Controls.UcPanel(this.components);
            this.ucPanel3 = new ZNLCRM.Controls.UcPanel(this.components);
            this.grpCurrency = new ZNLCRM.Controls.UcPanel(this.components);
            this.txtRateDate = new ZNLCRM.Controls.UcDateTimeInput(this.components);
            this.txtExchangeRate = new ZNLCRM.Controls.UcTextBox(this.components);
            this.cboCurrencyCode = new ZNLCRM.Controls.UcComboBox(this.components);
            this.ucLabel3 = new ZNLCRM.Controls.UcLabel(this.components);
            this.btnSave = new ZNLCRM.Controls.UcButton(this.components);
            this.txtRateTaxID = new ZNLCRM.Controls.UcTextBox(this.components);
            this.btnCancel = new ZNLCRM.Controls.UcButton(this.components);
            this.ucLabel1 = new ZNLCRM.Controls.UcLabel(this.components);
            this.txtRemark = new ZNLCRM.Controls.UcTextBox(this.components);
            this.ucLabel4 = new ZNLCRM.Controls.UcLabel(this.components);
            this.ucLabel2 = new ZNLCRM.Controls.UcLabel(this.components);
            this.dgvCurrency = new ZNLCRM.Controls.UcDataGridView(this.components);
            this.ucPanel4 = new ZNLCRM.Controls.UcPanel(this.components);
            this.ucToolStrip1 = new ZNLCRM.Controls.UcToolStrip(this.components);
            this.tsbAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbDel = new System.Windows.Forms.ToolStripButton();
            this.colRateTaxID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRateTaxGuid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCurrencyCode = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colExchangeRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRemark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreatedEmpID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreatedEmpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreatedTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUpdatedEmpID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUpdatedEmpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUpdatedTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ucPanel1.SuspendLayout();
            this.ucPanel2.SuspendLayout();
            this.ucPanel3.SuspendLayout();
            this.grpCurrency.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRateDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrency)).BeginInit();
            this.ucPanel4.SuspendLayout();
            this.ucToolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ucPanel1
            // 
            this.ucPanel1.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel1.Controls.Add(this.btnSearch);
            this.ucPanel1.Controls.Add(this.cboCurrency);
            this.ucPanel1.Controls.Add(this.ucLabelX1);
            this.ucPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucPanel1.Location = new System.Drawing.Point(0, 0);
            this.ucPanel1.Name = "ucPanel1";
            this.ucPanel1.Size = new System.Drawing.Size(885, 38);
            this.ucPanel1.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSearch.Image = global::ZNLCRM.UI.Properties.Resources.search;
            this.btnSearch.Location = new System.Drawing.Point(206, 6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "搜索";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cboCurrency
            // 
            this.cboCurrency.DisplayMember = "Text";
            this.cboCurrency.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboCurrency.FormattingEnabled = true;
            this.cboCurrency.ItemHeight = 15;
            this.cboCurrency.Location = new System.Drawing.Point(79, 8);
            this.cboCurrency.Name = "cboCurrency";
            this.cboCurrency.Size = new System.Drawing.Size(121, 21);
            this.cboCurrency.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboCurrency.TabIndex = 1;
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
            this.ucLabelX1.Location = new System.Drawing.Point(26, 6);
            this.ucLabelX1.Name = "ucLabelX1";
            this.ucLabelX1.Size = new System.Drawing.Size(47, 23);
            this.ucLabelX1.TabIndex = 0;
            this.ucLabelX1.Text = "币种：";
            // 
            // ucPanel2
            // 
            this.ucPanel2.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel2.Controls.Add(this.ucPanel3);
            this.ucPanel2.Controls.Add(this.ucPanel1);
            this.ucPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPanel2.Location = new System.Drawing.Point(0, 35);
            this.ucPanel2.Name = "ucPanel2";
            this.ucPanel2.Size = new System.Drawing.Size(885, 426);
            this.ucPanel2.TabIndex = 1;
            // 
            // ucPanel3
            // 
            this.ucPanel3.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel3.Controls.Add(this.grpCurrency);
            this.ucPanel3.Controls.Add(this.dgvCurrency);
            this.ucPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPanel3.Location = new System.Drawing.Point(0, 38);
            this.ucPanel3.Name = "ucPanel3";
            this.ucPanel3.Padding = new System.Windows.Forms.Padding(5);
            this.ucPanel3.Size = new System.Drawing.Size(885, 388);
            this.ucPanel3.TabIndex = 1;
            // 
            // grpCurrency
            // 
            this.grpCurrency.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpCurrency.BackColor = System.Drawing.Color.Transparent;
            this.grpCurrency.Controls.Add(this.txtRateDate);
            this.grpCurrency.Controls.Add(this.txtExchangeRate);
            this.grpCurrency.Controls.Add(this.cboCurrencyCode);
            this.grpCurrency.Controls.Add(this.ucLabel3);
            this.grpCurrency.Controls.Add(this.btnSave);
            this.grpCurrency.Controls.Add(this.txtRateTaxID);
            this.grpCurrency.Controls.Add(this.btnCancel);
            this.grpCurrency.Controls.Add(this.ucLabel1);
            this.grpCurrency.Controls.Add(this.txtRemark);
            this.grpCurrency.Controls.Add(this.ucLabel4);
            this.grpCurrency.Controls.Add(this.ucLabel2);
            this.grpCurrency.Location = new System.Drawing.Point(234, 70);
            this.grpCurrency.Name = "grpCurrency";
            this.grpCurrency.Size = new System.Drawing.Size(359, 168);
            this.grpCurrency.TabIndex = 6;
            this.grpCurrency.Visible = false;
            // 
            // txtRateDate
            // 
            // 
            // 
            // 
            this.txtRateDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtRateDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtRateDate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.txtRateDate.ButtonDropDown.Visible = true;
            this.txtRateDate.IsPopupCalendarOpen = false;
            this.txtRateDate.Location = new System.Drawing.Point(112, 72);
            // 
            // 
            // 
            this.txtRateDate.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.txtRateDate.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.txtRateDate.MonthCalendar.BackgroundStyle.Class = "";
            this.txtRateDate.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtRateDate.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.txtRateDate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.txtRateDate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.txtRateDate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.txtRateDate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtRateDate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.txtRateDate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.txtRateDate.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.txtRateDate.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtRateDate.MonthCalendar.DisplayMonth = new System.DateTime(2014, 12, 1, 0, 0, 0, 0);
            this.txtRateDate.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.txtRateDate.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.txtRateDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.txtRateDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.txtRateDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.txtRateDate.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.txtRateDate.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtRateDate.MonthCalendar.TodayButtonVisible = true;
            this.txtRateDate.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.txtRateDate.Name = "txtRateDate";
            this.txtRateDate.Size = new System.Drawing.Size(153, 21);
            this.txtRateDate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.txtRateDate.TabIndex = 15;
            // 
            // txtExchangeRate
            // 
            // 
            // 
            // 
            this.txtExchangeRate.Border.Class = "TextBoxBorder";
            this.txtExchangeRate.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtExchangeRate.EnterToNextControl = false;
            this.txtExchangeRate.Location = new System.Drawing.Point(112, 44);
            this.txtExchangeRate.Name = "txtExchangeRate";
            this.txtExchangeRate.Size = new System.Drawing.Size(153, 21);
            this.txtExchangeRate.TabIndex = 14;
            // 
            // cboCurrencyCode
            // 
            this.cboCurrencyCode.DisplayMember = "Text";
            this.cboCurrencyCode.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboCurrencyCode.FormattingEnabled = true;
            this.cboCurrencyCode.ItemHeight = 15;
            this.cboCurrencyCode.Location = new System.Drawing.Point(112, 17);
            this.cboCurrencyCode.Name = "cboCurrencyCode";
            this.cboCurrencyCode.Size = new System.Drawing.Size(153, 21);
            this.cboCurrencyCode.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboCurrencyCode.TabIndex = 13;
            // 
            // ucLabel3
            // 
            this.ucLabel3.AutoSize = true;
            this.ucLabel3.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabel3.ForeColor = System.Drawing.Color.Gray;
            this.ucLabel3.Location = new System.Drawing.Point(61, 20);
            this.ucLabel3.Name = "ucLabel3";
            this.ucLabel3.Size = new System.Drawing.Size(41, 12);
            this.ucLabel3.TabIndex = 6;
            this.ucLabel3.Text = "币种：";
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Image = global::ZNLCRM.UI.Properties.Resources.save_1;
            this.btnSave.Location = new System.Drawing.Point(96, 131);
            this.btnSave.Name = "btnSave";
            this.btnSave.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlS);
            this.btnSave.Size = new System.Drawing.Size(83, 23);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "保存(S)";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtRateTaxID
            // 
            // 
            // 
            // 
            this.txtRateTaxID.Border.Class = "TextBoxBorder";
            this.txtRateTaxID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtRateTaxID.EnterToNextControl = false;
            this.txtRateTaxID.Location = new System.Drawing.Point(271, 18);
            this.txtRateTaxID.Name = "txtRateTaxID";
            this.txtRateTaxID.ReadOnly = true;
            this.txtRateTaxID.Size = new System.Drawing.Size(62, 21);
            this.txtRateTaxID.TabIndex = 7;
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.Image = global::ZNLCRM.UI.Properties.Resources.cancel_1;
            this.btnCancel.Location = new System.Drawing.Point(185, 131);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(86, 23);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "取消(C)";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ucLabel1
            // 
            this.ucLabel1.AutoSize = true;
            this.ucLabel1.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabel1.ForeColor = System.Drawing.Color.Gray;
            this.ucLabel1.Location = new System.Drawing.Point(61, 100);
            this.ucLabel1.Name = "ucLabel1";
            this.ucLabel1.Size = new System.Drawing.Size(41, 12);
            this.ucLabel1.TabIndex = 6;
            this.ucLabel1.Text = "备注：";
            // 
            // txtRemark
            // 
            // 
            // 
            // 
            this.txtRemark.Border.Class = "TextBoxBorder";
            this.txtRemark.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtRemark.EnterToNextControl = false;
            this.txtRemark.Location = new System.Drawing.Point(112, 100);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(153, 21);
            this.txtRemark.TabIndex = 0;
            // 
            // ucLabel4
            // 
            this.ucLabel4.AutoSize = true;
            this.ucLabel4.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabel4.ForeColor = System.Drawing.Color.Gray;
            this.ucLabel4.Location = new System.Drawing.Point(61, 48);
            this.ucLabel4.Name = "ucLabel4";
            this.ucLabel4.Size = new System.Drawing.Size(41, 12);
            this.ucLabel4.TabIndex = 6;
            this.ucLabel4.Text = "汇率：";
            // 
            // ucLabel2
            // 
            this.ucLabel2.AutoSize = true;
            this.ucLabel2.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabel2.ForeColor = System.Drawing.Color.Gray;
            this.ucLabel2.Location = new System.Drawing.Point(13, 75);
            this.ucLabel2.Name = "ucLabel2";
            this.ucLabel2.Size = new System.Drawing.Size(89, 12);
            this.ucLabel2.TabIndex = 6;
            this.ucLabel2.Text = "汇率启用日期：";
            // 
            // dgvCurrency
            // 
            this.dgvCurrency.AllowUserToAddRows = false;
            this.dgvCurrency.AllowUserToDeleteRows = false;
            this.dgvCurrency.AllowUserToOrderColumns = true;
            this.dgvCurrency.BackgroundColor = System.Drawing.Color.White;
            this.dgvCurrency.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCurrency.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRateTaxID,
            this.colRateTaxGuid,
            this.colCurrencyCode,
            this.colExchangeRate,
            this.colRateDate,
            this.colRemark,
            this.colCreatedEmpID,
            this.colCreatedEmpName,
            this.colCreatedTime,
            this.colUpdatedEmpID,
            this.colUpdatedEmpName,
            this.colUpdatedTime});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCurrency.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCurrency.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCurrency.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvCurrency.HighlightSelectedColumnHeaders = false;
            this.dgvCurrency.Location = new System.Drawing.Point(5, 5);
            this.dgvCurrency.Name = "dgvCurrency";
            this.dgvCurrency.PaintEnhancedSelection = false;
            this.dgvCurrency.ReadOnly = true;
            this.dgvCurrency.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCurrency.RowTemplate.Height = 23;
            this.dgvCurrency.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCurrency.SelectAllSignVisible = false;
            this.dgvCurrency.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvCurrency.Size = new System.Drawing.Size(875, 378);
            this.dgvCurrency.TabIndex = 0;
            this.dgvCurrency.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCurrency_CellDoubleClick);
            this.dgvCurrency.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCurrency_RowEnter);
            // 
            // ucPanel4
            // 
            this.ucPanel4.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel4.Controls.Add(this.ucToolStrip1);
            this.ucPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucPanel4.Location = new System.Drawing.Point(0, 0);
            this.ucPanel4.Name = "ucPanel4";
            this.ucPanel4.Size = new System.Drawing.Size(885, 35);
            this.ucPanel4.TabIndex = 2;
            // 
            // ucToolStrip1
            // 
            this.ucToolStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ucToolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAdd,
            this.tsbDel});
            this.ucToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.ucToolStrip1.Name = "ucToolStrip1";
            this.ucToolStrip1.Padding = new System.Windows.Forms.Padding(5);
            this.ucToolStrip1.Size = new System.Drawing.Size(885, 35);
            this.ucToolStrip1.TabIndex = 0;
            this.ucToolStrip1.Text = "ucToolStrip1";
            // 
            // tsbAdd
            // 
            this.tsbAdd.Image = global::ZNLCRM.UI.Properties.Resources.add_2;
            this.tsbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdd.Name = "tsbAdd";
            this.tsbAdd.Size = new System.Drawing.Size(52, 22);
            this.tsbAdd.Text = "添加";
            this.tsbAdd.Click += new System.EventHandler(this.tsbAdd_Click);
            // 
            // tsbDel
            // 
            this.tsbDel.Image = global::ZNLCRM.UI.Properties.Resources.del_2;
            this.tsbDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDel.Name = "tsbDel";
            this.tsbDel.Size = new System.Drawing.Size(52, 22);
            this.tsbDel.Text = "删除";
            this.tsbDel.Click += new System.EventHandler(this.tsbDel_Click);
            // 
            // colRateTaxID
            // 
            this.colRateTaxID.DataPropertyName = "RateTaxID";
            this.colRateTaxID.HeaderText = "RateTaxID";
            this.colRateTaxID.Name = "colRateTaxID";
            this.colRateTaxID.ReadOnly = true;
            this.colRateTaxID.Visible = false;
            // 
            // colRateTaxGuid
            // 
            this.colRateTaxGuid.DataPropertyName = "RateTaxGuid";
            this.colRateTaxGuid.HeaderText = "RateTaxGuid";
            this.colRateTaxGuid.Name = "colRateTaxGuid";
            this.colRateTaxGuid.ReadOnly = true;
            this.colRateTaxGuid.Visible = false;
            // 
            // colCurrencyCode
            // 
            this.colCurrencyCode.DataPropertyName = "CurrencyCode";
            this.colCurrencyCode.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.colCurrencyCode.HeaderText = "币种";
            this.colCurrencyCode.Name = "colCurrencyCode";
            this.colCurrencyCode.ReadOnly = true;
            this.colCurrencyCode.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colCurrencyCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colExchangeRate
            // 
            this.colExchangeRate.DataPropertyName = "ExchangeRate";
            this.colExchangeRate.HeaderText = "汇率";
            this.colExchangeRate.Name = "colExchangeRate";
            this.colExchangeRate.ReadOnly = true;
            // 
            // colRateDate
            // 
            this.colRateDate.DataPropertyName = "RateDate";
            this.colRateDate.HeaderText = "汇率日期";
            this.colRateDate.Name = "colRateDate";
            this.colRateDate.ReadOnly = true;
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
            this.colCreatedEmpID.HeaderText = "创建人ID";
            this.colCreatedEmpID.Name = "colCreatedEmpID";
            this.colCreatedEmpID.ReadOnly = true;
            this.colCreatedEmpID.Visible = false;
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
            this.colCreatedTime.HeaderText = "创建日期";
            this.colCreatedTime.Name = "colCreatedTime";
            this.colCreatedTime.ReadOnly = true;
            // 
            // colUpdatedEmpID
            // 
            this.colUpdatedEmpID.DataPropertyName = "UpdatedEmpID";
            this.colUpdatedEmpID.HeaderText = "修改人ID";
            this.colUpdatedEmpID.Name = "colUpdatedEmpID";
            this.colUpdatedEmpID.ReadOnly = true;
            this.colUpdatedEmpID.Visible = false;
            // 
            // colUpdatedEmpName
            // 
            this.colUpdatedEmpName.DataPropertyName = "UpdatedEmpName";
            this.colUpdatedEmpName.HeaderText = "修改人员";
            this.colUpdatedEmpName.Name = "colUpdatedEmpName";
            this.colUpdatedEmpName.ReadOnly = true;
            // 
            // colUpdatedTime
            // 
            this.colUpdatedTime.DataPropertyName = "UpdatedTime";
            this.colUpdatedTime.HeaderText = "修改日期";
            this.colUpdatedTime.Name = "colUpdatedTime";
            this.colUpdatedTime.ReadOnly = true;
            // 
            // frmSYSCurrency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 461);
            this.Controls.Add(this.ucPanel2);
            this.Controls.Add(this.ucPanel4);
            this.Name = "frmSYSCurrency";
            this.Text = "币种管理";
            this.Load += new System.EventHandler(this.frmSYSCurrency_Load);
            this.ucPanel1.ResumeLayout(false);
            this.ucPanel2.ResumeLayout(false);
            this.ucPanel3.ResumeLayout(false);
            this.grpCurrency.ResumeLayout(false);
            this.grpCurrency.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRateDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrency)).EndInit();
            this.ucPanel4.ResumeLayout(false);
            this.ucPanel4.PerformLayout();
            this.ucToolStrip1.ResumeLayout(false);
            this.ucToolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.UcPanel ucPanel1;
        private Controls.UcButton btnSearch;
        private Controls.UcComboBox cboCurrency;
        private Controls.UcLabelX ucLabelX1;
        private Controls.UcPanel ucPanel2;
        private Controls.UcPanel ucPanel3;
        private Controls.UcDataGridView dgvCurrency;
        private Controls.UcPanel ucPanel4;
        private Controls.UcToolStrip ucToolStrip1;
        private System.Windows.Forms.ToolStripButton tsbAdd;
        private System.Windows.Forms.ToolStripButton tsbDel;
        private Controls.UcPanel grpCurrency;
        private Controls.UcDateTimeInput txtRateDate;
        private Controls.UcTextBox txtExchangeRate;
        private Controls.UcComboBox cboCurrencyCode;
        private Controls.UcLabel ucLabel3;
        private Controls.UcButton btnSave;
        private Controls.UcTextBox txtRateTaxID;
        private Controls.UcButton btnCancel;
        private Controls.UcLabel ucLabel1;
        private Controls.UcTextBox txtRemark;
        private Controls.UcLabel ucLabel4;
        private Controls.UcLabel ucLabel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRateTaxID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRateTaxGuid;
        private System.Windows.Forms.DataGridViewComboBoxColumn colCurrencyCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExchangeRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRateDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRemark;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreatedEmpID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreatedEmpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreatedTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUpdatedEmpID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUpdatedEmpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUpdatedTime;
    }
}