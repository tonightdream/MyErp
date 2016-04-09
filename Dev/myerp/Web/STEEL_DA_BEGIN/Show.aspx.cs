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
namespace MyERP.Web.STEEL_DA_BEGIN
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
		MyERP.BLL.STEEL_DA_BEGIN bll=new MyERP.BLL.STEEL_DA_BEGIN();
		MyERP.Model.STEEL_DA_BEGIN model=bll.GetModel();
		this.lblCOMPANY_CODE.Text=model.COMPANY_CODE;
		this.lblCOMPANY_NAME.Text=model.COMPANY_NAME;
		this.lblITEM_INTERNAL_CODE.Text=model.ITEM_INTERNAL_CODE;
		this.lblITEM_CODE.Text=model.ITEM_CODE;
		this.lblITEM_NAME.Text=model.ITEM_NAME;
		this.lblPARENT_ITEM_CODE.Text=model.PARENT_ITEM_CODE;
		this.lblACTUAL_QTY.Text=model.ACTUAL_QTY.ToString();
		this.lblCREATE_DATE.Text=model.CREATE_DATE.ToString();

	}


    }
}
