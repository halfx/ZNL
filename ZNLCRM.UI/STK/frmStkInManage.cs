using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NPOI.HSSF.Record.Formula.Functions;
using ZNLCRM.UI.Logic.STK;
using ZNLCRM.UI.Logic.Sys;
using ZNLFrame.Entity;
using ZNLCRM.Entity.UserModel.Sys;
using ZNLCRM.Utility.CommonEnum;
using ZNLCRM.Entity.UserModel.STK;
using ZNLCRM.UI.Logic.Common;
using ZNLCRM.Utility;
using ZNLCRM.Entity.UserModel.Common;
using ZNLCRM.UI.Logic.WF;

namespace ZNLCRM.UI.STK
{
    public partial class frmStkInManage : frmBaseForm
    {
        ZNLCRM.UI.Logic.AppHandler.SearchAssembleHandler appHandler;
        STK_InLogic stkInlogic = null;
        SYS_DictItemLineLogic dictLineLogic = null;
        int rowIndex = 0;
        Guid? stkInGuid = null;
        public frmStkInManage()
        {
            InitializeComponent();
            stkInlogic = new STK_InLogic(this);
            dictLineLogic = new SYS_DictItemLineLogic(this);
            appHandler = new Logic.AppHandler.SearchAssembleHandler(this);
        }
        private void frmStkInManage_Load(object sender, EventArgs e)
        {
            appHandler.CreateControlInPanel(this.GetType().FullName, this.btnDtlSearch, this.panDtlWhere);
            appHandler.CreateControlInPanel(this.GetType().FullName, this.btnSearch, this.panMastWhere);
            this.panDtlWhere.Height += 35;
            this.panMastWhere.Height += 35;
            SearchStkIn(1);
        }
        #region 绑定表格,分页
        /// <summary>
        /// 绑定表格,分页控件
        /// </summary>
        /// <param name="dgv">表格控件</param>
        /// <param name="pg">分页控件</param>
        /// <param name="param">查询参数对象</param>
        /// <param name="isTable">是否返回DataTable</param>
        private void BindDataGridView(Controls.UcDataGridView dgv, Controls.UcPager pg, STK_InParam param, bool isTable)
        {
            PageList<STK_InResult> pageList = null;
            if (isTable)
            {
                pageList = this.AsyncExecute<PageList<STK_InResult>,
                STK_InParam>(param, stkInlogic.GetPageList, a =>
                {
                    dgv.DataSource = a.ResultJoinList;
                    pg.PageSize = param.PageSize.ToInt32();
                    pg.RecordCount = a.TotalCount;
                });
            }
            else
            {
                pageList = this.AsyncExecute<PageList<STK_InResult>,
                STK_InParam>(param, stkInlogic.GetPageList, a =>
                {
                    dgv.DataSource = a.ResultList;
                    pg.PageSize = param.PageSize.ToInt32();
                    pg.RecordCount = a.TotalCount;
                });
            }
        }
        #endregion

        #region 入库主单查询
        /// <summary>
        /// 入库主单查询
        /// </summary>
        public void SearchStkIn(int pgIndex)
        {
            STK_InParam param = new STK_InParam();
            param = this.ConvertControlToEntity<STK_InParam>(this.panMastWhere.Controls, param, null);
            param.PageIndex = pgIndex;
            param.PageSize = 5;
            BindDataGridView(dgvStkIn, pgStkIn, param, false);
        } 
        #endregion

       

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            frmStkIn frmStkIn = new frmStkIn();
            frmStkIn.BringToFront();
            frmStkIn.StartPosition = FormStartPosition.CenterScreen;
            frmStkIn.ShowDialog();
            frmStkIn.RefreshParentForm += delegate { SearchStkIn(pgStkIn.PageIndex); };
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            if (stkInGuid != null)
            {
                frmStkIn frmStkIn = new frmStkIn();
                frmStkIn.StkInGuid = stkInGuid;
                frmStkIn.BringToFront();
                frmStkIn.StartPosition = FormStartPosition.CenterScreen;
                frmStkIn.ShowDialog();
            }
            else
            {
                this.ShowMessage("请选择要编辑的入库单");
            }
        }

