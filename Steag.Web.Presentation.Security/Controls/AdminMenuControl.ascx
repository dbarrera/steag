<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MenuControl.cs" Inherits="Steag.Web.Presentation.Security.Controls.MenuControl" %>
<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>

<telerik:RadMenu ID="mnuAdmin" runat="server" Width="100%">
    <Items>
        <telerik:RadMenuItem Text="SARF Management" NavigateUrl="DefaultCS.aspx?Page=Products">
            <Items>
                <telerik:RadMenuItem Text="SARF Entry" NavigateUrl="DefaultCS.aspx?Page=Products" />
                <telerik:RadMenuItem Text="SARF Inquiry" NavigateUrl="DefaultCS.aspx?Page=Products" />
            </Items>
        </telerik:RadMenuItem>
        <telerik:RadMenuItem Text="EACS Management" NavigateUrl="DefaultCS.aspx?Page=Products">
            <Items>
                <telerik:RadMenuItem Text="EACS Inquiry" NavigateUrl="DefaultCS.aspx?Page=Products" />
            </Items>
        </telerik:RadMenuItem>
        <telerik:RadMenuItem Text="Visitors Management" NavigateUrl="DefaultCS.aspx?Page=Products">
            <Items>
                <telerik:RadMenuItem Text="Visitors Entry" NavigateUrl="DefaultCS.aspx?Page=Products" />
                <telerik:RadMenuItem Text="Visitors Inquiry" NavigateUrl="DefaultCS.aspx?Page=Products" />
            </Items>
        </telerik:RadMenuItem>
        <telerik:RadMenuItem Text="System Administration">
            <Items>
                <telerik:RadMenuItem Text="User Management" NavigateUrl="~/UserAccount/UserManagement.aspx" />
                <telerik:RadMenuItem Text="User Entry" NavigateUrl="~/UserAccount/Register.aspx" />
            </Items>
        </telerik:RadMenuItem>
    </Items>
</telerik:RadMenu>

<div class="clear padding-top-10">
    <telerik:RadSiteMap ID="BreadCrumbSiteMap" runat="server" DataTextField="Text" DataNavigateUrlField="NavigateUrl" CssClass="breadcrumb">
        <DefaultLevelSettings ListLayout-RepeatDirection="Horizontal" SeparatorText="->" Layout="Flow" />
    </telerik:RadSiteMap>
</div>
