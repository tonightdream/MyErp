﻿<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="MyERP.Web.CL_ITEM_STOCK_DETAIL.Show" Title="显示页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>                   
                    <td class="tdbg">
                               
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		SEQUENCE
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSEQUENCE" runat="server"></asp:Label>
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
		COMPANY_CODE
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblCOMPANY_CODE" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		COMPANY_NAME
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblCOMPANY_NAME" runat="server"></asp:Label>
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
		ITEM_CODE_old
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblITEM_CODE_old" runat="server"></asp:Label>
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
		ITEM_TYPE
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblITEM_TYPE" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ITEM_COLOR
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblITEM_COLOR" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		IMAGE
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblIMAGE" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PARENT_ITEM_CODE
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPARENT_ITEM_CODE" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		TYPE_NAME
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblTYPE_NAME" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SPECIFICATIONS
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSPECIFICATIONS" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ITEM_JZ
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblITEM_JZ" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ITEM_HZ
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblITEM_HZ" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ITEM_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblITEM_rate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ITEM_GYLC
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblITEM_GYLC" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		MEASURE_UNIT
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblMEASURE_UNIT" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		NET_PRICE
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblNET_PRICE" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PRICE
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPRICE" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		QTY
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblQTY" runat="server"></asp:Label>
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
		MIN_QTY
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblMIN_QTY" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		MAX_QTY
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblMAX_QTY" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SUPPLY_CODE
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSUPPLY_CODE" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SUPPLY_NAME
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSUPPLY_NAME" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		POSITION
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPOSITION" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		DESCRIPTION
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblDESCRIPTION" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		BARCODE
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblBARCODE" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		CREATE_DATE
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblCREATE_DATE" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		CREATE_NAME
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblCREATE_NAME" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		UPDATE_DATE
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblUPDATE_DATE" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		UPDATE_NAME
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblUPDATE_NAME" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		REMARK
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblREMARK" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




