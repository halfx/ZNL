using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZNLCRM.UI.Logic.Common;
using ZNLCRM.UI.Logic.SPM;
using ZNLCRM.UI.Logic.Sys;
using DevComponents.DotNetBar;
using ZNLCRM.Entity.UserModel.Sys;
using ZNLCRM.Entity.UserModel.SPM;
using ZNLFrame.Entity;
using ZNLCRM.Entity.UserModel.Common;
using ZNLCRM.Utility;
using ZNLCRM.Entity.UserModel.STK;
using ZNLCRM.UI.Logic.STK;
using ZNLCRM.UI.STK;

namespace ZNLCRM.UI.SPM
{
    public partial class frmSalesReturnManage : frmBaseForm
    {
        ORD_SalesReturnLogic returnLogic = null;
        SYS_DictItemLineLogic dictLineLogic = null;
        STK_InLogic stkInLogic = null;
      
        int rowIndex = 0;
        Guid? srguid=null;
        public frmSalesReturnManage()
        {
            InitializeComponent();
            returnLogic = new ORD_SalesReturnLogic(this);
            dictLineLogic = new SYS_DictItemLineLogic(this);
            stkInLogic = new STK_InLogic(this);
        }
        #region 窗体加载
        private void frmSalesReturnManage_Load(object sender, EventArgs e)
        {
            //ButtonItem biStkIn = new ButtonItem();
            //biStkIn.Text = ">-入库";
            //biStkIn.Click += new EventHandler(biStkIn_Click);
            //colOper.SubItems.Add(biStkIn);
            BindComboBox();
            BindDataGridView(1);
        }
        #endregion

        #region  初始化下拉框
        private void BindComboBox()
        {
            List<SYS_DictItemLineResult> itemLineList = dictLineLogic.GetListByCode(new SYS_DictItemLineParam
            {
                ItemCodes = new string[] { "Currency" }
            });
            dictLineLogic.BindComboBox(colCurrency, "Currency", itemLineList);
        }
        #endregion

        #region 绑定表格
        private void BindDataGridView(int pageIndex)
        {
            ORD_SalesReturnParam param = new ORD_SalesReturnParam();
            param.BillNo = txtBillNo.Text;
            param.SOBillNo = txtSOBillNo.Text;
            param.PageIndex = pageIndex;
            param.PageSize = 100;
            PageList<ORD_SalesReturnResult> pageList = this.AsyncExecute<PageList<ORD_SalesReturnResult>, ORD_SalesReturnParam>(param, returnLogic.GetPageList, a =>
            {
                dgvSalesReturn.DataSource = a.ResultList;
                pgSalesReturn.RecordCount = a.TotalCount;

            });

        }
        #endregion

        void biStkIn_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvSalesReturn.CurrentRow;
            if (row != null)
            {
                Guid? srguid = row.Cells["colSRGuid"].Value.ToGuid();
                string billno = row.Cells["colBillNo"].Value.ToStringHasNull();
                ORD_SalesReturnResult orderResult = returnLogic.GetInfo(new ORD_SalesReturnParam() { SRGuid = srguid });
                if (orderResult != null && orderResult.Status == "Complete" && orderResult.StkInOccStatus != "全部占有")
                {
                    List<ORD_SalesReturnLineResult> lineList = orderResult.ReturnLineList;
                    if (lineList != null && lineList.Count > 0)
                    {
                        //有效的可作为入库明细的采购记录
                        List<ORD_SalesReturnLineResult> effLineList = lineList.Where(a => a.Qty > a.StkInOccQty.ToInt32()).ToList();
                        if (effLineList != null && effLineList.Count > 0)
                        {
                            List<STK_InResult> inResultList = stkInLogic.GetList(new STK_InParam() { SourceBillGuid = srguid, Status = "New" });
                            frmStkIn frmStkIn = new frmStkIn();
                            frmStkIn.BringToFront();
                            frmStkIn.StartPosition = FormStartPosition.CenterParent;
                            if (inResultList != null && inResultList.Count > 0)
                            {
                                //存在关联的未提交的入库单
                                frmStkIn.StkInGuid = inResultList[0].StkInGuid;
                            }
                            else
                            {
                                frmStkIn.SourceBillGuid = srguid;
                                frmStkIn.SourceBillNo = billno;
                                frmStkIn.BillType = "SOR_IN";
                            }
                            frmStkIn.ShowDialog();
                        }
                        else
                        {
                            this.ShowMessage("当前销售退货单没有再需要入库的销售退货明细！若存在有关联的已提交未审核的入库单，请及时联系相关人员审核！");
                        }
                    }
                }
                else
                {
                    this.ShowMessage("未审核或者全部占有的销售退货单据不允许入库！");
                }


            }
            else
            {
                this.ShowMessage("未选中数据行！");
            }

        }

        #region 添加销售退货单
        private void tsbAdd_Click(object sender, EventArgs e)
        {
            frmSalesReturn frmSalesReturn = new frmSalesReturn();
            frmSalesReturn.BringToFront();
            frmSalesReturn.StartPosition = FormStartPosition.CenterScreen;
            frmSalesReturn.ShowDialog();
            frmSalesReturn.RefreshParentForm += delegate { BindDataGridView(pgSalesReturn.PageIndex); };
        }
        #endregion 
        #region 编辑销售退货单
        private void tsbEdit_Click(object sender, EventArgs e)
        {
            if (srguid != null)
            {
                frmSalesReturn frmSalesReturn = new frmSalesReturn();
                frmSalesReturn.SRGuid = srguid;
                frmSalesReturn.BringToFront();
                frmSalesReturn.StartPosition = FormStartPosition.CenterScreen;
                frmSalesReturn.ShowDialog();
                frmSalesReturn.RefreshParentForm += delegate { BindDataGridView(pgSalesReturn.PageIndex); };

            }
            else
            {
                this.ShowMessage("请选择要编辑的销售退货单");

            }
        }
        #endregion 
        #region 删除销售退货单
        private void tsbDel_Click(object sender, EventArgs e)
        {
            ORD_SalesReturnParam param = new ORD_SalesReturnParam();
            param.SRGuid = srguid;

            ORD_SalesReturnResult rst = returnLogic.GetInfo(param);
            if (rst != null)
            {
                if (MessageBox.Show("请确认是否要删除销售退货单：【" + rst.BillNo + "】", "操作提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    WCFAddUpdateResult result = this.AsyncExecute<WCFAddUpdateResult, ORD_SalesReturnParam>(param, returnLogic.DelInfo, a => { BindDataGridView(pgSalesReturn.PageIndex); });
                }
            }
            else
            {
                this.ShowMessage("请选择需要删除的采购明细！");
            }
        }
        #endregion
        #region 搜索销售退货单
        private void btnSearch_Click(object sender, EventArgs e)
        {
            BindDataGridView(1);
        }
        #endregion 

        #region 分页
        private void pgSalesReturn_PageIndexChanged(object sender, EventArgs e)
        {
            BindDataGridView(pgSalesReturn.PageIndex);
        }
        #endregion

        private void dgvSalesReturn_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                rowIndex = e.RowIndex;
                srguid = dgvSalesReturn["colSRGuid", rowIndex].Value.ToGuid();
            }
        }

        private void dgvSalesReturn_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                tsbEdit_Click(sender, e);
            }
        }
        

       
    }
}
