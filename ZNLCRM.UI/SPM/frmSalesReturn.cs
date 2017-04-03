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
using ZNLCRM.UI.Logic.Sys;
using ZNLCRM.UI.Logic.CRM;
using ZNLCRM.UI.Logic.SPM;
using ZNLCRM.UI.Logic.STK;
using ZNLCRM.Entity.UserModel.SPM;
using ZNLCRM.Utility;
using ZNLCRM.Entity.UserModel.HR;
using ZNLCRM.Entity.UserModel.Sys;
using ZNLCRM.Client.Entry;
using ZNLCRM.Entity.UserModel.Common;
using ZNLCRM.Entity.UserModel.CRM;
using ZNLCRM.Entity.UserModel.STK;
using ZNLCRM.UI.HR;
using ZNLCRM.UI.CRM;
using ZNLCRM.UI.PPM;
using ZNLCRM.UI.STK;

namespace ZNLCRM.UI.SPM
{
    public partial class frmSalesReturn : frmBaseEditForm
    {
        public delegate void dlgRefreshParentForm();
        public event dlgRefreshParentForm RefreshParentForm;
        public delegate void dlgSaveAttach(string sourceTable, Guid sourceGuid, string sourceBillNo);
        public event dlgSaveAttach SaveAttach;
        public int? SRID = null;
        public Guid? SRGuid = null;
      

        HR_OrgLogic orgLogic = null;
        SYS_DictItemLineLogic dictLineLogic = null;
        CRM_CompanyLogic companyLogic = null;
        ORD_SalesOrderLogic orderLogic = null;
        ORD_SalesReturnLogic returnLogic = null;
        STK_OutLineLogic outLineLogic = null;
        BindingSource bsSalesReturnLine = new BindingSource();
        List<ORD_SalesReturnLineResult> tempList = new List<ORD_SalesReturnLineResult>();
        List<ORD_SalesReturnLineResult> delList = new List<ORD_SalesReturnLineResult>();
        List<ORD_SalesReturnLineResult> addOrModifyList = new List<ORD_SalesReturnLineResult>();
        bool operFlag = false;
        Guid? _SOGuid = null;
        public frmSalesReturn()
        {
            InitForm( null);
           
        }
        public frmSalesReturn ( Guid? sourceBillGuid)
        {
            InitForm(sourceBillGuid);
        }
        void InitForm( Guid? sourceBillGuid)
        {
            InitializeComponent();
            this.GetEditEntity += new dlgGetEditEntity(Form_GetEditEntity);
            dictLineLogic = new SYS_DictItemLineLogic(this);
            orgLogic = new HR_OrgLogic(this);
            returnLogic = new ORD_SalesReturnLogic(this);
            outLineLogic = new STK_OutLineLogic(this);
            companyLogic = new CRM_CompanyLogic(this);
            orderLogic = new ORD_SalesOrderLogic(this);
            _SOGuid = sourceBillGuid;
        }
        #region 实现基类获取实体信息方法
        object Form_GetEditEntity()
        {
            ORD_SalesReturnResult info = new ORD_SalesReturnResult();
            info.SRGuid = SRGuid;
            info = this.ConvertControlToEntity<ORD_SalesReturnResult>(this.stcpBase.Controls, info, null);
            this.SetDataIsChanged<ORD_SalesReturnResult>(info);
            return info;
        }
        #endregion

        #region 初始化绑定控件
        public void BindComboBox()
        {
            orgLogic.BindComboBox(cboOperOrgID, new HR_OrgParam { });
            List<SYS_DictItemLineResult> itemLineList = dictLineLogic.GetListByCode(new SYS_DictItemLineParam
            {
                ItemCodes = new string[] {"TransportCompany","FreightPaymentType","Currency","Warehouse","UnitCode" }
            });
       
            dictLineLogic.BindComboBox(cboTransportCompany, "TransportCompany", itemLineList);
            dictLineLogic.BindComboBox(cboFreightClearForm, "FreightPaymentType", itemLineList);
            dictLineLogic.BindComboBox(cboCurrency, "Currency", itemLineList);
            dictLineLogic.BindComboBox(colCurrency, "Currency", itemLineList);
            dictLineLogic.BindComboBox(colWarehouse, "Warehouse", itemLineList);
            dictLineLogic.BindComboBox(colUnit, "UnitCode", itemLineList);

        }
        #endregion

