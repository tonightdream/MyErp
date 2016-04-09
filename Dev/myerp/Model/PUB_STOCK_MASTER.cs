using System;
namespace MyERP.Model
{
	/// <summary>
	/// PUB_STOCK_MASTER:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class PUB_STOCK_MASTER
	{
		public PUB_STOCK_MASTER()
		{}
		#region Model
		private string _company_code;
		private string _company_name;
		private string _parent_company_code;
		private string _stock_code;
		private string _stock_name;
		private string _parent_stock_code;
		private string _create_name;
		private DateTime? _create_date;
		private string _update_name;
		private DateTime? _update_date;
		private string _remark;
		/// <summary>
		/// 
		/// </summary>
		public string COMPANY_CODE
		{
			set{ _company_code=value;}
			get{return _company_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string COMPANY_NAME
		{
			set{ _company_name=value;}
			get{return _company_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PARENT_COMPANY_CODE
		{
			set{ _parent_company_code=value;}
			get{return _parent_company_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string STOCK_CODE
		{
			set{ _stock_code=value;}
			get{return _stock_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string STOCK_NAME
		{
			set{ _stock_name=value;}
			get{return _stock_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PARENT_STOCK_CODE
		{
			set{ _parent_stock_code=value;}
			get{return _parent_stock_code;}
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

