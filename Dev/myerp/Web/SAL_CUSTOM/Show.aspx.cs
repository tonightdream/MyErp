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
namespace MyERP.Web.SAL_CUSTOM
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
		MyERP.BLL.SAL_CUSTOM bll=new MyERP.BLL.SAL_CUSTOM();
		MyERP.Model.SAL_CUSTOM model=bll.GetModel();
		this.lblCompanyCode.Text=model.CompanyCode;
		this.lblCustomerCode.Text=model.CustomerCode;
		this.lblCustomerLevel.Text=model.CustomerLevel;
		this.lblDiscount.Text=model.Discount.ToString();
		this.lblDiscountGrade.Text=model.DiscountGrade.ToString();
		this.lblTradeAmount.Text=model.TradeAmount.ToString();
		this.lblTradeAmountDate.Text=model.TradeAmountDate.ToString();
		this.lblTradeGrade.Text=model.TradeGrade.ToString();
		this.lblDueAmount.Text=model.DueAmount.ToString();
		this.lblDueAmountDate.Text=model.DueAmountDate.ToString();
		this.lblDueGrade.Text=model.DueGrade.ToString();
		this.lblDueTime.Text=model.DueTime.ToString();
		this.lblDueTimeGrade.Text=model.DueTimeGrade.ToString();
		this.lblDueTimeDate.Text=model.DueTimeDate.ToString();
		this.lblRemark.Text=model.Remark;

	}


    }
}
