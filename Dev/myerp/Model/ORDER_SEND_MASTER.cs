using System;
namespace MyERP.Model
{
	/// <summary>
	/// ORDER_SEND_MASTER:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ORDER_SEND_MASTER
	{
		public ORDER_SEND_MASTER()
		{}
		#region Model
		private string _masterid;
		private string _billno;
		private string _manual_billno;
		private string _vehicle_code;
		private string _vehicle_name;
		private string _custom_code;
		private string _custom_name;
		private DateTime? _bill_date;
		private string _bill_status;
		private string _now_status;
		private string _now_date;
		private string _stock_code;
		private string _stock_name;
		private string _department_code;
		private string _department_name;
		private string _factory;
		private string _sale_name;
		private string _create_code;
		private string _create_name;
		private DateTime? _create_date;
		private string _update_name;
		private DateTime? _update_date;
		private string _remark;
		/// <summary>
		/// 
		/// </summary>
		public string MASTERID
		{
			set{ _masterid=value;}
			get{return _masterid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BILLNO
		{
			set{ _billno=value;}
			get{return _billno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MANUAL_BILLNO
		{
			set{ _manual_billno=value;}
			get{return _manual_billno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Vehicle_CODE
		{
			set{ _vehicle_code=value;}
			get{return _vehicle_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Vehicle_NAME
		{
			set{ _vehicle_name=value;}
			get{return _vehicle_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CUSTOM_CODE
		{
			set{ _custom_code=value;}
			get{return _custom_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CUSTOM_NAME
		{
			set{ _custom_name=value;}
			get{return _custom_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? BILL_DATE
		{
			set{ _bill_date=value;}
			get{return _bill_date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BILL_STATUS
		{
			set{ _bill_status=value;}
			get{return _bill_status;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string NOW_STATUS
		{
			set{ _now_status=value;}
			get{return _now_status;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string NOW_DATE
		{
			set{ _now_date=value;}
			get{return _now_date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string STOCK_CODE
		{
			set{ _stock_code=value;}
			get{return _stock_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string STOCK_NAME
		{
			set{ _stock_name=value;}
			get{return _stock_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DEPARTMENT_CODE
		{
			set{ _department_code=value;}
			get{return _department_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DEPARTMENT_NAME
		{
			set{ _department_name=value;}
			get{return _department_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FACTORY
		{
			set{ _factory=value;}
			get{return _factory;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SALE_NAME
		{
			set{ _sale_name=value;}
			get{return _sale_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CREATE_CODE
		{
			set{ _create_code=value;}
			get{return _create_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CREATE_NAME
		{
			set{ _create_name=value;}
			get{return _create_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? CREATE_DATE
		{
			set{ _create_date=value;}
			get{return _create_date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UPDATE_NAME
		{
			set{ _update_name=value;}
			get{return _update_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? UPDATE_DATE
		{
			set{ _update_date=value;}
			get{return _update_date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string REMARK
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		#endregion Model

	}
}

