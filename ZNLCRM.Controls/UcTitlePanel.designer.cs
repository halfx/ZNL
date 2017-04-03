namespace ZNLCRM.Controls
{
    partial class UcTitlePanel
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
            this.pContent = new DevComponents.DotNetBar.PanelEx();
            this.pBack = new DevComponents.DotNetBar.PanelEx();
            this.pBack.SuspendLayout();
            this.SuspendLayout();
            // 
            // pTitle
            // 
            this.pTitle.CanvasColor = System.Drawing.SystemColors.Control;
            this.pTitle.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTitle.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pTitle.Location = new System.Drawing.Point(5, 5);
            this.pTitle.Name = "pTitle";
            this.pTitle.Padding = new System.Windows.Forms.Padding(3);
            this.pTitle.Size = new System.Drawing.Size(333, 26);
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
            // 
            // pContent
            // 
            this.pContent.CanvasColor = System.Drawing.SystemColors.Control;
            this.pContent.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pContent.Location = new System.Drawing.Point(5, 31);
            this.pContent.Name = "pContent";
            this.pContent.Size = new System.Drawing.Size(333, 114);
            this.pContent.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pContent.Style.BackColor1.Color = System.Drawing.Color.White;
            this.pContent.Style.BackColor2.Color = System.Drawing.Color.White;
            this.pContent.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pContent.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pContent.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pContent.Style.GradientAngle = 90;
            this.pContent.TabIndex = 1;
            this.pContent.Text = "Content";
            // 
            // pBack
            // 
            this.pBack.CanvasColor = System.Drawing.SystemColors.Control;
            this.pBack.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pBack.Controls.Add(this.pContent);
            this.pBack.Controls.Add(this.pTitle);
            this.pBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pBack.Location = new System.Drawing.Point(0, 0);
            this.pBack.Name = "pBack";
            this.pBack.Padding = new System.Windows.Forms.Padding(5);
            this.pBack.Size = new System.Drawing.Size(343, 150);
            this.pBack.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pBack.Style.BackColor1.Color = System.Drawing.Color.White;
            this.pBack.Style.BackColor2.Color = System.Drawing.Color.White;
            this.pBack.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pBack.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pBack.Style.GradientAngle = 90;
            this.pBack.TabIndex = 2;
            // 
            // UcTitlePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pBack);
            this.Name = "UcTitlePanel";
            this.Size = new System.Drawing.Size(343, 150);
            this.pBack.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx pTitle;
        private DevComponents.DotNetBar.PanelEx pContent;
        private DevComponents.DotNetBar.PanelEx pBack;
    }
}
