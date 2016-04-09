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
namespace MyERP.Web.ORDER_CG_MASTER
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtMASTERID.Text.Trim().Length==0)
			{
				strErr+="MASTERID不能为空！\\n";	
			}
			if(this.txtBILLNO.Text.Trim().Length==0)
			{
				strErr+="BILLNO不能为空！\\n";	
			}
			if(this.txtMANUAL_BILLNO.Text.Trim().Length==0)
			{
				strErr+="MANUAL_BILLNO不能为空！\\n";	
			}
			if(this.txtCUSTOM_CODE.Text.Trim().Length==0)
			{
				strErr+="CUSTOM_CODE不能为空！\\n";	
			}
			if(this.txtCUSTOM_NAME.Text.Trim().Length==0)
			{
				strErr+="CUSTOM_NAME不能为空！\\n";	
			}
			if(this.txtFACTORY.Text.Trim().Length==0)
			{
				strErr+="FACTORY不能为空！\\n";	
			}
			if(this.txtBILL_TYPE.Text.Trim().Length==0)
			{
				strErr+="BILL_TYPE不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtBILL_DATE.Text))
			{
				strErr+="BILL_DATE格式错误！\\n";	
			}
			if(this.txtBILL_STATUS.Text.Trim().Length==0)
			{
				strErr+="BILL_STATUS不能为空！\\n";	
			}
			if(this.txtSCYQ.Text.Trim().Length==0)
			{
				strErr+="SCYQ不能为空！\\n";	
			}
			if(this.txtBZTYPE.Text.Trim().Length==0)
			{
				strErr+="BZTYPE不能为空！\\n";	
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
			if(this.txtREMARK1.Text.Trim().Length==0)
			{
				strErr+="REMARK1不能为空！\\n";	
			}
			if(this.txtREMARK2.Text.Trim().Length==0)
			{
				strErr+="REMARK2不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string MASTERID=this.txtMASTERID.Text;
			string BILLNO=this.txtBILLNO.Text;
			string MANUAL_BILLNO=this.txtMANUAL_BILLNO.Text;
			string CUSTOM_CODE=this.txtCUSTOM_CODE.Text;
			string CUSTOM_NAME=this.txtCUSTOM_NAME.Text;
			string FACTORY=this.txtFACTORY.Text;
			string BILL_TYPE=this.txtBILL_TYPE.Text;
			DateTime BILL_DATE=DateTime.Parse(this.txtBILL_DATE.Text);
			string BILL_STATUS=this.txtBILL_STATUS.Text;
			string SCYQ=this.txtSCYQ.Text;
			string BZTYPE=this.txtBZTYPE.Text;
			string STOCK_CODE=this.txtSTOCK_CODE.Text;
			string STOCK_NAME=this.txtSTOCK_NAME.Text;
			string DEPARTMENT_CODE=this.txtDEPARTMENT_CODE.Text;
			string DEPARTMENT_NAME=this.txtDEPARTMENT_NAME.Text;
			string CREATE_CODE=this.txtCREATE_CODE.Text;
			string CREATE_NAME=this.txtCREATE_NAME.Text;
			DateTime CREATE_DATE=DateTime.Parse(this.txtCREATE_DATE.Text);
			string REMARK=this.txtREMARK.Text;
			string REMARK1=this.txtREMARK1.Text;
			string REMARK2=this.txtREMARK2.Text;

			MyERP.Model.ORDER_CG_MASTER model=new MyERP.Model.ORDER_CG_MASTER();
			model.MASTERID=MASTERID;
			model.BILLNO=BILLNO;
			model.MANUAL_BILLNO=MANUAL_BILLNO;
			model.CUSTOM_CODE=CUSTOM_CODE;
			model.CUSTOM_NAME=CUSTOM_NAME;
			model.FACTORY=FACTORY;
			model.BILL_TYPE=BILL_TYPE;
			model.BILL_DATE=BILL_DATE;
			model.BILL_STATUS=BILL_STATUS;
			model.SCYQ=SCYQ;
			model.BZTYPE=BZTYPE;
			model.STOCK_CODE=STOCK_CODE;
			model.STOCK_NAME=STOCK_NAME;
			model.DEPARTMENT_CODE=DEPARTMENT_CODE;
			model.DEPARTMENT_NAME=DEPARTMENT_NAME;
			model.CREATE_CODE=CREATE_CODE;
			model.CREATE_NAME=CREATE_NAME;
			model.CREATE_DATE=CREATE_DATE;
			model.REMARK=REMARK;
			model.REMARK1=REMARK1;
			model.REMARK2=REMARK2;

			MyERP.BLL.ORDER_CG_MASTER bll=new MyERP.BLL.ORDER_CG_MASTER();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
