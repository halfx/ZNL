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
    public  class ORD_PurchaseOrderLineLogic:BaseLogic
    {
        public ORD_PurchaseOrderLineLogic(Form form) : base(form) { }
 

        public ORD_PurchaseOrderLineResult GetInfo(ORD_PurchaseOrderLineParam param)
        {
            ORD_PurchaseOrderLineResult ret = new ORD_PurchaseOrderLineResult();
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.PPM.ORD_PurchaseOrderLineBLL", "GetInfo", param);
            ret = rst == null ? new ORD_PurchaseOrderLineResult() : rst.Result as ORD_PurchaseOrderLineResult;
            return ret;
        }
        public List<ORD_PurchaseOrderLineResult> GetList(ORD_PurchaseOrderLineParam param)
        {
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.PPM.ORD_PurchaseOrderLineBLL", "GetList", param);
            List<ORD_PurchaseOrderLineResult> list = new List<ORD_PurchaseOrderLineResult>();
            list = (rst == null ? new List<ORD_PurchaseOrderLineResult>() : rst.Result as List<ORD_PurchaseOrderLineResult>);
            return list;
        }

        public WCFAddUpdateResult DelInfo(ORD_PurchaseOrderLineParam param)
        {
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.PPM.ORD_PurchaseOrderLineBLL", "DelInfo", param);
            ret = (rst == null ? new WCFAddUpdateResult() : rst.Result as WCFAddUpdateResult);
            return ret;
        }

        public WCFAddUpdateResult UpdateOrInsertList(List<ORD_PurchaseOrderLineResult> list)
        {

            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.PPM.ORD_PurchaseOrderLineBLL", "UpdateOrInsertList", list);
            ret = (rst == null ? new WCFAddUpdateResult() : rst.Result as WCFAddUpdateResult);
            return ret;
        }
    }
}
