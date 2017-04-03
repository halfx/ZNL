using System;
using System.Collections.Generic;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using DevComponents.DotNetBar.Controls;

namespace ZNLCRM.Controls
{
    /// <summary>
    /// 联想输入控件(表格)
    /// </summary>
    public class ucAutoCompleteGrid : UcDataGridView
    {
        #region 私有变量
        private string _tableName;//表名
        private string _searchFilter;//过滤条件
        private string _keyField;//键值字段

        DataTable _dt = null;//表数据
        BindingSource _bs = null;//绑定数据源

        Control _editControl = null;
        /// <summary>
        /// 编辑控件
        /// </summary>
        public Control EditControl
        {
            get { return _editControl; }
            set
            {
                _editControl = value;
                if (value != null)
                {
                    _editControl.TextChanged -= new EventHandler(EditControl_TextChanged);
                    _editControl.TextChanged += new EventHandler(EditControl_TextChanged);
                    //_editControl.KeyUp += new KeyEventHandler(EditControl_KeyUp);
                    _editControl.KeyPress -= new KeyPressEventHandler(EditControl_KeyPress);
                    _editControl.KeyPress += new KeyPressEventHandler(EditControl_KeyPress);
                    _editControl.KeyDown -= new KeyEventHandler(EditControl_KeyDown);
                    _editControl.KeyDown += new KeyEventHandler(EditControl_KeyDown);
                    _editControl.Leave -= new EventHandler(EditControl_Leave);
                    _editControl.Leave += new EventHandler(EditControl_Leave);
                    if (_editControl is TextBoxX && (_editControl as TextBoxX).ButtonCustom.Visible)
                    {
                        (_editControl as TextBoxX).ButtonCustomClick -= new EventHandler(EditControl_CustomButtonClick);
                        (_editControl as TextBoxX).ButtonCustomClick += new EventHandler(EditControl_CustomButtonClick);
                    }
                }
            }
        }


        string _head = string.Empty;

        bool isSearch = true;
        #endregion

        #region 事件
        public delegate void ReturnParmsEventHandler(object sender, DataGridViewRow retRow);
        public event ReturnParmsEventHandler ReturnParam;
        #endregion

        public ucAutoCompleteGrid(string tableName, string keyField, string searchFilter = "")
        {
            if (!this.DesignMode)
            {
                InitializeVariable(tableName, keyField, searchFilter);
            }
        }

        #region 变量初始化
        private void InitializeVariable(string tableName, string keyField, string searchFilter)
        {
            try
            {
                _tableName = tableName;
                _searchFilter = searchFilter;
                _keyField = keyField;

                //_fields = new List<Sys_TableField>();
                //_fields = FormFactoryLogic.GetTableFields(_tableName, "", "ListSortIndex");
                //CreateDataGridView(_fields);
            }
            catch
            {

            }
        }
        #endregion

        #region 创建DataGrieViewX
        //private void CreateDataGridView(List<Sys_TableField> fields)
        private void CreateDataGridView()
        {
            //if (fields == null)
            //{
            //    return;
            //}
            this.SuspendLayout();
            this.Dock = DockStyle.None;
            this.RowHeadersVisible = false;
             this.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Visible = false;
            this.Enabled = false;
            this.ResumeLayout();

            _bs = new BindingSource();
        }
        #endregion

