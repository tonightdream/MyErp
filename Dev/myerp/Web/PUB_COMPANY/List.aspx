<%@ Page Title="PUB_COMPANY" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="MyERP.Web.PUB_COMPANY.List" %>
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
                            
		<asp:BoundField DataField="COMPANY_CODE" HeaderText="COMPANY_CODE" SortExpression="COMPANY_CODE" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="COMPANY_NAME" HeaderText="COMPANY_NAME" SortExpression="COMPANY_NAME" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="COMPANY_FULLNAME" HeaderText="COMPANY_FULLNAME" SortExpression="COMPANY_FULLNAME" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="PARENT_COMPANY_CODE" HeaderText="PARENT_COMPANY_CODE" SortExpression="PARENT_COMPANY_CODE" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="MANAGER" HeaderText="MANAGER" SortExpression="MANAGER" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ADDRESS" HeaderText="ADDRESS" SortExpression="ADDRESS" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="TELPHONE" HeaderText="TELPHONE" SortExpression="TELPHONE" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ZIP" HeaderText="ZIP" SortExpression="ZIP" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="EMAIL" HeaderText="EMAIL" SortExpression="EMAIL" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="HTTP" HeaderText="HTTP" SortExpression="HTTP" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="LICENSE" HeaderText="LICENSE" SortExpression="LICENSE" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="REGISTER_BANK" HeaderText="REGISTER_BANK" SortExpression="REGISTER_BANK" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="BANK_ACCOUNT" HeaderText="BANK_ACCOUNT" SortExpression="BANK_ACCOUNT" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ALLOW_USED" HeaderText="ALLOW_USED" SortExpression="ALLOW_USED" ItemStyle-HorizontalAlign="Center"  /> 
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
