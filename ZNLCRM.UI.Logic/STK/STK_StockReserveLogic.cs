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
    public   class STK_StockReserveLogic:BaseLogic
    {
        public STK_StockReserveLogic(Form form) : base(form) { }
        public List<STK_StockReserveResult> GetList(STK_StockReserveParam param)
        {
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.STK.STK_StockReserveBLL", "GetList", param);
            List<STK_StockReserveResult> list = new List<STK_StockReserveResult>();
            list = (rst == null ? new List<STK_StockReserveResult>() : rst.Result as List<STK_StockReserveResult>);
            return list;
        }
        public PageList<STK_StockReserveResult> GetPageList(STK_StockReserveParam param)
        {
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.STK.STK_StockReserveBLL", "GetPageList", param);
            PageList<STK_StockReserveResult> pageList = new PageList<STK_StockReserveResult>();
            pageList = (rst == null ? new PageList<STK_StockReserveResult>() : rst.Result as PageList<STK_StockReserveResult>);

            return pageList;
        }
        public bool OperateReserveList(List<STK_StockReserveResult> resultList)
        {
            bool flag = false;
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.STK.STK_StockReserveBLL", "OperateReserveList", resultList);
            flag = (rst == null ? true : (bool)rst.Result);
            return flag;
        
        }
        public bool OperateReserve(STK_StockReserveResult result)
        {
            bool flag = false;
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.STK.STK_StockReserveBLL", "OperateReserve", result);
            flag = (rst == null ? true : (bool)rst.Result);
            return flag;
        }
        public WCFAddUpdateResult UpdateOrInsertList(List<STK_StockReserveResult> list)
        {

            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.STK.STK_StockReserveBLL", "UpdateOrInsertList", list);
            ret = (rst == null ? new WCFAddUpdateResult() : rst.Result as WCFAddUpdateResult);
            return ret;
        }
        public WCFAddUpdateResult AddOrUpdate(STK_StockReserveResult param)
        {
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.STK.STK_StockReserveBLL", "AddOrUpdate", param);
            ret = (rst == null ? new WCFAddUpdateResult() : rst.Result as WCFAddUpdateResult);
            return ret;
        }

        public STK_StockReserveResult GetInfo(STK_StockReserveParam param)
        {
            STK_StockReserveResult ret = new STK_StockReserveResult();
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.STK.STK_StockReserveBLL", "GetInfo", param);
            ret = (rst == null ? new STK_StockReserveResult() : rst.Result as STK_StockReserveResult);
            return ret;
        }


        public WCFAddUpdateResult DelInfo(STK_StockReserveParam param)
        {
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.STK.STK_StockReserveBLL", "DelInfo", param);
            ret = (rst == null ? new WCFAddUpdateResult() : rst.Result as WCFAddUpdateResult);
            return ret;
        }
    }
}
