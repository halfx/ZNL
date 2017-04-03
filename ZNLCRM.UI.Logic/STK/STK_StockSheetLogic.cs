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
    public   class STK_StockSheetLogic:BaseLogic
    {
        public STK_StockSheetLogic(Form form) : base(form) { }
        public List<STK_StockSheetResult> GetList(STK_StockSheetParam param)
        {
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.STK.STK_StockSheetBLL", "GetList", param);
            List<STK_StockSheetResult> list = new List<STK_StockSheetResult>();
            list = (rst == null ? new List<STK_StockSheetResult>() : rst.Result as List<STK_StockSheetResult>);
            return list;
        }
        public PageList<STK_StockSheetResult> GetPageList(STK_StockSheetParam param)
        {
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.STK.STK_StockSheetBLL", "GetPageList", param);
            PageList<STK_StockSheetResult> pageList = new PageList<STK_StockSheetResult>();
            pageList = (rst == null ? new PageList<STK_StockSheetResult>() : rst.Result as PageList<STK_StockSheetResult>);

            return pageList;
        }

        public WCFAddUpdateResult UpdateOrInsertList(List<STK_StockSheetResult> list)
        {

            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.STK.STK_StockSheetBLL", "UpdateOrInsertList", list);
            ret = (rst == null ? new WCFAddUpdateResult() : rst.Result as WCFAddUpdateResult);
            return ret;
        }
        public WCFAddUpdateResult AddOrUpdate(STK_StockSheetResult param)
        {
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.STK.STK_StockSheetBLL", "AddOrUpdate", param);
            ret = (rst == null ? new WCFAddUpdateResult() : rst.Result as WCFAddUpdateResult);
            return ret;
        }

        public STK_StockSheetResult GetInfo(STK_StockSheetParam param)
        {
            STK_StockSheetResult ret = new STK_StockSheetResult();
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.STK.STK_StockSheetBLL", "GetInfo", param);
            ret = (rst == null ? new STK_StockSheetResult() : rst.Result as STK_StockSheetResult);
            return ret;
        }


        public WCFAddUpdateResult DelInfo(STK_StockSheetParam param)
        {
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.STK.STK_StockSheetBLL", "DelInfo", param);
            ret = (rst == null ? new WCFAddUpdateResult() : rst.Result as WCFAddUpdateResult);
            return ret;
        }
    }
}
