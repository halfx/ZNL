namespace ZNLCRM.UI.SYS
{
    partial class frmCodeRuleEdit
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
            this.panMid = new ZNLCRM.Controls.UcPanel(this.components);
            this.panBottom = new ZNLCRM.Controls.UcPanel(this.components);
            this.btnCancel = new ZNLCRM.Controls.UcButton(this.components);
            this.btnSave = new ZNLCRM.Controls.UcButton(this.components);
            this.grpMain = new System.Windows.Forms.GroupBox();
            this.txtModuleName = new ZNLCRM.Controls.UcTextBox(this.components);
            this.txtLength = new ZNLCRM.Controls.UcTextBox(this.components);
            this.txtInitialValue = new ZNLCRM.Controls.UcTextBox(this.components);
            this.txtTableName = new ZNLCRM.Controls.UcTextBox(this.components);
            this.txtCredentialName = new ZNLCRM.Controls.UcTextBox(this.components);
            this.ucLabel1 = new ZNLCRM.Controls.UcLabel(this.components);
            this.chkIsDeleted = new ZNLCRM.Controls.UcCheckBox(this.components);
            this.ucLabel11 = new ZNLCRM.Controls.UcLabel(this.components);
            this.ucLabel12 = new ZNLCRM.Controls.UcLabel(this.components);
            this.chkIsContinuous = new ZNLCRM.Controls.UcCheckBox(this.components);
            this.ucLabel10 = new ZNLCRM.Controls.UcLabel(this.components);
            this.ucLabel9 = new ZNLCRM.Controls.UcLabel(this.components);
            this.ucLabel8 = new ZNLCRM.Controls.UcLabel(this.components);
            this.ucLabel7 = new ZNLCRM.Controls.UcLabel(this.components);
            this.ucLabel6 = new ZNLCRM.Controls.UcLabel(this.components);
            this.txtSuffix = new ZNLCRM.Controls.UcTextBox(this.components);
            this.ucLabel4 = new ZNLCRM.Controls.UcLabel(this.components);
            this.txtPrefix = new ZNLCRM.Controls.UcTextBox(this.components);
            this.ucLabel2 = new ZNLCRM.Controls.UcLabel(this.components);
            this.ucLabel3 = new ZNLCRM.Controls.UcLabel(this.components);
            this.chkIsOrderNo = new ZNLCRM.Controls.UcCheckBox(this.components);
            this.chkIsManualInput = new ZNLCRM.Controls.UcCheckBox(this.components);
            this.ucLabel5 = new ZNLCRM.Controls.UcLabel(this.components);
            this.txtCodeFieldName = new ZNLCRM.Controls.UcTextBox(this.components);
            this.panMid.SuspendLayout();
            this.panBottom.SuspendLayout();
            this.grpMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panMid
            // 
            this.panMid.BackColor = System.Drawing.Color.Transparent;
            this.panMid.Controls.Add(this.panBottom);
            this.panMid.Controls.Add(this.grpMain);
            this.panMid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panMid.Location = new System.Drawing.Point(0, 0);
            this.panMid.Name = "panMid";
            this.panMid.Padding = new System.Windows.Forms.Padding(5);
            this.panMid.Size = new System.Drawing.Size(398, 405);
            this.panMid.TabIndex = 4;
            // 
            // panBottom
            // 
            this.panBottom.BackColor = System.Drawing.Color.Transparent;
            this.panBottom.Controls.Add(this.btnCancel);
            this.panBottom.Controls.Add(this.btnSave);
            this.panBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panBottom.Location = new System.Drawing.Point(5, 347);
            this.panBottom.Name = "panBottom";
            this.panBottom.Size = new System.Drawing.Size(388, 53);
            this.panBottom.TabIndex = 11;
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.Location = new System.Drawing.Point(207, 15);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "取消";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Location = new System.Drawing.Point(111, 15);
            this.btnSave.Name = "btnSave";
            this.btnSave.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlS);
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "保存(S)";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // grpMain
            // 
            this.grpMain.Controls.Add(this.txtModuleName);
            this.grpMain.Controls.Add(this.txtLength);
            this.grpMain.Controls.Add(this.txtInitialValue);
            this.grpMain.Controls.Add(this.txtTableName);
            this.grpMain.Controls.Add(this.txtCredentialName);
            this.grpMain.Controls.Add(this.ucLabel1);
            this.grpMain.Controls.Add(this.chkIsDeleted);
            this.grpMain.Controls.Add(this.ucLabel11);
            this.grpMain.Controls.Add(this.ucLabel12);
            this.grpMain.Controls.Add(this.chkIsContinuous);
            this.grpMain.Controls.Add(this.ucLabel10);
            this.grpMain.Controls.Add(this.ucLabel9);
            this.grpMain.Controls.Add(this.ucLabel8);
            this.grpMain.Controls.Add(this.ucLabel7);
            this.grpMain.Controls.Add(this.ucLabel6);
            this.grpMain.Controls.Add(this.txtSuffix);
            this.grpMain.Controls.Add(this.ucLabel4);
            this.grpMain.Controls.Add(this.txtPrefix);
            this.grpMain.Controls.Add(this.ucLabel2);
            this.grpMain.Controls.Add(this.ucLabel3);
            this.grpMain.Controls.Add(this.chkIsOrderNo);
            this.grpMain.Controls.Add(this.chkIsManualInput);
            this.grpMain.Controls.Add(this.ucLabel5);
            this.grpMain.Controls.Add(this.txtCodeFieldName);
            this.grpMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpMain.Location = new System.Drawing.Point(5, 5);
            this.grpMain.Name = "grpMain";
            this.grpMain.Size = new System.Drawing.Size(388, 342);
            this.grpMain.TabIndex = 10;
            this.grpMain.TabStop = false;
            this.grpMain.Text = "主要信息";
            // 
            // txtModuleName
            // 
            // 
            // 
            // 
            this.txtModuleName.Border.Class = "TextBoxBorder";
            this.txtModuleName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtModuleName.EnterToNextControl = false;
            this.txtModuleName.Location = new System.Drawing.Point(103, 285);
            this.txtModuleName.Name = "txtModuleName";
            this.txtModuleName.Size = new System.Drawing.Size(126, 21);
            this.txtModuleName.TabIndex = 10;
            // 
            // txtLength
            // 
            // 
            // 
            // 
            this.txtLength.Border.Class = "TextBoxBorder";
            this.txtLength.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtLength.EnterToNextControl = false;
            this.txtLength.Location = new System.Drawing.Point(103, 238);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(126, 21);
            this.txtLength.TabIndex = 8;
            // 
            // txtInitialValue
            // 
            // 
            // 
            // 
            this.txtInitialValue.Border.Class = "TextBoxBorder";
            this.txtInitialValue.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtInitialValue.EnterToNextControl = false;
            this.txtInitialValue.Location = new System.Drawing.Point(103, 187);
            this.txtInitialValue.Name = "txtInitialValue";
            this.txtInitialValue.Size = new System.Drawing.Size(126, 21);
            this.txtInitialValue.TabIndex = 6;
            // 
            // txtTableName
            // 
            // 
            // 
            // 
            this.txtTableName.Border.Class = "TextBoxBorder";
            this.txtTableName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTableName.EnterToNextControl = false;
            this.txtTableName.Location = new System.Drawing.Point(103, 77);
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.Size = new System.Drawing.Size(126, 21);
            this.txtTableName.TabIndex = 2;
            // 
            // txtCredentialName
            // 
            // 
            // 
            // 
            this.txtCredentialName.Border.Class = "TextBoxBorder";
            this.txtCredentialName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCredentialName.EnterToNextControl = false;
            this.txtCredentialName.Location = new System.Drawing.Point(103, 23);
            this.txtCredentialName.Name = "txtCredentialName";
            this.txtCredentialName.Size = new System.Drawing.Size(126, 21);
            this.txtCredentialName.TabIndex = 0;
            // 
            // ucLabel1
            // 
            this.ucLabel1.AutoSize = true;
            this.ucLabel1.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabel1.ForeColor = System.Drawing.Color.Gray;
            this.ucLabel1.Location = new System.Drawing.Point(34, 314);
            this.ucLabel1.Name = "ucLabel1";
            this.ucLabel1.Size = new System.Drawing.Size(59, 12);
            this.ucLabel1.TabIndex = 27;
            this.ucLabel1.Text = "数据状态:";
            // 
            // chkIsDeleted
            // 
            // 
            // 
            // 
            this.chkIsDeleted.BackgroundStyle.Class = "";
            this.chkIsDeleted.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkIsDeleted.Enabled = false;
            this.chkIsDeleted.Location = new System.Drawing.Point(100, 310);
            this.chkIsDeleted.Name = "chkIsDeleted";
            this.chkIsDeleted.Size = new System.Drawing.Size(40, 23);
            this.chkIsDeleted.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chkIsDeleted.TabIndex = 11;
            this.chkIsDeleted.Text = "是";
            // 
            // ucLabel11
            // 
            this.ucLabel11.AutoSize = true;
            this.ucLabel11.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabel11.ForeColor = System.Drawing.Color.Gray;
            this.ucLabel11.Location = new System.Drawing.Point(10, 266);
            this.ucLabel11.Name = "ucLabel11";
            this.ucLabel11.Size = new System.Drawing.Size(83, 12);
            this.ucLabel11.TabIndex = 25;
            this.ucLabel11.Text = "是否手工输入:";
            // 
            // ucLabel12
            // 
            this.ucLabel12.AutoSize = true;
            this.ucLabel12.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabel12.ForeColor = System.Drawing.Color.Gray;
            this.ucLabel12.Location = new System.Drawing.Point(26, 217);
            this.ucLabel12.Name = "ucLabel12";
            this.ucLabel12.Size = new System.Drawing.Size(71, 12);
            this.ucLabel12.TabIndex = 24;
            this.ucLabel12.Text = "是否全连续:";
            // 
            // chkIsContinuous
            // 
            // 
            // 
            // 
            this.chkIsContinuous.BackgroundStyle.Class = "";
            this.chkIsContinuous.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkIsContinuous.Location = new System.Drawing.Point(100, 213);
            this.chkIsContinuous.Name = "chkIsContinuous";
            this.chkIsContinuous.Size = new System.Drawing.Size(40, 23);
            this.chkIsContinuous.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chkIsContinuous.TabIndex = 7;
            this.chkIsContinuous.Text = "是";
            // 
            // ucLabel10
            // 
            this.ucLabel10.AutoSize = true;
            this.ucLabel10.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabel10.ForeColor = System.Drawing.Color.Gray;
            this.ucLabel10.Location = new System.Drawing.Point(38, 56);
            this.ucLabel10.Name = "ucLabel10";
            this.ucLabel10.Size = new System.Drawing.Size(59, 12);
            this.ucLabel10.TabIndex = 21;
            this.ucLabel10.Text = "单据编号:";
            // 
            // ucLabel9
            // 
            this.ucLabel9.AutoSize = true;
            this.ucLabel9.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabel9.ForeColor = System.Drawing.Color.Gray;
            this.ucLabel9.Location = new System.Drawing.Point(38, 28);
            this.ucLabel9.Name = "ucLabel9";
            this.ucLabel9.Size = new System.Drawing.Size(59, 12);
            this.ucLabel9.TabIndex = 20;
            this.ucLabel9.Text = "单据名称:";
            // 
            // ucLabel8
            // 
            this.ucLabel8.AutoSize = true;
            this.ucLabel8.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabel8.ForeColor = System.Drawing.Color.Gray;
            this.ucLabel8.Location = new System.Drawing.Point(34, 289);
            this.ucLabel8.Name = "ucLabel8";
            this.ucLabel8.Size = new System.Drawing.Size(59, 12);
            this.ucLabel8.TabIndex = 17;
            this.ucLabel8.Text = "模块名称:";
            // 
            // ucLabel7
            // 
            this.ucLabel7.AutoSize = true;
            this.ucLabel7.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabel7.ForeColor = System.Drawing.Color.Gray;
            this.ucLabel7.Location = new System.Drawing.Point(34, 243);
            this.ucLabel7.Name = "ucLabel7";
            this.ucLabel7.Size = new System.Drawing.Size(59, 12);
            this.ucLabel7.TabIndex = 15;
            this.ucLabel7.Text = "编号长度:";
            // 
            // ucLabel6
            // 
            this.ucLabel6.AutoSize = true;
            this.ucLabel6.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabel6.ForeColor = System.Drawing.Color.Gray;
            this.ucLabel6.Location = new System.Drawing.Point(62, 164);
            this.ucLabel6.Name = "ucLabel6";
            this.ucLabel6.Size = new System.Drawing.Size(35, 12);
            this.ucLabel6.TabIndex = 14;
            this.ucLabel6.Text = "后缀:";
            // 
            // txtSuffix
            // 
            // 
            // 
            // 
            this.txtSuffix.Border.Class = "TextBoxBorder";
            this.txtSuffix.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSuffix.EnterToNextControl = false;
            this.txtSuffix.Location = new System.Drawing.Point(103, 159);
            this.txtSuffix.Name = "txtSuffix";
            this.txtSuffix.Size = new System.Drawing.Size(126, 21);
            this.txtSuffix.TabIndex = 5;
            // 
            // ucLabel4
            // 
            this.ucLabel4.AutoSize = true;
            this.ucLabel4.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabel4.ForeColor = System.Drawing.Color.Gray;
            this.ucLabel4.Location = new System.Drawing.Point(62, 137);
            this.ucLabel4.Name = "ucLabel4";
            this.ucLabel4.Size = new System.Drawing.Size(35, 12);
            this.ucLabel4.TabIndex = 12;
            this.ucLabel4.Text = "前缀:";
            // 
            // txtPrefix
            // 
            // 
            // 
            // 
            this.txtPrefix.Border.Class = "TextBoxBorder";
            this.txtPrefix.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPrefix.EnterToNextControl = false;
            this.txtPrefix.Location = new System.Drawing.Point(103, 133);
            this.txtPrefix.Name = "txtPrefix";
            this.txtPrefix.Size = new System.Drawing.Size(126, 21);
            this.txtPrefix.TabIndex = 4;
            // 
            // ucLabel2
            // 
            this.ucLabel2.AutoSize = true;
            this.ucLabel2.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabel2.ForeColor = System.Drawing.Color.Gray;
            this.ucLabel2.Location = new System.Drawing.Point(62, 82);
            this.ucLabel2.Name = "ucLabel2";
            this.ucLabel2.Size = new System.Drawing.Size(35, 12);
            this.ucLabel2.TabIndex = 9;
            this.ucLabel2.Text = "表名:";
            // 
            // ucLabel3
            // 
            this.ucLabel3.AutoSize = true;
            this.ucLabel3.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabel3.ForeColor = System.Drawing.Color.Gray;
            this.ucLabel3.Location = new System.Drawing.Point(38, 110);
            this.ucLabel3.Name = "ucLabel3";
            this.ucLabel3.Size = new System.Drawing.Size(59, 12);
            this.ucLabel3.TabIndex = 3;
            this.ucLabel3.Text = "编号字段:";
            // 
            // chkIsOrderNo
            // 
            // 
            // 
            // 
            this.chkIsOrderNo.BackgroundStyle.Class = "";
            this.chkIsOrderNo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkIsOrderNo.Location = new System.Drawing.Point(101, 50);
            this.chkIsOrderNo.Name = "chkIsOrderNo";
            this.chkIsOrderNo.Size = new System.Drawing.Size(39, 23);
            this.chkIsOrderNo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chkIsOrderNo.TabIndex = 1;
            this.chkIsOrderNo.Text = "是";
            // 
            // chkIsManualInput
            // 
            // 
            // 
            // 
            this.chkIsManualInput.BackgroundStyle.Class = "";
            this.chkIsManualInput.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chkIsManualInput.Location = new System.Drawing.Point(99, 260);
            this.chkIsManualInput.Name = "chkIsManualInput";
            this.chkIsManualInput.Size = new System.Drawing.Size(41, 23);
            this.chkIsManualInput.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chkIsManualInput.TabIndex = 9;
            this.chkIsManualInput.Text = "是";
            // 
            // ucLabel5
            // 
            this.ucLabel5.AutoSize = true;
            this.ucLabel5.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabel5.ForeColor = System.Drawing.Color.Gray;
            this.ucLabel5.Location = new System.Drawing.Point(50, 192);
            this.ucLabel5.Name = "ucLabel5";
            this.ucLabel5.Size = new System.Drawing.Size(47, 12);
            this.ucLabel5.TabIndex = 3;
            this.ucLabel5.Text = "初始值:";
            // 
            // txtCodeFieldName
            // 
            // 
            // 
            // 
            this.txtCodeFieldName.Border.Class = "TextBoxBorder";
            this.txtCodeFieldName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCodeFieldName.EnterToNextControl = false;
            this.txtCodeFieldName.Location = new System.Drawing.Point(103, 106);
            this.txtCodeFieldName.Name = "txtCodeFieldName";
            this.txtCodeFieldName.Size = new System.Drawing.Size(126, 21);
            this.txtCodeFieldName.TabIndex = 3;
            // 
            // frmCodeRuleEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 405);
            this.Controls.Add(this.panMid);
            this.MaximizeBox = false;
            this.Name = "frmCodeRuleEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "编码规则编辑";
            this.Load += new System.EventHandler(this.frmCodeRuleEdit_Load);
            this.panMid.ResumeLayout(false);
            this.panBottom.ResumeLayout(false);
            this.grpMain.ResumeLayout(false);
            this.grpMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.UcPanel panMid;
        private System.Windows.Forms.GroupBox grpMain;
        private Controls.UcLabel ucLabel3;
        private Controls.UcCheckBox chkIsOrderNo;
        private Controls.UcCheckBox chkIsManualInput;
        private Controls.UcTextBox txtCodeFieldName;
        private Controls.UcLabel ucLabel2;
        private Controls.UcLabel ucLabel4;
        private Controls.UcTextBox txtPrefix;
        private Controls.UcLabel ucLabel6;
        private Controls.UcTextBox txtSuffix;
        private Controls.UcLabel ucLabel7;
        private Controls.UcLabel ucLabel9;
        private Controls.UcLabel ucLabel8;
        private Controls.UcLabel ucLabel10;
        private Controls.UcLabel ucLabel5;
        private Controls.UcLabel ucLabel12;
        private Controls.UcCheckBox chkIsContinuous;
        private Controls.UcLabel ucLabel11;
        private Controls.UcLabel ucLabel1;
        private Controls.UcCheckBox chkIsDeleted;
        private Controls.UcPanel panBottom;
        private Controls.UcButton btnCancel;
        private Controls.UcButton btnSave;
        private Controls.UcTextBox txtCredentialName;
        private Controls.UcTextBox txtTableName;
        private Controls.UcTextBox txtInitialValue;
        private Controls.UcTextBox txtLength;
        private Controls.UcTextBox txtModuleName;


    }
}