using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZNLCRM.Entity.UserModel.CRM;
using ZNLCRM.UI.Logic.Common;
using ZNLCRM.UI.Logic.Sys;
using ZNLFrame.Entity;
using ZNLCRM.Entity.UserModel.Sys;
using ZNLCRM.UI.Logic.PPM;
using ZNLCRM.Utility.CommonEnum;
using ZNLCRM.Entity.UserModel.PPM;
using ZNLCRM.Entity.UserModel.Common;
using ZNLCRM.Utility;
using ZNLCRM.Entity.UserModel.HR;
using DevComponents.DotNetBar;
using ZNLCRM.UI.Logic.STK;
using ZNLCRM.Entity.UserModel.STK;
using ZNLCRM.UI.STK;
using ZNLCRM.UI.Logic.WF;

namespace ZNLCRM.UI.PPM
{
    public partial class frmPurchaseManage : frmBaseForm
    {
        ZNLCRM.UI.Logic.AppHandler.SearchAssembleHandler appHandler;
        ORD_PurchaseOrderLogic orderLogic = null;
        ORD_PurchaseOrderLineLogic orderLineLogic = null;//订单明细
        SYS_DictItemLineLogic dictLineLogic = null;
        STK_InLogic stkInLogic = null;
        int rowIndex = 0;
        Guid poguid;
        Guid poLineGuid;//采购明细GUID
        //string poBillNo = null;//明细所在订单号
        public frmPurchaseManage()
        {
            InitializeComponent();
            appHandler = new Logic.AppHandler.SearchAssembleHandler(this);
            dictLineLogic = new SYS_DictItemLineLogic(this);
            orderLogic = new ORD_PurchaseOrderLogic(this);
            orderLineLogic = new ORD_PurchaseOrderLineLogic(this);//初始化订单明细
            //poBillNo = "";//初始化明细所在订单号
        }

        #region 窗体加载
        private void frmPurchaseManage_Load(object sender, EventArgs e)
        {
            appHandler.CreateControlInPanel(this.GetType().FullName, this.btnDtlSearch, this.panDtlWhere);
            appHandler.CreateControlInPanel(this.GetType().FullName, this.btnSearch, this.panMastWhere);
            this.panDtlWhere.Height += 35;
            this.panMastWhere.Height += 35;
            SearchPO(1);
            SearchDtl(1);
        }
        #endregion

        #region 绑定表格
        /// <summary>
        /// 绑定表格,分页控件
        /// </summary>
        /// <param name="dgv">表格控件</param>
        /// <param name="pg">分页控件</param>
        /// <param name="param">查询参数对象</param>
        /// <param name="isTable">是否返回DataTable</param>
        private void BindDataGridView( Controls.UcDataGridView dgv, Controls.UcPager pg, ORD_PurchaseOrderParam param,bool isTable)
        {
            PageList<ORD_PurchaseOrderResult> pageList = null;
            if (isTable)
            {
               pageList = this.AsyncExecute<PageList<ORD_PurchaseOrderResult>,
               ORD_PurchaseOrderParam>(param, orderLogic.GetDtlPageList, a =>
               {
                   dgv.DataSource = a.ResultJoinList;
                   pg.PageSize = param.PageSize.ToInt32();
                   pg.RecordCount = a.TotalCount;
               });
            }
            else
            {
                pageList = this.AsyncExecute<PageList<ORD_PurchaseOrderResult>,
                ORD_PurchaseOrderParam>(param, orderLogic.GetPageList, a =>
               {
                   dgv.DataSource = a.ResultList;
                   pg.PageSize = param.PageSize.ToInt32();
                   pg.RecordCount = a.TotalCount;
               });
            }
        }
        #endregion

