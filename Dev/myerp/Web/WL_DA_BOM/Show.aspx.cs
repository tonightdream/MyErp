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
namespace MyERP.Web.WL_DA_BOM
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
		MyERP.BLL.WL_DA_BOM bll=new MyERP.BLL.WL_DA_BOM();
		MyERP.Model.WL_DA_BOM model=bll.GetModel();
		this.lblSEQUENCE.Text=model.SEQUENCE.ToString();
		this.lblITEM_INTERNAL_CODE.Text=model.ITEM_INTERNAL_CODE;
		this.lblITEM_CODE.Text=model.ITEM_CODE;
		this.lblITEM_NAME.Text=model.ITEM_NAME;
		this.lblITEM_COLOR.Text=model.ITEM_COLOR;
		this.lblPARENT_ITEM_CODE.Text=model.PARENT_ITEM_CODE;
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
		this.lblMIN_QTY.Text=model.MIN_QTY.ToString();
		this.lblMAX_QTY.Text=model.MAX_QTY.ToString();
		this.lblPOSITION.Text=model.POSITION;
		this.lblIMAGE.Text=model.IMAGE.ToString();
		this.lblIMAGE_NAME.Text=model.IMAGE_NAME;
		this.lblQuantity.Text=model.Quantity.ToString();
		this.lblBARCODE.Text=model.BARCODE;
		this.lblCREATE_NAME.Text=model.CREATE_NAME;
		this.lblCREATE_DATE.Text=model.CREATE_DATE.ToString();
		this.lblUPDATE_NAME.Text=model.UPDATE_NAME;
		this.lblUPDATE_DATE.Text=model.UPDATE_DATE.ToString();
		this.lblREMARK.Text=model.REMARK;

	}


    }
}
