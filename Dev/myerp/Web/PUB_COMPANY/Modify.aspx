<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Modify.aspx.cs" Inherits="MyERP.Web.PUB_COMPANY.Modify" Title="修改页" %>
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
		<asp:TextBox id="txtCOMPANY_CODE" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		COMPANY_NAME
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtCOMPANY_NAME" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		COMPANY_FULLNAME
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtCOMPANY_FULLNAME" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PARENT_COMPANY_CODE
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtPARENT_COMPANY_CODE" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		MANAGER
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtMANAGER" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ADDRESS
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtADDRESS" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		TELPHONE
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtTELPHONE" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ZIP
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtZIP" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		EMAIL
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtEMAIL" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		HTTP
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtHTTP" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		LICENSE
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtLICENSE" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		REGISTER_BANK
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtREGISTER_BANK" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		BANK_ACCOUNT
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtBANK_ACCOUNT" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ALLOW_USED
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtALLOW_USED" runat="server" Width="200px"></asp:TextBox>
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
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>

