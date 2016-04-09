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
namespace MyERP.Web.STEEL_GG_BOM
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
					int temID=(Convert.ToInt32(strid));
					ShowInfo(temID);
				}
			}
		}
		
	private void ShowInfo(int temID)
	{
		MyERP.BLL.STEEL_GG_BOM bll=new MyERP.BLL.STEEL_GG_BOM();
		MyERP.Model.STEEL_GG_BOM model=bll.GetModel(temID);
		this.lbltemID.Text=model.temID.ToString();
		this.lblINTERNAL_CODE.Text=model.INTERNAL_CODE;
		this.lblSEQUENCE.Text=model.SEQUENCE.ToString();
		this.lblITEM_INTERNAL_CODE.Text=model.ITEM_INTERNAL_CODE;
		this.lblITEM_CODE.Text=model.ITEM_CODE;
		this.lblITEM_NAME.Text=model.ITEM_NAME;
		this.lblSPECIFICATIONS.Text=model.SPECIFICATIONS;
		this.lblKD.Text=model.KD.ToString();
		this.lblQUANTITY.Text=model.QUANTITY.ToString();
		this.lblCREATE_NAME.Text=model.CREATE_NAME;
		this.lblCREATE_DATE.Text=model.CREATE_DATE.ToString();
		this.lblUPDATE_NAME.Text=model.UPDATE_NAME;
		this.lblUPDATE_DATE.Text=model.UPDATE_DATE.ToString();
		this.lblREMARK.Text=model.REMARK;

	}


    }
}
