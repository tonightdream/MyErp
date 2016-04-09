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
namespace MyERP.Web.PUB_FIXEDASSET
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
					string ITEM_INTERNAL_CODE= strid;
					ShowInfo(ITEM_INTERNAL_CODE);
				}
			}
		}
		
	private void ShowInfo(string ITEM_INTERNAL_CODE)
	{
		MyERP.BLL.PUB_FIXEDASSET bll=new MyERP.BLL.PUB_FIXEDASSET();
		MyERP.Model.PUB_FIXEDASSET model=bll.GetModel(ITEM_INTERNAL_CODE);
		this.lblITEM_INTERNAL_CODE.Text=model.ITEM_INTERNAL_CODE;
		this.lblFIXEDASSET_CODE.Text=model.FIXEDASSET_CODE;
		this.lblFIXEDASSET_NAME.Text=model.FIXEDASSET_NAME;
		this.lblSPECIFICATIONS.Text=model.SPECIFICATIONS;
		this.lblSUPPLY_CODE.Text=model.SUPPLY_CODE;
		this.lblSUPPLY_NAME.Text=model.SUPPLY_NAME;
		this.lblOUT_DATE.Text=model.OUT_DATE.ToString();
		this.lblPOWER_RATE.Text=model.POWER_RATE;
		this.lblBEGIN_DATE.Text=model.BEGIN_DATE;
		this.lblEND_DATE.Text=model.END_DATE;
		this.lblMEASURE_UNIT.Text=model.MEASURE_UNIT;
		this.lblQUANTITY.Text=model.QUANTITY.ToString();
		this.lblFIXEDASSET_STATUS.Text=model.FIXEDASSET_STATUS;
		this.lblDEPARTMENT_CODE.Text=model.DEPARTMENT_CODE;
		this.lblDEPARTMENT_NAME.Text=model.DEPARTMENT_NAME;
		this.lblPOSITION.Text=model.POSITION;
		this.lblCREATE_NAME.Text=model.CREATE_NAME;
		this.lblCREATE_DATE.Text=model.CREATE_DATE.ToString();
		this.lblUPDATE_NAME.Text=model.UPDATE_NAME;
		this.lblUPDATE_DATE.Text=model.UPDATE_DATE.ToString();
		this.lblREMARK.Text=model.REMARK;

	}


    }
}
