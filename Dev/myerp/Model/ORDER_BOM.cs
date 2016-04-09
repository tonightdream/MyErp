using System;
namespace MyERP.Model
{
	/// <summary>
	/// ORDER_BOM:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ORDER_BOM
	{
		public ORDER_BOM()
		{}
		#region Model
		private int _sequence;
		private string _masterid;
		private string _detailid;
		private string _billno;
		private string _item_internal_code;
		private string _item_code;
		private string _item_code_old;
		private string _item_name;
		private string _item_color;
		private string _parent_item_code;
		private string _item_type;
		private string _specifications;
		private string _measure_unit;
		private string _item_cz;
		private decimal? _item_lh;
		private decimal? _item_lk;
		private decimal? _item_bj;
		private decimal? _item_jz;
		private decimal? _item_hz;
		private string _item_rate;
		private string _item_gylc;
		private decimal? _net_price;
		private decimal? _price;
		private decimal? _min_qty;
		private decimal? _max_qty;
		private string _position;
		private byte[] _image;
		private string _image_name;
		private decimal? _quantity;
		private decimal? _total_quantity=0M;
		private string _barcode;
		private string _create_name;
		private DateTime? _create_date;
		private string _update_name;
		private DateTime? _update_date;
		private string _remark;
		/// <summary>
		/// 
		/// </summary>
		public int SEQUENCE
		{
			set{ _sequence=value;}
			get{return _sequence;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MASTERID
		{
			set{ _masterid=value;}
			get{return _masterid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DETAILID
		{
			set{ _detailid=value;}
			get{return _detailid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BILLNO
		{
			set{ _billno=value;}
			get{return _billno;}
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
		public string ITEM_CZ
		{
			set{ _item_cz=value;}
			get{return _item_cz;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? ITEM_LH
		{
			set{ _item_lh=value;}
			get{return _item_lh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? ITEM_LK
		{
			set{ _item_lk=value;}
			get{return _item_lk;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? ITEM_BJ
		{
			set{ _item_bj=value;}
			get{return _item_bj;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? ITEM_JZ
		{
			set{ _item_jz=value;}
			get{return _item_jz;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? ITEM_HZ
		{
			set{ _item_hz=value;}
			get{return _item_hz;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ITEM_rate
		{
			set{ _item_rate=value;}
			get{return _item_rate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ITEM_GYLC
		{
			set{ _item_gylc=value;}
			get{return _item_gylc;}
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
		public decimal? Quantity
		{
			set{ _quantity=value;}
			get{return _quantity;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? total_quantity
		{
			set{ _total_quantity=value;}
			get{return _total_quantity;}
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

