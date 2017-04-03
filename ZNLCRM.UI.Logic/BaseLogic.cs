using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLCRM.Client.Entry;
using ZNLFrame.Entity;
using ZNLCRM.Controls;
using System.Windows.Forms;

namespace ZNLCRM.UI.Logic
{
    public class BaseLogic
    {
        UcInformationBox _infoBox;//消息框
        protected Form _form;
        protected BaseLogic()
        {

        }
        protected BaseLogic(Form form)
        {
            _form = form;
        }
        protected ExeResult Execute(string nameSpaceClassFullName, string methodName, object param)
        {
            ExeResult rst = new ExeResult();
            rst = WCFBLL.Execute(nameSpaceClassFullName, methodName, param);
            string info=AnalysisExeResult(rst);
            if (!string.IsNullOrEmpty(info))
            {
                if (_form != null)
                {
                    Action<string> showMsg = ShowMessage;
                    if(this._form.IsHandleCreated)
                        this._form.Invoke(showMsg, info);
                }
                rst = null;
            }
            return rst;
        }
        public static string AnalysisExeResult(ExeResult result)
        {
            string strRet = string.Empty;
            if (result.Complete == ExeComplete.WarnEx || result.Complete == ExeComplete.ErrorEx)
            {
                strRet = result.Message;
            }
            else if (result.Complete == ExeComplete.AccessDeniedEx)
            {
                strRet = "无权限访问:" + result.Message;
            }
            else if (result.Complete == ExeComplete.LoginEx)
            {
                strRet = "登录出错:" + result.Message;
            }
            return strRet;
        }
        protected DateTime? GetServerTime()
        {
            return ZNLCRM.Client.Entry.WCFBLL.GetServerTime();
        }
        protected void ShowMessage(string message)
        {
            Action<string> showMessage = this.ShowAsyMessage;
            this._form.Invoke(showMessage, message);
        }
        void ShowAsyMessage(string message)
        {
            if (string.IsNullOrEmpty(message))
            {
                return;
            }
            if (_infoBox == null)
            {
                _infoBox = new UcInformationBox();
                _form.Controls.Add(_infoBox);
            }
            _infoBox.BringToFront();
            _infoBox.ShowMessage(message);
        }
    }
}
