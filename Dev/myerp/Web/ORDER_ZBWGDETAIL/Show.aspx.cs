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
namespace MyERP.Web.ORDER_ZBWGDETAIL
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
		MyERP.BLL.ORDER_ZBWGDETAIL bll=new MyERP.BLL.ORDER_ZBWGDETAIL();
		MyERP.Model.ORDER_ZBWGDETAIL model=bll.GetModel();
		this.lblDetailID.Text=model.DetailID.ToString();
		this.lblBillNO.Text=model.BillNO;
		this.lblSequence.Text=model.Sequence;
		this.lblItemInternalCode.Text=model.ItemInternalCode;
		this.lblZXBJNO.Text=model.ZXBJNO;
		this.lblZXBJNAME.Text=model.ZXBJNAME;
		this.lblQuantity.Text=model.Quantity.ToString();
		this.lblFPqty.Text=model.FPqty.ToString();
		this.lblCREATE_DATE.Text=model.CREATE_DATE;
		this.lblCREATE_NAME.Text=model.CREATE_NAME;
		this.lblREMARK.Text=model.REMARK;

	}


    }
}
