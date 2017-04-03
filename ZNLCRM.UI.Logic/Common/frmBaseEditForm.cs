using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZNLCRM.Entity.UserModel.Common;

namespace ZNLCRM.UI.Logic.Common
{
    public partial class frmBaseEditForm : frmBaseForm
    {
        protected object _editBeforeData;
        protected object _editCurrentData;
        object _fromWinWhere;
        protected object FromWinWhere
        {
            get {return _fromWinWhere; }
            set{_fromWinWhere=value;}
        }
        Guid? _guidKey = null;
        bool _isChanged = false;
        public delegate object dlgGetEditEntity();
        public event dlgGetEditEntity GetEditEntity;
        protected bool DataIsChanged
        {
            set { _isChanged = value; }
            get { return _isChanged; }
        }
        protected Guid? GuidKey
        {
            set { _guidKey=value; }
            get { return _guidKey; }
        }
        protected object EditBeforeData
        {
            set { _editBeforeData = value; }
            get { return _editBeforeData; }
        }
        protected object EditCurrentData
        {
            set { _editCurrentData = value; }
            get { return _editCurrentData; }
        }
        public frmBaseEditForm()
        {
            InitializeComponent();
            if (!this.DesignMode)
            {
                FormClosing += frmBaseEditForm_Closeing;
            }
        }
        protected void ShowNoChangedMsg()
        {
            this.ShowMessage("数据未做任修改,不允许修改数据!");
        }
        protected void frmBaseEditForm_Closeing(object sender, FormClosingEventArgs e)
        {
            if (GetEditEntity != null) _editCurrentData=GetEditEntity();
            if(_isChanged)
            {
                if (MessageBox.Show("您有修改数据,是否不保存退出?", "保存提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }
        
        protected bool SetDataIsChanged<T>(T newData)
        {
            bool ret = false;
            ret = this.EntityIsChanged<T>(newData, (T)_editBeforeData, false);
            this._editCurrentData = newData;
            _isChanged = ret;
            return ret;
        }
        protected void SetDataIsNoChanged()
        {
            this._editBeforeData = this._editCurrentData;
            this._isChanged = false;
        }
        protected void SaveComplete(WCFAddUpdateResult exeRst,params Control.ControlCollection[] controlsArr)
        {
            this._editBeforeData = this._editCurrentData;
            foreach (Control.ControlCollection controls in controlsArr)
            {
                this.ConvertEntityToControl<WCFAddUpdateResult>(controls, exeRst, null);
                this.ConvertControlToEntity<object>(controls, this._editCurrentData, null);
            }
            this.GuidKey = exeRst.KeyGuid;
            this._isChanged = false;
            this.ShowMessage("保存成功!");
        }
    }
}
