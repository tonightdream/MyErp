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
namespace MyERP.Web.ORDER_SEND_MASTER
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					string BILLNO= Request.Params["id"];
					ShowInfo(BILLNO);
				}
			}
		}
			
	private void ShowInfo(string BILLNO)
	{
		MyERP.BLL.ORDER_SEND_MASTER bll=new MyERP.BLL.ORDER_SEND_MASTER();
		MyERP.Model.ORDER_SEND_MASTER model=bll.GetModel(BILLNO);
		this.txtMASTERID.Text=model.MASTERID;
		this.lblBILLNO.Text=model.BILLNO;
		this.txtMANUAL_BILLNO.Text=model.MANUAL_BILLNO;
		this.txtVehicle_CODE.Text=model.Vehicle_CODE;
		this.txtVehicle_NAME.Text=model.Vehicle_NAME;
		this.txtCUSTOM_CODE.Text=model.CUSTOM_CODE;
		this.txtCUSTOM_NAME.Text=model.CUSTOM_NAME;
		this.txtBILL_DATE.Text=model.BILL_DATE.ToString();
		this.txtBILL_STATUS.Text=model.BILL_STATUS;
		this.txtNOW_STATUS.Text=model.NOW_STATUS;
		this.txtNOW_DATE.Text=model.NOW_DATE;
		this.txtSTOCK_CODE.Text=model.STOCK_CODE;
		this.txtSTOCK_NAME.Text=model.STOCK_NAME;
		this.txtDEPARTMENT_CODE.Text=model.DEPARTMENT_CODE;
		this.txtDEPARTMENT_NAME.Text=model.DEPARTMENT_NAME;
		this.txtFACTORY.Text=model.FACTORY;
		this.txtSALE_NAME.Text=model.SALE_NAME;
		this.txtCREATE_CODE.Text=model.CREATE_CODE;
		this.txtCREATE_NAME.Text=model.CREATE_NAME;
		this.txtCREATE_DATE.Text=model.CREATE_DATE.ToString();
		this.txtUPDATE_NAME.Text=model.UPDATE_NAME;
		this.txtUPDATE_DATE.Text=model.UPDATE_DATE.ToString();
		this.txtREMARK.Text=model.REMARK;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtMASTERID.Text.Trim().Length==0)
			{
				strErr+="MASTERID不能为空！\\n";	
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
			if(this.txtCUSTOM_CODE.Text.Trim().Length==0)
			{
				strErr+="CUSTOM_CODE不能为空！\\n";	
			}
			if(this.txtCUSTOM_NAME.Text.Trim().Length==0)
			{
				strErr+="CUSTOM_NAME不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtBILL_DATE.Text))
			{
				strErr+="BILL_DATE格式错误！\\n";	
			}
			if(this.txtBILL_STATUS.Text.Trim().Length==0)
			{
				strErr+="BILL_STATUS不能为空！\\n";	
			}
			if(this.txtNOW_STATUS.Text.Trim().Length==0)
			{
				strErr+="NOW_STATUS不能为空！\\n";	
			}
			if(this.txtNOW_DATE.Text.Trim().Length==0)
			{
				strErr+="NOW_DATE不能为空！\\n";	
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
			if(this.txtFACTORY.Text.Trim().Length==0)
			{
				strErr+="FACTORY不能为空！\\n";	
			}
			if(this.txtSALE_NAME.Text.Trim().Length==0)
			{
				strErr+="SALE_NAME不能为空！\\n";	
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
			string MASTERID=this.txtMASTERID.Text;
			string BILLNO=this.lblBILLNO.Text;
			string MANUAL_BILLNO=this.txtMANUAL_BILLNO.Text;
			string Vehicle_CODE=this.txtVehicle_CODE.Text;
			string Vehicle_NAME=this.txtVehicle_NAME.Text;
			string CUSTOM_CODE=this.txtCUSTOM_CODE.Text;
			string CUSTOM_NAME=this.txtCUSTOM_NAME.Text;
			DateTime BILL_DATE=DateTime.Parse(this.txtBILL_DATE.Text);
			string BILL_STATUS=this.txtBILL_STATUS.Text;
			string NOW_STATUS=this.txtNOW_STATUS.Text;
			string NOW_DATE=this.txtNOW_DATE.Text;
			string STOCK_CODE=this.txtSTOCK_CODE.Text;
			string STOCK_NAME=this.txtSTOCK_NAME.Text;
			string DEPARTMENT_CODE=this.txtDEPARTMENT_CODE.Text;
			string DEPARTMENT_NAME=this.txtDEPARTMENT_NAME.Text;
			string FACTORY=this.txtFACTORY.Text;
			string SALE_NAME=this.txtSALE_NAME.Text;
			string CREATE_CODE=this.txtCREATE_CODE.Text;
			string CREATE_NAME=this.txtCREATE_NAME.Text;
			DateTime CREATE_DATE=DateTime.Parse(this.txtCREATE_DATE.Text);
			string UPDATE_NAME=this.txtUPDATE_NAME.Text;
			DateTime UPDATE_DATE=DateTime.Parse(this.txtUPDATE_DATE.Text);
			string REMARK=this.txtREMARK.Text;


			MyERP.Model.ORDER_SEND_MASTER model=new MyERP.Model.ORDER_SEND_MASTER();
			model.MASTERID=MASTERID;
			model.BILLNO=BILLNO;
			model.MANUAL_BILLNO=MANUAL_BILLNO;
			model.Vehicle_CODE=Vehicle_CODE;
			model.Vehicle_NAME=Vehicle_NAME;
			model.CUSTOM_CODE=CUSTOM_CODE;
			model.CUSTOM_NAME=CUSTOM_NAME;
			model.BILL_DATE=BILL_DATE;
			model.BILL_STATUS=BILL_STATUS;
			model.NOW_STATUS=NOW_STATUS;
			model.NOW_DATE=NOW_DATE;
			model.STOCK_CODE=STOCK_CODE;
			model.STOCK_NAME=STOCK_NAME;
			model.DEPARTMENT_CODE=DEPARTMENT_CODE;
			model.DEPARTMENT_NAME=DEPARTMENT_NAME;
			model.FACTORY=FACTORY;
			model.SALE_NAME=SALE_NAME;
			model.CREATE_CODE=CREATE_CODE;
			model.CREATE_NAME=CREATE_NAME;
			model.CREATE_DATE=CREATE_DATE;
			model.UPDATE_NAME=UPDATE_NAME;
			model.UPDATE_DATE=UPDATE_DATE;
			model.REMARK=REMARK;

			MyERP.BLL.ORDER_SEND_MASTER bll=new MyERP.BLL.ORDER_SEND_MASTER();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
