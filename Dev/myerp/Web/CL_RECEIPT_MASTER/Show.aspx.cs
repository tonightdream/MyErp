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
namespace MyERP.Web.CL_RECEIPT_MASTER
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
		MyERP.BLL.CL_RECEIPT_MASTER bll=new MyERP.BLL.CL_RECEIPT_MASTER();
		MyERP.Model.CL_RECEIPT_MASTER model=bll.GetModel(BillNo);
		this.lblBillNo.Text=model.BillNo;
		this.lblCOMPANY_CODE.Text=model.COMPANY_CODE;
		this.lblCOMPANY_NAME.Text=model.COMPANY_NAME;
		this.lblCUSTOM_CODE.Text=model.CUSTOM_CODE;
		this.lblCUSTOM_NAME.Text=model.CUSTOM_NAME;
		this.lblBILLTYPE.Text=model.BILLTYPE;
		this.lblBILL_STATUS.Text=model.BILL_STATUS;
		this.lblSTOCK_CODE.Text=model.STOCK_CODE;
		this.lblSTOCK_NAME.Text=model.STOCK_NAME;
		this.lblDEPARTMENT_CODE.Text=model.DEPARTMENT_CODE;
		this.lblDEPARTMENT_NAME.Text=model.DEPARTMENT_NAME;
		this.lblEMPLOYEE_CODE.Text=model.EMPLOYEE_CODE;
		this.lblEMPLOYEE_NAME.Text=model.EMPLOYEE_NAME;
		this.lblBILLDATE.Text=model.BILLDATE.ToString();
		this.lblCREATE_DATE.Text=model.CREATE_DATE.ToString();
		this.lblREMARK.Text=model.REMARK;

	}


    }
}
