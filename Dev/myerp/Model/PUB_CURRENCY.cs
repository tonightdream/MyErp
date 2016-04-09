using System;
namespace MyERP.Model
{
	/// <summary>
	/// PUB_CURRENCY:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class PUB_CURRENCY
	{
		public PUB_CURRENCY()
		{}
		#region Model
		private string _company_code;
		private string _currency_code;
		private string _currency_name;
		private decimal? _exchange_rate;
		private string _allow_usered;
		private string _create_name;
		private DateTime? _create_date;
		private string _remark;
		/// <summary>
		/// 
		/// </summary>
		public string COMPANY_CODE
		{
			set{ _company_code=value;}
			get{return _company_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CURRENCY_CODE
		{
			set{ _currency_code=value;}
			get{return _currency_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CURRENCY_NAME
		{
			set{ _currency_name=value;}
			get{return _currency_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? EXCHANGE_RATE
		{
			set{ _exchange_rate=value;}
			get{return _exchange_rate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ALLOW_USERED
		{
			set{ _allow_usered=value;}
			get{return _allow_usered;}
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