        #region 初始化加载数据
        private void InitData()
        {
            if (SRGuid != null)
            {
                ORD_SalesReturnResult info = returnLogic.GetInfo(new ORD_SalesReturnParam { SRGuid = SRGuid });

                this.ConvertEntityToControl<ORD_SalesReturnResult>(this.stcpBase.Controls, info, null);
                if (info != null)
                {
                    txtOperDeptName.Text = info.OperDeptName;
                    decimal totalAmount = Math.Round(info.Amount.ToDecimal(), 3, MidpointRounding.AwayFromZero);
                    txtAmount.Text = totalAmount.ToStringHasNull();
                    if (info.ReturnLineList != null)
                    {
                        addOrModifyList = info.ReturnLineList;
                    }
                }
            }
            else
            {
                txtReturnDate.Text = DateTime.Now.Date.ToStringHasNull();
                txtOperDeptID.Text = MySession.DeptID.ToStringHasNull();
                txtOperDeptName.Text = MySession.DeptName;
                txtOperEmpID.Text = MySession.UserID.ToStringHasNull();
                txtOperEmpName.Text = MySession.UserName.ToStringHasNull();
                SYS_DictItemLineLogic.SetCombolSelectedIndex(this.cboOperOrgID, MySession.OrgID, true);
            }
            bsSalesReturnLine.DataSource = addOrModifyList;
            dgvSalesReturnLine.DataSource = bsSalesReturnLine;
            //CheckAuditButton("ORD_SalesOrder", SRGuid, this.tsbSubmit, null, this.tsbAudit, this.tsbUnDo);
            if (SRGuid==null && _SOGuid != null)
            {
                ORD_SalesOrderResult orderResult = orderLogic.GetInfo(new ORD_SalesOrderParam() { SOGuid = _SOGuid });
                if(orderResult!=null)
                InitSourceData(orderResult);
            }
        }
        #endregion

        #region 窗体加载
        private void frmSalesReturn_Load(object sender, EventArgs e)
        {
            colModel.ButtonCustomClick += new EventHandler<EventArgs>(editControl_ButtonCustomClick);
            colModel.ButtonClearClick += new EventHandler<CancelEventArgs>(editControl_ButtonClearClick);
            frmSysAttachFiles frm = new frmSysAttachFiles();
            frm.SourceGuid = SRGuid;
            frm.TopLevel = false;
            //frm.Tag = newItem; //存放选项卡对象，方便后续在事件里关闭选项卡
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            stcpSys_AttachFiles.Controls.Add(frm);
            frm.Show();
            BindComboBox();
            InitData();
            this.SaveAttach += new dlgSaveAttach(frm.SaveAttach);
            operFlag = true;
        }
        #endregion

        #region 列编辑控件双击弹窗
        private void editControl_ButtonCustomClick(object sender, EventArgs e)
        {
            ImportSourceLine(false);
        }
        #endregion

        #region 列编辑控件双击清除
        private void editControl_ButtonClearClick(object sender, EventArgs e)
        {

        }
        #endregion

        #region 按钮点击事件
        #region 保存
        private void tsbSave_Click(object sender, EventArgs e)
        {
            ORD_SalesReturnResult info = Form_GetEditEntity() as ORD_SalesReturnResult;
            if (!this.DataIsChanged)
            {
                this.ShowNoChangedMsg();
                return;
            }
           

            bsSalesReturnLine.EndEdit();
            tempList.Clear();
            foreach (ORD_SalesReturnLineResult rst in addOrModifyList)
            {
                if (rst.HasChanged())
                {
                    tempList.Add(rst);
                }
            }
            //tempList.AddRange(addOrModifyList);
            tempList.AddRange(delList);
            info.ReturnLineList = tempList;
            WCFAddUpdateResult result = this.AsyncExecute<WCFAddUpdateResult, ORD_SalesReturnResult>(info, returnLogic.AddOrUpdate, (a) =>
            {
                if (a.KeyGuid.ToGuid() != Guid.Empty)
                {
          
                    SRGuid = a.KeyGuid.ToGuid();
                    CRM_CompanyResult companyResult = companyLogic.GetCustInfo(new CRM_CompanyParam() { CompanyID = txtCustomerID.Text.ToInt32() });
                    if (companyResult != null)
                    {
                        companyResult.LastBusinessDate = txtReturnDate.Text.ToDateTime();
                        companyLogic.AddOrUpdateSup(companyResult);
                    }
                    if (SaveAttach != null)
                        SaveAttach("ORD_SalesReturn", SRGuid.ToGuid(), a.BillNo);
                    InitData();
                    delList.Clear();
                }
            });
        }
        #endregion

        #region 提交
        private void tsbSubmit_Click(object sender, EventArgs e)
        {
            tsbSave_Click(sender, e);
            bool flag = returnLogic.SubmitSalesReturnBill(new ORD_SalesReturnParam() { SRGuid = SRGuid });
            if (flag)
            {
                InitData();
            }
        }
        #endregion

