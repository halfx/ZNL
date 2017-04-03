using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using DevComponents.DotNetBar.Controls;
using System.Windows.Forms;

namespace ZNLCRM.Controls
{
    public partial class UcTextBox : TextBoxX
    {
        #region 自定义字段
        private bool _enterToNextControl;
        private AutoCompleteStringCollection AutoCompleteData;
        BackgroundWorker bw = new BackgroundWorker();
        private object objlock = new object();
        #endregion

        #region 自定义属性
        [Category("行为"),Description("回车转到下一个控件")]
        public bool EnterToNextControl
        {
            get { return _enterToNextControl; }
            set { _enterToNextControl = value; }
        }
        [Category("行为"),Description("回车之后触发的事件,如回车查询等,只有在回车转到下一个控件为false时才有效")]
        public event EventHandler EnterToDo;

        public delegate void EventBindAutoCompleteDataHandler(out AutoCompleteStringCollection DataSource, string keyValue);
        public event EventBindAutoCompleteDataHandler BindAutoCompleteData;
        #endregion

        public UcTextBox()
        {
            InitializeComponent();
            if (!this.DesignMode)
            {
                this.MouseUp += new MouseEventHandler(UcTextBox_MouseUp);
                this.GotFocus += new EventHandler(UcTextBox_GotFocus);
                this.TextChanged += new EventHandler(UcTextBox_TextChanged);
            }
        }

        void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            lock (objlock)
            {
                BindAutoCompleteData(out AutoCompleteData, e.Argument as string);
                e.Result = AutoCompleteData;
            }
        }

        void UcTextBox_TextChanged(object sender, EventArgs e)
        {
            if (BindAutoCompleteData != null)
            {
                if (this.Text.Trim().Length == 2 && (this.AutoCompleteCustomSource == null || this.AutoCompleteCustomSource.Count == 0))
                {
                    this.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    this.AutoCompleteMode = AutoCompleteMode.Suggest;
                    if (bw.IsBusy)
                    {
                        bw.CancelAsync();
                        bw.Dispose();
                    }

                    bw = new BackgroundWorker();
                    bw.DoWork += new DoWorkEventHandler(bw_DoWork);
                    bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bw_RunWorkerCompleted);
                    bw.RunWorkerAsync(this.Text.Trim());
                }

                if (this.Text.Trim().Length == 0 && AutoCompleteData != null)
                {
                    AutoCompleteData.Clear();
                    this.AutoCompleteCustomSource.Clear();
                }
            }
        }

        void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            lock (objlock)
            {
                this.AutoCompleteCustomSource = e.Result as AutoCompleteStringCollection;
            }
        }

        public UcTextBox(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
            if (!this.DesignMode)
            {
                this.MouseUp += new MouseEventHandler(UcTextBox_MouseUp);
                this.GotFocus += new EventHandler(UcTextBox_GotFocus);
                this.TextChanged += new EventHandler(UcTextBox_TextChanged);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void UcTextBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (BindAutoCompleteData == null)
            {
                //如果鼠标左键操作并且标记存在，则执行全选 
                if (e.Button == MouseButtons.Left && this.Tag != null && (bool)this.Tag == true)
                {
                    this.SelectAll();
                }

                //取消全选标记 
                this.Tag = false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void UcTextBox_GotFocus(object sender, EventArgs e)
        {
            if (BindAutoCompleteData == null)
            {
                this.Tag = true;//设置标记 
                this.SelectAll();
            }
        } 

        protected override bool ProcessDialogKey(System.Windows.Forms.Keys keyData)
        {
            if (_enterToNextControl && keyData == Keys.Enter)
            {
                keyData = Keys.Tab;
            }
            else if (this.EnterToDo != null && keyData == Keys.Enter)
            {
                this.EnterToDo(this, new EventArgs());
            }
            return base.ProcessDialogKey(keyData);
        }
    }
}
