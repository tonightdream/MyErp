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
namespace MyERP.Web.STEEL_GG
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
					string INTERNAL_CODE= strid;
					ShowInfo(INTERNAL_CODE);
				}
			}
		}
		
	private void ShowInfo(string INTERNAL_CODE)
	{
		MyERP.BLL.STEEL_GG bll=new MyERP.BLL.STEEL_GG();
		MyERP.Model.STEEL_GG model=bll.GetModel(INTERNAL_CODE);
		this.lblINTERNAL_CODE.Text=model.INTERNAL_CODE;
		this.lblDEPARTMENT_CODE.Text=model.DEPARTMENT_CODE;
		this.lblDEPARTMENT_NAME.Text=model.DEPARTMENT_NAME;
		this.lblPARENT_DEPARTMENT_CODE.Text=model.PARENT_DEPARTMENT_CODE;
		this.lblITEM_INTERNAL_CODE.Text=model.ITEM_INTERNAL_CODE;
		this.lblITEM_CODE.Text=model.ITEM_CODE;
		this.lblITEM_NAME.Text=model.ITEM_NAME;
		this.lblSPECIFICATIONS.Text=model.SPECIFICATIONS;
		this.lblHD.Text=model.HD.ToString();
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
