using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZNLCRM.Entity.UserModel.Sys;
using ZNLFrame.Entity;
using ZNLCRM.Entity.UserModel.SPM;
using ZNLCRM.Entity.UserModel.Common;

namespace ZNLCRM.UI.Logic.Sys
{
    public  class Sys_AttachFilesLogic:BaseLogic
    {
        public Sys_AttachFilesLogic(Form form)
            : base(form)
        { 
        
        }
        public List<Sys_AttachFilesResult> UploadAttach(List<Sys_AttachFilesResult> param)
        {
            ExeResult rst = Execute("ZNLCRM.BLL.Sys.Sys_AttachFilesBLL", "UploadAttach", param);
            List<Sys_AttachFilesResult> list = (rst == null ? new List<Sys_AttachFilesResult>() : rst.Result as List<Sys_AttachFilesResult>);
            return list;
        }
        public Sys_AttachFilesResult GetInfo(Sys_AttachFilesParam param)
        {
            Sys_AttachFilesResult ret = new Sys_AttachFilesResult();
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.Sys.Sys_AttachFilesBLL", "GetInfo", param);
            ret = rst == null ? new Sys_AttachFilesResult() : rst.Result as Sys_AttachFilesResult;
            return ret;
        }
        public PageList<Sys_AttachFilesResult> GetPageList(Sys_AttachFilesParam param)
        {
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.Sys.Sys_AttachFilesBLL", "GetPageList", param);
            PageList<Sys_AttachFilesResult> pageList = new PageList<Sys_AttachFilesResult>();
            pageList = (rst == null ? new PageList<Sys_AttachFilesResult>() : rst.Result as PageList<Sys_AttachFilesResult>);
            return pageList;
        }
        public List<Sys_AttachFilesResult> GetList(Sys_AttachFilesParam param)
        {
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.Sys.Sys_AttachFilesBLL", "GetList", param);
            List<Sys_AttachFilesResult> list = new List<Sys_AttachFilesResult>();
            list = (rst == null ? new List<Sys_AttachFilesResult>() : rst.Result as List<Sys_AttachFilesResult>);
            return list;
        }

        public WCFAddUpdateResult DelInfo(Sys_AttachFilesParam param)
        {
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.Sys.Sys_AttachFilesBLL", "DelInfo", param);
            ret = (rst == null ? new WCFAddUpdateResult() : rst.Result as WCFAddUpdateResult);
            return ret;
        }

        public WCFAddUpdateResult UpdateOrInsertList(List<Sys_AttachFilesResult> list)
        {

            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.Sys.Sys_AttachFilesBLL", "UpdateOrInsertList", list);
            ret = (rst == null ? new WCFAddUpdateResult() : rst.Result as WCFAddUpdateResult);
            return ret;
        }
    }
}
