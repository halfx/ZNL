namespace ZNLCRM.UI.SPM
{
    partial class frmSelectSalesOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelectSalesOrder));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ucPanel3 = new ZNLCRM.Controls.UcPanel(this.components);
            this.pgSalesOrder = new ZNLCRM.Controls.UcPager();
            this.grpSearch = new ZNLCRM.Controls.UcPanel(this.components);
            this.btnSearch = new ZNLCRM.Controls.UcButton(this.components);
            this.UcLabel1 = new ZNLCRM.Controls.UcLabel(this.components);
            this.txtBillNo = new ZNLCRM.Controls.UcTextBox(this.components);
            this.panBottom = new ZNLCRM.Controls.UcPanel(this.components);
            this.btnCancel = new ZNLCRM.Controls.UcButton(this.components);
            this.btnOK = new ZNLCRM.Controls.UcButton(this.components);
            this.dgvSalesOrder = new ZNLCRM.Controls.UcDataGridView(this.components);
            this.colSOGuid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBillNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBillType = new DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn();
            this.colSODate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBuyerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSalerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCurrency = new DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn();
            this.colTaxRate = new DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTaxAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCommissionAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNeedDeliveryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNeedRecAmtDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApproveStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAllStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkAll = new ZNLCRM.Controls.UcCheckBox(this.components);
            this.ucPanel3.SuspendLayout();
            this.grpSearch.SuspendLayout();
            this.panBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // ucPanel3
            // 
            this.ucPanel3.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel3.Controls.Add(this.pgSalesOrder);
            this.ucPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucPanel3.Location = new System.Drawing.Point(0, 482);
            this.ucPanel3.Name = "ucPanel3";
            this.ucPanel3.Size = new System.Drawing.Size(1048, 33);
            this.ucPanel3.TabIndex = 15;
            // 
            // pgSalesOrder
            // 
            this.pgSalesOrder.BackColor = System.Drawing.Color.Transparent;
            this.pgSalesOrder.Location = new System.Drawing.Point(3, 8);
            this.pgSalesOrder.Name = "pgSalesOrder";
            this.pgSalesOrder.RecordCount = 0;
            this.pgSalesOrder.Size = new System.Drawing.Size(212, 16);
            this.pgSalesOrder.TabIndex = 2;
            this.pgSalesOrder.PageIndexChanged += new System.EventHandler(this.pgSalesOrder_PageIndexChanged);
            // 
            // grpSearch
            // 
            this.grpSearch.BackColor = System.Drawing.Color.Transparent;
            this.grpSearch.Controls.Add(this.chkAll);
            this.grpSearch.Controls.Add(this.btnSearch);
            this.grpSearch.Controls.Add(this.UcLabel1);
            this.grpSearch.Controls.Add(this.txtBillNo);
            this.grpSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpSearch.Location = new System.Drawing.Point(0, 0);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(1048, 30);
            this.grpSearch.TabIndex = 14;
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
            // UcLabel1
            // 
            this.UcLabel1.AutoSize = true;
            this.UcLabel1.Font = new System.Drawing.Font("宋体", 9F);
            this.UcLabel1.ForeColor = System.Drawing.Color.Gray;
            this.UcLabel1.Location = new System.Drawing.Point(29, 7);
            this.UcLabel1.Name = "UcLabel1";
            this.UcLabel1.Size = new System.Drawing.Size(65, 12);
            this.UcLabel1.TabIndex = 2;
            this.UcLabel1.Text = "销售单号：";
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
            // panBottom
            // 
            this.panBottom.BackColor = System.Drawing.Color.Transparent;
            this.panBottom.Controls.Add(this.btnCancel);
            this.panBottom.Controls.Add(this.btnOK);
            this.panBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panBottom.Location = new System.Drawing.Point(0, 515);
            this.panBottom.Name = "panBottom";
            this.panBottom.Size = new System.Drawing.Size(1048, 47);
            this.panBottom.TabIndex = 16;
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(551, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(86, 30);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnOK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOK.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnOK.Image = ((System.Drawing.Image)(resources.GetObject("btnOK.Image")));
            this.btnOK.Location = new System.Drawing.Point(441, 6);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(86, 30);
            this.btnOK.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "确定(&S)";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // dgvSalesOrder
            // 
            this.dgvSalesOrder.AllowUserToAddRows = false;
            this.dgvSalesOrder.AllowUserToDeleteRows = false;
            this.dgvSalesOrder.AllowUserToOrderColumns = true;
            this.dgvSalesOrder.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSalesOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSalesOrder.ColumnHeadersHeight = 30;
            this.dgvSalesOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSOGuid,
            this.colBillNo,
            this.colBillType,
            this.colSODate,
            this.colBuyerID,
            this.colSalerName,
            this.colCustomerID,
            this.colCustomerName,
            this.colContact,
            this.colCurrency,
            this.colTaxRate,
            this.colAmount,
            this.colTaxAmount,
            this.colCommissionAmount,
            this.colNeedDeliveryDate,
            this.colNeedRecAmtDate,
            this.colApproveStatus,
            this.colAllStatus});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSalesOrder.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSalesOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSalesOrder.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvSalesOrder.HighlightSelectedColumnHeaders = false;
            this.dgvSalesOrder.Location = new System.Drawing.Point(0, 30);
            this.dgvSalesOrder.Name = "dgvSalesOrder";
            this.dgvSalesOrder.PaintEnhancedSelection = false;
            this.dgvSalesOrder.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSalesOrder.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSalesOrder.RowTemplate.Height = 23;
            this.dgvSalesOrder.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSalesOrder.SelectAllSignVisible = false;
            this.dgvSalesOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvSalesOrder.Size = new System.Drawing.Size(1048, 452);
            this.dgvSalesOrder.TabIndex = 17;
            // 
            // colSOGuid
            // 
            this.colSOGuid.DataPropertyName = "SOGuid";
            this.colSOGuid.HeaderText = "SOGuid";
            this.colSOGuid.Name = "colSOGuid";
            this.colSOGuid.Visible = false;
            // 
            // colBillNo
            // 
            this.colBillNo.DataPropertyName = "BillNo";
            this.colBillNo.HeaderText = "单据编号";
            this.colBillNo.Name = "colBillNo";
            // 
            // colBillType
            // 
            this.colBillType.DataPropertyName = "BillType";
            this.colBillType.DropDownHeight = 106;
            this.colBillType.DropDownWidth = 121;
            this.colBillType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colBillType.HeaderText = "单据类型";
            this.colBillType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.colBillType.ItemHeight = 16;
            this.colBillType.Name = "colBillType";
            this.colBillType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colBillType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.colBillType.Width = 80;
            // 
            // colSODate
            // 
            this.colSODate.DataPropertyName = "SODate";
            this.colSODate.HeaderText = "销售日期";
            this.colSODate.Name = "colSODate";
            this.colSODate.Width = 80;
            // 
            // colBuyerID
            // 
            this.colBuyerID.DataPropertyName = "SalerID";
            this.colBuyerID.HeaderText = "销售员ID";
            this.colBuyerID.Name = "colBuyerID";
            this.colBuyerID.Visible = false;
            // 
            // colSalerName
            // 
            this.colSalerName.DataPropertyName = "SalerName";
            this.colSalerName.HeaderText = "销售员";
            this.colSalerName.Name = "colSalerName";
            this.colSalerName.Width = 80;
            // 
            // colCustomerID
            // 
            this.colCustomerID.DataPropertyName = "CustomerID";
            this.colCustomerID.HeaderText = "客户ID";
            this.colCustomerID.Name = "colCustomerID";
            this.colCustomerID.Visible = false;
            // 
            // colCustomerName
            // 
            this.colCustomerName.DataPropertyName = "CustomerName";
            this.colCustomerName.HeaderText = "客户名称";
            this.colCustomerName.Name = "colCustomerName";
            this.colCustomerName.Width = 200;
            // 
            // colContact
            // 
            this.colContact.DataPropertyName = "Contact";
            this.colContact.HeaderText = "联系人";
            this.colContact.Name = "colContact";
            this.colContact.Width = 80;
            // 
            // colCurrency
            // 
            this.colCurrency.DataPropertyName = "Currency";
            this.colCurrency.DropDownHeight = 106;
            this.colCurrency.DropDownWidth = 121;
            this.colCurrency.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colCurrency.HeaderText = "币种";
            this.colCurrency.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.colCurrency.ItemHeight = 16;
            this.colCurrency.Name = "colCurrency";
            this.colCurrency.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colCurrency.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.colCurrency.Width = 60;
            // 
            // colTaxRate
            // 
            this.colTaxRate.DataPropertyName = "TaxRate";
            this.colTaxRate.DropDownHeight = 106;
            this.colTaxRate.DropDownWidth = 121;
            this.colTaxRate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colTaxRate.HeaderText = "税率";
            this.colTaxRate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.colTaxRate.ItemHeight = 16;
            this.colTaxRate.Name = "colTaxRate";
            this.colTaxRate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colTaxRate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.colTaxRate.Width = 60;
            // 
            // colAmount
            // 
            this.colAmount.DataPropertyName = "Amount";
            this.colAmount.HeaderText = "总金额";
            this.colAmount.Name = "colAmount";
            this.colAmount.Width = 80;
            // 
            // colTaxAmount
            // 
            this.colTaxAmount.DataPropertyName = "TaxAmount";
            this.colTaxAmount.HeaderText = "税金金额";
            this.colTaxAmount.Name = "colTaxAmount";
            this.colTaxAmount.Width = 80;
            // 
            // colCommissionAmount
            // 
            this.colCommissionAmount.DataPropertyName = "CommissionAmount";
            this.colCommissionAmount.HeaderText = "佣金金额";
            this.colCommissionAmount.Name = "colCommissionAmount";
            this.colCommissionAmount.Width = 80;
            // 
            // colNeedDeliveryDate
            // 
            this.colNeedDeliveryDate.DataPropertyName = "NeedDeliveryDate";
            this.colNeedDeliveryDate.HeaderText = "应发货日期";
            this.colNeedDeliveryDate.Name = "colNeedDeliveryDate";
            this.colNeedDeliveryDate.Width = 80;
            // 
            // colNeedRecAmtDate
            // 
            this.colNeedRecAmtDate.DataPropertyName = "NeedRecAmtDate";
            this.colNeedRecAmtDate.HeaderText = "应收款日期";
            this.colNeedRecAmtDate.Name = "colNeedRecAmtDate";
            this.colNeedRecAmtDate.Width = 80;
            // 
            // colApproveStatus
            // 
            this.colApproveStatus.DataPropertyName = "ApproveStatus";
            this.colApproveStatus.HeaderText = "单据状态";
            this.colApproveStatus.Name = "colApproveStatus";
            this.colApproveStatus.Width = 80;
            // 
            // colAllStatus
            // 
            this.colAllStatus.DataPropertyName = "AllStatus";
            this.colAllStatus.HeaderText = "业务状态";
            this.colAllStatus.Name = "colAllStatus";
            this.colAllStatus.Width = 200;
            // 
            // chkAll
            // 
            // 
            // 
            // 
            this.chkAll.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkAll.Location = new System.Drawing.Point(412, 4);
            this.chkAll.Name = "chkAll";
            this.chkAll.Size = new System.Drawing.Size(63, 23);
            this.chkAll.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chkAll.TabIndex = 5;
            this.chkAll.Text = "全选";
            // 
            // frmSelectSalesOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 562);
            this.Controls.Add(this.dgvSalesOrder);
            this.Controls.Add(this.ucPanel3);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.panBottom);
            this.Name = "frmSelectSalesOrder";
            this.Text = "选择销售单";
            this.Load += new System.EventHandler(this.frmSelectSalesOrder_Load);
            this.ucPanel3.ResumeLayout(false);
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            this.panBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.UcPanel ucPanel3;
        private Controls.UcPager pgSalesOrder;
        private Controls.UcPanel grpSearch;
        private Controls.UcButton btnSearch;
        private Controls.UcLabel UcLabel1;
        private Controls.UcTextBox txtBillNo;
        private Controls.UcPanel panBottom;
        private Controls.UcButton btnCancel;
        private Controls.UcButton btnOK;
        private Controls.UcDataGridView dgvSalesOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSOGuid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBillNo;
        private DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn colBillType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSODate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBuyerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSalerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContact;
        private DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn colCurrency;
        private DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn colTaxRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTaxAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCommissionAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNeedDeliveryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNeedRecAmtDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApproveStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAllStatus;
        private Controls.UcCheckBox chkAll;
    }
}