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
namespace MyERP.Web.PUB_CUSTOM
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtCUSTOM_CODE.Text.Trim().Length==0)
			{
				strErr+="CUSTOM_CODE不能为空！\\n";	
			}
			if(this.txtCUSTOM_NAME.Text.Trim().Length==0)
			{
				strErr+="CUSTOM_NAME不能为空！\\n";	
			}
			if(this.txtCREDIT_LIMIT.Text.Trim().Length==0)
			{
				strErr+="CREDIT_LIMIT不能为空！\\n";	
			}
			if(this.txtORG_CODE.Text.Trim().Length==0)
			{
				strErr+="ORG_CODE不能为空！\\n";	
			}
			if(this.txtPARENT_CUSTOM_CODE.Text.Trim().Length==0)
			{
				strErr+="PARENT_CUSTOM_CODE不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtCREDIT_AMOUNT.Text))
			{
				strErr+="CREDIT_AMOUNT格式错误！\\n";	
			}
			if(this.txtCUSTOM_TYPE_CODE.Text.Trim().Length==0)
			{
				strErr+="CUSTOM_TYPE_CODE不能为空！\\n";	
			}
			if(this.txtFULL_NAME.Text.Trim().Length==0)
			{
				strErr+="FULL_NAME不能为空！\\n";	
			}
			if(this.txtSALE_MAN.Text.Trim().Length==0)
			{
				strErr+="SALE_MAN不能为空！\\n";	
			}
			if(this.txtFAX.Text.Trim().Length==0)
			{
				strErr+="FAX不能为空！\\n";	
			}
			if(this.txtMANAGER.Text.Trim().Length==0)
			{
				strErr+="MANAGER不能为空！\\n";	
			}
			if(this.txtADDRESS.Text.Trim().Length==0)
			{
				strErr+="ADDRESS不能为空！\\n";	
			}
			if(this.txtTELPHIONE.Text.Trim().Length==0)
			{
				strErr+="TELPHIONE不能为空！\\n";	
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
			if(this.txtVIPCARD_CODE.Text.Trim().Length==0)
			{
				strErr+="VIPCARD_CODE不能为空！\\n";	
			}
			if(this.txtVIPCARD_NAME.Text.Trim().Length==0)
			{
				strErr+="VIPCARD_NAME不能为空！\\n";	
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
			string CUSTOM_CODE=this.txtCUSTOM_CODE.Text;
			string CUSTOM_NAME=this.txtCUSTOM_NAME.Text;
			string CREDIT_LIMIT=this.txtCREDIT_LIMIT.Text;
			string ORG_CODE=this.txtORG_CODE.Text;
			string PARENT_CUSTOM_CODE=this.txtPARENT_CUSTOM_CODE.Text;
			decimal CREDIT_AMOUNT=decimal.Parse(this.txtCREDIT_AMOUNT.Text);
			string CUSTOM_TYPE_CODE=this.txtCUSTOM_TYPE_CODE.Text;
			string FULL_NAME=this.txtFULL_NAME.Text;
			string SALE_MAN=this.txtSALE_MAN.Text;
			string FAX=this.txtFAX.Text;
			string MANAGER=this.txtMANAGER.Text;
			string ADDRESS=this.txtADDRESS.Text;
			string TELPHIONE=this.txtTELPHIONE.Text;
			string ZIP=this.txtZIP.Text;
			string EMAIL=this.txtEMAIL.Text;
			string HTTP=this.txtHTTP.Text;
			string VIPCARD_CODE=this.txtVIPCARD_CODE.Text;
			string VIPCARD_NAME=this.txtVIPCARD_NAME.Text;
			string CREATE_NAME=this.txtCREATE_NAME.Text;
			string CREATE_DATE=this.txtCREATE_DATE.Text;
			string UPDATE_NAME=this.txtUPDATE_NAME.Text;
			string UPDATE_DATE=this.txtUPDATE_DATE.Text;
			string REMARK=this.txtREMARK.Text;

			MyERP.Model.PUB_CUSTOM model=new MyERP.Model.PUB_CUSTOM();
			model.CUSTOM_CODE=CUSTOM_CODE;
			model.CUSTOM_NAME=CUSTOM_NAME;
			model.CREDIT_LIMIT=CREDIT_LIMIT;
			model.ORG_CODE=ORG_CODE;
			model.PARENT_CUSTOM_CODE=PARENT_CUSTOM_CODE;
			model.CREDIT_AMOUNT=CREDIT_AMOUNT;
			model.CUSTOM_TYPE_CODE=CUSTOM_TYPE_CODE;
			model.FULL_NAME=FULL_NAME;
			model.SALE_MAN=SALE_MAN;
			model.FAX=FAX;
			model.MANAGER=MANAGER;
			model.ADDRESS=ADDRESS;
			model.TELPHIONE=TELPHIONE;
			model.ZIP=ZIP;
			model.EMAIL=EMAIL;
			model.HTTP=HTTP;
			model.VIPCARD_CODE=VIPCARD_CODE;
			model.VIPCARD_NAME=VIPCARD_NAME;
			model.CREATE_NAME=CREATE_NAME;
			model.CREATE_DATE=CREATE_DATE;
			model.UPDATE_NAME=UPDATE_NAME;
			model.UPDATE_DATE=UPDATE_DATE;
			model.REMARK=REMARK;

			MyERP.BLL.PUB_CUSTOM bll=new MyERP.BLL.PUB_CUSTOM();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
