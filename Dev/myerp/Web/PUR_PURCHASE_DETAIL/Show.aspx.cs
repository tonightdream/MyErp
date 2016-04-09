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
namespace MyERP.Web.PUR_PURCHASE_DETAIL
{
    public partial class Show : Page
    {        
        		public string strid=""; 
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				#warning 代码生成提示：显示页面,请检查确认该语句是否正确
				ShowInfo();
			}
		}
		
	private void ShowInfo()
	{
		MyERP.BLL.PUR_PURCHASE_DETAIL bll=new MyERP.BLL.PUR_PURCHASE_DETAIL();
		MyERP.Model.PUR_PURCHASE_DETAIL model=bll.GetModel();
		this.lblDETAILID.Text=model.DETAILID;
		this.lblMASTERID.Text=model.MASTERID;
		this.lblBILLNO.Text=model.BILLNO;
		this.lblSequence.Text=model.Sequence.ToString();
		this.lblSUPPLY_CODE.Text=model.SUPPLY_CODE;
		this.lblSUPPLY_NAME.Text=model.SUPPLY_NAME;
		this.lblITEM_INTERNAL_CODE.Text=model.ITEM_INTERNAL_CODE;
		this.lblITEM_CODE.Text=model.ITEM_CODE;
		this.lblITEM_CODE_old.Text=model.ITEM_CODE_old;
		this.lblSPECIFICATIONS.Text=model.SPECIFICATIONS;
		this.lblPARENT_ITEM_CODE.Text=model.PARENT_ITEM_CODE.ToString();
		this.lblITEM_CD.Text=model.ITEM_CD.ToString();
		this.lblITEM_KD.Text=model.ITEM_KD.ToString();
		this.lblITEM_GD.Text=model.ITEM_GD.ToString();
		this.lblMEASURE_UNIT.Text=model.MEASURE_UNIT;
		this.lblITEM_NAME.Text=model.ITEM_NAME;
		this.lblITEM_TYPE.Text=model.ITEM_TYPE;
		this.lblCOLOR.Text=model.COLOR;
		this.lblIMAGE.Text=model.IMAGE;
		this.lblDWMJ.Text=model.DWMJ.ToString();
		this.lblDESCRIPTION.Text=model.DESCRIPTION;
		this.lblBARCODE.Text=model.BARCODE;
		this.lblNET_PRICE.Text=model.NET_PRICE.ToString();
		this.lblPRICE.Text=model.PRICE.ToString();
		this.lblQuantity.Text=model.Quantity.ToString();
		this.lblPAYAMOUNT.Text=model.PAYAMOUNT.ToString();
		this.lblTAX_RATE.Text=model.TAX_RATE.ToString();
		this.lblORD_CGqty.Text=model.ORD_CGqty.ToString();
		this.lblORD_CLqty.Text=model.ORD_CLqty.ToString();
		this.lblORD_PCqty.Text=model.ORD_PCqty.ToString();
		this.lblORD_WGqty.Text=model.ORD_WGqty.ToString();
		this.lblORD_TCqty.Text=model.ORD_TCqty.ToString();
		this.lblORD_WGZL.Text=model.ORD_WGZL.ToString();
		this.lblORD_FPqty.Text=model.ORD_FPqty.ToString();
		this.lblORD_Sendqty.Text=model.ORD_Sendqty.ToString();
		this.lblORD_SHqty.Text=model.ORD_SHqty.ToString();
		this.lblORD_LHqty.Text=model.ORD_LHqty.ToString();
		this.lblORD_HZqty.Text=model.ORD_HZqty.ToString();
		this.lblORD_THqty.Text=model.ORD_THqty.ToString();
		this.lblORD_Acceptqty.Text=model.ORD_Acceptqty.ToString();
		this.lblORD_SHDH.Text=model.ORD_SHDH;
		this.lblREMARK.Text=model.REMARK;

	}


    }
}
