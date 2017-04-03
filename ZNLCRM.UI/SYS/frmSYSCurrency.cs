using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZNLCRM.UI.Logic.Common;
using ZNLCRM.Entity.UserModel.Sys;
using ZNLCRM.UI.Logic.Sys;
using ZNLCRM.Entity.UserModel.Common;
using ZNLFrame.Entity;
using ZNLCRM.Entity.DBModel;
using ZNLCRM.Utility.CommonEnum;
using ZNLCRM.Utility;

namespace ZNLCRM.UI.SYS
{
    public partial class frmSYSCurrency : frmBaseForm
    {
        
        int rateTaxID;
        SYS_CurrencyLogic currencyLogic = null;
        SYS_DictItemLineLogic dictLineLogic = null;
        public frmSYSCurrency()
        {
            InitializeComponent();
            currencyLogic = new SYS_CurrencyLogic(this);
            dictLineLogic = new SYS_DictItemLineLogic(this);
        }
        
        #region  绑定下拉框
        private void BindComboBox()
        {

            List<SYS_DictItemLineResult> itemLineList = dictLineLogic.GetListByCode(new SYS_DictItemLineParam
            {
                ItemCodes = new string[] {"Currency"}
            });
            dictLineLogic.BindComboBox(cboCurrency, "Currency" , itemLineList);
            dictLineLogic.BindComboBox(cboCurrencyCode, "Currency" , itemLineList);
            dictLineLogic.BindComboBox(colCurrencyCode, "Currency", itemLineList);
        }
        #endregion
        #region 绑定DataGridView
        private void BindDataGridView()
        {
            try
            {
                SYS_CurrencyParam param = new SYS_CurrencyParam();
                if (!string.IsNullOrEmpty(cboCurrency.Text)) param.CurrencyCode = cboCurrency.SelectedValue.ToStringHasNull();
                List<SYS_CurrencyResult> rst = this.AsyncExecute<List<SYS_CurrencyResult>, SYS_CurrencyParam>(param, currencyLogic.GetList, a => {
                    dgvCurrency.DataSource = a;
                });
            }
            catch (Exception e)
            {
                this.ShowMessage(e.Message);
            }
        
        }
        #endregion
        #region 清除面板里控件的内容
        private void ClearConent()
        {
            txtRateTaxID.Text = string.Empty;
            txtRateDate.Text = string.Empty;
            txtExchangeRate.Text = string.Empty;
            txtRemark.Text = string.Empty;
            cboCurrencyCode.Text = string.Empty;
        }
        #endregion
        #region 窗体加载
        private void frmSYSCurrency_Load(object sender, EventArgs e)
        {
            BindComboBox();
            BindDataGridView();
        }
        #endregion

        #region 添加
        private void tsbAdd_Click(object sender, EventArgs e)
        {
            this.ShowEditWindow("添加币种信息", grpCurrency);
            ClearConent();
        }
        #endregion

        #region 删除
        private void tsbDel_Click(object sender, EventArgs e)
        {
            SYS_CurrencyParam param = new SYS_CurrencyParam();
            param.RateTaxID = rateTaxID;
            SYS_CurrencyResult rst = currencyLogic.GetInfo(param);
            if (rst != null)
            {
                if (MessageBox.Show("请确认是否删除记录：【" + rst.CurrencyCode +"-"+rst.ExchangeRate+"-"+rst.RateDate+ "】", "操作提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    WCFAddUpdateResult result = this.AsyncExecute<WCFAddUpdateResult, SYS_CurrencyParam>(param, currencyLogic.DelInfo, (a) =>
                    {
                        if (a.Key > 0)
                        {

                            BindDataGridView();
                        }
                    });
                }
            }
            else
            {
                this.ShowMessage("请选择需要删除的数据字典！");
            }
        }
        #endregion
        #region 搜索
        private void btnSearch_Click(object sender, EventArgs e)
        {
            BindDataGridView();
        }
        #endregion
        #region 保存
        private void btnSave_Click(object sender, EventArgs e)
        {
            SYS_CurrencyResult info = new SYS_CurrencyResult();
            info = this.ConvertControlToEntity<SYS_CurrencyResult>(this.grpCurrency.Controls, info, null);
            WCFAddUpdateResult result = this.AsyncExecute<WCFAddUpdateResult, SYS_CurrencyResult>(info, currencyLogic.AddOrUpdate, (a) =>
            {
                this.HidEditWindow();
                BindDataGridView();
            });
        }
        #endregion
        #region 取消
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.HidEditWindow();
        }
        #endregion

        #region 单元格双击
        private void dgvCurrency_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
               
                
            }
        }
        #endregion

        #region 行进入事件
        private void dgvCurrency_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                rateTaxID = dgvCurrency["colRateTaxID", e.RowIndex].Value.ToInt32();
            }
        }
        #endregion


    }
}
