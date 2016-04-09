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
namespace MyERP.Web.SYS_REGISTER
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					string COMPANY_CODE= Request.Params["id"];
					ShowInfo(COMPANY_CODE);
				}
			}
		}
			
	private void ShowInfo(string COMPANY_CODE)
	{
		MyERP.BLL.SYS_REGISTER bll=new MyERP.BLL.SYS_REGISTER();
		MyERP.Model.SYS_REGISTER model=bll.GetModel(COMPANY_CODE);
		this.lblCOMPANY_CODE.Text=model.COMPANY_CODE;
		this.txtCOMPANY_NAME.Text=model.COMPANY_NAME;
		this.txtPARENT_COMPANY_CODE.Text=model.PARENT_COMPANY_CODE;
		this.txtFULL_NAME.Text=model.FULL_NAME;
		this.txtADRESS.Text=model.ADRESS;
		this.txtSERVICE_PHONE.Text=model.SERVICE_PHONE;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtCOMPANY_NAME.Text.Trim().Length==0)
			{
				strErr+="COMPANY_NAME不能为空！\\n";	
			}
			if(this.txtPARENT_COMPANY_CODE.Text.Trim().Length==0)
			{
				strErr+="PARENT_COMPANY_CODE不能为空！\\n";	
			}
			if(this.txtFULL_NAME.Text.Trim().Length==0)
			{
				strErr+="FULL_NAME不能为空！\\n";	
			}
			if(this.txtADRESS.Text.Trim().Length==0)
			{
				strErr+="ADRESS不能为空！\\n";	
			}
			if(this.txtSERVICE_PHONE.Text.Trim().Length==0)
			{
				strErr+="SERVICE_PHONE不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string COMPANY_CODE=this.lblCOMPANY_CODE.Text;
			string COMPANY_NAME=this.txtCOMPANY_NAME.Text;
			string PARENT_COMPANY_CODE=this.txtPARENT_COMPANY_CODE.Text;
			string FULL_NAME=this.txtFULL_NAME.Text;
			string ADRESS=this.txtADRESS.Text;
			string SERVICE_PHONE=this.txtSERVICE_PHONE.Text;


			MyERP.Model.SYS_REGISTER model=new MyERP.Model.SYS_REGISTER();
			model.COMPANY_CODE=COMPANY_CODE;
			model.COMPANY_NAME=COMPANY_NAME;
			model.PARENT_COMPANY_CODE=PARENT_COMPANY_CODE;
			model.FULL_NAME=FULL_NAME;
			model.ADRESS=ADRESS;
			model.SERVICE_PHONE=SERVICE_PHONE;

			MyERP.BLL.SYS_REGISTER bll=new MyERP.BLL.SYS_REGISTER();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
