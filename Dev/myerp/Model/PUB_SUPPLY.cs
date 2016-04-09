using System;
namespace MyERP.Model
{
	/// <summary>
	/// PUB_SUPPLY:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class PUB_SUPPLY
	{
		public PUB_SUPPLY()
		{}
		#region Model
		private string _internal_code;
		private string _supply_code;
		private string _supply_name;
		private string _parent_supply_code;
		private string _typecode;
		private string _typename;
		private string _telphone;
		private string _telphone1;
		private string _fax;
		private string _email;
		private string _fullname;
		private string _address;
		private string _easycode;
		private string _contact_man;
		private string _create_name;
		private DateTime? _create_date;
		private string _update_name;
		private DateTime? _update_date;
		private bool _allow_used;
		private string _remark;
		/// <summary>
		/// 
		/// </summary>
		public string INTERNAL_CODE
		{
			set{ _internal_code=value;}
			get{return _internal_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SUPPLY_CODE
		{
			set{ _supply_code=value;}
			get{return _supply_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SUPPLY_NAME
		{
			set{ _supply_name=value;}
			get{return _supply_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PARENT_SUPPLY_CODE
		{
			set{ _parent_supply_code=value;}
			get{return _parent_supply_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TypeCode
		{
			set{ _typecode=value;}
			get{return _typecode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TypeName
		{
			set{ _typename=value;}
			get{return _typename;}
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
		public string TELPHONE1
		{
			set{ _telphone1=value;}
			get{return _telphone1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FAX
		{
			set{ _fax=value;}
			get{return _fax;}
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
		public string FULLNAME
		{
			set{ _fullname=value;}
			get{return _fullname;}
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
		public string EASYCODE
		{
			set{ _easycode=value;}
			get{return _easycode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Contact_MAN
		{
			set{ _contact_man=value;}
			get{return _contact_man;}
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
		public bool ALLOW_used
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

