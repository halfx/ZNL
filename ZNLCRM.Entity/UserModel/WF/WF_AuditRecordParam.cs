using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLFrame.Entity;

namespace ZNLCRM.Entity.UserModel.WF
{
    [Serializable]
    public class WF_AuditRecordParam : PageParam
    {
        public string SourceTableEngName { get; set; }
        public Guid? SourceBillGuid { get; set; }
        public string SourceBillNo { get; set; }
        ///// <summary>
        ///// 审核完成后执行的方法类路径
        ///// </summary>
        //public string AfterAuditMethodPath { get; set; }
        ///// <summary>
        ///// 审核完成后执行的方法名称
        ///// </summary>
        //public string AfterAuditMethodName { get; set; }
        ///// <summary>
        ///// 审核完成后执行的方法参数
        ///// </summary>
        //public object AfterAuditMethodParam { get; set; }
        /// <summary>
        /// 审核结果，同意，拒绝，驳回
        /// </summary>
        public string AuditResult { get; set; }

        public string AuditRemark { get; set; }
        /// <summary>
        /// 是否正在生效
        /// </summary>
        public bool? IsCurrent { get; set; }
        /// <summary>
        /// 操作类型,cancel(撤单),takeback(收回)
        /// </summary>
        public string OperationType { get; set; }
    }
}