        #region 审核
        private void tsbAudit_Click(object sender, EventArgs e)
        {
            bool flag = returnLogic.AuditSalesReturnBill(new ORD_SalesReturnParam() { SRGuid = SRGuid });
            if (flag)
            {
                InitData();
            }
        }
        #endregion

        #region 撤销
        private void tsbUnDo_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region 添加空行
        private void btnAddRow_Click(object sender, EventArgs e)
        {
            bsSalesReturnLine.AddNew();
            ORD_SalesReturnLineResult rst = bsSalesReturnLine.Current as ORD_SalesReturnLineResult;
            InitNewData(rst);
        }
        #endregion

        #region 插入一行
        private void btnInsertBefore_Click(object sender, EventArgs e)
        {
            
            ORD_SalesReturnLineResult rst = new ORD_SalesReturnLineResult();
            InitNewData(rst);
            bsSalesReturnLine.Insert(dgvSalesReturnLine.CurrentRow.Index, rst);
        }
        #endregion

        void InitNewData(ORD_SalesReturnLineResult rst)
        {
            rst.Currency = cboCurrency.SelectedValue.ToStringHasNull();
            rst.InvType = "备货库存";
            rst.Unit = "PCS";
        }

        #region  删除选中行
        private void btnDelRow_Click(object sender, EventArgs e)
        {
            if (this.bsSalesReturnLine.Current != null)
            {

                Guid? SRGuid =null;
                ORD_SalesReturnLineResult delResult = this.bsSalesReturnLine.Current as ORD_SalesReturnLineResult;
                SRGuid = delResult.SRGuid;
                if (SRGuid.ToGuid()!=Guid.Empty)
                {
                    delResult.IsDeleted = true;
                    delList.Add(delResult);
                }
                bsSalesReturnLine.RemoveCurrent();

            }
        }
        #endregion
        #endregion


        #region 源单据选择
        private void txtSOBillNo_ButtonCustomClick(object sender, EventArgs e)
        {

            frmSelectSalesOrder frmSelectSalesOrder = new frmSelectSalesOrder(false);
            frmSelectSalesOrder.CustomerID = txtCustomerID.Text.ToInt32();
            frmSelectSalesOrder.BringToFront();
            frmSelectSalesOrder.StartPosition = FormStartPosition.CenterScreen;
            
            DialogResult rst = frmSelectSalesOrder.ShowDialog();
            if (rst == DialogResult.OK)
            {
                List<ORD_SalesOrderResult> rstList = frmSelectSalesOrder.GetSelectList<ORD_SalesOrderResult>();
                if (rstList != null && rstList.Count > 0)
                {
                    bsSalesReturnLine.Clear();
                    tempList.Clear();
                    delList.Clear();
                    addOrModifyList.Clear();
                    ORD_SalesOrderResult orderResult=rstList[0];
                    InitSourceData(orderResult);
                }
            }
                     
        }

        void InitSourceData(ORD_SalesOrderResult orderResult)
        {
            if (orderResult != null)
            {
                txtSOGuid.Text = orderResult.SOGuid.ToStringHasNull();
                txtSOBillNo.Text = orderResult.BillNo;
                cboCurrency.SelectedValue = orderResult.Currency;
                txtSODate.Text = orderResult.SODate.ToStringHasNull();
                txtCustomerID.Text = orderResult.CustomerID.ToStringHasNull();
                txtCustomerName.Text = orderResult.CustomerName;
                decimal? totalAmount = 0.0m;
                List<STK_OutLineResult> outLineList= outLineLogic.GetList(new STK_OutLineParam() { SourceBillGuid = orderResult.SOGuid ,IsReturnOver=false});
                foreach (STK_OutLineResult outLineResult in outLineList)
                {
                    ORD_SalesReturnLineResult returnListResult = new ORD_SalesReturnLineResult();
                    SetStkLineObjectValue(returnListResult, outLineResult);
                    totalAmount += returnListResult.Amount;
                    bsSalesReturnLine.Add(returnListResult);
                }
                totalAmount = Math.Round(totalAmount.ToDecimal(), 3, MidpointRounding.AwayFromZero);
                txtAmount.Text = totalAmount.ToStringHasNull();
            }
        }

        
        #endregion

        #region 源单据清除
        private void txtSOBillNo_ButtonCustom2Click(object sender, EventArgs e)
        {
            txtSOGuid.Text = string.Empty;
            txtSOBillNo.Text = string.Empty;
            
        }
        #endregion

