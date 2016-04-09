<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="MyERP.Web.PUB_COMPANY.Show" Title="显示页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>                   
                    <td class="tdbg">
                               
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
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
		COMPANY_FULLNAME
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblCOMPANY_FULLNAME" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PARENT_COMPANY_CODE
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPARENT_COMPANY_CODE" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		MANAGER
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblMANAGER" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ADDRESS
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblADDRESS" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		TELPHONE
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblTELPHONE" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ZIP
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblZIP" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		EMAIL
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblEMAIL" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		HTTP
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblHTTP" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		LICENSE
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblLICENSE" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		REGISTER_BANK
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblREGISTER_BANK" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		BANK_ACCOUNT
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblBANK_ACCOUNT" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ALLOW_USED
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblALLOW_USED" runat="server"></asp:Label>
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




