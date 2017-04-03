namespace ZNLCRM.UI.PPM
{
    partial class frmPurchaseReturnManage
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
            this.ucPanel2 = new ZNLCRM.Controls.UcPanel(this.components);
            this.ucPanel3 = new ZNLCRM.Controls.UcPanel(this.components);
            this.ucPanel7 = new ZNLCRM.Controls.UcPanel(this.components);
            this.dgvPurchaseReturn = new ZNLCRM.Controls.UcDataGridView(this.components);
            this.ucPanel6 = new ZNLCRM.Controls.UcPanel(this.components);
            this.txtOperEmpName = new ZNLCRM.Controls.UcTextBox(this.components);
            this.ucLabel2 = new ZNLCRM.Controls.UcLabel(this.components);
            this.txtSupplierName = new ZNLCRM.Controls.UcTextBox(this.components);
            this.ucLabel1 = new ZNLCRM.Controls.UcLabel(this.components);
            this.btnSearch = new ZNLCRM.Controls.UcButton(this.components);
            this.txtBillNo = new ZNLCRM.Controls.UcTextBox(this.components);
            this.ucLabel4 = new ZNLCRM.Controls.UcLabel(this.components);
            this.ucPanel4 = new ZNLCRM.Controls.UcPanel(this.components);
            this.ucToolStrip1 = new ZNLCRM.Controls.UcToolStrip(this.components);
            this.tsbAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbDel = new System.Windows.Forms.ToolStripButton();
            this.tsbPrint = new System.Windows.Forms.ToolStripButton();
            this.tlbAuditBill = new System.Windows.Forms.ToolStripButton();
            this.tlbCancelBill = new System.Windows.Forms.ToolStripButton();
            this.ucPanel5 = new ZNLCRM.Controls.UcPanel(this.components);
            this.pgPurchaseReturn = new ZNLCRM.Controls.UcPager();
            this.colOperOut = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colPRID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPRGuid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBillNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReturnDate = new DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn();
            this.colSupplierID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSupplierName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOperOrgID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOperOrgName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOperDeptID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOperDeptName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOperEmpID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOperEmpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCurrency = new DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAllStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStkOutOccStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApproveStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRemark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreatedEmpID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreatedEmpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreatedTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ucPanel2.SuspendLayout();
            this.ucPanel3.SuspendLayout();
            this.ucPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseReturn)).BeginInit();
            this.ucPanel6.SuspendLayout();
            this.ucPanel4.SuspendLayout();
            this.ucToolStrip1.SuspendLayout();
            this.ucPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // ucPanel2
            // 
            this.ucPanel2.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel2.Controls.Add(this.ucPanel3);
            this.ucPanel2.Controls.Add(this.ucPanel4);
            this.ucPanel2.Controls.Add(this.ucPanel5);
            this.ucPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPanel2.Location = new System.Drawing.Point(0, 0);
            this.ucPanel2.Name = "ucPanel2";
            this.ucPanel2.Size = new System.Drawing.Size(930, 431);
            this.ucPanel2.TabIndex = 4;
            // 
            // ucPanel3
            // 
            this.ucPanel3.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel3.Controls.Add(this.ucPanel7);
            this.ucPanel3.Controls.Add(this.ucPanel6);
            this.ucPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPanel3.Location = new System.Drawing.Point(0, 37);
            this.ucPanel3.Name = "ucPanel3";
            this.ucPanel3.Padding = new System.Windows.Forms.Padding(5);
            this.ucPanel3.Size = new System.Drawing.Size(930, 364);
            this.ucPanel3.TabIndex = 1;
            // 
            // ucPanel7
            // 
            this.ucPanel7.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel7.Controls.Add(this.dgvPurchaseReturn);
            this.ucPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPanel7.Location = new System.Drawing.Point(5, 36);
            this.ucPanel7.Name = "ucPanel7";
            this.ucPanel7.Padding = new System.Windows.Forms.Padding(5);
            this.ucPanel7.Size = new System.Drawing.Size(920, 323);
            this.ucPanel7.TabIndex = 2;
            // 
            // dgvPurchaseReturn
            // 
            this.dgvPurchaseReturn.AllowUserToAddRows = false;
            this.dgvPurchaseReturn.AllowUserToDeleteRows = false;
            this.dgvPurchaseReturn.AllowUserToOrderColumns = true;
            this.dgvPurchaseReturn.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPurchaseReturn.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPurchaseReturn.ColumnHeadersHeight = 30;
            this.dgvPurchaseReturn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colOperOut,
            this.colPRID,
            this.colPRGuid,
            this.colBillNo,
            this.colReturnDate,
            this.colSupplierID,
            this.colSupplierName,
            this.colOperOrgID,
            this.colOperOrgName,
            this.colOperDeptID,
            this.colOperDeptName,
            this.colOperEmpID,
            this.colOperEmpName,
            this.colCurrency,
            this.colAmount,
            this.colAllStatus,
            this.colStkOutOccStatus,
            this.colApproveStatus,
            this.colStatus,
            this.colRemark,
            this.colCreatedEmpID,
            this.colCreatedEmpName,
            this.colCreatedTime});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPurchaseReturn.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPurchaseReturn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPurchaseReturn.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvPurchaseReturn.HighlightSelectedColumnHeaders = false;
            this.dgvPurchaseReturn.Location = new System.Drawing.Point(5, 5);
            this.dgvPurchaseReturn.Name = "dgvPurchaseReturn";
            this.dgvPurchaseReturn.PaintEnhancedSelection = false;
            this.dgvPurchaseReturn.ReadOnly = true;
            this.dgvPurchaseReturn.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPurchaseReturn.RowTemplate.Height = 23;
            this.dgvPurchaseReturn.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPurchaseReturn.SelectAllSignVisible = false;
            this.dgvPurchaseReturn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvPurchaseReturn.Size = new System.Drawing.Size(910, 313);
            this.dgvPurchaseReturn.TabIndex = 0;
            this.dgvPurchaseReturn.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPurchaseReturn_CellContentClick);
            this.dgvPurchaseReturn.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvPurchaseReturn_DataBindingComplete);
            // 
            // ucPanel6
            // 
            this.ucPanel6.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel6.Controls.Add(this.txtOperEmpName);
            this.ucPanel6.Controls.Add(this.ucLabel2);
            this.ucPanel6.Controls.Add(this.txtSupplierName);
            this.ucPanel6.Controls.Add(this.ucLabel1);
            this.ucPanel6.Controls.Add(this.btnSearch);
            this.ucPanel6.Controls.Add(this.txtBillNo);
            this.ucPanel6.Controls.Add(this.ucLabel4);
            this.ucPanel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucPanel6.Location = new System.Drawing.Point(5, 5);
            this.ucPanel6.Name = "ucPanel6";
            this.ucPanel6.Size = new System.Drawing.Size(920, 31);
            this.ucPanel6.TabIndex = 1;
            // 
            // txtOperEmpName
            // 
            // 
            // 
            // 
            this.txtOperEmpName.Border.Class = "TextBoxBorder";
            this.txtOperEmpName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtOperEmpName.EnterToNextControl = false;
            this.txtOperEmpName.Location = new System.Drawing.Point(555, 6);
            this.txtOperEmpName.Name = "txtOperEmpName";
            this.txtOperEmpName.Size = new System.Drawing.Size(100, 21);
            this.txtOperEmpName.TabIndex = 8;
            // 
            // ucLabel2
            // 
            this.ucLabel2.AutoSize = true;
            this.ucLabel2.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabel2.ForeColor = System.Drawing.Color.Gray;
            this.ucLabel2.Location = new System.Drawing.Point(484, 10);
            this.ucLabel2.Name = "ucLabel2";
            this.ucLabel2.Size = new System.Drawing.Size(65, 12);
            this.ucLabel2.TabIndex = 7;
            this.ucLabel2.Text = "归属人员：";
            // 
            // txtSupplierName
            // 
            // 
            // 
            // 
            this.txtSupplierName.Border.Class = "TextBoxBorder";
            this.txtSupplierName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSupplierName.EnterToNextControl = false;
            this.txtSupplierName.Location = new System.Drawing.Point(278, 6);
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.Size = new System.Drawing.Size(200, 21);
            this.txtSupplierName.TabIndex = 6;
            // 
            // ucLabel1
            // 
            this.ucLabel1.AutoSize = true;
            this.ucLabel1.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabel1.ForeColor = System.Drawing.Color.Gray;
            this.ucLabel1.Location = new System.Drawing.Point(219, 10);
            this.ucLabel1.Name = "ucLabel1";
            this.ucLabel1.Size = new System.Drawing.Size(53, 12);
            this.ucLabel1.TabIndex = 5;
            this.ucLabel1.Text = "供应商：";
            // 
            // btnSearch
            // 
            this.btnSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSearch.Image = global::ZNLCRM.UI.Properties.Resources.search;
            this.btnSearch.Location = new System.Drawing.Point(683, 6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "搜索";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtBillNo
            // 
            // 
            // 
            // 
            this.txtBillNo.Border.Class = "TextBoxBorder";
            this.txtBillNo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtBillNo.EnterToNextControl = false;
            this.txtBillNo.Location = new System.Drawing.Point(104, 6);
            this.txtBillNo.Name = "txtBillNo";
            this.txtBillNo.Size = new System.Drawing.Size(100, 21);
            this.txtBillNo.TabIndex = 2;
            // 
            // ucLabel4
            // 
            this.ucLabel4.AutoSize = true;
            this.ucLabel4.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabel4.ForeColor = System.Drawing.Color.Gray;
            this.ucLabel4.Location = new System.Drawing.Point(12, 10);
            this.ucLabel4.Name = "ucLabel4";
            this.ucLabel4.Size = new System.Drawing.Size(89, 12);
            this.ucLabel4.TabIndex = 0;
            this.ucLabel4.Text = "采购退货单号：";
            // 
            // ucPanel4
            // 
            this.ucPanel4.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel4.Controls.Add(this.ucToolStrip1);
            this.ucPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucPanel4.Location = new System.Drawing.Point(0, 0);
            this.ucPanel4.Name = "ucPanel4";
            this.ucPanel4.Size = new System.Drawing.Size(930, 37);
            this.ucPanel4.TabIndex = 4;
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
            this.ucToolStrip1.Size = new System.Drawing.Size(930, 37);
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
            this.tsbAdd.ToolTipText = "添加新的采购退货单";
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
            // ucPanel5
            // 
            this.ucPanel5.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel5.Controls.Add(this.pgPurchaseReturn);
            this.ucPanel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucPanel5.Location = new System.Drawing.Point(0, 401);
            this.ucPanel5.Name = "ucPanel5";
            this.ucPanel5.Size = new System.Drawing.Size(930, 30);
            this.ucPanel5.TabIndex = 2;
            // 
            // pgPurchaseReturn
            // 
            this.pgPurchaseReturn.BackColor = System.Drawing.Color.Transparent;
            this.pgPurchaseReturn.Location = new System.Drawing.Point(14, 7);
            this.pgPurchaseReturn.Name = "pgPurchaseReturn";
            this.pgPurchaseReturn.RecordCount = 0;
            this.pgPurchaseReturn.Size = new System.Drawing.Size(195, 15);
            this.pgPurchaseReturn.TabIndex = 0;
            this.pgPurchaseReturn.PageIndexChanged += new System.EventHandler(this.pgPurchaseReturn_PageIndexChanged);
            // 
            // colOperOut
            // 
            this.colOperOut.HeaderText = "操作";
            this.colOperOut.Name = "colOperOut";
            this.colOperOut.ReadOnly = true;
            this.colOperOut.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colOperOut.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colOperOut.Text = "入库";
            this.colOperOut.Width = 80;
            // 
            // colPRID
            // 
            this.colPRID.DataPropertyName = "PRID";
            this.colPRID.HeaderText = "PRID";
            this.colPRID.Name = "colPRID";
            this.colPRID.ReadOnly = true;
            this.colPRID.Visible = false;
            // 
            // colPRGuid
            // 
            this.colPRGuid.DataPropertyName = "PRGuid";
            this.colPRGuid.HeaderText = "PRGuid";
            this.colPRGuid.Name = "colPRGuid";
            this.colPRGuid.ReadOnly = true;
            this.colPRGuid.Visible = false;
            // 
            // colBillNo
            // 
            this.colBillNo.DataPropertyName = "BillNo";
            this.colBillNo.HeaderText = "单据编号";
            this.colBillNo.Name = "colBillNo";
            this.colBillNo.ReadOnly = true;
            // 
            // colReturnDate
            // 
            // 
            // 
            // 
            this.colReturnDate.BackgroundStyle.Class = "DataGridViewDateTimeBorder";
            this.colReturnDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.colReturnDate.CustomFormat = "yyyy-MM-dd";
            this.colReturnDate.DataPropertyName = "ReturnDate";
            this.colReturnDate.Format = DevComponents.Editors.eDateTimePickerFormat.Custom;
            this.colReturnDate.HeaderText = "退货日期";
            this.colReturnDate.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left;
            // 
            // 
            // 
            this.colReturnDate.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.colReturnDate.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.colReturnDate.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            // 
            // 
            // 
            this.colReturnDate.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.colReturnDate.MonthCalendar.DisplayMonth = new System.DateTime(2015, 2, 1, 0, 0, 0, 0);
            this.colReturnDate.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.colReturnDate.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.colReturnDate.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.colReturnDate.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.colReturnDate.Name = "colReturnDate";
            this.colReturnDate.ReadOnly = true;
            this.colReturnDate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colSupplierID
            // 
            this.colSupplierID.DataPropertyName = "SupplierID";
            this.colSupplierID.HeaderText = "供应商ID";
            this.colSupplierID.Name = "colSupplierID";
            this.colSupplierID.ReadOnly = true;
            this.colSupplierID.Visible = false;
            // 
            // colSupplierName
            // 
            this.colSupplierName.DataPropertyName = "SupplierName";
            this.colSupplierName.HeaderText = "供应商名称";
            this.colSupplierName.Name = "colSupplierName";
            this.colSupplierName.ReadOnly = true;
            this.colSupplierName.Width = 150;
            // 
            // colOperOrgID
            // 
            this.colOperOrgID.DataPropertyName = "OperOrgID";
            this.colOperOrgID.HeaderText = "归属机构ID";
            this.colOperOrgID.Name = "colOperOrgID";
            this.colOperOrgID.ReadOnly = true;
            this.colOperOrgID.Visible = false;
            // 
            // colOperOrgName
            // 
            this.colOperOrgName.DataPropertyName = "OperOrgName";
            this.colOperOrgName.HeaderText = "归属机构";
            this.colOperOrgName.Name = "colOperOrgName";
            this.colOperOrgName.ReadOnly = true;
            // 
            // colOperDeptID
            // 
            this.colOperDeptID.DataPropertyName = "OperDeptID";
            this.colOperDeptID.HeaderText = "归属部门ID";
            this.colOperDeptID.Name = "colOperDeptID";
            this.colOperDeptID.ReadOnly = true;
            this.colOperDeptID.Visible = false;
            // 
            // colOperDeptName
            // 
            this.colOperDeptName.DataPropertyName = "OperDeptName";
            this.colOperDeptName.HeaderText = "归属部门";
            this.colOperDeptName.Name = "colOperDeptName";
            this.colOperDeptName.ReadOnly = true;
            // 
            // colOperEmpID
            // 
            this.colOperEmpID.DataPropertyName = "OperEmpID";
            this.colOperEmpID.HeaderText = "归属人员ID";
            this.colOperEmpID.Name = "colOperEmpID";
            this.colOperEmpID.ReadOnly = true;
            this.colOperEmpID.Visible = false;
            // 
            // colOperEmpName
            // 
            this.colOperEmpName.DataPropertyName = "OperEmpName";
            this.colOperEmpName.HeaderText = "归属人员";
            this.colOperEmpName.Name = "colOperEmpName";
            this.colOperEmpName.ReadOnly = true;
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
            // colAmount
            // 
            this.colAmount.DataPropertyName = "Amount";
            this.colAmount.HeaderText = "退货金额";
            this.colAmount.Name = "colAmount";
            this.colAmount.ReadOnly = true;
            // 
            // colAllStatus
            // 
            this.colAllStatus.DataPropertyName = "AllStatus";
            this.colAllStatus.HeaderText = "业务状态";
            this.colAllStatus.Name = "colAllStatus";
            this.colAllStatus.ReadOnly = true;
            // 
            // colStkOutOccStatus
            // 
            this.colStkOutOccStatus.DataPropertyName = "StkOutOccStatus";
            this.colStkOutOccStatus.HeaderText = "出库占有状态";
            this.colStkOutOccStatus.Name = "colStkOutOccStatus";
            this.colStkOutOccStatus.ReadOnly = true;
            this.colStkOutOccStatus.Visible = false;
            // 
            // colApproveStatus
            // 
            this.colApproveStatus.DataPropertyName = "ApproveStatus";
            this.colApproveStatus.HeaderText = "单据状态";
            this.colApproveStatus.Name = "colApproveStatus";
            this.colApproveStatus.ReadOnly = true;
            // 
            // colStatus
            // 
            this.colStatus.DataPropertyName = "Status";
            this.colStatus.HeaderText = "单据状态";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            this.colStatus.Visible = false;
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
            // frmPurchaseReturnManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 431);
            this.Controls.Add(this.ucPanel2);
            this.Name = "frmPurchaseReturnManage";
            this.Text = "采购退货管理";
            this.Load += new System.EventHandler(this.frmPurchaseReturnManage_Load);
            this.ucPanel2.ResumeLayout(false);
            this.ucPanel3.ResumeLayout(false);
            this.ucPanel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseReturn)).EndInit();
            this.ucPanel6.ResumeLayout(false);
            this.ucPanel6.PerformLayout();
            this.ucPanel4.ResumeLayout(false);
            this.ucPanel4.PerformLayout();
            this.ucToolStrip1.ResumeLayout(false);
            this.ucToolStrip1.PerformLayout();
            this.ucPanel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.UcPanel ucPanel2;
        private Controls.UcPanel ucPanel3;
        private Controls.UcPanel ucPanel7;
        private Controls.UcDataGridView dgvPurchaseReturn;
        private Controls.UcPanel ucPanel6;
        private Controls.UcButton btnSearch;
        private Controls.UcTextBox txtBillNo;
        private Controls.UcLabel ucLabel4;
        private Controls.UcPanel ucPanel4;
        private Controls.UcToolStrip ucToolStrip1;
        private System.Windows.Forms.ToolStripButton tsbAdd;
        private System.Windows.Forms.ToolStripButton tsbEdit;
        private System.Windows.Forms.ToolStripButton tsbDel;
        private System.Windows.Forms.ToolStripButton tsbPrint;
        private Controls.UcPanel ucPanel5;
        private Controls.UcPager pgPurchaseReturn;
        private Controls.UcTextBox txtOperEmpName;
        private Controls.UcLabel ucLabel2;
        private Controls.UcTextBox txtSupplierName;
        private Controls.UcLabel ucLabel1;
        private System.Windows.Forms.ToolStripButton tlbAuditBill;
        private System.Windows.Forms.ToolStripButton tlbCancelBill;
        private System.Windows.Forms.DataGridViewLinkColumn colOperOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPRID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPRGuid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBillNo;
        private DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn colReturnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSupplierID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSupplierName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOperOrgID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOperOrgName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOperDeptID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOperDeptName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOperEmpID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOperEmpName;
        private DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn colCurrency;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAllStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStkOutOccStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApproveStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRemark;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreatedEmpID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreatedEmpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreatedTime;
    }
}