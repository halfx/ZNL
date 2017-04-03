using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZNLCRM.Entity.DBModel
{
    using System;
    using MySoft.Data;
    using ZNLFrame.Entity;


    /// <summary>
    /// 表名：SYS_UserGridColIndex 主键列：CIID
    /// </summary>
    [SerializableAttribute()]
    public partial class SYS_UserGridColIndex : BaseEntity
    {

        protected Int32 _CIID;

        protected Guid? _UserGUID;

        protected Guid? _DGGUID;

        protected String _ColName;

        protected Int32? _DisplayIndex;

        protected Guid? _CompanyID;

        /// <summary>
        /// 列顺序ID
        /// </summary>
        public Int32 CIID
        {
            get
            {
                return this._CIID;
            }
            set
            {
                this.OnPropertyValueChange(_.CIID, _CIID, value);
                this._CIID = value;
            }
        }

        /// <summary>
        /// 用户GUID
        /// </summary>
        public Guid? UserGUID
        {
            get
            {
                return this._UserGUID;
            }
            set
            {
                this.OnPropertyValueChange(_.UserGUID, _UserGUID, value);
                this._UserGUID = value;
            }
        }

        public Guid? DGGUID
        {
            get
            {
                return this._DGGUID;
            }
            set
            {
                this.OnPropertyValueChange(_.DGGUID, _DGGUID, value);
                this._DGGUID = value;
            }
        }

        /// <summary>
        /// 列名
        /// </summary>
        public String ColName
        {
            get
            {
                return this._ColName;
            }
            set
            {
                this.OnPropertyValueChange(_.ColName, _ColName, value);
                this._ColName = value;
            }
        }

        /// <summary>
        /// 显示顺序
        /// </summary>
        public Int32? DisplayIndex
        {
            get
            {
                return this._DisplayIndex;
            }
            set
            {
                this.OnPropertyValueChange(_.DisplayIndex, _DisplayIndex, value);
                this._DisplayIndex = value;
            }
        }

        /// <summary>
        /// 注册公司ID
        /// </summary>
        public Guid? CompanyID
        {
            get
            {
                return this._CompanyID;
            }
            set
            {
                this.OnPropertyValueChange(_.CompanyID, _CompanyID, value);
                this._CompanyID = value;
            }
        }

        /// <summary>
        /// 获取实体对应的表名
        /// </summary>
        protected override Table GetTable()
        {
            return new Table<SYS_UserGridColIndex>("SYS_UserGridColIndex");
        }

        /// <summary>
        /// 获取实体中的标识列
        /// </summary>
        protected override Field GetIdentityField()
        {
            return _.CIID;
        }

        /// <summary>
        /// 获取实体中的主键列
        /// </summary>
        protected override Field[] GetPrimaryKeyFields()
        {
            return new Field[] {
                        _.CIID};
        }

        /// <summary>
        /// 获取列信息
        /// </summary>
        protected override Field[] GetFields()
        {
            return new Field[] {
                        _.CIID,
                        _.UserGUID,
                        _.DGGUID,
                        _.ColName,
                        _.DisplayIndex,
                        _.CompanyID};
        }

        /// <summary>
        /// 获取列数据
        /// </summary>
        protected override object[] GetValues()
        {
            return new object[] {
                        this._CIID,
                        this._UserGUID,
                        this._DGGUID,
                        this._ColName,
                        this._DisplayIndex,
                        this._CompanyID};
        }

        /// <summary>
        /// 给当前实体赋值
        /// </summary>
        protected override void SetValues(IRowReader reader)
        {
            if ((false == reader.IsDBNull(_.CIID)))
            {
                this._CIID = reader.GetInt32(_.CIID);
            }
            if ((false == reader.IsDBNull(_.UserGUID)))
            {
                this._UserGUID = reader.GetGuid(_.UserGUID);
            }
            if ((false == reader.IsDBNull(_.DGGUID)))
            {
                this._DGGUID = reader.GetGuid(_.DGGUID);
            }
            if ((false == reader.IsDBNull(_.ColName)))
            {
                this._ColName = reader.GetString(_.ColName);
            }
            if ((false == reader.IsDBNull(_.DisplayIndex)))
            {
                this._DisplayIndex = reader.GetInt32(_.DisplayIndex);
            }
            if ((false == reader.IsDBNull(_.CompanyID)))
            {
                this._CompanyID = reader.GetGuid(_.CompanyID);
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
            if ((false == typeof(SYS_UserGridColIndex).IsAssignableFrom(obj.GetType())))
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
            public static AllField All = new AllField<SYS_UserGridColIndex>();

            /// <summary>
            /// 列顺序ID - 字段名：CIID - 数据类型：Int32
            /// </summary>
            public static Field CIID = new Field<SYS_UserGridColIndex>("CIID");

            /// <summary>
            /// 用户GUID - 字段名：UserGUID - 数据类型：Nullable`1
            /// </summary>
            public static Field UserGUID = new Field<SYS_UserGridColIndex>("UserGUID");

            /// <summary>
            /// 字段名：DGGUID - 数据类型：Nullable`1
            /// </summary>
            public static Field DGGUID = new Field<SYS_UserGridColIndex>("DGGUID");

            /// <summary>
            /// 列名 - 字段名：ColName - 数据类型：String
            /// </summary>
            public static Field ColName = new Field<SYS_UserGridColIndex>("ColName");

            /// <summary>
            /// 显示顺序 - 字段名：DisplayIndex - 数据类型：Nullable`1
            /// </summary>
            public static Field DisplayIndex = new Field<SYS_UserGridColIndex>("DisplayIndex");

            /// <summary>
            /// 注册公司ID - 字段名：CompanyID - 数据类型：Nullable`1
            /// </summary>
            public static Field CompanyID = new Field<SYS_UserGridColIndex>("CompanyID");
        }
    }
}
