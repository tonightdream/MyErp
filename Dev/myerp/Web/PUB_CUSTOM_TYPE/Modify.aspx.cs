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
namespace MyERP.Web.PUB_CUSTOM_TYPE
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
		MyERP.BLL.PUB_CUSTOM_TYPE bll=new MyERP.BLL.PUB_CUSTOM_TYPE();
		MyERP.Model.PUB_CUSTOM_TYPE model=bll.GetModel();
		this.txtINTERNAL_CODE.Text=model.INTERNAL_CODE;
		this.txtTYPE_CODE.Text=model.TYPE_CODE;
		this.txtTYPE_NAME.Text=model.TYPE_NAME;
		this.txtCRDATE_NAME.Text=model.CRDATE_NAME;
		this.txtCREATE_DATE.Text=model.CREATE_DATE;
		this.txtUPDATE_NAME.Text=model.UPDATE_NAME;
		this.txtUPDATE_DATE.Text=model.UPDATE_DATE;
		this.txtREMARK.Text=model.REMARK;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtINTERNAL_CODE.Text.Trim().Length==0)
			{
				strErr+="INTERNAL_CODE不能为空！\\n";	
			}
			if(this.txtTYPE_CODE.Text.Trim().Length==0)
			{
				strErr+="TYPE_CODE不能为空！\\n";	
			}
			if(this.txtTYPE_NAME.Text.Trim().Length==0)
			{
				strErr+="TYPE_NAME不能为空！\\n";	
			}
			if(this.txtCRDATE_NAME.Text.Trim().Length==0)
			{
				strErr+="CRDATE_NAME不能为空！\\n";	
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
			if(this.txtREMARK.Text.Trim().Length==0)
			{
				strErr+="REMARK不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string INTERNAL_CODE=this.txtINTERNAL_CODE.Text;
			string TYPE_CODE=this.txtTYPE_CODE.Text;
			string TYPE_NAME=this.txtTYPE_NAME.Text;
			string CRDATE_NAME=this.txtCRDATE_NAME.Text;
			string CREATE_DATE=this.txtCREATE_DATE.Text;
			string UPDATE_NAME=this.txtUPDATE_NAME.Text;
			string UPDATE_DATE=this.txtUPDATE_DATE.Text;
			string REMARK=this.txtREMARK.Text;


			MyERP.Model.PUB_CUSTOM_TYPE model=new MyERP.Model.PUB_CUSTOM_TYPE();
			model.INTERNAL_CODE=INTERNAL_CODE;
			model.TYPE_CODE=TYPE_CODE;
			model.TYPE_NAME=TYPE_NAME;
			model.CRDATE_NAME=CRDATE_NAME;
			model.CREATE_DATE=CREATE_DATE;
			model.UPDATE_NAME=UPDATE_NAME;
			model.UPDATE_DATE=UPDATE_DATE;
			model.REMARK=REMARK;

			MyERP.BLL.PUB_CUSTOM_TYPE bll=new MyERP.BLL.PUB_CUSTOM_TYPE();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
