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
namespace MyERP.Web.SAL_ITEM_NOW_PRICE
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtCompanyCode.Text.Trim().Length==0)
			{
				strErr+="CompanyCode不能为空！\\n";	
			}
			if(this.txtItemNo.Text.Trim().Length==0)
			{
				strErr+="ItemNo不能为空！\\n";	
			}
			if(this.txtColor.Text.Trim().Length==0)
			{
				strErr+="Color不能为空！\\n";	
			}
			if(this.txtItemInternalCode.Text.Trim().Length==0)
			{
				strErr+="ItemInternalCode不能为空！\\n";	
			}
			if(this.txtInternalCodeMean.Text.Trim().Length==0)
			{
				strErr+="InternalCodeMean不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtAllPrice.Text))
			{
				strErr+="AllPrice格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtWholeSalePrice.Text))
			{
				strErr+="WholeSalePrice格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtOncePrice.Text))
			{
				strErr+="OncePrice格式错误！\\n";	
			}
			if(this.txtMeasureUnit.Text.Trim().Length==0)
			{
				strErr+="MeasureUnit不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string CompanyCode=this.txtCompanyCode.Text;
			string ItemNo=this.txtItemNo.Text;
			string Color=this.txtColor.Text;
			string ItemInternalCode=this.txtItemInternalCode.Text;
			string InternalCodeMean=this.txtInternalCodeMean.Text;
			decimal AllPrice=decimal.Parse(this.txtAllPrice.Text);
			decimal WholeSalePrice=decimal.Parse(this.txtWholeSalePrice.Text);
			decimal OncePrice=decimal.Parse(this.txtOncePrice.Text);
			string MeasureUnit=this.txtMeasureUnit.Text;
			byte[] LastEdit= new UnicodeEncoding().GetBytes(this.txtLastEdit.Text);

			MyERP.Model.SAL_ITEM_NOW_PRICE model=new MyERP.Model.SAL_ITEM_NOW_PRICE();
			model.CompanyCode=CompanyCode;
			model.ItemNo=ItemNo;
			model.Color=Color;
			model.ItemInternalCode=ItemInternalCode;
			model.InternalCodeMean=InternalCodeMean;
			model.AllPrice=AllPrice;
			model.WholeSalePrice=WholeSalePrice;
			model.OncePrice=OncePrice;
			model.MeasureUnit=MeasureUnit;
			model.LastEdit=LastEdit;

			MyERP.BLL.SAL_ITEM_NOW_PRICE bll=new MyERP.BLL.SAL_ITEM_NOW_PRICE();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
