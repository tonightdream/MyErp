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
namespace MyERP.Web.PUB_STOCK_MASTER
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
					string STOCK_CODE= strid;
					ShowInfo(STOCK_CODE);
				}
			}
		}
		
	private void ShowInfo(string STOCK_CODE)
	{
		MyERP.BLL.PUB_STOCK_MASTER bll=new MyERP.BLL.PUB_STOCK_MASTER();
		MyERP.Model.PUB_STOCK_MASTER model=bll.GetModel(STOCK_CODE);
		this.lblCOMPANY_CODE.Text=model.COMPANY_CODE;
		this.lblCOMPANY_NAME.Text=model.COMPANY_NAME;
		this.lblPARENT_COMPANY_CODE.Text=model.PARENT_COMPANY_CODE;
		this.lblSTOCK_CODE.Text=model.STOCK_CODE;
		this.lblSTOCK_NAME.Text=model.STOCK_NAME;
		this.lblPARENT_STOCK_CODE.Text=model.PARENT_STOCK_CODE;
		this.lblCREATE_NAME.Text=model.CREATE_NAME;
		this.lblCREATE_DATE.Text=model.CREATE_DATE.ToString();
		this.lblUPDATE_NAME.Text=model.UPDATE_NAME;
		this.lblUPDATE_DATE.Text=model.UPDATE_DATE.ToString();
		this.lblREMARK.Text=model.REMARK;

	}


    }
}
