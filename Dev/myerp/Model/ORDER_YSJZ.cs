using System;
namespace MyERP.Model
{
	/// <summary>
	/// ORDER_YSJZ:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ORDER_YSJZ
	{
		public ORDER_YSJZ()
		{}
		#region Model
		private string _fdid;
		private string _customcode;
		private string _customname;
		private decimal? _sjjz;
		private decimal? _qzzk;
		private decimal? _qzys;
		private decimal? _ysje;
		private decimal? _ysws;
		private string _begindate;
		private string _enddate;
		private string _createname;
		private string _createdate;
		private string _remark;
		/// <summary>
		/// 
		/// </summary>
		public string FDID
		{
			set{ _fdid=value;}
			get{return _fdid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string customcode
		{
			set{ _customcode=value;}
			get{return _customcode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string customname
		{
			set{ _customname=value;}
			get{return _customname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? SJJZ
		{
			set{ _sjjz=value;}
			get{return _sjjz;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? QZZK
		{
			set{ _qzzk=value;}
			get{return _qzzk;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? QZYS
		{
			set{ _qzys=value;}
			get{return _qzys;}
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
		public decimal? YSWS
		{
			set{ _ysws=value;}
			get{return _ysws;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string begindate
		{
			set{ _begindate=value;}
			get{return _begindate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string enddate
		{
			set{ _enddate=value;}
			get{return _enddate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string createname
		{
			set{ _createname=value;}
			get{return _createname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string createdate
		{
			set{ _createdate=value;}
			get{return _createdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string remark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		#endregion Model

	}
}

