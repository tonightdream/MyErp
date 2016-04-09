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
namespace MyERP.Web.PUB_AREA
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
					string AREA_CODE= strid;
					ShowInfo(AREA_CODE);
				}
			}
		}
		
	private void ShowInfo(string AREA_CODE)
	{
		MyERP.BLL.PUB_AREA bll=new MyERP.BLL.PUB_AREA();
		MyERP.Model.PUB_AREA model=bll.GetModel(AREA_CODE);
		this.lblCOMPANY_CODE.Text=model.COMPANY_CODE;
		this.lblAREA_CODE.Text=model.AREA_CODE;
		this.lblAREA_NAME.Text=model.AREA_NAME;
		this.lblPARENT_AREA_CODE.Text=model.PARENT_AREA_CODE;
		this.lblMANAGER.Text=model.MANAGER;
		this.lblALLOW_USERED.Text=model.ALLOW_USERED;
		this.lblCREATE_NAME.Text=model.CREATE_NAME;
		this.lblCREATE_DATE.Text=model.CREATE_DATE.ToString();
		this.lblUPDATE_NAME.Text=model.UPDATE_NAME;
		this.lblUPDATE_DATE.Text=model.UPDATE_DATE.ToString();

	}


    }
}
