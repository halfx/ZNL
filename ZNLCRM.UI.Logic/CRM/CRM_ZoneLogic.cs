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
    public  class CRM_ZoneLogic:BaseLogic
    {
        public CRM_ZoneLogic(Form form) : base(form) { }

        public void BindComboBox(Controls.UcComboBox c, CRM_ZoneParam param)
        {
            if (c != null && param != null)
            {
                List<CRM_ZoneResult> zoneList = this.GetList(param);
                zoneList.Insert(0, new CRM_ZoneResult { Name_CN = "" });
                c.ValueMember = "Name_CN";
                c.DisplayMember = "Name_CN";
                c.DataSource = zoneList;
            }

        }

        public WCFAddUpdateResult UpdateOrInsertList(List<CRM_ZoneResult> list)
        {

            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.CRM.CRM_ZoneBLL", "UpdateOrInsertList", list);
            ret = (rst == null ? new WCFAddUpdateResult() : rst.Result as WCFAddUpdateResult);
            return ret;
        }


        public List<CRM_ZoneResult> GetList(CRM_ZoneParam param)
        {
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.CRM.CRM_ZoneBLL", "GetList", param);
            List<CRM_ZoneResult> list = new List<CRM_ZoneResult>();
            list = (rst == null ? new List<CRM_ZoneResult>() : rst.Result as List<CRM_ZoneResult>);
            return list;
        }

        public WCFAddUpdateResult AddOrUpdate(CRM_ZoneResult param)
        {
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.CRM.CRM_ZoneBLL", "AddOrUpdate", param);
            ret = (rst == null ? new WCFAddUpdateResult() : rst.Result as WCFAddUpdateResult);
            return ret;
        }

        public CRM_ZoneResult GetInfo(CRM_ZoneParam param)
        {
            CRM_ZoneResult ret = new CRM_ZoneResult();
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.CRM.CRM_ZoneBLL", "GetInfo", param);
            ret = rst == null ? new CRM_ZoneResult() : rst.Result as CRM_ZoneResult;
            return ret;
        }


        public WCFAddUpdateResult DelInfo(CRM_ZoneParam param)
        {
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.CRM.CRM_ZoneBLL", "DelInfo", param);
            ret = (rst == null ? new WCFAddUpdateResult() : rst.Result as WCFAddUpdateResult);
            return ret;
        }
    }
}
