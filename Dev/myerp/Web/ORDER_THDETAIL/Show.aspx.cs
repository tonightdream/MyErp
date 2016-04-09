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
namespace MyERP.Web.ORDER_THDETAIL
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
		MyERP.BLL.ORDER_THDETAIL bll=new MyERP.BLL.ORDER_THDETAIL();
		MyERP.Model.ORDER_THDETAIL model=bll.GetModel();
		this.lblDetailID.Text=model.DetailID.ToString();
		this.lblBillNo.Text=model.BillNo;
		this.lblSequence.Text=model.Sequence;
		this.lblItemInternalCode.Text=model.ItemInternalCode;
		this.lblZXBJNO.Text=model.ZXBJNO;
		this.lblSHDH.Text=model.SHDH;
		this.lblQuantity.Text=model.Quantity.ToString();
		this.lblTHRQ.Text=model.THRQ;
		this.lblCREATE_NAME.Text=model.CREATE_NAME;
		this.lblCREATE_DATE.Text=model.CREATE_DATE.ToString();
		this.lblREMARK.Text=model.REMARK;

	}


    }
}
