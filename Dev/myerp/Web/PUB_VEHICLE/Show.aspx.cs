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
namespace MyERP.Web.PUB_VEHICLE
{
    public partial class Show : Page
    {        
        		public string strid=""; 
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					strid = Request.Params["id"];
					string Vehicle_CODE= strid;
					ShowInfo(Vehicle_CODE);
				}
			}
		}
		
	private void ShowInfo(string Vehicle_CODE)
	{
		MyERP.BLL.PUB_VEHICLE bll=new MyERP.BLL.PUB_VEHICLE();
		MyERP.Model.PUB_VEHICLE model=bll.GetModel(Vehicle_CODE);
		this.lblVehicleID.Text=model.VehicleID.ToString();
		this.lblVehicle_CODE.Text=model.Vehicle_CODE;
		this.lblVehicle_NAME.Text=model.Vehicle_NAME;
		this.lblMobilePhone.Text=model.MobilePhone;
		this.lblstandard_area.Text=model.standard_area.ToString();
		this.lblReal_area.Text=model.Real_area.ToString();
		this.lblweigth.Text=model.weigth.ToString();
		this.lblWithcar.Text=model.Withcar;
		this.lblCREATE_DATE.Text=model.CREATE_DATE;
		this.lblCREATE_NAME.Text=model.CREATE_NAME;
		this.lblUPDATE_DATE.Text=model.UPDATE_DATE.ToString();
		this.lblUPDATE_NAME.Text=model.UPDATE_NAME;
		this.lblREMARK.Text=model.REMARK;

	}


    }
}
