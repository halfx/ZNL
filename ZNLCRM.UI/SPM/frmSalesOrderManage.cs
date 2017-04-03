using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZNLCRM.Entity.DBModel;
using ZNLCRM.UI.Logic.SPM;
using ZNLCRM.UI.Logic.Common;
using ZNLCRM.Entity.UserModel.SPM;
using ZNLFrame.Entity;
using ZNLCRM.Entity.UserModel.Common;
using ZNLCRM.Utility;
using ZNLCRM.Utility.CommonEnum;
using ZNLCRM.UI.Logic.Sys;
using ZNLCRM.Entity.UserModel.Sys;
using DevComponents.DotNetBar;
using ZNLCRM.Entity.UserModel.STK;
using ZNLCRM.UI.Logic.STK;
using ZNLCRM.UI.STK;
using ZNLCRM.UI.Logic.WF;

namespace ZNLCRM.UI.SPM
{
    public partial class frmSalesOrderManage : frmBaseForm
    {
        ORD_SalesOrderLogic orderLogic = null;
        SYS_DictItemLineLogic dictLineLogic = null;
        ORD_SalesReturnLogic returnLogic = null;
        STK_OutLogic outLogic = null;
        int rowIndex = 0;
        int soid = 0;
        Guid soguid ;
        public frmSalesOrderManage()
        {
            InitializeComponent();
            orderLogic = new ORD_SalesOrderLogic(this);
            dictLineLogic = new SYS_DictItemLineLogic(this);
            returnLogic = new ORD_SalesReturnLogic(this);
            outLogic = new STK_OutLogic(this);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            BindDataGridView(1);
        }

        private void frmSalesOrderManage_Load(object sender, EventArgs e)
        {
         
            BindComboBox();
            BindDataGridView(1);
        }

       

        #region 绑定下拉框
        private void BindComboBox()
        {
            List<SYS_DictItemLineResult> itemLineList = dictLineLogic.GetListByCode(new SYS_DictItemLineParam
            {
                ItemCodes = new string[] {
                "SalesOrderBillType","Currency","TaxRate"}
            });
            dictLineLogic.BindComboBox(cboBillType, "SalesOrderBillType", itemLineList);
            dictLineLogic.BindComboBox(colBillType, "SalesOrderBillType", itemLineList);
            dictLineLogic.BindComboBox(colCurrency, "Currency", itemLineList);
            dictLineLogic.BindComboBox(colTaxRate, "TaxRate", itemLineList);
        
        }
        #endregion
        #region  绑定表格
        private void BindDataGridView(int pageIndex)
        {
            ORD_SalesOrderParam param = new ORD_SalesOrderParam();
            param.BillNo = txtBillNo.Text;
            param.PageIndex = pageIndex;
            param.PageSize = 100;
            PageList<ORD_SalesOrderResult> pageList = this.AsyncExecute<PageList<ORD_SalesOrderResult>, ORD_SalesOrderParam>(param, orderLogic.GetPageList, a =>
            {

                dgvSalesOrder.DataSource = a.ResultList;
                pgSalesOrder.RecordCount = a.TotalCount;

            });
        }
        #endregion

