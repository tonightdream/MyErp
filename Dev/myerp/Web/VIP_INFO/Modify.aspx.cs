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
namespace MyERP.Web.VIP_INFO
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					decimal VIP_TEMP_CARD_CODE=(Convert.ToDecimal(Request.Params["id"]));
					ShowInfo(VIP_TEMP_CARD_CODE);
				}
			}
		}
			
	private void ShowInfo(decimal VIP_TEMP_CARD_CODE)
	{
		MyERP.BLL.VIP_INFO bll=new MyERP.BLL.VIP_INFO();
		MyERP.Model.VIP_INFO model=bll.GetModel(VIP_TEMP_CARD_CODE);
		this.txtCOMPANY_CODE.Text=model.COMPANY_CODE;
		this.txtUSER_CODE.Text=model.USER_CODE;
		this.txtUSER_NAME.Text=model.USER_NAME;
		this.lblVIP_CARD_CODE.Text=model.VIP_CARD_CODE;
		this.lblVIP_TEMP_CARD_CODE.Text=model.VIP_TEMP_CARD_CODE.ToString();
		this.txtPASSWORD.Text=model.PASSWORD;
		this.txtBEGIN_DATE.Text=model.BEGIN_DATE.ToString();
		this.txtEND_DATE.Text=model.END_DATE.ToString();
		this.txtVIP_TYPE.Text=model.VIP_TYPE;
		this.txtTOTAL_SALES.Text=model.TOTAL_SALES.ToString();
		this.txtsalesno.Text=model.salesno;
		this.txtCREATE_NAME.Text=model.CREATE_NAME;
		this.txtCREATE_DATE.Text=model.CREATE_DATE.ToString();
		this.txtUPDATE_NAME.Text=model.UPDATE_NAME;
		this.txtUPDATE_DATE.Text=model.UPDATE_DATE.ToString();
		this.txtREMARK.Text=model.REMARK;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtCOMPANY_CODE.Text.Trim().Length==0)
			{
				strErr+="COMPANY_CODE不能为空！\\n";	
			}
			if(this.txtUSER_CODE.Text.Trim().Length==0)
			{
				strErr+="USER_CODE不能为空！\\n";	
			}
			if(this.txtUSER_NAME.Text.Trim().Length==0)
			{
				strErr+="USER_NAME不能为空！\\n";	
			}
			if(this.txtPASSWORD.Text.Trim().Length==0)
			{
				strErr+="PASSWORD不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtBEGIN_DATE.Text))
			{
				strErr+="BEGIN_DATE格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtEND_DATE.Text))
			{
				strErr+="END_DATE格式错误！\\n";	
			}
			if(this.txtVIP_TYPE.Text.Trim().Length==0)
			{
				strErr+="VIP_TYPE不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtTOTAL_SALES.Text))
			{
				strErr+="TOTAL_SALES格式错误！\\n";	
			}
			if(this.txtsalesno.Text.Trim().Length==0)
			{
				strErr+="salesno不能为空！\\n";	
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
			string COMPANY_CODE=this.txtCOMPANY_CODE.Text;
			string USER_CODE=this.txtUSER_CODE.Text;
			string USER_NAME=this.txtUSER_NAME.Text;
			string VIP_CARD_CODE=this.lblVIP_CARD_CODE.Text;
			decimal VIP_TEMP_CARD_CODE=decimal.Parse(this.lblVIP_TEMP_CARD_CODE.Text);
			string PASSWORD=this.txtPASSWORD.Text;
			DateTime BEGIN_DATE=DateTime.Parse(this.txtBEGIN_DATE.Text);
			DateTime END_DATE=DateTime.Parse(this.txtEND_DATE.Text);
			string VIP_TYPE=this.txtVIP_TYPE.Text;
			decimal TOTAL_SALES=decimal.Parse(this.txtTOTAL_SALES.Text);
			string salesno=this.txtsalesno.Text;
			string CREATE_NAME=this.txtCREATE_NAME.Text;
			DateTime CREATE_DATE=DateTime.Parse(this.txtCREATE_DATE.Text);
			string UPDATE_NAME=this.txtUPDATE_NAME.Text;
			DateTime UPDATE_DATE=DateTime.Parse(this.txtUPDATE_DATE.Text);
			string REMARK=this.txtREMARK.Text;


			MyERP.Model.VIP_INFO model=new MyERP.Model.VIP_INFO();
			model.COMPANY_CODE=COMPANY_CODE;
			model.USER_CODE=USER_CODE;
			model.USER_NAME=USER_NAME;
			model.VIP_CARD_CODE=VIP_CARD_CODE;
			model.VIP_TEMP_CARD_CODE=VIP_TEMP_CARD_CODE;
			model.PASSWORD=PASSWORD;
			model.BEGIN_DATE=BEGIN_DATE;
			model.END_DATE=END_DATE;
			model.VIP_TYPE=VIP_TYPE;
			model.TOTAL_SALES=TOTAL_SALES;
			model.salesno=salesno;
			model.CREATE_NAME=CREATE_NAME;
			model.CREATE_DATE=CREATE_DATE;
			model.UPDATE_NAME=UPDATE_NAME;
			model.UPDATE_DATE=UPDATE_DATE;
			model.REMARK=REMARK;

			MyERP.BLL.VIP_INFO bll=new MyERP.BLL.VIP_INFO();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
