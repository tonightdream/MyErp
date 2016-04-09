using System;
namespace MyERP.Model
{
	/// <summary>
	/// STEEL_RECEIPT_DETAIL:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class STEEL_RECEIPT_DETAIL
	{
		public STEEL_RECEIPT_DETAIL()
		{}
		#region Model
		private int _tempid;
		private string _billno;
		private int? _sequence;
		private string _item_internal_code;
		private string _item_code;
		private string _item_name;
		private string _parent_item_code;
		private string _specifications;
		private string _measure_unit;
		private string _item_type;
		private string _item_color;
		private decimal? _net_price;
		private decimal? _price;
		private decimal? _qty;
		private decimal? _quantity;
		private decimal? _actual_qty;
		private decimal? _ykquantity;
		private decimal? _payamount;
		private string _supply_code;
		private string _supply_name;
		private string _position;
		private string _barcode;
		private string _remark;
		private string _description;
		/// <summary>
		/// 
		/// </summary>
		public int TempID
		{
			set{ _tempid=value;}
			get{return _tempid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BillNo
		{
			set{ _billno=value;}
			get{return _billno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? SEQUENCE
		{
			set{ _sequence=value;}
			get{return _sequence;}
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
		public string PARENT_ITEM_CODE
		{
			set{ _parent_item_code=value;}
			get{return _parent_item_code;}
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
		public string ITEM_TYPE
		{
			set{ _item_type=value;}
			get{return _item_type;}
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
		public decimal? QTY
		{
			set{ _qty=value;}
			get{return _qty;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? QUANTITY
		{
			set{ _quantity=value;}
			get{return _quantity;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? ACTUAL_QTY
		{
			set{ _actual_qty=value;}
			get{return _actual_qty;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? YKQUANTITY
		{
			set{ _ykquantity=value;}
			get{return _ykquantity;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? PAYAMOUNT
		{
			set{ _payamount=value;}
			get{return _payamount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SUPPLY_CODE
		{
			set{ _supply_code=value;}
			get{return _supply_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SUPPLY_NAME
		{
			set{ _supply_name=value;}
			get{return _supply_name;}
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
		public string BARCODE
		{
			set{ _barcode=value;}
			get{return _barcode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string REMARK
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DESCRIPTION
		{
			set{ _description=value;}
			get{return _description;}
		}
		#endregion Model

	}
}

