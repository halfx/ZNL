namespace ZNLCRM.UI.PPM
{
    partial class frmSelectPurchaseReturn
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelectPurchaseReturn));
            this.dgvPurchaseReturn = new ZNLCRM.Controls.UcDataGridView(this.components);
            this.colPRGuid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBillNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReturnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOperEmpID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOperEmpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSupplierID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSupplierName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCurrency = new DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApproveStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAllStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ucPanel3 = new ZNLCRM.Controls.UcPanel(this.components);
            this.pgPurchaseReturn = new ZNLCRM.Controls.UcPager();
            this.grpSearch = new ZNLCRM.Controls.UcPanel(this.components);
            this.chkAll = new ZNLCRM.Controls.UcCheckBox(this.components);
            this.btnSearch = new ZNLCRM.Controls.UcButton(this.components);
            this.UcLabel1 = new ZNLCRM.Controls.UcLabel(this.components);
            this.txtBillNo = new ZNLCRM.Controls.UcTextBox(this.components);
            this.panBottom = new ZNLCRM.Controls.UcPanel(this.components);
            this.btnCancel = new ZNLCRM.Controls.UcButton(this.components);
            this.btnOK = new ZNLCRM.Controls.UcButton(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseReturn)).BeginInit();
            this.ucPanel3.SuspendLayout();
            this.grpSearch.SuspendLayout();
            this.panBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPurchaseReturn
            // 
            this.dgvPurchaseReturn.AllowUserToAddRows = false;
            this.dgvPurchaseReturn.AllowUserToDeleteRows = false;
            this.dgvPurchaseReturn.AllowUserToOrderColumns = true;
            this.dgvPurchaseReturn.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPurchaseReturn.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPurchaseReturn.ColumnHeadersHeight = 30;
            this.dgvPurchaseReturn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPRGuid,
            this.colBillNo,
            this.colReturnDate,
            this.colOperEmpID,
            this.colOperEmpName,
            this.colSupplierID,
            this.colSupplierName,
            this.colContact,
            this.colCurrency,
            this.colAmount,
            this.colApproveStatus,
            this.colAllStatus});
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
            this.dgvPurchaseReturn.Location = new System.Drawing.Point(0, 30);
            this.dgvPurchaseReturn.Name = "dgvPurchaseReturn";
            this.dgvPurchaseReturn.PaintEnhancedSelection = false;
            this.dgvPurchaseReturn.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPurchaseReturn.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPurchaseReturn.RowTemplate.Height = 23;
            this.dgvPurchaseReturn.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPurchaseReturn.SelectAllSignVisible = false;
            this.dgvPurchaseReturn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvPurchaseReturn.Size = new System.Drawing.Size(900, 362);
            this.dgvPurchaseReturn.TabIndex = 25;
            // 
            // colPRGuid
            // 
            this.colPRGuid.DataPropertyName = "PRGuid";
            this.colPRGuid.HeaderText = "PRGuid";
            this.colPRGuid.Name = "colPRGuid";
            this.colPRGuid.Visible = false;
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
            // colSupplierID
            // 
            this.colSupplierID.DataPropertyName = "SupplierID";
            this.colSupplierID.HeaderText = "供应商ID";
            this.colSupplierID.Name = "colSupplierID";
            this.colSupplierID.Visible = false;
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
            // ucPanel3
            // 
            this.ucPanel3.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel3.Controls.Add(this.pgPurchaseReturn);
            this.ucPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucPanel3.Location = new System.Drawing.Point(0, 392);
            this.ucPanel3.Name = "ucPanel3";
            this.ucPanel3.Size = new System.Drawing.Size(900, 33);
            this.ucPanel3.TabIndex = 23;
            // 
            // pgPurchaseReturn
            // 
            this.pgPurchaseReturn.BackColor = System.Drawing.Color.Transparent;
            this.pgPurchaseReturn.Location = new System.Drawing.Point(13, 6);
            this.pgPurchaseReturn.Name = "pgPurchaseReturn";
            this.pgPurchaseReturn.RecordCount = 0;
            this.pgPurchaseReturn.Size = new System.Drawing.Size(212, 16);
            this.pgPurchaseReturn.TabIndex = 2;
            this.pgPurchaseReturn.PageIndexChanged += new System.EventHandler(this.pgPurchaseReturn_PageIndexChanged);
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
            this.grpSearch.Size = new System.Drawing.Size(900, 30);
            this.grpSearch.TabIndex = 22;
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
            this.UcLabel1.Text = "采购退货单号：";
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
            this.panBottom.Location = new System.Drawing.Point(0, 425);
            this.panBottom.Name = "panBottom";
            this.panBottom.Size = new System.Drawing.Size(900, 47);
            this.panBottom.TabIndex = 24;
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(477, 6);
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
            this.btnOK.Location = new System.Drawing.Point(367, 6);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(86, 30);
            this.btnOK.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "确定(&S)";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // frmSelectPurchaseReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 472);
            this.Controls.Add(this.dgvPurchaseReturn);
            this.Controls.Add(this.ucPanel3);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.panBottom);
            this.Name = "frmSelectPurchaseReturn";
            this.Text = "选择采购退货单";
            this.Load += new System.EventHandler(this.frmSelectPurchaseReturn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseReturn)).EndInit();
            this.ucPanel3.ResumeLayout(false);
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            this.panBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.UcDataGridView dgvPurchaseReturn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPRGuid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBillNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReturnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOperEmpID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOperEmpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSupplierID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSupplierName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContact;
        private DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn colCurrency;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApproveStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAllStatus;
        private Controls.UcPanel ucPanel3;
        private Controls.UcPager pgPurchaseReturn;
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