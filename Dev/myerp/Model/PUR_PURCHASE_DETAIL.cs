using System;
namespace MyERP.Model
{
	/// <summary>
	/// PUR_PURCHASE_DETAIL:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class PUR_PURCHASE_DETAIL
	{
		public PUR_PURCHASE_DETAIL()
		{}
		#region Model
		private string _detailid;
		private string _masterid;
		private string _billno;
		private int? _sequence;
		private string _supply_code;
		private string _supply_name;
		private string _item_internal_code;
		private string _item_code;
		private string _item_code_old;
		private string _specifications;
		private decimal? _parent_item_code;
		private decimal? _item_cd;
		private decimal? _item_kd;
		private decimal? _item_gd;
		private string _measure_unit;
		private string _item_name;
		private string _item_type;
		private string _color;
		private string _image;
		private decimal? _dwmj;
		private string _description;
		private string _barcode;
		private decimal? _net_price;
		private decimal? _price;
		private int? _quantity;
		private decimal? _payamount;
		private decimal? _tax_rate;
		private int? _ord_cgqty;
		private int? _ord_clqty;
		private int? _ord_pcqty;
		private int? _ord_wgqty;
		private int? _ord_tcqty;
		private int? _ord_wgzl;
		private int? _ord_fpqty;
		private int? _ord_sendqty;
		private int? _ord_shqty;
		private int? _ord_lhqty;
		private int? _ord_hzqty;
		private int? _ord_thqty;
		private int? _ord_acceptqty;
		private string _ord_shdh;
		private string _remark;
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
		public string MASTERID
		{
			set{ _masterid=value;}
			get{return _masterid;}
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
		public int? Sequence
		{
			set{ _sequence=value;}
			get{return _sequence;}
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
		public string SPECIFICATIONS
		{
			set{ _specifications=value;}
			get{return _specifications;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? PARENT_ITEM_CODE
		{
			set{ _parent_item_code=value;}
			get{return _parent_item_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? ITEM_CD
		{
			set{ _item_cd=value;}
			get{return _item_cd;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? ITEM_KD
		{
			set{ _item_kd=value;}
			get{return _item_kd;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? ITEM_GD
		{
			set{ _item_gd=value;}
			get{return _item_gd;}
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
		public string ITEM_NAME
		{
			set{ _item_name=value;}
			get{return _item_name;}
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
		public string COLOR
		{
			set{ _color=value;}
			get{return _color;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string IMAGE
		{
			set{ _image=value;}
			get{return _image;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? DWMJ
		{
			set{ _dwmj=value;}
			get{return _dwmj;}
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
		public string BARCODE
		{
			set{ _barcode=value;}
			get{return _barcode;}
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
		public int? Quantity
		{
			set{ _quantity=value;}
			get{return _quantity;}
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
		public decimal? TAX_RATE
		{
			set{ _tax_rate=value;}
			get{return _tax_rate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ORD_CGqty
		{
			set{ _ord_cgqty=value;}
			get{return _ord_cgqty;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ORD_CLqty
		{
			set{ _ord_clqty=value;}
			get{return _ord_clqty;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ORD_PCqty
		{
			set{ _ord_pcqty=value;}
			get{return _ord_pcqty;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ORD_WGqty
		{
			set{ _ord_wgqty=value;}
			get{return _ord_wgqty;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ORD_TCqty
		{
			set{ _ord_tcqty=value;}
			get{return _ord_tcqty;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ORD_WGZL
		{
			set{ _ord_wgzl=value;}
			get{return _ord_wgzl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ORD_FPqty
		{
			set{ _ord_fpqty=value;}
			get{return _ord_fpqty;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ORD_Sendqty
		{
			set{ _ord_sendqty=value;}
			get{return _ord_sendqty;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ORD_SHqty
		{
			set{ _ord_shqty=value;}
			get{return _ord_shqty;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ORD_LHqty
		{
			set{ _ord_lhqty=value;}
			get{return _ord_lhqty;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ORD_HZqty
		{
			set{ _ord_hzqty=value;}
			get{return _ord_hzqty;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ORD_THqty
		{
			set{ _ord_thqty=value;}
			get{return _ord_thqty;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ORD_Acceptqty
		{
			set{ _ord_acceptqty=value;}
			get{return _ord_acceptqty;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ORD_SHDH
		{
			set{ _ord_shdh=value;}
			get{return _ord_shdh;}
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

