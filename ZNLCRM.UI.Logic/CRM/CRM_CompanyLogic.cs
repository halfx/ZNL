using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZNLFrame.Entity;
using ZNLCRM.Entity.UserModel.CRM;
using ZNLCRM.Entity.UserModel.Common;

namespace ZNLCRM.UI.Logic.CRM
{
    public  class CRM_CompanyLogic:BaseLogic
    {
        public CRM_CompanyLogic(Form form) : base(form) { }



        #region 客户相关方法
        public PageList<CRM_CompanyResult> GetCustPageList(CRM_CompanyParam param)
        {
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.CRM.CRM_CompanyBLL", "GetCustPageList", param);
            PageList<CRM_CompanyResult> list = new PageList<CRM_CompanyResult>();
            list = (rst == null ? new PageList<CRM_CompanyResult>() : rst.Result as PageList<CRM_CompanyResult>);
            return list;
        }

        public List<CRM_CompanyResult> GetCustList(CRM_CompanyParam param)
         {
             ExeResult rst = new ExeResult();
             rst = this.Execute("ZNLCRM.BLL.CRM.CRM_CompanyBLL", "GetCustList", param);
             List<CRM_CompanyResult> list = new List<CRM_CompanyResult>();
             list = (rst == null ? new List<CRM_CompanyResult>() : rst.Result as List<CRM_CompanyResult>);
             return list;
         }

        public WCFAddUpdateResult AddOrUpdateCust(CRM_CompanyResult param)
        {
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.CRM.CRM_CompanyBLL", "AddOrUpdateCust", param);
            ret = (rst == null ? new WCFAddUpdateResult() : rst.Result as WCFAddUpdateResult);
            return ret;
        }

        public CRM_CompanyResult GetCustInfo(CRM_CompanyParam param)
        {
            CRM_CompanyResult ret = new CRM_CompanyResult();
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.CRM.CRM_CompanyBLL", "GetCustInfo", param);
            ret = rst == null ? new CRM_CompanyResult() : rst.Result as CRM_CompanyResult;
            return ret;
        }
 
        public WCFAddUpdateResult DelCustInfo(CRM_CompanyParam param)
        {
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.CRM.CRM_CompanyBLL", "DelCustInfo", param);
            ret = (rst == null ? new WCFAddUpdateResult() : rst.Result as WCFAddUpdateResult);
            return ret;
        }

        #endregion

        #region 供应商相关方法

        public PageList<CRM_CompanyResult> GetSupPageList(CRM_CompanyParam param){

            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.CRM.CRM_CompanyBLL", "GetSupPageList", param);
            PageList<CRM_CompanyResult> list = new PageList<CRM_CompanyResult>();
            list = (rst == null ? new PageList<CRM_CompanyResult>() : rst.Result as PageList<CRM_CompanyResult>);
            return list;
        }

        public List<CRM_CompanyResult> GetSupList(CRM_CompanyParam param) {
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.CRM.CRM_CompanyBLL", "GetSupList", param);
            List<CRM_CompanyResult> list = new List<CRM_CompanyResult>();
            list = (rst == null ? new List<CRM_CompanyResult>() : rst.Result as List<CRM_CompanyResult>);
            return list;
        }

        public WCFAddUpdateResult AddOrUpdateSup(CRM_CompanyResult param)
        {
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.CRM.CRM_CompanyBLL", "AddOrUpdateSup", param);
            ret = (rst == null ? new WCFAddUpdateResult() : rst.Result as WCFAddUpdateResult);
            return ret;
        }

        public CRM_CompanyResult GetSupInfo(CRM_CompanyParam param) {
            CRM_CompanyResult ret = new CRM_CompanyResult();
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.CRM.CRM_CompanyBLL", "GetSupInfo", param);
            ret = rst == null ? new CRM_CompanyResult() : rst.Result as CRM_CompanyResult;
            return ret;
        }

        public WCFAddUpdateResult DelSupInfo(CRM_CompanyParam param) {
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.CRM.CRM_CompanyBLL", "DelSupInfo", param);
            ret = (rst == null ? new WCFAddUpdateResult() : rst.Result as WCFAddUpdateResult);
            return ret;
        }
        #endregion
    }
}
