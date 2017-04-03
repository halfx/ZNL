using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZNLCRM.UI.Logic.Common;
using ZNLCRM.Entity.UserModel.CRM;
using ZNLCRM.UI.Logic.Sys;
using ZNLCRM.Entity.UserModel.Sys;
using ZNLCRM.UI.Logic.CRM;
using ZNLCRM.UI.Logic.HR;
using ZNLCRM.Entity.UserModel.HR;
using ZNLCRM.Entity.DBModel;
using ZNLCRM.UI.HR;
using ZNLCRM.Utility;
using ZNLCRM.Entity.UserModel.Common;
using ZNLCRM.UI.SYS;
using ZNLCRM.Controls;
using ZNLFrame.Entity;
using ZNLCRM.Utility.CommonEnum;
namespace ZNLCRM.UI.CRM
{
    public partial class frmCustomerEdit : frmBaseEditForm
    {
        public delegate void dlgRefreshParentForm();
        public event dlgRefreshParentForm RefreshParentForm;
        public  int companyID = 0;
        SYS_DictItemLineLogic dictLineLogic = null;
        CRM_ZoneLogic zoneLogic = null;
        HR_OrgLogic orgLogic = null;
        HR_DepartmentLogic deptLogic = null;
        CRM_CompanyLogic companyLogic = null;
        BindingSource bsContact = new BindingSource ();
        List<CRM_CompanyContactResult> tempList = new List<CRM_CompanyContactResult>();
        List<CRM_CompanyContactResult> delList = new List<CRM_CompanyContactResult>();
        List<CRM_CompanyContactResult> addOrModifyList = new List<CRM_CompanyContactResult>();
        public frmCustomerEdit()
        {
            InitializeComponent();
            this.GetEditEntity += new dlgGetEditEntity(Form_GetEditEntity);
            dictLineLogic = new SYS_DictItemLineLogic(this);
            zoneLogic = new CRM_ZoneLogic(this);
            orgLogic = new HR_OrgLogic(this);
            deptLogic = new HR_DepartmentLogic(this);
            companyLogic = new CRM_CompanyLogic(this);
        }

        #region 实现基类获取实体信息方法
        object Form_GetEditEntity()
        {
            CRM_CompanyResult info = new CRM_CompanyResult();
            info.CompanyID = companyID;
            info = this.ConvertControlToEntity<CRM_CompanyResult>(this.tpCompanyInfo.Controls, info, null);
            info = this.ConvertControlToEntity<CRM_CompanyResult>(this.tpFunnelInfo.Controls, info, null);
            info = this.ConvertControlToEntity<CRM_CompanyResult>(this.tpOtherContact.Controls, info, null);
            this.SetDataIsChanged<CRM_CompanyResult>(info);
            return info;
        }
        #endregion
        #region 窗体加载
        private void frmCustomerEdit_Load(object sender, EventArgs e)
        {
            BindComboBox();
            InitData();
        }
        #endregion

