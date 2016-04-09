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
namespace MyERP.Web.ORDER_SKJL
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				#warning 代码生成提示：显示页面,请检查确认该语句是否正确
				ShowInfo();
			}
		}
			
	private void ShowInfo()
	{
		MyERP.BLL.ORDER_SKJL bll=new MyERP.BLL.ORDER_SKJL();
		MyERP.Model.ORDER_SKJL model=bll.GetModel();
		this.txtBillNO.Text=model.BillNO;
		this.txtJZBH.Text=model.JZBH;
		this.txtSKJE.Text=model.SKJE.ToString();
		this.txtCREATE_NAME.Text=model.CREATE_NAME;
		this.txtCREATE_DATE.Text=model.CREATE_DATE.ToString();
		this.txtREMARK.Text=model.REMARK;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtBillNO.Text.Trim().Length==0)
			{
				strErr+="BillNO不能为空！\\n";	
			}
			if(this.txtJZBH.Text.Trim().Length==0)
			{
				strErr+="JZBH不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtSKJE.Text))
			{
				strErr+="SKJE格式错误！\\n";	
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
			string BillNO=this.txtBillNO.Text;
			string JZBH=this.txtJZBH.Text;
			decimal SKJE=decimal.Parse(this.txtSKJE.Text);
			string CREATE_NAME=this.txtCREATE_NAME.Text;
			DateTime CREATE_DATE=DateTime.Parse(this.txtCREATE_DATE.Text);
			string REMARK=this.txtREMARK.Text;


			MyERP.Model.ORDER_SKJL model=new MyERP.Model.ORDER_SKJL();
			model.BillNO=BillNO;
			model.JZBH=JZBH;
			model.SKJE=SKJE;
			model.CREATE_NAME=CREATE_NAME;
			model.CREATE_DATE=CREATE_DATE;
			model.REMARK=REMARK;

			MyERP.BLL.ORDER_SKJL bll=new MyERP.BLL.ORDER_SKJL();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
