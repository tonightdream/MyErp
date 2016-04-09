using System;
namespace MyERP.Model
{
	/// <summary>
	/// ORDER_SEND_REMARK:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ORDER_SEND_REMARK
	{
		public ORDER_SEND_REMARK()
		{}
		#region Model
		private string _masterid;
		private string _billno;
		private int _sequence;
		private string _manual_billno;
		private string _vehicle_code;
		private string _vehicle_name;
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
		public int Sequence
		{
			set{ _sequence=value;}
			get{return _sequence;}
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

