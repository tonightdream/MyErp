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
namespace MyERP.Web.CL_ITEM_STOCK_DETAIL_BEGIN_RECORD
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
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
			if(!PageValidate.IsDateTime(txtCREATE_DATE.Text))
			{
				strErr+="CREATE_DATE格式错误！\\n";	
			}
			if(this.txtCREATE_NAME.Text.Trim().Length==0)
			{
				strErr+="CREATE_NAME不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string COMPANY_CODE=this.txtCOMPANY_CODE.Text;
			string COMPANY_NAME=this.txtCOMPANY_NAME.Text;
			DateTime CREATE_DATE=DateTime.Parse(this.txtCREATE_DATE.Text);
			string CREATE_NAME=this.txtCREATE_NAME.Text;

			MyERP.Model.CL_ITEM_STOCK_DETAIL_BEGIN_RECORD model=new MyERP.Model.CL_ITEM_STOCK_DETAIL_BEGIN_RECORD();
			model.COMPANY_CODE=COMPANY_CODE;
			model.COMPANY_NAME=COMPANY_NAME;
			model.CREATE_DATE=CREATE_DATE;
			model.CREATE_NAME=CREATE_NAME;

			MyERP.BLL.CL_ITEM_STOCK_DETAIL_BEGIN_RECORD bll=new MyERP.BLL.CL_ITEM_STOCK_DETAIL_BEGIN_RECORD();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
