namespace ZNLCRM.UI.CRM
{
    partial class frmSelectSupplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelectSupplier));
            this.dgvCompany = new ZNLCRM.Controls.UcDataGridView(this.components);
            this.colCompanyID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCompanyGuID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCompanyCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAttachEmpID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAttachEmpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWebSite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContactName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ucPanel2 = new ZNLCRM.Controls.UcPanel(this.components);
            this.ucPanel1 = new ZNLCRM.Controls.UcPanel(this.components);
            this.ucPanel3 = new ZNLCRM.Controls.UcPanel(this.components);
            this.pgCompany = new ZNLCRM.Controls.UcPager();
            this.grpSearch = new ZNLCRM.Controls.UcPanel(this.components);
            this.chkAll = new ZNLCRM.Controls.UcCheckBox(this.components);
            this.txtCompanyCode = new ZNLCRM.Controls.UcTextBox(this.components);
            this.ucLabel1 = new ZNLCRM.Controls.UcLabel(this.components);
            this.btnSearch = new ZNLCRM.Controls.UcButton(this.components);
            this.ucLabel2 = new ZNLCRM.Controls.UcLabel(this.components);
            this.txtCompanyName = new ZNLCRM.Controls.UcTextBox(this.components);
            this.btnCancel = new ZNLCRM.Controls.UcButton(this.components);
            this.panBottom = new ZNLCRM.Controls.UcPanel(this.components);
            this.btnOk = new ZNLCRM.Controls.UcButton(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompany)).BeginInit();
            this.ucPanel2.SuspendLayout();
            this.ucPanel1.SuspendLayout();
            this.ucPanel3.SuspendLayout();
            this.grpSearch.SuspendLayout();
            this.panBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCompany
            // 
            this.dgvCompany.AllowUserToAddRows = false;
            this.dgvCompany.AllowUserToDeleteRows = false;
            this.dgvCompany.AllowUserToOrderColumns = true;
            this.dgvCompany.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCompany.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCompany.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompany.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCompanyID,
            this.colCompanyGuID,
            this.colCompanyCode,
            this.colCompanyName,
            this.colAttachEmpID,
            this.colAttachEmpName,
            this.colWebSite,
            this.colContactName,
            this.colTelephone,
            this.colEmail});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCompany.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCompany.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCompany.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvCompany.HighlightSelectedColumnHeaders = false;
            this.dgvCompany.Location = new System.Drawing.Point(5, 5);
            this.dgvCompany.Name = "dgvCompany";
            this.dgvCompany.PaintEnhancedSelection = false;
            this.dgvCompany.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCompany.RowTemplate.Height = 23;
            this.dgvCompany.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCompany.SelectAllSignVisible = false;
            this.dgvCompany.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvCompany.Size = new System.Drawing.Size(838, 354);
            this.dgvCompany.TabIndex = 0;
            // 
            // colCompanyID
            // 
            this.colCompanyID.DataPropertyName = "CompanyID";
            this.colCompanyID.HeaderText = "公司ID";
            this.colCompanyID.Name = "colCompanyID";
            this.colCompanyID.Visible = false;
            // 
            // colCompanyGuID
            // 
            this.colCompanyGuID.DataPropertyName = "CompanyGuID";
            this.colCompanyGuID.HeaderText = "公司GUID";
            this.colCompanyGuID.Name = "colCompanyGuID";
            this.colCompanyGuID.Visible = false;
            // 
            // colCompanyCode
            // 
            this.colCompanyCode.DataPropertyName = "CompanyCode";
            this.colCompanyCode.HeaderText = "公司编码";
            this.colCompanyCode.Name = "colCompanyCode";
            // 
            // colCompanyName
            // 
            this.colCompanyName.DataPropertyName = "CompanyName";
            this.colCompanyName.HeaderText = "公司名称";
            this.colCompanyName.Name = "colCompanyName";
            // 
            // colAttachEmpID
            // 
            this.colAttachEmpID.DataPropertyName = "AttachEmpID";
            this.colAttachEmpID.HeaderText = "归属人ID";
            this.colAttachEmpID.Name = "colAttachEmpID";
            this.colAttachEmpID.Visible = false;
            // 
            // colAttachEmpName
            // 
            this.colAttachEmpName.DataPropertyName = "AttachEmpName";
            this.colAttachEmpName.HeaderText = "归属人";
            this.colAttachEmpName.Name = "colAttachEmpName";
            // 
            // colWebSite
            // 
            this.colWebSite.DataPropertyName = "WebSite";
            this.colWebSite.HeaderText = "公司网址";
            this.colWebSite.Name = "colWebSite";
            this.colWebSite.ReadOnly = true;
            // 
            // colContactName
            // 
            this.colContactName.DataPropertyName = "ContactName";
            this.colContactName.HeaderText = "联系人";
            this.colContactName.Name = "colContactName";
            this.colContactName.ReadOnly = true;
            // 
            // colTelephone
            // 
            this.colTelephone.DataPropertyName = "Telephone";
            this.colTelephone.HeaderText = "联系电话";
            this.colTelephone.Name = "colTelephone";
            // 
            // colEmail
            // 
            this.colEmail.DataPropertyName = "Email";
            this.colEmail.HeaderText = "电子邮箱";
            this.colEmail.Name = "colEmail";
            // 
            // ucPanel2
            // 
            this.ucPanel2.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel2.Controls.Add(this.dgvCompany);
            this.ucPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPanel2.Location = new System.Drawing.Point(0, 30);
            this.ucPanel2.Name = "ucPanel2";
            this.ucPanel2.Padding = new System.Windows.Forms.Padding(5);
            this.ucPanel2.Size = new System.Drawing.Size(848, 364);
            this.ucPanel2.TabIndex = 4;
            // 
            // ucPanel1
            // 
            this.ucPanel1.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel1.Controls.Add(this.ucPanel2);
            this.ucPanel1.Controls.Add(this.ucPanel3);
            this.ucPanel1.Controls.Add(this.grpSearch);
            this.ucPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPanel1.Location = new System.Drawing.Point(0, 0);
            this.ucPanel1.Name = "ucPanel1";
            this.ucPanel1.Size = new System.Drawing.Size(848, 422);
            this.ucPanel1.TabIndex = 14;
            // 
            // ucPanel3
            // 
            this.ucPanel3.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel3.Controls.Add(this.pgCompany);
            this.ucPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucPanel3.Location = new System.Drawing.Point(0, 394);
            this.ucPanel3.Name = "ucPanel3";
            this.ucPanel3.Size = new System.Drawing.Size(848, 28);
            this.ucPanel3.TabIndex = 5;
            // 
            // pgCompany
            // 
            this.pgCompany.BackColor = System.Drawing.Color.Transparent;
            this.pgCompany.Location = new System.Drawing.Point(21, 6);
            this.pgCompany.Name = "pgCompany";
            this.pgCompany.RecordCount = 0;
            this.pgCompany.Size = new System.Drawing.Size(224, 16);
            this.pgCompany.TabIndex = 2;
            this.pgCompany.PageIndexChanged += new System.EventHandler(this.pgCompany_PageIndexChanged);
            // 
            // grpSearch
            // 
            this.grpSearch.BackColor = System.Drawing.Color.Transparent;
            this.grpSearch.Controls.Add(this.chkAll);
            this.grpSearch.Controls.Add(this.txtCompanyCode);
            this.grpSearch.Controls.Add(this.ucLabel1);
            this.grpSearch.Controls.Add(this.btnSearch);
            this.grpSearch.Controls.Add(this.ucLabel2);
            this.grpSearch.Controls.Add(this.txtCompanyName);
            this.grpSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpSearch.Location = new System.Drawing.Point(0, 0);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(848, 30);
            this.grpSearch.TabIndex = 3;
            // 
            // chkAll
            // 
            // 
            // 
            // 
            this.chkAll.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkAll.Location = new System.Drawing.Point(600, 3);
            this.chkAll.Name = "chkAll";
            this.chkAll.Size = new System.Drawing.Size(61, 23);
            this.chkAll.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chkAll.TabIndex = 7;
            this.chkAll.Text = "所有";
            // 
            // txtCompanyCode
            // 
            // 
            // 
            // 
            this.txtCompanyCode.Border.Class = "TextBoxBorder";
            this.txtCompanyCode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCompanyCode.EnterToNextControl = false;
            this.txtCompanyCode.Location = new System.Drawing.Point(351, 5);
            this.txtCompanyCode.Name = "txtCompanyCode";
            this.txtCompanyCode.Size = new System.Drawing.Size(145, 21);
            this.txtCompanyCode.TabIndex = 6;
            // 
            // ucLabel1
            // 
            this.ucLabel1.AutoSize = true;
            this.ucLabel1.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabel1.ForeColor = System.Drawing.Color.Gray;
            this.ucLabel1.Location = new System.Drawing.Point(279, 7);
            this.ucLabel1.Name = "ucLabel1";
            this.ucLabel1.Size = new System.Drawing.Size(65, 12);
            this.ucLabel1.TabIndex = 5;
            this.ucLabel1.Text = "公司名称：";
            // 
            // btnSearch
            // 
            this.btnSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSearch.Image = global::ZNLCRM.UI.Properties.Resources.search;
            this.btnSearch.Location = new System.Drawing.Point(502, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "搜索";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // ucLabel2
            // 
            this.ucLabel2.AutoSize = true;
            this.ucLabel2.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabel2.ForeColor = System.Drawing.Color.Gray;
            this.ucLabel2.Location = new System.Drawing.Point(6, 7);
            this.ucLabel2.Name = "ucLabel2";
            this.ucLabel2.Size = new System.Drawing.Size(65, 12);
            this.ucLabel2.TabIndex = 2;
            this.ucLabel2.Text = "公司名称：";
            // 
            // txtCompanyName
            // 
            // 
            // 
            // 
            this.txtCompanyName.Border.Class = "TextBoxBorder";
            this.txtCompanyName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCompanyName.EnterToNextControl = false;
            this.txtCompanyName.Location = new System.Drawing.Point(77, 3);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(177, 21);
            this.txtCompanyName.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(451, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(86, 30);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panBottom
            // 
            this.panBottom.BackColor = System.Drawing.Color.Transparent;
            this.panBottom.Controls.Add(this.btnCancel);
            this.panBottom.Controls.Add(this.btnOk);
            this.panBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panBottom.Location = new System.Drawing.Point(0, 422);
            this.panBottom.Name = "panBottom";
            this.panBottom.Size = new System.Drawing.Size(848, 41);
            this.panBottom.TabIndex = 15;
            // 
            // btnOk
            // 
            this.btnOk.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnOk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOk.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnOk.Image = ((System.Drawing.Image)(resources.GetObject("btnOk.Image")));
            this.btnOk.Location = new System.Drawing.Point(341, 6);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(86, 30);
            this.btnOk.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "确定(&S)";
            this.btnOk.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // frmSelectSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 463);
            this.Controls.Add(this.ucPanel1);
            this.Controls.Add(this.panBottom);
            this.Name = "frmSelectSupplier";
            this.Text = "供应商选择";
            this.Load += new System.EventHandler(this.frmSelectSupplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompany)).EndInit();
            this.ucPanel2.ResumeLayout(false);
            this.ucPanel1.ResumeLayout(false);
            this.ucPanel3.ResumeLayout(false);
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            this.panBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.UcDataGridView dgvCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCompanyID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCompanyGuID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCompanyCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAttachEmpID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAttachEmpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWebSite;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContactName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelephone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private Controls.UcPanel ucPanel2;
        private Controls.UcPanel ucPanel1;
        private Controls.UcPanel ucPanel3;
        private Controls.UcPager pgCompany;
        private Controls.UcPanel grpSearch;
        private Controls.UcCheckBox chkAll;
        private Controls.UcTextBox txtCompanyCode;
        private Controls.UcLabel ucLabel1;
        private Controls.UcButton btnSearch;
        private Controls.UcLabel ucLabel2;
        private Controls.UcTextBox txtCompanyName;
        private Controls.UcButton btnCancel;
        private Controls.UcPanel panBottom;
        private Controls.UcButton btnOk;
    }
}