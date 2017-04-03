using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZNLCRM.Entity.UserModel.Common;
using ZNLCRM.Utility;
namespace ZNLCRM.Controls
{
    public partial class UcDropDataGridView : UserControl
    {
        UcDataGridView __dropGridView;
        System.Timers.Timer __timerDropList = null;
        DateTime __timerNumber = DateTime.Now;
        List<string> __lstAddDropGridControl = new List<string>();
        Action __dropGridElapsed;

        public UcDropDataGridView()
        {
            InitializeComponent();
        }
        
        #region 创建下拉表格,为防止反复触发,性能上做了优化
        public void CreateDropGrid<T, R, P>(int width, int height
                                            , List<DropGridCol> colList, P param, Func<P, T> action)
        {
            __timerNumber = DateTime.Now;
            __dropGridElapsed = delegate()
            {
                CreateDropGridEx<T, R, P>(width, height, colList, param, action);
                __timerDropList.Stop();
            };
            if (__timerDropList == null)
            {
                __timerDropList = new System.Timers.Timer();
                __timerDropList.Interval = 100;
                __timerDropList.Elapsed -= __timerDropList_Elapsed;
                __timerDropList.Elapsed += new System.Timers.ElapsedEventHandler(__timerDropList_Elapsed); ;
            }
            __timerDropList.Start();
        }
        #endregion
        #region 计算下拉表格的弹出时间,如果到达,则显示出来
        void __timerDropList_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if ((DateTime.Now - __timerNumber).TotalMilliseconds > 700)
            {
                if (__dropGridElapsed != null) this.Invoke(__dropGridElapsed);
                __timerNumber = DateTime.Now;
                __timerDropList.Stop();
            }
        }
        #endregion
        #region 下拉表格弹出私有方法
        void CreateDropGridEx<T, R, P>(int width, int height
                                           , List<DropGridCol> colList, P param
                                           , Func<P, T> action)
        {
            #region 获取下拉文本控件
            if (!colList.Exists(a => a.IsDropSource == true))
            {
                MessageBox.Show("您没指定表格列集合的下拉文本标识！","错误提示",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            object lnkCon;
            lnkCon = colList.Find(a => a.IsDropSource == true).ToControl;
            if (lnkCon == null)
            {
                MessageBox.Show("您没指定表格列集合的下拉文本控件！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            #endregion
            #region 创建表格控件
            UcDataGridView gridView = this.ucDataGridView;
            if (gridView == null)
            {
                gridView = new UcDataGridView();
                gridView.Name = "__dropGrid";
                gridView.Anchor = AnchorStyles.None;
                this.Controls.Add(gridView);
            }
            __dropGridView = gridView;
            #endregion
            #region 执行表格数据源委托
            T t = action(param);
            List<R> rstList = new List<R>();
            if (t.GetType() == typeof(ZNLFrame.Entity.PageList<R>))
            {
                rstList = (List<R>)t.GetType().GetProperty("ResultList").GetValue(t, null);
            }
            else
            {
                rstList = t as List<R>;
            }
            #endregion
            #region 绑定表格
            gridView.ReadOnly = true;
            gridView.DataSource = null;
            gridView.Columns.Clear();
            gridView.Rows.Clear();
            foreach (DropGridCol info in colList)
            {
                gridView.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    Name = "col_" + gridView.Name + "_" + info.ColName,
                    HeaderText = info.HeadText,
                    Visible = info.IsShow,
                    DataPropertyName = info.ColName,
                    Width = info.Width
                });
            }
            gridView.DataSource = rstList;
            this.Width = width;
            this.Height = height;
            #endregion
            #region 定位表格
            if (lnkCon.GetType() == typeof(UcTextBox))
            {
                InitTextDropGrid<T, R, P>(gridView, lnkCon as UcTextBox, colList, param, action);
            }
            if (lnkCon.GetType() == typeof(DataGridViewTextBoxEditingControl))
            {
                InitGridCellDropGrid<T, R, P>(gridView, lnkCon as DataGridViewTextBoxEditingControl, colList, param, action);
            }
            #endregion
            if (!this.Visible) this.Visible = true;
        }
        #endregion
        #region 文本下拉表格的处理方式
        void InitGridCellDropGrid<T, R, P>(UcDataGridView gridView, DataGridViewTextBoxEditingControl lnkCon
                                            , List<DropGridCol> colList, P param
                                            , Func<P, T> action)
        {
            #region 定位表格
            int x = 0, y = 0;
            Control curCon = lnkCon;// lnkCon.DataGridView;
            while (!curCon.GetType().Name.ToStringHasNull().StartsWith("frm"))
            {
                x += curCon.Left;
                y += curCon.Top;
                curCon = curCon.Parent;
            }
            y += lnkCon.Height;

            //int rowIdx = lnkCon.;
            //int colIdx = lnkCon.EditingControlDataGridView;
            //x += lnkCon.EditingControlDataGridView.GetCellDisplayRectangle(colIdx, rowIdx, false).X;
            //y += lnkCon.EditingControlDataGridView.GetCellDisplayRectangle(colIdx, rowIdx, false).Y + lnkCon.EditingControlDataGridView.Rows[rowIdx].Height;

            //if (x + gridView.ClientSize.Width > gridView.ClientSize.Width)
            //{
            //    x = (x - gridView.ClientSize.Width) + lnkCon.Width < 0 ? 0 : (x - gridView.ClientSize.Width) + lnkCon.Width;
            //}

            //if (y + gridView.Height > gridView.ClientSize.Height)
            //{
            //    y = y - lnkCon.Height - -gridView.ClientSize.Height < 0 ? 0 : y - lnkCon.Height - gridView.ClientSize.Height;
            //}
            this.Left = x;
            this.Top = y;
            this.BringToFront();
            #endregion
            #region 设置控件的PreviewKeyDown等事件
            lnkCon.PreviewKeyDown -= _lnkCon_PreviewKeyDown;
            lnkCon.PreviewKeyDown += new PreviewKeyDownEventHandler(_lnkCon_PreviewKeyDown);

            lnkCon.EditingControlDataGridView.CellEnter -= _editingControlDataGridView_CellEnter;
            lnkCon.EditingControlDataGridView.CellEnter += new DataGridViewCellEventHandler(_editingControlDataGridView_CellEnter);
            lnkCon.EditingControlDataGridView.Scroll -= _gridView_Scroll;
            lnkCon.EditingControlDataGridView.Scroll += new ScrollEventHandler(_gridView_Scroll);
            lnkCon.EditingControlDataGridView.Resize -= _gridView_Resize;
            lnkCon.EditingControlDataGridView.Resize += new EventHandler(_gridView_Resize);
            #endregion
            #region 表格赋加事件
            if (gridView.Tag != lnkCon)
            {
                gridView.PreviewKeyDown -= _gridView_PreviewKeyDown;
                gridView.PreviewKeyDown += new PreviewKeyDownEventHandler(_gridView_PreviewKeyDown);
                gridView.CellClick -= _gridView_CellClick;
                gridView.CellClick += new DataGridViewCellEventHandler(_gridView_CellClick);
            }
            #endregion
            gridView.Tag = lnkCon;
            if (gridView.Rows.Count > 0)
            {
                gridView.Columns[0].Tag = colList;
            }
            if (!gridView.Visible) this.Visible = true;
        }

        #region 赋加表格事件,隐藏下拉表格
        void _editingControlDataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            __timerDropList.Stop();
            this.Visible = false;
        }
        #endregion
        #region 赋加表格可调整尺寸
        void _gridView_Resize(object sender, EventArgs e)
        {
            __timerDropList.Stop();
            this.Visible = false;
        }
        #endregion
        #region 赋加表格滚动事件
        void _gridView_Scroll(object sender, ScrollEventArgs e)
        {
            __timerDropList.Stop();
            this.Visible = false;
        }
        #endregion
        #region 赋加文本键按下回车和上下链的处理方式事件
        void _lnkCon_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.__timerDropList.Stop();
                this.Visible = false;
            }
            else if (e.KeyCode == Keys.Enter || e.KeyCode == (Keys.LButton | Keys.MButton | Keys.Back))
            {
                _gridCellClick(this.__dropGridView);
            }
            else if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
            {
                __dropGridView.Focus();
            }
        }
        #endregion
        #endregion
        #region 表格单元格的下拉表格处理方式
        
        void InitTextDropGrid<T, R, P>(UcDataGridView gridView, Control lnkCon
                                    , List<DropGridCol> colList, P param, Func<P, T> action)
        {
            #region 定位表格
            int x = 0, y = 0;
            Control curCon = lnkCon;
            while (!curCon.GetType().Name.ToStringHasNull().StartsWith("frm"))
            {
                x += curCon.Left;
                y += curCon.Top;
                curCon = curCon.Parent;
            }
            y += lnkCon.Height;

            if (x + gridView.Width > this.FindForm().ClientSize.Width)
            {
                x = (x - gridView.Width) + lnkCon.Width < 0 ? 0 : (x - gridView.Width) + lnkCon.Width;
            }

            if (y + gridView.Height > this.FindForm().ClientSize.Height)
            {
                y = y - lnkCon.Height - gridView.Height < 0 ? 0 : y - lnkCon.Height - gridView.Height;
            }
            this.Left = x;
            this.Top = y;
            this.BringToFront();
            #endregion
            #region 设置控件的KeyUp事件
            if (!__lstAddDropGridControl.Exists(a => a == lnkCon.Name))
            {
                __lstAddDropGridControl.Add(lnkCon.Name);
                lnkCon.KeyDown += delegate(object sender, KeyEventArgs e)
                {
                    if (e.KeyCode == Keys.Escape)
                    {
                        this.__timerDropList.Stop();
                        this.Visible = false;
                    }
                    else if (e.KeyCode == Keys.Enter)
                    {
                        _gridCellClick(gridView);
                    }
                    else if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
                    {
                        gridView.Focus();
                    }
                };
            }
            #endregion
            #region 表格赋加事件
            if (gridView.Tag != lnkCon)
            {
                gridView.PreviewKeyDown -= _gridView_PreviewKeyDown;
                gridView.PreviewKeyDown += new PreviewKeyDownEventHandler(_gridView_PreviewKeyDown);
                gridView.CellClick -= _gridView_CellClick;
                gridView.CellClick += new DataGridViewCellEventHandler(_gridView_CellClick);
            }
            gridView.Tag = lnkCon;
            if (gridView.Rows.Count > 0)
            {
                gridView.Columns[0].Tag = colList;
            }
            #endregion
            if (!this.Visible) this.Visible = true;
        }
        #endregion
        #region 下拉列表回车的处理事件
        void _gridView_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.__timerDropList.Stop();
                this.Visible = false;
            }
            else if (e.KeyCode == (Keys.LButton | Keys.MButton | Keys.Back))//回车
            {
                _gridCellClick(sender as UcDataGridView);
            }
        }
        #endregion
        #region 下拉表格的单击事件
        void _gridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _gridCellClick(this.__dropGridView);
        }
        void _gridCellClick(UcDataGridView gridView)
        {
            if (!gridView.Visible) return;
            #region 获取单元格格和所需物件
            Control con = gridView.Tag as Control;
            List<DropGridCol> lstCol = new List<DropGridCol>();
            if (gridView.CurrentCell == null) return;
            int rowIdx = gridView.CurrentCell.RowIndex;
            DataGridViewRow row = gridView.Rows[rowIdx];
            lstCol = gridView.Columns[0].Tag as List<DropGridCol>;
            #endregion
            #region 表格赋值
            foreach (DropGridCol info in lstCol)
            {
                if (info.ToControl != null)
                {
                    #region 文本框
                    if (info.ToControl.GetType() == typeof(UcTextBox))
                    {
                        (info.ToControl as UcTextBox).Text = row.Cells["col_" + gridView.Name + "_" + info.ColName].Value.ToStringHasNull();
                    }
                    #endregion
                    #region 表格单元格
                    else if (info.ToControl.GetType() == typeof(DataGridViewTextBoxCell))
                    {
                        DataGridViewTextBoxCell cell = (info.ToControl as DataGridViewTextBoxCell);
                        cell.Value = row.Cells["col_" + gridView.Name + "_" + info.ColName].Value.ToStringHasNull();
                    }
                    #endregion
                    #region 单元格编辑文本
                    else if (info.ToControl.GetType() == typeof(DataGridViewTextBoxEditingControl))
                    {
                        rowIdx = (info.ToControl as DataGridViewTextBoxEditingControl).EditingControlRowIndex;

                        DataGridViewCell cell = (info.ToControl as DataGridViewTextBoxEditingControl).EditingControlDataGridView.CurrentCell;
                        cell.Value = row.Cells["col_" + gridView.Name + "_" + info.ColName].Value.ToStringHasNull();
                        (info.ToControl as DataGridViewTextBoxEditingControl).Text = row.Cells["col_" + gridView.Name + "_" + info.ColName].Value.ToStringHasNull();
                    }
                    #endregion
                }
            }
            #endregion
            #region 隐藏表格
            this.Visible = false;
            con.Focus();
            #endregion
        }
        #endregion
        
    }
}
