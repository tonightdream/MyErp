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
namespace MyERP.Web.SAL_CUSTOM
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
		MyERP.BLL.SAL_CUSTOM bll=new MyERP.BLL.SAL_CUSTOM();
		MyERP.Model.SAL_CUSTOM model=bll.GetModel();
		this.txtCompanyCode.Text=model.CompanyCode;
		this.txtCustomerCode.Text=model.CustomerCode;
		this.txtCustomerLevel.Text=model.CustomerLevel;
		this.txtDiscount.Text=model.Discount.ToString();
		this.txtDiscountGrade.Text=model.DiscountGrade.ToString();
		this.txtTradeAmount.Text=model.TradeAmount.ToString();
		this.txtTradeAmountDate.Text=model.TradeAmountDate.ToString();
		this.txtTradeGrade.Text=model.TradeGrade.ToString();
		this.txtDueAmount.Text=model.DueAmount.ToString();
		this.txtDueAmountDate.Text=model.DueAmountDate.ToString();
		this.txtDueGrade.Text=model.DueGrade.ToString();
		this.txtDueTime.Text=model.DueTime.ToString();
		this.txtDueTimeGrade.Text=model.DueTimeGrade.ToString();
		this.txtDueTimeDate.Text=model.DueTimeDate.ToString();
		this.txtRemark.Text=model.Remark;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtCompanyCode.Text.Trim().Length==0)
			{
				strErr+="CompanyCode不能为空！\\n";	
			}
			if(this.txtCustomerCode.Text.Trim().Length==0)
			{
				strErr+="CustomerCode不能为空！\\n";	
			}
			if(this.txtCustomerLevel.Text.Trim().Length==0)
			{
				strErr+="CustomerLevel不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtDiscount.Text))
			{
				strErr+="Discount格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtDiscountGrade.Text))
			{
				strErr+="DiscountGrade格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtTradeAmount.Text))
			{
				strErr+="TradeAmount格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtTradeAmountDate.Text))
			{
				strErr+="TradeAmountDate格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtTradeGrade.Text))
			{
				strErr+="TradeGrade格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtDueAmount.Text))
			{
				strErr+="DueAmount格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtDueAmountDate.Text))
			{
				strErr+="DueAmountDate格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtDueGrade.Text))
			{
				strErr+="DueGrade格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtDueTime.Text))
			{
				strErr+="DueTime格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtDueTimeGrade.Text))
			{
				strErr+="DueTimeGrade格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtDueTimeDate.Text))
			{
				strErr+="DueTimeDate格式错误！\\n";	
			}
			if(this.txtRemark.Text.Trim().Length==0)
			{
				strErr+="Remark不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string CompanyCode=this.txtCompanyCode.Text;
			string CustomerCode=this.txtCustomerCode.Text;
			string CustomerLevel=this.txtCustomerLevel.Text;
			decimal Discount=decimal.Parse(this.txtDiscount.Text);
			int DiscountGrade=int.Parse(this.txtDiscountGrade.Text);
			decimal TradeAmount=decimal.Parse(this.txtTradeAmount.Text);
			DateTime TradeAmountDate=DateTime.Parse(this.txtTradeAmountDate.Text);
			int TradeGrade=int.Parse(this.txtTradeGrade.Text);
			decimal DueAmount=decimal.Parse(this.txtDueAmount.Text);
			DateTime DueAmountDate=DateTime.Parse(this.txtDueAmountDate.Text);
			int DueGrade=int.Parse(this.txtDueGrade.Text);
			int DueTime=int.Parse(this.txtDueTime.Text);
			int DueTimeGrade=int.Parse(this.txtDueTimeGrade.Text);
			DateTime DueTimeDate=DateTime.Parse(this.txtDueTimeDate.Text);
			string Remark=this.txtRemark.Text;


			MyERP.Model.SAL_CUSTOM model=new MyERP.Model.SAL_CUSTOM();
			model.CompanyCode=CompanyCode;
			model.CustomerCode=CustomerCode;
			model.CustomerLevel=CustomerLevel;
			model.Discount=Discount;
			model.DiscountGrade=DiscountGrade;
			model.TradeAmount=TradeAmount;
			model.TradeAmountDate=TradeAmountDate;
			model.TradeGrade=TradeGrade;
			model.DueAmount=DueAmount;
			model.DueAmountDate=DueAmountDate;
			model.DueGrade=DueGrade;
			model.DueTime=DueTime;
			model.DueTimeGrade=DueTimeGrade;
			model.DueTimeDate=DueTimeDate;
			model.Remark=Remark;

			MyERP.BLL.SAL_CUSTOM bll=new MyERP.BLL.SAL_CUSTOM();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
