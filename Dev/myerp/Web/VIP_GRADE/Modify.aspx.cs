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
namespace MyERP.Web.VIP_GRADE
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
		MyERP.BLL.VIP_GRADE bll=new MyERP.BLL.VIP_GRADE();
		MyERP.Model.VIP_GRADE model=bll.GetModel();
		this.txtCOMPANY_CODE.Text=model.COMPANY_CODE;
		this.txtGRADE_CODE.Text=model.GRADE_CODE;
		this.txtGRADE_NAME.Text=model.GRADE_NAME;
		this.txtGRADE_TYPE.Text=model.GRADE_TYPE;
		this.txtindate.Text=model.indate.ToString();
		this.txtoutdate.Text=model.outdate.ToString();
		this.txtLOW_SALES.Text=model.LOW_SALES.ToString();
		this.txtTOTAL_SALES.Text=model.TOTAL_SALES.ToString();
		this.txtzsrgrade.Text=model.zsrgrade.ToString();
		this.txtstandrate.Text=model.standrate.ToString();
		this.txtspecialrate.Text=model.specialrate.ToString();
		this.txtbirthdayrate.Text=model.birthdayrate.ToString();
		this.txtbirthdayspsrate.Text=model.birthdayspsrate.ToString();
		this.txtyear_option.Text=model.year_option.ToString();
		this.txtrun.Text=model.run;
		this.txtCREATE_NAME.Text=model.CREATE_NAME;
		this.txtCREATE_DATE.Text=model.CREATE_DATE.ToString();
		this.txtUPDATE_NAME.Text=model.UPDATE_NAME;
		this.txtUPDATE_DATE.Text=model.UPDATE_DATE.ToString();
		this.txtREMARK.Text=model.REMARK;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtCOMPANY_CODE.Text.Trim().Length==0)
			{
				strErr+="COMPANY_CODE不能为空！\\n";	
			}
			if(this.txtGRADE_CODE.Text.Trim().Length==0)
			{
				strErr+="GRADE_CODE不能为空！\\n";	
			}
			if(this.txtGRADE_NAME.Text.Trim().Length==0)
			{
				strErr+="GRADE_NAME不能为空！\\n";	
			}
			if(this.txtGRADE_TYPE.Text.Trim().Length==0)
			{
				strErr+="GRADE_TYPE不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtindate.Text))
			{
				strErr+="indate格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtoutdate.Text))
			{
				strErr+="outdate格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtLOW_SALES.Text))
			{
				strErr+="LOW_SALES格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtTOTAL_SALES.Text))
			{
				strErr+="TOTAL_SALES格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtzsrgrade.Text))
			{
				strErr+="zsrgrade格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtstandrate.Text))
			{
				strErr+="standrate格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtspecialrate.Text))
			{
				strErr+="specialrate格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtbirthdayrate.Text))
			{
				strErr+="birthdayrate格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtbirthdayspsrate.Text))
			{
				strErr+="birthdayspsrate格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtyear_option.Text))
			{
				strErr+="year_option格式错误！\\n";	
			}
			if(this.txtrun.Text.Trim().Length==0)
			{
				strErr+="run不能为空！\\n";	
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
			string COMPANY_CODE=this.txtCOMPANY_CODE.Text;
			string GRADE_CODE=this.txtGRADE_CODE.Text;
			string GRADE_NAME=this.txtGRADE_NAME.Text;
			string GRADE_TYPE=this.txtGRADE_TYPE.Text;
			DateTime indate=DateTime.Parse(this.txtindate.Text);
			DateTime outdate=DateTime.Parse(this.txtoutdate.Text);
			decimal LOW_SALES=decimal.Parse(this.txtLOW_SALES.Text);
			decimal TOTAL_SALES=decimal.Parse(this.txtTOTAL_SALES.Text);
			decimal zsrgrade=decimal.Parse(this.txtzsrgrade.Text);
			decimal standrate=decimal.Parse(this.txtstandrate.Text);
			decimal specialrate=decimal.Parse(this.txtspecialrate.Text);
			decimal birthdayrate=decimal.Parse(this.txtbirthdayrate.Text);
			decimal birthdayspsrate=decimal.Parse(this.txtbirthdayspsrate.Text);
			decimal year_option=decimal.Parse(this.txtyear_option.Text);
			string run=this.txtrun.Text;
			string CREATE_NAME=this.txtCREATE_NAME.Text;
			DateTime CREATE_DATE=DateTime.Parse(this.txtCREATE_DATE.Text);
			string UPDATE_NAME=this.txtUPDATE_NAME.Text;
			DateTime UPDATE_DATE=DateTime.Parse(this.txtUPDATE_DATE.Text);
			string REMARK=this.txtREMARK.Text;


			MyERP.Model.VIP_GRADE model=new MyERP.Model.VIP_GRADE();
			model.COMPANY_CODE=COMPANY_CODE;
			model.GRADE_CODE=GRADE_CODE;
			model.GRADE_NAME=GRADE_NAME;
			model.GRADE_TYPE=GRADE_TYPE;
			model.indate=indate;
			model.outdate=outdate;
			model.LOW_SALES=LOW_SALES;
			model.TOTAL_SALES=TOTAL_SALES;
			model.zsrgrade=zsrgrade;
			model.standrate=standrate;
			model.specialrate=specialrate;
			model.birthdayrate=birthdayrate;
			model.birthdayspsrate=birthdayspsrate;
			model.year_option=year_option;
			model.run=run;
			model.CREATE_NAME=CREATE_NAME;
			model.CREATE_DATE=CREATE_DATE;
			model.UPDATE_NAME=UPDATE_NAME;
			model.UPDATE_DATE=UPDATE_DATE;
			model.REMARK=REMARK;

			MyERP.BLL.VIP_GRADE bll=new MyERP.BLL.VIP_GRADE();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
