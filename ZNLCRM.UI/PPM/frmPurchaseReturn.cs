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
using ZNLCRM.UI.Logic.PPM;
using ZNLCRM.UI.Logic.STK;
using ZNLCRM.Entity.UserModel.PPM;
using ZNLCRM.Entity.UserModel.Sys;
using ZNLCRM.Entity.UserModel.HR;
using ZNLCRM.Client.Entry;
using ZNLCRM.Utility;
using ZNLCRM.Entity.UserModel.STK;
using ZNLCRM.Entity.UserModel.CRM;
using ZNLCRM.UI.SPM;
using ZNLCRM.UI.STK;
using ZNLCRM.UI.CRM;
using ZNLCRM.UI.HR;
using ZNLCRM.Entity.UserModel.Common;

namespace ZNLCRM.UI.PPM
{
    public partial class frmPurchaseReturn : frmBaseEditForm
    {
        public delegate void dlgRefreshParentForm();
        public event dlgRefreshParentForm RefreshParentForm;
        public delegate void dlgSaveAttach(string sourceTable, Guid sourceGuid, string sourceBillNo);
        public event dlgSaveAttach SaveAttach;
        public int? PRID = null;
        public Guid? PRGuid = null;
        public Guid? SourceBillGuid = null;
        public string SourceBillNo = null;
        HR_OrgLogic orgLogic = null;
        SYS_DictItemLineLogic dictLineLogic = null;
        CRM_CompanyLogic companyLogic = null;
        ORD_PurchaseOrderLogic orderLogic = null;
        ORD_PurchaseReturnLogic returnLogic = null;
        STK_InLineLogic inLineLogic = null;
        BindingSource bsPurchaseReturnLine = new BindingSource();
        List<ORD_PurchaseReturnLineResult> tempList = new List<ORD_PurchaseReturnLineResult>();
        List<ORD_PurchaseReturnLineResult> delList = new List<ORD_PurchaseReturnLineResult>();
        List<ORD_PurchaseReturnLineResult> addOrModifyList = new List<ORD_PurchaseReturnLineResult>();
        bool operFlag = false;
        public frmPurchaseReturn()
        {
            InitializeComponent();
            dictLineLogic = new SYS_DictItemLineLogic(this);
            orgLogic = new HR_OrgLogic(this);
            returnLogic = new ORD_PurchaseReturnLogic(this);
            inLineLogic = new STK_InLineLogic(this);
            companyLogic = new CRM_CompanyLogic(this);
            orderLogic = new ORD_PurchaseOrderLogic(this);
        }
        #region 实现基类获取实体信息方法
        object Form_GetEditEntity()
        {
            ORD_PurchaseReturnResult info = new ORD_PurchaseReturnResult();
            info.PRGuid = PRGuid;
            info = this.ConvertControlToEntity<ORD_PurchaseReturnResult>(this.stcpBase.Controls, info, null);
            this.SetDataIsChanged<ORD_PurchaseReturnResult>(info);
            return info;
        }
        #endregion

        #region 初始化绑定控件
        public void BindComboBox()
        {
            orgLogic.BindComboBox(cboOperOrgID, new HR_OrgParam { });
            List<SYS_DictItemLineResult> itemLineList = dictLineLogic.GetListByCode(new SYS_DictItemLineParam
            {
                ItemCodes = new string[] { "Currency", "Warehouse", "UnitCode" }
            });

            dictLineLogic.BindComboBox(cboCurrency, "Currency", itemLineList);
            dictLineLogic.BindComboBox(colCurrency, "Currency", itemLineList);
            dictLineLogic.BindComboBox(colWarehouse, "Warehouse", itemLineList);
            dictLineLogic.BindComboBox(colUnit, "UnitCode", itemLineList);

        }
        #endregion

