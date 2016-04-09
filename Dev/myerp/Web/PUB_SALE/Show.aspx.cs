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
namespace MyERP.Web.PUB_SALE
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
		MyERP.BLL.PUB_SALE bll=new MyERP.BLL.PUB_SALE();
		MyERP.Model.PUB_SALE model=bll.GetModel();
		this.lblCompanyCode.Text=model.CompanyCode;
		this.lblEmployeCode.Text=model.EmployeCode;
		this.lblEmployeeName.Text=model.EmployeeName;
		this.lblDepartmentCode.Text=model.DepartmentCode;
		this.lblEmployeeType.Text=model.EmployeeType;
		this.lblIDCardNo.Text=model.IDCardNo;
		this.lblSociatyNo.Text=model.SociatyNo;
		this.lblSensusData.Text=model.SensusData;
		this.lblSex.Text=model.Sex;
		this.lblBirthDay.Text=model.BirthDay.ToString();
		this.lblDegree.Text=model.Degree;
		this.lblDegreeCard.Text=model.DegreeCard;
		this.lblHealth.Text=model.Health;
		this.lblHealthDate.Text=model.HealthDate.ToString();
		this.lblSpinsterhood.Text=model.Spinsterhood;
		this.lblSpinsterhoodDate.Text=model.SpinsterhoodDate.ToString();
		this.lblIdleness.Text=model.Idleness;
		this.lblIdlenessDate.Text=model.IdlenessDate.ToString();
		this.lblTitle.Text=model.Title;
		this.lblArrialDay.Text=model.ArrialDay.ToString();
		this.lblLeaveDay.Text=model.LeaveDay.ToString();
		this.lblPhone.Text=model.Phone;
		this.lblAddress.Text=model.Address;
		this.lblZip.Text=model.Zip;
		this.lblEmail.Text=model.Email;
		this.lblAllowUsed.Text=model.AllowUsed;
		this.lblSociatyCode.Text=model.SociatyCode;
		this.lblSociatyDate.Text=model.SociatyDate.ToString();
		this.lblSociatyPay.Text=model.SociatyPay.ToString();
		this.lblIndiSWBX.Text=model.IndiSWBX.ToString();
		this.lblIndiSYBX.Text=model.IndiSYBX.ToString();
		this.lblSociatyComp.Text=model.SociatyComp;
		this.lblRemark.Text=model.Remark;
		this.lblEmployeNo.Text=model.EmployeNo;
		this.lblWorkID.Text=model.WorkID;
		this.lblSituations.Text=model.Situations;
		this.lblHospitalPay.Text=model.HospitalPay;
		this.lblHospitalDate.Text=model.HospitalDate.ToString();
		this.lblContract.Text=model.Contract;
		this.lblContractDate.Text=model.ContractDate.ToString();
		this.lblPayMounth.Text=model.PayMounth;
		this.lblIsZB.Text=model.IsZB;
		this.lblIsBD.Text=model.IsBD;
		this.lblLastEdit.Text=model.LastEdit.ToString();

	}


    }
}
