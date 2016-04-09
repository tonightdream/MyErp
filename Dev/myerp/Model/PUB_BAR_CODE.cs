using System;
namespace MyERP.Model
{
	/// <summary>
	/// PUB_BAR_CODE:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class PUB_BAR_CODE
	{
		public PUB_BAR_CODE()
		{}
		#region Model
		private string _company_code;
		private string _item_code;
		private string _bar_code;
		private string _color_code;
		private string _ruler_code;
		private string _length_code;
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
		public string ITEM_CODE
		{
			set{ _item_code=value;}
			get{return _item_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BAR_CODE
		{
			set{ _bar_code=value;}
			get{return _bar_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string COLOR_CODE
		{
			set{ _color_code=value;}
			get{return _color_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RULER_CODE
		{
			set{ _ruler_code=value;}
			get{return _ruler_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LENGTH_CODE
		{
			set{ _length_code=value;}
			get{return _length_code;}
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

