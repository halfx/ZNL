namespace ZNLCRM.UI.SYS
{
    partial class frmMenuManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuManage));
            this.panMid = new ZNLCRM.Controls.UcPanel(this.components);
            this.expandableSplitter1 = new DevComponents.DotNetBar.ExpandableSplitter();
            this.ucPanel2 = new ZNLCRM.Controls.UcPanel(this.components);
            this.grpDgvModule = new System.Windows.Forms.GroupBox();
            this.grpEditModule = new System.Windows.Forms.GroupBox();
            this.ucLabel9 = new ZNLCRM.Controls.UcLabel(this.components);
            this.txtActionCode = new ZNLCRM.Controls.UcTextBox(this.components);
            this.ucLabel10 = new ZNLCRM.Controls.UcLabel(this.components);
            this.txtModuleName = new ZNLCRM.Controls.UcTextBox(this.components);
            this.stxMenuID = new ZNLCRM.Controls.UcTextBox(this.components);
            this.txtModuleID = new ZNLCRM.Controls.UcTextBox(this.components);
            this.ucLabel11 = new ZNLCRM.Controls.UcLabel(this.components);
            this.sxtParentMenuName = new ZNLCRM.Controls.UcTextBox(this.components);
            this.ucLabel12 = new ZNLCRM.Controls.UcLabel(this.components);
            this.txtModuleCode = new ZNLCRM.Controls.UcTextBox(this.components);
            this.btnCloseEditModule = new ZNLCRM.Controls.UcButton(this.components);
            this.btnSaveEditModule = new ZNLCRM.Controls.UcButton(this.components);
            this.grpEditMenu = new System.Windows.Forms.GroupBox();
            this.ucLabel7 = new ZNLCRM.Controls.UcLabel(this.components);
            this.txtOrderSeq = new ZNLCRM.Controls.UcTextBox(this.components);
            this.ucLabel6 = new ZNLCRM.Controls.UcLabel(this.components);
            this.txtMenuName = new ZNLCRM.Controls.UcTextBox(this.components);
            this.txtMenuID = new ZNLCRM.Controls.UcTextBox(this.components);
            this.lblParenetMenu = new ZNLCRM.Controls.UcLabel(this.components);
            this.txtParentMenuName = new ZNLCRM.Controls.UcTextBox(this.components);
            this.ucLabel5 = new ZNLCRM.Controls.UcLabel(this.components);
            this.txtMenuCode = new ZNLCRM.Controls.UcTextBox(this.components);
            this.btnCloseEditMenu = new ZNLCRM.Controls.UcButton(this.components);
            this.btnSaveMenu = new ZNLCRM.Controls.UcButton(this.components);
            this.dgvModule = new ZNLCRM.Controls.UcDataGridView(this.components);
            this.col_Sys_Module_ModuleID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Sys_Module_ModuleCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Sys_Module_ModuleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Sys_Module_ActionCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ucPanel1 = new ZNLCRM.Controls.UcPanel(this.components);
            this.treMenu = new ZNLCRM.Controls.UcAdTree(this.components);
            this.node1 = new DevComponents.AdvTree.Node();
            this.nodeConnector1 = new DevComponents.AdvTree.NodeConnector();
            this.elementStyle1 = new DevComponents.DotNetBar.ElementStyle();
            this.panTopMain = new ZNLCRM.Controls.UcPanel(this.components);
            this.tlbMain = new ZNLCRM.Controls.UcToolStrip(this.components);
            this.tlbAdd1 = new System.Windows.Forms.ToolStripButton();
            this.tlbAdd2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tlbEdit = new System.Windows.Forms.ToolStripButton();
            this.tlbEdit2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tlbDel = new System.Windows.Forms.ToolStripButton();
            this.tlbDel2 = new System.Windows.Forms.ToolStripButton();
            this.miniToolStrip = new ZNLCRM.Controls.UcToolStrip(this.components);
            this.txtTargetForm = new ZNLCRM.Controls.UcTextBox(this.components);
            this.ucLabel1 = new ZNLCRM.Controls.UcLabel(this.components);
            this.txmOrderSeq = new ZNLCRM.Controls.UcTextBox(this.components);
            this.ucLabel2 = new ZNLCRM.Controls.UcLabel(this.components);
            this.panMid.SuspendLayout();
            this.ucPanel2.SuspendLayout();
            this.grpDgvModule.SuspendLayout();
            this.grpEditModule.SuspendLayout();
            this.grpEditMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModule)).BeginInit();
            this.ucPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treMenu)).BeginInit();
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
            this.panMid.Size = new System.Drawing.Size(1048, 345);
            this.panMid.TabIndex = 4;
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
            this.expandableSplitter1.Location = new System.Drawing.Point(250, 5);
            this.expandableSplitter1.Name = "expandableSplitter1";
            this.expandableSplitter1.Size = new System.Drawing.Size(6, 335);
            this.expandableSplitter1.Style = DevComponents.DotNetBar.eSplitterStyle.Office2007;
            this.expandableSplitter1.TabIndex = 6;
            this.expandableSplitter1.TabStop = false;
            // 
            // ucPanel2
            // 
            this.ucPanel2.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel2.Controls.Add(this.grpDgvModule);
            this.ucPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPanel2.Location = new System.Drawing.Point(250, 5);
            this.ucPanel2.Name = "ucPanel2";
            this.ucPanel2.Padding = new System.Windows.Forms.Padding(5);
            this.ucPanel2.Size = new System.Drawing.Size(793, 335);
            this.ucPanel2.TabIndex = 5;
            // 
            // grpDgvModule
            // 
            this.grpDgvModule.Controls.Add(this.grpEditModule);
            this.grpDgvModule.Controls.Add(this.grpEditMenu);
            this.grpDgvModule.Controls.Add(this.dgvModule);
            this.grpDgvModule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDgvModule.Location = new System.Drawing.Point(5, 5);
            this.grpDgvModule.Name = "grpDgvModule";
            this.grpDgvModule.Size = new System.Drawing.Size(783, 325);
            this.grpDgvModule.TabIndex = 1;
            this.grpDgvModule.TabStop = false;
            this.grpDgvModule.Text = "模块列表";
            // 
            // grpEditModule
            // 
            this.grpEditModule.Controls.Add(this.ucLabel1);
            this.grpEditModule.Controls.Add(this.txtTargetForm);
            this.grpEditModule.Controls.Add(this.ucLabel2);
            this.grpEditModule.Controls.Add(this.txmOrderSeq);
            this.grpEditModule.Controls.Add(this.ucLabel9);
            this.grpEditModule.Controls.Add(this.txtActionCode);
            this.grpEditModule.Controls.Add(this.ucLabel10);
            this.grpEditModule.Controls.Add(this.txtModuleName);
            this.grpEditModule.Controls.Add(this.stxMenuID);
            this.grpEditModule.Controls.Add(this.txtModuleID);
            this.grpEditModule.Controls.Add(this.ucLabel11);
            this.grpEditModule.Controls.Add(this.sxtParentMenuName);
            this.grpEditModule.Controls.Add(this.ucLabel12);
            this.grpEditModule.Controls.Add(this.txtModuleCode);
            this.grpEditModule.Controls.Add(this.btnCloseEditModule);
            this.grpEditModule.Controls.Add(this.btnSaveEditModule);
            this.grpEditModule.Location = new System.Drawing.Point(323, 47);
            this.grpEditModule.Name = "grpEditModule";
            this.grpEditModule.Size = new System.Drawing.Size(357, 260);
            this.grpEditModule.TabIndex = 0;
            this.grpEditModule.TabStop = false;
            this.grpEditModule.Text = "模块编辑区";
            this.grpEditModule.Visible = false;
            // 
            // ucLabel9
            // 
            this.ucLabel9.AutoSize = true;
            this.ucLabel9.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabel9.ForeColor = System.Drawing.Color.Gray;
            this.ucLabel9.Location = new System.Drawing.Point(6, 141);
            this.ucLabel9.Name = "ucLabel9";
            this.ucLabel9.Size = new System.Drawing.Size(65, 12);
            this.ucLabel9.TabIndex = 6;
            this.ucLabel9.Text = "操作行为：";
            // 
            // txtActionCode
            // 
            // 
            // 
            // 
            this.txtActionCode.Border.Class = "TextBoxBorder";
            this.txtActionCode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtActionCode.EnterToNextControl = false;
            this.txtActionCode.Location = new System.Drawing.Point(77, 139);
            this.txtActionCode.Name = "txtActionCode";
            this.txtActionCode.Size = new System.Drawing.Size(261, 21);
            this.txtActionCode.TabIndex = 3;
            // 
            // ucLabel10
            // 
            this.ucLabel10.AutoSize = true;
            this.ucLabel10.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabel10.ForeColor = System.Drawing.Color.Gray;
            this.ucLabel10.Location = new System.Drawing.Point(6, 82);
            this.ucLabel10.Name = "ucLabel10";
            this.ucLabel10.Size = new System.Drawing.Size(65, 12);
            this.ucLabel10.TabIndex = 6;
            this.ucLabel10.Text = "模块名称：";
            // 
            // txtModuleName
            // 
            // 
            // 
            // 
            this.txtModuleName.Border.Class = "TextBoxBorder";
            this.txtModuleName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtModuleName.EnterToNextControl = false;
            this.txtModuleName.Location = new System.Drawing.Point(77, 80);
            this.txtModuleName.Name = "txtModuleName";
            this.txtModuleName.Size = new System.Drawing.Size(153, 21);
            this.txtModuleName.TabIndex = 2;
            // 
            // stxMenuID
            // 
            // 
            // 
            // 
            this.stxMenuID.Border.Class = "TextBoxBorder";
            this.stxMenuID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.stxMenuID.EnterToNextControl = false;
            this.stxMenuID.Location = new System.Drawing.Point(260, 51);
            this.stxMenuID.Name = "stxMenuID";
            this.stxMenuID.ReadOnly = true;
            this.stxMenuID.Size = new System.Drawing.Size(51, 21);
            this.stxMenuID.TabIndex = 0;
            this.stxMenuID.Visible = false;
            // 
            // txtModuleID
            // 
            // 
            // 
            // 
            this.txtModuleID.Border.Class = "TextBoxBorder";
            this.txtModuleID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtModuleID.EnterToNextControl = false;
            this.txtModuleID.Location = new System.Drawing.Point(260, 20);
            this.txtModuleID.Name = "txtModuleID";
            this.txtModuleID.ReadOnly = true;
            this.txtModuleID.Size = new System.Drawing.Size(51, 21);
            this.txtModuleID.TabIndex = 0;
            this.txtModuleID.Visible = false;
            // 
            // ucLabel11
            // 
            this.ucLabel11.AutoSize = true;
            this.ucLabel11.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabel11.ForeColor = System.Drawing.Color.Gray;
            this.ucLabel11.Location = new System.Drawing.Point(6, 26);
            this.ucLabel11.Name = "ucLabel11";
            this.ucLabel11.Size = new System.Drawing.Size(65, 12);
            this.ucLabel11.TabIndex = 6;
            this.ucLabel11.Text = "所属菜单：";
            // 
            // sxtParentMenuName
            // 
            // 
            // 
            // 
            this.sxtParentMenuName.Border.Class = "TextBoxBorder";
            this.sxtParentMenuName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.sxtParentMenuName.EnterToNextControl = false;
            this.sxtParentMenuName.Location = new System.Drawing.Point(77, 24);
            this.sxtParentMenuName.Name = "sxtParentMenuName";
            this.sxtParentMenuName.ReadOnly = true;
            this.sxtParentMenuName.Size = new System.Drawing.Size(153, 21);
            this.sxtParentMenuName.TabIndex = 0;
            // 
            // ucLabel12
            // 
            this.ucLabel12.AutoSize = true;
            this.ucLabel12.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabel12.ForeColor = System.Drawing.Color.Gray;
            this.ucLabel12.Location = new System.Drawing.Point(6, 53);
            this.ucLabel12.Name = "ucLabel12";
            this.ucLabel12.Size = new System.Drawing.Size(65, 12);
            this.ucLabel12.TabIndex = 6;
            this.ucLabel12.Text = "模块编号：";
            // 
            // txtModuleCode
            // 
            // 
            // 
            // 
            this.txtModuleCode.Border.Class = "TextBoxBorder";
            this.txtModuleCode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtModuleCode.EnterToNextControl = false;
            this.txtModuleCode.Location = new System.Drawing.Point(77, 51);
            this.txtModuleCode.Name = "txtModuleCode";
            this.txtModuleCode.ReadOnly = true;
            this.txtModuleCode.Size = new System.Drawing.Size(153, 21);
            this.txtModuleCode.TabIndex = 1;
            // 
            // btnCloseEditModule
            // 
            this.btnCloseEditModule.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCloseEditModule.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCloseEditModule.Location = new System.Drawing.Point(173, 210);
            this.btnCloseEditModule.Name = "btnCloseEditModule";
            this.btnCloseEditModule.Size = new System.Drawing.Size(75, 23);
            this.btnCloseEditModule.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCloseEditModule.TabIndex = 5;
            this.btnCloseEditModule.Text = "取消";
            this.btnCloseEditModule.Click += new System.EventHandler(this.btnCloseEditModule_Click);
            // 
            // btnSaveEditModule
            // 
            this.btnSaveEditModule.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSaveEditModule.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSaveEditModule.Image = global::ZNLCRM.UI.Properties.Resources.save_1;
            this.btnSaveEditModule.Location = new System.Drawing.Point(77, 210);
            this.btnSaveEditModule.Name = "btnSaveEditModule";
            this.btnSaveEditModule.Size = new System.Drawing.Size(75, 23);
            this.btnSaveEditModule.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSaveEditModule.TabIndex = 4;
            this.btnSaveEditModule.Text = "保存";
            this.btnSaveEditModule.Click += new System.EventHandler(this.btnSaveEditModule_Click);
            // 
            // grpEditMenu
            // 
            this.grpEditMenu.Controls.Add(this.ucLabel7);
            this.grpEditMenu.Controls.Add(this.txtOrderSeq);
            this.grpEditMenu.Controls.Add(this.ucLabel6);
            this.grpEditMenu.Controls.Add(this.txtMenuName);
            this.grpEditMenu.Controls.Add(this.txtMenuID);
            this.grpEditMenu.Controls.Add(this.lblParenetMenu);
            this.grpEditMenu.Controls.Add(this.txtParentMenuName);
            this.grpEditMenu.Controls.Add(this.ucLabel5);
            this.grpEditMenu.Controls.Add(this.txtMenuCode);
            this.grpEditMenu.Controls.Add(this.btnCloseEditMenu);
            this.grpEditMenu.Controls.Add(this.btnSaveMenu);
            this.grpEditMenu.Location = new System.Drawing.Point(39, 96);
            this.grpEditMenu.Name = "grpEditMenu";
            this.grpEditMenu.Size = new System.Drawing.Size(269, 184);
            this.grpEditMenu.TabIndex = 0;
            this.grpEditMenu.TabStop = false;
            this.grpEditMenu.Text = "菜单编辑区";
            this.grpEditMenu.Visible = false;
            // 
            // ucLabel7
            // 
            this.ucLabel7.AutoSize = true;
            this.ucLabel7.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabel7.ForeColor = System.Drawing.Color.Gray;
            this.ucLabel7.Location = new System.Drawing.Point(15, 109);
            this.ucLabel7.Name = "ucLabel7";
            this.ucLabel7.Size = new System.Drawing.Size(53, 12);
            this.ucLabel7.TabIndex = 6;
            this.ucLabel7.Text = "次序号：";
            // 
            // txtOrderSeq
            // 
            // 
            // 
            // 
            this.txtOrderSeq.Border.Class = "TextBoxBorder";
            this.txtOrderSeq.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtOrderSeq.EnterToNextControl = false;
            this.txtOrderSeq.Location = new System.Drawing.Point(86, 107);
            this.txtOrderSeq.Name = "txtOrderSeq";
            this.txtOrderSeq.Size = new System.Drawing.Size(153, 21);
            this.txtOrderSeq.TabIndex = 3;
            // 
            // ucLabel6
            // 
            this.ucLabel6.AutoSize = true;
            this.ucLabel6.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabel6.ForeColor = System.Drawing.Color.Gray;
            this.ucLabel6.Location = new System.Drawing.Point(15, 80);
            this.ucLabel6.Name = "ucLabel6";
            this.ucLabel6.Size = new System.Drawing.Size(65, 12);
            this.ucLabel6.TabIndex = 6;
            this.ucLabel6.Text = "菜单名称：";
            // 
            // txtMenuName
            // 
            // 
            // 
            // 
            this.txtMenuName.Border.Class = "TextBoxBorder";
            this.txtMenuName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMenuName.EnterToNextControl = false;
            this.txtMenuName.Location = new System.Drawing.Point(86, 78);
            this.txtMenuName.Name = "txtMenuName";
            this.txtMenuName.Size = new System.Drawing.Size(153, 21);
            this.txtMenuName.TabIndex = 2;
            // 
            // txtMenuID
            // 
            // 
            // 
            // 
            this.txtMenuID.Border.Class = "TextBoxBorder";
            this.txtMenuID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMenuID.EnterToNextControl = false;
            this.txtMenuID.Location = new System.Drawing.Point(212, 17);
            this.txtMenuID.Name = "txtMenuID";
            this.txtMenuID.ReadOnly = true;
            this.txtMenuID.Size = new System.Drawing.Size(51, 21);
            this.txtMenuID.TabIndex = 0;
            this.txtMenuID.Visible = false;
            // 
            // lblParenetMenu
            // 
            this.lblParenetMenu.AutoSize = true;
            this.lblParenetMenu.Font = new System.Drawing.Font("宋体", 9F);
            this.lblParenetMenu.ForeColor = System.Drawing.Color.Gray;
            this.lblParenetMenu.Location = new System.Drawing.Point(15, 24);
            this.lblParenetMenu.Name = "lblParenetMenu";
            this.lblParenetMenu.Size = new System.Drawing.Size(53, 12);
            this.lblParenetMenu.TabIndex = 6;
            this.lblParenetMenu.Text = "父菜单：";
            // 
            // txtParentMenuName
            // 
            // 
            // 
            // 
            this.txtParentMenuName.Border.Class = "TextBoxBorder";
            this.txtParentMenuName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtParentMenuName.Enabled = false;
            this.txtParentMenuName.EnterToNextControl = false;
            this.txtParentMenuName.Location = new System.Drawing.Point(86, 22);
            this.txtParentMenuName.Name = "txtParentMenuName";
            this.txtParentMenuName.ReadOnly = true;
            this.txtParentMenuName.Size = new System.Drawing.Size(153, 21);
            this.txtParentMenuName.TabIndex = 0;
            // 
            // ucLabel5
            // 
            this.ucLabel5.AutoSize = true;
            this.ucLabel5.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabel5.ForeColor = System.Drawing.Color.Gray;
            this.ucLabel5.Location = new System.Drawing.Point(15, 51);
            this.ucLabel5.Name = "ucLabel5";
            this.ucLabel5.Size = new System.Drawing.Size(65, 12);
            this.ucLabel5.TabIndex = 6;
            this.ucLabel5.Text = "菜单编号：";
            // 
            // txtMenuCode
            // 
            // 
            // 
            // 
            this.txtMenuCode.Border.Class = "";
            this.txtMenuCode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMenuCode.EnterToNextControl = false;
            this.txtMenuCode.Location = new System.Drawing.Point(86, 49);
            this.txtMenuCode.Name = "txtMenuCode";
            this.txtMenuCode.Size = new System.Drawing.Size(153, 21);
            this.txtMenuCode.TabIndex = 1;
            // 
            // btnCloseEditMenu
            // 
            this.btnCloseEditMenu.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCloseEditMenu.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCloseEditMenu.Location = new System.Drawing.Point(164, 145);
            this.btnCloseEditMenu.Name = "btnCloseEditMenu";
            this.btnCloseEditMenu.Size = new System.Drawing.Size(75, 23);
            this.btnCloseEditMenu.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCloseEditMenu.TabIndex = 5;
            this.btnCloseEditMenu.Text = "取消";
            this.btnCloseEditMenu.Click += new System.EventHandler(this.btnCloseEditMenu_Click);
            // 
            // btnSaveMenu
            // 
            this.btnSaveMenu.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSaveMenu.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSaveMenu.Image = global::ZNLCRM.UI.Properties.Resources.save_1;
            this.btnSaveMenu.Location = new System.Drawing.Point(68, 145);
            this.btnSaveMenu.Name = "btnSaveMenu";
            this.btnSaveMenu.Size = new System.Drawing.Size(75, 23);
            this.btnSaveMenu.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSaveMenu.TabIndex = 4;
            this.btnSaveMenu.Text = "保存";
            this.btnSaveMenu.Click += new System.EventHandler(this.btnSaveMenu_Click);
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
            this.dgvModule.Location = new System.Drawing.Point(3, 17);
            this.dgvModule.Name = "dgvModule";
            this.dgvModule.PaintEnhancedSelection = false;
            this.dgvModule.ReadOnly = true;
            this.dgvModule.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvModule.RowTemplate.Height = 23;
            this.dgvModule.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvModule.SelectAllSignVisible = false;
            this.dgvModule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvModule.Size = new System.Drawing.Size(777, 305);
            this.dgvModule.TabIndex = 0;
            this.dgvModule.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvModule_CellDoubleClick);
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
            // ucPanel1
            // 
            this.ucPanel1.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel1.Controls.Add(this.treMenu);
            this.ucPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.ucPanel1.Location = new System.Drawing.Point(5, 5);
            this.ucPanel1.Name = "ucPanel1";
            this.ucPanel1.Padding = new System.Windows.Forms.Padding(5, 5, 10, 5);
            this.ucPanel1.Size = new System.Drawing.Size(245, 335);
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
            this.treMenu.Size = new System.Drawing.Size(230, 325);
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
            // panTopMain
            // 
            this.panTopMain.BackColor = System.Drawing.Color.Transparent;
            this.panTopMain.Controls.Add(this.tlbMain);
            this.panTopMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.panTopMain.Location = new System.Drawing.Point(0, 0);
            this.panTopMain.Name = "panTopMain";
            this.panTopMain.Size = new System.Drawing.Size(1048, 33);
            this.panTopMain.TabIndex = 5;
            // 
            // tlbMain
            // 
            this.tlbMain.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tlbMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlbAdd1,
            this.tlbAdd2,
            this.toolStripSeparator1,
            this.tlbEdit,
            this.tlbEdit2,
            this.toolStripSeparator2,
            this.tlbDel,
            this.tlbDel2});
            this.tlbMain.Location = new System.Drawing.Point(0, 0);
            this.tlbMain.Name = "tlbMain";
            this.tlbMain.Padding = new System.Windows.Forms.Padding(5);
            this.tlbMain.Size = new System.Drawing.Size(1048, 34);
            this.tlbMain.TabIndex = 4;
            this.tlbMain.Text = "ucToolStrip1";
            this.tlbMain.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.tlbMain_ItemClicked);
            // 
            // tlbAdd1
            // 
            this.tlbAdd1.Image = ((System.Drawing.Image)(resources.GetObject("tlbAdd1.Image")));
            this.tlbAdd1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlbAdd1.Name = "tlbAdd1";
            this.tlbAdd1.Size = new System.Drawing.Size(76, 21);
            this.tlbAdd1.Text = "添加菜单";
            this.tlbAdd1.ToolTipText = "添加菜单项";
            // 
            // tlbAdd2
            // 
            this.tlbAdd2.Image = ((System.Drawing.Image)(resources.GetObject("tlbAdd2.Image")));
            this.tlbAdd2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlbAdd2.Name = "tlbAdd2";
            this.tlbAdd2.Size = new System.Drawing.Size(76, 21);
            this.tlbAdd2.Text = "添加模块";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 24);
            // 
            // tlbEdit
            // 
            this.tlbEdit.Image = ((System.Drawing.Image)(resources.GetObject("tlbEdit.Image")));
            this.tlbEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlbEdit.Name = "tlbEdit";
            this.tlbEdit.Size = new System.Drawing.Size(76, 21);
            this.tlbEdit.Text = "修改菜单";
            this.tlbEdit.ToolTipText = "修改菜单";
            // 
            // tlbEdit2
            // 
            this.tlbEdit2.Image = ((System.Drawing.Image)(resources.GetObject("tlbEdit2.Image")));
            this.tlbEdit2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlbEdit2.Name = "tlbEdit2";
            this.tlbEdit2.Size = new System.Drawing.Size(76, 21);
            this.tlbEdit2.Text = "修改模块";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 24);
            // 
            // tlbDel
            // 
            this.tlbDel.Image = ((System.Drawing.Image)(resources.GetObject("tlbDel.Image")));
            this.tlbDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlbDel.Name = "tlbDel";
            this.tlbDel.Size = new System.Drawing.Size(76, 21);
            this.tlbDel.Text = "删除菜单";
            this.tlbDel.ToolTipText = "删除菜单";
            // 
            // tlbDel2
            // 
            this.tlbDel2.Image = ((System.Drawing.Image)(resources.GetObject("tlbDel2.Image")));
            this.tlbDel2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlbDel2.Name = "tlbDel2";
            this.tlbDel2.Size = new System.Drawing.Size(76, 21);
            this.tlbDel2.Text = "删除模块";
            // 
            // miniToolStrip
            // 
            this.miniToolStrip.AutoSize = false;
            this.miniToolStrip.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.miniToolStrip.CanOverflow = false;
            this.miniToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.miniToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.miniToolStrip.Location = new System.Drawing.Point(282, 7);
            this.miniToolStrip.Name = "miniToolStrip";
            this.miniToolStrip.Padding = new System.Windows.Forms.Padding(5);
            this.miniToolStrip.Size = new System.Drawing.Size(1048, 34);
            this.miniToolStrip.TabIndex = 4;
            // 
            // txtTargetForm
            // 
            // 
            // 
            // 
            this.txtTargetForm.Border.Class = "TextBoxBorder";
            this.txtTargetForm.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTargetForm.EnterToNextControl = false;
            this.txtTargetForm.Location = new System.Drawing.Point(77, 110);
            this.txtTargetForm.Name = "txtTargetForm";
            this.txtTargetForm.Size = new System.Drawing.Size(261, 21);
            this.txtTargetForm.TabIndex = 3;
            // 
            // ucLabel1
            // 
            this.ucLabel1.AutoSize = true;
            this.ucLabel1.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabel1.ForeColor = System.Drawing.Color.Gray;
            this.ucLabel1.Location = new System.Drawing.Point(6, 112);
            this.ucLabel1.Name = "ucLabel1";
            this.ucLabel1.Size = new System.Drawing.Size(65, 12);
            this.ucLabel1.TabIndex = 6;
            this.ucLabel1.Text = "目标窗体：";
            // 
            // txmOrderSeq
            // 
            // 
            // 
            // 
            this.txmOrderSeq.Border.Class = "TextBoxBorder";
            this.txmOrderSeq.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txmOrderSeq.EnterToNextControl = false;
            this.txmOrderSeq.Location = new System.Drawing.Point(77, 169);
            this.txmOrderSeq.Name = "txmOrderSeq";
            this.txmOrderSeq.Size = new System.Drawing.Size(153, 21);
            this.txmOrderSeq.TabIndex = 3;
            // 
            // ucLabel2
            // 
            this.ucLabel2.AutoSize = true;
            this.ucLabel2.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabel2.ForeColor = System.Drawing.Color.Gray;
            this.ucLabel2.Location = new System.Drawing.Point(6, 171);
            this.ucLabel2.Name = "ucLabel2";
            this.ucLabel2.Size = new System.Drawing.Size(53, 12);
            this.ucLabel2.TabIndex = 6;
            this.ucLabel2.Text = "次序号：";
            // 
            // frmMenuManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 378);
            this.Controls.Add(this.panMid);
            this.Controls.Add(this.panTopMain);
            this.Name = "frmMenuManage";
            this.Text = "系统菜单定义";
            this.Load += new System.EventHandler(this.frmMenuManage_Load);
            this.panMid.ResumeLayout(false);
            this.ucPanel2.ResumeLayout(false);
            this.grpDgvModule.ResumeLayout(false);
            this.grpEditModule.ResumeLayout(false);
            this.grpEditModule.PerformLayout();
            this.grpEditMenu.ResumeLayout(false);
            this.grpEditMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModule)).EndInit();
            this.ucPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treMenu)).EndInit();
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
        private Controls.UcPanel ucPanel1;
        private Controls.UcAdTree treMenu;
        private DevComponents.AdvTree.Node node1;
        private DevComponents.AdvTree.NodeConnector nodeConnector1;
        private DevComponents.DotNetBar.ElementStyle elementStyle1;
        private System.Windows.Forms.GroupBox grpEditMenu;
        private Controls.UcLabel ucLabel5;
        private Controls.UcTextBox txtMenuCode;
        private Controls.UcLabel ucLabel7;
        private Controls.UcTextBox txtOrderSeq;
        private Controls.UcLabel ucLabel6;
        private Controls.UcTextBox txtMenuName;
        private Controls.UcButton btnCloseEditMenu;
        private Controls.UcButton btnSaveMenu;
        private System.Windows.Forms.GroupBox grpEditModule;
        private Controls.UcLabel ucLabel9;
        private Controls.UcTextBox txtActionCode;
        private Controls.UcLabel ucLabel10;
        private Controls.UcTextBox txtModuleName;
        private Controls.UcLabel ucLabel11;
        private Controls.UcTextBox sxtParentMenuName;
        private Controls.UcLabel ucLabel12;
        private Controls.UcTextBox txtModuleCode;
        private Controls.UcButton btnCloseEditModule;
        private Controls.UcButton btnSaveEditModule;
        private System.Windows.Forms.GroupBox grpDgvModule;
        private Controls.UcDataGridView dgvModule;
        private Controls.UcToolStrip miniToolStrip;
        private System.Windows.Forms.ToolStripButton tlbAdd1;
        private System.Windows.Forms.ToolStripButton tlbAdd2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tlbEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tlbDel;
        private Controls.UcPanel panTopMain;
        private Controls.UcToolStrip tlbMain;
        private Controls.UcTextBox txtMenuID;
        private Controls.UcLabel lblParenetMenu;
        private Controls.UcTextBox txtParentMenuName;
        private Controls.UcTextBox txtModuleID;
        private Controls.UcTextBox stxMenuID;
        private System.Windows.Forms.ToolStripButton tlbEdit2;
        private System.Windows.Forms.ToolStripButton tlbDel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Sys_Module_ModuleID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Sys_Module_ModuleCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Sys_Module_ModuleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Sys_Module_ActionCode;
        private Controls.UcLabel ucLabel1;
        private Controls.UcTextBox txtTargetForm;
        private Controls.UcLabel ucLabel2;
        private Controls.UcTextBox txmOrderSeq;
    }
}