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
namespace MyERP.Web.STEEL_RECEIPT_MASTER
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
		MyERP.BLL.STEEL_RECEIPT_MASTER bll=new MyERP.BLL.STEEL_RECEIPT_MASTER();
		MyERP.Model.STEEL_RECEIPT_MASTER model=bll.GetModel(BillNo);
		this.lblBillNo.Text=model.BillNo;
		this.txtMANUAL_BILLNO.Text=model.MANUAL_BILLNO;
		this.txtCOMPANY_CODE.Text=model.COMPANY_CODE;
		this.txtCOMPANY_NAME.Text=model.COMPANY_NAME;
		this.txtCUSTOM_CODE.Text=model.CUSTOM_CODE;
		this.txtCUSTOM_NAME.Text=model.CUSTOM_NAME;
		this.txtBILLTYPE.Text=model.BILLTYPE;
		this.txtBILL_STATUS.Text=model.BILL_STATUS;
		this.txtSTOCK_CODE.Text=model.STOCK_CODE;
		this.txtSTOCK_NAME.Text=model.STOCK_NAME;
		this.txtDEPARTMENT_CODE.Text=model.DEPARTMENT_CODE;
		this.txtDEPARTMENT_NAME.Text=model.DEPARTMENT_NAME;
		this.txtEMPLOYEE_CODE.Text=model.EMPLOYEE_CODE;
		this.txtEMPLOYEE_NAME.Text=model.EMPLOYEE_NAME;
		this.txtBILLDATE.Text=model.BILLDATE.ToString();
		this.txtCREATE_DATE.Text=model.CREATE_DATE.ToString();
		this.txtREMARK.Text=model.REMARK;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtMANUAL_BILLNO.Text.Trim().Length==0)
			{
				strErr+="MANUAL_BILLNO不能为空！\\n";	
			}
			if(this.txtCOMPANY_CODE.Text.Trim().Length==0)
			{
				strErr+="COMPANY_CODE不能为空！\\n";	
			}
			if(this.txtCOMPANY_NAME.Text.Trim().Length==0)
			{
				strErr+="COMPANY_NAME不能为空！\\n";	
			}
			if(this.txtCUSTOM_CODE.Text.Trim().Length==0)
			{
				strErr+="CUSTOM_CODE不能为空！\\n";	
			}
			if(this.txtCUSTOM_NAME.Text.Trim().Length==0)
			{
				strErr+="CUSTOM_NAME不能为空！\\n";	
			}
			if(this.txtBILLTYPE.Text.Trim().Length==0)
			{
				strErr+="BILLTYPE不能为空！\\n";	
			}
			if(this.txtBILL_STATUS.Text.Trim().Length==0)
			{
				strErr+="BILL_STATUS不能为空！\\n";	
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
			if(this.txtEMPLOYEE_CODE.Text.Trim().Length==0)
			{
				strErr+="EMPLOYEE_CODE不能为空！\\n";	
			}
			if(this.txtEMPLOYEE_NAME.Text.Trim().Length==0)
			{
				strErr+="EMPLOYEE_NAME不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtBILLDATE.Text))
			{
				strErr+="BILLDATE格式错误！\\n";	
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
			string MANUAL_BILLNO=this.txtMANUAL_BILLNO.Text;
			string COMPANY_CODE=this.txtCOMPANY_CODE.Text;
			string COMPANY_NAME=this.txtCOMPANY_NAME.Text;
			string CUSTOM_CODE=this.txtCUSTOM_CODE.Text;
			string CUSTOM_NAME=this.txtCUSTOM_NAME.Text;
			string BILLTYPE=this.txtBILLTYPE.Text;
			string BILL_STATUS=this.txtBILL_STATUS.Text;
			string STOCK_CODE=this.txtSTOCK_CODE.Text;
			string STOCK_NAME=this.txtSTOCK_NAME.Text;
			string DEPARTMENT_CODE=this.txtDEPARTMENT_CODE.Text;
			string DEPARTMENT_NAME=this.txtDEPARTMENT_NAME.Text;
			string EMPLOYEE_CODE=this.txtEMPLOYEE_CODE.Text;
			string EMPLOYEE_NAME=this.txtEMPLOYEE_NAME.Text;
			DateTime BILLDATE=DateTime.Parse(this.txtBILLDATE.Text);
			DateTime CREATE_DATE=DateTime.Parse(this.txtCREATE_DATE.Text);
			string REMARK=this.txtREMARK.Text;


			MyERP.Model.STEEL_RECEIPT_MASTER model=new MyERP.Model.STEEL_RECEIPT_MASTER();
			model.BillNo=BillNo;
			model.MANUAL_BILLNO=MANUAL_BILLNO;
			model.COMPANY_CODE=COMPANY_CODE;
			model.COMPANY_NAME=COMPANY_NAME;
			model.CUSTOM_CODE=CUSTOM_CODE;
			model.CUSTOM_NAME=CUSTOM_NAME;
			model.BILLTYPE=BILLTYPE;
			model.BILL_STATUS=BILL_STATUS;
			model.STOCK_CODE=STOCK_CODE;
			model.STOCK_NAME=STOCK_NAME;
			model.DEPARTMENT_CODE=DEPARTMENT_CODE;
			model.DEPARTMENT_NAME=DEPARTMENT_NAME;
			model.EMPLOYEE_CODE=EMPLOYEE_CODE;
			model.EMPLOYEE_NAME=EMPLOYEE_NAME;
			model.BILLDATE=BILLDATE;
			model.CREATE_DATE=CREATE_DATE;
			model.REMARK=REMARK;

			MyERP.BLL.STEEL_RECEIPT_MASTER bll=new MyERP.BLL.STEEL_RECEIPT_MASTER();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
