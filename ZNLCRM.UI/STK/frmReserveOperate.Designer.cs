namespace ZNLCRM.UI.STK
{
    partial class frmReserveOperate
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ucPanel1 = new ZNLCRM.Controls.UcPanel(this.components);
            this.txtSourceBillLineCode = new ZNLCRM.Controls.UcLabelX(this.components);
            this.ucLabelX17 = new ZNLCRM.Controls.UcLabelX(this.components);
            this.txtQty = new ZNLCRM.Controls.UcLabelX(this.components);
            this.txtSourceBillNo = new ZNLCRM.Controls.UcLabelX(this.components);
            this.ucLabelX12 = new ZNLCRM.Controls.UcLabelX(this.components);
            this.ucLabelX11 = new ZNLCRM.Controls.UcLabelX(this.components);
            this.ucLabelX5 = new ZNLCRM.Controls.UcLabelX(this.components);
            this.txtPackage = new ZNLCRM.Controls.UcLabelX(this.components);
            this.txtBatch = new ZNLCRM.Controls.UcLabelX(this.components);
            this.txtBrand = new ZNLCRM.Controls.UcLabelX(this.components);
            this.txtModel = new ZNLCRM.Controls.UcLabelX(this.components);
            this.ucLabelX9 = new ZNLCRM.Controls.UcLabelX(this.components);
            this.ucLabelX8 = new ZNLCRM.Controls.UcLabelX(this.components);
            this.ucLabelX7 = new ZNLCRM.Controls.UcLabelX(this.components);
            this.ucLabelX6 = new ZNLCRM.Controls.UcLabelX(this.components);
            this.UcLabelX1 = new ZNLCRM.Controls.UcLabelX(this.components);
            this.ucPanel2 = new ZNLCRM.Controls.UcPanel(this.components);
            this.ucPanel5 = new ZNLCRM.Controls.UcPanel(this.components);
            this.txtReserveQty = new ZNLCRM.Controls.UcLabelX(this.components);
            this.ucLabelX2 = new ZNLCRM.Controls.UcLabelX(this.components);
            this.btnOK = new ZNLCRM.Controls.UcButton(this.components);
            this.ucPanel3 = new ZNLCRM.Controls.UcPanel(this.components);
            this.ucPanel4 = new ZNLCRM.Controls.UcPanel(this.components);
            this.btnSearch = new ZNLCRM.Controls.UcButton(this.components);
            this.cboWarehouse = new ZNLCRM.Controls.UcComboBox(this.components);
            this.ucLabelX16 = new ZNLCRM.Controls.UcLabelX(this.components);
            this.ucLabelX13 = new ZNLCRM.Controls.UcLabelX(this.components);
            this.txtSModel = new ZNLCRM.Controls.UcTextBox(this.components);
            this.ucPanel6 = new ZNLCRM.Controls.UcPanel(this.components);
            this.pgStock = new ZNLCRM.Controls.UcPager();
            this.ucLabelX3 = new ZNLCRM.Controls.UcLabelX(this.components);
            this.dgvReserve = new ZNLCRM.Controls.UcDataGridView(this.components);
            this.ucPanel7 = new ZNLCRM.Controls.UcPanel(this.components);
            this.ucExpandableSplitter1 = new ZNLCRM.Controls.UcExpandableSplitter(this.components);
            this.ucLabelX4 = new ZNLCRM.Controls.UcLabelX(this.components);
            this.dgvStock = new ZNLCRM.Controls.UcDataGridView(this.components);
            this.colRemoveReserve = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colSRGuid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSourceBillGuid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSourceBillLineGuid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSourceBillNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSourceBillType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStkInLineGuid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReserveQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUsedQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReserveType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInvType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInBatchNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWarehouse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBrand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBatch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPackage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMPQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMarkCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreatedEmpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreatedTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUpdatedEmpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUpdatedTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAddReserve = new System.Windows.Forms.DataGridViewLinkColumn();
            this.col_Stock_ItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Stock_StkInGuid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Stock_StkInBillNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Stock_StkInLineGuid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Stock_Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Stock_InvType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Stock_InBatchNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInvQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Stock_BookedQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Stock_UsableQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Stock_Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Stock_Warehouse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Stock_Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Stock_Brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Stock_Batch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Stock_Package = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Stock_Quality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Stock_MPQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Stock_MarkCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Stock_CreatedEmpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Stock_CreatedTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Stock_UpdatedEmpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Stock_UpdatedTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ucPanel1.SuspendLayout();
            this.ucPanel2.SuspendLayout();
            this.ucPanel5.SuspendLayout();
            this.ucPanel3.SuspendLayout();
            this.ucPanel4.SuspendLayout();
            this.ucPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReserve)).BeginInit();
            this.ucPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            this.SuspendLayout();
            // 
            // ucPanel1
            // 
            this.ucPanel1.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel1.Controls.Add(this.txtSourceBillLineCode);
            this.ucPanel1.Controls.Add(this.ucLabelX17);
            this.ucPanel1.Controls.Add(this.txtQty);
            this.ucPanel1.Controls.Add(this.txtSourceBillNo);
            this.ucPanel1.Controls.Add(this.ucLabelX12);
            this.ucPanel1.Controls.Add(this.ucLabelX11);
            this.ucPanel1.Controls.Add(this.ucLabelX5);
            this.ucPanel1.Controls.Add(this.txtPackage);
            this.ucPanel1.Controls.Add(this.txtBatch);
            this.ucPanel1.Controls.Add(this.txtBrand);
            this.ucPanel1.Controls.Add(this.txtModel);
            this.ucPanel1.Controls.Add(this.ucLabelX9);
            this.ucPanel1.Controls.Add(this.ucLabelX8);
            this.ucPanel1.Controls.Add(this.ucLabelX7);
            this.ucPanel1.Controls.Add(this.ucLabelX6);
            this.ucPanel1.Controls.Add(this.UcLabelX1);
            this.ucPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucPanel1.Location = new System.Drawing.Point(0, 0);
            this.ucPanel1.Name = "ucPanel1";
            this.ucPanel1.Size = new System.Drawing.Size(1126, 60);
            this.ucPanel1.TabIndex = 0;
            // 
            // txtSourceBillLineCode
            // 
            // 
            // 
            // 
            this.txtSourceBillLineCode.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSourceBillLineCode.Font = new System.Drawing.Font("宋体", 9F);
            this.txtSourceBillLineCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(73)))), ((int)(((byte)(125)))));
            this.txtSourceBillLineCode.Location = new System.Drawing.Point(546, 30);
            this.txtSourceBillLineCode.Name = "txtSourceBillLineCode";
            this.txtSourceBillLineCode.Size = new System.Drawing.Size(150, 23);
            this.txtSourceBillLineCode.TabIndex = 28;
            // 
            // ucLabelX17
            // 
            // 
            // 
            // 
            this.ucLabelX17.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ucLabelX17.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabelX17.ForeColor = System.Drawing.Color.Gray;
            this.ucLabelX17.Location = new System.Drawing.Point(284, 30);
            this.ucLabelX17.Name = "ucLabelX17";
            this.ucLabelX17.Size = new System.Drawing.Size(66, 23);
            this.ucLabelX17.TabIndex = 27;
            this.ucLabelX17.Text = "<b>单据编号：</b>";
            // 
            // txtQty
            // 
            // 
            // 
            // 
            this.txtQty.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtQty.Font = new System.Drawing.Font("宋体", 9F);
            this.txtQty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(73)))), ((int)(((byte)(125)))));
            this.txtQty.Location = new System.Drawing.Point(188, 30);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(80, 23);
            this.txtQty.TabIndex = 26;
            // 
            // txtSourceBillNo
            // 
            // 
            // 
            // 
            this.txtSourceBillNo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSourceBillNo.Font = new System.Drawing.Font("宋体", 9F);
            this.txtSourceBillNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(73)))), ((int)(((byte)(125)))));
            this.txtSourceBillNo.Location = new System.Drawing.Point(364, 27);
            this.txtSourceBillNo.Name = "txtSourceBillNo";
            this.txtSourceBillNo.Size = new System.Drawing.Size(100, 23);
            this.txtSourceBillNo.TabIndex = 25;
            // 
            // ucLabelX12
            // 
            // 
            // 
            // 
            this.ucLabelX12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ucLabelX12.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabelX12.ForeColor = System.Drawing.Color.Gray;
            this.ucLabelX12.Location = new System.Drawing.Point(481, 30);
            this.ucLabelX12.Name = "ucLabelX12";
            this.ucLabelX12.Size = new System.Drawing.Size(66, 23);
            this.ucLabelX12.TabIndex = 23;
            this.ucLabelX12.Text = "<b>明细料号：</b>";
            // 
            // ucLabelX11
            // 
            // 
            // 
            // 
            this.ucLabelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ucLabelX11.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabelX11.ForeColor = System.Drawing.Color.Gray;
            this.ucLabelX11.Location = new System.Drawing.Point(752, 5);
            this.ucLabelX11.Name = "ucLabelX11";
            this.ucLabelX11.Size = new System.Drawing.Size(80, 23);
            this.ucLabelX11.TabIndex = 22;
            // 
            // ucLabelX5
            // 
            // 
            // 
            // 
            this.ucLabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ucLabelX5.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabelX5.ForeColor = System.Drawing.Color.Gray;
            this.ucLabelX5.Location = new System.Drawing.Point(103, 30);
            this.ucLabelX5.Name = "ucLabelX5";
            this.ucLabelX5.Size = new System.Drawing.Size(79, 23);
            this.ucLabelX5.TabIndex = 21;
            this.ucLabelX5.Text = "<b>需备货数量：</b>";
            // 
            // txtPackage
            // 
            // 
            // 
            // 
            this.txtPackage.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPackage.Font = new System.Drawing.Font("宋体", 9F);
            this.txtPackage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(73)))), ((int)(((byte)(125)))));
            this.txtPackage.Location = new System.Drawing.Point(616, 5);
            this.txtPackage.Name = "txtPackage";
            this.txtPackage.Size = new System.Drawing.Size(80, 23);
            this.txtPackage.TabIndex = 20;
            // 
            // txtBatch
            // 
            // 
            // 
            // 
            this.txtBatch.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtBatch.Font = new System.Drawing.Font("宋体", 9F);
            this.txtBatch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(73)))), ((int)(((byte)(125)))));
            this.txtBatch.Location = new System.Drawing.Point(481, 5);
            this.txtBatch.Name = "txtBatch";
            this.txtBatch.Size = new System.Drawing.Size(80, 23);
            this.txtBatch.TabIndex = 19;
            // 
            // txtBrand
            // 
            // 
            // 
            // 
            this.txtBrand.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtBrand.Font = new System.Drawing.Font("宋体", 9F);
            this.txtBrand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(73)))), ((int)(((byte)(125)))));
            this.txtBrand.Location = new System.Drawing.Point(357, 5);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(80, 23);
            this.txtBrand.TabIndex = 18;
            // 
            // txtModel
            // 
            // 
            // 
            // 
            this.txtModel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtModel.Font = new System.Drawing.Font("宋体", 9F);
            this.txtModel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(73)))), ((int)(((byte)(125)))));
            this.txtModel.Location = new System.Drawing.Point(152, 5);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(150, 23);
            this.txtModel.TabIndex = 17;
            // 
            // ucLabelX9
            // 
            // 
            // 
            // 
            this.ucLabelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ucLabelX9.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabelX9.ForeColor = System.Drawing.Color.Gray;
            this.ucLabelX9.Location = new System.Drawing.Point(567, 5);
            this.ucLabelX9.Name = "ucLabelX9";
            this.ucLabelX9.Size = new System.Drawing.Size(43, 23);
            this.ucLabelX9.TabIndex = 14;
            this.ucLabelX9.Text = "<b>封装：</b>";
            // 
            // ucLabelX8
            // 
            // 
            // 
            // 
            this.ucLabelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ucLabelX8.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabelX8.ForeColor = System.Drawing.Color.Gray;
            this.ucLabelX8.Location = new System.Drawing.Point(443, 5);
            this.ucLabelX8.Name = "ucLabelX8";
            this.ucLabelX8.Size = new System.Drawing.Size(43, 23);
            this.ucLabelX8.TabIndex = 12;
            this.ucLabelX8.Text = "<b>批号：</b>";
            // 
            // ucLabelX7
            // 
            // 
            // 
            // 
            this.ucLabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ucLabelX7.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabelX7.ForeColor = System.Drawing.Color.Gray;
            this.ucLabelX7.Location = new System.Drawing.Point(308, 5);
            this.ucLabelX7.Name = "ucLabelX7";
            this.ucLabelX7.Size = new System.Drawing.Size(43, 23);
            this.ucLabelX7.TabIndex = 10;
            this.ucLabelX7.Text = "<b>品牌：</b>";
            // 
            // ucLabelX6
            // 
            // 
            // 
            // 
            this.ucLabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ucLabelX6.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabelX6.ForeColor = System.Drawing.Color.Gray;
            this.ucLabelX6.Location = new System.Drawing.Point(103, 5);
            this.ucLabelX6.Name = "ucLabelX6";
            this.ucLabelX6.Size = new System.Drawing.Size(43, 23);
            this.ucLabelX6.TabIndex = 8;
            this.ucLabelX6.Text = "<b>型号：</b>";
            // 
            // UcLabelX1
            // 
            // 
            // 
            // 
            this.UcLabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.UcLabelX1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.UcLabelX1.ForeColor = System.Drawing.Color.Gray;
            this.UcLabelX1.Location = new System.Drawing.Point(12, 21);
            this.UcLabelX1.Name = "UcLabelX1";
            this.UcLabelX1.Size = new System.Drawing.Size(68, 23);
            this.UcLabelX1.TabIndex = 0;
            this.UcLabelX1.Text = "<b>需备货明细</b>";
            // 
            // ucPanel2
            // 
            this.ucPanel2.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel2.Controls.Add(this.ucPanel5);
            this.ucPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucPanel2.Location = new System.Drawing.Point(0, 60);
            this.ucPanel2.Name = "ucPanel2";
            this.ucPanel2.Size = new System.Drawing.Size(1126, 238);
            this.ucPanel2.TabIndex = 1;
            // 
            // ucPanel5
            // 
            this.ucPanel5.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel5.Controls.Add(this.dgvReserve);
            this.ucPanel5.Controls.Add(this.ucPanel7);
            this.ucPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPanel5.Location = new System.Drawing.Point(0, 0);
            this.ucPanel5.Name = "ucPanel5";
            this.ucPanel5.Size = new System.Drawing.Size(1126, 238);
            this.ucPanel5.TabIndex = 1;
            // 
            // txtReserveQty
            // 
            // 
            // 
            // 
            this.txtReserveQty.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtReserveQty.Font = new System.Drawing.Font("宋体", 9F);
            this.txtReserveQty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(73)))), ((int)(((byte)(125)))));
            this.txtReserveQty.Location = new System.Drawing.Point(186, 6);
            this.txtReserveQty.Name = "txtReserveQty";
            this.txtReserveQty.Size = new System.Drawing.Size(80, 23);
            this.txtReserveQty.TabIndex = 27;
            // 
            // ucLabelX2
            // 
            // 
            // 
            // 
            this.ucLabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ucLabelX2.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabelX2.ForeColor = System.Drawing.Color.Gray;
            this.ucLabelX2.Location = new System.Drawing.Point(114, 5);
            this.ucLabelX2.Name = "ucLabelX2";
            this.ucLabelX2.Size = new System.Drawing.Size(79, 23);
            this.ucLabelX2.TabIndex = 22;
            this.ucLabelX2.Text = "<b>已备货数量</b>：";
            // 
            // btnOK
            // 
            this.btnOK.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnOK.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnOK.Location = new System.Drawing.Point(725, 5);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 23);
            this.btnOK.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "确定保存并关闭";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // ucPanel3
            // 
            this.ucPanel3.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel3.Controls.Add(this.dgvStock);
            this.ucPanel3.Controls.Add(this.ucPanel4);
            this.ucPanel3.Controls.Add(this.ucPanel6);
            this.ucPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPanel3.Location = new System.Drawing.Point(0, 298);
            this.ucPanel3.Name = "ucPanel3";
            this.ucPanel3.Size = new System.Drawing.Size(1126, 304);
            this.ucPanel3.TabIndex = 2;
            // 
            // ucPanel4
            // 
            this.ucPanel4.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel4.Controls.Add(this.ucLabelX4);
            this.ucPanel4.Controls.Add(this.btnSearch);
            this.ucPanel4.Controls.Add(this.cboWarehouse);
            this.ucPanel4.Controls.Add(this.ucLabelX16);
            this.ucPanel4.Controls.Add(this.ucLabelX13);
            this.ucPanel4.Controls.Add(this.txtSModel);
            this.ucPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucPanel4.Location = new System.Drawing.Point(0, 0);
            this.ucPanel4.Name = "ucPanel4";
            this.ucPanel4.Size = new System.Drawing.Size(1126, 30);
            this.ucPanel4.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSearch.Image = global::ZNLCRM.UI.Properties.Resources.search;
            this.btnSearch.Location = new System.Drawing.Point(701, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "搜索";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cboWarehouse
            // 
            this.cboWarehouse.DisplayMember = "Text";
            this.cboWarehouse.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboWarehouse.FormattingEnabled = true;
            this.cboWarehouse.ItemHeight = 15;
            this.cboWarehouse.Location = new System.Drawing.Point(385, 4);
            this.cboWarehouse.Name = "cboWarehouse";
            this.cboWarehouse.Size = new System.Drawing.Size(121, 21);
            this.cboWarehouse.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboWarehouse.TabIndex = 11;
            // 
            // ucLabelX16
            // 
            // 
            // 
            // 
            this.ucLabelX16.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ucLabelX16.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabelX16.ForeColor = System.Drawing.Color.Gray;
            this.ucLabelX16.Location = new System.Drawing.Point(336, 4);
            this.ucLabelX16.Name = "ucLabelX16";
            this.ucLabelX16.Size = new System.Drawing.Size(43, 23);
            this.ucLabelX16.TabIndex = 10;
            this.ucLabelX16.Text = "<b>仓库：</b>";
            // 
            // ucLabelX13
            // 
            // 
            // 
            // 
            this.ucLabelX13.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ucLabelX13.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabelX13.ForeColor = System.Drawing.Color.Gray;
            this.ucLabelX13.Location = new System.Drawing.Point(131, 4);
            this.ucLabelX13.Name = "ucLabelX13";
            this.ucLabelX13.Size = new System.Drawing.Size(43, 23);
            this.ucLabelX13.TabIndex = 9;
            this.ucLabelX13.Text = "<b>型号：</b>";
            // 
            // txtSModel
            // 
            // 
            // 
            // 
            this.txtSModel.Border.Class = "TextBoxBorder";
            this.txtSModel.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSModel.EnterToNextControl = false;
            this.txtSModel.Location = new System.Drawing.Point(180, 4);
            this.txtSModel.Name = "txtSModel";
            this.txtSModel.PreventEnterBeep = true;
            this.txtSModel.Size = new System.Drawing.Size(150, 21);
            this.txtSModel.TabIndex = 3;
            // 
            // ucPanel6
            // 
            this.ucPanel6.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel6.Controls.Add(this.pgStock);
            this.ucPanel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucPanel6.Location = new System.Drawing.Point(0, 273);
            this.ucPanel6.Name = "ucPanel6";
            this.ucPanel6.Size = new System.Drawing.Size(1126, 31);
            this.ucPanel6.TabIndex = 3;
            // 
            // pgStock
            // 
            this.pgStock.BackColor = System.Drawing.Color.Transparent;
            this.pgStock.Location = new System.Drawing.Point(7, 9);
            this.pgStock.Name = "pgStock";
            this.pgStock.RecordCount = 0;
            this.pgStock.Size = new System.Drawing.Size(202, 15);
            this.pgStock.TabIndex = 0;
            this.pgStock.PageIndexChanged += new System.EventHandler(this.pgStock_PageIndexChanged);
            // 
            // ucLabelX3
            // 
            // 
            // 
            // 
            this.ucLabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ucLabelX3.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabelX3.ForeColor = System.Drawing.Color.Gray;
            this.ucLabelX3.Location = new System.Drawing.Point(43, 5);
            this.ucLabelX3.Name = "ucLabelX3";
            this.ucLabelX3.Size = new System.Drawing.Size(73, 23);
            this.ucLabelX3.TabIndex = 28;
            this.ucLabelX3.Text = "<b><font color=\"#C0504D\">备货信息</font></b>";
            // 
            // dgvReserve
            // 
            this.dgvReserve.AllowUserToAddRows = false;
            this.dgvReserve.AllowUserToDeleteRows = false;
            this.dgvReserve.AllowUserToOrderColumns = true;
            this.dgvReserve.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReserve.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvReserve.ColumnHeadersHeight = 30;
            this.dgvReserve.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRemoveReserve,
            this.colSRGuid,
            this.colSourceBillGuid,
            this.colSourceBillLineGuid,
            this.colSourceBillNo,
            this.colSourceBillType,
            this.colStkInLineGuid,
            this.colItemCode,
            this.colReserveQty,
            this.colUsedQty,
            this.colReserveType,
            this.colModel,
            this.colInvType,
            this.colInBatchNo,
            this.colUnit,
            this.colWarehouse,
            this.colLocation,
            this.colBrand,
            this.colBatch,
            this.colPackage,
            this.colQuality,
            this.colMPQ,
            this.colMarkCode,
            this.colCreatedEmpName,
            this.colCreatedTime,
            this.colUpdatedEmpName,
            this.colUpdatedTime});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReserve.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvReserve.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReserve.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvReserve.HighlightSelectedColumnHeaders = false;
            this.dgvReserve.Location = new System.Drawing.Point(0, 31);
            this.dgvReserve.Name = "dgvReserve";
            this.dgvReserve.PaintEnhancedSelection = false;
            this.dgvReserve.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvReserve.RowTemplate.Height = 25;
            this.dgvReserve.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReserve.SelectAllSignVisible = false;
            this.dgvReserve.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvReserve.Size = new System.Drawing.Size(1126, 207);
            this.dgvReserve.TabIndex = 29;
            this.dgvReserve.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReserve_CellContentClick);
            this.dgvReserve.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReserve_CellValidated);
            this.dgvReserve.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvReserve_DataBindingComplete);
            // 
            // ucPanel7
            // 
            this.ucPanel7.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel7.Controls.Add(this.ucLabelX3);
            this.ucPanel7.Controls.Add(this.btnOK);
            this.ucPanel7.Controls.Add(this.txtReserveQty);
            this.ucPanel7.Controls.Add(this.ucLabelX2);
            this.ucPanel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucPanel7.Location = new System.Drawing.Point(0, 0);
            this.ucPanel7.Name = "ucPanel7";
            this.ucPanel7.Size = new System.Drawing.Size(1126, 31);
            this.ucPanel7.TabIndex = 30;
            // 
            // ucExpandableSplitter1
            // 
            this.ucExpandableSplitter1.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207)))));
            this.ucExpandableSplitter1.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.ucExpandableSplitter1.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.ucExpandableSplitter1.Dock = System.Windows.Forms.DockStyle.Top;
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
            this.ucExpandableSplitter1.Location = new System.Drawing.Point(0, 298);
            this.ucExpandableSplitter1.Name = "ucExpandableSplitter1";
            this.ucExpandableSplitter1.Size = new System.Drawing.Size(1126, 3);
            this.ucExpandableSplitter1.Style = DevComponents.DotNetBar.eSplitterStyle.Office2007;
            this.ucExpandableSplitter1.TabIndex = 3;
            this.ucExpandableSplitter1.TabStop = false;
            // 
            // ucLabelX4
            // 
            // 
            // 
            // 
            this.ucLabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ucLabelX4.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabelX4.ForeColor = System.Drawing.Color.Gray;
            this.ucLabelX4.Location = new System.Drawing.Point(43, 5);
            this.ucLabelX4.Name = "ucLabelX4";
            this.ucLabelX4.Size = new System.Drawing.Size(73, 23);
            this.ucLabelX4.TabIndex = 29;
            this.ucLabelX4.Text = "<b><font color=\"#758C48\">可使用库存</font></b>";
            // 
            // dgvStock
            // 
            this.dgvStock.AllowUserToAddRows = false;
            this.dgvStock.AllowUserToDeleteRows = false;
            this.dgvStock.AllowUserToOrderColumns = true;
            this.dgvStock.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvStock.ColumnHeadersHeight = 30;
            this.dgvStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colAddReserve,
            this.col_Stock_ItemCode,
            this.col_Stock_StkInGuid,
            this.col_Stock_StkInBillNo,
            this.col_Stock_StkInLineGuid,
            this.col_Stock_Model,
            this.col_Stock_InvType,
            this.col_Stock_InBatchNo,
            this.colInvQty,
            this.col_Stock_BookedQty,
            this.col_Stock_UsableQty,
            this.col_Stock_Unit,
            this.col_Stock_Warehouse,
            this.col_Stock_Location,
            this.col_Stock_Brand,
            this.col_Stock_Batch,
            this.col_Stock_Package,
            this.col_Stock_Quality,
            this.col_Stock_MPQ,
            this.col_Stock_MarkCode,
            this.col_Stock_CreatedEmpName,
            this.col_Stock_CreatedTime,
            this.col_Stock_UpdatedEmpName,
            this.col_Stock_UpdatedTime});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStock.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStock.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvStock.HighlightSelectedColumnHeaders = false;
            this.dgvStock.Location = new System.Drawing.Point(0, 30);
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.PaintEnhancedSelection = false;
            this.dgvStock.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvStock.RowTemplate.Height = 25;
            this.dgvStock.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStock.SelectAllSignVisible = false;
            this.dgvStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvStock.Size = new System.Drawing.Size(1126, 243);
            this.dgvStock.TabIndex = 4;
            this.dgvStock.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStock_CellContentClick);
            // 
            // colRemoveReserve
            // 
            this.colRemoveReserve.HeaderText = "取消备货";
            this.colRemoveReserve.Name = "colRemoveReserve";
            this.colRemoveReserve.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colRemoveReserve.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colRemoveReserve.Text = "取消备货";
            this.colRemoveReserve.Width = 80;
            // 
            // colSRGuid
            // 
            this.colSRGuid.HeaderText = "SRGuid";
            this.colSRGuid.Name = "colSRGuid";
            this.colSRGuid.Visible = false;
            // 
            // colSourceBillGuid
            // 
            this.colSourceBillGuid.DataPropertyName = "SourceBillGuid";
            this.colSourceBillGuid.HeaderText = "SourceBillGuid";
            this.colSourceBillGuid.Name = "colSourceBillGuid";
            this.colSourceBillGuid.Visible = false;
            // 
            // colSourceBillLineGuid
            // 
            this.colSourceBillLineGuid.DataPropertyName = "SourceBillLineGuid";
            this.colSourceBillLineGuid.HeaderText = "SourceBillLineGuid";
            this.colSourceBillLineGuid.Name = "colSourceBillLineGuid";
            this.colSourceBillLineGuid.Visible = false;
            // 
            // colSourceBillNo
            // 
            this.colSourceBillNo.DataPropertyName = "SourceBillNo";
            this.colSourceBillNo.HeaderText = "业务单号";
            this.colSourceBillNo.Name = "colSourceBillNo";
            this.colSourceBillNo.Width = 80;
            // 
            // colSourceBillType
            // 
            this.colSourceBillType.DataPropertyName = "SourceBillType";
            this.colSourceBillType.HeaderText = "出库类型";
            this.colSourceBillType.Name = "colSourceBillType";
            this.colSourceBillType.Width = 80;
            // 
            // colStkInLineGuid
            // 
            this.colStkInLineGuid.DataPropertyName = "StkInLineGuid";
            this.colStkInLineGuid.HeaderText = "StkInLineGuid";
            this.colStkInLineGuid.Name = "colStkInLineGuid";
            this.colStkInLineGuid.Visible = false;
            // 
            // colItemCode
            // 
            this.colItemCode.DataPropertyName = "ItemCode";
            this.colItemCode.HeaderText = "ItemCode";
            this.colItemCode.Name = "colItemCode";
            this.colItemCode.Visible = false;
            // 
            // colReserveQty
            // 
            this.colReserveQty.DataPropertyName = "ReserveQty";
            this.colReserveQty.HeaderText = "预留数量";
            this.colReserveQty.Name = "colReserveQty";
            this.colReserveQty.Width = 80;
            // 
            // colUsedQty
            // 
            this.colUsedQty.DataPropertyName = "UsedQty";
            this.colUsedQty.HeaderText = "使用数量";
            this.colUsedQty.Name = "colUsedQty";
            this.colUsedQty.Width = 80;
            // 
            // colReserveType
            // 
            this.colReserveType.DataPropertyName = "ReserveType";
            this.colReserveType.HeaderText = "预留类型";
            this.colReserveType.Name = "colReserveType";
            this.colReserveType.Width = 80;
            // 
            // colModel
            // 
            this.colModel.DataPropertyName = "Model";
            this.colModel.HeaderText = "型号";
            this.colModel.Name = "colModel";
            // 
            // colInvType
            // 
            this.colInvType.DataPropertyName = "InvType";
            this.colInvType.HeaderText = "库存类型";
            this.colInvType.Name = "colInvType";
            this.colInvType.Width = 80;
            // 
            // colInBatchNo
            // 
            this.colInBatchNo.DataPropertyName = "InBatchNo";
            this.colInBatchNo.HeaderText = "入库批次号";
            this.colInBatchNo.Name = "colInBatchNo";
            // 
            // colUnit
            // 
            this.colUnit.DataPropertyName = "Unit";
            this.colUnit.HeaderText = "单位";
            this.colUnit.Name = "colUnit";
            this.colUnit.Width = 60;
            // 
            // colWarehouse
            // 
            this.colWarehouse.DataPropertyName = "Warehouse";
            this.colWarehouse.HeaderText = "仓库";
            this.colWarehouse.Name = "colWarehouse";
            this.colWarehouse.Width = 80;
            // 
            // colLocation
            // 
            this.colLocation.DataPropertyName = "Location";
            this.colLocation.HeaderText = "位置";
            this.colLocation.Name = "colLocation";
            this.colLocation.Width = 80;
            // 
            // colBrand
            // 
            this.colBrand.DataPropertyName = "Brand";
            this.colBrand.HeaderText = "品牌";
            this.colBrand.Name = "colBrand";
            this.colBrand.Width = 80;
            // 
            // colBatch
            // 
            this.colBatch.DataPropertyName = "Batch";
            this.colBatch.HeaderText = "批号";
            this.colBatch.Name = "colBatch";
            this.colBatch.Width = 80;
            // 
            // colPackage
            // 
            this.colPackage.DataPropertyName = "Package";
            this.colPackage.HeaderText = "封装";
            this.colPackage.Name = "colPackage";
            this.colPackage.Width = 80;
            // 
            // colQuality
            // 
            this.colQuality.DataPropertyName = "Quality";
            this.colQuality.HeaderText = "品质";
            this.colQuality.Name = "colQuality";
            this.colQuality.Width = 80;
            // 
            // colMPQ
            // 
            this.colMPQ.DataPropertyName = "MPQ";
            this.colMPQ.HeaderText = "包装";
            this.colMPQ.Name = "colMPQ";
            this.colMPQ.Width = 80;
            // 
            // colMarkCode
            // 
            this.colMarkCode.DataPropertyName = "MarkCode";
            this.colMarkCode.HeaderText = "标示码";
            this.colMarkCode.Name = "colMarkCode";
            this.colMarkCode.Width = 80;
            // 
            // colCreatedEmpName
            // 
            this.colCreatedEmpName.DataPropertyName = "CreatedEmpName";
            this.colCreatedEmpName.HeaderText = "创建人员";
            this.colCreatedEmpName.Name = "colCreatedEmpName";
            // 
            // colCreatedTime
            // 
            this.colCreatedTime.DataPropertyName = "CreatedTime";
            this.colCreatedTime.HeaderText = "创建时间";
            this.colCreatedTime.Name = "colCreatedTime";
            // 
            // colUpdatedEmpName
            // 
            this.colUpdatedEmpName.DataPropertyName = "UpdatedEmpName";
            this.colUpdatedEmpName.HeaderText = "更新人员";
            this.colUpdatedEmpName.Name = "colUpdatedEmpName";
            // 
            // colUpdatedTime
            // 
            this.colUpdatedTime.DataPropertyName = "UpdatedTime";
            this.colUpdatedTime.HeaderText = "更新时间";
            this.colUpdatedTime.Name = "colUpdatedTime";
            // 
            // colAddReserve
            // 
            this.colAddReserve.HeaderText = "预留";
            this.colAddReserve.Name = "colAddReserve";
            this.colAddReserve.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colAddReserve.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colAddReserve.Text = "预留";
            this.colAddReserve.Width = 60;
            // 
            // col_Stock_ItemCode
            // 
            this.col_Stock_ItemCode.DataPropertyName = "ItemCode";
            this.col_Stock_ItemCode.HeaderText = "ItemCode";
            this.col_Stock_ItemCode.Name = "col_Stock_ItemCode";
            this.col_Stock_ItemCode.Visible = false;
            // 
            // col_Stock_StkInGuid
            // 
            this.col_Stock_StkInGuid.DataPropertyName = "StkInGuid";
            this.col_Stock_StkInGuid.HeaderText = "StkInGuid";
            this.col_Stock_StkInGuid.Name = "col_Stock_StkInGuid";
            this.col_Stock_StkInGuid.Visible = false;
            // 
            // col_Stock_StkInBillNo
            // 
            this.col_Stock_StkInBillNo.DataPropertyName = "StkInBillNo";
            this.col_Stock_StkInBillNo.HeaderText = "入库单号";
            this.col_Stock_StkInBillNo.Name = "col_Stock_StkInBillNo";
            // 
            // col_Stock_StkInLineGuid
            // 
            this.col_Stock_StkInLineGuid.DataPropertyName = "StkInLineGuid";
            this.col_Stock_StkInLineGuid.HeaderText = "StkInLineGuid";
            this.col_Stock_StkInLineGuid.Name = "col_Stock_StkInLineGuid";
            this.col_Stock_StkInLineGuid.Visible = false;
            // 
            // col_Stock_Model
            // 
            this.col_Stock_Model.DataPropertyName = "Model";
            this.col_Stock_Model.HeaderText = "型号";
            this.col_Stock_Model.Name = "col_Stock_Model";
            this.col_Stock_Model.Width = 80;
            // 
            // col_Stock_InvType
            // 
            this.col_Stock_InvType.DataPropertyName = "InvType";
            this.col_Stock_InvType.HeaderText = "库存类型";
            this.col_Stock_InvType.Name = "col_Stock_InvType";
            this.col_Stock_InvType.Width = 80;
            // 
            // col_Stock_InBatchNo
            // 
            this.col_Stock_InBatchNo.DataPropertyName = "InBatchNo";
            this.col_Stock_InBatchNo.HeaderText = "入库批次号";
            this.col_Stock_InBatchNo.Name = "col_Stock_InBatchNo";
            // 
            // colInvQty
            // 
            this.colInvQty.DataPropertyName = "InvQty";
            this.colInvQty.HeaderText = "库存量";
            this.colInvQty.Name = "colInvQty";
            this.colInvQty.Width = 80;
            // 
            // col_Stock_BookedQty
            // 
            this.col_Stock_BookedQty.DataPropertyName = "BookedQty";
            this.col_Stock_BookedQty.HeaderText = "预留量";
            this.col_Stock_BookedQty.Name = "col_Stock_BookedQty";
            this.col_Stock_BookedQty.Width = 80;
            // 
            // col_Stock_UsableQty
            // 
            this.col_Stock_UsableQty.DataPropertyName = "UsableQty";
            this.col_Stock_UsableQty.HeaderText = "可用量";
            this.col_Stock_UsableQty.Name = "col_Stock_UsableQty";
            this.col_Stock_UsableQty.Width = 80;
            // 
            // col_Stock_Unit
            // 
            this.col_Stock_Unit.DataPropertyName = "Unit";
            this.col_Stock_Unit.HeaderText = "单位";
            this.col_Stock_Unit.Name = "col_Stock_Unit";
            this.col_Stock_Unit.Width = 60;
            // 
            // col_Stock_Warehouse
            // 
            this.col_Stock_Warehouse.DataPropertyName = "Warehouse";
            this.col_Stock_Warehouse.HeaderText = "仓库";
            this.col_Stock_Warehouse.Name = "col_Stock_Warehouse";
            this.col_Stock_Warehouse.Width = 80;
            // 
            // col_Stock_Location
            // 
            this.col_Stock_Location.DataPropertyName = "Location";
            this.col_Stock_Location.HeaderText = "位置";
            this.col_Stock_Location.Name = "col_Stock_Location";
            this.col_Stock_Location.Width = 80;
            // 
            // col_Stock_Brand
            // 
            this.col_Stock_Brand.DataPropertyName = "Brand";
            this.col_Stock_Brand.HeaderText = "品牌";
            this.col_Stock_Brand.Name = "col_Stock_Brand";
            this.col_Stock_Brand.Width = 80;
            // 
            // col_Stock_Batch
            // 
            this.col_Stock_Batch.DataPropertyName = "Batch";
            this.col_Stock_Batch.HeaderText = "批号";
            this.col_Stock_Batch.Name = "col_Stock_Batch";
            this.col_Stock_Batch.Width = 80;
            // 
            // col_Stock_Package
            // 
            this.col_Stock_Package.DataPropertyName = "Package";
            this.col_Stock_Package.HeaderText = "封装";
            this.col_Stock_Package.Name = "col_Stock_Package";
            this.col_Stock_Package.Width = 80;
            // 
            // col_Stock_Quality
            // 
            this.col_Stock_Quality.DataPropertyName = "Quality";
            this.col_Stock_Quality.HeaderText = "品质";
            this.col_Stock_Quality.Name = "col_Stock_Quality";
            this.col_Stock_Quality.Width = 80;
            // 
            // col_Stock_MPQ
            // 
            this.col_Stock_MPQ.DataPropertyName = "MPQ";
            this.col_Stock_MPQ.HeaderText = "包装";
            this.col_Stock_MPQ.Name = "col_Stock_MPQ";
            this.col_Stock_MPQ.Width = 80;
            // 
            // col_Stock_MarkCode
            // 
            this.col_Stock_MarkCode.DataPropertyName = "MarkCode";
            this.col_Stock_MarkCode.HeaderText = "标记码";
            this.col_Stock_MarkCode.Name = "col_Stock_MarkCode";
            this.col_Stock_MarkCode.Width = 80;
            // 
            // col_Stock_CreatedEmpName
            // 
            this.col_Stock_CreatedEmpName.DataPropertyName = "CreatedEmpName";
            this.col_Stock_CreatedEmpName.HeaderText = "创建人员";
            this.col_Stock_CreatedEmpName.Name = "col_Stock_CreatedEmpName";
            this.col_Stock_CreatedEmpName.Width = 80;
            // 
            // col_Stock_CreatedTime
            // 
            this.col_Stock_CreatedTime.DataPropertyName = "CreatedTime";
            this.col_Stock_CreatedTime.HeaderText = "创建时间";
            this.col_Stock_CreatedTime.Name = "col_Stock_CreatedTime";
            this.col_Stock_CreatedTime.Width = 80;
            // 
            // col_Stock_UpdatedEmpName
            // 
            this.col_Stock_UpdatedEmpName.DataPropertyName = "UpdatedEmpName";
            this.col_Stock_UpdatedEmpName.HeaderText = "修改人员";
            this.col_Stock_UpdatedEmpName.Name = "col_Stock_UpdatedEmpName";
            this.col_Stock_UpdatedEmpName.Width = 80;
            // 
            // col_Stock_UpdatedTime
            // 
            this.col_Stock_UpdatedTime.DataPropertyName = "UpdatedTime";
            this.col_Stock_UpdatedTime.HeaderText = "修改时间";
            this.col_Stock_UpdatedTime.Name = "col_Stock_UpdatedTime";
            this.col_Stock_UpdatedTime.Width = 80;
            // 
            // frmReserveOperate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 602);
            this.Controls.Add(this.ucExpandableSplitter1);
            this.Controls.Add(this.ucPanel3);
            this.Controls.Add(this.ucPanel2);
            this.Controls.Add(this.ucPanel1);
            this.Name = "frmReserveOperate";
            this.Text = "库存预留操作";
            this.Load += new System.EventHandler(this.frmReserveOperate_Load);
            this.ucPanel1.ResumeLayout(false);
            this.ucPanel2.ResumeLayout(false);
            this.ucPanel5.ResumeLayout(false);
            this.ucPanel3.ResumeLayout(false);
            this.ucPanel4.ResumeLayout(false);
            this.ucPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReserve)).EndInit();
            this.ucPanel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.UcPanel ucPanel1;
        private Controls.UcLabelX UcLabelX1;
        private Controls.UcPanel ucPanel2;
        private Controls.UcPanel ucPanel3;
        private Controls.UcLabelX txtBatch;
        private Controls.UcLabelX txtBrand;
        private Controls.UcLabelX txtModel;
        private Controls.UcLabelX ucLabelX9;
        private Controls.UcLabelX ucLabelX8;
        private Controls.UcLabelX ucLabelX7;
        private Controls.UcLabelX ucLabelX6;
        private Controls.UcLabelX ucLabelX12;
        private Controls.UcLabelX ucLabelX11;
        private Controls.UcLabelX ucLabelX5;
        private Controls.UcLabelX txtPackage;
        private Controls.UcPanel ucPanel5;
        private Controls.UcLabelX txtSourceBillLineCode;
        private Controls.UcLabelX ucLabelX17;
        private Controls.UcLabelX txtQty;
        private Controls.UcLabelX txtSourceBillNo;
        private Controls.UcButton btnOK;
        private Controls.UcPanel ucPanel4;
        private Controls.UcButton btnSearch;
        private Controls.UcComboBox cboWarehouse;
        private Controls.UcLabelX ucLabelX16;
        private Controls.UcLabelX ucLabelX13;
        private Controls.UcTextBox txtSModel;
        private Controls.UcPanel ucPanel6;
        private Controls.UcPager pgStock;
        private Controls.UcLabelX txtReserveQty;
        private Controls.UcLabelX ucLabelX2;
        private Controls.UcDataGridView dgvReserve;
        private Controls.UcLabelX ucLabelX3;
        private Controls.UcPanel ucPanel7;
        private Controls.UcDataGridView dgvStock;
        private Controls.UcLabelX ucLabelX4;
        private Controls.UcExpandableSplitter ucExpandableSplitter1;
        private System.Windows.Forms.DataGridViewLinkColumn colRemoveReserve;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSRGuid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSourceBillGuid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSourceBillLineGuid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSourceBillNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSourceBillType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStkInLineGuid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReserveQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsedQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReserveType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInBatchNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWarehouse;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBrand;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBatch;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPackage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuality;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMPQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMarkCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreatedEmpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreatedTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUpdatedEmpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUpdatedTime;
        private System.Windows.Forms.DataGridViewLinkColumn colAddReserve;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Stock_ItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Stock_StkInGuid;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Stock_StkInBillNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Stock_StkInLineGuid;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Stock_Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Stock_InvType;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Stock_InBatchNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Stock_BookedQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Stock_UsableQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Stock_Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Stock_Warehouse;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Stock_Location;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Stock_Brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Stock_Batch;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Stock_Package;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Stock_Quality;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Stock_MPQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Stock_MarkCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Stock_CreatedEmpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Stock_CreatedTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Stock_UpdatedEmpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Stock_UpdatedTime;
    }
}