namespace ZNLCRM.UI.PPM
{
    partial class frmSelectPurchaseOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelectPurchaseOrder));
            this.dgvPurchaseOrder = new ZNLCRM.Controls.UcDataGridView(this.components);
            this.ucPanel3 = new ZNLCRM.Controls.UcPanel(this.components);
            this.pgPurchaseOrder = new ZNLCRM.Controls.UcPager();
            this.btnSearch = new ZNLCRM.Controls.UcButton(this.components);
            this.btnCancel = new ZNLCRM.Controls.UcButton(this.components);
            this.ucPanel1 = new ZNLCRM.Controls.UcPanel(this.components);
            this.ucPanel2 = new ZNLCRM.Controls.UcPanel(this.components);
            this.grpSearch = new ZNLCRM.Controls.UcPanel(this.components);
            this.UcLabel1 = new ZNLCRM.Controls.UcLabel(this.components);
            this.txtBillNo = new ZNLCRM.Controls.UcTextBox(this.components);
            this.chkAll = new ZNLCRM.Controls.UcCheckBox(this.components);
            this.panBottom = new ZNLCRM.Controls.UcPanel(this.components);
            this.btnOK = new ZNLCRM.Controls.UcButton(this.components);
            this.colPOID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPOGuid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBillNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPODate = new DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn();
            this.colBuyerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBuyerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSupplierName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTaxRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCurrency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNeedDeliveryDate = new DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn();
            this.colAllStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApproveStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseOrder)).BeginInit();
            this.ucPanel3.SuspendLayout();
            this.ucPanel1.SuspendLayout();
            this.ucPanel2.SuspendLayout();
            this.grpSearch.SuspendLayout();
            this.panBottom.SuspendLayout();
            this.SuspendLayout();
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
            this.dgvPurchaseOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPurchaseOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPOID,
            this.colPOGuid,
            this.colBillNo,
            this.colPODate,
            this.colBuyerID,
            this.colBuyerName,
            this.colSupplierName,
            this.colContact,
            this.colTelephone,
            this.colTaxRate,
            this.colCurrency,
            this.colAmount,
            this.colNeedDeliveryDate,
            this.colAllStatus,
            this.colApproveStatus});
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
            this.dgvPurchaseOrder.Location = new System.Drawing.Point(0, 30);
            this.dgvPurchaseOrder.Name = "dgvPurchaseOrder";
            this.dgvPurchaseOrder.PaintEnhancedSelection = false;
            this.dgvPurchaseOrder.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPurchaseOrder.RowTemplate.Height = 23;
            this.dgvPurchaseOrder.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPurchaseOrder.SelectAllSignVisible = false;
            this.dgvPurchaseOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvPurchaseOrder.Size = new System.Drawing.Size(963, 339);
            this.dgvPurchaseOrder.TabIndex = 0;
            // 
            // ucPanel3
            // 
            this.ucPanel3.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel3.Controls.Add(this.pgPurchaseOrder);
            this.ucPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucPanel3.Location = new System.Drawing.Point(0, 369);
            this.ucPanel3.Name = "ucPanel3";
            this.ucPanel3.Size = new System.Drawing.Size(963, 33);
            this.ucPanel3.TabIndex = 4;
            // 
            // pgPurchaseOrder
            // 
            this.pgPurchaseOrder.BackColor = System.Drawing.Color.Transparent;
            this.pgPurchaseOrder.Location = new System.Drawing.Point(3, 8);
            this.pgPurchaseOrder.Name = "pgPurchaseOrder";
            this.pgPurchaseOrder.RecordCount = 0;
            this.pgPurchaseOrder.Size = new System.Drawing.Size(212, 16);
            this.pgPurchaseOrder.TabIndex = 2;
            this.pgPurchaseOrder.PageIndexChanged += new System.EventHandler(this.pgPurchaseOrder_PageIndexChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSearch.Image = global::ZNLCRM.UI.Properties.Resources.search;
            this.btnSearch.Location = new System.Drawing.Point(314, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "搜索";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(508, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(86, 30);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ucPanel1
            // 
            this.ucPanel1.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel1.Controls.Add(this.ucPanel2);
            this.ucPanel1.Controls.Add(this.panBottom);
            this.ucPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPanel1.Location = new System.Drawing.Point(0, 0);
            this.ucPanel1.Name = "ucPanel1";
            this.ucPanel1.Size = new System.Drawing.Size(963, 449);
            this.ucPanel1.TabIndex = 2;
            // 
            // ucPanel2
            // 
            this.ucPanel2.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel2.Controls.Add(this.dgvPurchaseOrder);
            this.ucPanel2.Controls.Add(this.ucPanel3);
            this.ucPanel2.Controls.Add(this.grpSearch);
            this.ucPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPanel2.Location = new System.Drawing.Point(0, 0);
            this.ucPanel2.Name = "ucPanel2";
            this.ucPanel2.Size = new System.Drawing.Size(963, 402);
            this.ucPanel2.TabIndex = 14;
            // 
            // grpSearch
            // 
            this.grpSearch.BackColor = System.Drawing.Color.Transparent;
            this.grpSearch.Controls.Add(this.btnSearch);
            this.grpSearch.Controls.Add(this.UcLabel1);
            this.grpSearch.Controls.Add(this.txtBillNo);
            this.grpSearch.Controls.Add(this.chkAll);
            this.grpSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpSearch.Location = new System.Drawing.Point(0, 0);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(963, 30);
            this.grpSearch.TabIndex = 3;
            // 
            // UcLabel1
            // 
            this.UcLabel1.AutoSize = true;
            this.UcLabel1.Font = new System.Drawing.Font("宋体", 9F);
            this.UcLabel1.ForeColor = System.Drawing.Color.Gray;
            this.UcLabel1.Location = new System.Drawing.Point(29, 7);
            this.UcLabel1.Name = "UcLabel1";
            this.UcLabel1.Size = new System.Drawing.Size(65, 12);
            this.UcLabel1.TabIndex = 2;
            this.UcLabel1.Text = "采购单号：";
            // 
            // txtBillNo
            // 
            // 
            // 
            // 
            this.txtBillNo.Border.Class = "TextBoxBorder";
            this.txtBillNo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtBillNo.EnterToNextControl = false;
            this.txtBillNo.Location = new System.Drawing.Point(100, 3);
            this.txtBillNo.Name = "txtBillNo";
            this.txtBillNo.Size = new System.Drawing.Size(208, 21);
            this.txtBillNo.TabIndex = 3;
            // 
            // chkAll
            // 
            // 
            // 
            // 
            this.chkAll.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkAll.Location = new System.Drawing.Point(395, 7);
            this.chkAll.Name = "chkAll";
            this.chkAll.Size = new System.Drawing.Size(64, 17);
            this.chkAll.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chkAll.TabIndex = 2;
            this.chkAll.Text = "全选";
            // 
            // panBottom
            // 
            this.panBottom.BackColor = System.Drawing.Color.Transparent;
            this.panBottom.Controls.Add(this.btnCancel);
            this.panBottom.Controls.Add(this.btnOK);
            this.panBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panBottom.Location = new System.Drawing.Point(0, 402);
            this.panBottom.Name = "panBottom";
            this.panBottom.Size = new System.Drawing.Size(963, 47);
            this.panBottom.TabIndex = 13;
            // 
            // btnOK
            // 
            this.btnOK.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnOK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOK.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnOK.Image = ((System.Drawing.Image)(resources.GetObject("btnOK.Image")));
            this.btnOK.Location = new System.Drawing.Point(398, 6);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(86, 30);
            this.btnOK.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "确定(&S)";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // colPOID
            // 
            this.colPOID.DataPropertyName = "POID";
            this.colPOID.HeaderText = "POID";
            this.colPOID.Name = "colPOID";
            this.colPOID.Visible = false;
            // 
            // colPOGuid
            // 
            this.colPOGuid.DataPropertyName = "POGuid";
            this.colPOGuid.HeaderText = "POGuid";
            this.colPOGuid.Name = "colPOGuid";
            this.colPOGuid.Visible = false;
            // 
            // colBillNo
            // 
            this.colBillNo.DataPropertyName = "BillNo";
            this.colBillNo.HeaderText = "单据编号";
            this.colBillNo.Name = "colBillNo";
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
            this.colPODate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colBuyerID
            // 
            this.colBuyerID.DataPropertyName = "BuyerID";
            this.colBuyerID.HeaderText = "采购员ID";
            this.colBuyerID.Name = "colBuyerID";
            this.colBuyerID.Visible = false;
            // 
            // colBuyerName
            // 
            this.colBuyerName.DataPropertyName = "BuyerName";
            this.colBuyerName.HeaderText = "采购员";
            this.colBuyerName.Name = "colBuyerName";
            // 
            // colSupplierName
            // 
            this.colSupplierName.DataPropertyName = "SupplierName";
            this.colSupplierName.HeaderText = "供应商名称";
            this.colSupplierName.Name = "colSupplierName";
            this.colSupplierName.Width = 200;
            // 
            // colContact
            // 
            this.colContact.DataPropertyName = "Contact";
            this.colContact.HeaderText = "联系人";
            this.colContact.Name = "colContact";
            // 
            // colTelephone
            // 
            this.colTelephone.DataPropertyName = "Telephone";
            this.colTelephone.HeaderText = "联系电话";
            this.colTelephone.Name = "colTelephone";
            // 
            // colTaxRate
            // 
            this.colTaxRate.DataPropertyName = "TaxRate";
            this.colTaxRate.HeaderText = "税率";
            this.colTaxRate.Name = "colTaxRate";
            // 
            // colCurrency
            // 
            this.colCurrency.DataPropertyName = "Currency";
            this.colCurrency.HeaderText = "币种";
            this.colCurrency.Name = "colCurrency";
            // 
            // colAmount
            // 
            this.colAmount.DataPropertyName = "Amount";
            this.colAmount.HeaderText = "总金额";
            this.colAmount.Name = "colAmount";
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
            // colAllStatus
            // 
            this.colAllStatus.DataPropertyName = "AllStatus";
            this.colAllStatus.HeaderText = "业务状态";
            this.colAllStatus.Name = "colAllStatus";
            this.colAllStatus.Width = 150;
            // 
            // colApproveStatus
            // 
            this.colApproveStatus.DataPropertyName = "ApproveStatus";
            this.colApproveStatus.HeaderText = "单据状态";
            this.colApproveStatus.Name = "colApproveStatus";
            // 
            // frmSelectPurchaseOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 449);
            this.Controls.Add(this.ucPanel1);
            this.Name = "frmSelectPurchaseOrder";
            this.Text = "采购单选择";
            this.Load += new System.EventHandler(this.frmSelectPurchaseOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseOrder)).EndInit();
            this.ucPanel3.ResumeLayout(false);
            this.ucPanel1.ResumeLayout(false);
            this.ucPanel2.ResumeLayout(false);
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            this.panBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.UcDataGridView dgvPurchaseOrder;
        private Controls.UcPanel ucPanel3;
        private Controls.UcPager pgPurchaseOrder;
        private Controls.UcButton btnSearch;
        private Controls.UcButton btnCancel;
        private Controls.UcPanel ucPanel1;
        private Controls.UcPanel ucPanel2;
        private Controls.UcPanel grpSearch;
        private Controls.UcLabel UcLabel1;
        private Controls.UcTextBox txtBillNo;
        private Controls.UcCheckBox chkAll;
        private Controls.UcPanel panBottom;
        private Controls.UcButton btnOK;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPOID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPOGuid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBillNo;
        private DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn colPODate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBuyerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBuyerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSupplierName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContact;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelephone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTaxRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCurrency;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn colNeedDeliveryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAllStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApproveStatus;
    }
}