﻿<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="MyERP.Web.SAL_ITEM_STOCK_DETAIL_BEGIN.Show" Title="显示页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>                   
                    <td class="tdbg">
                               
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		STOCK_CODE
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSTOCK_CODE" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		STOCK_NAME
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSTOCK_NAME" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ITEM_INTERNAL_CODE
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblITEM_INTERNAL_CODE" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ITEM_CODE
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblITEM_CODE" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ITEM_NAME
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblITEM_NAME" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ACTUAL_QTY
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblACTUAL_QTY" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		CREATE_DATE
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblCREATE_DATE" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




