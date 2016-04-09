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
namespace MyERP.Web.PUB_ITEM_TYPE
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
					string TYPE_CODE= strid;
					ShowInfo(TYPE_CODE);
				}
			}
		}
		
	private void ShowInfo(string TYPE_CODE)
	{
		MyERP.BLL.PUB_ITEM_TYPE bll=new MyERP.BLL.PUB_ITEM_TYPE();
		MyERP.Model.PUB_ITEM_TYPE model=bll.GetModel(TYPE_CODE);
		this.lblINTERNAL_CODE.Text=model.INTERNAL_CODE;
		this.lblCOMPANY_CODE.Text=model.COMPANY_CODE;
		this.lblCOMPANY_NAME.Text=model.COMPANY_NAME;
		this.lblTYPE_CODE.Text=model.TYPE_CODE;
		this.lblTYPE_NAME.Text=model.TYPE_NAME;
		this.lblPARENT_TYPE_CODE.Text=model.PARENT_TYPE_CODE;
		this.lblCREATE_NAME.Text=model.CREATE_NAME;
		this.lblCREATE_DATE.Text=model.CREATE_DATE.ToString();
		this.lblALLOW_used.Text=model.ALLOW_used?"是":"否";

	}


    }
}
