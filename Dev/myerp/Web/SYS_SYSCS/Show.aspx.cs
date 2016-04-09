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
namespace MyERP.Web.SYS_SYSCS
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
		MyERP.BLL.SYS_SYSCS bll=new MyERP.BLL.SYS_SYSCS();
		MyERP.Model.SYS_SYSCS model=bll.GetModel();
		this.lblCOMPANY_CODE.Text=model.COMPANY_CODE;
		this.lblCOMPANY_NAME.Text=model.COMPANY_NAME;
		this.lblFullName.Text=model.FullName;
		this.lblAddress.Text=model.Address;
		this.lblPhone.Text=model.Phone;
		this.lblEmail.Text=model.Email;
		this.lblFax.Text=model.Fax;
		this.lblSHDCNT.Text=model.SHDCNT.ToString();
		this.lblITEM_CODE_LENGTH.Text=model.ITEM_CODE_LENGTH;
		this.lblBillasstock.Text=model.Billasstock?"是":"否";
		this.lblMAYLH.Text=model.MAYLH;
		this.lblServiceTelphone.Text=model.ServiceTelphone;
		this.lblCREATE_NAME.Text=model.CREATE_NAME;
		this.lblCREATE_DATE.Text=model.CREATE_DATE;
		this.lblREMARK.Text=model.REMARK;

	}


    }
}
