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
    /// 表名：SYS_DataGrid 主键列：DGID
    /// </summary>
    [SerializableAttribute()]
    public partial class SYS_DataGrid : BaseEntity
    {

        protected Int32 _DGID;

        protected Guid? _DGGUID;

        protected String _GridName;

        protected String _FormName;

        protected String _ParentName;

        /// <summary>
        /// 表格ID
        /// </summary>
        public Int32 DGID
        {
            get
            {
                return this._DGID;
            }
            set
            {
                this.OnPropertyValueChange(_.DGID, _DGID, value);
                this._DGID = value;
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
        /// 表格名称
        /// </summary>
        public String GridName
        {
            get
            {
                return this._GridName;
            }
            set
            {
                this.OnPropertyValueChange(_.GridName, _GridName, value);
                this._GridName = value;
            }
        }

        /// <summary>
        /// 表格编码
        /// </summary>
        public String FormName
        {
            get
            {
                return this._FormName;
            }
            set
            {
                this.OnPropertyValueChange(_.FormName, _FormName, value);
                this._FormName = value;
            }
        }

        /// <summary>
        /// 父级名称（包涵表格的窗体、用户控件名称）
        /// </summary>
        public String ParentName
        {
            get
            {
                return this._ParentName;
            }
            set
            {
                this.OnPropertyValueChange(_.ParentName, _ParentName, value);
                this._ParentName = value;
            }
        }

        /// <summary>
        /// 获取实体对应的表名
        /// </summary>
        protected override Table GetTable()
        {
            return new Table<SYS_DataGrid>("SYS_DataGrid");
        }

        /// <summary>
        /// 获取实体中的标识列
        /// </summary>
        protected override Field GetIdentityField()
        {
            return _.DGID;
        }

        /// <summary>
        /// 获取实体中的主键列
        /// </summary>
        protected override Field[] GetPrimaryKeyFields()
        {
            return new Field[] {
                        _.DGID};
        }

        /// <summary>
        /// 获取列信息
        /// </summary>
        protected override Field[] GetFields()
        {
            return new Field[] {
                        _.DGID,
                        _.DGGUID,
                        _.GridName,
                        _.FormName,
                        _.ParentName};
        }

        /// <summary>
        /// 获取列数据
        /// </summary>
        protected override object[] GetValues()
        {
            return new object[] {
                        this._DGID,
                        this._DGGUID,
                        this._GridName,
                        this._FormName,
                        this._ParentName};
        }

        /// <summary>
        /// 给当前实体赋值
        /// </summary>
        protected override void SetValues(IRowReader reader)
        {
            if ((false == reader.IsDBNull(_.DGID)))
            {
                this._DGID = reader.GetInt32(_.DGID);
            }
            if ((false == reader.IsDBNull(_.DGGUID)))
            {
                this._DGGUID = reader.GetGuid(_.DGGUID);
            }
            if ((false == reader.IsDBNull(_.GridName)))
            {
                this._GridName = reader.GetString(_.GridName);
            }
            if ((false == reader.IsDBNull(_.FormName)))
            {
                this._FormName = reader.GetString(_.FormName);
            }
            if ((false == reader.IsDBNull(_.ParentName)))
            {
                this._ParentName = reader.GetString(_.ParentName);
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
            if ((false == typeof(SYS_DataGrid).IsAssignableFrom(obj.GetType())))
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
            public static AllField All = new AllField<SYS_DataGrid>();

            /// <summary>
            /// 表格ID - 字段名：DGID - 数据类型：Int32
            /// </summary>
            public static Field DGID = new Field<SYS_DataGrid>("DGID");

            /// <summary>
            /// 字段名：DGGUID - 数据类型：Nullable`1
            /// </summary>
            public static Field DGGUID = new Field<SYS_DataGrid>("DGGUID");

            /// <summary>
            /// 表格名称 - 字段名：GridName - 数据类型：String
            /// </summary>
            public static Field GridName = new Field<SYS_DataGrid>("GridName");

            /// <summary>
            /// 表格编码 - 字段名：FormName - 数据类型：String
            /// </summary>
            public static Field FormName = new Field<SYS_DataGrid>("FormName");

            /// <summary>
            /// 父级名称（包涵表格的窗体、用户控件名称） - 字段名：ParentName - 数据类型：String
            /// </summary>
            public static Field ParentName = new Field<SYS_DataGrid>("ParentName");
        }
    }
}
