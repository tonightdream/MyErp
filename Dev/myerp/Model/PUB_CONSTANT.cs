using System;
namespace MyERP.Model
{
	/// <summary>
	/// PUB_CONSTANT:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class PUB_CONSTANT
	{
		public PUB_CONSTANT()
		{}
		#region Model
		private string _company_code;
		private string _const_type;
		private string _const_code;
		private string _create_name;
		private string _create_date;
		private string _update_name;
		private string _update_date;
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
		public string CONST_TYPE
		{
			set{ _const_type=value;}
			get{return _const_type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CONST_CODE
		{
			set{ _const_code=value;}
			get{return _const_code;}
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
		public string UPDATE_NAME
		{
			set{ _update_name=value;}
			get{return _update_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UPDATE_DATE
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

