namespace ZNLCRM.Controls
{
    partial class UcPager
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
            this.lblPager = new System.Windows.Forms.Label();
            this.labelControl1 = new System.Windows.Forms.Label();
            this.lPrevious = new System.Windows.Forms.Label();
            this.lNext = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPager
            // 
            this.lblPager.AutoSize = true;
            this.lblPager.ForeColor = System.Drawing.Color.Gray;
            this.lblPager.Location = new System.Drawing.Point(3, 2);
            this.lblPager.Name = "lblPager";
            this.lblPager.Size = new System.Drawing.Size(107, 12);
            this.lblPager.TabIndex = 10;
            this.lblPager.Text = "总共{0}条,第{1}页";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(115, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(0, 14);
            this.labelControl1.TabIndex = 11;
            // 
            // lPrevious
            // 
            this.lPrevious.AutoSize = true;
            this.lPrevious.Location = new System.Drawing.Point(170, 2);
            this.lPrevious.Name = "lPrevious";
            this.lPrevious.Size = new System.Drawing.Size(41, 12);
            this.lPrevious.TabIndex = 12;
            this.lPrevious.Text = "上一页";
            this.lPrevious.Click += new System.EventHandler(this.lPrevious_Click);
            // 
            // lNext
            // 
            this.lNext.AutoSize = true;
            this.lNext.Location = new System.Drawing.Point(223, 2);
            this.lNext.Name = "lNext";
            this.lNext.Size = new System.Drawing.Size(41, 12);
            this.lNext.TabIndex = 13;
            this.lNext.Text = "下一页";
            this.lNext.Click += new System.EventHandler(this.lNext_Click);
            // 
            // WinFormPager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lNext);
            this.Controls.Add(this.lPrevious);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.lblPager);
            this.Name = "UcPager";
            this.Size = new System.Drawing.Size(346, 15);
            this.Load += new System.EventHandler(this.WinFormPager_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.WinFormPager_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPager;
        private System.Windows.Forms.Label labelControl1;
        private System.Windows.Forms.Label lPrevious;
        private System.Windows.Forms.Label lNext;
    }
}
