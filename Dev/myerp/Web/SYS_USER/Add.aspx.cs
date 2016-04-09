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
namespace MyERP.Web.SYS_USER
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtUSER_CODE.Text.Trim().Length==0)
			{
				strErr+="USER_CODE不能为空！\\n";	
			}
			if(this.txtCOMPANY_CODE.Text.Trim().Length==0)
			{
				strErr+="COMPANY_CODE不能为空！\\n";	
			}
			if(this.txtCOMPANY_NAME.Text.Trim().Length==0)
			{
				strErr+="COMPANY_NAME不能为空！\\n";	
			}
			if(this.txtUSER_NAME.Text.Trim().Length==0)
			{
				strErr+="USER_NAME不能为空！\\n";	
			}
			if(this.txtSTOCK_CODE.Text.Trim().Length==0)
			{
				strErr+="STOCK_CODE不能为空！\\n";	
			}
			if(this.txtSTOCK_NAME.Text.Trim().Length==0)
			{
				strErr+="STOCK_NAME不能为空！\\n";	
			}
			if(this.txtDEPARTMENT_CODE.Text.Trim().Length==0)
			{
				strErr+="DEPARTMENT_CODE不能为空！\\n";	
			}
			if(this.txtDEPARTMENT_NAME.Text.Trim().Length==0)
			{
				strErr+="DEPARTMENT_NAME不能为空！\\n";	
			}
			if(this.txtdepartment.Text.Trim().Length==0)
			{
				strErr+="department不能为空！\\n";	
			}
			if(this.txtPARENT_DEPARTMENT_CODE.Text.Trim().Length==0)
			{
				strErr+="PARENT_DEPARTMENT_CODE不能为空！\\n";	
			}
			if(this.txtPASSWORD.Text.Trim().Length==0)
			{
				strErr+="PASSWORD不能为空！\\n";	
			}
			if(this.txtDescription.Text.Trim().Length==0)
			{
				strErr+="Description不能为空！\\n";	
			}
			if(this.txtEmployeeCode.Text.Trim().Length==0)
			{
				strErr+="EmployeeCode不能为空！\\n";	
			}
			if(this.txtAllowUsed.Text.Trim().Length==0)
			{
				strErr+="AllowUsed不能为空！\\n";	
			}
			if(this.txtisLicenceAudit.Text.Trim().Length==0)
			{
				strErr+="isLicenceAudit不能为空！\\n";	
			}
			if(this.txtUserType.Text.Trim().Length==0)
			{
				strErr+="UserType不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtAuditDate.Text))
			{
				strErr+="AuditDate格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string USER_CODE=this.txtUSER_CODE.Text;
			string COMPANY_CODE=this.txtCOMPANY_CODE.Text;
			string COMPANY_NAME=this.txtCOMPANY_NAME.Text;
			string USER_NAME=this.txtUSER_NAME.Text;
			string STOCK_CODE=this.txtSTOCK_CODE.Text;
			string STOCK_NAME=this.txtSTOCK_NAME.Text;
			string DEPARTMENT_CODE=this.txtDEPARTMENT_CODE.Text;
			string DEPARTMENT_NAME=this.txtDEPARTMENT_NAME.Text;
			string department=this.txtdepartment.Text;
			string PARENT_DEPARTMENT_CODE=this.txtPARENT_DEPARTMENT_CODE.Text;
			bool PPRICE_SHOW=this.chkPPRICE_SHOW.Checked;
			string PASSWORD=this.txtPASSWORD.Text;
			string Description=this.txtDescription.Text;
			string EmployeeCode=this.txtEmployeeCode.Text;
			string AllowUsed=this.txtAllowUsed.Text;
			string isLicenceAudit=this.txtisLicenceAudit.Text;
			string UserType=this.txtUserType.Text;
			byte[] LastEdit= new UnicodeEncoding().GetBytes(this.txtLastEdit.Text);
			DateTime AuditDate=DateTime.Parse(this.txtAuditDate.Text);

			MyERP.Model.SYS_USER model=new MyERP.Model.SYS_USER();
			model.USER_CODE=USER_CODE;
			model.COMPANY_CODE=COMPANY_CODE;
			model.COMPANY_NAME=COMPANY_NAME;
			model.USER_NAME=USER_NAME;
			model.STOCK_CODE=STOCK_CODE;
			model.STOCK_NAME=STOCK_NAME;
			model.DEPARTMENT_CODE=DEPARTMENT_CODE;
			model.DEPARTMENT_NAME=DEPARTMENT_NAME;
			model.department=department;
			model.PARENT_DEPARTMENT_CODE=PARENT_DEPARTMENT_CODE;
			model.PPRICE_SHOW=PPRICE_SHOW;
			model.PASSWORD=PASSWORD;
			model.Description=Description;
			model.EmployeeCode=EmployeeCode;
			model.AllowUsed=AllowUsed;
			model.isLicenceAudit=isLicenceAudit;
			model.UserType=UserType;
			model.LastEdit=LastEdit;
			model.AuditDate=AuditDate;

			MyERP.BLL.SYS_USER bll=new MyERP.BLL.SYS_USER();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
