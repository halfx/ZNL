namespace ZNLCRM.UI.SYS
{
    partial class frmSelectMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelectMenu));
            this.panMid = new ZNLCRM.Controls.UcPanelEx(this.components);
            this.treMenu = new ZNLCRM.Controls.UcAdTree(this.components);
            this.node1 = new DevComponents.AdvTree.Node();
            this.nodeConnector1 = new DevComponents.AdvTree.NodeConnector();
            this.elementStyle1 = new DevComponents.DotNetBar.ElementStyle();
            this.panBottom = new ZNLCRM.Controls.UcPanelEx(this.components);
            this.btnCancel = new ZNLCRM.Controls.UcButton(this.components);
            this.btnOk = new ZNLCRM.Controls.UcButton(this.components);
            this.panMid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treMenu)).BeginInit();
            this.panBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // panMid
            // 
            this.panMid.CanvasColor = System.Drawing.SystemColors.Control;
            this.panMid.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panMid.Controls.Add(this.treMenu);
            this.panMid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panMid.Location = new System.Drawing.Point(0, 0);
            this.panMid.Name = "panMid";
            this.panMid.Size = new System.Drawing.Size(445, 342);
            this.panMid.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panMid.Style.BackColor1.Color = System.Drawing.Color.Transparent;
            this.panMid.Style.BackColor2.Color = System.Drawing.Color.Transparent;
            this.panMid.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panMid.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panMid.Style.GradientAngle = 90;
            this.panMid.TabIndex = 0;
            // 
            // treMenu
            // 
            this.treMenu.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline;
            this.treMenu.AllowDrop = true;
            this.treMenu.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.treMenu.BackgroundStyle.Class = "TreeBorderKey";
            this.treMenu.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.treMenu.CellLayout = DevComponents.AdvTree.eCellLayout.Horizontal;
            this.treMenu.CellPartLayout = DevComponents.AdvTree.eCellPartLayout.Horizontal;
            this.treMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treMenu.Location = new System.Drawing.Point(0, 0);
            this.treMenu.Name = "treMenu";
            this.treMenu.Nodes.AddRange(new DevComponents.AdvTree.Node[] {
            this.node1});
            this.treMenu.NodesConnector = this.nodeConnector1;
            this.treMenu.NodeStyle = this.elementStyle1;
            this.treMenu.PathSeparator = ";";
            this.treMenu.Size = new System.Drawing.Size(445, 342);
            this.treMenu.Styles.Add(this.elementStyle1);
            this.treMenu.TabIndex = 1;
            this.treMenu.NodeClick += new DevComponents.AdvTree.TreeNodeMouseEventHandler(this.treMenu_NodeClick);
            // 
            // node1
            // 
            this.node1.Expanded = true;
            this.node1.Name = "node1";
            this.node1.Text = "node1";
            // 
            // nodeConnector1
            // 
            this.nodeConnector1.LineColor = System.Drawing.SystemColors.ControlText;
            // 
            // elementStyle1
            // 
            this.elementStyle1.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.elementStyle1.Name = "elementStyle1";
            this.elementStyle1.TextColor = System.Drawing.SystemColors.ControlText;
            // 
            // panBottom
            // 
            this.panBottom.CanvasColor = System.Drawing.SystemColors.Control;
            this.panBottom.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panBottom.Controls.Add(this.btnCancel);
            this.panBottom.Controls.Add(this.btnOk);
            this.panBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panBottom.Location = new System.Drawing.Point(0, 342);
            this.panBottom.Name = "panBottom";
            this.panBottom.Size = new System.Drawing.Size(445, 55);
            this.panBottom.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panBottom.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.panBottom.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
            this.panBottom.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panBottom.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panBottom.Style.GradientAngle = 90;
            this.panBottom.TabIndex = 0;
            this.panBottom.Click += new System.EventHandler(this.panBottom_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(211, 13);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(86, 30);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.Click += new System.EventHandler(this.btnCloseEditModule_Click);
            // 
            // btnOk
            // 
            this.btnOk.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnOk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOk.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnOk.Image = ((System.Drawing.Image)(resources.GetObject("btnOk.Image")));
            this.btnOk.Location = new System.Drawing.Point(101, 13);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(86, 30);
            this.btnOk.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnOk.TabIndex = 8;
            this.btnOk.Text = "确定(&S)";
            this.btnOk.Click += new System.EventHandler(this.btnSaveEditModule_Click);
            // 
            // frmSelectMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 397);
            this.Controls.Add(this.panMid);
            this.Controls.Add(this.panBottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmSelectMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "菜单选择";
            this.Load += new System.EventHandler(this.frmSelectMenu_Load);
            this.panMid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treMenu)).EndInit();
            this.panBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.UcPanelEx panMid;
        private Controls.UcPanelEx panBottom;
        private Controls.UcAdTree treMenu;
        private DevComponents.AdvTree.Node node1;
        private DevComponents.AdvTree.NodeConnector nodeConnector1;
        private DevComponents.DotNetBar.ElementStyle elementStyle1;
        private Controls.UcButton btnCancel;
        private Controls.UcButton btnOk;
    }
}