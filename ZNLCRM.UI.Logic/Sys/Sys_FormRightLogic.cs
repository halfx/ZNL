using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZNLCRM.Entity.UserModel.Sys;
using ZNLFrame.Entity;
using ZNLCRM.Entity.UserModel.Common;

namespace ZNLCRM.UI.Logic.Sys
{
    public class Sys_FormRightLogic : BaseLogic
    {
        public Sys_FormRightLogic(Form form) : base(form) { }

        public PageList<Sys_FormRightResult> GetPageList(Sys_FormRightParam param)
        {
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.Sys.Sys_FormRightBLL", "GetPageList", param);
            PageList<Sys_FormRightResult> pageList = new PageList<Sys_FormRightResult>();
            pageList = (rst == null ? new PageList<Sys_FormRightResult>() : rst.Result as PageList<Sys_FormRightResult>);
            return pageList;
        }
        public List<Sys_FormRightResult> GetRightTree(Sys_FormRightParam param)
        {
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.Sys.Sys_FormRightBLL", "GetRightTree", param);
            List<Sys_FormRightResult> pageList = new List<Sys_FormRightResult>();
            pageList = (rst == null ? new List<Sys_FormRightResult>() : rst.Result as List<Sys_FormRightResult>);
            return pageList;
        }
        public Sys_FormRightResult GetInfo(Sys_FormRightParam param)
        {
            Sys_FormRightResult ret = new Sys_FormRightResult();
            ExeResult rst = new ExeResult();
            if (param.FormRightID <= 0)
            {
                this.ShowMessage("请指定要修改的记录！");
                return ret;
            }
            rst = this.Execute("ZNLCRM.BLL.Sys.Sys_FormRightBLL", "GetInfo", param);
            ret = rst == null ? new Sys_FormRightResult() : rst.Result as Sys_FormRightResult;
            return ret;
        }
        public WCFAddUpdateResult AddOrUpdate(Sys_FormRightResult param)
        {
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.Sys.Sys_FormRightBLL", "AddOrUpdate", param);
            ret = (rst == null ? new WCFAddUpdateResult() : rst.Result as WCFAddUpdateResult);
            return ret;
        }
        public WCFAddUpdateResult DelInfo(Sys_FormRightParam param)
        {
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            if (param.FormRightID <= 0)
            {
                this.ShowMessage("请指定要修改的记录！");
                return ret;
            }
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.Sys.Sys_FormRightBLL", "DelInfo", param);
            ret = (rst == null ? new WCFAddUpdateResult() : rst.Result as WCFAddUpdateResult);
            return ret;
        }
    }
}
