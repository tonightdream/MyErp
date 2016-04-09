<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeBehind="Add.aspx.cs" Inherits="MyERP.Web.PUR_PURCHASE_MASTER.Add" Title="增加页" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">    
    <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
        <tr>
            <td class="tdbg">
                
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		MASTERID
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtMASTERID" runat="server" Width="200px"></asp:TextBox>
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
		FACTORY
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtFACTORY" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		MANUAL_BILLNO
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtMANUAL_BILLNO" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SUPPLY_CODE
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtSUPPLY_CODE" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SUPPLY_NAME
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtSUPPLY_NAME" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		BILL_TYPE
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtBILL_TYPE" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		BILL_DATE
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox ID="txtBILL_DATE" runat="server" Width="70px"  onfocus="setday(this)"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		BILL_STATUS
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtBILL_STATUS" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SCYQ
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtSCYQ" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		BZTYPE
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtBZTYPE" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		STOCK_CODE
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtSTOCK_CODE" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		STOCK_NAME
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtSTOCK_NAME" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		DEPARTMENT_CODE
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtDEPARTMENT_CODE" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		DEPARTMENT_NAME
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtDEPARTMENT_NAME" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		CREATE_CODE
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtCREATE_CODE" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		CREATE_NAME
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtCREATE_NAME" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		CREATE_DATE
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox ID="txtCREATE_DATE" runat="server" Width="70px"  onfocus="setday(this)"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		UPDATE_NAME
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtUPDATE_NAME" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		UPDATE_DATE
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtUPDATE_DATE" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		REMARK
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtREMARK" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		REMARK1
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtREMARK1" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		REMARK2
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtREMARK2" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
</table>
<script src="/js/calendar1.js" type="text/javascript"></script>

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
