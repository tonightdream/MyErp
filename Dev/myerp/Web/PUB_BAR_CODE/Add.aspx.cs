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
namespace MyERP.Web.PUB_BAR_CODE
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
			if(this.txtITEM_CODE.Text.Trim().Length==0)
			{
				strErr+="ITEM_CODE不能为空！\\n";	
			}
			if(this.txtBAR_CODE.Text.Trim().Length==0)
			{
				strErr+="BAR_CODE不能为空！\\n";	
			}
			if(this.txtCOLOR_CODE.Text.Trim().Length==0)
			{
				strErr+="COLOR_CODE不能为空！\\n";	
			}
			if(this.txtRULER_CODE.Text.Trim().Length==0)
			{
				strErr+="RULER_CODE不能为空！\\n";	
			}
			if(this.txtLENGTH_CODE.Text.Trim().Length==0)
			{
				strErr+="LENGTH_CODE不能为空！\\n";	
			}
			if(this.txtCREATE_NAME.Text.Trim().Length==0)
			{
				strErr+="CREATE_NAME不能为空！\\n";	
			}
			if(this.txtCREATE_DATE.Text.Trim().Length==0)
			{
				strErr+="CREATE_DATE不能为空！\\n";	
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
			string ITEM_CODE=this.txtITEM_CODE.Text;
			string BAR_CODE=this.txtBAR_CODE.Text;
			string COLOR_CODE=this.txtCOLOR_CODE.Text;
			string RULER_CODE=this.txtRULER_CODE.Text;
			string LENGTH_CODE=this.txtLENGTH_CODE.Text;
			string CREATE_NAME=this.txtCREATE_NAME.Text;
			string CREATE_DATE=this.txtCREATE_DATE.Text;
			string REMARK=this.txtREMARK.Text;

			MyERP.Model.PUB_BAR_CODE model=new MyERP.Model.PUB_BAR_CODE();
			model.COMPANY_CODE=COMPANY_CODE;
			model.ITEM_CODE=ITEM_CODE;
			model.BAR_CODE=BAR_CODE;
			model.COLOR_CODE=COLOR_CODE;
			model.RULER_CODE=RULER_CODE;
			model.LENGTH_CODE=LENGTH_CODE;
			model.CREATE_NAME=CREATE_NAME;
			model.CREATE_DATE=CREATE_DATE;
			model.REMARK=REMARK;

			MyERP.BLL.PUB_BAR_CODE bll=new MyERP.BLL.PUB_BAR_CODE();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
