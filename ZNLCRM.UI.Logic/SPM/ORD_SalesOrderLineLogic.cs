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
    public  class ORD_SalesOrderLineLogic:BaseLogic
    {
         public ORD_SalesOrderLineLogic(Form form) : base(form) { }

        public ORD_SalesOrderLineResult GetInfo(ORD_SalesOrderLineParam param)
        {
            ORD_SalesOrderLineResult ret = new ORD_SalesOrderLineResult();
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.SPM.ORD_SalesOrderLineBLL", "GetInfo", param);
            ret = rst == null ? new ORD_SalesOrderLineResult() : rst.Result as ORD_SalesOrderLineResult;
            return ret;
        }
        public List<ORD_SalesOrderLineResult> GetList(ORD_SalesOrderLineParam param)
        {
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.SPM.ORD_SalesOrderLineBLL", "GetList", param);
            List<ORD_SalesOrderLineResult> list = new List<ORD_SalesOrderLineResult>();
            list = (rst == null ? new List<ORD_SalesOrderLineResult>() : rst.Result as List<ORD_SalesOrderLineResult>);
            return list;
        }

        public WCFAddUpdateResult DelInfo(ORD_SalesOrderLineParam param)
        {
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.SPM.ORD_SalesOrderLineBLL", "DelInfo", param);
            ret = (rst == null ? new WCFAddUpdateResult() : rst.Result as WCFAddUpdateResult);
            return ret;
        }

        public WCFAddUpdateResult UpdateOrInsertList(List<ORD_SalesOrderLineResult> list)
        {

            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.SPM.ORD_SalesOrderLineBLL", "UpdateOrInsertList", list);
            ret = (rst == null ? new WCFAddUpdateResult() : rst.Result as WCFAddUpdateResult);
            return ret;
        }
    }
}
