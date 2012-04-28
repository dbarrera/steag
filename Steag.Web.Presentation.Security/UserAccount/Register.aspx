﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Steag.Web.Presentation.Security.UserAccount.Register" 
MasterPageFile="~/Masters/AuthenticatedUser.Master" %>

<%@ Register assembly="Steag.Web.Presentation.Security" namespace="Steag.Web.Presentation.Security.Controls" tagprefix="cc1" %>

<asp:Content ID="contentTitle" runat="server" EnableViewState="false" ContentPlaceHolderID="title">
    STEAG Security Management System - Register User
</asp:Content>

<asp:Content ID="contentMain" runat="server" ContentPlaceHolderID="MainContent">

    <cc1:UserRoleDropDown ID="cboUserRole" runat="server">
    </cc1:UserRoleDropDown>

</asp:Content>



