using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLCRM.Entity.UserModel.Sys;

namespace ZNLCRM.BLL.Sys
{
    /// <summary>
    /// 此类为窗体初始化加载时需要调用的方法
    /// </summary>
    public class FormLoadBLL:BaseBLL
    {
        public FormLoadResult GetFormLoadResult(FormLoadParam param)
        {
            FormLoadResult ret = new FormLoadResult();
            Sys_FormRightBLL formBll = new Sys_FormRightBLL();
            formBll.SessionInfo = this.SessionInfo;
            List<Sys_FormRightResult> formRightList = new List<Sys_FormRightResult>();
            formRightList = formBll.GetEmpWindowRight(new Sys_FormRightParam() { NameSpace = param.NameSpace, FormEngName = param.FormName });
            ret.FormRightList = formRightList;
            return ret;
        }
    }
}
