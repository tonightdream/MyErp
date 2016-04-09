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
namespace MyERP.Web.ORDER_PCMASTER
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
					string BillNo= strid;
					ShowInfo(BillNo);
				}
			}
		}
		
	private void ShowInfo(string BillNo)
	{
		MyERP.BLL.ORDER_PCMASTER bll=new MyERP.BLL.ORDER_PCMASTER();
		MyERP.Model.ORDER_PCMASTER model=bll.GetModel(BillNo);
		this.lblBillNo.Text=model.BillNo;
		this.lblBILL_DATE.Text=model.BILL_DATE;
		this.lblGROUP.Text=model.GROUP;
		this.lblMACHINE.Text=model.MACHINE;
		this.lblFACTORY.Text=model.FACTORY;
		this.lblBILL_STATUS.Text=model.BILL_STATUS.ToString();
		this.lblSTOCK_CODE.Text=model.STOCK_CODE;
		this.lblSTOCK_NAME.Text=model.STOCK_NAME;
		this.lblDEPARTMENT_CODE.Text=model.DEPARTMENT_CODE;
		this.lblDEPARTMENT_NAME.Text=model.DEPARTMENT_NAME;
		this.lblCREATE_CODE.Text=model.CREATE_CODE;
		this.lblCREATE_NAME.Text=model.CREATE_NAME;
		this.lblCREATE_DATE.Text=model.CREATE_DATE.ToString();
		this.lblREMARK.Text=model.REMARK;

	}


    }
}
