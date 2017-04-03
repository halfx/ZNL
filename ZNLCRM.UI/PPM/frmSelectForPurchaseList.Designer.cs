namespace ZNLCRM.UI.PPM
{
    partial class frmSelectForPurchaseList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelectForPurchaseList));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpSearch = new ZNLCRM.Controls.UcPanel(this.components);
            this.txtSOLineCode = new ZNLCRM.Controls.UcTextBox(this.components);
            this.ucLabel3 = new ZNLCRM.Controls.UcLabel(this.components);
            this.txtSOBillNo = new ZNLCRM.Controls.UcTextBox(this.components);
            this.ucLabel2 = new ZNLCRM.Controls.UcLabel(this.components);
            this.btnSearch = new ZNLCRM.Controls.UcButton(this.components);
            this.UcLabel1 = new ZNLCRM.Controls.UcLabel(this.components);
            this.txtModel = new ZNLCRM.Controls.UcTextBox(this.components);
            this.panBottom = new ZNLCRM.Controls.UcPanel(this.components);
            this.btnCancel = new ZNLCRM.Controls.UcButton(this.components);
            this.btnOK = new ZNLCRM.Controls.UcButton(this.components);
            this.ucPanel1 = new ZNLCRM.Controls.UcPanel(this.components);
            this.dgvPurchaseList = new ZNLCRM.Controls.UcDataGridView(this.components);
            this.colNoticeGuid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSOGuid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLineGuid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLineCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNoticeTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNeedDeliveryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSOBillNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBrand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBatch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPackage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInvType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNoticeQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPurchaseQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDemands = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBuyerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBuyerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCurrency = new DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn();
            this.colUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPurCurrency = new DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn();
            this.ucPanel3 = new ZNLCRM.Controls.UcPanel(this.components);
            this.pgPurchaseList = new ZNLCRM.Controls.UcPager();
            this.chkAll = new ZNLCRM.Controls.UcCheckBox(this.components);
            this.grpSearch.SuspendLayout();
            this.panBottom.SuspendLayout();
            this.ucPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseList)).BeginInit();
            this.ucPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpSearch
            // 
            this.grpSearch.BackColor = System.Drawing.Color.Transparent;
            this.grpSearch.Controls.Add(this.chkAll);
            this.grpSearch.Controls.Add(this.txtSOLineCode);
            this.grpSearch.Controls.Add(this.ucLabel3);
            this.grpSearch.Controls.Add(this.txtSOBillNo);
            this.grpSearch.Controls.Add(this.ucLabel2);
            this.grpSearch.Controls.Add(this.btnSearch);
            this.grpSearch.Controls.Add(this.UcLabel1);
            this.grpSearch.Controls.Add(this.txtModel);
            this.grpSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpSearch.Location = new System.Drawing.Point(0, 0);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(996, 36);
            this.grpSearch.TabIndex = 18;
            // 
            // txtSOLineCode
            // 
            // 
            // 
            // 
            this.txtSOLineCode.Border.Class = "TextBoxBorder";
            this.txtSOLineCode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSOLineCode.EnterToNextControl = false;
            this.txtSOLineCode.Location = new System.Drawing.Point(524, 8);
            this.txtSOLineCode.Name = "txtSOLineCode";
            this.txtSOLineCode.Size = new System.Drawing.Size(150, 21);
            this.txtSOLineCode.TabIndex = 8;
            // 
            // ucLabel3
            // 
            this.ucLabel3.AutoSize = true;
            this.ucLabel3.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabel3.ForeColor = System.Drawing.Color.Gray;
            this.ucLabel3.Location = new System.Drawing.Point(453, 15);
            this.ucLabel3.Name = "ucLabel3";
            this.ucLabel3.Size = new System.Drawing.Size(65, 12);
            this.ucLabel3.TabIndex = 7;
            this.ucLabel3.Text = "销售料号：";
            // 
            // txtSOBillNo
            // 
            // 
            // 
            // 
            this.txtSOBillNo.Border.Class = "TextBoxBorder";
            this.txtSOBillNo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSOBillNo.EnterToNextControl = false;
            this.txtSOBillNo.Location = new System.Drawing.Point(297, 8);
            this.txtSOBillNo.Name = "txtSOBillNo";
            this.txtSOBillNo.Size = new System.Drawing.Size(150, 21);
            this.txtSOBillNo.TabIndex = 6;
            // 
            // ucLabel2
            // 
            this.ucLabel2.AutoSize = true;
            this.ucLabel2.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabel2.ForeColor = System.Drawing.Color.Gray;
            this.ucLabel2.Location = new System.Drawing.Point(226, 14);
            this.ucLabel2.Name = "ucLabel2";
            this.ucLabel2.Size = new System.Drawing.Size(65, 12);
            this.ucLabel2.TabIndex = 5;
            this.ucLabel2.Text = "销售单号：";
            // 
            // btnSearch
            // 
            this.btnSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSearch.Image = global::ZNLCRM.UI.Properties.Resources.search;
            this.btnSearch.Location = new System.Drawing.Point(697, 8);
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
            this.UcLabel1.Location = new System.Drawing.Point(23, 10);
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
            this.txtModel.Location = new System.Drawing.Point(70, 8);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(150, 21);
            this.txtModel.TabIndex = 3;
            // 
            // panBottom
            // 
            this.panBottom.BackColor = System.Drawing.Color.Transparent;
            this.panBottom.Controls.Add(this.btnCancel);
            this.panBottom.Controls.Add(this.btnOK);
            this.panBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panBottom.Location = new System.Drawing.Point(0, 410);
            this.panBottom.Name = "panBottom";
            this.panBottom.Size = new System.Drawing.Size(996, 47);
            this.panBottom.TabIndex = 19;
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(525, 6);
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
            this.btnOK.Location = new System.Drawing.Point(415, 6);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(86, 30);
            this.btnOK.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "确定(&S)";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // ucPanel1
            // 
            this.ucPanel1.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel1.Controls.Add(this.dgvPurchaseList);
            this.ucPanel1.Controls.Add(this.ucPanel3);
            this.ucPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPanel1.Location = new System.Drawing.Point(0, 36);
            this.ucPanel1.Name = "ucPanel1";
            this.ucPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.ucPanel1.Size = new System.Drawing.Size(996, 374);
            this.ucPanel1.TabIndex = 20;
            // 
            // dgvPurchaseList
            // 
            this.dgvPurchaseList.AllowUserToAddRows = false;
            this.dgvPurchaseList.AllowUserToDeleteRows = false;
            this.dgvPurchaseList.AllowUserToOrderColumns = true;
            this.dgvPurchaseList.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPurchaseList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPurchaseList.ColumnHeadersHeight = 30;
            this.dgvPurchaseList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNoticeGuid,
            this.colSOGuid,
            this.SOLineGuid,
            this.SOLineCode,
            this.colNoticeTime,
            this.colNeedDeliveryDate,
            this.colSOBillNo,
            this.colModel,
            this.colBrand,
            this.colBatch,
            this.colPackage,
            this.colInvType,
            this.colNoticeQty,
            this.colPurchaseQty,
            this.colDemands,
            this.colBuyerID,
            this.colBuyerName,
            this.colCurrency,
            this.colUnitPrice,
            this.colPurCurrency});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPurchaseList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPurchaseList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPurchaseList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvPurchaseList.HighlightSelectedColumnHeaders = false;
            this.dgvPurchaseList.Location = new System.Drawing.Point(5, 5);
            this.dgvPurchaseList.Name = "dgvPurchaseList";
            this.dgvPurchaseList.PaintEnhancedSelection = false;
            this.dgvPurchaseList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPurchaseList.RowTemplate.Height = 23;
            this.dgvPurchaseList.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPurchaseList.SelectAllSignVisible = false;
            this.dgvPurchaseList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvPurchaseList.Size = new System.Drawing.Size(986, 331);
            this.dgvPurchaseList.TabIndex = 1;
            // 
            // colNoticeGuid
            // 
            this.colNoticeGuid.DataPropertyName = "NoticeGuid";
            this.colNoticeGuid.HeaderText = "NoticeGuid";
            this.colNoticeGuid.Name = "colNoticeGuid";
            this.colNoticeGuid.Visible = false;
            // 
            // colSOGuid
            // 
            this.colSOGuid.DataPropertyName = "SOGuid";
            this.colSOGuid.HeaderText = "SOGuid";
            this.colSOGuid.Name = "colSOGuid";
            this.colSOGuid.Visible = false;
            // 
            // SOLineGuid
            // 
            this.SOLineGuid.DataPropertyName = "SOLineGuid";
            this.SOLineGuid.HeaderText = "SOLineGuid";
            this.SOLineGuid.Name = "SOLineGuid";
            this.SOLineGuid.Visible = false;
            // 
            // SOLineCode
            // 
            this.SOLineCode.DataPropertyName = "SOLineCode";
            this.SOLineCode.HeaderText = "SOLineCode";
            this.SOLineCode.Name = "SOLineCode";
            this.SOLineCode.Visible = false;
            // 
            // colNoticeTime
            // 
            this.colNoticeTime.DataPropertyName = "CreatedTime";
            this.colNoticeTime.HeaderText = "通知时间";
            this.colNoticeTime.Name = "colNoticeTime";
            this.colNoticeTime.Width = 80;
            // 
            // colNeedDeliveryDate
            // 
            this.colNeedDeliveryDate.DataPropertyName = "NeedDeliveryDate";
            this.colNeedDeliveryDate.HeaderText = "应发货日期";
            this.colNeedDeliveryDate.Name = "colNeedDeliveryDate";
            // 
            // colSOBillNo
            // 
            this.colSOBillNo.DataPropertyName = "SOBillNo";
            this.colSOBillNo.HeaderText = "销售单号";
            this.colSOBillNo.Name = "colSOBillNo";
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
            // colInvType
            // 
            this.colInvType.DataPropertyName = "InvType";
            this.colInvType.HeaderText = "库存类型";
            this.colInvType.Name = "colInvType";
            this.colInvType.Width = 80;
            // 
            // colNoticeQty
            // 
            this.colNoticeQty.DataPropertyName = "NoticeQty";
            this.colNoticeQty.HeaderText = "通知数量";
            this.colNoticeQty.Name = "colNoticeQty";
            this.colNoticeQty.Width = 80;
            // 
            // colPurchaseQty
            // 
            this.colPurchaseQty.DataPropertyName = "PurchaseQty";
            this.colPurchaseQty.HeaderText = "采购数量";
            this.colPurchaseQty.Name = "colPurchaseQty";
            this.colPurchaseQty.Width = 80;
            // 
            // colDemands
            // 
            this.colDemands.DataPropertyName = "Demands";
            this.colDemands.HeaderText = "采购要求";
            this.colDemands.Name = "colDemands";
            // 
            // colBuyerID
            // 
            this.colBuyerID.HeaderText = "采购员ID";
            this.colBuyerID.Name = "colBuyerID";
            this.colBuyerID.Visible = false;
            // 
            // colBuyerName
            // 
            this.colBuyerName.HeaderText = "采购员";
            this.colBuyerName.Name = "colBuyerName";
            this.colBuyerName.Visible = false;
            this.colBuyerName.Width = 80;
            // 
            // colCurrency
            // 
            this.colCurrency.DropDownHeight = 106;
            this.colCurrency.DropDownWidth = 121;
            this.colCurrency.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colCurrency.HeaderText = "销售币种";
            this.colCurrency.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.colCurrency.IntegralHeight = false;
            this.colCurrency.ItemHeight = 16;
            this.colCurrency.Name = "colCurrency";
            this.colCurrency.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colCurrency.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.colCurrency.Visible = false;
            this.colCurrency.Width = 80;
            // 
            // colUnitPrice
            // 
            this.colUnitPrice.HeaderText = "销售价";
            this.colUnitPrice.Name = "colUnitPrice";
            this.colUnitPrice.Visible = false;
            this.colUnitPrice.Width = 80;
            // 
            // colPurCurrency
            // 
            this.colPurCurrency.DropDownHeight = 106;
            this.colPurCurrency.DropDownWidth = 121;
            this.colPurCurrency.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colPurCurrency.HeaderText = "采购币种";
            this.colPurCurrency.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.colPurCurrency.IntegralHeight = false;
            this.colPurCurrency.ItemHeight = 16;
            this.colPurCurrency.Name = "colPurCurrency";
            this.colPurCurrency.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // ucPanel3
            // 
            this.ucPanel3.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel3.Controls.Add(this.pgPurchaseList);
            this.ucPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucPanel3.Location = new System.Drawing.Point(5, 336);
            this.ucPanel3.Name = "ucPanel3";
            this.ucPanel3.Size = new System.Drawing.Size(986, 33);
            this.ucPanel3.TabIndex = 5;
            // 
            // pgPurchaseList
            // 
            this.pgPurchaseList.BackColor = System.Drawing.Color.Transparent;
            this.pgPurchaseList.Location = new System.Drawing.Point(3, 8);
            this.pgPurchaseList.Name = "pgPurchaseList";
            this.pgPurchaseList.RecordCount = 0;
            this.pgPurchaseList.Size = new System.Drawing.Size(212, 16);
            this.pgPurchaseList.TabIndex = 2;
            this.pgPurchaseList.PageIndexChanged += new System.EventHandler(this.pgPurchaseList_PageIndexChanged);
            // 
            // chkAll
            // 
            // 
            // 
            // 
            this.chkAll.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkAll.Location = new System.Drawing.Point(778, 12);
            this.chkAll.Name = "chkAll";
            this.chkAll.Size = new System.Drawing.Size(64, 17);
            this.chkAll.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chkAll.TabIndex = 9;
            this.chkAll.Text = "全选";
            // 
            // frmSelectForPurchaseList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 457);
            this.Controls.Add(this.ucPanel1);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.panBottom);
            this.Name = "frmSelectForPurchaseList";
            this.Text = "选择待采购明细";
            this.Load += new System.EventHandler(this.frmSelectPurchaseList_Load);
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            this.panBottom.ResumeLayout(false);
            this.ucPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseList)).EndInit();
            this.ucPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.UcPanel grpSearch;
        private Controls.UcButton btnSearch;
        private Controls.UcLabel UcLabel1;
        private Controls.UcTextBox txtModel;
        private Controls.UcPanel panBottom;
        private Controls.UcButton btnCancel;
        private Controls.UcButton btnOK;
        private Controls.UcPanel ucPanel1;
        private Controls.UcDataGridView dgvPurchaseList;
        private Controls.UcPanel ucPanel3;
        private Controls.UcPager pgPurchaseList;
        private Controls.UcTextBox txtSOLineCode;
        private Controls.UcLabel ucLabel3;
        private Controls.UcTextBox txtSOBillNo;
        private Controls.UcLabel ucLabel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNoticeGuid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSOGuid;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLineGuid;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLineCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNoticeTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNeedDeliveryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSOBillNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBrand;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBatch;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPackage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNoticeQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPurchaseQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDemands;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBuyerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBuyerName;
        private DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn colCurrency;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnitPrice;
        private DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn colPurCurrency;
        private Controls.UcCheckBox chkAll;
    }
}