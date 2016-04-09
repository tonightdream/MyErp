<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="MyERP.Web.ORDER_YSJZ.Show" Title="显示页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>                   
                    <td class="tdbg">
                               
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		FDID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblFDID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		customcode
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcustomcode" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		customname
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcustomname" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SJJZ
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSJJZ" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		QZZK
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblQZZK" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		QZYS
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblQZYS" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		YSJE
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblYSJE" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		YSWS
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblYSWS" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		begindate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblbegindate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		enddate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblenddate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		createname
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcreatename" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		createdate
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblcreatedate" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		remark
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblremark" runat="server"></asp:Label>
	</td></tr>
</table>

                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>




