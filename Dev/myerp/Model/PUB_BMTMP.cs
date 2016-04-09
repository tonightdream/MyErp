using System;
namespace MyERP.Model
{
	/// <summary>
	/// PUB_BMTMP:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class PUB_BMTMP
	{
		public PUB_BMTMP()
		{}
		#region Model
		private string _bmcode;
		private string _bmname;
		/// <summary>
		/// 
		/// </summary>
		public string BMCODE
		{
			set{ _bmcode=value;}
			get{return _bmcode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BMNAME
		{
			set{ _bmname=value;}
			get{return _bmname;}
		}
		#endregion Model

	}
}

