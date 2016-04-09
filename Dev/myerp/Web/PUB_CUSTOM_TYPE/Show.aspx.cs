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
namespace MyERP.Web.PUB_CUSTOM_TYPE
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
		MyERP.BLL.PUB_CUSTOM_TYPE bll=new MyERP.BLL.PUB_CUSTOM_TYPE();
		MyERP.Model.PUB_CUSTOM_TYPE model=bll.GetModel();
		this.lblINTERNAL_CODE.Text=model.INTERNAL_CODE;
		this.lblTYPE_CODE.Text=model.TYPE_CODE;
		this.lblTYPE_NAME.Text=model.TYPE_NAME;
		this.lblCRDATE_NAME.Text=model.CRDATE_NAME;
		this.lblCREATE_DATE.Text=model.CREATE_DATE;
		this.lblUPDATE_NAME.Text=model.UPDATE_NAME;
		this.lblUPDATE_DATE.Text=model.UPDATE_DATE;
		this.lblREMARK.Text=model.REMARK;

	}


    }
}
