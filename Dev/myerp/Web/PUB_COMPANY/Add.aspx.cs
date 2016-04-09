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
namespace MyERP.Web.PUB_COMPANY
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtCOMPANY_CODE.Text.Trim().Length==0)
			{
				strErr+="COMPANY_CODE不能为空！\\n";	
			}
			if(this.txtCOMPANY_NAME.Text.Trim().Length==0)
			{
				strErr+="COMPANY_NAME不能为空！\\n";	
			}
			if(this.txtCOMPANY_FULLNAME.Text.Trim().Length==0)
			{
				strErr+="COMPANY_FULLNAME不能为空！\\n";	
			}
			if(this.txtPARENT_COMPANY_CODE.Text.Trim().Length==0)
			{
				strErr+="PARENT_COMPANY_CODE不能为空！\\n";	
			}
			if(this.txtMANAGER.Text.Trim().Length==0)
			{
				strErr+="MANAGER不能为空！\\n";	
			}
			if(this.txtADDRESS.Text.Trim().Length==0)
			{
				strErr+="ADDRESS不能为空！\\n";	
			}
			if(this.txtTELPHONE.Text.Trim().Length==0)
			{
				strErr+="TELPHONE不能为空！\\n";	
			}
			if(this.txtZIP.Text.Trim().Length==0)
			{
				strErr+="ZIP不能为空！\\n";	
			}
			if(this.txtEMAIL.Text.Trim().Length==0)
			{
				strErr+="EMAIL不能为空！\\n";	
			}
			if(this.txtHTTP.Text.Trim().Length==0)
			{
				strErr+="HTTP不能为空！\\n";	
			}
			if(this.txtLICENSE.Text.Trim().Length==0)
			{
				strErr+="LICENSE不能为空！\\n";	
			}
			if(this.txtREGISTER_BANK.Text.Trim().Length==0)
			{
				strErr+="REGISTER_BANK不能为空！\\n";	
			}
			if(this.txtBANK_ACCOUNT.Text.Trim().Length==0)
			{
				strErr+="BANK_ACCOUNT不能为空！\\n";	
			}
			if(this.txtALLOW_USED.Text.Trim().Length==0)
			{
				strErr+="ALLOW_USED不能为空！\\n";	
			}
			if(this.txtREMARK.Text.Trim().Length==0)
			{
				strErr+="REMARK不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string COMPANY_CODE=this.txtCOMPANY_CODE.Text;
			string COMPANY_NAME=this.txtCOMPANY_NAME.Text;
			string COMPANY_FULLNAME=this.txtCOMPANY_FULLNAME.Text;
			string PARENT_COMPANY_CODE=this.txtPARENT_COMPANY_CODE.Text;
			string MANAGER=this.txtMANAGER.Text;
			string ADDRESS=this.txtADDRESS.Text;
			string TELPHONE=this.txtTELPHONE.Text;
			string ZIP=this.txtZIP.Text;
			string EMAIL=this.txtEMAIL.Text;
			string HTTP=this.txtHTTP.Text;
			string LICENSE=this.txtLICENSE.Text;
			string REGISTER_BANK=this.txtREGISTER_BANK.Text;
			string BANK_ACCOUNT=this.txtBANK_ACCOUNT.Text;
			string ALLOW_USED=this.txtALLOW_USED.Text;
			string REMARK=this.txtREMARK.Text;

			MyERP.Model.PUB_COMPANY model=new MyERP.Model.PUB_COMPANY();
			model.COMPANY_CODE=COMPANY_CODE;
			model.COMPANY_NAME=COMPANY_NAME;
			model.COMPANY_FULLNAME=COMPANY_FULLNAME;
			model.PARENT_COMPANY_CODE=PARENT_COMPANY_CODE;
			model.MANAGER=MANAGER;
			model.ADDRESS=ADDRESS;
			model.TELPHONE=TELPHONE;
			model.ZIP=ZIP;
			model.EMAIL=EMAIL;
			model.HTTP=HTTP;
			model.LICENSE=LICENSE;
			model.REGISTER_BANK=REGISTER_BANK;
			model.BANK_ACCOUNT=BANK_ACCOUNT;
			model.ALLOW_USED=ALLOW_USED;
			model.REMARK=REMARK;

			MyERP.BLL.PUB_COMPANY bll=new MyERP.BLL.PUB_COMPANY();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
