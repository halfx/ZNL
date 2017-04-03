using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLFrame.Entity;

namespace ZNLCRM.Entity.UserModel.Sys
{

    [Serializable]
    public class Sys_EmpRightParam : PageParam
    {
        public int EmpRightID { get; set; }
        public Guid? GCompanyID { get; set; }
        public int EmpID { get; set; }
        public int ModuleID { get; set; }
        public string ModuleName { get; set; }
        /// <summary>
        /// 操作
        /// </summary>
        public string ActionCode { get; set; }

        public int MenuID { get; set; }

        /// <summary>
        /// 是否选中所有模块
        /// </summary>
        public bool IsAllModule { get; set; }

        //选择没有设置权限的模块
        public bool IsNoAction { get; set; }
        /// <summary>
        /// 员工权限列表
        /// </summary>
        public List<Sys_EmpRightResult> EmpRightList { get; set; }

    }
}
