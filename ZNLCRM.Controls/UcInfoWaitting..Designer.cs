namespace ZNLCRM.Controls
{
    partial class UcInfoWaitting
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
            this.labMsgContent = new DevComponents.DotNetBar.LabelX();
            this.pBack = new DevComponents.DotNetBar.PanelEx();
            this.btnCancel = new System.Windows.Forms.Button();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.prgTips = new DevComponents.DotNetBar.Controls.CircularProgress();
            this.delayTimer = new System.Windows.Forms.Timer(this.components);
            this.pBack.SuspendLayout();
            this.SuspendLayout();
            // 
            // labMsgContent
            // 
            this.labMsgContent.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labMsgContent.BackgroundStyle.Class = "";
            this.labMsgContent.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labMsgContent.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(255)));
            this.labMsgContent.ForeColor = System.Drawing.Color.DimGray;
            this.labMsgContent.Location = new System.Drawing.Point(47, 8);
            this.labMsgContent.Name = "labMsgContent";
            this.labMsgContent.PaddingBottom = 3;
            this.labMsgContent.PaddingLeft = 3;
            this.labMsgContent.PaddingRight = 3;
            this.labMsgContent.PaddingTop = 3;
            this.labMsgContent.SingleLineColor = System.Drawing.Color.Transparent;
            this.labMsgContent.Size = new System.Drawing.Size(353, 25);
            this.labMsgContent.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7;
            this.labMsgContent.TabIndex = 0;
            this.labMsgContent.Text = "请稍候,正在热行操作...";
            // 
            // pBack
            // 
            this.pBack.CanvasColor = System.Drawing.SystemColors.Control;
            this.pBack.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.pBack.Controls.Add(this.btnCancel);
            this.pBack.Controls.Add(this.labelX1);
            this.pBack.Controls.Add(this.prgTips);
            this.pBack.Controls.Add(this.labMsgContent);
            this.pBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pBack.Location = new System.Drawing.Point(0, 0);
            this.pBack.Name = "pBack";
            this.pBack.Padding = new System.Windows.Forms.Padding(3);
            this.pBack.Size = new System.Drawing.Size(565, 61);
            this.pBack.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.pBack.Style.BackColor1.Color = System.Drawing.Color.White;
            this.pBack.Style.BackColor2.Color = System.Drawing.SystemColors.ControlLight;
            this.pBack.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.pBack.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pBack.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pBack.Style.GradientAngle = 90;
            this.pBack.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(470, 27);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(60, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(255)));
            this.labelX1.ForeColor = System.Drawing.Color.DimGray;
            this.labelX1.Location = new System.Drawing.Point(48, 28);
            this.labelX1.Name = "labelX1";
            this.labelX1.PaddingBottom = 3;
            this.labelX1.PaddingLeft = 3;
            this.labelX1.PaddingRight = 3;
            this.labelX1.PaddingTop = 3;
            this.labelX1.SingleLineColor = System.Drawing.Color.Transparent;
            this.labelX1.Size = new System.Drawing.Size(426, 24);
            this.labelX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7;
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "如果长时间没响应,可能是网络异常造成操作失败,可关闭当前窗体,重新操作";
            this.labelX1.WordWrap = true;
            // 
            // prgTips
            // 
            // 
            // 
            // 
            this.prgTips.BackgroundStyle.Class = "";
            this.prgTips.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.prgTips.Location = new System.Drawing.Point(8, 11);
            this.prgTips.Name = "prgTips";
            this.prgTips.ProgressTextFormat = "{100}%";
            this.prgTips.Size = new System.Drawing.Size(32, 32);
            this.prgTips.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.prgTips.TabIndex = 2;
            this.prgTips.Value = 100;
            // 
            // delayTimer
            // 
            this.delayTimer.Interval = 1000;
            this.delayTimer.Tick += new System.EventHandler(this.delayTimer_Tick);
            // 
            // UcInfoWaitting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pBack);
            this.Name = "UcInfoWaitting";
            this.Size = new System.Drawing.Size(565, 61);
            this.Load += new System.EventHandler(this.UcInfoWaitting_Load);
            this.pBack.ResumeLayout(false);
            this.pBack.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labMsgContent;
        private DevComponents.DotNetBar.PanelEx pBack;
        private DevComponents.DotNetBar.Controls.CircularProgress prgTips;
        private System.Windows.Forms.Timer delayTimer;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.Button btnCancel;
    }
}
