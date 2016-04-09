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
namespace MyERP.Web.CL_ITEM_STOCK_DETAIL
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
					string ITEM_CODE= strid;
					ShowInfo(ITEM_CODE);
				}
			}
		}
		
	private void ShowInfo(string ITEM_CODE)
	{
		MyERP.BLL.CL_ITEM_STOCK_DETAIL bll=new MyERP.BLL.CL_ITEM_STOCK_DETAIL();
		MyERP.Model.CL_ITEM_STOCK_DETAIL model=bll.GetModel(ITEM_CODE);
		this.lblSEQUENCE.Text=model.SEQUENCE.ToString();
		this.lblITEM_INTERNAL_CODE.Text=model.ITEM_INTERNAL_CODE;
		this.lblCOMPANY_CODE.Text=model.COMPANY_CODE;
		this.lblCOMPANY_NAME.Text=model.COMPANY_NAME;
		this.lblITEM_CODE.Text=model.ITEM_CODE;
		this.lblITEM_CODE_old.Text=model.ITEM_CODE_old;
		this.lblITEM_NAME.Text=model.ITEM_NAME;
		this.lblITEM_TYPE.Text=model.ITEM_TYPE;
		this.lblITEM_COLOR.Text=model.ITEM_COLOR;
		this.lblIMAGE.Text=model.IMAGE.ToString();
		this.lblPARENT_ITEM_CODE.Text=model.PARENT_ITEM_CODE;
		this.lblTYPE_NAME.Text=model.TYPE_NAME;
		this.lblSPECIFICATIONS.Text=model.SPECIFICATIONS;
		this.lblITEM_JZ.Text=model.ITEM_JZ.ToString();
		this.lblITEM_HZ.Text=model.ITEM_HZ.ToString();
		this.lblITEM_rate.Text=model.ITEM_rate;
		this.lblITEM_GYLC.Text=model.ITEM_GYLC;
		this.lblMEASURE_UNIT.Text=model.MEASURE_UNIT;
		this.lblNET_PRICE.Text=model.NET_PRICE.ToString();
		this.lblPRICE.Text=model.PRICE.ToString();
		this.lblQTY.Text=model.QTY.ToString();
		this.lblACTUAL_QTY.Text=model.ACTUAL_QTY.ToString();
		this.lblMIN_QTY.Text=model.MIN_QTY.ToString();
		this.lblMAX_QTY.Text=model.MAX_QTY.ToString();
		this.lblSUPPLY_CODE.Text=model.SUPPLY_CODE;
		this.lblSUPPLY_NAME.Text=model.SUPPLY_NAME;
		this.lblPOSITION.Text=model.POSITION;
		this.lblDESCRIPTION.Text=model.DESCRIPTION;
		this.lblBARCODE.Text=model.BARCODE;
		this.lblCREATE_DATE.Text=model.CREATE_DATE.ToString();
		this.lblCREATE_NAME.Text=model.CREATE_NAME;
		this.lblUPDATE_DATE.Text=model.UPDATE_DATE.ToString();
		this.lblUPDATE_NAME.Text=model.UPDATE_NAME;
		this.lblREMARK.Text=model.REMARK;

	}


    }
}
