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
namespace MyERP.Web.ORDER_COMPLAIN
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
		MyERP.BLL.ORDER_COMPLAIN bll=new MyERP.BLL.ORDER_COMPLAIN();
		MyERP.Model.ORDER_COMPLAIN model=bll.GetModel();
		this.lblINTERNAL_CODE.Text=model.INTERNAL_CODE;
		this.lblDEPARTMENT_CODE.Text=model.DEPARTMENT_CODE;
		this.lblDEPARTMENT_NAME.Text=model.DEPARTMENT_NAME;
		this.lblCUSTOM_CODE.Text=model.CUSTOM_CODE;
		this.lblCUSTOM_NAME.Text=model.CUSTOM_NAME;
		this.lblBILLNO.Text=model.BILLNO;
		this.lblITEM_CODE.Text=model.ITEM_CODE;
		this.lblITEM_NAME.Text=model.ITEM_NAME;
		this.lblMEASURE_UNIT.Text=model.MEASURE_UNIT;
		this.lblSPECIFICATIONS.Text=model.SPECIFICATIONS;
		this.lblIMAGE_NAME.Text=model.IMAGE_NAME;
		this.lblQUANTITY.Text=model.QUANTITY.ToString();
		this.lblCOMPLAIN_question.Text=model.COMPLAIN_question;
		this.lblUPDATE_question.Text=model.UPDATE_question;
		this.lblTracking_question.Text=model.Tracking_question;
		this.lblBEGIN_DATE.Text=model.BEGIN_DATE;
		this.lblEND_DATE.Text=model.END_DATE;
		this.lblBILL_STATUS.Text=model.BILL_STATUS;
		this.lblCREATE_NAME.Text=model.CREATE_NAME;
		this.lblCREATE_DATE.Text=model.CREATE_DATE.ToString();
		this.lblUPDATE_NAME.Text=model.UPDATE_NAME;
		this.lblUPDATE_DATE.Text=model.UPDATE_DATE.ToString();
		this.lblREMARK.Text=model.REMARK;

	}


    }
}
