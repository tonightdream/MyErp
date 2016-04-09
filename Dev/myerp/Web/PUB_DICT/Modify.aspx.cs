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
namespace MyERP.Web.PUB_DICT
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					string DICT_CODE= Request.Params["id"];
					ShowInfo(DICT_CODE);
				}
			}
		}
			
	private void ShowInfo(string DICT_CODE)
	{
		MyERP.BLL.PUB_DICT bll=new MyERP.BLL.PUB_DICT();
		MyERP.Model.PUB_DICT model=bll.GetModel(DICT_CODE);
		this.lblDICT_CODE.Text=model.DICT_CODE;
		this.txtDICT_NAME.Text=model.DICT_NAME;
		this.txtPARENT_DICT_CODE.Text=model.PARENT_DICT_CODE;
		this.txtCREATE_NAME.Text=model.CREATE_NAME;
		this.txtCREATE_DATE.Text=model.CREATE_DATE.ToString();
		this.txtUPDATE_NAME.Text=model.UPDATE_NAME;
		this.txtUPDATE_DATE.Text=model.UPDATE_DATE.ToString();
		this.txtREMARK.Text=model.REMARK;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtDICT_NAME.Text.Trim().Length==0)
			{
				strErr+="DICT_NAME不能为空！\\n";	
			}
			if(this.txtPARENT_DICT_CODE.Text.Trim().Length==0)
			{
				strErr+="PARENT_DICT_CODE不能为空！\\n";	
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
			if(this.txtREMARK.Text.Trim().Length==0)
			{
				strErr+="REMARK不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string DICT_CODE=this.lblDICT_CODE.Text;
			string DICT_NAME=this.txtDICT_NAME.Text;
			string PARENT_DICT_CODE=this.txtPARENT_DICT_CODE.Text;
			string CREATE_NAME=this.txtCREATE_NAME.Text;
			DateTime CREATE_DATE=DateTime.Parse(this.txtCREATE_DATE.Text);
			string UPDATE_NAME=this.txtUPDATE_NAME.Text;
			DateTime UPDATE_DATE=DateTime.Parse(this.txtUPDATE_DATE.Text);
			string REMARK=this.txtREMARK.Text;


			MyERP.Model.PUB_DICT model=new MyERP.Model.PUB_DICT();
			model.DICT_CODE=DICT_CODE;
			model.DICT_NAME=DICT_NAME;
			model.PARENT_DICT_CODE=PARENT_DICT_CODE;
			model.CREATE_NAME=CREATE_NAME;
			model.CREATE_DATE=CREATE_DATE;
			model.UPDATE_NAME=UPDATE_NAME;
			model.UPDATE_DATE=UPDATE_DATE;
			model.REMARK=REMARK;

			MyERP.BLL.PUB_DICT bll=new MyERP.BLL.PUB_DICT();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
