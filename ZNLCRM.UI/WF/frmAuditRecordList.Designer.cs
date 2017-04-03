namespace ZNLCRM.UI.WF
{
    partial class frmAuditRecordList
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
            this.panTop = new ZNLCRM.Controls.UcPanelEx(this.components);
            this.panMid = new ZNLCRM.Controls.UcPanelEx(this.components);
            this.dgvMain = new ZNLCRM.Controls.UcDataGridView(this.components);
            this.col_CRM_JobMast_EmpJobGuid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_CRM_JobMast_BillNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Seq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_CRM_JobMast_JobName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_CRM_JobMast_JobDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_CRM_JobMast_BelongEmpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_CRM_JobMast_Summary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panBottom = new ZNLCRM.Controls.UcPanelEx(this.components);
            this.ucLabel1 = new ZNLCRM.Controls.UcLabel(this.components);
            this.txtBillNo = new ZNLCRM.Controls.UcTextBox(this.components);
            this.ucLabel2 = new ZNLCRM.Controls.UcLabel(this.components);
            this.txtTransferManID = new ZNLCRM.Controls.UcTextBox(this.components);
            this.ucLabel4 = new ZNLCRM.Controls.UcLabel(this.components);
            this.txtApproveStatus = new ZNLCRM.Controls.UcTextBox(this.components);
            this.ucLabel5 = new ZNLCRM.Controls.UcLabel(this.components);
            this.ucLabel3 = new ZNLCRM.Controls.UcLabel(this.components);
            this.txtTransferManName = new ZNLCRM.Controls.UcTextBox(this.components);
            this.txtCheckRemark = new ZNLCRM.Controls.UcTextBox(this.components);
            this.txtCurrentCheckMan = new ZNLCRM.Controls.UcTextBox(this.components);
            this.ucButton4 = new ZNLCRM.Controls.UcButton(this.components);
            this.btnCancel = new ZNLCRM.Controls.UcButton(this.components);
            this.btnSubmit = new ZNLCRM.Controls.UcButton(this.components);
            this.btnCancelCheck = new ZNLCRM.Controls.UcButton(this.components);
            this.btnNoPass = new ZNLCRM.Controls.UcButton(this.components);
            this.btnReturn = new ZNLCRM.Controls.UcButton(this.components);
            this.btnArgee = new ZNLCRM.Controls.UcButton(this.components);
            this.panMid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.panBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // panTop
            // 
            this.panTop.CanvasColor = System.Drawing.SystemColors.Control;
            this.panTop.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panTop.Location = new System.Drawing.Point(0, 0);
            this.panTop.Name = "panTop";
            this.panTop.Size = new System.Drawing.Size(819, 10);
            this.panTop.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panTop.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panTop.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panTop.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panTop.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panTop.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panTop.Style.GradientAngle = 90;
            this.panTop.TabIndex = 0;
            // 
            // panMid
            // 
            this.panMid.CanvasColor = System.Drawing.SystemColors.Control;
            this.panMid.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panMid.Controls.Add(this.dgvMain);
            this.panMid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panMid.Location = new System.Drawing.Point(0, 10);
            this.panMid.Name = "panMid";
            this.panMid.Size = new System.Drawing.Size(819, 205);
            this.panMid.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panMid.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panMid.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panMid.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panMid.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panMid.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panMid.Style.GradientAngle = 90;
            this.panMid.TabIndex = 0;
            this.panMid.Text = "ucPanelEx1";
            // 
            // dgvMain
            // 
            this.dgvMain.AllowUserToAddRows = false;
            this.dgvMain.AllowUserToDeleteRows = false;
            this.dgvMain.AllowUserToOrderColumns = true;
            this.dgvMain.BackgroundColor = System.Drawing.Color.White;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_CRM_JobMast_EmpJobGuid,
            this.col_CRM_JobMast_BillNo,
            this.col_Seq,
            this.col_CRM_JobMast_JobName,
            this.col_CRM_JobMast_JobDate,
            this.col_CRM_JobMast_BelongEmpName,
            this.col_CRM_JobMast_Summary});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMain.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMain.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvMain.HighlightSelectedColumnHeaders = false;
            this.dgvMain.Location = new System.Drawing.Point(0, 0);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.PaintEnhancedSelection = false;
            this.dgvMain.ReadOnly = true;
            this.dgvMain.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvMain.RowTemplate.Height = 23;
            this.dgvMain.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMain.SelectAllSignVisible = false;
            this.dgvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvMain.Size = new System.Drawing.Size(819, 205);
            this.dgvMain.TabIndex = 1;
            this.dgvMain.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMain_CellContentClick);
            // 
            // col_CRM_JobMast_EmpJobGuid
            // 
            this.col_CRM_JobMast_EmpJobGuid.DataPropertyName = "WF_RecGuid";
            this.col_CRM_JobMast_EmpJobGuid.HeaderText = "KeyGuid";
            this.col_CRM_JobMast_EmpJobGuid.Name = "col_CRM_JobMast_EmpJobGuid";
            this.col_CRM_JobMast_EmpJobGuid.ReadOnly = true;
            this.col_CRM_JobMast_EmpJobGuid.Visible = false;
            this.col_CRM_JobMast_EmpJobGuid.Width = 60;
            // 
            // col_CRM_JobMast_BillNo
            // 
            this.col_CRM_JobMast_BillNo.DataPropertyName = "SourceBillNo";
            this.col_CRM_JobMast_BillNo.HeaderText = "单据编号";
            this.col_CRM_JobMast_BillNo.Name = "col_CRM_JobMast_BillNo";
            this.col_CRM_JobMast_BillNo.ReadOnly = true;
            this.col_CRM_JobMast_BillNo.Visible = false;
            this.col_CRM_JobMast_BillNo.Width = 80;
            // 
            // col_Seq
            // 
            this.col_Seq.DataPropertyName = "SeqNo";
            this.col_Seq.HeaderText = "次序";
            this.col_Seq.Name = "col_Seq";
            this.col_Seq.ReadOnly = true;
            this.col_Seq.Width = 60;
            // 
            // col_CRM_JobMast_JobName
            // 
            this.col_CRM_JobMast_JobName.DataPropertyName = "AuditEmpNames";
            this.col_CRM_JobMast_JobName.HeaderText = "审核人";
            this.col_CRM_JobMast_JobName.Name = "col_CRM_JobMast_JobName";
            this.col_CRM_JobMast_JobName.ReadOnly = true;
            this.col_CRM_JobMast_JobName.Width = 80;
            // 
            // col_CRM_JobMast_JobDate
            // 
            this.col_CRM_JobMast_JobDate.DataPropertyName = "AuditResult";
            this.col_CRM_JobMast_JobDate.HeaderText = "审核结果";
            this.col_CRM_JobMast_JobDate.Name = "col_CRM_JobMast_JobDate";
            this.col_CRM_JobMast_JobDate.ReadOnly = true;
            this.col_CRM_JobMast_JobDate.Width = 80;
            // 
            // col_CRM_JobMast_BelongEmpName
            // 
            this.col_CRM_JobMast_BelongEmpName.DataPropertyName = "AuditRemark";
            this.col_CRM_JobMast_BelongEmpName.HeaderText = "审核意见";
            this.col_CRM_JobMast_BelongEmpName.Name = "col_CRM_JobMast_BelongEmpName";
            this.col_CRM_JobMast_BelongEmpName.ReadOnly = true;
            this.col_CRM_JobMast_BelongEmpName.Width = 400;
            // 
            // col_CRM_JobMast_Summary
            // 
            this.col_CRM_JobMast_Summary.DataPropertyName = "CreatedTime";
            this.col_CRM_JobMast_Summary.HeaderText = "操作时间";
            this.col_CRM_JobMast_Summary.Name = "col_CRM_JobMast_Summary";
            this.col_CRM_JobMast_Summary.ReadOnly = true;
            this.col_CRM_JobMast_Summary.Width = 120;
            // 
            // panBottom
            // 
            this.panBottom.CanvasColor = System.Drawing.SystemColors.Control;
            this.panBottom.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panBottom.Controls.Add(this.btnSubmit);
            this.panBottom.Controls.Add(this.ucLabel1);
            this.panBottom.Controls.Add(this.txtBillNo);
            this.panBottom.Controls.Add(this.ucLabel2);
            this.panBottom.Controls.Add(this.txtTransferManID);
            this.panBottom.Controls.Add(this.ucLabel4);
            this.panBottom.Controls.Add(this.txtApproveStatus);
            this.panBottom.Controls.Add(this.ucLabel5);
            this.panBottom.Controls.Add(this.ucLabel3);
            this.panBottom.Controls.Add(this.txtTransferManName);
            this.panBottom.Controls.Add(this.txtCheckRemark);
            this.panBottom.Controls.Add(this.txtCurrentCheckMan);
            this.panBottom.Controls.Add(this.ucButton4);
            this.panBottom.Controls.Add(this.btnCancel);
            this.panBottom.Controls.Add(this.btnCancelCheck);
            this.panBottom.Controls.Add(this.btnNoPass);
            this.panBottom.Controls.Add(this.btnReturn);
            this.panBottom.Controls.Add(this.btnArgee);
            this.panBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panBottom.Location = new System.Drawing.Point(0, 215);
            this.panBottom.Name = "panBottom";
            this.panBottom.Size = new System.Drawing.Size(819, 152);
            this.panBottom.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panBottom.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panBottom.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panBottom.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panBottom.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panBottom.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panBottom.Style.GradientAngle = 90;
            this.panBottom.TabIndex = 0;
            // 
            // ucLabel1
            // 
            this.ucLabel1.AutoSize = true;
            this.ucLabel1.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabel1.ForeColor = System.Drawing.Color.Gray;
            this.ucLabel1.Location = new System.Drawing.Point(534, 16);
            this.ucLabel1.Name = "ucLabel1";
            this.ucLabel1.Size = new System.Drawing.Size(83, 12);
            this.ucLabel1.TabIndex = 5;
            this.ucLabel1.Text = "审核单据编号:";
            // 
            // txtBillNo
            // 
            // 
            // 
            // 
            this.txtBillNo.Border.Class = "TextBoxBorder";
            this.txtBillNo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtBillNo.EnterToNextControl = false;
            this.txtBillNo.Location = new System.Drawing.Point(623, 13);
            this.txtBillNo.Name = "txtBillNo";
            this.txtBillNo.ReadOnly = true;
            this.txtBillNo.Size = new System.Drawing.Size(162, 21);
            this.txtBillNo.TabIndex = 4;
            // 
            // ucLabel2
            // 
            this.ucLabel2.AutoSize = true;
            this.ucLabel2.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabel2.ForeColor = System.Drawing.Color.Gray;
            this.ucLabel2.Location = new System.Drawing.Point(277, 16);
            this.ucLabel2.Name = "ucLabel2";
            this.ucLabel2.Size = new System.Drawing.Size(83, 12);
            this.ucLabel2.TabIndex = 5;
            this.ucLabel2.Text = "审核单据状态:";
            // 
            // txtTransferManID
            // 
            // 
            // 
            // 
            this.txtTransferManID.Border.Class = "TextBoxBorder";
            this.txtTransferManID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTransferManID.EnterToNextControl = false;
            this.txtTransferManID.Location = new System.Drawing.Point(94, 101);
            this.txtTransferManID.Name = "txtTransferManID";
            this.txtTransferManID.ReadOnly = true;
            this.txtTransferManID.Size = new System.Drawing.Size(33, 21);
            this.txtTransferManID.TabIndex = 4;
            this.txtTransferManID.Visible = false;
            // 
            // ucLabel4
            // 
            this.ucLabel4.AutoSize = true;
            this.ucLabel4.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabel4.ForeColor = System.Drawing.Color.Gray;
            this.ucLabel4.Location = new System.Drawing.Point(13, 103);
            this.ucLabel4.Name = "ucLabel4";
            this.ucLabel4.Size = new System.Drawing.Size(35, 12);
            this.ucLabel4.TabIndex = 5;
            this.ucLabel4.Text = "转发:";
            this.ucLabel4.Visible = false;
            // 
            // txtApproveStatus
            // 
            // 
            // 
            // 
            this.txtApproveStatus.Border.Class = "TextBoxBorder";
            this.txtApproveStatus.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtApproveStatus.EnterToNextControl = false;
            this.txtApproveStatus.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtApproveStatus.ForeColor = System.Drawing.Color.Red;
            this.txtApproveStatus.Location = new System.Drawing.Point(366, 14);
            this.txtApproveStatus.Name = "txtApproveStatus";
            this.txtApproveStatus.ReadOnly = true;
            this.txtApproveStatus.Size = new System.Drawing.Size(162, 21);
            this.txtApproveStatus.TabIndex = 4;
            // 
            // ucLabel5
            // 
            this.ucLabel5.AutoSize = true;
            this.ucLabel5.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabel5.ForeColor = System.Drawing.Color.Gray;
            this.ucLabel5.Location = new System.Drawing.Point(13, 45);
            this.ucLabel5.Name = "ucLabel5";
            this.ucLabel5.Size = new System.Drawing.Size(59, 12);
            this.ucLabel5.TabIndex = 5;
            this.ucLabel5.Text = "审核意见:";
            // 
            // ucLabel3
            // 
            this.ucLabel3.AutoSize = true;
            this.ucLabel3.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabel3.ForeColor = System.Drawing.Color.Gray;
            this.ucLabel3.Location = new System.Drawing.Point(12, 16);
            this.ucLabel3.Name = "ucLabel3";
            this.ucLabel3.Size = new System.Drawing.Size(71, 12);
            this.ucLabel3.TabIndex = 5;
            this.ucLabel3.Text = "当前审核人:";
            // 
            // txtTransferManName
            // 
            // 
            // 
            // 
            this.txtTransferManName.Border.Class = "TextBoxBorder";
            this.txtTransferManName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTransferManName.ButtonCustom.Visible = true;
            this.txtTransferManName.EnterToNextControl = false;
            this.txtTransferManName.Location = new System.Drawing.Point(54, 99);
            this.txtTransferManName.Multiline = true;
            this.txtTransferManName.Name = "txtTransferManName";
            this.txtTransferManName.ReadOnly = true;
            this.txtTransferManName.Size = new System.Drawing.Size(44, 25);
            this.txtTransferManName.TabIndex = 4;
            this.txtTransferManName.Visible = false;
            // 
            // txtCheckRemark
            // 
            // 
            // 
            // 
            this.txtCheckRemark.Border.Class = "TextBoxBorder";
            this.txtCheckRemark.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCheckRemark.EnterToNextControl = false;
            this.txtCheckRemark.Location = new System.Drawing.Point(101, 42);
            this.txtCheckRemark.Multiline = true;
            this.txtCheckRemark.Name = "txtCheckRemark";
            this.txtCheckRemark.Size = new System.Drawing.Size(687, 48);
            this.txtCheckRemark.TabIndex = 4;
            // 
            // txtCurrentCheckMan
            // 
            // 
            // 
            // 
            this.txtCurrentCheckMan.Border.Class = "TextBoxBorder";
            this.txtCurrentCheckMan.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCurrentCheckMan.EnterToNextControl = false;
            this.txtCurrentCheckMan.Location = new System.Drawing.Point(101, 13);
            this.txtCurrentCheckMan.Name = "txtCurrentCheckMan";
            this.txtCurrentCheckMan.ReadOnly = true;
            this.txtCurrentCheckMan.Size = new System.Drawing.Size(162, 21);
            this.txtCurrentCheckMan.TabIndex = 4;
            // 
            // ucButton4
            // 
            this.ucButton4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ucButton4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ucButton4.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ucButton4.Location = new System.Drawing.Point(49, 80);
            this.ucButton4.Name = "ucButton4";
            this.ucButton4.Size = new System.Drawing.Size(78, 27);
            this.ucButton4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ucButton4.TabIndex = 3;
            this.ucButton4.Text = "转发确定";
            this.ucButton4.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.AutoSize = true;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.Location = new System.Drawing.Point(656, 103);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 36);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "取消";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSubmit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSubmit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSubmit.Image = global::ZNLCRM.UI.Properties.Resources.submit2;
            this.btnSubmit.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnSubmit.Location = new System.Drawing.Point(66, 102);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlS);
            this.btnSubmit.Size = new System.Drawing.Size(100, 36);
            this.btnSubmit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "提交";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancelCheck
            // 
            this.btnCancelCheck.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancelCheck.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelCheck.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancelCheck.Image = global::ZNLCRM.UI.Properties.Resources.takeback2;
            this.btnCancelCheck.ImageFixedSize = new System.Drawing.Size(22, 22);
            this.btnCancelCheck.Location = new System.Drawing.Point(188, 103);
            this.btnCancelCheck.Name = "btnCancelCheck";
            this.btnCancelCheck.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlS);
            this.btnCancelCheck.Size = new System.Drawing.Size(100, 36);
            this.btnCancelCheck.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancelCheck.TabIndex = 2;
            this.btnCancelCheck.Text = "收回";
            this.btnCancelCheck.Click += new System.EventHandler(this.btnCancelCheck_Click);
            // 
            // btnNoPass
            // 
            this.btnNoPass.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnNoPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNoPass.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnNoPass.Image = global::ZNLCRM.UI.Properties.Resources.nopass;
            this.btnNoPass.ImageFixedSize = new System.Drawing.Size(28, 28);
            this.btnNoPass.Location = new System.Drawing.Point(539, 103);
            this.btnNoPass.Name = "btnNoPass";
            this.btnNoPass.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlS);
            this.btnNoPass.Size = new System.Drawing.Size(100, 36);
            this.btnNoPass.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnNoPass.TabIndex = 1;
            this.btnNoPass.Text = "拒绝(N)";
            this.btnNoPass.Click += new System.EventHandler(this.btnNoPass_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnReturn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReturn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnReturn.Image = global::ZNLCRM.UI.Properties.Resources.returnsubmit;
            this.btnReturn.ImageFixedSize = new System.Drawing.Size(28, 28);
            this.btnReturn.Location = new System.Drawing.Point(422, 103);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlS);
            this.btnReturn.Size = new System.Drawing.Size(100, 36);
            this.btnReturn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnReturn.TabIndex = 1;
            this.btnReturn.Text = "驳回(B)";
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnArgee
            // 
            this.btnArgee.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnArgee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnArgee.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnArgee.Image = global::ZNLCRM.UI.Properties.Resources.checkok;
            this.btnArgee.ImageFixedSize = new System.Drawing.Size(28, 28);
            this.btnArgee.Location = new System.Drawing.Point(305, 103);
            this.btnArgee.Name = "btnArgee";
            this.btnArgee.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlS);
            this.btnArgee.Size = new System.Drawing.Size(100, 36);
            this.btnArgee.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnArgee.TabIndex = 1;
            this.btnArgee.Text = "同意(G)";
            this.btnArgee.Click += new System.EventHandler(this.btnArgee_Click);
            // 
            // frmAuditRecordList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 367);
            this.Controls.Add(this.panMid);
            this.Controls.Add(this.panBottom);
            this.Controls.Add(this.panTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmAuditRecordList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "审核清单";
            this.Load += new System.EventHandler(this.frmAuditRecordList_Load);
            this.panMid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.panBottom.ResumeLayout(false);
            this.panBottom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.UcPanelEx panTop;
        private Controls.UcPanelEx panMid;
        private Controls.UcPanelEx panBottom;
        private Controls.UcDataGridView dgvMain;
        private Controls.UcButton btnCancelCheck;
        private Controls.UcButton btnCancel;
        private Controls.UcLabel ucLabel1;
        private Controls.UcTextBox txtBillNo;
        private Controls.UcLabel ucLabel3;
        private Controls.UcTextBox txtCurrentCheckMan;
        private Controls.UcLabel ucLabel5;
        private Controls.UcTextBox txtCheckRemark;
        private Controls.UcButton btnNoPass;
        private Controls.UcButton btnReturn;
        private Controls.UcButton btnArgee;
        private Controls.UcLabel ucLabel4;
        private Controls.UcTextBox txtTransferManName;
        private Controls.UcButton ucButton4;
        private Controls.UcTextBox txtTransferManID;
        private Controls.UcLabel ucLabel2;
        private Controls.UcTextBox txtApproveStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_CRM_JobMast_EmpJobGuid;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_CRM_JobMast_BillNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Seq;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_CRM_JobMast_JobName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_CRM_JobMast_JobDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_CRM_JobMast_BelongEmpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_CRM_JobMast_Summary;
        private Controls.UcButton btnSubmit;
    }
}