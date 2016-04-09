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
namespace MyERP.Web.PUB_COMPANY
{
    public partial class Show : Page
    {        
        		public string strid=""; 
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
		MyERP.BLL.PUB_COMPANY bll=new MyERP.BLL.PUB_COMPANY();
		MyERP.Model.PUB_COMPANY model=bll.GetModel();
		this.lblCOMPANY_CODE.Text=model.COMPANY_CODE;
		this.lblCOMPANY_NAME.Text=model.COMPANY_NAME;
		this.lblCOMPANY_FULLNAME.Text=model.COMPANY_FULLNAME;
		this.lblPARENT_COMPANY_CODE.Text=model.PARENT_COMPANY_CODE;
		this.lblMANAGER.Text=model.MANAGER;
		this.lblADDRESS.Text=model.ADDRESS;
		this.lblTELPHONE.Text=model.TELPHONE;
		this.lblZIP.Text=model.ZIP;
		this.lblEMAIL.Text=model.EMAIL;
		this.lblHTTP.Text=model.HTTP;
		this.lblLICENSE.Text=model.LICENSE;
		this.lblREGISTER_BANK.Text=model.REGISTER_BANK;
		this.lblBANK_ACCOUNT.Text=model.BANK_ACCOUNT;
		this.lblALLOW_USED.Text=model.ALLOW_USED;
		this.lblREMARK.Text=model.REMARK;

	}


    }
}
