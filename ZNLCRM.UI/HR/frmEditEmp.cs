using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZNLCRM.UI.Logic.Common;
using ZNLCRM.Entity.UserModel.HR;
using ZNLCRM.Entity.UserModel.Common;
using ZNLCRM.UI.Logic.HR;
using DevComponents.Editors;
using ZNLFrame.Entity;
using ZNLCRM.Entity.UserModel.Sys;
using ZNLCRM.UI.Logic.Sys;
using ZNLCRM.Utility.CommonEnum;

namespace ZNLCRM.UI.HR
{
    public partial class frmEditEmp : frmBaseEditForm
    {

        public delegate void dlgRefreshParentForm();
        public event dlgRefreshParentForm RefreshParentForm;
        public int empID = 0;
        public int orgID = 0;
        public int deptID = 0;
        HR_EmployeeLogic empLogic = null;
        HR_OrgLogic orgLogic = null;
        HR_DepartmentLogic deptLogic = null;
        SYS_DictItemLineLogic dictLineLogic = null;
        public frmEditEmp()
        {
            InitializeComponent();
            this.GetEditEntity += new dlgGetEditEntity(Form_GetEditEntity);
            empLogic = new HR_EmployeeLogic(this);
            orgLogic = new HR_OrgLogic(this);
            deptLogic = new HR_DepartmentLogic(this);
            dictLineLogic = new SYS_DictItemLineLogic(this);
        }

        #region 实现基类获取实体信息方法
        object Form_GetEditEntity()
        {
            HR_EmployeeResult info = new HR_EmployeeResult();
            info.EmpID = empID;
            info = this.ConvertControlToEntity<HR_EmployeeResult>(this.grpCo1.Controls, info, null);
            info = this.ConvertControlToEntity<HR_EmployeeResult>(this.grpCo2.Controls, info, null);
            info = this.ConvertControlToEntity<HR_EmployeeResult>(this.grpCo3.Controls, info, null);
            info = this.ConvertControlToEntity<HR_EmployeeResult>(this.tpSysInfo.Controls, info, null);
            this.SetDataIsChanged<HR_EmployeeResult>(info);
            return info;
        }
        #endregion

     

        private void btnSave_Click(object sender, EventArgs e)
        {
            HR_EmployeeResult info = Form_GetEditEntity() as HR_EmployeeResult;
            if (!this.DataIsChanged)
            {
                this.ShowNoChangedMsg();
                return;
            }
            WCFAddUpdateResult result = this.AsyncExecute<WCFAddUpdateResult, HR_EmployeeResult>(info, empLogic.AddOrUpdate, (a) =>
            {
                if (a.Key > 0)
                {
                    txtEmpID.Text = a.Key.ToString();
                    txtEmpGuid.Text = a.KeyGuid.ToString();
                    SetDataIsNoChanged();
                }
            });
        }

        protected void ShowNoChangedMsg()
        {
            this.ShowMessage("数据未做任修改,不允许修改数据!");
        }

        #region 窗体加载
        private void frmEditEmp_Load(object sender, EventArgs e)
        {

            InitData();
            GetEmpInfo();
         
        }
        #endregion

        #region 初始化绑定控件
        public void InitData()
        {
            
            orgLogic.BindComboBox(cboOrgID, new HR_OrgParam() {});
            deptLogic.BindComboBox(cboDeptID, new HR_DepartmentParam() { });
            
            List<HR_EmployeeResult> empList=  empLogic.GetEmpList(new HR_EmployeeParam() { });

            empLogic.BindComboBox(cboManagerEmpID, empList);
            empLogic.BindComboBox(cboLastEditEmpID, empList);
            //empLogic.BindComboBox(cboRelationSales, empList);
            //empLogic.BindComboBox(cboRelationBuyers, empList);
            List<SYS_DictItemLineResult> itemLineList = dictLineLogic.GetListByCode(new SYS_DictItemLineParam
            {
                ItemCodes = new string[] {
                "Probation","Position","EmpStatus" ,"Gender","Nation","Marriage","Education","Professional","Currency","EmpIsActive" }
            });

            dictLineLogic.BindComboBox(cboProbation, "Probation" ,itemLineList );
            dictLineLogic.BindComboBox(cboPositionID,  "Position" , itemLineList);
            dictLineLogic.BindComboBox(cboEmpStatus,  "EmpStatus" , itemLineList);
            dictLineLogic.BindComboBox(cboSex, "Gender" ,itemLineList );
            dictLineLogic.BindComboBox(cboNation, "Nation", itemLineList);
            dictLineLogic.BindComboBox(cboMarriage, "Marriage", itemLineList);
            dictLineLogic.BindComboBox(cboEducation, "Education", itemLineList);
            dictLineLogic.BindComboBox(cboProfessional, "Professional", itemLineList);
            dictLineLogic.BindComboBox(cboDefaultSaleCurreny, "Currency", itemLineList);
            dictLineLogic.BindComboBox(cboDefaultBuyCurreny, "Currency", itemLineList);
            dictLineLogic.BindComboBox(cboIsActive, "EmpIsActive", itemLineList);
            //dictLineLogic.BindComboBox(cboCustStatus, new SYS_DictItemLineParam { ItemCode = "CustStatus" }, pgList.ResultJoinList);
            //dictLineLogic.BindComboBox(cboCustDealType, new SYS_DictItemLineParam { ItemCode = "CustDealType" }, pgList.ResultJoinList);
            //dictLineLogic.BindComboBox(cboClearingForm, new SYS_DictItemLineParam { ItemCode = "ClearingForm" }, pgList.ResultJoinList);
        }
        #endregion

        #region 加载人员信息
        public void GetEmpInfo()
        {
            if(empID>0 && orgID>0 && deptID>0)
            {
                HR_EmployeeParam param = new HR_EmployeeParam();
                param.EmpID =empID;
                param.DeptID = deptID;
                param.OrgID = orgID;
                HR_EmployeeResult info = empLogic.GetInfo(param);
                if (info != null)
                {
                    this.ConvertEntityToControl<HR_EmployeeResult>(this.grpCo1.Controls, info, null);
                    this.ConvertEntityToControl<HR_EmployeeResult>(this.grpCo2.Controls, info, null);
                    this.ConvertEntityToControl<HR_EmployeeResult>(this.grpCo3.Controls, info, null);
                    this.ConvertEntityToControl<HR_EmployeeResult>(this.tpSysInfo.Controls, info, null);
                }

            }
        }
            
            
        #endregion

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtLastSignInDate_Click(object sender, EventArgs e)
        {

        }



    }
}
