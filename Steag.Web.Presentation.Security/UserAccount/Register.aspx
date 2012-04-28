<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Steag.Web.Presentation.Security.UserAccount.Register" 
MasterPageFile="~/Masters/AuthenticatedUser.Master" %>

<%@ Register assembly="Steag.Web.Presentation.Security" namespace="Steag.Web.Presentation.Security.Controls" tagprefix="cc1" %>
<%@ Register src="~/Controls/PasswordEntryControl.ascx" tagname="PasswordEntryControl" tagprefix="steag" %>

<asp:Content ID="contentTitle" runat="server" EnableViewState="false" ContentPlaceHolderID="title">
    STEAG Security Management System - Register User
</asp:Content>

<asp:Content ID="contentMain" runat="server" ContentPlaceHolderID="MainContent">
    <steag:PasswordEntryControl ID="txtPassword" runat="server" />
    <cc1:UserRoleDropDown ID="cboUserRole" runat="server">
    </cc1:UserRoleDropDown>

</asp:Content>



