<%@ Page Title="PUB_DEPARTMENT" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="MyERP.Web.PUB_DEPARTMENT.List" %>
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
                    BorderWidth="1px" DataKeyNames="DEPARTMENT_CODE" OnRowDataBound="gridView_RowDataBound"
                    AutoGenerateColumns="false" PageSize="10"  RowStyle-HorizontalAlign="Center" OnRowCreated="gridView_OnRowCreated">
                    <Columns>
                    <asp:TemplateField ControlStyle-Width="30" HeaderText="选择"    >
                                <ItemTemplate>
                                    <asp:CheckBox ID="DeleteThis" onclick="javascript:CCA(this);" runat="server" />
                                </ItemTemplate>
                            </asp:TemplateField> 
                            
		<asp:BoundField DataField="INTERNAL_CODE" HeaderText="INTERNAL_CODE" SortExpression="INTERNAL_CODE" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="COMPANY_CODE" HeaderText="COMPANY_CODE" SortExpression="COMPANY_CODE" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="DEPARTMENT_CODE" HeaderText="DEPARTMENT_CODE" SortExpression="DEPARTMENT_CODE" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="DEPARTMENT_NAME" HeaderText="DEPARTMENT_NAME" SortExpression="DEPARTMENT_NAME" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="PARENT_DEPARTMENT_CODE" HeaderText="PARENT_DEPARTMENT_CODE" SortExpression="PARENT_DEPARTMENT_CODE" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="MANAGER" HeaderText="MANAGER" SortExpression="MANAGER" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="TELEPHONE" HeaderText="TELEPHONE" SortExpression="TELEPHONE" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ADDRESS" HeaderText="ADDRESS" SortExpression="ADDRESS" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="SHOP_NAME" HeaderText="SHOP_NAME" SortExpression="SHOP_NAME" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="SETTLE_DATE" HeaderText="SETTLE_DATE" SortExpression="SETTLE_DATE" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="SIZE" HeaderText="SIZE" SortExpression="SIZE" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="EMAIL" HeaderText="EMAIL" SortExpression="EMAIL" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="FAX" HeaderText="FAX" SortExpression="FAX" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="DISCOUNT" HeaderText="DISCOUNT" SortExpression="DISCOUNT" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="SHIP" HeaderText="SHIP" SortExpression="SHIP" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="PPRICE_SHOW" HeaderText="PPRICE_SHOW" SortExpression="PPRICE_SHOW" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="SALE_METHOD" HeaderText="SALE_METHOD" SortExpression="SALE_METHOD" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ALLOW_USED" HeaderText="ALLOW_USED" SortExpression="ALLOW_USED" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="START_DATE" HeaderText="START_DATE" SortExpression="START_DATE" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="CREATE_NAME" HeaderText="CREATE_NAME" SortExpression="CREATE_NAME" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="CREATE_DATE" HeaderText="CREATE_DATE" SortExpression="CREATE_DATE" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="UPDATE_NAME" HeaderText="UPDATE_NAME" SortExpression="UPDATE_NAME" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="UPDATE_DATE" HeaderText="UPDATE_DATE" SortExpression="UPDATE_DATE" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="REMARK" HeaderText="REMARK" SortExpression="REMARK" ItemStyle-HorizontalAlign="Center"  /> 
                            
                            <asp:HyperLinkField HeaderText="详细" ControlStyle-Width="50" DataNavigateUrlFields="DEPARTMENT_CODE" DataNavigateUrlFormatString="Show.aspx?id={0}"
                                Text="详细"  />
                            <asp:HyperLinkField HeaderText="编辑" ControlStyle-Width="50" DataNavigateUrlFields="DEPARTMENT_CODE" DataNavigateUrlFormatString="Modify.aspx?id={0}"
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
