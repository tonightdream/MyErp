using System;
namespace MyERP.Model
{
	/// <summary>
	/// PUB_ITEM_TYPE:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class PUB_ITEM_TYPE
	{
		public PUB_ITEM_TYPE()
		{}
		#region Model
		private string _internal_code;
		private string _company_code;
		private string _company_name;
		private string _type_code;
		private string _type_name;
		private string _parent_type_code;
		private string _create_name;
		private DateTime? _create_date;
		private bool _allow_used;
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
		public string TYPE_CODE
		{
			set{ _type_code=value;}
			get{return _type_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TYPE_NAME
		{
			set{ _type_name=value;}
			get{return _type_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PARENT_TYPE_CODE
		{
			set{ _parent_type_code=value;}
			get{return _parent_type_code;}
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
		public bool ALLOW_used
		{
			set{ _allow_used=value;}
			get{return _allow_used;}
		}
		#endregion Model

	}
}

