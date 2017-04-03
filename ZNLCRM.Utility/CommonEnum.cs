using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZNLCRM.Utility.CommonEnum
{
   
        /// <summary>
        /// 权限操作项
        /// </summary>
        public enum ActionCodeItem : int
        {
            Search = 1,
            New = 2,
            Edit = 3,
            Delete = 4,
            Import = 5,
            Output = 6,
            Print = 7,
            ViewAll = 8,
            Approve = 9
        }
    /// <summary>
    /// 数据值类型
    /// </summary>
        public enum DataValueType
        {
            String,
            Int32,
            XML,
            JSON,
            Boolean,
            Decimal
        }
    /// <summary>
    ///附件类型
    /// </summary>
        public enum AttachType
        { 
            Bill,//单据
            Pic,//图片
            Pdf,//Pdf
            Email,//邮件
            UserDoc,//文档
        }

        /// <summary>
        /// 会员类型枚举(0:免费,1:收费,2:试用)
        /// </summary>
        public enum MemberType
        {
            /// <summary>
            /// 免费
            /// </summary>
            Free = 0,
            /// <summary>
            /// 收费
            /// </summary>
            Paied = 1,
            /// <summary>
            /// 试用
            /// </summary>
            Trialed = 2
        }
        /// <summary>
        /// 数据状态
        /// </summary>
        public enum IsActive : int
        {
            /// <summary>
            /// 禁用
            /// </summary>
            Disabled = 1,
            /// <summary>
            /// 可用
            /// </summary>
            Usable = 2,
            /// <summary>
            /// 删除
            /// </summary>
            Deleted = 3,
            /// <summary>
            /// 加锁
            /// </summary>
            Locked = 4
        }
}
