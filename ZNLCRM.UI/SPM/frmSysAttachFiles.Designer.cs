namespace ZNLCRM.UI.SPM
{
    partial class frmSysAttachFiles
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvAttach = new ZNLCRM.Controls.UcDataGridView(this.components);
            this.colAttachID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAttachGuID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrgID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDeptID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDownLoad = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colAttachName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFileSuffix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFileSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFilePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDownloadNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ucPanel1 = new ZNLCRM.Controls.UcPanel(this.components);
            this.ucToolStrip1 = new ZNLCRM.Controls.UcToolStrip(this.components);
            this.tsbImport = new System.Windows.Forms.ToolStripButton();
            this.tsbDel = new System.Windows.Forms.ToolStripButton();
            this.ucPanel2 = new ZNLCRM.Controls.UcPanel(this.components);
            this.ofdAttach = new System.Windows.Forms.OpenFileDialog();
            this.ucPanel3 = new ZNLCRM.Controls.UcPanel(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.pgAttach = new ZNLCRM.Controls.UcPager();
            this.sfdAttach = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttach)).BeginInit();
            this.ucPanel1.SuspendLayout();
            this.ucToolStrip1.SuspendLayout();
            this.ucPanel2.SuspendLayout();
            this.ucPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAttach
            // 
            this.dgvAttach.AllowUserToAddRows = false;
            this.dgvAttach.AllowUserToDeleteRows = false;
            this.dgvAttach.AllowUserToOrderColumns = true;
            this.dgvAttach.BackgroundColor = System.Drawing.Color.White;
            this.dgvAttach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAttach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colAttachID,
            this.colAttachGuID,
            this.colOrgID,
            this.colDeptID,
            this.colDownLoad,
            this.colAttachName,
            this.colFileName,
            this.colFileSuffix,
            this.colFileSize,
            this.colFilePath,
            this.colDownloadNum});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAttach.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAttach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAttach.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvAttach.HighlightSelectedColumnHeaders = false;
            this.dgvAttach.Location = new System.Drawing.Point(5, 5);
            this.dgvAttach.Name = "dgvAttach";
            this.dgvAttach.PaintEnhancedSelection = false;
            this.dgvAttach.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvAttach.RowHeadersWidth = 40;
            this.dgvAttach.RowTemplate.Height = 23;
            this.dgvAttach.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAttach.SelectAllSignVisible = false;
            this.dgvAttach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvAttach.ShowRowNo = true;
            this.dgvAttach.Size = new System.Drawing.Size(978, 393);
            this.dgvAttach.TabIndex = 0;
            this.dgvAttach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAttach_CellContentClick);
            this.dgvAttach.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvAttach_DataBindingComplete);
            // 
            // colAttachID
            // 
            this.colAttachID.DataPropertyName = "AttachID";
            this.colAttachID.HeaderText = "AttachID";
            this.colAttachID.Name = "colAttachID";
            this.colAttachID.Visible = false;
            // 
            // colAttachGuID
            // 
            this.colAttachGuID.DataPropertyName = "AttachGuID";
            this.colAttachGuID.HeaderText = "AttachGuID";
            this.colAttachGuID.Name = "colAttachGuID";
            this.colAttachGuID.Visible = false;
            // 
            // colOrgID
            // 
            this.colOrgID.DataPropertyName = "OrgID";
            this.colOrgID.HeaderText = "OrgID";
            this.colOrgID.Name = "colOrgID";
            this.colOrgID.Visible = false;
            // 
            // colDeptID
            // 
            this.colDeptID.DataPropertyName = "DeptID";
            this.colDeptID.HeaderText = "DeptID";
            this.colDeptID.Name = "colDeptID";
            this.colDeptID.Visible = false;
            // 
            // colDownLoad
            // 
            this.colDownLoad.HeaderText = "";
            this.colDownLoad.Name = "colDownLoad";
            this.colDownLoad.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colDownLoad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colDownLoad.Text = "下载";
            this.colDownLoad.Width = 40;
            // 
            // colAttachName
            // 
            this.colAttachName.DataPropertyName = "AttachName";
            this.colAttachName.HeaderText = "附件名称";
            this.colAttachName.Name = "colAttachName";
            this.colAttachName.ReadOnly = true;
            this.colAttachName.Width = 150;
            // 
            // colFileName
            // 
            this.colFileName.DataPropertyName = "FileName";
            this.colFileName.HeaderText = "服务器文件名";
            this.colFileName.Name = "colFileName";
            this.colFileName.ReadOnly = true;
            this.colFileName.Width = 200;
            // 
            // colFileSuffix
            // 
            this.colFileSuffix.DataPropertyName = "FileSuffix";
            this.colFileSuffix.HeaderText = "文件后缀";
            this.colFileSuffix.Name = "colFileSuffix";
            this.colFileSuffix.ReadOnly = true;
            this.colFileSuffix.Width = 60;
            // 
            // colFileSize
            // 
            this.colFileSize.DataPropertyName = "FileSize";
            this.colFileSize.HeaderText = "文件大小";
            this.colFileSize.Name = "colFileSize";
            this.colFileSize.ReadOnly = true;
            this.colFileSize.Width = 60;
            // 
            // colFilePath
            // 
            this.colFilePath.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colFilePath.DataPropertyName = "FilePath";
            this.colFilePath.HeaderText = "文件路径";
            this.colFilePath.Name = "colFilePath";
            this.colFilePath.ReadOnly = true;
            // 
            // colDownloadNum
            // 
            this.colDownloadNum.DataPropertyName = "DownloadNum";
            this.colDownloadNum.HeaderText = "下载次数";
            this.colDownloadNum.Name = "colDownloadNum";
            this.colDownloadNum.ReadOnly = true;
            this.colDownloadNum.Width = 60;
            // 
            // ucPanel1
            // 
            this.ucPanel1.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel1.Controls.Add(this.ucToolStrip1);
            this.ucPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucPanel1.Location = new System.Drawing.Point(0, 0);
            this.ucPanel1.Name = "ucPanel1";
            this.ucPanel1.Size = new System.Drawing.Size(988, 35);
            this.ucPanel1.TabIndex = 1;
            // 
            // ucToolStrip1
            // 
            this.ucToolStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ucToolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbImport,
            this.tsbDel});
            this.ucToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.ucToolStrip1.Name = "ucToolStrip1";
            this.ucToolStrip1.Padding = new System.Windows.Forms.Padding(5);
            this.ucToolStrip1.Size = new System.Drawing.Size(988, 35);
            this.ucToolStrip1.TabIndex = 0;
            this.ucToolStrip1.Text = "ucToolStrip1";
            // 
            // tsbImport
            // 
            this.tsbImport.Image = global::ZNLCRM.UI.Properties.Resources.export_1;
            this.tsbImport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbImport.Name = "tsbImport";
            this.tsbImport.Size = new System.Drawing.Size(52, 22);
            this.tsbImport.Text = "上传";
            this.tsbImport.Click += new System.EventHandler(this.tsbImport_Click);
            // 
            // tsbDel
            // 
            this.tsbDel.Image = global::ZNLCRM.UI.Properties.Resources.del_2;
            this.tsbDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDel.Name = "tsbDel";
            this.tsbDel.Size = new System.Drawing.Size(52, 22);
            this.tsbDel.Text = "删除";
            this.tsbDel.Click += new System.EventHandler(this.tsbDel_Click);
            // 
            // ucPanel2
            // 
            this.ucPanel2.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel2.Controls.Add(this.dgvAttach);
            this.ucPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPanel2.Location = new System.Drawing.Point(0, 35);
            this.ucPanel2.Name = "ucPanel2";
            this.ucPanel2.Padding = new System.Windows.Forms.Padding(5);
            this.ucPanel2.Size = new System.Drawing.Size(988, 403);
            this.ucPanel2.TabIndex = 2;
            // 
            // ucPanel3
            // 
            this.ucPanel3.BackColor = System.Drawing.Color.Transparent;
            this.ucPanel3.Controls.Add(this.progressBar1);
            this.ucPanel3.Controls.Add(this.pgAttach);
            this.ucPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucPanel3.Location = new System.Drawing.Point(0, 438);
            this.ucPanel3.Name = "ucPanel3";
            this.ucPanel3.Size = new System.Drawing.Size(988, 34);
            this.ucPanel3.TabIndex = 3;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(268, 4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(290, 23);
            this.progressBar1.TabIndex = 1;
            // 
            // pgAttach
            // 
            this.pgAttach.BackColor = System.Drawing.Color.Transparent;
            this.pgAttach.Location = new System.Drawing.Point(12, 8);
            this.pgAttach.Name = "pgAttach";
            this.pgAttach.RecordCount = 0;
            this.pgAttach.Size = new System.Drawing.Size(214, 15);
            this.pgAttach.TabIndex = 0;
            // 
            // frmSysAttachFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 472);
            this.Controls.Add(this.ucPanel2);
            this.Controls.Add(this.ucPanel1);
            this.Controls.Add(this.ucPanel3);
            this.Name = "frmSysAttachFiles";
            this.Text = "附件管理";
            this.Load += new System.EventHandler(this.frmSysAttachFiles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttach)).EndInit();
            this.ucPanel1.ResumeLayout(false);
            this.ucPanel1.PerformLayout();
            this.ucToolStrip1.ResumeLayout(false);
            this.ucToolStrip1.PerformLayout();
            this.ucPanel2.ResumeLayout(false);
            this.ucPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.UcDataGridView dgvAttach;
        private Controls.UcPanel ucPanel1;
        private Controls.UcPanel ucPanel2;
        private Controls.UcToolStrip ucToolStrip1;
        private System.Windows.Forms.ToolStripButton tsbImport;
        private System.Windows.Forms.OpenFileDialog ofdAttach;
        private System.Windows.Forms.ToolStripButton tsbDel;
        private Controls.UcPanel ucPanel3;
        private Controls.UcPager pgAttach;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.SaveFileDialog sfdAttach;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAttachID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAttachGuID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrgID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDeptID;
        private System.Windows.Forms.DataGridViewLinkColumn colDownLoad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAttachName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFileSuffix;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFileSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFilePath;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDownloadNum;
    }
}