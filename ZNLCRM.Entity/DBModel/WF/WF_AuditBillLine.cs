﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by CodeSmith Template.
//
//     Creater: Administrator
//     Date:    2015/1/6
//     Time:    10:09
//     Version: 4.0.0.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------

/// <summary>
/// CodeSmith自动生成的实体
/// </summary>
namespace ZNLCRM.Entity.DBModel
{
    using System;
    using MySoft.Data;
    using ZNLCRM.Utility;
    using ZNLFrame.Entity;
    /// <summary>
    /// 表名：WF_AuditBillLine 主键列：WFAuditLineID
    /// </summary>
    [SerializableAttribute()]
    public partial class WF_AuditBillLine : BaseEntity
    {
        #region Private Properties

        private Int32 _WFAuditLineID;
        private Guid? _WFAuditLineGuid;
        private Guid? _WFAuditGuid;
        private Guid? _GCompanyID;
        private Guid? _LimitFunGuid;
        private String _OperationType;
        private String _NextType;
        private Int32? _StepNo;
        private Int32? _GreeMans;
        private String _AuditEmpIDs;
        private String _AuditEmpNames;
        private Guid? _AuditFunGuid;
        private String _AuditFunName;
        private Int32? _CreatedEmpID;
        private String _CreatedEmpName;
        private DateTime? _CreatedTime;
        private Int32? _UpdatedEmpID;
        private String _UpdatedEmpName;
        private DateTime? _UpdatedTime;
        private Boolean? _IsDeleted;

        #endregion

        #region Public Properties

        /// <summary>
        /// 审核流程明细步骤ID.
        /// </summary>
        public Int32 WFAuditLineID
        {
            get
            {
                return _WFAuditLineID;
            }
            set
            {
                this.OnPropertyValueChange(_.WFAuditLineID, _WFAuditLineID, value);
                this._WFAuditLineID = value;
            }
        }

        /// <summary>
        /// 审核流程明细步骤GuID.
        /// </summary>
        public Guid? WFAuditLineGuid
        {
            get
            {
                return this._WFAuditLineGuid;
            }
            set
            {
                this.OnPropertyValueChange(_.WFAuditLineGuid, _WFAuditLineGuid, value);
                this._WFAuditLineGuid = value;
            }
        }

        /// <summary>
        /// 审核流程GuID.
        /// </summary>
        public Guid? WFAuditGuid
        {
            get
            {
                return this._WFAuditGuid;
            }
            set
            {
                this.OnPropertyValueChange(_.WFAuditGuid, _WFAuditGuid, value);
                this._WFAuditGuid = value;
            }
        }

        /// <summary>
        /// 公司ID.
        /// </summary>
        public Guid? GCompanyID
        {
            get
            {
                return this._GCompanyID;
            }
            set
            {
                this.OnPropertyValueChange(_.GCompanyID, _GCompanyID, value);
                this._GCompanyID = value;
            }
        }

        /// <summary>
        /// 前提条件.
        /// </summary>
        public Guid? LimitFunGuid
        {
            get
            {
                return this._LimitFunGuid;
            }
            set
            {
                this.OnPropertyValueChange(_.LimitFunGuid, _LimitFunGuid, value);
                this._LimitFunGuid = value;
            }
        }

        /// <summary>
        /// 操作类型(提交,下一步,完成).
        /// </summary>
        public String OperationType
        {
            get
            {
                return this._OperationType;
            }
            set
            {
                this.OnPropertyValueChange(_.OperationType, _OperationType, value);
                this._OperationType = value.SubStr(20);
            }
        }

        /// <summary>
        /// 下一步审核类型(指定审核人,条件,审核完成).
        /// </summary>
        public String NextType
        {
            get
            {
                return this._NextType;
            }
            set
            {
                this.OnPropertyValueChange(_.NextType, _NextType, value);
                this._NextType = value.SubStr(20);
            }
        }

        /// <summary>
        /// 次序编号.
        /// </summary>
        public Int32? StepNo
        {
            get
            {
                return this._StepNo;
            }
            set
            {
                this.OnPropertyValueChange(_.StepNo, _StepNo, value);
                this._StepNo = value;
            }
        }

        /// <summary>
        /// 同意人数.
        /// </summary>
        public Int32? GreeMans
        {
            get
            {
                return this._GreeMans;
            }
            set
            {
                this.OnPropertyValueChange(_.GreeMans, _GreeMans, value);
                this._GreeMans = value;
            }
        }

        /// <summary>
        /// 审核人ID字符串(以逗号分隔,只应用于[NextType=指定审核人]有效).
        /// </summary>
        public String AuditEmpIDs
        {
            get
            {
                return this._AuditEmpIDs;
            }
            set
            {
                this.OnPropertyValueChange(_.AuditEmpIDs, _AuditEmpIDs, value);
                this._AuditEmpIDs = value.SubStr(200);
            }
        }

