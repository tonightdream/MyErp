﻿<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeBehind="Add.aspx.cs" Inherits="MyERP.Web.ORDER_CG_DETAIL.Add" Title="增加页" %>

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
		<asp:TextBox id="txtSEQUENCE" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		MASTERID
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtMASTERID" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		DETAILID
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtDETAILID" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		BILLNO
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtBILLNO" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ITEM_INTERNAL_CODE
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtITEM_INTERNAL_CODE" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ITEM_CODE
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtITEM_CODE" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ITEM_NAME
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtITEM_NAME" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ITEM_COLOR
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtITEM_COLOR" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ITEM_TYPE
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtITEM_TYPE" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SPECIFICATIONS
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtSPECIFICATIONS" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		MEASURE_UNIT
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtMEASURE_UNIT" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ITEM_CZ
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtITEM_CZ" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ITEM_LH
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtITEM_LH" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ITEM_LK
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtITEM_LK" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ITEM_BJ
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtITEM_BJ" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ITEM_JZ
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtITEM_JZ" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ITEM_HZ
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtITEM_HZ" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ITEM_rate
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtITEM_rate" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ITEM_GYLC
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtITEM_GYLC" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		NET_PRICE
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtNET_PRICE" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PRICE
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtPRICE" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Quantity
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtQuantity" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		total_quantity
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txttotal_quantity" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ORD_TL
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtORD_TL" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		BARCODE
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtBARCODE" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		REMARK
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtREMARK" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
</table>

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
    <br />
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>
