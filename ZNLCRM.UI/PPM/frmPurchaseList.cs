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
using DevComponents.DotNetBar.SuperGrid.Style;
using ZNLCRM.Entity.UserModel.SPM;
using ZNLFrame.Entity;

namespace ZNLCRM.UI.PPM
{
    public partial class frmPurchaseList : frmBaseForm
    {
        ORD_PurchaseNoticeLogic noticeLogic = null;
        public frmPurchaseList()
        {
            InitializeComponent();
            noticeLogic = new ORD_PurchaseNoticeLogic(this);
            InitializeGrid();
        }

        
        private void frmPurchaseList_Load(object sender, EventArgs e)
        {
            BindSuperGrid(1);
        }
        void InitializeGrid()
        {
            usgPurchaseList.DefaultVisualStyles.CellStyles.Default.Alignment = Alignment.MiddleCenter;
        }
        void BindSuperGrid(int pageIndex)
        {
            ORD_PurchaseNoticeParam param = new ORD_PurchaseNoticeParam();
            param.PageIndex = pageIndex;
            PageList<ORD_PurchaseNoticeResult> noticeList = this.AsyncExecute<PageList<ORD_PurchaseNoticeResult>, ORD_PurchaseNoticeParam>(param, noticeLogic.GetPageList, a =>
            {
                usgPurchaseList.PrimaryGrid.DataSource = a.ResultList;
                pgList.RecordCount = a.TotalCount;

            });
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            BindSuperGrid(1);
        }

        private void pgList_PageIndexChanged(object sender, EventArgs e)
        {
            BindSuperGrid(pgList.PageIndex);
        }
    }
}
