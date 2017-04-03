using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLCRM.Entity.DBModel;

namespace ZNLCRM.Entity.UserModel.ReportTool
{
    [Serializable]
    public class Sys_ReportResult : Sys_Report
    {
        /// <summary>
        /// 报表带区集合
        /// </summary>
        public List<Sys_ReportSectionResult> ReportSections { get; set; }
        /// <summary>
        /// 报表当中的所有元素
        /// </summary>
        public List<Sys_ReportElementsResult> ReportElements { get; set; }

    }
}
