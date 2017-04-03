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
using ZNLCRM.Entity.UserModel.SPM;
using ZNLCRM.Entity.UserModel.Sys;
using ZNLCRM.UI.Logic.Sys;

namespace ZNLCRM.UI.SPM
{
    public partial class frmSelectSalesReturnLine : frmSelectForm
    {
        string _idColName = "colSRLineGuid";
        string _chkColName = "colSelect";
        ORD_SalesReturnLineLogic lineLogic = null;
        SYS_DictItemLineLogic dictLineLogic = null;
        public Guid?[] NoSRLineGuids = null;
        public Guid? SRLineGuid = null;
        public Guid? SRGuid = null;
        public string Model = string.Empty;
        public frmSelectSalesReturnLine(bool isMutiSelect)
        {
            InitializeComponent();
            InitBaseSelectForm(isMutiSelect, this.dgvSalesReturn, this.chkAll, _idColName, _chkColName);
            lineLogic = new ORD_SalesReturnLineLogic(this);
            dictLineLogic = new SYS_DictItemLineLogic(this);
        }

        private void frmSelectSalesReturnLine_Load(object sender, EventArgs e)
        {
            InitData();
            BindDataGridView();
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            SubmitForm();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.CancelForm();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            BindDataGridView();
        }
        #region 初始化绑定控件
        public void BindComboBox()
        {
         
            List<SYS_DictItemLineResult> itemLineList = dictLineLogic.GetListByCode(new SYS_DictItemLineParam
            {
                ItemCodes = new string[] {
               "Currency","TaxRate"}
            });
            dictLineLogic.BindComboBox(colCurrency, "Currency", itemLineList);
            dictLineLogic.BindComboBox(colTaxRate, "TaxRate", itemLineList);
        }
        #endregion
        private void InitData()
        {
            txtModel.Text = Model;
        }
        private void BindDataGridView()
        {
            ORD_SalesReturnLineParam param = new ORD_SalesReturnLineParam();

            param.SRGuid = SRGuid;
            param.Model = txtModel.Text.Trim();
            param.NoSRLineGuids = NoSRLineGuids;
            param.SRLineGuid = SRLineGuid;
            List<ORD_SalesReturnLineResult> lstRst = lineLogic.GetList(param);
            dgvSalesReturn.DataSource = lstRst;
            this.SetDataSource<ORD_SalesReturnLineResult>(lstRst);
            SetGridCheck(this.dgvSalesReturn, _idColName, _chkColName);
        }
    }
}
