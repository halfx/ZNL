namespace ZNLCRM.UI.SYS
{
    partial class frmEmpRightManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmpRightManage));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabMenu = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.adtMenu = new ZNLCRM.Controls.UcAdTree(this.components);
            this.nodeConnector1 = new DevComponents.AdvTree.NodeConnector();
            this.elementStyle1 = new DevComponents.DotNetBar.ElementStyle();
            this.ucPanel1 = new ZNLCRM.Controls.UcPanel(this.components);
            this.panelShowRight = new ZNLCRM.Controls.UcPanel(this.components);
            this.cbgRight = new ZNLCRM.Controls.UcCheckBoxGroup();
            this.dgvModule = new ZNLCRM.Controls.UcDataGridView(this.components);
            this.ucPanel2 = new ZNLCRM.Controls.UcPanel(this.components);
            this.btn_SystemSave = new ZNLCRM.Controls.UcButton(this.components);
            this.pgEmpRight = new ZNLCRM.Controls.UcPager();
            this.ucPanel3 = new ZNLCRM.Controls.UcPanel(this.components);
            this.cboIsNoSet = new ZNLCRM.Controls.UcCheckBox(this.components);
            this.btnSearch = new ZNLCRM.Controls.UcButton(this.components);
            this.ucLabel4 = new ZNLCRM.Controls.UcLabel(this.components);
            this.txtModuleName = new ZNLCRM.Controls.UcTextBox(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panToo = new ZNLCRM.Controls.UcPanel(this.components);
            this.ucTextBox2 = new ZNLCRM.Controls.UcTextBox(this.components);
            this.ucLabel3 = new ZNLCRM.Controls.UcLabel(this.components);
            this.txtEmpID = new ZNLCRM.Controls.UcTextBox(this.components);
            this.txtEmpName = new ZNLCRM.Controls.UcTextBox(this.components);
            this.ucLabel2 = new ZNLCRM.Controls.UcLabel(this.components);
            this.ucLabel1 = new ZNLCRM.Controls.UcLabel(this.components);
            this.panCon = new ZNLCRM.Controls.UcPanel(this.components);
            this.cbx_Search = new System.Windows.Forms.CheckBox();
            this.cbx_Edits = new System.Windows.Forms.CheckBox();
            this.cbx_Approve = new System.Windows.Forms.CheckBox();
            this.cbx_Imports = new System.Windows.Forms.CheckBox();
            this.cbx_Output = new System.Windows.Forms.CheckBox();
            this.cbx_ViewAlls = new System.Windows.Forms.CheckBox();
            this.sxtParentMenuName = new ZNLCRM.Controls.UcTextBox(this.components);
            this.ucTextBox3 = new ZNLCRM.Controls.UcTextBox(this.components);
            this.colEmpRightID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmpID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colModuleID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colModuleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBaseActionCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colActionCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRightName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl.SuspendLayout();
            this.tabMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adtMenu)).BeginInit();
            this.ucPanel1.SuspendLayout();
            this.panelShowRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModule)).BeginInit();
            this.ucPanel2.SuspendLayout();
            this.ucPanel3.SuspendLayout();
            this.panToo.SuspendLayout();
            this.panCon.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabMenu);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.ImageList = this.imageList1;
            this.tabControl.ItemSize = new System.Drawing.Size(60, 32);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.Padding = new System.Drawing.Point(12, 5);
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1007, 531);
            this.tabControl.TabIndex = 0;
            // 
            // tabMenu
            // 
            this.tabMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabMenu.Controls.Add(this.splitContainer1);
            this.tabMenu.ImageIndex = 0;
            this.tabMenu.Location = new System.Drawing.Point(4, 36);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.Padding = new System.Windows.Forms.Padding(3);
            this.tabMenu.Size = new System.Drawing.Size(999, 491);
            this.tabMenu.TabIndex = 0;
            this.tabMenu.Text = "系统模块";
            this.tabMenu.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.adtMenu);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.ucPanel1);
            this.splitContainer1.Panel2.Controls.Add(this.ucPanel2);
            this.splitContainer1.Panel2.Controls.Add(this.ucPanel3);
            this.splitContainer1.Size = new System.Drawing.Size(993, 485);
            this.splitContainer1.SplitterDistance = 173;
            this.splitContainer1.TabIndex = 0;
            // 
            // adtMenu
            // 
            this.adtMenu.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline;
            this.adtMenu.AllowDrop = true;
            this.adtMenu.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.adtMenu.BackgroundStyle.Class = "TreeBorderKey";
            this.adtMenu.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.adtMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adtMenu.Location = new System.Drawing.Point(0, 0);
            this.adtMenu.Name = "adtMenu";
            this.adtMenu.NodesConnector = this.nodeConnector1;
            this.adtMenu.NodeStyle = this.elementStyle1;
            this.adtMenu.PathSeparator = ";";
            this.adtMenu.Size = new System.Drawing.Size(173, 485);
            this.adtMenu.Styles.Add(this.elementStyle1);
            this.adtMenu.TabIndex = 0;
            this.adtMenu.Text = "adtMenu";
            this.adtMenu.NodeClick += new DevComponents.AdvTree.TreeNodeMouseEventHandler(this.adtMenu_NodeClick);
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
            // ucPanel1
            // 
            this.ucPanel1.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel1.Controls.Add(this.panelShowRight);
            this.ucPanel1.Controls.Add(this.dgvModule);
            this.ucPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPanel1.Location = new System.Drawing.Point(0, 30);
            this.ucPanel1.Name = "ucPanel1";
            this.ucPanel1.Size = new System.Drawing.Size(816, 421);
            this.ucPanel1.TabIndex = 1;
            // 
            // panelShowRight
            // 
            this.panelShowRight.BackColor = System.Drawing.Color.Transparent;
            this.panelShowRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelShowRight.Controls.Add(this.cbgRight);
            this.panelShowRight.Location = new System.Drawing.Point(291, 21);
            this.panelShowRight.Name = "panelShowRight";
            this.panelShowRight.Size = new System.Drawing.Size(500, 22);
            this.panelShowRight.TabIndex = 1;
            this.panelShowRight.Visible = false;
            this.panelShowRight.MouseLeave += new System.EventHandler(this.panelShowRight_MouseLeave);
            // 
            // cbgRight
            // 
            this.cbgRight.BackColor = System.Drawing.Color.Transparent;
            this.cbgRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbgRight.KvList = ((System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<string, object>>)(resources.GetObject("cbgRight.KvList")));
            this.cbgRight.Location = new System.Drawing.Point(0, 0);
            this.cbgRight.Name = "cbgRight";
            this.cbgRight.Size = new System.Drawing.Size(498, 20);
            this.cbgRight.TabIndex = 0;
            this.cbgRight.Value = "";
            this.cbgRight.ItemCheckedChanged += new ZNLCRM.Controls.UcCheckBoxGroup.CheckBoxGroupValueChangedEventHandler(this.cbgRight_ItemCheckedChanged);
            this.cbgRight.MouseLeave += new System.EventHandler(this.cbgRight_MouseLeave);
            // 
            // dgvModule
            // 
            this.dgvModule.AllowUserToAddRows = false;
            this.dgvModule.AllowUserToDeleteRows = false;
            this.dgvModule.AllowUserToOrderColumns = true;
            this.dgvModule.BackgroundColor = System.Drawing.Color.White;
            this.dgvModule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colEmpRightID,
            this.colEmpID,
            this.colEmpName,
            this.colModuleID,
            this.colModuleName,
            this.colBaseActionCode,
            this.colActionCode,
            this.colRightName});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvModule.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvModule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvModule.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvModule.HighlightSelectedColumnHeaders = false;
            this.dgvModule.Location = new System.Drawing.Point(0, 0);
            this.dgvModule.Name = "dgvModule";
            this.dgvModule.PaintEnhancedSelection = false;
            this.dgvModule.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvModule.RowTemplate.Height = 23;
            this.dgvModule.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvModule.SelectAllSignVisible = false;
            this.dgvModule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvModule.Size = new System.Drawing.Size(816, 421);
            this.dgvModule.TabIndex = 0;
            this.dgvModule.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvModule_CellMouseEnter);
            this.dgvModule.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvModule_CellMouseLeave);
            this.dgvModule.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvModule_DataBindingComplete);
            // 
            // ucPanel2
            // 
            this.ucPanel2.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel2.Controls.Add(this.btn_SystemSave);
            this.ucPanel2.Controls.Add(this.pgEmpRight);
            this.ucPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucPanel2.Location = new System.Drawing.Point(0, 451);
            this.ucPanel2.Name = "ucPanel2";
            this.ucPanel2.Size = new System.Drawing.Size(816, 34);
            this.ucPanel2.TabIndex = 1;
            // 
            // btn_SystemSave
            // 
            this.btn_SystemSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_SystemSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_SystemSave.Image = ((System.Drawing.Image)(resources.GetObject("btn_SystemSave.Image")));
            this.btn_SystemSave.Location = new System.Drawing.Point(13, 5);
            this.btn_SystemSave.Name = "btn_SystemSave";
            this.btn_SystemSave.Size = new System.Drawing.Size(92, 23);
            this.btn_SystemSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_SystemSave.TabIndex = 1;
            this.btn_SystemSave.Text = "保存修改";
            this.btn_SystemSave.Click += new System.EventHandler(this.btn_SystemSave_Click);
            // 
            // pgEmpRight
            // 
            this.pgEmpRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pgEmpRight.AutoSize = true;
            this.pgEmpRight.BackColor = System.Drawing.Color.Transparent;
            this.pgEmpRight.Location = new System.Drawing.Point(524, 10);
            this.pgEmpRight.Name = "pgEmpRight";
            this.pgEmpRight.RecordCount = 0;
            this.pgEmpRight.Size = new System.Drawing.Size(267, 16);
            this.pgEmpRight.TabIndex = 0;
            this.pgEmpRight.PageIndexChanged += new System.EventHandler(this.pgEmpRight_PageIndexChanged);
            // 
            // ucPanel3
            // 
            this.ucPanel3.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel3.Controls.Add(this.cboIsNoSet);
            this.ucPanel3.Controls.Add(this.btnSearch);
            this.ucPanel3.Controls.Add(this.ucLabel4);
            this.ucPanel3.Controls.Add(this.txtModuleName);
            this.ucPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucPanel3.Location = new System.Drawing.Point(0, 0);
            this.ucPanel3.Name = "ucPanel3";
            this.ucPanel3.Size = new System.Drawing.Size(816, 30);
            this.ucPanel3.TabIndex = 2;
            // 
            // cboIsNoSet
            // 
            // 
            // 
            // 
            this.cboIsNoSet.BackgroundStyle.Class = "";
            this.cboIsNoSet.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cboIsNoSet.Location = new System.Drawing.Point(311, 4);
            this.cboIsNoSet.Name = "cboIsNoSet";
            this.cboIsNoSet.Size = new System.Drawing.Size(124, 23);
            this.cboIsNoSet.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboIsNoSet.TabIndex = 3;
            this.cboIsNoSet.Text = "查看未设权限模块";
            this.cboIsNoSet.CheckedChanged += new System.EventHandler(this.cboIsNoSet_CheckedChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSearch.Image = global::ZNLCRM.UI.Properties.Resources.search;
            this.btnSearch.Location = new System.Drawing.Point(441, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlS);
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "搜索(S)";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // ucLabel4
            // 
            this.ucLabel4.AutoSize = true;
            this.ucLabel4.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabel4.ForeColor = System.Drawing.Color.Gray;
            this.ucLabel4.Location = new System.Drawing.Point(29, 8);
            this.ucLabel4.Name = "ucLabel4";
            this.ucLabel4.Size = new System.Drawing.Size(59, 12);
            this.ucLabel4.TabIndex = 1;
            this.ucLabel4.Text = "模块名称:";
            // 
            // txtModuleName
            // 
            // 
            // 
            // 
            this.txtModuleName.Border.Class = "TextBoxBorder";
            this.txtModuleName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtModuleName.EnterToNextControl = false;
            this.txtModuleName.Location = new System.Drawing.Point(100, 4);
            this.txtModuleName.Name = "txtModuleName";
            this.txtModuleName.Size = new System.Drawing.Size(205, 21);
            this.txtModuleName.TabIndex = 0;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "sys.png");
            // 
            // panToo
            // 
            this.panToo.BackColor = System.Drawing.Color.Transparent;
            this.panToo.Controls.Add(this.ucTextBox2);
            this.panToo.Controls.Add(this.ucLabel3);
            this.panToo.Controls.Add(this.txtEmpID);
            this.panToo.Controls.Add(this.txtEmpName);
            this.panToo.Controls.Add(this.ucLabel2);
            this.panToo.Controls.Add(this.ucLabel1);
            this.panToo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panToo.Location = new System.Drawing.Point(0, 0);
            this.panToo.Name = "panToo";
            this.panToo.Size = new System.Drawing.Size(1007, 49);
            this.panToo.TabIndex = 1;
            this.panToo.Paint += new System.Windows.Forms.PaintEventHandler(this.panToo_Paint);
            // 
            // ucTextBox2
            // 
            // 
            // 
            // 
            this.ucTextBox2.Border.Class = "TextBoxBorder";
            this.ucTextBox2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ucTextBox2.EnterToNextControl = false;
            this.ucTextBox2.Location = new System.Drawing.Point(456, 13);
            this.ucTextBox2.Name = "ucTextBox2";
            this.ucTextBox2.ReadOnly = true;
            this.ucTextBox2.Size = new System.Drawing.Size(145, 21);
            this.ucTextBox2.TabIndex = 1;
            // 
            // ucLabel3
            // 
            this.ucLabel3.AutoSize = true;
            this.ucLabel3.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabel3.ForeColor = System.Drawing.Color.Gray;
            this.ucLabel3.Location = new System.Drawing.Point(396, 17);
            this.ucLabel3.Name = "ucLabel3";
            this.ucLabel3.Size = new System.Drawing.Size(65, 12);
            this.ucLabel3.TabIndex = 0;
            this.ucLabel3.Text = "模块名称：";
            // 
            // txtEmpID
            // 
            // 
            // 
            // 
            this.txtEmpID.Border.Class = "TextBoxBorder";
            this.txtEmpID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtEmpID.EnterToNextControl = false;
            this.txtEmpID.Location = new System.Drawing.Point(72, 13);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.ReadOnly = true;
            this.txtEmpID.Size = new System.Drawing.Size(116, 21);
            this.txtEmpID.TabIndex = 1;
            this.txtEmpID.Text = "1";
            // 
            // txtEmpName
            // 
            // 
            // 
            // 
            this.txtEmpName.Border.Class = "TextBoxBorder";
            this.txtEmpName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtEmpName.EnterToNextControl = false;
            this.txtEmpName.Location = new System.Drawing.Point(265, 13);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.ReadOnly = true;
            this.txtEmpName.Size = new System.Drawing.Size(116, 21);
            this.txtEmpName.TabIndex = 1;
            this.txtEmpName.Text = "系统管理员";
            // 
            // ucLabel2
            // 
            this.ucLabel2.AutoSize = true;
            this.ucLabel2.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabel2.ForeColor = System.Drawing.Color.Gray;
            this.ucLabel2.Location = new System.Drawing.Point(204, 17);
            this.ucLabel2.Name = "ucLabel2";
            this.ucLabel2.Size = new System.Drawing.Size(65, 12);
            this.ucLabel2.TabIndex = 0;
            this.ucLabel2.Text = "员工名称：";
            // 
            // ucLabel1
            // 
            this.ucLabel1.AutoSize = true;
            this.ucLabel1.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabel1.ForeColor = System.Drawing.Color.Gray;
            this.ucLabel1.Location = new System.Drawing.Point(12, 17);
            this.ucLabel1.Name = "ucLabel1";
            this.ucLabel1.Size = new System.Drawing.Size(65, 12);
            this.ucLabel1.TabIndex = 0;
            this.ucLabel1.Text = "员工编号：";
            // 
            // panCon
            // 
            this.panCon.BackColor = System.Drawing.Color.Transparent;
            this.panCon.Controls.Add(this.tabControl);
            this.panCon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panCon.Location = new System.Drawing.Point(0, 49);
            this.panCon.Name = "panCon";
            this.panCon.Size = new System.Drawing.Size(1007, 531);
            this.panCon.TabIndex = 2;
            // 
            // cbx_Search
            // 
            this.cbx_Search.AutoSize = true;
            this.cbx_Search.Location = new System.Drawing.Point(12, 3);
            this.cbx_Search.Name = "cbx_Search";
            this.cbx_Search.Size = new System.Drawing.Size(48, 16);
            this.cbx_Search.TabIndex = 0;
            this.cbx_Search.Text = "查询";
            this.cbx_Search.UseVisualStyleBackColor = true;
            // 
            // cbx_Edits
            // 
            this.cbx_Edits.AutoSize = true;
            this.cbx_Edits.Location = new System.Drawing.Point(120, 3);
            this.cbx_Edits.Name = "cbx_Edits";
            this.cbx_Edits.Size = new System.Drawing.Size(48, 16);
            this.cbx_Edits.TabIndex = 0;
            this.cbx_Edits.Text = "修改";
            this.cbx_Edits.UseVisualStyleBackColor = true;
            // 
            // cbx_Approve
            // 
            this.cbx_Approve.AutoSize = true;
            this.cbx_Approve.Location = new System.Drawing.Point(12, 25);
            this.cbx_Approve.Name = "cbx_Approve";
            this.cbx_Approve.Size = new System.Drawing.Size(48, 16);
            this.cbx_Approve.TabIndex = 0;
            this.cbx_Approve.Text = "审核";
            this.cbx_Approve.UseVisualStyleBackColor = true;
            // 
            // cbx_Imports
            // 
            this.cbx_Imports.AutoSize = true;
            this.cbx_Imports.Location = new System.Drawing.Point(66, 25);
            this.cbx_Imports.Name = "cbx_Imports";
            this.cbx_Imports.Size = new System.Drawing.Size(48, 16);
            this.cbx_Imports.TabIndex = 0;
            this.cbx_Imports.Text = "导入";
            this.cbx_Imports.UseVisualStyleBackColor = true;
            // 
            // cbx_Output
            // 
            this.cbx_Output.AutoSize = true;
            this.cbx_Output.Location = new System.Drawing.Point(120, 25);
            this.cbx_Output.Name = "cbx_Output";
            this.cbx_Output.Size = new System.Drawing.Size(48, 16);
            this.cbx_Output.TabIndex = 0;
            this.cbx_Output.Text = "导出";
            this.cbx_Output.UseVisualStyleBackColor = true;
            // 
            // cbx_ViewAlls
            // 
            this.cbx_ViewAlls.AutoSize = true;
            this.cbx_ViewAlls.Location = new System.Drawing.Point(12, 47);
            this.cbx_ViewAlls.Name = "cbx_ViewAlls";
            this.cbx_ViewAlls.Size = new System.Drawing.Size(72, 16);
            this.cbx_ViewAlls.TabIndex = 0;
            this.cbx_ViewAlls.Text = "查询所有";
            this.cbx_ViewAlls.UseVisualStyleBackColor = true;
            // 
            // sxtParentMenuName
            // 
            // 
            // 
            // 
            this.sxtParentMenuName.Border.Class = "TextBoxBorder";
            this.sxtParentMenuName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.sxtParentMenuName.EnterToNextControl = false;
            this.sxtParentMenuName.Location = new System.Drawing.Point(140, 20);
            this.sxtParentMenuName.Name = "sxtParentMenuName";
            this.sxtParentMenuName.ReadOnly = true;
            this.sxtParentMenuName.Size = new System.Drawing.Size(153, 21);
            this.sxtParentMenuName.TabIndex = 0;
            // 
            // ucTextBox3
            // 
            // 
            // 
            // 
            this.ucTextBox3.Border.Class = "TextBoxBorder";
            this.ucTextBox3.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ucTextBox3.EnterToNextControl = false;
            this.ucTextBox3.Location = new System.Drawing.Point(140, 48);
            this.ucTextBox3.Name = "ucTextBox3";
            this.ucTextBox3.ReadOnly = true;
            this.ucTextBox3.Size = new System.Drawing.Size(153, 21);
            this.ucTextBox3.TabIndex = 0;
            // 
            // colEmpRightID
            // 
            this.colEmpRightID.DataPropertyName = "EmpRightID";
            this.colEmpRightID.HeaderText = "ID";
            this.colEmpRightID.Name = "colEmpRightID";
            this.colEmpRightID.Visible = false;
            // 
            // colEmpID
            // 
            this.colEmpID.FillWeight = 5.215466F;
            this.colEmpID.HeaderText = "员工编号";
            this.colEmpID.Name = "colEmpID";
            this.colEmpID.ReadOnly = true;
            this.colEmpID.Visible = false;
            // 
            // colEmpName
            // 
            this.colEmpName.FillWeight = 3.833367F;
            this.colEmpName.HeaderText = "员工名称";
            this.colEmpName.Name = "colEmpName";
            this.colEmpName.ReadOnly = true;
            this.colEmpName.Visible = false;
            // 
            // colModuleID
            // 
            this.colModuleID.DataPropertyName = "ModuleID";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colModuleID.DefaultCellStyle = dataGridViewCellStyle1;
            this.colModuleID.FillWeight = 5.723201F;
            this.colModuleID.HeaderText = "模块ID";
            this.colModuleID.Name = "colModuleID";
            this.colModuleID.ReadOnly = true;
            // 
            // colModuleName
            // 
            this.colModuleName.DataPropertyName = "ModuleName";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colModuleName.DefaultCellStyle = dataGridViewCellStyle2;
            this.colModuleName.FillWeight = 1.470326F;
            this.colModuleName.HeaderText = "模块名称";
            this.colModuleName.Name = "colModuleName";
            this.colModuleName.ReadOnly = true;
            // 
            // colBaseActionCode
            // 
            this.colBaseActionCode.DataPropertyName = "BaseActionCode";
            this.colBaseActionCode.HeaderText = "模块所有权限编码";
            this.colBaseActionCode.Name = "colBaseActionCode";
            this.colBaseActionCode.Visible = false;
            // 
            // colActionCode
            // 
            this.colActionCode.DataPropertyName = "ActionCode";
            this.colActionCode.HeaderText = "个人权限编码";
            this.colActionCode.Name = "colActionCode";
            this.colActionCode.Visible = false;
            // 
            // colRightName
            // 
            this.colRightName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colRightName.DataPropertyName = "RightName";
            this.colRightName.FillWeight = 134.5191F;
            this.colRightName.HeaderText = "个人所有权限";
            this.colRightName.Name = "colRightName";
            this.colRightName.ReadOnly = true;
            this.colRightName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // frmEmpRightManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 580);
            this.Controls.Add(this.panCon);
            this.Controls.Add(this.panToo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmEmpRightManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "所有模块权限设置";
            this.Load += new System.EventHandler(this.frmSysModuleManage_Load);
            this.tabControl.ResumeLayout(false);
            this.tabMenu.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.adtMenu)).EndInit();
            this.ucPanel1.ResumeLayout(false);
            this.panelShowRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvModule)).EndInit();
            this.ucPanel2.ResumeLayout(false);
            this.ucPanel2.PerformLayout();
            this.ucPanel3.ResumeLayout(false);
            this.ucPanel3.PerformLayout();
            this.panToo.ResumeLayout(false);
            this.panToo.PerformLayout();
            this.panCon.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabMenu;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private Controls.UcDataGridView dgvModule;
        private Controls.UcPanel panToo;
        private Controls.UcPanel panCon;
        private Controls.UcLabel ucLabel1;
        private Controls.UcTextBox ucTextBox2;
        private Controls.UcLabel ucLabel3;
        private Controls.UcTextBox txtEmpName;
        private Controls.UcLabel ucLabel2;
        private Controls.UcAdTree adtMenu;
        private DevComponents.AdvTree.NodeConnector nodeConnector1;
        private DevComponents.DotNetBar.ElementStyle elementStyle1;
        private Controls.UcTextBox txtEmpID;
        private System.Windows.Forms.CheckBox cbx_Search;
        private System.Windows.Forms.CheckBox cbx_Edits;
        private System.Windows.Forms.CheckBox cbx_Approve;
        private System.Windows.Forms.CheckBox cbx_Imports;
        private System.Windows.Forms.CheckBox cbx_Output;
        private System.Windows.Forms.CheckBox cbx_ViewAlls;
        private Controls.UcTextBox sxtParentMenuName;
        private Controls.UcTextBox ucTextBox3;
        private Controls.UcPanel ucPanel1;
        private Controls.UcPanel ucPanel2;
        private Controls.UcPager pgEmpRight;
        private Controls.UcButton btn_SystemSave;
        private Controls.UcPanel panelShowRight;
        private Controls.UcCheckBoxGroup cbgRight;
        private Controls.UcPanel ucPanel3;
        private Controls.UcCheckBox cboIsNoSet;
        private Controls.UcButton btnSearch;
        private Controls.UcLabel ucLabel4;
        private Controls.UcTextBox txtModuleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmpRightID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmpID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colModuleID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colModuleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBaseActionCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colActionCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRightName;
    }
}