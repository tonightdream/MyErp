using System;
namespace MyERP.Model
{
	/// <summary>
	/// ORDER_ZBPrice:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ORDER_ZBPrice
	{
		public ORDER_ZBPrice()
		{}
		#region Model
		private string _custom_code;
		private string _custom_name;
		private Guid _zbggid;
		private string _zbbh;
		private string _pzmc;
		private decimal? _price;
		private string _create_name;
		private DateTime? _create_date;
		/// <summary>
		/// 
		/// </summary>
		public string CUSTOM_CODE
		{
			set{ _custom_code=value;}
			get{return _custom_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CUSTOM_NAME
		{
			set{ _custom_name=value;}
			get{return _custom_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public Guid ZBGGID
		{
			set{ _zbggid=value;}
			get{return _zbggid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ZBBH
		{
			set{ _zbbh=value;}
			get{return _zbbh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PZMC
		{
			set{ _pzmc=value;}
			get{return _pzmc;}
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
		#endregion Model

	}
}

