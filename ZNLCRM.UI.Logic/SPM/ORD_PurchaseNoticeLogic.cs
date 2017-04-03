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
    public  class ORD_PurchaseNoticeLogic:BaseLogic
    {
        public ORD_PurchaseNoticeLogic(Form form) : base(form) { }
        public bool CancelPurchaseNotice(ORD_PurchaseNoticeParam param)
        {
            bool flag = true;
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.SPM.ORD_PurchaseNoticeBLL", "CancelPurchaseNotice", param);
            flag = rst == null ? false : (bool)rst.Result;
            return flag;
        }
        public ORD_PurchaseNoticeResult GetInfo(ORD_PurchaseNoticeParam param)
        {
            ORD_PurchaseNoticeResult ret = new ORD_PurchaseNoticeResult();
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.SPM.ORD_PurchaseNoticeBLL", "GetInfo", param);
            ret = rst == null ? new ORD_PurchaseNoticeResult() : rst.Result as ORD_PurchaseNoticeResult;
            return ret;
        }

        public PageList<ORD_PurchaseNoticeResult> GetPageList(ORD_PurchaseNoticeParam param)
        {
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.SPM.ORD_PurchaseNoticeBLL", "GetPageList", param);
            PageList<ORD_PurchaseNoticeResult> pglist = new PageList<ORD_PurchaseNoticeResult>();
            pglist = (rst == null ? new PageList<ORD_PurchaseNoticeResult>() : rst.Result as PageList<ORD_PurchaseNoticeResult>);
            return pglist;
        }
        public List<ORD_PurchaseNoticeResult> GetList(ORD_PurchaseNoticeParam param)
        {
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.SPM.ORD_PurchaseNoticeBLL", "GetList", param);
            List<ORD_PurchaseNoticeResult> list = new List<ORD_PurchaseNoticeResult>();
            list = (rst == null ? new List<ORD_PurchaseNoticeResult>() : rst.Result as List<ORD_PurchaseNoticeResult>);
            return list;
        }

        public WCFAddUpdateResult DelInfo(ORD_PurchaseNoticeParam param)
        {
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.SPM.ORD_PurchaseNoticeBLL", "DelInfo", param);
            ret = (rst == null ? new WCFAddUpdateResult() : rst.Result as WCFAddUpdateResult);
            return ret;
        }

        public WCFAddUpdateResult UpdateOrInsertList(List<ORD_PurchaseNoticeResult> list)
        {

            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.SPM.ORD_PurchaseNoticeBLL", "UpdateOrInsertList", list);
            ret = (rst == null ? new WCFAddUpdateResult() : rst.Result as WCFAddUpdateResult);
            return ret;
        }
    }
}
