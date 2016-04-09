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
namespace MyERP.Web.ORDER_CG_DETAIL
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
		MyERP.BLL.ORDER_CG_DETAIL bll=new MyERP.BLL.ORDER_CG_DETAIL();
		MyERP.Model.ORDER_CG_DETAIL model=bll.GetModel();
		this.lblSEQUENCE.Text=model.SEQUENCE.ToString();
		this.lblMASTERID.Text=model.MASTERID;
		this.lblDETAILID.Text=model.DETAILID;
		this.lblBILLNO.Text=model.BILLNO;
		this.lblITEM_INTERNAL_CODE.Text=model.ITEM_INTERNAL_CODE;
		this.lblITEM_CODE.Text=model.ITEM_CODE;
		this.lblITEM_NAME.Text=model.ITEM_NAME;
		this.lblITEM_COLOR.Text=model.ITEM_COLOR;
		this.lblITEM_TYPE.Text=model.ITEM_TYPE;
		this.lblSPECIFICATIONS.Text=model.SPECIFICATIONS;
		this.lblMEASURE_UNIT.Text=model.MEASURE_UNIT;
		this.lblITEM_CZ.Text=model.ITEM_CZ;
		this.lblITEM_LH.Text=model.ITEM_LH.ToString();
		this.lblITEM_LK.Text=model.ITEM_LK.ToString();
		this.lblITEM_BJ.Text=model.ITEM_BJ.ToString();
		this.lblITEM_JZ.Text=model.ITEM_JZ.ToString();
		this.lblITEM_HZ.Text=model.ITEM_HZ.ToString();
		this.lblITEM_rate.Text=model.ITEM_rate;
		this.lblITEM_GYLC.Text=model.ITEM_GYLC;
		this.lblNET_PRICE.Text=model.NET_PRICE.ToString();
		this.lblPRICE.Text=model.PRICE.ToString();
		this.lblQuantity.Text=model.Quantity.ToString();
		this.lbltotal_quantity.Text=model.total_quantity.ToString();
		this.lblORD_TL.Text=model.ORD_TL;
		this.lblBARCODE.Text=model.BARCODE;
		this.lblREMARK.Text=model.REMARK;

	}


    }
}
