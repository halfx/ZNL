namespace ZNLCRM.UI.SPM
{
    partial class frmSelectSalesReturnLine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelectSalesReturnLine));
            this.dgvSalesReturn = new ZNLCRM.Controls.UcDataGridView(this.components);
            this.grpSearch = new ZNLCRM.Controls.UcPanel(this.components);
            this.btnSearch = new ZNLCRM.Controls.UcButton(this.components);
            this.UcLabel1 = new ZNLCRM.Controls.UcLabel(this.components);
            this.txtModel = new ZNLCRM.Controls.UcTextBox(this.components);
            this.chkAll = new ZNLCRM.Controls.UcCheckBox(this.components);
            this.panBottom = new ZNLCRM.Controls.UcPanel(this.components);
            this.btnCancel = new ZNLCRM.Controls.UcButton(this.components);
            this.btnOK = new ZNLCRM.Controls.UcButton(this.components);
            this.colSRLineGuid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSRBillNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSRGuid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBrand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPackage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBatch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInvType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWarehouse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStkInQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCurrency = new DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn();
            this.colTaxRate = new DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLinkStkInUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLinkStkInFreight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLinkStkInCurrency = new DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn();
            this.colLinkStkInTaxRate = new DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn();
            this.colLinkStkInCostPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRemark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMPQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMarkCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesReturn)).BeginInit();
            this.grpSearch.SuspendLayout();
            this.panBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSalesReturn
            // 
            this.dgvSalesReturn.AllowUserToAddRows = false;
            this.dgvSalesReturn.AllowUserToDeleteRows = false;
            this.dgvSalesReturn.AllowUserToOrderColumns = true;
            this.dgvSalesReturn.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSalesReturn.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSalesReturn.ColumnHeadersHeight = 30;
            this.dgvSalesReturn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSRLineGuid,
            this.colSRBillNo,
            this.colSRGuid,
            this.colModel,
            this.colBrand,
            this.colPackage,
            this.colBatch,
            this.colInvType,
            this.colWarehouse,
            this.colLocation,
            this.colQty,
            this.colStkInQty,
            this.colUnitPrice,
            this.colCurrency,
            this.colTaxRate,
            this.colAmount,
            this.colLinkStkInUnitPrice,
            this.colLinkStkInFreight,
            this.colLinkStkInCurrency,
            this.colLinkStkInTaxRate,
            this.colLinkStkInCostPrice,
            this.colRemark,
            this.colQuality,
            this.colMPQ,
            this.colMarkCode});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSalesReturn.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSalesReturn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSalesReturn.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvSalesReturn.HighlightSelectedColumnHeaders = false;
            this.dgvSalesReturn.Location = new System.Drawing.Point(0, 30);
            this.dgvSalesReturn.Name = "dgvSalesReturn";
            this.dgvSalesReturn.PaintEnhancedSelection = false;
            this.dgvSalesReturn.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvSalesReturn.RowTemplate.Height = 23;
            this.dgvSalesReturn.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSalesReturn.SelectAllSignVisible = false;
            this.dgvSalesReturn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvSalesReturn.Size = new System.Drawing.Size(1037, 370);
            this.dgvSalesReturn.TabIndex = 17;
            // 
            // grpSearch
            // 
            this.grpSearch.BackColor = System.Drawing.Color.Transparent;
            this.grpSearch.Controls.Add(this.btnSearch);
            this.grpSearch.Controls.Add(this.UcLabel1);
            this.grpSearch.Controls.Add(this.txtModel);
            this.grpSearch.Controls.Add(this.chkAll);
            this.grpSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpSearch.Location = new System.Drawing.Point(0, 0);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(1037, 30);
            this.grpSearch.TabIndex = 18;
            // 
            // btnSearch
            // 
            this.btnSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSearch.Image = global::ZNLCRM.UI.Properties.Resources.search;
            this.btnSearch.Location = new System.Drawing.Point(268, 2);
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
            this.UcLabel1.Location = new System.Drawing.Point(29, 7);
            this.UcLabel1.Name = "UcLabel1";
            this.UcLabel1.Size = new System.Drawing.Size(41, 12);
            this.UcLabel1.TabIndex = 2;
            this.UcLabel1.Text = "型号：";
            // 
            // txtModel
            // 
            // 
            // 
            // 
            this.txtModel.Border.Class = "TextBoxBorder";
            this.txtModel.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtModel.EnterToNextControl = false;
            this.txtModel.Location = new System.Drawing.Point(100, 3);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(150, 21);
            this.txtModel.TabIndex = 3;
            // 
            // chkAll
            // 
            // 
            // 
            // 
            this.chkAll.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkAll.Location = new System.Drawing.Point(349, 7);
            this.chkAll.Name = "chkAll";
            this.chkAll.Size = new System.Drawing.Size(64, 17);
            this.chkAll.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chkAll.TabIndex = 2;
            this.chkAll.Text = "全选";
            // 
            // panBottom
            // 
            this.panBottom.BackColor = System.Drawing.Color.Transparent;
            this.panBottom.Controls.Add(this.btnCancel);
            this.panBottom.Controls.Add(this.btnOK);
            this.panBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panBottom.Location = new System.Drawing.Point(0, 400);
            this.panBottom.Name = "panBottom";
            this.panBottom.Size = new System.Drawing.Size(1037, 47);
            this.panBottom.TabIndex = 19;
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(545, 6);
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
            this.btnOK.Location = new System.Drawing.Point(435, 6);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(86, 30);
            this.btnOK.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "确定(&S)";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // colSRLineGuid
            // 
            this.colSRLineGuid.DataPropertyName = "SRLineGuid";
            this.colSRLineGuid.HeaderText = "SRLineGuid";
            this.colSRLineGuid.Name = "colSRLineGuid";
            this.colSRLineGuid.Visible = false;
            // 
            // colSRBillNo
            // 
            this.colSRBillNo.DataPropertyName = "SRBillNo";
            this.colSRBillNo.HeaderText = "退货单号";
            this.colSRBillNo.Name = "colSRBillNo";
            // 
            // colSRGuid
            // 
            this.colSRGuid.DataPropertyName = "SRGuid";
            this.colSRGuid.HeaderText = "SRGuid";
            this.colSRGuid.Name = "colSRGuid";
            this.colSRGuid.Visible = false;
            // 
            // colModel
            // 
            this.colModel.DataPropertyName = "Model";
            this.colModel.HeaderText = "型号";
            this.colModel.Name = "colModel";
            this.colModel.Width = 150;
            // 
            // colBrand
            // 
            this.colBrand.DataPropertyName = "Brand";
            this.colBrand.HeaderText = "品牌";
            this.colBrand.Name = "colBrand";
            this.colBrand.Width = 80;
            // 
            // colPackage
            // 
            this.colPackage.DataPropertyName = "Package";
            this.colPackage.HeaderText = "封装";
            this.colPackage.Name = "colPackage";
            this.colPackage.Width = 80;
            // 
            // colBatch
            // 
            this.colBatch.DataPropertyName = "Batch";
            this.colBatch.HeaderText = "批号";
            this.colBatch.Name = "colBatch";
            this.colBatch.Visible = false;
            this.colBatch.Width = 80;
            // 
            // colInvType
            // 
            this.colInvType.DataPropertyName = "InvType";
            this.colInvType.HeaderText = "库存类型";
            this.colInvType.Name = "colInvType";
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
            // colQty
            // 
            this.colQty.DataPropertyName = "Qty";
            this.colQty.HeaderText = "退货数量";
            this.colQty.Name = "colQty";
            this.colQty.Width = 80;
            // 
            // colStkInQty
            // 
            this.colStkInQty.DataPropertyName = "StkInQty";
            this.colStkInQty.HeaderText = "退货入库数量";
            this.colStkInQty.Name = "colStkInQty";
            this.colStkInQty.Width = 80;
            // 
            // colUnitPrice
            // 
            this.colUnitPrice.DataPropertyName = "UnitPrice";
            this.colUnitPrice.HeaderText = "退货单价";
            this.colUnitPrice.Name = "colUnitPrice";
            this.colUnitPrice.Width = 80;
            // 
            // colCurrency
            // 
            this.colCurrency.DataPropertyName = "Currency";
            this.colCurrency.DropDownHeight = 106;
            this.colCurrency.DropDownWidth = 121;
            this.colCurrency.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colCurrency.HeaderText = "退货币种";
            this.colCurrency.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.colCurrency.ItemHeight = 16;
            this.colCurrency.Name = "colCurrency";
            this.colCurrency.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colCurrency.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // colTaxRate
            // 
            this.colTaxRate.DataPropertyName = "TaxRate";
            this.colTaxRate.DropDownHeight = 106;
            this.colTaxRate.DropDownWidth = 121;
            this.colTaxRate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colTaxRate.HeaderText = "退货税率";
            this.colTaxRate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.colTaxRate.ItemHeight = 16;
            this.colTaxRate.Name = "colTaxRate";
            this.colTaxRate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colTaxRate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // colAmount
            // 
            this.colAmount.DataPropertyName = "Amount";
            this.colAmount.HeaderText = "退货金额";
            this.colAmount.Name = "colAmount";
            this.colAmount.Width = 80;
            // 
            // colLinkStkInUnitPrice
            // 
            this.colLinkStkInUnitPrice.DataPropertyName = "LinkStkInUnitPrice";
            this.colLinkStkInUnitPrice.HeaderText = "关联采购价格";
            this.colLinkStkInUnitPrice.Name = "colLinkStkInUnitPrice";
            // 
            // colLinkStkInFreight
            // 
            this.colLinkStkInFreight.DataPropertyName = "LinkStkInFreight";
            this.colLinkStkInFreight.HeaderText = "关联运费";
            this.colLinkStkInFreight.Name = "colLinkStkInFreight";
            // 
            // colLinkStkInCurrency
            // 
            this.colLinkStkInCurrency.DataPropertyName = "LinkStkInCurrency";
            this.colLinkStkInCurrency.DropDownHeight = 106;
            this.colLinkStkInCurrency.DropDownWidth = 121;
            this.colLinkStkInCurrency.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colLinkStkInCurrency.HeaderText = "关联币种";
            this.colLinkStkInCurrency.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.colLinkStkInCurrency.ItemHeight = 16;
            this.colLinkStkInCurrency.Name = "colLinkStkInCurrency";
            this.colLinkStkInCurrency.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colLinkStkInCurrency.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // colLinkStkInTaxRate
            // 
            this.colLinkStkInTaxRate.DataPropertyName = "LinkStkInTaxRate";
            this.colLinkStkInTaxRate.DropDownHeight = 106;
            this.colLinkStkInTaxRate.DropDownWidth = 121;
            this.colLinkStkInTaxRate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colLinkStkInTaxRate.HeaderText = "关联税率";
            this.colLinkStkInTaxRate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.colLinkStkInTaxRate.ItemHeight = 16;
            this.colLinkStkInTaxRate.Name = "colLinkStkInTaxRate";
            this.colLinkStkInTaxRate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colLinkStkInTaxRate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // colLinkStkInCostPrice
            // 
            this.colLinkStkInCostPrice.DataPropertyName = "LinkStkInCostPrice";
            this.colLinkStkInCostPrice.HeaderText = "关联成本单价";
            this.colLinkStkInCostPrice.Name = "colLinkStkInCostPrice";
            // 
            // colRemark
            // 
            this.colRemark.DataPropertyName = "Remark";
            this.colRemark.HeaderText = "备注";
            this.colRemark.Name = "colRemark";
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
            this.colMarkCode.HeaderText = "标记码";
            this.colMarkCode.Name = "colMarkCode";
            this.colMarkCode.Width = 80;
            // 
            // frmSelectSalesReturnLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 447);
            this.Controls.Add(this.dgvSalesReturn);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.panBottom);
            this.Name = "frmSelectSalesReturnLine";
            this.Text = "选择销售退货明细";
            this.Load += new System.EventHandler(this.frmSelectSalesReturnLine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesReturn)).EndInit();
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            this.panBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.UcDataGridView dgvSalesReturn;
        private Controls.UcPanel grpSearch;
        private Controls.UcButton btnSearch;
        private Controls.UcLabel UcLabel1;
        private Controls.UcTextBox txtModel;
        private Controls.UcCheckBox chkAll;
        private Controls.UcPanel panBottom;
        private Controls.UcButton btnCancel;
        private Controls.UcButton btnOK;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSRLineGuid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSRBillNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSRGuid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBrand;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPackage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBatch;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWarehouse;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStkInQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnitPrice;
        private DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn colCurrency;
        private DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn colTaxRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLinkStkInUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLinkStkInFreight;
        private DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn colLinkStkInCurrency;
        private DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn colLinkStkInTaxRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLinkStkInCostPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRemark;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuality;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMPQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMarkCode;
    }
}