        #region 初始化绑定控件
        public void BindComboBox()
        {
           
           zoneLogic.BindComboBox(cboArea,new CRM_ZoneParam{ZType=1});
           List<SYS_DictItemLineResult> itemLineList = dictLineLogic.GetListByCode(new SYS_DictItemLineParam
           {
               ItemCodes = new string[] {
                "Duty","Industry","DataSource" ,"GoodsSource","PriceLevel","CompanyLevel","CompanyNature","CompanyCreditRating","CompanyInStage", "CustStatus", "CustDealType","ClearingForm","Currency" }
            });
            orgLogic.BindComboBox(cboOrgID, new HR_OrgParam { });
            deptLogic.BindComboBox(cboDeptID, new HR_DepartmentParam { });
            dictLineLogic.BindComboBox(cboDuty, "Duty", itemLineList);
            dictLineLogic.BindComboBox(cboIndustry, "Industry", itemLineList);
            dictLineLogic.BindComboBox(cboDataSource, "DataSource", itemLineList);
            dictLineLogic.BindComboBox(cboGoodsSource, "GoodsSource", itemLineList);
            dictLineLogic.BindComboBox(cboPriceLevel, "PriceLevel", itemLineList);
            dictLineLogic.BindComboBox(cboRank, "CompanyLevel", itemLineList);
            dictLineLogic.BindComboBox(cboBusinessNature, "CompanyNature", itemLineList);
            dictLineLogic.BindComboBox(cboCreditRating, "CompanyCreditRating", itemLineList);
            dictLineLogic.BindComboBox(cboInStage, "CompanyInStage", itemLineList);
            dictLineLogic.BindComboBox(cboCustStatus, "CustStatus", itemLineList);
            dictLineLogic.BindComboBox(cboCustDealType, "CustDealType", itemLineList);
            dictLineLogic.BindComboBox(cboClearingForm, "ClearingForm", itemLineList);
            dictLineLogic.BindComboBox(cboCurrencyCode, "Currency", itemLineList);
            
            //dictLogic
            List<KeyValuePair<string,string>> kvList=new List<KeyValuePair<string,string>> ();
            kvList.Add(new KeyValuePair<string,string>("",""));
            kvList.Add(new KeyValuePair<string,string>("男","男"));
            kvList.Add(new KeyValuePair<string,string>("女","女"));
            colGender.DisplayMember = "Key";
            colGender.ValueMember = "Value";
            colGender.DataSource = kvList;
            
        }
        #endregion

        #region 初始化加载数据
        public void InitData()
        {
            //cboOrgID.SelectedValue = this.SessionInfo.OrgID;
            //cboDeptID.SelectedValue = this.SessionInfo.DeptID;
            if (companyID > 0)
            {
                CRM_CompanyResult info = companyLogic.GetCustInfo(new CRM_CompanyParam { CompanyID = companyID });
                this.ConvertEntityToControl<CRM_CompanyResult>(this.tpCompanyInfo.Controls, info, null);
                this.ConvertEntityToControl<CRM_CompanyResult>(this.tpFunnelInfo.Controls, info, null);
                this.ConvertEntityToControl<CRM_CompanyResult>(this.tpOtherContact.Controls, info, null);
                if (info != null && info.ContactList != null)
                {
                    addOrModifyList = info.ContactList;
                   
                }
            }
           
            bsContact.DataSource = addOrModifyList;
            dgvContact.DataSource = bsContact;
        }
        #endregion

        private void btnSave_Click(object sender, EventArgs e)
        {
            CRM_CompanyResult info = Form_GetEditEntity() as CRM_CompanyResult;
            if (!this.DataIsChanged)
            {
                this.ShowNoChangedMsg();
                return;
            }
            bool flag = false;
            foreach (CRM_CompanyContactResult rst in addOrModifyList)
            {
                if (string.IsNullOrEmpty(rst.ContactName) || string.IsNullOrEmpty(rst.Telephone))
                {
                    flag = true;
                    break;
                }
            }
            if (flag)
            {
                this.ShowMessage("联系人和联系电话不能为空！");
                return;
            }
            bsContact.EndEdit();
            tempList.Clear();
            foreach (CRM_CompanyContactResult rst in addOrModifyList)
            {
                if (rst.HasChanged())
                {
                    tempList.Add(rst);
                }
            }
            
            tempList.AddRange(delList);
            info.ContactList = tempList;
            WCFAddUpdateResult result = this.AsyncExecute<WCFAddUpdateResult, CRM_CompanyResult>(info, companyLogic.AddOrUpdateCust, (a) =>
            {
                companyID = a.Key;
                InitData();
                delList.Clear();
            });
            
        }

        #region 下拉级联
        private void CascadingDropDown(Controls.UcComboBox c, Controls.UcComboBox pc, int ztype)
        {
            if (pc.Text.Trim() != "")
            {
                CRM_ZoneResult rst = zoneLogic.GetInfo(new CRM_ZoneParam { Name_CN = pc.Text });
                if (rst != null)
                    zoneLogic.BindComboBox(c, new CRM_ZoneParam { ZType = ztype, PZID = rst.ZID });
                else c.DataSource = null;

            }
            else
                c.DataSource = null;
        }
        private void cboArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            CascadingDropDown(cboCountry, cboArea, 2);
            CascadingDropDown(cboProvince, cboCountry, 3);
            CascadingDropDown(cboCity, cboProvince, 4);
        }

