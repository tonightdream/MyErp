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
namespace MyERP.Web.PUB_ITEM_PRICE
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
			if(this.txtITEM_INTERNAL_CODE.Text.Trim().Length==0)
			{
				strErr+="ITEM_INTERNAL_CODE不能为空！\\n";	
			}
			if(this.txtITEM_CODE.Text.Trim().Length==0)
			{
				strErr+="ITEM_CODE不能为空！\\n";	
			}
			if(this.txtITEM_NAME.Text.Trim().Length==0)
			{
				strErr+="ITEM_NAME不能为空！\\n";	
			}
			if(this.txtCOLOR.Text.Trim().Length==0)
			{
				strErr+="COLOR不能为空！\\n";	
			}
			if(this.txtMeasureUnit.Text.Trim().Length==0)
			{
				strErr+="MeasureUnit不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtPRICE.Text))
			{
				strErr+="PRICE格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtSTART_DATE.Text))
			{
				strErr+="START_DATE格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtSTOP_DATE.Text))
			{
				strErr+="STOP_DATE格式错误！\\n";	
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
			string ITEM_INTERNAL_CODE=this.txtITEM_INTERNAL_CODE.Text;
			string ITEM_CODE=this.txtITEM_CODE.Text;
			string ITEM_NAME=this.txtITEM_NAME.Text;
			string COLOR=this.txtCOLOR.Text;
			string MeasureUnit=this.txtMeasureUnit.Text;
			decimal PRICE=decimal.Parse(this.txtPRICE.Text);
			DateTime START_DATE=DateTime.Parse(this.txtSTART_DATE.Text);
			DateTime STOP_DATE=DateTime.Parse(this.txtSTOP_DATE.Text);
			string CREATE_NAME=this.txtCREATE_NAME.Text;
			DateTime CREATE_DATE=DateTime.Parse(this.txtCREATE_DATE.Text);
			string REMARK=this.txtREMARK.Text;

			MyERP.Model.PUB_ITEM_PRICE model=new MyERP.Model.PUB_ITEM_PRICE();
			model.COMPANY_CODE=COMPANY_CODE;
			model.ITEM_INTERNAL_CODE=ITEM_INTERNAL_CODE;
			model.ITEM_CODE=ITEM_CODE;
			model.ITEM_NAME=ITEM_NAME;
			model.COLOR=COLOR;
			model.MeasureUnit=MeasureUnit;
			model.PRICE=PRICE;
			model.START_DATE=START_DATE;
			model.STOP_DATE=STOP_DATE;
			model.CREATE_NAME=CREATE_NAME;
			model.CREATE_DATE=CREATE_DATE;
			model.REMARK=REMARK;

			MyERP.BLL.PUB_ITEM_PRICE bll=new MyERP.BLL.PUB_ITEM_PRICE();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
