namespace ZNLCRM.Controls
{
    partial class UcSignature
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcSignature));
            this.lblFlag = new System.Windows.Forms.Label();
            this.picTY = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picTY)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFlag
            // 
            this.lblFlag.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFlag.AutoSize = true;
            this.lblFlag.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblFlag.ForeColor = System.Drawing.Color.Red;
            this.lblFlag.Location = new System.Drawing.Point(44, 25);
            this.lblFlag.Name = "lblFlag";
            this.lblFlag.Size = new System.Drawing.Size(85, 24);
            this.lblFlag.TabIndex = 243;
            this.lblFlag.Text = "已取消";
            // 
            // picTY
            // 
            this.picTY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picTY.Image = ((System.Drawing.Image)(resources.GetObject("picTY.Image")));
            this.picTY.Location = new System.Drawing.Point(0, 0);
            this.picTY.Name = "picTY";
            this.picTY.Size = new System.Drawing.Size(172, 72);
            this.picTY.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTY.TabIndex = 244;
            this.picTY.TabStop = false;
            // 
            // UcSignature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblFlag);
            this.Controls.Add(this.picTY);
            this.Name = "UcSignature";
            this.Size = new System.Drawing.Size(172, 72);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.UcSignature_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.picTY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFlag;
        private System.Windows.Forms.PictureBox picTY;

    }
}
