using System;
namespace MyERP.Model
{
	/// <summary>
	/// ORDER_PCDETAIL:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ORDER_PCDETAIL
	{
		public ORDER_PCDETAIL()
		{}
		#region Model
		private string _detailid;
		private string _masterid;
		private string _billno;
		private int _sequence;
		private string _item_internal_code;
		private string _item_code;
		private string _item_code_old;
		private string _item_name;
		private string _item_color;
		private decimal? _parent_item_code;
		private string _item_type;
		private string _item_logo;
		private string _item_description;
		private decimal? _item_cd;
		private decimal? _item_kd;
		private decimal? _item_gd;
		private string _item_specifications;
		private string _item_measure_unit;
		private string _item_gylc;
		private decimal? _item_position;
		private decimal? _item_min_qty;
		private decimal? _item_max_qty;
		private string _item_image;
		private string _item_image_name;
		private decimal? _item_dwmj;
		private string _item_barcode;
		private decimal? _net_price;
		private decimal? _price;
		private int? _quantity;
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
		private string _ord_tl;
		private string _ord_graphicno;
		private string _ord_shdh;
		private string _ord_bzfs;
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
		public int Sequence
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
		public decimal? PARENT_ITEM_CODE
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
		public string ITEM_LOGO
		{
			set{ _item_logo=value;}
			get{return _item_logo;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ITEM_DESCRIPTION
		{
			set{ _item_description=value;}
			get{return _item_description;}
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
		public string ITEM_SPECIFICATIONS
		{
			set{ _item_specifications=value;}
			get{return _item_specifications;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ITEM_MEASURE_UNIT
		{
			set{ _item_measure_unit=value;}
			get{return _item_measure_unit;}
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
		public decimal? ITEM_POSITION
		{
			set{ _item_position=value;}
			get{return _item_position;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? ITEM_MIN_QTY
		{
			set{ _item_min_qty=value;}
			get{return _item_min_qty;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? ITEM_MAX_QTY
		{
			set{ _item_max_qty=value;}
			get{return _item_max_qty;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ITEM_IMAGE
		{
			set{ _item_image=value;}
			get{return _item_image;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ITEM_IMAGE_NAME
		{
			set{ _item_image_name=value;}
			get{return _item_image_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? ITEM_DWMJ
		{
			set{ _item_dwmj=value;}
			get{return _item_dwmj;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ITEM_BARCODE
		{
			set{ _item_barcode=value;}
			get{return _item_barcode;}
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
		public string ORD_TL
		{
			set{ _ord_tl=value;}
			get{return _ord_tl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ORD_GRAPHICNO
		{
			set{ _ord_graphicno=value;}
			get{return _ord_graphicno;}
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
		public string ORD_BZFS
		{
			set{ _ord_bzfs=value;}
			get{return _ord_bzfs;}
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

