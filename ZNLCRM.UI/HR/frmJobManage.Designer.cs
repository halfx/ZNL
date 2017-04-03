namespace ZNLCRM.UI.HR
{
    partial class frmJobManage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.expandableSplitter1 = new DevComponents.DotNetBar.ExpandableSplitter();
            this.panMid = new ZNLCRM.Controls.UcPanel(this.components);
            this.dgvMain = new ZNLCRM.Controls.UcDataGridView(this.components);
            this.col_CRM_JobMast_EmpJobGuid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_CRM_JobMast_BillNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_CRM_JobMast_JobName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_CRM_JobMast_JobType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_CRM_JobMast_JobDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_CRM_JobMast_BelongEmpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_CRM_JobMast_Summary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_CRM_JobMast_ApproveStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_CRM_JobMast_CreatedTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_CRM_JobMast_CreatedEmpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panBottom = new ZNLCRM.Controls.UcPanel(this.components);
            this.pagMain = new ZNLCRM.Controls.UcPager();
            this.panTopMain = new ZNLCRM.Controls.UcPanel(this.components);
            this.panTop = new ZNLCRM.Controls.UcPanel(this.components);
            this.btnSearch = new ZNLCRM.Controls.UcButton(this.components);
            this.tlbMain = new ZNLCRM.Controls.UcToolStrip(this.components);
            this.tlbAdd1 = new System.Windows.Forms.ToolStripButton();
            this.tlbAdd2 = new System.Windows.Forms.ToolStripButton();
            this.tlbAdd3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tlbEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tlbDel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tlbAuditBill = new System.Windows.Forms.ToolStripButton();
            this.tlbCancelBill = new System.Windows.Forms.ToolStripButton();
            this.panMid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.panBottom.SuspendLayout();
            this.panTopMain.SuspendLayout();
            this.panTop.SuspendLayout();
            this.tlbMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // expandableSplitter1
            // 
            this.expandableSplitter1.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207)))));
            this.expandableSplitter1.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter1.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandableSplitter1.Dock = System.Windows.Forms.DockStyle.Top;
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
            this.expandableSplitter1.Location = new System.Drawing.Point(0, 79);
            this.expandableSplitter1.Name = "expandableSplitter1";
            this.expandableSplitter1.Size = new System.Drawing.Size(925, 6);
            this.expandableSplitter1.Style = DevComponents.DotNetBar.eSplitterStyle.Office2007;
            this.expandableSplitter1.TabIndex = 3;
            this.expandableSplitter1.TabStop = false;
            // 
            // panMid
            // 
            this.panMid.BackColor = System.Drawing.Color.Transparent;
            this.panMid.Controls.Add(this.dgvMain);
            this.panMid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panMid.Location = new System.Drawing.Point(0, 85);
            this.panMid.Name = "panMid";
            this.panMid.Padding = new System.Windows.Forms.Padding(5);
            this.panMid.Size = new System.Drawing.Size(925, 296);
            this.panMid.TabIndex = 0;
            // 
            // dgvMain
            // 
            this.dgvMain.AllowUserToAddRows = false;
            this.dgvMain.AllowUserToDeleteRows = false;
            this.dgvMain.AllowUserToOrderColumns = true;
            this.dgvMain.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_CRM_JobMast_EmpJobGuid,
            this.col_CRM_JobMast_BillNo,
            this.col_CRM_JobMast_JobName,
            this.col_CRM_JobMast_JobType,
            this.col_CRM_JobMast_JobDate,
            this.col_CRM_JobMast_BelongEmpName,
            this.col_CRM_JobMast_Summary,
            this.col_CRM_JobMast_ApproveStatus,
            this.col_CRM_JobMast_CreatedTime,
            this.col_CRM_JobMast_CreatedEmpName});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMain.DefaultCellStyle = dataGridViewCellStyle2;
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
            this.dgvMain.Size = new System.Drawing.Size(915, 286);
            this.dgvMain.TabIndex = 0;
            this.dgvMain.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvMain_CellMouseDoubleClick);
            // 
            // col_CRM_JobMast_EmpJobGuid
            // 
            this.col_CRM_JobMast_EmpJobGuid.DataPropertyName = "EmpJobGuid";
            this.col_CRM_JobMast_EmpJobGuid.HeaderText = "KeyGuid";
            this.col_CRM_JobMast_EmpJobGuid.Name = "col_CRM_JobMast_EmpJobGuid";
            this.col_CRM_JobMast_EmpJobGuid.ReadOnly = true;
            this.col_CRM_JobMast_EmpJobGuid.Visible = false;
            this.col_CRM_JobMast_EmpJobGuid.Width = 60;
            // 
            // col_CRM_JobMast_BillNo
            // 
            this.col_CRM_JobMast_BillNo.DataPropertyName = "BillNo";
            this.col_CRM_JobMast_BillNo.HeaderText = "单据编号";
            this.col_CRM_JobMast_BillNo.Name = "col_CRM_JobMast_BillNo";
            this.col_CRM_JobMast_BillNo.ReadOnly = true;
            this.col_CRM_JobMast_BillNo.Width = 80;
            // 
            // col_CRM_JobMast_JobName
            // 
            this.col_CRM_JobMast_JobName.DataPropertyName = "JobName";
            this.col_CRM_JobMast_JobName.HeaderText = "报告标题";
            this.col_CRM_JobMast_JobName.Name = "col_CRM_JobMast_JobName";
            this.col_CRM_JobMast_JobName.ReadOnly = true;
            this.col_CRM_JobMast_JobName.Width = 120;
            // 
            // col_CRM_JobMast_JobType
            // 
            this.col_CRM_JobMast_JobType.DataPropertyName = "JobType";
            this.col_CRM_JobMast_JobType.HeaderText = "报告类型";
            this.col_CRM_JobMast_JobType.Name = "col_CRM_JobMast_JobType";
            this.col_CRM_JobMast_JobType.ReadOnly = true;
            // 
            // col_CRM_JobMast_JobDate
            // 
            this.col_CRM_JobMast_JobDate.DataPropertyName = "JobDate";
            this.col_CRM_JobMast_JobDate.HeaderText = "报告日期";
            this.col_CRM_JobMast_JobDate.Name = "col_CRM_JobMast_JobDate";
            this.col_CRM_JobMast_JobDate.ReadOnly = true;
            // 
            // col_CRM_JobMast_BelongEmpName
            // 
            this.col_CRM_JobMast_BelongEmpName.DataPropertyName = "BelongEmpName";
            this.col_CRM_JobMast_BelongEmpName.HeaderText = "所属员工";
            this.col_CRM_JobMast_BelongEmpName.Name = "col_CRM_JobMast_BelongEmpName";
            this.col_CRM_JobMast_BelongEmpName.ReadOnly = true;
            // 
            // col_CRM_JobMast_Summary
            // 
            this.col_CRM_JobMast_Summary.DataPropertyName = "Summary";
            this.col_CRM_JobMast_Summary.HeaderText = "搞要";
            this.col_CRM_JobMast_Summary.Name = "col_CRM_JobMast_Summary";
            this.col_CRM_JobMast_Summary.ReadOnly = true;
            // 
            // col_CRM_JobMast_ApproveStatus
            // 
            this.col_CRM_JobMast_ApproveStatus.DataPropertyName = "ApproveStatus";
            this.col_CRM_JobMast_ApproveStatus.HeaderText = "审批状态";
            this.col_CRM_JobMast_ApproveStatus.Name = "col_CRM_JobMast_ApproveStatus";
            this.col_CRM_JobMast_ApproveStatus.ReadOnly = true;
            // 
            // col_CRM_JobMast_CreatedTime
            // 
            this.col_CRM_JobMast_CreatedTime.DataPropertyName = "CreatedTime";
            this.col_CRM_JobMast_CreatedTime.HeaderText = "创建日期";
            this.col_CRM_JobMast_CreatedTime.Name = "col_CRM_JobMast_CreatedTime";
            this.col_CRM_JobMast_CreatedTime.ReadOnly = true;
            // 
            // col_CRM_JobMast_CreatedEmpName
            // 
            this.col_CRM_JobMast_CreatedEmpName.DataPropertyName = "CreatedEmpName";
            this.col_CRM_JobMast_CreatedEmpName.HeaderText = "创建员工";
            this.col_CRM_JobMast_CreatedEmpName.Name = "col_CRM_JobMast_CreatedEmpName";
            this.col_CRM_JobMast_CreatedEmpName.ReadOnly = true;
            // 
            // panBottom
            // 
            this.panBottom.BackColor = System.Drawing.Color.Transparent;
            this.panBottom.Controls.Add(this.pagMain);
            this.panBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panBottom.Location = new System.Drawing.Point(0, 381);
            this.panBottom.Name = "panBottom";
            this.panBottom.Padding = new System.Windows.Forms.Padding(5);
            this.panBottom.Size = new System.Drawing.Size(925, 36);
            this.panBottom.TabIndex = 0;
            // 
            // pagMain
            // 
            this.pagMain.BackColor = System.Drawing.Color.Transparent;
            this.pagMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pagMain.Location = new System.Drawing.Point(5, 5);
            this.pagMain.Name = "pagMain";
            this.pagMain.RecordCount = 0;
            this.pagMain.Size = new System.Drawing.Size(915, 26);
            this.pagMain.TabIndex = 0;
            this.pagMain.PageIndexChanged += new System.EventHandler(this.pagMain_PageIndexChanged);
            // 
            // panTopMain
            // 
            this.panTopMain.BackColor = System.Drawing.Color.Transparent;
            this.panTopMain.Controls.Add(this.panTop);
            this.panTopMain.Controls.Add(this.tlbMain);
            this.panTopMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.panTopMain.Location = new System.Drawing.Point(0, 0);
            this.panTopMain.Name = "panTopMain";
            this.panTopMain.Size = new System.Drawing.Size(925, 79);
            this.panTopMain.TabIndex = 2;
            // 
            // panTop
            // 
            this.panTop.BackColor = System.Drawing.Color.Transparent;
            this.panTop.Controls.Add(this.btnSearch);
            this.panTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panTop.Location = new System.Drawing.Point(0, 36);
            this.panTop.Name = "panTop";
            this.panTop.Padding = new System.Windows.Forms.Padding(5);
            this.panTop.Size = new System.Drawing.Size(925, 43);
            this.panTop.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSearch.Location = new System.Drawing.Point(12, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "搜索";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tlbMain
            // 
            this.tlbMain.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tlbMain.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.tlbMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlbAdd1,
            this.tlbAdd2,
            this.tlbAdd3,
            this.toolStripSeparator1,
            this.tlbEdit,
            this.toolStripSeparator2,
            this.tlbDel,
            this.toolStripSeparator3,
            this.tlbAuditBill,
            this.tlbCancelBill});
            this.tlbMain.Location = new System.Drawing.Point(0, 0);
            this.tlbMain.Name = "tlbMain";
            this.tlbMain.Padding = new System.Windows.Forms.Padding(5);
            this.tlbMain.Size = new System.Drawing.Size(925, 36);
            this.tlbMain.TabIndex = 4;
            this.tlbMain.Text = "ucToolStrip1";
            this.tlbMain.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.tlbMain_ItemClicked);
            // 
            // tlbAdd1
            // 
            this.tlbAdd1.Image = global::ZNLCRM.UI.Properties.Resources.add;
            this.tlbAdd1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlbAdd1.Name = "tlbAdd1";
            this.tlbAdd1.Size = new System.Drawing.Size(81, 23);
            this.tlbAdd1.Text = "添加日报";
            // 
            // tlbAdd2
            // 
            this.tlbAdd2.Image = global::ZNLCRM.UI.Properties.Resources.add;
            this.tlbAdd2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlbAdd2.Name = "tlbAdd2";
            this.tlbAdd2.Size = new System.Drawing.Size(81, 23);
            this.tlbAdd2.Text = "添加周报";
            // 
            // tlbAdd3
            // 
            this.tlbAdd3.Image = global::ZNLCRM.UI.Properties.Resources.add;
            this.tlbAdd3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlbAdd3.Name = "tlbAdd3";
            this.tlbAdd3.Size = new System.Drawing.Size(81, 23);
            this.tlbAdd3.Text = "添加月报";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 26);
            // 
            // tlbEdit
            // 
            this.tlbEdit.Image = global::ZNLCRM.UI.Properties.Resources.modify;
            this.tlbEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlbEdit.Name = "tlbEdit";
            this.tlbEdit.Size = new System.Drawing.Size(55, 23);
            this.tlbEdit.Text = "修改";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 26);
            // 
            // tlbDel
            // 
            this.tlbDel.Image = global::ZNLCRM.UI.Properties.Resources.del;
            this.tlbDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlbDel.Name = "tlbDel";
            this.tlbDel.Size = new System.Drawing.Size(55, 23);
            this.tlbDel.Text = "删除";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 26);
            // 
            // tlbAuditBill
            // 
            this.tlbAuditBill.Image = global::ZNLCRM.UI.Properties.Resources.checkok;
            this.tlbAuditBill.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlbAuditBill.Name = "tlbAuditBill";
            this.tlbAuditBill.Size = new System.Drawing.Size(55, 23);
            this.tlbAuditBill.Text = "审核";
            // 
            // tlbCancelBill
            // 
            this.tlbCancelBill.Image = global::ZNLCRM.UI.Properties.Resources.cancel_1;
            this.tlbCancelBill.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlbCancelBill.Name = "tlbCancelBill";
            this.tlbCancelBill.Size = new System.Drawing.Size(55, 23);
            this.tlbCancelBill.Text = "撤单";
            // 
            // frmJobManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 417);
            this.Controls.Add(this.panMid);
            this.Controls.Add(this.expandableSplitter1);
            this.Controls.Add(this.panBottom);
            this.Controls.Add(this.panTopMain);
            this.Name = "frmJobManage";
            this.Text = "工作报告";
            this.Load += new System.EventHandler(this.frmJobManage_Load);
            this.panMid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.panBottom.ResumeLayout(false);
            this.panTopMain.ResumeLayout(false);
            this.panTopMain.PerformLayout();
            this.panTop.ResumeLayout(false);
            this.tlbMain.ResumeLayout(false);
            this.tlbMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.UcPanel panMid;
        private Controls.UcPanel panBottom;
        private Controls.UcDataGridView dgvMain;
        private Controls.UcPager pagMain;
        private Controls.UcPanel panTopMain;
        private Controls.UcPanel panTop;
        private Controls.UcButton btnSearch;
        private Controls.UcToolStrip tlbMain;
        private System.Windows.Forms.ToolStripButton tlbAdd1;
        private System.Windows.Forms.ToolStripButton tlbAdd2;
        private System.Windows.Forms.ToolStripButton tlbAdd3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tlbEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tlbDel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tlbAuditBill;
        private System.Windows.Forms.ToolStripButton tlbCancelBill;
        private DevComponents.DotNetBar.ExpandableSplitter expandableSplitter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_CRM_JobMast_EmpJobGuid;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_CRM_JobMast_BillNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_CRM_JobMast_JobName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_CRM_JobMast_JobType;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_CRM_JobMast_JobDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_CRM_JobMast_BelongEmpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_CRM_JobMast_Summary;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_CRM_JobMast_ApproveStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_CRM_JobMast_CreatedTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_CRM_JobMast_CreatedEmpName;

    }
}