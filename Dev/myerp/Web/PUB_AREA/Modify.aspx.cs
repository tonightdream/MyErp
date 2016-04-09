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
namespace MyERP.Web.PUB_AREA
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					string AREA_CODE= Request.Params["id"];
					ShowInfo(AREA_CODE);
				}
			}
		}
			
	private void ShowInfo(string AREA_CODE)
	{
		MyERP.BLL.PUB_AREA bll=new MyERP.BLL.PUB_AREA();
		MyERP.Model.PUB_AREA model=bll.GetModel(AREA_CODE);
		this.txtCOMPANY_CODE.Text=model.COMPANY_CODE;
		this.lblAREA_CODE.Text=model.AREA_CODE;
		this.txtAREA_NAME.Text=model.AREA_NAME;
		this.txtPARENT_AREA_CODE.Text=model.PARENT_AREA_CODE;
		this.txtMANAGER.Text=model.MANAGER;
		this.txtALLOW_USERED.Text=model.ALLOW_USERED;
		this.txtCREATE_NAME.Text=model.CREATE_NAME;
		this.txtCREATE_DATE.Text=model.CREATE_DATE.ToString();
		this.txtUPDATE_NAME.Text=model.UPDATE_NAME;
		this.txtUPDATE_DATE.Text=model.UPDATE_DATE.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtCOMPANY_CODE.Text.Trim().Length==0)
			{
				strErr+="COMPANY_CODE不能为空！\\n";	
			}
			if(this.txtAREA_NAME.Text.Trim().Length==0)
			{
				strErr+="AREA_NAME不能为空！\\n";	
			}
			if(this.txtPARENT_AREA_CODE.Text.Trim().Length==0)
			{
				strErr+="PARENT_AREA_CODE不能为空！\\n";	
			}
			if(this.txtMANAGER.Text.Trim().Length==0)
			{
				strErr+="MANAGER不能为空！\\n";	
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
			if(this.txtUPDATE_NAME.Text.Trim().Length==0)
			{
				strErr+="UPDATE_NAME不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtUPDATE_DATE.Text))
			{
				strErr+="UPDATE_DATE格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string COMPANY_CODE=this.txtCOMPANY_CODE.Text;
			string AREA_CODE=this.lblAREA_CODE.Text;
			string AREA_NAME=this.txtAREA_NAME.Text;
			string PARENT_AREA_CODE=this.txtPARENT_AREA_CODE.Text;
			string MANAGER=this.txtMANAGER.Text;
			string ALLOW_USERED=this.txtALLOW_USERED.Text;
			string CREATE_NAME=this.txtCREATE_NAME.Text;
			DateTime CREATE_DATE=DateTime.Parse(this.txtCREATE_DATE.Text);
			string UPDATE_NAME=this.txtUPDATE_NAME.Text;
			DateTime UPDATE_DATE=DateTime.Parse(this.txtUPDATE_DATE.Text);


			MyERP.Model.PUB_AREA model=new MyERP.Model.PUB_AREA();
			model.COMPANY_CODE=COMPANY_CODE;
			model.AREA_CODE=AREA_CODE;
			model.AREA_NAME=AREA_NAME;
			model.PARENT_AREA_CODE=PARENT_AREA_CODE;
			model.MANAGER=MANAGER;
			model.ALLOW_USERED=ALLOW_USERED;
			model.CREATE_NAME=CREATE_NAME;
			model.CREATE_DATE=CREATE_DATE;
			model.UPDATE_NAME=UPDATE_NAME;
			model.UPDATE_DATE=UPDATE_DATE;

			MyERP.BLL.PUB_AREA bll=new MyERP.BLL.PUB_AREA();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
