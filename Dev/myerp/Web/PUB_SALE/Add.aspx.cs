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
using Maticsoft.Common;
using LTP.Accounts.Bus;
namespace MyERP.Web.PUB_SALE
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtCompanyCode.Text.Trim().Length==0)
			{
				strErr+="CompanyCode不能为空！\\n";	
			}
			if(this.txtEmployeCode.Text.Trim().Length==0)
			{
				strErr+="EmployeCode不能为空！\\n";	
			}
			if(this.txtEmployeeName.Text.Trim().Length==0)
			{
				strErr+="EmployeeName不能为空！\\n";	
			}
			if(this.txtDepartmentCode.Text.Trim().Length==0)
			{
				strErr+="DepartmentCode不能为空！\\n";	
			}
			if(this.txtEmployeeType.Text.Trim().Length==0)
			{
				strErr+="EmployeeType不能为空！\\n";	
			}
			if(this.txtIDCardNo.Text.Trim().Length==0)
			{
				strErr+="IDCardNo不能为空！\\n";	
			}
			if(this.txtSociatyNo.Text.Trim().Length==0)
			{
				strErr+="SociatyNo不能为空！\\n";	
			}
			if(this.txtSensusData.Text.Trim().Length==0)
			{
				strErr+="SensusData不能为空！\\n";	
			}
			if(this.txtSex.Text.Trim().Length==0)
			{
				strErr+="Sex不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtBirthDay.Text))
			{
				strErr+="BirthDay格式错误！\\n";	
			}
			if(this.txtDegree.Text.Trim().Length==0)
			{
				strErr+="Degree不能为空！\\n";	
			}
			if(this.txtDegreeCard.Text.Trim().Length==0)
			{
				strErr+="DegreeCard不能为空！\\n";	
			}
			if(this.txtHealth.Text.Trim().Length==0)
			{
				strErr+="Health不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtHealthDate.Text))
			{
				strErr+="HealthDate格式错误！\\n";	
			}
			if(this.txtSpinsterhood.Text.Trim().Length==0)
			{
				strErr+="Spinsterhood不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtSpinsterhoodDate.Text))
			{
				strErr+="SpinsterhoodDate格式错误！\\n";	
			}
			if(this.txtIdleness.Text.Trim().Length==0)
			{
				strErr+="Idleness不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtIdlenessDate.Text))
			{
				strErr+="IdlenessDate格式错误！\\n";	
			}
			if(this.txtTitle.Text.Trim().Length==0)
			{
				strErr+="Title不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtArrialDay.Text))
			{
				strErr+="ArrialDay格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtLeaveDay.Text))
			{
				strErr+="LeaveDay格式错误！\\n";	
			}
			if(this.txtPhone.Text.Trim().Length==0)
			{
				strErr+="Phone不能为空！\\n";	
			}
			if(this.txtAddress.Text.Trim().Length==0)
			{
				strErr+="Address不能为空！\\n";	
			}
			if(this.txtZip.Text.Trim().Length==0)
			{
				strErr+="Zip不能为空！\\n";	
			}
			if(this.txtEmail.Text.Trim().Length==0)
			{
				strErr+="Email不能为空！\\n";	
			}
			if(this.txtAllowUsed.Text.Trim().Length==0)
			{
				strErr+="AllowUsed不能为空！\\n";	
			}
			if(this.txtSociatyCode.Text.Trim().Length==0)
			{
				strErr+="SociatyCode不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtSociatyDate.Text))
			{
				strErr+="SociatyDate格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtSociatyPay.Text))
			{
				strErr+="SociatyPay格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtIndiSWBX.Text))
			{
				strErr+="IndiSWBX格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtIndiSYBX.Text))
			{
				strErr+="IndiSYBX格式错误！\\n";	
			}
			if(this.txtSociatyComp.Text.Trim().Length==0)
			{
				strErr+="SociatyComp不能为空！\\n";	
			}
			if(this.txtRemark.Text.Trim().Length==0)
			{
				strErr+="Remark不能为空！\\n";	
			}
			if(this.txtEmployeNo.Text.Trim().Length==0)
			{
				strErr+="EmployeNo不能为空！\\n";	
			}
			if(this.txtWorkID.Text.Trim().Length==0)
			{
				strErr+="WorkID不能为空！\\n";	
			}
			if(this.txtSituations.Text.Trim().Length==0)
			{
				strErr+="Situations不能为空！\\n";	
			}
			if(this.txtHospitalPay.Text.Trim().Length==0)
			{
				strErr+="HospitalPay不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtHospitalDate.Text))
			{
				strErr+="HospitalDate格式错误！\\n";	
			}
			if(this.txtContract.Text.Trim().Length==0)
			{
				strErr+="Contract不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtContractDate.Text))
			{
				strErr+="ContractDate格式错误！\\n";	
			}
			if(this.txtPayMounth.Text.Trim().Length==0)
			{
				strErr+="PayMounth不能为空！\\n";	
			}
			if(this.txtIsZB.Text.Trim().Length==0)
			{
				strErr+="IsZB不能为空！\\n";	
			}
			if(this.txtIsBD.Text.Trim().Length==0)
			{
				strErr+="IsBD不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string CompanyCode=this.txtCompanyCode.Text;
			string EmployeCode=this.txtEmployeCode.Text;
			string EmployeeName=this.txtEmployeeName.Text;
			string DepartmentCode=this.txtDepartmentCode.Text;
			string EmployeeType=this.txtEmployeeType.Text;
			string IDCardNo=this.txtIDCardNo.Text;
			string SociatyNo=this.txtSociatyNo.Text;
			string SensusData=this.txtSensusData.Text;
			string Sex=this.txtSex.Text;
			DateTime BirthDay=DateTime.Parse(this.txtBirthDay.Text);
			string Degree=this.txtDegree.Text;
			string DegreeCard=this.txtDegreeCard.Text;
			string Health=this.txtHealth.Text;
			DateTime HealthDate=DateTime.Parse(this.txtHealthDate.Text);
			string Spinsterhood=this.txtSpinsterhood.Text;
			DateTime SpinsterhoodDate=DateTime.Parse(this.txtSpinsterhoodDate.Text);
			string Idleness=this.txtIdleness.Text;
			DateTime IdlenessDate=DateTime.Parse(this.txtIdlenessDate.Text);
			string Title=this.txtTitle.Text;
			DateTime ArrialDay=DateTime.Parse(this.txtArrialDay.Text);
			DateTime LeaveDay=DateTime.Parse(this.txtLeaveDay.Text);
			string Phone=this.txtPhone.Text;
			string Address=this.txtAddress.Text;
			string Zip=this.txtZip.Text;
			string Email=this.txtEmail.Text;
			string AllowUsed=this.txtAllowUsed.Text;
			string SociatyCode=this.txtSociatyCode.Text;
			DateTime SociatyDate=DateTime.Parse(this.txtSociatyDate.Text);
			decimal SociatyPay=decimal.Parse(this.txtSociatyPay.Text);
			decimal IndiSWBX=decimal.Parse(this.txtIndiSWBX.Text);
			decimal IndiSYBX=decimal.Parse(this.txtIndiSYBX.Text);
			string SociatyComp=this.txtSociatyComp.Text;
			string Remark=this.txtRemark.Text;
			string EmployeNo=this.txtEmployeNo.Text;
			string WorkID=this.txtWorkID.Text;
			string Situations=this.txtSituations.Text;
			string HospitalPay=this.txtHospitalPay.Text;
			DateTime HospitalDate=DateTime.Parse(this.txtHospitalDate.Text);
			string Contract=this.txtContract.Text;
			DateTime ContractDate=DateTime.Parse(this.txtContractDate.Text);
			string PayMounth=this.txtPayMounth.Text;
			string IsZB=this.txtIsZB.Text;
			string IsBD=this.txtIsBD.Text;
			byte[] LastEdit= new UnicodeEncoding().GetBytes(this.txtLastEdit.Text);

			MyERP.Model.PUB_SALE model=new MyERP.Model.PUB_SALE();
			model.CompanyCode=CompanyCode;
			model.EmployeCode=EmployeCode;
			model.EmployeeName=EmployeeName;
			model.DepartmentCode=DepartmentCode;
			model.EmployeeType=EmployeeType;
			model.IDCardNo=IDCardNo;
			model.SociatyNo=SociatyNo;
			model.SensusData=SensusData;
			model.Sex=Sex;
			model.BirthDay=BirthDay;
			model.Degree=Degree;
			model.DegreeCard=DegreeCard;
			model.Health=Health;
			model.HealthDate=HealthDate;
			model.Spinsterhood=Spinsterhood;
			model.SpinsterhoodDate=SpinsterhoodDate;
			model.Idleness=Idleness;
			model.IdlenessDate=IdlenessDate;
			model.Title=Title;
			model.ArrialDay=ArrialDay;
			model.LeaveDay=LeaveDay;
			model.Phone=Phone;
			model.Address=Address;
			model.Zip=Zip;
			model.Email=Email;
			model.AllowUsed=AllowUsed;
			model.SociatyCode=SociatyCode;
			model.SociatyDate=SociatyDate;
			model.SociatyPay=SociatyPay;
			model.IndiSWBX=IndiSWBX;
			model.IndiSYBX=IndiSYBX;
			model.SociatyComp=SociatyComp;
			model.Remark=Remark;
			model.EmployeNo=EmployeNo;
			model.WorkID=WorkID;
			model.Situations=Situations;
			model.HospitalPay=HospitalPay;
			model.HospitalDate=HospitalDate;
			model.Contract=Contract;
			model.ContractDate=ContractDate;
			model.PayMounth=PayMounth;
			model.IsZB=IsZB;
			model.IsBD=IsBD;
			model.LastEdit=LastEdit;

			MyERP.BLL.PUB_SALE bll=new MyERP.BLL.PUB_SALE();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