        #region 添加
        private void tsbAdd_Click(object sender, EventArgs e)
        {
            frmSalesOrder frmSalesOrder = new SPM.frmSalesOrder();
            frmSalesOrder.BringToFront();
            frmSalesOrder.StartPosition = FormStartPosition.CenterScreen;
            frmSalesOrder.ShowDialog();
           
            frmSalesOrder.RefreshParentForm += delegate { BindDataGridView(pgSalesOrder.PageIndex); };
        }
        #endregion
        #region 编辑
        private void tsbEdit_Click(object sender, EventArgs e)
        {
            if (soid > 0)
            {
                frmSalesOrder frmSalesOrder = new SPM.frmSalesOrder();
                frmSalesOrder.soid = soid    ;
                frmSalesOrder.soguid = soguid;
                frmSalesOrder.BringToFront();
                frmSalesOrder.StartPosition = FormStartPosition.CenterScreen;
                frmSalesOrder.ShowDialog();
                
            }
            else
            {
                this.ShowMessage("请选择要编辑的销售单");

            }
        }
        #endregion
        #region 删除
        private void tsbDel_Click(object sender, EventArgs e)
        {
            ORD_SalesOrderParam param = new ORD_SalesOrderParam();
            param.SOID = soid;

            ORD_SalesOrderResult rst = orderLogic.GetInfo(param);
            if (rst != null)
            {
                if (MessageBox.Show("请确认是否要删除销售单：【" + rst.BillNo + "】", "操作提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    WCFAddUpdateResult result = this.AsyncExecute<WCFAddUpdateResult, ORD_SalesOrderParam>(param, orderLogic.DelInfo, a => { BindDataGridView(pgSalesOrder.PageIndex); });
                }
            }
            else
            {
                this.ShowMessage("请选择需要删除的销售明细！");
            }
        }
        #endregion
        #region 审核单据
        private void tlbAuditBill_Click(object sender, EventArgs e)
        {
           if(dgvSalesOrder.CurrentCell!=null)
           {
               int rowIndex = dgvSalesOrder.CurrentCell.RowIndex;
               if (rowIndex >= 0)
               {
                   Guid? _SOGuid = dgvSalesOrder["colSOGuid", rowIndex].Value.ToGuid();
                   string billNo = dgvSalesOrder["colBillNo", rowIndex].Value.ToStringHasNull();
                   ZNLCRM.UI.Logic.WF.frmAuditRecordList frmRecord = new ZNLCRM.UI.Logic.WF.frmAuditRecordList("ORD_SalesOrder", _SOGuid, billNo);
                   frmRecord.BringToFront();
                   frmRecord.ShowDialog();
               }
               else
               {
                   this.ShowMessage("请指定要审核记录！");
                   return;
               }
           
           }
        }
        #endregion
        #region 撤单
        private void tlbCancelBill_Click(object sender, EventArgs e)
        {
            if (dgvSalesOrder.CurrentRow != null)
            {
                int rowIndex = dgvSalesOrder.CurrentRow.Index;
                if (rowIndex >= 0)
                {

                    Guid? _SOGuid = dgvSalesOrder["colSOGuid", rowIndex].Value.ToGuid();
                    WF_AuditRecordLogic logicWF = new WF_AuditRecordLogic(this);
                    WCFAddUpdateResult rstAudit = logicWF.CancelBill(new Entity.UserModel.WF.WF_AuditRecordParam()
                    {
                        SourceTableEngName = "ORD_SalesOrder",
                        SourceBillGuid = _SOGuid
                    });
                    if (rstAudit.Key > 0)
                    {
                        BindDataGridView(1);
                        this.ShowMessage("撤单成功!");
                    }
                }
                else 
                {
                    this.ShowMessage("请指定要撤单的记录！");
                    return;
                }
               
            }
        }
        #endregion 
        private void dgvSalesOrder_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                rowIndex = e.RowIndex;
                soid = dgvSalesOrder["colSOID", rowIndex].Value.ToInt32();
                soguid = dgvSalesOrder["colSOGuid", rowIndex].Value.ToGuid();
            }
        }

