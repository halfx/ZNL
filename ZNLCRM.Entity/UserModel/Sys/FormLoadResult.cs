using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLFrame.Entity;

namespace ZNLCRM.Entity.UserModel.Sys
{
    [Serializable]
    public class FormLoadResult:BaseEntity
    {
        public List<Sys_FormRightResult> FormRightList { get; set; }

    }
}
