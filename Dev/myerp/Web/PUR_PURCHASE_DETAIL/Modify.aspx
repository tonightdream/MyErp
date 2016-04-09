<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Modify.aspx.cs" Inherits="MyERP.Web.PUR_PURCHASE_DETAIL.Modify" Title="修改页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">    
    <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
        <tr>
            <td class="tdbg">
                
<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		DETAILID
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtDETAILID" runat="server" Width="200px"></asp:TextBox>
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
		BILLNO
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtBILLNO" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Sequence
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtSequence" runat="server" Width="200px"></asp:TextBox>
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
		ITEM_CODE_old
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtITEM_CODE_old" runat="server" Width="200px"></asp:TextBox>
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
		PARENT_ITEM_CODE
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtPARENT_ITEM_CODE" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ITEM_CD
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtITEM_CD" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ITEM_KD
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtITEM_KD" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ITEM_GD
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtITEM_GD" runat="server" Width="200px"></asp:TextBox>
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
		ITEM_NAME
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtITEM_NAME" runat="server" Width="200px"></asp:TextBox>
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
		COLOR
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtCOLOR" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		IMAGE
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtIMAGE" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		DWMJ
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtDWMJ" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		DESCRIPTION
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtDESCRIPTION" runat="server" Width="200px"></asp:TextBox>
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
		PAYAMOUNT
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtPAYAMOUNT" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		TAX_RATE
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtTAX_RATE" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ORD_CGqty
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtORD_CGqty" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ORD_CLqty
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtORD_CLqty" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ORD_PCqty
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtORD_PCqty" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ORD_WGqty
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtORD_WGqty" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ORD_TCqty
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtORD_TCqty" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ORD_WGZL
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtORD_WGZL" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ORD_FPqty
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtORD_FPqty" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ORD_Sendqty
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtORD_Sendqty" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ORD_SHqty
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtORD_SHqty" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ORD_LHqty
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtORD_LHqty" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ORD_HZqty
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtORD_HZqty" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ORD_THqty
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtORD_THqty" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ORD_Acceptqty
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtORD_Acceptqty" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ORD_SHDH
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtORD_SHDH" runat="server" Width="200px"></asp:TextBox>
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

