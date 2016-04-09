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
namespace MyERP.Web.ORDER_SEND_REMARK
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
		MyERP.BLL.ORDER_SEND_REMARK bll=new MyERP.BLL.ORDER_SEND_REMARK();
		MyERP.Model.ORDER_SEND_REMARK model=bll.GetModel();
		this.lblMASTERID.Text=model.MASTERID;
		this.lblBILLNO.Text=model.BILLNO;
		this.lblSequence.Text=model.Sequence.ToString();
		this.lblMANUAL_BILLNO.Text=model.MANUAL_BILLNO;
		this.lblVehicle_CODE.Text=model.Vehicle_CODE;
		this.lblVehicle_NAME.Text=model.Vehicle_NAME;
		this.lblSTOCK_CODE.Text=model.STOCK_CODE;
		this.lblSTOCK_NAME.Text=model.STOCK_NAME;
		this.lblDEPARTMENT_CODE.Text=model.DEPARTMENT_CODE;
		this.lblDEPARTMENT_NAME.Text=model.DEPARTMENT_NAME;
		this.lblCREATE_CODE.Text=model.CREATE_CODE;
		this.lblCREATE_NAME.Text=model.CREATE_NAME;
		this.lblCREATE_DATE.Text=model.CREATE_DATE.ToString();
		this.lblREMARK.Text=model.REMARK;

	}


    }
}
