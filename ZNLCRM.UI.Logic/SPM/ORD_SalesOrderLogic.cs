using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZNLCRM.Entity.UserModel.Common;
using ZNLCRM.Entity.UserModel.SPM;
using ZNLFrame.Entity;

namespace ZNLCRM.UI.Logic.SPM
{
    public  class ORD_SalesOrderLogic:BaseLogic
    {
          public ORD_SalesOrderLogic(Form form) : base(form) { }

          public bool SubmitSalesOrderBill(ORD_SalesOrderParam param)
          {
              bool ret = true;
              ExeResult rst = new ExeResult();
              rst = this.Execute("ZNLCRM.BLL.SPM.ORD_SalesOrderBLL", "SubmitSalesOrderBill", param);
              ret = (rst == null ? false : (bool)rst.Result);
              return ret;
          }
          public bool AuditSalesOrderBill(ORD_SalesOrderParam param)
          {
              bool ret = true;
              ExeResult rst = new ExeResult();
              rst = this.Execute("ZNLCRM.BLL.SPM.ORD_SalesOrderBLL", "AuditSalesOrderBill", param);
              ret = (rst == null ? false : (bool)rst.Result);
              return ret;
          }
        
        public WCFAddUpdateResult AddOrUpdate(ORD_SalesOrderResult param)
        {
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.SPM.ORD_SalesOrderBLL", "AddOrUpdate", param);
            ret = (rst == null ? new WCFAddUpdateResult() : rst.Result as WCFAddUpdateResult);
            return ret;
        }

        public ORD_SalesOrderResult GetInfo(ORD_SalesOrderParam param)
        {
            ORD_SalesOrderResult ret = new ORD_SalesOrderResult();
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.SPM.ORD_SalesOrderBLL", "GetInfo", param);
            ret = rst == null ? new ORD_SalesOrderResult() : rst.Result as ORD_SalesOrderResult;
            return ret;
        }
        public PageList<ORD_SalesOrderResult> GetPageList(ORD_SalesOrderParam param)
        {
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.SPM.ORD_SalesOrderBLL", "GetPageList", param);
            PageList<ORD_SalesOrderResult> pageList = new PageList<ORD_SalesOrderResult>();
            pageList = (rst == null ? new PageList<ORD_SalesOrderResult>() : rst.Result as PageList<ORD_SalesOrderResult>);
            return pageList;
        }

        public WCFAddUpdateResult DelInfo(ORD_SalesOrderParam param)
        {
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.SPM.ORD_SalesOrderBLL", "DelInfo", param);
            ret = (rst == null ? new WCFAddUpdateResult() : rst.Result as WCFAddUpdateResult);
            return ret;
        }

       
    }
}
