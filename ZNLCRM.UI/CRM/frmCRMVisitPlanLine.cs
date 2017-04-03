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
using ZNLCRM.UI.Logic.CRM;
using ZNLCRM.Utility;
using ZNLCRM.Entity.UserModel.Common;
using ZNLCRM.UI.HR;
using ZNLCRM.Entity.UserModel.HR;

namespace ZNLCRM.UI.CRM
{
    public partial class frmCRMVisitPlanLine : frmBaseEditForm
    {
        public Guid? custVstPlnGuID;
        public int custVstPlnLineID=0;
        Guid? companyGuID;
        CRM_VisitPlanLogic planLogic = null;
        CRM_VisitPlanLineLogic planLineLogic = null;
        CRM_CompanyLogic companyLogic = null;
        public frmCRMVisitPlanLine()
        {
            InitializeComponent();
            this.GetEditEntity += new dlgGetEditEntity(Form_GetEditEntity);
            planLogic = new CRM_VisitPlanLogic(this);
            planLineLogic = new CRM_VisitPlanLineLogic(this);
            companyLogic = new CRM_CompanyLogic(this);

        }

        #region 实现基类获取实体信息方法
        object Form_GetEditEntity()
        {
            CRM_VisitPlanLineResult info = new CRM_VisitPlanLineResult();
            info.CustVstPlnLineID = custVstPlnLineID;
            info = this.ConvertControlToEntity<CRM_VisitPlanLineResult>(this.grpVisitPlan.Controls, info, null);
            info = this.ConvertControlToEntity<CRM_VisitPlanLineResult>(this.grpVisitResult.Controls, info, null);
            info.VstText= txtLineVstText.BodyInnerHTML;
            this.SetDataIsChanged<CRM_VisitPlanLineResult>(info);
            return info;
        }
        #endregion

        #region 初始化绑定控件
        public void BindComboBox()
        {
            List<KeyValuePair<string, string>> kvList = new List<KeyValuePair<string, string>>();
            kvList.Insert(0, new KeyValuePair<string, string>("", ""));
            kvList.Add(new KeyValuePair<string, string>("上门拜访", "上门拜访"));
            cboVstTyp.DataSource = kvList;
            cboVstTyp.DisplayMember = "Key";
            cboVstTyp.ValueMember = "Value";


        }
        #endregion
        public void InitData()
        {

            if (custVstPlnGuID != Guid.Empty)
            { 
                CRM_VisitPlanResult planInfo=planLogic.GetInfo(new CRM_VisitPlanParam{CustVstPlnGuID=custVstPlnGuID});
                this.ConvertEntityToControl<CRM_VisitPlanResult>(this.grpVisitPlan.Controls, planInfo, null);
                this.ConvertEntityToControl<CRM_VisitPlanResult>(this.grpVisitResult.Controls, planInfo, null);
                companyGuID = planInfo.CompanyGuID;
                
            }
            if (custVstPlnLineID > 0)
            {
                CRM_VisitPlanLineResult planLineInfo = planLineLogic.GetInfo(new CRM_VisitPlanLineParam { CustVstPlnLineID = custVstPlnLineID });
                this.ConvertEntityToControl<CRM_VisitPlanLineResult>(this.grpVisitResult.Controls, planLineInfo, null);
                txtLineVstText.BodyInnerHTML = planLineInfo.VstText;
                companyGuID = planLineInfo.CompanyGuID;
            }
            else
            {
                txtRptEmpName.Text = this.SessionInfo.UserName;
                txtRptEmpID.Text = this.SessionInfo.UserID.ToStringHasNull();
                txtVstDate.Text = ZNLCRM.UI.Logic.Sys.Common.GetServerNow();
                txtVstName.Text = txtPlanName.Text;
            }
            if (companyGuID != Guid.Empty)
            {
                CRM_CompanyResult companyInfo= companyLogic.GetCustInfo(new CRM_CompanyParam { CompanyGuID = companyGuID });
                this.ConvertEntityToControl<CRM_CompanyResult>(this.grpVisitResult.Controls, companyInfo, null);
            }
        }
        private void frmCRMVisitPlanLine_Load(object sender, EventArgs e)
        {
            BindComboBox();
            InitData();
        }

        #region 保存拜访结果
        private void btnSave_Click(object sender, EventArgs e)
        {
            CRM_VisitPlanLineResult info = Form_GetEditEntity() as CRM_VisitPlanLineResult;

            if (!this.DataIsChanged)
            {
                this.ShowNoChangedMsg();
                return;
            }
            WCFAddUpdateResult result = this.AsyncExecute<WCFAddUpdateResult, CRM_VisitPlanLineResult>(info, planLineLogic.AddOrUpdate, (a) =>
            {
                if (a.Key > 0)
                {
                    custVstPlnLineID = a.Key;
                    this.SetDataIsNoChanged();
                    InitData();
                }
            });
        }
        #endregion

        private void txtRptEmpName_ButtonCustomClick(object sender, EventArgs e)
        {
            frmSelectEmp frmSelectEmp = new frmSelectEmp(false);
            frmSelectEmp.empIds = txtRptEmpID.Text.Split(',').Select(a => (int?)a.ToInt32()).ToArray();

            DialogResult rst = frmSelectEmp.ShowDialog();
            if (rst == DialogResult.OK)
            {
                List<HR_EmployeeResult> rstList = frmSelectEmp.GetSelectList<HR_EmployeeResult>();
                if (rstList != null && rstList.Count > 0)
                {
                    txtRptEmpID.Text = string.Join(",", rstList.Select(a => a.EmpID).ToArray());
                    txtRptEmpName.Text = string.Join(",", rstList.Select(a => a.EmpName).ToArray());
                }

            }
        }


    }
}
