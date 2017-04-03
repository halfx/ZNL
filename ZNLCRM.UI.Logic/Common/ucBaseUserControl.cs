using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZNLCRM.Controls;
using ZNLCRM.UI.Logic.Sys;
using ZNLFrame.Entity;
using ZNLCRM.Client.Entry;

namespace ZNLCRM.UI.Logic.Common
{
    public partial class ucBaseUserControl : UserControl
    {
        UcInformationBox _infoBox;//消息框
        public ucBaseUserControl()
            : base()
        {
            if (!this.DesignMode) 
            this.Load += new EventHandler(ucBaseUserControl_Load);
        }
        #region 绑定表格用户自定义的设置方法
        GridUserSetting _gridUserSetting = new GridUserSetting();
        void ucBaseUserControl_Load(object sender, EventArgs e)
        {
            if (this.DesignMode) return;
            BindAllGridSetEvent();
            SetFormRight();
        }
        private void BindAllGridSetEvent()
        {
            foreach (Control con in this.Controls)
            {
                if (con.GetType() == typeof(UcDataGridView))
                {
                    _gridUserSetting.BindApplyGridEvent(con as UcDataGridView);
                }
                else
                    BindAllGridSetEvent(con);
            }
        }
        private Control BindAllGridSetEvent(Control control)
        {
            Control ret = new Control();
            foreach (Control con in control.Controls)
            {
                if (con.GetType() == typeof(UcDataGridView))
                {
                    _gridUserSetting.BindApplyGridEvent(con as UcDataGridView);
                }
                else
                    BindAllGridSetEvent(con);
            }
            return ret;
        }
        #endregion
        /// <summary>
        /// 提示信息
        /// </summary>
        /// <param name="message"></param>
        protected void ShowMessage(string message)
        {
            if (string.IsNullOrEmpty(message))
            {
                return;
            }
            if (_infoBox == null)
            {
                _infoBox = new UcInformationBox();
                this.Controls.Add(_infoBox);
            }
            _infoBox.BringToFront();
            _infoBox.ShowMessage(message);
        }
        #region 关于权限控制
        protected void SetFormRight()
        {

        }
        #endregion
        /// <summary>
        /// WCF方法是否运行成功
        /// </summary>
        /// <param name="result">WCF运行结果</param>
        /// <returns>是否成功</returns>
        protected bool IsWcfExeSuccess(ExeResult result)
        {
            bool bRet = true;
            string strErr = WCFBLL.AnalysisExeResult(result);
            if (!string.IsNullOrEmpty(strErr))
            {
                ShowMessage(strErr);
                bRet = false;
            }
            return bRet;
        }
    }
}
