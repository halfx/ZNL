﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by CodeSmith Template.
//
//     Creater: Administrator
//     Date:    2014/10/21
//     Time:    14:40
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
    /// 表名：Sys_ReportSection 主键列：RptSectionID
    /// </summary>
    [SerializableAttribute()]
    public partial class Sys_ReportSection : BaseEntity
    {
        #region Private Properties

        private Int32 _RptSectionID;
        private Guid? _RptSectionGuID;
        private Guid? _SysRptGuID;
        private String _SectionName;
        private String _SectionChsName;
        private Boolean? _IsRepeatBody;
        private Int32? _MaxRow;
        private Int32? _RowHeight;
        private Int32? _SectionWidth;
        private Int32? _SectionHeight;
        private Boolean? _IsRepeatInPage;
        private Int32? _OrderSeq;
        private Boolean? _IsDeleted;

        #endregion

        #region Public Properties

        /// <summary>
        /// ID.
        /// </summary>
        public Int32 RptSectionID
        {
            get
            {
                return _RptSectionID;
            }
            set
            {
                this.OnPropertyValueChange(_.RptSectionID, _RptSectionID, value);
                this._RptSectionID = value;
            }
        }

        /// <summary>
        /// GUID.
        /// </summary>
        public Guid? RptSectionGuID
        {
            get
            {
                return this._RptSectionGuID;
            }
            set
            {
                this.OnPropertyValueChange(_.RptSectionGuID, _RptSectionGuID, value);
                this._RptSectionGuID = value;
            }
        }

        /// <summary>
        /// 关联报表GUID.
        /// </summary>
        public Guid? SysRptGuID
        {
            get
            {
                return this._SysRptGuID;
            }
            set
            {
                this.OnPropertyValueChange(_.SysRptGuID, _SysRptGuID, value);
                this._SysRptGuID = value;
            }
        }

        /// <summary>
        /// 关联带区名称.
        /// </summary>
        public String SectionName
        {
            get
            {
                return this._SectionName;
            }
            set
            {
                this.OnPropertyValueChange(_.SectionName, _SectionName, value);
                this._SectionName = value.SubStr(120);
            }
        }

        /// <summary>
        /// 关联带区中文名称.
        /// </summary>
        public String SectionChsName
        {
            get
            {
                return this._SectionChsName;
            }
            set
            {
                this.OnPropertyValueChange(_.SectionChsName, _SectionChsName, value);
                this._SectionChsName = value.SubStr(200);
            }
        }

        /// <summary>
        /// 是否重复主体.
        /// </summary>
        public Boolean? IsRepeatBody
        {
            get
            {
                return this._IsRepeatBody;
            }
            set
            {
                this.OnPropertyValueChange(_.IsRepeatBody, _IsRepeatBody, value);
                this._IsRepeatBody = value;
            }
        }

        /// <summary>
        /// 最大行数(只应用于主体带区).
        /// </summary>
        public Int32? MaxRow
        {
            get
            {
                return this._MaxRow;
            }
            set
            {
                this.OnPropertyValueChange(_.MaxRow, _MaxRow, value);
                this._MaxRow = value;
            }
        }

        /// <summary>
        /// 每行高度(只应用于主体带区).
        /// </summary>
        public Int32? RowHeight
        {
            get
            {
                return this._RowHeight;
            }
            set
            {
                this.OnPropertyValueChange(_.RowHeight, _RowHeight, value);
                this._RowHeight = value;
            }
        }

        /// <summary>
        /// 带区宽度.
        /// </summary>
        public Int32? SectionWidth
        {
            get
            {
                return this._SectionWidth;
            }
            set
            {
                this.OnPropertyValueChange(_.SectionWidth, _SectionWidth, value);
                this._SectionWidth = value;
            }
        }

        /// <summary>
        /// 带区高度.
        /// </summary>
        public Int32? SectionHeight
        {
            get
            {
                return this._SectionHeight;
            }
            set
            {
                this.OnPropertyValueChange(_.SectionHeight, _SectionHeight, value);
                this._SectionHeight = value;
            }
        }

        /// <summary>
        /// 在每页是否重复出现.
        /// </summary>
        public Boolean? IsRepeatInPage
        {
            get
            {
                return this._IsRepeatInPage;
            }
            set
            {
                this.OnPropertyValueChange(_.IsRepeatInPage, _IsRepeatInPage, value);
                this._IsRepeatInPage = value;
            }
        }

        /// <summary>
        /// .
        /// </summary>
        public Int32? OrderSeq
        {
            get
            {
                return this._OrderSeq;
            }
            set
            {
                this.OnPropertyValueChange(_.OrderSeq, _OrderSeq, value);
                this._OrderSeq = value;
            }
        }

        /// <summary>
        /// 是否删除(0:正常,1:已删除).
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
            return new Table<Sys_ReportSection>("Sys_ReportSection");
        }

        /// <summary>
        /// 获取实体中的标识列
        /// </summary>
        protected override Field GetIdentityField()
        {
            return _.RptSectionID;
        }

        /// <summary>
        /// 获取实体中的主键列
        /// </summary>
        protected override Field[] GetPrimaryKeyFields()
        {
            return new Field[] {
				_.RptSectionID
			};
        }

        /// <summary>
        /// 获取列信息
        /// </summary>
        protected override Field[] GetFields()
        {
            return new Field[] {
				_.RptSectionID,		
				_.RptSectionGuID,		
				_.SysRptGuID,		
				_.SectionName,		
				_.SectionChsName,		
				_.IsRepeatBody,		
				_.MaxRow,		
				_.RowHeight,		
				_.SectionWidth,		
				_.SectionHeight,		
				_.IsRepeatInPage,		
				_.OrderSeq,		
				_.IsDeleted		
			};
        }

        /// <summary>
        /// 获取列数据
        /// </summary>
        protected override object[] GetValues()
        {
            return new object[] {
				this._RptSectionID,		
				this._RptSectionGuID,		
				this._SysRptGuID,		
				this._SectionName,		
				this._SectionChsName,		
				this._IsRepeatBody,		
				this._MaxRow,		
				this._RowHeight,		
				this._SectionWidth,		
				this._SectionHeight,		
				this._IsRepeatInPage,		
				this._OrderSeq,		
				this._IsDeleted		
			};
        }

        /// <summary>
        /// 给当前实体赋值
        /// </summary>
        protected override void SetValues(IRowReader reader)
        {
            if ((false == reader.IsDBNull(_.RptSectionID)))
            {
                this._RptSectionID = reader.GetInt32(_.RptSectionID);
            }
            if ((false == reader.IsDBNull(_.RptSectionGuID)))
            {
                this._RptSectionGuID = reader.GetGuid(_.RptSectionGuID);
            }
            if ((false == reader.IsDBNull(_.SysRptGuID)))
            {
                this._SysRptGuID = reader.GetGuid(_.SysRptGuID);
            }
            if ((false == reader.IsDBNull(_.SectionName)))
            {
                this._SectionName = reader.GetString(_.SectionName);
            }
            if ((false == reader.IsDBNull(_.SectionChsName)))
            {
                this._SectionChsName = reader.GetString(_.SectionChsName);
            }
            if ((false == reader.IsDBNull(_.IsRepeatBody)))
            {
                this._IsRepeatBody = reader.GetBoolean(_.IsRepeatBody);
            }
            if ((false == reader.IsDBNull(_.MaxRow)))
            {
                this._MaxRow = reader.GetInt32(_.MaxRow);
            }
            if ((false == reader.IsDBNull(_.RowHeight)))
            {
                this._RowHeight = reader.GetInt32(_.RowHeight);
            }
            if ((false == reader.IsDBNull(_.SectionWidth)))
            {
                this._SectionWidth = reader.GetInt32(_.SectionWidth);
            }
            if ((false == reader.IsDBNull(_.SectionHeight)))
            {
                this._SectionHeight = reader.GetInt32(_.SectionHeight);
            }
            if ((false == reader.IsDBNull(_.IsRepeatInPage)))
            {
                this._IsRepeatInPage = reader.GetBoolean(_.IsRepeatInPage);
            }
            if ((false == reader.IsDBNull(_.OrderSeq)))
            {
                this._OrderSeq = reader.GetInt32(_.OrderSeq);
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
            if ((false == typeof(Sys_ReportSection).IsAssignableFrom(obj.GetType())))
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
            public static AllField All = new AllField<Sys_ReportSection>();

            /// <summary>
            /// ID - 字段名：RptSectionID - 数据类型：Int32?
            /// </summary>
            public static Field RptSectionID = new Field<Sys_ReportSection>("RptSectionID");
            /// <summary>
            /// GUID - 字段名：RptSectionGuID - 数据类型：Guid?
            /// </summary>
            public static Field RptSectionGuID = new Field<Sys_ReportSection>("RptSectionGuID");
            /// <summary>
            /// 关联报表GUID - 字段名：SysRptGuID - 数据类型：Guid?
            /// </summary>
            public static Field SysRptGuID = new Field<Sys_ReportSection>("SysRptGuID");
            /// <summary>
            /// 关联带区名称 - 字段名：SectionName - 数据类型：String
            /// </summary>
            public static Field SectionName = new Field<Sys_ReportSection>("SectionName");
            /// <summary>
            /// 关联带区中文名称 - 字段名：SectionChsName - 数据类型：String
            /// </summary>
            public static Field SectionChsName = new Field<Sys_ReportSection>("SectionChsName");
            /// <summary>
            /// 是否重复主体 - 字段名：IsRepeatBody - 数据类型：Boolean?
            /// </summary>
            public static Field IsRepeatBody = new Field<Sys_ReportSection>("IsRepeatBody");
            /// <summary>
            /// 最大行数(只应用于主体带区) - 字段名：MaxRow - 数据类型：Int32?
            /// </summary>
            public static Field MaxRow = new Field<Sys_ReportSection>("MaxRow");
            /// <summary>
            /// 每行高度(只应用于主体带区) - 字段名：RowHeight - 数据类型：Int32?
            /// </summary>
            public static Field RowHeight = new Field<Sys_ReportSection>("RowHeight");
            /// <summary>
            /// 带区宽度 - 字段名：SectionWidth - 数据类型：Int32?
            /// </summary>
            public static Field SectionWidth = new Field<Sys_ReportSection>("SectionWidth");
            /// <summary>
            /// 带区高度 - 字段名：SectionHeight - 数据类型：Int32?
            /// </summary>
            public static Field SectionHeight = new Field<Sys_ReportSection>("SectionHeight");
            /// <summary>
            /// 在每页是否重复出现 - 字段名：IsRepeatInPage - 数据类型：Boolean?
            /// </summary>
            public static Field IsRepeatInPage = new Field<Sys_ReportSection>("IsRepeatInPage");
            /// <summary>
            ///  - 字段名：OrderSeq - 数据类型：Int32?
            /// </summary>
            public static Field OrderSeq = new Field<Sys_ReportSection>("OrderSeq");
            /// <summary>
            /// 是否删除(0:正常,1:已删除) - 字段名：IsDeleted - 数据类型：Boolean?
            /// </summary>
            public static Field IsDeleted = new Field<Sys_ReportSection>("IsDeleted");
        }
    }
}
