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
namespace MyERP.Web.CL_ITEM_STOCK_DETAIL_BEGIN_RECORD
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
		MyERP.BLL.CL_ITEM_STOCK_DETAIL_BEGIN_RECORD bll=new MyERP.BLL.CL_ITEM_STOCK_DETAIL_BEGIN_RECORD();
		MyERP.Model.CL_ITEM_STOCK_DETAIL_BEGIN_RECORD model=bll.GetModel();
		this.lblCOMPANY_CODE.Text=model.COMPANY_CODE;
		this.lblCOMPANY_NAME.Text=model.COMPANY_NAME;
		this.lblCREATE_DATE.Text=model.CREATE_DATE.ToString();
		this.lblCREATE_NAME.Text=model.CREATE_NAME;

	}


    }
}
