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
namespace MyERP.Web.STEEL_GG
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					string INTERNAL_CODE= Request.Params["id"];
					ShowInfo(INTERNAL_CODE);
				}
			}
		}
			
	private void ShowInfo(string INTERNAL_CODE)
	{
		MyERP.BLL.STEEL_GG bll=new MyERP.BLL.STEEL_GG();
		MyERP.Model.STEEL_GG model=bll.GetModel(INTERNAL_CODE);
		this.lblINTERNAL_CODE.Text=model.INTERNAL_CODE;
		this.txtDEPARTMENT_CODE.Text=model.DEPARTMENT_CODE;
		this.txtDEPARTMENT_NAME.Text=model.DEPARTMENT_NAME;
		this.txtPARENT_DEPARTMENT_CODE.Text=model.PARENT_DEPARTMENT_CODE;
		this.txtITEM_INTERNAL_CODE.Text=model.ITEM_INTERNAL_CODE;
		this.txtITEM_CODE.Text=model.ITEM_CODE;
		this.txtITEM_NAME.Text=model.ITEM_NAME;
		this.txtSPECIFICATIONS.Text=model.SPECIFICATIONS;
		this.txtHD.Text=model.HD.ToString();
		this.txtKD.Text=model.KD.ToString();
		this.txtQUANTITY.Text=model.QUANTITY.ToString();
		this.txtCREATE_NAME.Text=model.CREATE_NAME;
		this.txtCREATE_DATE.Text=model.CREATE_DATE.ToString();
		this.txtUPDATE_NAME.Text=model.UPDATE_NAME;
		this.txtUPDATE_DATE.Text=model.UPDATE_DATE.ToString();
		this.txtREMARK.Text=model.REMARK;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtDEPARTMENT_CODE.Text.Trim().Length==0)
			{
				strErr+="DEPARTMENT_CODE不能为空！\\n";	
			}
			if(this.txtDEPARTMENT_NAME.Text.Trim().Length==0)
			{
				strErr+="DEPARTMENT_NAME不能为空！\\n";	
			}
			if(this.txtPARENT_DEPARTMENT_CODE.Text.Trim().Length==0)
			{
				strErr+="PARENT_DEPARTMENT_CODE不能为空！\\n";	
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
			if(this.txtSPECIFICATIONS.Text.Trim().Length==0)
			{
				strErr+="SPECIFICATIONS不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtHD.Text))
			{
				strErr+="HD格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtKD.Text))
			{
				strErr+="KD格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtQUANTITY.Text))
			{
				strErr+="QUANTITY格式错误！\\n";	
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
			string INTERNAL_CODE=this.lblINTERNAL_CODE.Text;
			string DEPARTMENT_CODE=this.txtDEPARTMENT_CODE.Text;
			string DEPARTMENT_NAME=this.txtDEPARTMENT_NAME.Text;
			string PARENT_DEPARTMENT_CODE=this.txtPARENT_DEPARTMENT_CODE.Text;
			string ITEM_INTERNAL_CODE=this.txtITEM_INTERNAL_CODE.Text;
			string ITEM_CODE=this.txtITEM_CODE.Text;
			string ITEM_NAME=this.txtITEM_NAME.Text;
			string SPECIFICATIONS=this.txtSPECIFICATIONS.Text;
			decimal HD=decimal.Parse(this.txtHD.Text);
			decimal KD=decimal.Parse(this.txtKD.Text);
			decimal QUANTITY=decimal.Parse(this.txtQUANTITY.Text);
			string CREATE_NAME=this.txtCREATE_NAME.Text;
			DateTime CREATE_DATE=DateTime.Parse(this.txtCREATE_DATE.Text);
			string UPDATE_NAME=this.txtUPDATE_NAME.Text;
			DateTime UPDATE_DATE=DateTime.Parse(this.txtUPDATE_DATE.Text);
			string REMARK=this.txtREMARK.Text;


			MyERP.Model.STEEL_GG model=new MyERP.Model.STEEL_GG();
			model.INTERNAL_CODE=INTERNAL_CODE;
			model.DEPARTMENT_CODE=DEPARTMENT_CODE;
			model.DEPARTMENT_NAME=DEPARTMENT_NAME;
			model.PARENT_DEPARTMENT_CODE=PARENT_DEPARTMENT_CODE;
			model.ITEM_INTERNAL_CODE=ITEM_INTERNAL_CODE;
			model.ITEM_CODE=ITEM_CODE;
			model.ITEM_NAME=ITEM_NAME;
			model.SPECIFICATIONS=SPECIFICATIONS;
			model.HD=HD;
			model.KD=KD;
			model.QUANTITY=QUANTITY;
			model.CREATE_NAME=CREATE_NAME;
			model.CREATE_DATE=CREATE_DATE;
			model.UPDATE_NAME=UPDATE_NAME;
			model.UPDATE_DATE=UPDATE_DATE;
			model.REMARK=REMARK;

			MyERP.BLL.STEEL_GG bll=new MyERP.BLL.STEEL_GG();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
