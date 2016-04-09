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
namespace MyERP.Web.SAL_ITEM_STOCK_DETAIL_BEGIN_RECORD
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
					int ID=(Convert.ToInt32(strid));
					ShowInfo(ID);
				}
			}
		}
		
	private void ShowInfo(int ID)
	{
		MyERP.BLL.SAL_ITEM_STOCK_DETAIL_BEGIN_RECORD bll=new MyERP.BLL.SAL_ITEM_STOCK_DETAIL_BEGIN_RECORD();
		MyERP.Model.SAL_ITEM_STOCK_DETAIL_BEGIN_RECORD model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.lblSTOCK_CODE.Text=model.STOCK_CODE;
		this.lblCREATE_DATE.Text=model.CREATE_DATE;
		this.lblCREATE_NAME.Text=model.CREATE_NAME;

	}


    }
}
