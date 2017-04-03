namespace ZNLCRM.UI.STK
{
    partial class frmStockManage
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
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn22 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn23 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn24 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn25 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn26 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn27 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.ucPanel1 = new ZNLCRM.Controls.UcPanel(this.components);
            this.cboWarehouse = new ZNLCRM.Controls.UcComboBox(this.components);
            this.ucLabelX2 = new ZNLCRM.Controls.UcLabelX(this.components);
            this.txtModel = new ZNLCRM.Controls.UcTextBox(this.components);
            this.ucLabelX1 = new ZNLCRM.Controls.UcLabelX(this.components);
            this.btnSearch = new ZNLCRM.Controls.UcButton(this.components);
            this.ucPanel2 = new ZNLCRM.Controls.UcPanel(this.components);
            this.sgcStock = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.ucPanel3 = new ZNLCRM.Controls.UcPanel(this.components);
            this.pgStock = new ZNLCRM.Controls.UcPager();
            this.ucPanel1.SuspendLayout();
            this.ucPanel2.SuspendLayout();
            this.ucPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ucPanel1
            // 
            this.ucPanel1.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel1.Controls.Add(this.cboWarehouse);
            this.ucPanel1.Controls.Add(this.ucLabelX2);
            this.ucPanel1.Controls.Add(this.txtModel);
            this.ucPanel1.Controls.Add(this.ucLabelX1);
            this.ucPanel1.Controls.Add(this.btnSearch);
            this.ucPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucPanel1.Location = new System.Drawing.Point(0, 0);
            this.ucPanel1.Name = "ucPanel1";
            this.ucPanel1.Size = new System.Drawing.Size(911, 48);
            this.ucPanel1.TabIndex = 1;
            // 
            // cboWarehouse
            // 
            this.cboWarehouse.DisplayMember = "Text";
            this.cboWarehouse.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboWarehouse.FormattingEnabled = true;
            this.cboWarehouse.ItemHeight = 15;
            this.cboWarehouse.Location = new System.Drawing.Point(303, 15);
            this.cboWarehouse.Name = "cboWarehouse";
            this.cboWarehouse.Size = new System.Drawing.Size(121, 21);
            this.cboWarehouse.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboWarehouse.TabIndex = 4;
            // 
            // ucLabelX2
            // 
            // 
            // 
            // 
            this.ucLabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ucLabelX2.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabelX2.ForeColor = System.Drawing.Color.Gray;
            this.ucLabelX2.Location = new System.Drawing.Point(253, 15);
            this.ucLabelX2.Name = "ucLabelX2";
            this.ucLabelX2.Size = new System.Drawing.Size(44, 23);
            this.ucLabelX2.TabIndex = 3;
            this.ucLabelX2.Text = "仓库：";
            // 
            // txtModel
            // 
            // 
            // 
            // 
            this.txtModel.Border.Class = "TextBoxBorder";
            this.txtModel.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtModel.EnterToNextControl = false;
            this.txtModel.Location = new System.Drawing.Point(65, 14);
            this.txtModel.Name = "txtModel";
            this.txtModel.PreventEnterBeep = true;
            this.txtModel.Size = new System.Drawing.Size(159, 21);
            this.txtModel.TabIndex = 2;
            // 
            // ucLabelX1
            // 
            // 
            // 
            // 
            this.ucLabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ucLabelX1.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabelX1.ForeColor = System.Drawing.Color.Gray;
            this.ucLabelX1.Location = new System.Drawing.Point(15, 14);
            this.ucLabelX1.Name = "ucLabelX1";
            this.ucLabelX1.Size = new System.Drawing.Size(44, 23);
            this.ucLabelX1.TabIndex = 1;
            this.ucLabelX1.Text = "型号：";
            // 
            // btnSearch
            // 
            this.btnSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSearch.Location = new System.Drawing.Point(430, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 27);
            this.btnSearch.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "搜 索";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // ucPanel2
            // 
            this.ucPanel2.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel2.Controls.Add(this.sgcStock);
            this.ucPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPanel2.Location = new System.Drawing.Point(0, 48);
            this.ucPanel2.Name = "ucPanel2";
            this.ucPanel2.Padding = new System.Windows.Forms.Padding(5);
            this.ucPanel2.Size = new System.Drawing.Size(911, 399);
            this.ucPanel2.TabIndex = 2;
            // 
            // sgcStock
            // 
            this.sgcStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sgcStock.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.sgcStock.ForeColor = System.Drawing.Color.Black;
            this.sgcStock.Location = new System.Drawing.Point(5, 5);
            this.sgcStock.Name = "sgcStock";
            this.sgcStock.PrimaryGrid.AllowRowHeaderResize = true;
            this.sgcStock.PrimaryGrid.AllowRowResize = true;
            this.sgcStock.PrimaryGrid.AutoGenerateColumns = false;
            this.sgcStock.PrimaryGrid.ColumnHeader.RowHeight = 30;
            gridColumn1.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridCheckBoxXEditControl);
            gridColumn1.HeaderText = "选?";
            gridColumn1.Name = "colSelect";
            gridColumn1.Width = 62;
            gridColumn2.DataPropertyName = "TItemCode";
            gridColumn2.HeaderText = "TItemCode";
            gridColumn2.Name = "colTItemCode";
            gridColumn2.Visible = false;
            gridColumn3.HeaderText = "ItemCode";
            gridColumn3.Name = "colItemCode";
            gridColumn3.Visible = false;
            gridColumn4.DataPropertyName = "Model";
            gridColumn4.HeaderText = "型号";
            gridColumn4.Name = "colModel";
            gridColumn5.DataPropertyName = "Brand";
            gridColumn5.HeaderText = "品牌";
            gridColumn5.Name = "colBrand";
            gridColumn5.Width = 80;
            gridColumn6.DataPropertyName = "Batch";
            gridColumn6.HeaderText = "批号";
            gridColumn6.Name = "colBatch";
            gridColumn6.Width = 80;
            gridColumn7.DataPropertyName = "Package";
            gridColumn7.HeaderText = "封装";
            gridColumn7.Name = "colPackage";
            gridColumn7.Width = 80;
            gridColumn8.HeaderText = "仓库";
            gridColumn8.Name = "colWarehouse";
            gridColumn8.Width = 80;
            gridColumn9.HeaderText = "总数量/库存量";
            gridColumn9.Name = "colInvQty";
            gridColumn9.Width = 80;
            gridColumn10.HeaderText = "最大库存/订购数";
            gridColumn10.Name = "colBookedQty";
            gridColumn10.Visible = false;
            gridColumn10.Width = 80;
            gridColumn11.HeaderText = "最小库存/可用量";
            gridColumn11.Name = "colUsableQty";
            gridColumn11.Visible = false;
            gridColumn11.Width = 80;
            gridColumn12.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridNumericUpDownEditControl);
            gridColumn12.HeaderText = "销售指导价";
            gridColumn12.Name = "colFollowPrice";
            gridColumn13.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridNumericUpDownEditControl);
            gridColumn13.HeaderText = "销售定价";
            gridColumn13.Name = "colSalePrice";
            gridColumn14.HeaderText = "批号";
            gridColumn14.Name = "colInBatchNo";
            gridColumn15.HeaderText = "位置";
            gridColumn15.Name = "colLocation";
            gridColumn15.Width = 80;
            gridColumn16.HeaderText = "品质";
            gridColumn16.Name = "colQuality";
            gridColumn16.Width = 80;
            gridColumn17.HeaderText = "包装";
            gridColumn17.Name = "colMPQ";
            gridColumn17.Width = 80;
            gridColumn18.HeaderText = "标记码";
            gridColumn18.Name = "colMarkCode";
            gridColumn18.Width = 80;
            gridColumn19.HeaderText = "描述";
            gridColumn19.Name = "colDescription";
            gridColumn19.Visible = false;
            gridColumn20.HeaderText = "备注";
            gridColumn20.Name = "colRemark";
            gridColumn21.HeaderText = "库存类型";
            gridColumn21.Name = "colInvType";
            gridColumn22.HeaderText = "单位";
            gridColumn22.Name = "colUnit";
            gridColumn22.Width = 30;
            gridColumn23.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridComboBoxExEditControl);
            gridColumn23.HeaderText = "币种";
            gridColumn23.Name = "colCurrency";
            gridColumn23.Width = 40;
            gridColumn24.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridNumericUpDownEditControl);
            gridColumn24.HeaderText = "采购价";
            gridColumn24.Name = "colBuyPrice";
            gridColumn24.Width = 80;
            gridColumn25.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridNumericUpDownEditControl);
            gridColumn25.HeaderText = "采购价（RMB）";
            gridColumn25.Name = "colBuyPriceRMB";
            gridColumn25.Width = 80;
            gridColumn26.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridNumericUpDownEditControl);
            gridColumn26.HeaderText = "采购平均价(RMB)";
            gridColumn26.Name = "colBuyAveragePrice";
            gridColumn26.Width = 80;
            gridColumn27.HeaderText = "创建时间";
            gridColumn27.Name = "colCreatedTime";
            gridColumn27.Width = 120;
            this.sgcStock.PrimaryGrid.Columns.Add(gridColumn1);
            this.sgcStock.PrimaryGrid.Columns.Add(gridColumn2);
            this.sgcStock.PrimaryGrid.Columns.Add(gridColumn3);
            this.sgcStock.PrimaryGrid.Columns.Add(gridColumn4);
            this.sgcStock.PrimaryGrid.Columns.Add(gridColumn5);
            this.sgcStock.PrimaryGrid.Columns.Add(gridColumn6);
            this.sgcStock.PrimaryGrid.Columns.Add(gridColumn7);
            this.sgcStock.PrimaryGrid.Columns.Add(gridColumn8);
            this.sgcStock.PrimaryGrid.Columns.Add(gridColumn9);
            this.sgcStock.PrimaryGrid.Columns.Add(gridColumn10);
            this.sgcStock.PrimaryGrid.Columns.Add(gridColumn11);
            this.sgcStock.PrimaryGrid.Columns.Add(gridColumn12);
            this.sgcStock.PrimaryGrid.Columns.Add(gridColumn13);
            this.sgcStock.PrimaryGrid.Columns.Add(gridColumn14);
            this.sgcStock.PrimaryGrid.Columns.Add(gridColumn15);
            this.sgcStock.PrimaryGrid.Columns.Add(gridColumn16);
            this.sgcStock.PrimaryGrid.Columns.Add(gridColumn17);
            this.sgcStock.PrimaryGrid.Columns.Add(gridColumn18);
            this.sgcStock.PrimaryGrid.Columns.Add(gridColumn19);
            this.sgcStock.PrimaryGrid.Columns.Add(gridColumn20);
            this.sgcStock.PrimaryGrid.Columns.Add(gridColumn21);
            this.sgcStock.PrimaryGrid.Columns.Add(gridColumn22);
            this.sgcStock.PrimaryGrid.Columns.Add(gridColumn23);
            this.sgcStock.PrimaryGrid.Columns.Add(gridColumn24);
            this.sgcStock.PrimaryGrid.Columns.Add(gridColumn25);
            this.sgcStock.PrimaryGrid.Columns.Add(gridColumn26);
            this.sgcStock.PrimaryGrid.Columns.Add(gridColumn27);
            this.sgcStock.PrimaryGrid.DefaultRowHeight = 24;
            this.sgcStock.PrimaryGrid.EnableColumnFiltering = true;
            this.sgcStock.PrimaryGrid.EnableFiltering = true;
            this.sgcStock.PrimaryGrid.EnableRowFiltering = true;
            this.sgcStock.PrimaryGrid.Filter.Visible = true;
            this.sgcStock.PrimaryGrid.RowHeaderWidth = 45;
            this.sgcStock.PrimaryGrid.ShowRowGridIndex = true;
            this.sgcStock.PrimaryGrid.ShowTreeButtons = true;
            this.sgcStock.PrimaryGrid.ShowTreeLines = true;
            this.sgcStock.Size = new System.Drawing.Size(901, 389);
            this.sgcStock.TabIndex = 0;
            this.sgcStock.Text = "superGridControl1";
            this.sgcStock.DataBindingComplete += new System.EventHandler<DevComponents.DotNetBar.SuperGrid.GridDataBindingCompleteEventArgs>(this.sgcStock_DataBindingComplete);
            // 
            // ucPanel3
            // 
            this.ucPanel3.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel3.Controls.Add(this.pgStock);
            this.ucPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucPanel3.Location = new System.Drawing.Point(0, 447);
            this.ucPanel3.Name = "ucPanel3";
            this.ucPanel3.Size = new System.Drawing.Size(911, 36);
            this.ucPanel3.TabIndex = 3;
            // 
            // pgStock
            // 
            this.pgStock.BackColor = System.Drawing.Color.Transparent;
            this.pgStock.Location = new System.Drawing.Point(12, 9);
            this.pgStock.Name = "pgStock";
            this.pgStock.RecordCount = 0;
            this.pgStock.Size = new System.Drawing.Size(233, 21);
            this.pgStock.TabIndex = 0;
            this.pgStock.PageIndexChanged += new System.EventHandler(this.pgStock_PageIndexChanged);
            // 
            // frmStockManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 483);
            this.Controls.Add(this.ucPanel2);
            this.Controls.Add(this.ucPanel1);
            this.Controls.Add(this.ucPanel3);
            this.Name = "frmStockManage";
            this.Text = "库存管理";
            this.Load += new System.EventHandler(this.frmStockManage_Load);
            this.ucPanel1.ResumeLayout(false);
            this.ucPanel2.ResumeLayout(false);
            this.ucPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.UcPanel ucPanel1;
        private Controls.UcPanel ucPanel2;
        private Controls.UcComboBox cboWarehouse;
        private Controls.UcLabelX ucLabelX2;
        private Controls.UcTextBox txtModel;
        private Controls.UcLabelX ucLabelX1;
        private Controls.UcButton btnSearch;
        private DevComponents.DotNetBar.SuperGrid.SuperGridControl sgcStock;
        private Controls.UcPanel ucPanel3;
        private Controls.UcPager pgStock;

    }
}