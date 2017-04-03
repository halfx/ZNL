namespace ZNLCRM.Controls
{
    partial class UcInformationBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcInformationBox));
            this.delayTimer = new System.Windows.Forms.Timer(this.components);
            this.labMsgContent = new DevComponents.DotNetBar.LabelX();
            this.pBack = new DevComponents.DotNetBar.PanelEx();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picBoxClose = new System.Windows.Forms.PictureBox();
            this.pBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // delayTimer
            // 
            this.delayTimer.Interval = 1000;
            this.delayTimer.Tick += new System.EventHandler(this.delayTimer_Tick);
            // 
            // labMsgContent
            // 
            this.labMsgContent.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labMsgContent.BackgroundStyle.Class = "";
            this.labMsgContent.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labMsgContent.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(255)));
            this.labMsgContent.ForeColor = System.Drawing.Color.Black;
            this.labMsgContent.Location = new System.Drawing.Point(39, 5);
            this.labMsgContent.Name = "labMsgContent";
            this.labMsgContent.PaddingBottom = 3;
            this.labMsgContent.PaddingLeft = 3;
            this.labMsgContent.PaddingRight = 3;
            this.labMsgContent.PaddingTop = 3;
            this.labMsgContent.SingleLineColor = System.Drawing.Color.Transparent;
            this.labMsgContent.Size = new System.Drawing.Size(592, 25);
            this.labMsgContent.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7;
            this.labMsgContent.TabIndex = 1;
            this.labMsgContent.Text = "这是提示窗体";
            // 
            // pBack
            // 
            this.pBack.CanvasColor = System.Drawing.SystemColors.Control;
            this.pBack.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pBack.Controls.Add(this.pictureBox1);
            this.pBack.Controls.Add(this.labMsgContent);
            this.pBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pBack.Location = new System.Drawing.Point(0, 0);
            this.pBack.Name = "pBack";
            this.pBack.Padding = new System.Windows.Forms.Padding(3);
            this.pBack.Size = new System.Drawing.Size(682, 32);
            this.pBack.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pBack.Style.BackColor1.Color = System.Drawing.Color.White;
            this.pBack.Style.BackColor2.Color = System.Drawing.Color.Gold;
            this.pBack.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pBack.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pBack.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pBack.Style.GradientAngle = 90;
            this.pBack.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // picBoxClose
            // 
            this.picBoxClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picBoxClose.BackColor = System.Drawing.Color.White;
            this.picBoxClose.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxClose.Image = global::ZNLCRM.Controls.Properties.Resources.del_3;
            this.picBoxClose.Location = new System.Drawing.Point(653, 7);
            this.picBoxClose.Name = "picBoxClose";
            this.picBoxClose.Size = new System.Drawing.Size(18, 18);
            this.picBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBoxClose.TabIndex = 3;
            this.picBoxClose.TabStop = false;
            this.picBoxClose.Click += new System.EventHandler(this.picBoxClose_Click);
            // 
            // UcInformationBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.picBoxClose);
            this.Controls.Add(this.pBack);
            this.Name = "UcInformationBox";
            this.Size = new System.Drawing.Size(682, 32);
            this.pBack.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer delayTimer;
        private DevComponents.DotNetBar.LabelX labMsgContent;
        private DevComponents.DotNetBar.PanelEx pBack;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picBoxClose;
    }
}
