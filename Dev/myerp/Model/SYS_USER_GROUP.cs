using System;
namespace MyERP.Model
{
	/// <summary>
	/// SYS_USER_GROUP:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class SYS_USER_GROUP
	{
		public SYS_USER_GROUP()
		{}
		#region Model
		private string _companycode;
		private string _usergroupno;
		private string _usergroupname;
		private string _description;
		private string _allowused;
		/// <summary>
		/// 
		/// </summary>
		public string CompanyCode
		{
			set{ _companycode=value;}
			get{return _companycode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UserGroupNo
		{
			set{ _usergroupno=value;}
			get{return _usergroupno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UserGroupName
		{
			set{ _usergroupname=value;}
			get{return _usergroupname;}
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
		public string AllowUsed
		{
			set{ _allowused=value;}
			get{return _allowused;}
		}
		#endregion Model

	}
}

