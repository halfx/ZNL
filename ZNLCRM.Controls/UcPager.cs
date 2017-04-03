using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ZNLCRM.Controls
{
    public partial class UcPager : UserControl
    {
        /// <summary>
        /// 默认“总页数”
        /// </summary>
        private int _PageCount;
        /// <summary>
        /// 默认“当前页码”
        /// </summary>
        private int _PageIndex = 1;
        /// <summary>
        /// 默认“每页行数”
        /// </summary>
        private int _PageSize = 100;
        /// <summary>
        /// 默认“总记录数”
        /// </summary>
        private int _RecordCount = 0;
        private string PagerText = "总共{0}条,第{1}页";
        public int PageCount
        {
            get
            {
                return this._PageCount;
            }
        }

        [DefaultValue(1), Category("自定义属性"), Description("当前显示的页数")]
        public int PageIndex
        {
            get
            {
                return this._PageIndex;
            }
            set
            {
                if (value < 0)
                {
                    this._PageIndex = 0;
                }
                else
                {
                    this._PageIndex = value;
                }
            }
        }

        [DefaultValue(100), Description("每页显示的记录数"), Category("自定义属性")]
        public int PageSize
        {
            get
            {
                return this._PageSize;
            }
            set
            {
                if (value < 1)
                {
                    value = 100;
                }
                this._PageSize = value;
                this.SetLabelLocation();
            }
        }

        [Description("要分页的总记录数"), Category("自定义属性")]
        public int RecordCount
        {
            get
            {
                return this._RecordCount;
            }
            set
            {
                this._RecordCount = value;
                this._PageCount = this.GetPageCount(this._RecordCount, this._PageSize);
                this.SetBtnEnabled();
            }
        }
        
        public delegate void dlgPageIndexChanging(UcPagerEventArgs e);
        [Description("更改页面索引前发生的事件"), Category("自定义事件")]
        public event dlgPageIndexChanging PageIndexChanging;
        

        [Description("更改页面索引事件"), Category("自定义事件")]
        public event EventHandler PageIndexChanged;

        public UcPager()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 获得总页数
        /// </summary>
        /// <param name="RecordCounts">总记录数</param>
        /// <param name="PageSizes">每页行数</param>
        /// <returns>总页数</returns>
        protected int GetPageCount(int RecordCounts, int PageSizes)
        {
            int num = 0;
            string str = (Convert.ToDouble(RecordCounts) / Convert.ToDouble(PageSizes)).ToString();
            if (str.IndexOf(".") < 0)
            {
                return Convert.ToInt32(str);
            }
            string[] strArray = Regex.Split(str, @"\.", RegexOptions.IgnoreCase);
            if (!string.IsNullOrEmpty(strArray[1].ToString()))
            {
                num = Convert.ToInt32(strArray[0]) + 1;
            }
            return num;
        }

        /// <summary>
        /// 设置翻页按钮是否启用
        /// </summary>
        protected void SetBtnEnabled()
        {
            if (this._PageIndex <= 1)
            {
                bool noOnePage = (this.PageCount > 1 && this.RecordCount >  PageSize);
                this.lPrevious.Enabled = false;
                this.lNext.Enabled = noOnePage;
            }
            else if ((this._PageIndex > 1) && (this._PageIndex < this._PageCount))
            {
                this.lPrevious.Enabled = true;
                this.lNext.Enabled = true;
            }
            else if (this._PageIndex == this._PageCount)
            {
                this.lPrevious.Enabled = true;
                this.lNext.Enabled = false;
            }
        }


        /// <summary>
        /// 设置文本间距
        /// </summary>
        protected void SetLabelLocation()
        {
            this.lPrevious.Left = (this.lblPager.Left + this.lblPager.Width) + 20;
            this.lNext.Left = this.lPrevious.Left + this.lPrevious.Width + 5;
        }

        /// <summary>
        /// 设置分页信息内容
        /// </summary>
        private void SetPagerText()
        {
            string[] strArray = new string[] { this.RecordCount.ToString(), this.PageIndex.ToString() };
            this.lblPager.Text = string.Format(this.PagerText, (object[])strArray);
        }

        #region Events

        /// <summary>
        /// 页码改变时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CustomEvent(object sender, EventArgs e)
        {
            try
            {
                this.PageIndexChanged(sender, e);
            }
            catch (Exception)
            {
                MessageBox.Show("未找到PageIndexChanged事件！");
            }
        }

        /// <summary>
        /// 点击下一页按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lNext_Click(object sender, EventArgs e)
        {
            int num = this._PageIndex;
            try
            {
                int num2 = Convert.ToInt32(num) + 1;
                if (num2 >= this._RecordCount)
                {
                    num2 = this._RecordCount;
                }
                UcPagerEventArgs pageEvt=new UcPagerEventArgs();
                pageEvt.PageIndex=num2;
                if(PageIndexChanging!=null)PageIndexChanging(pageEvt);
                if(pageEvt.CancelEvent){
                    return;
                }
                this._PageIndex = num2;
                this.SetPagerText();
                this.SetBtnEnabled();
                this.SetLabelLocation();
                this.CustomEvent(sender, e);
            }
            catch (Exception)
            {
            }
        }

        /// <summary>
        /// 点击上一页按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lPrevious_Click(object sender, EventArgs e)
        {
            int num = this._PageIndex;
            try
            {
                int num2 = Convert.ToInt32(num) - 1;
                if (num2 <= 0)
                {
                    num2 = 1;
                }
                UcPagerEventArgs pageEvt=new UcPagerEventArgs();
                pageEvt.PageIndex=num2;
                if(PageIndexChanging!=null)PageIndexChanging(pageEvt);
                if(pageEvt.CancelEvent){
                    return;
                }
                this._PageIndex = num2;
                this.SetPagerText();
                this.SetBtnEnabled();
                this.SetLabelLocation();
                this.CustomEvent(sender, e);
            }
            catch (Exception)
            {
            }
        }

        private void WinFormPager_Load(object sender, EventArgs e)
        {
            this.SetBtnEnabled();
        }

        private void WinFormPager_Paint(object sender, PaintEventArgs e)
        {
            this._PageCount = this.GetPageCount(this._RecordCount, this._PageSize);
            this.SetPagerText();
            this.SetLabelLocation();

        }

        #endregion
    }
}
