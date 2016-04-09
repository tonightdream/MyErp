using System;
namespace MyERP.Model
{
	/// <summary>
	/// ORDER_PCMASTER:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ORDER_PCMASTER
	{
		public ORDER_PCMASTER()
		{}
		#region Model
		private string _billno;
		private string _bill_date;
		private string _group;
		private string _machine;
		private string _factory;
		private int? _bill_status;
		private string _stock_code;
		private string _stock_name;
		private string _department_code;
		private string _department_name;
		private string _create_code;
		private string _create_name;
		private DateTime? _create_date;
		private string _remark;
		/// <summary>
		/// 
		/// </summary>
		public string BillNo
		{
			set{ _billno=value;}
			get{return _billno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BILL_DATE
		{
			set{ _bill_date=value;}
			get{return _bill_date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GROUP
		{
			set{ _group=value;}
			get{return _group;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MACHINE
		{
			set{ _machine=value;}
			get{return _machine;}
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
		public int? BILL_STATUS
		{
			set{ _bill_status=value;}
			get{return _bill_status;}
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
		public string REMARK
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		#endregion Model

	}
}