        private void tsbDel_Click(object sender, EventArgs e)
        {
            STK_InParam param = new STK_InParam();
            param.StkInGuid = stkInGuid;

            STK_InResult rst = stkInlogic.GetInfo(param);
            if (rst != null)
            {
                if (MessageBox.Show("请确认是否要删除入库单：【" + rst.BillNo + "】", "操作提示",
                    MessageBoxButtons.OKCancel, 
                    MessageBoxIcon.Question) == DialogResult.OK)
                {
                    WCFAddUpdateResult result = this.AsyncExecute<WCFAddUpdateResult, STK_InParam>(
                        param, stkInlogic.DelInfo, a => { SearchStkIn(pgStkIn.PageIndex); });
                }
            }
            else
            {
                this.ShowMessage("请选择需要删除的入库单！");
            }
        }

        #region 行进入事件
        private void dgvStkIn_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                rowIndex = e.RowIndex;
                stkInGuid = dgvStkIn["colStkInGuid", rowIndex].Value.ToGuid();
            }
        }
        #endregion

        #region  单元格双击
        private void dgvStkIn_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                tsbEdit_Click(sender, e);
            }
        }
        #endregion

        #region 分页
        private void pgList_PageIndexChanged(object sender, EventArgs e)
        {
            SearchStkIn(pgStkIn.PageIndex);
        }
        #endregion

        #region 搜索按钮
        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchStkIn(1);
        }
        #endregion
        #region 审核与取消审核
        private void tlbCancelBill_Click(object sender, EventArgs e)
        {
            AuditBill();
        }
        private void tlbAuditBill_Click(object sender, EventArgs e)
        {
            CancelBill();
        }
        void AuditBill()
        {
            int rowIdx = this.dgvDtlStkIn.CurrentCell == null ? -1 : this.dgvDtlStkIn.CurrentCell.RowIndex;
            if (rowIdx < 0)
            {
                this.ShowMessage("请指定要审核记录！");
                return;
            }
            Guid? guidKey = this.dgvDtlStkIn["colStkInGuid", rowIdx].Value.ToGuid();
            string billNo = this.dgvDtlStkIn["colBillNo", rowIdx].Value.ToStringHasNull();
            ZNLCRM.UI.Logic.WF.frmAuditRecordList frmRecord = new ZNLCRM.UI.Logic.WF.frmAuditRecordList("STK_In", guidKey, billNo);
            frmRecord.ShowDialog();

        }
        void CancelBill()
        {
            int rowIdx = this.dgvDtlStkIn.CurrentCell == null ? -1 : this.dgvDtlStkIn.CurrentCell.RowIndex;
            if (rowIdx < 0)
            {
                this.ShowMessage("请指定要撤单的记录！");
                return;
            }
            Guid? guidKey = this.dgvDtlStkIn["colStkInGuid", rowIdx].Value.ToGuid();
            WF_AuditRecordLogic logicWF = new WF_AuditRecordLogic(this);
            WCFAddUpdateResult rstAudit = logicWF.CancelBill(new Entity.UserModel.WF.WF_AuditRecordParam()
            {
                SourceTableEngName = "STK_In",
                SourceBillGuid = guidKey
            });
            if (rstAudit.Key > 0)
            {
                SearchStkIn(this.pgStkIn.PageIndex);
                this.ShowMessage("撤单成功!");
            }
        }
        #endregion


        /// <summary>
        /// 行焦点事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvDtlStkIn_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

        }
        /// <summary>
        /// 单元格双击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvDtlStkIn_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        /// <summary>
        /// 入库明细搜索事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDtlSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
