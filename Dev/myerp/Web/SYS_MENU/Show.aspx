<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="MyERP.Web.SYS_MENU.Show" Title="显示页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>                   
                    <td class="tdbg">
                               
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		MENU_CODE
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblMENU_CODE" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		MENU_NAME
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblMENU_NAME" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		MenuID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblMenuID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		IMAGE_INDEX
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblIMAGE_INDEX" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		MENU_UNIT
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblMENU_UNIT" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PARENT_MENU_CODE
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPARENT_MENU_CODE" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SysSelect
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSysSelect" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




