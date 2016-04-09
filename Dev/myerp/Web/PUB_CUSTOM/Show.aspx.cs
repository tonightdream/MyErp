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
namespace MyERP.Web.PUB_CUSTOM
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
					string CUSTOM_CODE= strid;
					ShowInfo(CUSTOM_CODE);
				}
			}
		}
		
	private void ShowInfo(string CUSTOM_CODE)
	{
		MyERP.BLL.PUB_CUSTOM bll=new MyERP.BLL.PUB_CUSTOM();
		MyERP.Model.PUB_CUSTOM model=bll.GetModel(CUSTOM_CODE);
		this.lblCUSTOM_CODE.Text=model.CUSTOM_CODE;
		this.lblCUSTOM_NAME.Text=model.CUSTOM_NAME;
		this.lblCREDIT_LIMIT.Text=model.CREDIT_LIMIT;
		this.lblORG_CODE.Text=model.ORG_CODE;
		this.lblPARENT_CUSTOM_CODE.Text=model.PARENT_CUSTOM_CODE;
		this.lblCREDIT_AMOUNT.Text=model.CREDIT_AMOUNT.ToString();
		this.lblCUSTOM_TYPE_CODE.Text=model.CUSTOM_TYPE_CODE;
		this.lblFULL_NAME.Text=model.FULL_NAME;
		this.lblSALE_MAN.Text=model.SALE_MAN;
		this.lblFAX.Text=model.FAX;
		this.lblMANAGER.Text=model.MANAGER;
		this.lblADDRESS.Text=model.ADDRESS;
		this.lblTELPHIONE.Text=model.TELPHIONE;
		this.lblZIP.Text=model.ZIP;
		this.lblEMAIL.Text=model.EMAIL;
		this.lblHTTP.Text=model.HTTP;
		this.lblVIPCARD_CODE.Text=model.VIPCARD_CODE;
		this.lblVIPCARD_NAME.Text=model.VIPCARD_NAME;
		this.lblCREATE_NAME.Text=model.CREATE_NAME;
		this.lblCREATE_DATE.Text=model.CREATE_DATE;
		this.lblUPDATE_NAME.Text=model.UPDATE_NAME;
		this.lblUPDATE_DATE.Text=model.UPDATE_DATE;
		this.lblREMARK.Text=model.REMARK;

	}


    }
}
