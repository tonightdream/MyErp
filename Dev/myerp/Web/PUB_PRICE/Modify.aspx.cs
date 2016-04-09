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
namespace MyERP.Web.PUB_PRICE
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
		MyERP.BLL.PUB_PRICE bll=new MyERP.BLL.PUB_PRICE();
		MyERP.Model.PUB_PRICE model=bll.GetModel();
		this.txtINTERNAL_CODE.Text=model.INTERNAL_CODE;
		this.txtCOMPANY_CODE.Text=model.COMPANY_CODE;
		this.txtITEM_CODE.Text=model.ITEM_CODE;
		this.txtITEM_NAME.Text=model.ITEM_NAME;
		this.txtCOLOR.Text=model.COLOR;
		this.txtALL_PRICE.Text=model.ALL_PRICE.ToString();
		this.txtCREATE_NAME.Text=model.CREATE_NAME;
		this.txtCREATE_DATE.Text=model.CREATE_DATE;
		this.txtUPDATE_NAME.Text=model.UPDATE_NAME;
		this.txtUPDATE_DATE.Text=model.UPDATE_DATE;

	}

		public void btnSave_Click(object sender, EventArgs e)
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
			if(!PageValidate.IsDecimal(txtALL_PRICE.Text))
			{
				strErr+="ALL_PRICE格式错误！\\n";	
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

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string INTERNAL_CODE=this.txtINTERNAL_CODE.Text;
			string COMPANY_CODE=this.txtCOMPANY_CODE.Text;
			string ITEM_CODE=this.txtITEM_CODE.Text;
			string ITEM_NAME=this.txtITEM_NAME.Text;
			string COLOR=this.txtCOLOR.Text;
			decimal ALL_PRICE=decimal.Parse(this.txtALL_PRICE.Text);
			string CREATE_NAME=this.txtCREATE_NAME.Text;
			string CREATE_DATE=this.txtCREATE_DATE.Text;
			string UPDATE_NAME=this.txtUPDATE_NAME.Text;
			string UPDATE_DATE=this.txtUPDATE_DATE.Text;


			MyERP.Model.PUB_PRICE model=new MyERP.Model.PUB_PRICE();
			model.INTERNAL_CODE=INTERNAL_CODE;
			model.COMPANY_CODE=COMPANY_CODE;
			model.ITEM_CODE=ITEM_CODE;
			model.ITEM_NAME=ITEM_NAME;
			model.COLOR=COLOR;
			model.ALL_PRICE=ALL_PRICE;
			model.CREATE_NAME=CREATE_NAME;
			model.CREATE_DATE=CREATE_DATE;
			model.UPDATE_NAME=UPDATE_NAME;
			model.UPDATE_DATE=UPDATE_DATE;

			MyERP.BLL.PUB_PRICE bll=new MyERP.BLL.PUB_PRICE();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
