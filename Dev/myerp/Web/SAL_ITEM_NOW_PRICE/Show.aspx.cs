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
namespace MyERP.Web.SAL_ITEM_NOW_PRICE
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
		MyERP.BLL.SAL_ITEM_NOW_PRICE bll=new MyERP.BLL.SAL_ITEM_NOW_PRICE();
		MyERP.Model.SAL_ITEM_NOW_PRICE model=bll.GetModel();
		this.lblCompanyCode.Text=model.CompanyCode;
		this.lblItemNo.Text=model.ItemNo;
		this.lblColor.Text=model.Color;
		this.lblItemInternalCode.Text=model.ItemInternalCode;
		this.lblInternalCodeMean.Text=model.InternalCodeMean;
		this.lblAllPrice.Text=model.AllPrice.ToString();
		this.lblWholeSalePrice.Text=model.WholeSalePrice.ToString();
		this.lblOncePrice.Text=model.OncePrice.ToString();
		this.lblMeasureUnit.Text=model.MeasureUnit;
		this.lblLastEdit.Text=model.LastEdit.ToString();

	}


    }
}