        #region 入库
        void biStkIn_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvPurchaseOrder.CurrentRow;
            if (row != null)
            {
                Guid? poguid = row.Cells["colPOGuid"].Value.ToGuid();
                ORD_PurchaseOrderResult orderResult = orderLogic.GetInfo(new ORD_PurchaseOrderParam() { POGuid = poguid });
                if (orderResult != null && orderResult.Status == "Complete" && orderResult.StkInOccStatus != "全部占有")
                {
                    List<ORD_PurchaseOrderLineResult> lineList = orderResult.OrderLineList;
                    if (lineList != null && lineList.Count > 0)
                    {
                        //有效的可作为入库明细的采购记录
                        List<ORD_PurchaseOrderLineResult> effLineList = lineList.Where(a => a.IsCancel == false && a.Qty > a.StkInOccQty).ToList();
                        if (effLineList != null && effLineList.Count > 0)
                        {
                            STK_InResult inResult = stkInLogic.GetInfo(new STK_InParam() { SourceBillGuid = poguid, Status = "New" });
                            frmStkIn frmStkIn = new frmStkIn();
                            frmStkIn.BringToFront();
                            frmStkIn.StartPosition = FormStartPosition.CenterParent;
                            if (inResult != null)
                            {
                                //存在关联的未提交的入库单
                                frmStkIn.StkInGuid = inResult.StkInGuid;
                            }
                            frmStkIn.ShowDialog();
                        }
                        else
                        {
                            this.ShowMessage("当前采购单没有再需要入库的采购明细！若存在有关联的已提交未审核的入库单，请及时联系相关人员审核！");
                        }
                    }
                }
                else
                {
                    this.ShowMessage("未审核或者全部占有的采购单据不允许入库！");
                }


            }
            else
            {
                this.ShowMessage("未选中数据行！");
            }

        } 
        #endregion

