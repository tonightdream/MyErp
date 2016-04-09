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
namespace MyERP.Web.SYS_REGISTER
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
					string COMPANY_CODE= strid;
					ShowInfo(COMPANY_CODE);
				}
			}
		}
		
	private void ShowInfo(string COMPANY_CODE)
	{
		MyERP.BLL.SYS_REGISTER bll=new MyERP.BLL.SYS_REGISTER();
		MyERP.Model.SYS_REGISTER model=bll.GetModel(COMPANY_CODE);
		this.lblCOMPANY_CODE.Text=model.COMPANY_CODE;
		this.lblCOMPANY_NAME.Text=model.COMPANY_NAME;
		this.lblPARENT_COMPANY_CODE.Text=model.PARENT_COMPANY_CODE;
		this.lblFULL_NAME.Text=model.FULL_NAME;
		this.lblADRESS.Text=model.ADRESS;
		this.lblSERVICE_PHONE.Text=model.SERVICE_PHONE;

	}


    }
}
