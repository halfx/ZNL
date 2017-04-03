namespace ZNLCRM.UI.SYS
{
    partial class frmSelectModule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelectModule));
            this.panMid = new ZNLCRM.Controls.UcPanel(this.components);
            this.ucTabControl1 = new ZNLCRM.Controls.UcTabControl(this.components);
            this.tabControlPanel1 = new DevComponents.DotNetBar.TabControlPanel();
            this.ucPanel2 = new ZNLCRM.Controls.UcPanel(this.components);
            this.grpDgvModule = new System.Windows.Forms.GroupBox();
            this.dgvModule = new ZNLCRM.Controls.UcDataGridView(this.components);
            this.col_Sys_Module_ModuleID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Sys_Module_ModuleCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Sys_Module_ModuleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Sys_Module_ActionCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ucPanel3 = new ZNLCRM.Controls.UcPanel(this.components);
            this.pagModule = new ZNLCRM.Controls.UcPager();
            this.grpSearch = new ZNLCRM.Controls.UcPanel(this.components);
            this.btnSearch = new ZNLCRM.Controls.UcButton(this.components);
            this.ucLabel2 = new ZNLCRM.Controls.UcLabel(this.components);
            this.txfModuleName = new ZNLCRM.Controls.UcTextBox(this.components);
            this.chkAll = new ZNLCRM.Controls.UcCheckBox(this.components);
            this.expandableSplitter1 = new DevComponents.DotNetBar.ExpandableSplitter();
            this.ucPanel1 = new ZNLCRM.Controls.UcPanel(this.components);
            this.treMenu = new ZNLCRM.Controls.UcAdTree(this.components);
            this.node1 = new DevComponents.AdvTree.Node();
            this.nodeConnector1 = new DevComponents.AdvTree.NodeConnector();
            this.elementStyle1 = new DevComponents.DotNetBar.ElementStyle();
            this.tabSlcModule = new DevComponents.DotNetBar.TabItem(this.components);
            this.panBottom = new ZNLCRM.Controls.UcPanel(this.components);
            this.btnCancel = new ZNLCRM.Controls.UcButton(this.components);
            this.btnOK = new ZNLCRM.Controls.UcButton(this.components);
            this.panMid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ucTabControl1)).BeginInit();
            this.ucTabControl1.SuspendLayout();
            this.tabControlPanel1.SuspendLayout();
            this.ucPanel2.SuspendLayout();
            this.grpDgvModule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModule)).BeginInit();
            this.ucPanel3.SuspendLayout();
            this.grpSearch.SuspendLayout();
            this.ucPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treMenu)).BeginInit();
            this.panBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // panMid
            // 
            this.panMid.BackColor = System.Drawing.Color.Transparent;
            this.panMid.Controls.Add(this.ucTabControl1);
            this.panMid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panMid.Location = new System.Drawing.Point(0, 0);
            this.panMid.Name = "panMid";
            this.panMid.Padding = new System.Windows.Forms.Padding(5);
            this.panMid.Size = new System.Drawing.Size(951, 378);
            this.panMid.TabIndex = 7;
            // 
            // ucTabControl1
            // 
            this.ucTabControl1.BackColor = System.Drawing.Color.Transparent;
            this.ucTabControl1.CanReorderTabs = true;
            this.ucTabControl1.Controls.Add(this.tabControlPanel1);
            this.ucTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucTabControl1.Location = new System.Drawing.Point(5, 5);
            this.ucTabControl1.Name = "ucTabControl1";
            this.ucTabControl1.SelectedTabFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold);
            this.ucTabControl1.SelectedTabIndex = 0;
            this.ucTabControl1.Size = new System.Drawing.Size(941, 368);
            this.ucTabControl1.Style = DevComponents.DotNetBar.eTabStripStyle.VS2005;
            this.ucTabControl1.TabIndex = 9;
            this.ucTabControl1.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            this.ucTabControl1.Tabs.Add(this.tabSlcModule);
            this.ucTabControl1.Text = "ucTabControl1";
            // 
            // tabControlPanel1
            // 
            this.tabControlPanel1.Controls.Add(this.ucPanel2);
            this.tabControlPanel1.Controls.Add(this.expandableSplitter1);
            this.tabControlPanel1.Controls.Add(this.ucPanel1);
            this.tabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel1.Location = new System.Drawing.Point(0, 25);
            this.tabControlPanel1.Name = "tabControlPanel1";
            this.tabControlPanel1.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel1.Size = new System.Drawing.Size(941, 343);
            this.tabControlPanel1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(242)))), ((int)(((byte)(232)))));
            this.tabControlPanel1.Style.BackColor2.Color = System.Drawing.Color.White;
            this.tabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(168)))), ((int)(((byte)(153)))));
            this.tabControlPanel1.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right)
                        | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel1.Style.GradientAngle = 90;
            this.tabControlPanel1.TabIndex = 1;
            this.tabControlPanel1.TabItem = this.tabSlcModule;
            // 
            // ucPanel2
            // 
            this.ucPanel2.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel2.Controls.Add(this.grpDgvModule);
            this.ucPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPanel2.Location = new System.Drawing.Point(201, 1);
            this.ucPanel2.Name = "ucPanel2";
            this.ucPanel2.Padding = new System.Windows.Forms.Padding(5);
            this.ucPanel2.Size = new System.Drawing.Size(739, 341);
            this.ucPanel2.TabIndex = 5;
            // 
            // grpDgvModule
            // 
            this.grpDgvModule.Controls.Add(this.dgvModule);
            this.grpDgvModule.Controls.Add(this.ucPanel3);
            this.grpDgvModule.Controls.Add(this.grpSearch);
            this.grpDgvModule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDgvModule.Location = new System.Drawing.Point(5, 5);
            this.grpDgvModule.Name = "grpDgvModule";
            this.grpDgvModule.Size = new System.Drawing.Size(729, 331);
            this.grpDgvModule.TabIndex = 1;
            this.grpDgvModule.TabStop = false;
            this.grpDgvModule.Text = "模块列表";
            // 
            // dgvModule
            // 
            this.dgvModule.AllowUserToAddRows = false;
            this.dgvModule.AllowUserToDeleteRows = false;
            this.dgvModule.AllowUserToOrderColumns = true;
            this.dgvModule.BackgroundColor = System.Drawing.Color.White;
            this.dgvModule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_Sys_Module_ModuleID,
            this.col_Sys_Module_ModuleCode,
            this.col_Sys_Module_ModuleName,
            this.col_Sys_Module_ActionCode});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvModule.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvModule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvModule.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvModule.HighlightSelectedColumnHeaders = false;
            this.dgvModule.Location = new System.Drawing.Point(3, 47);
            this.dgvModule.Name = "dgvModule";
            this.dgvModule.PaintEnhancedSelection = false;
            this.dgvModule.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvModule.RowTemplate.Height = 23;
            this.dgvModule.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvModule.SelectAllSignVisible = false;
            this.dgvModule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvModule.Size = new System.Drawing.Size(723, 250);
            this.dgvModule.TabIndex = 0;
            // 
            // col_Sys_Module_ModuleID
            // 
            this.col_Sys_Module_ModuleID.DataPropertyName = "ModuleID";
            this.col_Sys_Module_ModuleID.HeaderText = "模块ID";
            this.col_Sys_Module_ModuleID.Name = "col_Sys_Module_ModuleID";
            this.col_Sys_Module_ModuleID.ReadOnly = true;
            this.col_Sys_Module_ModuleID.Visible = false;
            // 
            // col_Sys_Module_ModuleCode
            // 
            this.col_Sys_Module_ModuleCode.DataPropertyName = "ModuleCode";
            this.col_Sys_Module_ModuleCode.HeaderText = "模块编号";
            this.col_Sys_Module_ModuleCode.Name = "col_Sys_Module_ModuleCode";
            this.col_Sys_Module_ModuleCode.ReadOnly = true;
            // 
            // col_Sys_Module_ModuleName
            // 
            this.col_Sys_Module_ModuleName.DataPropertyName = "ModuleName";
            this.col_Sys_Module_ModuleName.HeaderText = "模块名称";
            this.col_Sys_Module_ModuleName.Name = "col_Sys_Module_ModuleName";
            this.col_Sys_Module_ModuleName.ReadOnly = true;
            // 
            // col_Sys_Module_ActionCode
            // 
            this.col_Sys_Module_ActionCode.DataPropertyName = "ActionCode";
            this.col_Sys_Module_ActionCode.HeaderText = "权限关键字";
            this.col_Sys_Module_ActionCode.Name = "col_Sys_Module_ActionCode";
            this.col_Sys_Module_ActionCode.ReadOnly = true;
            this.col_Sys_Module_ActionCode.Width = 300;
            // 
            // ucPanel3
            // 
            this.ucPanel3.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel3.Controls.Add(this.pagModule);
            this.ucPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucPanel3.Location = new System.Drawing.Point(3, 297);
            this.ucPanel3.Name = "ucPanel3";
            this.ucPanel3.Size = new System.Drawing.Size(723, 31);
            this.ucPanel3.TabIndex = 4;
            // 
            // pagModule
            // 
            this.pagModule.BackColor = System.Drawing.Color.Transparent;
            this.pagModule.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pagModule.Location = new System.Drawing.Point(0, 5);
            this.pagModule.Name = "pagModule";
            this.pagModule.RecordCount = 0;
            this.pagModule.Size = new System.Drawing.Size(723, 26);
            this.pagModule.TabIndex = 2;
            // 
            // grpSearch
            // 
            this.grpSearch.BackColor = System.Drawing.Color.Transparent;
            this.grpSearch.Controls.Add(this.btnSearch);
            this.grpSearch.Controls.Add(this.ucLabel2);
            this.grpSearch.Controls.Add(this.txfModuleName);
            this.grpSearch.Controls.Add(this.chkAll);
            this.grpSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpSearch.Location = new System.Drawing.Point(3, 17);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(723, 30);
            this.grpSearch.TabIndex = 3;
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
            // ucLabel2
            // 
            this.ucLabel2.AutoSize = true;
            this.ucLabel2.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabel2.ForeColor = System.Drawing.Color.Gray;
            this.ucLabel2.Location = new System.Drawing.Point(6, 7);
            this.ucLabel2.Name = "ucLabel2";
            this.ucLabel2.Size = new System.Drawing.Size(65, 12);
            this.ucLabel2.TabIndex = 2;
            this.ucLabel2.Text = "模块名称：";
            // 
            // txfModuleName
            // 
            // 
            // 
            // 
            this.txfModuleName.Border.Class = "TextBoxBorder";
            this.txfModuleName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txfModuleName.EnterToNextControl = false;
            this.txfModuleName.Location = new System.Drawing.Point(77, 3);
            this.txfModuleName.Name = "txfModuleName";
            this.txfModuleName.Size = new System.Drawing.Size(208, 21);
            this.txfModuleName.TabIndex = 3;
            // 
            // chkAll
            // 
            // 
            // 
            // 
            this.chkAll.BackgroundStyle.Class = "";
            this.chkAll.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkAll.Location = new System.Drawing.Point(395, 7);
            this.chkAll.Name = "chkAll";
            this.chkAll.Size = new System.Drawing.Size(64, 17);
            this.chkAll.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chkAll.TabIndex = 2;
            this.chkAll.Text = "全选";
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
            this.expandableSplitter1.Location = new System.Drawing.Point(198, 1);
            this.expandableSplitter1.Name = "expandableSplitter1";
            this.expandableSplitter1.Size = new System.Drawing.Size(3, 341);
            this.expandableSplitter1.Style = DevComponents.DotNetBar.eSplitterStyle.Office2007;
            this.expandableSplitter1.TabIndex = 7;
            this.expandableSplitter1.TabStop = false;
            // 
            // ucPanel1
            // 
            this.ucPanel1.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel1.Controls.Add(this.treMenu);
            this.ucPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.ucPanel1.Location = new System.Drawing.Point(1, 1);
            this.ucPanel1.Name = "ucPanel1";
            this.ucPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.ucPanel1.Size = new System.Drawing.Size(197, 341);
            this.ucPanel1.TabIndex = 5;
            // 
            // treMenu
            // 
            this.treMenu.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline;
            this.treMenu.AllowDrop = true;
            this.treMenu.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.treMenu.BackgroundStyle.Class = "TreeBorderKey";
            this.treMenu.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.treMenu.CellLayout = DevComponents.AdvTree.eCellLayout.Horizontal;
            this.treMenu.CellPartLayout = DevComponents.AdvTree.eCellPartLayout.Horizontal;
            this.treMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treMenu.Location = new System.Drawing.Point(5, 5);
            this.treMenu.Name = "treMenu";
            this.treMenu.Nodes.AddRange(new DevComponents.AdvTree.Node[] {
            this.node1});
            this.treMenu.NodesConnector = this.nodeConnector1;
            this.treMenu.NodeStyle = this.elementStyle1;
            this.treMenu.PathSeparator = ";";
            this.treMenu.Size = new System.Drawing.Size(187, 331);
            this.treMenu.Styles.Add(this.elementStyle1);
            this.treMenu.TabIndex = 0;
            this.treMenu.NodeClick += new DevComponents.AdvTree.TreeNodeMouseEventHandler(this.treMenu_NodeClick);
            // 
            // node1
            // 
            this.node1.Expanded = true;
            this.node1.Name = "node1";
            this.node1.Text = "node1";
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
            // tabSlcModule
            // 
            this.tabSlcModule.AttachedControl = this.tabControlPanel1;
            this.tabSlcModule.Image = ((System.Drawing.Image)(resources.GetObject("tabSlcModule.Image")));
            this.tabSlcModule.Name = "tabSlcModule";
            this.tabSlcModule.Text = "功能模块选择";
            // 
            // panBottom
            // 
            this.panBottom.BackColor = System.Drawing.Color.Transparent;
            this.panBottom.Controls.Add(this.btnCancel);
            this.panBottom.Controls.Add(this.btnOK);
            this.panBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panBottom.Location = new System.Drawing.Point(0, 378);
            this.panBottom.Name = "panBottom";
            this.panBottom.Size = new System.Drawing.Size(951, 47);
            this.panBottom.TabIndex = 8;
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(502, 6);
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
            this.btnOK.Location = new System.Drawing.Point(392, 6);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(86, 30);
            this.btnOK.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "确定(&S)";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // frmSelectModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 425);
            this.Controls.Add(this.panMid);
            this.Controls.Add(this.panBottom);
            this.Name = "frmSelectModule";
            this.Text = "选择模块";
            this.Load += new System.EventHandler(this.frmSelectModule_Load);
            this.panMid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ucTabControl1)).EndInit();
            this.ucTabControl1.ResumeLayout(false);
            this.tabControlPanel1.ResumeLayout(false);
            this.ucPanel2.ResumeLayout(false);
            this.grpDgvModule.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvModule)).EndInit();
            this.ucPanel3.ResumeLayout(false);
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            this.ucPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treMenu)).EndInit();
            this.panBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.UcPanel panMid;
        private Controls.UcPanel ucPanel2;
        private System.Windows.Forms.GroupBox grpDgvModule;
        private Controls.UcDataGridView dgvModule;
        private Controls.UcPanel ucPanel1;
        private Controls.UcAdTree treMenu;
        private DevComponents.AdvTree.Node node1;
        private DevComponents.AdvTree.NodeConnector nodeConnector1;
        private DevComponents.DotNetBar.ElementStyle elementStyle1;
        private Controls.UcButton btnSearch;
        private Controls.UcTextBox txfModuleName;
        private Controls.UcLabel ucLabel2;
        private Controls.UcPanel panBottom;
        private Controls.UcButton btnCancel;
        private Controls.UcButton btnOK;
        private Controls.UcCheckBox chkAll;
        private Controls.UcTabControl ucTabControl1;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel1;
        private DevComponents.DotNetBar.ExpandableSplitter expandableSplitter1;
        private DevComponents.DotNetBar.TabItem tabSlcModule;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Sys_Module_ModuleID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Sys_Module_ModuleCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Sys_Module_ModuleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Sys_Module_ActionCode;
        private Controls.UcPanel ucPanel3;
        private Controls.UcPager pagModule;
        private Controls.UcPanel grpSearch;
    }
}