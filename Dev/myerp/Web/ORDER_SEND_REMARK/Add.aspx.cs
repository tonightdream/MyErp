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
namespace MyERP.Web.ORDER_SEND_REMARK
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
			if(!PageValidate.IsNumber(txtSequence.Text))
			{
				strErr+="Sequence格式错误！\\n";	
			}
			if(this.txtMANUAL_BILLNO.Text.Trim().Length==0)
			{
				strErr+="MANUAL_BILLNO不能为空！\\n";	
			}
			if(this.txtVehicle_CODE.Text.Trim().Length==0)
			{
				strErr+="Vehicle_CODE不能为空！\\n";	
			}
			if(this.txtVehicle_NAME.Text.Trim().Length==0)
			{
				strErr+="Vehicle_NAME不能为空！\\n";	
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
			string MASTERID=this.txtMASTERID.Text;
			string BILLNO=this.txtBILLNO.Text;
			int Sequence=int.Parse(this.txtSequence.Text);
			string MANUAL_BILLNO=this.txtMANUAL_BILLNO.Text;
			string Vehicle_CODE=this.txtVehicle_CODE.Text;
			string Vehicle_NAME=this.txtVehicle_NAME.Text;
			string STOCK_CODE=this.txtSTOCK_CODE.Text;
			string STOCK_NAME=this.txtSTOCK_NAME.Text;
			string DEPARTMENT_CODE=this.txtDEPARTMENT_CODE.Text;
			string DEPARTMENT_NAME=this.txtDEPARTMENT_NAME.Text;
			string CREATE_CODE=this.txtCREATE_CODE.Text;
			string CREATE_NAME=this.txtCREATE_NAME.Text;
			DateTime CREATE_DATE=DateTime.Parse(this.txtCREATE_DATE.Text);
			string REMARK=this.txtREMARK.Text;

			MyERP.Model.ORDER_SEND_REMARK model=new MyERP.Model.ORDER_SEND_REMARK();
			model.MASTERID=MASTERID;
			model.BILLNO=BILLNO;
			model.Sequence=Sequence;
			model.MANUAL_BILLNO=MANUAL_BILLNO;
			model.Vehicle_CODE=Vehicle_CODE;
			model.Vehicle_NAME=Vehicle_NAME;
			model.STOCK_CODE=STOCK_CODE;
			model.STOCK_NAME=STOCK_NAME;
			model.DEPARTMENT_CODE=DEPARTMENT_CODE;
			model.DEPARTMENT_NAME=DEPARTMENT_NAME;
			model.CREATE_CODE=CREATE_CODE;
			model.CREATE_NAME=CREATE_NAME;
			model.CREATE_DATE=CREATE_DATE;
			model.REMARK=REMARK;

			MyERP.BLL.ORDER_SEND_REMARK bll=new MyERP.BLL.ORDER_SEND_REMARK();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
