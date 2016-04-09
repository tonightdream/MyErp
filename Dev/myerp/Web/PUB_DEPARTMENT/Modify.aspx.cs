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
namespace MyERP.Web.PUB_DEPARTMENT
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					string DEPARTMENT_CODE= Request.Params["id"];
					ShowInfo(DEPARTMENT_CODE);
				}
			}
		}
			
	private void ShowInfo(string DEPARTMENT_CODE)
	{
		MyERP.BLL.PUB_DEPARTMENT bll=new MyERP.BLL.PUB_DEPARTMENT();
		MyERP.Model.PUB_DEPARTMENT model=bll.GetModel(DEPARTMENT_CODE);
		this.txtINTERNAL_CODE.Text=model.INTERNAL_CODE;
		this.txtCOMPANY_CODE.Text=model.COMPANY_CODE;
		this.lblDEPARTMENT_CODE.Text=model.DEPARTMENT_CODE;
		this.txtDEPARTMENT_NAME.Text=model.DEPARTMENT_NAME;
		this.txtPARENT_DEPARTMENT_CODE.Text=model.PARENT_DEPARTMENT_CODE;
		this.txtMANAGER.Text=model.MANAGER;
		this.txtTELEPHONE.Text=model.TELEPHONE;
		this.txtADDRESS.Text=model.ADDRESS;
		this.txtSHOP_NAME.Text=model.SHOP_NAME;
		this.txtSETTLE_DATE.Text=model.SETTLE_DATE.ToString();
		this.txtSIZE.Text=model.SIZE.ToString();
		this.txtEMAIL.Text=model.EMAIL;
		this.txtFAX.Text=model.FAX;
		this.txtDISCOUNT.Text=model.DISCOUNT.ToString();
		this.txtSHIP.Text=model.SHIP.ToString();
		this.txtPPRICE_SHOW.Text=model.PPRICE_SHOW.ToString();
		this.txtSALE_METHOD.Text=model.SALE_METHOD;
		this.txtALLOW_USED.Text=model.ALLOW_USED;
		this.txtSTART_DATE.Text=model.START_DATE.ToString();
		this.txtCREATE_NAME.Text=model.CREATE_NAME;
		this.txtCREATE_DATE.Text=model.CREATE_DATE.ToString();
		this.txtUPDATE_NAME.Text=model.UPDATE_NAME;
		this.txtUPDATE_DATE.Text=model.UPDATE_DATE.ToString();
		this.txtREMARK.Text=model.REMARK;

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
			if(this.txtDEPARTMENT_NAME.Text.Trim().Length==0)
			{
				strErr+="DEPARTMENT_NAME不能为空！\\n";	
			}
			if(this.txtPARENT_DEPARTMENT_CODE.Text.Trim().Length==0)
			{
				strErr+="PARENT_DEPARTMENT_CODE不能为空！\\n";	
			}
			if(this.txtMANAGER.Text.Trim().Length==0)
			{
				strErr+="MANAGER不能为空！\\n";	
			}
			if(this.txtTELEPHONE.Text.Trim().Length==0)
			{
				strErr+="TELEPHONE不能为空！\\n";	
			}
			if(this.txtADDRESS.Text.Trim().Length==0)
			{
				strErr+="ADDRESS不能为空！\\n";	
			}
			if(this.txtSHOP_NAME.Text.Trim().Length==0)
			{
				strErr+="SHOP_NAME不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtSETTLE_DATE.Text))
			{
				strErr+="SETTLE_DATE格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtSIZE.Text))
			{
				strErr+="SIZE格式错误！\\n";	
			}
			if(this.txtEMAIL.Text.Trim().Length==0)
			{
				strErr+="EMAIL不能为空！\\n";	
			}
			if(this.txtFAX.Text.Trim().Length==0)
			{
				strErr+="FAX不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtDISCOUNT.Text))
			{
				strErr+="DISCOUNT格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtSHIP.Text))
			{
				strErr+="SHIP格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtPPRICE_SHOW.Text))
			{
				strErr+="PPRICE_SHOW格式错误！\\n";	
			}
			if(this.txtSALE_METHOD.Text.Trim().Length==0)
			{
				strErr+="SALE_METHOD不能为空！\\n";	
			}
			if(this.txtALLOW_USED.Text.Trim().Length==0)
			{
				strErr+="ALLOW_USED不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtSTART_DATE.Text))
			{
				strErr+="START_DATE格式错误！\\n";	
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
			string INTERNAL_CODE=this.txtINTERNAL_CODE.Text;
			string COMPANY_CODE=this.txtCOMPANY_CODE.Text;
			string DEPARTMENT_CODE=this.lblDEPARTMENT_CODE.Text;
			string DEPARTMENT_NAME=this.txtDEPARTMENT_NAME.Text;
			string PARENT_DEPARTMENT_CODE=this.txtPARENT_DEPARTMENT_CODE.Text;
			string MANAGER=this.txtMANAGER.Text;
			string TELEPHONE=this.txtTELEPHONE.Text;
			string ADDRESS=this.txtADDRESS.Text;
			string SHOP_NAME=this.txtSHOP_NAME.Text;
			decimal SETTLE_DATE=decimal.Parse(this.txtSETTLE_DATE.Text);
			decimal SIZE=decimal.Parse(this.txtSIZE.Text);
			string EMAIL=this.txtEMAIL.Text;
			string FAX=this.txtFAX.Text;
			decimal DISCOUNT=decimal.Parse(this.txtDISCOUNT.Text);
			decimal SHIP=decimal.Parse(this.txtSHIP.Text);
			int PPRICE_SHOW=int.Parse(this.txtPPRICE_SHOW.Text);
			string SALE_METHOD=this.txtSALE_METHOD.Text;
			string ALLOW_USED=this.txtALLOW_USED.Text;
			DateTime START_DATE=DateTime.Parse(this.txtSTART_DATE.Text);
			string CREATE_NAME=this.txtCREATE_NAME.Text;
			DateTime CREATE_DATE=DateTime.Parse(this.txtCREATE_DATE.Text);
			string UPDATE_NAME=this.txtUPDATE_NAME.Text;
			DateTime UPDATE_DATE=DateTime.Parse(this.txtUPDATE_DATE.Text);
			string REMARK=this.txtREMARK.Text;


			MyERP.Model.PUB_DEPARTMENT model=new MyERP.Model.PUB_DEPARTMENT();
			model.INTERNAL_CODE=INTERNAL_CODE;
			model.COMPANY_CODE=COMPANY_CODE;
			model.DEPARTMENT_CODE=DEPARTMENT_CODE;
			model.DEPARTMENT_NAME=DEPARTMENT_NAME;
			model.PARENT_DEPARTMENT_CODE=PARENT_DEPARTMENT_CODE;
			model.MANAGER=MANAGER;
			model.TELEPHONE=TELEPHONE;
			model.ADDRESS=ADDRESS;
			model.SHOP_NAME=SHOP_NAME;
			model.SETTLE_DATE=SETTLE_DATE;
			model.SIZE=SIZE;
			model.EMAIL=EMAIL;
			model.FAX=FAX;
			model.DISCOUNT=DISCOUNT;
			model.SHIP=SHIP;
			model.PPRICE_SHOW=PPRICE_SHOW;
			model.SALE_METHOD=SALE_METHOD;
			model.ALLOW_USED=ALLOW_USED;
			model.START_DATE=START_DATE;
			model.CREATE_NAME=CREATE_NAME;
			model.CREATE_DATE=CREATE_DATE;
			model.UPDATE_NAME=UPDATE_NAME;
			model.UPDATE_DATE=UPDATE_DATE;
			model.REMARK=REMARK;

			MyERP.BLL.PUB_DEPARTMENT bll=new MyERP.BLL.PUB_DEPARTMENT();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
