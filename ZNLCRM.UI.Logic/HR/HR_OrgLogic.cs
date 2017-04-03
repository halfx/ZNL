using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZNLCRM.Entity.UserModel.Common;
using ZNLFrame.Entity;
using ZNLCRM.Entity.UserModel.HR;

namespace ZNLCRM.UI.Logic.HR
{
    public  class HR_OrgLogic:BaseLogic
    {

        public HR_OrgLogic(Form form) : base(form) { }

        public WCFAddUpdateResult AddOrUpdate(HR_OrgResult param)
        {
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.HR.HR_OrgBLL", "AddOrUpdate", param);
            ret = (rst == null ? new WCFAddUpdateResult() : rst.Result as WCFAddUpdateResult);
            return ret;
        }

        public HR_OrgResult GetInfo(HR_OrgParam param)
        {
            HR_OrgResult ret = new HR_OrgResult();
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.HR.HR_OrgBLL", "GetInfo", param);
            ret = rst == null ? new HR_OrgResult() : rst.Result as HR_OrgResult;
            return ret;
        }
        public List<HR_OrgResult> GetOrgTree(HR_OrgParam param)
        {
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.HR.HR_OrgBLL", "GetOrgTree", param);
            List<HR_OrgResult> pageList = new List<HR_OrgResult>();
            pageList = (rst == null ? new List<HR_OrgResult>() : rst.Result as List<HR_OrgResult>);
            return pageList;
        }
        public WCFAddUpdateResult DelInfo(HR_OrgParam param)
        {
            WCFAddUpdateResult ret = new WCFAddUpdateResult();
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.HR.HR_OrgBLL", "DelInfo", param);
            ret = (rst == null ? new WCFAddUpdateResult() : rst.Result as WCFAddUpdateResult);
            return ret;
        }

        public void BindComboBox(Controls.UcComboBox c,HR_OrgParam  param)
        {
            if (c !=null && param!=null)
            {
                List<HR_OrgResult> orgList = this.GetOrgTree(param);
                c.ValueMember = "OrgID";
                c.DisplayMember = "OrgName";
                c.DataSource = orgList;
            }
        }
            
          
    }
}
