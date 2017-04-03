namespace ZNLCRM.Controls
{
    partial class UcComAttachedInfo
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabItem1 = new DevComponents.DotNetBar.TabItem(this.components);
            this.ucTabControl1 = new ZNLCRM.Controls.UcTabControl(this.components);
            this.tcpMainBrand = new DevComponents.DotNetBar.TabControlPanel();
            this.plMainBrandContent = new ZNLCRM.Controls.UcPanel(this.components);
            this.dgvMainBrand = new ZNLCRM.Controls.UcDataGridView(this.components);
            this.plMainBrandTop = new ZNLCRM.Controls.UcPanel(this.components);
            this.ucPanel7 = new ZNLCRM.Controls.UcPanel(this.components);
            this.ucPanel8 = new ZNLCRM.Controls.UcPanel(this.components);
            this.btnSearchMainBrand = new ZNLCRM.Controls.UcButton(this.components);
            this.txtMainBrand = new ZNLCRM.Controls.UcTextBox(this.components);
            this.plMainBrandButtom = new ZNLCRM.Controls.UcPanel(this.components);
            this.ucPgMainBrand = new ZNLCRM.Controls.UcPager();
            this.tiMainBrand = new DevComponents.DotNetBar.TabItem(this.components);
            this.tcpMainSeries = new DevComponents.DotNetBar.TabControlPanel();
            this.plMainSeriesButtom = new ZNLCRM.Controls.UcPanel(this.components);
            this.ucPgMainSeries = new ZNLCRM.Controls.UcPager();
            this.plMainSeriesContent = new ZNLCRM.Controls.UcPanel(this.components);
            this.dgvMainSeries = new ZNLCRM.Controls.UcDataGridView(this.components);
            this.plMainSeriesTop = new ZNLCRM.Controls.UcPanel(this.components);
            this.ucPanel12 = new ZNLCRM.Controls.UcPanel(this.components);
            this.ucPanel13 = new ZNLCRM.Controls.UcPanel(this.components);
            this.btnSearchMainSeries = new ZNLCRM.Controls.UcButton(this.components);
            this.txtMainSeries = new ZNLCRM.Controls.UcTextBox(this.components);
            this.tiMainSeries = new DevComponents.DotNetBar.TabItem(this.components);
            this.tcpMainPackaging = new DevComponents.DotNetBar.TabControlPanel();
            this.plMainPackagingButtom = new ZNLCRM.Controls.UcPanel(this.components);
            this.ucPgMainPackaging = new ZNLCRM.Controls.UcPager();
            this.plMainPackagingContent = new ZNLCRM.Controls.UcPanel(this.components);
            this.dgvMainPackaging = new ZNLCRM.Controls.UcDataGridView(this.components);
            this.plMainPackagingTop = new ZNLCRM.Controls.UcPanel(this.components);
            this.ucPanel17 = new ZNLCRM.Controls.UcPanel(this.components);
            this.ucPanel18 = new ZNLCRM.Controls.UcPanel(this.components);
            this.btnSearchMainPackaging = new ZNLCRM.Controls.UcButton(this.components);
            this.txtMainPackaging = new ZNLCRM.Controls.UcTextBox(this.components);
            this.tiMainPackaging = new DevComponents.DotNetBar.TabItem(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ucTabControl1)).BeginInit();
            this.ucTabControl1.SuspendLayout();
            this.tcpMainBrand.SuspendLayout();
            this.plMainBrandContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMainBrand)).BeginInit();
            this.plMainBrandTop.SuspendLayout();
            this.ucPanel8.SuspendLayout();
            this.plMainBrandButtom.SuspendLayout();
            this.tcpMainSeries.SuspendLayout();
            this.plMainSeriesButtom.SuspendLayout();
            this.plMainSeriesContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMainSeries)).BeginInit();
            this.plMainSeriesTop.SuspendLayout();
            this.ucPanel13.SuspendLayout();
            this.tcpMainPackaging.SuspendLayout();
            this.plMainPackagingButtom.SuspendLayout();
            this.plMainPackagingContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMainPackaging)).BeginInit();
            this.plMainPackagingTop.SuspendLayout();
            this.ucPanel18.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabItem1
            // 
            this.tabItem1.Name = "tabItem1";
            this.tabItem1.Text = "拜访计划";
            // 
            // ucTabControl1
            // 
            this.ucTabControl1.BackColor = System.Drawing.Color.GhostWhite;
            this.ucTabControl1.CanReorderTabs = true;
            this.ucTabControl1.Controls.Add(this.tcpMainPackaging);
            this.ucTabControl1.Controls.Add(this.tcpMainSeries);
            this.ucTabControl1.Controls.Add(this.tcpMainBrand);
            this.ucTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucTabControl1.Location = new System.Drawing.Point(0, 0);
            this.ucTabControl1.Name = "ucTabControl1";
            this.ucTabControl1.SelectedTabFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold);
            this.ucTabControl1.SelectedTabIndex = 0;
            this.ucTabControl1.Size = new System.Drawing.Size(788, 381);
            this.ucTabControl1.Style = DevComponents.DotNetBar.eTabStripStyle.VS2005;
            this.ucTabControl1.TabIndex = 0;
            this.ucTabControl1.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            this.ucTabControl1.Tabs.Add(this.tiMainBrand);
            this.ucTabControl1.Tabs.Add(this.tiMainSeries);
            this.ucTabControl1.Tabs.Add(this.tiMainPackaging);
            this.ucTabControl1.Text = "ucTabControl1";
            // 
            // tcpMainBrand
            // 
            this.tcpMainBrand.Controls.Add(this.plMainBrandContent);
            this.tcpMainBrand.Controls.Add(this.plMainBrandTop);
            this.tcpMainBrand.Controls.Add(this.plMainBrandButtom);
            this.tcpMainBrand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcpMainBrand.Location = new System.Drawing.Point(0, 25);
            this.tcpMainBrand.Name = "tcpMainBrand";
            this.tcpMainBrand.Padding = new System.Windows.Forms.Padding(1);
            this.tcpMainBrand.Size = new System.Drawing.Size(788, 356);
            this.tcpMainBrand.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(242)))), ((int)(((byte)(232)))));
            this.tcpMainBrand.Style.BackColor2.Color = System.Drawing.Color.White;
            this.tcpMainBrand.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tcpMainBrand.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(168)))), ((int)(((byte)(153)))));
            this.tcpMainBrand.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right)
                        | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tcpMainBrand.Style.GradientAngle = 90;
            this.tcpMainBrand.TabIndex = 2;
            this.tcpMainBrand.TabItem = this.tiMainBrand;
            // 
            // plMainBrandContent
            // 
            this.plMainBrandContent.BackColor = System.Drawing.Color.Transparent;
            this.plMainBrandContent.Controls.Add(this.dgvMainBrand);
            this.plMainBrandContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plMainBrandContent.Location = new System.Drawing.Point(1, 31);
            this.plMainBrandContent.Name = "plMainBrandContent";
            this.plMainBrandContent.Size = new System.Drawing.Size(786, 294);
            this.plMainBrandContent.TabIndex = 2;
            // 
            // dgvMainBrand
            // 
            this.dgvMainBrand.AllowUserToAddRows = false;
            this.dgvMainBrand.AllowUserToDeleteRows = false;
            this.dgvMainBrand.AllowUserToOrderColumns = true;
            this.dgvMainBrand.BackgroundColor = System.Drawing.Color.White;
            this.dgvMainBrand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMainBrand.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMainBrand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMainBrand.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvMainBrand.HighlightSelectedColumnHeaders = false;
            this.dgvMainBrand.Location = new System.Drawing.Point(0, 0);
            this.dgvMainBrand.Name = "dgvMainBrand";
            this.dgvMainBrand.PaintEnhancedSelection = false;
            this.dgvMainBrand.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvMainBrand.RowTemplate.Height = 23;
            this.dgvMainBrand.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMainBrand.SelectAllSignVisible = false;
            this.dgvMainBrand.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvMainBrand.Size = new System.Drawing.Size(786, 294);
            this.dgvMainBrand.TabIndex = 0;
            // 
            // plMainBrandTop
            // 
            this.plMainBrandTop.BackColor = System.Drawing.Color.Transparent;
            this.plMainBrandTop.Controls.Add(this.ucPanel7);
            this.plMainBrandTop.Controls.Add(this.ucPanel8);
            this.plMainBrandTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.plMainBrandTop.Location = new System.Drawing.Point(1, 1);
            this.plMainBrandTop.Name = "plMainBrandTop";
            this.plMainBrandTop.Size = new System.Drawing.Size(786, 30);
            this.plMainBrandTop.TabIndex = 1;
            // 
            // ucPanel7
            // 
            this.ucPanel7.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPanel7.Location = new System.Drawing.Point(596, 0);
            this.ucPanel7.Name = "ucPanel7";
            this.ucPanel7.Size = new System.Drawing.Size(190, 30);
            this.ucPanel7.TabIndex = 1;
            // 
            // ucPanel8
            // 
            this.ucPanel8.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel8.Controls.Add(this.btnSearchMainBrand);
            this.ucPanel8.Controls.Add(this.txtMainBrand);
            this.ucPanel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.ucPanel8.Location = new System.Drawing.Point(0, 0);
            this.ucPanel8.Name = "ucPanel8";
            this.ucPanel8.Size = new System.Drawing.Size(596, 30);
            this.ucPanel8.TabIndex = 0;
            // 
            // btnSearchMainBrand
            // 
            this.btnSearchMainBrand.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSearchMainBrand.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSearchMainBrand.Image = global::ZNLCRM.Controls.Properties.Resources.search;
            this.btnSearchMainBrand.Location = new System.Drawing.Point(223, 2);
            this.btnSearchMainBrand.Name = "btnSearchMainBrand";
            this.btnSearchMainBrand.Size = new System.Drawing.Size(75, 23);
            this.btnSearchMainBrand.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSearchMainBrand.TabIndex = 2;
            this.btnSearchMainBrand.Text = "搜索";
            // 
            // txtMainBrand
            // 
            // 
            // 
            // 
            this.txtMainBrand.Border.Class = "TextBoxBorder";
            this.txtMainBrand.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMainBrand.EnterToNextControl = false;
            this.txtMainBrand.Location = new System.Drawing.Point(35, 4);
            this.txtMainBrand.Name = "txtMainBrand";
            this.txtMainBrand.Size = new System.Drawing.Size(182, 21);
            this.txtMainBrand.TabIndex = 1;
            this.txtMainBrand.WatermarkText = "请输入经营品牌";
            // 
            // plMainBrandButtom
            // 
            this.plMainBrandButtom.BackColor = System.Drawing.Color.Transparent;
            this.plMainBrandButtom.Controls.Add(this.ucPgMainBrand);
            this.plMainBrandButtom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.plMainBrandButtom.Location = new System.Drawing.Point(1, 325);
            this.plMainBrandButtom.Name = "plMainBrandButtom";
            this.plMainBrandButtom.Size = new System.Drawing.Size(786, 30);
            this.plMainBrandButtom.TabIndex = 3;
            // 
            // ucPgMainBrand
            // 
            this.ucPgMainBrand.BackColor = System.Drawing.Color.Transparent;
            this.ucPgMainBrand.Location = new System.Drawing.Point(565, 7);
            this.ucPgMainBrand.Name = "ucPgMainBrand";
            this.ucPgMainBrand.RecordCount = 0;
            this.ucPgMainBrand.Size = new System.Drawing.Size(203, 16);
            this.ucPgMainBrand.TabIndex = 0;
            // 
            // tiMainBrand
            // 
            this.tiMainBrand.AttachedControl = this.tcpMainBrand;
            this.tiMainBrand.Name = "tiMainBrand";
            this.tiMainBrand.Text = "经营品牌";
            // 
            // tcpMainSeries
            // 
            this.tcpMainSeries.Controls.Add(this.plMainSeriesButtom);
            this.tcpMainSeries.Controls.Add(this.plMainSeriesContent);
            this.tcpMainSeries.Controls.Add(this.plMainSeriesTop);
            this.tcpMainSeries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcpMainSeries.Location = new System.Drawing.Point(0, 25);
            this.tcpMainSeries.Name = "tcpMainSeries";
            this.tcpMainSeries.Padding = new System.Windows.Forms.Padding(1);
            this.tcpMainSeries.Size = new System.Drawing.Size(788, 356);
            this.tcpMainSeries.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(242)))), ((int)(((byte)(232)))));
            this.tcpMainSeries.Style.BackColor2.Color = System.Drawing.Color.White;
            this.tcpMainSeries.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tcpMainSeries.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(168)))), ((int)(((byte)(153)))));
            this.tcpMainSeries.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right)
                        | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tcpMainSeries.Style.GradientAngle = 90;
            this.tcpMainSeries.TabIndex = 3;
            this.tcpMainSeries.TabItem = this.tiMainSeries;
            // 
            // plMainSeriesButtom
            // 
            this.plMainSeriesButtom.BackColor = System.Drawing.Color.Transparent;
            this.plMainSeriesButtom.Controls.Add(this.ucPgMainSeries);
            this.plMainSeriesButtom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.plMainSeriesButtom.Location = new System.Drawing.Point(1, 325);
            this.plMainSeriesButtom.Name = "plMainSeriesButtom";
            this.plMainSeriesButtom.Size = new System.Drawing.Size(786, 30);
            this.plMainSeriesButtom.TabIndex = 4;
            // 
            // ucPgMainSeries
            // 
            this.ucPgMainSeries.BackColor = System.Drawing.Color.Transparent;
            this.ucPgMainSeries.Location = new System.Drawing.Point(565, 6);
            this.ucPgMainSeries.Name = "ucPgMainSeries";
            this.ucPgMainSeries.RecordCount = 0;
            this.ucPgMainSeries.Size = new System.Drawing.Size(203, 16);
            this.ucPgMainSeries.TabIndex = 0;
            // 
            // plMainSeriesContent
            // 
            this.plMainSeriesContent.BackColor = System.Drawing.Color.Transparent;
            this.plMainSeriesContent.Controls.Add(this.dgvMainSeries);
            this.plMainSeriesContent.Location = new System.Drawing.Point(1, 37);
            this.plMainSeriesContent.Name = "plMainSeriesContent";
            this.plMainSeriesContent.Size = new System.Drawing.Size(786, 282);
            this.plMainSeriesContent.TabIndex = 3;
            // 
            // dgvMainSeries
            // 
            this.dgvMainSeries.AllowUserToAddRows = false;
            this.dgvMainSeries.AllowUserToDeleteRows = false;
            this.dgvMainSeries.AllowUserToOrderColumns = true;
            this.dgvMainSeries.BackgroundColor = System.Drawing.Color.White;
            this.dgvMainSeries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMainSeries.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMainSeries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMainSeries.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvMainSeries.HighlightSelectedColumnHeaders = false;
            this.dgvMainSeries.Location = new System.Drawing.Point(0, 0);
            this.dgvMainSeries.Name = "dgvMainSeries";
            this.dgvMainSeries.PaintEnhancedSelection = false;
            this.dgvMainSeries.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvMainSeries.RowTemplate.Height = 23;
            this.dgvMainSeries.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMainSeries.SelectAllSignVisible = false;
            this.dgvMainSeries.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvMainSeries.Size = new System.Drawing.Size(786, 282);
            this.dgvMainSeries.TabIndex = 0;
            // 
            // plMainSeriesTop
            // 
            this.plMainSeriesTop.BackColor = System.Drawing.Color.Transparent;
            this.plMainSeriesTop.Controls.Add(this.ucPanel12);
            this.plMainSeriesTop.Controls.Add(this.ucPanel13);
            this.plMainSeriesTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.plMainSeriesTop.Location = new System.Drawing.Point(1, 1);
            this.plMainSeriesTop.Name = "plMainSeriesTop";
            this.plMainSeriesTop.Size = new System.Drawing.Size(786, 30);
            this.plMainSeriesTop.TabIndex = 2;
            // 
            // ucPanel12
            // 
            this.ucPanel12.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPanel12.Location = new System.Drawing.Point(596, 0);
            this.ucPanel12.Name = "ucPanel12";
            this.ucPanel12.Size = new System.Drawing.Size(190, 30);
            this.ucPanel12.TabIndex = 1;
            // 
            // ucPanel13
            // 
            this.ucPanel13.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel13.Controls.Add(this.btnSearchMainSeries);
            this.ucPanel13.Controls.Add(this.txtMainSeries);
            this.ucPanel13.Dock = System.Windows.Forms.DockStyle.Left;
            this.ucPanel13.Location = new System.Drawing.Point(0, 0);
            this.ucPanel13.Name = "ucPanel13";
            this.ucPanel13.Size = new System.Drawing.Size(596, 30);
            this.ucPanel13.TabIndex = 0;
            // 
            // btnSearchMainSeries
            // 
            this.btnSearchMainSeries.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSearchMainSeries.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSearchMainSeries.Image = global::ZNLCRM.Controls.Properties.Resources.search;
            this.btnSearchMainSeries.Location = new System.Drawing.Point(223, 3);
            this.btnSearchMainSeries.Name = "btnSearchMainSeries";
            this.btnSearchMainSeries.Size = new System.Drawing.Size(75, 23);
            this.btnSearchMainSeries.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSearchMainSeries.TabIndex = 2;
            this.btnSearchMainSeries.Text = "搜索";
            // 
            // txtMainSeries
            // 
            // 
            // 
            // 
            this.txtMainSeries.Border.Class = "TextBoxBorder";
            this.txtMainSeries.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMainSeries.EnterToNextControl = false;
            this.txtMainSeries.Location = new System.Drawing.Point(35, 5);
            this.txtMainSeries.Name = "txtMainSeries";
            this.txtMainSeries.Size = new System.Drawing.Size(182, 21);
            this.txtMainSeries.TabIndex = 1;
            this.txtMainSeries.WatermarkText = "请输入经营系列";
            // 
            // tiMainSeries
            // 
            this.tiMainSeries.AttachedControl = this.tcpMainSeries;
            this.tiMainSeries.Name = "tiMainSeries";
            this.tiMainSeries.Text = "经营系列";
            // 
            // tcpMainPackaging
            // 
            this.tcpMainPackaging.Controls.Add(this.plMainPackagingButtom);
            this.tcpMainPackaging.Controls.Add(this.plMainPackagingContent);
            this.tcpMainPackaging.Controls.Add(this.plMainPackagingTop);
            this.tcpMainPackaging.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcpMainPackaging.Location = new System.Drawing.Point(0, 25);
            this.tcpMainPackaging.Name = "tcpMainPackaging";
            this.tcpMainPackaging.Padding = new System.Windows.Forms.Padding(1);
            this.tcpMainPackaging.Size = new System.Drawing.Size(788, 356);
            this.tcpMainPackaging.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(242)))), ((int)(((byte)(232)))));
            this.tcpMainPackaging.Style.BackColor2.Color = System.Drawing.Color.White;
            this.tcpMainPackaging.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tcpMainPackaging.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(168)))), ((int)(((byte)(153)))));
            this.tcpMainPackaging.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right)
                        | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tcpMainPackaging.Style.GradientAngle = 90;
            this.tcpMainPackaging.TabIndex = 4;
            this.tcpMainPackaging.TabItem = this.tiMainPackaging;
            // 
            // plMainPackagingButtom
            // 
            this.plMainPackagingButtom.BackColor = System.Drawing.Color.Transparent;
            this.plMainPackagingButtom.Controls.Add(this.ucPgMainPackaging);
            this.plMainPackagingButtom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.plMainPackagingButtom.Location = new System.Drawing.Point(1, 325);
            this.plMainPackagingButtom.Name = "plMainPackagingButtom";
            this.plMainPackagingButtom.Size = new System.Drawing.Size(786, 30);
            this.plMainPackagingButtom.TabIndex = 5;
            // 
            // ucPgMainPackaging
            // 
            this.ucPgMainPackaging.BackColor = System.Drawing.Color.Transparent;
            this.ucPgMainPackaging.Location = new System.Drawing.Point(565, 7);
            this.ucPgMainPackaging.Name = "ucPgMainPackaging";
            this.ucPgMainPackaging.RecordCount = 0;
            this.ucPgMainPackaging.Size = new System.Drawing.Size(203, 16);
            this.ucPgMainPackaging.TabIndex = 0;
            // 
            // plMainPackagingContent
            // 
            this.plMainPackagingContent.BackColor = System.Drawing.Color.Transparent;
            this.plMainPackagingContent.Controls.Add(this.dgvMainPackaging);
            this.plMainPackagingContent.Location = new System.Drawing.Point(1, 37);
            this.plMainPackagingContent.Name = "plMainPackagingContent";
            this.plMainPackagingContent.Size = new System.Drawing.Size(786, 282);
            this.plMainPackagingContent.TabIndex = 4;
            // 
            // dgvMainPackaging
            // 
            this.dgvMainPackaging.AllowUserToAddRows = false;
            this.dgvMainPackaging.AllowUserToDeleteRows = false;
            this.dgvMainPackaging.AllowUserToOrderColumns = true;
            this.dgvMainPackaging.BackgroundColor = System.Drawing.Color.White;
            this.dgvMainPackaging.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMainPackaging.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMainPackaging.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMainPackaging.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvMainPackaging.HighlightSelectedColumnHeaders = false;
            this.dgvMainPackaging.Location = new System.Drawing.Point(0, 0);
            this.dgvMainPackaging.Name = "dgvMainPackaging";
            this.dgvMainPackaging.PaintEnhancedSelection = false;
            this.dgvMainPackaging.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvMainPackaging.RowTemplate.Height = 23;
            this.dgvMainPackaging.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMainPackaging.SelectAllSignVisible = false;
            this.dgvMainPackaging.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvMainPackaging.Size = new System.Drawing.Size(786, 282);
            this.dgvMainPackaging.TabIndex = 0;
            // 
            // plMainPackagingTop
            // 
            this.plMainPackagingTop.BackColor = System.Drawing.Color.Transparent;
            this.plMainPackagingTop.Controls.Add(this.ucPanel17);
            this.plMainPackagingTop.Controls.Add(this.ucPanel18);
            this.plMainPackagingTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.plMainPackagingTop.Location = new System.Drawing.Point(1, 1);
            this.plMainPackagingTop.Name = "plMainPackagingTop";
            this.plMainPackagingTop.Size = new System.Drawing.Size(786, 30);
            this.plMainPackagingTop.TabIndex = 2;
            // 
            // ucPanel17
            // 
            this.ucPanel17.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPanel17.Location = new System.Drawing.Point(596, 0);
            this.ucPanel17.Name = "ucPanel17";
            this.ucPanel17.Size = new System.Drawing.Size(190, 30);
            this.ucPanel17.TabIndex = 1;
            // 
            // ucPanel18
            // 
            this.ucPanel18.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel18.Controls.Add(this.btnSearchMainPackaging);
            this.ucPanel18.Controls.Add(this.txtMainPackaging);
            this.ucPanel18.Dock = System.Windows.Forms.DockStyle.Left;
            this.ucPanel18.Location = new System.Drawing.Point(0, 0);
            this.ucPanel18.Name = "ucPanel18";
            this.ucPanel18.Size = new System.Drawing.Size(596, 30);
            this.ucPanel18.TabIndex = 0;
            // 
            // btnSearchMainPackaging
            // 
            this.btnSearchMainPackaging.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSearchMainPackaging.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSearchMainPackaging.Image = global::ZNLCRM.Controls.Properties.Resources.search;
            this.btnSearchMainPackaging.Location = new System.Drawing.Point(218, 2);
            this.btnSearchMainPackaging.Name = "btnSearchMainPackaging";
            this.btnSearchMainPackaging.Size = new System.Drawing.Size(75, 23);
            this.btnSearchMainPackaging.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSearchMainPackaging.TabIndex = 2;
            this.btnSearchMainPackaging.Text = "搜索";
            // 
            // txtMainPackaging
            // 
            // 
            // 
            // 
            this.txtMainPackaging.Border.Class = "TextBoxBorder";
            this.txtMainPackaging.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMainPackaging.EnterToNextControl = false;
            this.txtMainPackaging.Location = new System.Drawing.Point(25, 4);
            this.txtMainPackaging.Name = "txtMainPackaging";
            this.txtMainPackaging.Size = new System.Drawing.Size(182, 21);
            this.txtMainPackaging.TabIndex = 1;
            this.txtMainPackaging.WatermarkText = "请输入主营封装";
            // 
            // tiMainPackaging
            // 
            this.tiMainPackaging.AttachedControl = this.tcpMainPackaging;
            this.tiMainPackaging.Name = "tiMainPackaging";
            this.tiMainPackaging.Text = "主营封装";
            // 
            // UcComAttachedInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ucTabControl1);
            this.Name = "UcComAttachedInfo";
            this.Size = new System.Drawing.Size(788, 381);
            ((System.ComponentModel.ISupportInitialize)(this.ucTabControl1)).EndInit();
            this.ucTabControl1.ResumeLayout(false);
            this.tcpMainBrand.ResumeLayout(false);
            this.plMainBrandContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMainBrand)).EndInit();
            this.plMainBrandTop.ResumeLayout(false);
            this.ucPanel8.ResumeLayout(false);
            this.plMainBrandButtom.ResumeLayout(false);
            this.tcpMainSeries.ResumeLayout(false);
            this.plMainSeriesButtom.ResumeLayout(false);
            this.plMainSeriesContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMainSeries)).EndInit();
            this.plMainSeriesTop.ResumeLayout(false);
            this.ucPanel13.ResumeLayout(false);
            this.tcpMainPackaging.ResumeLayout(false);
            this.plMainPackagingButtom.ResumeLayout(false);
            this.plMainPackagingContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMainPackaging)).EndInit();
            this.plMainPackagingTop.ResumeLayout(false);
            this.ucPanel18.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private UcTabControl ucTabControl1;
        private DevComponents.DotNetBar.TabItem tabItem1;
        private DevComponents.DotNetBar.TabControlPanel tcpMainBrand;
        private DevComponents.DotNetBar.TabItem tiMainBrand;
        private DevComponents.DotNetBar.TabControlPanel tcpMainSeries;
        private DevComponents.DotNetBar.TabItem tiMainSeries;
        private DevComponents.DotNetBar.TabControlPanel tcpMainPackaging;
        private DevComponents.DotNetBar.TabItem tiMainPackaging;
        private UcPanel plMainSeriesButtom;
        private UcPager ucPgMainSeries;
        private UcPanel plMainSeriesContent;
        private UcDataGridView dgvMainSeries;
        private UcPanel plMainSeriesTop;
        private UcPanel ucPanel12;
        private UcPanel ucPanel13;
        private UcButton btnSearchMainSeries;
        private UcTextBox txtMainSeries;
        private UcPanel plMainPackagingButtom;
        private UcPager ucPgMainPackaging;
        private UcPanel plMainPackagingContent;
        private UcDataGridView dgvMainPackaging;
        private UcPanel plMainPackagingTop;
        private UcPanel ucPanel17;
        private UcPanel ucPanel18;
        private UcButton btnSearchMainPackaging;
        private UcTextBox txtMainPackaging;
        private UcPanel plMainBrandContent;
        private UcDataGridView dgvMainBrand;
        private UcPanel plMainBrandTop;
        private UcPanel ucPanel7;
        private UcPanel ucPanel8;
        private UcButton btnSearchMainBrand;
        private UcTextBox txtMainBrand;
        private UcPanel plMainBrandButtom;
        private UcPager ucPgMainBrand;
    }
}
