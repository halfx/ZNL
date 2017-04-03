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
    /// 表名：SYS_UserGridColWidth 主键列：CWID
    /// </summary>
    [SerializableAttribute()]
    public partial class SYS_UserGridColWidth : BaseEntity
    {

        protected Int32 _CWID;

        protected Guid? _UserGUID;

        protected Guid? _DGGUID;

        protected String _ColName;

        protected Int32? _ColWidth;

        protected Guid? _CompanyID;

        /// <summary>
        /// 列宽度ID
        /// </summary>
        public Int32 CWID
        {
            get
            {
                return this._CWID;
            }
            set
            {
                this.OnPropertyValueChange(_.CWID, _CWID, value);
                this._CWID = value;
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
        /// 列顺序
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
        /// 列宽度
        /// </summary>
        public Int32? ColWidth
        {
            get
            {
                return this._ColWidth;
            }
            set
            {
                this.OnPropertyValueChange(_.ColWidth, _ColWidth, value);
                this._ColWidth = value;
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
            return new Table<SYS_UserGridColWidth>("SYS_UserGridColWidth");
        }

        /// <summary>
        /// 获取实体中的标识列
        /// </summary>
        protected override Field GetIdentityField()
        {
            return _.CWID;
        }

        /// <summary>
        /// 获取实体中的主键列
        /// </summary>
        protected override Field[] GetPrimaryKeyFields()
        {
            return new Field[] {
                        _.CWID};
        }

        /// <summary>
        /// 获取列信息
        /// </summary>
        protected override Field[] GetFields()
        {
            return new Field[] {
                        _.CWID,
                        _.UserGUID,
                        _.DGGUID,
                        _.ColName,
                        _.ColWidth,
                        _.CompanyID};
        }

        /// <summary>
        /// 获取列数据
        /// </summary>
        protected override object[] GetValues()
        {
            return new object[] {
                        this._CWID,
                        this._UserGUID,
                        this._DGGUID,
                        this._ColName,
                        this._ColWidth,
                        this._CompanyID};
        }

        /// <summary>
        /// 给当前实体赋值
        /// </summary>
        protected override void SetValues(IRowReader reader)
        {
            if ((false == reader.IsDBNull(_.CWID)))
            {
                this._CWID = reader.GetInt32(_.CWID);
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
            if ((false == reader.IsDBNull(_.ColWidth)))
            {
                this._ColWidth = reader.GetInt32(_.ColWidth);
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
            if ((false == typeof(SYS_UserGridColWidth).IsAssignableFrom(obj.GetType())))
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
            public static AllField All = new AllField<SYS_UserGridColWidth>();

            /// <summary>
            /// 列宽度ID - 字段名：CWID - 数据类型：Int32
            /// </summary>
            public static Field CWID = new Field<SYS_UserGridColWidth>("CWID");

            /// <summary>
            /// 用户GUID - 字段名：UserGUID - 数据类型：Nullable`1
            /// </summary>
            public static Field UserGUID = new Field<SYS_UserGridColWidth>("UserGUID");

            /// <summary>
            /// 字段名：DGGUID - 数据类型：Nullable`1
            /// </summary>
            public static Field DGGUID = new Field<SYS_UserGridColWidth>("DGGUID");

            /// <summary>
            /// 列顺序 - 字段名：ColName - 数据类型：String
            /// </summary>
            public static Field ColName = new Field<SYS_UserGridColWidth>("ColName");

            /// <summary>
            /// 列宽度 - 字段名：ColWidth - 数据类型：Nullable`1
            /// </summary>
            public static Field ColWidth = new Field<SYS_UserGridColWidth>("ColWidth");

            /// <summary>
            /// 注册公司ID - 字段名：CompanyID - 数据类型：Nullable`1
            /// </summary>
            public static Field CompanyID = new Field<SYS_UserGridColWidth>("CompanyID");
        }
    }
}
