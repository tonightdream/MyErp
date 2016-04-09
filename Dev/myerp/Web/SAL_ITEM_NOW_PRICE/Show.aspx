<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="MyERP.Web.SAL_ITEM_NOW_PRICE.Show" Title="显示页" %>
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
		ItemNo
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblItemNo" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Color
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblColor" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ItemInternalCode
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblItemInternalCode" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		InternalCodeMean
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblInternalCodeMean" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		AllPrice
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblAllPrice" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		WholeSalePrice
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblWholeSalePrice" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		OncePrice
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblOncePrice" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		MeasureUnit
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblMeasureUnit" runat="server"></asp:Label>
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




