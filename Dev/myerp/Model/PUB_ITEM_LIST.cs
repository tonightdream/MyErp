using System;
namespace MyERP.Model
{
	/// <summary>
	/// PUB_ITEM_LIST:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class PUB_ITEM_LIST
	{
		public PUB_ITEM_LIST()
		{}
		#region Model
		private string _item_internal_code;
		private string _item_code;
		private string _item_code_old;
		private string _item_name;
		private string _item_color;
		private string _parent_item_code;
		private string _item_type;
		private string _specifications;
		private string _measure_unit;
		private string _type_name;
		private decimal? _net_price;
		private decimal? _price;
		private decimal? _min_qty;
		private decimal? _max_qty;
		private string _position;
		private byte[] _image;
		private string _image_name;
		private decimal? _actual_qty;
		private string _barcode;
		private string _create_name;
		private DateTime? _create_date;
		private string _update_name;
		private DateTime? _update_date;
		private string _remark;
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
		public string ITEM_CODE_old
		{
			set{ _item_code_old=value;}
			get{return _item_code_old;}
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
		public string ITEM_COLOR
		{
			set{ _item_color=value;}
			get{return _item_color;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PARENT_ITEM_CODE
		{
			set{ _parent_item_code=value;}
			get{return _parent_item_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ITEM_TYPE
		{
			set{ _item_type=value;}
			get{return _item_type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SPECIFICATIONS
		{
			set{ _specifications=value;}
			get{return _specifications;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MEASURE_UNIT
		{
			set{ _measure_unit=value;}
			get{return _measure_unit;}
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
		public decimal? NET_PRICE
		{
			set{ _net_price=value;}
			get{return _net_price;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? PRICE
		{
			set{ _price=value;}
			get{return _price;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? MIN_QTY
		{
			set{ _min_qty=value;}
			get{return _min_qty;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? MAX_QTY
		{
			set{ _max_qty=value;}
			get{return _max_qty;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string POSITION
		{
			set{ _position=value;}
			get{return _position;}
		}
		/// <summary>
		/// 
		/// </summary>
		public byte[] IMAGE
		{
			set{ _image=value;}
			get{return _image;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string IMAGE_NAME
		{
			set{ _image_name=value;}
			get{return _image_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Actual_Qty
		{
			set{ _actual_qty=value;}
			get{return _actual_qty;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BARCODE
		{
			set{ _barcode=value;}
			get{return _barcode;}
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

