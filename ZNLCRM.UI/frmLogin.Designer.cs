namespace ZNLCRM.UI
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.panMid = new ZNLCRM.Controls.UcPanel(this.components);
            this.chkRemUserPwd = new ZNLCRM.Controls.UcCheckBox(this.components);
            this.chkRemUserName = new ZNLCRM.Controls.UcCheckBox(this.components);
            this.chkRemCompanyName = new ZNLCRM.Controls.UcCheckBox(this.components);
            this.txtUserPwd = new ZNLCRM.Controls.UcTextBox(this.components);
            this.txtUserName = new ZNLCRM.Controls.UcTextBox(this.components);
            this.txtCompanyName = new ZNLCRM.Controls.UcTextBox(this.components);
            this.ucLabelX3 = new ZNLCRM.Controls.UcLabelX(this.components);
            this.ucLabelX2 = new ZNLCRM.Controls.UcLabelX(this.components);
            this.ucLabelX1 = new ZNLCRM.Controls.UcLabelX(this.components);
            this.pWaiting = new ZNLCRM.Controls.UcPanel(this.components);
            this.ucLabel1 = new ZNLCRM.Controls.UcLabel(this.components);
            this.crpWaiting = new DevComponents.DotNetBar.Controls.CircularProgress();
            this.panTop = new ZNLCRM.Controls.UcPanel(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panBottom = new ZNLCRM.Controls.UcPanel(this.components);
            this.btnCancel = new ZNLCRM.Controls.UcButton(this.components);
            this.btnLogin = new ZNLCRM.Controls.UcButton(this.components);
            this.panMid.SuspendLayout();
            this.pWaiting.SuspendLayout();
            this.panTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // panMid
            // 
            this.panMid.BackColor = System.Drawing.Color.Transparent;
            this.panMid.Controls.Add(this.chkRemUserPwd);
            this.panMid.Controls.Add(this.chkRemUserName);
            this.panMid.Controls.Add(this.chkRemCompanyName);
            this.panMid.Controls.Add(this.txtUserPwd);
            this.panMid.Controls.Add(this.txtUserName);
            this.panMid.Controls.Add(this.txtCompanyName);
            this.panMid.Controls.Add(this.ucLabelX3);
            this.panMid.Controls.Add(this.ucLabelX2);
            this.panMid.Controls.Add(this.ucLabelX1);
            this.panMid.Controls.Add(this.pWaiting);
            this.panMid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panMid.Location = new System.Drawing.Point(0, 90);
            this.panMid.Name = "panMid";
            this.panMid.Size = new System.Drawing.Size(438, 98);
            this.panMid.TabIndex = 0;
            // 
            // chkRemUserPwd
            // 
            // 
            // 
            // 
            this.chkRemUserPwd.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkRemUserPwd.Location = new System.Drawing.Point(341, 71);
            this.chkRemUserPwd.Name = "chkRemUserPwd";
            this.chkRemUserPwd.Size = new System.Drawing.Size(81, 23);
            this.chkRemUserPwd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chkRemUserPwd.TabIndex = 5;
            this.chkRemUserPwd.Text = "记住密码";
            // 
            // chkRemUserName
            // 
            // 
            // 
            // 
            this.chkRemUserName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkRemUserName.Location = new System.Drawing.Point(341, 42);
            this.chkRemUserName.Name = "chkRemUserName";
            this.chkRemUserName.Size = new System.Drawing.Size(89, 23);
            this.chkRemUserName.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chkRemUserName.TabIndex = 3;
            this.chkRemUserName.Text = "记住登录名";
            // 
            // chkRemCompanyName
            // 
            // 
            // 
            // 
            this.chkRemCompanyName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkRemCompanyName.Checked = true;
            this.chkRemCompanyName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRemCompanyName.CheckValue = "Y";
            this.chkRemCompanyName.Location = new System.Drawing.Point(342, 13);
            this.chkRemCompanyName.Name = "chkRemCompanyName";
            this.chkRemCompanyName.Size = new System.Drawing.Size(88, 23);
            this.chkRemCompanyName.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chkRemCompanyName.TabIndex = 1;
            this.chkRemCompanyName.Text = "记住公司名";
            // 
            // txtUserPwd
            // 
            // 
            // 
            // 
            this.txtUserPwd.Border.Class = "TextBoxBorder";
            this.txtUserPwd.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtUserPwd.EnterToNextControl = false;
            this.txtUserPwd.Location = new System.Drawing.Point(87, 72);
            this.txtUserPwd.Name = "txtUserPwd";
            this.txtUserPwd.PasswordChar = '*';
            this.txtUserPwd.PreventEnterBeep = true;
            this.txtUserPwd.Size = new System.Drawing.Size(239, 21);
            this.txtUserPwd.TabIndex = 4;
            this.txtUserPwd.Text = "888888";
            // 
            // txtUserName
            // 
            // 
            // 
            // 
            this.txtUserName.Border.Class = "TextBoxBorder";
            this.txtUserName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtUserName.EnterToNextControl = false;
            this.txtUserName.Location = new System.Drawing.Point(87, 43);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.PreventEnterBeep = true;
            this.txtUserName.Size = new System.Drawing.Size(239, 21);
            this.txtUserName.TabIndex = 2;
            this.txtUserName.Text = "sysadmin";
            // 
            // txtCompanyName
            // 
            // 
            // 
            // 
            this.txtCompanyName.Border.Class = "TextBoxBorder";
            this.txtCompanyName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCompanyName.EnterToNextControl = false;
            this.txtCompanyName.Location = new System.Drawing.Point(87, 14);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.PreventEnterBeep = true;
            this.txtCompanyName.Size = new System.Drawing.Size(239, 21);
            this.txtCompanyName.TabIndex = 0;
            this.txtCompanyName.Text = "深圳正能量网络科技有限公司";
            // 
            // ucLabelX3
            // 
            // 
            // 
            // 
            this.ucLabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ucLabelX3.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabelX3.ForeColor = System.Drawing.Color.Gray;
            this.ucLabelX3.Location = new System.Drawing.Point(25, 71);
            this.ucLabelX3.Name = "ucLabelX3";
            this.ucLabelX3.Size = new System.Drawing.Size(76, 23);
            this.ucLabelX3.TabIndex = 2;
            this.ucLabelX3.Text = "密码:";
            // 
            // ucLabelX2
            // 
            // 
            // 
            // 
            this.ucLabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ucLabelX2.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabelX2.ForeColor = System.Drawing.Color.Gray;
            this.ucLabelX2.Location = new System.Drawing.Point(25, 42);
            this.ucLabelX2.Name = "ucLabelX2";
            this.ucLabelX2.Size = new System.Drawing.Size(76, 23);
            this.ucLabelX2.TabIndex = 2;
            this.ucLabelX2.Text = "登录名:";
            // 
            // ucLabelX1
            // 
            // 
            // 
            // 
            this.ucLabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ucLabelX1.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabelX1.ForeColor = System.Drawing.Color.Gray;
            this.ucLabelX1.Location = new System.Drawing.Point(25, 13);
            this.ucLabelX1.Name = "ucLabelX1";
            this.ucLabelX1.Size = new System.Drawing.Size(76, 23);
            this.ucLabelX1.TabIndex = 2;
            this.ucLabelX1.Text = "公司名:";
            // 
            // pWaiting
            // 
            this.pWaiting.BackColor = System.Drawing.Color.Transparent;
            this.pWaiting.Controls.Add(this.ucLabel1);
            this.pWaiting.Controls.Add(this.crpWaiting);
            this.pWaiting.Location = new System.Drawing.Point(3, 1);
            this.pWaiting.Name = "pWaiting";
            this.pWaiting.Size = new System.Drawing.Size(436, 97);
            this.pWaiting.TabIndex = 6;
            this.pWaiting.Visible = false;
            // 
            // ucLabel1
            // 
            this.ucLabel1.AutoSize = true;
            this.ucLabel1.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabel1.ForeColor = System.Drawing.Color.Red;
            this.ucLabel1.Location = new System.Drawing.Point(71, 37);
            this.ucLabel1.Name = "ucLabel1";
            this.ucLabel1.Size = new System.Drawing.Size(125, 12);
            this.ucLabel1.TabIndex = 1;
            this.ucLabel1.Text = "正在登录中,请稍候...";
            // 
            // crpWaiting
            // 
            // 
            // 
            // 
            this.crpWaiting.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.crpWaiting.Location = new System.Drawing.Point(29, 29);
            this.crpWaiting.Name = "crpWaiting";
            this.crpWaiting.Size = new System.Drawing.Size(36, 23);
            this.crpWaiting.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.crpWaiting.TabIndex = 0;
            // 
            // panTop
            // 
            this.panTop.BackColor = System.Drawing.Color.Transparent;
            this.panTop.Controls.Add(this.pictureBox1);
            this.panTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panTop.Location = new System.Drawing.Point(0, 0);
            this.panTop.Name = "panTop";
            this.panTop.Size = new System.Drawing.Size(438, 90);
            this.panTop.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(438, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panBottom
            // 
            this.panBottom.BackColor = System.Drawing.Color.Transparent;
            this.panBottom.Controls.Add(this.btnCancel);
            this.panBottom.Controls.Add(this.btnLogin);
            this.panBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panBottom.Location = new System.Drawing.Point(0, 188);
            this.panBottom.Name = "panBottom";
            this.panBottom.Size = new System.Drawing.Size(438, 54);
            this.panBottom.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.Image = global::ZNLCRM.UI.Properties.Resources.sign_out;
            this.btnCancel.ImageFixedSize = new System.Drawing.Size(18, 18);
            this.btnCancel.Location = new System.Drawing.Point(225, 17);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "关闭";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLogin.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnLogin.Image = global::ZNLCRM.UI.Properties.Resources.dept;
            this.btnLogin.Location = new System.Drawing.Point(127, 17);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "登录";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 242);
            this.ControlBox = false;
            this.Controls.Add(this.panMid);
            this.Controls.Add(this.panTop);
            this.Controls.Add(this.panBottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "正能量ERP登录";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.panMid.ResumeLayout(false);
            this.pWaiting.ResumeLayout(false);
            this.pWaiting.PerformLayout();
            this.panTop.ResumeLayout(false);
            this.panTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.UcPanel panMid;
        private Controls.UcTextBox txtCompanyName;
        private Controls.UcLabelX ucLabelX1;
        private Controls.UcTextBox txtUserPwd;
        private Controls.UcTextBox txtUserName;
        private Controls.UcLabelX ucLabelX3;
        private Controls.UcLabelX ucLabelX2;
        private Controls.UcPanel panTop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Controls.UcCheckBox chkRemUserName;
        private Controls.UcCheckBox chkRemCompanyName;
        private Controls.UcPanel panBottom;
        private Controls.UcCheckBox chkRemUserPwd;
        private Controls.UcButton btnCancel;
        private Controls.UcButton btnLogin;
        private Controls.UcPanel pWaiting;
        private Controls.UcLabel ucLabel1;
        private DevComponents.DotNetBar.Controls.CircularProgress crpWaiting;
    }
}