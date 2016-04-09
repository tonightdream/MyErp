using System;
namespace MyERP.Model
{
	/// <summary>
	/// PUB_FIXEDASSET:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class PUB_FIXEDASSET
	{
		public PUB_FIXEDASSET()
		{}
		#region Model
		private string _item_internal_code;
		private string _fixedasset_code;
		private string _fixedasset_name;
		private string _specifications;
		private string _supply_code;
		private string _supply_name;
		private DateTime? _out_date;
		private string _power_rate;
		private string _begin_date;
		private string _end_date;
		private string _measure_unit;
		private decimal? _quantity;
		private string _fixedasset_status;
		private string _department_code;
		private string _department_name;
		private string _position;
		private string _create_name;
		private DateTime? _create_date;
		private string _update_name;
		private DateTime? _update_date;
		private string _remark;
		/// <summary>
		/// 
		/// </summary>
		public string ITEM_INTERNAL_CODE
		{
			set{ _item_internal_code=value;}
			get{return _item_internal_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FIXEDASSET_CODE
		{
			set{ _fixedasset_code=value;}
			get{return _fixedasset_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FIXEDASSET_NAME
		{
			set{ _fixedasset_name=value;}
			get{return _fixedasset_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SPECIFICATIONS
		{
			set{ _specifications=value;}
			get{return _specifications;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SUPPLY_CODE
		{
			set{ _supply_code=value;}
			get{return _supply_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SUPPLY_NAME
		{
			set{ _supply_name=value;}
			get{return _supply_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? OUT_DATE
		{
			set{ _out_date=value;}
			get{return _out_date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string POWER_RATE
		{
			set{ _power_rate=value;}
			get{return _power_rate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BEGIN_DATE
		{
			set{ _begin_date=value;}
			get{return _begin_date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string END_DATE
		{
			set{ _end_date=value;}
			get{return _end_date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MEASURE_UNIT
		{
			set{ _measure_unit=value;}
			get{return _measure_unit;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? QUANTITY
		{
			set{ _quantity=value;}
			get{return _quantity;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FIXEDASSET_STATUS
		{
			set{ _fixedasset_status=value;}
			get{return _fixedasset_status;}
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
		public string POSITION
		{
			set{ _position=value;}
			get{return _position;}
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

