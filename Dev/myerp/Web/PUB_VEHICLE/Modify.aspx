﻿<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Modify.aspx.cs" Inherits="MyERP.Web.PUB_VEHICLE.Modify" Title="修改页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">    
    <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
        <tr>
            <td class="tdbg">
                
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		VehicleID
	：</td>
	<td height="25" width="*" align="left">
		<asp:label id="lblVehicleID" runat="server"></asp:label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Vehicle_CODE
	：</td>
	<td height="25" width="*" align="left">
		<asp:label id="lblVehicle_CODE" runat="server"></asp:label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Vehicle_NAME
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtVehicle_NAME" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		MobilePhone
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtMobilePhone" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		standard_area
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtstandard_area" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Real_area
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtReal_area" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		weigth
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtweigth" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Withcar
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtWithcar" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		CREATE_DATE
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtCREATE_DATE" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		CREATE_NAME
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtCREATE_NAME" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		UPDATE_DATE
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox ID="txtUPDATE_DATE" runat="server" Width="70px"  onfocus="setday(this)"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		UPDATE_NAME
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtUPDATE_NAME" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		REMARK
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtREMARK" runat="server" Width="200px"></asp:TextBox>
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

