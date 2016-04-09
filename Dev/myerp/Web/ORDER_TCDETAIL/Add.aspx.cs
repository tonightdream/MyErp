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
namespace MyERP.Web.ORDER_TCDETAIL
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
			if(this.txtZXBJNAME.Text.Trim().Length==0)
			{
				strErr+="ZXBJNAME不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtQuantity.Text))
			{
				strErr+="Quantity格式错误！\\n";	
			}
			if(this.txtCREATE_DATE.Text.Trim().Length==0)
			{
				strErr+="CREATE_DATE不能为空！\\n";	
			}
			if(this.txtCREATE_NAME.Text.Trim().Length==0)
			{
				strErr+="CREATE_NAME不能为空！\\n";	
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
			string Sequence=this.txtSequence.Text;
			string ItemInternalCode=this.txtItemInternalCode.Text;
			string ZXBJNO=this.txtZXBJNO.Text;
			string ZXBJNAME=this.txtZXBJNAME.Text;
			int Quantity=int.Parse(this.txtQuantity.Text);
			string CREATE_DATE=this.txtCREATE_DATE.Text;
			string CREATE_NAME=this.txtCREATE_NAME.Text;
			string REMARK=this.txtREMARK.Text;

			MyERP.Model.ORDER_TCDETAIL model=new MyERP.Model.ORDER_TCDETAIL();
			model.BillNO=BillNO;
			model.Sequence=Sequence;
			model.ItemInternalCode=ItemInternalCode;
			model.ZXBJNO=ZXBJNO;
			model.ZXBJNAME=ZXBJNAME;
			model.Quantity=Quantity;
			model.CREATE_DATE=CREATE_DATE;
			model.CREATE_NAME=CREATE_NAME;
			model.REMARK=REMARK;

			MyERP.BLL.ORDER_TCDETAIL bll=new MyERP.BLL.ORDER_TCDETAIL();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
