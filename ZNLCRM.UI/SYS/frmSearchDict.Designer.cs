namespace ZNLCRM.UI.SYS
{
    partial class frmSearchDict
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSearchDict));
            this.ucTabControl1 = new ZNLCRM.Controls.UcTabControl(this.components);
            this.tabControlPanel1 = new DevComponents.DotNetBar.TabControlPanel();
            this.ucPanel2 = new ZNLCRM.Controls.UcPanel(this.components);
            this.ucPanel1 = new ZNLCRM.Controls.UcPanel(this.components);
            this.dgvDict = new ZNLCRM.Controls.UcDataGridView(this.components);
            this.colDictItemLineID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemValue2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpSearch = new ZNLCRM.Controls.UcPanel(this.components);
            this.btnSearch = new ZNLCRM.Controls.UcButton(this.components);
            this.UcLabel1 = new ZNLCRM.Controls.UcLabel(this.components);
            this.txtDictValue = new ZNLCRM.Controls.UcTextBox(this.components);
            this.chkAll = new ZNLCRM.Controls.UcCheckBox(this.components);
            this.ucPanel3 = new ZNLCRM.Controls.UcPanel(this.components);
            this.pgDict = new ZNLCRM.Controls.UcPager();
            this.tabSlcModule = new DevComponents.DotNetBar.TabItem(this.components);
            this.panBottom = new ZNLCRM.Controls.UcPanel(this.components);
            this.btnCancel = new ZNLCRM.Controls.UcButton(this.components);
            this.btnOK = new ZNLCRM.Controls.UcButton(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ucTabControl1)).BeginInit();
            this.ucTabControl1.SuspendLayout();
            this.tabControlPanel1.SuspendLayout();
            this.ucPanel2.SuspendLayout();
            this.ucPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDict)).BeginInit();
            this.grpSearch.SuspendLayout();
            this.ucPanel3.SuspendLayout();
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
            this.ucTabControl1.Size = new System.Drawing.Size(797, 329);
            this.ucTabControl1.Style = DevComponents.DotNetBar.eTabStripStyle.VS2005;
            this.ucTabControl1.TabIndex = 10;
            this.ucTabControl1.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            this.ucTabControl1.Tabs.Add(this.tabSlcModule);
            this.ucTabControl1.Text = "ucTabControl1";
            // 
            // tabControlPanel1
            // 
            this.tabControlPanel1.Controls.Add(this.ucPanel2);
            this.tabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel1.Location = new System.Drawing.Point(0, 25);
            this.tabControlPanel1.Name = "tabControlPanel1";
            this.tabControlPanel1.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel1.Size = new System.Drawing.Size(797, 304);
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
            this.ucPanel2.Controls.Add(this.ucPanel1);
            this.ucPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPanel2.Location = new System.Drawing.Point(1, 1);
            this.ucPanel2.Name = "ucPanel2";
            this.ucPanel2.Padding = new System.Windows.Forms.Padding(5);
            this.ucPanel2.Size = new System.Drawing.Size(795, 302);
            this.ucPanel2.TabIndex = 5;
            // 
            // ucPanel1
            // 
            this.ucPanel1.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel1.Controls.Add(this.dgvDict);
            this.ucPanel1.Controls.Add(this.grpSearch);
            this.ucPanel1.Controls.Add(this.ucPanel3);
            this.ucPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPanel1.Location = new System.Drawing.Point(5, 5);
            this.ucPanel1.Name = "ucPanel1";
            this.ucPanel1.Size = new System.Drawing.Size(785, 292);
            this.ucPanel1.TabIndex = 2;
            // 
            // dgvDict
            // 
            this.dgvDict.AllowUserToAddRows = false;
            this.dgvDict.AllowUserToDeleteRows = false;
            this.dgvDict.AllowUserToOrderColumns = true;
            this.dgvDict.BackgroundColor = System.Drawing.Color.White;
            this.dgvDict.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDict.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDictItemLineID,
            this.colItemValue,
            this.colItemValue2});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDict.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDict.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDict.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvDict.HighlightSelectedColumnHeaders = false;
            this.dgvDict.Location = new System.Drawing.Point(0, 30);
            this.dgvDict.Name = "dgvDict";
            this.dgvDict.PaintEnhancedSelection = false;
            this.dgvDict.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDict.RowTemplate.Height = 23;
            this.dgvDict.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDict.SelectAllSignVisible = false;
            this.dgvDict.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvDict.Size = new System.Drawing.Size(785, 229);
            this.dgvDict.TabIndex = 0;
            // 
            // colDictItemLineID
            // 
            this.colDictItemLineID.DataPropertyName = "DictItemLineID";
            this.colDictItemLineID.HeaderText = "数据字典子项ID";
            this.colDictItemLineID.Name = "colDictItemLineID";
            this.colDictItemLineID.ReadOnly = true;
            this.colDictItemLineID.Visible = false;
            // 
            // colItemValue
            // 
            this.colItemValue.DataPropertyName = "ItemValue";
            this.colItemValue.HeaderText = "子项名称";
            this.colItemValue.Name = "colItemValue";
            this.colItemValue.ReadOnly = true;
            // 
            // colItemValue2
            // 
            this.colItemValue2.DataPropertyName = "ItemValue2";
            this.colItemValue2.HeaderText = "子项项值";
            this.colItemValue2.Name = "colItemValue2";
            this.colItemValue2.ReadOnly = true;
            // 
            // grpSearch
            // 
            this.grpSearch.BackColor = System.Drawing.Color.Transparent;
            this.grpSearch.Controls.Add(this.btnSearch);
            this.grpSearch.Controls.Add(this.UcLabel1);
            this.grpSearch.Controls.Add(this.txtDictValue);
            this.grpSearch.Controls.Add(this.chkAll);
            this.grpSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpSearch.Location = new System.Drawing.Point(0, 0);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(785, 30);
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
            // UcLabel1
            // 
            this.UcLabel1.AutoSize = true;
            this.UcLabel1.Font = new System.Drawing.Font("宋体", 9F);
            this.UcLabel1.ForeColor = System.Drawing.Color.Gray;
            this.UcLabel1.Location = new System.Drawing.Point(6, 7);
            this.UcLabel1.Name = "UcLabel1";
            this.UcLabel1.Size = new System.Drawing.Size(65, 12);
            this.UcLabel1.TabIndex = 2;
            this.UcLabel1.Text = "子项名称：";
            // 
            // txtDictValue
            // 
            // 
            // 
            // 
            this.txtDictValue.Border.Class = "TextBoxBorder";
            this.txtDictValue.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDictValue.EnterToNextControl = false;
            this.txtDictValue.Location = new System.Drawing.Point(77, 3);
            this.txtDictValue.Name = "txtDictValue";
            this.txtDictValue.Size = new System.Drawing.Size(208, 21);
            this.txtDictValue.TabIndex = 3;
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
            // ucPanel3
            // 
            this.ucPanel3.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel3.Controls.Add(this.pgDict);
            this.ucPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucPanel3.Location = new System.Drawing.Point(0, 259);
            this.ucPanel3.Name = "ucPanel3";
            this.ucPanel3.Size = new System.Drawing.Size(785, 33);
            this.ucPanel3.TabIndex = 4;
            // 
            // pgDict
            // 
            this.pgDict.BackColor = System.Drawing.Color.Transparent;
            this.pgDict.Location = new System.Drawing.Point(3, 8);
            this.pgDict.Name = "pgDict";
            this.pgDict.RecordCount = 0;
            this.pgDict.Size = new System.Drawing.Size(212, 16);
            this.pgDict.TabIndex = 2;
            // 
            // tabSlcModule
            // 
            this.tabSlcModule.AttachedControl = this.tabControlPanel1;
            this.tabSlcModule.Image = ((System.Drawing.Image)(resources.GetObject("tabSlcModule.Image")));
            this.tabSlcModule.Name = "tabSlcModule";
            this.tabSlcModule.Text = "字典子项选择";
            // 
            // panBottom
            // 
            this.panBottom.BackColor = System.Drawing.Color.Transparent;
            this.panBottom.Controls.Add(this.btnCancel);
            this.panBottom.Controls.Add(this.btnOK);
            this.panBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panBottom.Location = new System.Drawing.Point(0, 329);
            this.panBottom.Name = "panBottom";
            this.panBottom.Size = new System.Drawing.Size(797, 47);
            this.panBottom.TabIndex = 11;
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(425, 6);
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
            this.btnOK.Location = new System.Drawing.Point(315, 6);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(86, 30);
            this.btnOK.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "确定(&S)";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // frmSearchDict
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 376);
            this.Controls.Add(this.ucTabControl1);
            this.Controls.Add(this.panBottom);
            this.Name = "frmSearchDict";
            this.Text = "选择";
            this.Load += new System.EventHandler(this.frmSearchDict_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ucTabControl1)).EndInit();
            this.ucTabControl1.ResumeLayout(false);
            this.tabControlPanel1.ResumeLayout(false);
            this.ucPanel2.ResumeLayout(false);
            this.ucPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDict)).EndInit();
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            this.ucPanel3.ResumeLayout(false);
            this.panBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.UcTabControl ucTabControl1;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel1;
        private Controls.UcPanel ucPanel2;
        private Controls.UcDataGridView dgvDict;
        private Controls.UcPager pgDict;
        private Controls.UcPanel grpSearch;
        private Controls.UcButton btnSearch;
        private Controls.UcLabel UcLabel1;
        private Controls.UcTextBox txtDictValue;
        private Controls.UcCheckBox chkAll;
        private DevComponents.DotNetBar.TabItem tabSlcModule;
        private Controls.UcPanel ucPanel1;
        private Controls.UcPanel ucPanel3;
        private Controls.UcPanel panBottom;
        private Controls.UcButton btnCancel;
        private Controls.UcButton btnOK;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDictItemLineID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemValue2;
    }
}