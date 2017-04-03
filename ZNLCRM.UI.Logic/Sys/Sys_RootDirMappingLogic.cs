using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZNLCRM.Entity.UserModel.Common;
using ZNLCRM.Entity.UserModel.Sys;
using ZNLFrame.Entity;

namespace ZNLCRM.UI.Logic.Sys
{
    public  class Sys_RootDirMappingLogic:BaseLogic
    {
        public Sys_RootDirMappingLogic(Form form): base(form){ }



        public WCFAddUpdateResult AddOrUpdate(Sys_RootDirMappingResult param)
        {
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.Sys.Sys_RootDirMappingBLL", "AddOrUpdate", param);
            ret = (rst == null ? new WCFAddUpdateResult() : rst.Result as WCFAddUpdateResult);
            return ret;
        }

        public Sys_RootDirMappingResult GetInfo(Sys_RootDirMappingParam param)
        {
            Sys_RootDirMappingResult ret = new Sys_RootDirMappingResult();
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.Sys.Sys_RootDirMappingBLL", "GetInfo", param);
            ret = rst == null ? new Sys_RootDirMappingResult() : rst.Result as Sys_RootDirMappingResult;
            return ret;
        }
        public PageList<Sys_RootDirMappingResult> GetPageList(Sys_RootDirMappingParam param)
        {
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.Sys.Sys_RootDirMappingBLL", "GetPageList", param);
            PageList<Sys_RootDirMappingResult> pageList = new PageList<Sys_RootDirMappingResult>();
            pageList = (rst == null ? new PageList<Sys_RootDirMappingResult>() : rst.Result as PageList<Sys_RootDirMappingResult>);
            return pageList;
        }

        public WCFAddUpdateResult DelInfo(Sys_RootDirMappingParam param)
        {
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.Sys.Sys_RootDirMappingBLL", "DelInfo", param);
            ret = (rst == null ? new WCFAddUpdateResult() : rst.Result as WCFAddUpdateResult);
            return ret;
        }
    }
}
