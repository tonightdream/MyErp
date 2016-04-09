using System;
namespace MyERP.Model
{
	/// <summary>
	/// PUB_COMPANY:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class PUB_COMPANY
	{
		public PUB_COMPANY()
		{}
		#region Model
		private string _company_code;
		private string _company_name;
		private string _company_fullname;
		private string _parent_company_code;
		private string _manager;
		private string _address;
		private string _telphone;
		private string _zip;
		private string _email;
		private string _http;
		private string _license;
		private string _register_bank;
		private string _bank_account;
		private string _allow_used;
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
		public string COMPANY_NAME
		{
			set{ _company_name=value;}
			get{return _company_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string COMPANY_FULLNAME
		{
			set{ _company_fullname=value;}
			get{return _company_fullname;}
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
		public string MANAGER
		{
			set{ _manager=value;}
			get{return _manager;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ADDRESS
		{
			set{ _address=value;}
			get{return _address;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TELPHONE
		{
			set{ _telphone=value;}
			get{return _telphone;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ZIP
		{
			set{ _zip=value;}
			get{return _zip;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string EMAIL
		{
			set{ _email=value;}
			get{return _email;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string HTTP
		{
			set{ _http=value;}
			get{return _http;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LICENSE
		{
			set{ _license=value;}
			get{return _license;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string REGISTER_BANK
		{
			set{ _register_bank=value;}
			get{return _register_bank;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BANK_ACCOUNT
		{
			set{ _bank_account=value;}
			get{return _bank_account;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ALLOW_USED
		{
			set{ _allow_used=value;}
			get{return _allow_used;}
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

