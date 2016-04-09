<%@ Page Title="ORDER_ZXGG" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="MyERP.Web.ORDER_ZXGG.List" %>
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
                            
		<asp:BoundField DataField="INTERNAL_CODE" HeaderText="INTERNAL_CODE" SortExpression="INTERNAL_CODE" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="CUSTOM_CODE" HeaderText="CUSTOM_CODE" SortExpression="CUSTOM_CODE" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="CUSTOM_NAME" HeaderText="CUSTOM_NAME" SortExpression="CUSTOM_NAME" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ZXXXCode" HeaderText="ZXXXCode" SortExpression="ZXXXCode" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ZXXXName" HeaderText="ZXXXName" SortExpression="ZXXXName" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ZXKDGS" HeaderText="ZXKDGS" SortExpression="ZXKDGS" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ZXLENGS" HeaderText="ZXLENGS" SortExpression="ZXLENGS" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ZXZK" HeaderText="ZXZK" SortExpression="ZXZK" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ZXDT" HeaderText="ZXDT" SortExpression="ZXDT" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ZXZBSL" HeaderText="ZXZBSL" SortExpression="ZXZBSL" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ZXYZBJ" HeaderText="ZXYZBJ" SortExpression="ZXYZBJ" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ZXGZBJ" HeaderText="ZXGZBJ" SortExpression="ZXGZBJ" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ZXIMAGE" HeaderText="ZXIMAGE" SortExpression="ZXIMAGE" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ZXZK_cm" HeaderText="ZXZK_cm" SortExpression="ZXZK_cm" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ZXDT_cm" HeaderText="ZXDT_cm" SortExpression="ZXDT_cm" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ZXYxgs" HeaderText="ZXYxgs" SortExpression="ZXYxgs" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ZXYXGD" HeaderText="ZXYXGD" SortExpression="ZXYXGD" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="IMAGE_NAME" HeaderText="IMAGE_NAME" SortExpression="IMAGE_NAME" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="CREATE_NAME" HeaderText="CREATE_NAME" SortExpression="CREATE_NAME" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="CREATE_DATE" HeaderText="CREATE_DATE" SortExpression="CREATE_DATE" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="UPDATE_NAME" HeaderText="UPDATE_NAME" SortExpression="UPDATE_NAME" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="UPDATE_DATE" HeaderText="UPDATE_DATE" SortExpression="UPDATE_DATE" ItemStyle-HorizontalAlign="Center"  /> 
                            
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
