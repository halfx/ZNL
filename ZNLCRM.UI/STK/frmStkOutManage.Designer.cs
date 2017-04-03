namespace ZNLCRM.UI.STK
{
    partial class frmStkOutManage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStkOutManage));
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn1 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn2 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn3 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn4 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn5 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn6 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn7 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn8 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn9 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn10 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn11 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn12 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn13 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn14 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn15 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn16 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn17 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn18 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn19 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn20 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn21 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.stiList = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel2 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.dataGridViewX1 = new ZNLCRM.Controls.UcDataGridView(this.components);
            this.colStkOutLineGuid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStkOutGuid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBillNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSourceBillLineGuid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBrand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPackage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBatch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCurrency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTaxRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWarehouse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tab1 = new DevComponents.DotNetBar.SuperTabItem();
            this.tab2 = new DevComponents.DotNetBar.SuperTabItem();
            this.ucPanel2 = new ZNLCRM.Controls.UcPanel(this.components);
            this.ucPanel4 = new ZNLCRM.Controls.UcPanel(this.components);
            this.sgcStkOut = new ZNLCRM.Controls.UcSuperGridControl(this.components);
            this.ucPanel3 = new ZNLCRM.Controls.UcPanel(this.components);
            this.cboBillType = new ZNLCRM.Controls.UcComboBox(this.components);
            this.ucLabelX2 = new ZNLCRM.Controls.UcLabelX(this.components);
            this.btnSearch = new ZNLCRM.Controls.UcButton(this.components);
            this.txtBillNo = new ZNLCRM.Controls.UcTextBox(this.components);
            this.ucLabelX1 = new ZNLCRM.Controls.UcLabelX(this.components);
            this.ucPanel5 = new ZNLCRM.Controls.UcPanel(this.components);
            this.pgStkOut = new ZNLCRM.Controls.UcPager();
            this.ucPanel1 = new ZNLCRM.Controls.UcPanel(this.components);
            this.ucToolStrip1 = new ZNLCRM.Controls.UcToolStrip(this.components);
            this.tsbAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbDel = new System.Windows.Forms.ToolStripButton();
            this.tsbPrint = new System.Windows.Forms.ToolStripButton();
            this.superTabControlPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).BeginInit();
            this.ucPanel2.SuspendLayout();
            this.ucPanel4.SuspendLayout();
            this.ucPanel3.SuspendLayout();
            this.ucPanel5.SuspendLayout();
            this.ucPanel1.SuspendLayout();
            this.ucToolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // stiList
            // 
            this.stiList.AttachedControl = this.superTabControlPanel2;
            this.stiList.GlobalItem = false;
            this.stiList.Name = "stiList";
            this.stiList.Text = "列表展示";
            // 
            // superTabControlPanel2
            // 
            this.superTabControlPanel2.Controls.Add(this.dataGridViewX1);
            this.superTabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel2.Location = new System.Drawing.Point(0, 0);
            this.superTabControlPanel2.Name = "superTabControlPanel2";
            this.superTabControlPanel2.Padding = new System.Windows.Forms.Padding(5);
            this.superTabControlPanel2.Size = new System.Drawing.Size(1025, 28);
            this.superTabControlPanel2.TabIndex = 0;
            this.superTabControlPanel2.TabItem = this.stiList;
            // 
            // dataGridViewX1
            // 
            this.dataGridViewX1.AllowUserToAddRows = false;
            this.dataGridViewX1.AllowUserToDeleteRows = false;
            this.dataGridViewX1.AllowUserToOrderColumns = true;
            this.dataGridViewX1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewX1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewX1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewX1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colStkOutLineGuid,
            this.colStkOutGuid,
            this.colBillNo,
            this.colSourceBillLineGuid,
            this.colItemCode,
            this.colModel,
            this.colBrand,
            this.colPackage,
            this.colBatch,
            this.colQty,
            this.colUnit,
            this.colUnitPrice,
            this.colCurrency,
            this.colAmount,
            this.colTaxRate,
            this.colWarehouse});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewX1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewX1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewX1.EnableHeadersVisualStyles = false;
            this.dataGridViewX1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewX1.HighlightSelectedColumnHeaders = false;
            this.dataGridViewX1.Location = new System.Drawing.Point(5, 5);
            this.dataGridViewX1.Name = "dataGridViewX1";
            this.dataGridViewX1.PaintEnhancedSelection = false;
            this.dataGridViewX1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewX1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewX1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewX1.RowTemplate.Height = 23;
            this.dataGridViewX1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewX1.SelectAllSignVisible = false;
            this.dataGridViewX1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewX1.Size = new System.Drawing.Size(1015, 18);
            this.dataGridViewX1.TabIndex = 0;
            // 
            // colStkOutLineGuid
            // 
            this.colStkOutLineGuid.DataPropertyName = "StkOutLineGuid";
            this.colStkOutLineGuid.HeaderText = "出库明细Guid";
            this.colStkOutLineGuid.Name = "colStkOutLineGuid";
            this.colStkOutLineGuid.Visible = false;
            // 
            // colStkOutGuid
            // 
            this.colStkOutGuid.DataPropertyName = "StkOutGuid";
            this.colStkOutGuid.HeaderText = "出库主单Guid";
            this.colStkOutGuid.Name = "colStkOutGuid";
            this.colStkOutGuid.Visible = false;
            // 
            // colBillNo
            // 
            this.colBillNo.DataPropertyName = "BillNo";
            this.colBillNo.HeaderText = "出库单号";
            this.colBillNo.Name = "colBillNo";
            // 
            // colSourceBillLineGuid
            // 
            this.colSourceBillLineGuid.DataPropertyName = "SourceBillLineGuid";
            this.colSourceBillLineGuid.HeaderText = "关联明细guid";
            this.colSourceBillLineGuid.Name = "colSourceBillLineGuid";
            this.colSourceBillLineGuid.Visible = false;
            // 
            // colItemCode
            // 
            this.colItemCode.DataPropertyName = "ItemCode";
            this.colItemCode.HeaderText = "库存ID";
            this.colItemCode.Name = "colItemCode";
            this.colItemCode.Visible = false;
            // 
            // colModel
            // 
            this.colModel.DataPropertyName = "Model";
            this.colModel.HeaderText = "型号";
            this.colModel.Name = "colModel";
            // 
            // colBrand
            // 
            this.colBrand.DataPropertyName = "Brand";
            this.colBrand.HeaderText = "品牌";
            this.colBrand.Name = "colBrand";
            // 
            // colPackage
            // 
            this.colPackage.DataPropertyName = "Package";
            this.colPackage.HeaderText = "封装";
            this.colPackage.Name = "colPackage";
            // 
            // colBatch
            // 
            this.colBatch.DataPropertyName = "Batch";
            this.colBatch.HeaderText = "批号";
            this.colBatch.Name = "colBatch";
            // 
            // colQty
            // 
            this.colQty.HeaderText = "数量";
            this.colQty.Name = "colQty";
            // 
            // colUnit
            // 
            this.colUnit.HeaderText = "单位";
            this.colUnit.Name = "colUnit";
            // 
            // colUnitPrice
            // 
            this.colUnitPrice.HeaderText = "单价";
            this.colUnitPrice.Name = "colUnitPrice";
            // 
            // colCurrency
            // 
            this.colCurrency.HeaderText = "币种";
            this.colCurrency.Name = "colCurrency";
            // 
            // colAmount
            // 
            this.colAmount.HeaderText = "金额";
            this.colAmount.Name = "colAmount";
            // 
            // colTaxRate
            // 
            this.colTaxRate.HeaderText = "税率";
            this.colTaxRate.Name = "colTaxRate";
            // 
            // colWarehouse
            // 
            this.colWarehouse.HeaderText = "仓库";
            this.colWarehouse.Name = "colWarehouse";
            // 
            // tab1
            // 
            this.tab1.GlobalItem = false;
            this.tab1.Image = ((System.Drawing.Image)(resources.GetObject("tab1.Image")));
            this.tab1.Name = "tab1";
            this.tab1.Text = "Customer Data";
            // 
            // tab2
            // 
            this.tab2.GlobalItem = false;
            this.tab2.Image = ((System.Drawing.Image)(resources.GetObject("tab2.Image")));
            this.tab2.Name = "tab2";
            this.tab2.TabFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab2.Text = "Order Data";
            // 
            // ucPanel2
            // 
            this.ucPanel2.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel2.Controls.Add(this.ucPanel4);
            this.ucPanel2.Controls.Add(this.ucPanel3);
            this.ucPanel2.Controls.Add(this.ucPanel5);
            this.ucPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPanel2.Location = new System.Drawing.Point(0, 41);
            this.ucPanel2.Name = "ucPanel2";
            this.ucPanel2.Size = new System.Drawing.Size(1025, 408);
            this.ucPanel2.TabIndex = 11;
            // 
            // ucPanel4
            // 
            this.ucPanel4.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel4.Controls.Add(this.sgcStkOut);
            this.ucPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPanel4.Location = new System.Drawing.Point(0, 41);
            this.ucPanel4.Name = "ucPanel4";
            this.ucPanel4.Padding = new System.Windows.Forms.Padding(5);
            this.ucPanel4.Size = new System.Drawing.Size(1025, 331);
            this.ucPanel4.TabIndex = 13;
            // 
            // sgcStkOut
            // 
            this.sgcStkOut.DefaultVisualStyles.CellStyles.Default.Alignment = DevComponents.DotNetBar.SuperGrid.Style.Alignment.MiddleCenter;
            this.sgcStkOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sgcStkOut.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.sgcStkOut.Location = new System.Drawing.Point(5, 5);
            this.sgcStkOut.Name = "sgcStkOut";
            this.sgcStkOut.PrimaryGrid.AllowRowHeaderResize = true;
            this.sgcStkOut.PrimaryGrid.AllowRowResize = true;
            this.sgcStkOut.PrimaryGrid.AutoGenerateColumns = false;
            this.sgcStkOut.PrimaryGrid.ColumnHeader.RowHeight = 30;
            gridColumn1.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridCheckBoxXEditControl);
            gridColumn1.HeaderText = "选？";
            gridColumn1.Name = "colSelect";
            gridColumn1.Width = 35;
            gridColumn2.DataPropertyName = "StkOutGuid";
            gridColumn2.HeaderText = "StkOutGuid";
            gridColumn2.Name = "colStkOutGuid";
            gridColumn2.ReadOnly = true;
            gridColumn2.Visible = false;
            gridColumn3.DataPropertyName = "BillNo";
            gridColumn3.HeaderText = "销售单号";
            gridColumn3.Name = "colBillNo";
            gridColumn3.ReadOnly = true;
            gridColumn4.DataPropertyName = "BillType";
            gridColumn4.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridComboBoxExEditControl);
            gridColumn4.HeaderText = "出库类型";
            gridColumn4.Name = "colBillType";
            gridColumn4.ReadOnly = true;
            gridColumn4.RenderType = typeof(DevComponents.DotNetBar.SuperGrid.GridComboBoxExEditControl);
            gridColumn5.DataPropertyName = "OutDate";
            gridColumn5.HeaderText = "出库日期";
            gridColumn5.Name = "colOutDate";
            gridColumn5.ReadOnly = true;
            gridColumn6.DataPropertyName = "OperOrgID";
            gridColumn6.HeaderText = "归属机构ID";
            gridColumn6.Name = "colOperOrgID";
            gridColumn6.ReadOnly = true;
            gridColumn6.Visible = false;
            gridColumn7.DataPropertyName = "OperOrgName";
            gridColumn7.HeaderText = "归属机构";
            gridColumn7.Name = "colOperOrgName";
            gridColumn7.ReadOnly = true;
            gridColumn8.DataPropertyName = "OperDeptID";
            gridColumn8.HeaderText = "归属部门ID";
            gridColumn8.Name = "colOperDeptID";
            gridColumn8.ReadOnly = true;
            gridColumn8.Visible = false;
            gridColumn9.DataPropertyName = "OperDeptName";
            gridColumn9.HeaderText = "归属部门";
            gridColumn9.Name = "colOperDeptName";
            gridColumn9.ReadOnly = true;
            gridColumn10.DataPropertyName = "OperEmpID";
            gridColumn10.HeaderText = "归属人员ID";
            gridColumn10.Name = "colOperEmpID";
            gridColumn10.ReadOnly = true;
            gridColumn10.Visible = false;
            gridColumn11.DataPropertyName = "OperEmpName";
            gridColumn11.HeaderText = "归属人员";
            gridColumn11.Name = "colOperEmpName";
            gridColumn11.ReadOnly = true;
            gridColumn12.DataPropertyName = "SourceBillGuid";
            gridColumn12.HeaderText = "SourceBillGuid";
            gridColumn12.Name = "colSourceBillGuid";
            gridColumn12.ReadOnly = true;
            gridColumn12.Visible = false;
            gridColumn13.DataPropertyName = "SourceBillNo";
            gridColumn13.HeaderText = "源单据编号";
            gridColumn13.Name = "colSourceBillNo";
            gridColumn13.ReadOnly = true;
            gridColumn14.DataPropertyName = "Currency";
            gridColumn14.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridComboBoxExEditControl);
            gridColumn14.HeaderText = "币种";
            gridColumn14.Name = "colCurrency";
            gridColumn14.ReadOnly = true;
            gridColumn14.RenderType = typeof(DevComponents.DotNetBar.SuperGrid.GridComboBoxExEditControl);
            gridColumn15.DataPropertyName = "TaxRate";
            gridColumn15.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridComboBoxExEditControl);
            gridColumn15.HeaderText = "税率";
            gridColumn15.Name = "colTaxRate";
            gridColumn15.ReadOnly = true;
            gridColumn15.RenderType = typeof(DevComponents.DotNetBar.SuperGrid.GridComboBoxExEditControl);
            gridColumn16.DataPropertyName = "ExchangeRate";
            gridColumn16.HeaderText = "汇率";
            gridColumn16.Name = "colExchangeRate";
            gridColumn16.ReadOnly = true;
            gridColumn17.DataPropertyName = "Amount";
            gridColumn17.HeaderText = "总金额";
            gridColumn17.Name = "colAmount";
            gridColumn17.ReadOnly = true;
            gridColumn18.DataPropertyName = "ReceivedAmount";
            gridColumn18.HeaderText = "应收款金额";
            gridColumn18.Name = "colReceivedAmount";
            gridColumn18.ReadOnly = true;
            gridColumn19.DataPropertyName = "Remark";
            gridColumn19.HeaderText = "备注";
            gridColumn19.Name = "colRemark";
            gridColumn19.ReadOnly = true;
            gridColumn20.DataPropertyName = "CreatedTime";
            gridColumn20.HeaderText = "创建时间";
            gridColumn20.Name = "colCreatedTime";
            gridColumn20.ReadOnly = true;
            gridColumn21.DataPropertyName = "ApproveStatus";
            gridColumn21.HeaderText = "单据状态";
            gridColumn21.Name = "colApproveStatus";
            gridColumn21.ReadOnly = true;
            this.sgcStkOut.PrimaryGrid.Columns.Add(gridColumn1);
            this.sgcStkOut.PrimaryGrid.Columns.Add(gridColumn2);
            this.sgcStkOut.PrimaryGrid.Columns.Add(gridColumn3);
            this.sgcStkOut.PrimaryGrid.Columns.Add(gridColumn4);
            this.sgcStkOut.PrimaryGrid.Columns.Add(gridColumn5);
            this.sgcStkOut.PrimaryGrid.Columns.Add(gridColumn6);
            this.sgcStkOut.PrimaryGrid.Columns.Add(gridColumn7);
            this.sgcStkOut.PrimaryGrid.Columns.Add(gridColumn8);
            this.sgcStkOut.PrimaryGrid.Columns.Add(gridColumn9);
            this.sgcStkOut.PrimaryGrid.Columns.Add(gridColumn10);
            this.sgcStkOut.PrimaryGrid.Columns.Add(gridColumn11);
            this.sgcStkOut.PrimaryGrid.Columns.Add(gridColumn12);
            this.sgcStkOut.PrimaryGrid.Columns.Add(gridColumn13);
            this.sgcStkOut.PrimaryGrid.Columns.Add(gridColumn14);
            this.sgcStkOut.PrimaryGrid.Columns.Add(gridColumn15);
            this.sgcStkOut.PrimaryGrid.Columns.Add(gridColumn16);
            this.sgcStkOut.PrimaryGrid.Columns.Add(gridColumn17);
            this.sgcStkOut.PrimaryGrid.Columns.Add(gridColumn18);
            this.sgcStkOut.PrimaryGrid.Columns.Add(gridColumn19);
            this.sgcStkOut.PrimaryGrid.Columns.Add(gridColumn20);
            this.sgcStkOut.PrimaryGrid.Columns.Add(gridColumn21);
            this.sgcStkOut.PrimaryGrid.DefaultRowHeight = 24;
            this.sgcStkOut.PrimaryGrid.ShowRowGridIndex = true;
            this.sgcStkOut.Size = new System.Drawing.Size(1015, 321);
            this.sgcStkOut.TabIndex = 12;
            this.sgcStkOut.Text = "ucSuperGridControl1";
            this.sgcStkOut.RowActivated += new System.EventHandler<DevComponents.DotNetBar.SuperGrid.GridRowActivatedEventArgs>(this.sgcStkOut_RowActivated);
            this.sgcStkOut.RowDoubleClick += new System.EventHandler<DevComponents.DotNetBar.SuperGrid.GridRowDoubleClickEventArgs>(this.sgcStkOut_RowDoubleClick);
            // 
            // ucPanel3
            // 
            this.ucPanel3.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel3.Controls.Add(this.cboBillType);
            this.ucPanel3.Controls.Add(this.ucLabelX2);
            this.ucPanel3.Controls.Add(this.btnSearch);
            this.ucPanel3.Controls.Add(this.txtBillNo);
            this.ucPanel3.Controls.Add(this.ucLabelX1);
            this.ucPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucPanel3.Location = new System.Drawing.Point(0, 0);
            this.ucPanel3.Name = "ucPanel3";
            this.ucPanel3.Size = new System.Drawing.Size(1025, 41);
            this.ucPanel3.TabIndex = 11;
            // 
            // cboBillType
            // 
            this.cboBillType.DisplayMember = "Text";
            this.cboBillType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboBillType.FormattingEnabled = true;
            this.cboBillType.ItemHeight = 15;
            this.cboBillType.Location = new System.Drawing.Point(342, 10);
            this.cboBillType.Name = "cboBillType";
            this.cboBillType.Size = new System.Drawing.Size(121, 21);
            this.cboBillType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboBillType.TabIndex = 4;
            // 
            // ucLabelX2
            // 
            // 
            // 
            // 
            this.ucLabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ucLabelX2.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabelX2.ForeColor = System.Drawing.Color.Gray;
            this.ucLabelX2.Location = new System.Drawing.Point(268, 8);
            this.ucLabelX2.Name = "ucLabelX2";
            this.ucLabelX2.Size = new System.Drawing.Size(68, 23);
            this.ucLabelX2.TabIndex = 3;
            this.ucLabelX2.Text = "出库类型：";
            // 
            // btnSearch
            // 
            this.btnSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSearch.Image = global::ZNLCRM.UI.Properties.Resources.search;
            this.btnSearch.Location = new System.Drawing.Point(492, 10);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 21);
            this.btnSearch.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "搜 索";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtBillNo
            // 
            // 
            // 
            // 
            this.txtBillNo.Border.Class = "TextBoxBorder";
            this.txtBillNo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtBillNo.EnterToNextControl = false;
            this.txtBillNo.Location = new System.Drawing.Point(86, 10);
            this.txtBillNo.Name = "txtBillNo";
            this.txtBillNo.PreventEnterBeep = true;
            this.txtBillNo.Size = new System.Drawing.Size(150, 21);
            this.txtBillNo.TabIndex = 1;
            // 
            // ucLabelX1
            // 
            // 
            // 
            // 
            this.ucLabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ucLabelX1.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabelX1.ForeColor = System.Drawing.Color.Gray;
            this.ucLabelX1.Location = new System.Drawing.Point(12, 8);
            this.ucLabelX1.Name = "ucLabelX1";
            this.ucLabelX1.Size = new System.Drawing.Size(68, 23);
            this.ucLabelX1.TabIndex = 0;
            this.ucLabelX1.Text = "出库单号：";
            // 
            // ucPanel5
            // 
            this.ucPanel5.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel5.Controls.Add(this.pgStkOut);
            this.ucPanel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucPanel5.Location = new System.Drawing.Point(0, 372);
            this.ucPanel5.Name = "ucPanel5";
            this.ucPanel5.Size = new System.Drawing.Size(1025, 36);
            this.ucPanel5.TabIndex = 9;
            // 
            // pgStkOut
            // 
            this.pgStkOut.BackColor = System.Drawing.Color.Transparent;
            this.pgStkOut.Location = new System.Drawing.Point(14, 11);
            this.pgStkOut.Name = "pgStkOut";
            this.pgStkOut.RecordCount = 0;
            this.pgStkOut.Size = new System.Drawing.Size(195, 15);
            this.pgStkOut.TabIndex = 0;
            this.pgStkOut.PageIndexChanged += new System.EventHandler(this.pgStkOut_PageIndexChanged);
            // 
            // ucPanel1
            // 
            this.ucPanel1.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel1.Controls.Add(this.ucToolStrip1);
            this.ucPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucPanel1.Location = new System.Drawing.Point(0, 0);
            this.ucPanel1.Name = "ucPanel1";
            this.ucPanel1.Size = new System.Drawing.Size(1025, 41);
            this.ucPanel1.TabIndex = 10;
            // 
            // ucToolStrip1
            // 
            this.ucToolStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ucToolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucToolStrip1.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.ucToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAdd,
            this.tsbEdit,
            this.tsbDel,
            this.tsbPrint});
            this.ucToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.ucToolStrip1.Name = "ucToolStrip1";
            this.ucToolStrip1.Padding = new System.Windows.Forms.Padding(5);
            this.ucToolStrip1.Size = new System.Drawing.Size(1025, 41);
            this.ucToolStrip1.TabIndex = 7;
            this.ucToolStrip1.Text = "ucToolStrip1";
            // 
            // tsbAdd
            // 
            this.tsbAdd.Image = global::ZNLCRM.UI.Properties.Resources.add_1;
            this.tsbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdd.Name = "tsbAdd";
            this.tsbAdd.Size = new System.Drawing.Size(55, 28);
            this.tsbAdd.Text = "新增";
            this.tsbAdd.ToolTipText = "添加新的销售单";
            this.tsbAdd.Click += new System.EventHandler(this.tsbAdd_Click);
            // 
            // tsbEdit
            // 
            this.tsbEdit.Image = global::ZNLCRM.UI.Properties.Resources.edit_1;
            this.tsbEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEdit.Name = "tsbEdit";
            this.tsbEdit.Size = new System.Drawing.Size(55, 28);
            this.tsbEdit.Text = "修改";
            this.tsbEdit.Click += new System.EventHandler(this.tsbEdit_Click);
            // 
            // tsbDel
            // 
            this.tsbDel.Image = global::ZNLCRM.UI.Properties.Resources.del_1;
            this.tsbDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDel.Name = "tsbDel";
            this.tsbDel.Size = new System.Drawing.Size(55, 28);
            this.tsbDel.Text = "删除";
            this.tsbDel.Click += new System.EventHandler(this.tsbDel_Click);
            // 
            // tsbPrint
            // 
            this.tsbPrint.Image = global::ZNLCRM.UI.Properties.Resources.print_1;
            this.tsbPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPrint.Name = "tsbPrint";
            this.tsbPrint.Size = new System.Drawing.Size(55, 28);
            this.tsbPrint.Text = "打印";
            // 
            // frmStkOutManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 449);
            this.Controls.Add(this.ucPanel2);
            this.Controls.Add(this.ucPanel1);
            this.Name = "frmStkOutManage";
            this.Text = "出库管理";
            this.Load += new System.EventHandler(this.frmStkOutManage_Load);
            this.superTabControlPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).EndInit();
            this.ucPanel2.ResumeLayout(false);
            this.ucPanel4.ResumeLayout(false);
            this.ucPanel3.ResumeLayout(false);
            this.ucPanel5.ResumeLayout(false);
            this.ucPanel1.ResumeLayout(false);
            this.ucPanel1.PerformLayout();
            this.ucToolStrip1.ResumeLayout(false);
            this.ucToolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.UcToolStrip ucToolStrip1;
        private System.Windows.Forms.ToolStripButton tsbAdd;
        private System.Windows.Forms.ToolStripButton tsbEdit;
        private System.Windows.Forms.ToolStripButton tsbDel;
        private System.Windows.Forms.ToolStripButton tsbPrint;
        private Controls.UcPanel ucPanel5;
        private Controls.UcPager pgStkOut;
        private Controls.UcPanel ucPanel1;
        private Controls.UcPanel ucPanel2;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel2;
        private ZNLCRM.Controls.UcDataGridView dataGridViewX1;
        private DevComponents.DotNetBar.SuperTabItem stiList;
        private Controls.UcPanel ucPanel3;
        private Controls.UcButton btnSearch;
        private Controls.UcTextBox txtBillNo;
        private Controls.UcLabelX ucLabelX1;
        private DevComponents.DotNetBar.SuperTabItem tab1;
        private DevComponents.DotNetBar.SuperTabItem tab2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStkOutLineGuid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStkOutGuid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBillNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSourceBillLineGuid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBrand;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPackage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBatch;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCurrency;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTaxRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWarehouse;
        private Controls.UcPanel ucPanel4;
        private Controls.UcSuperGridControl sgcStkOut;
        private Controls.UcComboBox cboBillType;
        private Controls.UcLabelX ucLabelX2;
    }
}