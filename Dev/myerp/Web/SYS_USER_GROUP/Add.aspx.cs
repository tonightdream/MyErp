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
using Maticsoft.Common;
using LTP.Accounts.Bus;
namespace MyERP.Web.SYS_USER_GROUP
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtCompanyCode.Text.Trim().Length==0)
			{
				strErr+="CompanyCode不能为空！\\n";	
			}
			if(this.txtUserGroupNo.Text.Trim().Length==0)
			{
				strErr+="UserGroupNo不能为空！\\n";	
			}
			if(this.txtUserGroupName.Text.Trim().Length==0)
			{
				strErr+="UserGroupName不能为空！\\n";	
			}
			if(this.txtDescription.Text.Trim().Length==0)
			{
				strErr+="Description不能为空！\\n";	
			}
			if(this.txtAllowUsed.Text.Trim().Length==0)
			{
				strErr+="AllowUsed不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string CompanyCode=this.txtCompanyCode.Text;
			string UserGroupNo=this.txtUserGroupNo.Text;
			string UserGroupName=this.txtUserGroupName.Text;
			string Description=this.txtDescription.Text;
			string AllowUsed=this.txtAllowUsed.Text;

			MyERP.Model.SYS_USER_GROUP model=new MyERP.Model.SYS_USER_GROUP();
			model.CompanyCode=CompanyCode;
			model.UserGroupNo=UserGroupNo;
			model.UserGroupName=UserGroupName;
			model.Description=Description;
			model.AllowUsed=AllowUsed;

			MyERP.BLL.SYS_USER_GROUP bll=new MyERP.BLL.SYS_USER_GROUP();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
