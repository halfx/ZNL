using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZNLCRM.Entity.UserModel.PPM;
using ZNLFrame.Entity;
using ZNLCRM.Entity.UserModel.Common;

namespace ZNLCRM.UI.Logic.PPM
{
    public  class ORD_PurchaseReturnLogic:BaseLogic
    {
        public ORD_PurchaseReturnLogic(Form form) : base(form) { }
        public bool SubmitPurchaseReturnBill(ORD_PurchaseReturnParam param)
        {
            bool ret = true;
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.PPM.ORD_PurchaseReturnBLL", "SubmitPurchaseReturnBill", param);
            ret = (rst == null ? false : (bool)rst.Result);
            return ret;
        }
        public bool AuditPurchaseReturnBill(ORD_PurchaseReturnParam param)
        {
            bool ret = true;
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.PPM.ORD_PurchaseReturnBLL", "AuditPurchaseReturnBill", param);
            ret = (rst == null ? false : (bool)rst.Result);
            return ret;
        }

        public WCFAddUpdateResult AddOrUpdate(ORD_PurchaseReturnResult param)
        {
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.PPM.ORD_PurchaseReturnBLL", "AddOrUpdate", param);
            ret = (rst == null ? new WCFAddUpdateResult() : rst.Result as WCFAddUpdateResult);
            return ret;
        }
        public List<ORD_PurchaseReturnResult> GetList(ORD_PurchaseReturnParam param)
        {
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.PPM.ORD_PurchaseReturnBLL", "GetList", param);
            List<ORD_PurchaseReturnResult> list = new List<ORD_PurchaseReturnResult>();
            list = (rst == null ? new List<ORD_PurchaseReturnResult>() : rst.Result as List<ORD_PurchaseReturnResult>);
            return list;
        }
        public ORD_PurchaseReturnResult GetInfo(ORD_PurchaseReturnParam param)
        {
            ORD_PurchaseReturnResult ret = new ORD_PurchaseReturnResult();
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.PPM.ORD_PurchaseReturnBLL", "GetInfo", param);
            ret = rst == null ? new ORD_PurchaseReturnResult() : rst.Result as ORD_PurchaseReturnResult;
            return ret;
        }
        public PageList<ORD_PurchaseReturnResult> GetPageList(ORD_PurchaseReturnParam param)
        {
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.PPM.ORD_PurchaseReturnBLL", "GetPageList", param);
            PageList<ORD_PurchaseReturnResult> pageList = new PageList<ORD_PurchaseReturnResult>();
            pageList = (rst == null ? new PageList<ORD_PurchaseReturnResult>() : rst.Result as PageList<ORD_PurchaseReturnResult>);
            return pageList;
        }

        public WCFAddUpdateResult DelInfo(ORD_PurchaseReturnParam param)
        {
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.PPM.ORD_PurchaseReturnBLL", "DelInfo", param);
            ret = (rst == null ? new WCFAddUpdateResult() : rst.Result as WCFAddUpdateResult);
            return ret;
        }
    }
}
