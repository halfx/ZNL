using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ZNLCRM.Controls
{
    public partial class UcSignature : UserControl
    {
        public UcSignature()
        {
            InitializeComponent();
            SetFlag(SignFlag.None);
        }
        public enum SignFlag
        {
            None,
            CancelBill
        }
        public void SetFlag(SignFlag signFlag)
        {
            this.picTY.Visible = false;
            if (signFlag == SignFlag.None)
            {
                lblFlag.Text = "";
            }
            else if (signFlag == SignFlag.CancelBill)
            {
                lblFlag.Text = "已取消";
                this.picTY.Visible = true;
            }
        }

        private void UcSignature_Paint(object sender, PaintEventArgs e)
        {
            //int width = this.Width;
            //int height = this.Height;
            //this.Size = new Size(width, height);
            //Graphics g = e.Graphics;
            //g.FillEllipse(new SolidBrush(base.BackColor), 0.0f, 0.0f, width, height);
            //g.DrawEllipse(new Pen(Color.Red, 3), 0.0f, 0.0f, width-3, height-3);
        }
    }
}
