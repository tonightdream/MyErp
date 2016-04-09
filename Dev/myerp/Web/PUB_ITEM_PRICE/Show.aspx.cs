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
namespace MyERP.Web.PUB_ITEM_PRICE
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
					string ITEM_CODE= strid;
					ShowInfo(ITEM_CODE);
				}
			}
		}
		
	private void ShowInfo(string ITEM_CODE)
	{
		MyERP.BLL.PUB_ITEM_PRICE bll=new MyERP.BLL.PUB_ITEM_PRICE();
		MyERP.Model.PUB_ITEM_PRICE model=bll.GetModel(ITEM_CODE);
		this.lblCOMPANY_CODE.Text=model.COMPANY_CODE;
		this.lblITEM_INTERNAL_CODE.Text=model.ITEM_INTERNAL_CODE;
		this.lblITEM_CODE.Text=model.ITEM_CODE;
		this.lblITEM_NAME.Text=model.ITEM_NAME;
		this.lblCOLOR.Text=model.COLOR;
		this.lblMeasureUnit.Text=model.MeasureUnit;
		this.lblPRICE.Text=model.PRICE.ToString();
		this.lblSTART_DATE.Text=model.START_DATE.ToString();
		this.lblSTOP_DATE.Text=model.STOP_DATE.ToString();
		this.lblCREATE_NAME.Text=model.CREATE_NAME;
		this.lblCREATE_DATE.Text=model.CREATE_DATE.ToString();
		this.lblREMARK.Text=model.REMARK;

	}


    }
}
