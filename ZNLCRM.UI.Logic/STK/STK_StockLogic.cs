using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLCRM.Entity.UserModel.STK;
using ZNLFrame.Entity;
using System.Windows.Forms;
using ZNLCRM.Entity.UserModel.Common;

namespace ZNLCRM.UI.Logic.STK
{
    public  class STK_StockLogic:BaseLogic
    {
        public STK_StockLogic(Form form) : base(form) { }
        public List<STK_StockResult> GetList(STK_StockParam param)
        {
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.STK.STK_StockBLL", "GetList", param);
            List<STK_StockResult> list = new List<STK_StockResult>();
            list = (rst == null ? new List<STK_StockResult>() : rst.Result as List<STK_StockResult>);
            return list;
        }
        public PageList<STK_StockResult> GetPageList(STK_StockParam param)
        {
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.STK.STK_StockBLL", "GetPageList", param);
            PageList<STK_StockResult> pageList = new PageList<STK_StockResult>();
            pageList = (rst == null ? new PageList<STK_StockResult>() : rst.Result as PageList<STK_StockResult>);

            return pageList;
        }

        public WCFAddUpdateResult UpdateOrInsertList(List<STK_StockResult> list)
        {

            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.STK.STK_StockBLL", "UpdateOrInsertList", list);
            ret = (rst == null ? new WCFAddUpdateResult() : rst.Result as WCFAddUpdateResult);
            return ret;
        }
        public WCFAddUpdateResult AddOrUpdate(STK_StockResult param)
        {
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.STK.STK_StockBLL", "AddOrUpdate", param);
            ret = (rst == null ? new WCFAddUpdateResult() : rst.Result as WCFAddUpdateResult);
            return ret;
        }

        public STK_StockResult GetInfo(STK_StockParam param)
        {
            STK_StockResult ret = new STK_StockResult();
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.STK.STK_StockBLL", "GetInfo", param);
            ret = (rst == null ? new STK_StockResult() : rst.Result as STK_StockResult);
            return ret;
        }


        public WCFAddUpdateResult DelInfo(STK_StockParam param)
        {
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.STK.STK_StockBLL", "DelInfo", param);
            ret = (rst == null ? new WCFAddUpdateResult() : rst.Result as WCFAddUpdateResult);
            return ret;
        }
    }
}
