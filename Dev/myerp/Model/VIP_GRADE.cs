using System;
namespace MyERP.Model
{
	/// <summary>
	/// VIP_GRADE:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class VIP_GRADE
	{
		public VIP_GRADE()
		{}
		#region Model
		private string _company_code;
		private string _grade_code;
		private string _grade_name;
		private string _grade_type;
		private DateTime? _indate;
		private DateTime? _outdate;
		private decimal? _low_sales;
		private decimal? _total_sales;
		private decimal? _zsrgrade;
		private decimal? _standrate;
		private decimal? _specialrate;
		private decimal? _birthdayrate;
		private decimal? _birthdayspsrate;
		private decimal? _year_option;
		private string _run;
		private string _create_name;
		private DateTime? _create_date;
		private string _update_name;
		private DateTime? _update_date;
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
		public string GRADE_CODE
		{
			set{ _grade_code=value;}
			get{return _grade_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GRADE_NAME
		{
			set{ _grade_name=value;}
			get{return _grade_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GRADE_TYPE
		{
			set{ _grade_type=value;}
			get{return _grade_type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? indate
		{
			set{ _indate=value;}
			get{return _indate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? outdate
		{
			set{ _outdate=value;}
			get{return _outdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LOW_SALES
		{
			set{ _low_sales=value;}
			get{return _low_sales;}
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
		public decimal? zsrgrade
		{
			set{ _zsrgrade=value;}
			get{return _zsrgrade;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? standrate
		{
			set{ _standrate=value;}
			get{return _standrate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? specialrate
		{
			set{ _specialrate=value;}
			get{return _specialrate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? birthdayrate
		{
			set{ _birthdayrate=value;}
			get{return _birthdayrate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? birthdayspsrate
		{
			set{ _birthdayspsrate=value;}
			get{return _birthdayspsrate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? year_option
		{
			set{ _year_option=value;}
			get{return _year_option;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string run
		{
			set{ _run=value;}
			get{return _run;}
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

