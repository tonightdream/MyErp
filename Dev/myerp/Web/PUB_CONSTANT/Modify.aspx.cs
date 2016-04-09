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
namespace MyERP.Web.PUB_CONSTANT
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
		MyERP.BLL.PUB_CONSTANT bll=new MyERP.BLL.PUB_CONSTANT();
		MyERP.Model.PUB_CONSTANT model=bll.GetModel();
		this.txtCOMPANY_CODE.Text=model.COMPANY_CODE;
		this.txtCONST_TYPE.Text=model.CONST_TYPE;
		this.txtCONST_CODE.Text=model.CONST_CODE;
		this.txtCREATE_NAME.Text=model.CREATE_NAME;
		this.txtCREATE_DATE.Text=model.CREATE_DATE;
		this.txtUPDATE_NAME.Text=model.UPDATE_NAME;
		this.txtUPDATE_DATE.Text=model.UPDATE_DATE;
		this.txtREMARK.Text=model.REMARK;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtCOMPANY_CODE.Text.Trim().Length==0)
			{
				strErr+="COMPANY_CODE不能为空！\\n";	
			}
			if(this.txtCONST_TYPE.Text.Trim().Length==0)
			{
				strErr+="CONST_TYPE不能为空！\\n";	
			}
			if(this.txtCONST_CODE.Text.Trim().Length==0)
			{
				strErr+="CONST_CODE不能为空！\\n";	
			}
			if(this.txtCREATE_NAME.Text.Trim().Length==0)
			{
				strErr+="CREATE_NAME不能为空！\\n";	
			}
			if(this.txtCREATE_DATE.Text.Trim().Length==0)
			{
				strErr+="CREATE_DATE不能为空！\\n";	
			}
			if(this.txtUPDATE_NAME.Text.Trim().Length==0)
			{
				strErr+="UPDATE_NAME不能为空！\\n";	
			}
			if(this.txtUPDATE_DATE.Text.Trim().Length==0)
			{
				strErr+="UPDATE_DATE不能为空！\\n";	
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
			string CONST_TYPE=this.txtCONST_TYPE.Text;
			string CONST_CODE=this.txtCONST_CODE.Text;
			string CREATE_NAME=this.txtCREATE_NAME.Text;
			string CREATE_DATE=this.txtCREATE_DATE.Text;
			string UPDATE_NAME=this.txtUPDATE_NAME.Text;
			string UPDATE_DATE=this.txtUPDATE_DATE.Text;
			string REMARK=this.txtREMARK.Text;


			MyERP.Model.PUB_CONSTANT model=new MyERP.Model.PUB_CONSTANT();
			model.COMPANY_CODE=COMPANY_CODE;
			model.CONST_TYPE=CONST_TYPE;
			model.CONST_CODE=CONST_CODE;
			model.CREATE_NAME=CREATE_NAME;
			model.CREATE_DATE=CREATE_DATE;
			model.UPDATE_NAME=UPDATE_NAME;
			model.UPDATE_DATE=UPDATE_DATE;
			model.REMARK=REMARK;

			MyERP.BLL.PUB_CONSTANT bll=new MyERP.BLL.PUB_CONSTANT();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
