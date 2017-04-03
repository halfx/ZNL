using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLCRM.Entity.UserModel.Sys;
using ZNLFrame.Entity;
using ZNLCRM.Utility;
using System.Windows.Forms;

namespace ZNLCRM.UI.Logic.Sys
{
    public class FormLoadLogic:BaseLogic
    {
        public FormLoadLogic(Form form) : base(form) { }
        public FormLoadResult GetFormLoadResult(FormLoadParam param)
        {
            FormLoadResult ret = new FormLoadResult();
            ExeResult rst = new ExeResult();
            if (param.NameSpace.ToStringHasNull().Trim()=="")
            {
                this.ShowMessage("请指定命名空间！");
                return ret;
            }
            rst = this.Execute("ZNLCRM.BLL.Sys.FormLoadBLL", "GetFormLoadResult", param);
            ret = rst == null ? new FormLoadResult() : rst.Result as FormLoadResult;
            return ret;
        }
    }
}
