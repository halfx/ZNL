namespace ZNLCRM.UI.CRM
{
    partial class frmFINSubmitExpense
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
            this.panelExpense = new ZNLCRM.Controls.UcPanel(this.components);
            this.txtOpDate = new ZNLCRM.Controls.UcDateTimeInput(this.components);
            this.txtChkAmount = new ZNLCRM.Controls.UcTextBox(this.components);
            this.ucLabel7 = new ZNLCRM.Controls.UcLabel(this.components);
            this.txtOpEmpID = new ZNLCRM.Controls.UcTextBox(this.components);
            this.txtSourceGuid = new ZNLCRM.Controls.UcTextBox(this.components);
            this.txtOrgID = new ZNLCRM.Controls.UcTextBox(this.components);
            this.txtExpGuID = new ZNLCRM.Controls.UcTextBox(this.components);
            this.txtExpID = new ZNLCRM.Controls.UcTextBox(this.components);
            this.txtRemark = new ZNLCRM.Controls.UcTextBox(this.components);
            this.ucLabel6 = new ZNLCRM.Controls.UcLabel(this.components);
            this.txtAmount = new ZNLCRM.Controls.UcTextBox(this.components);
            this.ucLabel5 = new ZNLCRM.Controls.UcLabel(this.components);
            this.ucLabel4 = new ZNLCRM.Controls.UcLabel(this.components);
            this.txtOpEmpName = new ZNLCRM.Controls.UcTextBox(this.components);
            this.所属人员 = new ZNLCRM.Controls.UcLabel(this.components);
            this.ucLabel3 = new ZNLCRM.Controls.UcLabel(this.components);
            this.txtExpName = new ZNLCRM.Controls.UcTextBox(this.components);
            this.txtSourceBillNo = new ZNLCRM.Controls.UcTextBox(this.components);
            this.ucLabel2 = new ZNLCRM.Controls.UcLabel(this.components);
            this.ucLabel1 = new ZNLCRM.Controls.UcLabel(this.components);
            this.txtBillNo = new ZNLCRM.Controls.UcTextBox(this.components);
            this.ucPanel2 = new ZNLCRM.Controls.UcPanel(this.components);
            this.ucPanel4 = new ZNLCRM.Controls.UcPanel(this.components);
            this.dgvExpenseLine = new ZNLCRM.Controls.UcDataGridView(this.components);
            this.colExpLineID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExpLineGuID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExpGuID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colChkAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRemark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ucPanel3 = new ZNLCRM.Controls.UcPanel(this.components);
            this.ucToolStrip1 = new ZNLCRM.Controls.UcToolStrip(this.components);
            this.tsbAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbDel = new System.Windows.Forms.ToolStripButton();
            this.ucPanel5 = new ZNLCRM.Controls.UcPanel(this.components);
            this.btnCancel = new ZNLCRM.Controls.UcButton(this.components);
            this.btnSave = new ZNLCRM.Controls.UcButton(this.components);
            this.panelExpense.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtOpDate)).BeginInit();
            this.ucPanel2.SuspendLayout();
            this.ucPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenseLine)).BeginInit();
            this.ucPanel3.SuspendLayout();
            this.ucToolStrip1.SuspendLayout();
            this.ucPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelExpense
            // 
            this.panelExpense.BackColor = System.Drawing.Color.Transparent;
            this.panelExpense.Controls.Add(this.txtOpDate);
            this.panelExpense.Controls.Add(this.txtChkAmount);
            this.panelExpense.Controls.Add(this.ucLabel7);
            this.panelExpense.Controls.Add(this.txtOpEmpID);
            this.panelExpense.Controls.Add(this.txtSourceGuid);
            this.panelExpense.Controls.Add(this.txtOrgID);
            this.panelExpense.Controls.Add(this.txtExpGuID);
            this.panelExpense.Controls.Add(this.txtExpID);
            this.panelExpense.Controls.Add(this.txtRemark);
            this.panelExpense.Controls.Add(this.ucLabel6);
            this.panelExpense.Controls.Add(this.txtAmount);
            this.panelExpense.Controls.Add(this.ucLabel5);
            this.panelExpense.Controls.Add(this.ucLabel4);
            this.panelExpense.Controls.Add(this.txtOpEmpName);
            this.panelExpense.Controls.Add(this.所属人员);
            this.panelExpense.Controls.Add(this.ucLabel3);
            this.panelExpense.Controls.Add(this.txtExpName);
            this.panelExpense.Controls.Add(this.txtSourceBillNo);
            this.panelExpense.Controls.Add(this.ucLabel2);
            this.panelExpense.Controls.Add(this.ucLabel1);
            this.panelExpense.Controls.Add(this.txtBillNo);
            this.panelExpense.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelExpense.Location = new System.Drawing.Point(0, 0);
            this.panelExpense.Name = "panelExpense";
            this.panelExpense.Size = new System.Drawing.Size(736, 122);
            this.panelExpense.TabIndex = 0;
            // 
            // txtOpDate
            // 
            // 
            // 
            // 
            this.txtOpDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtOpDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtOpDate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.txtOpDate.ButtonDropDown.Visible = true;
            this.txtOpDate.CustomFormat = "yyyy-MM-dd";
            this.txtOpDate.Format = DevComponents.Editors.eDateTimePickerFormat.Custom;
            this.txtOpDate.IsPopupCalendarOpen = false;
            this.txtOpDate.Location = new System.Drawing.Point(88, 66);
            // 
            // 
            // 
            this.txtOpDate.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.txtOpDate.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.txtOpDate.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtOpDate.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.txtOpDate.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.txtOpDate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.txtOpDate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.txtOpDate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.txtOpDate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.txtOpDate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.txtOpDate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.txtOpDate.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtOpDate.MonthCalendar.DisplayMonth = new System.DateTime(2014, 11, 1, 0, 0, 0, 0);
            this.txtOpDate.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.txtOpDate.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.txtOpDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.txtOpDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.txtOpDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.txtOpDate.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtOpDate.MonthCalendar.TodayButtonVisible = true;
            this.txtOpDate.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.txtOpDate.Name = "txtOpDate";
            this.txtOpDate.Size = new System.Drawing.Size(150, 21);
            this.txtOpDate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.txtOpDate.TabIndex = 1;
            // 
            // txtChkAmount
            // 
            // 
            // 
            // 
            this.txtChkAmount.Border.Class = "TextBoxBorder";
            this.txtChkAmount.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtChkAmount.EnterToNextControl = false;
            this.txtChkAmount.Location = new System.Drawing.Point(582, 38);
            this.txtChkAmount.Name = "txtChkAmount";
            this.txtChkAmount.ReadOnly = true;
            this.txtChkAmount.Size = new System.Drawing.Size(150, 21);
            this.txtChkAmount.TabIndex = 20;
            // 
            // ucLabel7
            // 
            this.ucLabel7.AutoSize = true;
            this.ucLabel7.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabel7.ForeColor = System.Drawing.Color.Gray;
            this.ucLabel7.Location = new System.Drawing.Point(511, 44);
            this.ucLabel7.Name = "ucLabel7";
            this.ucLabel7.Size = new System.Drawing.Size(65, 12);
            this.ucLabel7.TabIndex = 19;
            this.ucLabel7.Text = "报销金额：";
            // 
            // txtOpEmpID
            // 
            // 
            // 
            // 
            this.txtOpEmpID.Border.Class = "TextBoxBorder";
            this.txtOpEmpID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtOpEmpID.EnterToNextControl = false;
            this.txtOpEmpID.Location = new System.Drawing.Point(696, 65);
            this.txtOpEmpID.Name = "txtOpEmpID";
            this.txtOpEmpID.ReadOnly = true;
            this.txtOpEmpID.Size = new System.Drawing.Size(36, 21);
            this.txtOpEmpID.TabIndex = 18;
            this.txtOpEmpID.Visible = false;
            // 
            // txtSourceGuid
            // 
            // 
            // 
            // 
            this.txtSourceGuid.Border.Class = "TextBoxBorder";
            this.txtSourceGuid.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSourceGuid.EnterToNextControl = false;
            this.txtSourceGuid.Location = new System.Drawing.Point(654, 66);
            this.txtSourceGuid.Name = "txtSourceGuid";
            this.txtSourceGuid.ReadOnly = true;
            this.txtSourceGuid.Size = new System.Drawing.Size(36, 21);
            this.txtSourceGuid.TabIndex = 17;
            this.txtSourceGuid.Visible = false;
            // 
            // txtOrgID
            // 
            // 
            // 
            // 
            this.txtOrgID.Border.Class = "TextBoxBorder";
            this.txtOrgID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtOrgID.EnterToNextControl = false;
            this.txtOrgID.Location = new System.Drawing.Point(609, 66);
            this.txtOrgID.Name = "txtOrgID";
            this.txtOrgID.ReadOnly = true;
            this.txtOrgID.Size = new System.Drawing.Size(39, 21);
            this.txtOrgID.TabIndex = 16;
            this.txtOrgID.Visible = false;
            // 
            // txtExpGuID
            // 
            // 
            // 
            // 
            this.txtExpGuID.Border.Class = "TextBoxBorder";
            this.txtExpGuID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtExpGuID.EnterToNextControl = false;
            this.txtExpGuID.Location = new System.Drawing.Point(567, 66);
            this.txtExpGuID.Name = "txtExpGuID";
            this.txtExpGuID.ReadOnly = true;
            this.txtExpGuID.Size = new System.Drawing.Size(36, 21);
            this.txtExpGuID.TabIndex = 15;
            this.txtExpGuID.Visible = false;
            // 
            // txtExpID
            // 
            // 
            // 
            // 
            this.txtExpID.Border.Class = "TextBoxBorder";
            this.txtExpID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtExpID.EnterToNextControl = false;
            this.txtExpID.Location = new System.Drawing.Point(522, 66);
            this.txtExpID.Name = "txtExpID";
            this.txtExpID.ReadOnly = true;
            this.txtExpID.Size = new System.Drawing.Size(39, 21);
            this.txtExpID.TabIndex = 14;
            this.txtExpID.Visible = false;
            // 
            // txtRemark
            // 
            // 
            // 
            // 
            this.txtRemark.Border.Class = "TextBoxBorder";
            this.txtRemark.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtRemark.EnterToNextControl = false;
            this.txtRemark.Location = new System.Drawing.Point(88, 93);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(604, 21);
            this.txtRemark.TabIndex = 13;
            // 
            // ucLabel6
            // 
            this.ucLabel6.AutoSize = true;
            this.ucLabel6.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabel6.ForeColor = System.Drawing.Color.Gray;
            this.ucLabel6.Location = new System.Drawing.Point(41, 95);
            this.ucLabel6.Name = "ucLabel6";
            this.ucLabel6.Size = new System.Drawing.Size(41, 12);
            this.ucLabel6.TabIndex = 12;
            this.ucLabel6.Text = "备注：";
            // 
            // txtAmount
            // 
            // 
            // 
            // 
            this.txtAmount.Border.Class = "TextBoxBorder";
            this.txtAmount.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtAmount.EnterToNextControl = false;
            this.txtAmount.Location = new System.Drawing.Point(342, 66);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.ReadOnly = true;
            this.txtAmount.Size = new System.Drawing.Size(150, 21);
            this.txtAmount.TabIndex = 11;
            // 
            // ucLabel5
            // 
            this.ucLabel5.AutoSize = true;
            this.ucLabel5.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabel5.ForeColor = System.Drawing.Color.Gray;
            this.ucLabel5.Location = new System.Drawing.Point(271, 70);
            this.ucLabel5.Name = "ucLabel5";
            this.ucLabel5.Size = new System.Drawing.Size(65, 12);
            this.ucLabel5.TabIndex = 10;
            this.ucLabel5.Text = "报销金额：";
            // 
            // ucLabel4
            // 
            this.ucLabel4.AutoSize = true;
            this.ucLabel4.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabel4.ForeColor = System.Drawing.Color.Gray;
            this.ucLabel4.IsMustChar = true;
            this.ucLabel4.Location = new System.Drawing.Point(41, 70);
            this.ucLabel4.Name = "ucLabel4";
            this.ucLabel4.Size = new System.Drawing.Size(41, 12);
            this.ucLabel4.TabIndex = 8;
            this.ucLabel4.Text = "日期：";
            // 
            // txtOpEmpName
            // 
            // 
            // 
            // 
            this.txtOpEmpName.Border.Class = "TextBoxBorder";
            this.txtOpEmpName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtOpEmpName.ButtonCustom.Visible = true;
            this.txtOpEmpName.EnterToNextControl = false;
            this.txtOpEmpName.Location = new System.Drawing.Point(342, 39);
            this.txtOpEmpName.Name = "txtOpEmpName";
            this.txtOpEmpName.Size = new System.Drawing.Size(150, 21);
            this.txtOpEmpName.TabIndex = 7;
            this.txtOpEmpName.ButtonCustomClick += new System.EventHandler(this.txtOpEmpName_ButtonCustomClick);
            // 
            // 所属人员
            // 
            this.所属人员.AutoSize = true;
            this.所属人员.Font = new System.Drawing.Font("宋体", 9F);
            this.所属人员.ForeColor = System.Drawing.Color.Gray;
            this.所属人员.IsMustChar = true;
            this.所属人员.Location = new System.Drawing.Point(271, 44);
            this.所属人员.Name = "所属人员";
            this.所属人员.Size = new System.Drawing.Size(65, 12);
            this.所属人员.TabIndex = 6;
            this.所属人员.Text = "所属人员：";
            // 
            // ucLabel3
            // 
            this.ucLabel3.AutoSize = true;
            this.ucLabel3.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabel3.ForeColor = System.Drawing.Color.Gray;
            this.ucLabel3.IsMustChar = true;
            this.ucLabel3.Location = new System.Drawing.Point(271, 14);
            this.ucLabel3.Name = "ucLabel3";
            this.ucLabel3.Size = new System.Drawing.Size(65, 12);
            this.ucLabel3.TabIndex = 5;
            this.ucLabel3.Text = "报销标题：";
            // 
            // txtExpName
            // 
            // 
            // 
            // 
            this.txtExpName.Border.Class = "TextBoxBorder";
            this.txtExpName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtExpName.EnterToNextControl = false;
            this.txtExpName.Location = new System.Drawing.Point(342, 12);
            this.txtExpName.Name = "txtExpName";
            this.txtExpName.Size = new System.Drawing.Size(350, 21);
            this.txtExpName.TabIndex = 4;
            // 
            // txtSourceBillNo
            // 
            // 
            // 
            // 
            this.txtSourceBillNo.Border.Class = "TextBoxBorder";
            this.txtSourceBillNo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSourceBillNo.ButtonCustom.Visible = true;
            this.txtSourceBillNo.EnterToNextControl = false;
            this.txtSourceBillNo.Location = new System.Drawing.Point(88, 39);
            this.txtSourceBillNo.Name = "txtSourceBillNo";
            this.txtSourceBillNo.Size = new System.Drawing.Size(150, 21);
            this.txtSourceBillNo.TabIndex = 3;
            this.txtSourceBillNo.ButtonCustomClick += new System.EventHandler(this.txtSourceBillNo_ButtonCustomClick);
            // 
            // ucLabel2
            // 
            this.ucLabel2.AutoSize = true;
            this.ucLabel2.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabel2.ForeColor = System.Drawing.Color.Gray;
            this.ucLabel2.Location = new System.Drawing.Point(17, 44);
            this.ucLabel2.Name = "ucLabel2";
            this.ucLabel2.Size = new System.Drawing.Size(65, 12);
            this.ucLabel2.TabIndex = 2;
            this.ucLabel2.Text = "关联单号：";
            // 
            // ucLabel1
            // 
            this.ucLabel1.AutoSize = true;
            this.ucLabel1.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabel1.ForeColor = System.Drawing.Color.Gray;
            this.ucLabel1.Location = new System.Drawing.Point(17, 14);
            this.ucLabel1.Name = "ucLabel1";
            this.ucLabel1.Size = new System.Drawing.Size(65, 12);
            this.ucLabel1.TabIndex = 1;
            this.ucLabel1.Text = "报销单号：";
            // 
            // txtBillNo
            // 
            // 
            // 
            // 
            this.txtBillNo.Border.Class = "TextBoxBorder";
            this.txtBillNo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtBillNo.EnterToNextControl = false;
            this.txtBillNo.Location = new System.Drawing.Point(88, 12);
            this.txtBillNo.Name = "txtBillNo";
            this.txtBillNo.ReadOnly = true;
            this.txtBillNo.Size = new System.Drawing.Size(150, 21);
            this.txtBillNo.TabIndex = 0;
            // 
            // ucPanel2
            // 
            this.ucPanel2.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel2.Controls.Add(this.ucPanel4);
            this.ucPanel2.Controls.Add(this.ucPanel3);
            this.ucPanel2.Controls.Add(this.ucPanel5);
            this.ucPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPanel2.Location = new System.Drawing.Point(0, 122);
            this.ucPanel2.Name = "ucPanel2";
            this.ucPanel2.Size = new System.Drawing.Size(736, 356);
            this.ucPanel2.TabIndex = 1;
            // 
            // ucPanel4
            // 
            this.ucPanel4.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel4.Controls.Add(this.dgvExpenseLine);
            this.ucPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPanel4.Location = new System.Drawing.Point(0, 37);
            this.ucPanel4.Name = "ucPanel4";
            this.ucPanel4.Size = new System.Drawing.Size(736, 285);
            this.ucPanel4.TabIndex = 1;
            // 
            // dgvExpenseLine
            // 
            this.dgvExpenseLine.AllowUserToAddRows = false;
            this.dgvExpenseLine.AllowUserToDeleteRows = false;
            this.dgvExpenseLine.AllowUserToOrderColumns = true;
            this.dgvExpenseLine.BackgroundColor = System.Drawing.Color.White;
            this.dgvExpenseLine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExpenseLine.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colExpLineID,
            this.colExpLineGuID,
            this.colExpGuID,
            this.colExpName,
            this.colAmount,
            this.colChkAmount,
            this.colRemark});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvExpenseLine.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvExpenseLine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvExpenseLine.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvExpenseLine.HighlightSelectedColumnHeaders = false;
            this.dgvExpenseLine.Location = new System.Drawing.Point(0, 0);
            this.dgvExpenseLine.Name = "dgvExpenseLine";
            this.dgvExpenseLine.PaintEnhancedSelection = false;
            this.dgvExpenseLine.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvExpenseLine.RowTemplate.Height = 23;
            this.dgvExpenseLine.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvExpenseLine.SelectAllSignVisible = false;
            this.dgvExpenseLine.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvExpenseLine.Size = new System.Drawing.Size(736, 285);
            this.dgvExpenseLine.TabIndex = 0;
            this.dgvExpenseLine.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExpenseLine_CellValueChanged);
            // 
            // colExpLineID
            // 
            this.colExpLineID.DataPropertyName = "ExpLineID";
            this.colExpLineID.HeaderText = "ExpLineID";
            this.colExpLineID.Name = "colExpLineID";
            this.colExpLineID.Visible = false;
            // 
            // colExpLineGuID
            // 
            this.colExpLineGuID.DataPropertyName = "ExpLineGuID";
            this.colExpLineGuID.HeaderText = "ExpLineGuID";
            this.colExpLineGuID.Name = "colExpLineGuID";
            this.colExpLineGuID.Visible = false;
            // 
            // colExpGuID
            // 
            this.colExpGuID.DataPropertyName = "ExpGuID";
            this.colExpGuID.HeaderText = "ExpGuID";
            this.colExpGuID.Name = "colExpGuID";
            this.colExpGuID.Visible = false;
            // 
            // colExpName
            // 
            this.colExpName.DataPropertyName = "ExpName";
            this.colExpName.HeaderText = "费用名目";
            this.colExpName.Name = "colExpName";
            // 
            // colAmount
            // 
            this.colAmount.DataPropertyName = "Amount";
            this.colAmount.HeaderText = "报销金额";
            this.colAmount.Name = "colAmount";
            // 
            // colChkAmount
            // 
            this.colChkAmount.DataPropertyName = "ChkAmount";
            this.colChkAmount.HeaderText = "已处理金额";
            this.colChkAmount.Name = "colChkAmount";
            this.colChkAmount.ReadOnly = true;
            // 
            // colRemark
            // 
            this.colRemark.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colRemark.DataPropertyName = "Remark";
            this.colRemark.HeaderText = "备注";
            this.colRemark.Name = "colRemark";
            // 
            // ucPanel3
            // 
            this.ucPanel3.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel3.Controls.Add(this.ucToolStrip1);
            this.ucPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucPanel3.Location = new System.Drawing.Point(0, 0);
            this.ucPanel3.Name = "ucPanel3";
            this.ucPanel3.Size = new System.Drawing.Size(736, 37);
            this.ucPanel3.TabIndex = 0;
            // 
            // ucToolStrip1
            // 
            this.ucToolStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ucToolStrip1.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.ucToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAdd,
            this.tsbDel});
            this.ucToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.ucToolStrip1.Name = "ucToolStrip1";
            this.ucToolStrip1.Padding = new System.Windows.Forms.Padding(5);
            this.ucToolStrip1.Size = new System.Drawing.Size(736, 36);
            this.ucToolStrip1.TabIndex = 0;
            this.ucToolStrip1.Text = "ucToolStrip1";
            // 
            // tsbAdd
            // 
            this.tsbAdd.Image = global::ZNLCRM.UI.Properties.Resources.add_2;
            this.tsbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdd.Name = "tsbAdd";
            this.tsbAdd.Size = new System.Drawing.Size(55, 23);
            this.tsbAdd.Text = "添加";
            this.tsbAdd.Click += new System.EventHandler(this.tsbAdd_Click);
            // 
            // tsbDel
            // 
            this.tsbDel.Image = global::ZNLCRM.UI.Properties.Resources.del_2;
            this.tsbDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDel.Name = "tsbDel";
            this.tsbDel.Size = new System.Drawing.Size(55, 23);
            this.tsbDel.Text = "删除";
            this.tsbDel.Click += new System.EventHandler(this.tsbDel_Click);
            // 
            // ucPanel5
            // 
            this.ucPanel5.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel5.Controls.Add(this.btnCancel);
            this.ucPanel5.Controls.Add(this.btnSave);
            this.ucPanel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucPanel5.Location = new System.Drawing.Point(0, 322);
            this.ucPanel5.Name = "ucPanel5";
            this.ucPanel5.Size = new System.Drawing.Size(736, 34);
            this.ucPanel5.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.Image = global::ZNLCRM.UI.Properties.Resources.cancel_1;
            this.btnCancel.Location = new System.Drawing.Point(342, 8);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "取消";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Image = global::ZNLCRM.UI.Properties.Resources.save_1;
            this.btnSave.Location = new System.Drawing.Point(261, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "保存";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmFINSubmitExpense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 478);
            this.Controls.Add(this.ucPanel2);
            this.Controls.Add(this.panelExpense);
            this.Name = "frmFINSubmitExpense";
            this.Text = "报销费用";
            this.Load += new System.EventHandler(this.frmFINSubmitExpense_Load);
            this.panelExpense.ResumeLayout(false);
            this.panelExpense.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtOpDate)).EndInit();
            this.ucPanel2.ResumeLayout(false);
            this.ucPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenseLine)).EndInit();
            this.ucPanel3.ResumeLayout(false);
            this.ucPanel3.PerformLayout();
            this.ucToolStrip1.ResumeLayout(false);
            this.ucToolStrip1.PerformLayout();
            this.ucPanel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.UcPanel panelExpense;
        private Controls.UcTextBox txtSourceGuid;
        private Controls.UcTextBox txtOrgID;
        private Controls.UcTextBox txtExpGuID;
        private Controls.UcTextBox txtExpID;
        private Controls.UcTextBox txtRemark;
        private Controls.UcLabel ucLabel6;
        private Controls.UcTextBox txtAmount;
        private Controls.UcLabel ucLabel5;
        private Controls.UcLabel ucLabel4;
        private Controls.UcTextBox txtOpEmpName;
        private Controls.UcLabel 所属人员;
        private Controls.UcLabel ucLabel3;
        private Controls.UcTextBox txtExpName;
        private Controls.UcTextBox txtSourceBillNo;
        private Controls.UcLabel ucLabel2;
        private Controls.UcLabel ucLabel1;
        private Controls.UcTextBox txtBillNo;
        private Controls.UcPanel ucPanel2;
        private Controls.UcTextBox txtOpEmpID;
        private Controls.UcPanel ucPanel5;
        private Controls.UcButton btnCancel;
        private Controls.UcButton btnSave;
        private Controls.UcPanel ucPanel4;
        private Controls.UcDataGridView dgvExpenseLine;
        private Controls.UcPanel ucPanel3;
        private Controls.UcToolStrip ucToolStrip1;
        private System.Windows.Forms.ToolStripButton tsbAdd;
        private System.Windows.Forms.ToolStripButton tsbDel;
        private Controls.UcTextBox txtChkAmount;
        private Controls.UcLabel ucLabel7;
        private Controls.UcDateTimeInput txtOpDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExpLineID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExpLineGuID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExpGuID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChkAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRemark;
    }
}