        private void cboCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            CascadingDropDown(cboProvince, cboCountry, 3);
            CascadingDropDown(cboCity, cboProvince, 4);
        }

        private void cboProvince_SelectedValueChanged(object sender, EventArgs e)
        {
            CascadingDropDown(cboCity, cboProvince, 4);
        }
        #endregion 

        private void txtAttachEmpName_ButtonCustomClick(object sender, EventArgs e)
        {
             frmSelectEmp frmSelectEmp = new frmSelectEmp(true);
             frmSelectEmp.empIds = txtAttachEmpID.Text.Split(',').Select(a => (int?)a.ToInt32()).ToArray();
             frmSelectEmp.OrgID = cboOrgID.SelectedValue.ToInt32();
             frmSelectEmp.DeptID = cboDeptID.SelectedValue.ToInt32();
            DialogResult rst = frmSelectEmp.ShowDialog();
            if (rst == DialogResult.OK)
            {
                List<HR_EmployeeResult> rstList = frmSelectEmp.GetSelectList<HR_EmployeeResult>();
                if(rstList!=null && rstList.Count>0)
                {
                    if (txtAttachEmpID.Text.Length > 0)
                    {
                        txtAttachEmpID.Text = txtAttachEmpID.Text + "," + string.Join(",", rstList.Select(a => a.EmpID).ToArray());
                        txtAttachEmpName.Text = txtAttachEmpName.Text + "," + string.Join(",", rstList.Select(a => a.EmpName).ToArray());
                    }
                    else
                    {
                        txtAttachEmpID.Text = string.Join(",", rstList.Select(a => a.EmpID).ToArray());
                        txtAttachEmpName.Text = string.Join(",", rstList.Select(a => a.EmpName).ToArray());
                    }
                 
                }
                
            }
        }

        private void SelectDict(UcTextBox textBox ,string itemCode)
        {
            frmSearchDict frmSearchDict = new frmSearchDict(true);
            frmSearchDict.ItemCode = itemCode;
            if (textBox.Text.Length>0)
            frmSearchDict.NoItemValue = textBox.Text.Split(',');
            frmSearchDict.BringToFront();
            if (DialogResult.OK == frmSearchDict.ShowDialog())
            {
                List<SYS_DictItemLineResult> rstList = frmSearchDict.GetSelectList<SYS_DictItemLineResult>();
                if (rstList != null && rstList.Count > 0)
                {
                    if (textBox.Text.Length > 0)
                    {
                        textBox.Text = textBox.Text + "," + string.Join(",", rstList.Select(a => a.ItemValue2).ToArray());
                    }
                    else
                    {
                        textBox.Text = string.Join(",", rstList.Select(a => a.ItemValue2).ToArray());
                    }
                }
            }
        }
        private void txtMainBrand_ButtonCustomClick(object sender, EventArgs e)
        {

            SelectDict(txtMainBrand, "MainBrand");
        }

        private void txtMainPackaging_ButtonCustomClick(object sender, EventArgs e)
        {

            SelectDict(txtMainPackaging, "MainPackaging");
        }

        private void txtMainSeries_ButtonCustomClick(object sender, EventArgs e)
        {
            SelectDict(txtMainSeries, "MainSeries");
        }

        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            bsContact.AddNew();
        }

        private void btnDelEmp_Click(object sender, EventArgs e)
        {
            if (this.bsContact.Current != null)
            {

                int contactID = 0;
                CRM_CompanyContactResult delResult = this.bsContact.Current as CRM_CompanyContactResult;
                contactID = delResult.ContactID.ToInt32();
                if (contactID > 0)
                {
                    delResult.IsDeleted = true;
                    delList.Add(delResult);
                }
                bsContact.RemoveCurrent();
                
                    
            }
        }

        private void txtAttachEmpName_ButtonCustom2Click(object sender, EventArgs e)
        {
            txtAttachEmpID.Text = string.Empty;
            txtAttachEmpName.Text = string.Empty;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

  









    }
}
