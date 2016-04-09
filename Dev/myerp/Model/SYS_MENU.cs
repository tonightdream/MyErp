using System;
namespace MyERP.Model
{
	/// <summary>
	/// SYS_MENU:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class SYS_MENU
	{
		public SYS_MENU()
		{}
		#region Model
		private string _menu_code;
		private string _menu_name;
		private Guid _menuid;
		private int? _image_index;
		private string _menu_unit;
		private string _parent_menu_code;
		private bool _sysselect;
		/// <summary>
		/// 
		/// </summary>
		public string MENU_CODE
		{
			set{ _menu_code=value;}
			get{return _menu_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MENU_NAME
		{
			set{ _menu_name=value;}
			get{return _menu_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public Guid MenuID
		{
			set{ _menuid=value;}
			get{return _menuid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? IMAGE_INDEX
		{
			set{ _image_index=value;}
			get{return _image_index;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MENU_UNIT
		{
			set{ _menu_unit=value;}
			get{return _menu_unit;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PARENT_MENU_CODE
		{
			set{ _parent_menu_code=value;}
			get{return _parent_menu_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool SysSelect
		{
			set{ _sysselect=value;}
			get{return _sysselect;}
		}
		#endregion Model

	}
}

