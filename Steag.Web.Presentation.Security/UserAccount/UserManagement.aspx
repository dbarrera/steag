<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserManagement.aspx.cs" Inherits="Steag.Web.Presentation.Security.UserAccount.UserManagement" 
MasterPageFile="~/Masters/AuthenticatedUser.Master" %>

<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<%@ Register src="~/Controls/SearchControl.ascx" tagname="SearchControl" tagprefix="steag" %>

<asp:Content ID="headContent" runat="server" ContentPlaceHolderID="title">
    STEAG Security Management System - User Management
</asp:Content>

<asp:Content ID="mainContent" runat="server" ContentPlaceHolderID="MainContent">
    <span class="heading-5">System User Management</span>
    <hr class="line-rule" />

    <div class="margin-top-40 height-39">
        <div class="fleft width-60">
            <span class="label-font">Filter</span>
        </div>
        <div class="fleft">
            <telerik:RadComboBox runat="server" ID="cboFilter" 
                onselectedindexchanged="cboFilter_SelectedIndexChanged" AutoPostBack="true">
                <Items>
                    <telerik:RadComboBoxItem Value="Active" Text="Active" />
                    <telerik:RadComboBoxItem Value="InActive" Text="InActive" />
                    <telerik:RadComboBoxItem Value="All" Text="All" />
                </Items>
            </telerik:RadComboBox>
        </div>
        
    </div>
    
    <div class="clear">
        <steag:SearchControl runat="server" ID="searchControl">
        </steag:SearchControl>
    </div>

    <div class="clear height-39 fright">
        <a href="Register.aspx" class="user-register-link link">
            <span>Add User</span>
        </a>
    </div>

    <div class="clear">
        <telerik:RadGrid ID="gridUsers" runat="server" AutoGenerateColumns="False" 
            GridLines="Both"
            AllowSorting="True" onsortcommand="gridUsers_SortCommand">
            <AlternatingItemStyle BackColor="#FFFFCC"/>       
            <HeaderStyle Font-Bold="true" ForeColor="#133E82" BackColor="#B2C2CA" />         
            <MasterTableView>            
                <CommandItemSettings ExportToPdfText="Export to Pdf">
                </CommandItemSettings>
                <RowIndicatorColumn>
                    <HeaderStyle Width="20px"></HeaderStyle>
                </RowIndicatorColumn>
                <ExpandCollapseColumn>
                    <HeaderStyle Width="20px"></HeaderStyle>
                </ExpandCollapseColumn>
                <Columns>
                    <telerik:GridBoundColumn HeaderText="User ID" UniqueName="ID" DataField="ID" Visible="false" AllowSorting="false">
                    </telerik:GridBoundColumn>

                    <telerik:GridBoundColumn HeaderText="Username" UniqueName="Username" DataField="Username" AllowSorting="true">
                    </telerik:GridBoundColumn>
                
                    <telerik:GridBoundColumn HeaderText="Last Name" UniqueName="LastName" DataField="LastName" AllowSorting="true">
                    </telerik:GridBoundColumn>
                
                    <telerik:GridBoundColumn HeaderText="First Name" UniqueName="FirstName" DataField="FirstName" AllowSorting="true">
                    </telerik:GridBoundColumn>

                    <telerik:GridTemplateColumn HeaderText="Role" UniqueName="UserRole">
                        <ItemTemplate>
                            <%# GetUserRoleCode((long)DataBinder.Eval(Container.DataItem, "UserRoleID")) %>
                        </ItemTemplate>
                    </telerik:GridTemplateColumn>
                
                    <telerik:GridBoundColumn HeaderText="Email Address" UniqueName="EmailAddress" DataField="EmailAddress" AllowSorting="true">                
                    </telerik:GridBoundColumn>             
                    
                    <telerik:GridCheckBoxColumn HeaderText="Active" UniqueName="IsActive" DataField="IsActive" AllowSorting="true">
                        <ItemStyle HorizontalAlign="Justify" />
                    </telerik:GridCheckBoxColumn>               
                
                    <telerik:GridTemplateColumn HeaderText="Edit">                    
                        <ItemTemplate>
                            <a href="EditUser.aspx?id=<%# DataBinder.Eval(Container.DataItem, "ID") %>" class="grid-edit-user-link">
                                <span>Edit</span>
                            </a>                        
                        </ItemTemplate>
                    </telerik:GridTemplateColumn>
                </Columns>
            </MasterTableView>
            <HeaderStyle BackColor="#B2C2CA"/>
            <ItemStyle BorderColor="#999999" BorderWidth="1px" />
            <HeaderContextMenu EnableImageSprites="True" CssClass="GridContextMenu GridContextMenu_Default">
            </HeaderContextMenu>
        </telerik:RadGrid>
    </div>
</asp:Content>


