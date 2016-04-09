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
namespace MyERP.Web.PUB_BAR_CODE
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
		MyERP.BLL.PUB_BAR_CODE bll=new MyERP.BLL.PUB_BAR_CODE();
		MyERP.Model.PUB_BAR_CODE model=bll.GetModel();
		this.lblCOMPANY_CODE.Text=model.COMPANY_CODE;
		this.lblITEM_CODE.Text=model.ITEM_CODE;
		this.lblBAR_CODE.Text=model.BAR_CODE;
		this.lblCOLOR_CODE.Text=model.COLOR_CODE;
		this.lblRULER_CODE.Text=model.RULER_CODE;
		this.lblLENGTH_CODE.Text=model.LENGTH_CODE;
		this.lblCREATE_NAME.Text=model.CREATE_NAME;
		this.lblCREATE_DATE.Text=model.CREATE_DATE;
		this.lblREMARK.Text=model.REMARK;

	}


    }
}
