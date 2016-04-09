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
namespace MyERP.Web.ORDER_THDETAIL
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
		MyERP.BLL.ORDER_THDETAIL bll=new MyERP.BLL.ORDER_THDETAIL();
		MyERP.Model.ORDER_THDETAIL model=bll.GetModel();
		this.lblDetailID.Text=model.DetailID.ToString();
		this.txtBillNo.Text=model.BillNo;
		this.txtSequence.Text=model.Sequence;
		this.txtItemInternalCode.Text=model.ItemInternalCode;
		this.txtZXBJNO.Text=model.ZXBJNO;
		this.txtSHDH.Text=model.SHDH;
		this.txtQuantity.Text=model.Quantity.ToString();
		this.txtTHRQ.Text=model.THRQ;
		this.txtCREATE_NAME.Text=model.CREATE_NAME;
		this.txtCREATE_DATE.Text=model.CREATE_DATE.ToString();
		this.txtREMARK.Text=model.REMARK;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtBillNo.Text.Trim().Length==0)
			{
				strErr+="BillNo不能为空！\\n";	
			}
			if(this.txtSequence.Text.Trim().Length==0)
			{
				strErr+="Sequence不能为空！\\n";	
			}
			if(this.txtItemInternalCode.Text.Trim().Length==0)
			{
				strErr+="ItemInternalCode不能为空！\\n";	
			}
			if(this.txtZXBJNO.Text.Trim().Length==0)
			{
				strErr+="ZXBJNO不能为空！\\n";	
			}
			if(this.txtSHDH.Text.Trim().Length==0)
			{
				strErr+="SHDH不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtQuantity.Text))
			{
				strErr+="Quantity格式错误！\\n";	
			}
			if(this.txtTHRQ.Text.Trim().Length==0)
			{
				strErr+="THRQ不能为空！\\n";	
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
			Guid DetailID= new Guid(this.lblDetailID.Text);
			string BillNo=this.txtBillNo.Text;
			string Sequence=this.txtSequence.Text;
			string ItemInternalCode=this.txtItemInternalCode.Text;
			string ZXBJNO=this.txtZXBJNO.Text;
			string SHDH=this.txtSHDH.Text;
			int Quantity=int.Parse(this.txtQuantity.Text);
			string THRQ=this.txtTHRQ.Text;
			string CREATE_NAME=this.txtCREATE_NAME.Text;
			DateTime CREATE_DATE=DateTime.Parse(this.txtCREATE_DATE.Text);
			string REMARK=this.txtREMARK.Text;


			MyERP.Model.ORDER_THDETAIL model=new MyERP.Model.ORDER_THDETAIL();
			model.DetailID=DetailID;
			model.BillNo=BillNo;
			model.Sequence=Sequence;
			model.ItemInternalCode=ItemInternalCode;
			model.ZXBJNO=ZXBJNO;
			model.SHDH=SHDH;
			model.Quantity=Quantity;
			model.THRQ=THRQ;
			model.CREATE_NAME=CREATE_NAME;
			model.CREATE_DATE=CREATE_DATE;
			model.REMARK=REMARK;

			MyERP.BLL.ORDER_THDETAIL bll=new MyERP.BLL.ORDER_THDETAIL();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
