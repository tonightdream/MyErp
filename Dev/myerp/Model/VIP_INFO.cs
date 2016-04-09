using System;
namespace MyERP.Model
{
	/// <summary>
	/// VIP_INFO:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class VIP_INFO
	{
		public VIP_INFO()
		{}
		#region Model
		private string _company_code="";
		private string _user_code;
		private string _user_name;
		private string _vip_card_code="";
		private decimal _vip_temp_card_code;
		private string _password="";
		private DateTime? _begin_date;
		private DateTime? _end_date;
		private string _vip_type="NULL";
		private decimal? _total_sales;
		private string _salesno="";
		private string _create_name;
		private DateTime? _create_date= DateTime.Now;
		private string _update_name;
		private DateTime? _update_date;
		private string _remark="";
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
		public string USER_CODE
		{
			set{ _user_code=value;}
			get{return _user_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string USER_NAME
		{
			set{ _user_name=value;}
			get{return _user_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string VIP_CARD_CODE
		{
			set{ _vip_card_code=value;}
			get{return _vip_card_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal VIP_TEMP_CARD_CODE
		{
			set{ _vip_temp_card_code=value;}
			get{return _vip_temp_card_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PASSWORD
		{
			set{ _password=value;}
			get{return _password;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? BEGIN_DATE
		{
			set{ _begin_date=value;}
			get{return _begin_date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? END_DATE
		{
			set{ _end_date=value;}
			get{return _end_date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string VIP_TYPE
		{
			set{ _vip_type=value;}
			get{return _vip_type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? TOTAL_SALES
		{
			set{ _total_sales=value;}
			get{return _total_sales;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string salesno
		{
			set{ _salesno=value;}
			get{return _salesno;}
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