        /// <summary>
        /// 审核人字符串(以逗号分隔,只应用于[NextType=指定审核人]有效).
        /// </summary>
        public String AuditEmpNames
        {
            get
            {
                return this._AuditEmpNames;
            }
            set
            {
                this.OnPropertyValueChange(_.AuditEmpNames, _AuditEmpNames, value);
                this._AuditEmpNames = value.SubStr(500);
            }
        }

        /// <summary>
        /// 转入下个人条件ID.
        /// </summary>
        public Guid? AuditFunGuid
        {
            get
            {
                return this._AuditFunGuid;
            }
            set
            {
                this.OnPropertyValueChange(_.AuditFunGuid, _AuditFunGuid, value);
                this._AuditFunGuid = value;
            }
        }

        /// <summary>
        /// 转入下个人条件名称.
        /// </summary>
        public String AuditFunName
        {
            get
            {
                return this._AuditFunName;
            }
            set
            {
                this.OnPropertyValueChange(_.AuditFunName, _AuditFunName, value);
                this._AuditFunName = value.SubStr(100);
            }
        }

        /// <summary>
        /// 创建人.
        /// </summary>
        public Int32? CreatedEmpID
        {
            get
            {
                return this._CreatedEmpID;
            }
            set
            {
                this.OnPropertyValueChange(_.CreatedEmpID, _CreatedEmpID, value);
                this._CreatedEmpID = value;
            }
        }

        /// <summary>
        /// 创建人姓名.
        /// </summary>
        public String CreatedEmpName
        {
            get
            {
                return this._CreatedEmpName;
            }
            set
            {
                this.OnPropertyValueChange(_.CreatedEmpName, _CreatedEmpName, value);
                this._CreatedEmpName = value.SubStr(50);
            }
        }

        /// <summary>
        /// 创建时间.
        /// </summary>
        public DateTime? CreatedTime
        {
            get
            {
                return this._CreatedTime;
            }
            set
            {
                this.OnPropertyValueChange(_.CreatedTime, _CreatedTime, value);
                this._CreatedTime = value;
            }
        }

        /// <summary>
        /// 更新人.
        /// </summary>
        public Int32? UpdatedEmpID
        {
            get
            {
                return this._UpdatedEmpID;
            }
            set
            {
                this.OnPropertyValueChange(_.UpdatedEmpID, _UpdatedEmpID, value);
                this._UpdatedEmpID = value;
            }
        }

        /// <summary>
        /// 更新人.
        /// </summary>
        public String UpdatedEmpName
        {
            get
            {
                return this._UpdatedEmpName;
            }
            set
            {
                this.OnPropertyValueChange(_.UpdatedEmpName, _UpdatedEmpName, value);
                this._UpdatedEmpName = value.SubStr(50);
            }
        }

        /// <summary>
        /// 更新时间.
        /// </summary>
        public DateTime? UpdatedTime
        {
            get
            {
                return this._UpdatedTime;
            }
            set
            {
                this.OnPropertyValueChange(_.UpdatedTime, _UpdatedTime, value);
                this._UpdatedTime = value;
            }
        }

        /// <summary>
        /// 是否删除.
        /// </summary>
        public Boolean? IsDeleted
        {
            get
            {
                return this._IsDeleted;
            }
            set
            {
                this.OnPropertyValueChange(_.IsDeleted, _IsDeleted, value);
                this._IsDeleted = value;
            }
        }

        #endregion
        /// <summary>
        /// 获取实体对应的表名
        /// </summary>
        protected override Table GetTable()
        {
            return new Table<WF_AuditBillLine>("WF_AuditBillLine");
        }

        /// <summary>
        /// 获取实体中的标识列
        /// </summary>
        protected override Field GetIdentityField()
        {
            return _.WFAuditLineID;
        }

        /// <summary>
        /// 获取实体中的主键列
        /// </summary>
        protected override Field[] GetPrimaryKeyFields()
        {
            return new Field[] {
				_.WFAuditLineID
			};
        }

        /// <summary>
        /// 获取列信息
        /// </summary>
        protected override Field[] GetFields()
        {
            return new Field[] {
				_.WFAuditLineID,		
				_.WFAuditLineGuid,		
				_.WFAuditGuid,		
				_.GCompanyID,		
				_.LimitFunGuid,		
				_.OperationType,		
				_.NextType,		
				_.StepNo,		
				_.GreeMans,		
				_.AuditEmpIDs,		
				_.AuditEmpNames,		
				_.AuditFunGuid,		
				_.AuditFunName,		
				_.CreatedEmpID,		
				_.CreatedEmpName,		
				_.CreatedTime,		
				_.UpdatedEmpID,		
				_.UpdatedEmpName,		
				_.UpdatedTime,		
				_.IsDeleted		
			};
        }

