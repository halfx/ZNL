namespace ZNLCRM.Controls
{
    partial class UcEditPanel
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
            this.pTitle = new DevComponents.DotNetBar.PanelEx();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.pContent = new DevComponents.DotNetBar.PanelEx();
            this.pTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            this.SuspendLayout();
            // 
            // pTitle
            // 
            this.pTitle.CanvasColor = System.Drawing.SystemColors.Control;
            this.pTitle.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pTitle.Controls.Add(this.picClose);
            this.pTitle.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.pTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTitle.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pTitle.Location = new System.Drawing.Point(0, 0);
            this.pTitle.Name = "pTitle";
            this.pTitle.Padding = new System.Windows.Forms.Padding(3);
            this.pTitle.Size = new System.Drawing.Size(537, 26);
            this.pTitle.Style.BackColor1.Color = System.Drawing.Color.White;
            this.pTitle.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pTitle.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pTitle.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pTitle.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right)
                        | DevComponents.DotNetBar.eBorderSide.Top)));
            this.pTitle.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pTitle.Style.GradientAngle = 90;
            this.pTitle.TabIndex = 0;
            this.pTitle.Text = "Title";
            this.pTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pTitle_MouseDown);
            this.pTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pTitle_MouseMove);
            // 
            // picClose
            // 
            this.picClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picClose.BackColor = System.Drawing.Color.White;
            this.picClose.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picClose.Image = global::ZNLCRM.Controls.Properties.Resources.del_3;
            this.picClose.Location = new System.Drawing.Point(513, 5);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(18, 18);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picClose.TabIndex = 2;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // pContent
            // 
            this.pContent.CanvasColor = System.Drawing.SystemColors.Control;
            this.pContent.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pContent.Location = new System.Drawing.Point(0, 26);
            this.pContent.Name = "pContent";
            this.pContent.Padding = new System.Windows.Forms.Padding(10);
            this.pContent.Size = new System.Drawing.Size(537, 244);
            this.pContent.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pContent.Style.BackColor1.Color = System.Drawing.Color.AliceBlue;
            this.pContent.Style.BackColor2.Color = System.Drawing.Color.AliceBlue;
            this.pContent.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pContent.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pContent.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pContent.Style.GradientAngle = 90;
            this.pContent.TabIndex = 2;
            this.pContent.Text = "Content";
            // 
            // UcEditPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.pContent);
            this.Controls.Add(this.pTitle);
            this.Name = "UcEditPanel";
            this.Size = new System.Drawing.Size(537, 270);
            this.Load += new System.EventHandler(this.UcEditPanel_Load);
            this.pTitle.ResumeLayout(false);
            this.pTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx pTitle;
        private System.Windows.Forms.PictureBox picClose;
        private DevComponents.DotNetBar.PanelEx pContent;


    }
}
