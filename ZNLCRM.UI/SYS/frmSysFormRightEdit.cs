using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZNLCRM.UI.Logic.Common;
using ZNLCRM.Entity.UserModel.Sys;
using ZNLCRM.UI.Logic.Sys;
using ZNLCRM.Entity.UserModel.Common;
using ZNLCRM.Utility;
using ZNLFrame.Entity;

namespace ZNLCRM.UI.SYS
{
    public partial class frmSysFormRightEdit : frmBaseEditForm
    {
        public int _formrightid;
        public frmSysFormRightEdit(int key)
        {
            InitializeComponent();
            _formrightid = key;
            this.GetEditEntity += new dlgGetEditEntity(Form_GetEditEntity);

        }
        #region 装载数据和设置界面状态
        void LoadData()
        {
            if (_formrightid == -1) return;
            Sys_FormRightLogic logic = new Sys_FormRightLogic(this);
            Sys_FormRightResult rst = logic.GetInfo(new Sys_FormRightParam()
            {
                FormRightID = _formrightid
            });
            if (rst == null) return;

            this.ConvertEntityToControl(this.grpMain.Controls, rst, null);
            this.EditBeforeData = rst;
        }
        #endregion
        #region 实现基类获取实体信息方法
        object Form_GetEditEntity()
        {
            Sys_FormRightResult info = new Sys_FormRightResult();
            info.FormRightID = _formrightid;
            info = this.ConvertControlToEntity<Sys_FormRightResult>(this.grpMain.Controls, info, null);
            this.SetDataIsChanged<Sys_FormRightResult>(info);
            return info;
        }
        #endregion

        private void frmSysFormRightEdit_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Sys_FormRightResult info = Form_GetEditEntity() as Sys_FormRightResult;
            if (!this.DataIsChanged)
            {
                this.ShowNoChangedMsg();
                return;
            }
            Sys_FormRightLogic logic = new Sys_FormRightLogic(this);
            WCFAddUpdateResult pageList = this.AsyncExecute<WCFAddUpdateResult, Sys_FormRightResult>(info, logic.AddOrUpdate,SaveComplete);
      
        }
        void SaveComplete(WCFAddUpdateResult a)
        {
            if (a.Key > 0)
            {
                this.SaveComplete(a, this.grpMain.Controls);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtModuleName_ButtonCustomClick(object sender, EventArgs e)
        {
            frmSelectModule frmModule = new frmSelectModule(false);
            DialogResult rst = frmModule.ShowDialog();
            if (rst == DialogResult.OK)
            {
                List<Sys_ModuleResult> slcModule = frmModule.GetSelectList<Sys_ModuleResult>();
                this.txtModuleID.Text = slcModule[0].ModuleID.ToStringHasNull();
                this.txtModuleName.Text = slcModule[0].ModuleName;
            }
        }

        private void txtModuleName_ButtonCustom2Click(object sender, EventArgs e)
        {
            this.txtModuleID.Text = "";
            this.txtModuleName.Text = "";
        }

        private void txtModuleName_KeyUp(object sender, KeyEventArgs e)
        {
            if (IsSysKeys(e.KeyCode)) return;
            Sys_ModuleParam param=new Sys_ModuleParam();
            param.ModuleName = this.txtModuleName.Text;
            List<DropGridCol> lstCol = new List<DropGridCol>();
            lstCol.Add(new DropGridCol() { IsDropSource = false, ColName = "ModuleID", HeadText = "模块ID", IsShow = false, ToControl = this.txtModuleID, Width = 10 });
            lstCol.Add(new DropGridCol() { IsDropSource = true, ColName = "ModuleName", HeadText = "模块模块名称", IsShow = true, ToControl = this.txtModuleName, Width = 200 });
            Sys_ModuleLogic logic=new Sys_ModuleLogic(this);
            CreateDropGrid<PageList<Sys_ModuleResult>, Sys_ModuleResult, Sys_ModuleParam>( 300, 200, lstCol, param, logic.GetPageList);
        }
    }
}
