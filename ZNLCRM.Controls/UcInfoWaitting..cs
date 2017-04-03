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
    public partial class UcInfoWaitting : UserControl
    {
        public UcInfoWaitting()
        {
            InitializeComponent();
        }
        
        public void ShowMessage(string message)
        {
            if (this.Parent != null)
            {
                ShowMessage(message, new Point((this.Parent.ClientRectangle.Width - this.pBack.Width - 1) / 2, (this.Parent.ClientRectangle.Height - this.pBack.Height - 1) / 2));
            }
        }
        void SetParentDisabled(bool enable)
        {
            foreach (Control con in this.Parent.Controls)
            {
                if(con==this)continue;
                if (con.GetType() == typeof(UcPanel) || con.GetType() == typeof(UcPanelEx))
                    con.Enabled = enable;
            }
            
        }
        void ShowMessage(string message, Point p)
        {
            if (this.ParentForm != null)
            {
                this.BackColor = Color.Transparent;
                this.Location = new Point(0, 0);
                this.labMsgContent.Text = message;
                this.Location = p;
                this.BringToFront();
                this.Visible = true;
                SetParentDisabled(false);
                startTime();
            }
        }
        #region 进度显示
        public void HideMsg()
        {
            this.Visible = false;
            _pecent = 0;
            SetParentDisabled(true);
            this.delayTimer.Stop();
        }

        delegate void _asyncDelegate();
        public delegate void _exeMothodDelegate();
        public delegate void _exeCompleteDelegate(object exeRst);
        int _pecent = 0;
        void startTime()
        {
            this.delayTimer.Stop();
            this.delayTimer.Interval = 20;
            this.delayTimer.Start();
        }
        #endregion

        private void delayTimer_Tick(object sender, EventArgs e)
        {
            if (_pecent > 100) _pecent = 1;
            this.prgTips.Value = _pecent;
            this.labelX1.Focus();
            _pecent++;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.HideMsg();
        }

        private void UcInfoWaitting_Load(object sender, EventArgs e)
        {

        }

    }
}
