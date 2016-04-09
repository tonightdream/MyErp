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
namespace MyERP.Web.WL_STOCK_BEGIN
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
		MyERP.BLL.WL_STOCK_BEGIN bll=new MyERP.BLL.WL_STOCK_BEGIN();
		MyERP.Model.WL_STOCK_BEGIN model=bll.GetModel();
		this.txtSTOCK_CODE.Text=model.STOCK_CODE;
		this.txtSTOCK_NAME.Text=model.STOCK_NAME;
		this.txtITEM_INTERNAL_CODE.Text=model.ITEM_INTERNAL_CODE;
		this.txtITEM_CODE.Text=model.ITEM_CODE;
		this.txtITEM_NAME.Text=model.ITEM_NAME;
		this.txtACTUAL_QTY.Text=model.ACTUAL_QTY.ToString();
		this.txtCREATE_DATE.Text=model.CREATE_DATE.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtSTOCK_CODE.Text.Trim().Length==0)
			{
				strErr+="STOCK_CODE不能为空！\\n";	
			}
			if(this.txtSTOCK_NAME.Text.Trim().Length==0)
			{
				strErr+="STOCK_NAME不能为空！\\n";	
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
			if(!PageValidate.IsDecimal(txtACTUAL_QTY.Text))
			{
				strErr+="ACTUAL_QTY格式错误！\\n";	
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
			string STOCK_CODE=this.txtSTOCK_CODE.Text;
			string STOCK_NAME=this.txtSTOCK_NAME.Text;
			string ITEM_INTERNAL_CODE=this.txtITEM_INTERNAL_CODE.Text;
			string ITEM_CODE=this.txtITEM_CODE.Text;
			string ITEM_NAME=this.txtITEM_NAME.Text;
			decimal ACTUAL_QTY=decimal.Parse(this.txtACTUAL_QTY.Text);
			DateTime CREATE_DATE=DateTime.Parse(this.txtCREATE_DATE.Text);


			MyERP.Model.WL_STOCK_BEGIN model=new MyERP.Model.WL_STOCK_BEGIN();
			model.STOCK_CODE=STOCK_CODE;
			model.STOCK_NAME=STOCK_NAME;
			model.ITEM_INTERNAL_CODE=ITEM_INTERNAL_CODE;
			model.ITEM_CODE=ITEM_CODE;
			model.ITEM_NAME=ITEM_NAME;
			model.ACTUAL_QTY=ACTUAL_QTY;
			model.CREATE_DATE=CREATE_DATE;

			MyERP.BLL.WL_STOCK_BEGIN bll=new MyERP.BLL.WL_STOCK_BEGIN();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
