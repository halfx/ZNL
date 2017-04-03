using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZNLCRM.Utility;
using ZNLCRM.Controls;
namespace ZNLCRM.UI.Logic.Common
{
    public partial class frmSelectForm : frmBaseEditForm
    {
        protected bool _isMutiSelect = false;
        protected List<object> _lstSelected = new List<object>();
        protected List<object> _lstDataSource = new List<object>();
        public frmSelectForm()
        {
            InitializeComponent();
        }
        protected void InitBaseSelectForm(bool isMutiSelect,UcDataGridView grid, UcCheckBox chkAll, string idColName, string chkColName)
        {
            _isMutiSelect = isMutiSelect;
            DataGridViewCheckBoxColumn chkSlc = new DataGridViewCheckBoxColumn()
            {
                ReadOnly = false,
                Width = 30,
                Frozen = true,
                Name = chkColName,
                HeaderText = ""
            };
            grid.Columns.Insert(0, chkSlc);
            #region 全选择功能控钮赋加事件 
            if (chkAll != null && _isMutiSelect)
            {
                chkAll.Visible = true;
                int x = 0, y = 0;
                x = grid.Left + grid.Columns[chkColName].Width;
                y = grid.Top + 10;
               //chkAll.Location = new Point(x + 5, y);
                chkAll.BringToFront();
                chkAll.Visible = true;
                chkAll.Dock = DockStyle.None;
                //chkAll.Size = new Size(15, 15);
                chkAll.CheckedChanged += delegate(object sender, EventArgs e)
                {
                    SelectAll(grid, chkAll, idColName, chkColName);
                };
            }
            else if (chkAll != null && !_isMutiSelect)
            {
                chkAll.Visible = false;
            }
            #endregion
            #region 表格赋加事件
            grid.CellContentClick += delegate(object sender, DataGridViewCellEventArgs e)
            {
                if (e.RowIndex < 0 || e.ColumnIndex < 0 || grid == null || grid.Columns[e.ColumnIndex].Name.IndexOf(chkColName) < 0)
                    return;
                bool isChk = grid[chkColName, e.RowIndex].EditedFormattedValue.ToBooleanHasNull();
                SetCheck(grid, e.RowIndex, isChk, idColName, chkColName);
            };
            #endregion
        }
        protected void SelectAll(UcDataGridView grid, UcCheckBox chkBox, string colChkName, string idColName, string chkColName)
        {
            if (!_isMutiSelect)
            {
                this.ShowMessage("您当前是单选模式，不允许全部选择！");
                return;
            }
            for (int i = 0; i < grid.Rows.Count; i++)
            {
                grid.Rows[i].Cells[chkColName].Value = chkBox.Checked;
                SetCheck(grid, i, chkBox.Checked, idColName, chkColName);
            }
        }
        
        public List<T> GetSelectList<T>()
        {
            List<T> ret = new List<T>();
            foreach (object obj in _lstSelected)
            {
                ret.Add((T)obj);
            }
            this.Close();
            this.Dispose();
            return ret;
        }
        protected void SetDataSource<T>(List<T> lstObj)
        {
            this._lstDataSource = new List<object>();
            foreach (object obj in lstObj)
            {
                _lstDataSource.Add(obj);
            }
        }
        protected void SetCheck(UcDataGridView grid, int rowIndex, bool isChecked, string idFieldName, string chkFieldName)
        {
            bool isChk = isChecked;
            #region 单选和多选控制不同状态
            if (!_isMutiSelect)
            {
                for (int i = 0; i < grid.Rows.Count; i++)
                {
                    if (i != rowIndex && isChk) grid[chkFieldName, i].Value = false;
                }
            }
            #endregion
            #region 设置选中状态的值
            string entityIDName = grid.Columns[idFieldName].DataPropertyName;
            string id = grid.Rows[rowIndex].Cells[idFieldName].Value.ToStringHasNull();
            object findInfo, findSlcInfo;
            findInfo = _lstDataSource.Find(a => a.GetType().BaseType.GetProperty(entityIDName).GetValue(a, null).ToStringHasNull() == id);
            if (findInfo == null) return;
            findSlcInfo = _lstSelected.Find(a => a.GetType().BaseType.GetProperty(entityIDName).GetValue(a, null).ToStringHasNull() == id);
            if (isChk)
            {
                if (!_isMutiSelect) _lstSelected.Clear();
                if (findSlcInfo == null) _lstSelected.Add(findInfo);
            }
            else
            {
                if (findSlcInfo != null) _lstSelected.Remove(findSlcInfo);
            }
            #endregion
        }
        protected void SetGridCheck(UcDataGridView grid, string idFieldName, string chkFieldName)
        {
            string entityIDName = grid.Columns[idFieldName].DataPropertyName;
            foreach (DataGridViewRow row in grid.Rows)
            {
                if (_lstSelected.Exists(a => a.GetType().BaseType.GetProperty(entityIDName).GetValue(a, null).ToStringHasNull() == row.Cells[idFieldName].Value.ToStringHasNull()))
                {
                    row.Cells[chkFieldName].Value = true;
                }
            }
        }
        protected void SelectAll(UcDataGridView grid,UcCheckBox chkAll, string idFieldName, string chkFieldName)
        {
            //if (!_isMutiSelect)
            //{
            //    this.ShowMessage("您当前是单选模式，不允许全部选择！");
            //    return;
            //}
            for (int i = 0; i < grid.Rows.Count; i++)
            {
                grid.Rows[i].Cells[chkFieldName].Value = chkAll.Checked;
                SetCheck(grid, i, chkAll.Checked, idFieldName, chkFieldName);
            }
        }
        protected void SubmitForm()
        {
            if (_lstSelected == null || _lstSelected.Count <= 0)
            {
                this.ShowMessage("请选择值！");
                return; 
            }
            this.DialogResult = DialogResult.OK;
        }
        protected void CancelForm()
        {
            this.DialogResult = DialogResult.Cancel;
            _lstSelected = null;
        }
    }
}
