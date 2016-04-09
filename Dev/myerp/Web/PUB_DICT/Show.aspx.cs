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
namespace MyERP.Web.PUB_DICT
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
					string DICT_CODE= strid;
					ShowInfo(DICT_CODE);
				}
			}
		}
		
	private void ShowInfo(string DICT_CODE)
	{
		MyERP.BLL.PUB_DICT bll=new MyERP.BLL.PUB_DICT();
		MyERP.Model.PUB_DICT model=bll.GetModel(DICT_CODE);
		this.lblDICT_CODE.Text=model.DICT_CODE;
		this.lblDICT_NAME.Text=model.DICT_NAME;
		this.lblPARENT_DICT_CODE.Text=model.PARENT_DICT_CODE;
		this.lblCREATE_NAME.Text=model.CREATE_NAME;
		this.lblCREATE_DATE.Text=model.CREATE_DATE.ToString();
		this.lblUPDATE_NAME.Text=model.UPDATE_NAME;
		this.lblUPDATE_DATE.Text=model.UPDATE_DATE.ToString();
		this.lblREMARK.Text=model.REMARK;

	}


    }
}
