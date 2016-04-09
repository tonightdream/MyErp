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
namespace MyERP.Web.PUB_CONSTANT
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
		MyERP.BLL.PUB_CONSTANT bll=new MyERP.BLL.PUB_CONSTANT();
		MyERP.Model.PUB_CONSTANT model=bll.GetModel();
		this.lblCOMPANY_CODE.Text=model.COMPANY_CODE;
		this.lblCONST_TYPE.Text=model.CONST_TYPE;
		this.lblCONST_CODE.Text=model.CONST_CODE;
		this.lblCREATE_NAME.Text=model.CREATE_NAME;
		this.lblCREATE_DATE.Text=model.CREATE_DATE;
		this.lblUPDATE_NAME.Text=model.UPDATE_NAME;
		this.lblUPDATE_DATE.Text=model.UPDATE_DATE;
		this.lblREMARK.Text=model.REMARK;

	}


    }
}
