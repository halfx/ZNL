using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZNLCRM.Entity.UserModel.Sys;
using ZNLCRM.UI.Logic.Common;
using ZNLCRM.Entity.UserModel.Common;
using ZNLCRM.UI.Logic.Sys;
using ZNLFrame.Entity;
using ZNLCRM.Utility.CommonEnum;


namespace ZNLCRM.UI.SYS
{
    public partial class frmSys_RootDirMapping : frmBaseForm
    {
        Sys_RootDirMappingLogic logic = null;
        SYS_DictItemLineLogic dictLineLogic = null;
        public frmSys_RootDirMapping()
        {
            InitializeComponent();
            logic = new Sys_RootDirMappingLogic(this);
            dictLineLogic = new SYS_DictItemLineLogic(this);
        }

        private void frmSys_RootDirMapping_Load(object sender, EventArgs e)
        {
            BindComboBox();
            BindDataGridView(pgMapping.PageIndex);
        }

        private void ClearConent()
        {
            txtMID.Text = string.Empty;
            txtMGuid.Text = string.Empty;
            txtPhysicalRootPath.Text = string.Empty;
            txtMappingIdentifier.Text = string.Empty;
            cboAttachType.Text = string.Empty;
            chkIsEffect.Checked = false;
        }
        private void tsbAdd_Click(object sender, EventArgs e)
        {
            this.ShowEditWindow("添加映射表", panelEdit);
            ClearConent();
            chkIsEffect.Checked = true;
            txtPhysicalRootPath.Text = @"D:\ZnlAtt\{Company}\{FolderName}";
            
        }

        private void BindComboBox()
        {
            List<SYS_DictItemLineResult> itemLineList = dictLineLogic.GetListByCode(new SYS_DictItemLineParam
            {
                ItemCodes = new string[] {
                "AttachType" }
            });
            dictLineLogic.BindComboBox(cboAttachType, "AttachType", itemLineList);
            dictLineLogic.BindComboBox(colAttachType, "AttachType", itemLineList);
        }

        private void BindDataGridView(int pageIndex)
        { 
            Sys_RootDirMappingParam param=  new Sys_RootDirMappingParam();
            if(!string.IsNullOrEmpty(txtSMappingIdentifier.Text.Trim()))
                param.MappingIdentifier=txtMappingIdentifier.Text.Trim();
            param.PageIndex = pageIndex;
            param.PageSize = 100;
            PageList<Sys_RootDirMappingResult> pageList = this.AsyncExecute<PageList<Sys_RootDirMappingResult>, Sys_RootDirMappingParam>(param, logic.GetPageList, a =>
            {

                dgvMapping.DataSource = a.ResultList;
                pgMapping.RecordCount = a.TotalCount;

            });
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Sys_RootDirMappingResult info = new Sys_RootDirMappingResult();
            info = this.ConvertControlToEntity<Sys_RootDirMappingResult>(this.panelEdit.Controls, info, null);

            WCFAddUpdateResult result = this.AsyncExecute<WCFAddUpdateResult, Sys_RootDirMappingResult>(info, logic.AddOrUpdate, (a) =>
            {
                if (a.Key > 0)
                {
                    BindDataGridView(pgMapping.PageIndex);
                    this.HidEditWindow();
                }
            });
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.HidEditWindow(); 
        }

        private void pgMapping_PageIndexChanged(object sender, EventArgs e)
        {
            BindDataGridView(pgMapping.PageIndex);
        }

        private void txtPhysicalRootPath_TextChanged(object sender, EventArgs e)
        {

        }

    
       
    }
}
