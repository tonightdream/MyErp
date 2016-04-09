<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Modify.aspx.cs" Inherits="MyERP.Web.ORDER_ZXGG.Modify" Title="修改页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">    
    <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
        <tr>
            <td class="tdbg">
                
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		INTERNAL_CODE
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtINTERNAL_CODE" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		CUSTOM_CODE
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtCUSTOM_CODE" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		CUSTOM_NAME
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtCUSTOM_NAME" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ZXXXCode
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtZXXXCode" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ZXXXName
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtZXXXName" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ZXKDGS
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtZXKDGS" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ZXLENGS
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtZXLENGS" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ZXZK
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtZXZK" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ZXDT
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtZXDT" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ZXZBSL
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtZXZBSL" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ZXYZBJ
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtZXYZBJ" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ZXGZBJ
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtZXGZBJ" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ZXIMAGE
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtZXIMAGE" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ZXZK_cm
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtZXZK_cm" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ZXDT_cm
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtZXDT_cm" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ZXYxgs
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtZXYxgs" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ZXYXGD
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtZXYXGD" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		IMAGE_NAME
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtIMAGE_NAME" runat="server" Width="200px"></asp:TextBox>
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
		<asp:TextBox id="txtCREATE_DATE" runat="server" Width="200px"></asp:TextBox>
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

