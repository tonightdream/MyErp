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
namespace MyERP.Web.SYS_USER
{
    public partial class Show : Page
    {        
        		public string strid=""; 
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					strid = Request.Params["id"];
					string USER_CODE= strid;
					ShowInfo(USER_CODE);
				}
			}
		}
		
	private void ShowInfo(string USER_CODE)
	{
		MyERP.BLL.SYS_USER bll=new MyERP.BLL.SYS_USER();
		MyERP.Model.SYS_USER model=bll.GetModel(USER_CODE);
		this.lblUSER_CODE.Text=model.USER_CODE;
		this.lblCOMPANY_CODE.Text=model.COMPANY_CODE;
		this.lblCOMPANY_NAME.Text=model.COMPANY_NAME;
		this.lblUSER_NAME.Text=model.USER_NAME;
		this.lblSTOCK_CODE.Text=model.STOCK_CODE;
		this.lblSTOCK_NAME.Text=model.STOCK_NAME;
		this.lblDEPARTMENT_CODE.Text=model.DEPARTMENT_CODE;
		this.lblDEPARTMENT_NAME.Text=model.DEPARTMENT_NAME;
		this.lbldepartment.Text=model.department;
		this.lblPARENT_DEPARTMENT_CODE.Text=model.PARENT_DEPARTMENT_CODE;
		this.lblPPRICE_SHOW.Text=model.PPRICE_SHOW?"是":"否";
		this.lblPASSWORD.Text=model.PASSWORD;
		this.lblDescription.Text=model.Description;
		this.lblEmployeeCode.Text=model.EmployeeCode;
		this.lblAllowUsed.Text=model.AllowUsed;
		this.lblisLicenceAudit.Text=model.isLicenceAudit;
		this.lblUserType.Text=model.UserType;
		this.lblLastEdit.Text=model.LastEdit.ToString();
		this.lblAuditDate.Text=model.AuditDate.ToString();

	}


    }
}
