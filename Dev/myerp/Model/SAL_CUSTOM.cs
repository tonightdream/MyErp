using System;
namespace MyERP.Model
{
	/// <summary>
	/// SAL_CUSTOM:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class SAL_CUSTOM
	{
		public SAL_CUSTOM()
		{}
		#region Model
		private string _companycode;
		private string _customercode;
		private string _customerlevel;
		private decimal? _discount;
		private int? _discountgrade;
		private decimal? _tradeamount;
		private DateTime? _tradeamountdate;
		private int? _tradegrade;
		private decimal? _dueamount;
		private DateTime? _dueamountdate;
		private int? _duegrade;
		private int? _duetime;
		private int? _duetimegrade;
		private DateTime? _duetimedate;
		private string _remark;
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
		public string CustomerCode
		{
			set{ _customercode=value;}
			get{return _customercode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CustomerLevel
		{
			set{ _customerlevel=value;}
			get{return _customerlevel;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Discount
		{
			set{ _discount=value;}
			get{return _discount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? DiscountGrade
		{
			set{ _discountgrade=value;}
			get{return _discountgrade;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? TradeAmount
		{
			set{ _tradeamount=value;}
			get{return _tradeamount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? TradeAmountDate
		{
			set{ _tradeamountdate=value;}
			get{return _tradeamountdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? TradeGrade
		{
			set{ _tradegrade=value;}
			get{return _tradegrade;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? DueAmount
		{
			set{ _dueamount=value;}
			get{return _dueamount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? DueAmountDate
		{
			set{ _dueamountdate=value;}
			get{return _dueamountdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? DueGrade
		{
			set{ _duegrade=value;}
			get{return _duegrade;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? DueTime
		{
			set{ _duetime=value;}
			get{return _duetime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? DueTimeGrade
		{
			set{ _duetimegrade=value;}
			get{return _duetimegrade;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? DueTimeDate
		{
			set{ _duetimedate=value;}
			get{return _duetimedate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Remark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		#endregion Model

	}
}

