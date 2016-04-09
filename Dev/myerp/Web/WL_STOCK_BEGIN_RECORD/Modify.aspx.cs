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
namespace MyERP.Web.WL_STOCK_BEGIN_RECORD
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int ID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(ID);
				}
			}
		}
			
	private void ShowInfo(int ID)
	{
		MyERP.BLL.WL_STOCK_BEGIN_RECORD bll=new MyERP.BLL.WL_STOCK_BEGIN_RECORD();
		MyERP.Model.WL_STOCK_BEGIN_RECORD model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.txtSTOCK_CODE.Text=model.STOCK_CODE;
		this.txtCREATE_DATE.Text=model.CREATE_DATE;
		this.txtCREATE_NAME.Text=model.CREATE_NAME;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtSTOCK_CODE.Text.Trim().Length==0)
			{
				strErr+="STOCK_CODE不能为空！\\n";	
			}
			if(this.txtCREATE_DATE.Text.Trim().Length==0)
			{
				strErr+="CREATE_DATE不能为空！\\n";	
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
			int ID=int.Parse(this.lblID.Text);
			string STOCK_CODE=this.txtSTOCK_CODE.Text;
			string CREATE_DATE=this.txtCREATE_DATE.Text;
			string CREATE_NAME=this.txtCREATE_NAME.Text;


			MyERP.Model.WL_STOCK_BEGIN_RECORD model=new MyERP.Model.WL_STOCK_BEGIN_RECORD();
			model.ID=ID;
			model.STOCK_CODE=STOCK_CODE;
			model.CREATE_DATE=CREATE_DATE;
			model.CREATE_NAME=CREATE_NAME;

			MyERP.BLL.WL_STOCK_BEGIN_RECORD bll=new MyERP.BLL.WL_STOCK_BEGIN_RECORD();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
