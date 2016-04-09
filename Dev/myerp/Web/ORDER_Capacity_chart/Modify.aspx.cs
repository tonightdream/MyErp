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
namespace MyERP.Web.ORDER_Capacity_chart
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
		MyERP.BLL.ORDER_Capacity_chart bll=new MyERP.BLL.ORDER_Capacity_chart();
		MyERP.Model.ORDER_Capacity_chart model=bll.GetModel();
		this.txtINTERNAL_CODE.Text=model.INTERNAL_CODE;
		this.txtBILLDATE.Text=model.BILLDATE.ToString();
		this.txtDEPARTMENT_CODE.Text=model.DEPARTMENT_CODE;
		this.txtDEPARTMENT_NAME.Text=model.DEPARTMENT_NAME;
		this.txtQUANTITY.Text=model.QUANTITY.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtINTERNAL_CODE.Text.Trim().Length==0)
			{
				strErr+="INTERNAL_CODE不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtBILLDATE.Text))
			{
				strErr+="BILLDATE格式错误！\\n";	
			}
			if(this.txtDEPARTMENT_CODE.Text.Trim().Length==0)
			{
				strErr+="DEPARTMENT_CODE不能为空！\\n";	
			}
			if(this.txtDEPARTMENT_NAME.Text.Trim().Length==0)
			{
				strErr+="DEPARTMENT_NAME不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtQUANTITY.Text))
			{
				strErr+="QUANTITY格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string INTERNAL_CODE=this.txtINTERNAL_CODE.Text;
			DateTime BILLDATE=DateTime.Parse(this.txtBILLDATE.Text);
			string DEPARTMENT_CODE=this.txtDEPARTMENT_CODE.Text;
			string DEPARTMENT_NAME=this.txtDEPARTMENT_NAME.Text;
			decimal QUANTITY=decimal.Parse(this.txtQUANTITY.Text);


			MyERP.Model.ORDER_Capacity_chart model=new MyERP.Model.ORDER_Capacity_chart();
			model.INTERNAL_CODE=INTERNAL_CODE;
			model.BILLDATE=BILLDATE;
			model.DEPARTMENT_CODE=DEPARTMENT_CODE;
			model.DEPARTMENT_NAME=DEPARTMENT_NAME;
			model.QUANTITY=QUANTITY;

			MyERP.BLL.ORDER_Capacity_chart bll=new MyERP.BLL.ORDER_Capacity_chart();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
