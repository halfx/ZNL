//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by CodeSmith Template.
//
//     Creater: David
//     Date:    2014/10/22
//     Time:    14:08
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
    /// 表名：CRM_Zone 主键列：ZID
    /// </summary>
    [SerializableAttribute()]
    public partial class CRM_Zone : BaseEntity
    {
        #region Private Properties

        private Int32 _ZID;
        private Guid? _ZGuID;
        private Guid? _GCompanyID;
        private String _ZCode;
        private Int32? _PZID;
        private Int32? _ZType;
        private String _Name_CN;
        private String _Name_EN;
        private Boolean? _IsDeleted;

        #endregion

        #region Public Properties

        /// <summary>
        /// .
        /// </summary>
        public Int32 ZID
        {
            get
            {
                return _ZID;
            }
            set
            {
                this.OnPropertyValueChange(_.ZID, _ZID, value);
                this._ZID = value;
            }
        }

        /// <summary>
        /// .
        /// </summary>
        public Guid? ZGuID
        {
            get
            {
                return this._ZGuID;
            }
            set
            {
                this.OnPropertyValueChange(_.ZGuID, _ZGuID, value);
                this._ZGuID = value;
            }
        }

        /// <summary>
        /// .
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
        /// .
        /// </summary>
        public String ZCode
        {
            get
            {
                return this._ZCode;
            }
            set
            {
                this.OnPropertyValueChange(_.ZCode, _ZCode, value);
                this._ZCode = value.SubStr(50);
            }
        }

        /// <summary>
        /// 父级ID.
        /// </summary>
        public Int32? PZID
        {
            get
            {
                return this._PZID;
            }
            set
            {
                this.OnPropertyValueChange(_.PZID, _PZID, value);
                this._PZID = value;
            }
        }

        /// <summary>
        /// 区域类型（1地区，2国家，3.省份，4城市，5大厦）.
        /// </summary>
        public Int32? ZType
        {
            get
            {
                return this._ZType;
            }
            set
            {
                this.OnPropertyValueChange(_.ZType, _ZType, value);
                this._ZType = value;
            }
        }

        /// <summary>
        /// 区域.
        /// </summary>
        public String Name_CN
        {
            get
            {
                return this._Name_CN;
            }
            set
            {
                this.OnPropertyValueChange(_.Name_CN, _Name_CN, value);
                this._Name_CN = value.SubStr(50);
            }
        }

        /// <summary>
        /// .
        /// </summary>
        public String Name_EN
        {
            get
            {
                return this._Name_EN;
            }
            set
            {
                this.OnPropertyValueChange(_.Name_EN, _Name_EN, value);
                this._Name_EN = value.SubStr(50);
            }
        }

        /// <summary>
        /// .
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
            return new Table<CRM_Zone>("CRM_Zone");
        }

        /// <summary>
        /// 获取实体中的标识列
        /// </summary>
        protected override Field GetIdentityField()
        {
            return _.ZID;
        }

        /// <summary>
        /// 获取实体中的主键列
        /// </summary>
        protected override Field[] GetPrimaryKeyFields()
        {
            return new Field[] {
				_.ZID
			};
        }

        /// <summary>
        /// 获取列信息
        /// </summary>
        protected override Field[] GetFields()
        {
            return new Field[] {
				_.ZID,		
				_.ZGuID,		
				_.GCompanyID,		
				_.ZCode,		
				_.PZID,		
				_.ZType,		
				_.Name_CN,		
				_.Name_EN,		
				_.IsDeleted		
			};
        }

        /// <summary>
        /// 获取列数据
        /// </summary>
        protected override object[] GetValues()
        {
            return new object[] {
				this._ZID,		
				this._ZGuID,		
				this._GCompanyID,		
				this._ZCode,		
				this._PZID,		
				this._ZType,		
				this._Name_CN,		
				this._Name_EN,		
				this._IsDeleted		
			};
        }

        /// <summary>
        /// 给当前实体赋值
        /// </summary>
        protected override void SetValues(IRowReader reader)
        {
            if ((false == reader.IsDBNull(_.ZID)))
            {
                this._ZID = reader.GetInt32(_.ZID);
            }
            if ((false == reader.IsDBNull(_.ZGuID)))
            {
                this._ZGuID = reader.GetGuid(_.ZGuID);
            }
            if ((false == reader.IsDBNull(_.GCompanyID)))
            {
                this._GCompanyID = reader.GetGuid(_.GCompanyID);
            }
            if ((false == reader.IsDBNull(_.ZCode)))
            {
                this._ZCode = reader.GetString(_.ZCode);
            }
            if ((false == reader.IsDBNull(_.PZID)))
            {
                this._PZID = reader.GetInt32(_.PZID);
            }
            if ((false == reader.IsDBNull(_.ZType)))
            {
                this._ZType = reader.GetInt32(_.ZType);
            }
            if ((false == reader.IsDBNull(_.Name_CN)))
            {
                this._Name_CN = reader.GetString(_.Name_CN);
            }
            if ((false == reader.IsDBNull(_.Name_EN)))
            {
                this._Name_EN = reader.GetString(_.Name_EN);
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
            if ((false == typeof(CRM_Zone).IsAssignableFrom(obj.GetType())))
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
            public static AllField All = new AllField<CRM_Zone>();

            /// <summary>
            ///  - 字段名：ZID - 数据类型：Int32?
            /// </summary>
            public static Field ZID = new Field<CRM_Zone>("ZID");
            /// <summary>
            ///  - 字段名：ZGuID - 数据类型：Guid?
            /// </summary>
            public static Field ZGuID = new Field<CRM_Zone>("ZGuID");
            /// <summary>
            ///  - 字段名：GCompanyID - 数据类型：Guid?
            /// </summary>
            public static Field GCompanyID = new Field<CRM_Zone>("GCompanyID");
            /// <summary>
            ///  - 字段名：ZCode - 数据类型：String
            /// </summary>
            public static Field ZCode = new Field<CRM_Zone>("ZCode");
            /// <summary>
            /// 父级ID - 字段名：PZID - 数据类型：Int32?
            /// </summary>
            public static Field PZID = new Field<CRM_Zone>("PZID");
            /// <summary>
            /// 区域类型（1地区，2国家，3.省份，4城市，5大厦） - 字段名：ZType - 数据类型：Int32?
            /// </summary>
            public static Field ZType = new Field<CRM_Zone>("ZType");
            /// <summary>
            /// 区域 - 字段名：Name_CN - 数据类型：String
            /// </summary>
            public static Field Name_CN = new Field<CRM_Zone>("Name_CN");
            /// <summary>
            ///  - 字段名：Name_EN - 数据类型：String
            /// </summary>
            public static Field Name_EN = new Field<CRM_Zone>("Name_EN");
            /// <summary>
            ///  - 字段名：IsDeleted - 数据类型：Boolean?
            /// </summary>
            public static Field IsDeleted = new Field<CRM_Zone>("IsDeleted");
        }
    }
}