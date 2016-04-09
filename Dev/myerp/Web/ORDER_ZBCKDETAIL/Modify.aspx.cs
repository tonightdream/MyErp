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
namespace MyERP.Web.ORDER_ZBCKDETAIL
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
		MyERP.BLL.ORDER_ZBCKDETAIL bll=new MyERP.BLL.ORDER_ZBCKDETAIL();
		MyERP.Model.ORDER_ZBCKDETAIL model=bll.GetModel();
		this.lblDetailID.Text=model.DetailID.ToString();
		this.txtBillNO.Text=model.BillNO;
		this.txtSequence.Text=model.Sequence.ToString();
		this.txtquantity.Text=model.quantity.ToString();
		this.txtCREATE_NAME.Text=model.CREATE_NAME;
		this.txtCREATE_DATE.Text=model.CREATE_DATE;
		this.txtREMARK.Text=model.REMARK;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtBillNO.Text.Trim().Length==0)
			{
				strErr+="BillNO不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtSequence.Text))
			{
				strErr+="Sequence格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtquantity.Text))
			{
				strErr+="quantity格式错误！\\n";	
			}
			if(this.txtCREATE_NAME.Text.Trim().Length==0)
			{
				strErr+="CREATE_NAME不能为空！\\n";	
			}
			if(this.txtCREATE_DATE.Text.Trim().Length==0)
			{
				strErr+="CREATE_DATE不能为空！\\n";	
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
			Guid DetailID= new Guid(this.lblDetailID.Text);
			string BillNO=this.txtBillNO.Text;
			int Sequence=int.Parse(this.txtSequence.Text);
			decimal quantity=decimal.Parse(this.txtquantity.Text);
			string CREATE_NAME=this.txtCREATE_NAME.Text;
			string CREATE_DATE=this.txtCREATE_DATE.Text;
			string REMARK=this.txtREMARK.Text;


			MyERP.Model.ORDER_ZBCKDETAIL model=new MyERP.Model.ORDER_ZBCKDETAIL();
			model.DetailID=DetailID;
			model.BillNO=BillNO;
			model.Sequence=Sequence;
			model.quantity=quantity;
			model.CREATE_NAME=CREATE_NAME;
			model.CREATE_DATE=CREATE_DATE;
			model.REMARK=REMARK;

			MyERP.BLL.ORDER_ZBCKDETAIL bll=new MyERP.BLL.ORDER_ZBCKDETAIL();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
