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
namespace MyERP.Web.PUB_PAYMENT_TYPE
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
					string PAYMENT_CODE= strid;
					ShowInfo(PAYMENT_CODE);
				}
			}
		}
		
	private void ShowInfo(string PAYMENT_CODE)
	{
		MyERP.BLL.PUB_PAYMENT_TYPE bll=new MyERP.BLL.PUB_PAYMENT_TYPE();
		MyERP.Model.PUB_PAYMENT_TYPE model=bll.GetModel(PAYMENT_CODE);
		this.lblCOMPANY_CODE.Text=model.COMPANY_CODE;
		this.lblPAYMENT_CODE.Text=model.PAYMENT_CODE;
		this.lblPAYMENT_NAME.Text=model.PAYMENT_NAME;
		this.lblDESC.Text=model.DESC;
		this.lblCREATE_NAME.Text=model.CREATE_NAME;
		this.lblCREATE_DATE.Text=model.CREATE_DATE.ToString();
		this.lblUPDATE_NAME.Text=model.UPDATE_NAME;
		this.lblUPDATE_DATE.Text=model.UPDATE_DATE.ToString();
		this.lblREMARK.Text=model.REMARK;

	}


    }
}