        /// <summary>
        /// 获取列数据
        /// </summary>
        protected override object[] GetValues()
        {
            return new object[] {
				this._WFAuditLineID,		
				this._WFAuditLineGuid,		
				this._WFAuditGuid,		
				this._GCompanyID,		
				this._LimitFunGuid,		
				this._OperationType,		
				this._NextType,		
				this._StepNo,		
				this._GreeMans,		
				this._AuditEmpIDs,		
				this._AuditEmpNames,		
				this._AuditFunGuid,		
				this._AuditFunName,		
				this._CreatedEmpID,		
				this._CreatedEmpName,		
				this._CreatedTime,		
				this._UpdatedEmpID,		
				this._UpdatedEmpName,		
				this._UpdatedTime,		
				this._IsDeleted		
			};
        }

        /// <summary>
        /// 给当前实体赋值
        /// </summary>
        protected override void SetValues(IRowReader reader)
        {
            if ((false == reader.IsDBNull(_.WFAuditLineID)))
            {
                this._WFAuditLineID = reader.GetInt32(_.WFAuditLineID);
            }
            if ((false == reader.IsDBNull(_.WFAuditLineGuid)))
            {
                this._WFAuditLineGuid = reader.GetGuid(_.WFAuditLineGuid);
            }
            if ((false == reader.IsDBNull(_.WFAuditGuid)))
            {
                this._WFAuditGuid = reader.GetGuid(_.WFAuditGuid);
            }
            if ((false == reader.IsDBNull(_.GCompanyID)))
            {
                this._GCompanyID = reader.GetGuid(_.GCompanyID);
            }
            if ((false == reader.IsDBNull(_.LimitFunGuid)))
            {
                this._LimitFunGuid = reader.GetGuid(_.LimitFunGuid);
            }
            if ((false == reader.IsDBNull(_.OperationType)))
            {
                this._OperationType = reader.GetString(_.OperationType);
            }
            if ((false == reader.IsDBNull(_.NextType)))
            {
                this._NextType = reader.GetString(_.NextType);
            }
            if ((false == reader.IsDBNull(_.StepNo)))
            {
                this._StepNo = reader.GetInt32(_.StepNo);
            }
            if ((false == reader.IsDBNull(_.GreeMans)))
            {
                this._GreeMans = reader.GetInt32(_.GreeMans);
            }
            if ((false == reader.IsDBNull(_.AuditEmpIDs)))
            {
                this._AuditEmpIDs = reader.GetString(_.AuditEmpIDs);
            }
            if ((false == reader.IsDBNull(_.AuditEmpNames)))
            {
                this._AuditEmpNames = reader.GetString(_.AuditEmpNames);
            }
            if ((false == reader.IsDBNull(_.AuditFunGuid)))
            {
                this._AuditFunGuid = reader.GetGuid(_.AuditFunGuid);
            }
            if ((false == reader.IsDBNull(_.AuditFunName)))
            {
                this._AuditFunName = reader.GetString(_.AuditFunName);
            }
            if ((false == reader.IsDBNull(_.CreatedEmpID)))
            {
                this._CreatedEmpID = reader.GetInt32(_.CreatedEmpID);
            }
            if ((false == reader.IsDBNull(_.CreatedEmpName)))
            {
                this._CreatedEmpName = reader.GetString(_.CreatedEmpName);
            }
            if ((false == reader.IsDBNull(_.CreatedTime)))
            {
                this._CreatedTime = reader.GetDateTime(_.CreatedTime);
            }
            if ((false == reader.IsDBNull(_.UpdatedEmpID)))
            {
                this._UpdatedEmpID = reader.GetInt32(_.UpdatedEmpID);
            }
            if ((false == reader.IsDBNull(_.UpdatedEmpName)))
            {
                this._UpdatedEmpName = reader.GetString(_.UpdatedEmpName);
            }
            if ((false == reader.IsDBNull(_.UpdatedTime)))
            {
                this._UpdatedTime = reader.GetDateTime(_.UpdatedTime);
            }
            if ((false == reader.IsDBNull(_.IsDeleted)))
            {
                this._IsDeleted = reader.GetBoolean(_.IsDeleted);
            }
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if ((obj == null))
            {
                return false;
            }
            if ((false == typeof(WF_AuditBillLine).IsAssignableFrom(obj.GetType())))
            {
                return false;
            }
            if ((((object)(this)) == ((object)(obj))))
            {
                return true;
            }
            return false;
        }

        public class _
        {

            /// <summary>
            /// 表示选择所有列，与*等同
            /// </summary>
            public static AllField All = new AllField<WF_AuditBillLine>();

