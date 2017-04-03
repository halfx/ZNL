using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLCRM.Entity.UserModel.Sys;
using ZNLFrame.Entity;
using ZNLCRM.Client.Entry;
using System.Windows.Forms;
using ZNLCRM.Entity.UserModel.Common;
using System.Data;

namespace ZNLCRM.UI.Logic.Sys
{
    /// <summary>
    /// 员工权限UI业务层
    /// </summary>
    public class Sys_EmpRightLogic : BaseLogic
    {
        public Sys_EmpRightLogic(Form form) : base(form) { }

        public PageList<Sys_EmpRightResult> GetPageList(Sys_EmpRightParam param)
        {
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.Sys.Sys_EmpRightBLL", "GetPageList", param);
            PageList<Sys_EmpRightResult> pageList = (rst == null ? new PageList<Sys_EmpRightResult>() : (PageList<Sys_EmpRightResult>)rst.Result);
            return pageList;
       
        }
        public WCFAddUpdateResult UpdateOrInsertList(List<Sys_EmpRightResult> list)
        {

            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.Sys.Sys_EmpRightBLL", "UpdateOrInsertList", list);
            ret = (rst == null ? new WCFAddUpdateResult() : rst.Result as WCFAddUpdateResult);
            return ret;
        }
    }

}
