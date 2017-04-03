namespace ZNLCRM.UI.SYS
{
    partial class frmSYSDictManage
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
            this.cmsDict = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiAddDict = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEditDict = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDelDict = new System.Windows.Forms.ToolStripMenuItem();
            this.ucPanel6 = new ZNLCRM.Controls.UcPanel(this.components);
            this.ucPanel2 = new ZNLCRM.Controls.UcPanel(this.components);
            this.ucPanel4 = new ZNLCRM.Controls.UcPanel(this.components);
            this.grpDict = new ZNLCRM.Controls.UcPanel(this.components);
            this.cboIsSys = new ZNLCRM.Controls.UcCheckBox(this.components);
            this.cboValueType = new ZNLCRM.Controls.UcComboBox(this.components);
            this.ucLabel2 = new ZNLCRM.Controls.UcLabel(this.components);
            this.txtItemName = new ZNLCRM.Controls.UcTextBox(this.components);
            this.字典名称 = new ZNLCRM.Controls.UcLabel(this.components);
            this.ucLabel5 = new ZNLCRM.Controls.UcLabel(this.components);
            this.txtDictItemID = new ZNLCRM.Controls.UcTextBox(this.components);
            this.btnSaveDict = new ZNLCRM.Controls.UcButton(this.components);
            this.ucLabel6 = new ZNLCRM.Controls.UcLabel(this.components);
            this.btnCancelDict = new ZNLCRM.Controls.UcButton(this.components);
            this.txtDictGroupName = new ZNLCRM.Controls.UcTextBox(this.components);
            this.txtItemCode = new ZNLCRM.Controls.UcTextBox(this.components);
            this.dgvDictItem = new ZNLCRM.Controls.UcDataGridView(this.components);
            this.colDictItemLineID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDictItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemValue2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ucPanel3 = new ZNLCRM.Controls.UcPanel(this.components);
            this.btnSave = new ZNLCRM.Controls.UcButton(this.components);
            this.btnDelDictLine = new ZNLCRM.Controls.UcButton(this.components);
            this.btnAddDictLine = new ZNLCRM.Controls.UcButton(this.components);
            this.ucExpandableSplitter1 = new ZNLCRM.Controls.UcExpandableSplitter(this.components);
            this.ucPanel1 = new ZNLCRM.Controls.UcPanel(this.components);
            this.atDict = new ZNLCRM.Controls.UcAdTree(this.components);
            this.nodeConnector1 = new DevComponents.AdvTree.NodeConnector();
            this.elementStyle1 = new DevComponents.DotNetBar.ElementStyle();
            this.ucPanel7 = new ZNLCRM.Controls.UcPanel(this.components);
            this.txtCondition = new ZNLCRM.Controls.UcTextBox(this.components);
            this.ucPanel5 = new ZNLCRM.Controls.UcPanel(this.components);
            this.ucToolStrip1 = new ZNLCRM.Controls.UcToolStrip(this.components);
            this.btnAddDict = new System.Windows.Forms.ToolStripButton();
            this.btnEditDict = new System.Windows.Forms.ToolStripButton();
            this.btnDelDict = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsDict.SuspendLayout();
            this.ucPanel6.SuspendLayout();
            this.ucPanel2.SuspendLayout();
            this.ucPanel4.SuspendLayout();
            this.grpDict.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDictItem)).BeginInit();
            this.ucPanel3.SuspendLayout();
            this.ucPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.atDict)).BeginInit();
            this.ucPanel7.SuspendLayout();
            this.ucPanel5.SuspendLayout();
            this.ucToolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmsDict
            // 
            this.cmsDict.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAddDict,
            this.tsmiEditDict,
            this.tsmiDelDict});
            this.cmsDict.Name = "contextMenuStrip1";
            this.cmsDict.Size = new System.Drawing.Size(149, 70);
            // 
            // tsmiAddDict
            // 
            this.tsmiAddDict.Image = global::ZNLCRM.UI.Properties.Resources.add_1;
            this.tsmiAddDict.Name = "tsmiAddDict";
            this.tsmiAddDict.Size = new System.Drawing.Size(148, 22);
            this.tsmiAddDict.Text = "添加数据字典";
            this.tsmiAddDict.Click += new System.EventHandler(this.tsmiAddDict_Click);
            // 
            // tsmiEditDict
            // 
            this.tsmiEditDict.Image = global::ZNLCRM.UI.Properties.Resources.edit_1;
            this.tsmiEditDict.Name = "tsmiEditDict";
            this.tsmiEditDict.Size = new System.Drawing.Size(148, 22);
            this.tsmiEditDict.Text = "修改数据字典";
            this.tsmiEditDict.Click += new System.EventHandler(this.tsmiEditDict_Click);
            // 
            // tsmiDelDict
            // 
            this.tsmiDelDict.Image = global::ZNLCRM.UI.Properties.Resources.del_1;
            this.tsmiDelDict.Name = "tsmiDelDict";
            this.tsmiDelDict.Size = new System.Drawing.Size(148, 22);
            this.tsmiDelDict.Text = "删除数据字典";
            this.tsmiDelDict.Click += new System.EventHandler(this.tsmiDelDict_Click);
            // 
            // ucPanel6
            // 
            this.ucPanel6.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel6.Controls.Add(this.ucPanel2);
            this.ucPanel6.Controls.Add(this.ucExpandableSplitter1);
            this.ucPanel6.Controls.Add(this.ucPanel1);
            this.ucPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPanel6.Location = new System.Drawing.Point(0, 36);
            this.ucPanel6.Name = "ucPanel6";
            this.ucPanel6.Size = new System.Drawing.Size(1129, 429);
            this.ucPanel6.TabIndex = 6;
            // 
            // ucPanel2
            // 
            this.ucPanel2.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel2.Controls.Add(this.ucPanel4);
            this.ucPanel2.Controls.Add(this.ucPanel3);
            this.ucPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPanel2.Location = new System.Drawing.Point(276, 0);
            this.ucPanel2.Name = "ucPanel2";
            this.ucPanel2.Size = new System.Drawing.Size(853, 429);
            this.ucPanel2.TabIndex = 3;
            // 
            // ucPanel4
            // 
            this.ucPanel4.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel4.Controls.Add(this.grpDict);
            this.ucPanel4.Controls.Add(this.dgvDictItem);
            this.ucPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPanel4.Location = new System.Drawing.Point(0, 37);
            this.ucPanel4.Name = "ucPanel4";
            this.ucPanel4.Size = new System.Drawing.Size(853, 392);
            this.ucPanel4.TabIndex = 1;
            // 
            // grpDict
            // 
            this.grpDict.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpDict.AutoSize = true;
            this.grpDict.BackColor = System.Drawing.Color.Transparent;
            this.grpDict.Controls.Add(this.cboIsSys);
            this.grpDict.Controls.Add(this.cboValueType);
            this.grpDict.Controls.Add(this.ucLabel2);
            this.grpDict.Controls.Add(this.txtItemName);
            this.grpDict.Controls.Add(this.字典名称);
            this.grpDict.Controls.Add(this.ucLabel5);
            this.grpDict.Controls.Add(this.txtDictItemID);
            this.grpDict.Controls.Add(this.btnSaveDict);
            this.grpDict.Controls.Add(this.ucLabel6);
            this.grpDict.Controls.Add(this.btnCancelDict);
            this.grpDict.Controls.Add(this.txtDictGroupName);
            this.grpDict.Controls.Add(this.txtItemCode);
            this.grpDict.Location = new System.Drawing.Point(14, 99);
            this.grpDict.Name = "grpDict";
            this.grpDict.Size = new System.Drawing.Size(311, 194);
            this.grpDict.TabIndex = 5;
            this.grpDict.Visible = false;
            // 
            // cboIsSys
            // 
            // 
            // 
            // 
            this.cboIsSys.BackgroundStyle.Class = "";
            this.cboIsSys.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cboIsSys.Location = new System.Drawing.Point(79, 129);
            this.cboIsSys.Name = "cboIsSys";
            this.cboIsSys.Size = new System.Drawing.Size(100, 23);
            this.cboIsSys.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboIsSys.TabIndex = 13;
            this.cboIsSys.Text = "是否系统字典";
            // 
            // cboValueType
            // 
            this.cboValueType.DisplayMember = "Text";
            this.cboValueType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboValueType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboValueType.FormattingEnabled = true;
            this.cboValueType.ItemHeight = 15;
            this.cboValueType.Location = new System.Drawing.Point(79, 102);
            this.cboValueType.Name = "cboValueType";
            this.cboValueType.Size = new System.Drawing.Size(153, 21);
            this.cboValueType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboValueType.TabIndex = 12;
            // 
            // ucLabel2
            // 
            this.ucLabel2.AutoSize = true;
            this.ucLabel2.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabel2.ForeColor = System.Drawing.Color.Gray;
            this.ucLabel2.Location = new System.Drawing.Point(8, 103);
            this.ucLabel2.Name = "ucLabel2";
            this.ucLabel2.Size = new System.Drawing.Size(65, 12);
            this.ucLabel2.TabIndex = 11;
            this.ucLabel2.Text = "数据类型：";
            // 
            // txtItemName
            // 
            // 
            // 
            // 
            this.txtItemName.Border.Class = "TextBoxBorder";
            this.txtItemName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtItemName.EnterToNextControl = false;
            this.txtItemName.Location = new System.Drawing.Point(79, 73);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(153, 21);
            this.txtItemName.TabIndex = 10;
            // 
            // 字典名称
            // 
            this.字典名称.AutoSize = true;
            this.字典名称.Font = new System.Drawing.Font("宋体", 9F);
            this.字典名称.ForeColor = System.Drawing.Color.Gray;
            this.字典名称.Location = new System.Drawing.Point(8, 75);
            this.字典名称.Name = "字典名称";
            this.字典名称.Size = new System.Drawing.Size(65, 12);
            this.字典名称.TabIndex = 9;
            this.字典名称.Text = "字典名称：";
            // 
            // ucLabel5
            // 
            this.ucLabel5.AutoSize = true;
            this.ucLabel5.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabel5.ForeColor = System.Drawing.Color.Gray;
            this.ucLabel5.Location = new System.Drawing.Point(8, 17);
            this.ucLabel5.Name = "ucLabel5";
            this.ucLabel5.Size = new System.Drawing.Size(65, 12);
            this.ucLabel5.TabIndex = 6;
            this.ucLabel5.Text = "所属组名：";
            // 
            // txtDictItemID
            // 
            // 
            // 
            // 
            this.txtDictItemID.Border.Class = "TextBoxBorder";
            this.txtDictItemID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDictItemID.EnterToNextControl = false;
            this.txtDictItemID.Location = new System.Drawing.Point(238, 15);
            this.txtDictItemID.Name = "txtDictItemID";
            this.txtDictItemID.ReadOnly = true;
            this.txtDictItemID.Size = new System.Drawing.Size(62, 21);
            this.txtDictItemID.TabIndex = 8;
            // 
            // btnSaveDict
            // 
            this.btnSaveDict.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSaveDict.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSaveDict.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSaveDict.Image = global::ZNLCRM.UI.Properties.Resources.save_1;
            this.btnSaveDict.Location = new System.Drawing.Point(79, 156);
            this.btnSaveDict.Name = "btnSaveDict";
            this.btnSaveDict.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlS);
            this.btnSaveDict.Size = new System.Drawing.Size(70, 23);
            this.btnSaveDict.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.btnSaveDict.TabIndex = 6;
            this.btnSaveDict.Text = "保存(S)";
            this.btnSaveDict.Click += new System.EventHandler(this.btnSaveDict_Click);
            // 
            // ucLabel6
            // 
            this.ucLabel6.AutoSize = true;
            this.ucLabel6.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabel6.ForeColor = System.Drawing.Color.Gray;
            this.ucLabel6.Location = new System.Drawing.Point(8, 46);
            this.ucLabel6.Name = "ucLabel6";
            this.ucLabel6.Size = new System.Drawing.Size(65, 12);
            this.ucLabel6.TabIndex = 6;
            this.ucLabel6.Text = "字典编码：";
            // 
            // btnCancelDict
            // 
            this.btnCancelDict.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancelDict.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelDict.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancelDict.Image = global::ZNLCRM.UI.Properties.Resources.cancel_1;
            this.btnCancelDict.Location = new System.Drawing.Point(165, 156);
            this.btnCancelDict.Name = "btnCancelDict";
            this.btnCancelDict.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlC);
            this.btnCancelDict.Size = new System.Drawing.Size(73, 23);
            this.btnCancelDict.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.btnCancelDict.TabIndex = 6;
            this.btnCancelDict.Text = "取消(C)";
            this.btnCancelDict.Click += new System.EventHandler(this.btnCancelDict_Click);
            // 
            // txtDictGroupName
            // 
            // 
            // 
            // 
            this.txtDictGroupName.Border.Class = "TextBoxBorder";
            this.txtDictGroupName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDictGroupName.EnterToNextControl = false;
            this.txtDictGroupName.Location = new System.Drawing.Point(79, 15);
            this.txtDictGroupName.Name = "txtDictGroupName";
            this.txtDictGroupName.Size = new System.Drawing.Size(153, 21);
            this.txtDictGroupName.TabIndex = 0;
            // 
            // txtItemCode
            // 
            // 
            // 
            // 
            this.txtItemCode.Border.Class = "TextBoxBorder";
            this.txtItemCode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtItemCode.EnterToNextControl = false;
            this.txtItemCode.Location = new System.Drawing.Point(79, 44);
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.Size = new System.Drawing.Size(153, 21);
            this.txtItemCode.TabIndex = 0;
            // 
            // dgvDictItem
            // 
            this.dgvDictItem.AllowUserToAddRows = false;
            this.dgvDictItem.AllowUserToDeleteRows = false;
            this.dgvDictItem.AllowUserToOrderColumns = true;
            this.dgvDictItem.BackgroundColor = System.Drawing.Color.White;
            this.dgvDictItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDictItemLineID,
            this.colDictItemID,
            this.colItemValue,
            this.colItemValue2});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDictItem.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDictItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDictItem.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvDictItem.HighlightSelectedColumnHeaders = false;
            this.dgvDictItem.Location = new System.Drawing.Point(0, 0);
            this.dgvDictItem.Name = "dgvDictItem";
            this.dgvDictItem.PaintEnhancedSelection = false;
            this.dgvDictItem.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDictItem.RowHeadersWidth = 40;
            this.dgvDictItem.RowTemplate.Height = 23;
            this.dgvDictItem.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDictItem.SelectAllSignVisible = false;
            this.dgvDictItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvDictItem.ShowRowNo = true;
            this.dgvDictItem.Size = new System.Drawing.Size(853, 392);
            this.dgvDictItem.TabIndex = 0;
            // 
            // colDictItemLineID
            // 
            this.colDictItemLineID.DataPropertyName = "DictItemLineID";
            this.colDictItemLineID.HeaderText = "子项ID";
            this.colDictItemLineID.Name = "colDictItemLineID";
            this.colDictItemLineID.Visible = false;
            // 
            // colDictItemID
            // 
            this.colDictItemID.DataPropertyName = "DictItemID";
            this.colDictItemID.HeaderText = "数据字典ID";
            this.colDictItemID.Name = "colDictItemID";
            this.colDictItemID.Visible = false;
            // 
            // colItemValue
            // 
            this.colItemValue.DataPropertyName = "ItemValue";
            this.colItemValue.HeaderText = "项名称";
            this.colItemValue.Name = "colItemValue";
            // 
            // colItemValue2
            // 
            this.colItemValue2.DataPropertyName = "ItemValue2";
            this.colItemValue2.HeaderText = "项值";
            this.colItemValue2.Name = "colItemValue2";
            // 
            // ucPanel3
            // 
            this.ucPanel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ucPanel3.Controls.Add(this.btnSave);
            this.ucPanel3.Controls.Add(this.btnDelDictLine);
            this.ucPanel3.Controls.Add(this.btnAddDictLine);
            this.ucPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucPanel3.Location = new System.Drawing.Point(0, 0);
            this.ucPanel3.Name = "ucPanel3";
            this.ucPanel3.Size = new System.Drawing.Size(853, 37);
            this.ucPanel3.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Image = global::ZNLCRM.UI.Properties.Resources.save_1;
            this.btnSave.Location = new System.Drawing.Point(163, 7);
            this.btnSave.Name = "btnSave";
            this.btnSave.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlS);
            this.btnSave.Size = new System.Drawing.Size(72, 23);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "保存(S)";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelDictLine
            // 
            this.btnDelDictLine.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDelDictLine.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDelDictLine.Image = global::ZNLCRM.UI.Properties.Resources.del_4;
            this.btnDelDictLine.Location = new System.Drawing.Point(87, 7);
            this.btnDelDictLine.Name = "btnDelDictLine";
            this.btnDelDictLine.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlD);
            this.btnDelDictLine.Size = new System.Drawing.Size(70, 23);
            this.btnDelDictLine.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.btnDelDictLine.TabIndex = 6;
            this.btnDelDictLine.Text = "删除(D)";
            this.btnDelDictLine.Click += new System.EventHandler(this.btnDelDictLine_Click);
            // 
            // btnAddDictLine
            // 
            this.btnAddDictLine.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddDictLine.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAddDictLine.Image = global::ZNLCRM.UI.Properties.Resources.add_4;
            this.btnAddDictLine.Location = new System.Drawing.Point(10, 7);
            this.btnAddDictLine.Name = "btnAddDictLine";
            this.btnAddDictLine.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlA);
            this.btnAddDictLine.Size = new System.Drawing.Size(71, 23);
            this.btnAddDictLine.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.btnAddDictLine.TabIndex = 5;
            this.btnAddDictLine.Text = "添加(A)";
            this.btnAddDictLine.Click += new System.EventHandler(this.btnAddDictLine_Click);
            // 
            // ucExpandableSplitter1
            // 
            this.ucExpandableSplitter1.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207)))));
            this.ucExpandableSplitter1.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.ucExpandableSplitter1.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.ucExpandableSplitter1.ExpandFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207)))));
            this.ucExpandableSplitter1.ExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.ucExpandableSplitter1.ExpandLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ucExpandableSplitter1.ExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.ucExpandableSplitter1.GripDarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ucExpandableSplitter1.GripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.ucExpandableSplitter1.GripLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.ucExpandableSplitter1.GripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.ucExpandableSplitter1.HotBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(151)))), ((int)(((byte)(61)))));
            this.ucExpandableSplitter1.HotBackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(94)))));
            this.ucExpandableSplitter1.HotBackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground2;
            this.ucExpandableSplitter1.HotBackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground;
            this.ucExpandableSplitter1.HotExpandFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207)))));
            this.ucExpandableSplitter1.HotExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.ucExpandableSplitter1.HotExpandLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ucExpandableSplitter1.HotExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.ucExpandableSplitter1.HotGripDarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207)))));
            this.ucExpandableSplitter1.HotGripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.ucExpandableSplitter1.HotGripLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.ucExpandableSplitter1.HotGripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.ucExpandableSplitter1.Location = new System.Drawing.Point(273, 0);
            this.ucExpandableSplitter1.Name = "ucExpandableSplitter1";
            this.ucExpandableSplitter1.Size = new System.Drawing.Size(3, 429);
            this.ucExpandableSplitter1.Style = DevComponents.DotNetBar.eSplitterStyle.Office2007;
            this.ucExpandableSplitter1.TabIndex = 4;
            this.ucExpandableSplitter1.TabStop = false;
            // 
            // ucPanel1
            // 
            this.ucPanel1.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel1.Controls.Add(this.atDict);
            this.ucPanel1.Controls.Add(this.ucPanel7);
            this.ucPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.ucPanel1.Location = new System.Drawing.Point(0, 0);
            this.ucPanel1.Name = "ucPanel1";
            this.ucPanel1.Size = new System.Drawing.Size(273, 429);
            this.ucPanel1.TabIndex = 1;
            // 
            // atDict
            // 
            this.atDict.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline;
            this.atDict.AllowDrop = true;
            this.atDict.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.atDict.BackgroundStyle.Class = "TreeBorderKey";
            this.atDict.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.atDict.Dock = System.Windows.Forms.DockStyle.Fill;
            this.atDict.GridRowLines = true;
            this.atDict.Location = new System.Drawing.Point(0, 34);
            this.atDict.Name = "atDict";
            this.atDict.NodesConnector = this.nodeConnector1;
            this.atDict.NodeStyle = this.elementStyle1;
            this.atDict.PathSeparator = ";";
            this.atDict.Size = new System.Drawing.Size(273, 395);
            this.atDict.Styles.Add(this.elementStyle1);
            this.atDict.TabIndex = 0;
            this.atDict.SelectedIndexChanged += new System.EventHandler(this.atDict_SelectedIndexChanged);
            // 
            // nodeConnector1
            // 
            this.nodeConnector1.LineColor = System.Drawing.SystemColors.ControlText;
            // 
            // elementStyle1
            // 
            this.elementStyle1.Class = "";
            this.elementStyle1.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.elementStyle1.Name = "elementStyle1";
            this.elementStyle1.TextColor = System.Drawing.SystemColors.ControlText;
            // 
            // ucPanel7
            // 
            this.ucPanel7.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel7.Controls.Add(this.txtCondition);
            this.ucPanel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucPanel7.Location = new System.Drawing.Point(0, 0);
            this.ucPanel7.Name = "ucPanel7";
            this.ucPanel7.Size = new System.Drawing.Size(273, 34);
            this.ucPanel7.TabIndex = 1;
            // 
            // txtCondition
            // 
            // 
            // 
            // 
            this.txtCondition.Border.Class = "TextBoxBorder";
            this.txtCondition.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCondition.ButtonCustom.Image = global::ZNLCRM.UI.Properties.Resources.search;
            this.txtCondition.ButtonCustom.Visible = true;
            this.txtCondition.ButtonCustom2.Image = global::ZNLCRM.UI.Properties.Resources.del_6;
            this.txtCondition.ButtonCustom2.Visible = true;
            this.txtCondition.EnterToNextControl = false;
            this.txtCondition.Location = new System.Drawing.Point(12, 6);
            this.txtCondition.Name = "txtCondition";
            this.txtCondition.Size = new System.Drawing.Size(218, 22);
            this.txtCondition.TabIndex = 0;
            this.txtCondition.WatermarkText = "字典编码 /名称";
            this.txtCondition.ButtonCustomClick += new System.EventHandler(this.txtCondition_ButtonCustomClick);
            this.txtCondition.ButtonCustom2Click += new System.EventHandler(this.txtCondition_ButtonCustom2Click);
            // 
            // ucPanel5
            // 
            this.ucPanel5.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel5.Controls.Add(this.ucToolStrip1);
            this.ucPanel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucPanel5.Location = new System.Drawing.Point(0, 0);
            this.ucPanel5.Name = "ucPanel5";
            this.ucPanel5.Size = new System.Drawing.Size(1129, 36);
            this.ucPanel5.TabIndex = 5;
            // 
            // ucToolStrip1
            // 
            this.ucToolStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ucToolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddDict,
            this.btnEditDict,
            this.btnDelDict,
            this.toolStripSeparator1});
            this.ucToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.ucToolStrip1.Name = "ucToolStrip1";
            this.ucToolStrip1.Padding = new System.Windows.Forms.Padding(5);
            this.ucToolStrip1.Size = new System.Drawing.Size(1129, 36);
            this.ucToolStrip1.TabIndex = 4;
            this.ucToolStrip1.Text = "ucToolStrip1";
            // 
            // btnAddDict
            // 
            this.btnAddDict.Image = global::ZNLCRM.UI.Properties.Resources.add_1;
            this.btnAddDict.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddDict.Name = "btnAddDict";
            this.btnAddDict.Size = new System.Drawing.Size(100, 23);
            this.btnAddDict.Text = "添加数据字典";
            this.btnAddDict.Click += new System.EventHandler(this.btnAddDict_Click);
            // 
            // btnEditDict
            // 
            this.btnEditDict.Image = global::ZNLCRM.UI.Properties.Resources.edit_1;
            this.btnEditDict.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditDict.Name = "btnEditDict";
            this.btnEditDict.Size = new System.Drawing.Size(100, 23);
            this.btnEditDict.Text = "修改数据字典";
            this.btnEditDict.Click += new System.EventHandler(this.btnEditDict_Click);
            // 
            // btnDelDict
            // 
            this.btnDelDict.Image = global::ZNLCRM.UI.Properties.Resources.del_1;
            this.btnDelDict.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelDict.Name = "btnDelDict";
            this.btnDelDict.Size = new System.Drawing.Size(100, 23);
            this.btnDelDict.Text = "删除数据字典";
            this.btnDelDict.Click += new System.EventHandler(this.btnDelDict_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 26);
            // 
            // frmSYSDictManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 465);
            this.Controls.Add(this.ucPanel6);
            this.Controls.Add(this.ucPanel5);
            this.Name = "frmSYSDictManage";
            this.Text = "数据字典管理";
            this.Load += new System.EventHandler(this.frmSYSDictManage_Load);
            this.cmsDict.ResumeLayout(false);
            this.ucPanel6.ResumeLayout(false);
            this.ucPanel2.ResumeLayout(false);
            this.ucPanel4.ResumeLayout(false);
            this.ucPanel4.PerformLayout();
            this.grpDict.ResumeLayout(false);
            this.grpDict.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDictItem)).EndInit();
            this.ucPanel3.ResumeLayout(false);
            this.ucPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.atDict)).EndInit();
            this.ucPanel7.ResumeLayout(false);
            this.ucPanel5.ResumeLayout(false);
            this.ucPanel5.PerformLayout();
            this.ucToolStrip1.ResumeLayout(false);
            this.ucToolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.UcAdTree atDict;
        private DevComponents.AdvTree.NodeConnector nodeConnector1;
        private DevComponents.DotNetBar.ElementStyle elementStyle1;
        private Controls.UcPanel ucPanel1;
        private Controls.UcPanel ucPanel2;
        private Controls.UcPanel ucPanel4;
        private Controls.UcDataGridView dgvDictItem;
        private Controls.UcPanel ucPanel3;
        private Controls.UcButton btnAddDictLine;
        private Controls.UcToolStrip ucToolStrip1;
        private System.Windows.Forms.ToolStripButton btnAddDict;
        private System.Windows.Forms.ToolStripButton btnEditDict;
        private System.Windows.Forms.ToolStripButton btnDelDict;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private Controls.UcPanel ucPanel5;
        private Controls.UcPanel ucPanel6;
        private Controls.UcExpandableSplitter ucExpandableSplitter1;
        private Controls.UcPanel grpDict;
        private Controls.UcLabel ucLabel5;
        private Controls.UcTextBox txtDictItemID;
        private Controls.UcButton btnSaveDict;
        private Controls.UcLabel ucLabel6;
        private Controls.UcButton btnCancelDict;
        private Controls.UcTextBox txtDictGroupName;
        private Controls.UcTextBox txtItemCode;
        private Controls.UcTextBox txtItemName;
        private Controls.UcLabel 字典名称;
        private Controls.UcLabel ucLabel2;
        private Controls.UcComboBox cboValueType;
        private System.Windows.Forms.ContextMenuStrip cmsDict;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddDict;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditDict;
        private System.Windows.Forms.ToolStripMenuItem tsmiDelDict;
        private Controls.UcButton btnDelDictLine;
        private Controls.UcButton btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDictItemLineID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDictItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemValue2;
        private Controls.UcCheckBox cboIsSys;
        private Controls.UcPanel ucPanel7;
        private Controls.UcTextBox txtCondition;
    }
}