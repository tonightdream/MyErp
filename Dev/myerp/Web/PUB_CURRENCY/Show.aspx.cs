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
namespace MyERP.Web.PUB_CURRENCY
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
		MyERP.BLL.PUB_CURRENCY bll=new MyERP.BLL.PUB_CURRENCY();
		MyERP.Model.PUB_CURRENCY model=bll.GetModel();
		this.lblCOMPANY_CODE.Text=model.COMPANY_CODE;
		this.lblCURRENCY_CODE.Text=model.CURRENCY_CODE;
		this.lblCURRENCY_NAME.Text=model.CURRENCY_NAME;
		this.lblEXCHANGE_RATE.Text=model.EXCHANGE_RATE.ToString();
		this.lblALLOW_USERED.Text=model.ALLOW_USERED;
		this.lblCREATE_NAME.Text=model.CREATE_NAME;
		this.lblCREATE_DATE.Text=model.CREATE_DATE.ToString();
		this.lblREMARK.Text=model.REMARK;

	}


    }
}
