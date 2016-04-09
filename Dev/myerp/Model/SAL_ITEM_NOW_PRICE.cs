using System;
namespace MyERP.Model
{
	/// <summary>
	/// SAL_ITEM_NOW_PRICE:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class SAL_ITEM_NOW_PRICE
	{
		public SAL_ITEM_NOW_PRICE()
		{}
		#region Model
		private string _companycode;
		private string _itemno;
		private string _color;
		private string _iteminternalcode;
		private string _internalcodemean;
		private decimal? _allprice;
		private decimal? _wholesaleprice;
		private decimal? _onceprice;
		private string _measureunit;
		private byte[] _lastedit;
		/// <summary>
		/// 
		/// </summary>
		public string CompanyCode
		{
			set{ _companycode=value;}
			get{return _companycode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ItemNo
		{
			set{ _itemno=value;}
			get{return _itemno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Color
		{
			set{ _color=value;}
			get{return _color;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ItemInternalCode
		{
			set{ _iteminternalcode=value;}
			get{return _iteminternalcode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string InternalCodeMean
		{
			set{ _internalcodemean=value;}
			get{return _internalcodemean;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? AllPrice
		{
			set{ _allprice=value;}
			get{return _allprice;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? WholeSalePrice
		{
			set{ _wholesaleprice=value;}
			get{return _wholesaleprice;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? OncePrice
		{
			set{ _onceprice=value;}
			get{return _onceprice;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MeasureUnit
		{
			set{ _measureunit=value;}
			get{return _measureunit;}
		}
		/// <summary>
		/// 
		/// </summary>
		public byte[] LastEdit
		{
			set{ _lastedit=value;}
			get{return _lastedit;}
		}
		#endregion Model

	}
}

