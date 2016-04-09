<%@ Page Title="ORDER_YSJZ" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="MyERP.Web.ORDER_YSJZ.List" %>
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
                            
		<asp:BoundField DataField="FDID" HeaderText="FDID" SortExpression="FDID" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="customcode" HeaderText="customcode" SortExpression="customcode" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="customname" HeaderText="customname" SortExpression="customname" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="SJJZ" HeaderText="SJJZ" SortExpression="SJJZ" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="QZZK" HeaderText="QZZK" SortExpression="QZZK" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="QZYS" HeaderText="QZYS" SortExpression="QZYS" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="YSJE" HeaderText="YSJE" SortExpression="YSJE" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="YSWS" HeaderText="YSWS" SortExpression="YSWS" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="begindate" HeaderText="begindate" SortExpression="begindate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="enddate" HeaderText="enddate" SortExpression="enddate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="createname" HeaderText="createname" SortExpression="createname" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="createdate" HeaderText="createdate" SortExpression="createdate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="remark" HeaderText="remark" SortExpression="remark" ItemStyle-HorizontalAlign="Center"  /> 
                            
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
