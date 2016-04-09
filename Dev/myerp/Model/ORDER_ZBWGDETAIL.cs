using System;
namespace MyERP.Model
{
	/// <summary>
	/// ORDER_ZBWGDETAIL:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ORDER_ZBWGDETAIL
	{
		public ORDER_ZBWGDETAIL()
		{}
		#region Model
		private Guid _detailid;
		private string _billno;
		private string _sequence;
		private string _iteminternalcode;
		private string _zxbjno;
		private string _zxbjname;
		private int? _quantity;
		private int? _fpqty;
		private string _create_date;
		private string _create_name;
		private string _remark;
		/// <summary>
		/// 
		/// </summary>
		public Guid DetailID
		{
			set{ _detailid=value;}
			get{return _detailid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BillNO
		{
			set{ _billno=value;}
			get{return _billno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Sequence
		{
			set{ _sequence=value;}
			get{return _sequence;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ItemInternalCode
		{
			set{ _iteminternalcode=value;}
			get{return _iteminternalcode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ZXBJNO
		{
			set{ _zxbjno=value;}
			get{return _zxbjno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ZXBJNAME
		{
			set{ _zxbjname=value;}
			get{return _zxbjname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Quantity
		{
			set{ _quantity=value;}
			get{return _quantity;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? FPqty
		{
			set{ _fpqty=value;}
			get{return _fpqty;}
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
		public string REMARK
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		#endregion Model

	}
}