        #region 初始化加载数据
        private void InitData()
        {
            if (PRGuid != null)
            {
                ORD_PurchaseReturnResult info = returnLogic.GetInfo(new ORD_PurchaseReturnParam { PRGuid = PRGuid });

                this.ConvertEntityToControl<ORD_PurchaseReturnResult>(this.stcpBase.Controls, info, null);
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
            bsPurchaseReturnLine.DataSource = addOrModifyList;
            dgvPurchaseReturnLine.DataSource = bsPurchaseReturnLine;
            //CheckAuditButton("ORD_SalesOrder", SRGuid, this.tsbSubmit, null, this.tsbAudit, this.tsbUnDo);
            if (PRGuid == null && SourceBillGuid != null)
            {
                ORD_PurchaseOrderResult orderResult = orderLogic.GetInfo(new ORD_PurchaseOrderParam() { POGuid = SourceBillGuid });
                if (orderResult != null)
                    InitSourceData(orderResult);
            }
        }
        #endregion
        void InitSourceData(ORD_PurchaseOrderResult orderResult)
        {
            if (orderResult != null)
            {
                txtPOGuid.Text = orderResult.POGuid.ToStringHasNull();
                txtPOBillNo.Text = orderResult.BillNo;
                cboCurrency.SelectedValue = orderResult.Currency;
                txtPODate.Text = orderResult.PODate.ToStringHasNull();
                decimal? totalAmount = 0.0m;
                List<STK_InLineResult> inLineList = inLineLogic.GetList(new STK_InLineParam() { SourceBillGuid = orderResult.POGuid });
                foreach (STK_InLineResult inLineResult in inLineList)
                {

                    ORD_PurchaseReturnLineResult returnListResult = new ORD_PurchaseReturnLineResult();
                    SetStkLineObjectValue(returnListResult, inLineResult);
                    totalAmount += returnListResult.Amount;
                    bsPurchaseReturnLine.Add(returnListResult);
                }
                totalAmount = Math.Round(totalAmount.ToDecimal(), 3, MidpointRounding.AwayFromZero);
                txtAmount.Text = totalAmount.ToStringHasNull();
                CRM_CompanyResult companyResult = companyLogic.GetCustInfo(new CRM_CompanyParam() { CompanyID = orderResult.SupplierID.ToInt32() });
                if (companyResult != null)
                {
                    txtSupplierID.Text = companyResult.CompanyID.ToStringHasNull();
                    txtSupplierName.Text = companyResult.CompanyName;
                }
            }
        }
        #region 窗体加载
        private void frmPurchaseReturn_Load(object sender, EventArgs e)
        {
            colModel.ButtonCustomClick += new EventHandler<EventArgs>(editControl_ButtonCustomClick);
            colModel.ButtonClearClick += new EventHandler<CancelEventArgs>(editControl_ButtonClearClick);
            frmSysAttachFiles frm = new frmSysAttachFiles();
            frm.SourceGuid = PRGuid;
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


        #region 添加新行
        private void btnAddRow_Click(object sender, EventArgs e)
        {
            bsPurchaseReturnLine.AddNew();
            ORD_PurchaseReturnLineResult rst = bsPurchaseReturnLine.Current as ORD_PurchaseReturnLineResult;
            InitNewData(rst);
        }
        #endregion

        #region 插入一行
        private void btnInsertBefore_Click(object sender, EventArgs e)
        {
            ORD_PurchaseReturnLineResult rst = new ORD_PurchaseReturnLineResult();
            InitNewData(rst);
            bsPurchaseReturnLine.Insert(dgvPurchaseReturnLine.CurrentRow.Index, rst);
        }
        #endregion

        void InitNewData(ORD_PurchaseReturnLineResult rst)
        {
            rst.Currency = cboCurrency.SelectedValue.ToStringHasNull();
            rst.InvType = "备货库存";
            rst.Unit = "PCS";
        }

        #region 删除一行
        private void btnDelRow_Click(object sender, EventArgs e)
        {
            if (this.bsPurchaseReturnLine.Current != null)
            {

                Guid? PRGuid = null;
                ORD_PurchaseReturnLineResult delResult = this.bsPurchaseReturnLine.Current as ORD_PurchaseReturnLineResult;
                PRGuid = delResult.PRGuid;
                if (PRGuid.ToGuid() != Guid.Empty)
                {
                    delResult.IsDeleted = true;
                    delList.Add(delResult);
                }
                bsPurchaseReturnLine.RemoveCurrent();
            }
        }
        #endregion

        #region 粘贴
        private void btnPaste_Click(object sender, EventArgs e)
        {

        }
        #endregion
       
        #region 选择源单据
        private void txtPOBillNo_ButtonCustomClick(object sender, EventArgs e)
        {
            frmSelectPurchaseOrder frmSelectPurchaseOrder = new frmSelectPurchaseOrder(false,
                new ORD_PurchaseOrderParam() { StkInOccStatusArr = new string[] { "全部占有", "部分占有" }});
            frmSelectPurchaseOrder.SupplierID = txtSupplierID.Text.ToInt32();
            frmSelectPurchaseOrder.BringToFront();
            frmSelectPurchaseOrder.StartPosition = FormStartPosition.CenterScreen;

            DialogResult rst = frmSelectPurchaseOrder.ShowDialog();
            if (rst == DialogResult.OK)
            {
                List<ORD_PurchaseOrderResult> rstList = frmSelectPurchaseOrder.GetSelectList<ORD_PurchaseOrderResult>();
                if (rstList != null && rstList.Count > 0)
                {
                    bsPurchaseReturnLine.Clear();
                    tempList.Clear();
                    delList.Clear();
                    addOrModifyList.Clear();
                    ORD_PurchaseOrderResult orderResult = rstList[0];
                    InitSourceData(orderResult);
                }
            }
        }
        #endregion

        #region  清除源单据
        private void txtPOBillNo_ButtonCustom2Click(object sender, EventArgs e)
        {
            txtPOGuid.Text = string.Empty;
            txtPOBillNo.Text = string.Empty;
        }
        #endregion


        #region 导入入库明细
        private void btnImportStkInLine_Click(object sender, EventArgs e)
        {
            ImportSourceLine(true);
        }
        #endregion

        private void ImportSourceLine(bool isMutiSelect)
        {
            if (string.IsNullOrEmpty(txtSupplierName.Text))
            {
                this.ShowMessage("请选择客户！");
                return;
            }
            if (string.IsNullOrEmpty(cboCurrency.Text))
            {
                this.ShowMessage("请选择币种！");
                return;
            }
            frmSelectStkInLine frm = new frmSelectStkInLine(isMutiSelect);

            if (txtPOGuid.Text.ToGuid() != Guid.Empty)
                frm.SourceBillGuid = txtPOGuid.Text.ToGuid();
            Guid? stkInLineGuid = Guid.Empty;
            string model = string.Empty;
            if (!isMutiSelect)
            {
                stkInLineGuid = dgvPurchaseReturnLine.CurrentRow.Cells["colStkInLineGuid"].Value.ToGuid();
                model = dgvPurchaseReturnLine.CurrentRow.Cells["colModel"].Value.ToStringHasNull();
            }

            if (!string.IsNullOrEmpty(model))
                frm.Model = model;
            if (stkInLineGuid != Guid.Empty)//如果已经存在关联的源单据明细，则只筛选此条明细
                frm.StkInLineGuid = stkInLineGuid;
            else//如果是新行，则排除掉已经存在列表里面的所有的源单据明细
            {
                Guid?[] noStkInLineGuids = addOrModifyList.Where(a => a.StkInLineGuid.ToGuid() != Guid.Empty).Select(a => a.StkInLineGuid).Distinct().ToArray();
                frm.NoStkInLineGuids = noStkInLineGuids;
            }
            frm.BringToFront();
            frm.StartPosition = FormStartPosition.CenterScreen;
            DialogResult rst = frm.ShowDialog();
            if (rst == DialogResult.OK)
            {
                List<STK_InLineResult> rstList = frm.GetSelectList<STK_InLineResult>();
                if (rstList != null && rstList.Count > 0)
                {
                    foreach (STK_InLineResult inLineResult in rstList)
                    {
                        bool isAddNew = true;
                        foreach (DataGridViewRow row in dgvPurchaseReturnLine.Rows)
                        {
                            //如果是已经存在的行，则利用现成的行进行编辑

                            if (row.Cells["colStkInLineGuid"].Value.ToGuid() == inLineResult.StkInLineGuid)
                            {
                                isAddNew = false;
                                ORD_PurchaseReturnLineResult returnLineResult = bsPurchaseReturnLine[row.Index] as ORD_PurchaseReturnLineResult;
                                SetStkLineObjectValue(returnLineResult, inLineResult);
                                break;
                            }
                        }
                        if (isAddNew)
                        {
                            if (!isMutiSelect)//单选
                            {
                                ORD_PurchaseReturnLineResult returnLineResult = bsPurchaseReturnLine.Current as ORD_PurchaseReturnLineResult;
                                SetStkLineObjectValue(returnLineResult, inLineResult);
                            }
                            else//多选
                            {
                                ORD_PurchaseReturnLineResult returnLineResult = new ORD_PurchaseReturnLineResult();
                                SetStkLineObjectValue(returnLineResult, inLineResult);
                                bsPurchaseReturnLine.Add(returnLineResult);
                            }
                        }
                    }
                }
            }
            dgvPurchaseReturnLine.EndEdit();



        }

        #region 给退货明细对象赋值
        public void SetStkLineObjectValue(ORD_PurchaseReturnLineResult returnLineResult, STK_InLineResult inLineRst)
        {
            returnLineResult.POGuid = inLineRst.SourceBillGuid;
            returnLineResult.POBillNo = inLineRst.SourceBillNo;//采购单号
            returnLineResult.POLineGuid = inLineRst.SourceBillLineGuid;

            returnLineResult.StkInGuid = inLineRst.StkInGuid;
            returnLineResult.StkInBillNo = inLineRst.StkInBillNo;//入库单号
            returnLineResult.StkInLineGuid = inLineRst.StkInLineGuid;
            returnLineResult.ItemCode = inLineRst.ItemCode;
            returnLineResult.Model = inLineRst.Model;
            returnLineResult.Brand = inLineRst.Brand;
            returnLineResult.Package = inLineRst.Package;
            returnLineResult.Batch = inLineRst.Batch;
            returnLineResult.MPQ = inLineRst.MPQ;
            returnLineResult.Quality = inLineRst.Quality;
            returnLineResult.MarkCode = inLineRst.MarkCode;
            returnLineResult.InvType = inLineRst.InvType;
            returnLineResult.Unit = inLineRst.Unit;
            returnLineResult.UnitPrice = inLineRst.UnitPrice;
            returnLineResult.Qty = inLineRst.Qty.ToInt32() - inLineRst.ReturnOccQty.ToInt32();
            returnLineResult.Currency = inLineRst.Currency;
            returnLineResult.Amount = returnLineResult.UnitPrice * returnLineResult.Qty;
            returnLineResult.Warehouse = inLineRst.Warehouse;
            returnLineResult.Location = inLineRst.Location;
            returnLineResult.IsDeleted = false;
        }
        #endregion

        #region 预留库存
        private void btnReserve_Click(object sender, EventArgs e)
        {
            if (PRGuid != null && txtApproveStatus.Text=="待审核")
            {
                frmStockReserve frmStockReserve = new frmStockReserve();
                frmStockReserve.StartPosition = FormStartPosition.CenterScreen;
                frmStockReserve.BringToFront();
                frmStockReserve.SourceBillGuid = PRGuid;
                //frmStockReserve.RefreshParentForm += delegate { BindSuperGridControl(); };
                frmStockReserve.ShowDialog();
            }
            else
            {
                this.ShowMessage("预留之前请先保存提交采购退货单！");
            }
        }
        #endregion

        #region  保存
        private void tsbSave_Click(object sender, EventArgs e)
        {
            ORD_PurchaseReturnResult info = Form_GetEditEntity() as ORD_PurchaseReturnResult;
            if (!this.DataIsChanged)
            {
                this.ShowNoChangedMsg();
                return;
            }
           
            bsPurchaseReturnLine.EndEdit();
            tempList.Clear();
            foreach (ORD_PurchaseReturnLineResult rst in addOrModifyList)
            {
                if (rst.HasChanged())
                {
                    tempList.Add(rst);
                }
            }
            //tempList.AddRange(addOrModifyList);
            tempList.AddRange(delList);
            info.ReturnLineList = tempList;
            WCFAddUpdateResult result = this.AsyncExecute<WCFAddUpdateResult, ORD_PurchaseReturnResult>(info, returnLogic.AddOrUpdate, (a) =>
            {
                if (a.KeyGuid.ToGuid() != Guid.Empty)
                {

                    PRGuid = a.KeyGuid.ToGuid();
                    CRM_CompanyResult companyResult = companyLogic.GetCustInfo(new CRM_CompanyParam() { CompanyID = txtSupplierID.Text.ToInt32() });
                    if (companyResult != null)
                    {
                        companyResult.LastBusinessDate = txtReturnDate.Text.ToDateTime();
                        companyLogic.AddOrUpdateSup(companyResult);
                    }
                    if (SaveAttach != null)
                        SaveAttach("ORD_PurchaseReturn", PRGuid.ToGuid(), a.BillNo);
                    
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
            bool flag = returnLogic.SubmitPurchaseReturnBill(new ORD_PurchaseReturnParam() { PRGuid = PRGuid });
            if (flag)
            {
                InitData();
            }
        }
        #endregion
        #region 审核
        private void tsbAudit_Click(object sender, EventArgs e)
        {
            bool flag = returnLogic.AuditPurchaseReturnBill(new ORD_PurchaseReturnParam() { PRGuid = PRGuid });
            if (flag)
            {
                InitData();
            }
        }
        #endregion

        #region  选择供应商
        private void txtSupplierName_ButtonCustomClick(object sender, EventArgs e)
        {
            frmSelectSupplier frmSelectCustomer = new frmSelectSupplier(false, "colCompanyID");
            frmSelectCustomer.BringToFront();
            frmSelectCustomer.StartPosition = FormStartPosition.CenterScreen;
            DialogResult rst = frmSelectCustomer.ShowDialog();
            if (rst == DialogResult.OK)
            {
                List<CRM_CompanyResult> rstList = frmSelectCustomer.GetSelectList<CRM_CompanyResult>();
                if (rstList != null && rstList.Count > 0)
                {
                    txtSupplierID.Text = rstList[0].CompanyID.ToStringHasNull(); ;
                    txtSupplierName.Text = rstList[0].CompanyName;
                    txtTelephone.Text = rstList[0].Telephone;
                    txtContact.Text = rstList[0].ContactName;
                }

            }
        }
        #endregion

        #region 清除供应商
        private void txtSupplierName_ButtonCustom2Click(object sender, EventArgs e)
        {
            txtSupplierID.Text = string.Empty;
            txtSupplierName.Text = string.Empty;
            txtContact.Text = string.Empty;
            txtTelephone.Text = string.Empty;
        }
        #endregion

        #region 选择联系人
        private void txtContact_ButtonCustomClick(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSupplierID.Text))
            {
                frmSelectCustomerContact frmSelectCustomerContact = new frmSelectCustomerContact(false);
                frmSelectCustomerContact.CompanyID = txtSupplierID.Text.ToInt32();
                frmSelectCustomerContact.BringToFront();
                frmSelectCustomerContact.StartPosition = FormStartPosition.CenterScreen;
                DialogResult rst = frmSelectCustomerContact.ShowDialog();
                if (rst == DialogResult.OK)
                {
                    List<CRM_CompanyContactResult> rstList = frmSelectCustomerContact.GetSelectList<CRM_CompanyContactResult>();
                    if (rstList != null && rstList.Count > 0)
                    {
                        txtContact.Text = rstList[0].ContactName;
                        txtTelephone.Text = rstList[0].Telephone;
                    }
                }
            }
            else
            {
                this.ShowMessage("请先选择供应商！");
            }
        }
        #endregion

        #region 清除联系人
        private void txtContact_ButtonCustom2Click(object sender, EventArgs e)
        {
            txtContact.Text = string.Empty;
            txtTelephone.Text = string.Empty;
        }
        #endregion



        #region 所属部门选择
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

        #region 清除所属部门
        private void txtOperDeptName_ButtonCustom2Click(object sender, EventArgs e)
        {
            txtOperDeptID.Text = string.Empty;
            txtOperDeptName.Text = string.Empty;
        }
        #endregion

        #region 所属人员选择
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

        #region 清除所属人员
        private void txtOperEmpName_ButtonCustom2Click(object sender, EventArgs e)
        {
            txtOperEmpID.Text = string.Empty;
            txtOperEmpName.Text = string.Empty;
        }
        #endregion

       


    }
}
