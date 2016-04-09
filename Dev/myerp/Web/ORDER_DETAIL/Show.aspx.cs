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
namespace MyERP.Web.ORDER_DETAIL
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
					string DETAILID= strid;
					ShowInfo(DETAILID);
				}
			}
		}
		
	private void ShowInfo(string DETAILID)
	{
		MyERP.BLL.ORDER_DETAIL bll=new MyERP.BLL.ORDER_DETAIL();
		MyERP.Model.ORDER_DETAIL model=bll.GetModel(DETAILID);
		this.lblMASTERID.Text=model.MASTERID;
		this.lblDETAILID.Text=model.DETAILID;
		this.lblBILLNO.Text=model.BILLNO;
		this.lblSequence.Text=model.Sequence.ToString();
		this.lblITEM_INTERNAL_CODE.Text=model.ITEM_INTERNAL_CODE;
		this.lblITEM_CODE.Text=model.ITEM_CODE;
		this.lblITEM_CODE_old.Text=model.ITEM_CODE_old;
		this.lblITEM_NAME.Text=model.ITEM_NAME;
		this.lblITEM_COLOR.Text=model.ITEM_COLOR;
		this.lblPARENT_ITEM_CODE.Text=model.PARENT_ITEM_CODE.ToString();
		this.lblITEM_TYPE.Text=model.ITEM_TYPE;
		this.lblITEM_LOGO.Text=model.ITEM_LOGO;
		this.lblITEM_CD.Text=model.ITEM_CD.ToString();
		this.lblITEM_KD.Text=model.ITEM_KD.ToString();
		this.lblITEM_GD.Text=model.ITEM_GD.ToString();
		this.lblITEM_GYLC.Text=model.ITEM_GYLC;
		this.lblSPECIFICATIONS.Text=model.SPECIFICATIONS;
		this.lblMEASURE_UNIT.Text=model.MEASURE_UNIT;
		this.lblDWMJ.Text=model.DWMJ.ToString();
		this.lblBZFS.Text=model.BZFS;
		this.lblGRAPHICNO.Text=model.GRAPHICNO;
		this.lblDESCRIPTION.Text=model.DESCRIPTION;
		this.lblNET_PRICE.Text=model.NET_PRICE.ToString();
		this.lblPRICE.Text=model.PRICE.ToString();
		this.lblQuantity.Text=model.Quantity.ToString();
		this.lblORD_CGqty.Text=model.ORD_CGqty.ToString();
		this.lblORD_CLqty.Text=model.ORD_CLqty.ToString();
		this.lblORD_PCqty.Text=model.ORD_PCqty.ToString();
		this.lblORD_WGqty.Text=model.ORD_WGqty.ToString();
		this.lblORD_TCqty.Text=model.ORD_TCqty.ToString();
		this.lblORD_WGZL.Text=model.ORD_WGZL.ToString();
		this.lblORD_FPqty.Text=model.ORD_FPqty.ToString();
		this.lblORD_LHqty.Text=model.ORD_LHqty.ToString();
		this.lblORD_Sendqty.Text=model.ORD_Sendqty.ToString();
		this.lblORD_SHqty.Text=model.ORD_SHqty.ToString();
		this.lblORD_HZqty.Text=model.ORD_HZqty.ToString();
		this.lblORD_THqty.Text=model.ORD_THqty.ToString();
		this.lblORD_Acceptqty.Text=model.ORD_Acceptqty.ToString();
		this.lblORD_SHDH.Text=model.ORD_SHDH;
		this.lblORD_TL.Text=model.ORD_TL;
		this.lblPOSITION.Text=model.POSITION.ToString();
		this.lblBARCODE.Text=model.BARCODE;
		this.lblREMARK.Text=model.REMARK;

	}


    }
}