            /// <summary>
            /// 审核流程明细步骤ID - 字段名：WFAuditLineID - 数据类型：Int32?
            /// </summary>
            public static Field WFAuditLineID = new Field<WF_AuditBillLine>("WFAuditLineID");
            /// <summary>
            /// 审核流程明细步骤GuID - 字段名：WFAuditLineGuid - 数据类型：Guid?
            /// </summary>
            public static Field WFAuditLineGuid = new Field<WF_AuditBillLine>("WFAuditLineGuid");
            /// <summary>
            /// 审核流程GuID - 字段名：WFAuditGuid - 数据类型：Guid?
            /// </summary>
            public static Field WFAuditGuid = new Field<WF_AuditBillLine>("WFAuditGuid");
            /// <summary>
            /// 公司ID - 字段名：GCompanyID - 数据类型：Guid?
            /// </summary>
            public static Field GCompanyID = new Field<WF_AuditBillLine>("GCompanyID");
            /// <summary>
            /// 前提条件 - 字段名：LimitFunGuid - 数据类型：Guid?
            /// </summary>
            public static Field LimitFunGuid = new Field<WF_AuditBillLine>("LimitFunGuid");
            /// <summary>
            /// 操作类型(提交,下一步,完成) - 字段名：OperationType - 数据类型：String
            /// </summary>
            public static Field OperationType = new Field<WF_AuditBillLine>("OperationType");
            /// <summary>
            /// 下一步审核类型(指定审核人,条件,审核完成) - 字段名：NextType - 数据类型：String
            /// </summary>
            public static Field NextType = new Field<WF_AuditBillLine>("NextType");
            /// <summary>
            /// 次序编号 - 字段名：StepNo - 数据类型：Int32?
            /// </summary>
            public static Field StepNo = new Field<WF_AuditBillLine>("StepNo");
            /// <summary>
            /// 同意人数 - 字段名：GreeMans - 数据类型：Int32?
            /// </summary>
            public static Field GreeMans = new Field<WF_AuditBillLine>("GreeMans");
            /// <summary>
            /// 审核人ID字符串(以逗号分隔,只应用于[NextType=指定审核人]有效) - 字段名：AuditEmpIDs - 数据类型：String
            /// </summary>
            public static Field AuditEmpIDs = new Field<WF_AuditBillLine>("AuditEmpIDs");
            /// <summary>
            /// 审核人字符串(以逗号分隔,只应用于[NextType=指定审核人]有效) - 字段名：AuditEmpNames - 数据类型：String
            /// </summary>
            public static Field AuditEmpNames = new Field<WF_AuditBillLine>("AuditEmpNames");
            /// <summary>
            /// 转入下个人条件ID - 字段名：AuditFunGuid - 数据类型：Guid?
            /// </summary>
            public static Field AuditFunGuid = new Field<WF_AuditBillLine>("AuditFunGuid");
            /// <summary>
            /// 转入下个人条件名称 - 字段名：AuditFunName - 数据类型：String
            /// </summary>
            public static Field AuditFunName = new Field<WF_AuditBillLine>("AuditFunName");
            /// <summary>
            /// 创建人 - 字段名：CreatedEmpID - 数据类型：Int32?
            /// </summary>
            public static Field CreatedEmpID = new Field<WF_AuditBillLine>("CreatedEmpID");
            /// <summary>
            /// 创建人姓名 - 字段名：CreatedEmpName - 数据类型：String
            /// </summary>
            public static Field CreatedEmpName = new Field<WF_AuditBillLine>("CreatedEmpName");
            /// <summary>
            /// 创建时间 - 字段名：CreatedTime - 数据类型：DateTime?
            /// </summary>
            public static Field CreatedTime = new Field<WF_AuditBillLine>("CreatedTime");
            /// <summary>
            /// 更新人 - 字段名：UpdatedEmpID - 数据类型：Int32?
            /// </summary>
            public static Field UpdatedEmpID = new Field<WF_AuditBillLine>("UpdatedEmpID");
            /// <summary>
            /// 更新人 - 字段名：UpdatedEmpName - 数据类型：String
            /// </summary>
            public static Field UpdatedEmpName = new Field<WF_AuditBillLine>("UpdatedEmpName");
            /// <summary>
            /// 更新时间 - 字段名：UpdatedTime - 数据类型：DateTime?
            /// </summary>
            public static Field UpdatedTime = new Field<WF_AuditBillLine>("UpdatedTime");
            /// <summary>
            /// 是否删除 - 字段名：IsDeleted - 数据类型：Boolean?
            /// </summary>
            public static Field IsDeleted = new Field<WF_AuditBillLine>("IsDeleted");
        }
    }
}