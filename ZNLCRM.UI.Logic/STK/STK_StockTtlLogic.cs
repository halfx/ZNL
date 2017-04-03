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
    public   class STK_StockTtlLogic:BaseLogic
    {
        public STK_StockTtlLogic(Form form) : base(form) { }
        public List<STK_StockTtlResult> GetList(STK_StockTtlParam param)
        {
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.STK.STK_StockTtlBLL", "GetList", param);
            List<STK_StockTtlResult> list = new List<STK_StockTtlResult>();
            list = (rst == null ? new List<STK_StockTtlResult>() : rst.Result as List<STK_StockTtlResult>);
            return list;
        }

        
         public PageList<STK_StockTtlResult> GetPageListByDetail(STK_StockTtlParam param)
        {
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.STK.STK_StockTtlBLL", "GetPageListByDetail", param);
            PageList<STK_StockTtlResult> pageList = new PageList<STK_StockTtlResult>();
            pageList = (rst == null ? new PageList<STK_StockTtlResult>() : rst.Result as PageList<STK_StockTtlResult>);

            return pageList;
        }
        public PageList<STK_StockTtlResult> GetPageList(STK_StockTtlParam param)
        {
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.STK.STK_StockTtlBLL", "GetPageList", param);
            PageList<STK_StockTtlResult> pageList = new PageList<STK_StockTtlResult>();
            pageList = (rst == null ? new PageList<STK_StockTtlResult>() : rst.Result as PageList<STK_StockTtlResult>);

            return pageList;
        }

        public WCFAddUpdateResult UpdateOrInsertList(List<STK_StockTtlResult> list)
        {

            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.STK.STK_StockTtlBLL", "UpdateOrInsertList", list);
            ret = (rst == null ? new WCFAddUpdateResult() : rst.Result as WCFAddUpdateResult);
            return ret;
        }
        public WCFAddUpdateResult AddOrUpdate(STK_StockTtlResult param)
        {
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.STK.STK_StockTtlBLL", "AddOrUpdate", param);
            ret = (rst == null ? new WCFAddUpdateResult() : rst.Result as WCFAddUpdateResult);
            return ret;
        }

        public STK_StockTtlResult GetInfo(STK_StockTtlParam param)
        {
            STK_StockTtlResult ret = new STK_StockTtlResult();
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.STK.STK_StockTtlBLL", "GetInfo", param);
            ret = (rst == null ? new STK_StockTtlResult() : rst.Result as STK_StockTtlResult);
            return ret;
        }


        public WCFAddUpdateResult DelInfo(STK_StockTtlParam param)
        {
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.STK.STK_StockTtlBLL", "DelInfo", param);
            ret = (rst == null ? new WCFAddUpdateResult() : rst.Result as WCFAddUpdateResult);
            return ret;
        }
    }
}
