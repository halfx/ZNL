using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZNLCRM.Entity.UserModel.PPM;
using ZNLFrame.Entity;

namespace ZNLCRM.UI.Logic.PPM
{
    public  class ORD_PurchaseReturnLineLogic:BaseLogic
    {
       public  ORD_PurchaseReturnLineLogic(Form form) : base(form) { }
       public List<ORD_PurchaseReturnLineResult> GetList(ORD_PurchaseReturnLineParam param)
       {
           ExeResult rst = new ExeResult();
           rst = this.Execute("ZNLCRM.BLL.PPM.ORD_PurchaseReturnLineBLL", "GetList", param);
           List<ORD_PurchaseReturnLineResult> list = new List<ORD_PurchaseReturnLineResult>();
           list = (rst == null ? new List<ORD_PurchaseReturnLineResult>() : rst.Result as List<ORD_PurchaseReturnLineResult>);
           return list;
       }
       public ORD_PurchaseReturnLineResult GetInfo(ORD_PurchaseReturnLineParam param)
       {
           ORD_PurchaseReturnLineResult ret = new ORD_PurchaseReturnLineResult();
           ExeResult rst = new ExeResult();
           rst = this.Execute("ZNLCRM.BLL.PPM.ORD_PurchaseReturnLineBLL", "GetInfo", param);
           ret = rst == null ? new ORD_PurchaseReturnLineResult() : rst.Result as ORD_PurchaseReturnLineResult;
           return ret;
       }
    }
}
