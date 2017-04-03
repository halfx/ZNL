namespace ZNLCRM.UI.SPM
{
    partial class frmSelectSalesReturn
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelectSalesReturn));
            this.dgvSalesReturn = new ZNLCRM.Controls.UcDataGridView(this.components);
            this.ucPanel3 = new ZNLCRM.Controls.UcPanel(this.components);
            this.pgSalesReturn = new ZNLCRM.Controls.UcPager();
            this.grpSearch = new ZNLCRM.Controls.UcPanel(this.components);
            this.chkAll = new ZNLCRM.Controls.UcCheckBox(this.components);
            this.btnSearch = new ZNLCRM.Controls.UcButton(this.components);
            this.UcLabel1 = new ZNLCRM.Controls.UcLabel(this.components);
            this.txtBillNo = new ZNLCRM.Controls.UcTextBox(this.components);
            this.panBottom = new ZNLCRM.Controls.UcPanel(this.components);
            this.btnCancel = new ZNLCRM.Controls.UcButton(this.components);
            this.btnOK = new ZNLCRM.Controls.UcButton(this.components);
            this.colSRGuid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBillNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReturnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOperEmpID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOperEmpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCurrency = new DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApproveStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAllStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesReturn)).BeginInit();
            this.ucPanel3.SuspendLayout();
            this.grpSearch.SuspendLayout();
            this.panBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSalesReturn
            // 
            this.dgvSalesReturn.AllowUserToAddRows = false;
            this.dgvSalesReturn.AllowUserToDeleteRows = false;
            this.dgvSalesReturn.AllowUserToOrderColumns = true;
            this.dgvSalesReturn.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSalesReturn.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvSalesReturn.ColumnHeadersHeight = 30;
            this.dgvSalesReturn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSRGuid,
            this.colBillNo,
            this.colReturnDate,
            this.colOperEmpID,
            this.colOperEmpName,
            this.colCustomerID,
            this.colCustomerName,
            this.colContact,
            this.colCurrency,
            this.colAmount,
            this.colApproveStatus,
            this.colAllStatus});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSalesReturn.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvSalesReturn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSalesReturn.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvSalesReturn.HighlightSelectedColumnHeaders = false;
            this.dgvSalesReturn.Location = new System.Drawing.Point(0, 30);
            this.dgvSalesReturn.Name = "dgvSalesReturn";
            this.dgvSalesReturn.PaintEnhancedSelection = false;
            this.dgvSalesReturn.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSalesReturn.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvSalesReturn.RowTemplate.Height = 23;
            this.dgvSalesReturn.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSalesReturn.SelectAllSignVisible = false;
            this.dgvSalesReturn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvSalesReturn.Size = new System.Drawing.Size(1023, 343);
            this.dgvSalesReturn.TabIndex = 21;
            // 
            // ucPanel3
            // 
            this.ucPanel3.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel3.Controls.Add(this.pgSalesReturn);
            this.ucPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucPanel3.Location = new System.Drawing.Point(0, 373);
            this.ucPanel3.Name = "ucPanel3";
            this.ucPanel3.Size = new System.Drawing.Size(1023, 33);
            this.ucPanel3.TabIndex = 19;
            // 
            // pgSalesReturn
            // 
            this.pgSalesReturn.BackColor = System.Drawing.Color.Transparent;
            this.pgSalesReturn.Location = new System.Drawing.Point(13, 6);
            this.pgSalesReturn.Name = "pgSalesReturn";
            this.pgSalesReturn.RecordCount = 0;
            this.pgSalesReturn.Size = new System.Drawing.Size(212, 16);
            this.pgSalesReturn.TabIndex = 2;
            this.pgSalesReturn.PageIndexChanged += new System.EventHandler(this.pgSalesReturn_PageIndexChanged);
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
            this.grpSearch.Size = new System.Drawing.Size(1023, 30);
            this.grpSearch.TabIndex = 18;
            // 
            // chkAll
            // 
            // 
            // 
            // 
            this.chkAll.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkAll.Location = new System.Drawing.Point(333, 4);
            this.chkAll.Name = "chkAll";
            this.chkAll.Size = new System.Drawing.Size(63, 23);
            this.chkAll.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chkAll.TabIndex = 5;
            this.chkAll.Text = "全选";
            // 
            // btnSearch
            // 
            this.btnSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSearch.Image = global::ZNLCRM.UI.Properties.Resources.search;
            this.btnSearch.Location = new System.Drawing.Point(235, 4);
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
            this.UcLabel1.Location = new System.Drawing.Point(29, 9);
            this.UcLabel1.Name = "UcLabel1";
            this.UcLabel1.Size = new System.Drawing.Size(89, 12);
            this.UcLabel1.TabIndex = 2;
            this.UcLabel1.Text = "销售退货单号：";
            // 
            // txtBillNo
            // 
            // 
            // 
            // 
            this.txtBillNo.Border.Class = "TextBoxBorder";
            this.txtBillNo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtBillNo.EnterToNextControl = false;
            this.txtBillNo.Location = new System.Drawing.Point(125, 4);
            this.txtBillNo.Name = "txtBillNo";
            this.txtBillNo.Size = new System.Drawing.Size(100, 21);
            this.txtBillNo.TabIndex = 3;
            // 
            // panBottom
            // 
            this.panBottom.BackColor = System.Drawing.Color.Transparent;
            this.panBottom.Controls.Add(this.btnCancel);
            this.panBottom.Controls.Add(this.btnOK);
            this.panBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panBottom.Location = new System.Drawing.Point(0, 406);
            this.panBottom.Name = "panBottom";
            this.panBottom.Size = new System.Drawing.Size(1023, 47);
            this.panBottom.TabIndex = 20;
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(538, 6);
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
            this.btnOK.Location = new System.Drawing.Point(428, 6);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(86, 30);
            this.btnOK.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "确定(&S)";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // colSRGuid
            // 
            this.colSRGuid.DataPropertyName = "SRGuid";
            this.colSRGuid.HeaderText = "SRGuid";
            this.colSRGuid.Name = "colSRGuid";
            this.colSRGuid.Visible = false;
            // 
            // colBillNo
            // 
            this.colBillNo.DataPropertyName = "BillNo";
            this.colBillNo.HeaderText = "单据编号";
            this.colBillNo.Name = "colBillNo";
            // 
            // colReturnDate
            // 
            this.colReturnDate.DataPropertyName = "ReturnDate";
            this.colReturnDate.HeaderText = "退货日期";
            this.colReturnDate.Name = "colReturnDate";
            this.colReturnDate.Width = 80;
            // 
            // colOperEmpID
            // 
            this.colOperEmpID.DataPropertyName = "OperEmpID";
            this.colOperEmpID.HeaderText = "归属人员ID";
            this.colOperEmpID.Name = "colOperEmpID";
            this.colOperEmpID.Visible = false;
            // 
            // colOperEmpName
            // 
            this.colOperEmpName.DataPropertyName = "OperEmpName";
            this.colOperEmpName.HeaderText = "归属人员";
            this.colOperEmpName.Name = "colOperEmpName";
            this.colOperEmpName.Width = 80;
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
            this.colCurrency.IntegralHeight = false;
            this.colCurrency.ItemHeight = 16;
            this.colCurrency.Name = "colCurrency";
            this.colCurrency.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colCurrency.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.colCurrency.Width = 60;
            // 
            // colAmount
            // 
            this.colAmount.DataPropertyName = "Amount";
            this.colAmount.HeaderText = "总金额";
            this.colAmount.Name = "colAmount";
            this.colAmount.Width = 80;
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
            // frmSelectSalesReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 453);
            this.Controls.Add(this.dgvSalesReturn);
            this.Controls.Add(this.ucPanel3);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.panBottom);
            this.Name = "frmSelectSalesReturn";
            this.Text = "选择销售退货单";
            this.Load += new System.EventHandler(this.frmSelectSalesReturn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesReturn)).EndInit();
            this.ucPanel3.ResumeLayout(false);
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            this.panBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.UcDataGridView dgvSalesReturn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSRGuid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBillNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReturnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOperEmpID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOperEmpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContact;
        private DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn colCurrency;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApproveStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAllStatus;
        private Controls.UcPanel ucPanel3;
        private Controls.UcPager pgSalesReturn;
        private Controls.UcPanel grpSearch;
        private Controls.UcCheckBox chkAll;
        private Controls.UcButton btnSearch;
        private Controls.UcLabel UcLabel1;
        private Controls.UcTextBox txtBillNo;
        private Controls.UcPanel panBottom;
        private Controls.UcButton btnCancel;
        private Controls.UcButton btnOK;
    }
}