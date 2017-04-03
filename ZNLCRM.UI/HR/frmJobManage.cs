using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZNLCRM.UI.Logic.Common;
using ZNLCRM.UI.Logic.HR;
using ZNLCRM.Entity.UserModel.HR;
using ZNLFrame.Entity;
using ZNLCRM.Utility;
using ZNLCRM.Entity.UserModel.Common;
using ZNLCRM.Entity.UserModel.CRM;
using ZNLCRM.UI.WF;
using ZNLCRM.UI.Logic.WF;


namespace ZNLCRM.UI.HR
{
    public partial class frmJobManage : frmBaseManageForm
    {
        ZNLCRM.UI.Logic.AppHandler.SearchAssembleHandler appHandler;
        public frmJobManage()
        {
            InitializeComponent();
            appHandler = new Logic.AppHandler.SearchAssembleHandler(this);
        }

        void BindData(int pageIndex)
        {
            CRM_JobMastLogic logic = new CRM_JobMastLogic(this);
            CRM_JobMastParam param = new CRM_JobMastParam();
            param = this.ConvertControlToEntity<CRM_JobMastParam>(this.panTop.Controls, param, null);
            param.PageIndex = pageIndex;
            param.PageSize = this.pagMain.PageSize;
            param.IsPage = true;
            PageList<CRM_JobMastResult> pageList = this.AsyncExecute<PageList<CRM_JobMastResult>, CRM_JobMastParam>(param, logic.GetPageList, BindDataComplete);
        }
        void BindDataComplete(PageList<CRM_JobMastResult> a)
        {
            this.dgvMain.DataSource = a.ResultList;
            this.pagMain.RecordCount = a.TotalCount.ToInt32();
        }

        private void frmJobManage_Load(object sender, EventArgs e)
        {
            appHandler.CreateControlInPanel(this.GetType().FullName,  this.btnSearch, this.panTop);
            BindData(1);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            BindData(1);
        }

        private void ucLabel4_Click(object sender, EventArgs e)
        {

        }

        private void pagMain_PageIndexChanged(object sender, EventArgs e)
        {
            BindData(this.pagMain.PageIndex);
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tlbMain_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            string jobType = "";
            #region 新增
            if (e.ClickedItem.Name == "tlbAdd1" || e.ClickedItem.Name == "tlbAdd2" || e.ClickedItem.Name == "tlbAdd3")
            {
                if (e.ClickedItem.Name == "tlbAdd1") jobType = "日报";
                if (e.ClickedItem.Name == "tlbAdd2") jobType = "周报";
                if (e.ClickedItem.Name == "tlbAdd3") jobType = "月报";
                frmJobEdit frmEdit = new frmJobEdit(jobType, null);
                frmEdit.ShowDialog();
            }
            #endregion
            #region 修改
            else if (e.ClickedItem.Name == "tlbEdit")
            {
                editData();
            }
            #endregion
            #region 删除
            if (e.ClickedItem.Name == "tlbDel")
            {
                int rowIdx = this.dgvMain.CurrentCell == null ? -1 : this.dgvMain.CurrentCell.RowIndex;
                if (rowIdx < 0)
                {
                    this.ShowMessage("请指定要删除记录！");
                    return;
                }
                Guid? guidKey = this.dgvMain["col_CRM_JobMast_EmpJobGuid", rowIdx].Value.ToGuid();
                CRM_JobMastLogic logic = new CRM_JobMastLogic(this);
                WCFAddUpdateResult rst = logic.DelInfo(new CRM_JobMastParam() { EmpJobGuid = guidKey });
                if (rst.Key > 0)
                {
                    BindData(this.pagMain.PageIndex);
                }
            }
            #endregion
            #region 审核
            else if (e.ClickedItem.Name == "tlbAuditBill")
            {
                auditBill();
            }
            #endregion
            #region 撤单
            else if (e.ClickedItem.Name == "tlbCancelBill")
            {
                cancelBill();
            }
            #endregion
        }
        void editData()
        {
            int rowIdx = this.dgvMain.CurrentCell == null ? -1 : this.dgvMain.CurrentCell.RowIndex;
            if (rowIdx < 0)
            {
                this.ShowMessage("请指定要修改记录！");
                return;
            }
            Guid? guidKey = this.dgvMain["col_CRM_JobMast_EmpJobGuid", rowIdx].Value.ToGuid();
            frmJobEdit frmEdit = new frmJobEdit("", guidKey);
            frmEdit.ShowDialog();
        }
        void auditBill()
        {
            int rowIdx = this.dgvMain.CurrentCell == null ? -1 : this.dgvMain.CurrentCell.RowIndex;
            if (rowIdx < 0)
            {
                this.ShowMessage("请指定要审核记录！");
                return;
            }
            Guid? guidKey = this.dgvMain["col_CRM_JobMast_EmpJobGuid", rowIdx].Value.ToGuid();
            string billNo = this.dgvMain["col_CRM_JobMast_BillNo", rowIdx].Value.ToStringHasNull();
            ZNLCRM.UI.Logic.WF.frmAuditRecordList frmRecord = new ZNLCRM.UI.Logic.WF.frmAuditRecordList("CRM_JobMast", guidKey, billNo);
            frmRecord.ShowDialog();
        }
        void cancelBill()
        {
            int rowIdx = this.dgvMain.CurrentCell == null ? -1 : this.dgvMain.CurrentCell.RowIndex;
            if (rowIdx < 0)
            {
                this.ShowMessage("请指定要撤单的记录！");
                return;
            }
            Guid? guidKey = this.dgvMain["col_CRM_JobMast_EmpJobGuid", rowIdx].Value.ToGuid();
            WF_AuditRecordLogic logicWF = new WF_AuditRecordLogic(this);
            WCFAddUpdateResult rstAudit = logicWF.CancelBill(new Entity.UserModel.WF.WF_AuditRecordParam()
            {
                SourceTableEngName = "CRM_JobMast",
                SourceBillGuid = guidKey
            });
            if (rstAudit.Key > 0)
            {
                BindData(1);
                this.ShowMessage("撤单成功!");
            }
        }

        private void dgvMain_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            editData();
        }
    }
}
