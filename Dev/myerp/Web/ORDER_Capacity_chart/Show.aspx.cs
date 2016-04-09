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
namespace MyERP.Web.ORDER_Capacity_chart
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
		MyERP.BLL.ORDER_Capacity_chart bll=new MyERP.BLL.ORDER_Capacity_chart();
		MyERP.Model.ORDER_Capacity_chart model=bll.GetModel();
		this.lblINTERNAL_CODE.Text=model.INTERNAL_CODE;
		this.lblBILLDATE.Text=model.BILLDATE.ToString();
		this.lblDEPARTMENT_CODE.Text=model.DEPARTMENT_CODE;
		this.lblDEPARTMENT_NAME.Text=model.DEPARTMENT_NAME;
		this.lblQUANTITY.Text=model.QUANTITY.ToString();

	}


    }
}
