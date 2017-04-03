namespace ZNLCRM.UI
{
    partial class frmTool
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
            this.txtPassword = new ZNLCRM.Controls.UcTextBox(this.components);
            this.ucLabelX1 = new ZNLCRM.Controls.UcLabelX(this.components);
            this.btnEncrypPassword = new ZNLCRM.Controls.UcButton(this.components);
            this.txtEncrypPassword = new ZNLCRM.Controls.UcTextBox(this.components);
            this.ucLabelX2 = new ZNLCRM.Controls.UcLabelX(this.components);
            this.ucTextBox1 = new ZNLCRM.Controls.UcTextBox(this.components);
            this.ucLabelX3 = new ZNLCRM.Controls.UcLabelX(this.components);
            this.ucButton1 = new ZNLCRM.Controls.UcButton(this.components);
            this.ucDateTimeInput1 = new ZNLCRM.Controls.UcDateTimeInput(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.ucDateTimeInput1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            // 
            // 
            // 
            this.txtPassword.Border.Class = "TextBoxBorder";
            this.txtPassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPassword.EnterToNextControl = false;
            this.txtPassword.Location = new System.Drawing.Point(92, 12);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(195, 21);
            this.txtPassword.TabIndex = 0;
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
            this.ucLabelX1.Location = new System.Drawing.Point(19, 6);
            this.ucLabelX1.Name = "ucLabelX1";
            this.ucLabelX1.Size = new System.Drawing.Size(67, 29);
            this.ucLabelX1.TabIndex = 1;
            this.ucLabelX1.Text = "密码原文：";
            // 
            // btnEncrypPassword
            // 
            this.btnEncrypPassword.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEncrypPassword.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnEncrypPassword.Location = new System.Drawing.Point(293, 12);
            this.btnEncrypPassword.Name = "btnEncrypPassword";
            this.btnEncrypPassword.Size = new System.Drawing.Size(111, 23);
            this.btnEncrypPassword.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnEncrypPassword.TabIndex = 2;
            this.btnEncrypPassword.Text = "生成加密字符";
            this.btnEncrypPassword.Click += new System.EventHandler(this.btnEncrypPassword_Click);
            // 
            // txtEncrypPassword
            // 
            // 
            // 
            // 
            this.txtEncrypPassword.Border.Class = "TextBoxBorder";
            this.txtEncrypPassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtEncrypPassword.EnterToNextControl = false;
            this.txtEncrypPassword.Location = new System.Drawing.Point(92, 39);
            this.txtEncrypPassword.Name = "txtEncrypPassword";
            this.txtEncrypPassword.Size = new System.Drawing.Size(312, 21);
            this.txtEncrypPassword.TabIndex = 3;
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
            this.ucLabelX2.Location = new System.Drawing.Point(19, 39);
            this.ucLabelX2.Name = "ucLabelX2";
            this.ucLabelX2.Size = new System.Drawing.Size(67, 29);
            this.ucLabelX2.TabIndex = 4;
            this.ucLabelX2.Text = "加密字符：";
            // 
            // ucTextBox1
            // 
            // 
            // 
            // 
            this.ucTextBox1.Border.Class = "TextBoxBorder";
            this.ucTextBox1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ucTextBox1.EnterToNextControl = false;
            this.ucTextBox1.Location = new System.Drawing.Point(92, 66);
            this.ucTextBox1.Name = "ucTextBox1";
            this.ucTextBox1.Size = new System.Drawing.Size(195, 21);
            this.ucTextBox1.TabIndex = 5;
            // 
            // ucLabelX3
            // 
            // 
            // 
            // 
            this.ucLabelX3.BackgroundStyle.Class = "";
            this.ucLabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ucLabelX3.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabelX3.ForeColor = System.Drawing.Color.Gray;
            this.ucLabelX3.Location = new System.Drawing.Point(19, 66);
            this.ucLabelX3.Name = "ucLabelX3";
            this.ucLabelX3.Size = new System.Drawing.Size(67, 29);
            this.ucLabelX3.TabIndex = 6;
            this.ucLabelX3.Text = "时间：";
            // 
            // ucButton1
            // 
            this.ucButton1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ucButton1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ucButton1.Location = new System.Drawing.Point(303, 66);
            this.ucButton1.Name = "ucButton1";
            this.ucButton1.Size = new System.Drawing.Size(75, 23);
            this.ucButton1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ucButton1.TabIndex = 7;
            this.ucButton1.Text = "ucButton1";
            this.ucButton1.Click += new System.EventHandler(this.ucButton1_Click);
            // 
            // ucDateTimeInput1
            // 
            // 
            // 
            // 
            this.ucDateTimeInput1.BackgroundStyle.Class = "DateTimeInputBackground";
            this.ucDateTimeInput1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ucDateTimeInput1.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.ucDateTimeInput1.IsPopupCalendarOpen = false;
            this.ucDateTimeInput1.Location = new System.Drawing.Point(191, 136);
            // 
            // 
            // 
            this.ucDateTimeInput1.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.ucDateTimeInput1.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.ucDateTimeInput1.MonthCalendar.BackgroundStyle.Class = "";
            this.ucDateTimeInput1.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ucDateTimeInput1.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.ucDateTimeInput1.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ucDateTimeInput1.MonthCalendar.DisplayMonth = new System.DateTime(2014, 11, 1, 0, 0, 0, 0);
            this.ucDateTimeInput1.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.ucDateTimeInput1.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.ucDateTimeInput1.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.ucDateTimeInput1.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ucDateTimeInput1.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.ucDateTimeInput1.Name = "ucDateTimeInput1";
            this.ucDateTimeInput1.Size = new System.Drawing.Size(200, 21);
            this.ucDateTimeInput1.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy/MM/dd HH:mm:ss";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(204, 163);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 21);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(204, 203);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 21);
            this.dateTimePicker2.TabIndex = 10;
            // 
            // frmTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 262);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.ucDateTimeInput1);
            this.Controls.Add(this.ucButton1);
            this.Controls.Add(this.ucLabelX3);
            this.Controls.Add(this.ucTextBox1);
            this.Controls.Add(this.ucLabelX2);
            this.Controls.Add(this.txtEncrypPassword);
            this.Controls.Add(this.btnEncrypPassword);
            this.Controls.Add(this.ucLabelX1);
            this.Controls.Add(this.txtPassword);
            this.Name = "frmTool";
            this.Text = "系统工具";
            this.Load += new System.EventHandler(this.frmTool_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ucDateTimeInput1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.UcTextBox txtPassword;
        private Controls.UcLabelX ucLabelX1;
        private Controls.UcButton btnEncrypPassword;
        private Controls.UcTextBox txtEncrypPassword;
        private Controls.UcLabelX ucLabelX2;
        private Controls.UcTextBox ucTextBox1;
        private Controls.UcLabelX ucLabelX3;
        private Controls.UcButton ucButton1;
        private Controls.UcDateTimeInput ucDateTimeInput1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}