namespace ZNLCRM.UI.STK
{
    partial class frmSelectStockReserve
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelectStockReserve));
            this.dgvStockReserve = new ZNLCRM.Controls.UcDataGridView(this.components);
            this.colSRGuid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSourceBillGuid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSourceBillNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSourceBillLineGuid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReserveQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOutQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReserveType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBrand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPackage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBatch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMPQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMarkCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InBatchNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWarehouse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInvType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRemark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreatedEmpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreatedTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUpdatedEmpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUpdatedTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpSearch = new ZNLCRM.Controls.UcPanel(this.components);
            this.btnSearch = new ZNLCRM.Controls.UcButton(this.components);
            this.UcLabel1 = new ZNLCRM.Controls.UcLabel(this.components);
            this.txtModel = new ZNLCRM.Controls.UcTextBox(this.components);
            this.chkAll = new ZNLCRM.Controls.UcCheckBox(this.components);
            this.panBottom = new ZNLCRM.Controls.UcPanel(this.components);
            this.btnCancel = new ZNLCRM.Controls.UcButton(this.components);
            this.btnOK = new ZNLCRM.Controls.UcButton(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockReserve)).BeginInit();
            this.grpSearch.SuspendLayout();
            this.panBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvStockReserve
            // 
            this.dgvStockReserve.AllowUserToAddRows = false;
            this.dgvStockReserve.AllowUserToDeleteRows = false;
            this.dgvStockReserve.AllowUserToOrderColumns = true;
            this.dgvStockReserve.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStockReserve.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStockReserve.ColumnHeadersHeight = 30;
            this.dgvStockReserve.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSRGuid,
            this.colSourceBillGuid,
            this.colSourceBillNo,
            this.colSourceBillLineGuid,
            this.colItemCode,
            this.colReserveQty,
            this.colOutQty,
            this.colUnit,
            this.colReserveType,
            this.colModel,
            this.colBrand,
            this.colPackage,
            this.colBatch,
            this.colQuality,
            this.colMPQ,
            this.colMarkCode,
            this.InBatchNo,
            this.colWarehouse,
            this.colLocation,
            this.colInvType,
            this.colRemark,
            this.colCreatedEmpName,
            this.colCreatedTime,
            this.colUpdatedEmpName,
            this.colUpdatedTime});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStockReserve.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStockReserve.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStockReserve.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvStockReserve.HighlightSelectedColumnHeaders = false;
            this.dgvStockReserve.Location = new System.Drawing.Point(0, 30);
            this.dgvStockReserve.Name = "dgvStockReserve";
            this.dgvStockReserve.PaintEnhancedSelection = false;
            this.dgvStockReserve.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStockReserve.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvStockReserve.RowTemplate.Height = 23;
            this.dgvStockReserve.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStockReserve.SelectAllSignVisible = false;
            this.dgvStockReserve.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvStockReserve.Size = new System.Drawing.Size(972, 339);
            this.dgvStockReserve.TabIndex = 17;
            // 
            // colSRGuid
            // 
            this.colSRGuid.DataPropertyName = "SRGuid";
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
            // colSourceBillNo
            // 
            this.colSourceBillNo.DataPropertyName = "SourceBillNo";
            this.colSourceBillNo.HeaderText = "源单据编号";
            this.colSourceBillNo.Name = "colSourceBillNo";
            // 
            // colSourceBillLineGuid
            // 
            this.colSourceBillLineGuid.DataPropertyName = "SourceBillLineGuid";
            this.colSourceBillLineGuid.HeaderText = "SourceBillLineGuid";
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
            // colReserveQty
            // 
            this.colReserveQty.DataPropertyName = "ReserveQty";
            this.colReserveQty.HeaderText = "预留数量";
            this.colReserveQty.Name = "colReserveQty";
            // 
            // colOutQty
            // 
            this.colOutQty.DataPropertyName = "OutQty";
            this.colOutQty.HeaderText = "出库数量";
            this.colOutQty.Name = "colOutQty";
            // 
            // colUnit
            // 
            this.colUnit.DataPropertyName = "Unit";
            this.colUnit.HeaderText = "单位";
            this.colUnit.Name = "colUnit";
            // 
            // colReserveType
            // 
            this.colReserveType.DataPropertyName = "ReserveType";
            this.colReserveType.HeaderText = "预留类型";
            this.colReserveType.Name = "colReserveType";
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
            // InBatchNo
            // 
            this.InBatchNo.HeaderText = "入库批次号";
            this.InBatchNo.Name = "InBatchNo";
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
            // colInvType
            // 
            this.colInvType.DataPropertyName = "InvType";
            this.colInvType.HeaderText = "库存类型";
            this.colInvType.Name = "colInvType";
            // 
            // colRemark
            // 
            this.colRemark.DataPropertyName = "Remark";
            this.colRemark.HeaderText = "备注";
            this.colRemark.Name = "colRemark";
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
            this.colUpdatedEmpName.HeaderText = "修改人员";
            this.colUpdatedEmpName.Name = "colUpdatedEmpName";
            // 
            // colUpdatedTime
            // 
            this.colUpdatedTime.DataPropertyName = "UpdatedTime";
            this.colUpdatedTime.HeaderText = "修改时间";
            this.colUpdatedTime.Name = "colUpdatedTime";
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
            this.grpSearch.Size = new System.Drawing.Size(972, 30);
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
            this.panBottom.Location = new System.Drawing.Point(0, 369);
            this.panBottom.Name = "panBottom";
            this.panBottom.Size = new System.Drawing.Size(972, 55);
            this.panBottom.TabIndex = 19;
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(511, 16);
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
            this.btnOK.Location = new System.Drawing.Point(401, 16);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(86, 30);
            this.btnOK.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "确定(&S)";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // frmSelectStockReserve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 424);
            this.Controls.Add(this.dgvStockReserve);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.panBottom);
            this.Name = "frmSelectStockReserve";
            this.Text = "选择预留信息";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockReserve)).EndInit();
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            this.panBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.UcDataGridView dgvStockReserve;
        private Controls.UcPanel grpSearch;
        private Controls.UcButton btnSearch;
        private Controls.UcLabel UcLabel1;
        private Controls.UcTextBox txtModel;
        private Controls.UcCheckBox chkAll;
        private Controls.UcPanel panBottom;
        private Controls.UcButton btnCancel;
        private Controls.UcButton btnOK;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSRGuid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSourceBillGuid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSourceBillNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSourceBillLineGuid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReserveQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOutQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReserveType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBrand;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPackage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBatch;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuality;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMPQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMarkCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn InBatchNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWarehouse;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRemark;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreatedEmpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreatedTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUpdatedEmpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUpdatedTime;
    }
}