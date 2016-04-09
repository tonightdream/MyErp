using System;
namespace MyERP.Model
{
	/// <summary>
	/// PUB_ITEM_DETAIL:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class PUB_ITEM_DETAIL
	{
		public PUB_ITEM_DETAIL()
		{}
		#region Model
		private int _sequence;
		private string _item_internal_code;
		private string _item_code;
		private string _item_code_old;
		private string _item_name;
		private string _item_color;
		private string _parent_item_code;
		private string _item_type;
		private string _specifications;
		private string _measure_unit;
		private string _description;
		private decimal? _item_lh;
		private decimal? _item_lk;
		private decimal? _item_bj;
		private decimal? _item_jz;
		private decimal? _item_hz;
		private string _item_rate;
		private string _item_gylc;
		private decimal? _net_price;
		private decimal? _price;
		private decimal? _quantity;
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
		public string DESCRIPTION
		{
			set{ _description=value;}
			get{return _description;}
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
		public decimal? Quantity
		{
			set{ _quantity=value;}
			get{return _quantity;}
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

