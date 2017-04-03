namespace ZNLCRM.UI.SYS
{
    partial class frmSys_RootDirMapping
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ucPanel1 = new ZNLCRM.Controls.UcPanel(this.components);
            this.ucToolStrip1 = new ZNLCRM.Controls.UcToolStrip(this.components);
            this.tsbAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbDel = new System.Windows.Forms.ToolStripButton();
            this.ucPanel2 = new ZNLCRM.Controls.UcPanel(this.components);
            this.ucPanel5 = new ZNLCRM.Controls.UcPanel(this.components);
            this.panelEdit = new ZNLCRM.Controls.UcPanel(this.components);
            this.txtMGuid = new ZNLCRM.Controls.UcTextBox(this.components);
            this.txtMID = new ZNLCRM.Controls.UcTextBox(this.components);
            this.btnCancel = new ZNLCRM.Controls.UcButton(this.components);
            this.btnSave = new ZNLCRM.Controls.UcButton(this.components);
            this.cboAttachType = new ZNLCRM.Controls.UcComboBox(this.components);
            this.txtPhysicalRootPath = new ZNLCRM.Controls.UcTextBox(this.components);
            this.txtMappingIdentifier = new ZNLCRM.Controls.UcTextBox(this.components);
            this.ucLabelX4 = new ZNLCRM.Controls.UcLabelX(this.components);
            this.chkIsEffect = new ZNLCRM.Controls.UcCheckBox(this.components);
            this.ucLabelX3 = new ZNLCRM.Controls.UcLabelX(this.components);
            this.ucLabelX2 = new ZNLCRM.Controls.UcLabelX(this.components);
            this.ucLabelX1 = new ZNLCRM.Controls.UcLabelX(this.components);
            this.dgvMapping = new ZNLCRM.Controls.UcDataGridView(this.components);
            this.ucPanel4 = new ZNLCRM.Controls.UcPanel(this.components);
            this.btnSearch = new ZNLCRM.Controls.UcButton(this.components);
            this.txtSMappingIdentifier = new ZNLCRM.Controls.UcTextBox(this.components);
            this.ucLabelX5 = new ZNLCRM.Controls.UcLabelX(this.components);
            this.ucPanel3 = new ZNLCRM.Controls.UcPanel(this.components);
            this.pgMapping = new ZNLCRM.Controls.UcPager();
            this.ucLabelX6 = new ZNLCRM.Controls.UcLabelX(this.components);
            this.colMID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMGuid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAttachType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colMappingIdentifier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhysicalRootPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsEffect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ucPanel1.SuspendLayout();
            this.ucToolStrip1.SuspendLayout();
            this.ucPanel2.SuspendLayout();
            this.ucPanel5.SuspendLayout();
            this.panelEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMapping)).BeginInit();
            this.ucPanel4.SuspendLayout();
            this.ucPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ucPanel1
            // 
            this.ucPanel1.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel1.Controls.Add(this.ucToolStrip1);
            this.ucPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucPanel1.Location = new System.Drawing.Point(0, 0);
            this.ucPanel1.Name = "ucPanel1";
            this.ucPanel1.Size = new System.Drawing.Size(839, 38);
            this.ucPanel1.TabIndex = 0;
            // 
            // ucToolStrip1
            // 
            this.ucToolStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ucToolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAdd,
            this.tsbEdit,
            this.tsbDel});
            this.ucToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.ucToolStrip1.Name = "ucToolStrip1";
            this.ucToolStrip1.Padding = new System.Windows.Forms.Padding(5);
            this.ucToolStrip1.Size = new System.Drawing.Size(839, 38);
            this.ucToolStrip1.TabIndex = 0;
            this.ucToolStrip1.Text = "ucToolStrip1";
            // 
            // tsbAdd
            // 
            this.tsbAdd.Image = global::ZNLCRM.UI.Properties.Resources.add_1;
            this.tsbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdd.Name = "tsbAdd";
            this.tsbAdd.Size = new System.Drawing.Size(52, 25);
            this.tsbAdd.Text = "新增";
            this.tsbAdd.Click += new System.EventHandler(this.tsbAdd_Click);
            // 
            // tsbEdit
            // 
            this.tsbEdit.Image = global::ZNLCRM.UI.Properties.Resources.edit_1;
            this.tsbEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEdit.Name = "tsbEdit";
            this.tsbEdit.Size = new System.Drawing.Size(52, 25);
            this.tsbEdit.Text = "修改";
            // 
            // tsbDel
            // 
            this.tsbDel.Image = global::ZNLCRM.UI.Properties.Resources.del_1;
            this.tsbDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDel.Name = "tsbDel";
            this.tsbDel.Size = new System.Drawing.Size(52, 25);
            this.tsbDel.Text = "删除";
            // 
            // ucPanel2
            // 
            this.ucPanel2.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel2.Controls.Add(this.ucPanel5);
            this.ucPanel2.Controls.Add(this.ucPanel4);
            this.ucPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPanel2.Location = new System.Drawing.Point(0, 38);
            this.ucPanel2.Name = "ucPanel2";
            this.ucPanel2.Size = new System.Drawing.Size(839, 332);
            this.ucPanel2.TabIndex = 1;
            // 
            // ucPanel5
            // 
            this.ucPanel5.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel5.Controls.Add(this.panelEdit);
            this.ucPanel5.Controls.Add(this.dgvMapping);
            this.ucPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPanel5.Location = new System.Drawing.Point(0, 35);
            this.ucPanel5.Name = "ucPanel5";
            this.ucPanel5.Padding = new System.Windows.Forms.Padding(5);
            this.ucPanel5.Size = new System.Drawing.Size(839, 297);
            this.ucPanel5.TabIndex = 3;
            // 
            // panelEdit
            // 
            this.panelEdit.BackColor = System.Drawing.Color.Transparent;
            this.panelEdit.Controls.Add(this.ucLabelX6);
            this.panelEdit.Controls.Add(this.txtMGuid);
            this.panelEdit.Controls.Add(this.txtMID);
            this.panelEdit.Controls.Add(this.btnCancel);
            this.panelEdit.Controls.Add(this.btnSave);
            this.panelEdit.Controls.Add(this.cboAttachType);
            this.panelEdit.Controls.Add(this.txtPhysicalRootPath);
            this.panelEdit.Controls.Add(this.txtMappingIdentifier);
            this.panelEdit.Controls.Add(this.ucLabelX4);
            this.panelEdit.Controls.Add(this.chkIsEffect);
            this.panelEdit.Controls.Add(this.ucLabelX3);
            this.panelEdit.Controls.Add(this.ucLabelX2);
            this.panelEdit.Controls.Add(this.ucLabelX1);
            this.panelEdit.Location = new System.Drawing.Point(209, 51);
            this.panelEdit.Name = "panelEdit";
            this.panelEdit.Size = new System.Drawing.Size(419, 205);
            this.panelEdit.TabIndex = 1;
            this.panelEdit.Visible = false;
            // 
            // txtMGuid
            // 
            // 
            // 
            // 
            this.txtMGuid.Border.Class = "TextBoxBorder";
            this.txtMGuid.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMGuid.EnterToNextControl = false;
            this.txtMGuid.Location = new System.Drawing.Point(231, 139);
            this.txtMGuid.Name = "txtMGuid";
            this.txtMGuid.Size = new System.Drawing.Size(47, 21);
            this.txtMGuid.TabIndex = 10;
            // 
            // txtMID
            // 
            // 
            // 
            // 
            this.txtMID.Border.Class = "TextBoxBorder";
            this.txtMID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMID.EnterToNextControl = false;
            this.txtMID.Location = new System.Drawing.Point(181, 139);
            this.txtMID.Name = "txtMID";
            this.txtMID.Size = new System.Drawing.Size(44, 21);
            this.txtMID.TabIndex = 9;
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.Image = global::ZNLCRM.UI.Properties.Resources.cancel_1;
            this.btnCancel.Location = new System.Drawing.Point(203, 171);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "取消";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Image = global::ZNLCRM.UI.Properties.Resources.save_1;
            this.btnSave.Location = new System.Drawing.Point(111, 171);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = " 保存";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cboAttachType
            // 
            this.cboAttachType.DisplayMember = "Text";
            this.cboAttachType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboAttachType.FormattingEnabled = true;
            this.cboAttachType.ItemHeight = 15;
            this.cboAttachType.Location = new System.Drawing.Point(111, 19);
            this.cboAttachType.Name = "cboAttachType";
            this.cboAttachType.Size = new System.Drawing.Size(114, 21);
            this.cboAttachType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboAttachType.TabIndex = 6;
            // 
            // txtPhysicalRootPath
            // 
            // 
            // 
            // 
            this.txtPhysicalRootPath.Border.Class = "TextBoxBorder";
            this.txtPhysicalRootPath.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPhysicalRootPath.EnterToNextControl = false;
            this.txtPhysicalRootPath.Location = new System.Drawing.Point(111, 77);
            this.txtPhysicalRootPath.Name = "txtPhysicalRootPath";
            this.txtPhysicalRootPath.Size = new System.Drawing.Size(250, 21);
            this.txtPhysicalRootPath.TabIndex = 5;
            this.txtPhysicalRootPath.Text = "D:\\ZnlAtt\\{Company}\\{FolderName}";
            this.txtPhysicalRootPath.TextChanged += new System.EventHandler(this.txtPhysicalRootPath_TextChanged);
            // 
            // txtMappingIdentifier
            // 
            // 
            // 
            // 
            this.txtMappingIdentifier.Border.Class = "TextBoxBorder";
            this.txtMappingIdentifier.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMappingIdentifier.EnterToNextControl = false;
            this.txtMappingIdentifier.Location = new System.Drawing.Point(111, 48);
            this.txtMappingIdentifier.Name = "txtMappingIdentifier";
            this.txtMappingIdentifier.Size = new System.Drawing.Size(250, 21);
            this.txtMappingIdentifier.TabIndex = 2;
            // 
            // ucLabelX4
            // 
            // 
            // 
            // 
            this.ucLabelX4.BackgroundStyle.Class = "";
            this.ucLabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ucLabelX4.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabelX4.ForeColor = System.Drawing.Color.Gray;
            this.ucLabelX4.Location = new System.Drawing.Point(36, 139);
            this.ucLabelX4.Name = "ucLabelX4";
            this.ucLabelX4.Size = new System.Drawing.Size(72, 23);
            this.ucLabelX4.TabIndex = 4;
            this.ucLabelX4.Text = "是否有效：";
            // 
            // chkIsEffect
            // 
            // 
            // 
            // 
            this.chkIsEffect.BackgroundStyle.Class = "";
            this.chkIsEffect.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkIsEffect.Checked = true;
            this.chkIsEffect.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIsEffect.CheckValue = "Y";
            this.chkIsEffect.Location = new System.Drawing.Point(111, 144);
            this.chkIsEffect.Name = "chkIsEffect";
            this.chkIsEffect.Size = new System.Drawing.Size(55, 14);
            this.chkIsEffect.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chkIsEffect.TabIndex = 3;
            this.chkIsEffect.Text = "有效";
            // 
            // ucLabelX3
            // 
            // 
            // 
            // 
            this.ucLabelX3.BackgroundStyle.Class = "";
            this.ucLabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ucLabelX3.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabelX3.ForeColor = System.Drawing.Color.Gray;
            this.ucLabelX3.Location = new System.Drawing.Point(25, 75);
            this.ucLabelX3.Name = "ucLabelX3";
            this.ucLabelX3.Size = new System.Drawing.Size(84, 23);
            this.ucLabelX3.TabIndex = 2;
            this.ucLabelX3.Text = "物理根路径：";
            // 
            // ucLabelX2
            // 
            // 
            // 
            // 
            this.ucLabelX2.BackgroundStyle.Class = "";
            this.ucLabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ucLabelX2.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabelX2.ForeColor = System.Drawing.Color.Gray;
            this.ucLabelX2.Location = new System.Drawing.Point(25, 46);
            this.ucLabelX2.Name = "ucLabelX2";
            this.ucLabelX2.Size = new System.Drawing.Size(84, 23);
            this.ucLabelX2.TabIndex = 1;
            this.ucLabelX2.Text = "映射标示符：";
            // 
            // ucLabelX1
            // 
            // 
            // 
            // 
            this.ucLabelX1.BackgroundStyle.Class = "";
            this.ucLabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ucLabelX1.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabelX1.ForeColor = System.Drawing.Color.Gray;
            this.ucLabelX1.Location = new System.Drawing.Point(36, 17);
            this.ucLabelX1.Name = "ucLabelX1";
            this.ucLabelX1.Size = new System.Drawing.Size(69, 23);
            this.ucLabelX1.TabIndex = 0;
            this.ucLabelX1.Text = "附件分类：";
            // 
            // dgvMapping
            // 
            this.dgvMapping.AllowUserToAddRows = false;
            this.dgvMapping.AllowUserToDeleteRows = false;
            this.dgvMapping.AllowUserToOrderColumns = true;
            this.dgvMapping.BackgroundColor = System.Drawing.Color.White;
            this.dgvMapping.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMapping.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMID,
            this.colMGuid,
            this.colAttachType,
            this.colMappingIdentifier,
            this.colPhysicalRootPath,
            this.colIsEffect});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMapping.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMapping.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMapping.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvMapping.HighlightSelectedColumnHeaders = false;
            this.dgvMapping.Location = new System.Drawing.Point(5, 5);
            this.dgvMapping.Name = "dgvMapping";
            this.dgvMapping.PaintEnhancedSelection = false;
            this.dgvMapping.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvMapping.RowTemplate.Height = 23;
            this.dgvMapping.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMapping.SelectAllSignVisible = false;
            this.dgvMapping.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvMapping.Size = new System.Drawing.Size(829, 287);
            this.dgvMapping.TabIndex = 0;
            // 
            // ucPanel4
            // 
            this.ucPanel4.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel4.Controls.Add(this.btnSearch);
            this.ucPanel4.Controls.Add(this.txtSMappingIdentifier);
            this.ucPanel4.Controls.Add(this.ucLabelX5);
            this.ucPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucPanel4.Location = new System.Drawing.Point(0, 0);
            this.ucPanel4.Name = "ucPanel4";
            this.ucPanel4.Size = new System.Drawing.Size(839, 35);
            this.ucPanel4.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSearch.Image = global::ZNLCRM.UI.Properties.Resources.search;
            this.btnSearch.Location = new System.Drawing.Point(289, 6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "搜索";
            // 
            // txtSMappingIdentifier
            // 
            // 
            // 
            // 
            this.txtSMappingIdentifier.Border.Class = "TextBoxBorder";
            this.txtSMappingIdentifier.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSMappingIdentifier.EnterToNextControl = false;
            this.txtSMappingIdentifier.Location = new System.Drawing.Point(104, 8);
            this.txtSMappingIdentifier.Name = "txtSMappingIdentifier";
            this.txtSMappingIdentifier.Size = new System.Drawing.Size(179, 21);
            this.txtSMappingIdentifier.TabIndex = 1;
            // 
            // ucLabelX5
            // 
            // 
            // 
            // 
            this.ucLabelX5.BackgroundStyle.Class = "";
            this.ucLabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ucLabelX5.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabelX5.ForeColor = System.Drawing.Color.Gray;
            this.ucLabelX5.Location = new System.Drawing.Point(23, 6);
            this.ucLabelX5.Name = "ucLabelX5";
            this.ucLabelX5.Size = new System.Drawing.Size(84, 23);
            this.ucLabelX5.TabIndex = 0;
            this.ucLabelX5.Text = "映射标示符：";
            // 
            // ucPanel3
            // 
            this.ucPanel3.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel3.Controls.Add(this.pgMapping);
            this.ucPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucPanel3.Location = new System.Drawing.Point(0, 370);
            this.ucPanel3.Name = "ucPanel3";
            this.ucPanel3.Size = new System.Drawing.Size(839, 37);
            this.ucPanel3.TabIndex = 2;
            // 
            // pgMapping
            // 
            this.pgMapping.BackColor = System.Drawing.Color.Transparent;
            this.pgMapping.Location = new System.Drawing.Point(7, 11);
            this.pgMapping.Name = "pgMapping";
            this.pgMapping.RecordCount = 0;
            this.pgMapping.Size = new System.Drawing.Size(346, 15);
            this.pgMapping.TabIndex = 0;
            this.pgMapping.PageIndexChanged += new System.EventHandler(this.pgMapping_PageIndexChanged);
            // 
            // ucLabelX6
            // 
            // 
            // 
            // 
            this.ucLabelX6.BackgroundStyle.Class = "";
            this.ucLabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ucLabelX6.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabelX6.ForeColor = System.Drawing.Color.Gray;
            this.ucLabelX6.Location = new System.Drawing.Point(111, 104);
            this.ucLabelX6.Name = "ucLabelX6";
            this.ucLabelX6.Size = new System.Drawing.Size(250, 23);
            this.ucLabelX6.TabIndex = 11;
            this.ucLabelX6.Text = "<font color=\"#C0504D\">例如：</font>D:\\ZnlAtt\\正能量技术\\Bill";
            // 
            // colMID
            // 
            this.colMID.DataPropertyName = "MID";
            this.colMID.HeaderText = "MID";
            this.colMID.Name = "colMID";
            this.colMID.Visible = false;
            // 
            // colMGuid
            // 
            this.colMGuid.DataPropertyName = "MGuid";
            this.colMGuid.HeaderText = "MGuid";
            this.colMGuid.Name = "colMGuid";
            this.colMGuid.Visible = false;
            // 
            // colAttachType
            // 
            this.colAttachType.DataPropertyName = "AttachType";
            this.colAttachType.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.colAttachType.HeaderText = "附件类型";
            this.colAttachType.Name = "colAttachType";
            this.colAttachType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colAttachType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colMappingIdentifier
            // 
            this.colMappingIdentifier.DataPropertyName = "MappingIdentifier";
            this.colMappingIdentifier.HeaderText = "映射标示符";
            this.colMappingIdentifier.Name = "colMappingIdentifier";
            // 
            // colPhysicalRootPath
            // 
            this.colPhysicalRootPath.DataPropertyName = "PhysicalRootPath";
            this.colPhysicalRootPath.HeaderText = "物理根目录";
            this.colPhysicalRootPath.Name = "colPhysicalRootPath";
            // 
            // colIsEffect
            // 
            this.colIsEffect.DataPropertyName = "IsEffect";
            this.colIsEffect.HeaderText = "是否有效";
            this.colIsEffect.Name = "colIsEffect";
            this.colIsEffect.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colIsEffect.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // frmSys_RootDirMapping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 407);
            this.Controls.Add(this.ucPanel2);
            this.Controls.Add(this.ucPanel1);
            this.Controls.Add(this.ucPanel3);
            this.Name = "frmSys_RootDirMapping";
            this.Text = "根目录映射设置";
            this.Load += new System.EventHandler(this.frmSys_RootDirMapping_Load);
            this.ucPanel1.ResumeLayout(false);
            this.ucPanel1.PerformLayout();
            this.ucToolStrip1.ResumeLayout(false);
            this.ucToolStrip1.PerformLayout();
            this.ucPanel2.ResumeLayout(false);
            this.ucPanel5.ResumeLayout(false);
            this.panelEdit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMapping)).EndInit();
            this.ucPanel4.ResumeLayout(false);
            this.ucPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.UcPanel ucPanel1;
        private Controls.UcToolStrip ucToolStrip1;
        private System.Windows.Forms.ToolStripButton tsbAdd;
        private Controls.UcPanel ucPanel2;
        private System.Windows.Forms.ToolStripButton tsbEdit;
        private System.Windows.Forms.ToolStripButton tsbDel;
        private Controls.UcDataGridView dgvMapping;
        private Controls.UcPanel ucPanel3;
        private Controls.UcPager pgMapping;
        private Controls.UcPanel panelEdit;
        private Controls.UcButton btnCancel;
        private Controls.UcButton btnSave;
        private Controls.UcComboBox cboAttachType;
        private Controls.UcTextBox txtPhysicalRootPath;
        private Controls.UcTextBox txtMappingIdentifier;
        private Controls.UcLabelX ucLabelX4;
        private Controls.UcCheckBox chkIsEffect;
        private Controls.UcLabelX ucLabelX3;
        private Controls.UcLabelX ucLabelX2;
        private Controls.UcLabelX ucLabelX1;
        private Controls.UcTextBox txtMGuid;
        private Controls.UcTextBox txtMID;
        private Controls.UcPanel ucPanel5;
        private Controls.UcPanel ucPanel4;
        private Controls.UcButton btnSearch;
        private Controls.UcTextBox txtSMappingIdentifier;
        private Controls.UcLabelX ucLabelX5;
        private Controls.UcLabelX ucLabelX6;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMGuid;
        private System.Windows.Forms.DataGridViewComboBoxColumn colAttachType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMappingIdentifier;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhysicalRootPath;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colIsEffect;
    }
}