using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZNLCRM.Entity.UserModel.STK;
using ZNLFrame.Entity;
using ZNLCRM.Entity.UserModel.Common;

namespace ZNLCRM.UI.Logic.STK
{
    public  class STK_InLineLogic:BaseLogic
    {
        public STK_InLineLogic(Form form) : base(form) { }
        public STK_InLineResult GetInfo(STK_InLineParam param)
        {
            STK_InLineResult ret = new STK_InLineResult();
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.STK.STK_InLineBLL", "GetInfo", param);
            ret = rst == null ? new STK_InLineResult() : rst.Result as STK_InLineResult;
            return ret;
        }
        public List<STK_InLineResult> GetList(STK_InLineParam param)
        {
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.STK.STK_InLineBLL", "GetList", param);
            List<STK_InLineResult> list = new List<STK_InLineResult>();
            list = (rst == null ? new List<STK_InLineResult>() : rst.Result as List<STK_InLineResult>);
            return list;
        }

        public WCFAddUpdateResult DelInfo(STK_InLineParam param)
        {
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.STK.STK_InLineBLL", "DelInfo", param);
            ret = (rst == null ? new WCFAddUpdateResult() : rst.Result as WCFAddUpdateResult);
            return ret;
        }
        public PageList<STK_InLineResult> GetPageList(STK_InLineParam param)
        {
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.STK.STK_InLineBLL", "GetPageList", param);
            PageList<STK_InLineResult> pageList = new PageList<STK_InLineResult>();
            pageList = (rst == null ? new PageList<STK_InLineResult>() : rst.Result as PageList<STK_InLineResult>);
            return pageList;
        }
        public WCFAddUpdateResult UpdateOrInsertList(List<STK_InLineResult> list)
        {

            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.STK.STK_InLineBLL", "UpdateOrInsertList", list);
            ret = (rst == null ? new WCFAddUpdateResult() : rst.Result as WCFAddUpdateResult);
            return ret;
        }
    }
}
