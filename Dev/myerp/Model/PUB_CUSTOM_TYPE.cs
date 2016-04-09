using System;
namespace MyERP.Model
{
	/// <summary>
	/// PUB_CUSTOM_TYPE:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class PUB_CUSTOM_TYPE
	{
		public PUB_CUSTOM_TYPE()
		{}
		#region Model
		private string _internal_code;
		private string _type_code;
		private string _type_name;
		private string _crdate_name;
		private string _create_date;
		private string _update_name;
		private string _update_date;
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
		public string CRDATE_NAME
		{
			set{ _crdate_name=value;}
			get{return _crdate_name;}
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

