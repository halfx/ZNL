using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLCRM.Entity.DBModel;
using ZNLCRM.Entity.UserModel.HR;

namespace ZNLCRM.Entity.UserModel.STK
{
    [Serializable]
    public   class STK_OutResult:STK_Out
    {
        public string OperOrgName { get; set; }
        public string OperDeptName { get; set; }
        public List<STK_OutLineResult> StkOutLineList { get; set; }
        public HR_DepartmentResult HR_DepartmentResult { get; set; }
    }
}
