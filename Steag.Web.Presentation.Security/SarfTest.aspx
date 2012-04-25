<%@ Page Title="STEAG Security Management System SARF" Language="C#" AutoEventWireup="true" CodeBehind="SarfTest.aspx.cs" Inherits="Steag.Web.Presentation.Security.SarfTest" MasterPageFile="~/Masters/AuthenticatedUser.Master" %>

<%@ Register TagPrefix="telerik" Namespace="Telerik.Web.UI" Assembly="Telerik.Web.UI" %>
<%@ Register Src="Controls/RadScriptManagerDefault.ascx" TagName="RadScriptManagerDefault" TagPrefix="steag" %>
<%@ Register Src="Controls/SarfInputControl.ascx" TagName="SarfInput" TagPrefix="steag" %>

<asp:Content ID="SarfTitle" ContentPlaceHolderID="title" runat="server">
    
</asp:Content>
<asp:Content ID="HeadSarf" ContentPlaceHolderID="head" runat="server">
   
</asp:Content>
<asp:Content ID="ContentSarf" ContentPlaceHolderID="MainContent" runat="server">
    <steag:RadScriptManagerDefault ID="RadManager" runat="server" />
    <steag:SarfInput ID="Sarf" runat="server" />
    <telerik:RadButton ID="addSarfButton" runat="server" Text="Add">
    </telerik:RadButton> 
</asp:Content>
<asp:Content ID="Last" ContentPlaceHolderID="last" runat="server">

</asp:Content>