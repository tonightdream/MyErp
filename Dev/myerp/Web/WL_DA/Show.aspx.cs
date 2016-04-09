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
namespace MyERP.Web.WL_DA
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
		MyERP.BLL.WL_DA bll=new MyERP.BLL.WL_DA();
		MyERP.Model.WL_DA model=bll.GetModel(ITEM_INTERNAL_CODE);
		this.lblITEM_INTERNAL_CODE.Text=model.ITEM_INTERNAL_CODE;
		this.lblITEM_CODE.Text=model.ITEM_CODE;
		this.lblITEM_CODE_old.Text=model.ITEM_CODE_old;
		this.lblITEM_NAME.Text=model.ITEM_NAME;
		this.lblITEM_COLOR.Text=model.ITEM_COLOR;
		this.lblPARENT_ITEM_CODE.Text=model.PARENT_ITEM_CODE;
		this.lblITEM_TYPE.Text=model.ITEM_TYPE;
		this.lblSPECIFICATIONS.Text=model.SPECIFICATIONS;
		this.lblITEM_CZ.Text=model.ITEM_CZ;
		this.lblITEM_JZ.Text=model.ITEM_JZ.ToString();
		this.lblITEM_HZ.Text=model.ITEM_HZ.ToString();
		this.lblITEM_GYLC.Text=model.ITEM_GYLC;
		this.lblDICT_CODE.Text=model.DICT_CODE;
		this.lblMEASURE_UNIT.Text=model.MEASURE_UNIT;
		this.lblTYPE_NAME.Text=model.TYPE_NAME;
		this.lblNET_PRICE.Text=model.NET_PRICE.ToString();
		this.lblPRICE.Text=model.PRICE.ToString();
		this.lblMIN_QTY.Text=model.MIN_QTY.ToString();
		this.lblMAX_QTY.Text=model.MAX_QTY.ToString();
		this.lblPOSITION.Text=model.POSITION;
		this.lblIMAGE.Text=model.IMAGE.ToString();
		this.lblIMAGE_NAME.Text=model.IMAGE_NAME;
		this.lblActual_Qty.Text=model.Actual_Qty.ToString();
		this.lblBARCODE.Text=model.BARCODE;
		this.lblDESCRIPTION.Text=model.DESCRIPTION;
		this.lblCREATE_NAME.Text=model.CREATE_NAME;
		this.lblCREATE_DATE.Text=model.CREATE_DATE.ToString();
		this.lblUPDATE_NAME.Text=model.UPDATE_NAME;
		this.lblUPDATE_DATE.Text=model.UPDATE_DATE.ToString();
		this.lblREMARK.Text=model.REMARK;

	}


    }
}
