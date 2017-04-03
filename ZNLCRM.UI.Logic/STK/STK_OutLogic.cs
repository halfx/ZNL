using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZNLCRM.Entity.UserModel.Common;
using ZNLFrame.Entity;
using ZNLCRM.Entity.UserModel.STK;

namespace ZNLCRM.UI.Logic.STK
{
    public  class STK_OutLogic:BaseLogic
    {
        public STK_OutLogic(Form form) : base(form) { }
        public bool SubmitStkOutBill(STK_OutParam param)
        {
            bool ret = true;
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.STK.STK_OutBLL", "SubmitStkOutBill", param);
            ret = (rst == null ? false : (bool)rst.Result);
            return ret;
        }
        public bool AuditStkOutBill(STK_OutParam param)
        {
            bool ret = true;
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.STK.STK_OutBLL", "AuditStkOutBill", param);
            ret = (rst == null ? false : (bool)rst.Result);
            return ret;
        }
         public WCFAddUpdateResult AddOrUpdate(STK_OutResult param)
         {
             WCFAddUpdateResult ret = new WCFAddUpdateResult();
             ExeResult rst = new ExeResult();
             rst = this.Execute("ZNLCRM.BLL.STK.STK_OutBLL", "AddOrUpdate", param);
             ret = (rst == null ? new WCFAddUpdateResult() : rst.Result as WCFAddUpdateResult);
             return ret;
         }

         public STK_OutResult GetInfo(STK_OutParam param)
         {
             STK_OutResult ret = new STK_OutResult();
             ExeResult rst = new ExeResult();
             rst = this.Execute("ZNLCRM.BLL.STK.STK_OutBLL", "GetInfo", param);
             ret = rst == null ? new STK_OutResult() : rst.Result as STK_OutResult;
             return ret;
         }
         public PageList<STK_OutResult> GetPageList(STK_OutParam param)
         {
             ExeResult rst = new ExeResult();
             rst = this.Execute("ZNLCRM.BLL.STK.STK_OutBLL", "GetPageList", param);
             PageList<STK_OutResult> pageList = new PageList<STK_OutResult>();
             pageList = (rst == null ? new PageList<STK_OutResult>() : rst.Result as PageList<STK_OutResult>);
             return pageList;
         }

         public WCFAddUpdateResult DelInfo(STK_OutParam param)
         {
             WCFAddUpdateResult ret = new WCFAddUpdateResult();
             ExeResult rst = new ExeResult();
             rst = this.Execute("ZNLCRM.BLL.STK.STK_OutBLL", "DelInfo", param);
             ret = (rst == null ? new WCFAddUpdateResult() : rst.Result as WCFAddUpdateResult);
             return ret;
         }
    }
}
