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
namespace MyERP.Web.SAL_RECEIPT_MASTER
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtBillNO.Text.Trim().Length==0)
			{
				strErr+="BillNO不能为空！\\n";	
			}
			if(this.txtCOMPANY_CODE.Text.Trim().Length==0)
			{
				strErr+="COMPANY_CODE不能为空！\\n";	
			}
			if(this.txtCOMPANY_NAME.Text.Trim().Length==0)
			{
				strErr+="COMPANY_NAME不能为空！\\n";	
			}
			if(this.txtPARENT_COMPANY_CODE.Text.Trim().Length==0)
			{
				strErr+="PARENT_COMPANY_CODE不能为空！\\n";	
			}
			if(this.txtCUSTOM_CODE.Text.Trim().Length==0)
			{
				strErr+="CUSTOM_CODE不能为空！\\n";	
			}
			if(this.txtCUSTOM_NAME.Text.Trim().Length==0)
			{
				strErr+="CUSTOM_NAME不能为空！\\n";	
			}
			if(this.txtBillTYPE.Text.Trim().Length==0)
			{
				strErr+="BillTYPE不能为空！\\n";	
			}
			if(this.txtSTOCK_CODE.Text.Trim().Length==0)
			{
				strErr+="STOCK_CODE不能为空！\\n";	
			}
			if(this.txtSTOCK_NAME.Text.Trim().Length==0)
			{
				strErr+="STOCK_NAME不能为空！\\n";	
			}
			if(this.txtINSTOCK_CODE.Text.Trim().Length==0)
			{
				strErr+="INSTOCK_CODE不能为空！\\n";	
			}
			if(this.txtINSTOCK_NAME.Text.Trim().Length==0)
			{
				strErr+="INSTOCK_NAME不能为空！\\n";	
			}
			if(this.txtEMPLOYEE_CODE.Text.Trim().Length==0)
			{
				strErr+="EMPLOYEE_CODE不能为空！\\n";	
			}
			if(this.txtEMPLOYEE_NAME.Text.Trim().Length==0)
			{
				strErr+="EMPLOYEE_NAME不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtBillDate.Text))
			{
				strErr+="BillDate格式错误！\\n";	
			}
			if(this.txtBILL_STATUS.Text.Trim().Length==0)
			{
				strErr+="BILL_STATUS不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtPayAcount.Text))
			{
				strErr+="PayAcount格式错误！\\n";	
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
			string BillNO=this.txtBillNO.Text;
			string COMPANY_CODE=this.txtCOMPANY_CODE.Text;
			string COMPANY_NAME=this.txtCOMPANY_NAME.Text;
			string PARENT_COMPANY_CODE=this.txtPARENT_COMPANY_CODE.Text;
			string CUSTOM_CODE=this.txtCUSTOM_CODE.Text;
			string CUSTOM_NAME=this.txtCUSTOM_NAME.Text;
			string BillTYPE=this.txtBillTYPE.Text;
			string STOCK_CODE=this.txtSTOCK_CODE.Text;
			string STOCK_NAME=this.txtSTOCK_NAME.Text;
			string INSTOCK_CODE=this.txtINSTOCK_CODE.Text;
			string INSTOCK_NAME=this.txtINSTOCK_NAME.Text;
			string EMPLOYEE_CODE=this.txtEMPLOYEE_CODE.Text;
			string EMPLOYEE_NAME=this.txtEMPLOYEE_NAME.Text;
			DateTime BillDate=DateTime.Parse(this.txtBillDate.Text);
			string BILL_STATUS=this.txtBILL_STATUS.Text;
			decimal PayAcount=decimal.Parse(this.txtPayAcount.Text);
			string REMARK=this.txtREMARK.Text;

			MyERP.Model.SAL_RECEIPT_MASTER model=new MyERP.Model.SAL_RECEIPT_MASTER();
			model.BillNO=BillNO;
			model.COMPANY_CODE=COMPANY_CODE;
			model.COMPANY_NAME=COMPANY_NAME;
			model.PARENT_COMPANY_CODE=PARENT_COMPANY_CODE;
			model.CUSTOM_CODE=CUSTOM_CODE;
			model.CUSTOM_NAME=CUSTOM_NAME;
			model.BillTYPE=BillTYPE;
			model.STOCK_CODE=STOCK_CODE;
			model.STOCK_NAME=STOCK_NAME;
			model.INSTOCK_CODE=INSTOCK_CODE;
			model.INSTOCK_NAME=INSTOCK_NAME;
			model.EMPLOYEE_CODE=EMPLOYEE_CODE;
			model.EMPLOYEE_NAME=EMPLOYEE_NAME;
			model.BillDate=BillDate;
			model.BILL_STATUS=BILL_STATUS;
			model.PayAcount=PayAcount;
			model.REMARK=REMARK;

			MyERP.BLL.SAL_RECEIPT_MASTER bll=new MyERP.BLL.SAL_RECEIPT_MASTER();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
