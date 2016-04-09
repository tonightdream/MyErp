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
namespace MyERP.Web.PUR_PURCHASE_MASTER
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
					string BILLNO= strid;
					ShowInfo(BILLNO);
				}
			}
		}
		
	private void ShowInfo(string BILLNO)
	{
		MyERP.BLL.PUR_PURCHASE_MASTER bll=new MyERP.BLL.PUR_PURCHASE_MASTER();
		MyERP.Model.PUR_PURCHASE_MASTER model=bll.GetModel(BILLNO);
		this.lblMASTERID.Text=model.MASTERID;
		this.lblBILLNO.Text=model.BILLNO;
		this.lblFACTORY.Text=model.FACTORY;
		this.lblMANUAL_BILLNO.Text=model.MANUAL_BILLNO;
		this.lblSUPPLY_CODE.Text=model.SUPPLY_CODE;
		this.lblSUPPLY_NAME.Text=model.SUPPLY_NAME;
		this.lblBILL_TYPE.Text=model.BILL_TYPE;
		this.lblBILL_DATE.Text=model.BILL_DATE.ToString();
		this.lblBILL_STATUS.Text=model.BILL_STATUS;
		this.lblSCYQ.Text=model.SCYQ;
		this.lblBZTYPE.Text=model.BZTYPE;
		this.lblSTOCK_CODE.Text=model.STOCK_CODE;
		this.lblSTOCK_NAME.Text=model.STOCK_NAME;
		this.lblDEPARTMENT_CODE.Text=model.DEPARTMENT_CODE;
		this.lblDEPARTMENT_NAME.Text=model.DEPARTMENT_NAME;
		this.lblCREATE_CODE.Text=model.CREATE_CODE;
		this.lblCREATE_NAME.Text=model.CREATE_NAME;
		this.lblCREATE_DATE.Text=model.CREATE_DATE.ToString();
		this.lblUPDATE_NAME.Text=model.UPDATE_NAME;
		this.lblUPDATE_DATE.Text=model.UPDATE_DATE;
		this.lblREMARK.Text=model.REMARK;
		this.lblREMARK1.Text=model.REMARK1;
		this.lblREMARK2.Text=model.REMARK2;

	}


    }
}
