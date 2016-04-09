<%@ Page Title="ORDER_PCDETAIL" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="MyERP.Web.ORDER_PCDETAIL.List" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<script language="javascript" src="/js/CheckBox.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<!--Title -->

            <!--Title end -->

            <!--Add  -->

            <!--Add end -->

            <!--Search -->
            <table style="width: 100%;" cellpadding="2" cellspacing="1" class="border">
                <tr>
                    <td style="width: 80px" align="right" class="tdbg">
                         <b>关键字：</b>
                    </td>
                    <td class="tdbg">                       
                    <asp:TextBox ID="txtKeyword" runat="server"></asp:TextBox>
                    &nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnSearch" runat="server" Text="查询"  OnClick="btnSearch_Click" >
                    </asp:Button>                    
                        
                    </td>
                    <td class="tdbg">
                    </td>
                </tr>
            </table>
            <!--Search end-->
            <br />
            <asp:GridView ID="gridView" runat="server" AllowPaging="True" Width="100%" CellPadding="3"  OnPageIndexChanging ="gridView_PageIndexChanging"
                    BorderWidth="1px" DataKeyNames="" OnRowDataBound="gridView_RowDataBound"
                    AutoGenerateColumns="false" PageSize="10"  RowStyle-HorizontalAlign="Center" OnRowCreated="gridView_OnRowCreated">
                    <Columns>
                    <asp:TemplateField ControlStyle-Width="30" HeaderText="选择"    >
                                <ItemTemplate>
                                    <asp:CheckBox ID="DeleteThis" onclick="javascript:CCA(this);" runat="server" />
                                </ItemTemplate>
                            </asp:TemplateField> 
                            
		<asp:BoundField DataField="DETAILID" HeaderText="DETAILID" SortExpression="DETAILID" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="MASTERID" HeaderText="MASTERID" SortExpression="MASTERID" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="BILLNO" HeaderText="BILLNO" SortExpression="BILLNO" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Sequence" HeaderText="Sequence" SortExpression="Sequence" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ITEM_INTERNAL_CODE" HeaderText="ITEM_INTERNAL_CODE" SortExpression="ITEM_INTERNAL_CODE" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ITEM_CODE" HeaderText="ITEM_CODE" SortExpression="ITEM_CODE" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ITEM_CODE_old" HeaderText="ITEM_CODE_old" SortExpression="ITEM_CODE_old" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ITEM_NAME" HeaderText="ITEM_NAME" SortExpression="ITEM_NAME" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ITEM_COLOR" HeaderText="ITEM_COLOR" SortExpression="ITEM_COLOR" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="PARENT_ITEM_CODE" HeaderText="PARENT_ITEM_CODE" SortExpression="PARENT_ITEM_CODE" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ITEM_TYPE" HeaderText="ITEM_TYPE" SortExpression="ITEM_TYPE" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ITEM_LOGO" HeaderText="ITEM_LOGO" SortExpression="ITEM_LOGO" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ITEM_DESCRIPTION" HeaderText="ITEM_DESCRIPTION" SortExpression="ITEM_DESCRIPTION" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ITEM_CD" HeaderText="ITEM_CD" SortExpression="ITEM_CD" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ITEM_KD" HeaderText="ITEM_KD" SortExpression="ITEM_KD" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ITEM_GD" HeaderText="ITEM_GD" SortExpression="ITEM_GD" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ITEM_SPECIFICATIONS" HeaderText="ITEM_SPECIFICATIONS" SortExpression="ITEM_SPECIFICATIONS" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ITEM_MEASURE_UNIT" HeaderText="ITEM_MEASURE_UNIT" SortExpression="ITEM_MEASURE_UNIT" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ITEM_GYLC" HeaderText="ITEM_GYLC" SortExpression="ITEM_GYLC" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ITEM_POSITION" HeaderText="ITEM_POSITION" SortExpression="ITEM_POSITION" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ITEM_MIN_QTY" HeaderText="ITEM_MIN_QTY" SortExpression="ITEM_MIN_QTY" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ITEM_MAX_QTY" HeaderText="ITEM_MAX_QTY" SortExpression="ITEM_MAX_QTY" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ITEM_IMAGE" HeaderText="ITEM_IMAGE" SortExpression="ITEM_IMAGE" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ITEM_IMAGE_NAME" HeaderText="ITEM_IMAGE_NAME" SortExpression="ITEM_IMAGE_NAME" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ITEM_DWMJ" HeaderText="ITEM_DWMJ" SortExpression="ITEM_DWMJ" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ITEM_BARCODE" HeaderText="ITEM_BARCODE" SortExpression="ITEM_BARCODE" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="NET_PRICE" HeaderText="NET_PRICE" SortExpression="NET_PRICE" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="PRICE" HeaderText="PRICE" SortExpression="PRICE" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Quantity" HeaderText="Quantity" SortExpression="Quantity" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ORD_CGqty" HeaderText="ORD_CGqty" SortExpression="ORD_CGqty" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ORD_CLqty" HeaderText="ORD_CLqty" SortExpression="ORD_CLqty" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ORD_PCqty" HeaderText="ORD_PCqty" SortExpression="ORD_PCqty" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ORD_WGqty" HeaderText="ORD_WGqty" SortExpression="ORD_WGqty" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ORD_TCqty" HeaderText="ORD_TCqty" SortExpression="ORD_TCqty" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ORD_WGZL" HeaderText="ORD_WGZL" SortExpression="ORD_WGZL" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ORD_FPqty" HeaderText="ORD_FPqty" SortExpression="ORD_FPqty" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ORD_Sendqty" HeaderText="ORD_Sendqty" SortExpression="ORD_Sendqty" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ORD_SHqty" HeaderText="ORD_SHqty" SortExpression="ORD_SHqty" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ORD_LHqty" HeaderText="ORD_LHqty" SortExpression="ORD_LHqty" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ORD_HZqty" HeaderText="ORD_HZqty" SortExpression="ORD_HZqty" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ORD_THqty" HeaderText="ORD_THqty" SortExpression="ORD_THqty" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ORD_Acceptqty" HeaderText="ORD_Acceptqty" SortExpression="ORD_Acceptqty" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ORD_TL" HeaderText="ORD_TL" SortExpression="ORD_TL" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ORD_GRAPHICNO" HeaderText="ORD_GRAPHICNO" SortExpression="ORD_GRAPHICNO" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ORD_SHDH" HeaderText="ORD_SHDH" SortExpression="ORD_SHDH" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ORD_BZFS" HeaderText="ORD_BZFS" SortExpression="ORD_BZFS" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="REMARK" HeaderText="REMARK" SortExpression="REMARK" ItemStyle-HorizontalAlign="Center"  /> 
                            
                            <asp:HyperLinkField HeaderText="详细" ControlStyle-Width="50" DataNavigateUrlFields="" DataNavigateUrlFormatString="Show.aspx?"
                                Text="详细"  />
                            <asp:HyperLinkField HeaderText="编辑" ControlStyle-Width="50" DataNavigateUrlFields="" DataNavigateUrlFormatString="Modify.aspx?"
                                Text="编辑"  />
                            <asp:TemplateField ControlStyle-Width="50" HeaderText="删除"   Visible="false"  >
                                <ItemTemplate>
                                    <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Delete"
                                         Text="删除"></asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                </asp:GridView>
               <table border="0" cellpadding="0" cellspacing="1" style="width: 100%;">
                <tr>
                    <td style="width: 1px;">                        
                    </td>
                    <td align="left">
                        <asp:Button ID="btnDelete" runat="server" Text="删除" OnClick="btnDelete_Click"/>                       
                    </td>
                </tr>
            </table>
</asp:Content>
<%--<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceCheckright" runat="server">
</asp:Content>--%>