        #region 采购主单查询
        /// <summary>
        /// 采购主单查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchPO(1);
        }

        /// <summary>
        /// 采集主单查询
        /// </summary>
        public void SearchPO(int pgIndex)
        {
            ORD_PurchaseOrderParam param = new ORD_PurchaseOrderParam();
            param = this.ConvertControlToEntity<ORD_PurchaseOrderParam>(this.panMastWhere.Controls, param, null);
            param.PageIndex = pgIndex;
            param.PageSize = 5;
            BindDataGridView(dgvPurchaseOrder, pgPurchaseOrder, param, false);
        }
        /// <summary>
        /// 明细查询
        /// </summary>
        /// <param name="pgIndex"></param>
        public void SearchDtl(int pgIndex)
        {
            ORD_PurchaseOrderParam param = new ORD_PurchaseOrderParam();
            param = this.ConvertControlToEntity<ORD_PurchaseOrderParam>(this.panDtlWhere.Controls, param, null);
            param.PageIndex = pgIndex;
            param.PageSize = 10;
            BindDataGridView(dgvDtl, pagDtl, param, true);
        }

        #endregion

        #region 采购明细查询
        /// <summary>
        /// 采购明细查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDtlSearch_Click(object sender, EventArgs e)
        {
            SearchDtl(1);
        }
        #endregion

        #region 添加
        private void tsbAdd_Click(object sender, EventArgs e)
        {
            frmPurchaseOrder frmPurchaseOrder = new frmPurchaseOrder();
            frmPurchaseOrder.BringToFront();
            frmPurchaseOrder.StartPosition = FormStartPosition.CenterScreen;
            frmPurchaseOrder.ShowDialog();
            frmPurchaseOrder.RefreshParentForm += delegate
            {
                btnSearch_Click(sender,e);
            };
        }
        #endregion

        #region 修改
        private void tsbEdit_Click(object sender, EventArgs e)
        {
            if (poguid !=null)
            {
                frmPurchaseOrder frmPurchaseOrder = new frmPurchaseOrder();
                frmPurchaseOrder.poguid = poguid;
                frmPurchaseOrder.BringToFront();
                frmPurchaseOrder.StartPosition = FormStartPosition.CenterScreen;
                frmPurchaseOrder.ShowDialog();
                frmPurchaseOrder.RefreshParentForm += delegate
                {
                    SearchPO(1);
                };
                
            }
            else
            {
                this.ShowMessage("请选择要编辑的采购单");

            }
        }
        #endregion


        #region 根据POGUID查询明细记录数
        /// <summary>
        /// 根据POGUID查询明细记录数
        /// </summary>
        /// <param name="_poGuid">采购明细POGUID</param>
        private int GetOrderDetailCountsByID(Guid _poGuid)
        {
            ORD_PurchaseOrderLineParam param = new ORD_PurchaseOrderLineParam();
            param.POGuid = _poGuid;
            List<ORD_PurchaseOrderLineResult> orderList = orderLineLogic.GetList(param);
            return orderList.Count;
        } 
        #endregion

        #region 删除订单明细
        /// <summary>
        /// 删除订单明细
        /// </summary>
        private void DeleteOrderDetail()
        {
            ORD_PurchaseOrderLineParam p = new ORD_PurchaseOrderLineParam();
            p.POGuid = poguid;
            p.POLineGuid = poLineGuid;
            ORD_PurchaseOrderLineResult r = orderLineLogic.GetInfo(p);
            if (r != null)
            {
                if (MessageBox.Show("请确认是否要删除该记录", "操作提示",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question) == DialogResult.OK)
                {
                    WCFAddUpdateResult result = this.AsyncExecute<WCFAddUpdateResult, ORD_PurchaseOrderLineParam>(
                        p, orderLineLogic.DelInfo, a =>{ SearchDtl(1);});
                    if (GetOrderDetailCountsByID(poguid) == 0)
                    {
                        DeletePurchaseOrder(false);
                    }
                }
            }
        } 
        #endregion

        #region 删除采购订单
        /// <summary>
        /// 删除采购订单
        /// </summary>
        /// <param name="showMsg"></param>
        private void DeletePurchaseOrder(bool showMsg)
        {
            ORD_PurchaseOrderParam param = new ORD_PurchaseOrderParam();
            param.POGuid = poguid;

            ORD_PurchaseOrderResult rst = orderLogic.GetInfo(param);
            if (rst != null)
            {
                if (showMsg)
                {
                    if (MessageBox.Show("请确认是否要删除采购单：【" + rst.BillNo + "】", "操作提示",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        WCFAddUpdateResult result = this.AsyncExecute<WCFAddUpdateResult, ORD_PurchaseOrderParam>(
                            param, orderLogic.DelInfo, a => { SearchPO(1); });
                    }
                }
                else
                {
                    WCFAddUpdateResult result = this.AsyncExecute<WCFAddUpdateResult, ORD_PurchaseOrderParam>(
                            param, orderLogic.DelInfo, a => { SearchPO(1); });
                }
            }
            else
            {
                this.ShowMessage("请选择需要删除的采购明细！");
            }
        } 
        #endregion

        #region 删除
        private void tsbDel_Click(object sender, EventArgs e)
        {
            
            //删除明细记录
            if (tabPurchase.SelectedTab.Name == "tbiDtl")
            {
                DeleteOrderDetail();
            }
            //删除明细记录
            if (tabPurchase.SelectedTab.Name == "tbiMast")
            {
                DeletePurchaseOrder(true);
            }
        }
        #endregion 

        #region 分页
        /// <summary>
        /// 主单分页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pgPurchaseOrder_PageIndexChanged(object sender, EventArgs e)
        {
            SearchPO(pgPurchaseOrder.PageIndex);
        }
        /// <summary>
        /// 明细分页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pagDtl_PageIndexChanged(object sender, EventArgs e)
        {
            SearchDtl(pagDtl.PageIndex);
        }
        #endregion

        /// <summary>
        /// 明细表行焦点事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvDtl_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                rowIndex = e.RowIndex;
                poguid = dgvDtl["colDtlPOGuid", rowIndex].Value.ToGuid();//采购主单GUID
                poLineGuid = dgvDtl["colDtlPOLineGuid", rowIndex].Value.ToGuid();//明细GUID
                //poBillNo = dgvDtl["colDtlBillNo", rowIndex].Value.ToString(); //明细所在订单号
            }
        }

        private void dgvPurchaseOrder_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                rowIndex = e.RowIndex;
                poguid = dgvPurchaseOrder["colPOGuid", rowIndex].Value.ToGuid();
            }
        }

        private void dgvPurchaseOrder_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                tsbEdit_Click(sender, e);
            }
        }

        private void dgvDtl_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                tsbEdit_Click(sender, e);
            }
        }

        private void tlbAuditBill_Click(object sender, EventArgs e)
        {
            auditBill();
        }

        void auditBill()
        {
            int rowIdx = this.dgvPurchaseOrder.CurrentCell == null ? -1 : this.dgvPurchaseOrder.CurrentCell.RowIndex;
            if (rowIdx < 0)
            {
                this.ShowMessage("请指定要审核记录！");
                return;
            }
            Guid? guidKey = this.dgvPurchaseOrder["colPOGuid", rowIdx].Value.ToGuid();
            string billNo = this.dgvPurchaseOrder["colBillNo", rowIdx].Value.ToStringHasNull();
            ZNLCRM.UI.Logic.WF.frmAuditRecordList frmRecord = new ZNLCRM.UI.Logic.WF.frmAuditRecordList("ORD_PurchaseOrder", guidKey, billNo);
            frmRecord.ShowDialog();
        }
        void cancelBill()
        {
            int rowIdx = this.dgvPurchaseOrder.CurrentCell == null ? -1 : this.dgvPurchaseOrder.CurrentCell.RowIndex;
            if (rowIdx < 0)
            {
                this.ShowMessage("请指定要撤单的记录！");
                return;
            }
            Guid? guidKey = this.dgvPurchaseOrder["colPOGuid", rowIdx].Value.ToGuid();
            WF_AuditRecordLogic logicWF = new WF_AuditRecordLogic(this);
            WCFAddUpdateResult rstAudit = logicWF.CancelBill(new Entity.UserModel.WF.WF_AuditRecordParam()
            {
                SourceTableEngName = "ORD_PurchaseOrder",
                SourceBillGuid = guidKey
            });
            if (rstAudit.Key > 0)
            {
                SearchPO(1);
                this.ShowMessage("撤单成功!");
            }
        }

        private void tlbCancelBill_Click(object sender, EventArgs e)
        {
            cancelBill();
        }

        private void dgvPurchaseOrder_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            BindComplete(dgvPurchaseOrder, "colOperIn", "colStkInStatus", "colStatus",true);
        }


        #region 入库按钮
        List<string> poList = new List<string>();
        /// <summary>
        /// 数据绑定完成公共事件方法
        /// </summary>
        /// <param name="dgv">表格对象</param>
        /// <param name="colName">操作列名</param>
        /// <param name="colStkin">入库状态列名</param>
        /// <param name="colStatus">状态列名</param>
        /// <param name="isPO">是否采购主单表</param>
        public void BindComplete(Controls.UcDataGridView dgv, string colName, string colStkin, string colStatus, bool isPO)
        {
            if (isPO)
            {
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    if (row.Cells[colStkin].Value.ToStringHasNull() != "全部入库" && row.Cells[colStatus].Value.ToStringHasNull() == "Complete")
                    {
                        row.Cells[colName].Value = "入库";
                        poList.Add(row.Cells["colPOGuid"].Value.ToString());
                    }
                    else
                    {
                        row.Cells[colName].Value = "";
                    }
                }
            }
            else
            {
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    if (row.Cells[colStkin].Value.ToStringHasNull() != "全部入库" && row.Cells[colStatus].Value.ToStringHasNull() == "Complete")
                    {
                        for (int i = 0; i < poList.Count; i++)
                        {
                            if (poList[i] == row.Cells["colDtlPOGuid"].Value.ToString())
                            {
                                row.Cells[colName].Value = "入库";
                            }
                        }
                    }
                    else
                    {
                        row.Cells[colName].Value = "";
                    }
                }
            }

        }
        
        #endregion
        #region 入库功能
        /// <summary>
        /// 入库
        /// </summary>
        /// <param name="dgv"></param>
        /// <param name="e"></param>
        /// <param name="colOperIn"></param>
        /// <param name="str_POGuid"></param>
        /// <param name="str_BillNo"></param>
        public void CellContentClick(Controls.UcDataGridView dgv, DataGridViewCellEventArgs e,string colOperIn,string str_POGuid,string str_BillNo)
        {
            
            if (e.ColumnIndex == dgv.Columns[colOperIn].Index)
            {
                frmStkIn frm = new frmStkIn("PO_IN", dgv[str_POGuid, e.RowIndex].Value.ToGuid());
                frm.ShowDialog();
            }
           
        }
        #endregion

        private void dgvPurchaseOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CellContentClick(this.dgvPurchaseOrder,e, "colOperIn", "colPOGuid", "colBillNo");
        }

        private void dgvDtl_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CellContentClick(this.dgvDtl, e, "colDtlOper", "colDtlPOGuid", "colDtlBillNo");
        }

        private void dgvDtl_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            BindComplete(dgvDtl, "colDtlOper", "colDtlStkInStatus", "colDtlStatus", false);
        }

        

    }
}
