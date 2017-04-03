using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLCRM.Entity.DBModel;

namespace ZNLCRM.Entity.UserModel.ReportTool
{
    [Serializable]
    public class Sys_ReportParam : Sys_Report
    {
        /// <summary>
        /// 报表ID
        /// </summary>
        public int? SysRptID { get; set; }
        /// <summary>
        /// 报表GUID
        /// </summary>
        public Guid? SysRptGuID { get; set; }
    }
}
