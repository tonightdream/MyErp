using System;
namespace MyERP.Model
{
	/// <summary>
	/// SYS_USER:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class SYS_USER
	{
		public SYS_USER()
		{}
		#region Model
		private string _user_code;
		private string _company_code;
		private string _company_name;
		private string _user_name;
		private string _stock_code;
		private string _stock_name;
		private string _department_code;
		private string _department_name;
		private string _department;
		private string _parent_department_code;
		private bool _pprice_show;
		private string _password;
		private string _description;
		private string _employeecode;
		private string _allowused;
		private string _islicenceaudit;
		private string _usertype;
		private byte[] _lastedit;
		private DateTime? _auditdate;
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
		public string USER_NAME
		{
			set{ _user_name=value;}
			get{return _user_name;}
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
		public string department
		{
			set{ _department=value;}
			get{return _department;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PARENT_DEPARTMENT_CODE
		{
			set{ _parent_department_code=value;}
			get{return _parent_department_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool PPRICE_SHOW
		{
			set{ _pprice_show=value;}
			get{return _pprice_show;}
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
		public string Description
		{
			set{ _description=value;}
			get{return _description;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string EmployeeCode
		{
			set{ _employeecode=value;}
			get{return _employeecode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string AllowUsed
		{
			set{ _allowused=value;}
			get{return _allowused;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string isLicenceAudit
		{
			set{ _islicenceaudit=value;}
			get{return _islicenceaudit;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UserType
		{
			set{ _usertype=value;}
			get{return _usertype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public byte[] LastEdit
		{
			set{ _lastedit=value;}
			get{return _lastedit;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? AuditDate
		{
			set{ _auditdate=value;}
			get{return _auditdate;}
		}
		#endregion Model

	}
}

