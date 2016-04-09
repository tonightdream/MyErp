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
namespace MyERP.Web.SAL_RECEIPT_DETAIL
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
					int TempID=(Convert.ToInt32(strid));
					ShowInfo(TempID);
				}
			}
		}
		
	private void ShowInfo(int TempID)
	{
		MyERP.BLL.SAL_RECEIPT_DETAIL bll=new MyERP.BLL.SAL_RECEIPT_DETAIL();
		MyERP.Model.SAL_RECEIPT_DETAIL model=bll.GetModel(TempID);
		this.lblTempID.Text=model.TempID.ToString();
		this.lblBillNo.Text=model.BillNo;
		this.lblSEQUENCE.Text=model.SEQUENCE.ToString();
		this.lblITEM_INTERNAL_CODE.Text=model.ITEM_INTERNAL_CODE;
		this.lblITEM_CODE.Text=model.ITEM_CODE;
		this.lblITEM_NAME.Text=model.ITEM_NAME;
		this.lblPARENT_ITEM_CODE.Text=model.PARENT_ITEM_CODE;
		this.lblITEM_TYPE.Text=model.ITEM_TYPE;
		this.lblITEM_COLOR.Text=model.ITEM_COLOR;
		this.lblSPECIFICATIONS.Text=model.SPECIFICATIONS;
		this.lblMEASURE_UNIT.Text=model.MEASURE_UNIT;
		this.lblNET_PRICE.Text=model.NET_PRICE.ToString();
		this.lblPRICE.Text=model.PRICE.ToString();
		this.lblACTUAL_QTY.Text=model.ACTUAL_QTY.ToString();
		this.lblQUANTITY.Text=model.QUANTITY.ToString();
		this.lblYKQUANTITY.Text=model.YKQUANTITY.ToString();
		this.lblPAYAMOUNT.Text=model.PAYAMOUNT.ToString();
		this.lblNET_PAYAMOUNT.Text=model.NET_PAYAMOUNT.ToString();
		this.lblBARCODE.Text=model.BARCODE;
		this.lblREMARK.Text=model.REMARK;

	}


    }
}
