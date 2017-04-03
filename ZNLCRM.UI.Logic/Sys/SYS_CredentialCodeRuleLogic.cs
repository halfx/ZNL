using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZNLFrame.Entity;
using ZNLCRM.Entity.UserModel.Sys;
using ZNLCRM.Entity.UserModel.Common;

namespace ZNLCRM.UI.Logic.Sys
{
    public class SYS_CredentialCodeRuleLogic : BaseLogic
    {
        public SYS_CredentialCodeRuleLogic(Form form) : base(form) { }

        public PageList<SYS_CredentialCodeRuleResult> GetPageList(SYS_CredentialCodeRuleParam param)
        {
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.Sys.Sys_CodeRulerBLL", "GetPageList", param);
            PageList<SYS_CredentialCodeRuleResult> pageList = new PageList<SYS_CredentialCodeRuleResult>();
            pageList = (rst == null ? new PageList<SYS_CredentialCodeRuleResult>() : rst.Result as PageList<SYS_CredentialCodeRuleResult>);
            return pageList;
        }
        public SYS_CredentialCodeRuleResult GetInfo(SYS_CredentialCodeRuleParam param)
        {
            SYS_CredentialCodeRuleResult ret = new SYS_CredentialCodeRuleResult();
            ExeResult rst = new ExeResult();
            if (param.RuleID <=0)
            {
                this.ShowMessage("请指定要修改的记录！");
                return ret;
            }
            rst = this.Execute("ZNLCRM.BLL.Sys.Sys_CodeRulerBLL", "GetInfo", param);
            ret = rst == null ? new SYS_CredentialCodeRuleResult() : rst.Result as SYS_CredentialCodeRuleResult;
            return ret;
        }
        public WCFAddUpdateResult AddOrUpdate(SYS_CredentialCodeRuleResult param)
        {
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.Sys.Sys_CodeRulerBLL", "AddOrUpdate", param);
            ret = (rst == null ? new WCFAddUpdateResult() : rst.Result as WCFAddUpdateResult);
            return ret;
        }
        public WCFAddUpdateResult DelInfo(SYS_CredentialCodeRuleParam param)
        {
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            if (param.RuleID <=0)
            {
                this.ShowMessage("请指定要修改的记录！");
                return ret;
            }
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.Sys.Sys_CodeRulerBLL", "DelInfo", param);
            ret = (rst == null ? new WCFAddUpdateResult() : rst.Result as WCFAddUpdateResult);
            return ret;
        }
    }
}
