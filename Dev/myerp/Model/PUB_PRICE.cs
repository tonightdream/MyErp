using System;
namespace MyERP.Model
{
	/// <summary>
	/// PUB_PRICE:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class PUB_PRICE
	{
		public PUB_PRICE()
		{}
		#region Model
		private string _internal_code;
		private string _company_code;
		private string _item_code;
		private string _item_name;
		private string _color;
		private decimal? _all_price;
		private string _create_name;
		private string _create_date;
		private string _update_name;
		private string _update_date;
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
		public string ITEM_CODE
		{
			set{ _item_code=value;}
			get{return _item_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ITEM_NAME
		{
			set{ _item_name=value;}
			get{return _item_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string COLOR
		{
			set{ _color=value;}
			get{return _color;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? ALL_PRICE
		{
			set{ _all_price=value;}
			get{return _all_price;}
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
		#endregion Model

	}
}

