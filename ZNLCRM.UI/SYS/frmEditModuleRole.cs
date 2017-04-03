using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZNLCRM.UI.Logic.Common;
using ZNLCRM.Entity.DBModel;
using ZNLCRM.Entity.UserModel.Sys;
using ZNLCRM.UI.Logic.Sys;
using ZNLFrame.Entity;

namespace ZNLCRM.UI.SYS
{
    public partial class frmEditModuleRole : frmBaseForm
    {
        string EmpID = string.Empty;
        string EmpName = string.Empty;
        string ModuleID = string.Empty;
        string ModuleName = string.Empty;
        string ModuleOperation = string.Empty;


        public delegate void RefreshPeantHandler();
        public event RefreshPeantHandler refreshPeantHandler;


        public frmEditModuleRole(string EmpID, string EmpName, string ModuleID, string ModuleName, string ModuleOperation)
        {
            InitializeComponent();
            this.EmpID = EmpID;
            this.EmpName = EmpName;
            this.ModuleID = ModuleID;
            this.ModuleName = ModuleName;
            this.ModuleOperation = ModuleOperation;
            //this.txtModuleCode.Text = ModuleID;
            //this.txtModuleName.Text = ModuleName;
            //InitiaCbx();
        }


        private void frmEditModuleRole_Load(object sender, EventArgs e)
        {
            this.txtEmpName.Text = EmpID;
            this.txtEmpID.Text = EmpName;
            this.txtModuleCode.Text = ModuleID;
            this.txtModuleName.Text = ModuleName;
            InitiaCbx();
        }

        #region[单选按钮]
        public void InitiaCbx()
        {
            string[] MO = ModuleOperation.Split(',');
            for (int i = 0; i < MO.Length; i++)
            {
                if (MO[i] == "Search")
                {
                    this.cbxSearch.Checked = true;
                }
                else if (MO[i] == "New")
                {
                    this.cbx_News.Checked = true;
                }
                else if (MO[i] == "Edit")
                {
                    this.cbx_Edit.Checked = true;
                }
                else if (MO[i] == "Delete")
                {
                    this.cbx_Del.Checked = true;
                }
                else if (MO[i] == "Import")
                {
                    this.cbx_Import.Checked = true;
                }
                else if (MO[i] == "Output")
                {
                    this.cbx_Outpint.Checked = true;
                }
                else if (MO[i] == "Print")
                {
                    this.cbx_Pint.Checked = true;
                }
                else if (MO[i] == "ViewAll")
                {
                    this.cbx_ViewAll.Checked = true;
                }
                else if (MO[i] == "Approve")
                {
                    this.cbx_App.Checked = true;
                }
            }
        }
        #endregion

        private void btnCloseEditModule_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveEditModule_Click(object sender, EventArgs e)
        {
            Sys_EmpRightParam param = new Sys_EmpRightParam();
            param.ModuleID = Convert.ToInt32(ModuleID);
            param.EmpID = Convert.ToInt32(EmpID);
            //param.GCompanyID = Guid.NewGuid();  //当前公司的Guid
            param.ActionCode = GetEmpModuleOperation();
            //ExeResult res = new Sys_EmpRightLogic().UpdataModuleOperation(param);
            //if (res.Complete == ExeComplete.Succeed)
            //{
            //    //ShowMessage("保存数据成功!");
            //    if (refreshPeantHandler != null)
            //    {
            //        refreshPeantHandler();
            //        this.Close();
            //    }
            //}
            //else
            //{
            //    ShowMessage(res.DebugMsg);
            //}
        }

        #region[获取员工操作权限]
        public string GetEmpModuleOperation()
        {
            string Operation = string.Empty;
            if (this.cbxSearch.Checked)
            {
                Operation += "Search,";
            }
            if (this.cbx_News.Checked)
            {
                Operation += "New,";
            }
            if (this.cbx_Edit.Checked)
            {
                Operation += "Edit,";
            }
            if (this.cbx_Del.Checked)
            {
                Operation += "Delete,";
            }
            if (this.cbx_Import.Checked)
            {
                Operation += "Import,";
            }
            if (this.cbx_Outpint.Checked)
            {
                Operation += "Output,";
            }
            if (this.cbx_Pint.Checked)
            {
                Operation += "Print,";
            }
            if (this.cbx_ViewAll.Checked)
            {
                Operation += "ViewAll,";
            }
            if (this.cbx_App.Checked)
            {
                Operation += "Approve";
            }
            return Operation;
        }
        #endregion
    }
}
