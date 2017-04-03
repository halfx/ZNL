using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZNLCRM.UI.Logic.CRM;
using ZNLFrame.Entity;
using ZNLCRM.Entity.UserModel.CRM;
using ZNLCRM.UI.Logic.Common;
using ZNLCRM.Utility;
using ZNLCRM.Entity.UserModel.Common;

namespace ZNLCRM.UI.CRM
{
    public partial class frmCRMVisitPlanManage : frmBaseForm
    {

        CRM_VisitPlanLogic planLogic = null;
        int rowIndex = 0;
        int custVstPlnID = 0;
        Guid custVstPlnGuID;
        public frmCRMVisitPlanManage()
        {
            InitializeComponent();
            planLogic = new CRM_VisitPlanLogic(this);
        }
        #region 窗体加载
        private void frmCRMVisitPlanManage_Load(object sender, EventArgs e)
        {
           
            BindDataGridView(1);
        }
        #endregion

        #region  绑定表格
        private void BindDataGridView(int pageIndex)
        { 
          
            CRM_VisitPlanParam   param=new CRM_VisitPlanParam();
            param.PlanName = txtPlanName.Text;
            param.PageIndex = pageIndex;
            param.PageSize=100;
              PageList<CRM_VisitPlanResult> pageList = this.AsyncExecute<PageList<CRM_VisitPlanResult>, CRM_VisitPlanParam>(param, planLogic.GetPageList, a =>
              {

                 dgvPlan.DataSource = a.ResultList;
                 pgPlan.RecordCount = a.TotalCount;
                 
              });
        } 
        #endregion

        #region 添加拜访计划
        private void tsbAddVisitPlan_Click(object sender, EventArgs e)
        {
            frmCRMVisitPlan frmCRMVisitPlan = new frmCRMVisitPlan();
            frmCRMVisitPlan.ShowDialog();
            frmCRMVisitPlan.BringToFront();
            //frmCRMVisitPlan.RefreshParentForm += new CRM.frmCRMVisitPlan.dlgRefreshParentForm (BindDataGridView);
            frmCRMVisitPlan.RefreshParentForm += delegate{ BindDataGridView(pgPlan.PageIndex);};
        }
        #endregion
        #region 编辑拜访计划
        private void tsbEditVisitPlan_Click(object sender, EventArgs e)
        {
            if (custVstPlnID > 0)
            {
                frmCRMVisitPlan frmCRMVisitPlan = new frmCRMVisitPlan();
                frmCRMVisitPlan.custVstPlnID = custVstPlnID;
                frmCRMVisitPlan.custVstPlnGuID = custVstPlnGuID;
                frmCRMVisitPlan.ShowDialog();
                frmCRMVisitPlan.BringToFront();
            }
            else
            {
                this.ShowMessage("请选择要编辑的拜访计划");

            }
        }
        #endregion 
        #region 删除拜访计划
        private void tsbDelVisitPlan_Click(object sender, EventArgs e)
        {

            CRM_VisitPlanParam param = new CRM_VisitPlanParam();
            param.CustVstPlnID = custVstPlnID;

            CRM_VisitPlanResult rst = planLogic.GetInfo(param);
            if (rst != null)
            {
                if (MessageBox.Show("请确认是否要删除拜访计划：【" + rst.PlanName + "】", "操作提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    WCFAddUpdateResult result = this.AsyncExecute<WCFAddUpdateResult, CRM_VisitPlanParam>(param, planLogic.DelInfo, a => { BindDataGridView(pgPlan.PageIndex); });
                }
            }
            else
            {
                this.ShowMessage("请选择需要删除的拜访计划！");
            }
        }
        #endregion

        private void pgPlan_PageIndexChanged(object sender, EventArgs e)
        {
            BindDataGridView(pgPlan.PageIndex);
        }

        #region 搜索
        private void btnSearch_Click(object sender, EventArgs e)
        {
            BindDataGridView(1);
        }
        #endregion

        private void dgvPlan_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                rowIndex = e.RowIndex;
                custVstPlnID = dgvPlan["colCustVstPlnID", rowIndex].Value.ToInt32();
                custVstPlnGuID = dgvPlan["colCustVstPlnGuID", rowIndex].Value.ToGuid();
            }
              
        }

        private void dgvPlan_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                tsbEditVisitPlan_Click(sender, e);
            }
        }

        private void dgvPlan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            { 
                if(dgvPlan.Columns[e.ColumnIndex].Name.Contains("colRecordResult"))
                {
                    frmCRMVisitPlanLine frmCRMVisitPlanLine = new frmCRMVisitPlanLine();
                    frmCRMVisitPlanLine.ShowDialog();
                    frmCRMVisitPlanLine.BringToFront();
                    frmCRMVisitPlanLine.custVstPlnGuID = custVstPlnGuID;
                    
                }
            }
        }

      


    }
}
