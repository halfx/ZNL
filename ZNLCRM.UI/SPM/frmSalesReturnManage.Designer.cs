namespace ZNLCRM.UI.SPM
{
    partial class frmSalesReturnManage
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
            this.ucPanel4 = new ZNLCRM.Controls.UcPanel(this.components);
            this.ucToolStrip1 = new ZNLCRM.Controls.UcToolStrip(this.components);
            this.tsbAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbDel = new System.Windows.Forms.ToolStripButton();
            this.tsbPrint = new System.Windows.Forms.ToolStripButton();
            this.ucPanel2 = new ZNLCRM.Controls.UcPanel(this.components);
            this.ucPanel3 = new ZNLCRM.Controls.UcPanel(this.components);
            this.dgvSalesReturn = new ZNLCRM.Controls.UcDataGridView(this.components);
            this.ucPanel1 = new ZNLCRM.Controls.UcPanel(this.components);
            this.txtSOBillNo = new ZNLCRM.Controls.UcTextBox(this.components);
            this.ucLabel2 = new ZNLCRM.Controls.UcLabel(this.components);
            this.btnSearch = new ZNLCRM.Controls.UcButton(this.components);
            this.txtBillNo = new ZNLCRM.Controls.UcTextBox(this.components);
            this.ucLabel1 = new ZNLCRM.Controls.UcLabel(this.components);
            this.ucPanel5 = new ZNLCRM.Controls.UcPanel(this.components);
            this.pgSalesReturn = new ZNLCRM.Controls.UcPager();
            this.colSRID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSRGuid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOperIn = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colBillNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReturnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSOGuid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSOBillNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOperOrgID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOperOrgName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOperDeptID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOperDeptName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOperEmpID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOperEmpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCurrency = new DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAllStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApproveStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRemark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreatedEmpID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreatedEmpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreatedTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ucPanel4.SuspendLayout();
            this.ucToolStrip1.SuspendLayout();
            this.ucPanel2.SuspendLayout();
            this.ucPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesReturn)).BeginInit();
            this.ucPanel1.SuspendLayout();
            this.ucPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // ucPanel4
            // 
            this.ucPanel4.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel4.Controls.Add(this.ucToolStrip1);
            this.ucPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucPanel4.Location = new System.Drawing.Point(0, 0);
            this.ucPanel4.Name = "ucPanel4";
            this.ucPanel4.Size = new System.Drawing.Size(999, 36);
            this.ucPanel4.TabIndex = 3;
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
            this.tsbPrint});
            this.ucToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.ucToolStrip1.Name = "ucToolStrip1";
            this.ucToolStrip1.Padding = new System.Windows.Forms.Padding(5);
            this.ucToolStrip1.Size = new System.Drawing.Size(999, 36);
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
            this.tsbAdd.ToolTipText = "添加新的销售退货单";
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
            // ucPanel2
            // 
            this.ucPanel2.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel2.Controls.Add(this.ucPanel3);
            this.ucPanel2.Controls.Add(this.ucPanel1);
            this.ucPanel2.Controls.Add(this.ucPanel5);
            this.ucPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPanel2.Location = new System.Drawing.Point(0, 36);
            this.ucPanel2.Name = "ucPanel2";
            this.ucPanel2.Size = new System.Drawing.Size(999, 389);
            this.ucPanel2.TabIndex = 4;
            // 
            // ucPanel3
            // 
            this.ucPanel3.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel3.Controls.Add(this.dgvSalesReturn);
            this.ucPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPanel3.Location = new System.Drawing.Point(0, 31);
            this.ucPanel3.Name = "ucPanel3";
            this.ucPanel3.Padding = new System.Windows.Forms.Padding(5);
            this.ucPanel3.Size = new System.Drawing.Size(999, 329);
            this.ucPanel3.TabIndex = 1;
            // 
            // dgvSalesReturn
            // 
            this.dgvSalesReturn.AllowUserToAddRows = false;
            this.dgvSalesReturn.AllowUserToDeleteRows = false;
            this.dgvSalesReturn.AllowUserToOrderColumns = true;
            this.dgvSalesReturn.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSalesReturn.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSalesReturn.ColumnHeadersHeight = 30;
            this.dgvSalesReturn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSRID,
            this.colSRGuid,
            this.colOperIn,
            this.colBillNo,
            this.colReturnDate,
            this.colCustomerID,
            this.colCustomerName,
            this.colSOGuid,
            this.colSOBillNo,
            this.colOperOrgID,
            this.colOperOrgName,
            this.colOperDeptID,
            this.colOperDeptName,
            this.colOperEmpID,
            this.colOperEmpName,
            this.colCurrency,
            this.colAmount,
            this.colAllStatus,
            this.colApproveStatus,
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
            this.dgvSalesReturn.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSalesReturn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSalesReturn.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvSalesReturn.HighlightSelectedColumnHeaders = false;
            this.dgvSalesReturn.Location = new System.Drawing.Point(5, 5);
            this.dgvSalesReturn.Name = "dgvSalesReturn";
            this.dgvSalesReturn.PaintEnhancedSelection = false;
            this.dgvSalesReturn.ReadOnly = true;
            this.dgvSalesReturn.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvSalesReturn.RowTemplate.Height = 23;
            this.dgvSalesReturn.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSalesReturn.SelectAllSignVisible = false;
            this.dgvSalesReturn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvSalesReturn.Size = new System.Drawing.Size(989, 319);
            this.dgvSalesReturn.TabIndex = 0;
            this.dgvSalesReturn.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSalesReturn_CellDoubleClick);
            this.dgvSalesReturn.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSalesReturn_RowEnter);
            // 
            // ucPanel1
            // 
            this.ucPanel1.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel1.Controls.Add(this.txtSOBillNo);
            this.ucPanel1.Controls.Add(this.ucLabel2);
            this.ucPanel1.Controls.Add(this.btnSearch);
            this.ucPanel1.Controls.Add(this.txtBillNo);
            this.ucPanel1.Controls.Add(this.ucLabel1);
            this.ucPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucPanel1.Location = new System.Drawing.Point(0, 0);
            this.ucPanel1.Name = "ucPanel1";
            this.ucPanel1.Size = new System.Drawing.Size(999, 31);
            this.ucPanel1.TabIndex = 0;
            // 
            // txtSOBillNo
            // 
            // 
            // 
            // 
            this.txtSOBillNo.Border.Class = "TextBoxBorder";
            this.txtSOBillNo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSOBillNo.EnterToNextControl = false;
            this.txtSOBillNo.Location = new System.Drawing.Point(285, 4);
            this.txtSOBillNo.Name = "txtSOBillNo";
            this.txtSOBillNo.Size = new System.Drawing.Size(100, 21);
            this.txtSOBillNo.TabIndex = 6;
            // 
            // ucLabel2
            // 
            this.ucLabel2.AutoSize = true;
            this.ucLabel2.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabel2.ForeColor = System.Drawing.Color.Gray;
            this.ucLabel2.Location = new System.Drawing.Point(214, 10);
            this.ucLabel2.Name = "ucLabel2";
            this.ucLabel2.Size = new System.Drawing.Size(65, 12);
            this.ucLabel2.TabIndex = 5;
            this.ucLabel2.Text = "销售单号：";
            // 
            // btnSearch
            // 
            this.btnSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSearch.Image = global::ZNLCRM.UI.Properties.Resources.search;
            this.btnSearch.Location = new System.Drawing.Point(403, 3);
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
            this.txtBillNo.Location = new System.Drawing.Point(108, 4);
            this.txtBillNo.Name = "txtBillNo";
            this.txtBillNo.Size = new System.Drawing.Size(100, 21);
            this.txtBillNo.TabIndex = 2;
            // 
            // ucLabel1
            // 
            this.ucLabel1.AutoSize = true;
            this.ucLabel1.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabel1.ForeColor = System.Drawing.Color.Gray;
            this.ucLabel1.Location = new System.Drawing.Point(12, 10);
            this.ucLabel1.Name = "ucLabel1";
            this.ucLabel1.Size = new System.Drawing.Size(89, 12);
            this.ucLabel1.TabIndex = 0;
            this.ucLabel1.Text = "销售退货单号：";
            // 
            // ucPanel5
            // 
            this.ucPanel5.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel5.Controls.Add(this.pgSalesReturn);
            this.ucPanel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucPanel5.Location = new System.Drawing.Point(0, 360);
            this.ucPanel5.Name = "ucPanel5";
            this.ucPanel5.Size = new System.Drawing.Size(999, 29);
            this.ucPanel5.TabIndex = 2;
            // 
            // pgSalesReturn
            // 
            this.pgSalesReturn.BackColor = System.Drawing.Color.Transparent;
            this.pgSalesReturn.Location = new System.Drawing.Point(14, 6);
            this.pgSalesReturn.Name = "pgSalesReturn";
            this.pgSalesReturn.RecordCount = 0;
            this.pgSalesReturn.Size = new System.Drawing.Size(346, 15);
            this.pgSalesReturn.TabIndex = 0;
            this.pgSalesReturn.PageIndexChanged += new System.EventHandler(this.pgSalesReturn_PageIndexChanged);
            // 
            // colSRID
            // 
            this.colSRID.DataPropertyName = "SRID";
            this.colSRID.HeaderText = "SRID";
            this.colSRID.Name = "colSRID";
            this.colSRID.ReadOnly = true;
            this.colSRID.Visible = false;
            // 
            // colSRGuid
            // 
            this.colSRGuid.DataPropertyName = "SRGuid";
            this.colSRGuid.HeaderText = "SRGuid";
            this.colSRGuid.Name = "colSRGuid";
            this.colSRGuid.ReadOnly = true;
            this.colSRGuid.Visible = false;
            // 
            // colOperIn
            // 
            this.colOperIn.HeaderText = "入库";
            this.colOperIn.Name = "colOperIn";
            this.colOperIn.ReadOnly = true;
            this.colOperIn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colOperIn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colOperIn.Text = "入库";
            this.colOperIn.Width = 80;
            // 
            // colBillNo
            // 
            this.colBillNo.DataPropertyName = "BillNo";
            this.colBillNo.HeaderText = "单据编号";
            this.colBillNo.Name = "colBillNo";
            this.colBillNo.ReadOnly = true;
            this.colBillNo.Width = 80;
            // 
            // colReturnDate
            // 
            this.colReturnDate.DataPropertyName = "ReturnDate";
            this.colReturnDate.HeaderText = "退货日期";
            this.colReturnDate.Name = "colReturnDate";
            this.colReturnDate.ReadOnly = true;
            this.colReturnDate.Width = 80;
            // 
            // colCustomerID
            // 
            this.colCustomerID.HeaderText = "客户ID";
            this.colCustomerID.Name = "colCustomerID";
            this.colCustomerID.ReadOnly = true;
            this.colCustomerID.Visible = false;
            // 
            // colCustomerName
            // 
            this.colCustomerName.DataPropertyName = "CustomerName";
            this.colCustomerName.HeaderText = "客户名称";
            this.colCustomerName.Name = "colCustomerName";
            this.colCustomerName.ReadOnly = true;
            this.colCustomerName.Width = 150;
            // 
            // colSOGuid
            // 
            this.colSOGuid.HeaderText = "SOGuid";
            this.colSOGuid.Name = "colSOGuid";
            this.colSOGuid.ReadOnly = true;
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
            this.colCurrency.Width = 60;
            // 
            // colAmount
            // 
            this.colAmount.DataPropertyName = "Amount";
            this.colAmount.HeaderText = " 退货金额";
            this.colAmount.Name = "colAmount";
            this.colAmount.ReadOnly = true;
            this.colAmount.Width = 80;
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
            // frmSalesReturnManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 425);
            this.Controls.Add(this.ucPanel2);
            this.Controls.Add(this.ucPanel4);
            this.Name = "frmSalesReturnManage";
            this.Text = "销售退货管理";
            this.Load += new System.EventHandler(this.frmSalesReturnManage_Load);
            this.ucPanel4.ResumeLayout(false);
            this.ucPanel4.PerformLayout();
            this.ucToolStrip1.ResumeLayout(false);
            this.ucToolStrip1.PerformLayout();
            this.ucPanel2.ResumeLayout(false);
            this.ucPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesReturn)).EndInit();
            this.ucPanel1.ResumeLayout(false);
            this.ucPanel1.PerformLayout();
            this.ucPanel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.UcPanel ucPanel4;
        private Controls.UcToolStrip ucToolStrip1;
        private System.Windows.Forms.ToolStripButton tsbAdd;
        private System.Windows.Forms.ToolStripButton tsbEdit;
        private System.Windows.Forms.ToolStripButton tsbDel;
        private System.Windows.Forms.ToolStripButton tsbPrint;
        private Controls.UcPanel ucPanel2;
        private Controls.UcPanel ucPanel3;
        private Controls.UcDataGridView dgvSalesReturn;
        private Controls.UcPanel ucPanel1;
        private Controls.UcButton btnSearch;
        private Controls.UcTextBox txtBillNo;
        private Controls.UcLabel ucLabel1;
        private Controls.UcPanel ucPanel5;
        private Controls.UcPager pgSalesReturn;
        private Controls.UcTextBox txtSOBillNo;
        private Controls.UcLabel ucLabel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSRID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSRGuid;
        private System.Windows.Forms.DataGridViewLinkColumn colOperIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBillNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReturnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSOGuid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSOBillNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOperOrgID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOperOrgName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOperDeptID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOperDeptName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOperEmpID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOperEmpName;
        private DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn colCurrency;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAllStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApproveStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRemark;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreatedEmpID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreatedEmpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreatedTime;
    }
}