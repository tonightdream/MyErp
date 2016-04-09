<%@ Page Title="PUB_SALE" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="MyERP.Web.PUB_SALE.List" %>
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
                            
		<asp:BoundField DataField="CompanyCode" HeaderText="CompanyCode" SortExpression="CompanyCode" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="EmployeCode" HeaderText="EmployeCode" SortExpression="EmployeCode" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="EmployeeName" HeaderText="EmployeeName" SortExpression="EmployeeName" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="DepartmentCode" HeaderText="DepartmentCode" SortExpression="DepartmentCode" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="EmployeeType" HeaderText="EmployeeType" SortExpression="EmployeeType" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="IDCardNo" HeaderText="IDCardNo" SortExpression="IDCardNo" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="SociatyNo" HeaderText="SociatyNo" SortExpression="SociatyNo" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="SensusData" HeaderText="SensusData" SortExpression="SensusData" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Sex" HeaderText="Sex" SortExpression="Sex" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="BirthDay" HeaderText="BirthDay" SortExpression="BirthDay" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Degree" HeaderText="Degree" SortExpression="Degree" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="DegreeCard" HeaderText="DegreeCard" SortExpression="DegreeCard" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Health" HeaderText="Health" SortExpression="Health" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="HealthDate" HeaderText="HealthDate" SortExpression="HealthDate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Spinsterhood" HeaderText="Spinsterhood" SortExpression="Spinsterhood" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="SpinsterhoodDate" HeaderText="SpinsterhoodDate" SortExpression="SpinsterhoodDate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Idleness" HeaderText="Idleness" SortExpression="Idleness" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="IdlenessDate" HeaderText="IdlenessDate" SortExpression="IdlenessDate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Title" HeaderText="Title" SortExpression="Title" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ArrialDay" HeaderText="ArrialDay" SortExpression="ArrialDay" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="LeaveDay" HeaderText="LeaveDay" SortExpression="LeaveDay" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Phone" HeaderText="Phone" SortExpression="Phone" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Address" HeaderText="Address" SortExpression="Address" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Zip" HeaderText="Zip" SortExpression="Zip" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="AllowUsed" HeaderText="AllowUsed" SortExpression="AllowUsed" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="SociatyCode" HeaderText="SociatyCode" SortExpression="SociatyCode" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="SociatyDate" HeaderText="SociatyDate" SortExpression="SociatyDate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="SociatyPay" HeaderText="SociatyPay" SortExpression="SociatyPay" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="IndiSWBX" HeaderText="IndiSWBX" SortExpression="IndiSWBX" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="IndiSYBX" HeaderText="IndiSYBX" SortExpression="IndiSYBX" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="SociatyComp" HeaderText="SociatyComp" SortExpression="SociatyComp" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Remark" HeaderText="Remark" SortExpression="Remark" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="EmployeNo" HeaderText="EmployeNo" SortExpression="EmployeNo" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="WorkID" HeaderText="WorkID" SortExpression="WorkID" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Situations" HeaderText="Situations" SortExpression="Situations" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="HospitalPay" HeaderText="HospitalPay" SortExpression="HospitalPay" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="HospitalDate" HeaderText="HospitalDate" SortExpression="HospitalDate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="Contract" HeaderText="Contract" SortExpression="Contract" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="ContractDate" HeaderText="ContractDate" SortExpression="ContractDate" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="PayMounth" HeaderText="PayMounth" SortExpression="PayMounth" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="IsZB" HeaderText="IsZB" SortExpression="IsZB" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="IsBD" HeaderText="IsBD" SortExpression="IsBD" ItemStyle-HorizontalAlign="Center"  /> 
		<asp:BoundField DataField="LastEdit" HeaderText="LastEdit" SortExpression="LastEdit" ItemStyle-HorizontalAlign="Center"  /> 
                            
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
