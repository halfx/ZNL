using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZNLCRM.Utility;

namespace ZNLCRM.Controls
{
    /// <summary>
    /// 提示消息框控件
    /// </summary>
    public partial class UcInformationBox : UserControl
    {
        #region 私有变量
        int _waringDelay = 20;
        int _initTime = 5 * 1000;
        int _rollupTime = 5 * 1000;
        public int WaringDelay
        {
            get { return _waringDelay; }
            set { _waringDelay = value; }
        }
        #endregion
        public UcInformationBox()
        {
            InitializeComponent();
            if (!this.DesignMode)
            {
                this.delayTimer.Interval = _waringDelay;// _waringDelay * 1000;
            }
        }
     
        private void delayTimer_Tick(object sender, EventArgs e)
        {
            if (_rollupTime <= 0)
            {
                this.Visible = false;
                delayTimer.Stop();
                _rollupTime = _initTime;
            }
            else
            {
                this.Width = this.ParentForm.ClientRectangle.Width - 3;
            }
            _rollupTime -= _waringDelay;
        }

        public void ShowMessage(string message)
        {
            if (this.Parent != null)
            {
                ShowMessage(message, new Point(2, 2));
            }
        }

        public void ShowMessage(string message, Point p)
        {
            if (this.ParentForm != null)
            {
                this.labMsgContent.Text = "<b>提示信息:</b>" + AddSapce(message);
                this.pBack.Style.BackColor2.Color = Color.Gold;
                this.Location = p;
                this.BringToFront();
                this.Visible = true;
                this.Width = this.ParentForm.ClientRectangle.Width - 3;
                this.labMsgContent.Width = this.ParentForm.ClientRectangle.Width - 100;
                delayTimer.Stop();
                delayTimer.Start();
            }
        }

        public void StopShow()
        {
            delayTimer.Stop();
            this.Visible = false;
        }

        /// <summary>
        /// 增加空格，以变换行
        /// </summary>
        /// <param name="mess"></param>
        private string AddSapce(string mess)
        {
            string strRet = string.Empty;
            int pixofchar = 7;//每个字符点6个像素点
            int chLen = System.Text.Encoding.Default.GetBytes(mess).Length;//显示的字符个数
            int showWidth = this.Width - 30;//显示宽度
            int firstRowShows = (showWidth - (4 * 2 + 1) * pixofchar)/pixofchar;//第一行显示的字符数
            int secondRowShows = showWidth / pixofchar;//第二行开始显示的字符数
            string subStr = string.Empty;
            if (chLen < firstRowShows)
            {
                return mess;
            }
            strRet += StringHandler.SubString(mess, firstRowShows);
            mess = mess.Substring(strRet.Length);
            chLen -= System.Text.Encoding.Default.GetBytes(strRet).Length;
            while (chLen >= 0)
            {
                if (chLen <= secondRowShows)
                {
                    strRet += " " + mess;
                    break;
                }

                subStr = StringHandler.SubString(mess, secondRowShows);
                strRet += " " + subStr;
                chLen -= System.Text.Encoding.Default.GetBytes(subStr).Length;
                mess = mess.Substring(subStr.Length);
            }
            return strRet;
        }

        private void picBoxClose_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.pBack.Style.BackColor1.Color = Color.White;
            this.pBack.Style.BackColor2.Color = Color.Gainsboro;
            delayTimer.Stop();
        }
    }
}
