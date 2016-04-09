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
namespace MyERP.Web.ORDER_SEND_SHD
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
		MyERP.BLL.ORDER_SEND_SHD bll=new MyERP.BLL.ORDER_SEND_SHD();
		MyERP.Model.ORDER_SEND_SHD model=bll.GetModel();
		this.lblBillNo.Text=model.BillNo;
		this.lblBILL_DATE.Text=model.BILL_DATE.ToString();
		this.lblCUSTOM_CODE.Text=model.CUSTOM_CODE;
		this.lblCUSTOM_NAME.Text=model.CUSTOM_NAME;
		this.lblPCBH.Text=model.PCBH;
		this.lblCLBH.Text=model.CLBH;
		this.lblSHJE.Text=model.SHJE.ToString();
		this.lblTHJE.Text=model.THJE.ToString();
		this.lblHZJE.Text=model.HZJE.ToString();
		this.lblLWKKJE.Text=model.LWKKJE.ToString();
		this.lblYSJE.Text=model.YSJE.ToString();
		this.lblAccepter.Text=model.Accepter;
		this.lblCREATE_NAME.Text=model.CREATE_NAME;
		this.lblCREATE_DATE.Text=model.CREATE_DATE.ToString();
		this.lblREMARK.Text=model.REMARK;

	}


    }
}
