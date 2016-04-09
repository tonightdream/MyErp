using System;
namespace MyERP.Model
{
	/// <summary>
	/// CL_ITEM_STOCK_DETAIL_BEGIN_RECORD:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class CL_ITEM_STOCK_DETAIL_BEGIN_RECORD
	{
		public CL_ITEM_STOCK_DETAIL_BEGIN_RECORD()
		{}
		#region Model
		private string _company_code;
		private string _company_name;
		private DateTime? _create_date;
		private string _create_name;
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
		public DateTime? CREATE_DATE
		{
			set{ _create_date=value;}
			get{return _create_date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CREATE_NAME
		{
			set{ _create_name=value;}
			get{return _create_name;}
		}
		#endregion Model

	}
}

