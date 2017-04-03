namespace ZNLCRM.UI.CRM
{
    partial class frmCRMVisitPlanManage
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
            this.ucPanel1 = new ZNLCRM.Controls.UcPanel(this.components);
            this.ucToolStrip1 = new ZNLCRM.Controls.UcToolStrip(this.components);
            this.tsbAddVisitPlan = new System.Windows.Forms.ToolStripButton();
            this.tsbEditVisitPlan = new System.Windows.Forms.ToolStripButton();
            this.tsbDelVisitPlan = new System.Windows.Forms.ToolStripButton();
            this.ucPanel2 = new ZNLCRM.Controls.UcPanel(this.components);
            this.dgvPlan = new ZNLCRM.Controls.UcDataGridView(this.components);
            this.ucPanel3 = new ZNLCRM.Controls.UcPanel(this.components);
            this.btnSearch = new ZNLCRM.Controls.UcButton(this.components);
            this.txtPlanName = new ZNLCRM.Controls.UcTextBox(this.components);
            this.ucLabel1 = new ZNLCRM.Controls.UcLabel(this.components);
            this.ucPanel4 = new ZNLCRM.Controls.UcPanel(this.components);
            this.pgPlan = new ZNLCRM.Controls.UcPager();
            this.colCustVstPlnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVisit = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colCustVstPlnGuID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBillNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_CompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPlanName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVstTyp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ucPanel1.SuspendLayout();
            this.ucToolStrip1.SuspendLayout();
            this.ucPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlan)).BeginInit();
            this.ucPanel3.SuspendLayout();
            this.ucPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // ucPanel1
            // 
            this.ucPanel1.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel1.Controls.Add(this.ucToolStrip1);
            this.ucPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucPanel1.Location = new System.Drawing.Point(0, 0);
            this.ucPanel1.Name = "ucPanel1";
            this.ucPanel1.Size = new System.Drawing.Size(946, 31);
            this.ucPanel1.TabIndex = 0;
            // 
            // ucToolStrip1
            // 
            this.ucToolStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ucToolStrip1.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.ucToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAddVisitPlan,
            this.tsbEditVisitPlan,
            this.tsbDelVisitPlan});
            this.ucToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.ucToolStrip1.Name = "ucToolStrip1";
            this.ucToolStrip1.Padding = new System.Windows.Forms.Padding(5);
            this.ucToolStrip1.Size = new System.Drawing.Size(946, 36);
            this.ucToolStrip1.TabIndex = 0;
            this.ucToolStrip1.Text = "ucToolStrip1";
            // 
            // tsbAddVisitPlan
            // 
            this.tsbAddVisitPlan.Image = global::ZNLCRM.UI.Properties.Resources.add_1;
            this.tsbAddVisitPlan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddVisitPlan.Name = "tsbAddVisitPlan";
            this.tsbAddVisitPlan.Size = new System.Drawing.Size(107, 23);
            this.tsbAddVisitPlan.Text = "添加拜访计划";
            this.tsbAddVisitPlan.Click += new System.EventHandler(this.tsbAddVisitPlan_Click);
            // 
            // tsbEditVisitPlan
            // 
            this.tsbEditVisitPlan.Image = global::ZNLCRM.UI.Properties.Resources.edit_1;
            this.tsbEditVisitPlan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditVisitPlan.Name = "tsbEditVisitPlan";
            this.tsbEditVisitPlan.Size = new System.Drawing.Size(107, 23);
            this.tsbEditVisitPlan.Text = "编辑拜访计划";
            this.tsbEditVisitPlan.Click += new System.EventHandler(this.tsbEditVisitPlan_Click);
            // 
            // tsbDelVisitPlan
            // 
            this.tsbDelVisitPlan.Image = global::ZNLCRM.UI.Properties.Resources.del_1;
            this.tsbDelVisitPlan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelVisitPlan.Name = "tsbDelVisitPlan";
            this.tsbDelVisitPlan.Size = new System.Drawing.Size(107, 23);
            this.tsbDelVisitPlan.Text = "删除拜访计划";
            this.tsbDelVisitPlan.Click += new System.EventHandler(this.tsbDelVisitPlan_Click);
            // 
            // ucPanel2
            // 
            this.ucPanel2.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel2.Controls.Add(this.dgvPlan);
            this.ucPanel2.Controls.Add(this.ucPanel3);
            this.ucPanel2.Controls.Add(this.ucPanel4);
            this.ucPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPanel2.Location = new System.Drawing.Point(0, 31);
            this.ucPanel2.Name = "ucPanel2";
            this.ucPanel2.Size = new System.Drawing.Size(946, 545);
            this.ucPanel2.TabIndex = 1;
            // 
            // dgvPlan
            // 
            this.dgvPlan.AllowUserToAddRows = false;
            this.dgvPlan.AllowUserToDeleteRows = false;
            this.dgvPlan.AllowUserToOrderColumns = true;
            this.dgvPlan.BackgroundColor = System.Drawing.Color.White;
            this.dgvPlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCustVstPlnID,
            this.colVisit,
            this.colCustVstPlnGuID,
            this.colBillNo,
            this.col_CompanyName,
            this.colPlanName,
            this.colVstTyp,
            this.colStartDate,
            this.colEndDate});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPlan.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPlan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPlan.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvPlan.HighlightSelectedColumnHeaders = false;
            this.dgvPlan.Location = new System.Drawing.Point(0, 30);
            this.dgvPlan.Name = "dgvPlan";
            this.dgvPlan.PaintEnhancedSelection = false;
            this.dgvPlan.ReadOnly = true;
            this.dgvPlan.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPlan.RowHeadersWidth = 40;
            this.dgvPlan.RowTemplate.Height = 23;
            this.dgvPlan.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPlan.SelectAllSignVisible = false;
            this.dgvPlan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvPlan.ShowRowNo = true;
            this.dgvPlan.Size = new System.Drawing.Size(946, 483);
            this.dgvPlan.TabIndex = 1;
            this.dgvPlan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPlan_CellContentClick);
            this.dgvPlan.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPlan_CellDoubleClick);
            this.dgvPlan.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPlan_RowEnter);
            // 
            // ucPanel3
            // 
            this.ucPanel3.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel3.Controls.Add(this.btnSearch);
            this.ucPanel3.Controls.Add(this.txtPlanName);
            this.ucPanel3.Controls.Add(this.ucLabel1);
            this.ucPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucPanel3.Location = new System.Drawing.Point(0, 0);
            this.ucPanel3.Name = "ucPanel3";
            this.ucPanel3.Size = new System.Drawing.Size(946, 30);
            this.ucPanel3.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSearch.Image = global::ZNLCRM.UI.Properties.Resources.search;
            this.btnSearch.Location = new System.Drawing.Point(237, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "搜索";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtPlanName
            // 
            // 
            // 
            // 
            this.txtPlanName.Border.Class = "TextBoxBorder";
            this.txtPlanName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPlanName.EnterToNextControl = false;
            this.txtPlanName.Location = new System.Drawing.Point(81, 5);
            this.txtPlanName.Name = "txtPlanName";
            this.txtPlanName.Size = new System.Drawing.Size(150, 21);
            this.txtPlanName.TabIndex = 1;
            // 
            // ucLabel1
            // 
            this.ucLabel1.AutoSize = true;
            this.ucLabel1.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabel1.ForeColor = System.Drawing.Color.Gray;
            this.ucLabel1.Location = new System.Drawing.Point(12, 10);
            this.ucLabel1.Name = "ucLabel1";
            this.ucLabel1.Size = new System.Drawing.Size(65, 12);
            this.ucLabel1.TabIndex = 0;
            this.ucLabel1.Text = "拜访主题：";
            // 
            // ucPanel4
            // 
            this.ucPanel4.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel4.Controls.Add(this.pgPlan);
            this.ucPanel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucPanel4.Location = new System.Drawing.Point(0, 513);
            this.ucPanel4.Name = "ucPanel4";
            this.ucPanel4.Size = new System.Drawing.Size(946, 32);
            this.ucPanel4.TabIndex = 2;
            // 
            // pgPlan
            // 
            this.pgPlan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pgPlan.AutoSize = true;
            this.pgPlan.BackColor = System.Drawing.Color.Transparent;
            this.pgPlan.Location = new System.Drawing.Point(129, 8);
            this.pgPlan.Name = "pgPlan";
            this.pgPlan.RecordCount = 0;
            this.pgPlan.Size = new System.Drawing.Size(267, 20);
            this.pgPlan.TabIndex = 1;
            this.pgPlan.PageIndexChanged += new System.EventHandler(this.pgPlan_PageIndexChanged);
            // 
            // colCustVstPlnID
            // 
            this.colCustVstPlnID.DataPropertyName = "CustVstPlnID";
            this.colCustVstPlnID.HeaderText = "拜访计划ID";
            this.colCustVstPlnID.Name = "colCustVstPlnID";
            this.colCustVstPlnID.ReadOnly = true;
            this.colCustVstPlnID.Visible = false;
            // 
            // colVisit
            // 
            this.colVisit.HeaderText = "";
            this.colVisit.Name = "colVisit";
            this.colVisit.ReadOnly = true;
            this.colVisit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colVisit.Text = "记录详情";
            this.colVisit.UseColumnTextForLinkValue = true;
            // 
            // colCustVstPlnGuID
            // 
            this.colCustVstPlnGuID.DataPropertyName = "CustVstPlnGuID";
            this.colCustVstPlnGuID.HeaderText = "拜访计划GUID";
            this.colCustVstPlnGuID.Name = "colCustVstPlnGuID";
            this.colCustVstPlnGuID.ReadOnly = true;
            this.colCustVstPlnGuID.Visible = false;
            // 
            // colBillNo
            // 
            this.colBillNo.DataPropertyName = "BillNo";
            this.colBillNo.HeaderText = "计划编号";
            this.colBillNo.Name = "colBillNo";
            this.colBillNo.ReadOnly = true;
            // 
            // col_CompanyName
            // 
            this.col_CompanyName.DataPropertyName = "CompanyName";
            this.col_CompanyName.HeaderText = "公司名";
            this.col_CompanyName.Name = "col_CompanyName";
            this.col_CompanyName.ReadOnly = true;
            this.col_CompanyName.Width = 200;
            // 
            // colPlanName
            // 
            this.colPlanName.DataPropertyName = "PlanName";
            this.colPlanName.HeaderText = "跟踪主题";
            this.colPlanName.Name = "colPlanName";
            this.colPlanName.ReadOnly = true;
            this.colPlanName.Width = 200;
            // 
            // colVstTyp
            // 
            this.colVstTyp.DataPropertyName = "VstTyp";
            this.colVstTyp.HeaderText = "拜访类型";
            this.colVstTyp.Name = "colVstTyp";
            this.colVstTyp.ReadOnly = true;
            this.colVstTyp.Width = 80;
            // 
            // colStartDate
            // 
            this.colStartDate.DataPropertyName = "StartDate";
            this.colStartDate.HeaderText = "开始时间";
            this.colStartDate.Name = "colStartDate";
            this.colStartDate.ReadOnly = true;
            // 
            // colEndDate
            // 
            this.colEndDate.DataPropertyName = "EndDate";
            this.colEndDate.HeaderText = "结束时间";
            this.colEndDate.Name = "colEndDate";
            this.colEndDate.ReadOnly = true;
            // 
            // frmCRMVisitPlanManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 576);
            this.Controls.Add(this.ucPanel2);
            this.Controls.Add(this.ucPanel1);
            this.Name = "frmCRMVisitPlanManage";
            this.Text = " 拜访计划管理";
            this.Load += new System.EventHandler(this.frmCRMVisitPlanManage_Load);
            this.ucPanel1.ResumeLayout(false);
            this.ucPanel1.PerformLayout();
            this.ucToolStrip1.ResumeLayout(false);
            this.ucToolStrip1.PerformLayout();
            this.ucPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlan)).EndInit();
            this.ucPanel3.ResumeLayout(false);
            this.ucPanel3.PerformLayout();
            this.ucPanel4.ResumeLayout(false);
            this.ucPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.UcPanel ucPanel1;
        private Controls.UcToolStrip ucToolStrip1;
        private Controls.UcPanel ucPanel2;
        private System.Windows.Forms.ToolStripButton tsbAddVisitPlan;
        private System.Windows.Forms.ToolStripButton tsbEditVisitPlan;
        private System.Windows.Forms.ToolStripButton tsbDelVisitPlan;
        private Controls.UcDataGridView dgvPlan;
        private Controls.UcPanel ucPanel3;
        private Controls.UcButton btnSearch;
        private Controls.UcTextBox txtPlanName;
        private Controls.UcLabel ucLabel1;
        private Controls.UcPanel ucPanel4;
        private Controls.UcPager pgPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustVstPlnID;
        private System.Windows.Forms.DataGridViewLinkColumn colVisit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustVstPlnGuID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBillNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_CompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlanName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVstTyp;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEndDate;
    }
}