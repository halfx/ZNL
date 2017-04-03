using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZNLCRM.Entity.UserModel.CRM;
using ZNLFrame.Entity;
using ZNLCRM.Entity.UserModel.Common;

namespace ZNLCRM.UI.Logic.CRM
{
    public  class CRM_CompanyContactLogic:BaseLogic
    {
        public CRM_CompanyContactLogic(Form form)
            : base(form)
        { }

        public List<CRM_CompanyContactResult> GetList(CRM_CompanyContactParam param)
        {
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.CRM.CRM_CompanyContactBLL", "GetList", param);
            List<CRM_CompanyContactResult> list = new List<CRM_CompanyContactResult>();
            list = (rst == null ? new List<CRM_CompanyContactResult>() : rst.Result as List<CRM_CompanyContactResult>);
            return list;
        }

        public WCFAddUpdateResult AddOrUpdate(CRM_CompanyContactResult param)
        {
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.CRM.CRM_CompanyContactBLL", "AddOrUpdate", param);
            ret = (rst == null ? new WCFAddUpdateResult() : rst.Result as WCFAddUpdateResult);
            return ret;
        }

        public CRM_CompanyContactResult GetInfo(CRM_CompanyContactParam param)
        {
            CRM_CompanyContactResult ret = new CRM_CompanyContactResult();
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.CRM.CRM_CompanyContactBLL", "GetInfo", param);
            ret = rst == null ? new CRM_CompanyContactResult() : rst.Result as CRM_CompanyContactResult;
            return ret;
        }


        public WCFAddUpdateResult DelInfo(CRM_CompanyContactParam param)
        {
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.CRM.CRM_CompanyContactBLL", "DelInfo", param);
            ret = (rst == null ? new WCFAddUpdateResult() : rst.Result as WCFAddUpdateResult);
            return ret;
        }
    }
}