        private void dgvSalesOrder_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                tsbEdit_Click(sender, e);
            }
        }

        private void dgvSalesOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                Guid? _SOGuid=dgvSalesOrder["colSOGuid",e.RowIndex].Value.ToGuid();
                if (dgvSalesOrder.Columns[e.ColumnIndex].Name == "colOperOut")
                {
                    ORD_SalesOrderResult orderResult = orderLogic.GetInfo(new ORD_SalesOrderParam() { SOGuid = soguid });
                    if (orderResult != null && orderResult.Status == "Complete" && orderResult.StkOutStatus != "全部出库" && orderResult.StkOutOccStatus != "全部占有")//没有全部出库的销售单才能创建出库单
                    {
                        List<ORD_SalesOrderLineResult> lineList = orderResult.OrderLineList;
                        if (lineList != null && lineList.Count > 0)
                        {
                            //判断是否存在有未取消的，出库数量小于下单数量
                            List<ORD_SalesOrderLineResult> effLineList = lineList.Where(a => a.IsCancel == false && a.StkOutOccQty < a.Qty).ToList();
                            if (effLineList != null && effLineList.Count > 0)
                            {
                                //如果存在未提交的关联的出库单，则直接调出出库单
                                STK_OutResult outResult = outLogic.GetInfo(new STK_OutParam() { SourceBillGuid = soguid, Status = "New" });
                                frmStkOut frmStkOut = new STK.frmStkOut("SO_OUT", _SOGuid);
                                frmStkOut.BringToFront();
                                frmStkOut.StartPosition = FormStartPosition.CenterParent;
                                if (frmStkOut != null)
                                {
                                    //存在关联的未提交的出库单
                                    frmStkOut.StkOutGuid = outResult.StkOutGuid;
                                }
                                frmStkOut.ShowDialog();
                            }
                            else
                            {
                                this.ShowMessage("当前销售单没有需出库的销售明细！若存在有关联的已提交未审核的出库单，请及时联系相关人员审核！");
                            }
                        }
                    }
                    else
                    {
                        this.ShowMessage("未审核或者全部出库占有的销售单据不允许再继续出库！");
                    }
                }
                if (dgvSalesOrder.Columns[e.ColumnIndex].Name == "colOperReturn")
                {
                    ORD_SalesOrderResult orderResult = orderLogic.GetInfo(new ORD_SalesOrderParam() { SOGuid = _SOGuid });
                    if (orderResult != null && orderResult.Status == "Complete" && orderResult.StkOutOccStatus != "待出库" && orderResult.ReturnOccStatus != "全部占有")//没有全部退货的销售单才能创建退货单
                    {
                        List<ORD_SalesOrderLineResult> lineList = orderResult.OrderLineList;
                        if (lineList != null && lineList.Count > 0)
                        {
                            //判断是否存在有未取消的，出库数量大于0，且出库数量大于退货占有数量的销售明细

                            List<ORD_SalesOrderLineResult> effLineList = lineList.Where(a => a.IsCancel == false && a.StkOutQty > 0 && a.StkOutQty > a.ReturnOccQty.ToInt32()).ToList();
                            if (effLineList != null && effLineList.Count > 0)
                            {
                                //如果存在未提交的关联的退货单，则直接调出退货单
                                List<ORD_SalesReturnResult> returnResultList = returnLogic.GetList(new ORD_SalesReturnParam() { SOGuid = _SOGuid, Status = "New" });
                                frmSalesReturn frmSalesReturn = new frmSalesReturn(_SOGuid);
                                frmSalesReturn.BringToFront();
                                frmSalesReturn.StartPosition = FormStartPosition.CenterParent;
                                if (returnResultList != null && returnResultList.Count > 0)
                                {
                                    //存在关联的未提交的退货单
                                    frmSalesReturn.SRGuid = returnResultList[0].SRGuid;
                                }
                                frmSalesReturn.ShowDialog();
                            }
                            else
                            {
                                this.ShowMessage("当前销售单没有需退货的销售明细！若存在有关联的已提交未审核的退货单，请及时联系相关人员审核！");
                            }
                        }
                    }
                    else
                    {
                        this.ShowMessage("未审核或者未出库或者全部退货占有的销售单据不允许退货！");
                    }
                }

            
            }
        }

        private void dgvSalesOrder_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dgvSalesOrder.Rows)
            {
                string stkOutOccStatus = row.Cells["colStkOutOccStatus"].Value.ToStringHasNull();
                string returnOccStatus = row.Cells["colReturnOccStatus"].Value.ToStringHasNull();
                string status = row.Cells["colStatus"].Value.ToStringHasNull();
                if (status != "Complete" && stkOutOccStatus != "全部占有")
                    row.Cells["colOperOut"].Value = "";
                if (status != "Complete" && returnOccStatus != "全部占有")
                    row.Cells["colOperReturn"].Value = "";
                
            
            }
        }

        

    }
}
