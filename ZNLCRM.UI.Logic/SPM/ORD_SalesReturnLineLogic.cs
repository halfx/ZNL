using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLCRM.Entity.UserModel.SPM;
using System.Windows.Forms;
using ZNLFrame.Entity;

namespace ZNLCRM.UI.Logic.SPM
{
    public class ORD_SalesReturnLineLogic:BaseLogic
    {
        public ORD_SalesReturnLineLogic(Form form) : base(form) { }
        public List<ORD_SalesReturnLineResult> GetList(ORD_SalesReturnLineParam param)
        {
            ExeResult rst = new ExeResult();
            rst = this.Execute("ZNLCRM.BLL.SPM.ORD_SalesReturnLineBLL", "GetList", param);
            List<ORD_SalesReturnLineResult> list = new List<ORD_SalesReturnLineResult>();
            list = (rst == null ? new List<ORD_SalesReturnLineResult>() : rst.Result as List<ORD_SalesReturnLineResult>);
            return list;
        }
    }
}
