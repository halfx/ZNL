namespace ZNLCRM.UI.SYS
{
    partial class frmCodeRuleManage
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
            this.panMid = new ZNLCRM.Controls.UcPanel(this.components);
            this.dgvMain = new ZNLCRM.Controls.UcDataGridView(this.components);
            this.col_SYS_CredentialCodeRule_RuleID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_SYS_CredentialCodeRule_IsManualInput = new DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn();
            this.col_SYS_CredentialCodeRule_ModuleID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_SYS_CredentialCodeRule_ModuleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_SYS_CredentialCodeRule_IsActive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_SYS_CredentialCodeRule_GCompanyID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_SYS_CredentialCodeRule_CredentialName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_SYS_CredentialCodeRule_IsOrderNo = new DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn();
            this.col_SYS_CredentialCodeRule_TableName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_SYS_CredentialCodeRule_CodeFieldName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_SYS_CredentialCodeRule_Prefix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_SYS_CredentialCodeRule_NotSet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_SYS_CredentialCodeRule_InitialValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_SYS_CredentialCodeRule_IsContinuous = new DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn();
            this.col_SYS_CredentialCodeRule_Length = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panBottom = new ZNLCRM.Controls.UcPanel(this.components);
            this.pagMain = new ZNLCRM.Controls.UcPager();
            this.ucLabel2 = new ZNLCRM.Controls.UcLabel(this.components);
            this.panTop = new ZNLCRM.Controls.UcPanel(this.components);
            this.ucLabel3 = new ZNLCRM.Controls.UcLabel(this.components);
            this.txtModuleName = new ZNLCRM.Controls.UcTextBox(this.components);
            this.txtTableName = new ZNLCRM.Controls.UcTextBox(this.components);
            this.ucLabel1 = new ZNLCRM.Controls.UcLabel(this.components);
            this.txtCredentialName = new ZNLCRM.Controls.UcTextBox(this.components);
            this.btnSearch = new ZNLCRM.Controls.UcButton(this.components);
            this.tlbDel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tlbEdit = new System.Windows.Forms.ToolStripButton();
            this.tlbAdd = new System.Windows.Forms.ToolStripButton();
            this.panTopMain = new ZNLCRM.Controls.UcPanel(this.components);
            this.tlbMain = new ZNLCRM.Controls.UcToolStrip(this.components);
            this.panMid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.panBottom.SuspendLayout();
            this.panTop.SuspendLayout();
            this.panTopMain.SuspendLayout();
            this.tlbMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panMid
            // 
            this.panMid.BackColor = System.Drawing.Color.Transparent;
            this.panMid.Controls.Add(this.dgvMain);
            this.panMid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panMid.Location = new System.Drawing.Point(0, 68);
            this.panMid.Name = "panMid";
            this.panMid.Padding = new System.Windows.Forms.Padding(5);
            this.panMid.Size = new System.Drawing.Size(1046, 279);
            this.panMid.TabIndex = 4;
            // 
            // dgvMain
            // 
            this.dgvMain.AllowUserToAddRows = false;
            this.dgvMain.AllowUserToDeleteRows = false;
            this.dgvMain.AllowUserToOrderColumns = true;
            this.dgvMain.BackgroundColor = System.Drawing.Color.White;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_SYS_CredentialCodeRule_RuleID,
            this.col_SYS_CredentialCodeRule_IsManualInput,
            this.col_SYS_CredentialCodeRule_ModuleID,
            this.col_SYS_CredentialCodeRule_ModuleName,
            this.col_SYS_CredentialCodeRule_IsActive,
            this.col_SYS_CredentialCodeRule_GCompanyID,
            this.col_SYS_CredentialCodeRule_CredentialName,
            this.col_SYS_CredentialCodeRule_IsOrderNo,
            this.col_SYS_CredentialCodeRule_TableName,
            this.col_SYS_CredentialCodeRule_CodeFieldName,
            this.col_SYS_CredentialCodeRule_Prefix,
            this.col_SYS_CredentialCodeRule_NotSet,
            this.col_SYS_CredentialCodeRule_InitialValue,
            this.col_SYS_CredentialCodeRule_IsContinuous,
            this.col_SYS_CredentialCodeRule_Length});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMain.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMain.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvMain.HighlightSelectedColumnHeaders = false;
            this.dgvMain.Location = new System.Drawing.Point(5, 5);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.PaintEnhancedSelection = false;
            this.dgvMain.ReadOnly = true;
            this.dgvMain.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvMain.RowTemplate.Height = 23;
            this.dgvMain.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMain.SelectAllSignVisible = false;
            this.dgvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvMain.Size = new System.Drawing.Size(1036, 269);
            this.dgvMain.TabIndex = 0;
            this.dgvMain.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvMain_CellMouseDoubleClick);
            // 
            // col_SYS_CredentialCodeRule_RuleID
            // 
            this.col_SYS_CredentialCodeRule_RuleID.DataPropertyName = "RuleID";
            this.col_SYS_CredentialCodeRule_RuleID.HeaderText = "KeyGuid";
            this.col_SYS_CredentialCodeRule_RuleID.Name = "col_SYS_CredentialCodeRule_RuleID";
            this.col_SYS_CredentialCodeRule_RuleID.ReadOnly = true;
            this.col_SYS_CredentialCodeRule_RuleID.Visible = false;
            this.col_SYS_CredentialCodeRule_RuleID.Width = 60;
            // 
            // col_SYS_CredentialCodeRule_IsManualInput
            // 
            this.col_SYS_CredentialCodeRule_IsManualInput.Checked = true;
            this.col_SYS_CredentialCodeRule_IsManualInput.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.col_SYS_CredentialCodeRule_IsManualInput.CheckValue = "N";
            this.col_SYS_CredentialCodeRule_IsManualInput.DataPropertyName = "IsManualInput";
            this.col_SYS_CredentialCodeRule_IsManualInput.Enabled = false;
            this.col_SYS_CredentialCodeRule_IsManualInput.HeaderText = "是否手工输入";
            this.col_SYS_CredentialCodeRule_IsManualInput.Name = "col_SYS_CredentialCodeRule_IsManualInput";
            this.col_SYS_CredentialCodeRule_IsManualInput.ReadOnly = true;
            this.col_SYS_CredentialCodeRule_IsManualInput.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_SYS_CredentialCodeRule_IsManualInput.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // col_SYS_CredentialCodeRule_ModuleID
            // 
            this.col_SYS_CredentialCodeRule_ModuleID.DataPropertyName = "ModuleID";
            this.col_SYS_CredentialCodeRule_ModuleID.HeaderText = "模块ID";
            this.col_SYS_CredentialCodeRule_ModuleID.Name = "col_SYS_CredentialCodeRule_ModuleID";
            this.col_SYS_CredentialCodeRule_ModuleID.ReadOnly = true;
            this.col_SYS_CredentialCodeRule_ModuleID.Visible = false;
            // 
            // col_SYS_CredentialCodeRule_ModuleName
            // 
            this.col_SYS_CredentialCodeRule_ModuleName.DataPropertyName = "ModuleName";
            this.col_SYS_CredentialCodeRule_ModuleName.HeaderText = "模块名称";
            this.col_SYS_CredentialCodeRule_ModuleName.Name = "col_SYS_CredentialCodeRule_ModuleName";
            this.col_SYS_CredentialCodeRule_ModuleName.ReadOnly = true;
            // 
            // col_SYS_CredentialCodeRule_IsActive
            // 
            this.col_SYS_CredentialCodeRule_IsActive.DataPropertyName = "IsActive";
            this.col_SYS_CredentialCodeRule_IsActive.HeaderText = "数据状态";
            this.col_SYS_CredentialCodeRule_IsActive.Name = "col_SYS_CredentialCodeRule_IsActive";
            this.col_SYS_CredentialCodeRule_IsActive.ReadOnly = true;
            // 
            // col_SYS_CredentialCodeRule_GCompanyID
            // 
            this.col_SYS_CredentialCodeRule_GCompanyID.DataPropertyName = "GCompanyID";
            this.col_SYS_CredentialCodeRule_GCompanyID.HeaderText = "注册公司";
            this.col_SYS_CredentialCodeRule_GCompanyID.Name = "col_SYS_CredentialCodeRule_GCompanyID";
            this.col_SYS_CredentialCodeRule_GCompanyID.ReadOnly = true;
            this.col_SYS_CredentialCodeRule_GCompanyID.Width = 80;
            // 
            // col_SYS_CredentialCodeRule_CredentialName
            // 
            this.col_SYS_CredentialCodeRule_CredentialName.DataPropertyName = "CredentialName";
            this.col_SYS_CredentialCodeRule_CredentialName.HeaderText = "单据名称";
            this.col_SYS_CredentialCodeRule_CredentialName.Name = "col_SYS_CredentialCodeRule_CredentialName";
            this.col_SYS_CredentialCodeRule_CredentialName.ReadOnly = true;
            this.col_SYS_CredentialCodeRule_CredentialName.Width = 120;
            // 
            // col_SYS_CredentialCodeRule_IsOrderNo
            // 
            this.col_SYS_CredentialCodeRule_IsOrderNo.Checked = true;
            this.col_SYS_CredentialCodeRule_IsOrderNo.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.col_SYS_CredentialCodeRule_IsOrderNo.CheckValue = "N";
            this.col_SYS_CredentialCodeRule_IsOrderNo.DataPropertyName = "IsOrderNo";
            this.col_SYS_CredentialCodeRule_IsOrderNo.Enabled = false;
            this.col_SYS_CredentialCodeRule_IsOrderNo.HeaderText = "单据编号";
            this.col_SYS_CredentialCodeRule_IsOrderNo.Name = "col_SYS_CredentialCodeRule_IsOrderNo";
            this.col_SYS_CredentialCodeRule_IsOrderNo.ReadOnly = true;
            this.col_SYS_CredentialCodeRule_IsOrderNo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_SYS_CredentialCodeRule_IsOrderNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // col_SYS_CredentialCodeRule_TableName
            // 
            this.col_SYS_CredentialCodeRule_TableName.DataPropertyName = "TableName";
            this.col_SYS_CredentialCodeRule_TableName.HeaderText = "表名";
            this.col_SYS_CredentialCodeRule_TableName.Name = "col_SYS_CredentialCodeRule_TableName";
            this.col_SYS_CredentialCodeRule_TableName.ReadOnly = true;
            // 
            // col_SYS_CredentialCodeRule_CodeFieldName
            // 
            this.col_SYS_CredentialCodeRule_CodeFieldName.DataPropertyName = "CodeFieldName";
            this.col_SYS_CredentialCodeRule_CodeFieldName.HeaderText = "编号字段";
            this.col_SYS_CredentialCodeRule_CodeFieldName.Name = "col_SYS_CredentialCodeRule_CodeFieldName";
            this.col_SYS_CredentialCodeRule_CodeFieldName.ReadOnly = true;
            // 
            // col_SYS_CredentialCodeRule_Prefix
            // 
            this.col_SYS_CredentialCodeRule_Prefix.DataPropertyName = "Prefix";
            this.col_SYS_CredentialCodeRule_Prefix.HeaderText = "前缀";
            this.col_SYS_CredentialCodeRule_Prefix.Name = "col_SYS_CredentialCodeRule_Prefix";
            this.col_SYS_CredentialCodeRule_Prefix.ReadOnly = true;
            // 
            // col_SYS_CredentialCodeRule_NotSet
            // 
            this.col_SYS_CredentialCodeRule_NotSet.DataPropertyName = "Suffix";
            this.col_SYS_CredentialCodeRule_NotSet.HeaderText = "后缀";
            this.col_SYS_CredentialCodeRule_NotSet.Name = "col_SYS_CredentialCodeRule_NotSet";
            this.col_SYS_CredentialCodeRule_NotSet.ReadOnly = true;
            // 
            // col_SYS_CredentialCodeRule_InitialValue
            // 
            this.col_SYS_CredentialCodeRule_InitialValue.DataPropertyName = "InitialValue";
            this.col_SYS_CredentialCodeRule_InitialValue.HeaderText = "初始值";
            this.col_SYS_CredentialCodeRule_InitialValue.Name = "col_SYS_CredentialCodeRule_InitialValue";
            this.col_SYS_CredentialCodeRule_InitialValue.ReadOnly = true;
            // 
            // col_SYS_CredentialCodeRule_IsContinuous
            // 
            this.col_SYS_CredentialCodeRule_IsContinuous.Checked = true;
            this.col_SYS_CredentialCodeRule_IsContinuous.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.col_SYS_CredentialCodeRule_IsContinuous.CheckValue = "N";
            this.col_SYS_CredentialCodeRule_IsContinuous.DataPropertyName = "IsContinuous";
            this.col_SYS_CredentialCodeRule_IsContinuous.Enabled = false;
            this.col_SYS_CredentialCodeRule_IsContinuous.HeaderText = "是否全连续";
            this.col_SYS_CredentialCodeRule_IsContinuous.Name = "col_SYS_CredentialCodeRule_IsContinuous";
            this.col_SYS_CredentialCodeRule_IsContinuous.ReadOnly = true;
            this.col_SYS_CredentialCodeRule_IsContinuous.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_SYS_CredentialCodeRule_IsContinuous.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // col_SYS_CredentialCodeRule_Length
            // 
            this.col_SYS_CredentialCodeRule_Length.DataPropertyName = "Length";
            this.col_SYS_CredentialCodeRule_Length.HeaderText = "编号长度";
            this.col_SYS_CredentialCodeRule_Length.Name = "col_SYS_CredentialCodeRule_Length";
            this.col_SYS_CredentialCodeRule_Length.ReadOnly = true;
            // 
            // panBottom
            // 
            this.panBottom.BackColor = System.Drawing.Color.Transparent;
            this.panBottom.Controls.Add(this.pagMain);
            this.panBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panBottom.Location = new System.Drawing.Point(0, 347);
            this.panBottom.Name = "panBottom";
            this.panBottom.Padding = new System.Windows.Forms.Padding(5);
            this.panBottom.Size = new System.Drawing.Size(1046, 36);
            this.panBottom.TabIndex = 3;
            // 
            // pagMain
            // 
            this.pagMain.BackColor = System.Drawing.Color.Transparent;
            this.pagMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pagMain.Location = new System.Drawing.Point(5, 5);
            this.pagMain.Name = "pagMain";
            this.pagMain.RecordCount = 0;
            this.pagMain.Size = new System.Drawing.Size(1036, 26);
            this.pagMain.TabIndex = 0;
            // 
            // ucLabel2
            // 
            this.ucLabel2.AutoSize = true;
            this.ucLabel2.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabel2.ForeColor = System.Drawing.Color.Gray;
            this.ucLabel2.Location = new System.Drawing.Point(196, 11);
            this.ucLabel2.Name = "ucLabel2";
            this.ucLabel2.Size = new System.Drawing.Size(29, 12);
            this.ucLabel2.TabIndex = 6;
            this.ucLabel2.Text = "表名";
            // 
            // panTop
            // 
            this.panTop.BackColor = System.Drawing.Color.Transparent;
            this.panTop.Controls.Add(this.ucLabel3);
            this.panTop.Controls.Add(this.txtModuleName);
            this.panTop.Controls.Add(this.ucLabel2);
            this.panTop.Controls.Add(this.txtTableName);
            this.panTop.Controls.Add(this.ucLabel1);
            this.panTop.Controls.Add(this.txtCredentialName);
            this.panTop.Controls.Add(this.btnSearch);
            this.panTop.Location = new System.Drawing.Point(0, 34);
            this.panTop.Name = "panTop";
            this.panTop.Padding = new System.Windows.Forms.Padding(5);
            this.panTop.Size = new System.Drawing.Size(1120, 34);
            this.panTop.TabIndex = 3;
            // 
            // ucLabel3
            // 
            this.ucLabel3.AutoSize = true;
            this.ucLabel3.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabel3.ForeColor = System.Drawing.Color.Gray;
            this.ucLabel3.Location = new System.Drawing.Point(368, 11);
            this.ucLabel3.Name = "ucLabel3";
            this.ucLabel3.Size = new System.Drawing.Size(53, 12);
            this.ucLabel3.TabIndex = 8;
            this.ucLabel3.Text = "模块名称";
            // 
            // txtModuleName
            // 
            // 
            // 
            // 
            this.txtModuleName.Border.Class = "TextBoxBorder";
            this.txtModuleName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtModuleName.EnterToNextControl = false;
            this.txtModuleName.Location = new System.Drawing.Point(427, 7);
            this.txtModuleName.Name = "txtModuleName";
            this.txtModuleName.Size = new System.Drawing.Size(115, 21);
            this.txtModuleName.TabIndex = 2;
            // 
            // txtTableName
            // 
            // 
            // 
            // 
            this.txtTableName.Border.Class = "TextBoxBorder";
            this.txtTableName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTableName.EnterToNextControl = false;
            this.txtTableName.Location = new System.Drawing.Point(231, 7);
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.Size = new System.Drawing.Size(115, 21);
            this.txtTableName.TabIndex = 1;
            // 
            // ucLabel1
            // 
            this.ucLabel1.AutoSize = true;
            this.ucLabel1.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabel1.ForeColor = System.Drawing.Color.Gray;
            this.ucLabel1.Location = new System.Drawing.Point(10, 11);
            this.ucLabel1.Name = "ucLabel1";
            this.ucLabel1.Size = new System.Drawing.Size(53, 12);
            this.ucLabel1.TabIndex = 6;
            this.ucLabel1.Text = "单据名称";
            // 
            // txtCredentialName
            // 
            // 
            // 
            // 
            this.txtCredentialName.Border.Class = "TextBoxBorder";
            this.txtCredentialName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCredentialName.EnterToNextControl = false;
            this.txtCredentialName.Location = new System.Drawing.Point(69, 7);
            this.txtCredentialName.Name = "txtCredentialName";
            this.txtCredentialName.Size = new System.Drawing.Size(97, 21);
            this.txtCredentialName.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSearch.Location = new System.Drawing.Point(572, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "搜索";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tlbDel
            // 
            this.tlbDel.Image = global::ZNLCRM.UI.Properties.Resources.del;
            this.tlbDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlbDel.Name = "tlbDel";
            this.tlbDel.Size = new System.Drawing.Size(52, 21);
            this.tlbDel.Text = "删除";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 24);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 24);
            // 
            // tlbEdit
            // 
            this.tlbEdit.Image = global::ZNLCRM.UI.Properties.Resources.modify;
            this.tlbEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlbEdit.Name = "tlbEdit";
            this.tlbEdit.Size = new System.Drawing.Size(52, 21);
            this.tlbEdit.Text = "修改";
            // 
            // tlbAdd
            // 
            this.tlbAdd.Image = global::ZNLCRM.UI.Properties.Resources.add;
            this.tlbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlbAdd.Name = "tlbAdd";
            this.tlbAdd.Size = new System.Drawing.Size(52, 21);
            this.tlbAdd.Text = "添加";
            // 
            // panTopMain
            // 
            this.panTopMain.BackColor = System.Drawing.Color.Transparent;
            this.panTopMain.Controls.Add(this.tlbMain);
            this.panTopMain.Controls.Add(this.panTop);
            this.panTopMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.panTopMain.Location = new System.Drawing.Point(0, 0);
            this.panTopMain.Name = "panTopMain";
            this.panTopMain.Size = new System.Drawing.Size(1046, 68);
            this.panTopMain.TabIndex = 5;
            // 
            // tlbMain
            // 
            this.tlbMain.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tlbMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlbAdd,
            this.toolStripSeparator1,
            this.tlbEdit,
            this.toolStripSeparator2,
            this.tlbDel});
            this.tlbMain.Location = new System.Drawing.Point(0, 0);
            this.tlbMain.Name = "tlbMain";
            this.tlbMain.Padding = new System.Windows.Forms.Padding(5);
            this.tlbMain.Size = new System.Drawing.Size(1046, 34);
            this.tlbMain.TabIndex = 4;
            this.tlbMain.Text = "ucToolStrip1";
            this.tlbMain.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.tlbMain_ItemClicked);
            // 
            // frmCodeRuleManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 383);
            this.Controls.Add(this.panMid);
            this.Controls.Add(this.panBottom);
            this.Controls.Add(this.panTopMain);
            this.Name = "frmCodeRuleManage";
            this.Text = "编码规则管理";
            this.Load += new System.EventHandler(this.frmCodeRuleManage_Load);
            this.panMid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.panBottom.ResumeLayout(false);
            this.panTop.ResumeLayout(false);
            this.panTop.PerformLayout();
            this.panTopMain.ResumeLayout(false);
            this.panTopMain.PerformLayout();
            this.tlbMain.ResumeLayout(false);
            this.tlbMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.UcPanel panMid;
        private Controls.UcDataGridView dgvMain;
        private Controls.UcPanel panBottom;
        private Controls.UcPager pagMain;
        private Controls.UcLabel ucLabel2;
        private Controls.UcPanel panTop;
        private Controls.UcTextBox txtTableName;
        private Controls.UcLabel ucLabel1;
        private Controls.UcTextBox txtCredentialName;
        private Controls.UcButton btnSearch;
        private System.Windows.Forms.ToolStripButton tlbDel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tlbEdit;
        private System.Windows.Forms.ToolStripButton tlbAdd;
        private Controls.UcPanel panTopMain;
        private Controls.UcToolStrip tlbMain;
        private Controls.UcLabel ucLabel3;
        private Controls.UcTextBox txtModuleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SYS_CredentialCodeRule_RuleID;
        private DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn col_SYS_CredentialCodeRule_IsManualInput;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SYS_CredentialCodeRule_ModuleID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SYS_CredentialCodeRule_ModuleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SYS_CredentialCodeRule_IsActive;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SYS_CredentialCodeRule_GCompanyID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SYS_CredentialCodeRule_CredentialName;
        private DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn col_SYS_CredentialCodeRule_IsOrderNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SYS_CredentialCodeRule_TableName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SYS_CredentialCodeRule_CodeFieldName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SYS_CredentialCodeRule_Prefix;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SYS_CredentialCodeRule_NotSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SYS_CredentialCodeRule_InitialValue;
        private DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn col_SYS_CredentialCodeRule_IsContinuous;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SYS_CredentialCodeRule_Length;

    }
}