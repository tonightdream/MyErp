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
namespace MyERP.Web.PUB_DEPARTMENT
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
					string DEPARTMENT_CODE= strid;
					ShowInfo(DEPARTMENT_CODE);
				}
			}
		}
		
	private void ShowInfo(string DEPARTMENT_CODE)
	{
		MyERP.BLL.PUB_DEPARTMENT bll=new MyERP.BLL.PUB_DEPARTMENT();
		MyERP.Model.PUB_DEPARTMENT model=bll.GetModel(DEPARTMENT_CODE);
		this.lblINTERNAL_CODE.Text=model.INTERNAL_CODE;
		this.lblCOMPANY_CODE.Text=model.COMPANY_CODE;
		this.lblDEPARTMENT_CODE.Text=model.DEPARTMENT_CODE;
		this.lblDEPARTMENT_NAME.Text=model.DEPARTMENT_NAME;
		this.lblPARENT_DEPARTMENT_CODE.Text=model.PARENT_DEPARTMENT_CODE;
		this.lblMANAGER.Text=model.MANAGER;
		this.lblTELEPHONE.Text=model.TELEPHONE;
		this.lblADDRESS.Text=model.ADDRESS;
		this.lblSHOP_NAME.Text=model.SHOP_NAME;
		this.lblSETTLE_DATE.Text=model.SETTLE_DATE.ToString();
		this.lblSIZE.Text=model.SIZE.ToString();
		this.lblEMAIL.Text=model.EMAIL;
		this.lblFAX.Text=model.FAX;
		this.lblDISCOUNT.Text=model.DISCOUNT.ToString();
		this.lblSHIP.Text=model.SHIP.ToString();
		this.lblPPRICE_SHOW.Text=model.PPRICE_SHOW.ToString();
		this.lblSALE_METHOD.Text=model.SALE_METHOD;
		this.lblALLOW_USED.Text=model.ALLOW_USED;
		this.lblSTART_DATE.Text=model.START_DATE.ToString();
		this.lblCREATE_NAME.Text=model.CREATE_NAME;
		this.lblCREATE_DATE.Text=model.CREATE_DATE.ToString();
		this.lblUPDATE_NAME.Text=model.UPDATE_NAME;
		this.lblUPDATE_DATE.Text=model.UPDATE_DATE.ToString();
		this.lblREMARK.Text=model.REMARK;

	}


    }
}
