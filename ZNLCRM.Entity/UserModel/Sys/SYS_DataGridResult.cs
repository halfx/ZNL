using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLCRM.Entity.DBModel;

namespace ZNLCRM.Entity.UserModel.Sys
{
    [Serializable]
    public class SYS_DataGridResult : SYS_DataGrid
    {
        public int? SaveMode { get; set; }
        public List<SYS_UserGridColIndex> ColIndexList { get; set; }
        public List<SYS_UserGridColWidth> ColWidthList { get; set; }
        public List<SYS_UserGridColName> ColNameList { get; set; }
    }
}
