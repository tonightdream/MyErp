<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="MyERP.Web.PUB_SALE.Show" Title="显示页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>                   
                    <td class="tdbg">
                               
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		CompanyCode
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblCompanyCode" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		EmployeCode
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblEmployeCode" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		EmployeeName
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblEmployeeName" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		DepartmentCode
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblDepartmentCode" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		EmployeeType
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblEmployeeType" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		IDCardNo
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblIDCardNo" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SociatyNo
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSociatyNo" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SensusData
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSensusData" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Sex
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSex" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		BirthDay
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblBirthDay" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Degree
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblDegree" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		DegreeCard
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblDegreeCard" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Health
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblHealth" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		HealthDate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblHealthDate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Spinsterhood
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSpinsterhood" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SpinsterhoodDate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSpinsterhoodDate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Idleness
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblIdleness" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		IdlenessDate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblIdlenessDate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Title
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblTitle" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ArrialDay
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblArrialDay" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		LeaveDay
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblLeaveDay" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Phone
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPhone" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Address
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblAddress" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Zip
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblZip" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Email
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblEmail" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		AllowUsed
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblAllowUsed" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SociatyCode
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSociatyCode" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SociatyDate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSociatyDate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SociatyPay
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSociatyPay" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		IndiSWBX
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblIndiSWBX" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		IndiSYBX
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblIndiSYBX" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SociatyComp
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSociatyComp" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Remark
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblRemark" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		EmployeNo
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblEmployeNo" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		WorkID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblWorkID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Situations
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSituations" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		HospitalPay
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblHospitalPay" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		HospitalDate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblHospitalDate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Contract
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblContract" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ContractDate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblContractDate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PayMounth
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPayMounth" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		IsZB
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblIsZB" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		IsBD
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblIsBD" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		LastEdit
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblLastEdit" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




