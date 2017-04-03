using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZNLCRM.Entity.UserModel.Common;
using ZNLFrame.Entity;
using ZNLCRM.Entity.UserModel.Sys;
using System.Data;
using ZNLCRM.Utility;

namespace ZNLCRM.UI.Logic.Sys
{
    public  class SYS_DictItemLogic:BaseLogic
    {
         public SYS_DictItemLogic(Form form) : base(form) { }

        
         
         public Dictionary<string, int> GetDictGroup(SYS_DictItemParam param)
         {
             ExeResult rst = new ExeResult();
             rst = this.Execute("ZNLCRM.BLL.Sys.SYS_DictItemBLL", "GetDictGroup", param);
             Dictionary<string, int> dic = new Dictionary<string, int>();
             dic = (rst == null ? new Dictionary<string, int>() : rst.Result as Dictionary<string, int>);
             return dic;
         
         }

         public List<SYS_DictItemResult> GetList(SYS_DictItemParam param)
         {
             ExeResult rst = new ExeResult();
             rst = this.Execute("ZNLCRM.BLL.Sys.SYS_DictItemBLL", "GetList", param);
             List<SYS_DictItemResult> list = new List<SYS_DictItemResult>();
             list = (rst == null ? new List<SYS_DictItemResult>() : rst.Result as List<SYS_DictItemResult>);
             return list;
         }

        public WCFAddUpdateResult AddOrUpdate(SYS_DictItemResult param)
        {
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.Sys.SYS_DictItemBLL", "AddOrUpdate", param);
            ret = (rst == null ? new WCFAddUpdateResult() : rst.Result as WCFAddUpdateResult);
            return ret;
        }

        public SYS_DictItemResult GetInfo(SYS_DictItemParam param)
        {
            SYS_DictItemResult ret = new SYS_DictItemResult();
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.Sys.SYS_DictItemBLL", "GetInfo", param);
            ret = rst == null ? new SYS_DictItemResult() : rst.Result as SYS_DictItemResult;
            return ret;
        }
     
 
        public WCFAddUpdateResult DelInfo(SYS_DictItemParam param)
        {
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.Sys.SYS_DictItemBLL", "DelInfo", param);
            ret = (rst == null ? new WCFAddUpdateResult() : rst.Result as WCFAddUpdateResult);
            return ret;
        }
    }
}
