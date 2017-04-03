using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevComponents.DotNetBar.ScrollBar;

namespace ZNLCRM.Controls
{
    /// <summary>
    /// 带汇总的DataGridView
    /// 通常情况下：GRID列非动太创建的，显示的时候是不会带求和行，
    ///             要想显示求和行，要执行方法CreateSummaryRow
    /// </summary>
    public partial class UcDataGridViewSummary : UcDataGridView, ISupportInitialize
    {
        #region 属性

        /// <summary>
        /// 汇总行的行标题是否显示 
        /// </summary>
        private bool displaySumRowHeader;
        [Browsable(true), Category("Summary")]
        public bool DisplaySumRowHeader
        {
            get { return displaySumRowHeader; }
            set { displaySumRowHeader = value; }
        }

        /// <summary>
        /// 汇总行的行标题
        /// </summary>
        private string sumRowHeaderText;
        [Browsable(true), Category("Summary")]
        public string SumRowHeaderText
        {
            get { return sumRowHeaderText; }
            set { sumRowHeaderText = value; }
        }

        /// <summary>
        /// 汇总行标题是否加粗显示
        /// </summary>
        private bool sumRowHeaderTextBold;
        [Browsable(true), Category("Summary")]
        public bool SumRowHeaderTextBold
        {
            get { return sumRowHeaderTextBold; }
            set { sumRowHeaderTextBold = value; }
        }

        /// <summary>
        /// 要汇总的列
        /// </summary>
        private string[] summaryColumns;
        [Browsable(true), Category("Summary")]
        public string[] SummaryColumns
        {
            get { return summaryColumns; }
            set { summaryColumns = value; }
        }

        /// <summary>
        /// 汇总行是否可见
        /// </summary>
        private bool summaryRowVisible;
        [Browsable(true), Category("Summary")]
        public bool SummaryRowVisible
        {
            get { return summaryRowVisible; }
            set
            {
                summaryRowVisible = value;
                if (summaryControl != null && spacePanel != null)
                {
                    summaryControl.Visible = value;
                    spacePanel.Visible = value;
                }
            }
        }

        /// <summary>
        /// 汇总行间隔
        /// </summary>
        private int summaryRowSpace = 0;
        [Browsable(true), Category("Summary")]
        public int SummaryRowSpace
        {
            get { return summaryRowSpace; }
            set { summaryRowSpace = value; }
        }
        /// <summary>
        /// 汇总数据格式
        /// </summary>
        private string formatString = "F02";
        [Browsable(true), Category("Summary"), DefaultValue("F02")]
        public string FormatString
        {
            get { return formatString; }
            set { formatString = value; }
        }

        /// <summary>
        /// 汇总行背景颜色
        /// </summary>
        [Browsable(true), Category("Summary")]
        public Color SummaryRowBackColor
        {
            get { return this.summaryControl.SummaryRowBackColor; }
            set { summaryControl.SummaryRowBackColor = value; }
        }


        /// <summary>
        /// advoid user from setting the scrollbars manually
        /// </summary>
        [Browsable(false)]
        public new ScrollBars ScrollBars
        {
            get { return base.ScrollBars; }
            set { base.ScrollBars = value; }
        }


        #endregion

        #region 私有变量

        public event EventHandler CreateSummary;
        private HScrollBarAdv hScrollBar;
        private SummaryControlContainer summaryControl;
        private Panel panel, spacePanel;
        private TextBox refBox;
        #endregion

