//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by CodeSmith Template.
//
//     Creater: David
//     Date:    2015/3/9
//     Time:    19:06
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
    /// 表名：ORD_PurchaseReturn 主键列：PRGuid
    /// </summary>
    [SerializableAttribute()]
	public partial class ORD_PurchaseReturn : BaseEntity
	{
		#region Private Properties
		
		private Int32? _PRID;
		private Guid? _PRGuid;
		private String _BillNo;
		private Guid? _GCompanyID;
		private Guid? _POGuid;
		private String _POBillNo;
		private Int32? _SupplierID;
		private String _SupplierName;
		private String _Contact;
		private String _Telephone;
		private String _DeliveryAddress;
		private DateTime? _ReturnDate;
		private Int32? _OperOrgID;
		private Int32? _OperDeptID;
		private Int32? _OperEmpID;
		private String _OperEmpName;
		private String _Currency;
		private Decimal? _Amount;
		private String _Remark;
		private String _StkOutOccStatus;
		private String _StkOutStatus;
		private String _ApproveStatus;
		private String _Status;
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
		/// 采购退货guid.
		/// </summary>
		public Guid? PRGuid
		{
			get 
			{
				return _PRGuid;
			}
			set 
			{
				this.OnPropertyValueChange(_.PRGuid, _PRGuid , value);
				this._PRGuid = value;
			}
		}
		
		/// <summary>
		/// 采购退货ID.
		/// </summary>
		public Int32? PRID
		{
			get 
			{
				return this._PRID;
			}
			set 
			{
				this.OnPropertyValueChange(_.PRID, _PRID , value);
				this._PRID = value;
			}
		}

		/// <summary>
		/// 采购退货单号.
		/// </summary>
		public String BillNo
		{
			get 
			{
				return this._BillNo;
			}
			set 
			{
				this.OnPropertyValueChange(_.BillNo, _BillNo , value);
				this._BillNo = value.SubStr(20);
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
		/// 采购单guid.
		/// </summary>
		public Guid? POGuid
		{
			get 
			{
				return this._POGuid;
			}
			set 
			{
				this.OnPropertyValueChange(_.POGuid, _POGuid , value);
				this._POGuid = value;
			}
		}

		/// <summary>
		/// 采购单号.
		/// </summary>
		public String POBillNo
		{
			get 
			{
				return this._POBillNo;
			}
			set 
			{
				this.OnPropertyValueChange(_.POBillNo, _POBillNo , value);
				this._POBillNo = value.SubStr(20);
			}
		}

		/// <summary>
		/// 供应商id.
		/// </summary>
		public Int32? SupplierID
		{
			get 
			{
				return this._SupplierID;
			}
			set 
			{
				this.OnPropertyValueChange(_.SupplierID, _SupplierID , value);
				this._SupplierID = value;
			}
		}

		/// <summary>
		/// 供应商名称.
		/// </summary>
		public String SupplierName
		{
			get 
			{
				return this._SupplierName;
			}
			set 
			{
				this.OnPropertyValueChange(_.SupplierName, _SupplierName , value);
				this._SupplierName = value.SubStr(100);
			}
		}

		/// <summary>
		/// 联系人.
		/// </summary>
		public String Contact
		{
			get 
			{
				return this._Contact;
			}
			set 
			{
				this.OnPropertyValueChange(_.Contact, _Contact , value);
				this._Contact = value.SubStr(50);
			}
		}

		/// <summary>
		/// 联系电话.
		/// </summary>
		public String Telephone
		{
			get 
			{
				return this._Telephone;
			}
			set 
			{
				this.OnPropertyValueChange(_.Telephone, _Telephone , value);
				this._Telephone = value.SubStr(50);
			}
		}

		/// <summary>
		/// 供应商收货地址.
		/// </summary>
		public String DeliveryAddress
		{
			get 
			{
				return this._DeliveryAddress;
			}
			set 
			{
				this.OnPropertyValueChange(_.DeliveryAddress, _DeliveryAddress , value);
				this._DeliveryAddress = value.SubStr(100);
			}
		}

		/// <summary>
		/// 退货日期.
		/// </summary>
		public DateTime? ReturnDate
		{
			get 
			{
				return this._ReturnDate;
			}
			set 
			{
				this.OnPropertyValueChange(_.ReturnDate, _ReturnDate , value);
				this._ReturnDate = value;
			}
		}

		/// <summary>
		/// 归属机构ID.
		/// </summary>
		public Int32? OperOrgID
		{
			get 
			{
				return this._OperOrgID;
			}
			set 
			{
				this.OnPropertyValueChange(_.OperOrgID, _OperOrgID , value);
				this._OperOrgID = value;
			}
		}

		/// <summary>
		/// 归属部门ID.
		/// </summary>
		public Int32? OperDeptID
		{
			get 
			{
				return this._OperDeptID;
			}
			set 
			{
				this.OnPropertyValueChange(_.OperDeptID, _OperDeptID , value);
				this._OperDeptID = value;
			}
		}

		/// <summary>
		/// 归属人员ID.
		/// </summary>
		public Int32? OperEmpID
		{
			get 
			{
				return this._OperEmpID;
			}
			set 
			{
				this.OnPropertyValueChange(_.OperEmpID, _OperEmpID , value);
				this._OperEmpID = value;
			}
		}

		/// <summary>
		/// 归属人员.
		/// </summary>
		public String OperEmpName
		{
			get 
			{
				return this._OperEmpName;
			}
			set 
			{
				this.OnPropertyValueChange(_.OperEmpName, _OperEmpName , value);
				this._OperEmpName = value.SubStr(50);
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
		/// 金额.
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
		/// 备注.
		/// </summary>
		public String Remark
		{
			get 
			{
				return this._Remark;
			}
			set 
			{
				this.OnPropertyValueChange(_.Remark, _Remark , value);
				this._Remark = value.SubStr(200);
			}
		}

		/// <summary>
		/// 出库占有状态.
		/// </summary>
		public String StkOutOccStatus
		{
			get 
			{
				return this._StkOutOccStatus;
			}
			set 
			{
				this.OnPropertyValueChange(_.StkOutOccStatus, _StkOutOccStatus , value);
				this._StkOutOccStatus = value.SubStr(10);
			}
		}

		/// <summary>
		/// 出库状态.
		/// </summary>
		public String StkOutStatus
		{
			get 
			{
				return this._StkOutStatus;
			}
			set 
			{
				this.OnPropertyValueChange(_.StkOutStatus, _StkOutStatus , value);
				this._StkOutStatus = value.SubStr(10);
			}
		}

		/// <summary>
		/// 审核状态.
		/// </summary>
		public String ApproveStatus
		{
			get 
			{
				return this._ApproveStatus;
			}
			set 
			{
				this.OnPropertyValueChange(_.ApproveStatus, _ApproveStatus , value);
				this._ApproveStatus = value.SubStr(20);
			}
		}

		/// <summary>
		/// 单据状态.
		/// </summary>
		public String Status
		{
			get 
			{
				return this._Status;
			}
			set 
			{
				this.OnPropertyValueChange(_.Status, _Status , value);
				this._Status = value.SubStr(10);
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
            return new Table< ORD_PurchaseReturn >("ORD_PurchaseReturn");
        }
		
        /// <summary>
        /// 获取实体中的标识列
        /// </summary>
        protected override Field GetIdentityField() {
            return _.PRID;
        }  			
		
        /// <summary>
        /// 获取实体中的主键列
        /// </summary>
        protected override Field[] GetPrimaryKeyFields() {
            return new Field[] {
				_.PRGuid
			};
        }
			
	    /// <summary>
        /// 获取列信息
        /// </summary>
        protected override Field[] GetFields() {
            return new Field[] {
				_.PRID,		
				_.PRGuid,		
				_.BillNo,		
				_.GCompanyID,		
				_.POGuid,		
				_.POBillNo,		
				_.SupplierID,		
				_.SupplierName,		
				_.Contact,		
				_.Telephone,		
				_.DeliveryAddress,		
				_.ReturnDate,		
				_.OperOrgID,		
				_.OperDeptID,		
				_.OperEmpID,		
				_.OperEmpName,		
				_.Currency,		
				_.Amount,		
				_.Remark,		
				_.StkOutOccStatus,		
				_.StkOutStatus,		
				_.ApproveStatus,		
				_.Status,		
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
				this._PRID,		
				this._PRGuid,		
				this._BillNo,		
				this._GCompanyID,		
				this._POGuid,		
				this._POBillNo,		
				this._SupplierID,		
				this._SupplierName,		
				this._Contact,		
				this._Telephone,		
				this._DeliveryAddress,		
				this._ReturnDate,		
				this._OperOrgID,		
				this._OperDeptID,		
				this._OperEmpID,		
				this._OperEmpName,		
				this._Currency,		
				this._Amount,		
				this._Remark,		
				this._StkOutOccStatus,		
				this._StkOutStatus,		
				this._ApproveStatus,		
				this._Status,		
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
            if ((false == reader.IsDBNull(_.PRID))) {
                this._PRID = reader.GetInt32(_.PRID);
            }
            if ((false == reader.IsDBNull(_.PRGuid))) {
                this._PRGuid = reader.GetGuid(_.PRGuid);
            }
            if ((false == reader.IsDBNull(_.BillNo))) {
                this._BillNo = reader.GetString(_.BillNo);
            }
            if ((false == reader.IsDBNull(_.GCompanyID))) {
                this._GCompanyID = reader.GetGuid(_.GCompanyID);
            }
            if ((false == reader.IsDBNull(_.POGuid))) {
                this._POGuid = reader.GetGuid(_.POGuid);
            }
            if ((false == reader.IsDBNull(_.POBillNo))) {
                this._POBillNo = reader.GetString(_.POBillNo);
            }
            if ((false == reader.IsDBNull(_.SupplierID))) {
                this._SupplierID = reader.GetInt32(_.SupplierID);
            }
            if ((false == reader.IsDBNull(_.SupplierName))) {
                this._SupplierName = reader.GetString(_.SupplierName);
            }
            if ((false == reader.IsDBNull(_.Contact))) {
                this._Contact = reader.GetString(_.Contact);
            }
            if ((false == reader.IsDBNull(_.Telephone))) {
                this._Telephone = reader.GetString(_.Telephone);
            }
            if ((false == reader.IsDBNull(_.DeliveryAddress))) {
                this._DeliveryAddress = reader.GetString(_.DeliveryAddress);
            }
            if ((false == reader.IsDBNull(_.ReturnDate))) {
                this._ReturnDate = reader.GetDateTime(_.ReturnDate);
            }
            if ((false == reader.IsDBNull(_.OperOrgID))) {
                this._OperOrgID = reader.GetInt32(_.OperOrgID);
            }
            if ((false == reader.IsDBNull(_.OperDeptID))) {
                this._OperDeptID = reader.GetInt32(_.OperDeptID);
            }
            if ((false == reader.IsDBNull(_.OperEmpID))) {
                this._OperEmpID = reader.GetInt32(_.OperEmpID);
            }
            if ((false == reader.IsDBNull(_.OperEmpName))) {
                this._OperEmpName = reader.GetString(_.OperEmpName);
            }
            if ((false == reader.IsDBNull(_.Currency))) {
                this._Currency = reader.GetString(_.Currency);
            }
            if ((false == reader.IsDBNull(_.Amount))) {
                this._Amount = reader.GetDecimal(_.Amount);
            }
            if ((false == reader.IsDBNull(_.Remark))) {
                this._Remark = reader.GetString(_.Remark);
            }
            if ((false == reader.IsDBNull(_.StkOutOccStatus))) {
                this._StkOutOccStatus = reader.GetString(_.StkOutOccStatus);
            }
            if ((false == reader.IsDBNull(_.StkOutStatus))) {
                this._StkOutStatus = reader.GetString(_.StkOutStatus);
            }
            if ((false == reader.IsDBNull(_.ApproveStatus))) {
                this._ApproveStatus = reader.GetString(_.ApproveStatus);
            }
            if ((false == reader.IsDBNull(_.Status))) {
                this._Status = reader.GetString(_.Status);
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
            if ((false == typeof(ORD_PurchaseReturn).IsAssignableFrom(obj.GetType()))) {
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
            public static AllField All = new AllField< ORD_PurchaseReturn >();
			
		    /// <summary>
            /// 采购退货ID - 字段名：PRID - 数据类型：Int32?
            /// </summary>
            public static Field PRID = new Field< ORD_PurchaseReturn >("PRID");
		    /// <summary>
            /// 采购退货guid - 字段名：PRGuid - 数据类型：Guid?
            /// </summary>
            public static Field PRGuid = new Field< ORD_PurchaseReturn >("PRGuid");
		    /// <summary>
            /// 采购退货单号 - 字段名：BillNo - 数据类型：String
            /// </summary>
            public static Field BillNo = new Field< ORD_PurchaseReturn >("BillNo");
		    /// <summary>
            ///  - 字段名：GCompanyID - 数据类型：Guid?
            /// </summary>
            public static Field GCompanyID = new Field< ORD_PurchaseReturn >("GCompanyID");
		    /// <summary>
            /// 采购单guid - 字段名：POGuid - 数据类型：Guid?
            /// </summary>
            public static Field POGuid = new Field< ORD_PurchaseReturn >("POGuid");
		    /// <summary>
            /// 采购单号 - 字段名：POBillNo - 数据类型：String
            /// </summary>
            public static Field POBillNo = new Field< ORD_PurchaseReturn >("POBillNo");
		    /// <summary>
            /// 供应商id - 字段名：SupplierID - 数据类型：Int32?
            /// </summary>
            public static Field SupplierID = new Field< ORD_PurchaseReturn >("SupplierID");
		    /// <summary>
            /// 供应商名称 - 字段名：SupplierName - 数据类型：String
            /// </summary>
            public static Field SupplierName = new Field< ORD_PurchaseReturn >("SupplierName");
		    /// <summary>
            /// 联系人 - 字段名：Contact - 数据类型：String
            /// </summary>
            public static Field Contact = new Field< ORD_PurchaseReturn >("Contact");
		    /// <summary>
            /// 联系电话 - 字段名：Telephone - 数据类型：String
            /// </summary>
            public static Field Telephone = new Field< ORD_PurchaseReturn >("Telephone");
		    /// <summary>
            /// 供应商收货地址 - 字段名：DeliveryAddress - 数据类型：String
            /// </summary>
            public static Field DeliveryAddress = new Field< ORD_PurchaseReturn >("DeliveryAddress");
		    /// <summary>
            /// 退货日期 - 字段名：ReturnDate - 数据类型：DateTime?
            /// </summary>
            public static Field ReturnDate = new Field< ORD_PurchaseReturn >("ReturnDate");
		    /// <summary>
            /// 归属机构ID - 字段名：OperOrgID - 数据类型：Int32?
            /// </summary>
            public static Field OperOrgID = new Field< ORD_PurchaseReturn >("OperOrgID");
		    /// <summary>
            /// 归属部门ID - 字段名：OperDeptID - 数据类型：Int32?
            /// </summary>
            public static Field OperDeptID = new Field< ORD_PurchaseReturn >("OperDeptID");
		    /// <summary>
            /// 归属人员ID - 字段名：OperEmpID - 数据类型：Int32?
            /// </summary>
            public static Field OperEmpID = new Field< ORD_PurchaseReturn >("OperEmpID");
		    /// <summary>
            /// 归属人员 - 字段名：OperEmpName - 数据类型：String
            /// </summary>
            public static Field OperEmpName = new Field< ORD_PurchaseReturn >("OperEmpName");
		    /// <summary>
            /// 币种 - 字段名：Currency - 数据类型：String
            /// </summary>
            public static Field Currency = new Field< ORD_PurchaseReturn >("Currency");
		    /// <summary>
            /// 金额 - 字段名：Amount - 数据类型：Decimal?
            /// </summary>
            public static Field Amount = new Field< ORD_PurchaseReturn >("Amount");
		    /// <summary>
            /// 备注 - 字段名：Remark - 数据类型：String
            /// </summary>
            public static Field Remark = new Field< ORD_PurchaseReturn >("Remark");
		    /// <summary>
            /// 出库占有状态 - 字段名：StkOutOccStatus - 数据类型：String
            /// </summary>
            public static Field StkOutOccStatus = new Field< ORD_PurchaseReturn >("StkOutOccStatus");
		    /// <summary>
            /// 出库状态 - 字段名：StkOutStatus - 数据类型：String
            /// </summary>
            public static Field StkOutStatus = new Field< ORD_PurchaseReturn >("StkOutStatus");
		    /// <summary>
            /// 审核状态 - 字段名：ApproveStatus - 数据类型：String
            /// </summary>
            public static Field ApproveStatus = new Field< ORD_PurchaseReturn >("ApproveStatus");
		    /// <summary>
            /// 单据状态 - 字段名：Status - 数据类型：String
            /// </summary>
            public static Field Status = new Field< ORD_PurchaseReturn >("Status");
		    /// <summary>
            ///  - 字段名：CreatedEmpID - 数据类型：Int32?
            /// </summary>
            public static Field CreatedEmpID = new Field< ORD_PurchaseReturn >("CreatedEmpID");
		    /// <summary>
            ///  - 字段名：CreatedEmpName - 数据类型：String
            /// </summary>
            public static Field CreatedEmpName = new Field< ORD_PurchaseReturn >("CreatedEmpName");
		    /// <summary>
            ///  - 字段名：CreatedTime - 数据类型：DateTime?
            /// </summary>
            public static Field CreatedTime = new Field< ORD_PurchaseReturn >("CreatedTime");
		    /// <summary>
            ///  - 字段名：UpdatedEmpID - 数据类型：Int32?
            /// </summary>
            public static Field UpdatedEmpID = new Field< ORD_PurchaseReturn >("UpdatedEmpID");
		    /// <summary>
            ///  - 字段名：UpdatedEmpName - 数据类型：String
            /// </summary>
            public static Field UpdatedEmpName = new Field< ORD_PurchaseReturn >("UpdatedEmpName");
		    /// <summary>
            ///  - 字段名：UpdatedTime - 数据类型：DateTime?
            /// </summary>
            public static Field UpdatedTime = new Field< ORD_PurchaseReturn >("UpdatedTime");
		    /// <summary>
            ///  - 字段名：IsDeleted - 数据类型：Boolean?
            /// </summary>
            public static Field IsDeleted = new Field< ORD_PurchaseReturn >("IsDeleted");
		}
	}
}