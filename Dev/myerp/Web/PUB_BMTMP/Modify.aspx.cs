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
namespace MyERP.Web.PUB_BMTMP
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
		MyERP.BLL.PUB_BMTMP bll=new MyERP.BLL.PUB_BMTMP();
		MyERP.Model.PUB_BMTMP model=bll.GetModel();
		this.txtBMCODE.Text=model.BMCODE;
		this.txtBMNAME.Text=model.BMNAME;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtBMCODE.Text.Trim().Length==0)
			{
				strErr+="BMCODE不能为空！\\n";	
			}
			if(this.txtBMNAME.Text.Trim().Length==0)
			{
				strErr+="BMNAME不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string BMCODE=this.txtBMCODE.Text;
			string BMNAME=this.txtBMNAME.Text;


			MyERP.Model.PUB_BMTMP model=new MyERP.Model.PUB_BMTMP();
			model.BMCODE=BMCODE;
			model.BMNAME=BMNAME;

			MyERP.BLL.PUB_BMTMP bll=new MyERP.BLL.PUB_BMTMP();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
