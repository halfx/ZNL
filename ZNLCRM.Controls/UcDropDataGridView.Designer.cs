namespace ZNLCRM.Controls
{
    partial class UcDropDataGridView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ucDataGridView = new ZNLCRM.Controls.UcDataGridView(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ucDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ucDataGridView
            // 
            this.ucDataGridView.AllowUserToAddRows = false;
            this.ucDataGridView.AllowUserToDeleteRows = false;
            this.ucDataGridView.AllowUserToOrderColumns = true;
            this.ucDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.ucDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ucDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.ucDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.ucDataGridView.HighlightSelectedColumnHeaders = false;
            this.ucDataGridView.Location = new System.Drawing.Point(0, 0);
            this.ucDataGridView.Name = "ucDataGridView";
            this.ucDataGridView.PaintEnhancedSelection = false;
            this.ucDataGridView.ReadOnly = true;
            this.ucDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ucDataGridView.RowTemplate.Height = 23;
            this.ucDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ucDataGridView.SelectAllSignVisible = false;
            this.ucDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.ucDataGridView.Size = new System.Drawing.Size(354, 196);
            this.ucDataGridView.TabIndex = 0;
            // 
            // UcDropDataGridView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ucDataGridView);
            this.Name = "UcDropDataGridView";
            this.Size = new System.Drawing.Size(354, 196);
            ((System.ComponentModel.ISupportInitialize)(this.ucDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UcDataGridView ucDataGridView;
    }
}
