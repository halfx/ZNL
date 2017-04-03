using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLFrame.Entity;

namespace ZNLCRM.Entity.UserModel.Sys
{
    [Serializable]
    public class Sys_ModuleParam : PageParam
    {
        public int ModuleID { get; set; }
        public int MenuID { get; set; }
        public string ModuleCode { get; set; }
        public string ModuleName { get; set; }
        public int?[] ModuleIDs { get; set; }

        /// <summary>
        /// 员工编号
        /// </summary>
        public int EmpID { get; set; }

        /// <summary>
        /// 员工名称
        /// </summary>
        public string EmpName { get; set; }

        /// <summary>
        /// 操作权限
        /// </summary>
        public string ModuleOperation { get; set; }

        public int?[] NotModuleIDs { get; set; }

    }
}
