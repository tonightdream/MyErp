using System;
namespace MyERP.Model
{
	/// <summary>
	/// WL_STOCK_DETAIL:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class WL_STOCK_DETAIL
	{
		public WL_STOCK_DETAIL()
		{}
		#region Model
		private string _stock_code;
		private string _stock_name;
		private string _item_internal_code;
		private string _item_code;
		private string _item_name;
		private decimal? _actual_qty;
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
		public string ITEM_INTERNAL_CODE
		{
			set{ _item_internal_code=value;}
			get{return _item_internal_code;}
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
		public decimal? ACTUAL_QTY
		{
			set{ _actual_qty=value;}
			get{return _actual_qty;}
		}
		#endregion Model

	}
}

