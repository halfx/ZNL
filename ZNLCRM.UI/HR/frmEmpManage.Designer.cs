namespace ZNLCRM.UI.HR
{
    partial class frmEmpManage
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
            this.cmsOrg = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiEditOrg = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDelOrg = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAddDept = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEditDept = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDelDept = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsiAddEmp = new System.Windows.Forms.ToolStripMenuItem();
            this.ucPanel1 = new ZNLCRM.Controls.UcPanel(this.components);
            this.ucPanel3 = new ZNLCRM.Controls.UcPanel(this.components);
            this.grpOrg = new ZNLCRM.Controls.UcPanel(this.components);
            this.txtOrgGuID = new ZNLCRM.Controls.UcTextBox(this.components);
            this.ucLabel5 = new ZNLCRM.Controls.UcLabel(this.components);
            this.txtOrgID = new ZNLCRM.Controls.UcTextBox(this.components);
            this.btnSaveOrg = new ZNLCRM.Controls.UcButton(this.components);
            this.ucLabel6 = new ZNLCRM.Controls.UcLabel(this.components);
            this.btnCancelOrg = new ZNLCRM.Controls.UcButton(this.components);
            this.txtOrgNo = new ZNLCRM.Controls.UcTextBox(this.components);
            this.txtOrgName = new ZNLCRM.Controls.UcTextBox(this.components);
            this.grpDept = new ZNLCRM.Controls.UcPanel(this.components);
            this.txtDeptOrgID = new ZNLCRM.Controls.UcTextBox(this.components);
            this.txtDeptOrgGuID = new ZNLCRM.Controls.UcTextBox(this.components);
            this.ucLabel3 = new ZNLCRM.Controls.UcLabel(this.components);
            this.txtParentID = new ZNLCRM.Controls.UcTextBox(this.components);
            this.btnSaveDept = new ZNLCRM.Controls.UcButton(this.components);
            this.txtDeptID = new ZNLCRM.Controls.UcTextBox(this.components);
            this.btnCancelDept = new ZNLCRM.Controls.UcButton(this.components);
            this.ucLabel1 = new ZNLCRM.Controls.UcLabel(this.components);
            this.txtParentDeptName = new ZNLCRM.Controls.UcTextBox(this.components);
            this.txtDeptName = new ZNLCRM.Controls.UcTextBox(this.components);
            this.ucLabel4 = new ZNLCRM.Controls.UcLabel(this.components);
            this.ucLabel2 = new ZNLCRM.Controls.UcLabel(this.components);
            this.txtDeptOrgName = new ZNLCRM.Controls.UcTextBox(this.components);
            this.txtDeptNo = new ZNLCRM.Controls.UcTextBox(this.components);
            this.dgvEmp = new ZNLCRM.Controls.UcDataGridView(this.components);
            this.colEmpRightBtn = new DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn();
            this.colEmpID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmpGuid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGCompanyID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrgID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDeptID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmpCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBillCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdentityCardNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSex = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colBirthday = new DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn();
            this.colPositionID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colManagerEmpID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSocialSecurityNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colJoinTime = new DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn();
            this.colQuitTime = new DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn();
            this.colTelephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPlaceOfOrigin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMarriage = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colEducation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProfessional = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSpecialty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProbation = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colLaborContract = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colMacAddress = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colHardDiskSN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNeedValidate = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colBasicSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastEditEmpID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastEditTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmpStatus = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colLastSignInDate = new DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn();
            this.colSignInTimes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUseTimeBegin = new DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn();
            this.colUseTimeOver = new DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn();
            this.colAfterTimeForBill = new DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn();
            this.colFamilyAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBakContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBakContactTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProtectedCusCnt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRelationSales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRelationBuyers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsSales = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colIsBuyer = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colIsStockManager = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colTelFax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSkype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DefaultCurreny = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colOcation = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colIsDeleted = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colIsActive = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ucPanel4 = new ZNLCRM.Controls.UcPanel(this.components);
            this.btnEditEmp = new ZNLCRM.Controls.UcButton(this.components);
            this.btnAddEmp = new ZNLCRM.Controls.UcButton(this.components);
            this.ucLabel7 = new ZNLCRM.Controls.UcLabel(this.components);
            this.txtEmpName = new ZNLCRM.Controls.UcTextBox(this.components);
            this.btnSearch = new ZNLCRM.Controls.UcButton(this.components);
            this.ucExpandableSplitter1 = new ZNLCRM.Controls.UcExpandableSplitter(this.components);
            this.ucPanel2 = new ZNLCRM.Controls.UcPanel(this.components);
            this.trOrg = new ZNLCRM.Controls.UcAdTree(this.components);
            this.nodeConnector1 = new DevComponents.AdvTree.NodeConnector();
            this.elementStyle1 = new DevComponents.DotNetBar.ElementStyle();
            this.ucToolStrip1 = new ZNLCRM.Controls.UcToolStrip(this.components);
            this.btnAddOrg = new System.Windows.Forms.ToolStripButton();
            this.btnEditOrg = new System.Windows.Forms.ToolStripButton();
            this.btnDelOrg = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAddDept = new System.Windows.Forms.ToolStripButton();
            this.btnEditDept = new System.Windows.Forms.ToolStripButton();
            this.btnDelDept = new System.Windows.Forms.ToolStripButton();
            this.cmsOrg.SuspendLayout();
            this.ucPanel1.SuspendLayout();
            this.ucPanel3.SuspendLayout();
            this.grpOrg.SuspendLayout();
            this.grpDept.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmp)).BeginInit();
            this.ucPanel4.SuspendLayout();
            this.ucPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trOrg)).BeginInit();
            this.ucToolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmsOrg
            // 
            this.cmsOrg.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEditOrg,
            this.tsmiDelOrg,
            this.tsmiAddDept,
            this.tsmiEditDept,
            this.tsmiDelDept,
            this.tmsiAddEmp});
            this.cmsOrg.Name = "contextMenuStrip1";
            this.cmsOrg.Size = new System.Drawing.Size(125, 136);
            // 
            // tsmiEditOrg
            // 
            this.tsmiEditOrg.Image = global::ZNLCRM.UI.Properties.Resources.edit_1;
            this.tsmiEditOrg.Name = "tsmiEditOrg";
            this.tsmiEditOrg.Size = new System.Drawing.Size(124, 22);
            this.tsmiEditOrg.Text = "修改机构";
            this.tsmiEditOrg.Click += new System.EventHandler(this.tsmiEditOrg_Click);
            // 
            // tsmiDelOrg
            // 
            this.tsmiDelOrg.Image = global::ZNLCRM.UI.Properties.Resources.del_1;
            this.tsmiDelOrg.Name = "tsmiDelOrg";
            this.tsmiDelOrg.Size = new System.Drawing.Size(124, 22);
            this.tsmiDelOrg.Text = "删除机构";
            this.tsmiDelOrg.Click += new System.EventHandler(this.tsmiDelOrg_Click);
            // 
            // tsmiAddDept
            // 
            this.tsmiAddDept.Image = global::ZNLCRM.UI.Properties.Resources.add_2;
            this.tsmiAddDept.Name = "tsmiAddDept";
            this.tsmiAddDept.Size = new System.Drawing.Size(124, 22);
            this.tsmiAddDept.Text = "添加部门";
            this.tsmiAddDept.Click += new System.EventHandler(this.tsmiAddDept_Click);
            // 
            // tsmiEditDept
            // 
            this.tsmiEditDept.Image = global::ZNLCRM.UI.Properties.Resources.edit_2;
            this.tsmiEditDept.Name = "tsmiEditDept";
            this.tsmiEditDept.Size = new System.Drawing.Size(124, 22);
            this.tsmiEditDept.Text = "修改部门";
            this.tsmiEditDept.Click += new System.EventHandler(this.tsmiEditDept_Click);
            // 
            // tsmiDelDept
            // 
            this.tsmiDelDept.Image = global::ZNLCRM.UI.Properties.Resources.del_2;
            this.tsmiDelDept.Name = "tsmiDelDept";
            this.tsmiDelDept.Size = new System.Drawing.Size(124, 22);
            this.tsmiDelDept.Text = "删除部门";
            this.tsmiDelDept.Click += new System.EventHandler(this.tsmiDelDept_Click);
            // 
            // tmsiAddEmp
            // 
            this.tmsiAddEmp.Image = global::ZNLCRM.UI.Properties.Resources.add_3;
            this.tmsiAddEmp.Name = "tmsiAddEmp";
            this.tmsiAddEmp.Size = new System.Drawing.Size(124, 22);
            this.tmsiAddEmp.Text = "添加人员";
            this.tmsiAddEmp.Click += new System.EventHandler(this.tmsiAddEmp_Click);
            // 
            // ucPanel1
            // 
            this.ucPanel1.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel1.Controls.Add(this.ucPanel3);
            this.ucPanel1.Controls.Add(this.ucExpandableSplitter1);
            this.ucPanel1.Controls.Add(this.ucPanel2);
            this.ucPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPanel1.Location = new System.Drawing.Point(0, 36);
            this.ucPanel1.Name = "ucPanel1";
            this.ucPanel1.Size = new System.Drawing.Size(1069, 478);
            this.ucPanel1.TabIndex = 1;
            // 
            // ucPanel3
            // 
            this.ucPanel3.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel3.Controls.Add(this.grpOrg);
            this.ucPanel3.Controls.Add(this.grpDept);
            this.ucPanel3.Controls.Add(this.dgvEmp);
            this.ucPanel3.Controls.Add(this.ucPanel4);
            this.ucPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPanel3.Location = new System.Drawing.Point(203, 0);
            this.ucPanel3.Name = "ucPanel3";
            this.ucPanel3.Size = new System.Drawing.Size(866, 478);
            this.ucPanel3.TabIndex = 1;
            // 
            // grpOrg
            // 
            this.grpOrg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpOrg.AutoSize = true;
            this.grpOrg.BackColor = System.Drawing.Color.Transparent;
            this.grpOrg.Controls.Add(this.txtOrgGuID);
            this.grpOrg.Controls.Add(this.ucLabel5);
            this.grpOrg.Controls.Add(this.txtOrgID);
            this.grpOrg.Controls.Add(this.btnSaveOrg);
            this.grpOrg.Controls.Add(this.ucLabel6);
            this.grpOrg.Controls.Add(this.btnCancelOrg);
            this.grpOrg.Controls.Add(this.txtOrgNo);
            this.grpOrg.Controls.Add(this.txtOrgName);
            this.grpOrg.Location = new System.Drawing.Point(55, 242);
            this.grpOrg.Name = "grpOrg";
            this.grpOrg.Size = new System.Drawing.Size(311, 117);
            this.grpOrg.TabIndex = 4;
            this.grpOrg.Visible = false;
            // 
            // txtOrgGuID
            // 
            // 
            // 
            // 
            this.txtOrgGuID.Border.Class = "TextBoxBorder";
            this.txtOrgGuID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtOrgGuID.EnterToNextControl = false;
            this.txtOrgGuID.Location = new System.Drawing.Point(234, 45);
            this.txtOrgGuID.Name = "txtOrgGuID";
            this.txtOrgGuID.ReadOnly = true;
            this.txtOrgGuID.Size = new System.Drawing.Size(62, 21);
            this.txtOrgGuID.TabIndex = 10;
            this.txtOrgGuID.Visible = false;
            // 
            // ucLabel5
            // 
            this.ucLabel5.AutoSize = true;
            this.ucLabel5.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabel5.ForeColor = System.Drawing.Color.Gray;
            this.ucLabel5.Location = new System.Drawing.Point(3, 19);
            this.ucLabel5.Name = "ucLabel5";
            this.ucLabel5.Size = new System.Drawing.Size(65, 12);
            this.ucLabel5.TabIndex = 6;
            this.ucLabel5.Text = "机构编号：";
            // 
            // txtOrgID
            // 
            // 
            // 
            // 
            this.txtOrgID.Border.Class = "TextBoxBorder";
            this.txtOrgID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtOrgID.EnterToNextControl = false;
            this.txtOrgID.Location = new System.Drawing.Point(233, 15);
            this.txtOrgID.Name = "txtOrgID";
            this.txtOrgID.ReadOnly = true;
            this.txtOrgID.Size = new System.Drawing.Size(62, 21);
            this.txtOrgID.TabIndex = 8;
            this.txtOrgID.Visible = false;
            // 
            // btnSaveOrg
            // 
            this.btnSaveOrg.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSaveOrg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSaveOrg.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSaveOrg.Image = global::ZNLCRM.UI.Properties.Resources.save_1;
            this.btnSaveOrg.Location = new System.Drawing.Point(67, 82);
            this.btnSaveOrg.Name = "btnSaveOrg";
            this.btnSaveOrg.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlS);
            this.btnSaveOrg.Size = new System.Drawing.Size(83, 23);
            this.btnSaveOrg.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.btnSaveOrg.TabIndex = 6;
            this.btnSaveOrg.Text = "保存(S)";
            this.btnSaveOrg.Click += new System.EventHandler(this.btnSaveOrg_Click);
            // 
            // ucLabel6
            // 
            this.ucLabel6.AutoSize = true;
            this.ucLabel6.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabel6.ForeColor = System.Drawing.Color.Gray;
            this.ucLabel6.Location = new System.Drawing.Point(3, 45);
            this.ucLabel6.Name = "ucLabel6";
            this.ucLabel6.Size = new System.Drawing.Size(65, 12);
            this.ucLabel6.TabIndex = 6;
            this.ucLabel6.Text = "机构名称：";
            // 
            // btnCancelOrg
            // 
            this.btnCancelOrg.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancelOrg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelOrg.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancelOrg.Image = global::ZNLCRM.UI.Properties.Resources.cancel_1;
            this.btnCancelOrg.Location = new System.Drawing.Point(156, 82);
            this.btnCancelOrg.Name = "btnCancelOrg";
            this.btnCancelOrg.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlC);
            this.btnCancelOrg.Size = new System.Drawing.Size(79, 23);
            this.btnCancelOrg.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.btnCancelOrg.TabIndex = 6;
            this.btnCancelOrg.Text = "取消(C)";
            this.btnCancelOrg.Click += new System.EventHandler(this.btnCancelOrg_Click);
            // 
            // txtOrgNo
            // 
            // 
            // 
            // 
            this.txtOrgNo.Border.Class = "TextBoxBorder";
            this.txtOrgNo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtOrgNo.EnterToNextControl = false;
            this.txtOrgNo.Location = new System.Drawing.Point(74, 16);
            this.txtOrgNo.Name = "txtOrgNo";
            this.txtOrgNo.Size = new System.Drawing.Size(153, 21);
            this.txtOrgNo.TabIndex = 0;
            // 
            // txtOrgName
            // 
            // 
            // 
            // 
            this.txtOrgName.Border.Class = "TextBoxBorder";
            this.txtOrgName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtOrgName.EnterToNextControl = false;
            this.txtOrgName.Location = new System.Drawing.Point(74, 43);
            this.txtOrgName.Name = "txtOrgName";
            this.txtOrgName.Size = new System.Drawing.Size(153, 21);
            this.txtOrgName.TabIndex = 0;
            // 
            // grpDept
            // 
            this.grpDept.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpDept.BackColor = System.Drawing.Color.Transparent;
            this.grpDept.Controls.Add(this.txtDeptOrgID);
            this.grpDept.Controls.Add(this.txtDeptOrgGuID);
            this.grpDept.Controls.Add(this.ucLabel3);
            this.grpDept.Controls.Add(this.txtParentID);
            this.grpDept.Controls.Add(this.btnSaveDept);
            this.grpDept.Controls.Add(this.txtDeptID);
            this.grpDept.Controls.Add(this.btnCancelDept);
            this.grpDept.Controls.Add(this.ucLabel1);
            this.grpDept.Controls.Add(this.txtParentDeptName);
            this.grpDept.Controls.Add(this.txtDeptName);
            this.grpDept.Controls.Add(this.ucLabel4);
            this.grpDept.Controls.Add(this.ucLabel2);
            this.grpDept.Controls.Add(this.txtDeptOrgName);
            this.grpDept.Controls.Add(this.txtDeptNo);
            this.grpDept.Location = new System.Drawing.Point(474, 243);
            this.grpDept.Name = "grpDept";
            this.grpDept.Size = new System.Drawing.Size(311, 178);
            this.grpDept.TabIndex = 5;
            this.grpDept.Visible = false;
            // 
            // txtDeptOrgID
            // 
            // 
            // 
            // 
            this.txtDeptOrgID.Border.Class = "TextBoxBorder";
            this.txtDeptOrgID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDeptOrgID.EnterToNextControl = false;
            this.txtDeptOrgID.Location = new System.Drawing.Point(233, 99);
            this.txtDeptOrgID.Name = "txtDeptOrgID";
            this.txtDeptOrgID.ReadOnly = true;
            this.txtDeptOrgID.Size = new System.Drawing.Size(62, 21);
            this.txtDeptOrgID.TabIndex = 12;
            this.txtDeptOrgID.Visible = false;
            // 
            // txtDeptOrgGuID
            // 
            // 
            // 
            // 
            this.txtDeptOrgGuID.Border.Class = "TextBoxBorder";
            this.txtDeptOrgGuID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDeptOrgGuID.EnterToNextControl = false;
            this.txtDeptOrgGuID.Location = new System.Drawing.Point(233, 73);
            this.txtDeptOrgGuID.Name = "txtDeptOrgGuID";
            this.txtDeptOrgGuID.ReadOnly = true;
            this.txtDeptOrgGuID.Size = new System.Drawing.Size(62, 21);
            this.txtDeptOrgGuID.TabIndex = 11;
            this.txtDeptOrgGuID.Visible = false;
            // 
            // ucLabel3
            // 
            this.ucLabel3.AutoSize = true;
            this.ucLabel3.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabel3.ForeColor = System.Drawing.Color.Gray;
            this.ucLabel3.Location = new System.Drawing.Point(3, 20);
            this.ucLabel3.Name = "ucLabel3";
            this.ucLabel3.Size = new System.Drawing.Size(65, 12);
            this.ucLabel3.TabIndex = 6;
            this.ucLabel3.Text = "所属机构：";
            // 
            // txtParentID
            // 
            // 
            // 
            // 
            this.txtParentID.Border.Class = "TextBoxBorder";
            this.txtParentID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtParentID.EnterToNextControl = false;
            this.txtParentID.Location = new System.Drawing.Point(233, 46);
            this.txtParentID.Name = "txtParentID";
            this.txtParentID.ReadOnly = true;
            this.txtParentID.Size = new System.Drawing.Size(62, 21);
            this.txtParentID.TabIndex = 8;
            this.txtParentID.Visible = false;
            // 
            // btnSaveDept
            // 
            this.btnSaveDept.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSaveDept.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSaveDept.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSaveDept.Image = global::ZNLCRM.UI.Properties.Resources.save_1;
            this.btnSaveDept.Location = new System.Drawing.Point(72, 137);
            this.btnSaveDept.Name = "btnSaveDept";
            this.btnSaveDept.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlS);
            this.btnSaveDept.Size = new System.Drawing.Size(83, 23);
            this.btnSaveDept.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.btnSaveDept.TabIndex = 6;
            this.btnSaveDept.Text = "保存(S)";
            this.btnSaveDept.Click += new System.EventHandler(this.btnSaveDept_Click);
            // 
            // txtDeptID
            // 
            // 
            // 
            // 
            this.txtDeptID.Border.Class = "TextBoxBorder";
            this.txtDeptID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDeptID.EnterToNextControl = false;
            this.txtDeptID.Location = new System.Drawing.Point(233, 18);
            this.txtDeptID.Name = "txtDeptID";
            this.txtDeptID.ReadOnly = true;
            this.txtDeptID.Size = new System.Drawing.Size(62, 21);
            this.txtDeptID.TabIndex = 7;
            this.txtDeptID.Visible = false;
            // 
            // btnCancelDept
            // 
            this.btnCancelDept.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancelDept.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelDept.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancelDept.Image = global::ZNLCRM.UI.Properties.Resources.cancel_1;
            this.btnCancelDept.Location = new System.Drawing.Point(161, 137);
            this.btnCancelDept.Name = "btnCancelDept";
            this.btnCancelDept.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlC);
            this.btnCancelDept.Size = new System.Drawing.Size(86, 23);
            this.btnCancelDept.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.btnCancelDept.TabIndex = 6;
            this.btnCancelDept.Text = "取消(C)";
            this.btnCancelDept.Click += new System.EventHandler(this.btnCancelDept_Click);
            // 
            // ucLabel1
            // 
            this.ucLabel1.AutoSize = true;
            this.ucLabel1.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabel1.ForeColor = System.Drawing.Color.Gray;
            this.ucLabel1.Location = new System.Drawing.Point(3, 104);
            this.ucLabel1.Name = "ucLabel1";
            this.ucLabel1.Size = new System.Drawing.Size(65, 12);
            this.ucLabel1.TabIndex = 6;
            this.ucLabel1.Text = "部门名称：";
            // 
            // txtParentDeptName
            // 
            // 
            // 
            // 
            this.txtParentDeptName.Border.Class = "TextBoxBorder";
            this.txtParentDeptName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtParentDeptName.EnterToNextControl = false;
            this.txtParentDeptName.Location = new System.Drawing.Point(74, 44);
            this.txtParentDeptName.Name = "txtParentDeptName";
            this.txtParentDeptName.ReadOnly = true;
            this.txtParentDeptName.Size = new System.Drawing.Size(153, 21);
            this.txtParentDeptName.TabIndex = 0;
            // 
            // txtDeptName
            // 
            // 
            // 
            // 
            this.txtDeptName.Border.Class = "TextBoxBorder";
            this.txtDeptName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDeptName.EnterToNextControl = false;
            this.txtDeptName.Location = new System.Drawing.Point(74, 100);
            this.txtDeptName.Name = "txtDeptName";
            this.txtDeptName.Size = new System.Drawing.Size(153, 21);
            this.txtDeptName.TabIndex = 0;
            // 
            // ucLabel4
            // 
            this.ucLabel4.AutoSize = true;
            this.ucLabel4.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabel4.ForeColor = System.Drawing.Color.Gray;
            this.ucLabel4.Location = new System.Drawing.Point(3, 46);
            this.ucLabel4.Name = "ucLabel4";
            this.ucLabel4.Size = new System.Drawing.Size(65, 12);
            this.ucLabel4.TabIndex = 6;
            this.ucLabel4.Text = "所属部门：";
            // 
            // ucLabel2
            // 
            this.ucLabel2.AutoSize = true;
            this.ucLabel2.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabel2.ForeColor = System.Drawing.Color.Gray;
            this.ucLabel2.Location = new System.Drawing.Point(3, 75);
            this.ucLabel2.Name = "ucLabel2";
            this.ucLabel2.Size = new System.Drawing.Size(65, 12);
            this.ucLabel2.TabIndex = 6;
            this.ucLabel2.Text = "部门编号：";
            // 
            // txtDeptOrgName
            // 
            // 
            // 
            // 
            this.txtDeptOrgName.Border.Class = "TextBoxBorder";
            this.txtDeptOrgName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDeptOrgName.EnterToNextControl = false;
            this.txtDeptOrgName.Location = new System.Drawing.Point(74, 16);
            this.txtDeptOrgName.Name = "txtDeptOrgName";
            this.txtDeptOrgName.ReadOnly = true;
            this.txtDeptOrgName.Size = new System.Drawing.Size(153, 21);
            this.txtDeptOrgName.TabIndex = 0;
            // 
            // txtDeptNo
            // 
            // 
            // 
            // 
            this.txtDeptNo.Border.Class = "TextBoxBorder";
            this.txtDeptNo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDeptNo.EnterToNextControl = false;
            this.txtDeptNo.Location = new System.Drawing.Point(74, 72);
            this.txtDeptNo.Name = "txtDeptNo";
            this.txtDeptNo.ReadOnly = true;
            this.txtDeptNo.Size = new System.Drawing.Size(153, 21);
            this.txtDeptNo.TabIndex = 0;
            // 
            // dgvEmp
            // 
            this.dgvEmp.AllowUserToAddRows = false;
            this.dgvEmp.AllowUserToDeleteRows = false;
            this.dgvEmp.AllowUserToOrderColumns = true;
            this.dgvEmp.BackgroundColor = System.Drawing.Color.White;
            this.dgvEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colEmpRightBtn,
            this.colEmpID,
            this.colEmpGuid,
            this.colGCompanyID,
            this.colOrgID,
            this.colDeptID,
            this.colEmpCode,
            this.colEmpName,
            this.colPassword,
            this.colBillCode,
            this.colIdentityCardNo,
            this.colSex,
            this.colBirthday,
            this.colPositionID,
            this.colManagerEmpID,
            this.colSocialSecurityNo,
            this.colJoinTime,
            this.colQuitTime,
            this.colTelephone,
            this.colMobile,
            this.colEmail,
            this.colNation,
            this.colPlaceOfOrigin,
            this.colMarriage,
            this.colEducation,
            this.colProfessional,
            this.colSpecialty,
            this.colProbation,
            this.colLaborContract,
            this.colMacAddress,
            this.colHardDiskSN,
            this.colNeedValidate,
            this.colBasicSalary,
            this.colLastEditEmpID,
            this.colLastEditTime,
            this.colEmpStatus,
            this.colLastSignInDate,
            this.colSignInTimes,
            this.colUseTimeBegin,
            this.colUseTimeOver,
            this.colAfterTimeForBill,
            this.colFamilyAddress,
            this.colBakContact,
            this.colBakContactTel,
            this.colProtectedCusCnt,
            this.colRelationSales,
            this.colRelationBuyers,
            this.colIsSales,
            this.colIsBuyer,
            this.colIsStockManager,
            this.colTelFax,
            this.colQQ,
            this.colSkype,
            this.DefaultCurreny,
            this.colOcation,
            this.colIsDeleted,
            this.colIsActive});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmp.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEmp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmp.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvEmp.HighlightSelectedColumnHeaders = false;
            this.dgvEmp.Location = new System.Drawing.Point(0, 31);
            this.dgvEmp.Name = "dgvEmp";
            this.dgvEmp.PaintEnhancedSelection = false;
            this.dgvEmp.ReadOnly = true;
            this.dgvEmp.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvEmp.RowHeadersWidth = 40;
            this.dgvEmp.RowTemplate.Height = 23;
            this.dgvEmp.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmp.SelectAllSignVisible = false;
            this.dgvEmp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvEmp.ShowRowNo = true;
            this.dgvEmp.Size = new System.Drawing.Size(866, 447);
            this.dgvEmp.TabIndex = 0;
            this.dgvEmp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ucDataGridView1_CellContentClick);
            this.dgvEmp.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmp_CellDoubleClick);
            // 
            // colEmpRightBtn
            // 
            this.colEmpRightBtn.Checked = true;
            this.colEmpRightBtn.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.colEmpRightBtn.CheckValue = "N";
            this.colEmpRightBtn.FillWeight = 40F;
            this.colEmpRightBtn.Frozen = true;
            this.colEmpRightBtn.HeaderText = "权限";
            this.colEmpRightBtn.Name = "colEmpRightBtn";
            this.colEmpRightBtn.ReadOnly = true;
            this.colEmpRightBtn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colEmpRightBtn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colEmpRightBtn.Width = 40;
            // 
            // colEmpID
            // 
            this.colEmpID.DataPropertyName = "EmpID";
            this.colEmpID.HeaderText = "人员ID";
            this.colEmpID.Name = "colEmpID";
            this.colEmpID.ReadOnly = true;
            this.colEmpID.Visible = false;
            // 
            // colEmpGuid
            // 
            this.colEmpGuid.DataPropertyName = "EmpGuid";
            this.colEmpGuid.HeaderText = "人员GUID";
            this.colEmpGuid.Name = "colEmpGuid";
            this.colEmpGuid.ReadOnly = true;
            this.colEmpGuid.Visible = false;
            // 
            // colGCompanyID
            // 
            this.colGCompanyID.DataPropertyName = "GCompanyID";
            this.colGCompanyID.HeaderText = "注册公司ID";
            this.colGCompanyID.Name = "colGCompanyID";
            this.colGCompanyID.ReadOnly = true;
            this.colGCompanyID.Visible = false;
            // 
            // colOrgID
            // 
            this.colOrgID.DataPropertyName = "OrgID";
            this.colOrgID.HeaderText = "机构ID";
            this.colOrgID.Name = "colOrgID";
            this.colOrgID.ReadOnly = true;
            this.colOrgID.Visible = false;
            // 
            // colDeptID
            // 
            this.colDeptID.DataPropertyName = "DeptID";
            this.colDeptID.HeaderText = "部门ID";
            this.colDeptID.Name = "colDeptID";
            this.colDeptID.ReadOnly = true;
            this.colDeptID.Visible = false;
            // 
            // colEmpCode
            // 
            this.colEmpCode.DataPropertyName = "EmpCode";
            this.colEmpCode.HeaderText = "人员编号";
            this.colEmpCode.Name = "colEmpCode";
            this.colEmpCode.ReadOnly = true;
            // 
            // colEmpName
            // 
            this.colEmpName.DataPropertyName = "EmpName";
            this.colEmpName.HeaderText = "人员名称";
            this.colEmpName.Name = "colEmpName";
            this.colEmpName.ReadOnly = true;
            // 
            // colPassword
            // 
            this.colPassword.HeaderText = "密码";
            this.colPassword.Name = "colPassword";
            this.colPassword.ReadOnly = true;
            this.colPassword.Visible = false;
            // 
            // colBillCode
            // 
            this.colBillCode.HeaderText = "单据标示代码";
            this.colBillCode.Name = "colBillCode";
            this.colBillCode.ReadOnly = true;
            this.colBillCode.Visible = false;
            // 
            // colIdentityCardNo
            // 
            this.colIdentityCardNo.DataPropertyName = "IdentityCardNo";
            this.colIdentityCardNo.HeaderText = "身份证号码";
            this.colIdentityCardNo.Name = "colIdentityCardNo";
            this.colIdentityCardNo.ReadOnly = true;
            // 
            // colSex
            // 
            this.colSex.HeaderText = "性别";
            this.colSex.Name = "colSex";
            this.colSex.ReadOnly = true;
            this.colSex.Visible = false;
            // 
            // colBirthday
            // 
            // 
            // 
            // 
            this.colBirthday.BackgroundStyle.Class = "DataGridViewDateTimeBorder";
            this.colBirthday.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.colBirthday.HeaderText = "出生日期";
            this.colBirthday.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left;
            // 
            // 
            // 
            this.colBirthday.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.colBirthday.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.colBirthday.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            // 
            // 
            // 
            this.colBirthday.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.colBirthday.MonthCalendar.DisplayMonth = new System.DateTime(2014, 9, 1, 0, 0, 0, 0);
            this.colBirthday.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.colBirthday.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.colBirthday.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.colBirthday.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.colBirthday.Name = "colBirthday";
            this.colBirthday.ReadOnly = true;
            // 
            // colPositionID
            // 
            this.colPositionID.HeaderText = "岗位";
            this.colPositionID.Name = "colPositionID";
            this.colPositionID.ReadOnly = true;
            // 
            // colManagerEmpID
            // 
            this.colManagerEmpID.HeaderText = "直接上司";
            this.colManagerEmpID.Name = "colManagerEmpID";
            this.colManagerEmpID.ReadOnly = true;
            this.colManagerEmpID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colManagerEmpID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colManagerEmpID.Visible = false;
            // 
            // colSocialSecurityNo
            // 
            this.colSocialSecurityNo.HeaderText = "社保号";
            this.colSocialSecurityNo.Name = "colSocialSecurityNo";
            this.colSocialSecurityNo.ReadOnly = true;
            this.colSocialSecurityNo.Visible = false;
            // 
            // colJoinTime
            // 
            // 
            // 
            // 
            this.colJoinTime.BackgroundStyle.Class = "DataGridViewDateTimeBorder";
            this.colJoinTime.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.colJoinTime.HeaderText = "入职时间";
            this.colJoinTime.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left;
            // 
            // 
            // 
            this.colJoinTime.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.colJoinTime.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.colJoinTime.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            // 
            // 
            // 
            this.colJoinTime.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.colJoinTime.MonthCalendar.DisplayMonth = new System.DateTime(2014, 9, 1, 0, 0, 0, 0);
            this.colJoinTime.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.colJoinTime.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.colJoinTime.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.colJoinTime.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.colJoinTime.Name = "colJoinTime";
            this.colJoinTime.ReadOnly = true;
            // 
            // colQuitTime
            // 
            // 
            // 
            // 
            this.colQuitTime.BackgroundStyle.Class = "DataGridViewDateTimeBorder";
            this.colQuitTime.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.colQuitTime.HeaderText = "离职时间";
            this.colQuitTime.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left;
            // 
            // 
            // 
            this.colQuitTime.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.colQuitTime.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.colQuitTime.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            // 
            // 
            // 
            this.colQuitTime.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.colQuitTime.MonthCalendar.DisplayMonth = new System.DateTime(2014, 9, 1, 0, 0, 0, 0);
            this.colQuitTime.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.colQuitTime.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.colQuitTime.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.colQuitTime.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.colQuitTime.Name = "colQuitTime";
            this.colQuitTime.ReadOnly = true;
            this.colQuitTime.Visible = false;
            // 
            // colTelephone
            // 
            this.colTelephone.HeaderText = "电话号码";
            this.colTelephone.Name = "colTelephone";
            this.colTelephone.ReadOnly = true;
            // 
            // colMobile
            // 
            this.colMobile.HeaderText = "手机号码";
            this.colMobile.Name = "colMobile";
            this.colMobile.ReadOnly = true;
            this.colMobile.Visible = false;
            // 
            // colEmail
            // 
            this.colEmail.HeaderText = "电子邮箱";
            this.colEmail.Name = "colEmail";
            this.colEmail.ReadOnly = true;
            this.colEmail.Visible = false;
            // 
            // colNation
            // 
            this.colNation.HeaderText = "民族";
            this.colNation.Name = "colNation";
            this.colNation.ReadOnly = true;
            this.colNation.Visible = false;
            // 
            // colPlaceOfOrigin
            // 
            this.colPlaceOfOrigin.HeaderText = "籍贯";
            this.colPlaceOfOrigin.Name = "colPlaceOfOrigin";
            this.colPlaceOfOrigin.ReadOnly = true;
            this.colPlaceOfOrigin.Visible = false;
            // 
            // colMarriage
            // 
            this.colMarriage.HeaderText = "婚姻状态";
            this.colMarriage.Name = "colMarriage";
            this.colMarriage.ReadOnly = true;
            this.colMarriage.Visible = false;
            // 
            // colEducation
            // 
            this.colEducation.HeaderText = "学历";
            this.colEducation.Name = "colEducation";
            this.colEducation.ReadOnly = true;
            // 
            // colProfessional
            // 
            this.colProfessional.HeaderText = "专业";
            this.colProfessional.Name = "colProfessional";
            this.colProfessional.ReadOnly = true;
            this.colProfessional.Visible = false;
            // 
            // colSpecialty
            // 
            this.colSpecialty.HeaderText = "特长";
            this.colSpecialty.Name = "colSpecialty";
            this.colSpecialty.ReadOnly = true;
            this.colSpecialty.Visible = false;
            // 
            // colProbation
            // 
            this.colProbation.HeaderText = "试用期";
            this.colProbation.Name = "colProbation";
            this.colProbation.ReadOnly = true;
            this.colProbation.Visible = false;
            // 
            // colLaborContract
            // 
            this.colLaborContract.HeaderText = "签合同否";
            this.colLaborContract.Name = "colLaborContract";
            this.colLaborContract.ReadOnly = true;
            this.colLaborContract.Visible = false;
            // 
            // colMacAddress
            // 
            this.colMacAddress.HeaderText = "网卡地址";
            this.colMacAddress.Name = "colMacAddress";
            this.colMacAddress.ReadOnly = true;
            this.colMacAddress.Visible = false;
            // 
            // colHardDiskSN
            // 
            this.colHardDiskSN.HeaderText = "硬盘序列号";
            this.colHardDiskSN.Name = "colHardDiskSN";
            this.colHardDiskSN.ReadOnly = true;
            this.colHardDiskSN.Visible = false;
            // 
            // colNeedValidate
            // 
            this.colNeedValidate.HeaderText = "是否需要验证";
            this.colNeedValidate.Name = "colNeedValidate";
            this.colNeedValidate.ReadOnly = true;
            this.colNeedValidate.Visible = false;
            // 
            // colBasicSalary
            // 
            this.colBasicSalary.HeaderText = "底薪";
            this.colBasicSalary.Name = "colBasicSalary";
            this.colBasicSalary.ReadOnly = true;
            this.colBasicSalary.Visible = false;
            // 
            // colLastEditEmpID
            // 
            this.colLastEditEmpID.HeaderText = "最后更新人";
            this.colLastEditEmpID.Name = "colLastEditEmpID";
            this.colLastEditEmpID.ReadOnly = true;
            this.colLastEditEmpID.Visible = false;
            // 
            // colLastEditTime
            // 
            this.colLastEditTime.HeaderText = "最后编辑时间";
            this.colLastEditTime.Name = "colLastEditTime";
            this.colLastEditTime.ReadOnly = true;
            this.colLastEditTime.Visible = false;
            // 
            // colEmpStatus
            // 
            this.colEmpStatus.HeaderText = "员工状态";
            this.colEmpStatus.Name = "colEmpStatus";
            this.colEmpStatus.ReadOnly = true;
            // 
            // colLastSignInDate
            // 
            // 
            // 
            // 
            this.colLastSignInDate.BackgroundStyle.Class = "DataGridViewDateTimeBorder";
            this.colLastSignInDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.colLastSignInDate.HeaderText = "最后一次登录时间";
            this.colLastSignInDate.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left;
            // 
            // 
            // 
            this.colLastSignInDate.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.colLastSignInDate.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.colLastSignInDate.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            // 
            // 
            // 
            this.colLastSignInDate.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.colLastSignInDate.MonthCalendar.DisplayMonth = new System.DateTime(2014, 9, 1, 0, 0, 0, 0);
            this.colLastSignInDate.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.colLastSignInDate.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.colLastSignInDate.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.colLastSignInDate.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.colLastSignInDate.Name = "colLastSignInDate";
            this.colLastSignInDate.ReadOnly = true;
            this.colLastSignInDate.Visible = false;
            // 
            // colSignInTimes
            // 
            this.colSignInTimes.HeaderText = "总登录次数";
            this.colSignInTimes.Name = "colSignInTimes";
            this.colSignInTimes.ReadOnly = true;
            this.colSignInTimes.Visible = false;
            // 
            // colUseTimeBegin
            // 
            // 
            // 
            // 
            this.colUseTimeBegin.BackgroundStyle.Class = "DataGridViewDateTimeBorder";
            this.colUseTimeBegin.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.colUseTimeBegin.HeaderText = "开始使用时间";
            this.colUseTimeBegin.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left;
            // 
            // 
            // 
            this.colUseTimeBegin.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.colUseTimeBegin.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.colUseTimeBegin.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            // 
            // 
            // 
            this.colUseTimeBegin.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.colUseTimeBegin.MonthCalendar.DisplayMonth = new System.DateTime(2014, 9, 1, 0, 0, 0, 0);
            this.colUseTimeBegin.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.colUseTimeBegin.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.colUseTimeBegin.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.colUseTimeBegin.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.colUseTimeBegin.Name = "colUseTimeBegin";
            this.colUseTimeBegin.ReadOnly = true;
            this.colUseTimeBegin.Visible = false;
            // 
            // colUseTimeOver
            // 
            // 
            // 
            // 
            this.colUseTimeOver.BackgroundStyle.Class = "DataGridViewDateTimeBorder";
            this.colUseTimeOver.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.colUseTimeOver.HeaderText = "结束使用时间";
            this.colUseTimeOver.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left;
            // 
            // 
            // 
            this.colUseTimeOver.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.colUseTimeOver.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.colUseTimeOver.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            // 
            // 
            // 
            this.colUseTimeOver.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.colUseTimeOver.MonthCalendar.DisplayMonth = new System.DateTime(2014, 9, 1, 0, 0, 0, 0);
            this.colUseTimeOver.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.colUseTimeOver.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.colUseTimeOver.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.colUseTimeOver.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.colUseTimeOver.Name = "colUseTimeOver";
            this.colUseTimeOver.ReadOnly = true;
            this.colUseTimeOver.Visible = false;
            // 
            // colAfterTimeForBill
            // 
            // 
            // 
            // 
            this.colAfterTimeForBill.BackgroundStyle.Class = "DataGridViewDateTimeBorder";
            this.colAfterTimeForBill.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.colAfterTimeForBill.HeaderText = "单据查询时间";
            this.colAfterTimeForBill.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left;
            // 
            // 
            // 
            this.colAfterTimeForBill.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.colAfterTimeForBill.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.colAfterTimeForBill.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            // 
            // 
            // 
            this.colAfterTimeForBill.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.colAfterTimeForBill.MonthCalendar.DisplayMonth = new System.DateTime(2014, 9, 1, 0, 0, 0, 0);
            this.colAfterTimeForBill.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.colAfterTimeForBill.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.colAfterTimeForBill.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.colAfterTimeForBill.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.colAfterTimeForBill.Name = "colAfterTimeForBill";
            this.colAfterTimeForBill.ReadOnly = true;
            this.colAfterTimeForBill.Visible = false;
            // 
            // colFamilyAddress
            // 
            this.colFamilyAddress.HeaderText = "家庭地址";
            this.colFamilyAddress.Name = "colFamilyAddress";
            this.colFamilyAddress.ReadOnly = true;
            this.colFamilyAddress.Visible = false;
            // 
            // colBakContact
            // 
            this.colBakContact.HeaderText = "备用联系人";
            this.colBakContact.Name = "colBakContact";
            this.colBakContact.ReadOnly = true;
            this.colBakContact.Visible = false;
            // 
            // colBakContactTel
            // 
            this.colBakContactTel.HeaderText = "备用联系方式";
            this.colBakContactTel.Name = "colBakContactTel";
            this.colBakContactTel.ReadOnly = true;
            this.colBakContactTel.Visible = false;
            // 
            // colProtectedCusCnt
            // 
            this.colProtectedCusCnt.HeaderText = "保护客户数";
            this.colProtectedCusCnt.Name = "colProtectedCusCnt";
            this.colProtectedCusCnt.ReadOnly = true;
            this.colProtectedCusCnt.Visible = false;
            // 
            // colRelationSales
            // 
            this.colRelationSales.HeaderText = "相关业务员";
            this.colRelationSales.Name = "colRelationSales";
            this.colRelationSales.ReadOnly = true;
            this.colRelationSales.Visible = false;
            // 
            // colRelationBuyers
            // 
            this.colRelationBuyers.HeaderText = "相关采购员";
            this.colRelationBuyers.Name = "colRelationBuyers";
            this.colRelationBuyers.ReadOnly = true;
            this.colRelationBuyers.Visible = false;
            // 
            // colIsSales
            // 
            this.colIsSales.HeaderText = "销售员";
            this.colIsSales.Name = "colIsSales";
            this.colIsSales.ReadOnly = true;
            this.colIsSales.Visible = false;
            // 
            // colIsBuyer
            // 
            this.colIsBuyer.HeaderText = "采购员";
            this.colIsBuyer.Name = "colIsBuyer";
            this.colIsBuyer.ReadOnly = true;
            this.colIsBuyer.Visible = false;
            // 
            // colIsStockManager
            // 
            this.colIsStockManager.HeaderText = "仓管员";
            this.colIsStockManager.Name = "colIsStockManager";
            this.colIsStockManager.ReadOnly = true;
            this.colIsStockManager.Visible = false;
            // 
            // colTelFax
            // 
            this.colTelFax.HeaderText = "传真";
            this.colTelFax.Name = "colTelFax";
            this.colTelFax.ReadOnly = true;
            this.colTelFax.Visible = false;
            // 
            // colQQ
            // 
            this.colQQ.HeaderText = "QQ号码";
            this.colQQ.Name = "colQQ";
            this.colQQ.ReadOnly = true;
            this.colQQ.Visible = false;
            // 
            // colSkype
            // 
            this.colSkype.HeaderText = "Skype";
            this.colSkype.Name = "colSkype";
            this.colSkype.ReadOnly = true;
            this.colSkype.Visible = false;
            // 
            // DefaultCurreny
            // 
            this.DefaultCurreny.HeaderText = "默认币种";
            this.DefaultCurreny.Name = "DefaultCurreny";
            this.DefaultCurreny.ReadOnly = true;
            this.DefaultCurreny.Visible = false;
            // 
            // colOcation
            // 
            this.colOcation.HeaderText = "位置";
            this.colOcation.Name = "colOcation";
            this.colOcation.ReadOnly = true;
            this.colOcation.Visible = false;
            // 
            // colIsDeleted
            // 
            this.colIsDeleted.HeaderText = "删除标记";
            this.colIsDeleted.Name = "colIsDeleted";
            this.colIsDeleted.ReadOnly = true;
            this.colIsDeleted.Visible = false;
            // 
            // colIsActive
            // 
            this.colIsActive.HeaderText = "是否启用";
            this.colIsActive.Name = "colIsActive";
            this.colIsActive.ReadOnly = true;
            this.colIsActive.Visible = false;
            // 
            // ucPanel4
            // 
            this.ucPanel4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ucPanel4.Controls.Add(this.btnEditEmp);
            this.ucPanel4.Controls.Add(this.btnAddEmp);
            this.ucPanel4.Controls.Add(this.ucLabel7);
            this.ucPanel4.Controls.Add(this.txtEmpName);
            this.ucPanel4.Controls.Add(this.btnSearch);
            this.ucPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucPanel4.Location = new System.Drawing.Point(0, 0);
            this.ucPanel4.Name = "ucPanel4";
            this.ucPanel4.Size = new System.Drawing.Size(866, 31);
            this.ucPanel4.TabIndex = 6;
            // 
            // btnEditEmp
            // 
            this.btnEditEmp.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEditEmp.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnEditEmp.Image = global::ZNLCRM.UI.Properties.Resources.add_3;
            this.btnEditEmp.Location = new System.Drawing.Point(416, 3);
            this.btnEditEmp.Name = "btnEditEmp";
            this.btnEditEmp.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlA);
            this.btnEditEmp.Size = new System.Drawing.Size(76, 23);
            this.btnEditEmp.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.btnEditEmp.TabIndex = 3;
            this.btnEditEmp.Text = "修改(M)";
            this.btnEditEmp.Click += new System.EventHandler(this.btnEditEmp_Click);
            // 
            // btnAddEmp
            // 
            this.btnAddEmp.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddEmp.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAddEmp.Image = global::ZNLCRM.UI.Properties.Resources.add_3;
            this.btnAddEmp.Location = new System.Drawing.Point(334, 3);
            this.btnAddEmp.Name = "btnAddEmp";
            this.btnAddEmp.Size = new System.Drawing.Size(76, 23);
            this.btnAddEmp.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.btnAddEmp.TabIndex = 3;
            this.btnAddEmp.Text = "添加(&A)";
            this.btnAddEmp.Click += new System.EventHandler(this.btnAddEmp_Click);
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
            this.ucLabel7.Text = "人员名称：";
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
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
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
            this.ucExpandableSplitter1.Location = new System.Drawing.Point(200, 0);
            this.ucExpandableSplitter1.Name = "ucExpandableSplitter1";
            this.ucExpandableSplitter1.Size = new System.Drawing.Size(3, 478);
            this.ucExpandableSplitter1.Style = DevComponents.DotNetBar.eSplitterStyle.Office2007;
            this.ucExpandableSplitter1.TabIndex = 2;
            this.ucExpandableSplitter1.TabStop = false;
            // 
            // ucPanel2
            // 
            this.ucPanel2.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel2.Controls.Add(this.trOrg);
            this.ucPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.ucPanel2.Location = new System.Drawing.Point(0, 0);
            this.ucPanel2.Name = "ucPanel2";
            this.ucPanel2.Size = new System.Drawing.Size(200, 478);
            this.ucPanel2.TabIndex = 0;
            // 
            // trOrg
            // 
            this.trOrg.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline;
            this.trOrg.AllowDrop = true;
            this.trOrg.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.trOrg.BackgroundStyle.Class = "TreeBorderKey";
            this.trOrg.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.trOrg.ContextMenuStrip = this.cmsOrg;
            this.trOrg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trOrg.GridLinesColor = System.Drawing.Color.Transparent;
            this.trOrg.GridRowLines = true;
            this.trOrg.Location = new System.Drawing.Point(0, 0);
            this.trOrg.Margin = new System.Windows.Forms.Padding(0);
            this.trOrg.Name = "trOrg";
            this.trOrg.NodesConnector = this.nodeConnector1;
            this.trOrg.NodeStyle = this.elementStyle1;
            this.trOrg.PathSeparator = ";";
            this.trOrg.Size = new System.Drawing.Size(200, 478);
            this.trOrg.Styles.Add(this.elementStyle1);
            this.trOrg.TabIndex = 0;
            this.trOrg.SelectedIndexChanged += new System.EventHandler(this.trOrg_SelectedIndexChanged);
            // 
            // nodeConnector1
            // 
            this.nodeConnector1.LineColor = System.Drawing.SystemColors.ControlText;
            // 
            // elementStyle1
            // 
            this.elementStyle1.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.elementStyle1.Name = "elementStyle1";
            this.elementStyle1.TextColor = System.Drawing.SystemColors.ControlText;
            // 
            // ucToolStrip1
            // 
            this.ucToolStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ucToolStrip1.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.ucToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddOrg,
            this.btnEditOrg,
            this.btnDelOrg,
            this.toolStripSeparator1,
            this.btnAddDept,
            this.btnEditDept,
            this.btnDelDept});
            this.ucToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.ucToolStrip1.Name = "ucToolStrip1";
            this.ucToolStrip1.Padding = new System.Windows.Forms.Padding(5);
            this.ucToolStrip1.Size = new System.Drawing.Size(1069, 36);
            this.ucToolStrip1.TabIndex = 0;
            this.ucToolStrip1.Text = "ucToolStrip1";
            // 
            // btnAddOrg
            // 
            this.btnAddOrg.Image = global::ZNLCRM.UI.Properties.Resources.add_1;
            this.btnAddOrg.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddOrg.Name = "btnAddOrg";
            this.btnAddOrg.Size = new System.Drawing.Size(81, 23);
            this.btnAddOrg.Text = "添加机构";
            this.btnAddOrg.Click += new System.EventHandler(this.btnAddOrg_Click);
            // 
            // btnEditOrg
            // 
            this.btnEditOrg.Image = global::ZNLCRM.UI.Properties.Resources.edit_1;
            this.btnEditOrg.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditOrg.Name = "btnEditOrg";
            this.btnEditOrg.Size = new System.Drawing.Size(81, 23);
            this.btnEditOrg.Text = "修改机构";
            this.btnEditOrg.Click += new System.EventHandler(this.btnEditOrg_Click);
            // 
            // btnDelOrg
            // 
            this.btnDelOrg.Image = global::ZNLCRM.UI.Properties.Resources.del_1;
            this.btnDelOrg.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelOrg.Name = "btnDelOrg";
            this.btnDelOrg.Size = new System.Drawing.Size(81, 23);
            this.btnDelOrg.Text = "删除机构";
            this.btnDelOrg.Click += new System.EventHandler(this.btnDelOrg_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 26);
            // 
            // btnAddDept
            // 
            this.btnAddDept.Image = global::ZNLCRM.UI.Properties.Resources.add_2;
            this.btnAddDept.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddDept.Name = "btnAddDept";
            this.btnAddDept.Size = new System.Drawing.Size(81, 23);
            this.btnAddDept.Text = "添加部门";
            this.btnAddDept.Click += new System.EventHandler(this.btnAddDept_Click);
            // 
            // btnEditDept
            // 
            this.btnEditDept.Image = global::ZNLCRM.UI.Properties.Resources.edit_2;
            this.btnEditDept.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditDept.Name = "btnEditDept";
            this.btnEditDept.Size = new System.Drawing.Size(81, 23);
            this.btnEditDept.Text = "修改部门";
            this.btnEditDept.Click += new System.EventHandler(this.btnEditDept_Click);
            // 
            // btnDelDept
            // 
            this.btnDelDept.Image = global::ZNLCRM.UI.Properties.Resources.del_2;
            this.btnDelDept.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelDept.Name = "btnDelDept";
            this.btnDelDept.Size = new System.Drawing.Size(81, 23);
            this.btnDelDept.Text = "删除部门";
            this.btnDelDept.Click += new System.EventHandler(this.btnDelDept_Click);
            // 
            // frmEmpManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 514);
            this.Controls.Add(this.ucPanel1);
            this.Controls.Add(this.ucToolStrip1);
            this.Name = "frmEmpManage";
            this.Text = "组织机构管理";
            this.Load += new System.EventHandler(this.frmEmpManage_Load);
            this.cmsOrg.ResumeLayout(false);
            this.ucPanel1.ResumeLayout(false);
            this.ucPanel3.ResumeLayout(false);
            this.ucPanel3.PerformLayout();
            this.grpOrg.ResumeLayout(false);
            this.grpOrg.PerformLayout();
            this.grpDept.ResumeLayout(false);
            this.grpDept.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmp)).EndInit();
            this.ucPanel4.ResumeLayout(false);
            this.ucPanel4.PerformLayout();
            this.ucPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trOrg)).EndInit();
            this.ucToolStrip1.ResumeLayout(false);
            this.ucToolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.UcToolStrip ucToolStrip1;
        private System.Windows.Forms.ToolStripButton btnAddOrg;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnDelDept;
        private Controls.UcPanel ucPanel1;
        private Controls.UcPanel ucPanel2;
        private Controls.UcPanel ucPanel3;
        private Controls.UcAdTree trOrg;
        private DevComponents.AdvTree.NodeConnector nodeConnector1;
        private DevComponents.DotNetBar.ElementStyle elementStyle1;
        private Controls.UcDataGridView dgvEmp;
        private System.Windows.Forms.ContextMenuStrip cmsOrg;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditOrg;
        private System.Windows.Forms.ToolStripMenuItem tsmiDelOrg;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddDept;
        private System.Windows.Forms.ToolStripMenuItem tsmiDelDept;
        private Controls.UcLabel ucLabel1;
        private Controls.UcTextBox txtDeptName;
        private Controls.UcLabel ucLabel2;
        private Controls.UcTextBox txtDeptNo;
        private Controls.UcLabel ucLabel3;
        private Controls.UcTextBox txtDeptOrgName;
        private Controls.UcLabel ucLabel4;
        private Controls.UcTextBox txtParentDeptName;
        private Controls.UcButton btnCancelDept;
        private Controls.UcButton btnSaveDept;
        private Controls.UcLabel ucLabel6;
        private Controls.UcTextBox txtOrgNo;
        private Controls.UcLabel ucLabel5;
        private Controls.UcTextBox txtOrgName;
        private Controls.UcButton btnCancelOrg;
        private Controls.UcButton btnSaveOrg;
        private Controls.UcExpandableSplitter ucExpandableSplitter1;
        private System.Windows.Forms.ToolStripButton btnEditOrg;
        private Controls.UcTextBox txtDeptID;
        private Controls.UcTextBox txtOrgID;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditDept;
        private Controls.UcTextBox txtOrgGuID;
        private Controls.UcTextBox txtParentID;
        private Controls.UcTextBox txtDeptOrgGuID;
        private Controls.UcPanel grpDept;
        private Controls.UcPanel grpOrg;
        private Controls.UcPanel ucPanel4;
        private Controls.UcButton btnSearch;
        private Controls.UcLabel ucLabel7;
        private Controls.UcTextBox txtEmpName;
        private Controls.UcButton btnAddEmp;
        private System.Windows.Forms.ToolStripMenuItem tmsiAddEmp;
        private Controls.UcTextBox txtDeptOrgID;
        private System.Windows.Forms.ToolStripButton btnDelOrg;
        private System.Windows.Forms.ToolStripButton btnAddDept;
        private System.Windows.Forms.ToolStripButton btnEditDept;
        private DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn colEmpRightBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmpID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmpGuid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGCompanyID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrgID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDeptID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmpCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBillCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdentityCardNo;
        private System.Windows.Forms.DataGridViewComboBoxColumn colSex;
        private DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn colBirthday;
        private System.Windows.Forms.DataGridViewComboBoxColumn colPositionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colManagerEmpID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSocialSecurityNo;
        private DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn colJoinTime;
        private DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn colQuitTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelephone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlaceOfOrigin;
        private System.Windows.Forms.DataGridViewComboBoxColumn colMarriage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEducation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProfessional;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSpecialty;
        private System.Windows.Forms.DataGridViewComboBoxColumn colProbation;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colLaborContract;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colMacAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHardDiskSN;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colNeedValidate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBasicSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLastEditEmpID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLastEditTime;
        private System.Windows.Forms.DataGridViewComboBoxColumn colEmpStatus;
        private DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn colLastSignInDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSignInTimes;
        private DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn colUseTimeBegin;
        private DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn colUseTimeOver;
        private DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn colAfterTimeForBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFamilyAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBakContact;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBakContactTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProtectedCusCnt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRelationSales;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRelationBuyers;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colIsSales;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colIsBuyer;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colIsStockManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelFax;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSkype;
        private System.Windows.Forms.DataGridViewComboBoxColumn DefaultCurreny;
        private System.Windows.Forms.DataGridViewComboBoxColumn colOcation;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colIsDeleted;
        private System.Windows.Forms.DataGridViewComboBoxColumn colIsActive;
        private Controls.UcButton btnEditEmp;
    }
}