        #region 构造函数
        public UcDataGridViewSummary()
        {
            InitializeComponent();
            if (!this.DesignMode)
            {
                refBox = new TextBox();
                panel = new Panel();
                spacePanel = new Panel();
                hScrollBar = new HScrollBarAdv();
                hScrollBar.Appearance = DevComponents.DotNetBar.eScrollBarAppearance.ApplicationScroll;

                summaryControl = new SummaryControlContainer(this);
                summaryControl.Visible = false;
                summaryControl.InitialHeight = refBox.Height;
                hScrollBar.Height = refBox.Height - 2;
                summaryControl.VisibilityChanged += new EventHandler(summaryControl_VisibilityChanged);

                Resize += new EventHandler(DataGridControlSum_Resize);
                RowHeadersWidthChanged += new EventHandler(DataGridControlSum_Resize);
                ColumnAdded += new DataGridViewColumnEventHandler(DataGridControlSum_ColumnAdded);
                ColumnRemoved += new DataGridViewColumnEventHandler(DataGridControlSum_ColumnRemoved);
                ColumnStateChanged += new DataGridViewColumnStateChangedEventHandler(DataGridControlSum_ColumnStateChanged);

                hScrollBar.Scroll += new ScrollEventHandler(hScrollBar_Scroll);
                hScrollBar.VisibleChanged += new EventHandler(hScrollBar_VisibleChanged);

                hScrollBar.Top += summaryControl.Bottom;
                hScrollBar.Minimum = 0;
                hScrollBar.Maximum = 0;
                hScrollBar.Value = 0;
            }
        }
        #endregion

        #region 公共方法

        /// <summary>
        /// Refresh the summary
        /// </summary>
        public void RefreshSummary()
        {
            if (this.summaryControl != null)
                this.summaryControl.RefreshSummary();
        }

        #endregion

        #region 计算列宽和滚动条宽度
        private void DataGridControlSum_ColumnStateChanged(object sender, DataGridViewColumnStateChangedEventArgs e)
        {
            if (e.StateChanged == DataGridViewElementStates.Visible)
            {
                calculateColumnsWidth();
                summaryControl.Width = columnsWidth;
                hScrollBar.Maximum = Convert.ToInt32(columnsWidth);
                resizeHScrollBar();
            }
        }

        private void DataGridControlSum_ColumnRemoved(object sender, DataGridViewColumnEventArgs e)
        {
            calculateColumnsWidth();
            summaryControl.Width = columnsWidth;
            hScrollBar.Maximum = Convert.ToInt32(columnsWidth);
            resizeHScrollBar();
        }
        private void DataGridControlSum_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            calculateColumnsWidth();
            summaryControl.Width = columnsWidth;
            hScrollBar.Maximum = Convert.ToInt32(columnsWidth);
            resizeHScrollBar();
        }

        int columnsWidth = 0;
        /// <summary>
        /// Calculate the width of all visible columns
        /// </summary>
        private void calculateColumnsWidth()
        {
            columnsWidth = 0;
            for (int iCnt = 0; iCnt < ColumnCount; iCnt++)
            {
                if (Columns[iCnt].Visible)
                {
                    if (Columns[iCnt].AutoSizeMode == DataGridViewAutoSizeColumnMode.Fill)
                    {
                        columnsWidth += Columns[iCnt].MinimumWidth;
                    }
                    else
                        columnsWidth += Columns[iCnt].Width;
                }
            }

        }

        #endregion
        //protected override 
        #region 事件委托

