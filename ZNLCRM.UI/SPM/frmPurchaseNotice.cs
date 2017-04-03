using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar.SuperGrid;
using ZNLCRM.UI.Logic.SPM;
using ZNLCRM.UI.Logic.Common;
using ZNLCRM.UI.Logic.Sys;
using ZNLCRM.Entity.UserModel.SPM;
using ZNLCRM.UI.Logic.HR;
using ZNLCRM.Entity.UserModel.HR;
using ZNLCRM.Entity.DBModel;
using ZNLCRM.Utility;
using ZNLCRM.Entity.UserModel.Common;
using DevComponents.DotNetBar;

namespace ZNLCRM.UI.SPM
{
    public partial class frmPurchaseNotice : frmBaseEditForm
    {
        public delegate void dlgRefreshParentForm();
        public event dlgRefreshParentForm RefreshParentForm;
        public Guid? SOGuid =null;
        ORD_SalesOrderLogic orderLogic = null;
        SYS_DictItemLineLogic dictLineLogic = null;
        ORD_SalesOrderLineLogic orderLineLogic = null;
        HR_EmployeeLogic empLogic = null;
        ORD_PurchaseNoticeLogic noticeLogic = null;
        GridPanel noNoticedPanel = null;
        GridPanel noticedPanel = null;
        List<HR_EmployeeResult> empList = null;
       
       
        public frmPurchaseNotice()
        {
            InitializeComponent();
            orderLogic = new ORD_SalesOrderLogic(this);
            orderLineLogic = new ORD_SalesOrderLineLogic(this);
            dictLineLogic = new SYS_DictItemLineLogic(this);
            empLogic = new HR_EmployeeLogic(this);
            noticeLogic = new ORD_PurchaseNoticeLogic(this);
            noNoticedPanel = usgNoNoticed.PrimaryGrid;
            noticedPanel = usgNoticed.PrimaryGrid;
            InitializeGrid();
            BindComboBox();
        }


        #region 窗体加载
        private void frmPurchaseNotice_Load(object sender, EventArgs e)
        {
            BindSuperGrid();
        }
        #endregion

        #region 绑定下拉控件
        private void BindComboBox()
        {
          empList= empLogic.GetEmpList(new HR_EmployeeParam() { });
           if (empList != null)
           {
               empList.Insert(0, new HR_EmployeeResult() { EmpID = 0, EmpName = "" });
               empLogic.BindComboBox(cboEmployee, empList);
               empLogic.BindComboBox(noNoticedPanel.Columns["colBuyer"].EditControl, empList);
               //noNoticedPanel.Columns["colBuyer"].RenderType = typeof(GridComboBoxExEditControl);
               empLogic.BindComboBox(noNoticedPanel.Columns["colBuyer"].RenderControl, empList);
           }
        }
        #endregion

        #region 初始化超级表格
        private void InitializeGrid()
        {
            GridColumn gridColumn = noticedPanel.Columns["colOperator"];
            
            gridColumn .EditorType = typeof(GridLabelXEditControl);
            GridLabelXEditControl lxc =(GridLabelXEditControl)gridColumn.EditControl;
            lxc.MarkupLinkClick+=new MarkupLinkClickEventHandler(lxc_MarkupLinkClick);

        }
        #endregion

        #region 绑定超级表格
        private void BindSuperGrid()
        {
            ORD_SalesOrderLineParam param = new ORD_SalesOrderLineParam();
            param.SOGuid = SOGuid;
            param.Model = txtModel.Text.Trim();
            param.SOLineCode = txtSOLineCode.Text.Trim();
            param.IsCancel = false;
            GridPanel noNoticedPanel = usgNoNoticed.PrimaryGrid;
            List<ORD_SalesOrderLineResult> lineResultList = orderLineLogic.GetList(param);
            List<ORD_PurchaseNoticeResult> noticeResultList = new List<ORD_PurchaseNoticeResult>();
            if (lineResultList != null && lineResultList.Count > 0)
            {
                noNoticedPanel.DataSource = lineResultList;
                Guid?[] SOLineGuids = lineResultList.Select(a => (Guid?)a.SOLineGuid).Distinct().ToArray();
                ORD_PurchaseNoticeParam noticeParam = new ORD_PurchaseNoticeParam();
                noticeParam.SOLineGuids = SOLineGuids;
                noticeResultList = noticeLogic.GetList(noticeParam);
            }
            GridPanel noticedPanel = usgNoticed.PrimaryGrid;
            if (noticeResultList != null && noticeResultList.Count > 0)
            {
                noticedPanel.DataSource = noticeResultList;
            }



        }
        #endregion

        #region 搜索
        private void btnSearch_Click(object sender, EventArgs e)
        {
            BindSuperGrid();
        }
        #endregion

