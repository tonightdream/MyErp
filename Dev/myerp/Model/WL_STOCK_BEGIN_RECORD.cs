using System;
namespace MyERP.Model
{
	/// <summary>
	/// WL_STOCK_BEGIN_RECORD:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class WL_STOCK_BEGIN_RECORD
	{
		public WL_STOCK_BEGIN_RECORD()
		{}
		#region Model
		private int _id;
		private string _stock_code;
		private string _create_date;
		private string _create_name;
		/// <summary>
		/// 
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
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
		public string CREATE_DATE
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

