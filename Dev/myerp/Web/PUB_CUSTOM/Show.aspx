<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="MyERP.Web.PUB_CUSTOM.Show" Title="显示页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>                   
                    <td class="tdbg">
                               
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		CUSTOM_CODE
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblCUSTOM_CODE" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		CUSTOM_NAME
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblCUSTOM_NAME" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		CREDIT_LIMIT
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblCREDIT_LIMIT" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ORG_CODE
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblORG_CODE" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PARENT_CUSTOM_CODE
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPARENT_CUSTOM_CODE" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		CREDIT_AMOUNT
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblCREDIT_AMOUNT" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		CUSTOM_TYPE_CODE
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblCUSTOM_TYPE_CODE" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		FULL_NAME
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblFULL_NAME" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SALE_MAN
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSALE_MAN" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		FAX
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblFAX" runat="server"></asp:Label>
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
		TELPHIONE
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblTELPHIONE" runat="server"></asp:Label>
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
		VIPCARD_CODE
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblVIPCARD_CODE" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		VIPCARD_NAME
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblVIPCARD_NAME" runat="server"></asp:Label>
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
		CREATE_DATE
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblCREATE_DATE" runat="server"></asp:Label>
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
		UPDATE_DATE
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblUPDATE_DATE" runat="server"></asp:Label>
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




