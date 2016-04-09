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
namespace MyERP.Web.VIP_INFO
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
					decimal VIP_TEMP_CARD_CODE=(Convert.ToDecimal(strid));
					ShowInfo(VIP_TEMP_CARD_CODE);
				}
			}
		}
		
	private void ShowInfo(decimal VIP_TEMP_CARD_CODE)
	{
		MyERP.BLL.VIP_INFO bll=new MyERP.BLL.VIP_INFO();
		MyERP.Model.VIP_INFO model=bll.GetModel(VIP_TEMP_CARD_CODE);
		this.lblCOMPANY_CODE.Text=model.COMPANY_CODE;
		this.lblUSER_CODE.Text=model.USER_CODE;
		this.lblUSER_NAME.Text=model.USER_NAME;
		this.lblVIP_CARD_CODE.Text=model.VIP_CARD_CODE;
		this.lblVIP_TEMP_CARD_CODE.Text=model.VIP_TEMP_CARD_CODE.ToString();
		this.lblPASSWORD.Text=model.PASSWORD;
		this.lblBEGIN_DATE.Text=model.BEGIN_DATE.ToString();
		this.lblEND_DATE.Text=model.END_DATE.ToString();
		this.lblVIP_TYPE.Text=model.VIP_TYPE;
		this.lblTOTAL_SALES.Text=model.TOTAL_SALES.ToString();
		this.lblsalesno.Text=model.salesno;
		this.lblCREATE_NAME.Text=model.CREATE_NAME;
		this.lblCREATE_DATE.Text=model.CREATE_DATE.ToString();
		this.lblUPDATE_NAME.Text=model.UPDATE_NAME;
		this.lblUPDATE_DATE.Text=model.UPDATE_DATE.ToString();
		this.lblREMARK.Text=model.REMARK;

	}


    }
}
