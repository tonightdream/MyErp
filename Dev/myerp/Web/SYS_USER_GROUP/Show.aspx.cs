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
namespace MyERP.Web.SYS_USER_GROUP
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
		MyERP.BLL.SYS_USER_GROUP bll=new MyERP.BLL.SYS_USER_GROUP();
		MyERP.Model.SYS_USER_GROUP model=bll.GetModel();
		this.lblCompanyCode.Text=model.CompanyCode;
		this.lblUserGroupNo.Text=model.UserGroupNo;
		this.lblUserGroupName.Text=model.UserGroupName;
		this.lblDescription.Text=model.Description;
		this.lblAllowUsed.Text=model.AllowUsed;

	}


    }
}
