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
    /// 表名：SYS_UserGridColName 主键列：CNID
    /// </summary>
    [SerializableAttribute()]
    public partial class SYS_UserGridColName : BaseEntity
    {

        protected Int32 _CNID;

        protected Guid? _UserGUID;

        protected Guid? _DGGUID;

        protected String _ColNameCode;

        protected String _ColNameCN_Default;

        protected String _ColNameCN_Custom;

        protected Boolean? _ColIsShow;

        protected Guid? _CompanyID;

        /// <summary>
        /// 自增ID
        /// </summary>
        public Int32 CNID
        {
            get
            {
                return this._CNID;
            }
            set
            {
                this.OnPropertyValueChange(_.CNID, _CNID, value);
                this._CNID = value;
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

        /// <summary>
        /// 表格GUID
        /// </summary>
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
        /// 列名(代码)
        /// </summary>
        public String ColNameCode
        {
            get
            {
                return this._ColNameCode;
            }
            set
            {
                this.OnPropertyValueChange(_.ColNameCode, _ColNameCode, value);
                this._ColNameCode = value;
            }
        }

        /// <summary>
        /// 默认列名
        /// </summary>
        public String ColNameCN_Default
        {
            get
            {
                return this._ColNameCN_Default;
            }
            set
            {
                this.OnPropertyValueChange(_.ColNameCN_Default, _ColNameCN_Default, value);
                this._ColNameCN_Default = value;
            }
        }

        /// <summary>
        /// 自定义列名
        /// </summary>
        public String ColNameCN_Custom
        {
            get
            {
                return this._ColNameCN_Custom;
            }
            set
            {
                this.OnPropertyValueChange(_.ColNameCN_Custom, _ColNameCN_Custom, value);
                this._ColNameCN_Custom = value;
            }
        }

        /// <summary>
        /// 是否显示
        /// </summary>
        public Boolean? ColIsShow
        {
            get
            {
                return this._ColIsShow;
            }
            set
            {
                this.OnPropertyValueChange(_.ColIsShow, _ColIsShow, value);
                this._ColIsShow = value;
            }
        }

        /// <summary>
        /// 公司GUID
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
            return new Table<SYS_UserGridColName>("SYS_UserGridColName");
        }

        /// <summary>
        /// 获取实体中的标识列
        /// </summary>
        protected override Field GetIdentityField()
        {
            return _.CNID;
        }

        /// <summary>
        /// 获取实体中的主键列
        /// </summary>
        protected override Field[] GetPrimaryKeyFields()
        {
            return new Field[] {
                        _.CNID};
        }

        /// <summary>
        /// 获取列信息
        /// </summary>
        protected override Field[] GetFields()
        {
            return new Field[] {
                        _.CNID,
                        _.UserGUID,
                        _.DGGUID,
                        _.ColNameCode,
                        _.ColNameCN_Default,
                        _.ColNameCN_Custom,
                        _.ColIsShow,
                        _.CompanyID};
        }

        /// <summary>
        /// 获取列数据
        /// </summary>
        protected override object[] GetValues()
        {
            return new object[] {
                        this._CNID,
                        this._UserGUID,
                        this._DGGUID,
                        this._ColNameCode,
                        this._ColNameCN_Default,
                        this._ColNameCN_Custom,
                        this._ColIsShow,
                        this._CompanyID};
        }

        /// <summary>
        /// 给当前实体赋值
        /// </summary>
        protected override void SetValues(IRowReader reader)
        {
            if ((false == reader.IsDBNull(_.CNID)))
            {
                this._CNID = reader.GetInt32(_.CNID);
            }
            if ((false == reader.IsDBNull(_.UserGUID)))
            {
                this._UserGUID = reader.GetGuid(_.UserGUID);
            }
            if ((false == reader.IsDBNull(_.DGGUID)))
            {
                this._DGGUID = reader.GetGuid(_.DGGUID);
            }
            if ((false == reader.IsDBNull(_.ColNameCode)))
            {
                this._ColNameCode = reader.GetString(_.ColNameCode);
            }
            if ((false == reader.IsDBNull(_.ColNameCN_Default)))
            {
                this._ColNameCN_Default = reader.GetString(_.ColNameCN_Default);
            }
            if ((false == reader.IsDBNull(_.ColNameCN_Custom)))
            {
                this._ColNameCN_Custom = reader.GetString(_.ColNameCN_Custom);
            }
            if ((false == reader.IsDBNull(_.ColIsShow)))
            {
                this._ColIsShow = reader.GetBoolean(_.ColIsShow);
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
            if ((false == typeof(SYS_UserGridColName).IsAssignableFrom(obj.GetType())))
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
            public static AllField All = new AllField<SYS_UserGridColName>();

            /// <summary>
            /// 自增ID - 字段名：CNID - 数据类型：Int32
            /// </summary>
            public static Field CNID = new Field<SYS_UserGridColName>("CNID");

            /// <summary>
            /// 用户GUID - 字段名：UserGUID - 数据类型：Nullable`1
            /// </summary>
            public static Field UserGUID = new Field<SYS_UserGridColName>("UserGUID");

            /// <summary>
            /// 表格GUID - 字段名：DGGUID - 数据类型：Nullable`1
            /// </summary>
            public static Field DGGUID = new Field<SYS_UserGridColName>("DGGUID");

            /// <summary>
            /// 列名(代码) - 字段名：ColNameCode - 数据类型：String
            /// </summary>
            public static Field ColNameCode = new Field<SYS_UserGridColName>("ColNameCode");

            /// <summary>
            /// 默认列名 - 字段名：ColNameCN_Default - 数据类型：String
            /// </summary>
            public static Field ColNameCN_Default = new Field<SYS_UserGridColName>("ColNameCN_Default");

            /// <summary>
            /// 自定义列名 - 字段名：ColNameCN_Custom - 数据类型：String
            /// </summary>
            public static Field ColNameCN_Custom = new Field<SYS_UserGridColName>("ColNameCN_Custom");

            /// <summary>
            /// 是否显示 - 字段名：ColIsShow - 数据类型：Nullable`1
            /// </summary>
            public static Field ColIsShow = new Field<SYS_UserGridColName>("ColIsShow");

            /// <summary>
            /// 公司GUID - 字段名：CompanyID - 数据类型：Nullable`1
            /// </summary>
            public static Field CompanyID = new Field<SYS_UserGridColName>("CompanyID");
        }
    }
}
