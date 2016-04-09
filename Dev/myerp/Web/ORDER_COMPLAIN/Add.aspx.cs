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
namespace MyERP.Web.ORDER_COMPLAIN
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtINTERNAL_CODE.Text.Trim().Length==0)
			{
				strErr+="INTERNAL_CODE不能为空！\\n";	
			}
			if(this.txtDEPARTMENT_CODE.Text.Trim().Length==0)
			{
				strErr+="DEPARTMENT_CODE不能为空！\\n";	
			}
			if(this.txtDEPARTMENT_NAME.Text.Trim().Length==0)
			{
				strErr+="DEPARTMENT_NAME不能为空！\\n";	
			}
			if(this.txtCUSTOM_CODE.Text.Trim().Length==0)
			{
				strErr+="CUSTOM_CODE不能为空！\\n";	
			}
			if(this.txtCUSTOM_NAME.Text.Trim().Length==0)
			{
				strErr+="CUSTOM_NAME不能为空！\\n";	
			}
			if(this.txtBILLNO.Text.Trim().Length==0)
			{
				strErr+="BILLNO不能为空！\\n";	
			}
			if(this.txtITEM_CODE.Text.Trim().Length==0)
			{
				strErr+="ITEM_CODE不能为空！\\n";	
			}
			if(this.txtITEM_NAME.Text.Trim().Length==0)
			{
				strErr+="ITEM_NAME不能为空！\\n";	
			}
			if(this.txtMEASURE_UNIT.Text.Trim().Length==0)
			{
				strErr+="MEASURE_UNIT不能为空！\\n";	
			}
			if(this.txtSPECIFICATIONS.Text.Trim().Length==0)
			{
				strErr+="SPECIFICATIONS不能为空！\\n";	
			}
			if(this.txtIMAGE_NAME.Text.Trim().Length==0)
			{
				strErr+="IMAGE_NAME不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtQUANTITY.Text))
			{
				strErr+="QUANTITY格式错误！\\n";	
			}
			if(this.txtCOMPLAIN_question.Text.Trim().Length==0)
			{
				strErr+="COMPLAIN_question不能为空！\\n";	
			}
			if(this.txtUPDATE_question.Text.Trim().Length==0)
			{
				strErr+="UPDATE_question不能为空！\\n";	
			}
			if(this.txtTracking_question.Text.Trim().Length==0)
			{
				strErr+="Tracking_question不能为空！\\n";	
			}
			if(this.txtBEGIN_DATE.Text.Trim().Length==0)
			{
				strErr+="BEGIN_DATE不能为空！\\n";	
			}
			if(this.txtEND_DATE.Text.Trim().Length==0)
			{
				strErr+="END_DATE不能为空！\\n";	
			}
			if(this.txtBILL_STATUS.Text.Trim().Length==0)
			{
				strErr+="BILL_STATUS不能为空！\\n";	
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
			string DEPARTMENT_CODE=this.txtDEPARTMENT_CODE.Text;
			string DEPARTMENT_NAME=this.txtDEPARTMENT_NAME.Text;
			string CUSTOM_CODE=this.txtCUSTOM_CODE.Text;
			string CUSTOM_NAME=this.txtCUSTOM_NAME.Text;
			string BILLNO=this.txtBILLNO.Text;
			string ITEM_CODE=this.txtITEM_CODE.Text;
			string ITEM_NAME=this.txtITEM_NAME.Text;
			string MEASURE_UNIT=this.txtMEASURE_UNIT.Text;
			string SPECIFICATIONS=this.txtSPECIFICATIONS.Text;
			string IMAGE_NAME=this.txtIMAGE_NAME.Text;
			decimal QUANTITY=decimal.Parse(this.txtQUANTITY.Text);
			string COMPLAIN_question=this.txtCOMPLAIN_question.Text;
			string UPDATE_question=this.txtUPDATE_question.Text;
			string Tracking_question=this.txtTracking_question.Text;
			string BEGIN_DATE=this.txtBEGIN_DATE.Text;
			string END_DATE=this.txtEND_DATE.Text;
			string BILL_STATUS=this.txtBILL_STATUS.Text;
			string CREATE_NAME=this.txtCREATE_NAME.Text;
			DateTime CREATE_DATE=DateTime.Parse(this.txtCREATE_DATE.Text);
			string UPDATE_NAME=this.txtUPDATE_NAME.Text;
			DateTime UPDATE_DATE=DateTime.Parse(this.txtUPDATE_DATE.Text);
			string REMARK=this.txtREMARK.Text;

			MyERP.Model.ORDER_COMPLAIN model=new MyERP.Model.ORDER_COMPLAIN();
			model.INTERNAL_CODE=INTERNAL_CODE;
			model.DEPARTMENT_CODE=DEPARTMENT_CODE;
			model.DEPARTMENT_NAME=DEPARTMENT_NAME;
			model.CUSTOM_CODE=CUSTOM_CODE;
			model.CUSTOM_NAME=CUSTOM_NAME;
			model.BILLNO=BILLNO;
			model.ITEM_CODE=ITEM_CODE;
			model.ITEM_NAME=ITEM_NAME;
			model.MEASURE_UNIT=MEASURE_UNIT;
			model.SPECIFICATIONS=SPECIFICATIONS;
			model.IMAGE_NAME=IMAGE_NAME;
			model.QUANTITY=QUANTITY;
			model.COMPLAIN_question=COMPLAIN_question;
			model.UPDATE_question=UPDATE_question;
			model.Tracking_question=Tracking_question;
			model.BEGIN_DATE=BEGIN_DATE;
			model.END_DATE=END_DATE;
			model.BILL_STATUS=BILL_STATUS;
			model.CREATE_NAME=CREATE_NAME;
			model.CREATE_DATE=CREATE_DATE;
			model.UPDATE_NAME=UPDATE_NAME;
			model.UPDATE_DATE=UPDATE_DATE;
			model.REMARK=REMARK;

			MyERP.BLL.ORDER_COMPLAIN bll=new MyERP.BLL.ORDER_COMPLAIN();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
