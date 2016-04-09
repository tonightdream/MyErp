<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="MyERP.Web.SAL_CUSTOM.Show" Title="显示页" %>
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
		CustomerCode
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblCustomerCode" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		CustomerLevel
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblCustomerLevel" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Discount
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblDiscount" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		DiscountGrade
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblDiscountGrade" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		TradeAmount
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblTradeAmount" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		TradeAmountDate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblTradeAmountDate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		TradeGrade
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblTradeGrade" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		DueAmount
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblDueAmount" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		DueAmountDate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblDueAmountDate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		DueGrade
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblDueGrade" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		DueTime
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblDueTime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		DueTimeGrade
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblDueTimeGrade" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		DueTimeDate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblDueTimeDate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Remark
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblRemark" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




