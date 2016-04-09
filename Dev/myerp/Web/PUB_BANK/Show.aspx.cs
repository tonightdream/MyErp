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
namespace MyERP.Web.PUB_BANK
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
					string BANK_CODE= strid;
					ShowInfo(BANK_CODE);
				}
			}
		}
		
	private void ShowInfo(string BANK_CODE)
	{
		MyERP.BLL.PUB_BANK bll=new MyERP.BLL.PUB_BANK();
		MyERP.Model.PUB_BANK model=bll.GetModel(BANK_CODE);
		this.lblINTERNAL_CODE.Text=model.INTERNAL_CODE;
		this.lblBANK_CODE.Text=model.BANK_CODE;
		this.lblBANK_NAME.Text=model.BANK_NAME;
		this.lblCREATE_NAME.Text=model.CREATE_NAME;
		this.lblCREATE_DATE.Text=model.CREATE_DATE.ToString();
		this.lblUPDATE_NAME.Text=model.UPDATE_NAME;
		this.lblUPDATE_DATE.Text=model.UPDATE_DATE;

	}


    }
}
