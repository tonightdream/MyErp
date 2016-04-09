using System;
namespace MyERP.Model
{
	/// <summary>
	/// ORDER_Capacity_chart:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ORDER_Capacity_chart
	{
		public ORDER_Capacity_chart()
		{}
		#region Model
		private string _internal_code;
		private DateTime? _billdate;
		private string _department_code;
		private string _department_name;
		private decimal? _quantity;
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
		public DateTime? BILLDATE
		{
			set{ _billdate=value;}
			get{return _billdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DEPARTMENT_CODE
		{
			set{ _department_code=value;}
			get{return _department_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DEPARTMENT_NAME
		{
			set{ _department_name=value;}
			get{return _department_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? QUANTITY
		{
			set{ _quantity=value;}
			get{return _quantity;}
		}
		#endregion Model

	}
}

