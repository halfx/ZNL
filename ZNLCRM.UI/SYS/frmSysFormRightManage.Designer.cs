namespace ZNLCRM.UI.SYS
{
    partial class frmSysFormRightManage
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
            this.expandableSplitter1 = new DevComponents.DotNetBar.ExpandableSplitter();
            this.ucPanel2 = new ZNLCRM.Controls.UcPanel(this.components);
            this.grpDgvModule = new System.Windows.Forms.GroupBox();
            this.dgvMain = new ZNLCRM.Controls.UcDataGridView(this.components);
            this.col_Sys_FormRight_FormRightID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Sys_FormRight_FormEngName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Sys_FormRight_FormChsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Sys_FormRight_UserControlEngName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Sys_FormRight_UserControlChsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Sys_FormRight_OprControlEngName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Sys_FormRight_OprControlChsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Sys_FormRight_OprPropertyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Sys_FormRight_ModuleID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Sys_FormRight_ModuleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Sys_FormRight_ActionCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Sys_FormRight_IsDeleted = new DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn();
            this.panWhere = new ZNLCRM.Controls.UcPanel(this.components);
            this.btnSearch = new ZNLCRM.Controls.UcButton(this.components);
            this.txfOprControlEngName = new ZNLCRM.Controls.UcTextBox(this.components);
            this.txfFormEngName = new ZNLCRM.Controls.UcTextBox(this.components);
            this.ucLabel1 = new ZNLCRM.Controls.UcLabel(this.components);
            this.ucLabel9 = new ZNLCRM.Controls.UcLabel(this.components);
            this.ucPage = new ZNLCRM.Controls.UcPanel(this.components);
            this.pagForm = new ZNLCRM.Controls.UcPager();
            this.ucPanel1 = new ZNLCRM.Controls.UcPanel(this.components);
            this.treeNameSpace = new ZNLCRM.Controls.UcAdTree(this.components);
            this.nodeConnector1 = new DevComponents.AdvTree.NodeConnector();
            this.elementStyle1 = new DevComponents.DotNetBar.ElementStyle();
            this.tlbEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tlbDel = new System.Windows.Forms.ToolStripButton();
            this.panTopMain = new ZNLCRM.Controls.UcPanel(this.components);
            this.tlbMain = new ZNLCRM.Controls.UcToolStrip(this.components);
            this.tlbAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.miniToolStrip = new ZNLCRM.Controls.UcToolStrip(this.components);
            this.panMid.SuspendLayout();
            this.ucPanel2.SuspendLayout();
            this.grpDgvModule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.panWhere.SuspendLayout();
            this.ucPage.SuspendLayout();
            this.ucPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeNameSpace)).BeginInit();
            this.panTopMain.SuspendLayout();
            this.tlbMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panMid
            // 
            this.panMid.BackColor = System.Drawing.Color.Transparent;
            this.panMid.Controls.Add(this.expandableSplitter1);
            this.panMid.Controls.Add(this.ucPanel2);
            this.panMid.Controls.Add(this.ucPanel1);
            this.panMid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panMid.Location = new System.Drawing.Point(0, 33);
            this.panMid.Name = "panMid";
            this.panMid.Padding = new System.Windows.Forms.Padding(5);
            this.panMid.Size = new System.Drawing.Size(891, 403);
            this.panMid.TabIndex = 7;
            // 
            // expandableSplitter1
            // 
            this.expandableSplitter1.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207)))));
            this.expandableSplitter1.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter1.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandableSplitter1.ExpandFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207)))));
            this.expandableSplitter1.ExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter1.ExpandLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.expandableSplitter1.ExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandableSplitter1.GripDarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.expandableSplitter1.GripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandableSplitter1.GripLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.expandableSplitter1.GripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.expandableSplitter1.HotBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(151)))), ((int)(((byte)(61)))));
            this.expandableSplitter1.HotBackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(94)))));
            this.expandableSplitter1.HotBackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground2;
            this.expandableSplitter1.HotBackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground;
            this.expandableSplitter1.HotExpandFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207)))));
            this.expandableSplitter1.HotExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter1.HotExpandLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.expandableSplitter1.HotExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandableSplitter1.HotGripDarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207)))));
            this.expandableSplitter1.HotGripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter1.HotGripLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.expandableSplitter1.HotGripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.expandableSplitter1.Location = new System.Drawing.Point(210, 5);
            this.expandableSplitter1.Name = "expandableSplitter1";
            this.expandableSplitter1.Size = new System.Drawing.Size(6, 393);
            this.expandableSplitter1.Style = DevComponents.DotNetBar.eSplitterStyle.Office2007;
            this.expandableSplitter1.TabIndex = 6;
            this.expandableSplitter1.TabStop = false;
            // 
            // ucPanel2
            // 
            this.ucPanel2.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel2.Controls.Add(this.grpDgvModule);
            this.ucPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPanel2.Location = new System.Drawing.Point(210, 5);
            this.ucPanel2.Name = "ucPanel2";
            this.ucPanel2.Padding = new System.Windows.Forms.Padding(5);
            this.ucPanel2.Size = new System.Drawing.Size(676, 393);
            this.ucPanel2.TabIndex = 5;
            // 
            // grpDgvModule
            // 
            this.grpDgvModule.Controls.Add(this.dgvMain);
            this.grpDgvModule.Controls.Add(this.panWhere);
            this.grpDgvModule.Controls.Add(this.ucPage);
            this.grpDgvModule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDgvModule.Location = new System.Drawing.Point(5, 5);
            this.grpDgvModule.Name = "grpDgvModule";
            this.grpDgvModule.Size = new System.Drawing.Size(666, 383);
            this.grpDgvModule.TabIndex = 1;
            this.grpDgvModule.TabStop = false;
            this.grpDgvModule.Text = "模块列表";
            // 
            // dgvMain
            // 
            this.dgvMain.AllowUserToAddRows = false;
            this.dgvMain.AllowUserToDeleteRows = false;
            this.dgvMain.AllowUserToOrderColumns = true;
            this.dgvMain.BackgroundColor = System.Drawing.Color.White;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_Sys_FormRight_FormRightID,
            this.col_Sys_FormRight_FormEngName,
            this.col_Sys_FormRight_FormChsName,
            this.col_Sys_FormRight_UserControlEngName,
            this.col_Sys_FormRight_UserControlChsName,
            this.col_Sys_FormRight_OprControlEngName,
            this.col_Sys_FormRight_OprControlChsName,
            this.col_Sys_FormRight_OprPropertyName,
            this.col_Sys_FormRight_ModuleID,
            this.col_Sys_FormRight_ModuleName,
            this.col_Sys_FormRight_ActionCode,
            this.col_Sys_FormRight_IsDeleted});
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
            this.dgvMain.Location = new System.Drawing.Point(3, 50);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.PaintEnhancedSelection = false;
            this.dgvMain.ReadOnly = true;
            this.dgvMain.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvMain.RowTemplate.Height = 23;
            this.dgvMain.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMain.SelectAllSignVisible = false;
            this.dgvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvMain.Size = new System.Drawing.Size(660, 304);
            this.dgvMain.TabIndex = 3;
            this.dgvMain.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvMain_CellMouseDoubleClick);
            // 
            // col_Sys_FormRight_FormRightID
            // 
            this.col_Sys_FormRight_FormRightID.DataPropertyName = "FormRightID";
            this.col_Sys_FormRight_FormRightID.HeaderText = "key";
            this.col_Sys_FormRight_FormRightID.Name = "col_Sys_FormRight_FormRightID";
            this.col_Sys_FormRight_FormRightID.ReadOnly = true;
            this.col_Sys_FormRight_FormRightID.Visible = false;
            this.col_Sys_FormRight_FormRightID.Width = 30;
            // 
            // col_Sys_FormRight_FormEngName
            // 
            this.col_Sys_FormRight_FormEngName.DataPropertyName = "FormEngName";
            this.col_Sys_FormRight_FormEngName.HeaderText = "窗体英文名";
            this.col_Sys_FormRight_FormEngName.Name = "col_Sys_FormRight_FormEngName";
            this.col_Sys_FormRight_FormEngName.ReadOnly = true;
            // 
            // col_Sys_FormRight_FormChsName
            // 
            this.col_Sys_FormRight_FormChsName.DataPropertyName = "FormChsName";
            this.col_Sys_FormRight_FormChsName.HeaderText = "窗体中文名称";
            this.col_Sys_FormRight_FormChsName.Name = "col_Sys_FormRight_FormChsName";
            this.col_Sys_FormRight_FormChsName.ReadOnly = true;
            // 
            // col_Sys_FormRight_UserControlEngName
            // 
            this.col_Sys_FormRight_UserControlEngName.DataPropertyName = "UserControlEngName";
            this.col_Sys_FormRight_UserControlEngName.HeaderText = "用户控件英文名";
            this.col_Sys_FormRight_UserControlEngName.Name = "col_Sys_FormRight_UserControlEngName";
            this.col_Sys_FormRight_UserControlEngName.ReadOnly = true;
            // 
            // col_Sys_FormRight_UserControlChsName
            // 
            this.col_Sys_FormRight_UserControlChsName.DataPropertyName = "UserControlChsName";
            this.col_Sys_FormRight_UserControlChsName.HeaderText = "用户控件中文名";
            this.col_Sys_FormRight_UserControlChsName.Name = "col_Sys_FormRight_UserControlChsName";
            this.col_Sys_FormRight_UserControlChsName.ReadOnly = true;
            // 
            // col_Sys_FormRight_OprControlEngName
            // 
            this.col_Sys_FormRight_OprControlEngName.DataPropertyName = "OprControlEngName";
            this.col_Sys_FormRight_OprControlEngName.HeaderText = "操作控件英文名";
            this.col_Sys_FormRight_OprControlEngName.Name = "col_Sys_FormRight_OprControlEngName";
            this.col_Sys_FormRight_OprControlEngName.ReadOnly = true;
            // 
            // col_Sys_FormRight_OprControlChsName
            // 
            this.col_Sys_FormRight_OprControlChsName.DataPropertyName = "OprControlChsName";
            this.col_Sys_FormRight_OprControlChsName.HeaderText = "操作控件中文名";
            this.col_Sys_FormRight_OprControlChsName.Name = "col_Sys_FormRight_OprControlChsName";
            this.col_Sys_FormRight_OprControlChsName.ReadOnly = true;
            // 
            // col_Sys_FormRight_OprPropertyName
            // 
            this.col_Sys_FormRight_OprPropertyName.DataPropertyName = "OprPropertyName";
            this.col_Sys_FormRight_OprPropertyName.HeaderText = "属性名";
            this.col_Sys_FormRight_OprPropertyName.Name = "col_Sys_FormRight_OprPropertyName";
            this.col_Sys_FormRight_OprPropertyName.ReadOnly = true;
            // 
            // col_Sys_FormRight_ModuleID
            // 
            this.col_Sys_FormRight_ModuleID.DataPropertyName = "ModuleID";
            this.col_Sys_FormRight_ModuleID.HeaderText = "模块ID";
            this.col_Sys_FormRight_ModuleID.Name = "col_Sys_FormRight_ModuleID";
            this.col_Sys_FormRight_ModuleID.ReadOnly = true;
            // 
            // col_Sys_FormRight_ModuleName
            // 
            this.col_Sys_FormRight_ModuleName.DataPropertyName = "ModuleName";
            this.col_Sys_FormRight_ModuleName.HeaderText = "模块名称";
            this.col_Sys_FormRight_ModuleName.Name = "col_Sys_FormRight_ModuleName";
            this.col_Sys_FormRight_ModuleName.ReadOnly = true;
            // 
            // col_Sys_FormRight_ActionCode
            // 
            this.col_Sys_FormRight_ActionCode.DataPropertyName = "ActionCode";
            this.col_Sys_FormRight_ActionCode.HeaderText = "对应权限";
            this.col_Sys_FormRight_ActionCode.Name = "col_Sys_FormRight_ActionCode";
            this.col_Sys_FormRight_ActionCode.ReadOnly = true;
            // 
            // col_Sys_FormRight_IsDeleted
            // 
            this.col_Sys_FormRight_IsDeleted.Checked = true;
            this.col_Sys_FormRight_IsDeleted.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.col_Sys_FormRight_IsDeleted.CheckValue = "N";
            this.col_Sys_FormRight_IsDeleted.DataPropertyName = "IsDeleted";
            this.col_Sys_FormRight_IsDeleted.HeaderText = "是否删除";
            this.col_Sys_FormRight_IsDeleted.Name = "col_Sys_FormRight_IsDeleted";
            this.col_Sys_FormRight_IsDeleted.ReadOnly = true;
            this.col_Sys_FormRight_IsDeleted.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_Sys_FormRight_IsDeleted.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // panWhere
            // 
            this.panWhere.BackColor = System.Drawing.Color.Transparent;
            this.panWhere.Controls.Add(this.btnSearch);
            this.panWhere.Controls.Add(this.txfOprControlEngName);
            this.panWhere.Controls.Add(this.txfFormEngName);
            this.panWhere.Controls.Add(this.ucLabel1);
            this.panWhere.Controls.Add(this.ucLabel9);
            this.panWhere.Dock = System.Windows.Forms.DockStyle.Top;
            this.panWhere.Location = new System.Drawing.Point(3, 17);
            this.panWhere.Name = "panWhere";
            this.panWhere.Size = new System.Drawing.Size(660, 33);
            this.panWhere.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSearch.Image = global::ZNLCRM.UI.Properties.Resources.search;
            this.btnSearch.Location = new System.Drawing.Point(569, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSearch.TabIndex = 23;
            this.btnSearch.Text = "搜索";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txfOprControlEngName
            // 
            // 
            // 
            // 
            this.txfOprControlEngName.Border.Class = "TextBoxBorder";
            this.txfOprControlEngName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txfOprControlEngName.EnterToNextControl = false;
            this.txfOprControlEngName.Location = new System.Drawing.Point(317, 5);
            this.txfOprControlEngName.Name = "txfOprControlEngName";
            this.txfOprControlEngName.Size = new System.Drawing.Size(144, 21);
            this.txfOprControlEngName.TabIndex = 21;
            this.txfOprControlEngName.TextChanged += new System.EventHandler(this.ucTextBox1_TextChanged);
            // 
            // txfFormEngName
            // 
            // 
            // 
            // 
            this.txfFormEngName.Border.Class = "TextBoxBorder";
            this.txfFormEngName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txfFormEngName.EnterToNextControl = false;
            this.txfFormEngName.Location = new System.Drawing.Point(90, 5);
            this.txfFormEngName.Name = "txfFormEngName";
            this.txfFormEngName.Size = new System.Drawing.Size(144, 21);
            this.txfFormEngName.TabIndex = 21;
            // 
            // ucLabel1
            // 
            this.ucLabel1.AutoSize = true;
            this.ucLabel1.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabel1.ForeColor = System.Drawing.Color.Gray;
            this.ucLabel1.Location = new System.Drawing.Point(240, 10);
            this.ucLabel1.Name = "ucLabel1";
            this.ucLabel1.Size = new System.Drawing.Size(77, 12);
            this.ucLabel1.TabIndex = 22;
            this.ucLabel1.Text = "控件英文名：";
            // 
            // ucLabel9
            // 
            this.ucLabel9.AutoSize = true;
            this.ucLabel9.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabel9.ForeColor = System.Drawing.Color.Gray;
            this.ucLabel9.Location = new System.Drawing.Point(13, 10);
            this.ucLabel9.Name = "ucLabel9";
            this.ucLabel9.Size = new System.Drawing.Size(77, 12);
            this.ucLabel9.TabIndex = 22;
            this.ucLabel9.Text = "窗体英文名：";
            // 
            // ucPage
            // 
            this.ucPage.BackColor = System.Drawing.Color.Transparent;
            this.ucPage.Controls.Add(this.pagForm);
            this.ucPage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucPage.Location = new System.Drawing.Point(3, 354);
            this.ucPage.Name = "ucPage";
            this.ucPage.Padding = new System.Windows.Forms.Padding(5);
            this.ucPage.Size = new System.Drawing.Size(660, 26);
            this.ucPage.TabIndex = 4;
            // 
            // pagForm
            // 
            this.pagForm.BackColor = System.Drawing.Color.Transparent;
            this.pagForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pagForm.Location = new System.Drawing.Point(5, 5);
            this.pagForm.Name = "pagForm";
            this.pagForm.RecordCount = 0;
            this.pagForm.Size = new System.Drawing.Size(650, 16);
            this.pagForm.TabIndex = 1;
            this.pagForm.PageIndexChanging += new ZNLCRM.Controls.UcPager.dlgPageIndexChanging(this.pagForm_PageIndexChanging);
            // 
            // ucPanel1
            // 
            this.ucPanel1.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel1.Controls.Add(this.treeNameSpace);
            this.ucPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.ucPanel1.Location = new System.Drawing.Point(5, 5);
            this.ucPanel1.Name = "ucPanel1";
            this.ucPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.ucPanel1.Size = new System.Drawing.Size(205, 393);
            this.ucPanel1.TabIndex = 5;
            // 
            // treeNameSpace
            // 
            this.treeNameSpace.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline;
            this.treeNameSpace.AllowDrop = true;
            this.treeNameSpace.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.treeNameSpace.BackgroundStyle.Class = "TreeBorderKey";
            this.treeNameSpace.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.treeNameSpace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeNameSpace.Location = new System.Drawing.Point(5, 5);
            this.treeNameSpace.Name = "treeNameSpace";
            this.treeNameSpace.NodesConnector = this.nodeConnector1;
            this.treeNameSpace.NodeStyle = this.elementStyle1;
            this.treeNameSpace.PathSeparator = ";";
            this.treeNameSpace.Size = new System.Drawing.Size(195, 383);
            this.treeNameSpace.Styles.Add(this.elementStyle1);
            this.treeNameSpace.TabIndex = 0;
            this.treeNameSpace.Text = "ucAdTree1";
            this.treeNameSpace.NodeClick += new DevComponents.AdvTree.TreeNodeMouseEventHandler(this.treeNameSpace_NodeClick);
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
            // tlbEdit
            // 
            this.tlbEdit.Image = global::ZNLCRM.UI.Properties.Resources.modify;
            this.tlbEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlbEdit.Name = "tlbEdit";
            this.tlbEdit.Size = new System.Drawing.Size(52, 21);
            this.tlbEdit.Text = "修改";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 24);
            // 
            // tlbDel
            // 
            this.tlbDel.Image = global::ZNLCRM.UI.Properties.Resources.del;
            this.tlbDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlbDel.Name = "tlbDel";
            this.tlbDel.Size = new System.Drawing.Size(52, 21);
            this.tlbDel.Text = "删除";
            // 
            // panTopMain
            // 
            this.panTopMain.BackColor = System.Drawing.Color.Transparent;
            this.panTopMain.Controls.Add(this.tlbMain);
            this.panTopMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.panTopMain.Location = new System.Drawing.Point(0, 0);
            this.panTopMain.Name = "panTopMain";
            this.panTopMain.Size = new System.Drawing.Size(891, 33);
            this.panTopMain.TabIndex = 8;
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
            this.tlbMain.Size = new System.Drawing.Size(891, 34);
            this.tlbMain.TabIndex = 4;
            this.tlbMain.Text = "ucToolStrip1";
            this.tlbMain.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.tlbMain_ItemClicked);
            // 
            // tlbAdd
            // 
            this.tlbAdd.Image = global::ZNLCRM.UI.Properties.Resources.add;
            this.tlbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlbAdd.Name = "tlbAdd";
            this.tlbAdd.Size = new System.Drawing.Size(76, 21);
            this.tlbAdd.Text = "添加模块";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 24);
            // 
            // miniToolStrip
            // 
            this.miniToolStrip.AutoSize = false;
            this.miniToolStrip.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.miniToolStrip.CanOverflow = false;
            this.miniToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.miniToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.miniToolStrip.Location = new System.Drawing.Point(62, 7);
            this.miniToolStrip.Name = "miniToolStrip";
            this.miniToolStrip.Padding = new System.Windows.Forms.Padding(5);
            this.miniToolStrip.Size = new System.Drawing.Size(1048, 34);
            this.miniToolStrip.TabIndex = 6;
            // 
            // frmSysFormRightManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 436);
            this.Controls.Add(this.panMid);
            this.Controls.Add(this.panTopMain);
            this.Controls.Add(this.miniToolStrip);
            this.Name = "frmSysFormRightManage";
            this.Text = "窗体操作权限定义";
            this.Load += new System.EventHandler(this.frmSysFormRightManage_Load);
            this.panMid.ResumeLayout(false);
            this.ucPanel2.ResumeLayout(false);
            this.grpDgvModule.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.panWhere.ResumeLayout(false);
            this.panWhere.PerformLayout();
            this.ucPage.ResumeLayout(false);
            this.ucPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeNameSpace)).EndInit();
            this.panTopMain.ResumeLayout(false);
            this.panTopMain.PerformLayout();
            this.tlbMain.ResumeLayout(false);
            this.tlbMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.UcPanel panMid;
        private DevComponents.DotNetBar.ExpandableSplitter expandableSplitter1;
        private Controls.UcPanel ucPanel2;
        private System.Windows.Forms.GroupBox grpDgvModule;
        private Controls.UcPanel ucPanel1;
        private Controls.UcAdTree treeNameSpace;
        private DevComponents.AdvTree.NodeConnector nodeConnector1;
        private DevComponents.DotNetBar.ElementStyle elementStyle1;
        private System.Windows.Forms.ToolStripButton tlbEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tlbDel;
        private Controls.UcPanel panTopMain;
        private Controls.UcToolStrip tlbMain;
        private System.Windows.Forms.ToolStripButton tlbAdd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private Controls.UcToolStrip miniToolStrip;
        private Controls.UcDataGridView dgvMain;
        private Controls.UcPanel panWhere;
        private Controls.UcPanel ucPage;
        private Controls.UcPager pagForm;
        private Controls.UcTextBox txfFormEngName;
        private Controls.UcLabel ucLabel9;
        private Controls.UcButton btnSearch;
        private Controls.UcTextBox txfOprControlEngName;
        private Controls.UcLabel ucLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Sys_FormRight_FormRightID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Sys_FormRight_FormEngName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Sys_FormRight_FormChsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Sys_FormRight_UserControlEngName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Sys_FormRight_UserControlChsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Sys_FormRight_OprControlEngName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Sys_FormRight_OprControlChsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Sys_FormRight_OprPropertyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Sys_FormRight_ModuleID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Sys_FormRight_ModuleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Sys_FormRight_ActionCode;
        private DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn col_Sys_FormRight_IsDeleted;
    }
}