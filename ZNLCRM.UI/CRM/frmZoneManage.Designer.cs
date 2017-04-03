namespace ZNLCRM.UI.CRM
{
    partial class frmZoneManage
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
            this.ucPanel3 = new ZNLCRM.Controls.UcPanel(this.components);
            this.dgvZone = new ZNLCRM.Controls.UcDataGridView(this.components);
            this.ucPanel4 = new ZNLCRM.Controls.UcPanel(this.components);
            this.btnSave = new ZNLCRM.Controls.UcButton(this.components);
            this.ucButton1 = new ZNLCRM.Controls.UcButton(this.components);
            this.btnAddZone = new ZNLCRM.Controls.UcButton(this.components);
            this.ucLabel7 = new ZNLCRM.Controls.UcLabel(this.components);
            this.txtEmpName = new ZNLCRM.Controls.UcTextBox(this.components);
            this.btnSearch = new ZNLCRM.Controls.UcButton(this.components);
            this.ucExpandableSplitter1 = new ZNLCRM.Controls.UcExpandableSplitter(this.components);
            this.ucPanel2 = new ZNLCRM.Controls.UcPanel(this.components);
            this.adtZone = new ZNLCRM.Controls.UcAdTree(this.components);
            this.cmsOper = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiArea = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCountry = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiProvince = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCity = new System.Windows.Forms.ToolStripMenuItem();
            this.nodeConnector1 = new DevComponents.AdvTree.NodeConnector();
            this.elementStyle1 = new DevComponents.DotNetBar.ElementStyle();
            this.ucPanel5 = new ZNLCRM.Controls.UcPanel(this.components);
            this.ucLabel1 = new ZNLCRM.Controls.UcLabel(this.components);
            this.txtSZone = new ZNLCRM.Controls.UcTextBox(this.components);
            this.colZID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPZID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colZCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName_CN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName_EN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colZType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ucPanel1.SuspendLayout();
            this.ucPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZone)).BeginInit();
            this.ucPanel4.SuspendLayout();
            this.ucPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adtZone)).BeginInit();
            this.cmsOper.SuspendLayout();
            this.ucPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // ucPanel1
            // 
            this.ucPanel1.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel1.Controls.Add(this.ucPanel3);
            this.ucPanel1.Controls.Add(this.ucExpandableSplitter1);
            this.ucPanel1.Controls.Add(this.ucPanel2);
            this.ucPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPanel1.Location = new System.Drawing.Point(0, 0);
            this.ucPanel1.Name = "ucPanel1";
            this.ucPanel1.Size = new System.Drawing.Size(882, 450);
            this.ucPanel1.TabIndex = 2;
            // 
            // ucPanel3
            // 
            this.ucPanel3.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel3.Controls.Add(this.dgvZone);
            this.ucPanel3.Controls.Add(this.ucPanel4);
            this.ucPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPanel3.Location = new System.Drawing.Point(276, 0);
            this.ucPanel3.Name = "ucPanel3";
            this.ucPanel3.Size = new System.Drawing.Size(606, 450);
            this.ucPanel3.TabIndex = 1;
            // 
            // dgvZone
            // 
            this.dgvZone.AllowUserToOrderColumns = true;
            this.dgvZone.BackgroundColor = System.Drawing.Color.White;
            this.dgvZone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZone.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colZID,
            this.colPZID,
            this.colZCode,
            this.colName_CN,
            this.colName_EN,
            this.colZType});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvZone.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvZone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvZone.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvZone.HighlightSelectedColumnHeaders = false;
            this.dgvZone.Location = new System.Drawing.Point(0, 31);
            this.dgvZone.Name = "dgvZone";
            this.dgvZone.PaintEnhancedSelection = false;
            this.dgvZone.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvZone.RowHeadersWidth = 40;
            this.dgvZone.RowTemplate.Height = 23;
            this.dgvZone.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvZone.SelectAllSignVisible = false;
            this.dgvZone.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvZone.ShowRowNo = true;
            this.dgvZone.Size = new System.Drawing.Size(606, 419);
            this.dgvZone.TabIndex = 0;
            // 
            // ucPanel4
            // 
            this.ucPanel4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ucPanel4.Controls.Add(this.btnSave);
            this.ucPanel4.Controls.Add(this.ucButton1);
            this.ucPanel4.Controls.Add(this.btnAddZone);
            this.ucPanel4.Controls.Add(this.ucLabel7);
            this.ucPanel4.Controls.Add(this.txtEmpName);
            this.ucPanel4.Controls.Add(this.btnSearch);
            this.ucPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucPanel4.Location = new System.Drawing.Point(0, 0);
            this.ucPanel4.Name = "ucPanel4";
            this.ucPanel4.Size = new System.Drawing.Size(606, 31);
            this.ucPanel4.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Image = global::ZNLCRM.UI.Properties.Resources.save_1;
            this.btnSave.Location = new System.Drawing.Point(498, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlS);
            this.btnSave.Size = new System.Drawing.Size(72, 23);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "保存(S)";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ucButton1
            // 
            this.ucButton1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ucButton1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ucButton1.Image = global::ZNLCRM.UI.Properties.Resources.del_4;
            this.ucButton1.Location = new System.Drawing.Point(416, 3);
            this.ucButton1.Name = "ucButton1";
            this.ucButton1.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlA);
            this.ucButton1.Size = new System.Drawing.Size(76, 23);
            this.ucButton1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.ucButton1.TabIndex = 4;
            this.ucButton1.Text = "删除(D)";
            this.ucButton1.Click += new System.EventHandler(this.ucButton1_Click);
            // 
            // btnAddZone
            // 
            this.btnAddZone.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddZone.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAddZone.Image = global::ZNLCRM.UI.Properties.Resources.add_4;
            this.btnAddZone.Location = new System.Drawing.Point(334, 3);
            this.btnAddZone.Name = "btnAddZone";
            this.btnAddZone.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlA);
            this.btnAddZone.Size = new System.Drawing.Size(76, 23);
            this.btnAddZone.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.btnAddZone.TabIndex = 3;
            this.btnAddZone.Text = "添加(A)";
            this.btnAddZone.Click += new System.EventHandler(this.btnAddZone_Click);
            // 
            // ucLabel7
            // 
            this.ucLabel7.AutoSize = true;
            this.ucLabel7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucLabel7.ForeColor = System.Drawing.Color.Black;
            this.ucLabel7.Location = new System.Drawing.Point(5, 9);
            this.ucLabel7.Name = "ucLabel7";
            this.ucLabel7.Size = new System.Drawing.Size(65, 12);
            this.ucLabel7.TabIndex = 2;
            this.ucLabel7.Text = "区域名称：";
            // 
            // txtEmpName
            // 
            // 
            // 
            // 
            this.txtEmpName.Border.Class = "TextBoxBorder";
            this.txtEmpName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtEmpName.EnterToNextControl = false;
            this.txtEmpName.Location = new System.Drawing.Point(80, 4);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(161, 21);
            this.txtEmpName.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSearch.Image = global::ZNLCRM.UI.Properties.Resources.search;
            this.btnSearch.Location = new System.Drawing.Point(251, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlF);
            this.btnSearch.Size = new System.Drawing.Size(77, 23);
            this.btnSearch.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "搜索(F)";
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
            this.ucExpandableSplitter1.Size = new System.Drawing.Size(3, 450);
            this.ucExpandableSplitter1.Style = DevComponents.DotNetBar.eSplitterStyle.Office2007;
            this.ucExpandableSplitter1.TabIndex = 2;
            this.ucExpandableSplitter1.TabStop = false;
            // 
            // ucPanel2
            // 
            this.ucPanel2.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel2.Controls.Add(this.adtZone);
            this.ucPanel2.Controls.Add(this.ucPanel5);
            this.ucPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.ucPanel2.Location = new System.Drawing.Point(0, 0);
            this.ucPanel2.Name = "ucPanel2";
            this.ucPanel2.Size = new System.Drawing.Size(273, 450);
            this.ucPanel2.TabIndex = 0;
            // 
            // adtZone
            // 
            this.adtZone.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline;
            this.adtZone.AllowDrop = true;
            this.adtZone.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.adtZone.BackgroundStyle.Class = "TreeBorderKey";
            this.adtZone.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.adtZone.ContextMenuStrip = this.cmsOper;
            this.adtZone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adtZone.GridLinesColor = System.Drawing.Color.Transparent;
            this.adtZone.GridRowLines = true;
            this.adtZone.Location = new System.Drawing.Point(0, 31);
            this.adtZone.Margin = new System.Windows.Forms.Padding(0);
            this.adtZone.Name = "adtZone";
            this.adtZone.NodesConnector = this.nodeConnector1;
            this.adtZone.NodeStyle = this.elementStyle1;
            this.adtZone.PathSeparator = ";";
            this.adtZone.Size = new System.Drawing.Size(273, 419);
            this.adtZone.Styles.Add(this.elementStyle1);
            this.adtZone.TabIndex = 0;
            this.adtZone.NodeClick += new DevComponents.AdvTree.TreeNodeMouseEventHandler(this.adtZone_NodeClick);
            this.adtZone.SelectedIndexChanged += new System.EventHandler(this.adtZone_SelectedIndexChanged);
            // 
            // cmsOper
            // 
            this.cmsOper.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiArea,
            this.tsmiCountry,
            this.tsmiProvince,
            this.tsmiCity});
            this.cmsOper.Name = "cmsOper";
            this.cmsOper.Size = new System.Drawing.Size(125, 92);
            // 
            // tsmiArea
            // 
            this.tsmiArea.Name = "tsmiArea";
            this.tsmiArea.Size = new System.Drawing.Size(124, 22);
            this.tsmiArea.Text = "添加地区";
            // 
            // tsmiCountry
            // 
            this.tsmiCountry.Name = "tsmiCountry";
            this.tsmiCountry.Size = new System.Drawing.Size(124, 22);
            this.tsmiCountry.Text = "添加国家";
            // 
            // tsmiProvince
            // 
            this.tsmiProvince.Name = "tsmiProvince";
            this.tsmiProvince.Size = new System.Drawing.Size(124, 22);
            this.tsmiProvince.Text = "添加省份";
            // 
            // tsmiCity
            // 
            this.tsmiCity.Name = "tsmiCity";
            this.tsmiCity.Size = new System.Drawing.Size(124, 22);
            this.tsmiCity.Text = "添加城市";
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
            // ucPanel5
            // 
            this.ucPanel5.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel5.Controls.Add(this.ucLabel1);
            this.ucPanel5.Controls.Add(this.txtSZone);
            this.ucPanel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucPanel5.Location = new System.Drawing.Point(0, 0);
            this.ucPanel5.Name = "ucPanel5";
            this.ucPanel5.Size = new System.Drawing.Size(273, 31);
            this.ucPanel5.TabIndex = 1;
            // 
            // ucLabel1
            // 
            this.ucLabel1.AutoSize = true;
            this.ucLabel1.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabel1.ForeColor = System.Drawing.Color.Gray;
            this.ucLabel1.Location = new System.Drawing.Point(24, 9);
            this.ucLabel1.Name = "ucLabel1";
            this.ucLabel1.Size = new System.Drawing.Size(65, 12);
            this.ucLabel1.TabIndex = 3;
            this.ucLabel1.Text = "搜索内容：";
            // 
            // txtSZone
            // 
            // 
            // 
            // 
            this.txtSZone.Border.Class = "TextBoxBorder";
            this.txtSZone.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSZone.ButtonCustom.Image = global::ZNLCRM.UI.Properties.Resources.search;
            this.txtSZone.ButtonCustom.Visible = true;
            this.txtSZone.EnterToNextControl = false;
            this.txtSZone.Location = new System.Drawing.Point(92, 4);
            this.txtSZone.Name = "txtSZone";
            this.txtSZone.Size = new System.Drawing.Size(148, 22);
            this.txtSZone.TabIndex = 2;
            this.txtSZone.ButtonCustomClick += new System.EventHandler(this.txtSZone_ButtonCustomClick);
            // 
            // colZID
            // 
            this.colZID.DataPropertyName = "ZID";
            this.colZID.HeaderText = "区域ID";
            this.colZID.Name = "colZID";
            this.colZID.Visible = false;
            // 
            // colPZID
            // 
            this.colPZID.DataPropertyName = "PZID";
            this.colPZID.HeaderText = "父级区域ID";
            this.colPZID.Name = "colPZID";
            this.colPZID.Visible = false;
            // 
            // colZCode
            // 
            this.colZCode.DataPropertyName = "ZCode";
            this.colZCode.HeaderText = "区域编码";
            this.colZCode.Name = "colZCode";
            // 
            // colName_CN
            // 
            this.colName_CN.DataPropertyName = "Name_CN";
            this.colName_CN.HeaderText = "区域名称";
            this.colName_CN.Name = "colName_CN";
            // 
            // colName_EN
            // 
            this.colName_EN.DataPropertyName = "Name_EN";
            this.colName_EN.HeaderText = "英文名称";
            this.colName_EN.Name = "colName_EN";
            // 
            // colZType
            // 
            this.colZType.HeaderText = "区域类型";
            this.colZType.Name = "colZType";
            this.colZType.Visible = false;
            // 
            // frmZoneManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 450);
            this.Controls.Add(this.ucPanel1);
            this.Name = "frmZoneManage";
            this.Text = "区域管理";
            this.Load += new System.EventHandler(this.frmZoneManage_Load);
            this.ucPanel1.ResumeLayout(false);
            this.ucPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZone)).EndInit();
            this.ucPanel4.ResumeLayout(false);
            this.ucPanel4.PerformLayout();
            this.ucPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.adtZone)).EndInit();
            this.cmsOper.ResumeLayout(false);
            this.ucPanel5.ResumeLayout(false);
            this.ucPanel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.UcPanel ucPanel1;
        private Controls.UcPanel ucPanel3;
        private Controls.UcDataGridView dgvZone;
        private Controls.UcPanel ucPanel4;
        private Controls.UcButton btnAddZone;
        private Controls.UcLabel ucLabel7;
        private Controls.UcTextBox txtEmpName;
        private Controls.UcButton btnSearch;
        private Controls.UcExpandableSplitter ucExpandableSplitter1;
        private Controls.UcPanel ucPanel2;
        private Controls.UcAdTree adtZone;
        private DevComponents.AdvTree.NodeConnector nodeConnector1;
        private DevComponents.DotNetBar.ElementStyle elementStyle1;
        private Controls.UcPanel ucPanel5;
        private Controls.UcTextBox txtSZone;
        private Controls.UcLabel ucLabel1;
        private System.Windows.Forms.ContextMenuStrip cmsOper;
        private System.Windows.Forms.ToolStripMenuItem tsmiArea;
        private System.Windows.Forms.ToolStripMenuItem tsmiCountry;
        private System.Windows.Forms.ToolStripMenuItem tsmiProvince;
        private System.Windows.Forms.ToolStripMenuItem tsmiCity;
        private Controls.UcButton ucButton1;
        private Controls.UcButton btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn colZID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPZID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colZCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName_CN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName_EN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colZType;
    }
}