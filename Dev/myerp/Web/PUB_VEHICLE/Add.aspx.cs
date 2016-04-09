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
namespace MyERP.Web.PUB_VEHICLE
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtVehicle_CODE.Text.Trim().Length==0)
			{
				strErr+="Vehicle_CODE不能为空！\\n";	
			}
			if(this.txtVehicle_NAME.Text.Trim().Length==0)
			{
				strErr+="Vehicle_NAME不能为空！\\n";	
			}
			if(this.txtMobilePhone.Text.Trim().Length==0)
			{
				strErr+="MobilePhone不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtstandard_area.Text))
			{
				strErr+="standard_area格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtReal_area.Text))
			{
				strErr+="Real_area格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtweigth.Text))
			{
				strErr+="weigth格式错误！\\n";	
			}
			if(this.txtWithcar.Text.Trim().Length==0)
			{
				strErr+="Withcar不能为空！\\n";	
			}
			if(this.txtCREATE_DATE.Text.Trim().Length==0)
			{
				strErr+="CREATE_DATE不能为空！\\n";	
			}
			if(this.txtCREATE_NAME.Text.Trim().Length==0)
			{
				strErr+="CREATE_NAME不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtUPDATE_DATE.Text))
			{
				strErr+="UPDATE_DATE格式错误！\\n";	
			}
			if(this.txtUPDATE_NAME.Text.Trim().Length==0)
			{
				strErr+="UPDATE_NAME不能为空！\\n";	
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
			string Vehicle_CODE=this.txtVehicle_CODE.Text;
			string Vehicle_NAME=this.txtVehicle_NAME.Text;
			string MobilePhone=this.txtMobilePhone.Text;
			decimal standard_area=decimal.Parse(this.txtstandard_area.Text);
			decimal Real_area=decimal.Parse(this.txtReal_area.Text);
			decimal weigth=decimal.Parse(this.txtweigth.Text);
			string Withcar=this.txtWithcar.Text;
			string CREATE_DATE=this.txtCREATE_DATE.Text;
			string CREATE_NAME=this.txtCREATE_NAME.Text;
			DateTime UPDATE_DATE=DateTime.Parse(this.txtUPDATE_DATE.Text);
			string UPDATE_NAME=this.txtUPDATE_NAME.Text;
			string REMARK=this.txtREMARK.Text;

			MyERP.Model.PUB_VEHICLE model=new MyERP.Model.PUB_VEHICLE();
			model.Vehicle_CODE=Vehicle_CODE;
			model.Vehicle_NAME=Vehicle_NAME;
			model.MobilePhone=MobilePhone;
			model.standard_area=standard_area;
			model.Real_area=Real_area;
			model.weigth=weigth;
			model.Withcar=Withcar;
			model.CREATE_DATE=CREATE_DATE;
			model.CREATE_NAME=CREATE_NAME;
			model.UPDATE_DATE=UPDATE_DATE;
			model.UPDATE_NAME=UPDATE_NAME;
			model.REMARK=REMARK;

			MyERP.BLL.PUB_VEHICLE bll=new MyERP.BLL.PUB_VEHICLE();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
