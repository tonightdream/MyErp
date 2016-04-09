using System;
namespace MyERP.Model
{
	/// <summary>
	/// PUB_BANK:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class PUB_BANK
	{
		public PUB_BANK()
		{}
		#region Model
		private string _internal_code;
		private string _bank_code;
		private string _bank_name;
		private string _create_name;
		private DateTime? _create_date;
		private string _update_name;
		private string _update_date;
		/// <summary>
		/// 
		/// </summary>
		public string INTERNAL_CODE
		{
			set{ _internal_code=value;}
			get{return _internal_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BANK_CODE
		{
			set{ _bank_code=value;}
			get{return _bank_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BANK_NAME
		{
			set{ _bank_name=value;}
			get{return _bank_name;}
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
		public string UPDATE_DATE
		{
			set{ _update_date=value;}
			get{return _update_date;}
		}
		#endregion Model

	}
}