        #region  linkbutton点击
        void lxc_MarkupLinkClick(object sender, MarkupLinkClickEventArgs e)
        {

            SelectedElementCollection collection = this.noticedPanel.GetSelectedCells();
            if (collection.Count > 0)
            {
                GridCell gridCell = collection[0] as GridCell;
                if (gridCell != null)
                {
                    GridRow gridRow = gridCell.Parent as GridRow;
                    if (gridRow != null)
                    {
                        if (MessageBox.Show("请确认是否通知采购员取消采购？", "操作提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {
                            Guid? noticeGuid = gridRow.Cells["colNoticeGuid"].Value.ToGuid();
                            bool flag= noticeLogic.CancelPurchaseNotice(new ORD_PurchaseNoticeParam() { NoticeGuid = noticeGuid });
                            if (flag)
                            {
                                BindSuperGrid();
                                if (RefreshParentForm != null)
                                {
                                    RefreshParentForm();
                                }
                            }
                        }
                    }
                }
            }
           //MessageBox.Show(noticeGuid.ToStringHasNull());
           // //SelectedElementCollection col = this.noticedPanel.GetSelectedRows();
           // //GridRow row= col[0] as GridRow;
        }
        #endregion


        #region 设置采购员
        private void btnSetBuyer_Click(object sender, EventArgs e)
        {
           GridPanel panel=usgNoNoticed.PrimaryGrid;

           foreach (GridRow row in panel.Rows)
           {
               row["colBuyer"].Value = cboEmployee.SelectedValue;
            
           }
        }
        #endregion

        #region 确定并通知
        private void btnNotice_Click(object sender, EventArgs e)
        {
            GridPanel panel = usgNoNoticed.PrimaryGrid;
            List<ORD_PurchaseNoticeResult> noticeList = new List<ORD_PurchaseNoticeResult>();
            ORD_PurchaseNoticeResult noticeResult = null;
            foreach (GridRow row in panel.Rows)
            {
               
                if (row.Cells["colCurrentQty"].Value.ToInt32() > 0)
                {
                    noticeResult = new ORD_PurchaseNoticeResult();
                    noticeResult.SOGuid = SOGuid;
                    noticeResult.SOLineGuid = row.Cells["colSOLineGuid"].Value.ToGuid();
                    noticeResult.NoticeQty=row.Cells["colCurrentQty"].Value.ToInt32();
                    noticeResult.BuyerID = row.Cells["colBuyer"].Value.ToInt32();
                    noticeResult.BuyerName = empList.FirstOrDefault(a => a.EmpID == noticeResult.BuyerID).EmpName;
                    noticeResult.Demands = row.Cells["colDemands"].Value.ToStringHasNull();
                    noticeList.Add(noticeResult);

                }

            }
            if (noticeList != null && noticeList.Count > 0)
            {
                WCFAddUpdateResult result = this.AsyncExecute<WCFAddUpdateResult, List<ORD_PurchaseNoticeResult>>(noticeList, noticeLogic.UpdateOrInsertList, (a) =>
                {
                    if (a.Key>0)
                    {
                        BindSuperGrid();
                        if (RefreshParentForm != null)
                        {
                            RefreshParentForm();
                        }
                    }
                });
            }
        }
        #endregion

        #region 超级控件绑定完成
        private void usgNoticed_DataBindingComplete(object sender, GridDataBindingCompleteEventArgs e)
        {
            foreach (GridRow row in e.GridPanel.Rows)
            {
                int NoticeQty = row.Cells["colNoticeQty"].Value.ToInt32();
                int PurchaseQty = row.Cells["colPurchaseQty"].Value.ToInt32();
                if (PurchaseQty == 0)
                {
                    row.Cells["colOperator"].Value = "<a href='#'>取消采购</a>";
                }
            
            }
        }

      

        private void usgNoNoticed_DataBindingComplete(object sender, GridDataBindingCompleteEventArgs e)
        {
            foreach (GridRow row in e.GridPanel.Rows)
            {

                int qty=row.Cells["colQty"].Value.ToInt32();
                int notifyQty=row.Cells["colNotifyQty"].Value.ToInt32();
                int spotQty=row.Cells["colSpotQty"].Value.ToInt32();
                

                if (qty - notifyQty - spotQty>0)
                {
                    int needNotifyQty = qty - notifyQty - spotQty;
                    row.Cells["colNeedNotifyQty"].Value = needNotifyQty;
                    row.Cells["colCurrentQty"].Value = needNotifyQty;
                }
                else
                {
                    row.Cells["colNeedNotifyQty"].Value = 0;
                }
            }
        }

        #endregion








    }
}
