namespace ZNLCRM.UI.FIN
{
    partial class frmBankAccountManage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ucPanel1 = new ZNLCRM.Controls.UcPanel(this.components);
            this.ucToolStrip1 = new ZNLCRM.Controls.UcToolStrip(this.components);
            this.tsbAddAccount = new System.Windows.Forms.ToolStripButton();
            this.tsbEditAccount = new System.Windows.Forms.ToolStripButton();
            this.tsbDelAccount = new System.Windows.Forms.ToolStripButton();
            this.tsbFrozenAccount = new System.Windows.Forms.ToolStripButton();
            this.ucPanel2 = new ZNLCRM.Controls.UcPanel(this.components);
            this.panelAccount = new ZNLCRM.Controls.UcPanel(this.components);
            this.btnSave = new ZNLCRM.Controls.UcButton(this.components);
            this.btnCancel = new ZNLCRM.Controls.UcButton(this.components);
            this.txtManagerID = new ZNLCRM.Controls.UcTextBox(this.components);
            this.txtCBID = new ZNLCRM.Controls.UcTextBox(this.components);
            this.chkFrozen = new ZNLCRM.Controls.UcCheckBox(this.components);
            this.ucLabel10 = new ZNLCRM.Controls.UcLabel(this.components);
            this.txtRemark = new ZNLCRM.Controls.UcTextBox(this.components);
            this.txtAmount = new ZNLCRM.Controls.UcTextBox(this.components);
            this.txtManagerName = new ZNLCRM.Controls.UcTextBox(this.components);
            this.ucLabel9 = new ZNLCRM.Controls.UcLabel(this.components);
            this.ucLabel8 = new ZNLCRM.Controls.UcLabel(this.components);
            this.ucLabel7 = new ZNLCRM.Controls.UcLabel(this.components);
            this.txtBFax = new ZNLCRM.Controls.UcTextBox(this.components);
            this.txtBTelephone = new ZNLCRM.Controls.UcTextBox(this.components);
            this.ucLabel6 = new ZNLCRM.Controls.UcLabel(this.components);
            this.ucLabel5 = new ZNLCRM.Controls.UcLabel(this.components);
            this.txtBAddress = new ZNLCRM.Controls.UcTextBox(this.components);
            this.cboCurrency = new ZNLCRM.Controls.UcComboBox(this.components);
            this.txtBCode = new ZNLCRM.Controls.UcTextBox(this.components);
            this.txtCBName = new ZNLCRM.Controls.UcTextBox(this.components);
            this.ucLabel4 = new ZNLCRM.Controls.UcLabel(this.components);
            this.ucLabel3 = new ZNLCRM.Controls.UcLabel(this.components);
            this.ucLabel2 = new ZNLCRM.Controls.UcLabel(this.components);
            this.txtCBNo = new ZNLCRM.Controls.UcTextBox(this.components);
            this.ucLabel1 = new ZNLCRM.Controls.UcLabel(this.components);
            this.dgvAccount = new ZNLCRM.Controls.UcDataGridView(this.components);
            this.ucPanel3 = new ZNLCRM.Controls.UcPanel(this.components);
            this.btnSearch = new ZNLCRM.Controls.UcButton(this.components);
            this.txtSCBName = new ZNLCRM.Controls.UcTextBox(this.components);
            this.ucLabelX2 = new ZNLCRM.Controls.UcLabelX(this.components);
            this.txtSCBNo = new ZNLCRM.Controls.UcTextBox(this.components);
            this.ucLabelX1 = new ZNLCRM.Controls.UcLabelX(this.components);
            this.colSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colCBID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCBNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCBName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCurrency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colManagerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ucPanel1.SuspendLayout();
            this.ucToolStrip1.SuspendLayout();
            this.ucPanel2.SuspendLayout();
            this.panelAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
            this.ucPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ucPanel1
            // 
            this.ucPanel1.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel1.Controls.Add(this.ucToolStrip1);
            this.ucPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucPanel1.Location = new System.Drawing.Point(0, 0);
            this.ucPanel1.Name = "ucPanel1";
            this.ucPanel1.Size = new System.Drawing.Size(902, 34);
            this.ucPanel1.TabIndex = 0;
            // 
            // ucToolStrip1
            // 
            this.ucToolStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ucToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAddAccount,
            this.tsbEditAccount,
            this.tsbDelAccount,
            this.tsbFrozenAccount});
            this.ucToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.ucToolStrip1.Name = "ucToolStrip1";
            this.ucToolStrip1.Padding = new System.Windows.Forms.Padding(5);
            this.ucToolStrip1.Size = new System.Drawing.Size(902, 34);
            this.ucToolStrip1.TabIndex = 0;
            this.ucToolStrip1.Text = "ucToolStrip1";
            this.ucToolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ucToolStrip1_ItemClicked);
            // 
            // tsbAddAccount
            // 
            this.tsbAddAccount.Image = global::ZNLCRM.UI.Properties.Resources.add_1;
            this.tsbAddAccount.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddAccount.Name = "tsbAddAccount";
            this.tsbAddAccount.Size = new System.Drawing.Size(76, 21);
            this.tsbAddAccount.Text = "添加账号";
            this.tsbAddAccount.Click += new System.EventHandler(this.tsbAddAccount_Click);
            // 
            // tsbEditAccount
            // 
            this.tsbEditAccount.Image = global::ZNLCRM.UI.Properties.Resources.edit_1;
            this.tsbEditAccount.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditAccount.Name = "tsbEditAccount";
            this.tsbEditAccount.Size = new System.Drawing.Size(76, 21);
            this.tsbEditAccount.Text = "修改账号";
            this.tsbEditAccount.Click += new System.EventHandler(this.tsbEditAccount_Click);
            // 
            // tsbDelAccount
            // 
            this.tsbDelAccount.Image = global::ZNLCRM.UI.Properties.Resources.del_1;
            this.tsbDelAccount.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelAccount.Name = "tsbDelAccount";
            this.tsbDelAccount.Size = new System.Drawing.Size(76, 21);
            this.tsbDelAccount.Text = "删除账号";
            this.tsbDelAccount.Click += new System.EventHandler(this.tsbDelAccount_Click);
            // 
            // tsbFrozenAccount
            // 
            this.tsbFrozenAccount.Image = global::ZNLCRM.UI.Properties.Resources._lock;
            this.tsbFrozenAccount.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFrozenAccount.Name = "tsbFrozenAccount";
            this.tsbFrozenAccount.Size = new System.Drawing.Size(76, 21);
            this.tsbFrozenAccount.Text = "冻结账号";
            this.tsbFrozenAccount.Click += new System.EventHandler(this.tsbFrozenAccount_Click);
            // 
            // ucPanel2
            // 
            this.ucPanel2.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel2.Controls.Add(this.panelAccount);
            this.ucPanel2.Controls.Add(this.dgvAccount);
            this.ucPanel2.Controls.Add(this.ucPanel3);
            this.ucPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPanel2.Location = new System.Drawing.Point(0, 34);
            this.ucPanel2.Name = "ucPanel2";
            this.ucPanel2.Size = new System.Drawing.Size(902, 394);
            this.ucPanel2.TabIndex = 1;
            // 
            // panelAccount
            // 
            this.panelAccount.BackColor = System.Drawing.Color.AliceBlue;
            this.panelAccount.Controls.Add(this.btnSave);
            this.panelAccount.Controls.Add(this.btnCancel);
            this.panelAccount.Controls.Add(this.txtManagerID);
            this.panelAccount.Controls.Add(this.txtCBID);
            this.panelAccount.Controls.Add(this.chkFrozen);
            this.panelAccount.Controls.Add(this.ucLabel10);
            this.panelAccount.Controls.Add(this.txtRemark);
            this.panelAccount.Controls.Add(this.txtAmount);
            this.panelAccount.Controls.Add(this.txtManagerName);
            this.panelAccount.Controls.Add(this.ucLabel9);
            this.panelAccount.Controls.Add(this.ucLabel8);
            this.panelAccount.Controls.Add(this.ucLabel7);
            this.panelAccount.Controls.Add(this.txtBFax);
            this.panelAccount.Controls.Add(this.txtBTelephone);
            this.panelAccount.Controls.Add(this.ucLabel6);
            this.panelAccount.Controls.Add(this.ucLabel5);
            this.panelAccount.Controls.Add(this.txtBAddress);
            this.panelAccount.Controls.Add(this.cboCurrency);
            this.panelAccount.Controls.Add(this.txtBCode);
            this.panelAccount.Controls.Add(this.txtCBName);
            this.panelAccount.Controls.Add(this.ucLabel4);
            this.panelAccount.Controls.Add(this.ucLabel3);
            this.panelAccount.Controls.Add(this.ucLabel2);
            this.panelAccount.Controls.Add(this.txtCBNo);
            this.panelAccount.Controls.Add(this.ucLabel1);
            this.panelAccount.Location = new System.Drawing.Point(37, 106);
            this.panelAccount.Name = "panelAccount";
            this.panelAccount.Size = new System.Drawing.Size(499, 274);
            this.panelAccount.TabIndex = 2;
            this.panelAccount.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Image = global::ZNLCRM.UI.Properties.Resources.save_1;
            this.btnSave.Location = new System.Drawing.Point(154, 233);
            this.btnSave.Name = "btnSave";
            this.btnSave.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlS);
            this.btnSave.Size = new System.Drawing.Size(83, 23);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.btnSave.TabIndex = 24;
            this.btnSave.Text = "保存(S)";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.Image = global::ZNLCRM.UI.Properties.Resources.cancel_1;
            this.btnCancel.Location = new System.Drawing.Point(243, 233);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlC);
            this.btnCancel.Size = new System.Drawing.Size(79, 23);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "取消(C)";
            // 
            // txtManagerID
            // 
            // 
            // 
            // 
            this.txtManagerID.Border.Class = "TextBoxBorder";
            this.txtManagerID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtManagerID.EnterToNextControl = false;
            this.txtManagerID.Location = new System.Drawing.Point(350, 206);
            this.txtManagerID.Name = "txtManagerID";
            this.txtManagerID.ReadOnly = true;
            this.txtManagerID.Size = new System.Drawing.Size(140, 21);
            this.txtManagerID.TabIndex = 22;
            // 
            // txtCBID
            // 
            // 
            // 
            // 
            this.txtCBID.Border.Class = "TextBoxBorder";
            this.txtCBID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCBID.EnterToNextControl = false;
            this.txtCBID.Location = new System.Drawing.Point(204, 206);
            this.txtCBID.Name = "txtCBID";
            this.txtCBID.ReadOnly = true;
            this.txtCBID.Size = new System.Drawing.Size(140, 21);
            this.txtCBID.TabIndex = 21;
            // 
            // chkFrozen
            // 
            // 
            // 
            // 
            this.chkFrozen.BackgroundStyle.Class = "";
            this.chkFrozen.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkFrozen.Location = new System.Drawing.Point(103, 204);
            this.chkFrozen.Name = "chkFrozen";
            this.chkFrozen.Size = new System.Drawing.Size(81, 23);
            this.chkFrozen.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chkFrozen.TabIndex = 20;
            this.chkFrozen.Text = "冻结账号";
            // 
            // ucLabel10
            // 
            this.ucLabel10.AutoSize = true;
            this.ucLabel10.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabel10.ForeColor = System.Drawing.Color.Gray;
            this.ucLabel10.Location = new System.Drawing.Point(54, 179);
            this.ucLabel10.Name = "ucLabel10";
            this.ucLabel10.Size = new System.Drawing.Size(41, 12);
            this.ucLabel10.TabIndex = 19;
            this.ucLabel10.Text = "备注：";
            // 
            // txtRemark
            // 
            // 
            // 
            // 
            this.txtRemark.Border.Class = "TextBoxBorder";
            this.txtRemark.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtRemark.EnterToNextControl = false;
            this.txtRemark.Location = new System.Drawing.Point(103, 177);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(364, 21);
            this.txtRemark.TabIndex = 18;
            // 
            // txtAmount
            // 
            // 
            // 
            // 
            this.txtAmount.Border.Class = "TextBoxBorder";
            this.txtAmount.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtAmount.EnterToNextControl = false;
            this.txtAmount.Location = new System.Drawing.Point(327, 150);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(140, 21);
            this.txtAmount.TabIndex = 17;
            // 
            // txtManagerName
            // 
            // 
            // 
            // 
            this.txtManagerName.Border.Class = "TextBoxBorder";
            this.txtManagerName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtManagerName.ButtonCustom.Visible = true;
            this.txtManagerName.ButtonCustom2.Image = global::ZNLCRM.UI.Properties.Resources.del_6;
            this.txtManagerName.ButtonCustom2.Visible = true;
            this.txtManagerName.EnterToNextControl = false;
            this.txtManagerName.Location = new System.Drawing.Point(103, 150);
            this.txtManagerName.Name = "txtManagerName";
            this.txtManagerName.Size = new System.Drawing.Size(140, 21);
            this.txtManagerName.TabIndex = 16;
            this.txtManagerName.ButtonCustomClick += new System.EventHandler(this.txtManagerName_ButtonCustomClick);
            this.txtManagerName.ButtonCustom2Click += new System.EventHandler(this.txtManagerName_ButtonCustom2Click);
            // 
            // ucLabel9
            // 
            this.ucLabel9.AutoSize = true;
            this.ucLabel9.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabel9.ForeColor = System.Drawing.Color.Gray;
            this.ucLabel9.Location = new System.Drawing.Point(256, 152);
            this.ucLabel9.Name = "ucLabel9";
            this.ucLabel9.Size = new System.Drawing.Size(65, 12);
            this.ucLabel9.TabIndex = 15;
            this.ucLabel9.Text = "账户余额：";
            // 
            // ucLabel8
            // 
            this.ucLabel8.AutoSize = true;
            this.ucLabel8.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabel8.ForeColor = System.Drawing.Color.Gray;
            this.ucLabel8.Location = new System.Drawing.Point(18, 152);
            this.ucLabel8.Name = "ucLabel8";
            this.ucLabel8.Size = new System.Drawing.Size(77, 12);
            this.ucLabel8.TabIndex = 14;
            this.ucLabel8.Text = "账户管理人：";
            // 
            // ucLabel7
            // 
            this.ucLabel7.AutoSize = true;
            this.ucLabel7.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabel7.ForeColor = System.Drawing.Color.Gray;
            this.ucLabel7.Location = new System.Drawing.Point(256, 125);
            this.ucLabel7.Name = "ucLabel7";
            this.ucLabel7.Size = new System.Drawing.Size(65, 12);
            this.ucLabel7.TabIndex = 13;
            this.ucLabel7.Text = "银行传真：";
            // 
            // txtBFax
            // 
            // 
            // 
            // 
            this.txtBFax.Border.Class = "TextBoxBorder";
            this.txtBFax.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtBFax.EnterToNextControl = false;
            this.txtBFax.Location = new System.Drawing.Point(327, 123);
            this.txtBFax.Name = "txtBFax";
            this.txtBFax.Size = new System.Drawing.Size(140, 21);
            this.txtBFax.TabIndex = 12;
            // 
            // txtBTelephone
            // 
            // 
            // 
            // 
            this.txtBTelephone.Border.Class = "TextBoxBorder";
            this.txtBTelephone.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtBTelephone.EnterToNextControl = false;
            this.txtBTelephone.Location = new System.Drawing.Point(103, 123);
            this.txtBTelephone.Name = "txtBTelephone";
            this.txtBTelephone.Size = new System.Drawing.Size(140, 21);
            this.txtBTelephone.TabIndex = 11;
            // 
            // ucLabel6
            // 
            this.ucLabel6.AutoSize = true;
            this.ucLabel6.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabel6.ForeColor = System.Drawing.Color.Gray;
            this.ucLabel6.Location = new System.Drawing.Point(30, 125);
            this.ucLabel6.Name = "ucLabel6";
            this.ucLabel6.Size = new System.Drawing.Size(65, 12);
            this.ucLabel6.TabIndex = 10;
            this.ucLabel6.Text = "银行电话：";
            // 
            // ucLabel5
            // 
            this.ucLabel5.AutoSize = true;
            this.ucLabel5.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabel5.ForeColor = System.Drawing.Color.Gray;
            this.ucLabel5.Location = new System.Drawing.Point(30, 98);
            this.ucLabel5.Name = "ucLabel5";
            this.ucLabel5.Size = new System.Drawing.Size(65, 12);
            this.ucLabel5.TabIndex = 9;
            this.ucLabel5.Text = "银行地址：";
            // 
            // txtBAddress
            // 
            // 
            // 
            // 
            this.txtBAddress.Border.Class = "TextBoxBorder";
            this.txtBAddress.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtBAddress.EnterToNextControl = false;
            this.txtBAddress.Location = new System.Drawing.Point(103, 96);
            this.txtBAddress.Name = "txtBAddress";
            this.txtBAddress.Size = new System.Drawing.Size(364, 21);
            this.txtBAddress.TabIndex = 8;
            // 
            // cboCurrency
            // 
            this.cboCurrency.DisplayMember = "Text";
            this.cboCurrency.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboCurrency.FormattingEnabled = true;
            this.cboCurrency.ItemHeight = 15;
            this.cboCurrency.Location = new System.Drawing.Point(327, 72);
            this.cboCurrency.Name = "cboCurrency";
            this.cboCurrency.Size = new System.Drawing.Size(140, 21);
            this.cboCurrency.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboCurrency.TabIndex = 7;
            // 
            // txtBCode
            // 
            // 
            // 
            // 
            this.txtBCode.Border.Class = "TextBoxBorder";
            this.txtBCode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtBCode.EnterToNextControl = false;
            this.txtBCode.Location = new System.Drawing.Point(103, 69);
            this.txtBCode.Name = "txtBCode";
            this.txtBCode.Size = new System.Drawing.Size(140, 21);
            this.txtBCode.TabIndex = 6;
            // 
            // txtCBName
            // 
            // 
            // 
            // 
            this.txtCBName.Border.Class = "TextBoxBorder";
            this.txtCBName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCBName.EnterToNextControl = false;
            this.txtCBName.Location = new System.Drawing.Point(103, 42);
            this.txtCBName.Name = "txtCBName";
            this.txtCBName.Size = new System.Drawing.Size(364, 21);
            this.txtCBName.TabIndex = 5;
            // 
            // ucLabel4
            // 
            this.ucLabel4.AutoSize = true;
            this.ucLabel4.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabel4.ForeColor = System.Drawing.Color.Gray;
            this.ucLabel4.Location = new System.Drawing.Point(280, 78);
            this.ucLabel4.Name = "ucLabel4";
            this.ucLabel4.Size = new System.Drawing.Size(41, 12);
            this.ucLabel4.TabIndex = 4;
            this.ucLabel4.Text = "币种：";
            // 
            // ucLabel3
            // 
            this.ucLabel3.AutoSize = true;
            this.ucLabel3.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabel3.ForeColor = System.Drawing.Color.Gray;
            this.ucLabel3.Location = new System.Drawing.Point(54, 78);
            this.ucLabel3.Name = "ucLabel3";
            this.ucLabel3.Size = new System.Drawing.Size(41, 12);
            this.ucLabel3.TabIndex = 3;
            this.ucLabel3.Text = "户名：";
            // 
            // ucLabel2
            // 
            this.ucLabel2.AutoSize = true;
            this.ucLabel2.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabel2.ForeColor = System.Drawing.Color.Gray;
            this.ucLabel2.Location = new System.Drawing.Point(42, 51);
            this.ucLabel2.Name = "ucLabel2";
            this.ucLabel2.Size = new System.Drawing.Size(53, 12);
            this.ucLabel2.TabIndex = 2;
            this.ucLabel2.Text = "开户行：";
            // 
            // txtCBNo
            // 
            // 
            // 
            // 
            this.txtCBNo.Border.Class = "TextBoxBorder";
            this.txtCBNo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCBNo.EnterToNextControl = false;
            this.txtCBNo.Location = new System.Drawing.Point(103, 15);
            this.txtCBNo.Name = "txtCBNo";
            this.txtCBNo.Size = new System.Drawing.Size(364, 21);
            this.txtCBNo.TabIndex = 1;
            // 
            // ucLabel1
            // 
            this.ucLabel1.AutoSize = true;
            this.ucLabel1.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabel1.ForeColor = System.Drawing.Color.Gray;
            this.ucLabel1.Location = new System.Drawing.Point(54, 24);
            this.ucLabel1.Name = "ucLabel1";
            this.ucLabel1.Size = new System.Drawing.Size(41, 12);
            this.ucLabel1.TabIndex = 0;
            this.ucLabel1.Text = "卡号：";
            // 
            // dgvAccount
            // 
            this.dgvAccount.AllowUserToAddRows = false;
            this.dgvAccount.AllowUserToDeleteRows = false;
            this.dgvAccount.AllowUserToOrderColumns = true;
            this.dgvAccount.BackgroundColor = System.Drawing.Color.White;
            this.dgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSelect,
            this.colCBID,
            this.colCBNo,
            this.colCBName,
            this.colBCode,
            this.colCurrency,
            this.colManagerName});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAccount.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAccount.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvAccount.HighlightSelectedColumnHeaders = false;
            this.dgvAccount.Location = new System.Drawing.Point(0, 32);
            this.dgvAccount.Name = "dgvAccount";
            this.dgvAccount.PaintEnhancedSelection = false;
            this.dgvAccount.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvAccount.RowTemplate.Height = 23;
            this.dgvAccount.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAccount.SelectAllSignVisible = false;
            this.dgvAccount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvAccount.Size = new System.Drawing.Size(902, 362);
            this.dgvAccount.TabIndex = 1;
            this.dgvAccount.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAccount_RowEnter);
            // 
            // ucPanel3
            // 
            this.ucPanel3.BackColor = System.Drawing.Color.AliceBlue;
            this.ucPanel3.Controls.Add(this.btnSearch);
            this.ucPanel3.Controls.Add(this.txtSCBName);
            this.ucPanel3.Controls.Add(this.ucLabelX2);
            this.ucPanel3.Controls.Add(this.txtSCBNo);
            this.ucPanel3.Controls.Add(this.ucLabelX1);
            this.ucPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucPanel3.Location = new System.Drawing.Point(0, 0);
            this.ucPanel3.Name = "ucPanel3";
            this.ucPanel3.Size = new System.Drawing.Size(902, 32);
            this.ucPanel3.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSearch.Image = global::ZNLCRM.UI.Properties.Resources.search;
            this.btnSearch.Location = new System.Drawing.Point(570, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "搜索";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSCBName
            // 
            // 
            // 
            // 
            this.txtSCBName.Border.Class = "TextBoxBorder";
            this.txtSCBName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSCBName.EnterToNextControl = false;
            this.txtSCBName.Location = new System.Drawing.Point(370, 5);
            this.txtSCBName.Name = "txtSCBName";
            this.txtSCBName.Size = new System.Drawing.Size(181, 21);
            this.txtSCBName.TabIndex = 3;
            // 
            // ucLabelX2
            // 
            // 
            // 
            // 
            this.ucLabelX2.BackgroundStyle.Class = "";
            this.ucLabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ucLabelX2.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabelX2.ForeColor = System.Drawing.Color.Gray;
            this.ucLabelX2.Location = new System.Drawing.Point(289, 5);
            this.ucLabelX2.Name = "ucLabelX2";
            this.ucLabelX2.Size = new System.Drawing.Size(75, 23);
            this.ucLabelX2.TabIndex = 2;
            this.ucLabelX2.Text = "账户名称：";
            // 
            // txtSCBNo
            // 
            // 
            // 
            // 
            this.txtSCBNo.Border.Class = "TextBoxBorder";
            this.txtSCBNo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSCBNo.EnterToNextControl = false;
            this.txtSCBNo.Location = new System.Drawing.Point(93, 5);
            this.txtSCBNo.Name = "txtSCBNo";
            this.txtSCBNo.Size = new System.Drawing.Size(181, 21);
            this.txtSCBNo.TabIndex = 1;
            // 
            // ucLabelX1
            // 
            // 
            // 
            // 
            this.ucLabelX1.BackgroundStyle.Class = "";
            this.ucLabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ucLabelX1.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabelX1.ForeColor = System.Drawing.Color.Gray;
            this.ucLabelX1.Location = new System.Drawing.Point(12, 5);
            this.ucLabelX1.Name = "ucLabelX1";
            this.ucLabelX1.Size = new System.Drawing.Size(75, 23);
            this.ucLabelX1.TabIndex = 0;
            this.ucLabelX1.Text = "银行卡号：";
            // 
            // colSelect
            // 
            this.colSelect.HeaderText = "";
            this.colSelect.Name = "colSelect";
            this.colSelect.Width = 30;
            // 
            // colCBID
            // 
            this.colCBID.DataPropertyName = "CBID";
            this.colCBID.HeaderText = "账号ID";
            this.colCBID.Name = "colCBID";
            this.colCBID.Visible = false;
            // 
            // colCBNo
            // 
            this.colCBNo.DataPropertyName = "CBNo";
            this.colCBNo.HeaderText = "银行卡号";
            this.colCBNo.Name = "colCBNo";
            this.colCBNo.ReadOnly = true;
            this.colCBNo.Width = 150;
            // 
            // colCBName
            // 
            this.colCBName.DataPropertyName = "CBName";
            this.colCBName.HeaderText = "开户行";
            this.colCBName.Name = "colCBName";
            this.colCBName.ReadOnly = true;
            this.colCBName.Width = 150;
            // 
            // colBCode
            // 
            this.colBCode.DataPropertyName = "BCode";
            this.colBCode.HeaderText = "户名";
            this.colBCode.Name = "colBCode";
            this.colBCode.ReadOnly = true;
            // 
            // colCurrency
            // 
            this.colCurrency.DataPropertyName = "Currency";
            this.colCurrency.HeaderText = "账号币种";
            this.colCurrency.Name = "colCurrency";
            this.colCurrency.ReadOnly = true;
            this.colCurrency.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colCurrency.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colManagerName
            // 
            this.colManagerName.DataPropertyName = "ManagerName";
            this.colManagerName.HeaderText = "账户管理人";
            this.colManagerName.Name = "colManagerName";
            this.colManagerName.ReadOnly = true;
            this.colManagerName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // frmBankAccountManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 428);
            this.Controls.Add(this.ucPanel2);
            this.Controls.Add(this.ucPanel1);
            this.Name = "frmBankAccountManage";
            this.Text = "银行账户管理";
            this.Load += new System.EventHandler(this.frmBankAccountManage_Load);
            this.ucPanel1.ResumeLayout(false);
            this.ucPanel1.PerformLayout();
            this.ucToolStrip1.ResumeLayout(false);
            this.ucToolStrip1.PerformLayout();
            this.ucPanel2.ResumeLayout(false);
            this.panelAccount.ResumeLayout(false);
            this.panelAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
            this.ucPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.UcPanel ucPanel1;
        private Controls.UcToolStrip ucToolStrip1;
        private System.Windows.Forms.ToolStripButton tsbAddAccount;
        private System.Windows.Forms.ToolStripButton tsbEditAccount;
        private System.Windows.Forms.ToolStripButton tsbDelAccount;
        private System.Windows.Forms.ToolStripButton tsbFrozenAccount;
        private Controls.UcPanel ucPanel2;
        private Controls.UcDataGridView dgvAccount;
        private Controls.UcPanel ucPanel3;
        private Controls.UcButton btnSearch;
        private Controls.UcTextBox txtSCBName;
        private Controls.UcLabelX ucLabelX2;
        private Controls.UcTextBox txtSCBNo;
        private Controls.UcLabelX ucLabelX1;
        private Controls.UcPanel panelAccount;
        private Controls.UcTextBox txtCBNo;
        private Controls.UcLabel ucLabel1;
        private Controls.UcTextBox txtManagerName;
        private Controls.UcLabel ucLabel9;
        private Controls.UcLabel ucLabel8;
        private Controls.UcLabel ucLabel7;
        private Controls.UcTextBox txtBFax;
        private Controls.UcTextBox txtBTelephone;
        private Controls.UcLabel ucLabel6;
        private Controls.UcLabel ucLabel5;
        private Controls.UcTextBox txtBAddress;
        private Controls.UcComboBox cboCurrency;
        private Controls.UcTextBox txtBCode;
        private Controls.UcTextBox txtCBName;
        private Controls.UcLabel ucLabel4;
        private Controls.UcLabel ucLabel3;
        private Controls.UcLabel ucLabel2;
        private Controls.UcLabel ucLabel10;
        private Controls.UcTextBox txtRemark;
        private Controls.UcTextBox txtAmount;
        private Controls.UcTextBox txtManagerID;
        private Controls.UcTextBox txtCBID;
        private Controls.UcCheckBox chkFrozen;
        private Controls.UcButton btnSave;
        private Controls.UcButton btnCancel;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCBID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCBNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCBName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCurrency;
        private System.Windows.Forms.DataGridViewTextBoxColumn colManagerName;
    }
}