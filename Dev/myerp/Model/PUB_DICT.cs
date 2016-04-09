using System;
namespace MyERP.Model
{
	/// <summary>
	/// PUB_DICT:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class PUB_DICT
	{
		public PUB_DICT()
		{}
		#region Model
		private string _dict_code;
		private string _dict_name;
		private string _parent_dict_code;
		private string _create_name;
		private DateTime? _create_date;
		private string _update_name;
		private DateTime? _update_date;
		private string _remark;
		/// <summary>
		/// 
		/// </summary>
		public string DICT_CODE
		{
			set{ _dict_code=value;}
			get{return _dict_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DICT_NAME
		{
			set{ _dict_name=value;}
			get{return _dict_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PARENT_DICT_CODE
		{
			set{ _parent_dict_code=value;}
			get{return _parent_dict_code;}
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

