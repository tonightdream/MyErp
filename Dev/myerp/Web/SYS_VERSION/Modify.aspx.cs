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
namespace MyERP.Web.SYS_VERSION
{
    public partial class Modify : Page
    {       

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
		MyERP.BLL.SYS_VERSION bll=new MyERP.BLL.SYS_VERSION();
		MyERP.Model.SYS_VERSION model=bll.GetModel();
		this.txtVERSION.Text=model.VERSION;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtVERSION.Text.Trim().Length==0)
			{
				strErr+="VERSION不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string VERSION=this.txtVERSION.Text;


			MyERP.Model.SYS_VERSION model=new MyERP.Model.SYS_VERSION();
			model.VERSION=VERSION;

			MyERP.BLL.SYS_VERSION bll=new MyERP.BLL.SYS_VERSION();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
