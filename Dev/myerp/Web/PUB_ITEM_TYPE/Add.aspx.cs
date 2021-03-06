﻿using System;
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
namespace MyERP.Web.PUB_ITEM_TYPE
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
			if(this.txtCOMPANY_CODE.Text.Trim().Length==0)
			{
				strErr+="COMPANY_CODE不能为空！\\n";	
			}
			if(this.txtCOMPANY_NAME.Text.Trim().Length==0)
			{
				strErr+="COMPANY_NAME不能为空！\\n";	
			}
			if(this.txtTYPE_CODE.Text.Trim().Length==0)
			{
				strErr+="TYPE_CODE不能为空！\\n";	
			}
			if(this.txtTYPE_NAME.Text.Trim().Length==0)
			{
				strErr+="TYPE_NAME不能为空！\\n";	
			}
			if(this.txtPARENT_TYPE_CODE.Text.Trim().Length==0)
			{
				strErr+="PARENT_TYPE_CODE不能为空！\\n";	
			}
			if(this.txtCREATE_NAME.Text.Trim().Length==0)
			{
				strErr+="CREATE_NAME不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtCREATE_DATE.Text))
			{
				strErr+="CREATE_DATE格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string INTERNAL_CODE=this.txtINTERNAL_CODE.Text;
			string COMPANY_CODE=this.txtCOMPANY_CODE.Text;
			string COMPANY_NAME=this.txtCOMPANY_NAME.Text;
			string TYPE_CODE=this.txtTYPE_CODE.Text;
			string TYPE_NAME=this.txtTYPE_NAME.Text;
			string PARENT_TYPE_CODE=this.txtPARENT_TYPE_CODE.Text;
			string CREATE_NAME=this.txtCREATE_NAME.Text;
			DateTime CREATE_DATE=DateTime.Parse(this.txtCREATE_DATE.Text);
			bool ALLOW_used=this.chkALLOW_used.Checked;

			MyERP.Model.PUB_ITEM_TYPE model=new MyERP.Model.PUB_ITEM_TYPE();
			model.INTERNAL_CODE=INTERNAL_CODE;
			model.COMPANY_CODE=COMPANY_CODE;
			model.COMPANY_NAME=COMPANY_NAME;
			model.TYPE_CODE=TYPE_CODE;
			model.TYPE_NAME=TYPE_NAME;
			model.PARENT_TYPE_CODE=PARENT_TYPE_CODE;
			model.CREATE_NAME=CREATE_NAME;
			model.CREATE_DATE=CREATE_DATE;
			model.ALLOW_used=ALLOW_used;

			MyERP.BLL.PUB_ITEM_TYPE bll=new MyERP.BLL.PUB_ITEM_TYPE();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
