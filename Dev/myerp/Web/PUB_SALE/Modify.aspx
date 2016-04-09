<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Modify.aspx.cs" Inherits="MyERP.Web.PUB_SALE.Modify" Title="修改页" %>
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
		<asp:TextBox id="txtCompanyCode" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		EmployeCode
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtEmployeCode" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		EmployeeName
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtEmployeeName" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		DepartmentCode
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtDepartmentCode" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		EmployeeType
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtEmployeeType" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		IDCardNo
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtIDCardNo" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SociatyNo
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtSociatyNo" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SensusData
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtSensusData" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Sex
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtSex" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		BirthDay
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox ID="txtBirthDay" runat="server" Width="70px"  onfocus="setday(this)"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Degree
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtDegree" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		DegreeCard
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtDegreeCard" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Health
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtHealth" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		HealthDate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox ID="txtHealthDate" runat="server" Width="70px"  onfocus="setday(this)"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Spinsterhood
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtSpinsterhood" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SpinsterhoodDate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox ID="txtSpinsterhoodDate" runat="server" Width="70px"  onfocus="setday(this)"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Idleness
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtIdleness" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		IdlenessDate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox ID="txtIdlenessDate" runat="server" Width="70px"  onfocus="setday(this)"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Title
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtTitle" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ArrialDay
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox ID="txtArrialDay" runat="server" Width="70px"  onfocus="setday(this)"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		LeaveDay
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox ID="txtLeaveDay" runat="server" Width="70px"  onfocus="setday(this)"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Phone
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtPhone" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Address
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtAddress" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Zip
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtZip" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Email
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtEmail" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		AllowUsed
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtAllowUsed" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SociatyCode
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtSociatyCode" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SociatyDate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox ID="txtSociatyDate" runat="server" Width="70px"  onfocus="setday(this)"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SociatyPay
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtSociatyPay" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		IndiSWBX
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtIndiSWBX" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		IndiSYBX
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtIndiSYBX" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SociatyComp
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtSociatyComp" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Remark
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtRemark" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		EmployeNo
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtEmployeNo" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		WorkID
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtWorkID" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Situations
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtSituations" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		HospitalPay
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtHospitalPay" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		HospitalDate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox ID="txtHospitalDate" runat="server" Width="70px"  onfocus="setday(this)"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Contract
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtContract" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ContractDate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox ID="txtContractDate" runat="server" Width="70px"  onfocus="setday(this)"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PayMounth
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtPayMounth" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		IsZB
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtIsZB" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		IsBD
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtIsBD" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		LastEdit
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtLastEdit" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
</table>
<script src="/js/calendar1.js" type="text/javascript"></script>

            </td>
        </tr>
        <tr>
            <td class="tdbg" align="center" valign="bottom">
                <asp:Button ID="btnSave" runat="server" Text="保存"
                    OnClick="btnSave_Click" class="inputbutton" onmouseover="this.className='inputbutton_hover'"
                    onmouseout="this.className='inputbutton'"></asp:Button>
                <asp:Button ID="btnCancle" runat="server" Text="取消"
                    OnClick="btnCancle_Click" class="inputbutton" onmouseover="this.className='inputbutton_hover'"
                    onmouseout="this.className='inputbutton'"></asp:Button>
            </td>
        </tr>
    </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>

