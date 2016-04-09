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
namespace MyERP.Web.ORDER_ZBPrice
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
			if(this.txtZBBH.Text.Trim().Length==0)
			{
				strErr+="ZBBH不能为空！\\n";	
			}
			if(this.txtPZMC.Text.Trim().Length==0)
			{
				strErr+="PZMC不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtPRICE.Text))
			{
				strErr+="PRICE格式错误！\\n";	
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
			string CUSTOM_CODE=this.txtCUSTOM_CODE.Text;
			string CUSTOM_NAME=this.txtCUSTOM_NAME.Text;
			string ZBBH=this.txtZBBH.Text;
			string PZMC=this.txtPZMC.Text;
			decimal PRICE=decimal.Parse(this.txtPRICE.Text);
			string CREATE_NAME=this.txtCREATE_NAME.Text;
			DateTime CREATE_DATE=DateTime.Parse(this.txtCREATE_DATE.Text);

			MyERP.Model.ORDER_ZBPrice model=new MyERP.Model.ORDER_ZBPrice();
			model.CUSTOM_CODE=CUSTOM_CODE;
			model.CUSTOM_NAME=CUSTOM_NAME;
			model.ZBBH=ZBBH;
			model.PZMC=PZMC;
			model.PRICE=PRICE;
			model.CREATE_NAME=CREATE_NAME;
			model.CREATE_DATE=CREATE_DATE;

			MyERP.BLL.ORDER_ZBPrice bll=new MyERP.BLL.ORDER_ZBPrice();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
