using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Text;
namespace MyERP.Web.SYS_MENU
{
    public partial class Show : Page
    {        
        		public string strid=""; 
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					strid = Request.Params["id"];
					string MENU_CODE= strid;
					ShowInfo(MENU_CODE);
				}
			}
		}
		
	private void ShowInfo(string MENU_CODE)
	{
		MyERP.BLL.SYS_MENU bll=new MyERP.BLL.SYS_MENU();
		MyERP.Model.SYS_MENU model=bll.GetModel(MENU_CODE);
		this.lblMENU_CODE.Text=model.MENU_CODE;
		this.lblMENU_NAME.Text=model.MENU_NAME;
		this.lblMenuID.Text=model.MenuID.ToString();
		this.lblIMAGE_INDEX.Text=model.IMAGE_INDEX.ToString();
		this.lblMENU_UNIT.Text=model.MENU_UNIT;
		this.lblPARENT_MENU_CODE.Text=model.PARENT_MENU_CODE;
		this.lblSysSelect.Text=model.SysSelect?"是":"否";

	}


    }
}
