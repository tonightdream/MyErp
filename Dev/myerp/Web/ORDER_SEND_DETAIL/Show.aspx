<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="MyERP.Web.ORDER_SEND_DETAIL.Show" Title="显示页" %>
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
		<asp:Label id="lblDETAILID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		MASTERID
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblMASTERID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		BILLNO
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblBILLNO" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Sequence
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSequence" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ITEM_INTERNAL_CODE
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblITEM_INTERNAL_CODE" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ITEM_CODE
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblITEM_CODE" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ITEM_NAME
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblITEM_NAME" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ITEM_COLOR
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblITEM_COLOR" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PARENT_ITEM_CODE
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPARENT_ITEM_CODE" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ITEM_TYPE
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblITEM_TYPE" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ITEM_CD
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblITEM_CD" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ITEM_KD
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblITEM_KD" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ITEM_GD
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblITEM_GD" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ITEM_SPECIFICATIONS
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblITEM_SPECIFICATIONS" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ITEM_MEASURE_UNIT
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblITEM_MEASURE_UNIT" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ITEM_GYLC
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblITEM_GYLC" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ITEM_POSITION
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblITEM_POSITION" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ITEM_MIN_QTY
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblITEM_MIN_QTY" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ITEM_MAX_QTY
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblITEM_MAX_QTY" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ITEM_IMAGE
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblITEM_IMAGE" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ITEM_IMAGE_NAME
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblITEM_IMAGE_NAME" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ITEM_DWMJ
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblITEM_DWMJ" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ITEM_BARCODE
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblITEM_BARCODE" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		NET_PRICE
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblNET_PRICE" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PRICE
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPRICE" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Quantity
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblQuantity" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ORD_CGqty
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblORD_CGqty" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ORD_CLqty
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblORD_CLqty" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ORD_PCqty
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblORD_PCqty" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ORD_WGqty
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblORD_WGqty" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ORD_TCqty
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblORD_TCqty" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ORD_WGZL
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblORD_WGZL" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ORD_FPqty
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblORD_FPqty" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ORD_Sendqty
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblORD_Sendqty" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ORD_SHqty
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblORD_SHqty" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ORD_LHqty
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblORD_LHqty" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ORD_HZqty
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblORD_HZqty" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ORD_THqty
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblORD_THqty" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ORD_Acceptqty
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblORD_Acceptqty" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ORD_TL
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblORD_TL" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ORD_GRAPHICNO
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblORD_GRAPHICNO" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ORD_SHDH
	：</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblORD_SHDH" runat="server"></asp:Label>
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




