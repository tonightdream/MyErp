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
namespace MyERP.Web.PUB_SUPPLY
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtINTERNAL_CODE.Text.Trim().Length==0)
			{
				strErr+="INTERNAL_CODE不能为空！\\n";	
			}
			if(this.txtSUPPLY_CODE.Text.Trim().Length==0)
			{
				strErr+="SUPPLY_CODE不能为空！\\n";	
			}
			if(this.txtSUPPLY_NAME.Text.Trim().Length==0)
			{
				strErr+="SUPPLY_NAME不能为空！\\n";	
			}
			if(this.txtPARENT_SUPPLY_CODE.Text.Trim().Length==0)
			{
				strErr+="PARENT_SUPPLY_CODE不能为空！\\n";	
			}
			if(this.txtTypeCode.Text.Trim().Length==0)
			{
				strErr+="TypeCode不能为空！\\n";	
			}
			if(this.txtTypeName.Text.Trim().Length==0)
			{
				strErr+="TypeName不能为空！\\n";	
			}
			if(this.txtTELPHONE.Text.Trim().Length==0)
			{
				strErr+="TELPHONE不能为空！\\n";	
			}
			if(this.txtTELPHONE1.Text.Trim().Length==0)
			{
				strErr+="TELPHONE1不能为空！\\n";	
			}
			if(this.txtFAX.Text.Trim().Length==0)
			{
				strErr+="FAX不能为空！\\n";	
			}
			if(this.txtEMAIL.Text.Trim().Length==0)
			{
				strErr+="EMAIL不能为空！\\n";	
			}
			if(this.txtFULLNAME.Text.Trim().Length==0)
			{
				strErr+="FULLNAME不能为空！\\n";	
			}
			if(this.txtADDRESS.Text.Trim().Length==0)
			{
				strErr+="ADDRESS不能为空！\\n";	
			}
			if(this.txtEASYCODE.Text.Trim().Length==0)
			{
				strErr+="EASYCODE不能为空！\\n";	
			}
			if(this.txtContact_MAN.Text.Trim().Length==0)
			{
				strErr+="Contact_MAN不能为空！\\n";	
			}
			if(this.txtCREATE_NAME.Text.Trim().Length==0)
			{
				strErr+="CREATE_NAME不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtCREATE_DATE.Text))
			{
				strErr+="CREATE_DATE格式错误！\\n";	
			}
			if(this.txtUPDATE_NAME.Text.Trim().Length==0)
			{
				strErr+="UPDATE_NAME不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtUPDATE_DATE.Text))
			{
				strErr+="UPDATE_DATE格式错误！\\n";	
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
			string INTERNAL_CODE=this.txtINTERNAL_CODE.Text;
			string SUPPLY_CODE=this.txtSUPPLY_CODE.Text;
			string SUPPLY_NAME=this.txtSUPPLY_NAME.Text;
			string PARENT_SUPPLY_CODE=this.txtPARENT_SUPPLY_CODE.Text;
			string TypeCode=this.txtTypeCode.Text;
			string TypeName=this.txtTypeName.Text;
			string TELPHONE=this.txtTELPHONE.Text;
			string TELPHONE1=this.txtTELPHONE1.Text;
			string FAX=this.txtFAX.Text;
			string EMAIL=this.txtEMAIL.Text;
			string FULLNAME=this.txtFULLNAME.Text;
			string ADDRESS=this.txtADDRESS.Text;
			string EASYCODE=this.txtEASYCODE.Text;
			string Contact_MAN=this.txtContact_MAN.Text;
			string CREATE_NAME=this.txtCREATE_NAME.Text;
			DateTime CREATE_DATE=DateTime.Parse(this.txtCREATE_DATE.Text);
			string UPDATE_NAME=this.txtUPDATE_NAME.Text;
			DateTime UPDATE_DATE=DateTime.Parse(this.txtUPDATE_DATE.Text);
			bool ALLOW_used=this.chkALLOW_used.Checked;
			string REMARK=this.txtREMARK.Text;

			MyERP.Model.PUB_SUPPLY model=new MyERP.Model.PUB_SUPPLY();
			model.INTERNAL_CODE=INTERNAL_CODE;
			model.SUPPLY_CODE=SUPPLY_CODE;
			model.SUPPLY_NAME=SUPPLY_NAME;
			model.PARENT_SUPPLY_CODE=PARENT_SUPPLY_CODE;
			model.TypeCode=TypeCode;
			model.TypeName=TypeName;
			model.TELPHONE=TELPHONE;
			model.TELPHONE1=TELPHONE1;
			model.FAX=FAX;
			model.EMAIL=EMAIL;
			model.FULLNAME=FULLNAME;
			model.ADDRESS=ADDRESS;
			model.EASYCODE=EASYCODE;
			model.Contact_MAN=Contact_MAN;
			model.CREATE_NAME=CREATE_NAME;
			model.CREATE_DATE=CREATE_DATE;
			model.UPDATE_NAME=UPDATE_NAME;
			model.UPDATE_DATE=UPDATE_DATE;
			model.ALLOW_used=ALLOW_used;
			model.REMARK=REMARK;

			MyERP.BLL.PUB_SUPPLY bll=new MyERP.BLL.PUB_SUPPLY();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
