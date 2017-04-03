namespace ZNLCRM.UI.SYS
{
    partial class frmEditModuleRole
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
            this.ucLabel11 = new ZNLCRM.Controls.UcLabel(this.components);
            this.btnCloseEditModule = new ZNLCRM.Controls.UcButton(this.components);
            this.ucLabel10 = new ZNLCRM.Controls.UcLabel(this.components);
            this.ucLabel4 = new ZNLCRM.Controls.UcLabel(this.components);
            this.ucLabel12 = new ZNLCRM.Controls.UcLabel(this.components);
            this.ucLabel9 = new ZNLCRM.Controls.UcLabel(this.components);
            this.txtModuleName = new ZNLCRM.Controls.UcTextBox(this.components);
            this.txtModuleCode = new ZNLCRM.Controls.UcTextBox(this.components);
            this.btnSaveEditModule = new ZNLCRM.Controls.UcButton(this.components);
            this.txtEmpName = new ZNLCRM.Controls.UcTextBox(this.components);
            this.txtEmpID = new ZNLCRM.Controls.UcTextBox(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbx_Pint = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.cbx_Del = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.cbx_Outpint = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.cbx_Import = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.cbx_ViewAll = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.cbx_Edit = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.cbx_App = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.cbx_News = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.cbxSearch = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ucLabel11
            // 
            this.ucLabel11.AutoSize = true;
            this.ucLabel11.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabel11.ForeColor = System.Drawing.Color.Gray;
            this.ucLabel11.Location = new System.Drawing.Point(79, 18);
            this.ucLabel11.Name = "ucLabel11";
            this.ucLabel11.Size = new System.Drawing.Size(65, 12);
            this.ucLabel11.TabIndex = 26;
            this.ucLabel11.Text = "员工编号：";
            // 
            // btnCloseEditModule
            // 
            this.btnCloseEditModule.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCloseEditModule.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCloseEditModule.Location = new System.Drawing.Point(228, 241);
            this.btnCloseEditModule.Name = "btnCloseEditModule";
            this.btnCloseEditModule.Size = new System.Drawing.Size(75, 23);
            this.btnCloseEditModule.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCloseEditModule.TabIndex = 21;
            this.btnCloseEditModule.Text = "取消";
            this.btnCloseEditModule.Click += new System.EventHandler(this.btnCloseEditModule_Click);
            // 
            // ucLabel10
            // 
            this.ucLabel10.AutoSize = true;
            this.ucLabel10.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabel10.ForeColor = System.Drawing.Color.Gray;
            this.ucLabel10.Location = new System.Drawing.Point(79, 106);
            this.ucLabel10.Name = "ucLabel10";
            this.ucLabel10.Size = new System.Drawing.Size(65, 12);
            this.ucLabel10.TabIndex = 22;
            this.ucLabel10.Text = "模块名称：";
            // 
            // ucLabel4
            // 
            this.ucLabel4.AutoSize = true;
            this.ucLabel4.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabel4.ForeColor = System.Drawing.Color.Gray;
            this.ucLabel4.Location = new System.Drawing.Point(79, 49);
            this.ucLabel4.Name = "ucLabel4";
            this.ucLabel4.Size = new System.Drawing.Size(65, 12);
            this.ucLabel4.TabIndex = 24;
            this.ucLabel4.Text = "员工名称：";
            // 
            // ucLabel12
            // 
            this.ucLabel12.AutoSize = true;
            this.ucLabel12.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabel12.ForeColor = System.Drawing.Color.Gray;
            this.ucLabel12.Location = new System.Drawing.Point(79, 79);
            this.ucLabel12.Name = "ucLabel12";
            this.ucLabel12.Size = new System.Drawing.Size(65, 12);
            this.ucLabel12.TabIndex = 23;
            this.ucLabel12.Text = "模块编号：";
            // 
            // ucLabel9
            // 
            this.ucLabel9.AutoSize = true;
            this.ucLabel9.Font = new System.Drawing.Font("宋体", 9F);
            this.ucLabel9.ForeColor = System.Drawing.Color.Gray;
            this.ucLabel9.Location = new System.Drawing.Point(79, 136);
            this.ucLabel9.Name = "ucLabel9";
            this.ucLabel9.Size = new System.Drawing.Size(65, 12);
            this.ucLabel9.TabIndex = 25;
            this.ucLabel9.Text = "操作行为：";
            // 
            // txtModuleName
            // 
            // 
            // 
            // 
            this.txtModuleName.Border.Class = "TextBoxBorder";
            this.txtModuleName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtModuleName.EnterToNextControl = false;
            this.txtModuleName.Location = new System.Drawing.Point(149, 103);
            this.txtModuleName.Name = "txtModuleName";
            this.txtModuleName.Size = new System.Drawing.Size(153, 21);
            this.txtModuleName.TabIndex = 19;
            // 
            // txtModuleCode
            // 
            // 
            // 
            // 
            this.txtModuleCode.Border.Class = "TextBoxBorder";
            this.txtModuleCode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtModuleCode.EnterToNextControl = false;
            this.txtModuleCode.Location = new System.Drawing.Point(150, 74);
            this.txtModuleCode.Name = "txtModuleCode";
            this.txtModuleCode.ReadOnly = true;
            this.txtModuleCode.Size = new System.Drawing.Size(153, 21);
            this.txtModuleCode.TabIndex = 18;
            // 
            // btnSaveEditModule
            // 
            this.btnSaveEditModule.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSaveEditModule.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSaveEditModule.Image = global::ZNLCRM.UI.Properties.Resources.save_1;
            this.btnSaveEditModule.Location = new System.Drawing.Point(81, 239);
            this.btnSaveEditModule.Name = "btnSaveEditModule";
            this.btnSaveEditModule.Size = new System.Drawing.Size(75, 23);
            this.btnSaveEditModule.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSaveEditModule.TabIndex = 20;
            this.btnSaveEditModule.Text = "保存";
            this.btnSaveEditModule.Click += new System.EventHandler(this.btnSaveEditModule_Click);
            // 
            // txtEmpName
            // 
            // 
            // 
            // 
            this.txtEmpName.Border.Class = "TextBoxBorder";
            this.txtEmpName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtEmpName.EnterToNextControl = false;
            this.txtEmpName.Location = new System.Drawing.Point(149, 45);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.ReadOnly = true;
            this.txtEmpName.Size = new System.Drawing.Size(153, 21);
            this.txtEmpName.TabIndex = 18;
            // 
            // txtEmpID
            // 
            // 
            // 
            // 
            this.txtEmpID.Border.Class = "TextBoxBorder";
            this.txtEmpID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtEmpID.EnterToNextControl = false;
            this.txtEmpID.Location = new System.Drawing.Point(150, 16);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.ReadOnly = true;
            this.txtEmpID.Size = new System.Drawing.Size(153, 21);
            this.txtEmpID.TabIndex = 18;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbx_Pint);
            this.groupBox1.Controls.Add(this.cbx_Del);
            this.groupBox1.Controls.Add(this.cbx_Outpint);
            this.groupBox1.Controls.Add(this.cbx_Import);
            this.groupBox1.Controls.Add(this.cbx_ViewAll);
            this.groupBox1.Controls.Add(this.cbx_Edit);
            this.groupBox1.Controls.Add(this.cbx_App);
            this.groupBox1.Controls.Add(this.cbx_News);
            this.groupBox1.Controls.Add(this.cbxSearch);
            this.groupBox1.Location = new System.Drawing.Point(146, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 98);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            // 
            // cbx_Pint
            // 
            // 
            // 
            // 
            this.cbx_Pint.BackgroundStyle.Class = "";
            this.cbx_Pint.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cbx_Pint.Location = new System.Drawing.Point(198, 40);
            this.cbx_Pint.Name = "cbx_Pint";
            this.cbx_Pint.Size = new System.Drawing.Size(56, 23);
            this.cbx_Pint.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbx_Pint.TabIndex = 0;
            this.cbx_Pint.Text = "打印";
            // 
            // cbx_Del
            // 
            // 
            // 
            // 
            this.cbx_Del.BackgroundStyle.Class = "";
            this.cbx_Del.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cbx_Del.Location = new System.Drawing.Point(198, 13);
            this.cbx_Del.Name = "cbx_Del";
            this.cbx_Del.Size = new System.Drawing.Size(56, 23);
            this.cbx_Del.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbx_Del.TabIndex = 0;
            this.cbx_Del.Text = "删除";
            // 
            // cbx_Outpint
            // 
            // 
            // 
            // 
            this.cbx_Outpint.BackgroundStyle.Class = "";
            this.cbx_Outpint.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cbx_Outpint.Location = new System.Drawing.Point(132, 40);
            this.cbx_Outpint.Name = "cbx_Outpint";
            this.cbx_Outpint.Size = new System.Drawing.Size(56, 23);
            this.cbx_Outpint.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbx_Outpint.TabIndex = 0;
            this.cbx_Outpint.Text = "导出";
            // 
            // cbx_Import
            // 
            // 
            // 
            // 
            this.cbx_Import.BackgroundStyle.Class = "";
            this.cbx_Import.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cbx_Import.Location = new System.Drawing.Point(70, 40);
            this.cbx_Import.Name = "cbx_Import";
            this.cbx_Import.Size = new System.Drawing.Size(56, 23);
            this.cbx_Import.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbx_Import.TabIndex = 0;
            this.cbx_Import.Text = "导入";
            // 
            // cbx_ViewAll
            // 
            // 
            // 
            // 
            this.cbx_ViewAll.BackgroundStyle.Class = "";
            this.cbx_ViewAll.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cbx_ViewAll.Location = new System.Drawing.Point(8, 65);
            this.cbx_ViewAll.Name = "cbx_ViewAll";
            this.cbx_ViewAll.Size = new System.Drawing.Size(82, 23);
            this.cbx_ViewAll.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbx_ViewAll.TabIndex = 0;
            this.cbx_ViewAll.Text = "查看所有";
            // 
            // cbx_Edit
            // 
            // 
            // 
            // 
            this.cbx_Edit.BackgroundStyle.Class = "";
            this.cbx_Edit.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cbx_Edit.Location = new System.Drawing.Point(132, 13);
            this.cbx_Edit.Name = "cbx_Edit";
            this.cbx_Edit.Size = new System.Drawing.Size(56, 23);
            this.cbx_Edit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbx_Edit.TabIndex = 0;
            this.cbx_Edit.Text = "修改";
            // 
            // cbx_App
            // 
            // 
            // 
            // 
            this.cbx_App.BackgroundStyle.Class = "";
            this.cbx_App.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cbx_App.Location = new System.Drawing.Point(8, 40);
            this.cbx_App.Name = "cbx_App";
            this.cbx_App.Size = new System.Drawing.Size(56, 23);
            this.cbx_App.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbx_App.TabIndex = 0;
            this.cbx_App.Text = "审核";
            // 
            // cbx_News
            // 
            // 
            // 
            // 
            this.cbx_News.BackgroundStyle.Class = "";
            this.cbx_News.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cbx_News.Location = new System.Drawing.Point(70, 13);
            this.cbx_News.Name = "cbx_News";
            this.cbx_News.Size = new System.Drawing.Size(56, 23);
            this.cbx_News.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbx_News.TabIndex = 0;
            this.cbx_News.Text = "新增";
            // 
            // cbxSearch
            // 
            // 
            // 
            // 
            this.cbxSearch.BackgroundStyle.Class = "";
            this.cbxSearch.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cbxSearch.Location = new System.Drawing.Point(8, 12);
            this.cbxSearch.Name = "cbxSearch";
            this.cbxSearch.Size = new System.Drawing.Size(56, 23);
            this.cbxSearch.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbxSearch.TabIndex = 0;
            this.cbxSearch.Text = "查询";
            // 
            // frmEditModuleRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 290);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ucLabel11);
            this.Controls.Add(this.btnCloseEditModule);
            this.Controls.Add(this.ucLabel10);
            this.Controls.Add(this.ucLabel4);
            this.Controls.Add(this.ucLabel12);
            this.Controls.Add(this.ucLabel9);
            this.Controls.Add(this.txtModuleName);
            this.Controls.Add(this.txtEmpID);
            this.Controls.Add(this.txtEmpName);
            this.Controls.Add(this.txtModuleCode);
            this.Controls.Add(this.btnSaveEditModule);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmEditModuleRole";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "编辑莫模块权限";
            this.Load += new System.EventHandler(this.frmEditModuleRole_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.UcLabel ucLabel11;
        private Controls.UcButton btnCloseEditModule;
        private Controls.UcLabel ucLabel10;
        private Controls.UcLabel ucLabel4;
        private Controls.UcLabel ucLabel12;
        private Controls.UcLabel ucLabel9;
        private Controls.UcTextBox txtModuleName;
        private Controls.UcTextBox txtModuleCode;
        private Controls.UcButton btnSaveEditModule;
        private Controls.UcTextBox txtEmpName;
        private Controls.UcTextBox txtEmpID;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.Controls.CheckBoxX cbxSearch;
        private DevComponents.DotNetBar.Controls.CheckBoxX cbx_Pint;
        private DevComponents.DotNetBar.Controls.CheckBoxX cbx_Del;
        private DevComponents.DotNetBar.Controls.CheckBoxX cbx_Outpint;
        private DevComponents.DotNetBar.Controls.CheckBoxX cbx_Import;
        private DevComponents.DotNetBar.Controls.CheckBoxX cbx_ViewAll;
        private DevComponents.DotNetBar.Controls.CheckBoxX cbx_Edit;
        private DevComponents.DotNetBar.Controls.CheckBoxX cbx_App;
        private DevComponents.DotNetBar.Controls.CheckBoxX cbx_News;

    }
}