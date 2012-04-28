<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MenuControl.cs" Inherits="Steag.Web.Presentation.Security.Controls.MenuControl" %>
<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>

<telerik:RadMenu ID="mnuAdmin" runat="server" Width="100%">
    <Items>
        <telerik:RadMenuItem Text="SARF Management">
            <Items>
                <telerik:RadMenuItem Text="SARF Entry" NavigateUrl="" />
                <telerik:RadMenuItem Text="SARF Inquiry" NavigateUrl="" />
            </Items>
        </telerik:RadMenuItem>        
    </Items>
</telerik:RadMenu>

<div class="clear padding-top-10">
    <telerik:RadSiteMap ID="BreadCrumbSiteMap" runat="server" DataTextField="Text" DataNavigateUrlField="NavigateUrl" CssClass="breadcrumb">
        <DefaultLevelSettings ListLayout-RepeatDirection="Horizontal" SeparatorText="->" Layout="Flow" />
    </telerik:RadSiteMap>
</div>
