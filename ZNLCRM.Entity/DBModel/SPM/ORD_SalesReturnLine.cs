//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by CodeSmith Template.
//
//     Creater: David
//     Date:    2015/3/6
//     Time:    11:08
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
    /// 表名：ORD_SalesReturnLine 主键列：SRLineGuid
    /// </summary>
    [SerializableAttribute()]
	public partial class ORD_SalesReturnLine : BaseEntity
	{
		#region Private Properties
		
		private Int32? _SRLineID;
		private Guid? _SRLineGuid;
		private Guid? _SRGuid;
		private Guid? _GCompanyID;
		private Guid? _SOGuid;
		private String _SOBillNo;
		private Guid? _SOLineGuid;
		private Guid? _StkOutGuid;
		private String _StkOutBillNo;
		private Guid? _StkOutLineGuid;
		private Int32? _BuyerID;
		private String _BuyerName;
		private Guid? _StkInLineGuid;
		private Guid? _ItemCode;
		private String _Model;
		private String _Brand;
		private String _Batch;
		private String _Package;
		private String _Quality;
		private String _MPQ;
		private String _MarkCode;
		private String _InvType;
		private String _Warehouse;
		private String _Location;
		private Int32? _Qty;
		private Int32? _StkInOccQty;
		private Int32? _StkInQty;
		private String _Unit;
		private Decimal? _UnitPrice;
		private String _Currency;
		private Decimal? _Amount;
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
		/// 销售退货明细guid.
		/// </summary>
		public Guid? SRLineGuid
		{
			get 
			{
				return _SRLineGuid;
			}
			set 
			{
				this.OnPropertyValueChange(_.SRLineGuid, _SRLineGuid , value);
				this._SRLineGuid = value;
			}
		}
		
		/// <summary>
		/// 销售退货明细ID.
		/// </summary>
		public Int32? SRLineID
		{
			get 
			{
				return this._SRLineID;
			}
			set 
			{
				this.OnPropertyValueChange(_.SRLineID, _SRLineID , value);
				this._SRLineID = value;
			}
		}

		/// <summary>
		/// 销售退货guid.
		/// </summary>
		public Guid? SRGuid
		{
			get 
			{
				return this._SRGuid;
			}
			set 
			{
				this.OnPropertyValueChange(_.SRGuid, _SRGuid , value);
				this._SRGuid = value;
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
				this.OnPropertyValueChange(_.GCompanyID, _GCompanyID , value);
				this._GCompanyID = value;
			}
		}

		/// <summary>
		/// 销售单guid.
		/// </summary>
		public Guid? SOGuid
		{
			get 
			{
				return this._SOGuid;
			}
			set 
			{
				this.OnPropertyValueChange(_.SOGuid, _SOGuid , value);
				this._SOGuid = value;
			}
		}

		/// <summary>
		/// 销售单号.
		/// </summary>
		public String SOBillNo
		{
			get 
			{
				return this._SOBillNo;
			}
			set 
			{
				this.OnPropertyValueChange(_.SOBillNo, _SOBillNo , value);
				this._SOBillNo = value.SubStr(20);
			}
		}

		/// <summary>
		/// 销售明细Guid.
		/// </summary>
		public Guid? SOLineGuid
		{
			get 
			{
				return this._SOLineGuid;
			}
			set 
			{
				this.OnPropertyValueChange(_.SOLineGuid, _SOLineGuid , value);
				this._SOLineGuid = value;
			}
		}

		/// <summary>
		/// 出库单Guid.
		/// </summary>
		public Guid? StkOutGuid
		{
			get 
			{
				return this._StkOutGuid;
			}
			set 
			{
				this.OnPropertyValueChange(_.StkOutGuid, _StkOutGuid , value);
				this._StkOutGuid = value;
			}
		}

		/// <summary>
		/// 出库单号.
		/// </summary>
		public String StkOutBillNo
		{
			get 
			{
				return this._StkOutBillNo;
			}
			set 
			{
				this.OnPropertyValueChange(_.StkOutBillNo, _StkOutBillNo , value);
				this._StkOutBillNo = value.SubStr(20);
			}
		}

		/// <summary>
		/// 出库明细guid.
		/// </summary>
		public Guid? StkOutLineGuid
		{
			get 
			{
				return this._StkOutLineGuid;
			}
			set 
			{
				this.OnPropertyValueChange(_.StkOutLineGuid, _StkOutLineGuid , value);
				this._StkOutLineGuid = value;
			}
		}

		/// <summary>
		/// .
		/// </summary>
		public Int32? BuyerID
		{
			get 
			{
				return this._BuyerID;
			}
			set 
			{
				this.OnPropertyValueChange(_.BuyerID, _BuyerID , value);
				this._BuyerID = value;
			}
		}

		/// <summary>
		/// .
		/// </summary>
		public String BuyerName
		{
			get 
			{
				return this._BuyerName;
			}
			set 
			{
				this.OnPropertyValueChange(_.BuyerName, _BuyerName , value);
				this._BuyerName = value.SubStr(50);
			}
		}

		/// <summary>
		/// 入库单明细guid.
		/// </summary>
		public Guid? StkInLineGuid
		{
			get 
			{
				return this._StkInLineGuid;
			}
			set 
			{
				this.OnPropertyValueChange(_.StkInLineGuid, _StkInLineGuid , value);
				this._StkInLineGuid = value;
			}
		}

		/// <summary>
		/// 库存ID.
		/// </summary>
		public Guid? ItemCode
		{
			get 
			{
				return this._ItemCode;
			}
			set 
			{
				this.OnPropertyValueChange(_.ItemCode, _ItemCode , value);
				this._ItemCode = value;
			}
		}

		/// <summary>
		/// 型号.
		/// </summary>
		public String Model
		{
			get 
			{
				return this._Model;
			}
			set 
			{
				this.OnPropertyValueChange(_.Model, _Model , value);
				this._Model = value.SubStr(50);
			}
		}

		/// <summary>
		/// 品牌.
		/// </summary>
		public String Brand
		{
			get 
			{
				return this._Brand;
			}
			set 
			{
				this.OnPropertyValueChange(_.Brand, _Brand , value);
				this._Brand = value.SubStr(50);
			}
		}

		/// <summary>
		/// 批号.
		/// </summary>
		public String Batch
		{
			get 
			{
				return this._Batch;
			}
			set 
			{
				this.OnPropertyValueChange(_.Batch, _Batch , value);
				this._Batch = value.SubStr(50);
			}
		}

		/// <summary>
		/// 封装.
		/// </summary>
		public String Package
		{
			get 
			{
				return this._Package;
			}
			set 
			{
				this.OnPropertyValueChange(_.Package, _Package , value);
				this._Package = value.SubStr(50);
			}
		}

		/// <summary>
		/// 品质.
		/// </summary>
		public String Quality
		{
			get 
			{
				return this._Quality;
			}
			set 
			{
				this.OnPropertyValueChange(_.Quality, _Quality , value);
				this._Quality = value.SubStr(50);
			}
		}

		/// <summary>
		/// 包装.
		/// </summary>
		public String MPQ
		{
			get 
			{
				return this._MPQ;
			}
			set 
			{
				this.OnPropertyValueChange(_.MPQ, _MPQ , value);
				this._MPQ = value.SubStr(50);
			}
		}

		/// <summary>
		/// 标记码.
		/// </summary>
		public String MarkCode
		{
			get 
			{
				return this._MarkCode;
			}
			set 
			{
				this.OnPropertyValueChange(_.MarkCode, _MarkCode , value);
				this._MarkCode = value.SubStr(50);
			}
		}

		/// <summary>
		/// 库存类型.
		/// </summary>
		public String InvType
		{
			get 
			{
				return this._InvType;
			}
			set 
			{
				this.OnPropertyValueChange(_.InvType, _InvType , value);
				this._InvType = value.SubStr(50);
			}
		}

		/// <summary>
		/// 仓库.
		/// </summary>
		public String Warehouse
		{
			get 
			{
				return this._Warehouse;
			}
			set 
			{
				this.OnPropertyValueChange(_.Warehouse, _Warehouse , value);
				this._Warehouse = value.SubStr(30);
			}
		}

		/// <summary>
		/// 位置.
		/// </summary>
		public String Location
		{
			get 
			{
				return this._Location;
			}
			set 
			{
				this.OnPropertyValueChange(_.Location, _Location , value);
				this._Location = value.SubStr(30);
			}
		}

		/// <summary>
		/// 退货数量.
		/// </summary>
		public Int32? Qty
		{
			get 
			{
				return this._Qty;
			}
			set 
			{
				this.OnPropertyValueChange(_.Qty, _Qty , value);
				this._Qty = value;
			}
		}

		/// <summary>
		/// 入库占有数量.
		/// </summary>
		public Int32? StkInOccQty
		{
			get 
			{
				return this._StkInOccQty;
			}
			set 
			{
				this.OnPropertyValueChange(_.StkInOccQty, _StkInOccQty , value);
				this._StkInOccQty = value;
			}
		}

		/// <summary>
		/// 入库数量.
		/// </summary>
		public Int32? StkInQty
		{
			get 
			{
				return this._StkInQty;
			}
			set 
			{
				this.OnPropertyValueChange(_.StkInQty, _StkInQty , value);
				this._StkInQty = value;
			}
		}

		/// <summary>
		/// 单位.
		/// </summary>
		public String Unit
		{
			get 
			{
				return this._Unit;
			}
			set 
			{
				this.OnPropertyValueChange(_.Unit, _Unit , value);
				this._Unit = value.SubStr(10);
			}
		}

		/// <summary>
		/// .
		/// </summary>
		public Decimal? UnitPrice
		{
			get 
			{
				return this._UnitPrice;
			}
			set 
			{
				this.OnPropertyValueChange(_.UnitPrice, _UnitPrice , value);
				this._UnitPrice = value;
			}
		}

		/// <summary>
		/// 币种.
		/// </summary>
		public String Currency
		{
			get 
			{
				return this._Currency;
			}
			set 
			{
				this.OnPropertyValueChange(_.Currency, _Currency , value);
				this._Currency = value.SubStr(10);
			}
		}

		/// <summary>
		/// .
		/// </summary>
		public Decimal? Amount
		{
			get 
			{
				return this._Amount;
			}
			set 
			{
				this.OnPropertyValueChange(_.Amount, _Amount , value);
				this._Amount = value;
			}
		}

		/// <summary>
		/// .
		/// </summary>
		public Int32? CreatedEmpID
		{
			get 
			{
				return this._CreatedEmpID;
			}
			set 
			{
				this.OnPropertyValueChange(_.CreatedEmpID, _CreatedEmpID , value);
				this._CreatedEmpID = value;
			}
		}

		/// <summary>
		/// .
		/// </summary>
		public String CreatedEmpName
		{
			get 
			{
				return this._CreatedEmpName;
			}
			set 
			{
				this.OnPropertyValueChange(_.CreatedEmpName, _CreatedEmpName , value);
				this._CreatedEmpName = value.SubStr(50);
			}
		}

		/// <summary>
		/// .
		/// </summary>
		public DateTime? CreatedTime
		{
			get 
			{
				return this._CreatedTime;
			}
			set 
			{
				this.OnPropertyValueChange(_.CreatedTime, _CreatedTime , value);
				this._CreatedTime = value;
			}
		}

		/// <summary>
		/// .
		/// </summary>
		public Int32? UpdatedEmpID
		{
			get 
			{
				return this._UpdatedEmpID;
			}
			set 
			{
				this.OnPropertyValueChange(_.UpdatedEmpID, _UpdatedEmpID , value);
				this._UpdatedEmpID = value;
			}
		}

		/// <summary>
		/// .
		/// </summary>
		public String UpdatedEmpName
		{
			get 
			{
				return this._UpdatedEmpName;
			}
			set 
			{
				this.OnPropertyValueChange(_.UpdatedEmpName, _UpdatedEmpName , value);
				this._UpdatedEmpName = value.SubStr(50);
			}
		}

		/// <summary>
		/// .
		/// </summary>
		public DateTime? UpdatedTime
		{
			get 
			{
				return this._UpdatedTime;
			}
			set 
			{
				this.OnPropertyValueChange(_.UpdatedTime, _UpdatedTime , value);
				this._UpdatedTime = value;
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
				this.OnPropertyValueChange(_.IsDeleted, _IsDeleted , value);
				this._IsDeleted = value;
			}
		}
		
		#endregion
	    /// <summary>
        /// 获取实体对应的表名
        /// </summary>
        protected override Table GetTable() {
            return new Table< ORD_SalesReturnLine >("ORD_SalesReturnLine");
        }
		
        /// <summary>
        /// 获取实体中的标识列
        /// </summary>
        protected override Field GetIdentityField() {
            return _.SRLineID;
        }  			
		
        /// <summary>
        /// 获取实体中的主键列
        /// </summary>
        protected override Field[] GetPrimaryKeyFields() {
            return new Field[] {
				_.SRLineGuid
			};
        }
			
	    /// <summary>
        /// 获取列信息
        /// </summary>
        protected override Field[] GetFields() {
            return new Field[] {
				_.SRLineID,		
				_.SRLineGuid,		
				_.SRGuid,		
				_.GCompanyID,		
				_.SOGuid,		
				_.SOBillNo,		
				_.SOLineGuid,		
				_.StkOutGuid,		
				_.StkOutBillNo,		
				_.StkOutLineGuid,		
				_.BuyerID,		
				_.BuyerName,		
				_.StkInLineGuid,		
				_.ItemCode,		
				_.Model,		
				_.Brand,		
				_.Batch,		
				_.Package,		
				_.Quality,		
				_.MPQ,		
				_.MarkCode,		
				_.InvType,		
				_.Warehouse,		
				_.Location,		
				_.Qty,		
				_.StkInOccQty,		
				_.StkInQty,		
				_.Unit,		
				_.UnitPrice,		
				_.Currency,		
				_.Amount,		
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
        protected override object[] GetValues() {
            return new object[] {
				this._SRLineID,		
				this._SRLineGuid,		
				this._SRGuid,		
				this._GCompanyID,		
				this._SOGuid,		
				this._SOBillNo,		
				this._SOLineGuid,		
				this._StkOutGuid,		
				this._StkOutBillNo,		
				this._StkOutLineGuid,		
				this._BuyerID,		
				this._BuyerName,		
				this._StkInLineGuid,		
				this._ItemCode,		
				this._Model,		
				this._Brand,		
				this._Batch,		
				this._Package,		
				this._Quality,		
				this._MPQ,		
				this._MarkCode,		
				this._InvType,		
				this._Warehouse,		
				this._Location,		
				this._Qty,		
				this._StkInOccQty,		
				this._StkInQty,		
				this._Unit,		
				this._UnitPrice,		
				this._Currency,		
				this._Amount,		
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
        protected override void SetValues(IRowReader reader) {
            if ((false == reader.IsDBNull(_.SRLineID))) {
                this._SRLineID = reader.GetInt32(_.SRLineID);
            }
            if ((false == reader.IsDBNull(_.SRLineGuid))) {
                this._SRLineGuid = reader.GetGuid(_.SRLineGuid);
            }
            if ((false == reader.IsDBNull(_.SRGuid))) {
                this._SRGuid = reader.GetGuid(_.SRGuid);
            }
            if ((false == reader.IsDBNull(_.GCompanyID))) {
                this._GCompanyID = reader.GetGuid(_.GCompanyID);
            }
            if ((false == reader.IsDBNull(_.SOGuid))) {
                this._SOGuid = reader.GetGuid(_.SOGuid);
            }
            if ((false == reader.IsDBNull(_.SOBillNo))) {
                this._SOBillNo = reader.GetString(_.SOBillNo);
            }
            if ((false == reader.IsDBNull(_.SOLineGuid))) {
                this._SOLineGuid = reader.GetGuid(_.SOLineGuid);
            }
            if ((false == reader.IsDBNull(_.StkOutGuid))) {
                this._StkOutGuid = reader.GetGuid(_.StkOutGuid);
            }
            if ((false == reader.IsDBNull(_.StkOutBillNo))) {
                this._StkOutBillNo = reader.GetString(_.StkOutBillNo);
            }
            if ((false == reader.IsDBNull(_.StkOutLineGuid))) {
                this._StkOutLineGuid = reader.GetGuid(_.StkOutLineGuid);
            }
            if ((false == reader.IsDBNull(_.BuyerID))) {
                this._BuyerID = reader.GetInt32(_.BuyerID);
            }
            if ((false == reader.IsDBNull(_.BuyerName))) {
                this._BuyerName = reader.GetString(_.BuyerName);
            }
            if ((false == reader.IsDBNull(_.StkInLineGuid))) {
                this._StkInLineGuid = reader.GetGuid(_.StkInLineGuid);
            }
            if ((false == reader.IsDBNull(_.ItemCode))) {
                this._ItemCode = reader.GetGuid(_.ItemCode);
            }
            if ((false == reader.IsDBNull(_.Model))) {
                this._Model = reader.GetString(_.Model);
            }
            if ((false == reader.IsDBNull(_.Brand))) {
                this._Brand = reader.GetString(_.Brand);
            }
            if ((false == reader.IsDBNull(_.Batch))) {
                this._Batch = reader.GetString(_.Batch);
            }
            if ((false == reader.IsDBNull(_.Package))) {
                this._Package = reader.GetString(_.Package);
            }
            if ((false == reader.IsDBNull(_.Quality))) {
                this._Quality = reader.GetString(_.Quality);
            }
            if ((false == reader.IsDBNull(_.MPQ))) {
                this._MPQ = reader.GetString(_.MPQ);
            }
            if ((false == reader.IsDBNull(_.MarkCode))) {
                this._MarkCode = reader.GetString(_.MarkCode);
            }
            if ((false == reader.IsDBNull(_.InvType))) {
                this._InvType = reader.GetString(_.InvType);
            }
            if ((false == reader.IsDBNull(_.Warehouse))) {
                this._Warehouse = reader.GetString(_.Warehouse);
            }
            if ((false == reader.IsDBNull(_.Location))) {
                this._Location = reader.GetString(_.Location);
            }
            if ((false == reader.IsDBNull(_.Qty))) {
                this._Qty = reader.GetInt32(_.Qty);
            }
            if ((false == reader.IsDBNull(_.StkInOccQty))) {
                this._StkInOccQty = reader.GetInt32(_.StkInOccQty);
            }
            if ((false == reader.IsDBNull(_.StkInQty))) {
                this._StkInQty = reader.GetInt32(_.StkInQty);
            }
            if ((false == reader.IsDBNull(_.Unit))) {
                this._Unit = reader.GetString(_.Unit);
            }
            if ((false == reader.IsDBNull(_.UnitPrice))) {
                this._UnitPrice = reader.GetDecimal(_.UnitPrice);
            }
            if ((false == reader.IsDBNull(_.Currency))) {
                this._Currency = reader.GetString(_.Currency);
            }
            if ((false == reader.IsDBNull(_.Amount))) {
                this._Amount = reader.GetDecimal(_.Amount);
            }
            if ((false == reader.IsDBNull(_.CreatedEmpID))) {
                this._CreatedEmpID = reader.GetInt32(_.CreatedEmpID);
            }
            if ((false == reader.IsDBNull(_.CreatedEmpName))) {
                this._CreatedEmpName = reader.GetString(_.CreatedEmpName);
            }
            if ((false == reader.IsDBNull(_.CreatedTime))) {
                this._CreatedTime = reader.GetDateTime(_.CreatedTime);
            }
            if ((false == reader.IsDBNull(_.UpdatedEmpID))) {
                this._UpdatedEmpID = reader.GetInt32(_.UpdatedEmpID);
            }
            if ((false == reader.IsDBNull(_.UpdatedEmpName))) {
                this._UpdatedEmpName = reader.GetString(_.UpdatedEmpName);
            }
            if ((false == reader.IsDBNull(_.UpdatedTime))) {
                this._UpdatedTime = reader.GetDateTime(_.UpdatedTime);
            }
            if ((false == reader.IsDBNull(_.IsDeleted))) {
                this._IsDeleted = reader.GetBoolean(_.IsDeleted);
            }
		}
		
	    public override int GetHashCode() {
            return base.GetHashCode();
        }
        
        public override bool Equals(object obj) {
            if ((obj == null)) {
                return false;
            }
            if ((false == typeof(ORD_SalesReturnLine).IsAssignableFrom(obj.GetType()))) {
                return false;
            }
            if ((((object)(this)) == ((object)(obj)))) {
                return true;
            }
            return false;
        }
		
        public class _ {
                
            /// <summary>
            /// 表示选择所有列，与*等同
            /// </summary>
            public static AllField All = new AllField< ORD_SalesReturnLine >();
			
		    /// <summary>
            /// 销售退货明细ID - 字段名：SRLineID - 数据类型：Int32?
            /// </summary>
            public static Field SRLineID = new Field< ORD_SalesReturnLine >("SRLineID");
		    /// <summary>
            /// 销售退货明细guid - 字段名：SRLineGuid - 数据类型：Guid?
            /// </summary>
            public static Field SRLineGuid = new Field< ORD_SalesReturnLine >("SRLineGuid");
		    /// <summary>
            /// 销售退货guid - 字段名：SRGuid - 数据类型：Guid?
            /// </summary>
            public static Field SRGuid = new Field< ORD_SalesReturnLine >("SRGuid");
		    /// <summary>
            ///  - 字段名：GCompanyID - 数据类型：Guid?
            /// </summary>
            public static Field GCompanyID = new Field< ORD_SalesReturnLine >("GCompanyID");
		    /// <summary>
            /// 销售单guid - 字段名：SOGuid - 数据类型：Guid?
            /// </summary>
            public static Field SOGuid = new Field< ORD_SalesReturnLine >("SOGuid");
		    /// <summary>
            /// 销售单号 - 字段名：SOBillNo - 数据类型：String
            /// </summary>
            public static Field SOBillNo = new Field< ORD_SalesReturnLine >("SOBillNo");
		    /// <summary>
            /// 销售明细Guid - 字段名：SOLineGuid - 数据类型：Guid?
            /// </summary>
            public static Field SOLineGuid = new Field< ORD_SalesReturnLine >("SOLineGuid");
		    /// <summary>
            /// 出库单Guid - 字段名：StkOutGuid - 数据类型：Guid?
            /// </summary>
            public static Field StkOutGuid = new Field< ORD_SalesReturnLine >("StkOutGuid");
		    /// <summary>
            /// 出库单号 - 字段名：StkOutBillNo - 数据类型：String
            /// </summary>
            public static Field StkOutBillNo = new Field< ORD_SalesReturnLine >("StkOutBillNo");
		    /// <summary>
            /// 出库明细guid - 字段名：StkOutLineGuid - 数据类型：Guid?
            /// </summary>
            public static Field StkOutLineGuid = new Field< ORD_SalesReturnLine >("StkOutLineGuid");
		    /// <summary>
            ///  - 字段名：BuyerID - 数据类型：Int32?
            /// </summary>
            public static Field BuyerID = new Field< ORD_SalesReturnLine >("BuyerID");
		    /// <summary>
            ///  - 字段名：BuyerName - 数据类型：String
            /// </summary>
            public static Field BuyerName = new Field< ORD_SalesReturnLine >("BuyerName");
		    /// <summary>
            /// 入库单明细guid - 字段名：StkInLineGuid - 数据类型：Guid?
            /// </summary>
            public static Field StkInLineGuid = new Field< ORD_SalesReturnLine >("StkInLineGuid");
		    /// <summary>
            /// 库存ID - 字段名：ItemCode - 数据类型：Guid?
            /// </summary>
            public static Field ItemCode = new Field< ORD_SalesReturnLine >("ItemCode");
		    /// <summary>
            /// 型号 - 字段名：Model - 数据类型：String
            /// </summary>
            public static Field Model = new Field< ORD_SalesReturnLine >("Model");
		    /// <summary>
            /// 品牌 - 字段名：Brand - 数据类型：String
            /// </summary>
            public static Field Brand = new Field< ORD_SalesReturnLine >("Brand");
		    /// <summary>
            /// 批号 - 字段名：Batch - 数据类型：String
            /// </summary>
            public static Field Batch = new Field< ORD_SalesReturnLine >("Batch");
		    /// <summary>
            /// 封装 - 字段名：Package - 数据类型：String
            /// </summary>
            public static Field Package = new Field< ORD_SalesReturnLine >("Package");
		    /// <summary>
            /// 品质 - 字段名：Quality - 数据类型：String
            /// </summary>
            public static Field Quality = new Field< ORD_SalesReturnLine >("Quality");
		    /// <summary>
            /// 包装 - 字段名：MPQ - 数据类型：String
            /// </summary>
            public static Field MPQ = new Field< ORD_SalesReturnLine >("MPQ");
		    /// <summary>
            /// 标记码 - 字段名：MarkCode - 数据类型：String
            /// </summary>
            public static Field MarkCode = new Field< ORD_SalesReturnLine >("MarkCode");
		    /// <summary>
            /// 库存类型 - 字段名：InvType - 数据类型：String
            /// </summary>
            public static Field InvType = new Field< ORD_SalesReturnLine >("InvType");
		    /// <summary>
            /// 仓库 - 字段名：Warehouse - 数据类型：String
            /// </summary>
            public static Field Warehouse = new Field< ORD_SalesReturnLine >("Warehouse");
		    /// <summary>
            /// 位置 - 字段名：Location - 数据类型：String
            /// </summary>
            public static Field Location = new Field< ORD_SalesReturnLine >("Location");
		    /// <summary>
            /// 退货数量 - 字段名：Qty - 数据类型：Int32?
            /// </summary>
            public static Field Qty = new Field< ORD_SalesReturnLine >("Qty");
		    /// <summary>
            /// 入库占有数量 - 字段名：StkInOccQty - 数据类型：Int32?
            /// </summary>
            public static Field StkInOccQty = new Field< ORD_SalesReturnLine >("StkInOccQty");
		    /// <summary>
            /// 入库数量 - 字段名：StkInQty - 数据类型：Int32?
            /// </summary>
            public static Field StkInQty = new Field< ORD_SalesReturnLine >("StkInQty");
		    /// <summary>
            /// 单位 - 字段名：Unit - 数据类型：String
            /// </summary>
            public static Field Unit = new Field< ORD_SalesReturnLine >("Unit");
		    /// <summary>
            ///  - 字段名：UnitPrice - 数据类型：Decimal?
            /// </summary>
            public static Field UnitPrice = new Field< ORD_SalesReturnLine >("UnitPrice");
		    /// <summary>
            /// 币种 - 字段名：Currency - 数据类型：String
            /// </summary>
            public static Field Currency = new Field< ORD_SalesReturnLine >("Currency");
		    /// <summary>
            ///  - 字段名：Amount - 数据类型：Decimal?
            /// </summary>
            public static Field Amount = new Field< ORD_SalesReturnLine >("Amount");
		    /// <summary>
            ///  - 字段名：CreatedEmpID - 数据类型：Int32?
            /// </summary>
            public static Field CreatedEmpID = new Field< ORD_SalesReturnLine >("CreatedEmpID");
		    /// <summary>
            ///  - 字段名：CreatedEmpName - 数据类型：String
            /// </summary>
            public static Field CreatedEmpName = new Field< ORD_SalesReturnLine >("CreatedEmpName");
		    /// <summary>
            ///  - 字段名：CreatedTime - 数据类型：DateTime?
            /// </summary>
            public static Field CreatedTime = new Field< ORD_SalesReturnLine >("CreatedTime");
		    /// <summary>
            ///  - 字段名：UpdatedEmpID - 数据类型：Int32?
            /// </summary>
            public static Field UpdatedEmpID = new Field< ORD_SalesReturnLine >("UpdatedEmpID");
		    /// <summary>
            ///  - 字段名：UpdatedEmpName - 数据类型：String
            /// </summary>
            public static Field UpdatedEmpName = new Field< ORD_SalesReturnLine >("UpdatedEmpName");
		    /// <summary>
            ///  - 字段名：UpdatedTime - 数据类型：DateTime?
            /// </summary>
            public static Field UpdatedTime = new Field< ORD_SalesReturnLine >("UpdatedTime");
		    /// <summary>
            ///  - 字段名：IsDeleted - 数据类型：Boolean?
            /// </summary>
            public static Field IsDeleted = new Field< ORD_SalesReturnLine >("IsDeleted");
		}
	}
}
