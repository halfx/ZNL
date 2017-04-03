namespace ZNLCRM.UI.SPM
{
    partial class frmSalesOrderManage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ucPanel2 = new ZNLCRM.Controls.UcPanel(this.components);
            this.ucPanel3 = new ZNLCRM.Controls.UcPanel(this.components);
            this.dgvSalesOrder = new ZNLCRM.Controls.UcDataGridView(this.components);
            this.ucPanel1 = new ZNLCRM.Controls.UcPanel(this.components);
            this.btnSearch = new ZNLCRM.Controls.UcButton(this.components);
            this.cboBillType = new ZNLCRM.Controls.UcComboBox(this.components);
            this.txtBillNo = new ZNLCRM.Controls.UcTextBox(this.components);
            this.ucLabel2 = new ZNLCRM.Controls.UcLabel(this.components);
            this.ucLabel1 = new ZNLCRM.Controls.UcLabel(this.components);
            this.ucPanel5 = new ZNLCRM.Controls.UcPanel(this.components);
            this.pgSalesOrder = new ZNLCRM.Controls.UcPager();
            this.ucPanel4 = new ZNLCRM.Controls.UcPanel(this.components);
            this.ucToolStrip1 = new ZNLCRM.Controls.UcToolStrip(this.components);
            this.tsbAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbDel = new System.Windows.Forms.ToolStripButton();
            this.tsbPrint = new System.Windows.Forms.ToolStripButton();
            this.tlbAuditBill = new System.Windows.Forms.ToolStripButton();
            this.tlbCancelBill = new System.Windows.Forms.ToolStripButton();
            this.colSelect = new DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn();
            this.colOperOut = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colOperReturn = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colSOID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSOGuid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBillType = new DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn();
            this.colBillNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSalOrgID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSalOrgName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSalDeptID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSalDeptName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSalerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSalerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCurrency = new DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn();
            this.colTaxRate = new DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCommissionAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAllStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApproveStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStkOutOccStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReturnOccStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRemark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreatedEmpID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreatedEmpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreatedTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ucPanel2.SuspendLayout();
            this.ucPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesOrder)).BeginInit();
            this.ucPanel1.SuspendLayout();
            this.ucPanel5.SuspendLayout();
            this.ucPanel4.SuspendLayout();
            this.ucToolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ucPanel2
            // 
            this.ucPanel2.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel2.Controls.Add(this.ucPanel3);
            this.ucPanel2.Controls.Add(this.ucPanel1);
            this.ucPanel2.Controls.Add(this.ucPanel5);
            this.ucPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPanel2.Location = new System.Drawing.Point(0, 36);
            this.ucPanel2.Name = "ucPanel2";
            this.ucPanel2.Size = new System.Drawing.Size(1032, 467);
            this.ucPanel2.TabIndex = 1;
            // 
            // ucPanel3
            // 
            this.ucPanel3.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel3.Controls.Add(this.dgvSalesOrder);
            this.ucPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPanel3.Location = new System.Drawing.Point(0, 31);
            this.ucPanel3.Name = "ucPanel3";
            this.ucPanel3.Padding = new System.Windows.Forms.Padding(5);
            this.ucPanel3.Size = new System.Drawing.Size(1032, 407);
            this.ucPanel3.TabIndex = 1;
            // 
            // dgvSalesOrder
            // 
            this.dgvSalesOrder.AllowUserToAddRows = false;
            this.dgvSalesOrder.AllowUserToDeleteRows = false;
            this.dgvSalesOrder.AllowUserToOrderColumns = true;
            this.dgvSalesOrder.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSalesOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSalesOrder.ColumnHeadersHeight = 30;
            this.dgvSalesOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSelect,
            this.colOperOut,
            this.colOperReturn,
            this.colSOID,
            this.colSOGuid,
            this.colBillType,
            this.colBillNo,
            this.colCustomerName,
            this.colSalOrgID,
            this.colSalOrgName,
            this.colSalDeptID,
            this.colSalDeptName,
            this.colSalerName,
            this.colSalerID,
            this.colCurrency,
            this.colTaxRate,
            this.colAmount,
            this.colCommissionAmount,
            this.colAllStatus,
            this.colApproveStatus,
            this.colStatus,
            this.colStkOutOccStatus,
            this.colReturnOccStatus,
            this.colRemark,
            this.colCreatedEmpID,
            this.colCreatedEmpName,
            this.colCreatedTime});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSalesOrder.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSalesOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSalesOrder.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvSalesOrder.HighlightSelectedColumnHeaders = false;
            this.dgvSalesOrder.Location = new System.Drawing.Point(5, 5);
            this.dgvSalesOrder.Name = "dgvSalesOrder";
            this.dgvSalesOrder.PaintEnhancedSelection = false;
            this.dgvSalesOrder.ReadOnly = true;
            this.dgvSalesOrder.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvSalesOrder.RowTemplate.Height = 23;
            this.dgvSalesOrder.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSalesOrder.SelectAllSignVisible = false;
            this.dgvSalesOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvSalesOrder.Size = new System.Drawing.Size(1022, 397);
            this.dgvSalesOrder.TabIndex = 0;
            this.dgvSalesOrder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSalesOrder_CellContentClick);
            this.dgvSalesOrder.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSalesOrder_CellDoubleClick);
            this.dgvSalesOrder.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvSalesOrder_DataBindingComplete);
            this.dgvSalesOrder.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSalesOrder_RowEnter);
            // 
            // ucPanel1
            // 
            this.ucPanel1.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel1.Controls.Add(this.btnSearch);
            this.ucPanel1.Controls.Add(this.cboBillType);
            this.ucPanel1.Controls.Add(this.txtBillNo);
            this.ucPanel1.Controls.Add(this.ucLabel2);
            this.ucPanel1.Controls.Add(this.ucLabel1);
            this.ucPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucPanel1.Location = new System.Drawing.Point(0, 0);
            this.ucPanel1.Name = "ucPanel1";
            this.ucPanel1.Size = new System.Drawing.Size(1032, 31);
            this.ucPanel1.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSearch.Image = global::ZNLCRM.UI.Properties.Resources.search;
            this.btnSearch.Location = new System.Drawing.Point(363, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "搜索";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cboBillType
            // 
            this.cboBillType.DisplayMember = "Text";
            this.cboBillType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboBillType.FormattingEnabled = true;
            this.cboBillType.ItemHeight = 15;
            this.cboBillType.Location = new System.Drawing.Point(261, 4);
            this.cboBillType.Name = "cboBillType";
            this.cboBillType.Size = new System.Drawing.Size(96, 21);
            this.cboBillType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboBillType.TabIndex = 3;
            // 
            // txtBillNo
            // 
            // 
            // 
            // 
            this.txtBillNo.Border.Class = "TextBoxBorder";
            this.txtBillNo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtBillNo.EnterToNextControl = false;
            this.txtBillNo.Location = new System.Drawing.Point(83, 4);
            this.txtBillNo.Name = "txtBillNo";
            this.txtBillNo.Size = new System.Drawing.Size(100, 21);
            this.txtBillNo.TabIndex = 2;
            // 
            // ucLabel2
            // 
            this.ucLabel2.AutoSize = true;
            this.ucLabel2.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabel2.ForeColor = System.Drawing.Color.Gray;
            this.ucLabel2.Location = new System.Drawing.Point(190, 10);
            this.ucLabel2.Name = "ucLabel2";
            this.ucLabel2.Size = new System.Drawing.Size(65, 12);
            this.ucLabel2.TabIndex = 1;
            this.ucLabel2.Text = "订单类型：";
            // 
            // ucLabel1
            // 
            this.ucLabel1.AutoSize = true;
            this.ucLabel1.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabel1.ForeColor = System.Drawing.Color.Gray;
            this.ucLabel1.Location = new System.Drawing.Point(12, 10);
            this.ucLabel1.Name = "ucLabel1";
            this.ucLabel1.Size = new System.Drawing.Size(65, 12);
            this.ucLabel1.TabIndex = 0;
            this.ucLabel1.Text = "销售单号：";
            // 
            // ucPanel5
            // 
            this.ucPanel5.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel5.Controls.Add(this.pgSalesOrder);
            this.ucPanel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucPanel5.Location = new System.Drawing.Point(0, 438);
            this.ucPanel5.Name = "ucPanel5";
            this.ucPanel5.Size = new System.Drawing.Size(1032, 29);
            this.ucPanel5.TabIndex = 2;
            // 
            // pgSalesOrder
            // 
            this.pgSalesOrder.BackColor = System.Drawing.Color.Transparent;
            this.pgSalesOrder.Location = new System.Drawing.Point(14, 6);
            this.pgSalesOrder.Name = "pgSalesOrder";
            this.pgSalesOrder.RecordCount = 0;
            this.pgSalesOrder.Size = new System.Drawing.Size(346, 15);
            this.pgSalesOrder.TabIndex = 0;
            // 
            // ucPanel4
            // 
            this.ucPanel4.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel4.Controls.Add(this.ucToolStrip1);
            this.ucPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucPanel4.Location = new System.Drawing.Point(0, 0);
            this.ucPanel4.Name = "ucPanel4";
            this.ucPanel4.Size = new System.Drawing.Size(1032, 36);
            this.ucPanel4.TabIndex = 2;
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
            this.ucToolStrip1.Size = new System.Drawing.Size(1032, 36);
            this.ucToolStrip1.TabIndex = 0;
            this.ucToolStrip1.Text = "ucToolStrip1";
            // 
            // tsbAdd
            // 
            this.tsbAdd.Image = global::ZNLCRM.UI.Properties.Resources.add_1;
            this.tsbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdd.Name = "tsbAdd";
            this.tsbAdd.Size = new System.Drawing.Size(55, 23);
            this.tsbAdd.Text = "新增";
            this.tsbAdd.ToolTipText = "添加新的销售单";
            this.tsbAdd.Click += new System.EventHandler(this.tsbAdd_Click);
            // 
            // tsbEdit
            // 
            this.tsbEdit.Image = global::ZNLCRM.UI.Properties.Resources.edit_1;
            this.tsbEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEdit.Name = "tsbEdit";
            this.tsbEdit.Size = new System.Drawing.Size(55, 23);
            this.tsbEdit.Text = "修改";
            this.tsbEdit.Click += new System.EventHandler(this.tsbEdit_Click);
            // 
            // tsbDel
            // 
            this.tsbDel.Image = global::ZNLCRM.UI.Properties.Resources.del_1;
            this.tsbDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDel.Name = "tsbDel";
            this.tsbDel.Size = new System.Drawing.Size(55, 23);
            this.tsbDel.Text = "删除";
            this.tsbDel.Click += new System.EventHandler(this.tsbDel_Click);
            // 
            // tsbPrint
            // 
            this.tsbPrint.Image = global::ZNLCRM.UI.Properties.Resources.print_1;
            this.tsbPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPrint.Name = "tsbPrint";
            this.tsbPrint.Size = new System.Drawing.Size(55, 23);
            this.tsbPrint.Text = "打印";
            // 
            // tlbAuditBill
            // 
            this.tlbAuditBill.Image = global::ZNLCRM.UI.Properties.Resources.checkok;
            this.tlbAuditBill.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlbAuditBill.Name = "tlbAuditBill";
            this.tlbAuditBill.Size = new System.Drawing.Size(55, 23);
            this.tlbAuditBill.Text = "审核";
            this.tlbAuditBill.Click += new System.EventHandler(this.tlbAuditBill_Click);
            // 
            // tlbCancelBill
            // 
            this.tlbCancelBill.Image = global::ZNLCRM.UI.Properties.Resources.cancel_1;
            this.tlbCancelBill.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlbCancelBill.Name = "tlbCancelBill";
            this.tlbCancelBill.Size = new System.Drawing.Size(55, 23);
            this.tlbCancelBill.Text = "撤单";
            this.tlbCancelBill.Click += new System.EventHandler(this.tlbCancelBill_Click);
            // 
            // colSelect
            // 
            this.colSelect.Checked = true;
            this.colSelect.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.colSelect.CheckValue = "N";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colSelect.DefaultCellStyle = dataGridViewCellStyle2;
            this.colSelect.HeaderText = "选？";
            this.colSelect.Name = "colSelect";
            this.colSelect.ReadOnly = true;
            this.colSelect.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colSelect.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colSelect.Width = 35;
            // 
            // colOperOut
            // 
            this.colOperOut.HeaderText = "出库";
            this.colOperOut.Name = "colOperOut";
            this.colOperOut.ReadOnly = true;
            this.colOperOut.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colOperOut.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colOperOut.Text = "出库";
            this.colOperOut.Width = 80;
            // 
            // colOperReturn
            // 
            this.colOperReturn.HeaderText = "退货";
            this.colOperReturn.Name = "colOperReturn";
            this.colOperReturn.ReadOnly = true;
            this.colOperReturn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colOperReturn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colOperReturn.Text = "退货";
            this.colOperReturn.Width = 80;
            // 
            // colSOID
            // 
            this.colSOID.DataPropertyName = "SOID";
            this.colSOID.HeaderText = "SOID";
            this.colSOID.Name = "colSOID";
            this.colSOID.ReadOnly = true;
            this.colSOID.Visible = false;
            // 
            // colSOGuid
            // 
            this.colSOGuid.DataPropertyName = "SOGuid";
            this.colSOGuid.HeaderText = "SOGuid";
            this.colSOGuid.Name = "colSOGuid";
            this.colSOGuid.ReadOnly = true;
            this.colSOGuid.Visible = false;
            // 
            // colBillType
            // 
            this.colBillType.DataPropertyName = "BillType";
            this.colBillType.DropDownHeight = 106;
            this.colBillType.DropDownWidth = 121;
            this.colBillType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colBillType.HeaderText = "单据类型";
            this.colBillType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.colBillType.IntegralHeight = false;
            this.colBillType.ItemHeight = 16;
            this.colBillType.Name = "colBillType";
            this.colBillType.ReadOnly = true;
            this.colBillType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colBillType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // colBillNo
            // 
            this.colBillNo.DataPropertyName = "BillNo";
            this.colBillNo.HeaderText = "单据编号";
            this.colBillNo.Name = "colBillNo";
            this.colBillNo.ReadOnly = true;
            // 
            // colCustomerName
            // 
            this.colCustomerName.DataPropertyName = "CustomerName";
            this.colCustomerName.HeaderText = "客户名称";
            this.colCustomerName.Name = "colCustomerName";
            this.colCustomerName.ReadOnly = true;
            // 
            // colSalOrgID
            // 
            this.colSalOrgID.DataPropertyName = "SalOrgID";
            this.colSalOrgID.HeaderText = "销售机构ID";
            this.colSalOrgID.Name = "colSalOrgID";
            this.colSalOrgID.ReadOnly = true;
            this.colSalOrgID.Visible = false;
            // 
            // colSalOrgName
            // 
            this.colSalOrgName.DataPropertyName = "SalOrgName";
            this.colSalOrgName.HeaderText = "销售机构";
            this.colSalOrgName.Name = "colSalOrgName";
            this.colSalOrgName.ReadOnly = true;
            // 
            // colSalDeptID
            // 
            this.colSalDeptID.DataPropertyName = "SalDeptID";
            this.colSalDeptID.HeaderText = "销售部门";
            this.colSalDeptID.Name = "colSalDeptID";
            this.colSalDeptID.ReadOnly = true;
            this.colSalDeptID.Visible = false;
            // 
            // colSalDeptName
            // 
            this.colSalDeptName.DataPropertyName = "SalDeptName";
            this.colSalDeptName.HeaderText = "销售部门";
            this.colSalDeptName.Name = "colSalDeptName";
            this.colSalDeptName.ReadOnly = true;
            // 
            // colSalerName
            // 
            this.colSalerName.DataPropertyName = "SalerName";
            this.colSalerName.HeaderText = "销售员";
            this.colSalerName.Name = "colSalerName";
            this.colSalerName.ReadOnly = true;
            // 
            // colSalerID
            // 
            this.colSalerID.DataPropertyName = "SalerID";
            this.colSalerID.HeaderText = "销售员ID";
            this.colSalerID.Name = "colSalerID";
            this.colSalerID.ReadOnly = true;
            this.colSalerID.Visible = false;
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
            this.colTaxRate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // colAmount
            // 
            this.colAmount.DataPropertyName = "Amount";
            this.colAmount.HeaderText = "销售金额";
            this.colAmount.Name = "colAmount";
            this.colAmount.ReadOnly = true;
            // 
            // colCommissionAmount
            // 
            this.colCommissionAmount.DataPropertyName = "CommissionAmount";
            this.colCommissionAmount.HeaderText = "佣金额金额";
            this.colCommissionAmount.Name = "colCommissionAmount";
            this.colCommissionAmount.ReadOnly = true;
            // 
            // colAllStatus
            // 
            this.colAllStatus.DataPropertyName = "AllStatus";
            this.colAllStatus.HeaderText = "业务状态";
            this.colAllStatus.Name = "colAllStatus";
            this.colAllStatus.ReadOnly = true;
            this.colAllStatus.Width = 200;
            // 
            // colApproveStatus
            // 
            this.colApproveStatus.DataPropertyName = "ApproveStatus";
            this.colApproveStatus.HeaderText = "单据状态";
            this.colApproveStatus.Name = "colApproveStatus";
            this.colApproveStatus.ReadOnly = true;
            this.colApproveStatus.Width = 80;
            // 
            // colStatus
            // 
            this.colStatus.DataPropertyName = "Status";
            this.colStatus.HeaderText = "单据状态";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            this.colStatus.Visible = false;
            // 
            // colStkOutOccStatus
            // 
            this.colStkOutOccStatus.DataPropertyName = "StkOutOccStatus";
            this.colStkOutOccStatus.HeaderText = "出库占有状态";
            this.colStkOutOccStatus.Name = "colStkOutOccStatus";
            this.colStkOutOccStatus.ReadOnly = true;
            this.colStkOutOccStatus.Visible = false;
            // 
            // colReturnOccStatus
            // 
            this.colReturnOccStatus.DataPropertyName = "ReturnOccStatus";
            this.colReturnOccStatus.HeaderText = "退货占有状态";
            this.colReturnOccStatus.Name = "colReturnOccStatus";
            this.colReturnOccStatus.ReadOnly = true;
            this.colReturnOccStatus.Visible = false;
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
            // frmSalesOrderManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 503);
            this.Controls.Add(this.ucPanel2);
            this.Controls.Add(this.ucPanel4);
            this.Name = "frmSalesOrderManage";
            this.Text = "销售单管理";
            this.Load += new System.EventHandler(this.frmSalesOrderManage_Load);
            this.ucPanel2.ResumeLayout(false);
            this.ucPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesOrder)).EndInit();
            this.ucPanel1.ResumeLayout(false);
            this.ucPanel1.PerformLayout();
            this.ucPanel5.ResumeLayout(false);
            this.ucPanel4.ResumeLayout(false);
            this.ucPanel4.PerformLayout();
            this.ucToolStrip1.ResumeLayout(false);
            this.ucToolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.UcPanel ucPanel1;
        private Controls.UcLabel ucLabel1;
        private Controls.UcPanel ucPanel2;
        private Controls.UcComboBox cboBillType;
        private Controls.UcTextBox txtBillNo;
        private Controls.UcLabel ucLabel2;
        private Controls.UcPanel ucPanel3;
        private Controls.UcPanel ucPanel4;
        private Controls.UcToolStrip ucToolStrip1;
        private System.Windows.Forms.ToolStripButton tsbAdd;
        private System.Windows.Forms.ToolStripButton tsbEdit;
        private System.Windows.Forms.ToolStripButton tsbDel;
        private System.Windows.Forms.ToolStripButton tsbPrint;
        private Controls.UcPanel ucPanel5;
        private Controls.UcPager pgSalesOrder;
        private Controls.UcDataGridView dgvSalesOrder;
        private Controls.UcButton btnSearch;
        private System.Windows.Forms.ToolStripButton tlbAuditBill;
        private System.Windows.Forms.ToolStripButton tlbCancelBill;
        private DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn colSelect;
        private System.Windows.Forms.DataGridViewLinkColumn colOperOut;
        private System.Windows.Forms.DataGridViewLinkColumn colOperReturn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSOID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSOGuid;
        private DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn colBillType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBillNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSalOrgID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSalOrgName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSalDeptID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSalDeptName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSalerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSalerID;
        private DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn colCurrency;
        private DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn colTaxRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCommissionAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAllStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApproveStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStkOutOccStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReturnOccStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRemark;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreatedEmpID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreatedEmpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreatedTime;
    }
}