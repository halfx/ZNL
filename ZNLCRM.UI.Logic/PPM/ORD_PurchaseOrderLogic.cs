using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZNLCRM.Entity.DBModel;
using ZNLCRM.Entity.UserModel.Common;
using ZNLCRM.Entity.UserModel.PPM;
using ZNLFrame.Entity;

namespace ZNLCRM.UI.Logic.PPM
{
    public  class ORD_PurchaseOrderLogic:BaseLogic
    {
        public ORD_PurchaseOrderLogic(Form form) : base(form) { }
        public bool SubmitPurchaseOrderBill(ORD_PurchaseOrderParam param)
        {
            bool ret = true;
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.PPM.ORD_PurchaseOrderBLL", "SubmitPurchaseOrderBill", param);
            ret = (rst == null ? false : (bool)rst.Result);
            return ret;
        }
        public bool AuditPurchaseOrderBill(ORD_PurchaseOrderParam param)
        {
            bool ret = true;
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.PPM.ORD_PurchaseOrderBLL", "AuditPurchaseOrderBill", param);
            ret = (rst == null ? false : (bool)rst.Result);
            return ret;
        }
        public WCFAddUpdateResult AddOrUpdate(ORD_PurchaseOrderResult param)
        {
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.PPM.ORD_PurchaseOrderBLL", "AddOrUpdate", param);
            ret = (rst == null ? new WCFAddUpdateResult() : rst.Result as WCFAddUpdateResult);
            return ret;
        }

        public ORD_PurchaseOrderResult GetInfo(ORD_PurchaseOrderParam param)
        {
            ORD_PurchaseOrderResult ret = new ORD_PurchaseOrderResult();
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.PPM.ORD_PurchaseOrderBLL", "GetInfo", param);
            ret = (rst == null ? new ORD_PurchaseOrderResult() : rst.Result as ORD_PurchaseOrderResult);
            return ret;
        }

        public PageList<ORD_PurchaseOrderResult> GetPageList(ORD_PurchaseOrderParam param)
        {
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.PPM.ORD_PurchaseOrderBLL", "GetPageList", param);
            PageList<ORD_PurchaseOrderResult> pageList = new PageList<ORD_PurchaseOrderResult>();
            pageList = (rst == null ? new PageList<ORD_PurchaseOrderResult>() : rst.Result as PageList<ORD_PurchaseOrderResult>);
            
            return pageList;
        }

        #region 获取彩购订单明细分页数据
        /// <summary>
        /// 获取彩购订单明细分页数据 - 2015/03/10  W:LHQ
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public PageList<ORD_PurchaseOrderResult> GetDtlPageList(ORD_PurchaseOrderParam param)
        {
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.PPM.ORD_PurchaseOrderBLL", "GetDtlPageList", param);
            PageList<ORD_PurchaseOrderResult> pageList = new PageList<ORD_PurchaseOrderResult>();
            pageList = (rst == null ? new PageList<ORD_PurchaseOrderResult>() : rst.Result as PageList<ORD_PurchaseOrderResult>);
            return pageList;
        } 
        #endregion

        public WCFAddUpdateResult DelInfo(ORD_PurchaseOrderParam param)
        {
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.PPM.ORD_PurchaseOrderBLL", "DelInfo", param);
            ret = (rst == null ? new WCFAddUpdateResult() : rst.Result as WCFAddUpdateResult);
            return ret;
        }

        public WCFAddUpdateResult UpdateCancelFlag(ORD_PurchaseOrderResult param)
        {
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.PPM.ORD_PurchaseOrderBLL", "UpdateCancelFlag", param);
            ret = (rst == null ? new WCFAddUpdateResult() : rst.Result as WCFAddUpdateResult);
            return ret;
        }

        public List<ORD_PurchaseOrderLineResult> GetLastHisstoryPrice(ORD_PurchaseOrderParam param)
        {
            List<ORD_PurchaseOrderLineResult> ret = new List<ORD_PurchaseOrderLineResult>();
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.PPM.ORD_PurchaseOrderBLL", "GetLastHisstoryPrice", param);
            ret = (rst == null ? new List<ORD_PurchaseOrderLineResult>() : rst.Result as List<ORD_PurchaseOrderLineResult>);
            return ret;
        }
    }
}
