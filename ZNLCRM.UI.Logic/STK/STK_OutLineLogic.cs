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
    public  class STK_OutLineLogic:BaseLogic
    {
        public STK_OutLineLogic(Form form) : base(form) { }
        public STK_OutLineResult GetInfo(STK_OutLineParam param)
        {
            STK_OutLineResult ret = new STK_OutLineResult();
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.STK.STK_OutLineBLL", "GetInfo", param);
            ret = rst == null ? new STK_OutLineResult() : rst.Result as STK_OutLineResult;
            return ret;
        }
        public List<STK_OutLineResult> GetList(STK_OutLineParam param)
        {
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.STK.STK_OutLineBLL", "GetList", param);
            List<STK_OutLineResult> list = new List<STK_OutLineResult>();
            list = (rst == null ? new List<STK_OutLineResult>() : rst.Result as List<STK_OutLineResult>);
            return list;
        }
        public PageList<STK_OutLineResult> GetPageList(STK_OutLineParam param)
        {
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.STK.STK_OutLineBLL", "GetPageList", param);
            PageList<STK_OutLineResult> pageList = new PageList<STK_OutLineResult>();
            pageList = (rst == null ? new PageList<STK_OutLineResult>() : rst.Result as PageList<STK_OutLineResult>);
            return pageList;
        }
        public WCFAddUpdateResult DelInfo(STK_OutLineParam param)
        {
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.STK.STK_OutLineBLL", "DelInfo", param);
            ret = (rst == null ? new WCFAddUpdateResult() : rst.Result as WCFAddUpdateResult);
            return ret;
        }

        public WCFAddUpdateResult UpdateOrInsertList(List<STK_OutLineResult> list)
        {

            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.STK.STK_OutLineBLL", "UpdateOrInsertList", list);
            ret = (rst == null ? new WCFAddUpdateResult() : rst.Result as WCFAddUpdateResult);
            return ret;
        }
    }
}
