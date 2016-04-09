using System;
namespace MyERP.Model
{
	/// <summary>
	/// PUB_VEHICLE:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class PUB_VEHICLE
	{
		public PUB_VEHICLE()
		{}
		#region Model
		private Guid _vehicleid;
		private string _vehicle_code;
		private string _vehicle_name;
		private string _mobilephone;
		private decimal? _standard_area;
		private decimal? _real_area;
		private decimal? _weigth;
		private string _withcar;
		private string _create_date;
		private string _create_name;
		private DateTime? _update_date;
		private string _update_name;
		private string _remark;
		/// <summary>
		/// 
		/// </summary>
		public Guid VehicleID
		{
			set{ _vehicleid=value;}
			get{return _vehicleid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Vehicle_CODE
		{
			set{ _vehicle_code=value;}
			get{return _vehicle_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Vehicle_NAME
		{
			set{ _vehicle_name=value;}
			get{return _vehicle_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MobilePhone
		{
			set{ _mobilephone=value;}
			get{return _mobilephone;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? standard_area
		{
			set{ _standard_area=value;}
			get{return _standard_area;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Real_area
		{
			set{ _real_area=value;}
			get{return _real_area;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? weigth
		{
			set{ _weigth=value;}
			get{return _weigth;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Withcar
		{
			set{ _withcar=value;}
			get{return _withcar;}
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
		public string UPDATE_NAME
		{
			set{ _update_name=value;}
			get{return _update_name;}
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

