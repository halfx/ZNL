using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZNLCRM.Entity.UserModel.SPM;
using ZNLFrame.Entity;
using ZNLCRM.Entity.UserModel.Common;

namespace ZNLCRM.UI.Logic.SPM
{
    public  class ORD_SalesReturnLogic:BaseLogic
    {
        public ORD_SalesReturnLogic(Form form) : base(form) { }
        public bool SubmitSalesReturnBill(ORD_SalesReturnParam param)
        {
            bool ret = true;
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.SPM.ORD_SalesReturnBLL", "SubmitSalesReturnBill", param);
            ret = (rst == null ? false : (bool)rst.Result);
            return ret;
        }
        public bool AuditSalesReturnBill(ORD_SalesReturnParam param)
        {
            bool ret = true;
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.SPM.ORD_SalesReturnBLL", "AuditSalesReturnBill", param);
            ret = (rst == null ? false : (bool)rst.Result);
            return ret;
        }

        public WCFAddUpdateResult AddOrUpdate(ORD_SalesReturnResult param)
        {
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.SPM.ORD_SalesReturnBLL", "AddOrUpdate", param);
            ret = (rst == null ? new WCFAddUpdateResult() : rst.Result as WCFAddUpdateResult);
            return ret;
        }
        public List<ORD_SalesReturnResult> GetList(ORD_SalesReturnParam param)
        {
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.SPM.ORD_SalesReturnBLL", "GetList", param);
            List<ORD_SalesReturnResult> list = new List<ORD_SalesReturnResult>();
            list = (rst == null ? new List<ORD_SalesReturnResult>() : rst.Result as List<ORD_SalesReturnResult>);
            return list;
        }
        public ORD_SalesReturnResult GetInfo(ORD_SalesReturnParam param)
        {
            ORD_SalesReturnResult ret = new ORD_SalesReturnResult();
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.SPM.ORD_SalesReturnBLL", "GetInfo", param);
            ret = rst == null ? new ORD_SalesReturnResult() : rst.Result as ORD_SalesReturnResult;
            return ret;
        }
        public PageList<ORD_SalesReturnResult> GetPageList(ORD_SalesReturnParam param)
        {
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.SPM.ORD_SalesReturnBLL", "GetPageList", param);
            PageList<ORD_SalesReturnResult> pageList = new PageList<ORD_SalesReturnResult>();
            pageList = (rst == null ? new PageList<ORD_SalesReturnResult>() : rst.Result as PageList<ORD_SalesReturnResult>);
            return pageList;
        }

        public WCFAddUpdateResult DelInfo(ORD_SalesReturnParam param)
        {
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.SPM.ORD_SalesReturnBLL", "DelInfo", param);
            ret = (rst == null ? new WCFAddUpdateResult() : rst.Result as WCFAddUpdateResult);
            return ret;
        }
    }
}
