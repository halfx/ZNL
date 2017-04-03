namespace ZNLCRM.UI.SYS
{
    partial class frmSysEmpDataRight
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSysEmpDataRight));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControlPanel3 = new DevComponents.DotNetBar.TabControlPanel();
            this.dgvDept = new ZNLCRM.Controls.UcDataGridView(this.components);
            this.tabItem3 = new DevComponents.DotNetBar.TabItem(this.components);
            this.colDeptID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDeptName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDeptOrgName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReadDept = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colEditDept = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ucPanel2 = new ZNLCRM.Controls.UcPanel(this.components);
            this.ucTabControl1 = new ZNLCRM.Controls.UcTabControl(this.components);
            this.tabControlPanel4 = new DevComponents.DotNetBar.TabControlPanel();
            this.ucPanel4 = new ZNLCRM.Controls.UcPanel(this.components);
            this.dgvEmp = new ZNLCRM.Controls.UcDataGridView(this.components);
            this.colEmpID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmpOrgName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmpDeptName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReadEmp = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colEditEmp = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ucPanel3 = new ZNLCRM.Controls.UcPanel(this.components);
            this.btnSearch = new ZNLCRM.Controls.UcButton(this.components);
            this.ucLabel3 = new ZNLCRM.Controls.UcLabel(this.components);
            this.txtSEmpName = new ZNLCRM.Controls.UcTextBox(this.components);
            this.tiEmp = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel1 = new DevComponents.DotNetBar.TabControlPanel();
            this.dgvRole = new ZNLCRM.Controls.UcDataGridView(this.components);
            this.colSelectRole = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colRoleID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRoleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiRole = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel2 = new DevComponents.DotNetBar.TabControlPanel();
            this.dgvOrg = new ZNLCRM.Controls.UcDataGridView(this.components);
            this.colOrgID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrgName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReadOrg = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colEditOrg = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tiOrg = new DevComponents.DotNetBar.TabItem(this.components);
            this.tiDept = new DevComponents.DotNetBar.TabItem(this.components);
            this.ucPanel1 = new ZNLCRM.Controls.UcPanel(this.components);
            this.btnSave = new ZNLCRM.Controls.UcButton(this.components);
            this.txtEmpID = new ZNLCRM.Controls.UcTextBox(this.components);
            this.txtEmpName = new ZNLCRM.Controls.UcTextBox(this.components);
            this.ucLabel2 = new ZNLCRM.Controls.UcLabel(this.components);
            this.ucLabel1 = new ZNLCRM.Controls.UcLabel(this.components);
            this.tabControlPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDept)).BeginInit();
            this.ucPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ucTabControl1)).BeginInit();
            this.ucTabControl1.SuspendLayout();
            this.tabControlPanel4.SuspendLayout();
            this.ucPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmp)).BeginInit();
            this.ucPanel3.SuspendLayout();
            this.tabControlPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRole)).BeginInit();
            this.tabControlPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrg)).BeginInit();
            this.ucPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlPanel3
            // 
            this.tabControlPanel3.Controls.Add(this.dgvDept);
            this.tabControlPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel3.Location = new System.Drawing.Point(0, 25);
            this.tabControlPanel3.Name = "tabControlPanel3";
            this.tabControlPanel3.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel3.Size = new System.Drawing.Size(859, 424);
            this.tabControlPanel3.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(242)))), ((int)(((byte)(232)))));
            this.tabControlPanel3.Style.BackColor2.Color = System.Drawing.Color.White;
            this.tabControlPanel3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel3.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(168)))), ((int)(((byte)(153)))));
            this.tabControlPanel3.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right)
                        | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel3.Style.GradientAngle = 90;
            this.tabControlPanel3.TabIndex = 3;
            this.tabControlPanel3.TabItem = this.tiDept;
            // 
            // dgvDept
            // 
            this.dgvDept.AllowUserToAddRows = false;
            this.dgvDept.AllowUserToDeleteRows = false;
            this.dgvDept.AllowUserToOrderColumns = true;
            this.dgvDept.BackgroundColor = System.Drawing.Color.White;
            this.dgvDept.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDept.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDeptID,
            this.colDeptName,
            this.colDeptOrgName,
            this.colReadDept,
            this.colEditDept});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDept.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDept.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDept.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvDept.HighlightSelectedColumnHeaders = false;
            this.dgvDept.Location = new System.Drawing.Point(1, 1);
            this.dgvDept.Name = "dgvDept";
            this.dgvDept.PaintEnhancedSelection = false;
            this.dgvDept.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDept.RowTemplate.Height = 23;
            this.dgvDept.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDept.SelectAllSignVisible = false;
            this.dgvDept.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvDept.Size = new System.Drawing.Size(857, 422);
            this.dgvDept.TabIndex = 1;
            this.dgvDept.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvDept_DataBindingComplete);
            // 
            // tabItem3
            // 
            this.tabItem3.AttachedControl = this.tabControlPanel3;
            this.tabItem3.Name = "tabItem3";
            this.tabItem3.Text = "部门权限";
            // 
            // colDeptID
            // 
            this.colDeptID.DataPropertyName = "DeptID";
            this.colDeptID.HeaderText = "部门ID";
            this.colDeptID.Name = "colDeptID";
            this.colDeptID.Width = 150;
            // 
            // colDeptName
            // 
            this.colDeptName.DataPropertyName = "DeptName";
            this.colDeptName.HeaderText = "部门名称";
            this.colDeptName.Name = "colDeptName";
            this.colDeptName.Width = 150;
            // 
            // colDeptOrgName
            // 
            this.colDeptOrgName.DataPropertyName = "OrgName";
            this.colDeptOrgName.HeaderText = "机构名称";
            this.colDeptOrgName.Name = "colDeptOrgName";
            this.colDeptOrgName.Width = 150;
            // 
            // colReadDept
            // 
            this.colReadDept.HeaderText = "查看";
            this.colReadDept.Name = "colReadDept";
            this.colReadDept.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colReadDept.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colReadDept.Width = 40;
            // 
            // colEditDept
            // 
            this.colEditDept.HeaderText = "编辑";
            this.colEditDept.Name = "colEditDept";
            this.colEditDept.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colEditDept.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colEditDept.Width = 40;
            // 
            // ucPanel2
            // 
            this.ucPanel2.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel2.Controls.Add(this.ucTabControl1);
            this.ucPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPanel2.Location = new System.Drawing.Point(0, 38);
            this.ucPanel2.Name = "ucPanel2";
            this.ucPanel2.Size = new System.Drawing.Size(859, 449);
            this.ucPanel2.TabIndex = 1;
            // 
            // ucTabControl1
            // 
            this.ucTabControl1.BackColor = System.Drawing.Color.Transparent;
            this.ucTabControl1.CanReorderTabs = true;
            this.ucTabControl1.Controls.Add(this.tabControlPanel1);
            this.ucTabControl1.Controls.Add(this.tabControlPanel4);
            this.ucTabControl1.Controls.Add(this.tabControlPanel3);
            this.ucTabControl1.Controls.Add(this.tabControlPanel2);
            this.ucTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucTabControl1.Location = new System.Drawing.Point(0, 0);
            this.ucTabControl1.Name = "ucTabControl1";
            this.ucTabControl1.SelectedTabFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold);
            this.ucTabControl1.SelectedTabIndex = 0;
            this.ucTabControl1.Size = new System.Drawing.Size(859, 449);
            this.ucTabControl1.Style = DevComponents.DotNetBar.eTabStripStyle.VS2005;
            this.ucTabControl1.TabIndex = 10;
            this.ucTabControl1.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            this.ucTabControl1.Tabs.Add(this.tiRole);
            this.ucTabControl1.Tabs.Add(this.tiOrg);
            this.ucTabControl1.Tabs.Add(this.tiDept);
            this.ucTabControl1.Tabs.Add(this.tiEmp);
            this.ucTabControl1.Text = "ucTabControl1";
            // 
            // tabControlPanel4
            // 
            this.tabControlPanel4.Controls.Add(this.ucPanel4);
            this.tabControlPanel4.Controls.Add(this.ucPanel3);
            this.tabControlPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel4.Location = new System.Drawing.Point(0, 25);
            this.tabControlPanel4.Name = "tabControlPanel4";
            this.tabControlPanel4.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel4.Size = new System.Drawing.Size(859, 424);
            this.tabControlPanel4.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(242)))), ((int)(((byte)(232)))));
            this.tabControlPanel4.Style.BackColor2.Color = System.Drawing.Color.White;
            this.tabControlPanel4.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel4.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(168)))), ((int)(((byte)(153)))));
            this.tabControlPanel4.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right)
                        | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel4.Style.GradientAngle = 90;
            this.tabControlPanel4.TabIndex = 4;
            this.tabControlPanel4.TabItem = this.tiEmp;
            // 
            // ucPanel4
            // 
            this.ucPanel4.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel4.Controls.Add(this.dgvEmp);
            this.ucPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPanel4.Location = new System.Drawing.Point(1, 34);
            this.ucPanel4.Name = "ucPanel4";
            this.ucPanel4.Size = new System.Drawing.Size(857, 389);
            this.ucPanel4.TabIndex = 3;
            // 
            // dgvEmp
            // 
            this.dgvEmp.AllowUserToAddRows = false;
            this.dgvEmp.AllowUserToDeleteRows = false;
            this.dgvEmp.AllowUserToOrderColumns = true;
            this.dgvEmp.BackgroundColor = System.Drawing.Color.White;
            this.dgvEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colEmpID,
            this.colEmpName,
            this.colEmpOrgName,
            this.colEmpDeptName,
            this.colReadEmp,
            this.colEditEmp});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmp.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEmp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmp.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvEmp.HighlightSelectedColumnHeaders = false;
            this.dgvEmp.Location = new System.Drawing.Point(0, 0);
            this.dgvEmp.Name = "dgvEmp";
            this.dgvEmp.PaintEnhancedSelection = false;
            this.dgvEmp.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvEmp.RowTemplate.Height = 23;
            this.dgvEmp.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmp.SelectAllSignVisible = false;
            this.dgvEmp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvEmp.Size = new System.Drawing.Size(857, 389);
            this.dgvEmp.TabIndex = 2;
            this.dgvEmp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmp_CellContentClick);
            this.dgvEmp.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvEmp_DataBindingComplete);
            // 
            // colEmpID
            // 
            this.colEmpID.DataPropertyName = "EmpID";
            this.colEmpID.HeaderText = "人员ID";
            this.colEmpID.Name = "colEmpID";
            // 
            // colEmpName
            // 
            this.colEmpName.DataPropertyName = "EmpName";
            this.colEmpName.HeaderText = "人员名称";
            this.colEmpName.Name = "colEmpName";
            this.colEmpName.Width = 150;
            // 
            // colEmpOrgName
            // 
            this.colEmpOrgName.DataPropertyName = "OrgName";
            this.colEmpOrgName.HeaderText = "机构名称";
            this.colEmpOrgName.Name = "colEmpOrgName";
            this.colEmpOrgName.Width = 150;
            // 
            // colEmpDeptName
            // 
            this.colEmpDeptName.DataPropertyName = "DeptName";
            this.colEmpDeptName.HeaderText = "部门名称";
            this.colEmpDeptName.Name = "colEmpDeptName";
            this.colEmpDeptName.Width = 150;
            // 
            // colReadEmp
            // 
            this.colReadEmp.HeaderText = "查看";
            this.colReadEmp.Name = "colReadEmp";
            this.colReadEmp.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colReadEmp.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colReadEmp.Width = 40;
            // 
            // colEditEmp
            // 
            this.colEditEmp.HeaderText = "编辑";
            this.colEditEmp.Name = "colEditEmp";
            this.colEditEmp.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colEditEmp.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colEditEmp.Width = 40;
            // 
            // ucPanel3
            // 
            this.ucPanel3.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel3.Controls.Add(this.btnSearch);
            this.ucPanel3.Controls.Add(this.ucLabel3);
            this.ucPanel3.Controls.Add(this.txtSEmpName);
            this.ucPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucPanel3.Location = new System.Drawing.Point(1, 1);
            this.ucPanel3.Name = "ucPanel3";
            this.ucPanel3.Size = new System.Drawing.Size(857, 33);
            this.ucPanel3.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSearch.Image = global::ZNLCRM.UI.Properties.Resources.search;
            this.btnSearch.Location = new System.Drawing.Point(238, 6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "查看";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // ucLabel3
            // 
            this.ucLabel3.AutoSize = true;
            this.ucLabel3.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabel3.ForeColor = System.Drawing.Color.Gray;
            this.ucLabel3.Location = new System.Drawing.Point(16, 11);
            this.ucLabel3.Name = "ucLabel3";
            this.ucLabel3.Size = new System.Drawing.Size(65, 12);
            this.ucLabel3.TabIndex = 3;
            this.ucLabel3.Text = "员工名称：";
            // 
            // txtSEmpName
            // 
            // 
            // 
            // 
            this.txtSEmpName.Border.Class = "TextBoxBorder";
            this.txtSEmpName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSEmpName.EnterToNextControl = false;
            this.txtSEmpName.Location = new System.Drawing.Point(87, 6);
            this.txtSEmpName.Name = "txtSEmpName";
            this.txtSEmpName.Size = new System.Drawing.Size(145, 21);
            this.txtSEmpName.TabIndex = 0;
            // 
            // tiEmp
            // 
            this.tiEmp.AttachedControl = this.tabControlPanel4;
            this.tiEmp.Name = "tiEmp";
            this.tiEmp.Text = "人员权限";
            // 
            // tabControlPanel1
            // 
            this.tabControlPanel1.Controls.Add(this.dgvRole);
            this.tabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel1.Location = new System.Drawing.Point(0, 25);
            this.tabControlPanel1.Name = "tabControlPanel1";
            this.tabControlPanel1.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel1.Size = new System.Drawing.Size(859, 424);
            this.tabControlPanel1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(242)))), ((int)(((byte)(232)))));
            this.tabControlPanel1.Style.BackColor2.Color = System.Drawing.Color.White;
            this.tabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(168)))), ((int)(((byte)(153)))));
            this.tabControlPanel1.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right)
                        | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel1.Style.GradientAngle = 90;
            this.tabControlPanel1.TabIndex = 1;
            this.tabControlPanel1.TabItem = this.tiRole;
            // 
            // dgvRole
            // 
            this.dgvRole.AllowUserToAddRows = false;
            this.dgvRole.AllowUserToDeleteRows = false;
            this.dgvRole.AllowUserToOrderColumns = true;
            this.dgvRole.BackgroundColor = System.Drawing.Color.White;
            this.dgvRole.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRole.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSelectRole,
            this.colRoleID,
            this.colRoleName});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRole.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRole.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvRole.HighlightSelectedColumnHeaders = false;
            this.dgvRole.Location = new System.Drawing.Point(1, 1);
            this.dgvRole.Name = "dgvRole";
            this.dgvRole.PaintEnhancedSelection = false;
            this.dgvRole.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvRole.RowTemplate.Height = 23;
            this.dgvRole.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRole.SelectAllSignVisible = false;
            this.dgvRole.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvRole.Size = new System.Drawing.Size(857, 422);
            this.dgvRole.TabIndex = 0;
            this.dgvRole.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvRole_DataBindingComplete);
            // 
            // colSelectRole
            // 
            this.colSelectRole.HeaderText = "选择";
            this.colSelectRole.Name = "colSelectRole";
            this.colSelectRole.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colSelectRole.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colSelectRole.Width = 40;
            // 
            // colRoleID
            // 
            this.colRoleID.DataPropertyName = "RoleID";
            this.colRoleID.HeaderText = "角色编号";
            this.colRoleID.Name = "colRoleID";
            // 
            // colRoleName
            // 
            this.colRoleName.DataPropertyName = "RoleName";
            this.colRoleName.HeaderText = "角色名称";
            this.colRoleName.Name = "colRoleName";
            // 
            // tiRole
            // 
            this.tiRole.AttachedControl = this.tabControlPanel1;
            this.tiRole.Image = ((System.Drawing.Image)(resources.GetObject("tiRole.Image")));
            this.tiRole.Name = "tiRole";
            this.tiRole.Text = "所属角色";
            // 
            // tabControlPanel2
            // 
            this.tabControlPanel2.Controls.Add(this.dgvOrg);
            this.tabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel2.Location = new System.Drawing.Point(0, 25);
            this.tabControlPanel2.Name = "tabControlPanel2";
            this.tabControlPanel2.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel2.Size = new System.Drawing.Size(859, 424);
            this.tabControlPanel2.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(242)))), ((int)(((byte)(232)))));
            this.tabControlPanel2.Style.BackColor2.Color = System.Drawing.Color.White;
            this.tabControlPanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel2.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(168)))), ((int)(((byte)(153)))));
            this.tabControlPanel2.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right)
                        | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel2.Style.GradientAngle = 90;
            this.tabControlPanel2.TabIndex = 2;
            this.tabControlPanel2.TabItem = this.tiOrg;
            // 
            // dgvOrg
            // 
            this.dgvOrg.AllowUserToAddRows = false;
            this.dgvOrg.AllowUserToDeleteRows = false;
            this.dgvOrg.AllowUserToOrderColumns = true;
            this.dgvOrg.BackgroundColor = System.Drawing.Color.White;
            this.dgvOrg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colOrgID,
            this.colOrgName,
            this.colReadOrg,
            this.colEditOrg});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrg.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvOrg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrg.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvOrg.HighlightSelectedColumnHeaders = false;
            this.dgvOrg.Location = new System.Drawing.Point(1, 1);
            this.dgvOrg.Name = "dgvOrg";
            this.dgvOrg.PaintEnhancedSelection = false;
            this.dgvOrg.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvOrg.RowTemplate.Height = 23;
            this.dgvOrg.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrg.SelectAllSignVisible = false;
            this.dgvOrg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvOrg.Size = new System.Drawing.Size(857, 422);
            this.dgvOrg.TabIndex = 1;
            this.dgvOrg.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvOrg_DataBindingComplete);
            // 
            // colOrgID
            // 
            this.colOrgID.DataPropertyName = "OrgID";
            this.colOrgID.HeaderText = "机构ID";
            this.colOrgID.Name = "colOrgID";
            // 
            // colOrgName
            // 
            this.colOrgName.DataPropertyName = "OrgName";
            this.colOrgName.HeaderText = "机构名称";
            this.colOrgName.Name = "colOrgName";
            // 
            // colReadOrg
            // 
            this.colReadOrg.HeaderText = "查看";
            this.colReadOrg.Name = "colReadOrg";
            this.colReadOrg.Width = 40;
            // 
            // colEditOrg
            // 
            this.colEditOrg.HeaderText = "编辑";
            this.colEditOrg.Name = "colEditOrg";
            this.colEditOrg.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colEditOrg.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colEditOrg.Width = 40;
            // 
            // tiOrg
            // 
            this.tiOrg.AttachedControl = this.tabControlPanel2;
            this.tiOrg.Name = "tiOrg";
            this.tiOrg.Text = "机构权限";
            // 
            // tiDept
            // 
            this.tiDept.AttachedControl = this.tabControlPanel3;
            this.tiDept.Name = "tiDept";
            this.tiDept.Text = "部门权限";
            // 
            // ucPanel1
            // 
            this.ucPanel1.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel1.Controls.Add(this.btnSave);
            this.ucPanel1.Controls.Add(this.txtEmpID);
            this.ucPanel1.Controls.Add(this.txtEmpName);
            this.ucPanel1.Controls.Add(this.ucLabel2);
            this.ucPanel1.Controls.Add(this.ucLabel1);
            this.ucPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucPanel1.Location = new System.Drawing.Point(0, 0);
            this.ucPanel1.Name = "ucPanel1";
            this.ucPanel1.Size = new System.Drawing.Size(859, 38);
            this.ucPanel1.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Image = global::ZNLCRM.UI.Properties.Resources.save_1;
            this.btnSave.Location = new System.Drawing.Point(387, 8);
            this.btnSave.Name = "btnSave";
            this.btnSave.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlS);
            this.btnSave.Size = new System.Drawing.Size(99, 23);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "保存修改(S)";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtEmpID
            // 
            // 
            // 
            // 
            this.txtEmpID.Border.Class = "TextBoxBorder";
            this.txtEmpID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtEmpID.EnterToNextControl = false;
            this.txtEmpID.Location = new System.Drawing.Point(72, 8);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.ReadOnly = true;
            this.txtEmpID.Size = new System.Drawing.Size(116, 21);
            this.txtEmpID.TabIndex = 4;
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
            this.txtEmpName.Location = new System.Drawing.Point(265, 8);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.ReadOnly = true;
            this.txtEmpName.Size = new System.Drawing.Size(116, 21);
            this.txtEmpName.TabIndex = 5;
            this.txtEmpName.Text = "小明";
            // 
            // ucLabel2
            // 
            this.ucLabel2.AutoSize = true;
            this.ucLabel2.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabel2.ForeColor = System.Drawing.Color.Gray;
            this.ucLabel2.Location = new System.Drawing.Point(204, 12);
            this.ucLabel2.Name = "ucLabel2";
            this.ucLabel2.Size = new System.Drawing.Size(65, 12);
            this.ucLabel2.TabIndex = 2;
            this.ucLabel2.Text = "员工名称：";
            // 
            // ucLabel1
            // 
            this.ucLabel1.AutoSize = true;
            this.ucLabel1.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabel1.ForeColor = System.Drawing.Color.Gray;
            this.ucLabel1.Location = new System.Drawing.Point(12, 12);
            this.ucLabel1.Name = "ucLabel1";
            this.ucLabel1.Size = new System.Drawing.Size(65, 12);
            this.ucLabel1.TabIndex = 3;
            this.ucLabel1.Text = "员工编号：";
            // 
            // frmSysEmpDataRight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 487);
            this.Controls.Add(this.ucPanel2);
            this.Controls.Add(this.ucPanel1);
            this.Name = "frmSysEmpDataRight";
            this.Text = "个人数据权限设置";
            this.Load += new System.EventHandler(this.frmSysEmpDataRight_Load);
            this.tabControlPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDept)).EndInit();
            this.ucPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ucTabControl1)).EndInit();
            this.ucTabControl1.ResumeLayout(false);
            this.tabControlPanel4.ResumeLayout(false);
            this.ucPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmp)).EndInit();
            this.ucPanel3.ResumeLayout(false);
            this.ucPanel3.PerformLayout();
            this.tabControlPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRole)).EndInit();
            this.tabControlPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrg)).EndInit();
            this.ucPanel1.ResumeLayout(false);
            this.ucPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.UcPanel ucPanel1;
        private Controls.UcPanel ucPanel2;
        private Controls.UcTextBox txtEmpID;
        private Controls.UcTextBox txtEmpName;
        private Controls.UcLabel ucLabel2;
        private Controls.UcLabel ucLabel1;
        private Controls.UcTabControl ucTabControl1;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel4;
        private DevComponents.DotNetBar.TabItem tiEmp;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel3;
        private DevComponents.DotNetBar.TabItem tiDept;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel2;
        private DevComponents.DotNetBar.TabItem tiOrg;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel1;
        private DevComponents.DotNetBar.TabItem tiRole;
        private DevComponents.DotNetBar.TabItem tabItem3;
        private Controls.UcDataGridView dgvOrg;
        private Controls.UcDataGridView dgvRole;
        private Controls.UcPanel ucPanel4;
        private Controls.UcDataGridView dgvEmp;
        private Controls.UcPanel ucPanel3;
        private Controls.UcDataGridView dgvDept;
        private Controls.UcButton btnSearch;
        private Controls.UcLabel ucLabel3;
        private Controls.UcTextBox txtSEmpName;
        private Controls.UcButton btnSave;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colSelectRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRoleID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRoleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrgID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrgName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colReadOrg;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colEditOrg;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDeptID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDeptName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDeptOrgName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colReadDept;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colEditDept;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmpID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmpOrgName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmpDeptName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colReadEmp;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colEditEmp;
    }
}