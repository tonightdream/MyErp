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
namespace MyERP.Web.VIP_GRADE
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
		MyERP.BLL.VIP_GRADE bll=new MyERP.BLL.VIP_GRADE();
		MyERP.Model.VIP_GRADE model=bll.GetModel();
		this.lblCOMPANY_CODE.Text=model.COMPANY_CODE;
		this.lblGRADE_CODE.Text=model.GRADE_CODE;
		this.lblGRADE_NAME.Text=model.GRADE_NAME;
		this.lblGRADE_TYPE.Text=model.GRADE_TYPE;
		this.lblindate.Text=model.indate.ToString();
		this.lbloutdate.Text=model.outdate.ToString();
		this.lblLOW_SALES.Text=model.LOW_SALES.ToString();
		this.lblTOTAL_SALES.Text=model.TOTAL_SALES.ToString();
		this.lblzsrgrade.Text=model.zsrgrade.ToString();
		this.lblstandrate.Text=model.standrate.ToString();
		this.lblspecialrate.Text=model.specialrate.ToString();
		this.lblbirthdayrate.Text=model.birthdayrate.ToString();
		this.lblbirthdayspsrate.Text=model.birthdayspsrate.ToString();
		this.lblyear_option.Text=model.year_option.ToString();
		this.lblrun.Text=model.run;
		this.lblCREATE_NAME.Text=model.CREATE_NAME;
		this.lblCREATE_DATE.Text=model.CREATE_DATE.ToString();
		this.lblUPDATE_NAME.Text=model.UPDATE_NAME;
		this.lblUPDATE_DATE.Text=model.UPDATE_DATE.ToString();
		this.lblREMARK.Text=model.REMARK;

	}


    }
}