        #region 给入库明细对象赋值
        public void SetStkLineObjectValue(ORD_SalesReturnLineResult returnLineResult, STK_OutLineResult outLineRst)
        {
            returnLineResult.SOGuid = outLineRst.SourceBillGuid;
            returnLineResult.SOBillNo = outLineRst.SourceBillNo;//销售单号
            returnLineResult.SOLineGuid = outLineRst.SourceBillLineGuid;
            
            returnLineResult.StkOutGuid = outLineRst.StkOutGuid;
            returnLineResult.StkOutBillNo = outLineRst.StkOutBillNo;//出库单号
            returnLineResult.StkOutLineGuid = outLineRst.StkOutLineGuid;


            returnLineResult.BuyerID = outLineRst.BuyerID;
            returnLineResult.BuyerName = outLineRst.BuyerName;
            returnLineResult.StkInLineGuid = outLineRst.StkInLineGuid;
            returnLineResult.ItemCode = outLineRst.ItemCode;
            returnLineResult.Model = outLineRst.Model;
            returnLineResult.Brand = outLineRst.Brand;
            returnLineResult.Package = outLineRst.Package;
            returnLineResult.Batch = outLineRst.Batch;
            returnLineResult.MPQ = outLineRst.MPQ;
            returnLineResult.Quality = outLineRst.Quality;
            returnLineResult.MarkCode = outLineRst.MarkCode;
            returnLineResult.InvType = outLineRst.InvType;
            returnLineResult.Currency = outLineRst.Currency;
            returnLineResult.Unit = outLineRst.Unit;
            returnLineResult.UnitPrice = outLineRst.UnitPrice;
            returnLineResult.Qty = outLineRst.Qty.ToInt32() - outLineRst.ReturnOccQty.ToInt32();
            returnLineResult.Amount = returnLineResult.UnitPrice * returnLineResult.Qty;
            returnLineResult.Warehouse = outLineRst.Warehouse;
            returnLineResult.Location = outLineRst.Location;
            returnLineResult.IsDeleted = false;
        }
        #endregion

        #region 归属部门选择
        private void txtOperDeptName_ButtonCustomClick(object sender, EventArgs e)
        {
            frmSelectDepartment frmSelectDepartment = new frmSelectDepartment(false);
            frmSelectDepartment.deptIds = txtOperDeptID.Text.Split(',').Select(a => (int?)a.ToInt32()).ToArray();
            frmSelectDepartment.OrgID = cboOperOrgID.SelectedValue.ToInt32();
            frmSelectDepartment.BringToFront();
            frmSelectDepartment.StartPosition = FormStartPosition.CenterScreen;
            DialogResult rst = frmSelectDepartment.ShowDialog();
            if (rst == DialogResult.OK)
            {
                List<HR_DepartmentResult> rstList = frmSelectDepartment.GetSelectList<HR_DepartmentResult>();
                if (rstList != null && rstList.Count > 0)
                {

                    txtOperDeptID.Text = rstList[0].DeptID.ToStringHasNull();
                    txtOperDeptName.Text = rstList[0].DeptName;

                }
            }
        }
        #endregion

        #region 归属部门清除
        private void txtOperDeptName_ButtonCustom2Click(object sender, EventArgs e)
        {
            txtOperDeptID.Text = string.Empty;
            txtOperDeptName.Text = string.Empty;
        }
        #endregion

        #region 归属人员选择
        private void txtOperEmpName_ButtonCustomClick(object sender, EventArgs e)
        {
            frmSelectEmp frmSelectEmp = new frmSelectEmp(false);
            frmSelectEmp.empIds = txtOperEmpID.Text.Split(',').Select(a => (int?)a.ToInt32()).ToArray();
            frmSelectEmp.OrgID = cboOperOrgID.SelectedValue.ToInt32();
            frmSelectEmp.DeptID = txtOperDeptID.Text.ToInt32();
            DialogResult rst = frmSelectEmp.ShowDialog();
            if (rst == DialogResult.OK)
            {
                List<HR_EmployeeResult> rstList = frmSelectEmp.GetSelectList<HR_EmployeeResult>();
                if (rstList != null && rstList.Count > 0)
                {
                    txtOperEmpID.Text = rstList[0].EmpID.ToStringHasNull();
                    txtOperEmpName.Text = rstList[0].EmpName;
                }
            }
        }
        #endregion

        #region 归属人员清除
        private void txtOperEmpName_ButtonCustom2Click(object sender, EventArgs e)
        {
            txtOperEmpID.Text = string.Empty;
            txtOperEmpName.Text = string.Empty;
        }
        #endregion

