using System;
namespace MyERP.Model
{
	/// <summary>
	/// SAL_RECEIPT_MASTER:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class SAL_RECEIPT_MASTER
	{
		public SAL_RECEIPT_MASTER()
		{}
		#region Model
		private string _billno;
		private string _company_code;
		private string _company_name;
		private string _parent_company_code;
		private string _custom_code;
		private string _custom_name;
		private string _billtype;
		private string _stock_code;
		private string _stock_name;
		private string _instock_code;
		private string _instock_name;
		private string _employee_code;
		private string _employee_name;
		private DateTime? _billdate;
		private string _bill_status;
		private decimal? _payacount;
		private string _remark;
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
		public string BillTYPE
		{
			set{ _billtype=value;}
			get{return _billtype;}
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
		public string INSTOCK_CODE
		{
			set{ _instock_code=value;}
			get{return _instock_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string INSTOCK_NAME
		{
			set{ _instock_name=value;}
			get{return _instock_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string EMPLOYEE_CODE
		{
			set{ _employee_code=value;}
			get{return _employee_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string EMPLOYEE_NAME
		{
			set{ _employee_name=value;}
			get{return _employee_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? BillDate
		{
			set{ _billdate=value;}
			get{return _billdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BILL_STATUS
		{
			set{ _bill_status=value;}
			get{return _bill_status;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? PayAcount
		{
			set{ _payacount=value;}
			get{return _payacount;}
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

