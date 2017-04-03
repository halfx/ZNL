namespace ZNLCRM.UI.CRM
{
    partial class frmSelectSupplierContact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelectSupplierContact));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panBottom = new ZNLCRM.Controls.UcPanel(this.components);
            this.btnCancel = new ZNLCRM.Controls.UcButton(this.components);
            this.btnOk = new ZNLCRM.Controls.UcButton(this.components);
            this.dgvContact = new ZNLCRM.Controls.UcDataGridView(this.components);
            this.colContactID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContactName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBirthplace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGender = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colTelephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBirthday = new DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn();
            this.colMobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMSN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSkyp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRemark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpSearch = new ZNLCRM.Controls.UcPanel(this.components);
            this.chkAll = new ZNLCRM.Controls.UcCheckBox(this.components);
            this.txtTelephone = new ZNLCRM.Controls.UcTextBox(this.components);
            this.ucLabel1 = new ZNLCRM.Controls.UcLabel(this.components);
            this.btnSearch = new ZNLCRM.Controls.UcButton(this.components);
            this.ucLabel2 = new ZNLCRM.Controls.UcLabel(this.components);
            this.txtContactName = new ZNLCRM.Controls.UcTextBox(this.components);
            this.panBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContact)).BeginInit();
            this.grpSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // panBottom
            // 
            this.panBottom.BackColor = System.Drawing.Color.Transparent;
            this.panBottom.Controls.Add(this.btnCancel);
            this.panBottom.Controls.Add(this.btnOk);
            this.panBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panBottom.Location = new System.Drawing.Point(0, 314);
            this.panBottom.Name = "panBottom";
            this.panBottom.Size = new System.Drawing.Size(813, 41);
            this.panBottom.TabIndex = 17;
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(433, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(86, 30);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnOk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOk.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnOk.Image = ((System.Drawing.Image)(resources.GetObject("btnOk.Image")));
            this.btnOk.Location = new System.Drawing.Point(323, 6);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(86, 30);
            this.btnOk.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "确定(&S)";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // dgvContact
            // 
            this.dgvContact.AllowUserToAddRows = false;
            this.dgvContact.AllowUserToDeleteRows = false;
            this.dgvContact.AllowUserToOrderColumns = true;
            this.dgvContact.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvContact.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvContact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContact.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colContactID,
            this.colContactName,
            this.colPosition,
            this.colBirthplace,
            this.colGender,
            this.colTelephone,
            this.colBirthday,
            this.colMobile,
            this.colEmail,
            this.colQQ,
            this.colMSN,
            this.colSkyp,
            this.colRemark});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvContact.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvContact.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvContact.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvContact.HighlightSelectedColumnHeaders = false;
            this.dgvContact.Location = new System.Drawing.Point(0, 30);
            this.dgvContact.Name = "dgvContact";
            this.dgvContact.PaintEnhancedSelection = false;
            this.dgvContact.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvContact.RowHeadersWidth = 40;
            this.dgvContact.RowTemplate.Height = 23;
            this.dgvContact.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvContact.SelectAllSignVisible = false;
            this.dgvContact.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvContact.ShowRowNo = true;
            this.dgvContact.Size = new System.Drawing.Size(813, 325);
            this.dgvContact.TabIndex = 15;
            // 
            // colContactID
            // 
            this.colContactID.DataPropertyName = "ContactID";
            this.colContactID.HeaderText = "联系人ID";
            this.colContactID.Name = "colContactID";
            this.colContactID.Visible = false;
            // 
            // colContactName
            // 
            this.colContactName.DataPropertyName = "ContactName";
            this.colContactName.HeaderText = "联系人";
            this.colContactName.Name = "colContactName";
            // 
            // colPosition
            // 
            this.colPosition.DataPropertyName = "Position";
            this.colPosition.HeaderText = "职务";
            this.colPosition.Name = "colPosition";
            // 
            // colBirthplace
            // 
            this.colBirthplace.DataPropertyName = "Birthplace";
            this.colBirthplace.HeaderText = "籍贯";
            this.colBirthplace.Name = "colBirthplace";
            this.colBirthplace.Width = 200;
            // 
            // colGender
            // 
            this.colGender.DataPropertyName = "Gender";
            this.colGender.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.colGender.HeaderText = "性别";
            this.colGender.Name = "colGender";
            this.colGender.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colGender.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colTelephone
            // 
            this.colTelephone.DataPropertyName = "Telephone";
            this.colTelephone.HeaderText = "电话";
            this.colTelephone.Name = "colTelephone";
            // 
            // colBirthday
            // 
            // 
            // 
            // 
            this.colBirthday.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.colBirthday.BackgroundStyle.Class = "DataGridViewDateTimeBorder";
            this.colBirthday.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.colBirthday.BackgroundStyle.TextColor = System.Drawing.SystemColors.ControlText;
            this.colBirthday.DataPropertyName = "Birthday";
            this.colBirthday.HeaderText = "生日";
            this.colBirthday.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left;
            // 
            // 
            // 
            this.colBirthday.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.colBirthday.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.colBirthday.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            // 
            // 
            // 
            this.colBirthday.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.colBirthday.MonthCalendar.DisplayMonth = new System.DateTime(2014, 10, 1, 0, 0, 0, 0);
            this.colBirthday.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.colBirthday.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.colBirthday.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.colBirthday.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.colBirthday.Name = "colBirthday";
            // 
            // colMobile
            // 
            this.colMobile.DataPropertyName = "Mobile";
            this.colMobile.HeaderText = "手机";
            this.colMobile.Name = "colMobile";
            // 
            // colEmail
            // 
            this.colEmail.DataPropertyName = "Email";
            this.colEmail.HeaderText = "邮箱";
            this.colEmail.Name = "colEmail";
            // 
            // colQQ
            // 
            this.colQQ.DataPropertyName = "QQ";
            this.colQQ.HeaderText = "QQ";
            this.colQQ.Name = "colQQ";
            // 
            // colMSN
            // 
            this.colMSN.DataPropertyName = "MSN";
            this.colMSN.HeaderText = "MSN";
            this.colMSN.Name = "colMSN";
            // 
            // colSkyp
            // 
            this.colSkyp.DataPropertyName = "Skyp";
            this.colSkyp.HeaderText = "Skyp";
            this.colSkyp.Name = "colSkyp";
            // 
            // colRemark
            // 
            this.colRemark.DataPropertyName = "Remark";
            this.colRemark.HeaderText = "备注";
            this.colRemark.Name = "colRemark";
            // 
            // grpSearch
            // 
            this.grpSearch.BackColor = System.Drawing.Color.Transparent;
            this.grpSearch.Controls.Add(this.chkAll);
            this.grpSearch.Controls.Add(this.txtTelephone);
            this.grpSearch.Controls.Add(this.ucLabel1);
            this.grpSearch.Controls.Add(this.btnSearch);
            this.grpSearch.Controls.Add(this.ucLabel2);
            this.grpSearch.Controls.Add(this.txtContactName);
            this.grpSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpSearch.Location = new System.Drawing.Point(0, 0);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(813, 30);
            this.grpSearch.TabIndex = 16;
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
            // txtTelephone
            // 
            // 
            // 
            // 
            this.txtTelephone.Border.Class = "TextBoxBorder";
            this.txtTelephone.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTelephone.EnterToNextControl = false;
            this.txtTelephone.Location = new System.Drawing.Point(351, 5);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(145, 21);
            this.txtTelephone.TabIndex = 6;
            // 
            // ucLabel1
            // 
            this.ucLabel1.AutoSize = true;
            this.ucLabel1.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabel1.ForeColor = System.Drawing.Color.Gray;
            this.ucLabel1.Location = new System.Drawing.Point(304, 9);
            this.ucLabel1.Name = "ucLabel1";
            this.ucLabel1.Size = new System.Drawing.Size(41, 12);
            this.ucLabel1.TabIndex = 5;
            this.ucLabel1.Text = "电话：";
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
            this.ucLabel2.Location = new System.Drawing.Point(18, 9);
            this.ucLabel2.Name = "ucLabel2";
            this.ucLabel2.Size = new System.Drawing.Size(53, 12);
            this.ucLabel2.TabIndex = 2;
            this.ucLabel2.Text = "联系人：";
            // 
            // txtContactName
            // 
            // 
            // 
            // 
            this.txtContactName.Border.Class = "TextBoxBorder";
            this.txtContactName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtContactName.EnterToNextControl = false;
            this.txtContactName.Location = new System.Drawing.Point(77, 5);
            this.txtContactName.Name = "txtContactName";
            this.txtContactName.Size = new System.Drawing.Size(177, 21);
            this.txtContactName.TabIndex = 3;
            // 
            // frmSelectSupplierContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 355);
            this.Controls.Add(this.panBottom);
            this.Controls.Add(this.dgvContact);
            this.Controls.Add(this.grpSearch);
            this.Name = "frmSelectSupplierContact";
            this.Text = "联系人选择";
            this.Load += new System.EventHandler(this.frmSelectSupplierContact_Load);
            this.panBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContact)).EndInit();
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.UcPanel panBottom;
        private Controls.UcButton btnCancel;
        private Controls.UcButton btnOk;
        private Controls.UcDataGridView dgvContact;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContactID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContactName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBirthplace;
        private System.Windows.Forms.DataGridViewComboBoxColumn colGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelephone;
        private DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn colBirthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMSN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSkyp;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRemark;
        private Controls.UcPanel grpSearch;
        private Controls.UcCheckBox chkAll;
        private Controls.UcTextBox txtTelephone;
        private Controls.UcLabel ucLabel1;
        private Controls.UcButton btnSearch;
        private Controls.UcLabel ucLabel2;
        private Controls.UcTextBox txtContactName;
    }
}