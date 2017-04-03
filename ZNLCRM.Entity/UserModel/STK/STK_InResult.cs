using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLCRM.Entity.DBModel;
using ZNLCRM.Entity.UserModel.HR;

namespace ZNLCRM.Entity.UserModel.STK
{
    [Serializable]
    public  class STK_InResult:STK_In
    {
        public List<STK_InLineResult> StkInLineList { get; set; }
        public HR_DepartmentResult HR_DepartmentResult { get; set; }
        public string OperOrgName { get; set; }
        public string OperDeptName { get; set; }
    }
}
