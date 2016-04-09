using System;
namespace MyERP.Model
{
	/// <summary>
	/// SYS_SYSCS:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class SYS_SYSCS
	{
		public SYS_SYSCS()
		{}
		#region Model
		private string _company_code;
		private string _company_name;
		private string _fullname;
		private string _address;
		private string _phone;
		private string _email;
		private string _fax;
		private int? _shdcnt;
		private string _item_code_length;
		private bool _billasstock;
		private string _maylh;
		private string _servicetelphone;
		private string _create_name;
		private string _create_date;
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
		public string FullName
		{
			set{ _fullname=value;}
			get{return _fullname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Address
		{
			set{ _address=value;}
			get{return _address;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Phone
		{
			set{ _phone=value;}
			get{return _phone;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Email
		{
			set{ _email=value;}
			get{return _email;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Fax
		{
			set{ _fax=value;}
			get{return _fax;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? SHDCNT
		{
			set{ _shdcnt=value;}
			get{return _shdcnt;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ITEM_CODE_LENGTH
		{
			set{ _item_code_length=value;}
			get{return _item_code_length;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool Billasstock
		{
			set{ _billasstock=value;}
			get{return _billasstock;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MAYLH
		{
			set{ _maylh=value;}
			get{return _maylh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ServiceTelphone
		{
			set{ _servicetelphone=value;}
			get{return _servicetelphone;}
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
		public string CREATE_DATE
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

