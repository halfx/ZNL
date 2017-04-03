namespace ZNLCRM.UI.HR
{
    partial class frmJobEdit
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
            this.panMid = new ZNLCRM.Controls.UcPanel(this.components);
            this.grpContext = new System.Windows.Forms.GroupBox();
            this.rtxJobContext = new ZNLCRM.Controls.UcRichBox(this.components);
            this.panEditInfo = new ZNLCRM.Controls.UcPanel(this.components);
            this.ucLabel7 = new ZNLCRM.Controls.UcLabel(this.components);
            this.txtCreatedEmpName = new ZNLCRM.Controls.UcTextBox(this.components);
            this.btnUpload = new ZNLCRM.Controls.UcButton(this.components);
            this.txtCreatedTime = new ZNLCRM.Controls.UcTextBox(this.components);
            this.ucLabel10 = new ZNLCRM.Controls.UcLabel(this.components);
            this.ucLabel8 = new ZNLCRM.Controls.UcLabel(this.components);
            this.txtUpdatedTime = new ZNLCRM.Controls.UcTextBox(this.components);
            this.txtUpdatedEmpName = new ZNLCRM.Controls.UcTextBox(this.components);
            this.ucLabel9 = new ZNLCRM.Controls.UcLabel(this.components);
            this.grpMain = new System.Windows.Forms.GroupBox();
            this.dtaJobDate = new ZNLCRM.Controls.UcDateTimeInput(this.components);
            this.ucLabel1 = new ZNLCRM.Controls.UcLabel(this.components);
            this.ucLabel6 = new ZNLCRM.Controls.UcLabel(this.components);
            this.chkJobType3 = new ZNLCRM.Controls.UcCheckBox(this.components);
            this.ucLabel3 = new ZNLCRM.Controls.UcLabel(this.components);
            this.chkJobType2 = new ZNLCRM.Controls.UcCheckBox(this.components);
            this.ucLabel4 = new ZNLCRM.Controls.UcLabel(this.components);
            this.chkJobType1 = new ZNLCRM.Controls.UcCheckBox(this.components);
            this.ucLabel5 = new ZNLCRM.Controls.UcLabel(this.components);
            this.txtBelongEmpName = new ZNLCRM.Controls.UcTextBox(this.components);
            this.ucLabel2 = new ZNLCRM.Controls.UcLabel(this.components);
            this.txtJobName = new ZNLCRM.Controls.UcTextBox(this.components);
            this.txtBillNo = new ZNLCRM.Controls.UcTextBox(this.components);
            this.txtApproveStatus = new ZNLCRM.Controls.UcTextBox(this.components);
            this.grpAttach = new System.Windows.Forms.GroupBox();
            this.ucDataGridView1 = new ZNLCRM.Controls.UcDataGridView(this.components);
            this.col_Att_AttachGuID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Att_AttachName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Att_FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Att_Size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Att_FileType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Att_DownLoadNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Att_CreatedTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Att_CreatedEmpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Att_Operation = new System.Windows.Forms.DataGridViewLinkColumn();
            this.panBottom = new ZNLCRM.Controls.UcPanel(this.components);
            this.btnCancel = new ZNLCRM.Controls.UcButton(this.components);
            this.btnCancelCheck = new ZNLCRM.Controls.UcButton(this.components);
            this.btnCheck = new ZNLCRM.Controls.UcButton(this.components);
            this.btnSubmit = new ZNLCRM.Controls.UcButton(this.components);
            this.btnSave = new ZNLCRM.Controls.UcButton(this.components);
            this.btnTakeBack = new ZNLCRM.Controls.UcButton(this.components);
            this.panMid.SuspendLayout();
            this.grpContext.SuspendLayout();
            this.panEditInfo.SuspendLayout();
            this.grpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtaJobDate)).BeginInit();
            this.grpAttach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ucDataGridView1)).BeginInit();
            this.panBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // panMid
            // 
            this.panMid.BackColor = System.Drawing.Color.Transparent;
            this.panMid.Controls.Add(this.grpContext);
            this.panMid.Controls.Add(this.grpMain);
            this.panMid.Controls.Add(this.grpAttach);
            this.panMid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panMid.Location = new System.Drawing.Point(0, 0);
            this.panMid.Name = "panMid";
            this.panMid.Padding = new System.Windows.Forms.Padding(5);
            this.panMid.Size = new System.Drawing.Size(945, 434);
            this.panMid.TabIndex = 2;
            // 
            // grpContext
            // 
            this.grpContext.Controls.Add(this.rtxJobContext);
            this.grpContext.Controls.Add(this.panEditInfo);
            this.grpContext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpContext.Location = new System.Drawing.Point(5, 91);
            this.grpContext.Name = "grpContext";
            this.grpContext.Size = new System.Drawing.Size(935, 230);
            this.grpContext.TabIndex = 11;
            this.grpContext.TabStop = false;
            this.grpContext.Text = "报告内容";
            // 
            // rtxJobContext
            // 
            this.rtxJobContext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxJobContext.Location = new System.Drawing.Point(3, 17);
            this.rtxJobContext.Name = "rtxJobContext";
            this.rtxJobContext.Size = new System.Drawing.Size(929, 172);
            this.rtxJobContext.TabIndex = 0;
            this.rtxJobContext.Text = "";
            // 
            // panEditInfo
            // 
            this.panEditInfo.BackColor = System.Drawing.Color.Transparent;
            this.panEditInfo.Controls.Add(this.ucLabel7);
            this.panEditInfo.Controls.Add(this.txtCreatedEmpName);
            this.panEditInfo.Controls.Add(this.btnUpload);
            this.panEditInfo.Controls.Add(this.txtCreatedTime);
            this.panEditInfo.Controls.Add(this.ucLabel10);
            this.panEditInfo.Controls.Add(this.ucLabel8);
            this.panEditInfo.Controls.Add(this.txtUpdatedTime);
            this.panEditInfo.Controls.Add(this.txtUpdatedEmpName);
            this.panEditInfo.Controls.Add(this.ucLabel9);
            this.panEditInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panEditInfo.Location = new System.Drawing.Point(3, 189);
            this.panEditInfo.Name = "panEditInfo";
            this.panEditInfo.Size = new System.Drawing.Size(929, 38);
            this.panEditInfo.TabIndex = 5;
            // 
            // ucLabel7
            // 
            this.ucLabel7.AutoSize = true;
            this.ucLabel7.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabel7.ForeColor = System.Drawing.Color.Gray;
            this.ucLabel7.Location = new System.Drawing.Point(3, 11);
            this.ucLabel7.Name = "ucLabel7";
            this.ucLabel7.Size = new System.Drawing.Size(47, 12);
            this.ucLabel7.TabIndex = 3;
            this.ucLabel7.Text = "创建人:";
            // 
            // txtCreatedEmpName
            // 
            // 
            // 
            // 
            this.txtCreatedEmpName.Border.Class = "TextBoxBorder";
            this.txtCreatedEmpName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCreatedEmpName.EnterToNextControl = false;
            this.txtCreatedEmpName.Location = new System.Drawing.Point(56, 7);
            this.txtCreatedEmpName.Name = "txtCreatedEmpName";
            this.txtCreatedEmpName.ReadOnly = true;
            this.txtCreatedEmpName.Size = new System.Drawing.Size(122, 21);
            this.txtCreatedEmpName.TabIndex = 0;
            // 
            // btnUpload
            // 
            this.btnUpload.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnUpload.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnUpload.Location = new System.Drawing.Point(783, 5);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(75, 23);
            this.btnUpload.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnUpload.TabIndex = 4;
            this.btnUpload.Text = "上传附件";
            // 
            // txtCreatedTime
            // 
            // 
            // 
            // 
            this.txtCreatedTime.Border.Class = "TextBoxBorder";
            this.txtCreatedTime.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCreatedTime.EnterToNextControl = false;
            this.txtCreatedTime.Location = new System.Drawing.Point(249, 7);
            this.txtCreatedTime.Name = "txtCreatedTime";
            this.txtCreatedTime.ReadOnly = true;
            this.txtCreatedTime.Size = new System.Drawing.Size(122, 21);
            this.txtCreatedTime.TabIndex = 1;
            // 
            // ucLabel10
            // 
            this.ucLabel10.AutoSize = true;
            this.ucLabel10.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabel10.ForeColor = System.Drawing.Color.Gray;
            this.ucLabel10.Location = new System.Drawing.Point(574, 11);
            this.ucLabel10.Name = "ucLabel10";
            this.ucLabel10.Size = new System.Drawing.Size(59, 12);
            this.ucLabel10.TabIndex = 3;
            this.ucLabel10.Text = "修改时间:";
            // 
            // ucLabel8
            // 
            this.ucLabel8.AutoSize = true;
            this.ucLabel8.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabel8.ForeColor = System.Drawing.Color.Gray;
            this.ucLabel8.Location = new System.Drawing.Point(184, 11);
            this.ucLabel8.Name = "ucLabel8";
            this.ucLabel8.Size = new System.Drawing.Size(59, 12);
            this.ucLabel8.TabIndex = 3;
            this.ucLabel8.Text = "创建时间:";
            // 
            // txtUpdatedTime
            // 
            // 
            // 
            // 
            this.txtUpdatedTime.Border.Class = "TextBoxBorder";
            this.txtUpdatedTime.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtUpdatedTime.EnterToNextControl = false;
            this.txtUpdatedTime.Location = new System.Drawing.Point(639, 7);
            this.txtUpdatedTime.Name = "txtUpdatedTime";
            this.txtUpdatedTime.ReadOnly = true;
            this.txtUpdatedTime.Size = new System.Drawing.Size(122, 21);
            this.txtUpdatedTime.TabIndex = 3;
            // 
            // txtUpdatedEmpName
            // 
            // 
            // 
            // 
            this.txtUpdatedEmpName.Border.Class = "TextBoxBorder";
            this.txtUpdatedEmpName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtUpdatedEmpName.EnterToNextControl = false;
            this.txtUpdatedEmpName.Location = new System.Drawing.Point(446, 7);
            this.txtUpdatedEmpName.Name = "txtUpdatedEmpName";
            this.txtUpdatedEmpName.ReadOnly = true;
            this.txtUpdatedEmpName.Size = new System.Drawing.Size(122, 21);
            this.txtUpdatedEmpName.TabIndex = 2;
            // 
            // ucLabel9
            // 
            this.ucLabel9.AutoSize = true;
            this.ucLabel9.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabel9.ForeColor = System.Drawing.Color.Gray;
            this.ucLabel9.Location = new System.Drawing.Point(393, 11);
            this.ucLabel9.Name = "ucLabel9";
            this.ucLabel9.Size = new System.Drawing.Size(47, 12);
            this.ucLabel9.TabIndex = 3;
            this.ucLabel9.Text = "修改人:";
            // 
            // grpMain
            // 
            this.grpMain.Controls.Add(this.dtaJobDate);
            this.grpMain.Controls.Add(this.ucLabel1);
            this.grpMain.Controls.Add(this.ucLabel6);
            this.grpMain.Controls.Add(this.chkJobType3);
            this.grpMain.Controls.Add(this.ucLabel3);
            this.grpMain.Controls.Add(this.chkJobType2);
            this.grpMain.Controls.Add(this.ucLabel4);
            this.grpMain.Controls.Add(this.chkJobType1);
            this.grpMain.Controls.Add(this.ucLabel5);
            this.grpMain.Controls.Add(this.txtBelongEmpName);
            this.grpMain.Controls.Add(this.ucLabel2);
            this.grpMain.Controls.Add(this.txtJobName);
            this.grpMain.Controls.Add(this.txtBillNo);
            this.grpMain.Controls.Add(this.txtApproveStatus);
            this.grpMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpMain.Location = new System.Drawing.Point(5, 5);
            this.grpMain.Name = "grpMain";
            this.grpMain.Size = new System.Drawing.Size(935, 86);
            this.grpMain.TabIndex = 10;
            this.grpMain.TabStop = false;
            this.grpMain.Text = "主要信息";
            // 
            // dtaJobDate
            // 
            // 
            // 
            // 
            this.dtaJobDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtaJobDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtaJobDate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtaJobDate.ButtonDropDown.Visible = true;
            this.dtaJobDate.CustomFormat = "yyyy/MM/dd";
            this.dtaJobDate.IsPopupCalendarOpen = false;
            this.dtaJobDate.Location = new System.Drawing.Point(531, 51);
            // 
            // 
            // 
            this.dtaJobDate.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtaJobDate.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dtaJobDate.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtaJobDate.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtaJobDate.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtaJobDate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtaJobDate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtaJobDate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtaJobDate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtaJobDate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtaJobDate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtaJobDate.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtaJobDate.MonthCalendar.DisplayMonth = new System.DateTime(2014, 11, 1, 0, 0, 0, 0);
            this.dtaJobDate.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtaJobDate.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtaJobDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtaJobDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtaJobDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtaJobDate.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtaJobDate.MonthCalendar.TodayButtonVisible = true;
            this.dtaJobDate.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtaJobDate.Name = "dtaJobDate";
            this.dtaJobDate.Size = new System.Drawing.Size(122, 21);
            this.dtaJobDate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtaJobDate.TabIndex = 6;
            // 
            // ucLabel1
            // 
            this.ucLabel1.AutoSize = true;
            this.ucLabel1.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabel1.ForeColor = System.Drawing.Color.Gray;
            this.ucLabel1.Location = new System.Drawing.Point(6, 28);
            this.ucLabel1.Name = "ucLabel1";
            this.ucLabel1.Size = new System.Drawing.Size(59, 12);
            this.ucLabel1.TabIndex = 3;
            this.ucLabel1.Text = "报告单号:";
            // 
            // ucLabel6
            // 
            this.ucLabel6.AutoSize = true;
            this.ucLabel6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold);
            this.ucLabel6.ForeColor = System.Drawing.Color.Black;
            this.ucLabel6.Location = new System.Drawing.Point(466, 28);
            this.ucLabel6.Name = "ucLabel6";
            this.ucLabel6.Size = new System.Drawing.Size(64, 12);
            this.ucLabel6.TabIndex = 3;
            this.ucLabel6.Text = "审核状态:";
            // 
            // chkJobType3
            // 
            // 
            // 
            // 
            this.chkJobType3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkJobType3.Location = new System.Drawing.Point(399, 23);
            this.chkJobType3.Name = "chkJobType3";
            this.chkJobType3.Size = new System.Drawing.Size(65, 23);
            this.chkJobType3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chkJobType3.TabIndex = 8;
            this.chkJobType3.Text = "月报";
            // 
            // ucLabel3
            // 
            this.ucLabel3.AutoSize = true;
            this.ucLabel3.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabel3.ForeColor = System.Drawing.Color.Gray;
            this.ucLabel3.Location = new System.Drawing.Point(6, 55);
            this.ucLabel3.Name = "ucLabel3";
            this.ucLabel3.Size = new System.Drawing.Size(59, 12);
            this.ucLabel3.TabIndex = 3;
            this.ucLabel3.Text = "报告标题:";
            // 
            // chkJobType2
            // 
            // 
            // 
            // 
            this.chkJobType2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkJobType2.Location = new System.Drawing.Point(341, 23);
            this.chkJobType2.Name = "chkJobType2";
            this.chkJobType2.Size = new System.Drawing.Size(52, 23);
            this.chkJobType2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chkJobType2.TabIndex = 7;
            this.chkJobType2.Text = "周报";
            // 
            // ucLabel4
            // 
            this.ucLabel4.AutoSize = true;
            this.ucLabel4.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabel4.ForeColor = System.Drawing.Color.Gray;
            this.ucLabel4.Location = new System.Drawing.Point(466, 55);
            this.ucLabel4.Name = "ucLabel4";
            this.ucLabel4.Size = new System.Drawing.Size(59, 12);
            this.ucLabel4.TabIndex = 3;
            this.ucLabel4.Text = "报告日期:";
            // 
            // chkJobType1
            // 
            // 
            // 
            // 
            this.chkJobType1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkJobType1.Location = new System.Drawing.Point(289, 23);
            this.chkJobType1.Name = "chkJobType1";
            this.chkJobType1.Size = new System.Drawing.Size(58, 23);
            this.chkJobType1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chkJobType1.TabIndex = 1;
            this.chkJobType1.Text = "日报";
            // 
            // ucLabel5
            // 
            this.ucLabel5.AutoSize = true;
            this.ucLabel5.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabel5.ForeColor = System.Drawing.Color.Gray;
            this.ucLabel5.Location = new System.Drawing.Point(670, 55);
            this.ucLabel5.Name = "ucLabel5";
            this.ucLabel5.Size = new System.Drawing.Size(47, 12);
            this.ucLabel5.TabIndex = 3;
            this.ucLabel5.Text = "报告人:";
            // 
            // txtBelongEmpName
            // 
            // 
            // 
            // 
            this.txtBelongEmpName.Border.Class = "TextBoxBorder";
            this.txtBelongEmpName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtBelongEmpName.EnterToNextControl = false;
            this.txtBelongEmpName.Location = new System.Drawing.Point(723, 51);
            this.txtBelongEmpName.Name = "txtBelongEmpName";
            this.txtBelongEmpName.ReadOnly = true;
            this.txtBelongEmpName.Size = new System.Drawing.Size(122, 21);
            this.txtBelongEmpName.TabIndex = 5;
            // 
            // ucLabel2
            // 
            this.ucLabel2.AutoSize = true;
            this.ucLabel2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold);
            this.ucLabel2.ForeColor = System.Drawing.Color.Black;
            this.ucLabel2.Location = new System.Drawing.Point(218, 28);
            this.ucLabel2.Name = "ucLabel2";
            this.ucLabel2.Size = new System.Drawing.Size(64, 12);
            this.ucLabel2.TabIndex = 2;
            this.ucLabel2.Text = "报告类型:";
            // 
            // txtJobName
            // 
            // 
            // 
            // 
            this.txtJobName.Border.Class = "TextBoxBorder";
            this.txtJobName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtJobName.EnterToNextControl = false;
            this.txtJobName.Location = new System.Drawing.Point(75, 51);
            this.txtJobName.Name = "txtJobName";
            this.txtJobName.Size = new System.Drawing.Size(370, 21);
            this.txtJobName.TabIndex = 3;
            // 
            // txtBillNo
            // 
            // 
            // 
            // 
            this.txtBillNo.Border.Class = "TextBoxBorder";
            this.txtBillNo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtBillNo.EnterToNextControl = false;
            this.txtBillNo.Location = new System.Drawing.Point(75, 24);
            this.txtBillNo.Name = "txtBillNo";
            this.txtBillNo.ReadOnly = true;
            this.txtBillNo.Size = new System.Drawing.Size(122, 21);
            this.txtBillNo.TabIndex = 0;
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
            this.txtApproveStatus.ForeColor = System.Drawing.Color.Black;
            this.txtApproveStatus.Location = new System.Drawing.Point(531, 24);
            this.txtApproveStatus.Name = "txtApproveStatus";
            this.txtApproveStatus.ReadOnly = true;
            this.txtApproveStatus.Size = new System.Drawing.Size(122, 21);
            this.txtApproveStatus.TabIndex = 2;
            this.txtApproveStatus.Text = "未提交";
            // 
            // grpAttach
            // 
            this.grpAttach.Controls.Add(this.ucDataGridView1);
            this.grpAttach.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpAttach.Location = new System.Drawing.Point(5, 321);
            this.grpAttach.Name = "grpAttach";
            this.grpAttach.Size = new System.Drawing.Size(935, 108);
            this.grpAttach.TabIndex = 12;
            this.grpAttach.TabStop = false;
            this.grpAttach.Text = "附件";
            // 
            // ucDataGridView1
            // 
            this.ucDataGridView1.AllowUserToAddRows = false;
            this.ucDataGridView1.AllowUserToDeleteRows = false;
            this.ucDataGridView1.AllowUserToOrderColumns = true;
            this.ucDataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.ucDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ucDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_Att_AttachGuID,
            this.col_Att_AttachName,
            this.col_Att_FileName,
            this.col_Att_Size,
            this.col_Att_FileType,
            this.col_Att_DownLoadNum,
            this.col_Att_CreatedTime,
            this.col_Att_CreatedEmpName,
            this.col_Att_Operation});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ucDataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.ucDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.ucDataGridView1.HighlightSelectedColumnHeaders = false;
            this.ucDataGridView1.Location = new System.Drawing.Point(3, 17);
            this.ucDataGridView1.Name = "ucDataGridView1";
            this.ucDataGridView1.PaintEnhancedSelection = false;
            this.ucDataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ucDataGridView1.RowTemplate.Height = 23;
            this.ucDataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ucDataGridView1.SelectAllSignVisible = false;
            this.ucDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.ucDataGridView1.Size = new System.Drawing.Size(929, 88);
            this.ucDataGridView1.TabIndex = 0;
            // 
            // col_Att_AttachGuID
            // 
            this.col_Att_AttachGuID.HeaderText = "key";
            this.col_Att_AttachGuID.Name = "col_Att_AttachGuID";
            // 
            // col_Att_AttachName
            // 
            this.col_Att_AttachName.HeaderText = "附件名称";
            this.col_Att_AttachName.Name = "col_Att_AttachName";
            // 
            // col_Att_FileName
            // 
            this.col_Att_FileName.HeaderText = "文件名";
            this.col_Att_FileName.Name = "col_Att_FileName";
            // 
            // col_Att_Size
            // 
            this.col_Att_Size.HeaderText = "大小";
            this.col_Att_Size.Name = "col_Att_Size";
            this.col_Att_Size.Width = 60;
            // 
            // col_Att_FileType
            // 
            this.col_Att_FileType.HeaderText = "文件类型";
            this.col_Att_FileType.Name = "col_Att_FileType";
            this.col_Att_FileType.Width = 60;
            // 
            // col_Att_DownLoadNum
            // 
            this.col_Att_DownLoadNum.HeaderText = "下载次数";
            this.col_Att_DownLoadNum.Name = "col_Att_DownLoadNum";
            this.col_Att_DownLoadNum.Width = 60;
            // 
            // col_Att_CreatedTime
            // 
            this.col_Att_CreatedTime.HeaderText = "创建时间";
            this.col_Att_CreatedTime.Name = "col_Att_CreatedTime";
            // 
            // col_Att_CreatedEmpName
            // 
            this.col_Att_CreatedEmpName.HeaderText = "创建人";
            this.col_Att_CreatedEmpName.Name = "col_Att_CreatedEmpName";
            // 
            // col_Att_Operation
            // 
            this.col_Att_Operation.HeaderText = "下载";
            this.col_Att_Operation.Name = "col_Att_Operation";
            this.col_Att_Operation.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_Att_Operation.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.col_Att_Operation.Width = 60;
            // 
            // panBottom
            // 
            this.panBottom.BackColor = System.Drawing.Color.Transparent;
            this.panBottom.Controls.Add(this.btnCancel);
            this.panBottom.Controls.Add(this.btnCancelCheck);
            this.panBottom.Controls.Add(this.btnTakeBack);
            this.panBottom.Controls.Add(this.btnCheck);
            this.panBottom.Controls.Add(this.btnSubmit);
            this.panBottom.Controls.Add(this.btnSave);
            this.panBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panBottom.Location = new System.Drawing.Point(0, 434);
            this.panBottom.Name = "panBottom";
            this.panBottom.Size = new System.Drawing.Size(945, 40);
            this.panBottom.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.Location = new System.Drawing.Point(663, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 26);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "取消";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCancelCheck
            // 
            this.btnCancelCheck.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancelCheck.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelCheck.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancelCheck.Image = global::ZNLCRM.UI.Properties.Resources.cancel_1;
            this.btnCancelCheck.ImageFixedSize = new System.Drawing.Size(16, 16);
            this.btnCancelCheck.Location = new System.Drawing.Point(570, 6);
            this.btnCancelCheck.Name = "btnCancelCheck";
            this.btnCancelCheck.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlS);
            this.btnCancelCheck.Size = new System.Drawing.Size(75, 26);
            this.btnCancelCheck.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancelCheck.TabIndex = 0;
            this.btnCancelCheck.Text = "撤单";
            this.btnCancelCheck.Click += new System.EventHandler(this.btnCancelCheck_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCheck.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCheck.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCheck.Image = global::ZNLCRM.UI.Properties.Resources.audit;
            this.btnCheck.ImageFixedSize = new System.Drawing.Size(16, 16);
            this.btnCheck.Location = new System.Drawing.Point(482, 6);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlS);
            this.btnCheck.Size = new System.Drawing.Size(75, 26);
            this.btnCheck.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCheck.TabIndex = 0;
            this.btnCheck.Text = "审核(K)";
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSubmit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSubmit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSubmit.Image = global::ZNLCRM.UI.Properties.Resources.submit;
            this.btnSubmit.Location = new System.Drawing.Point(304, 6);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlS);
            this.btnSubmit.Size = new System.Drawing.Size(75, 26);
            this.btnSubmit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "提交(T)";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Image = global::ZNLCRM.UI.Properties.Resources.save_1;
            this.btnSave.Location = new System.Drawing.Point(194, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlS);
            this.btnSave.Size = new System.Drawing.Size(75, 26);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "保存(S)";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnTakeBack
            // 
            this.btnTakeBack.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTakeBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTakeBack.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnTakeBack.Image = global::ZNLCRM.UI.Properties.Resources.refresh_1;
            this.btnTakeBack.ImageFixedSize = new System.Drawing.Size(16, 16);
            this.btnTakeBack.Location = new System.Drawing.Point(394, 6);
            this.btnTakeBack.Name = "btnTakeBack";
            this.btnTakeBack.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlS);
            this.btnTakeBack.Size = new System.Drawing.Size(75, 26);
            this.btnTakeBack.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnTakeBack.TabIndex = 0;
            this.btnTakeBack.Text = "收回(T)";
            this.btnTakeBack.Click += new System.EventHandler(this.btnTakeBack_Click);
            // 
            // frmJobEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 474);
            this.Controls.Add(this.panMid);
            this.Controls.Add(this.panBottom);
            this.Name = "frmJobEdit";
            this.Text = "工作报告编辑";
            this.Load += new System.EventHandler(this.frmJobEdit_Load);
            this.panMid.ResumeLayout(false);
            this.grpContext.ResumeLayout(false);
            this.panEditInfo.ResumeLayout(false);
            this.panEditInfo.PerformLayout();
            this.grpMain.ResumeLayout(false);
            this.grpMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtaJobDate)).EndInit();
            this.grpAttach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ucDataGridView1)).EndInit();
            this.panBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.UcPanel panMid;
        private Controls.UcTextBox txtBelongEmpName;
        private Controls.UcTextBox txtBillNo;
        private Controls.UcLabel ucLabel2;
        private Controls.UcLabel ucLabel1;
        private Controls.UcPanel panBottom;
        private Controls.UcCheckBox chkJobType3;
        private Controls.UcCheckBox chkJobType2;
        private Controls.UcCheckBox chkJobType1;
        private Controls.UcTextBox txtJobName;
        private Controls.UcLabel ucLabel3;
        private Controls.UcLabel ucLabel4;
        private Controls.UcLabel ucLabel5;
        private Controls.UcTextBox txtApproveStatus;
        private Controls.UcLabel ucLabel6;
        private System.Windows.Forms.GroupBox grpContext;
        private System.Windows.Forms.GroupBox grpMain;
        private Controls.UcRichBox rtxJobContext;
        private Controls.UcButton btnCancel;
        private Controls.UcButton btnSave;
        private Controls.UcLabel ucLabel10;
        private Controls.UcTextBox txtUpdatedTime;
        private Controls.UcLabel ucLabel9;
        private Controls.UcTextBox txtUpdatedEmpName;
        private Controls.UcLabel ucLabel8;
        private Controls.UcTextBox txtCreatedTime;
        private Controls.UcLabel ucLabel7;
        private Controls.UcTextBox txtCreatedEmpName;
        private System.Windows.Forms.GroupBox grpAttach;
        private Controls.UcDataGridView ucDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Att_AttachGuID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Att_AttachName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Att_FileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Att_Size;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Att_FileType;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Att_DownLoadNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Att_CreatedTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Att_CreatedEmpName;
        private System.Windows.Forms.DataGridViewLinkColumn col_Att_Operation;
        private Controls.UcButton btnUpload;
        private Controls.UcPanel panEditInfo;
        private Controls.UcDateTimeInput dtaJobDate;
        private Controls.UcButton btnCheck;
        private Controls.UcButton btnSubmit;
        private Controls.UcButton btnCancelCheck;
        private Controls.UcButton btnTakeBack;

    }
}