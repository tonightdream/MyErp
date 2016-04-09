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
namespace MyERP.Web.ORDER_SEND_SHD
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtBillNo.Text.Trim().Length==0)
			{
				strErr+="BillNo不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtBILL_DATE.Text))
			{
				strErr+="BILL_DATE格式错误！\\n";	
			}
			if(this.txtCUSTOM_CODE.Text.Trim().Length==0)
			{
				strErr+="CUSTOM_CODE不能为空！\\n";	
			}
			if(this.txtCUSTOM_NAME.Text.Trim().Length==0)
			{
				strErr+="CUSTOM_NAME不能为空！\\n";	
			}
			if(this.txtPCBH.Text.Trim().Length==0)
			{
				strErr+="PCBH不能为空！\\n";	
			}
			if(this.txtCLBH.Text.Trim().Length==0)
			{
				strErr+="CLBH不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtSHJE.Text))
			{
				strErr+="SHJE格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtTHJE.Text))
			{
				strErr+="THJE格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtHZJE.Text))
			{
				strErr+="HZJE格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtLWKKJE.Text))
			{
				strErr+="LWKKJE格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtYSJE.Text))
			{
				strErr+="YSJE格式错误！\\n";	
			}
			if(this.txtAccepter.Text.Trim().Length==0)
			{
				strErr+="Accepter不能为空！\\n";	
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
			string BillNo=this.txtBillNo.Text;
			DateTime BILL_DATE=DateTime.Parse(this.txtBILL_DATE.Text);
			string CUSTOM_CODE=this.txtCUSTOM_CODE.Text;
			string CUSTOM_NAME=this.txtCUSTOM_NAME.Text;
			string PCBH=this.txtPCBH.Text;
			string CLBH=this.txtCLBH.Text;
			decimal SHJE=decimal.Parse(this.txtSHJE.Text);
			decimal THJE=decimal.Parse(this.txtTHJE.Text);
			decimal HZJE=decimal.Parse(this.txtHZJE.Text);
			decimal LWKKJE=decimal.Parse(this.txtLWKKJE.Text);
			decimal YSJE=decimal.Parse(this.txtYSJE.Text);
			string Accepter=this.txtAccepter.Text;
			string CREATE_NAME=this.txtCREATE_NAME.Text;
			DateTime CREATE_DATE=DateTime.Parse(this.txtCREATE_DATE.Text);
			string REMARK=this.txtREMARK.Text;

			MyERP.Model.ORDER_SEND_SHD model=new MyERP.Model.ORDER_SEND_SHD();
			model.BillNo=BillNo;
			model.BILL_DATE=BILL_DATE;
			model.CUSTOM_CODE=CUSTOM_CODE;
			model.CUSTOM_NAME=CUSTOM_NAME;
			model.PCBH=PCBH;
			model.CLBH=CLBH;
			model.SHJE=SHJE;
			model.THJE=THJE;
			model.HZJE=HZJE;
			model.LWKKJE=LWKKJE;
			model.YSJE=YSJE;
			model.Accepter=Accepter;
			model.CREATE_NAME=CREATE_NAME;
			model.CREATE_DATE=CREATE_DATE;
			model.REMARK=REMARK;

			MyERP.BLL.ORDER_SEND_SHD bll=new MyERP.BLL.ORDER_SEND_SHD();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
