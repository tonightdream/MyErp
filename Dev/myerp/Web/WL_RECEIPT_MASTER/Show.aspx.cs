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
namespace MyERP.Web.WL_RECEIPT_MASTER
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
					string BillNO= strid;
					ShowInfo(BillNO);
				}
			}
		}
		
	private void ShowInfo(string BillNO)
	{
		MyERP.BLL.WL_RECEIPT_MASTER bll=new MyERP.BLL.WL_RECEIPT_MASTER();
		MyERP.Model.WL_RECEIPT_MASTER model=bll.GetModel(BillNO);
		this.lblBillNO.Text=model.BillNO;
		this.lblCOMPANY_CODE.Text=model.COMPANY_CODE;
		this.lblCOMPANY_NAME.Text=model.COMPANY_NAME;
		this.lblPARENT_COMPANY_CODE.Text=model.PARENT_COMPANY_CODE;
		this.lblCUSTOM_CODE.Text=model.CUSTOM_CODE;
		this.lblCUSTOM_NAME.Text=model.CUSTOM_NAME;
		this.lblBillTYPE.Text=model.BillTYPE;
		this.lblSTOCK_CODE.Text=model.STOCK_CODE;
		this.lblSTOCK_NAME.Text=model.STOCK_NAME;
		this.lblINSTOCK_CODE.Text=model.INSTOCK_CODE;
		this.lblINSTOCK_NAME.Text=model.INSTOCK_NAME;
		this.lblEMPLOYEE_CODE.Text=model.EMPLOYEE_CODE;
		this.lblEMPLOYEE_NAME.Text=model.EMPLOYEE_NAME;
		this.lblBillDate.Text=model.BillDate.ToString();
		this.lblBILL_STATUS.Text=model.BILL_STATUS;
		this.lblPayAcount.Text=model.PayAcount.ToString();
		this.lblREMARK.Text=model.REMARK;

	}


    }
}
