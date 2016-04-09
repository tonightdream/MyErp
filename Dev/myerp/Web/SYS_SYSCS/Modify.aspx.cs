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
namespace MyERP.Web.SYS_SYSCS
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
		MyERP.BLL.SYS_SYSCS bll=new MyERP.BLL.SYS_SYSCS();
		MyERP.Model.SYS_SYSCS model=bll.GetModel();
		this.txtCOMPANY_CODE.Text=model.COMPANY_CODE;
		this.txtCOMPANY_NAME.Text=model.COMPANY_NAME;
		this.txtFullName.Text=model.FullName;
		this.txtAddress.Text=model.Address;
		this.txtPhone.Text=model.Phone;
		this.txtEmail.Text=model.Email;
		this.txtFax.Text=model.Fax;
		this.txtSHDCNT.Text=model.SHDCNT.ToString();
		this.txtITEM_CODE_LENGTH.Text=model.ITEM_CODE_LENGTH;
		this.chkBillasstock.Checked=model.Billasstock;
		this.txtMAYLH.Text=model.MAYLH;
		this.txtServiceTelphone.Text=model.ServiceTelphone;
		this.txtCREATE_NAME.Text=model.CREATE_NAME;
		this.txtCREATE_DATE.Text=model.CREATE_DATE;
		this.txtREMARK.Text=model.REMARK;

	}

		public void btnSave_Click(object sender, EventArgs e)
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
			if(this.txtFullName.Text.Trim().Length==0)
			{
				strErr+="FullName不能为空！\\n";	
			}
			if(this.txtAddress.Text.Trim().Length==0)
			{
				strErr+="Address不能为空！\\n";	
			}
			if(this.txtPhone.Text.Trim().Length==0)
			{
				strErr+="Phone不能为空！\\n";	
			}
			if(this.txtEmail.Text.Trim().Length==0)
			{
				strErr+="Email不能为空！\\n";	
			}
			if(this.txtFax.Text.Trim().Length==0)
			{
				strErr+="Fax不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtSHDCNT.Text))
			{
				strErr+="SHDCNT格式错误！\\n";	
			}
			if(this.txtITEM_CODE_LENGTH.Text.Trim().Length==0)
			{
				strErr+="ITEM_CODE_LENGTH不能为空！\\n";	
			}
			if(this.txtMAYLH.Text.Trim().Length==0)
			{
				strErr+="MAYLH不能为空！\\n";	
			}
			if(this.txtServiceTelphone.Text.Trim().Length==0)
			{
				strErr+="ServiceTelphone不能为空！\\n";	
			}
			if(this.txtCREATE_NAME.Text.Trim().Length==0)
			{
				strErr+="CREATE_NAME不能为空！\\n";	
			}
			if(this.txtCREATE_DATE.Text.Trim().Length==0)
			{
				strErr+="CREATE_DATE不能为空！\\n";	
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
			string FullName=this.txtFullName.Text;
			string Address=this.txtAddress.Text;
			string Phone=this.txtPhone.Text;
			string Email=this.txtEmail.Text;
			string Fax=this.txtFax.Text;
			int SHDCNT=int.Parse(this.txtSHDCNT.Text);
			string ITEM_CODE_LENGTH=this.txtITEM_CODE_LENGTH.Text;
			bool Billasstock=this.chkBillasstock.Checked;
			string MAYLH=this.txtMAYLH.Text;
			string ServiceTelphone=this.txtServiceTelphone.Text;
			string CREATE_NAME=this.txtCREATE_NAME.Text;
			string CREATE_DATE=this.txtCREATE_DATE.Text;
			string REMARK=this.txtREMARK.Text;


			MyERP.Model.SYS_SYSCS model=new MyERP.Model.SYS_SYSCS();
			model.COMPANY_CODE=COMPANY_CODE;
			model.COMPANY_NAME=COMPANY_NAME;
			model.FullName=FullName;
			model.Address=Address;
			model.Phone=Phone;
			model.Email=Email;
			model.Fax=Fax;
			model.SHDCNT=SHDCNT;
			model.ITEM_CODE_LENGTH=ITEM_CODE_LENGTH;
			model.Billasstock=Billasstock;
			model.MAYLH=MAYLH;
			model.ServiceTelphone=ServiceTelphone;
			model.CREATE_NAME=CREATE_NAME;
			model.CREATE_DATE=CREATE_DATE;
			model.REMARK=REMARK;

			MyERP.BLL.SYS_SYSCS bll=new MyERP.BLL.SYS_SYSCS();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
