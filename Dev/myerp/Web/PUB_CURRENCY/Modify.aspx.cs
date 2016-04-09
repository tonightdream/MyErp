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
namespace MyERP.Web.PUB_CURRENCY
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
		MyERP.BLL.PUB_CURRENCY bll=new MyERP.BLL.PUB_CURRENCY();
		MyERP.Model.PUB_CURRENCY model=bll.GetModel();
		this.txtCOMPANY_CODE.Text=model.COMPANY_CODE;
		this.txtCURRENCY_CODE.Text=model.CURRENCY_CODE;
		this.txtCURRENCY_NAME.Text=model.CURRENCY_NAME;
		this.txtEXCHANGE_RATE.Text=model.EXCHANGE_RATE.ToString();
		this.txtALLOW_USERED.Text=model.ALLOW_USERED;
		this.txtCREATE_NAME.Text=model.CREATE_NAME;
		this.txtCREATE_DATE.Text=model.CREATE_DATE.ToString();
		this.txtREMARK.Text=model.REMARK;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtCOMPANY_CODE.Text.Trim().Length==0)
			{
				strErr+="COMPANY_CODE不能为空！\\n";	
			}
			if(this.txtCURRENCY_CODE.Text.Trim().Length==0)
			{
				strErr+="CURRENCY_CODE不能为空！\\n";	
			}
			if(this.txtCURRENCY_NAME.Text.Trim().Length==0)
			{
				strErr+="CURRENCY_NAME不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtEXCHANGE_RATE.Text))
			{
				strErr+="EXCHANGE_RATE格式错误！\\n";	
			}
			if(this.txtALLOW_USERED.Text.Trim().Length==0)
			{
				strErr+="ALLOW_USERED不能为空！\\n";	
			}
			if(this.txtCREATE_NAME.Text.Trim().Length==0)
			{
				strErr+="CREATE_NAME不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtCREATE_DATE.Text))
			{
				strErr+="CREATE_DATE格式错误！\\n";	
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
			string CURRENCY_CODE=this.txtCURRENCY_CODE.Text;
			string CURRENCY_NAME=this.txtCURRENCY_NAME.Text;
			decimal EXCHANGE_RATE=decimal.Parse(this.txtEXCHANGE_RATE.Text);
			string ALLOW_USERED=this.txtALLOW_USERED.Text;
			string CREATE_NAME=this.txtCREATE_NAME.Text;
			DateTime CREATE_DATE=DateTime.Parse(this.txtCREATE_DATE.Text);
			string REMARK=this.txtREMARK.Text;


			MyERP.Model.PUB_CURRENCY model=new MyERP.Model.PUB_CURRENCY();
			model.COMPANY_CODE=COMPANY_CODE;
			model.CURRENCY_CODE=CURRENCY_CODE;
			model.CURRENCY_NAME=CURRENCY_NAME;
			model.EXCHANGE_RATE=EXCHANGE_RATE;
			model.ALLOW_USERED=ALLOW_USERED;
			model.CREATE_NAME=CREATE_NAME;
			model.CREATE_DATE=CREATE_DATE;
			model.REMARK=REMARK;

			MyERP.BLL.PUB_CURRENCY bll=new MyERP.BLL.PUB_CURRENCY();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