        /// <summary>
        /// Moves viewable area of DataGridView according to the position of the scrollbar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void hScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            int index = GetIndexByPos(e.NewValue);
            if (index != -1)
            {
                if (!this.Columns[index].Frozen)
                {
                    FirstDisplayedScrollingColumnIndex = index;
                }
            }
        }

        public void CreateSummaryRow()
        {
            OnCreateSummary(this, EventArgs.Empty);
        }

        /// <summary>
        /// Calls the CreateSummary event
        /// </summary>
        private void OnCreateSummary(object sender, EventArgs e)
        {
            if (CreateSummary != null)
                CreateSummary(sender, e);
        }

        #endregion

        #region 附加汇总行、滚动条

        /// <summary>
        /// Position the summaryControl under the
        /// DataGridView
        /// </summary>
        private void adjustSumControlToGrid()
        {
            if (summaryControl == null || Parent == null)
                return;
            summaryControl.Top = Height + summaryRowSpace;
            summaryControl.Left = Left;
            summaryControl.Width = Width;
        }

        /// <summary>
        /// Position the hScrollbar under the summaryControl
        /// </summary>
        private void adjustScrollbarToSummaryControl()
        {
            if (Parent != null)
            {
                hScrollBar.Top = refBox.Height + 2;
                hScrollBar.Width = Width;
                hScrollBar.Left = Left;

                resizeHScrollBar();
            }
        }

        /// <summary>
        /// Resizes the horizontal scrollbar acording
        /// to the with of the client size and maximum size of the scrollbar
        /// </summary>
        private void resizeHScrollBar()
        {
            //Is used to calculate the LageChange of the scrollbar
            int vscrollbarWidth = 0;
            if (VerticalScrollBar.Visible)
                vscrollbarWidth = VerticalScrollBar.Width;

            int rowHeaderWith = RowHeadersVisible ? RowHeadersWidth : 0;

            if (columnsWidth > 0)
            {
                //This is neccessary if AutoGenerateColumns = true because DataGridControlSum_ColumnAdded won't be fired
                if (hScrollBar.Maximum == 0)
                    hScrollBar.Maximum = columnsWidth;

                //Calculate how much of the columns are visible in %
                int scrollBarWidth = Convert.ToInt32(Convert.ToDouble(ClientSize.Width - RowHeadersWidth - vscrollbarWidth) / (Convert.ToDouble(hScrollBar.Maximum) / 100F));

                if (scrollBarWidth > 100 || columnsWidth + rowHeaderWith < ClientSize.Width)
                {
                    if (hScrollBar.Visible)
                    {
                        hScrollBar.Visible = false;
                    }
                }
                else if (scrollBarWidth > 0)
                {
                    if (!hScrollBar.Visible)
                    {
                        hScrollBar.Visible = true;
                    }
                    hScrollBar.LargeChange = hScrollBar.Maximum / 100 * scrollBarWidth;
                    hScrollBar.SmallChange = hScrollBar.LargeChange / 100;
                }
            }
        }

        private void DataGridControlSum_Resize(object sender, EventArgs e)
        {
            if (Parent != null)
            {
                calculateColumnsWidth();
                resizeHScrollBar();
                adjustSumControlToGrid();
                adjustScrollbarToSummaryControl();
            }
        }

        /// <summary>
        /// Recalculate the width of the summary control according to 
        /// the state of the scrollbar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void hScrollBar_VisibleChanged(object sender, EventArgs e)
        {
            if (Parent != null)
            {
                //only perform operation if parent is visible
                if (Parent.Visible)
                {
                    int height;
                    if (hScrollBar.Visible)
                        height = summaryControl.InitialHeight + hScrollBar.Height;
                    else
                        height = summaryControl.InitialHeight;

                    if (summaryControl.Height != height && summaryControl.Visible)
                    {
                        summaryControl.Height = height;
                        this.Height = panel.Height - summaryControl.Height - summaryRowSpace;
                    }
                }
            }
        }

        /// <summary>
        /// Recalculate the height of the DataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void summaryControl_VisibilityChanged(object sender, EventArgs e)
        {
            if (!summaryControl.Visible)
            {
                ScrollBars = ScrollBars.Both;
                this.Height = panel.Height;
            }
            else
            {
                this.Height = panel.Height - summaryControl.Height - summaryRowSpace;
                ScrollBars = ScrollBars.Vertical;
            }
        }

        /// <summary>
        /// When the DataGridView is visible for the first time a panel is created.
        /// The DataGridView is then removed from the parent control and added as 
        /// child to the newly created panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void changeParent()
        {
            if (!DesignMode && Parent != null)
            {

                summaryControl.InitialHeight = this.refBox.Height;
                summaryControl.Height = summaryControl.InitialHeight;
                summaryControl.BackColor = this.RowHeadersDefaultCellStyle.BackColor;
                summaryControl.ForeColor = Color.Transparent;
                summaryControl.RightToLeft = this.RightToLeft;
                panel.Bounds = this.Bounds;
                panel.BackColor = this.BackgroundColor;

                panel.Dock = this.Dock;
                panel.Anchor = this.Anchor;
                panel.Padding = this.Padding;
                panel.Margin = this.Margin;
                panel.Top = this.Top;
                panel.Left = this.Left;
                panel.BorderStyle = this.BorderStyle;
                panel.Name = "p"+this.Name.Replace("dgv","");

                Margin = new Padding(0);
                Padding = new Padding(0);
                Top = 0;
                Left = 0;

                summaryControl.Dock = DockStyle.Bottom;
                this.Dock = DockStyle.Fill;

                if (this.Parent is TableLayoutPanel)
                {
                    int rowSpan, colSpan;

                    TableLayoutPanel tlp = this.Parent as TableLayoutPanel;
                    TableLayoutPanelCellPosition cellPos = tlp.GetCellPosition(this);

                    rowSpan = tlp.GetRowSpan(this);
                    colSpan = tlp.GetColumnSpan(this);

                    tlp.Controls.Remove(this);
                    tlp.Controls.Add(panel, cellPos.Column, cellPos.Row);
                    tlp.SetRowSpan(panel, rowSpan);
                    tlp.SetColumnSpan(panel, colSpan);
                }
                else
                {
                    Control parent = this.Parent;
                    //remove DataGridView from ParentControls
                    parent.Controls.Remove(this);
                    parent.Controls.Add(panel);
                }

                this.BorderStyle = BorderStyle.None;

                panel.BringToFront();


                hScrollBar.Top = refBox.Height + 2;
                hScrollBar.Width = this.Width;
                hScrollBar.Left = this.Left;

                summaryControl.Controls.Add(hScrollBar);
                hScrollBar.BringToFront();
                panel.Controls.Add(this);

                spacePanel = new Panel();
                spacePanel.BackColor = panel.BackColor;
                spacePanel.Height = summaryRowSpace;
                spacePanel.Dock = DockStyle.Bottom;

                panel.Controls.Add(spacePanel);
                panel.Controls.Add(summaryControl);

                resizeHScrollBar();
                adjustSumControlToGrid();
                adjustScrollbarToSummaryControl();

                resizeHScrollBar();
            }
        }

        #endregion

        #region ISupportInitialzie

        public void BeginInit()
        { }

        public void EndInit()
        {
            changeParent();
        }

        #endregion

        #region 滚动到一定位置，属于第哪一列的列号
        int GetIndexByPos(int newPos)
        {
            int i = 0;
            int index = -1;
            int tmpPos = newPos;
            while (tmpPos > 0 && i < Columns.Count)
            {
                //查找第i个显示列
                foreach (DataGridViewColumn dgvc in Columns)
                {
                    if (dgvc.DisplayIndex == i)
                    {
                        i++;
                        if (dgvc.Visible)
                        {
                            //如果找到的列可显示，显示列数加1，滚动位置减去该列宽，找下一个位置
                            index = dgvc.Index;
                            tmpPos -= dgvc.Width;
                            break;
                        }
                    }
                }
            }
            if (index > -1 && newPos + Width - RowHeadersWidth - VerticalScrollBar.Width + 50 > columnsWidth)
            {
                    foreach (DataGridViewColumn dgvc in Columns)
                    {
                        if (i >= Columns.Count)
                        {
                            break;
                        }
                        if (dgvc.DisplayIndex == i)
                        {
                            i++;
                            if (dgvc.Visible)
                            {
                                //如果找到的列可显示，显示列数加1，滚动位置减去该列宽，找下一个位置
                                index = dgvc.Index;
                                break;
                            }
                        }
                    } 

            }
            return index;
        }
        #endregion
    }
}
