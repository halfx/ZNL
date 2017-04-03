namespace ZNLCRM.UI.HR
{
    partial class frmSelectDepartment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelectDepartment));
            this.ucTabControl1 = new ZNLCRM.Controls.UcTabControl(this.components);
            this.tabControlPanel1 = new DevComponents.DotNetBar.TabControlPanel();
            this.ucPanel2 = new ZNLCRM.Controls.UcPanel(this.components);
            this.grpDept = new System.Windows.Forms.GroupBox();
            this.dgvDept = new ZNLCRM.Controls.UcDataGridView(this.components);
            this.colDeptID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDeptNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDeptName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpSearch = new ZNLCRM.Controls.UcPanel(this.components);
            this.btnSearch = new ZNLCRM.Controls.UcButton(this.components);
            this.ucLabel2 = new ZNLCRM.Controls.UcLabel(this.components);
            this.txtDeptName = new ZNLCRM.Controls.UcTextBox(this.components);
            this.chkAll = new ZNLCRM.Controls.UcCheckBox(this.components);
            this.expandableSplitter1 = new DevComponents.DotNetBar.ExpandableSplitter();
            this.ucPanel1 = new ZNLCRM.Controls.UcPanel(this.components);
            this.trOrg = new ZNLCRM.Controls.UcAdTree(this.components);
            this.nodeConnector1 = new DevComponents.AdvTree.NodeConnector();
            this.elementStyle1 = new DevComponents.DotNetBar.ElementStyle();
            this.tabSlcEmp = new DevComponents.DotNetBar.TabItem(this.components);
            this.panBottom = new ZNLCRM.Controls.UcPanel(this.components);
            this.btnCancel = new ZNLCRM.Controls.UcButton(this.components);
            this.btnOk = new ZNLCRM.Controls.UcButton(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ucTabControl1)).BeginInit();
            this.ucTabControl1.SuspendLayout();
            this.tabControlPanel1.SuspendLayout();
            this.ucPanel2.SuspendLayout();
            this.grpDept.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDept)).BeginInit();
            this.grpSearch.SuspendLayout();
            this.ucPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trOrg)).BeginInit();
            this.panBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // ucTabControl1
            // 
            this.ucTabControl1.BackColor = System.Drawing.Color.Transparent;
            this.ucTabControl1.CanReorderTabs = true;
            this.ucTabControl1.Controls.Add(this.tabControlPanel1);
            this.ucTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucTabControl1.Location = new System.Drawing.Point(0, 0);
            this.ucTabControl1.Name = "ucTabControl1";
            this.ucTabControl1.SelectedTabFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold);
            this.ucTabControl1.SelectedTabIndex = 0;
            this.ucTabControl1.Size = new System.Drawing.Size(879, 305);
            this.ucTabControl1.Style = DevComponents.DotNetBar.eTabStripStyle.VS2005;
            this.ucTabControl1.TabIndex = 11;
            this.ucTabControl1.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            this.ucTabControl1.Tabs.Add(this.tabSlcEmp);
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
            this.tabControlPanel1.Size = new System.Drawing.Size(879, 280);
            this.tabControlPanel1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(242)))), ((int)(((byte)(232)))));
            this.tabControlPanel1.Style.BackColor2.Color = System.Drawing.Color.White;
            this.tabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(168)))), ((int)(((byte)(153)))));
            this.tabControlPanel1.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right)
                        | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel1.Style.GradientAngle = 90;
            this.tabControlPanel1.TabIndex = 1;
            this.tabControlPanel1.TabItem = this.tabSlcEmp;
            // 
            // ucPanel2
            // 
            this.ucPanel2.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel2.Controls.Add(this.grpDept);
            this.ucPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPanel2.Location = new System.Drawing.Point(201, 1);
            this.ucPanel2.Name = "ucPanel2";
            this.ucPanel2.Padding = new System.Windows.Forms.Padding(5);
            this.ucPanel2.Size = new System.Drawing.Size(677, 278);
            this.ucPanel2.TabIndex = 5;
            // 
            // grpDept
            // 
            this.grpDept.Controls.Add(this.dgvDept);
            this.grpDept.Controls.Add(this.grpSearch);
            this.grpDept.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDept.Location = new System.Drawing.Point(5, 5);
            this.grpDept.Name = "grpDept";
            this.grpDept.Size = new System.Drawing.Size(667, 268);
            this.grpDept.TabIndex = 1;
            this.grpDept.TabStop = false;
            this.grpDept.Text = "部门列表";
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
            this.colDeptNo,
            this.colDeptName});
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
            this.dgvDept.Location = new System.Drawing.Point(3, 47);
            this.dgvDept.Name = "dgvDept";
            this.dgvDept.PaintEnhancedSelection = false;
            this.dgvDept.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDept.RowTemplate.Height = 23;
            this.dgvDept.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDept.SelectAllSignVisible = false;
            this.dgvDept.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvDept.Size = new System.Drawing.Size(661, 218);
            this.dgvDept.TabIndex = 0;
            // 
            // colDeptID
            // 
            this.colDeptID.DataPropertyName = "DeptID";
            this.colDeptID.HeaderText = "部门ID";
            this.colDeptID.Name = "colDeptID";
            this.colDeptID.ReadOnly = true;
            this.colDeptID.Visible = false;
            // 
            // colDeptNo
            // 
            this.colDeptNo.DataPropertyName = "DeptNo";
            this.colDeptNo.HeaderText = "部门编号";
            this.colDeptNo.Name = "colDeptNo";
            this.colDeptNo.ReadOnly = true;
            // 
            // colDeptName
            // 
            this.colDeptName.DataPropertyName = "DeptName";
            this.colDeptName.HeaderText = "部门名称";
            this.colDeptName.Name = "colDeptName";
            this.colDeptName.ReadOnly = true;
            // 
            // grpSearch
            // 
            this.grpSearch.BackColor = System.Drawing.Color.Transparent;
            this.grpSearch.Controls.Add(this.btnSearch);
            this.grpSearch.Controls.Add(this.ucLabel2);
            this.grpSearch.Controls.Add(this.txtDeptName);
            this.grpSearch.Controls.Add(this.chkAll);
            this.grpSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpSearch.Location = new System.Drawing.Point(3, 17);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(661, 30);
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
            this.ucLabel2.Text = "部门名称：";
            // 
            // txtDeptName
            // 
            // 
            // 
            // 
            this.txtDeptName.Border.Class = "TextBoxBorder";
            this.txtDeptName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDeptName.EnterToNextControl = false;
            this.txtDeptName.Location = new System.Drawing.Point(77, 3);
            this.txtDeptName.Name = "txtDeptName";
            this.txtDeptName.Size = new System.Drawing.Size(208, 21);
            this.txtDeptName.TabIndex = 3;
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
            this.expandableSplitter1.Size = new System.Drawing.Size(3, 278);
            this.expandableSplitter1.Style = DevComponents.DotNetBar.eSplitterStyle.Office2007;
            this.expandableSplitter1.TabIndex = 7;
            this.expandableSplitter1.TabStop = false;
            // 
            // ucPanel1
            // 
            this.ucPanel1.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel1.Controls.Add(this.trOrg);
            this.ucPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.ucPanel1.Location = new System.Drawing.Point(1, 1);
            this.ucPanel1.Name = "ucPanel1";
            this.ucPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.ucPanel1.Size = new System.Drawing.Size(197, 278);
            this.ucPanel1.TabIndex = 5;
            // 
            // trOrg
            // 
            this.trOrg.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline;
            this.trOrg.AllowDrop = true;
            this.trOrg.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.trOrg.BackgroundStyle.Class = "TreeBorderKey";
            this.trOrg.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.trOrg.CellLayout = DevComponents.AdvTree.eCellLayout.Horizontal;
            this.trOrg.CellPartLayout = DevComponents.AdvTree.eCellPartLayout.Horizontal;
            this.trOrg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trOrg.Location = new System.Drawing.Point(5, 5);
            this.trOrg.Name = "trOrg";
            this.trOrg.NodesConnector = this.nodeConnector1;
            this.trOrg.NodeStyle = this.elementStyle1;
            this.trOrg.PathSeparator = ";";
            this.trOrg.Size = new System.Drawing.Size(187, 268);
            this.trOrg.Styles.Add(this.elementStyle1);
            this.trOrg.TabIndex = 0;
            this.trOrg.SelectedIndexChanged += new System.EventHandler(this.trOrg_SelectedIndexChanged);
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
            // tabSlcEmp
            // 
            this.tabSlcEmp.AttachedControl = this.tabControlPanel1;
            this.tabSlcEmp.Image = ((System.Drawing.Image)(resources.GetObject("tabSlcEmp.Image")));
            this.tabSlcEmp.Name = "tabSlcEmp";
            this.tabSlcEmp.Text = "部门选择";
            // 
            // panBottom
            // 
            this.panBottom.BackColor = System.Drawing.Color.Transparent;
            this.panBottom.Controls.Add(this.btnCancel);
            this.panBottom.Controls.Add(this.btnOk);
            this.panBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panBottom.Location = new System.Drawing.Point(0, 305);
            this.panBottom.Name = "panBottom";
            this.panBottom.Size = new System.Drawing.Size(879, 47);
            this.panBottom.TabIndex = 12;
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(466, 6);
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
            this.btnOk.Location = new System.Drawing.Point(356, 6);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(86, 30);
            this.btnOk.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "确定(&S)";
            this.btnOk.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // frmSelectDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 352);
            this.Controls.Add(this.ucTabControl1);
            this.Controls.Add(this.panBottom);
            this.Name = "frmSelectDepartment";
            this.Text = "部门选择窗体";
            this.Load += new System.EventHandler(this.frmSelectDepartment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ucTabControl1)).EndInit();
            this.ucTabControl1.ResumeLayout(false);
            this.tabControlPanel1.ResumeLayout(false);
            this.ucPanel2.ResumeLayout(false);
            this.grpDept.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDept)).EndInit();
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            this.ucPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trOrg)).EndInit();
            this.panBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.UcTabControl ucTabControl1;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel1;
        private Controls.UcPanel ucPanel2;
        private System.Windows.Forms.GroupBox grpDept;
        private Controls.UcDataGridView dgvDept;
        private Controls.UcPanel grpSearch;
        private Controls.UcButton btnSearch;
        private Controls.UcLabel ucLabel2;
        private Controls.UcTextBox txtDeptName;
        private Controls.UcCheckBox chkAll;
        private DevComponents.DotNetBar.ExpandableSplitter expandableSplitter1;
        private Controls.UcPanel ucPanel1;
        private Controls.UcAdTree trOrg;
        private DevComponents.AdvTree.NodeConnector nodeConnector1;
        private DevComponents.DotNetBar.ElementStyle elementStyle1;
        private DevComponents.DotNetBar.TabItem tabSlcEmp;
        private Controls.UcPanel panBottom;
        private Controls.UcButton btnCancel;
        private Controls.UcButton btnOk;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDeptID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDeptNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDeptName;
    }
}