        #region 控件输入改变
        private void EditControl_TextChanged(object sender, EventArgs e)
        {
            if (!isSearch)
            {
                isSearch = true;
                return;
            }
            string searchKey = _editControl.Text.Trim();
            if (searchKey.Length < 1)
            {
                if (this.Visible)
                {
                    this.Visible = false;
                }
                return;
            }
            if (_editControl.Parent != null)
            {
                //把列表加到控件同父级的容器中
                if (this.Parent == null)
                {
                    //this.Parent.Controls.Add(_dgv);
                    Point p = new Point(_editControl.Left, _editControl.Bottom);
                    Control parent = _editControl.Parent;
                    //一级一级的往上定位，直到Form一级
                    while (!(parent is Form) && parent != null)
                    {
                        p.X += parent.Left;
                        p.Y += parent.Top;
                        parent = parent.Parent;
                    }

                    this.Location = p;
                    if (parent != null)
                    {
                        parent.Controls.Add(this);
                    }
                }
                //判断是否需要重新查询数据库
                //=两个字符才查询
                //条件,关键字前两个字符写上次查询的不一样

                if (searchKey.Length >= 1 && searchKey != _head)
                {
                    _head = searchKey;
                    string strWhere = "";// ControlFactory.AnalyzeFilterStr(_searchFilter);
                    if (string.IsNullOrEmpty(strWhere))
                    {
                        strWhere = string.Format("{0} like '%{1}%'", _keyField, searchKey);
                    }
                    else
                    {
                        strWhere += string.Format(" And {0} like '%{1}%'", _keyField, searchKey);
                    }

                    string orderBy = string.Empty;
                    //if (!string.IsNullOrEmpty(_keyField) && _fields.Find(a => a.FieldName == _keyField) != null)
                    //{
                    //    orderBy = _keyField;
                    //}
                    //_dt = icErp.Utility.DataAccess.GetToDataTable(_tableName, strWhere, orderBy);  //速度太慢了,注释 add by:allen
                    try
                    {

                        DataTable dt = null;//icErp.Utility.DataAccess.GetDataTableBySql(string.Format("select top 20 * from [{0}] where {1} {2}", _tableName, strWhere,string.IsNullOrEmpty(orderBy)?"":("order by "+orderBy)));
                        if (_dt == null)
                        {
                            _dt = dt;
                        }
                        else
                        {
                            _dt.Clear();
                            if (dt != null && dt.Rows.Count > 0)
                            {
                                foreach (DataRow dr in dt.Rows)
                                {
                                    _dt.ImportRow(dr);
                                }
                            }
                        }
                        if (_bs.DataSource == null)
                        {
                            _bs.DataSource = _dt;
                        }
                        if (this.DataSource == null)
                        {
                            this.DataSource = _bs;
                        }
                        _bs.Filter = "";

                        if (_dt.Rows.Count < 1)
                        {
                            this.Visible = false;
                        }
                    }
                    catch
                    {}
                }
                else if (searchKey.Length == 2 && searchKey == _head)
                {
                    _bs.Filter = "";

                    if (_dt.Rows.Count < 1)
                    {
                        this.Visible = false;
                    }
                }
                else if (searchKey.Length > 2)
                {
                    //从表中筛选
                    _bs.Filter = string.Format("{0} like '%{1}%'", _keyField, searchKey);
                    //_bs.ffi
                    if (this.Rows.Count < 1)
                    {
                        this.Visible = false;
                    }
                }

            }
        }
        #endregion

        //#region 编辑控件向下按钮
        //private void EditControl_KeyUp(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyData == Keys.Down)
        //    {
        //        isFocus = false;
        //        if (!this.Visible)
        //        {
        //            this.Visible = true;
        //        }

        //        e.Handled = true;
        //        this.Focus();
        //        isFocus = true;
        //        return;
        //    }
        //}
        //#endregion

        #region MyRegion
        private void EditControl_KeyPress(object seder, KeyPressEventArgs e)
        {
            this.BringToFront();
            if (!this.Visible && (e.KeyChar == (char)8 || e.KeyChar >= (char)48))
            {
                this.Visible = true;
            }
        }
        #endregion

        void EditControl_Leave(object sender, EventArgs e)
        {
            this.Visible = false;
            if (sender is TextBoxXEditingControl)
            {
                //if (this.CurrentRow != null)
                //{
                    if (this.ReturnParam != null)
                    {
                        isSearch = false;
                        this.ReturnParam(this, this.CurrentRow);
                    }
                //}
            }
        }

        void EditControl_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.Rows.Count > 0)
            {
                int rowIndex = -1;
                if (this.CurrentRow != null)
                {
                    rowIndex = this.CurrentRow.Index;
                }

                if (e.KeyCode == Keys.Down)
                {
                    //箭头向下
                    //列表下移一行,填充输入框
                    if (!this.Visible)
                    {
                        this.Visible = true;
                    }
                    rowIndex++;
                    if (rowIndex == this.Rows.Count)
                    {
                        rowIndex = 0;
                    }
                    this.CurrentCell = this.Rows[rowIndex].Cells[this.Columns.GetFirstColumn(DataGridViewElementStates.Visible).Index];
                    isSearch = false;
                    EditControl.Text = this.Rows[rowIndex].Cells["col_" + _tableName + "_" + _keyField].Value.ToString();
                    (EditControl as TextBox).Select(EditControl.Text.Length, 1);
                }
                else if (e.KeyCode == Keys.Up)
                {
                    e.Handled = true;
                    if (!this.Visible)
                    {
                        this.Visible = true;
                    }
                    rowIndex--;
                    if (rowIndex < 0)
                    {
                        rowIndex = this.Rows.Count - 1;
                    }
                    this.CurrentCell = this.Rows[rowIndex].Cells[this.Columns.GetFirstColumn(DataGridViewElementStates.Visible).Index];
                    isSearch = false;
                    EditControl.Text = this.Rows[rowIndex].Cells["col_" + _tableName + "_" + _keyField].Value.ToString();
                    (EditControl as TextBox).Select(EditControl.Text.Length + 1, 1);
                }
                else if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
                {
                    //回车或tab键选择

                    if (this.CurrentRow != null)
                    {
                        if (this.ReturnParam != null)
                        {
                            isSearch = false;
                            this.Visible = false;
                            this.ReturnParam(this, this.CurrentRow);
                        }
                    }
                }
            }
        }

        #region TextBoxX的CustomButtomClick
        private void EditControl_CustomButtonClick(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                this.Visible = false;
            }
        }
        #endregion
    }
}
