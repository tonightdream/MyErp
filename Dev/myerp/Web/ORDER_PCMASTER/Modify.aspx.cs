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
namespace MyERP.Web.ORDER_PCMASTER
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					string BillNo= Request.Params["id"];
					ShowInfo(BillNo);
				}
			}
		}
			
	private void ShowInfo(string BillNo)
	{
		MyERP.BLL.ORDER_PCMASTER bll=new MyERP.BLL.ORDER_PCMASTER();
		MyERP.Model.ORDER_PCMASTER model=bll.GetModel(BillNo);
		this.lblBillNo.Text=model.BillNo;
		this.txtBILL_DATE.Text=model.BILL_DATE;
		this.txtGROUP.Text=model.GROUP;
		this.txtMACHINE.Text=model.MACHINE;
		this.txtFACTORY.Text=model.FACTORY;
		this.txtBILL_STATUS.Text=model.BILL_STATUS.ToString();
		this.txtSTOCK_CODE.Text=model.STOCK_CODE;
		this.txtSTOCK_NAME.Text=model.STOCK_NAME;
		this.txtDEPARTMENT_CODE.Text=model.DEPARTMENT_CODE;
		this.txtDEPARTMENT_NAME.Text=model.DEPARTMENT_NAME;
		this.txtCREATE_CODE.Text=model.CREATE_CODE;
		this.txtCREATE_NAME.Text=model.CREATE_NAME;
		this.txtCREATE_DATE.Text=model.CREATE_DATE.ToString();
		this.txtREMARK.Text=model.REMARK;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtBILL_DATE.Text.Trim().Length==0)
			{
				strErr+="BILL_DATE不能为空！\\n";	
			}
			if(this.txtGROUP.Text.Trim().Length==0)
			{
				strErr+="GROUP不能为空！\\n";	
			}
			if(this.txtMACHINE.Text.Trim().Length==0)
			{
				strErr+="MACHINE不能为空！\\n";	
			}
			if(this.txtFACTORY.Text.Trim().Length==0)
			{
				strErr+="FACTORY不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtBILL_STATUS.Text))
			{
				strErr+="BILL_STATUS格式错误！\\n";	
			}
			if(this.txtSTOCK_CODE.Text.Trim().Length==0)
			{
				strErr+="STOCK_CODE不能为空！\\n";	
			}
			if(this.txtSTOCK_NAME.Text.Trim().Length==0)
			{
				strErr+="STOCK_NAME不能为空！\\n";	
			}
			if(this.txtDEPARTMENT_CODE.Text.Trim().Length==0)
			{
				strErr+="DEPARTMENT_CODE不能为空！\\n";	
			}
			if(this.txtDEPARTMENT_NAME.Text.Trim().Length==0)
			{
				strErr+="DEPARTMENT_NAME不能为空！\\n";	
			}
			if(this.txtCREATE_CODE.Text.Trim().Length==0)
			{
				strErr+="CREATE_CODE不能为空！\\n";	
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
			string BillNo=this.lblBillNo.Text;
			string BILL_DATE=this.txtBILL_DATE.Text;
			string GROUP=this.txtGROUP.Text;
			string MACHINE=this.txtMACHINE.Text;
			string FACTORY=this.txtFACTORY.Text;
			int BILL_STATUS=int.Parse(this.txtBILL_STATUS.Text);
			string STOCK_CODE=this.txtSTOCK_CODE.Text;
			string STOCK_NAME=this.txtSTOCK_NAME.Text;
			string DEPARTMENT_CODE=this.txtDEPARTMENT_CODE.Text;
			string DEPARTMENT_NAME=this.txtDEPARTMENT_NAME.Text;
			string CREATE_CODE=this.txtCREATE_CODE.Text;
			string CREATE_NAME=this.txtCREATE_NAME.Text;
			DateTime CREATE_DATE=DateTime.Parse(this.txtCREATE_DATE.Text);
			string REMARK=this.txtREMARK.Text;


			MyERP.Model.ORDER_PCMASTER model=new MyERP.Model.ORDER_PCMASTER();
			model.BillNo=BillNo;
			model.BILL_DATE=BILL_DATE;
			model.GROUP=GROUP;
			model.MACHINE=MACHINE;
			model.FACTORY=FACTORY;
			model.BILL_STATUS=BILL_STATUS;
			model.STOCK_CODE=STOCK_CODE;
			model.STOCK_NAME=STOCK_NAME;
			model.DEPARTMENT_CODE=DEPARTMENT_CODE;
			model.DEPARTMENT_NAME=DEPARTMENT_NAME;
			model.CREATE_CODE=CREATE_CODE;
			model.CREATE_NAME=CREATE_NAME;
			model.CREATE_DATE=CREATE_DATE;
			model.REMARK=REMARK;

			MyERP.BLL.ORDER_PCMASTER bll=new MyERP.BLL.ORDER_PCMASTER();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
