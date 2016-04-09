using System;
namespace MyERP.Model
{
	/// <summary>
	/// SYS_VERSION:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class SYS_VERSION
	{
		public SYS_VERSION()
		{}
		#region Model
		private string _version;
		/// <summary>
		/// 
		/// </summary>
		public string VERSION
		{
			set{ _version=value;}
			get{return _version;}
		}
		#endregion Model

	}
}

