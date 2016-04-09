using System;
namespace MyERP.Model
{
	/// <summary>
	/// PUB_PAYMENT_TYPE:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class PUB_PAYMENT_TYPE
	{
		public PUB_PAYMENT_TYPE()
		{}
		#region Model
		private string _company_code;
		private string _payment_code;
		private string _payment_name;
		private string _desc;
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
		public string PAYMENT_CODE
		{
			set{ _payment_code=value;}
			get{return _payment_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PAYMENT_NAME
		{
			set{ _payment_name=value;}
			get{return _payment_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DESC
		{
			set{ _desc=value;}
			get{return _desc;}
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

