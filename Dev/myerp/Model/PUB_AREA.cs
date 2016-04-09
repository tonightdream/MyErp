using System;
namespace MyERP.Model
{
	/// <summary>
	/// PUB_AREA:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class PUB_AREA
	{
		public PUB_AREA()
		{}
		#region Model
		private string _company_code;
		private string _area_code;
		private string _area_name;
		private string _parent_area_code;
		private string _manager;
		private string _allow_usered;
		private string _create_name;
		private DateTime? _create_date;
		private string _update_name;
		private DateTime? _update_date;
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
		public string AREA_CODE
		{
			set{ _area_code=value;}
			get{return _area_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string AREA_NAME
		{
			set{ _area_name=value;}
			get{return _area_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PARENT_AREA_CODE
		{
			set{ _parent_area_code=value;}
			get{return _parent_area_code;}
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
		public string ALLOW_USERED
		{
			set{ _allow_usered=value;}
			get{return _allow_usered;}
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
		#endregion Model

	}
}

