using System;
namespace MyERP.Model
{
	/// <summary>
	/// SYS_REGISTER:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class SYS_REGISTER
	{
		public SYS_REGISTER()
		{}
		#region Model
		private string _company_code;
		private string _company_name;
		private string _parent_company_code;
		private string _full_name;
		private string _adress;
		private string _service_phone;
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
		public string COMPANY_NAME
		{
			set{ _company_name=value;}
			get{return _company_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PARENT_COMPANY_CODE
		{
			set{ _parent_company_code=value;}
			get{return _parent_company_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FULL_NAME
		{
			set{ _full_name=value;}
			get{return _full_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ADRESS
		{
			set{ _adress=value;}
			get{return _adress;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SERVICE_PHONE
		{
			set{ _service_phone=value;}
			get{return _service_phone;}
		}
		#endregion Model

	}
}

