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
namespace MyERP.Web.STEEL_GG_BOM
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
			if(!PageValidate.IsNumber(txtSEQUENCE.Text))
			{
				strErr+="SEQUENCE格式错误！\\n";	
			}
			if(this.txtITEM_INTERNAL_CODE.Text.Trim().Length==0)
			{
				strErr+="ITEM_INTERNAL_CODE不能为空！\\n";	
			}
			if(this.txtITEM_CODE.Text.Trim().Length==0)
			{
				strErr+="ITEM_CODE不能为空！\\n";	
			}
			if(this.txtITEM_NAME.Text.Trim().Length==0)
			{
				strErr+="ITEM_NAME不能为空！\\n";	
			}
			if(this.txtSPECIFICATIONS.Text.Trim().Length==0)
			{
				strErr+="SPECIFICATIONS不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtKD.Text))
			{
				strErr+="KD格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtQUANTITY.Text))
			{
				strErr+="QUANTITY格式错误！\\n";	
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
			int SEQUENCE=int.Parse(this.txtSEQUENCE.Text);
			string ITEM_INTERNAL_CODE=this.txtITEM_INTERNAL_CODE.Text;
			string ITEM_CODE=this.txtITEM_CODE.Text;
			string ITEM_NAME=this.txtITEM_NAME.Text;
			string SPECIFICATIONS=this.txtSPECIFICATIONS.Text;
			decimal KD=decimal.Parse(this.txtKD.Text);
			decimal QUANTITY=decimal.Parse(this.txtQUANTITY.Text);
			string CREATE_NAME=this.txtCREATE_NAME.Text;
			DateTime CREATE_DATE=DateTime.Parse(this.txtCREATE_DATE.Text);
			string UPDATE_NAME=this.txtUPDATE_NAME.Text;
			DateTime UPDATE_DATE=DateTime.Parse(this.txtUPDATE_DATE.Text);
			string REMARK=this.txtREMARK.Text;

			MyERP.Model.STEEL_GG_BOM model=new MyERP.Model.STEEL_GG_BOM();
			model.INTERNAL_CODE=INTERNAL_CODE;
			model.SEQUENCE=SEQUENCE;
			model.ITEM_INTERNAL_CODE=ITEM_INTERNAL_CODE;
			model.ITEM_CODE=ITEM_CODE;
			model.ITEM_NAME=ITEM_NAME;
			model.SPECIFICATIONS=SPECIFICATIONS;
			model.KD=KD;
			model.QUANTITY=QUANTITY;
			model.CREATE_NAME=CREATE_NAME;
			model.CREATE_DATE=CREATE_DATE;
			model.UPDATE_NAME=UPDATE_NAME;
			model.UPDATE_DATE=UPDATE_DATE;
			model.REMARK=REMARK;

			MyERP.BLL.STEEL_GG_BOM bll=new MyERP.BLL.STEEL_GG_BOM();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
