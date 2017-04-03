using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZNLCRM.UI.Logic.Common;
using ZNLCRM.Utility;
using ZNLCRM.Entity.UserModel.HR;
using ZNLCRM.Client.Entry;
using System.Threading.Tasks;
using ZNLFrame.Entity;
using ZNLCRM.Entity.UserModel.Account;
using ZNLCRM.UI.Logic.Account;
using ZNLCRM.Entity.UserModel.Common;
using ZNLCRM.UI.Logic.Sys;
using System.Threading;

namespace ZNLCRM.UI
{
    public partial class frmLogin :Form// frmBaseForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        #region 帐号记住勾选
        private void ReadAccount()
        {
            try
            {
                string compannyName = ManagerAppConfig.GetAppConfig("CompannyName");
                if (!string.IsNullOrEmpty(compannyName))
                {
                    txtCompanyName.Text = compannyName;
                    this.chkRemCompanyName.Checked = true;
                }

                string needRemember = ManagerAppConfig.GetAppConfig("RememberAccountOrPassword");
                if (string.IsNullOrEmpty(needRemember) || needRemember.ToUpper() != "Y")
                {
                    this.chkRemUserName.Checked = false;
                }
                else
                {
                    chkRemUserName.Checked = true;
                    string empCode = ManagerAppConfig.GetAppConfig("EmpCode");
                    if (!string.IsNullOrEmpty(empCode))
                    {
                        txtUserName.Text = EncrypHandler.Decrypto(empCode);
                    }

                    string pwd = ManagerAppConfig.GetAppConfig("Pwd");
                    if (!string.IsNullOrEmpty(pwd))
                    {
                        this.chkRemUserPwd.Text = EncrypHandler.Decrypto(pwd);
                    }
                }
            }
            catch
            {

            }
        }
        private void SaveAccount(SYS_UserAccountParam param)
        {
            if (this.chkRemCompanyName.Checked)
            {
                ManagerAppConfig.UpdateAppConfig("CompannyName", param.CompanyName);
            }
            else
            {
                ManagerAppConfig.UpdateAppConfig("CompannyName", "");
            }
            if (this.chkRemUserName.Checked)
            {
                ManagerAppConfig.UpdateAppConfig("EmpCode", EncrypHandler.Encrypto(param.UserName));
            }
            else
            {
                ManagerAppConfig.UpdateAppConfig("EmpCode", "");
            }
            if (this.chkRemUserPwd.Checked)
            {
                ManagerAppConfig.UpdateAppConfig("Pwd", EncrypHandler.Encrypto(param.PWD));
            }
            else
            {
                ManagerAppConfig.UpdateAppConfig("Pwd", "");
            }
        }
        #endregion
        #region 提示信息
        private void ShowLoginError(string error)
        {
            ShowWaitProgress(false);
            MessageBox.Show(error, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void ShowWaitProgress(bool displayed = true)
        {
            if (displayed)
            {
                pWaiting.BringToFront();
                pWaiting.Visible = true;
                btnLogin.Enabled = false;
                ShowCirular(displayed);
            }
            else
            {
                pWaiting.Text = string.Empty;
                pWaiting.Visible = false;
                btnLogin.Enabled = true;
                crpWaiting.Visible = false;
                ShowCirular(displayed);
            }
        }
        System.Threading.Timer _timerCirular;
        void ShowCirular(bool disapay = true)
        {
            if (disapay)
            {
                if (_timerCirular == null)
                {
                    _timerCirular = new System.Threading.Timer(new TimerCallback(timerCallBack), this, 0, 50);
                }
            }
            else
            {
                if (_timerCirular != null)
                {
                    _timerCirular.Dispose();
                    _timerCirular = null;
                }
            }
        }
        void timerCallBack(object obj)
        {
            if (this.crpWaiting.Value <= 100) this.crpWaiting.Value++;
            else this.crpWaiting.Value = 0;
        }
        #endregion
        #region 登录验证,验证公恒
        private SYS_UserAccountParam GetValidAccount()
        {
            string companyName = txtCompanyName.Text;
            if (companyName.Trim().Length == 0)
            {
                ShowLoginError("请输入公司名称！");
                return null;
            }

            string userName = txtUserName.Text;
            if (userName.Trim().Length == 0)
            {
                ShowLoginError("请输入用户名称！");
                return null;
            }

            string password = this.txtUserPwd.Text;
            if (password.Length == 0)
            {
                ShowLoginError("请输入用户密码！");
                return null;
            }

            var param = new SYS_UserAccountParam();
            param.CompanyName = companyName;
            param.UserName = userName;
            param.PWD = password;
            return param;
        }
        private void Login()
        {
            var param = GetValidAccount();
            if (param == null)
                return;

            SaveAccount(param);
            param.PWD = StringExt.MD5(param.PWD);
            param.Account = param.UserName;
            #region 登录验证
            ShowWaitProgress();
            Task.Factory
                .StartNew<ExeResult>(_ => CheckCompanyBegin((SYS_UserAccountParam)_), param)
                .Done(exeResult =>
                {
                    if (CheckCompanyEnd(exeResult))
                    {
                        ThreadPool.QueueUserWorkItem(_ =>
                        {
                            var result = CheckLoginBegin((SYS_UserAccountParam)_);
                            BeginInvoke(new Action<ExeResult>(CheckLoginEnd), result);
                        }, param);
                    }
                });
            #endregion
        }
        private ExeResult CheckCompanyBegin(SYS_UserAccountParam param)
        {
            return new UserLogic()
                .GetChargeRecord(new SYS_CompanyInfoParam { CompanyName = param.CompanyName });
        }
        private bool CheckCompanyEnd(ExeResult exeResult)
        {

            if (exeResult.Complete == ExeComplete.WarnEx)
            {
                ShowLoginError(exeResult.Message);
                return false;
            }
            else if (exeResult.Complete != ExeComplete.Succeed)
            {
                ShowLoginError("验证失败,可能是网络繁忙,请稍侯再试！");
                return false;
            }
            EnsureCompanyType((SYS_ChargeRecordResult)exeResult.Result);
            return true;
        }
        private void EnsureCompanyType(SYS_ChargeRecordResult charge)
        {
            //判断当前用户是什么类型用户
            if (charge == null || charge.ChargeEndTime == null)
            {
                MySession.MemberType = (int)ZNLCRM.Utility.CommonEnum.MemberType.Free; //标志为免费用户
                return;
            }

            var remanSpan = charge.ChargeEndTime.Value.ToString("yyyy-MM-dd").ToDateTime() -
                            WCFBLL.GetServerTime().Value.ToString("yyyy-MM-dd").ToDateTime();
            MySession.RemainDays = remanSpan.Days;
            if (remanSpan.Days < 0)
            {
                MySession.MemberType = (int)ZNLCRM.Utility.CommonEnum.MemberType.Free; //标志为免费用户
            }
            else if (charge.ChargeType == 5)
            {
                MySession.MemberType = (int)ZNLCRM.Utility.CommonEnum.MemberType.Trialed; //试用用户
            }
            else
            {
                MySession.MemberType = (int)ZNLCRM.Utility.CommonEnum.MemberType.Paied; //收费用户
            }
        }
        #endregion
        #region 验证登录帐号
        private ExeResult CheckLoginBegin(SYS_UserAccountParam param)
        {
            return new UserLogic().UserLogin(param);
        }

        private void CheckLoginEnd(ExeResult ret)
        {
            if (ret.Complete == ExeComplete.WarnEx)
            {
                ShowLoginError(ret.Message);
            }
            else if (ret.Complete != ExeComplete.Succeed)
            {
                ShowLoginError("登录发生异常，请尝试重新登录！");
            }
            else
            {
                pWaiting.Text = "登录成功！正在加载数据,请稍等...";
                var account = (SYS_UserAccountResult)ret.Result;
                Task.Factory
                    .StartNew(_ =>
                   {
                       InitSession((SYS_UserAccountResult)_);
                       new SYS_ManageLogic().InitGlobalVars();
                   }, account)
                   .Done(x => LoadMainForm());
            }
        }
        private void InitSession(SYS_UserAccountResult account)
        {
            MySession.CompanyID = account.GCompanyID;
            MySession.UserID = account.UserID;
            MySession.UserName = account.EmpName;
            MySession.UserAccount = account.Account;
            MySession.UserGUID = account.UserGUID;
            MySession.SaleCurrency = account.SaleCurrency;
            MySession.BuyCurrency = account.BuyCurrency;
            MySession.OrgID = account.OrgID.ToInt32();
            MySession.DeptID = account.DeptID.ToInt32();
            MySession.OrgName = account.OrgName;
            MySession.DeptName = account.DeptName;
        }
        private void LoadMainForm()
        {
            var fMain = new frmMain();
            Owner = fMain;
            fMain.LogOut = Logout;
            Hide();
            fMain.Show();
        }
        private void Logout()
        {
            this.txtUserPwd.Text = string.Empty;
            Owner = null;
            ShowWaitProgress(false);
            Show();
        }
        #endregion
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            MySession.CompanyID = null;
            MySession.UserID = 0;
            MySession.UserName = "";

            ReadAccount();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
