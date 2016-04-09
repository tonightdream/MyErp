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
namespace MyERP.Web.ORDER_ZXGG
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
		MyERP.BLL.ORDER_ZXGG bll=new MyERP.BLL.ORDER_ZXGG();
		MyERP.Model.ORDER_ZXGG model=bll.GetModel();
		this.lblINTERNAL_CODE.Text=model.INTERNAL_CODE;
		this.lblCUSTOM_CODE.Text=model.CUSTOM_CODE;
		this.lblCUSTOM_NAME.Text=model.CUSTOM_NAME;
		this.lblZXXXCode.Text=model.ZXXXCode;
		this.lblZXXXName.Text=model.ZXXXName;
		this.lblZXKDGS.Text=model.ZXKDGS;
		this.lblZXLENGS.Text=model.ZXLENGS;
		this.lblZXZK.Text=model.ZXZK.ToString();
		this.lblZXDT.Text=model.ZXDT.ToString();
		this.lblZXZBSL.Text=model.ZXZBSL.ToString();
		this.lblZXYZBJ.Text=model.ZXYZBJ;
		this.lblZXGZBJ.Text=model.ZXGZBJ;
		this.lblZXIMAGE.Text=model.ZXIMAGE.ToString();
		this.lblZXZK_cm.Text=model.ZXZK_cm.ToString();
		this.lblZXDT_cm.Text=model.ZXDT_cm.ToString();
		this.lblZXYxgs.Text=model.ZXYxgs;
		this.lblZXYXGD.Text=model.ZXYXGD;
		this.lblIMAGE_NAME.Text=model.IMAGE_NAME;
		this.lblCREATE_NAME.Text=model.CREATE_NAME;
		this.lblCREATE_DATE.Text=model.CREATE_DATE;
		this.lblUPDATE_NAME.Text=model.UPDATE_NAME;
		this.lblUPDATE_DATE.Text=model.UPDATE_DATE;

	}


    }
}
