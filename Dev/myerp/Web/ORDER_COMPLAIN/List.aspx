<%@ Page Title="ORDER_COMPLAIN" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="MyERP.Web.ORDER_COMPLAIN.List" %>
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
		<asp:BoundField DataField="DEPARTMENT_CODE" HeaderText="DEPARTMENT_CODE" SortExpression="DEPARTMENT_CODE" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="DEPARTMENT_NAME" HeaderText="DEPARTMENT_NAME" SortExpression="DEPARTMENT_NAME" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="CUSTOM_CODE" HeaderText="CUSTOM_CODE" SortExpression="CUSTOM_CODE" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="CUSTOM_NAME" HeaderText="CUSTOM_NAME" SortExpression="CUSTOM_NAME" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="BILLNO" HeaderText="BILLNO" SortExpression="BILLNO" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ITEM_CODE" HeaderText="ITEM_CODE" SortExpression="ITEM_CODE" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ITEM_NAME" HeaderText="ITEM_NAME" SortExpression="ITEM_NAME" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="MEASURE_UNIT" HeaderText="MEASURE_UNIT" SortExpression="MEASURE_UNIT" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="SPECIFICATIONS" HeaderText="SPECIFICATIONS" SortExpression="SPECIFICATIONS" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="IMAGE_NAME" HeaderText="IMAGE_NAME" SortExpression="IMAGE_NAME" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="QUANTITY" HeaderText="QUANTITY" SortExpression="QUANTITY" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="COMPLAIN_question" HeaderText="COMPLAIN_question" SortExpression="COMPLAIN_question" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="UPDATE_question" HeaderText="UPDATE_question" SortExpression="UPDATE_question" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Tracking_question" HeaderText="Tracking_question" SortExpression="Tracking_question" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="BEGIN_DATE" HeaderText="BEGIN_DATE" SortExpression="BEGIN_DATE" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="END_DATE" HeaderText="END_DATE" SortExpression="END_DATE" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="BILL_STATUS" HeaderText="BILL_STATUS" SortExpression="BILL_STATUS" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="CREATE_NAME" HeaderText="CREATE_NAME" SortExpression="CREATE_NAME" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="CREATE_DATE" HeaderText="CREATE_DATE" SortExpression="CREATE_DATE" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="UPDATE_NAME" HeaderText="UPDATE_NAME" SortExpression="UPDATE_NAME" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="UPDATE_DATE" HeaderText="UPDATE_DATE" SortExpression="UPDATE_DATE" ItemStyle-HorizontalAlign="Center"  /> 
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