        #region  导入关联明细
        private void btnImportStkOutLine_Click(object sender, EventArgs e)
        {
            ImportSourceLine(true);
        }

        private void ImportSourceLine(bool isMutiSelect)
        {
            if (string.IsNullOrEmpty(txtCustomerID.Text))
            {
                this.ShowMessage("请选择客户！");
                return;
            }
            if (string.IsNullOrEmpty(cboCurrency.Text))
            {
                this.ShowMessage("请选择币种！");
                return;
            }
                frmSelectStkOutLine frm = new frmSelectStkOutLine(isMutiSelect);
               
                if (txtSOGuid.Text.ToGuid() != Guid.Empty)
                    frm.SourceBillGuid = txtSOGuid.Text.ToGuid();
                Guid? stkOutLineGuid = Guid.Empty;
                string model = string.Empty;
                if (!isMutiSelect)
                {
                    stkOutLineGuid = dgvSalesReturnLine.CurrentRow.Cells["colStkOutLineGuid"].Value.ToGuid();
                    model = dgvSalesReturnLine.CurrentRow.Cells["colModel"].Value.ToStringHasNull();
                }

                if (!string.IsNullOrEmpty(model))
                    frm.Model = model;
                if (stkOutLineGuid != Guid.Empty)//如果已经存在关联的源单据明细，则只筛选此条明细
                    frm.StkOutLineGuid = stkOutLineGuid;
                else//如果是新行，则排除掉已经存在列表里面的所有的源单据明细
                {
                    Guid?[] noStkOutLineGuids = addOrModifyList.Where(a => a.StkOutLineGuid.ToGuid() != Guid.Empty).Select(a => a.StkOutLineGuid).Distinct().ToArray();
                    frm.NoStkOutLineGuids = noStkOutLineGuids;
                }
                frm.BringToFront();
                frm.StartPosition = FormStartPosition.CenterScreen;
                DialogResult rst = frm.ShowDialog();
                if (rst == DialogResult.OK)
                {
                    List<STK_OutLineResult> rstList = frm.GetSelectList<STK_OutLineResult>();
                    if (rstList != null && rstList.Count > 0)
                    {
                        foreach (STK_OutLineResult outLineResult in rstList)
                        {
                            bool isAddNew = true;
                            foreach (DataGridViewRow row in dgvSalesReturnLine.Rows)
                            {
                                //如果是已经存在的行，则利用现成的行进行编辑

                                if (row.Cells["colStkOutLineGuid"].Value.ToGuid() == outLineResult.StkOutLineGuid)
                                {
                                    isAddNew = false;
                                    ORD_SalesReturnLineResult returnLineResult = bsSalesReturnLine[row.Index] as ORD_SalesReturnLineResult;
                                    SetStkLineObjectValue(returnLineResult, outLineResult);
                                    break;
                                }
                            }
                            if (isAddNew)
                            {
                                if (!isMutiSelect)//单选
                                {
                                    ORD_SalesReturnLineResult returnLineResult = bsSalesReturnLine.Current as ORD_SalesReturnLineResult;
                                    SetStkLineObjectValue(returnLineResult, outLineResult);
                                }
                                else//多选
                                {
                                    ORD_SalesReturnLineResult returnLineResult = new ORD_SalesReturnLineResult();
                                    SetStkLineObjectValue(returnLineResult, outLineResult);
                                    bsSalesReturnLine.Add(returnLineResult);
                                }
                            }
                        }
                    }
                }
                dgvSalesReturnLine.EndEdit();
           

           
        }
        #endregion

        #region 客户选择
        private void txtCustomerName_ButtonCustomClick(object sender, EventArgs e)
        {
            frmSelectCustomer frmSelectCustomer = new frmSelectCustomer(false, "colCompanyID");
            frmSelectCustomer.BringToFront();
            frmSelectCustomer.StartPosition = FormStartPosition.CenterScreen;
            DialogResult rst = frmSelectCustomer.ShowDialog();
            if (rst == DialogResult.OK)
            {
                List<CRM_CompanyResult> rstList = frmSelectCustomer.GetSelectList<CRM_CompanyResult>();
                if (rstList != null && rstList.Count > 0)
                {
                    txtCustomerID.Text = rstList[0].CompanyID.ToStringHasNull();
                    txtCustomerName.Text = rstList[0].CompanyName.ToStringHasNull();
                }
            }
        }
        #endregion
        #region  客户清除
        private void txtCustomerName_ButtonCustom2Click(object sender, EventArgs e)
        {
            txtCustomerID.Text = string.Empty;
            txtCustomerName.Text = string.Empty;
          
        }
        #endregion
    }
}
