using System;
namespace MyERP.Model
{
	/// <summary>
	/// ORDER_SEND_SHD:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ORDER_SEND_SHD
	{
		public ORDER_SEND_SHD()
		{}
		#region Model
		private string _billno;
		private DateTime? _bill_date;
		private string _custom_code;
		private string _custom_name;
		private string _pcbh;
		private string _clbh;
		private decimal? _shje;
		private decimal? _thje;
		private decimal? _hzje;
		private decimal? _lwkkje;
		private decimal? _ysje;
		private string _accepter;
		private string _create_name;
		private DateTime? _create_date;
		private string _remark;
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
		public DateTime? BILL_DATE
		{
			set{ _bill_date=value;}
			get{return _bill_date;}
		}
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
		public string PCBH
		{
			set{ _pcbh=value;}
			get{return _pcbh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CLBH
		{
			set{ _clbh=value;}
			get{return _clbh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? SHJE
		{
			set{ _shje=value;}
			get{return _shje;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? THJE
		{
			set{ _thje=value;}
			get{return _thje;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? HZJE
		{
			set{ _hzje=value;}
			get{return _hzje;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LWKKJE
		{
			set{ _lwkkje=value;}
			get{return _lwkkje;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? YSJE
		{
			set{ _ysje=value;}
			get{return _ysje;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Accepter
		{
			set{ _accepter=value;}
			get{return _accepter;}
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
		public string REMARK
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		#endregion Model

	}
}

