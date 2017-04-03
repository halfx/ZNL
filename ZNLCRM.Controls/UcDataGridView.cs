using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using DevComponents.DotNetBar.Controls;
using System.Drawing;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using ZNLCRM.Utility;

namespace ZNLCRM.Controls
{
    public partial class UcDataGridView : DataGridViewX
    {
        #region 属性
        private static bool _ctrlCKeyDown; //是否已按下Ctrl+C
        private bool _showRowNo;//是否显示行号
        [Category("行为"), DefaultValue(false)]
        public bool ShowRowNo
        {
            get { return _showRowNo; }
            set
            {
                _showRowNo = value;
                if (_showRowNo)
                {
                    this.RowHeadersVisible = true;
                    this.RowHeadersWidth = 40;
                    this.RowPostPaint += new DataGridViewRowPostPaintEventHandler(ucDataGridViewX_RowPostPaint);
                }
                else
                {
                    this.RowPostPaint -= new DataGridViewRowPostPaintEventHandler(ucDataGridViewX_RowPostPaint);
                }
            }
        }
        #endregion

        public UcDataGridView()
        {
            InitializeComponent();
            if (!this.DesignMode)
            {
                InitalizeSetup();
            }
        }

        public UcDataGridView(IContainer container)
        {
            InitializeComponent();
            if (!this.DesignMode)
            {
                container.Add(this);
                InitalizeSetup();
            }
        }

        void ucDataGridViewX_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            Rectangle rectangle = new Rectangle(e.RowBounds.Location.X,
                e.RowBounds.Location.Y,
                this.RowHeadersWidth - 4,
                e.RowBounds.Height);

            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(),
                this.RowHeadersDefaultCellStyle.Font,
                rectangle,
                this.RowHeadersDefaultCellStyle.ForeColor,
                TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }

        void InitalizeSetup()
        {
            this.AllowUserToAddRows = false;
            this.AllowUserToDeleteRows = false;
            this.AllowUserToOrderColumns = true;
            this.AutoGenerateColumns = false;

            this.HighlightSelectedColumnHeaders = false;
            this.RowTemplate.Resizable = DataGridViewTriState.False;
            this.PaintEnhancedSelection = false;
            this.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.BackgroundColor = System.Drawing.Color.White;

            DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
            dataGridViewCellStyle.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle.SelectionBackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.DefaultCellStyle = dataGridViewCellStyle;
            this.SelectAllSignVisible = false;
            this.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.ShowCellToolTips = true;

            //防止数据绑定出错，弹出错误框
            this.DataError += delegate(object sender, DataGridViewDataErrorEventArgs e)
            {
                e.Cancel = true;
            };

            //去掉焦点虚框
            this.RowPrePaint += delegate(object sender, DataGridViewRowPrePaintEventArgs e)
            {
                e.PaintParts = e.PaintParts ^ DataGridViewPaintParts.Focus;
            };

            //如果是负数，用红字显示
            this.CellFormatting += delegate(object sender, DataGridViewCellFormattingEventArgs e)
            {
                DataGridViewX senderDgv = sender as DataGridViewX;

                if (e.ColumnIndex > -1 && senderDgv.Columns[e.ColumnIndex].Tag is ColorPickerButton)
                {
                    return;
                }
                if (e.Value != DBNull.Value && e.Value != null && (e.Value is int || e.Value is decimal || e.Value is double))
                {
                    e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    bool isSign = false;
                    if (e.Value is int && Convert.ToInt32(e.Value) < 0)
                    {
                        isSign = true;
                    }
                    else if (e.Value is decimal)
                    {
                        if (e.Value != null && e.Value.ToDecimal() != 0)
                        {
                            if (e.Value.ToStringHasNull().IndexOf(".") != -1)
                            {
                                e.Value = e.Value.ToDecimal().ToString("G").TrimEnd('0').TrimEnd('.'); //去掉小数点后多余的零 addby:allen.he
                            }
                        }
                        else
                        {
                            e.Value = "0";
                        }
                        if (Convert.ToDecimal(e.Value) < 0.0m)
                        {
                            isSign = true;
                        }
                    }
                    else if (e.Value is double && Convert.ToDouble(e.Value) < 0.0d)
                    {
                        isSign = true;
                    }

                    if (isSign)
                    {
                        e.CellStyle.ForeColor = Color.Red;
                    }
                }
            };

            this.CellEnter += delegate(object sender, DataGridViewCellEventArgs e)
            {
                //如果是下列表，就打开下拉
                if (this.Columns[e.ColumnIndex] is DataGridViewComboBoxColumn && !this[e.ColumnIndex, e.RowIndex].ReadOnly)
                {
                    SendKeys.Send("{F4}");
                }
            };
            this.CurrentCellDirtyStateChanged += delegate(object sender, EventArgs e)
            {
                DataGridView dgv = sender as DataGridView;
                if (dgv.IsCurrentCellDirty && dgv.CurrentCell is DataGridViewCheckBoxCell)
                {
                    dgv.CommitEdit(DataGridViewDataErrorContexts.Commit);
                }
            };

            #region 排序比较(防止异常)
            this.SortCompare += delegate(object sender, DataGridViewSortCompareEventArgs e)
            {
                e.SortResult = StringHandler.Compare(e.CellValue1, e.CellValue2);
                e.Handled = true;
            };
            #endregion

            this.KeyDown += delegate(object sender, KeyEventArgs e)
            {
                if ((e.Control) && e.KeyCode == Keys.C)
                {
                    _ctrlCKeyDown = true;
                    return;
                }
            };
            this.LostFocus += delegate(object sender, EventArgs e)
            {
                if (_ctrlCKeyDown)
                {
                    Clipboard.SetData("Text", Clipboard.GetText());
                }
            };
           
            //this.SelectionChanged += delegate(object sender, EventArgs e)
            //{
            //    DataGridView dgv = sender as DataGridView;
            //    dgv.ClearSelection();
            //};
        }

    }
}
