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
namespace MyERP.Web.PUB_SUPPLY
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
		MyERP.BLL.PUB_SUPPLY bll=new MyERP.BLL.PUB_SUPPLY();
		MyERP.Model.PUB_SUPPLY model=bll.GetModel();
		this.lblINTERNAL_CODE.Text=model.INTERNAL_CODE;
		this.lblSUPPLY_CODE.Text=model.SUPPLY_CODE;
		this.lblSUPPLY_NAME.Text=model.SUPPLY_NAME;
		this.lblPARENT_SUPPLY_CODE.Text=model.PARENT_SUPPLY_CODE;
		this.lblTypeCode.Text=model.TypeCode;
		this.lblTypeName.Text=model.TypeName;
		this.lblTELPHONE.Text=model.TELPHONE;
		this.lblTELPHONE1.Text=model.TELPHONE1;
		this.lblFAX.Text=model.FAX;
		this.lblEMAIL.Text=model.EMAIL;
		this.lblFULLNAME.Text=model.FULLNAME;
		this.lblADDRESS.Text=model.ADDRESS;
		this.lblEASYCODE.Text=model.EASYCODE;
		this.lblContact_MAN.Text=model.Contact_MAN;
		this.lblCREATE_NAME.Text=model.CREATE_NAME;
		this.lblCREATE_DATE.Text=model.CREATE_DATE.ToString();
		this.lblUPDATE_NAME.Text=model.UPDATE_NAME;
		this.lblUPDATE_DATE.Text=model.UPDATE_DATE.ToString();
		this.lblALLOW_used.Text=model.ALLOW_used?"是":"否";
		this.lblREMARK.Text=model.REMARK;

	}


    }
}
