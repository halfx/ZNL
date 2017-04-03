using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZNLCRM.Entity.UserModel.Common;
using ZNLCRM.Entity.UserModel.STK;
using ZNLFrame.Entity;

namespace ZNLCRM.UI.Logic.STK
{
     public  class STK_InLogic:BaseLogic
    {
         public STK_InLogic(Form form) : base(form) { }

         public bool SubmitStkInBill(STK_InParam param)
         {
             bool ret = true;
             ExeResult rst = new ExeResult();
             rst = this.Execute("ZNLCRM.BLL.STK.STK_InBLL", "SubmitStkInBill", param);
             ret = (rst == null ? false : (bool)rst.Result);
             return ret;
         }
         public bool AuditStkInBill(STK_InParam param)
         {
             bool ret = true;
             ExeResult rst = new ExeResult();
             rst = this.Execute("ZNLCRM.BLL.STK.STK_InBLL", "AuditStkInBill", param);
             ret = (rst == null ? false : (bool)rst.Result);
             return ret;
         }

         public WCFAddUpdateResult AddOrUpdate(STK_InResult param)
         {
             WCFAddUpdateResult ret = new WCFAddUpdateResult();
             ExeResult rst = new ExeResult();
             rst = this.Execute("ZNLCRM.BLL.STK.STK_InBLL", "AddOrUpdate", param);
             ret = (rst == null ? new WCFAddUpdateResult() : rst.Result as WCFAddUpdateResult);
             return ret;
         }
         public List<STK_InResult> GetList(STK_InParam param)
         {
             ExeResult rst = new ExeResult();
             rst = this.Execute("ZNLCRM.BLL.STK.STK_InBLL", "GetList", param);
             List<STK_InResult> list = new List<STK_InResult>();
             list = (rst == null ? new List<STK_InResult>() : rst.Result as List<STK_InResult>);
             return list;
         }
         public STK_InResult GetInfo(STK_InParam param)
         {
             STK_InResult ret = new STK_InResult();
             ExeResult rst = new ExeResult();
             rst = this.Execute("ZNLCRM.BLL.STK.STK_InBLL", "GetInfo", param);
             ret = rst == null ? new STK_InResult() : rst.Result as STK_InResult;
             return ret;
         }
         public PageList<STK_InResult> GetPageList(STK_InParam param)
         {
             ExeResult rst = new ExeResult();
             rst = this.Execute("ZNLCRM.BLL.STK.STK_InBLL", "GetPageList", param);
             PageList<STK_InResult> pageList = new PageList<STK_InResult>();
             pageList = (rst == null ? new PageList<STK_InResult>() : rst.Result as PageList<STK_InResult>);
             return pageList;
         }

         public WCFAddUpdateResult DelInfo(STK_InParam param)
         {
             WCFAddUpdateResult ret = new WCFAddUpdateResult();
             ExeResult rst = new ExeResult();
             rst = this.Execute("ZNLCRM.BLL.STK.STK_InBLL", "DelInfo", param);
             ret = (rst == null ? new WCFAddUpdateResult() : rst.Result as WCFAddUpdateResult);
             return ret;
         }
    }
}
