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
namespace MyERP.Web.SYS_USER_DATARIGHT
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
					int tempid=(Convert.ToInt32(strid));
					ShowInfo(tempid);
				}
			}
		}
		
	private void ShowInfo(int tempid)
	{
		MyERP.BLL.SYS_USER_DATARIGHT bll=new MyERP.BLL.SYS_USER_DATARIGHT();
		MyERP.Model.SYS_USER_DATARIGHT model=bll.GetModel(tempid);
		this.lblMENU_CODE.Text=model.MENU_CODE;
		this.lblMENU_NAME.Text=model.MENU_NAME;
		this.lblMENU_UNIT.Text=model.MENU_UNIT;
		this.lblPARENT_MENU_CODE.Text=model.PARENT_MENU_CODE;
		this.lblUSER_CODE.Text=model.USER_CODE;
		this.lblIMAGE_INDEX.Text=model.IMAGE_INDEX.ToString();
		this.lbltempid.Text=model.tempid.ToString();

	}


    }
}
