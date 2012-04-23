<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SarfTest.aspx.cs" Inherits="Steag.Web.Presentation.Security.SarfTest" MasterPageFile="~/Masters/AuthenticatedUser.Master" %>
<%@ Register Src="Controls/SarfInputControl.ascx" TagName="SarfInput" TagPrefix="steag" %>

<asp:Content ID="SarfTitle" ContentPlaceHolderID="title" runat="server">
    STEAG Security Management System SARF
</asp:Content>

<asp:Content ID="ContentSarf" ContentPlaceHolderID="MainContent" runat="server">
    <steag:SarfInput ID="Sarf" runat="server" />
</asp:Content>
<asp:Content ID="Last" ContentPlaceHolderID="last" runat="server">

</asp:Content>